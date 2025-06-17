using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace SRF
{
	[Serializable]
	public class SRList<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, ISerializationCallbackReceiver
	{
		[SerializeField]
		private T[] _buffer;

		[SerializeField]
		private int _count;

		private EqualityComparer<T> _equalityComparer;

		private ReadOnlyCollection<T> _readOnlyWrapper;

		public T[] Buffer
		{
			get
			{
				return _buffer;
			}
			private set
			{
				_buffer = value;
			}
		}

		private EqualityComparer<T> EqualityComparer
		{
			get
			{
				if (_equalityComparer == null)
				{
					_equalityComparer = EqualityComparer<T>.Default;
				}
				return _equalityComparer;
			}
		}

		public int Count
		{
			get
			{
				return _count;
			}
			private set
			{
				_count = value;
			}
		}

		public bool IsReadOnly => false;

		public T this[int index]
		{
			get
			{
				if (Buffer == null)
				{
					throw new IndexOutOfRangeException();
				}
				return Buffer[index];
			}
			set
			{
				if (Buffer == null)
				{
					throw new IndexOutOfRangeException();
				}
				Buffer[index] = value;
			}
		}

		public SRList()
		{
		}

		public SRList(int capacity)
		{
			Buffer = new T[capacity];
		}

		public SRList(IEnumerable<T> source)
		{
			AddRange(source);
		}

		public IEnumerator<T> GetEnumerator()
		{
			if (Buffer != null)
			{
				int i = 0;
				while (i < Count)
				{
					yield return Buffer[i];
					int num = i + 1;
					i = num;
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public void Add(T item)
		{
			if (Buffer == null || Count == Buffer.Length)
			{
				Expand();
			}
			Buffer[Count++] = item;
		}

		public void Clear()
		{
			Count = 0;
		}

		public bool Contains(T item)
		{
			if (Buffer == null)
			{
				return false;
			}
			for (int i = 0; i < Count; i++)
			{
				if (EqualityComparer.Equals(Buffer[i], item))
				{
					return true;
				}
			}
			return false;
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			Trim();
			Buffer.CopyTo(array, arrayIndex);
		}

		public bool Remove(T item)
		{
			if (Buffer == null)
			{
				return false;
			}
			int num = IndexOf(item);
			if (num < 0)
			{
				return false;
			}
			RemoveAt(num);
			return true;
		}

		public int IndexOf(T item)
		{
			if (Buffer == null)
			{
				return -1;
			}
			for (int i = 0; i < Count; i++)
			{
				if (EqualityComparer.Equals(Buffer[i], item))
				{
					return i;
				}
			}
			return -1;
		}

		public void Insert(int index, T item)
		{
			if (Buffer == null || Count == Buffer.Length)
			{
				Expand();
			}
			if (index < Count)
			{
				for (int num = Count; num > index; num--)
				{
					Buffer[num] = Buffer[num - 1];
				}
				Buffer[index] = item;
				int count = Count + 1;
				Count = count;
			}
			else
			{
				Add(item);
			}
		}

		public void RemoveAt(int index)
		{
			if (Buffer != null && index < Count)
			{
				int count = Count - 1;
				Count = count;
				Buffer[index] = default(T);
				for (int i = index; i < Count; i++)
				{
					Buffer[i] = Buffer[i + 1];
				}
			}
		}

		public void OnBeforeSerialize()
		{
			Debug.Log("[OnBeforeSerialize] Count: {0}".Fmt(_count));
			Clean();
		}

		public void OnAfterDeserialize()
		{
			Debug.Log("[OnAfterDeserialize] Count: {0}".Fmt(_count));
		}

		public void AddRange(IEnumerable<T> range)
		{
			foreach (T item in range)
			{
				Add(item);
			}
		}

		public void Clear(bool clean)
		{
			Clear();
			if (clean)
			{
				Clean();
			}
		}

		public void Clean()
		{
			if (Buffer != null)
			{
				for (int i = Count; i < _buffer.Length; i++)
				{
					_buffer[i] = default(T);
				}
			}
		}

		public ReadOnlyCollection<T> AsReadOnly()
		{
			if (_readOnlyWrapper == null)
			{
				_readOnlyWrapper = new ReadOnlyCollection<T>(this);
			}
			return _readOnlyWrapper;
		}

		private void Expand()
		{
			T[] array = ((Buffer != null) ? new T[Mathf.Max(Buffer.Length << 1, 32)] : new T[32]);
			if (Buffer != null && Count > 0)
			{
				Buffer.CopyTo(array, 0);
			}
			Buffer = array;
		}

		public void Trim()
		{
			if (Count > 0)
			{
				if (Count < Buffer.Length)
				{
					T[] array = new T[Count];
					for (int i = 0; i < Count; i++)
					{
						array[i] = Buffer[i];
					}
					Buffer = array;
				}
			}
			else
			{
				Buffer = new T[0];
			}
		}

		public void Sort(Comparison<T> comparer)
		{
			bool flag = true;
			while (flag)
			{
				flag = false;
				for (int i = 1; i < Count; i++)
				{
					if (comparer(Buffer[i - 1], Buffer[i]) > 0)
					{
						T val = Buffer[i];
						Buffer[i] = Buffer[i - 1];
						Buffer[i - 1] = val;
						flag = true;
					}
				}
			}
		}
	}
}
