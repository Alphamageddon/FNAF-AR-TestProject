using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace SRF
{
	public class Hierarchy
	{
		private static readonly char[] Seperator = new char[1] { '/' };

		private static readonly Dictionary<string, Transform> Cache = new Dictionary<string, Transform>();

		[Obsolete("Use static Get() instead")]
		public Transform this[string key] => Get(key);

		public static Transform Get(string key)
		{
			if (Cache.TryGetValue(key, out var value))
			{
				return value;
			}
			GameObject gameObject = GameObject.Find(key);
			if ((bool)gameObject)
			{
				value = gameObject.transform;
				Cache.Add(key, value);
				return value;
			}
			string[] array = key.Split(Seperator, StringSplitOptions.RemoveEmptyEntries);
			value = new GameObject(array.Last()).transform;
			Cache.Add(key, value);
			if (array.Length == 1)
			{
				return value;
			}
			value.parent = Get(string.Join("/", array, 0, array.Length - 1));
			return value;
		}
	}
}
