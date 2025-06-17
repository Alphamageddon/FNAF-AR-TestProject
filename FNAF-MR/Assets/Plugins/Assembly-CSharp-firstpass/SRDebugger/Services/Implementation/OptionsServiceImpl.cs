using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using SRDebugger.Internal;
using SRF.Service;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IOptionsService))]
	public class OptionsServiceImpl : IOptionsService
	{
		private readonly Dictionary<object, ICollection<OptionDefinition>> _optionContainerLookup = new Dictionary<object, ICollection<OptionDefinition>>();

		private readonly List<OptionDefinition> _options = new List<OptionDefinition>();

		private readonly IList<OptionDefinition> _optionsReadonly;

		public ICollection<OptionDefinition> Options => _optionsReadonly;

		public event EventHandler OptionsUpdated;

		public event EventHandler<PropertyChangedEventArgs> OptionsValueUpdated;

		public OptionsServiceImpl()
		{
			_optionsReadonly = new ReadOnlyCollection<OptionDefinition>(_options);
			Scan(SROptions.Current);
			SROptions.Current.PropertyChanged += OnSROptionsPropertyChanged;
		}

		public void Scan(object obj)
		{
			AddContainer(obj);
		}

		public void AddContainer(object obj)
		{
			if (_optionContainerLookup.ContainsKey(obj))
			{
				throw new Exception("An object should only be added once.");
			}
			ICollection<OptionDefinition> collection = SRDebuggerUtil.ScanForOptions(obj);
			_optionContainerLookup.Add(obj, collection);
			if (collection.Count > 0)
			{
				_options.AddRange(collection);
				OnOptionsUpdated();
				if (obj is INotifyPropertyChanged notifyPropertyChanged)
				{
					notifyPropertyChanged.PropertyChanged += OnPropertyChanged;
				}
			}
		}

		public void RemoveContainer(object obj)
		{
			if (!_optionContainerLookup.ContainsKey(obj))
			{
				return;
			}
			ICollection<OptionDefinition> collection = _optionContainerLookup[obj];
			_optionContainerLookup.Remove(obj);
			foreach (OptionDefinition item in collection)
			{
				_options.Remove(item);
			}
			if (obj is INotifyPropertyChanged notifyPropertyChanged)
			{
				notifyPropertyChanged.PropertyChanged -= OnPropertyChanged;
			}
			OnOptionsUpdated();
		}

		private void OnPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
		{
			if (this.OptionsValueUpdated != null)
			{
				this.OptionsValueUpdated(this, propertyChangedEventArgs);
			}
		}

		private void OnSROptionsPropertyChanged(object sender, string propertyName)
		{
			OnPropertyChanged(sender, new PropertyChangedEventArgs(propertyName));
		}

		private void OnOptionsUpdated()
		{
			if (this.OptionsUpdated != null)
			{
				this.OptionsUpdated(this, EventArgs.Empty);
			}
		}
	}
}
