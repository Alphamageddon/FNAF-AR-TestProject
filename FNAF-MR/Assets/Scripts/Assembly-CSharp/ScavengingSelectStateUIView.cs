using System.Collections.Generic;
using UnityEngine;

public class ScavengingSelectStateUIView : MonoBehaviour
{
	[SerializeField]
	private ScavengingSelectButton prefab;

	[SerializeField]
	private Transform prefabParent;

	private Dictionary<string, ScavengingSelectButton> buttons = new Dictionary<string, ScavengingSelectButton>();

	private List<string> scavengingEntitiesWithButtons = new List<string>();

	private void OnEnable()
	{
		MasterDomain.GetDomain().eventExposer.add_ScavengingEntitiesModelsUpdated(EventExposer_ScavengingEntitiesModelsUpdated);
		MasterDomain.GetDomain().ServerDomain.playerDataRequester.GetPlayerData(PlayerDataError);
	}

	private void PlayerDataError(ServerData reponse)
	{
		Debug.LogError("Couldnt get player data heres the error ig: " + reponse.JSON);
	}

	private void OnDisable()
	{
		MasterDomain.GetDomain().eventExposer.remove_ScavengingEntitiesModelsUpdated(EventExposer_ScavengingEntitiesModelsUpdated);
		ClearAllButtons();
	}

	private void EventExposer_ScavengingEntitiesModelsUpdated(IEnumerable<ScavengingEntity> entities)
	{
		List<string> list = new List<string>(buttons.Keys);
		foreach (ScavengingEntity entity in entities)
		{
			list.Remove(entity.EntityId);
			CreateEntityButton(entity);
		}
		foreach (string item in list)
		{
			ClearButton(buttons[item]);
		}
	}

	private void CreateEntityButton(ScavengingEntity entity)
	{
		foreach (string key in buttons.Keys)
		{
			if (key == entity.EntityId)
			{
				return;
			}
		}
		MasterDomain domain = MasterDomain.GetDomain();
		ScavengingSelectButton scavengingSelectButton = Object.Instantiate(prefab, prefabParent, worldPositionStays: false);
		scavengingSelectButton.Setup(entity, domain.GameAssetManagementDomain, domain.ItemDefinitionDomain.ItemDefinitions);
		buttons.Add(entity.EntityId, scavengingSelectButton);
	}

	private void ClearButton(ScavengingSelectButton button)
	{
		RemoveButton(button);
	}

	private void RemoveButton(ScavengingSelectButton button)
	{
		if (button != null)
		{
			buttons.Remove(button.entityData.EntityId);
			button.Teardown();
		}
	}

	private void ClearAllButtons()
	{
		List<ScavengingSelectButton> list = new List<ScavengingSelectButton>();
		foreach (ScavengingSelectButton value in buttons.Values)
		{
			list.Add(value);
		}
		foreach (ScavengingSelectButton item in list)
		{
			RemoveButton(item);
		}
		buttons.Clear();
		list.Clear();
		list = null;
	}
}
