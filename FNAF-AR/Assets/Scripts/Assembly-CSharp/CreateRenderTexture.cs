using UnityEngine;

[RequireComponent(typeof(Camera))]
public class CreateRenderTexture : MonoBehaviour
{
	public Material iosMaterial;

	public Material androidMaterial;

	private Camera cam;

	private MeshRenderer mr;

	private void Start()
	{
		cam = GetComponent<Camera>();
		float num = cam.fieldOfView * 0.5f * 0.01745329f * 26f;
		CreateQuad(num * cam.aspect, num, 13f);
		SetupCameraRenderTexture();
	}

	private void SetupCameraRenderTexture()
	{
		cam = GetComponent<Camera>();
		cam.targetTexture = new RenderTexture(((Screen.width < 0) ? (Screen.width + 1) : Screen.width) >> 1, ((Screen.height < 0) ? (Screen.height + 1) : Screen.height) >> 1, 24);
		RenderTexture.active = cam.targetTexture;
		mr.material.mainTexture = cam.targetTexture;
	}

	private void CreateQuad(float width, float height, float distance)
	{
		GameObject gameObject = new GameObject();
		gameObject.transform.parent = base.transform.parent;
		gameObject.transform.localEulerAngles = Vector3.zero;
		gameObject.transform.localScale = Vector3.one * 1.1f;
		gameObject.layer = LayerMask.NameToLayer("PostProcessing");
		gameObject.transform.localPosition = Vector3.zero;
		gameObject.name = "Camera_Background_RenderTexture";
		mr = gameObject.AddComponent<MeshRenderer>();
		mr.material = androidMaterial;
		mr.material.renderQueue = 9998;
		Mesh mesh = new Mesh();
		gameObject.AddComponent<MeshFilter>().mesh = mesh;
		mesh.vertices = new Vector3[4]
		{
			new Vector3(width * -0.5f, height * -0.5f, distance),
			new Vector3(width * 0.5f, height * -0.5f, distance),
			new Vector3(width * -0.5f, height * 0.5f, distance),
			new Vector3(width * 0.5f, height * 0.5f, distance)
		};
		mesh.triangles = new int[6] { 0, 2, 1, 2, 3, 1 };
		mesh.normals = new Vector3[4]
		{
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward,
			-Vector3.forward
		};
		mesh.uv = new Vector2[4]
		{
			new Vector2(0f, 0f),
			new Vector2(1f, 0f),
			new Vector2(0f, 1f),
			new Vector2(1f, 1f)
		};
	}
}
