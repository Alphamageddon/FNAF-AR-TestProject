using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Other
{
	[RequireComponent(typeof(ScrollRect))]
	[ExecuteInEditMode]
	public class ScrollRectPatch : MonoBehaviour
	{
		public RectTransform Content;

		public Mask ReplaceMask;

		public RectTransform Viewport;

		private void Awake()
		{
			ScrollRect component = GetComponent<ScrollRect>();
			component.content = Content;
			component.viewport = Viewport;
			if (ReplaceMask != null)
			{
				GameObject obj = ReplaceMask.gameObject;
				Object.Destroy(obj.GetComponent<Graphic>());
				Object.Destroy(obj.GetComponent<CanvasRenderer>());
				Object.Destroy(ReplaceMask);
				obj.AddComponent<RectMask2D>();
			}
		}
	}
}
