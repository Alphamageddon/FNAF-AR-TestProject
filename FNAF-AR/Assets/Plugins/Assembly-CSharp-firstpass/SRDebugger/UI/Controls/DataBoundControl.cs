using System;
using SRF.Helpers;
using UnityEngine;

namespace SRDebugger.UI.Controls
{
	public abstract class DataBoundControl : OptionsControlBase
	{
		private bool _hasStarted;

		private bool _isReadOnly;

		private object _prevValue;

		private PropertyReference _prop;

		public PropertyReference Property => _prop;

		public bool IsReadOnly => _isReadOnly;

		public string PropertyName { get; private set; }

		public void Bind(string propertyName, PropertyReference prop)
		{
			PropertyName = propertyName;
			_prop = prop;
			_isReadOnly = !prop.CanWrite;
			OnBind(propertyName, prop.PropertyType);
			Refresh();
		}

		protected void UpdateValue(object newValue)
		{
			if (newValue != _prevValue && !IsReadOnly)
			{
				_prop.SetValue(newValue);
				_prevValue = newValue;
			}
		}

		public override void Refresh()
		{
			if (_prop == null)
			{
				return;
			}
			object value = _prop.GetValue();
			if (value != _prevValue)
			{
				try
				{
					OnValueUpdated(value);
				}
				catch (Exception exception)
				{
					Debug.LogError("[SROptions] Error refreshing binding.");
					Debug.LogException(exception);
				}
			}
			_prevValue = value;
		}

		protected virtual void OnBind(string propertyName, Type t)
		{
		}

		protected abstract void OnValueUpdated(object newValue);

		public abstract bool CanBind(Type type, bool isReadOnly);

		protected override void Start()
		{
			base.Start();
			Refresh();
			_hasStarted = true;
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			if (_hasStarted)
			{
				Refresh();
			}
		}
	}
}
