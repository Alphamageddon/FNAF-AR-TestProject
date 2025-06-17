using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using SRF.Helpers;
using UnityEngine;
using UnityEngine.EventSystems;

namespace SRDebugger.Internal
{
	public static class SRDebuggerUtil
	{
		public static bool IsMobilePlatform
		{
			get
			{
				if (Application.isMobilePlatform)
				{
					return true;
				}
				RuntimePlatform platform = Application.platform;
				if ((uint)(platform - 18) <= 2u)
				{
					return true;
				}
				return false;
			}
		}

		public static bool EnsureEventSystemExists()
		{
			if (!Settings.Instance.EnableEventSystemGeneration)
			{
				return false;
			}
			if (EventSystem.current != null)
			{
				return false;
			}
			EventSystem eventSystem = Object.FindObjectOfType<EventSystem>();
			if (eventSystem != null && eventSystem.gameObject.activeSelf && eventSystem.enabled)
			{
				return false;
			}
			Debug.LogWarning("[SRDebugger] No EventSystem found in scene - creating a default one.");
			CreateDefaultEventSystem();
			return true;
		}

		public static void CreateDefaultEventSystem()
		{
			GameObject gameObject = new GameObject("EventSystem");
			gameObject.AddComponent<EventSystem>();
			gameObject.AddComponent<StandaloneInputModule>();
		}

		public static ICollection<OptionDefinition> ScanForOptions(object obj)
		{
			List<OptionDefinition> list = new List<OptionDefinition>();
			MemberInfo[] members = obj.GetType().GetMembers(BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty);
			foreach (MemberInfo memberInfo in members)
			{
				CategoryAttribute attribute = SRReflection.GetAttribute<CategoryAttribute>(memberInfo);
				string category = ((attribute == null) ? "Default" : attribute.Category);
				int sortPriority = SRReflection.GetAttribute<SROptions.SortAttribute>(memberInfo)?.SortPriority ?? 0;
				SROptions.DisplayNameAttribute attribute2 = SRReflection.GetAttribute<SROptions.DisplayNameAttribute>(memberInfo);
				string name = ((attribute2 == null) ? memberInfo.Name : attribute2.Name);
				if (memberInfo is PropertyInfo)
				{
					PropertyInfo propertyInfo = memberInfo as PropertyInfo;
					if (!(propertyInfo.GetGetMethod() == null) && (propertyInfo.GetGetMethod().Attributes & MethodAttributes.Static) == 0)
					{
						list.Add(new OptionDefinition(name, category, sortPriority, new PropertyReference(obj, propertyInfo)));
					}
				}
				else if (memberInfo is MethodInfo)
				{
					MethodInfo methodInfo = memberInfo as MethodInfo;
					if (!methodInfo.IsStatic && !(methodInfo.ReturnType != typeof(void)) && methodInfo.GetParameters().Length == 0)
					{
						list.Add(new OptionDefinition(name, category, sortPriority, new MethodReference(obj, methodInfo)));
					}
				}
			}
			return list;
		}

		public static string GetNumberString(int value, int max, string exceedsMaxString)
		{
			if (value >= max)
			{
				return exceedsMaxString;
			}
			return value.ToString();
		}

		public static void ConfigureCanvas(Canvas canvas)
		{
			if (Settings.Instance.UseDebugCamera)
			{
				canvas.worldCamera = Service.DebugCamera.Camera;
				canvas.renderMode = RenderMode.ScreenSpaceCamera;
			}
		}
	}
}
