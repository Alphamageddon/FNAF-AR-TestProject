using UnityEngine;
using UnityEngine.UI;

public class ScavengingSelectButton : MonoBehaviour
{
	[SerializeField]
	private Image portraitImage;

	public ScavengingEntity entityData;

	public void Setup(ScavengingEntity entity, GameAssetManagementDomain assetManagement, ItemDefinitions itemDefinitions)
	{
		entityData = entity;
		PlushSuitData plushSuitById = itemDefinitions.GetPlushSuitById(entityData.PlushSuitId);
		if (plushSuitById != null)
		{
			assetManagement.IconLookupAccess.GetIcon(IconGroup.Portrait, plushSuitById.PortraitIconName, IconRetrieved);
		}
	}

	public void Teardown()
	{
		entityData = null;
		Object.Destroy(base.gameObject);
	}

	public void ButtonPress()
	{
		MasterDomain.GetDomain().eventExposer.OnOrtonScavengingEncounterMapEntityChosen(entityData);
	}

	private void IconRetrieved(Sprite sprite)
	{
		portraitImage.overrideSprite = sprite;
		base.gameObject.SetActive(value: true);
	}
}
