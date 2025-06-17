using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SRF.Components;
using SRF.Helpers;
using UnityEngine;

namespace SRF.Service
{
	[AddComponentMenu("SRF/Service/Service Manager")]
	public class SRServiceManager : SRAutoSingleton<SRServiceManager>
	{
		[Serializable]
		private class Service
		{
			public object Object;

			public Type Type;
		}

		[Serializable]
		private class ServiceStub
		{
			public Func<object> Constructor;

			public Type InterfaceType;

			public Func<Type> Selector;

			public Type Type;

			public override string ToString()
			{
				string text = InterfaceType.Name + " (";
				if (Type != null)
				{
					text = text + "Type: " + Type;
				}
				else if (Selector != null)
				{
					text = text + "Selector: " + Selector;
				}
				else if (Constructor != null)
				{
					text = text + "Constructor: " + Constructor;
				}
				return text + ")";
			}
		}

		public const bool EnableLogging = false;

		public static int LoadingCount;

		private readonly SRList<Service> _services = new SRList<Service>();

		private List<ServiceStub> _serviceStubs;

		private static bool _hasQuit;

		public static bool IsLoading => LoadingCount > 0;

		public static T GetService<T>() where T : class
		{
			T val = GetServiceInternal(typeof(T)) as T;
			if (val == null && !_hasQuit)
			{
				Debug.LogWarning("Service {0} not found. (HasQuit: {1})".Fmt(typeof(T).Name, _hasQuit));
			}
			return val;
		}

		public static object GetService(Type t)
		{
			object serviceInternal = GetServiceInternal(t);
			if (serviceInternal == null && !_hasQuit)
			{
				Debug.LogWarning("Service {0} not found. (HasQuit: {1})".Fmt(t.Name, _hasQuit));
			}
			return serviceInternal;
		}

		private static object GetServiceInternal(Type t)
		{
			if (_hasQuit || !Application.isPlaying)
			{
				return null;
			}
			SRList<Service> services = SRAutoSingleton<SRServiceManager>.Instance._services;
			for (int i = 0; i < services.Count; i++)
			{
				Service service = services[i];
				if (t.IsAssignableFrom(service.Type))
				{
					if (service.Object == null)
					{
						UnRegisterService(t);
						break;
					}
					return service.Object;
				}
			}
			return SRAutoSingleton<SRServiceManager>.Instance.AutoCreateService(t);
		}

		public static bool HasService<T>() where T : class
		{
			return HasService(typeof(T));
		}

		public static bool HasService(Type t)
		{
			if (_hasQuit || !Application.isPlaying)
			{
				return false;
			}
			SRList<Service> services = SRAutoSingleton<SRServiceManager>.Instance._services;
			for (int i = 0; i < services.Count; i++)
			{
				Service service = services[i];
				if (t.IsAssignableFrom(service.Type))
				{
					return service.Object != null;
				}
			}
			return false;
		}

		public static void RegisterService<T>(object service) where T : class
		{
			RegisterService(typeof(T), service);
		}

		private static void RegisterService(Type t, object service)
		{
			if (_hasQuit)
			{
				return;
			}
			if (HasService(t))
			{
				if (GetServiceInternal(t) == service)
				{
					return;
				}
				throw new Exception("Service already registered for type " + t.Name);
			}
			UnRegisterService(t);
			if (!t.IsInstanceOfType(service))
			{
				throw new ArgumentException("service {0} must be assignable from type {1}".Fmt(service.GetType(), t));
			}
			SRAutoSingleton<SRServiceManager>.Instance._services.Add(new Service
			{
				Object = service,
				Type = t
			});
		}

		public static void UnRegisterService<T>() where T : class
		{
			UnRegisterService(typeof(T));
		}

		private static void UnRegisterService(Type t)
		{
			if (_hasQuit || !SRAutoSingleton<SRServiceManager>.HasInstance || !HasService(t))
			{
				return;
			}
			SRList<Service> services = SRAutoSingleton<SRServiceManager>.Instance._services;
			for (int num = services.Count - 1; num >= 0; num--)
			{
				if (services[num].Type == t)
				{
					services.RemoveAt(num);
				}
			}
		}

		protected override void Awake()
		{
			_hasQuit = false;
			base.Awake();
			UnityEngine.Object.DontDestroyOnLoad(base.CachedGameObject);
			base.CachedGameObject.hideFlags = HideFlags.NotEditable;
		}

