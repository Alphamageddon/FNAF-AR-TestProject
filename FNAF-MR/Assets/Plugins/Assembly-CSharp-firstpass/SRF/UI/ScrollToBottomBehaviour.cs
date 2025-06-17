using UnityEngine;
using UnityEngine.UI;

namespace SRF.UI
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("SRF/UI/Scroll To Bottom Behaviour")]
	public class ScrollToBottomBehaviour : MonoBehaviour
	{
		[SerializeField]
		private ScrollRect _scrollRect;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		public void Start()
		{
			if (_scrollRect == null)
			{
				Debug.LogError("[ScrollToBottomBehaviour] ScrollRect not set");
				return;
			}
			if (_canvasGroup == null)
			{
				Debug.LogError("[ScrollToBottomBehaviour] CanvasGroup not set");
				return;
			}
			_scrollRect.onValueChanged.AddListener(OnScrollRectValueChanged);
			Refresh();
		}

		private void OnEnable()
		{
			Refresh();
		}

		public void Trigger()
		{
			_scrollRect.normalizedPosition = new Vector2(0f, 0f);
		}

		private void OnScrollRectValueChanged(Vector2 position)
		{
			Refresh();
		}

		private void Refresh()
		{
			if (!(_scrollRect == null))
			{
				if (_scrollRect.normalizedPosition.y < 0.001f)
				{
					SetVisible(truth: false);
				}
				else
				{
					SetVisible(truth: true);
				}
			}
		}

		private void SetVisible(bool truth)
		{
			if (truth)
			{
				_canvasGroup.alpha = 1f;
				_canvasGroup.interactable = true;
				_canvasGroup.blocksRaycasts = true;
			}
			else
			{
				_canvasGroup.alpha = 0f;
				_canvasGroup.interactable = false;
				_canvasGroup.blocksRaycasts = false;
			}
		}
	}
}
