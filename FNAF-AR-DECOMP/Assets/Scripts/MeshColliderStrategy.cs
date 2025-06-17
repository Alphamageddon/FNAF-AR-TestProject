using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ColliderModifier.MeshColliderStrategy : ColliderModifier.IColliderStrategy
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.MeshCollider> _colliders;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ColliderModifier.MeshColliderStrategy()
    {
        this._colliders = new System.Collections.Generic.Dictionary<UnityEngine.GameObject, UnityEngine.MeshCollider>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void AddColliderTo(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve)
    {
        if((this._colliders.ContainsKey(key:  ve.GameObject)) != false)
        {
                this._colliders.Item[ve.GameObject].sharedMesh = ve.Mesh;
            return;
        }
        
        this._colliders.Add(key:  ve.GameObject, value:  ve.GameObject.AddComponent<UnityEngine.MeshCollider>());
    }

}
