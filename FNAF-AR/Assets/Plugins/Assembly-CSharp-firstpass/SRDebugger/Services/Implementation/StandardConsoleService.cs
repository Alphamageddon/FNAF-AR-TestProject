using SRF.Service;
using UnityEngine;

namespace SRDebugger.Services.Implementation
{
	[Service(typeof(IConsoleService))]
	public class StandardConsoleService : IConsoleService
	{
		private readonly bool _collapseEnabled;

		private bool _hasCleared;

		private readonly CircularBuffer<ConsoleEntry> _allConsoleEntries;

		private CircularBuffer<ConsoleEntry> _consoleEntries;

		private readonly object _threadLock = new object();

		public int ErrorCount { get; private set; }

		public int WarningCount { get; private set; }

		public int InfoCount { get; private set; }

		public IReadOnlyList<ConsoleEntry> Entries
		{
			get
			{
				if (!_hasCleared)
				{
					return _allConsoleEntries;
				}
				return _consoleEntries;
			}
		}

		public IReadOnlyList<ConsoleEntry> AllEntries => _allConsoleEntries;

		public event ConsoleUpdatedEventHandler Updated;

		public StandardConsoleService()
		{
			Application.logMessageReceivedThreaded += UnityLogCallback;
			SRServiceManager.RegisterService<IConsoleService>(this);
			_collapseEnabled = Settings.Instance.CollapseDuplicateLogEntries;
			_allConsoleEntries = new CircularBuffer<ConsoleEntry>(Settings.Instance.MaximumConsoleEntries);
		}

		public void Clear()
		{
			lock (_threadLock)
			{
				_hasCleared = true;
				if (_consoleEntries == null)
				{
					_consoleEntries = new CircularBuffer<ConsoleEntry>(Settings.Instance.MaximumConsoleEntries);
				}
				else
				{
					_consoleEntries.Clear();
				}
				int num = (InfoCount = 0);
				int errorCount = (WarningCount = num);
				ErrorCount = errorCount;
			}
			OnUpdated();
		}

		protected void OnEntryAdded(ConsoleEntry entry)
		{
			if (_hasCleared)
			{
				if (_consoleEntries.IsFull)
				{
					AdjustCounter(_consoleEntries.Front().LogType, -1);
					_consoleEntries.PopFront();
				}
				_consoleEntries.PushBack(entry);
			}
			else if (_allConsoleEntries.IsFull)
			{
				AdjustCounter(_allConsoleEntries.Front().LogType, -1);
				_allConsoleEntries.PopFront();
			}
			_allConsoleEntries.PushBack(entry);
			OnUpdated();
		}

		protected void OnEntryDuplicated(ConsoleEntry entry)
		{
			entry.Count++;
			OnUpdated();
			if (_hasCleared && _consoleEntries.Count == 0)
			{
				OnEntryAdded(new ConsoleEntry(entry)
				{
					Count = 1
				});
			}
		}

		private void OnUpdated()
		{
			if (this.Updated != null)
			{
				try
				{
					this.Updated(this);
				}
				catch
				{
				}
			}
		}

		private void UnityLogCallback(string condition, string stackTrace, LogType type)
		{
			lock (_threadLock)
			{
				ConsoleEntry consoleEntry = ((_collapseEnabled && _allConsoleEntries.Count > 0) ? _allConsoleEntries[_allConsoleEntries.Count - 1] : null);
				if (consoleEntry != null && consoleEntry.LogType == type && consoleEntry.Message == condition && consoleEntry.StackTrace == stackTrace)
				{
					OnEntryDuplicated(consoleEntry);
				}
				else
				{
					ConsoleEntry entry = new ConsoleEntry
					{
						LogType = type,
						StackTrace = stackTrace,
						Message = condition
					};
					OnEntryAdded(entry);
				}
				AdjustCounter(type, 1);
			}
		}

		private void AdjustCounter(LogType type, int amount)
		{
			switch (type)
			{
			case LogType.Error:
			case LogType.Assert:
			case LogType.Exception:
				ErrorCount += amount;
				break;
			case LogType.Warning:
				WarningCount += amount;
				break;
			case LogType.Log:
				InfoCount += amount;
				break;
			}
		}
	}
}
