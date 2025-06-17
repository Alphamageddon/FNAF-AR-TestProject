using UnityEngine;

public class Outline : MonoBehaviour
{
	public GameObject meshObject;

	private LineRenderer lineRenderer;

	private Mesh mesh;

	private Vector3[] vertices;

	private void Start()
	{
		mesh = meshObject.GetComponent<MeshFilter>().mesh;
		vertices = mesh.vertices;
		lineRenderer = GetComponent<LineRenderer>();
		lineRenderer.positionCount = vertices.Length;
		lineRenderer.SetPositions(vertices);
	}

	private void Update()
	{
		Vector3 vector = Camera.main.WorldToViewportPoint(meshObject.transform.position);
		if (vector.x > 0f && vector.x < 1f && vector.y > 0f && vector.y < 1f)
		{
			lineRenderer.enabled = true;
		}
		else
		{
			lineRenderer.enabled = false;
		}
	}
}
