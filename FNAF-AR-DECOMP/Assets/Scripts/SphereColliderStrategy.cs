using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ColliderModifier.SphereColliderStrategy : ColliderModifier.IColliderStrategy
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.SphereCollider> _colliders;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ColliderModifier.SphereColliderStrategy()
    {
        this._colliders = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.SphereCollider>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddColliderTo(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve)
    {
        float val_5;
        float val_9;
        UnityEngine.GameObject val_12;
        UnityEngine.SphereCollider val_13;
        val_12 = ve.GameObject;
        if((this._colliders.ContainsKey(key:  ve.GameObject)) != false)
        {
                UnityEngine.Bounds val_3 = ve.Mesh.bounds;
            this._colliders.Item[val_12].center = new UnityEngine.Vector3() {x = val_5, y = V1.16B, z = V2.16B};
            val_12 = ve.GameObject;
            val_13 = this._colliders.Item[val_12];
            UnityEngine.Bounds val_7 = ve.Mesh.bounds;
            val_13.radius = val_9;
            return;
        }
        
        val_13 = val_12.AddComponent<UnityEngine.SphereCollider>();
        this._colliders.Add(key:  val_12, value:  val_13);
    }

}
