using UnityEngine;

public class FazWrenchConduit : MonoBehaviour
{
	[SerializeField]
	private Material offGlow;

	private Animator animator;

	private MasterDomain masterDomain;

	private AudioPlayer audioPlayer;

	private MeshRenderer rend;

	private bool justUsed;

	private bool givenReward;

	private void Start()
	{
		animator = GetComponent<Animator>();
		rend = GetComponent<MeshRenderer>();
		GetComponent<CustomAnimationEventScript>().AnimEvent += OnAnimationEvent;
		masterDomain = MasterDomain.GetDomain();
		audioPlayer = masterDomain.GameAudioDomain.AudioPlayer;
		if (PlayerPrefs.GetInt("FazWrenchUsed") == 1)
		{
			animator.SetBool("PlayerPrefsUsed", value: true);
			Material[] materials = new Material[2]
			{
				rend.materials[0],
				offGlow
			};
			rend.materials = materials;
		}
	}

	private void OnMouseDown()
	{
		InteractFazWrench();
	}

	public void InteractFazWrench()
	{
		if (PlayerPrefs.GetInt("FazWrenchUsed") == 1 || justUsed)
		{
			Fail();
			return;
		}
		TrophyInventory trophyInventory = masterDomain.WorkshopDomain.Inventory.TrophyInventory;
		if (trophyInventory.entries.ContainsKey("FazWrench") && trophyInventory.entries["FazWrench"] > 0)
		{
			Use();
		}
		else
		{
			Fail();
		}
	}

	private void Fail()
	{
		audioPlayer.RaiseGameEventForMode(AudioEventName.UIWorkshopAnimatronicLockedTapped, AudioMode.Global);
	}

	private void Use()
	{
		justUsed = true;
		PlayerPrefs.SetInt("FazWrenchUsed", 1);
		animator.SetBool("ConduitUsed", value: true);
	}

	private void OnAnimationEvent(string eventId)
	{
		if (!(eventId == "ShatterGlass"))
		{
			if (eventId == "GiveReward" && !givenReward)
			{
				givenReward = true;
				masterDomain.ServerDomain.grantItemRequester.GrantPlayerItem("MXES_Mod");
			}
		}
		else
		{
			audioPlayer.RaiseGameEventForMode(AudioEventName.GlassShatter, AudioMode.Global);
			Material[] materials = new Material[2]
			{
				rend.materials[0],
				offGlow
			};
			rend.materials = materials;
		}
	}
}
