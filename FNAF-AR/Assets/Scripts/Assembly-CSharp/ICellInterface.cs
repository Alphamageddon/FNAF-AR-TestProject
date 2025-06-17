using UnityEngine;

public interface ICellInterface<T>
{
	void SetData(T data);

	void SetSprite(Sprite sprite);
}
