using System;
using SRF;
using SRF.UI;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls.Data
{
	public class EnumControl : DataBoundControl
	{
		private object _lastValue;

		private string[] _names;

		private Array _values;

		[RequiredField]
		public LayoutElement ContentLayoutElement;

		public GameObject[] DisableOnReadOnly;

		[RequiredField]
		public SRSpinner Spinner;

		[RequiredField]
		public Text Title;

		[RequiredField]
		public Text Value;

		protected override void Start()
		{
			base.Start();
		}

		protected override void OnBind(string propertyName, Type t)
		{
			base.OnBind(propertyName, t);
			Title.text = propertyName;
			Spinner.interactable = !base.IsReadOnly;
			if (DisableOnReadOnly != null)
			{
				GameObject[] disableOnReadOnly = DisableOnReadOnly;
				for (int i = 0; i < disableOnReadOnly.Length; i++)
				{
					disableOnReadOnly[i].SetActive(!base.IsReadOnly);
				}
			}
			_names = Enum.GetNames(t);
			_values = Enum.GetValues(t);
			string text = "";
			for (int j = 0; j < _names.Length; j++)
			{
				if (_names[j].Length > text.Length)
				{
					text = _names[j];
				}
			}
			if (_names.Length != 0)
			{
				float preferredWidth = Value.cachedTextGeneratorForLayout.GetPreferredWidth(text, Value.GetGenerationSettings(new Vector2(float.MaxValue, Value.preferredHeight)));
				ContentLayoutElement.preferredWidth = preferredWidth;
			}
		}

		protected override void OnValueUpdated(object newValue)
		{
			_lastValue = newValue;
			Value.text = newValue.ToString();
		}

		public override bool CanBind(Type type, bool isReadOnly)
		{
			return type.IsEnum;
		}

		private void SetIndex(int i)
		{
			UpdateValue(_values.GetValue(i));
			Refresh();
		}

		public void GoToNext()
		{
			int num = Array.IndexOf(_values, _lastValue);
			SetIndex(SRMath.Wrap(_values.Length, num + 1));
		}

		public void GoToPrevious()
		{
			int num = Array.IndexOf(_values, _lastValue);
			SetIndex(SRMath.Wrap(_values.Length, num - 1));
		}
	}
}
