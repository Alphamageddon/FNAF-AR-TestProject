using System;
using UnityEngine;

public class SpaceMover
{
	public enum Mode
	{
		LOCAL = 0,
		GLOBAL = 1,
		SCAVENGING = 2
	}

	private Action OnStartedMoving;

	private Action OnStoppedMoving;

	private LocalSpaceMover _localSpaceMover;

	private GlobalSpaceMover _globalSpaceMover;

	private ScavengingSpaceMover _scavengingSpaceMover;

	private Mode _movementMode;

	private readonly SimpleTimer _moveDuration;

	protected float _movementUnitsPerSecond;

	protected bool _rotateAroundOrigin;

	protected bool _followWayPoints;

	public bool IsMoving => _movementUnitsPerSecond != 0f;

	public void add_OnStartedMoving(Action value)
	{
		OnStartedMoving = (Action)Delegate.Combine(OnStartedMoving, value);
	}

	public void remove_OnStartedMoving(Action value)
	{
		OnStartedMoving = (Action)Delegate.Remove(OnStartedMoving, value);
	}

	public void add_OnStoppedMoving(Action value)
	{
		OnStoppedMoving = (Action)Delegate.Combine(OnStoppedMoving, value);
	}

	public void remove_OnStoppedMoving(Action value)
	{
		OnStoppedMoving = (Action)Delegate.Remove(OnStoppedMoving, value);
	}

	public void SetMoveTowardsCameraMode(Mode mode)
	{
		_movementMode = mode;
	}

	public void Update()
	{
		if (_movementUnitsPerSecond == 0f)
		{
			return;
		}
		if (_moveDuration.Started && _moveDuration.IsExpired())
		{
			StopMovement();
			return;
		}
		if (_followWayPoints)
		{
			_scavengingSpaceMover.MoveFollowWaypoints();
			return;
		}
		if (_rotateAroundOrigin)
		{
			switch (_movementMode)
			{
			case Mode.LOCAL:
				_localSpaceMover.RotateAroundOrigin();
				break;
			case Mode.GLOBAL:
				_globalSpaceMover.RotateAroundCamera();
				break;
			}
			return;
		}
		switch (_movementMode)
		{
		case Mode.LOCAL:
			if (_localSpaceMover.MoveTowardOrigin())
			{
				StopMovement();
			}
			break;
		case Mode.GLOBAL:
			if (_globalSpaceMover.MoveTowardCamera())
			{
				StopMovement();
			}
			break;
		case Mode.SCAVENGING:
			if (_scavengingSpaceMover.MoveTowardPlayer())
			{
				StopMovement();
			}
			break;
		}
	}

	public float GetMoveSpeed()
	{
		return _movementUnitsPerSecond;
	}

	public void StopMovement()
	{
		if (IsMoving && OnStoppedMoving != null)
		{
			OnStoppedMoving();
		}
		_moveDuration.Reset();
		_movementUnitsPerSecond = 0f;
		switch (_movementMode)
		{
		case Mode.LOCAL:
			_localSpaceMover.SetMovementUnitsPerSecond(_movementUnitsPerSecond);
			break;
		case Mode.GLOBAL:
			_globalSpaceMover.SetMovementUnitsPerSecond(_movementUnitsPerSecond);
			break;
		case Mode.SCAVENGING:
			_scavengingSpaceMover.SetMovementUnitsPerSecond(_movementUnitsPerSecond);
			break;
		}
	}

	private void StartMovement(float unitsPerSecond, float duration)
	{
		_movementUnitsPerSecond = unitsPerSecond;
		if (duration < 0f)
		{
			_moveDuration.Reset();
		}
		else
		{
			_moveDuration.StartTimer(duration);
		}
		if (OnStartedMoving != null)
		{
			OnStartedMoving();
		}
	}

	public void MoveInCircleAroundOrigin(float degreesPerSecond, float duration)
	{
		_followWayPoints = false;
		_rotateAroundOrigin = true;
		StartMovement(degreesPerSecond, duration);
		switch (_movementMode)
		{
		case Mode.LOCAL:
			_localSpaceMover.SetMovementUnitsPerSecond(degreesPerSecond);
			break;
		case Mode.GLOBAL:
			_globalSpaceMover.SetMovementUnitsPerSecond(degreesPerSecond);
			break;
		}
	}

	public void MoveInLineTowardOrigin(float unitsPerSecond, float duration)
	{
		_rotateAroundOrigin = false;
		_followWayPoints = false;
		StartMovement(unitsPerSecond, duration);
		switch (_movementMode)
		{
		case Mode.LOCAL:
			_localSpaceMover.SetMovementUnitsPerSecond(unitsPerSecond);
			break;
		case Mode.GLOBAL:
			_globalSpaceMover.SetMovementUnitsPerSecond(unitsPerSecond);
			break;
		case Mode.SCAVENGING:
			_scavengingSpaceMover.SetMovementUnitsPerSecond(unitsPerSecond);
			break;
		}
	}

	public void MoveFollowWaypoints(float unitsPerSecond, float duration)
	{
		if (_movementMode == Mode.SCAVENGING)
		{
			_rotateAroundOrigin = false;
			_followWayPoints = true;
			StartMovement(unitsPerSecond, duration);
			_scavengingSpaceMover.FindClosestWaypoint();
			_scavengingSpaceMover.SetMovementUnitsPerSecond(unitsPerSecond);
		}
	}

	public float GetDistanceFromCamera()
	{
		return _movementMode switch
		{
			Mode.LOCAL => _localSpaceMover.GetDistanceFromLocalOrigin(), 
			Mode.GLOBAL => _globalSpaceMover.GetDistanceFromCamera(), 
			Mode.SCAVENGING => _scavengingSpaceMover.GetDistanceFromPlayer(), 
			_ => 0f, 
		};
	}

	public void ScavengingTeleportToStartPoint(ScavengingEnvironment env)
	{
		_scavengingSpaceMover.TeleportToStartPoint(env);
	}

	public void SwapWaypointIncrement()
	{
		_scavengingSpaceMover.SwapWaypointIncrement();
	}

	public SpaceMover(Transform animatronicPrefabTransform, Transform userTransform)
	{
		_moveDuration = new SimpleTimer();
		_localSpaceMover = new LocalSpaceMover(animatronicPrefabTransform);
		_globalSpaceMover = new GlobalSpaceMover(animatronicPrefabTransform, userTransform);
		_scavengingSpaceMover = new ScavengingSpaceMover(animatronicPrefabTransform, userTransform);
	}

	public void Teardown()
	{
		_localSpaceMover.Teardown();
		_globalSpaceMover.Teardown();
		_scavengingSpaceMover.Teardown();
		_localSpaceMover = null;
		_globalSpaceMover = null;
		_scavengingSpaceMover = null;
	}
}
