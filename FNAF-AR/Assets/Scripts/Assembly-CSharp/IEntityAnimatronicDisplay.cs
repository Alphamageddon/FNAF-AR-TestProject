using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface IEntityAnimatronicDisplay
{
	MapEntity Entity { get; }

	CONFIG_DATA.MapEntities EntityConfigData { get; }

	TextMeshProUGUI EncounterButtonText { get; }

	Button JammerButton { get; }

	TextMeshProUGUI JammerButtonText { get; }

	Button CloseButton { get; }

	MonoBehaviour CoroutineRunner { get; }

	void Setup(EntityDisplayData data, IAnimatronicDisplayController controller);

	void Teardown();

	void ForceClose();

	void Encounter();

	void Jam();

	void Flee();

	void ShowAlert(string locKey, EntityAnimatronicAlertStyle alertStyle);

	void SetButtonVisibility(bool canJam, bool canEncounter, bool canClose);

	IEnumerator AnimateStatBarFill();

	float CalculateDrawerHeight();

	void ActivateLoadout(bool activate);
}
