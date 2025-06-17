using System;
using System.Collections;
using System.Collections.Generic;

namespace SRDebugger
{
	public class CircularBuffer<T> : IEnumerable<T>, IEnumerable, IReadOnlyList<T>
	{
		private readonly T[] _buffer;

		private int _end;

		private int _count;

		private int _start;

		public int Capacity => _buffer.Length;

		public bool IsFull => Count == Capacity;

		public bool IsEmpty => Count == 0;

		public int Count => _count;

		public T this[int index]
		{
			get
			{
				if (IsEmpty)
				{
					throw new IndexOutOfRangeException($"Cannot access index {index}. Buffer is empty");
				}
				if (index >= _count)
				{
					throw new IndexOutOfRangeException($"Cannot access index {index}. Buffer size is {_count}");
				}
				int num = InternalIndex(index);
				return _buffer[num];
			}
			set
			{
				if (IsEmpty)
				{
					throw new IndexOutOfRangeException($"Cannot access index {index}. Buffer is empty");
				}
				if (index >= _count)
				{
					throw new IndexOutOfRangeException($"Cannot access index {index}. Buffer size is {_count}");
				}
				int num = InternalIndex(index);
				_buffer[num] = value;
			}
		}

		public CircularBuffer(int capacity)
			: this(capacity, new T[0])
		{
		}

		public CircularBuffer(int capacity, T[] items)
		{
			if (capacity < 1)
			{
				throw new ArgumentException("Circular buffer cannot have negative or zero capacity.", "capacity");
			}
			if (items == null)
			{
				throw new ArgumentNullException("items");
			}
			if (items.Length > capacity)
			{
				throw new ArgumentException("Too many items to fit circular buffer", "items");
			}
			_buffer = new T[capacity];
			Array.Copy(items, _buffer, items.Length);
			_count = items.Length;
			_start = 0;
			_end = ((_count != capacity) ? _count : 0);
		}

		public void Clear()
		{
			_count = 0;
			_end = 0;
			_start = 0;
		}

		public IEnumerator<T> GetEnumerator()
		{
			ArraySegment<T>[] array = new ArraySegment<T>[2]
			{
				ArrayOne(),
				ArrayTwo()
			};
			ArraySegment<T>[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				ArraySegment<T> segment = array2[i];
				for (int j = 0; j < segment.Count; j++)
				{
					yield return segment.Array[segment.Offset + j];
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public T Front()
		{
			ThrowIfEmpty();
			return _buffer[_start];
		}

		public T Back()
		{
			ThrowIfEmpty();
			return _buffer[((_end != 0) ? _end : _count) - 1];
		}

		public void PushBack(T item)
		{
			if (IsFull)
			{
				_buffer[_end] = item;
				Increment(ref _end);
				_start = _end;
			}
			else
			{
				_buffer[_end] = item;
				Increment(ref _end);
				_count++;
			}
		}

		public void PushFront(T item)
		{
			if (IsFull)
			{
				Decrement(ref _start);
				_end = _start;
				_buffer[_start] = item;
			}
			else
			{
				Decrement(ref _start);
				_buffer[_start] = item;
				_count++;
			}
		}

		public void PopBack()
		{
			ThrowIfEmpty("Cannot take elements from an empty buffer.");
			Decrement(ref _end);
			_buffer[_end] = default(T);
			_count--;
		}

		public void PopFront()
		{
			ThrowIfEmpty("Cannot take elements from an empty buffer.");
			_buffer[_start] = default(T);
			Increment(ref _start);
			_count--;
		}

		public T[] ToArray()
		{
			T[] array = new T[Count];
			int num = 0;
			ArraySegment<T>[] array2 = new ArraySegment<T>[2]
			{
				ArrayOne(),
				ArrayTwo()
			};
			for (int i = 0; i < array2.Length; i++)
			{
				ArraySegment<T> arraySegment = array2[i];
				Array.Copy(arraySegment.Array, arraySegment.Offset, array, num, arraySegment.Count);
				num += arraySegment.Count;
			}
			return array;
		}

		private void ThrowIfEmpty(string message = "Cannot access an empty buffer.")
		{
			if (IsEmpty)
			{
				throw new InvalidOperationException(message);
			}
		}

		private void Increment(ref int index)
		{
			if (++index == Capacity)
			{
				index = 0;
			}
		}

		private void Decrement(ref int index)
		{
			if (index == 0)
			{
				index = Capacity;
			}
			index--;
		}

		private int InternalIndex(int index)
		{
			return _start + ((index < Capacity - _start) ? index : (index - Capacity));
		}

		private ArraySegment<T> ArrayOne()
		{
			if (_start < _end)
			{
				return new ArraySegment<T>(_buffer, _start, _end - _start);
			}
			return new ArraySegment<T>(_buffer, _start, _buffer.Length - _start);
		}

		private ArraySegment<T> ArrayTwo()
		{
			if (_start < _end)
			{
				return new ArraySegment<T>(_buffer, _end, 0);
			}
			return new ArraySegment<T>(_buffer, 0, _end);
		}
	}
}
