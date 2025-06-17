using SRDebugger.UI.Other;
using SRF;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI
{
	public class MobileMenuController : SRMonoBehaviourEx
	{
		private Button _closeButton;

		[SerializeField]
		private float _maxMenuWidth = 185f;

		[SerializeField]
		private float _peekAmount = 45f;

		private float _targetXPosition;

		[RequiredField]
		public RectTransform Content;

		[RequiredField]
		public RectTransform Menu;

		[RequiredField]
		public Button OpenButton;

		[RequiredField]
		public SRTabController TabController;

		public float PeekAmount => _peekAmount;

		public float MaxMenuWidth => _maxMenuWidth;

		protected override void OnEnable()
		{
			base.OnEnable();
			RectTransform rectTransform = Menu.parent as RectTransform;
			Menu.GetComponent<LayoutElement>().ignoreLayout = true;
			Menu.pivot = new Vector2(1f, 1f);
			Menu.offsetMin = new Vector2(1f, 0f);
			Menu.offsetMax = new Vector2(1f, 1f);
			Menu.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Mathf.Clamp(rectTransform.rect.width - PeekAmount, 0f, MaxMenuWidth));
			Menu.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, rectTransform.rect.height);
			Menu.anchoredPosition = new Vector2(0f, 0f);
			if (_closeButton == null)
			{
				CreateCloseButton();
			}
			OpenButton.gameObject.SetActive(value: true);
			TabController.ActiveTabChanged += TabControllerOnActiveTabChanged;
		}

		protected override void OnDisable()
		{
			base.OnDisable();
			Menu.GetComponent<LayoutElement>().ignoreLayout = false;
			Content.anchoredPosition = new Vector2(0f, 0f);
			_closeButton.gameObject.SetActive(value: false);
			OpenButton.gameObject.SetActive(value: false);
			TabController.ActiveTabChanged -= TabControllerOnActiveTabChanged;
		}

		private void CreateCloseButton()
		{
			GameObject obj = new GameObject("SR_CloseButtonCanvas", typeof(RectTransform));
			obj.transform.SetParent(Content, worldPositionStays: false);
			Canvas canvas = obj.AddComponent<Canvas>();
			obj.AddComponent<GraphicRaycaster>();
			RectTransform componentOrAdd = obj.GetComponentOrAdd<RectTransform>();
			canvas.overrideSorting = true;
			canvas.sortingOrder = 122;
			obj.AddComponent<LayoutElement>().ignoreLayout = true;
			SetRectSize(componentOrAdd);
			GameObject gameObject = new GameObject("SR_CloseButton", typeof(RectTransform));
			gameObject.transform.SetParent(componentOrAdd, worldPositionStays: false);
			RectTransform component = gameObject.GetComponent<RectTransform>();
			SetRectSize(component);
			gameObject.AddComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
			_closeButton = gameObject.AddComponent<Button>();
			_closeButton.transition = Selectable.Transition.None;
			_closeButton.onClick.AddListener(CloseButtonClicked);
			_closeButton.gameObject.SetActive(value: false);
		}

		private void SetRectSize(RectTransform rect)
		{
			rect.anchorMin = new Vector2(0f, 0f);
			rect.anchorMax = new Vector2(1f, 1f);
			rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, Content.rect.width);
			rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, Content.rect.height);
		}

		private void CloseButtonClicked()
		{
			Close();
		}

		protected override void Update()
		{
			base.Update();
			float x = Content.anchoredPosition.x;
			if (Mathf.Abs(_targetXPosition - x) < 2.5f)
			{
				Content.anchoredPosition = new Vector2(_targetXPosition, Content.anchoredPosition.y);
			}
			else
			{
				Content.anchoredPosition = new Vector2(SRMath.SpringLerp(x, _targetXPosition, 15f, Time.unscaledDeltaTime), Content.anchoredPosition.y);
			}
		}

		private void TabControllerOnActiveTabChanged(SRTabController srTabController, SRTab srTab)
		{
			Close();
		}

		[ContextMenu("Open")]
		public void Open()
		{
			_targetXPosition = Menu.rect.width;
			_closeButton.gameObject.SetActive(value: true);
		}

		[ContextMenu("Close")]
		public void Close()
		{
			_targetXPosition = 0f;
			_closeButton.gameObject.SetActive(value: false);
		}
	}
}
