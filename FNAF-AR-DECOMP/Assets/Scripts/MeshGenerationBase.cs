using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class MeshGenerationBase : MeshModifier, IReplaceable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria> <Criteria>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria> Criteria { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria> get_Criteria()
    {
        return (System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria>)this.<Criteria>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Criteria(System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria> value)
    {
        this.<Criteria>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void Initialize()
    {
        this.Initialize();
        this.<Criteria>k__BackingField = new System.Collections.Generic.HashSet<Mapbox.Unity.MeshGeneration.Modifiers.IReplacementCriteria>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MeshGenerationBase()
    {
    
    }

}
