using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace SRF.UI
{
	[AddComponentMenu("SRF/UI/Spinner")]
	public class SRSpinner : Selectable, IDragHandler, IEventSystemHandler, IBeginDragHandler
	{
		[Serializable]
		public class SpinEvent : UnityEvent
		{
		}

		private float _dragDelta;

		[SerializeField]
		private SpinEvent _onSpinDecrement = new SpinEvent();

		[SerializeField]
		private SpinEvent _onSpinIncrement = new SpinEvent();

		public float DragThreshold = 20f;

		public SpinEvent OnSpinIncrement
		{
			get
			{
				return _onSpinIncrement;
			}
			set
			{
				_onSpinIncrement = value;
			}
		}

		public SpinEvent OnSpinDecrement
		{
			get
			{
				return _onSpinDecrement;
			}
			set
			{
				_onSpinDecrement = value;
			}
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
			_dragDelta = 0f;
		}

		public void OnDrag(PointerEventData eventData)
		{
			if (!base.interactable)
			{
				return;
			}
			_dragDelta += eventData.delta.x;
			if (Mathf.Abs(_dragDelta) > DragThreshold)
			{
				float num = Mathf.Sign(_dragDelta);
				int num2 = Mathf.FloorToInt(Mathf.Abs(_dragDelta) / DragThreshold);
				if (num > 0f)
				{
					OnIncrement(num2);
				}
				else
				{
					OnDecrement(num2);
				}
				_dragDelta -= (float)num2 * DragThreshold * num;
			}
		}

		private void OnIncrement(int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				OnSpinIncrement.Invoke();
			}
		}

		private void OnDecrement(int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				OnSpinDecrement.Invoke();
			}
		}
	}
}
