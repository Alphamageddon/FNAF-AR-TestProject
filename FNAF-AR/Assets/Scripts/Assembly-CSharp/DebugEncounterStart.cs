using UnityEngine;

public class DebugEncounterStart : MonoBehaviour
{
	public GyroCamera gyro;

	public EditorMouseControls editormouse;

	public FirstPersonCameraRotation fps;

	public EscToggleMouse esc;

	private bool clicked;

	public void EncounterStart()
	{
		if (!clicked)
		{
			clicked = true;
			MasterDomain domain = MasterDomain.GetDomain();
			Debug.LogError("IMPORTANT: ActiveMapEntity IS " + ((domain.TheGameDomain.ActiveMapEntity == null) ? "NULL!" : "NOT NULL."));
			domain.eventExposer.OnAnimatronicEncounterStarted(domain.TheGameDomain.ActiveMapEntity);
			Debug.LogError("IMPORTANT! START BUTTON HAS JUST STARTED ENCOUNTER");
			base.gameObject.SetActive(value: false);
		}
	}
}
