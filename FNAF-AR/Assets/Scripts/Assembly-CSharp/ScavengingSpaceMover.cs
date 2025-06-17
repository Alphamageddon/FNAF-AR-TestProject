using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ScavengingSpaceMover
{
	private Transform _playerTransform;

	private Transform _animatronicPrefabTransform;

	private float _movementUnitsPerSecond;

	private bool _incrementWaypoint = true;

	private ScavengingEnvironment _scavengingEnvironment;

	private NavMeshAgent navMeshAgent;

	private List<Vector3> activeWayPointPositions;

	private int activeWaypointIdx;

	public float GetDistanceFromPlayer()
	{
		return Vector3.Distance(_animatronicPrefabTransform.position, _playerTransform.position);
	}

	public void TeleportToStartPoint(ScavengingEnvironment env)
	{
		_scavengingEnvironment = env;
		if (_scavengingEnvironment.AnimatronicStartPosition != null)
		{
			_animatronicPrefabTransform.position = _scavengingEnvironment.AnimatronicStartPosition.position;
		}
		SetWaypoints();
		SetupNavMeshAgent();
	}

	private void SetWaypoints()
	{
		activeWayPointPositions.Clear();
		Transform[] wayPoints = _scavengingEnvironment.wayPoints;
		foreach (Transform transform in wayPoints)
		{
			activeWayPointPositions.Add(transform.position);
		}
		FindClosestWaypoint();
	}

	private void SetupNavMeshAgent()
	{
		navMeshAgent = _animatronicPrefabTransform.gameObject.AddComponent<NavMeshAgent>();
		navMeshAgent.baseOffset = 1.6f;
		navMeshAgent.speed = 0f;
		navMeshAgent.angularSpeed = 120f;
		navMeshAgent.acceleration = 8f;
		navMeshAgent.stoppingDistance = 0f;
		navMeshAgent.autoBraking = true;
		navMeshAgent.radius = 0.6f;
		navMeshAgent.height = 2.59f;
	}

	public bool MoveTowardPlayer()
	{
		navMeshAgent.speed = _movementUnitsPerSecond;
		navMeshAgent.SetDestination(_playerTransform.position);
		if (Vector3.Distance(_animatronicPrefabTransform.position, _playerTransform.position) < 1f)
		{
			return true;
		}
		return false;
	}

	public void MoveFollowWaypoints()
	{
		navMeshAgent.speed = _movementUnitsPerSecond;
		navMeshAgent.SetDestination(activeWayPointPositions[activeWaypointIdx]);
		if (Vector3.Distance(_animatronicPrefabTransform.position, activeWayPointPositions[activeWaypointIdx]) < 1f)
		{
			IncreaseIndex();
		}
	}

	public void SwapWaypointIncrement()
	{
		_incrementWaypoint = !_incrementWaypoint;
	}

	private void IncreaseIndex()
	{
		if (_incrementWaypoint)
		{
			if (activeWaypointIdx + 1 >= activeWayPointPositions.Count)
			{
				activeWaypointIdx = 0;
			}
			else
			{
				activeWaypointIdx++;
			}
		}
		else if (activeWaypointIdx - 1 < 0)
		{
			activeWaypointIdx = activeWayPointPositions.Count - 1;
		}
		else
		{
			activeWaypointIdx--;
		}
	}

	public void SetMovementUnitsPerSecond(float movementUnitsPerSecond)
	{
		_movementUnitsPerSecond = movementUnitsPerSecond;
		navMeshAgent.speed = _movementUnitsPerSecond;
	}

	public void FindClosestWaypoint()
	{
		float num = -1f;
		int num2 = 0;
		for (int i = 0; i < activeWayPointPositions.Count; i++)
		{
			float num3 = Vector3.Distance(_animatronicPrefabTransform.position, activeWayPointPositions[i]);
			if (num == -1f || num3 < num)
			{
				num2 = i;
				num = num3;
			}
		}
		activeWaypointIdx = num2;
	}

	public ScavengingSpaceMover(Transform prefab, Transform user)
	{
		_animatronicPrefabTransform = prefab;
		_playerTransform = user;
		activeWayPointPositions = new List<Vector3>();
	}

	public void Teardown()
	{
		_playerTransform = null;
		_animatronicPrefabTransform = null;
		_scavengingEnvironment = null;
		navMeshAgent = null;
		activeWayPointPositions = null;
	}
}
