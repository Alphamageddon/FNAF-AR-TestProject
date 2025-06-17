using UnityEngine;

public static class TeleportReposition
{
	public static void NormalTeleport(Blackboard blackboard)
	{
		Debug.LogWarning("Doing a normal teleport!");
		if (blackboard == null)
		{
			Debug.LogWarning("normal teleport blackboard null");
		}
		if (blackboard.Model == null)
		{
			Debug.LogWarning("normal teleport model null");
		}
		blackboard.Model.Teleport(Random.Range(blackboard.AttackProfile.TeleportReposition.AngleFromCamera.Min, blackboard.AttackProfile.TeleportReposition.AngleFromCamera.Max), Random.Range(blackboard.AttackProfile.TeleportReposition.DistanceFromCamera.Min, blackboard.AttackProfile.TeleportReposition.DistanceFromCamera.Max), faceCamera: false);
		blackboard.ShouldCheckForDirectionChange = false;
	}

	public static void PhantomTeleport(Blackboard blackboard, float distance)
	{
		blackboard.Model.Teleport(Random.Range(blackboard.AttackProfile.TeleportReposition.AngleFromCamera.Min, blackboard.AttackProfile.TeleportReposition.AngleFromCamera.Max), distance, faceCamera: false);
	}
}
