using System;
using System.Collections.Generic;
using UnityEngine;

namespace SRF
{
	public static class SRFIListExtensions
	{
		public static T Random<T>(this IList<T> list)
		{
			if (list.Count == 0)
			{
				throw new IndexOutOfRangeException("List needs at least one entry to call Random()");
			}
			if (list.Count == 1)
			{
				return list[0];
			}
			return list[UnityEngine.Random.Range(0, list.Count)];
		}

		public static T RandomOrDefault<T>(this IList<T> list)
		{
			if (list.Count == 0)
			{
				return default(T);
			}
			return list.Random();
		}

		public static T PopLast<T>(this IList<T> list)
		{
			if (list.Count == 0)
			{
				throw new InvalidOperationException();
			}
			T result = list[list.Count - 1];
			list.RemoveAt(list.Count - 1);
			return result;
		}
	}
}
