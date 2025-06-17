using System;
using System.Linq;
using System.Reflection;

namespace SRF.Helpers
{
	public class PropertyReference
	{
		private readonly PropertyInfo _property;

		private readonly object _target;

		public string PropertyName => _property.Name;

		public Type PropertyType => _property.PropertyType;

		public bool CanRead => _property.GetGetMethod() != null;

		public bool CanWrite => _property.GetSetMethod() != null;

		public PropertyReference(object target, PropertyInfo property)
		{
			SRDebugUtil.AssertNotNull(target);
			_target = target;
			_property = property;
		}

		public object GetValue()
		{
			if (_property.CanRead)
			{
				return SRReflection.GetPropertyValue(_target, _property);
			}
			return null;
		}

		public void SetValue(object value)
		{
			if (_property.CanWrite)
			{
				SRReflection.SetPropertyValue(_target, _property, value);
				return;
			}
			throw new InvalidOperationException("Can not write to property");
		}

		public T GetAttribute<T>() where T : Attribute
		{
			return _property.GetCustomAttributes(typeof(T), inherit: true).FirstOrDefault() as T;
		}
	}
}
