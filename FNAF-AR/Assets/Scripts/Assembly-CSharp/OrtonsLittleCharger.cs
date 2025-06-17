using Animatronics.Animatronic3d.Model;
using UnityEngine;

[RequireComponent(typeof(OrtonsLittleOverrider))]
public class OrtonsLittleCharger : MonoBehaviour
{
	[Header("Activate Charge")]
	public bool Charge;

	[Header("Settings")]
	public float Seconds = 1f;

	public float ShockWindow = 0.8f;

	public bool Jumpscare;

	public bool PlayJumpscareAnimation;

	[Header("Debug")]
	public float JumpscareRange;

	public float DecloakRange;

	public float CloakRange;

	public bool Charging;

	private OrtonsLittleOverrider lilOverrider;

	private bool StartedCloak;

	private bool StartedDecloak;

	private void Update()
	{
		if (lilOverrider == null)
		{
			lilOverrider = GetComponent<OrtonsLittleOverrider>();
			return;
		}
		lilOverrider.Charging = Charging;
		if (Charge)
		{
			Charge = false;
			Charging = true;
			JumpscareRange = lilOverrider.modelConfig.MovementSettings.DelayedJumpscareDistance;
			DecloakRange = lilOverrider.modelConfig.CloakSettings.ShockWindowOpenTime * lilOverrider.modelConfig.MovementSettings.AnimatedSpeed + (ShockWindow * lilOverrider.modelConfig.MovementSettings.AnimatedSpeed + JumpscareRange);
			CloakRange = JumpscareRange + lilOverrider.modelConfig.CloakSettings.CloakTime * lilOverrider.modelConfig.MovementSettings.AnimatedSpeed;
			if (!Jumpscare)
			{
				JumpscareRange = 0f;
				DecloakRange = lilOverrider.modelConfig.MovementSettings.ChargeFeintDistance;
				CloakRange = 0f;
			}
			StartedCloak = false;
			StartedDecloak = false;
			lilOverrider.modelConfig.Animator.ResetTrigger("ChargeEnd");
			lilOverrider.modelConfig.Animator.SetTrigger("Charge");
			lilOverrider.SetCloakState(cloakEnabled: true);
			lilOverrider.SetEyeCloakState(eyeCloakEnabled: false);
			lilOverrider.matController.SetEyeGlow(eyeGlowEnabled: true);
			base.transform.localPosition = new Vector3(0f, 0f, 30f);
			TeleportAtCurrentAngle(Seconds * lilOverrider.modelConfig.MovementSettings.AnimatedSpeed + DecloakRange);
		}
		if (!Charging)
		{
			return;
		}
		MoveTowardOrigin();
		if (GetDistanceFromLocalOrigin() <= JumpscareRange)
		{
			HandleJumpscare();
			return;
		}
		if (!StartedCloak && GetDistanceFromLocalOrigin() <= CloakRange)
		{
			StartedCloak = true;
			lilOverrider.BeginCloak();
			lilOverrider.BeginEyeCloak();
		}
		if (!StartedDecloak && GetDistanceFromLocalOrigin() <= DecloakRange)
		{
			if (!Jumpscare)
			{
				EndCharge();
				return;
			}
			StartedDecloak = true;
			lilOverrider.BeginDecloak();
		}
	}

	private void HandleJumpscare()
	{
		if (PlayJumpscareAnimation)
		{
			lilOverrider.Jumpscare();
		}
		EndCharge();
	}

	private void EndCharge()
	{
		Charging = false;
		base.transform.localPosition = Vector3.zero;
		lilOverrider.modelConfig.Animator.ResetTrigger("Charge");
		lilOverrider.modelConfig.Animator.SetTrigger("ChargeEnd");
		lilOverrider.SetCloakState(cloakEnabled: false);
		lilOverrider.SetEyeCloakState(eyeCloakEnabled: false);
	}

	public float GetDistanceFromLocalOrigin()
	{
		return base.transform.localPosition.magnitude;
	}

	public void TeleportAtCurrentAngle(float distanceFromCamera)
	{
		base.transform.localPosition = base.transform.localPosition.normalized * distanceFromCamera;
		base.transform.forward = -base.transform.localPosition;
	}

	public bool MoveTowardOrigin()
	{
		Debug.Log("Movement speed is " + lilOverrider.modelConfig.MovementSettings.AnimatedSpeed);
		float num = lilOverrider.modelConfig.MovementSettings.AnimatedSpeed * Time.deltaTime;
		if (num < GetDistanceFromLocalOrigin())
		{
			Vector3 translation = (Vector3.zero - base.transform.localPosition).normalized * num;
			base.transform.Translate(translation, Space.World);
			base.transform.forward = -base.transform.localPosition;
			return false;
		}
		EndCharge();
		return true;
	}
}
