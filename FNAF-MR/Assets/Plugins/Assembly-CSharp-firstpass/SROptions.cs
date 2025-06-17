using System;

public class SROptions
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class NumberRangeAttribute : Attribute
	{
		public readonly double Max;

		public readonly double Min;

		public NumberRangeAttribute(double min, double max)
		{
			Min = min;
			Max = max;
		}
	}

	[AttributeUsage(AttributeTargets.Property)]
	public sealed class IncrementAttribute : Attribute
	{
		public readonly double Increment;

		public IncrementAttribute(double increment)
		{
			Increment = increment;
		}
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class SortAttribute : Attribute
	{
		public readonly int SortPriority;

		public SortAttribute(int priority)
		{
			SortPriority = priority;
		}
	}

	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class DisplayNameAttribute : Attribute
	{
		public readonly string Name;

		public DisplayNameAttribute(string name)
		{
			Name = name;
		}
	}

	private static readonly SROptions _current = new SROptions();

	public static SROptions Current => _current;

	public event SROptionsPropertyChanged PropertyChanged;

	public void OnPropertyChanged(string propertyName)
	{
		if (this.PropertyChanged != null)
		{
			this.PropertyChanged(this, propertyName);
		}
	}
}
