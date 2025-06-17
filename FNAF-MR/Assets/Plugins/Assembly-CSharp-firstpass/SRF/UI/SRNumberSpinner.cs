using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/SRNumberSpinner")]
	public class SRNumberSpinner : InputField
	{
		private double _currentValue;

		private double _dragStartAmount;

		private double _dragStep;

		public float DragSensitivity = 0.01f;

		public double MaxValue = double.MaxValue;

		public double MinValue = double.MinValue;

		protected override void Awake()
		{
			base.Awake();
			if (base.contentType != ContentType.IntegerNumber && base.contentType != ContentType.DecimalNumber)
			{
				Debug.LogError("[SRNumberSpinner] contentType must be integer or decimal. Defaulting to integer");
				base.contentType = ContentType.DecimalNumber;
			}
		}

		public override void OnPointerClick(PointerEventData eventData)
		{
			if (base.interactable && !eventData.dragging)
			{
				EventSystem.current.SetSelectedGameObject(base.gameObject, eventData);
				base.OnPointerClick(eventData);
				if (m_Keyboard == null || !m_Keyboard.active)
				{
					OnSelect(eventData);
					return;
				}
				UpdateLabel();
				eventData.Use();
			}
		}

		public override void OnPointerDown(PointerEventData eventData)
		{
		}

		public override void OnPointerUp(PointerEventData eventData)
		{
		}

		public override void OnBeginDrag(PointerEventData eventData)
		{
			if (!base.interactable)
			{
				return;
			}
			if (Mathf.Abs(eventData.delta.y) > Mathf.Abs(eventData.delta.x))
			{
				Transform parent = base.transform.parent;
				if (parent != null)
				{
					eventData.pointerDrag = ExecuteEvents.GetEventHandler<IBeginDragHandler>(parent.gameObject);
					if (eventData.pointerDrag != null)
					{
						ExecuteEvents.Execute(eventData.pointerDrag, eventData, ExecuteEvents.beginDragHandler);
					}
				}
				return;
			}
			eventData.Use();
			_dragStartAmount = double.Parse(base.text);
			_currentValue = _dragStartAmount;
			float num = 1f;
			if (base.contentType == ContentType.IntegerNumber)
			{
				num *= 10f;
			}
			_dragStep = Math.Max(num, _dragStartAmount * 0.05000000074505806);
			if (base.isFocused)
			{
				DeactivateInputField();
			}
		}

		public override void OnDrag(PointerEventData eventData)
		{
			if (base.interactable)
			{
				float x = eventData.delta.x;
				_currentValue += Math.Abs(_dragStep) * (double)x * (double)DragSensitivity;
				_currentValue = Math.Round(_currentValue, 2);
				if (_currentValue > MaxValue)
				{
					_currentValue = MaxValue;
				}
				if (_currentValue < MinValue)
				{
					_currentValue = MinValue;
				}
				if (base.contentType == ContentType.IntegerNumber)
				{
					base.text = ((int)Math.Round(_currentValue)).ToString();
				}
				else
				{
					base.text = _currentValue.ToString();
				}
			}
		}

		public override void OnEndDrag(PointerEventData eventData)
		{
			if (base.interactable)
			{
				eventData.Use();
				if (_dragStartAmount != _currentValue)
				{
					DeactivateInputField();
					SendOnSubmit();
				}
			}
		}
	}
}
