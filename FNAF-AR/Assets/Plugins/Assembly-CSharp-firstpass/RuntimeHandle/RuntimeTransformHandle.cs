using UnityEngine;
using UnityEngine.Events;

namespace RuntimeHandle
{
	public class RuntimeTransformHandle : MonoBehaviour
	{
		public HandleAxes axes = HandleAxes.XYZ;

		public HandleSpace space = HandleSpace.LOCAL;

		public HandleType type;

		public HandleSnappingType snappingType = HandleSnappingType.RELATIVE;

		public Vector3 positionSnap = Vector3.zero;

		public float rotationSnap;

		public Vector3 scaleSnap = Vector3.zero;

		public bool autoScale;

		public float autoScaleFactor = 1f;

		public Camera handleCamera;

		private Vector3 _previousMousePosition;

		private HandleBase _previousAxis;

		private HandleBase _draggingHandle;

		private HandleType _previousType;

		private HandleAxes _previousAxes;

		private PositionHandle _positionHandle;

		private RotationHandle _rotationHandle;

		private ScaleHandle _scaleHandle;

		public Transform target;

		public UnityEvent startedDraggingHandle = new UnityEvent();

		public UnityEvent isDraggingHandle = new UnityEvent();

		public UnityEvent endedDraggingHandle = new UnityEvent();

		[SerializeField]
		private bool disableWhenNoTarget;

		private void Start()
		{
			if (handleCamera == null)
			{
				handleCamera = Camera.main;
			}
			_previousType = type;
			if (target == null)
			{
				target = base.transform;
			}
			if (disableWhenNoTarget && target == base.transform)
			{
				base.gameObject.SetActive(value: false);
			}
			CreateHandles();
		}

		private void CreateHandles()
		{
			switch (type)
			{
			case HandleType.POSITION:
				_positionHandle = base.gameObject.AddComponent<PositionHandle>().Initialize(this);
				break;
			case HandleType.ROTATION:
				_rotationHandle = base.gameObject.AddComponent<RotationHandle>().Initialize(this);
				break;
			case HandleType.SCALE:
				_scaleHandle = base.gameObject.AddComponent<ScaleHandle>().Initialize(this);
				break;
			}
		}

		private void Clear()
		{
			_draggingHandle = null;
			if ((bool)_positionHandle)
			{
				_positionHandle.Destroy();
			}
			if ((bool)_rotationHandle)
			{
				_rotationHandle.Destroy();
			}
			if ((bool)_scaleHandle)
			{
				_scaleHandle.Destroy();
			}
		}

		private void Update()
		{
			if (autoScale)
			{
				base.transform.localScale = Vector3.one * (Vector3.Distance(handleCamera.transform.position, base.transform.position) * autoScaleFactor) / 15f;
			}
			if (_previousType != type || _previousAxes != axes)
			{
				Clear();
				CreateHandles();
				_previousType = type;
				_previousAxes = axes;
			}
			HandleBase p_handle = null;
			Vector3 p_hitPoint = Vector3.zero;
			GetHandle(ref p_handle, ref p_hitPoint);
			HandleOverEffect(p_handle, p_hitPoint);
			if (PointerIsDown() && _draggingHandle != null)
			{
				_draggingHandle.Interact(_previousMousePosition);
				isDraggingHandle.Invoke();
			}
			if (GetPointerDown() && p_handle != null)
			{
				_draggingHandle = p_handle;
				_draggingHandle.StartInteraction(p_hitPoint);
				startedDraggingHandle.Invoke();
			}
			if (GetPointerUp() && _draggingHandle != null)
			{
				_draggingHandle.EndInteraction();
				_draggingHandle = null;
				endedDraggingHandle.Invoke();
			}
			_previousMousePosition = GetMousePosition();
			base.transform.position = target.transform.position;
			if (space == HandleSpace.LOCAL || type == HandleType.SCALE)
			{
				base.transform.rotation = target.transform.rotation;
			}
			else
			{
				base.transform.rotation = Quaternion.identity;
			}
		}

		public static bool GetPointerDown()
		{
			return Input.GetMouseButtonDown(0);
		}

		public static bool PointerIsDown()
		{
			return Input.GetMouseButton(0);
		}

		public static bool GetPointerUp()
		{
			return Input.GetMouseButtonUp(0);
		}

		public static Vector3 GetMousePosition()
		{
			return Input.mousePosition;
		}

		private void HandleOverEffect(HandleBase p_axis, Vector3 p_hitPoint)
		{
			if (_draggingHandle == null && _previousAxis != null && (_previousAxis != p_axis || !_previousAxis.CanInteract(p_hitPoint)))
			{
				_previousAxis.SetDefaultColor();
			}
			if (p_axis != null && _draggingHandle == null && p_axis.CanInteract(p_hitPoint))
			{
				p_axis.SetColor(Color.yellow);
			}
			_previousAxis = p_axis;
		}

		private void GetHandle(ref HandleBase p_handle, ref Vector3 p_hitPoint)
		{
			RaycastHit[] array = Physics.RaycastAll(Camera.main.ScreenPointToRay(GetMousePosition()));
			if (array.Length == 0)
			{
				return;
			}
			RaycastHit[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				RaycastHit raycastHit = array2[i];
				p_handle = raycastHit.collider.gameObject.GetComponentInParent<HandleBase>();
				if (p_handle != null)
				{
					p_hitPoint = raycastHit.point;
					break;
				}
			}
		}

		public static RuntimeTransformHandle Create(Transform p_target, HandleType p_handleType)
		{
			RuntimeTransformHandle runtimeTransformHandle = new GameObject().AddComponent<RuntimeTransformHandle>();
			runtimeTransformHandle.target = p_target;
			runtimeTransformHandle.type = p_handleType;
			return runtimeTransformHandle;
		}

		public void SetTarget(Transform newTarget)
		{
			target = newTarget;
		}

		public void SetTarget(GameObject newTarget)
		{
			target = newTarget.transform;
			if (target == null)
			{
				target = base.transform;
			}
			if (disableWhenNoTarget && target == base.transform)
			{
				base.gameObject.SetActive(value: false);
			}
			else if (disableWhenNoTarget && target != base.transform)
			{
				base.gameObject.SetActive(value: true);
			}
		}

		public void SetHandleMode(int mode)
		{
			SetHandleMode((HandleType)mode);
		}

		public void SetHandleMode(HandleType mode)
		{
			type = mode;
		}

		public void EnableXAxis(bool enable)
		{
			if (enable)
			{
				axes |= HandleAxes.X;
			}
			else
			{
				axes &= (HandleAxes)(-5);
			}
		}

		public void EnableYAxis(bool enable)
		{
			if (enable)
			{
				axes |= HandleAxes.Y;
			}
			else
			{
				axes &= (HandleAxes)(-3);
			}
		}

		public void EnableZAxis(bool enable)
		{
			if (enable)
			{
				axes |= HandleAxes.Z;
			}
			else
			{
				axes &= (HandleAxes)(-2);
			}
		}

		public void SetAxis(HandleAxes newAxes)
		{
			axes = newAxes;
		}
	}
}