		protected void UpdateStubs()
		{
			if (_serviceStubs != null)
			{
				return;
			}
			_serviceStubs = new List<ServiceStub>();
			List<Type> list = new List<Type>();
			Assembly assembly = typeof(SRServiceManager).Assembly;
			try
			{
				list.AddRange(assembly.GetExportedTypes());
			}
			catch (Exception exception)
			{
				Debug.LogError("[SRServiceManager] Error loading assembly {0}".Fmt(assembly.FullName), this);
				Debug.LogException(exception);
			}
			foreach (Type item in list)
			{
				ScanType(item);
			}
		}

		protected object AutoCreateService(Type t)
		{
			UpdateStubs();
			foreach (ServiceStub serviceStub in _serviceStubs)
			{
				if (serviceStub.InterfaceType != t)
				{
					continue;
				}
				object obj = null;
				if (serviceStub.Constructor != null)
				{
					obj = serviceStub.Constructor();
				}
				else
				{
					Type type = serviceStub.Type;
					if (type == null)
					{
						type = serviceStub.Selector();
					}
					obj = DefaultServiceConstructor(t, type);
				}
				if (!HasService(t))
				{
					RegisterService(t, obj);
				}
				return obj;
			}
			return null;
		}

		protected void OnApplicationQuit()
		{
			_hasQuit = true;
		}

		private static object DefaultServiceConstructor(Type serviceIntType, Type implType)
		{
			if (typeof(MonoBehaviour).IsAssignableFrom(implType))
			{
				return new GameObject("_S_" + serviceIntType.Name).AddComponent(implType);
			}
			if (typeof(ScriptableObject).IsAssignableFrom(implType))
			{
				return ScriptableObject.CreateInstance(implType);
			}
			return Activator.CreateInstance(implType);
		}

		private void ScanType(Type type)
		{
			ServiceAttribute attribute = SRReflection.GetAttribute<ServiceAttribute>(type);
			if (attribute != null)
			{
				_serviceStubs.Add(new ServiceStub
				{
					Type = type,
					InterfaceType = attribute.ServiceType
				});
			}
			ScanTypeForConstructors(type, _serviceStubs);
			ScanTypeForSelectors(type, _serviceStubs);
		}

		private static void ScanTypeForSelectors(Type t, List<ServiceStub> stubs)
		{
			MethodInfo[] staticMethods = GetStaticMethods(t);
			foreach (MethodInfo methodInfo in staticMethods)
			{
				ServiceSelectorAttribute attrib = SRReflection.GetAttribute<ServiceSelectorAttribute>(methodInfo);
				if (attrib == null)
				{
					continue;
				}
				if (methodInfo.ReturnType != typeof(Type))
				{
					Debug.LogError("ServiceSelector must have return type of Type ({0}.{1}())".Fmt(t.Name, methodInfo.Name));
					continue;
				}
				if (methodInfo.GetParameters().Length != 0)
				{
					Debug.LogError("ServiceSelector must have no parameters ({0}.{1}())".Fmt(t.Name, methodInfo.Name));
					continue;
				}
				ServiceStub serviceStub = stubs.FirstOrDefault((ServiceStub p) => p.InterfaceType == attrib.ServiceType);
				if (serviceStub == null)
				{
					serviceStub = new ServiceStub
					{
						InterfaceType = attrib.ServiceType
					};
					stubs.Add(serviceStub);
				}
				serviceStub.Selector = (Func<Type>)Delegate.CreateDelegate(typeof(Func<Type>), methodInfo);
			}
		}

		private static void ScanTypeForConstructors(Type t, List<ServiceStub> stubs)
		{
			MethodInfo[] staticMethods = GetStaticMethods(t);
			foreach (MethodInfo methodInfo in staticMethods)
			{
				ServiceConstructorAttribute attrib = SRReflection.GetAttribute<ServiceConstructorAttribute>(methodInfo);
				if (attrib == null)
				{
					continue;
				}
				if (methodInfo.ReturnType != attrib.ServiceType)
				{
					Debug.LogError("ServiceConstructor must have return type of {2} ({0}.{1}())".Fmt(t.Name, methodInfo.Name, attrib.ServiceType));
					continue;
				}
				if (methodInfo.GetParameters().Length != 0)
				{
					Debug.LogError("ServiceConstructor must have no parameters ({0}.{1}())".Fmt(t.Name, methodInfo.Name));
					continue;
				}
				ServiceStub serviceStub = stubs.FirstOrDefault((ServiceStub p) => p.InterfaceType == attrib.ServiceType);
				if (serviceStub == null)
				{
					serviceStub = new ServiceStub
					{
						InterfaceType = attrib.ServiceType
					};
					stubs.Add(serviceStub);
				}
				MethodInfo m = methodInfo;
				serviceStub.Constructor = () => m.Invoke(null, null);
			}
		}

		private static MethodInfo[] GetStaticMethods(Type t)
		{
			return t.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		}
	}
}
