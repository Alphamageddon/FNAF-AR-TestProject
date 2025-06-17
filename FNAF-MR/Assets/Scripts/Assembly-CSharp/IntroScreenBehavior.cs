using UnityEngine;
using UnityEngine.UI;

public class IntroScreenBehavior : MonoBehaviour
{
	[SerializeField]
	private Animator animator;

	private AudioPlayer audioPlayer;

	public void Activate(Button button)
	{
		animator.SetTrigger("Play");
		button.onClick.AddListener(NextCard);
		audioPlayer = MasterDomain.GetDomain().GameAudioDomain.AudioPlayer;
	}

	private void NextCard()
	{
		animator.SetTrigger("Next");
		if (audioPlayer != null)
		{
			audioPlayer.RaiseGameEventForMode(AudioEventName.CameraIntroCard, AudioMode.Global);
		}
	}
}
