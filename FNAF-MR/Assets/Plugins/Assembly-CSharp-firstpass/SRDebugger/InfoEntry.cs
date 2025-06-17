using System;
using SRF;

namespace SRDebugger
{
	public sealed class InfoEntry
	{
		private Func<object> _valueGetter;

		public string Title { get; set; }

		public object Value
		{
			get
			{
				try
				{
					return _valueGetter();
				}
				catch (Exception ex)
				{
					return "Error ({0})".Fmt(ex.GetType().Name);
				}
			}
		}

		public bool IsPrivate { get; private set; }

		public static InfoEntry Create(string name, Func<object> getter, bool isPrivate = false)
		{
			return new InfoEntry
			{
				Title = name,
				_valueGetter = getter,
				IsPrivate = isPrivate
			};
		}

		public static InfoEntry Create(string name, object value, bool isPrivate = false)
		{
			return new InfoEntry
			{
				Title = name,
				_valueGetter = () => value,
				IsPrivate = isPrivate
			};
		}
	}
}
