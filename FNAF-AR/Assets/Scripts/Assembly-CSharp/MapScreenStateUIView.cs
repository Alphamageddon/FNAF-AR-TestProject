using System.Collections.Generic;
using UnityEngine;

public class MapScreenStateUIView : MonoBehaviour
{
	[SerializeField]
	private MapScreenButton prefab;

	[SerializeField]
	private Transform naturalParent;

	[SerializeField]
	private Transform friendsParent;

	private Dictionary<string, MapScreenButton> buttons = new Dictionary<string, MapScreenButton>();

	private List<string> mapEntitiesWithButtons = new List<string>();

	private void OnEnable()
	{
		MasterDomain.GetDomain().eventExposer.add_MapEntitiesModelsUpdated(EventExposer_MapEntitiesModelsUpdated);
		MasterDomain.GetDomain().ServerDomain.playerDataRequester.GetPlayerData(PlayerDataError);
	}

	private void PlayerDataError(ServerData reponse)
	{
		Debug.LogError("Couldnt get player data heres the error ig: " + reponse.JSON);
	}

	private void MapEntitiesReceived(IEnumerable<MapEntitySynchronizeableState> eh)
	{
		MasterDomain.GetDomain().MapEntityDomain.RequestNewModels();
	}

	private void OnDisable()
	{
		MasterDomain.GetDomain().eventExposer.remove_MapEntitiesModelsUpdated(EventExposer_MapEntitiesModelsUpdated);
		ClearAllButtons();
	}

	private void EventExposer_MapEntitiesModelsUpdated(IEnumerable<MapEntity> entities)
	{
		List<string> list = new List<string>(buttons.Keys);
		foreach (MapEntity entity in entities)
		{
			list.Remove(entity.EntityId);
			CreateEntityButton(entity);
		}
		foreach (string item in list)
		{
			ClearButton(buttons[item]);
		}
	}

	private void CreateEntityButton(MapEntity entity)
	{
		foreach (string key in buttons.Keys)
		{
			if (key == entity.EntityId)
			{
				return;
			}
		}
		MasterDomain domain = MasterDomain.GetDomain();
		if (entity.SynchronizeableState.history.sourceFeature != "SentFromFriend")
		{
			MapScreenButton mapScreenButton = Object.Instantiate(prefab, naturalParent, worldPositionStays: false);
			mapScreenButton.Setup(entity, domain.GameAssetManagementDomain, domain.ItemDefinitionDomain.ItemDefinitions);
			buttons.Add(entity.EntityId, mapScreenButton);
		}
		else
		{
			MapScreenButton mapScreenButton2 = Object.Instantiate(prefab, friendsParent, worldPositionStays: false);
			mapScreenButton2.Setup(entity, domain.GameAssetManagementDomain, domain.ItemDefinitionDomain.ItemDefinitions);
			buttons.Add(entity.EntityId, mapScreenButton2);
		}
	}

	private void ClearButton(MapScreenButton button)
	{
		RemoveButton(button);
	}

	private void RemoveButton(MapScreenButton button)
	{
		if (button != null)
		{
			buttons.Remove(button.entityData.EntityId);
			button.Teardown();
		}
	}

	private void ClearAllButtons()
	{
		List<MapScreenButton> list = new List<MapScreenButton>();
		foreach (MapScreenButton value in buttons.Values)
		{
			list.Add(value);
		}
		foreach (MapScreenButton item in list)
		{
			RemoveButton(item);
		}
		buttons.Clear();
		list.Clear();
		list = null;
	}
}
