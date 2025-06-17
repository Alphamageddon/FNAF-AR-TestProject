using System.Collections.Generic;
using UnityEngine;

public class CustomNightAnimatronicAI
{
	private CustomNightAnimatronic data;

	private CustomNightController controller;

	private int AIValue;

	private CustomNightAnimatronic.CustomNightRooms prevRoom;

	private CustomNightAnimatronic.CustomNightRooms currentRoom;

	private GameObject prefab;

	public CustomNightAnimatronicAI(CustomNightAnimatronic animData, CustomNightController control)
	{
		data = animData;
		AIValue = data.InitialAIValue;
		currentRoom = data.originRoom;
		prevRoom = data.originRoom;
		controller = control;
		CreatePrefab();
	}

	public void ThreeAM()
	{
		AIValue = Mathf.Min(20, AIValue + data.ThreeAMValueBoost);
	}

	public void MovementOpportunity()
	{
		List<CustomNightAnimatronic.CustomNightRooms> list = new List<CustomNightAnimatronic.CustomNightRooms>();
		foreach (CustomNightAnimatronic.CustomNightRooms item in CustomNightAnimatronic.possibleRooms[currentRoom])
		{
			switch (item)
			{
			case CustomNightAnimatronic.CustomNightRooms.Stage:
				list.Add(item);
				break;
			case CustomNightAnimatronic.CustomNightRooms.DiningArea:
				list.Add(item);
				break;
			case CustomNightAnimatronic.CustomNightRooms.Kitchen:
				if (data.CanGoKitchen && prevRoom != CustomNightAnimatronic.CustomNightRooms.Kitchen)
				{
					list.Add(item);
				}
				break;
			case CustomNightAnimatronic.CustomNightRooms.Restrooms:
				if (data.CanGoRestrooms && prevRoom != CustomNightAnimatronic.CustomNightRooms.Restrooms)
				{
					list.Add(item);
				}
				break;
			case CustomNightAnimatronic.CustomNightRooms.Backstage:
				if (data.CanGoBackstage && prevRoom != CustomNightAnimatronic.CustomNightRooms.Backstage)
				{
					list.Add(item);
				}
				break;
			case CustomNightAnimatronic.CustomNightRooms.Closet:
				if (data.CanGoCloset && prevRoom != CustomNightAnimatronic.CustomNightRooms.Closet)
				{
					list.Add(item);
				}
				break;
			case CustomNightAnimatronic.CustomNightRooms.WestHall:
				list.Add(item);
				break;
			case CustomNightAnimatronic.CustomNightRooms.EastHall:
				list.Add(item);
				break;
			case CustomNightAnimatronic.CustomNightRooms.WestCorner:
				list.Add(item);
				break;
			case CustomNightAnimatronic.CustomNightRooms.EastCorner:
				list.Add(item);
				break;
			case CustomNightAnimatronic.CustomNightRooms.Office:
				if (currentRoom == CustomNightAnimatronic.CustomNightRooms.WestCorner)
				{
					list.Add(item);
				}
				else if (currentRoom == CustomNightAnimatronic.CustomNightRooms.EastCorner)
				{
					list.Add(item);
				}
				break;
			case CustomNightAnimatronic.CustomNightRooms.PirateCove:
				list.Add(item);
				break;
			case CustomNightAnimatronic.CustomNightRooms.DiningAreaWest:
				if (!data.EastPath)
				{
					list.Add(item);
				}
				break;
			case CustomNightAnimatronic.CustomNightRooms.DiningAreaEast:
				if (data.EastPath)
				{
					list.Add(item);
				}
				break;
			case CustomNightAnimatronic.CustomNightRooms.PirateCove2:
				list.Add(item);
				break;
			case CustomNightAnimatronic.CustomNightRooms.PirateCove3:
				list.Add(item);
				break;
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		int num = Random.Range(1, 21);
		if (AIValue >= num)
		{
			if (list.Count == 1)
			{
				MoveToRoom(list[0]);
			}
			else
			{
				MoveToRoom(list[Random.Range(0, list.Count)]);
			}
		}
	}

	private void Pushback()
	{
		Debug.Log(data.Id + " is pushbacked");
		MoveToRoom(data.pushbackRoom);
	}

	private void MoveToRoom(CustomNightAnimatronic.CustomNightRooms room)
	{
		if (controller.camUp && CustomNightAnimatronic.StunLockRooms.Contains(currentRoom))
		{
			if (currentRoom == controller.currentCamera)
			{
				Debug.Log(data.Id + " is cam-locked in " + currentRoom);
				return;
			}
			if (currentRoom == CustomNightAnimatronic.CustomNightRooms.PirateCove2 && controller.currentCamera == CustomNightAnimatronic.CustomNightRooms.PirateCove)
			{
				Debug.Log(data.Id + " is cam-locked in " + currentRoom);
				return;
			}
			if (currentRoom == CustomNightAnimatronic.CustomNightRooms.PirateCove3 && controller.currentCamera == CustomNightAnimatronic.CustomNightRooms.PirateCove)
			{
				Debug.Log(data.Id + " is cam-locked in " + currentRoom);
				return;
			}
		}
		if (room == CustomNightAnimatronic.CustomNightRooms.Office)
		{
			if (currentRoom == CustomNightAnimatronic.CustomNightRooms.WestCorner && controller.LeftDoorClosed)
			{
				Pushback();
				return;
			}
			if (currentRoom == CustomNightAnimatronic.CustomNightRooms.EastCorner && controller.RightDoorClosed)
			{
				Pushback();
				return;
			}
			if (data.Id != "Foxy" && !controller.camUp)
			{
				Debug.Log(data.Id + " is waiting for cam up in " + currentRoom);
				return;
			}
		}
		Debug.Log(data.Id + " is moving to " + room.ToString() + " from " + currentRoom);
		prevRoom = currentRoom;
		currentRoom = room;
		if (currentRoom == CustomNightAnimatronic.CustomNightRooms.Office)
		{
			SetPrefabLocation(currentRoom);
			Jumpscare();
		}
		else
		{
			SetPrefabLocation(currentRoom);
		}
	}

	private void Jumpscare()
	{
		controller.FinishNight(didDie: true);
	}

	private void CreatePrefab()
	{
		MasterDomain.GetDomain().GameAssetManagementDomain.AssetCacheAccess.Instantiate(data.Bundle, data.Prefab, PrefabSuccess, PrefabFail);
	}

	private void PrefabSuccess(GameObject obj)
	{
		prefab = obj;
		SetPrefabLocation(currentRoom);
	}

	private void PrefabFail()
	{
		Debug.LogError("failed to load animatronic prefab for bundle " + data.Bundle + " asset " + data.Prefab);
	}

	private void SetPrefabLocation(CustomNightAnimatronic.CustomNightRooms room)
	{
		if (prefab != null)
		{
			prefab.transform.position = controller.roomTransforms[(int)(room - 1)].position;
			prefab.transform.rotation = controller.roomTransforms[(int)(room - 1)].rotation;
		}
	}
}
