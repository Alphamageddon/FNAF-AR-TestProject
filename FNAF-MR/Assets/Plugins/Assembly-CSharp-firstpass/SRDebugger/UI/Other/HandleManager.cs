using SRF;
using UnityEngine;

namespace SRDebugger.UI.Other
{
	public class HandleManager : SRMonoBehaviour
	{
		private bool _hasSet;

		public GameObject BottomHandle;

		public GameObject BottomLeftHandle;

		public GameObject BottomRightHandle;

		public PinAlignment DefaultAlignment;

		public GameObject LeftHandle;

		public GameObject RightHandle;

		public GameObject TopHandle;

		public GameObject TopLeftHandle;

		public GameObject TopRightHandle;

		private void Start()
		{
			if (!_hasSet)
			{
				SetAlignment(DefaultAlignment);
			}
		}

		public void SetAlignment(PinAlignment alignment)
		{
			_hasSet = true;
			switch (alignment)
			{
			case PinAlignment.TopLeft:
			case PinAlignment.TopRight:
				SetActive(BottomHandle, active: true);
				SetActive(TopHandle, active: false);
				SetActive(TopLeftHandle, active: false);
				SetActive(TopRightHandle, active: false);
				break;
			case PinAlignment.BottomLeft:
			case PinAlignment.BottomRight:
				SetActive(BottomHandle, active: false);
				SetActive(TopHandle, active: true);
				SetActive(BottomLeftHandle, active: false);
				SetActive(BottomRightHandle, active: false);
				break;
			}
			switch (alignment)
			{
			case PinAlignment.TopLeft:
			case PinAlignment.BottomLeft:
				SetActive(LeftHandle, active: false);
				SetActive(RightHandle, active: true);
				SetActive(TopLeftHandle, active: false);
				SetActive(BottomLeftHandle, active: false);
				break;
			case PinAlignment.TopRight:
			case PinAlignment.BottomRight:
				SetActive(LeftHandle, active: true);
				SetActive(RightHandle, active: false);
				SetActive(TopRightHandle, active: false);
				SetActive(BottomRightHandle, active: false);
				break;
			}
			switch (alignment)
			{
			case PinAlignment.TopLeft:
				SetActive(BottomLeftHandle, active: false);
				SetActive(BottomRightHandle, active: true);
				break;
			case PinAlignment.TopRight:
				SetActive(BottomLeftHandle, active: true);
				SetActive(BottomRightHandle, active: false);
				break;
			case PinAlignment.BottomLeft:
				SetActive(TopLeftHandle, active: false);
				SetActive(TopRightHandle, active: true);
				break;
			case PinAlignment.BottomRight:
				SetActive(TopLeftHandle, active: true);
				SetActive(TopRightHandle, active: false);
				break;
			}
		}

		private void SetActive(GameObject obj, bool active)
		{
			if (!(obj == null))
			{
				obj.SetActive(active);
			}
		}
	}
}
