using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FeaturePointViewspaceBoxer
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool logDebugDetails;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Vector2Int numBoxes;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>>[,] cachedBoxedPoints;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<System.Collections.Generic.List<System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>>> cachedBoxedPointLists;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Camera m_Camera;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FeaturePointViewspaceBoxer(UnityEngine.Camera m_Camera)
    {
        GameSparks.RT.Proto.Key val_1 = new GameSparks.RT.Proto.Key(field:  5, wireType:  10);
        this.numBoxes = val_1.<Field>k__BackingField;
        this.cachedBoxedPointLists = new System.Collections.Generic.List<System.Collections.Generic.List<System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>>>();
        this.m_Camera = m_Camera;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void BoxPoints(UnityEngine.Vector3[] sourcePoints, out System.Collections.Generic.List<System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>>[,] boxedPoints)
    {
        var val_15;
        UnityEngine.Vector3[] val_16;
        UnityEngine.Vector2Int val_17;
        var val_18;
        System.Collections.Generic.List<System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>>[,] val_20;
        var val_21;
        var val_22;
        System.Collections.Generic.List<System.Collections.Generic.List<System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>>> val_24;
        val_16 = sourcePoints;
        if(this.cachedBoxedPoints == null)
        {
            goto label_1;
        }
        
        val_17 = this.numBoxes;
        if(((this.cachedBoxedPoints.GetLength(dimension:  0)) != val_17.x) || ((this.cachedBoxedPoints.GetLength(dimension:  1)) != val_17))
        {
            goto label_4;
        }
        
        val_15 = 0;
        goto label_5;
        label_13:
        val_18 = 0;
        goto label_6;
        label_11:
        val_18 = 1;
        this.cachedBoxedPoints[0 + (16824064 * 0)] = 0;
        label_6:
        if(val_18 < (this.cachedBoxedPoints.GetLength(dimension:  1)))
        {
            goto label_11;
        }
        
        val_15 = 1;
        label_5:
        val_20 = this.cachedBoxedPoints;
        if(val_15 < (val_20.GetLength(dimension:  0)))
        {
            goto label_13;
        }
        
        val_17 = val_17;
        goto label_14;
        label_1:
        val_17 = this.numBoxes;
        label_4:
        val_20 = val_17.x;
        this.cachedBoxedPoints = null;
        label_14:
        val_21 = 0;
        val_22 = 12;
        goto label_15;
        label_45:
        val_15 = 0;
        val_20 = 32;
        UnityEngine.Vector3 val_8 = this.m_Camera.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = 8.96831E-44f, y = 0f, z = 1.85775E-36f});
        if((((val_8.y <= 0.99f) && (val_8.y >= 0.01f)) && (val_8.x >= 0.01f)) && (val_8.x <= 0.99f))
        {
                float val_15 = (float)val_17.x;
            val_15 = val_8.x * val_15;
            float val_16 = (float)val_17;
            val_16 = val_8.y * val_16;
            System.Collections.Generic.List<System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>> val_17 = this.cachedBoxedPoints[(UnityEngine.Mathf.__il2cppRuntimeField_name * (long)(int)(val_10)) + (long)(int)(val_11)];
            val_24 = this.cachedBoxedPointLists;
            if(val_24.Count <= 0)
        {
                val_24 = this.cachedBoxedPointLists;
            val_24.Add(item:  new System.Collections.Generic.List<System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>>());
        }
        
            var val_18 = (long)UnityEngine.Mathf.FloorToInt(f:  val_15);
            val_18 = ((long)UnityEngine.Mathf.FloorToInt(f:  val_16)) + ((public System.Collections.Generic.List<UnityEngine.Vector3> System.Collections.Generic.List<System.Collections.Generic.List<UnityEngine.Vector3>>::get_Item(int index)) * val_18);
            this.cachedBoxedPoints[val_18] = this.cachedBoxedPointLists.Item[0];
            var val_19 = (long)UnityEngine.Mathf.FloorToInt(f:  val_15);
            val_19 = ((long)UnityEngine.Mathf.FloorToInt(f:  val_16)) + (this.cachedBoxedPoints * val_19);
            this.cachedBoxedPoints[val_19].Clear();
            val_16 = val_16;
            var val_21 = (long)UnityEngine.Mathf.FloorToInt(f:  val_15);
            val_21 = ((long)UnityEngine.Mathf.FloorToInt(f:  val_16)) + (16824064 * val_21);
            val_22 = 12;
            this.cachedBoxedPoints[val_21].Add(item:  new System.ValueTuple<UnityEngine.Vector3, UnityEngine.Vector3>() {Item2 = new UnityEngine.Vector3() {x = 5.813607E+13f, y = 2.524356E-29f, z = 5.792757E+13f}});
        }
        
        val_21 = 1;
        label_15:
        if(val_21 < (sourcePoints + 24))
        {
            goto label_45;
        }
        
        boxedPoints = this.cachedBoxedPoints;
    }

}
