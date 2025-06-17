using System;
using System.Collections.Generic;
using System.Reflection;
using SRF.Helpers;
using SRF.Service;
using UnityEngine;

namespace SRF
{
	public abstract class SRMonoBehaviourEx : SRMonoBehaviour
	{
		private struct FieldInfo
		{
			public bool AutoCreate;

			public bool AutoSet;

			public System.Reflection.FieldInfo Field;

			public bool Import;

			public Type ImportType;
		}

		private static Dictionary<Type, IList<FieldInfo>> _checkedFields;

		private static void CheckFields(SRMonoBehaviourEx instance, bool justSet = false)
		{
			if (_checkedFields == null)
			{
				_checkedFields = new Dictionary<Type, IList<FieldInfo>>();
			}
			Type type = instance.GetType();
			if (!_checkedFields.TryGetValue(instance.GetType(), out var value))
			{
				value = ScanType(type);
				_checkedFields.Add(type, value);
			}
			PopulateObject(value, instance, justSet);
		}

		private static void PopulateObject(IList<FieldInfo> cache, SRMonoBehaviourEx instance, bool justSet)
		{
			for (int i = 0; i < cache.Count; i++)
			{
				FieldInfo fieldInfo = cache[i];
				if (!EqualityComparer<object>.Default.Equals(fieldInfo.Field.GetValue(instance), null))
				{
					continue;
				}
				if (fieldInfo.Import)
				{
					Type type = fieldInfo.ImportType ?? fieldInfo.Field.FieldType;
					object service = SRServiceManager.GetService(type);
					if (service == null)
					{
						Debug.LogWarning("Field {0} import failed (Type {1})".Fmt(fieldInfo.Field.Name, type));
					}
					else
					{
						fieldInfo.Field.SetValue(instance, service);
					}
					continue;
				}
				if (fieldInfo.AutoSet)
				{
					Component component = instance.GetComponent(fieldInfo.Field.FieldType);
					if (!EqualityComparer<object>.Default.Equals(component, null))
					{
						fieldInfo.Field.SetValue(instance, component);
						continue;
					}
				}
				if (justSet)
				{
					continue;
				}
				if (fieldInfo.AutoCreate)
				{
					Component value = instance.CachedGameObject.AddComponent(fieldInfo.Field.FieldType);
					fieldInfo.Field.SetValue(instance, value);
				}
				throw new UnassignedReferenceException("Field {0} is unassigned, but marked with RequiredFieldAttribute".Fmt(fieldInfo.Field.Name));
			}
		}

		private static List<FieldInfo> ScanType(Type t)
		{
			List<FieldInfo> list = new List<FieldInfo>();
			RequiredFieldAttribute attribute = SRReflection.GetAttribute<RequiredFieldAttribute>(t);
			System.Reflection.FieldInfo[] fields = t.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			foreach (System.Reflection.FieldInfo fieldInfo in fields)
			{
				RequiredFieldAttribute attribute2 = SRReflection.GetAttribute<RequiredFieldAttribute>(fieldInfo);
				ImportAttribute attribute3 = SRReflection.GetAttribute<ImportAttribute>(fieldInfo);
				if (attribute != null || attribute2 != null || attribute3 != null)
				{
					FieldInfo item = new FieldInfo
					{
						Field = fieldInfo
					};
					if (attribute3 != null)
					{
						item.Import = true;
						item.ImportType = attribute3.Service;
					}
					else if (attribute2 != null)
					{
						item.AutoSet = attribute2.AutoSearch;
						item.AutoCreate = attribute2.AutoCreate;
					}
					else
					{
						item.AutoSet = attribute.AutoSearch;
						item.AutoCreate = attribute.AutoCreate;
					}
					list.Add(item);
				}
			}
			return list;
		}

		protected virtual void Awake()
		{
			CheckFields(this);
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		protected virtual void OnDestroy()
		{
		}
	}
}
