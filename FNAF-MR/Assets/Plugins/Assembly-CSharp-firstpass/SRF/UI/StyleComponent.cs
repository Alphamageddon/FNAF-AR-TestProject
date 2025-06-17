using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace SRF.UI
{
	[ExecuteInEditMode]
	[AddComponentMenu("SRF/UI/Style Component")]
	public class StyleComponent : SRMonoBehaviour
	{
		private Style _activeStyle;

		private StyleRoot _cachedRoot;

		private Graphic _graphic;

		private bool _hasStarted;

		private Image _image;

		private Selectable _selectable;

		[SerializeField]
		[FormerlySerializedAs("StyleKey")]
		[HideInInspector]
		private string _styleKey;

		public bool IgnoreImage;

		public string StyleKey
		{
			get
			{
				return _styleKey;
			}
			set
			{
				_styleKey = value;
				Refresh(invalidateCache: false);
			}
		}

		private void Start()
		{
			Refresh(invalidateCache: true);
			_hasStarted = true;
		}

		private void OnEnable()
		{
			if (_hasStarted)
			{
				Refresh(invalidateCache: false);
			}
		}

		public void Refresh(bool invalidateCache)
		{
			if (string.IsNullOrEmpty(StyleKey))
			{
				_activeStyle = null;
				return;
			}
			if (_cachedRoot == null || invalidateCache)
			{
				_cachedRoot = GetStyleRoot();
			}
			if (_cachedRoot == null)
			{
				Debug.LogWarning("[StyleComponent] No active StyleRoot object found in parents.", this);
				_activeStyle = null;
				return;
			}
			Style style = _cachedRoot.GetStyle(StyleKey);
			if (style == null)
			{
				Debug.LogWarning("[StyleComponent] Style not found ({0})".Fmt(StyleKey), this);
				_activeStyle = null;
			}
			else
			{
				_activeStyle = style;
				ApplyStyle();
			}
		}

		private StyleRoot GetStyleRoot()
		{
			Transform transform = base.CachedTransform;
			int num = 0;
			StyleRoot componentInParent;
			do
			{
				componentInParent = transform.GetComponentInParent<StyleRoot>();
				if (componentInParent != null)
				{
					transform = componentInParent.transform.parent;
				}
				num++;
				if (num > 100)
				{
					Debug.LogWarning("Breaking Loop");
					break;
				}
			}
			while (componentInParent != null && !componentInParent.enabled && transform != null);
			return componentInParent;
		}

		private void ApplyStyle()
		{
			if (_activeStyle == null)
			{
				return;
			}
			if (_graphic == null)
			{
				_graphic = GetComponent<Graphic>();
			}
			if (_selectable == null)
			{
				_selectable = GetComponent<Selectable>();
			}
			if (_image == null)
			{
				_image = GetComponent<Image>();
			}
			if (!IgnoreImage && _image != null)
			{
				_image.sprite = _activeStyle.Image;
			}
			if (_selectable != null)
			{
				ColorBlock colors = _selectable.colors;
				colors.normalColor = _activeStyle.NormalColor;
				colors.highlightedColor = _activeStyle.HoverColor;
				colors.pressedColor = _activeStyle.ActiveColor;
				colors.disabledColor = _activeStyle.DisabledColor;
				colors.colorMultiplier = 1f;
				_selectable.colors = colors;
				if (_graphic != null)
				{
					_graphic.color = Color.white;
				}
			}
			else if (_graphic != null)
			{
				_graphic.color = _activeStyle.NormalColor;
			}
		}

		private void SRStyleDirty()
		{
			if (!base.CachedGameObject.activeInHierarchy)
			{
				_cachedRoot = null;
			}
			else
			{
				Refresh(invalidateCache: true);
			}
		}
	}
}
