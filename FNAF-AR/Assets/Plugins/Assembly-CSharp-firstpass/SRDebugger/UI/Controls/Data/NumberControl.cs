using System;
using System.Collections.Generic;
using SRF;
using SRF.UI;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls.Data
{
	public class NumberControl : DataBoundControl
	{
		public struct ValueRange
		{
			public double MaxValue;

			public double MinValue;
		}

		private static readonly Type[] IntegerTypes = new Type[6]
		{
			typeof(int),
			typeof(short),
			typeof(byte),
			typeof(sbyte),
			typeof(uint),
			typeof(ushort)
		};

		private static readonly Type[] DecimalTypes = new Type[2]
		{
			typeof(float),
			typeof(double)
		};

		public static readonly Dictionary<Type, ValueRange> ValueRanges = new Dictionary<Type, ValueRange>
		{
			{
				typeof(int),
				new ValueRange
				{
					MaxValue = 2147483647.0,
					MinValue = -2147483648.0
				}
			},
			{
				typeof(short),
				new ValueRange
				{
					MaxValue = 32767.0,
					MinValue = -32768.0
				}
			},
			{
				typeof(byte),
				new ValueRange
				{
					MaxValue = 255.0,
					MinValue = 0.0
				}
			},
			{
				typeof(sbyte),
				new ValueRange
				{
					MaxValue = 127.0,
					MinValue = -128.0
				}
			},
			{
				typeof(uint),
				new ValueRange
				{
					MaxValue = 4294967295.0,
					MinValue = 0.0
				}
			},
			{
				typeof(ushort),
				new ValueRange
				{
					MaxValue = 65535.0,
					MinValue = 0.0
				}
			},
			{
				typeof(float),
				new ValueRange
				{
					MaxValue = 3.4028234663852886E+38,
					MinValue = -3.4028234663852886E+38
				}
			},
			{
				typeof(double),
				new ValueRange
				{
					MaxValue = double.MaxValue,
					MinValue = double.MinValue
				}
			}
		};

		private string _lastValue;

		private Type _type;

		public GameObject[] DisableOnReadOnly;

		public SRNumberButton DownNumberButton;

		[RequiredField]
		public SRNumberSpinner NumberSpinner;

		[RequiredField]
		public Text Title;

		public SRNumberButton UpNumberButton;

		protected override void Start()
		{
			base.Start();
			NumberSpinner.onEndEdit.AddListener(OnValueChanged);
		}

		private void OnValueChanged(string newValue)
		{
			try
			{
				object newValue2 = Convert.ChangeType(newValue, _type);
				UpdateValue(newValue2);
			}
			catch (Exception)
			{
				NumberSpinner.text = _lastValue;
			}
		}

		protected override void OnBind(string propertyName, Type t)
		{
			base.OnBind(propertyName, t);
			Title.text = propertyName;
			if (IsIntegerType(t))
			{
				NumberSpinner.contentType = InputField.ContentType.IntegerNumber;
			}
			else
			{
				if (!IsDecimalType(t))
				{
					throw new ArgumentException("Type must be one of expected types", "t");
				}
				NumberSpinner.contentType = InputField.ContentType.DecimalNumber;
			}
			SROptions.NumberRangeAttribute attribute = base.Property.GetAttribute<SROptions.NumberRangeAttribute>();
			NumberSpinner.MaxValue = GetMaxValue(t);
			NumberSpinner.MinValue = GetMinValue(t);
			if (attribute != null)
			{
				NumberSpinner.MaxValue = Math.Min(attribute.Max, NumberSpinner.MaxValue);
				NumberSpinner.MinValue = Math.Max(attribute.Min, NumberSpinner.MinValue);
			}
			SROptions.IncrementAttribute attribute2 = base.Property.GetAttribute<SROptions.IncrementAttribute>();
			if (attribute2 != null)
			{
				if (UpNumberButton != null)
				{
					UpNumberButton.Amount = attribute2.Increment;
				}
				if (DownNumberButton != null)
				{
					DownNumberButton.Amount = 0.0 - attribute2.Increment;
				}
			}
			_type = t;
			NumberSpinner.interactable = !base.IsReadOnly;
			if (DisableOnReadOnly != null)
			{
				GameObject[] disableOnReadOnly = DisableOnReadOnly;
				for (int i = 0; i < disableOnReadOnly.Length; i++)
				{
					disableOnReadOnly[i].SetActive(!base.IsReadOnly);
				}
			}
		}

		protected override void OnValueUpdated(object newValue)
		{
			string text = Convert.ToDecimal(newValue).ToString();
			if (text != _lastValue)
			{
				NumberSpinner.text = text;
			}
			_lastValue = text;
		}

		public override bool CanBind(Type type, bool isReadOnly)
		{
			if (!IsDecimalType(type))
			{
				return IsIntegerType(type);
			}
			return true;
		}

		protected static bool IsIntegerType(Type t)
		{
			for (int i = 0; i < IntegerTypes.Length; i++)
			{
				if (IntegerTypes[i] == t)
				{
					return true;
				}
			}
			return false;
		}

		protected static bool IsDecimalType(Type t)
		{
			for (int i = 0; i < DecimalTypes.Length; i++)
			{
				if (DecimalTypes[i] == t)
				{
					return true;
				}
			}
			return false;
		}

		protected double GetMaxValue(Type t)
		{
			if (ValueRanges.TryGetValue(t, out var value))
			{
				return value.MaxValue;
			}
			Debug.LogWarning("[NumberControl] No MaxValue stored for type {0}".Fmt(t));
			return double.MaxValue;
		}

		protected double GetMinValue(Type t)
		{
			if (ValueRanges.TryGetValue(t, out var value))
			{
				return value.MinValue;
			}
			Debug.LogWarning("[NumberControl] No MinValue stored for type {0}".Fmt(t));
			return double.MinValue;
		}
	}
}
