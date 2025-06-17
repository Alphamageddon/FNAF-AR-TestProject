using UnityEngine;

namespace Game.AttackSequence.Animatronic
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class TeleportReposition
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void NormalTeleport(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard)
        {
            var val_10;
            var val_17;
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_10 = 6;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_2 = blackboard.AttackProfile;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_10 = 6;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4 = blackboard.AttackProfile;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_10 = 6;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_6 = blackboard.AttackProfile;
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_10 = 6;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_8 = blackboard.AttackProfile;
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_10 = 2;
            var val_20 = 0;
            val_20 = val_20 + 1;
            val_10 = 39;
            val_17 = public System.Void Animatronics.Animatronic3d.IAnimatronic3D::Teleport(float angleFromCamera, float distanceFromCamera, bool faceCamera);
            blackboard.Model.Teleport(angleFromCamera:  UnityEngine.Random.Range(min:  val_2.TeleportReposition.AngleFromCamera.Min, max:  val_4.TeleportReposition.AngleFromCamera.Max), distanceFromCamera:  UnityEngine.Random.Range(min:  val_6.TeleportReposition.DistanceFromCamera.Min, max:  val_8.TeleportReposition.DistanceFromCamera.Max), faceCamera:  false);
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_17 = 17;
            blackboard.ShouldCheckForDirectionChange = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void PhantomTeleport(Game.AttackSequence.Animatronic.PhaseManagement.IBlackboardPhaseAccess blackboard, float distance)
        {
            var val_6;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_6 = 6;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_2 = blackboard.AttackProfile;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_6 = 6;
            Game.ItemDefinition.Data.DataDefinitions.AttackProfile val_4 = blackboard.AttackProfile;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_6 = 2;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_6 = 39;
            blackboard.Model.Teleport(angleFromCamera:  UnityEngine.Random.Range(min:  val_2.TeleportReposition.AngleFromCamera.Min, max:  val_4.TeleportReposition.AngleFromCamera.Max), distanceFromCamera:  distance, faceCamera:  false);
        }
    
    }

}
