using System.Reflection;
using UnityEngine;

namespace TMPro
{
	public class TMP_InputFieldWithBugfix : TMP_InputField
	{
		protected override void Append(char input)
		{
			if (base.readOnly || TouchScreenKeyboard.isSupported)
			{
				return;
			}
			if (base.onValidateInput != null)
			{
				input = base.onValidateInput(base.text, base.stringPositionInternal, input);
			}
			else
			{
				if (base.characterValidation == CharacterValidation.CustomValidator)
				{
					input = Validate(base.text, base.stringPositionInternal, input);
					if (input != 0)
					{
						typeof(TMP_InputField).GetMethod("SendOnValueChanged", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(this, null);
						UpdateLabel();
					}
					return;
				}
				if (base.characterValidation != CharacterValidation.None)
				{
					input = Validate(base.text, base.stringPositionInternal, input);
				}
			}
			if (input != 0)
			{
				typeof(TMP_InputField).GetMethod("Insert", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(this, new object[1] { input });
			}
		}
	}
}
