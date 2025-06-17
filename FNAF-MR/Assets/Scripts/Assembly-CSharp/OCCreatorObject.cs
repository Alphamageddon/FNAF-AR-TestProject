using UnityEngine;

public class OCCreatorObject
{
	public PrimitiveType meshType;

	public string ParentName;

	public Color color;

	public Vector3 position = Vector3.zero;

	public Quaternion rotation = Quaternion.identity;

	public Vector3 scale = Vector3.one;

	public OCCreatorObject(PrimitiveType type, string parent)
	{
		meshType = type;
		if (parent != null)
		{
			ParentName = parent;
		}
	}
}
