using System;
using SRF;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls.Data
{
	public class StringControl : DataBoundControl
	{
		[RequiredField]
		public InputField InputField;

		[RequiredField]
		public Text Title;

		protected override void Start()
		{
			base.Start();
			InputField.onValueChanged.AddListener(OnValueChanged);
		}

		private void OnValueChanged(string newValue)
		{
			UpdateValue(newValue);
		}

		protected override void OnBind(string propertyName, Type t)
		{
			base.OnBind(propertyName, t);
			Title.text = propertyName;
			InputField.text = "";
			InputField.interactable = !base.IsReadOnly;
		}

		protected override void OnValueUpdated(object newValue)
		{
			string text = ((newValue == null) ? "" : ((string)newValue));
			InputField.text = text;
		}

		public override bool CanBind(Type type, bool isReadOnly)
		{
			if (type == typeof(string))
			{
				return !isReadOnly;
			}
			return false;
		}
	}
}
