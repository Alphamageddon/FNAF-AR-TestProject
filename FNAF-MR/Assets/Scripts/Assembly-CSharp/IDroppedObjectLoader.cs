using System;
using System.Collections.Generic;
using UnityEngine;

public interface IDroppedObjectLoader
{
	void Load(Transform parent, Action<List<DroppedObject>> onComplete);

	void Unload();
}
