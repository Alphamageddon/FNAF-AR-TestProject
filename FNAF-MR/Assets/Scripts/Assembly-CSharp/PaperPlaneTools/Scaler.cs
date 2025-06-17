using UnityEngine;

namespace PaperPlaneTools
{
	[ExecuteInEditMode]
	public class Scaler : MonoBehaviour
	{
		public float maxWidth = 1f;

		public float maxHeight = 1f;

		private void Update()
		{
			RectTransform component = GetComponent<RectTransform>();
			RectTransform rectTransform = ((base.transform.parent != null) ? base.transform.parent.GetComponent<RectTransform>() : null);
			float a = 1f;
			float width = component.rect.width;
			float num = ((rectTransform != null) ? rectTransform.rect.width : 0f);
			if (width > 0f)
			{
				a = Mathf.Min(1f, num * maxWidth / width);
			}
			float b = 1f;
			float height = component.rect.height;
			float num2 = ((rectTransform != null) ? rectTransform.rect.height : 0f);
			if (width > 0f)
			{
				b = Mathf.Min(1f, num2 * maxHeight / height);
			}
			float num3 = Mathf.Min(a, b);
			base.transform.localScale = new Vector3(num3, num3, 1f);
		}
	}
}
