using System;
using UnityEngine;

[Serializable]
public class CloakSettings
{
	public Vector3 CloakedRevealPlanePosition;

	public Vector3 DecloakedRevealPlanePosition;

	public float CloakTime;

	public float DecloakTime;

	public float ShockWindowOpenTime;

	public bool ShouldUpdateEveryTime;

	public bool ShouldCloak;

	public bool ShouldDecloak;

	public bool ShouldShowEyes;

	public bool ShouldHideEyes;
}
