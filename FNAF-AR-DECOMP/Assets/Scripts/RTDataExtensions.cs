using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class RTDataExtensions
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static GameSparks.RT.RTData SetVector2(GameSparks.RT.RTData data, uint index, UnityEngine.Vector2 vector2)
    {
        GameSparks.RT.RTData val_1 = data.SetRTVector(index:  index, value:  new GameSparks.RT.RTVector() {x = new System.Nullable<System.Single>() {HasValue = true}, y = new System.Nullable<System.Single>() {HasValue = true}, z = new System.Nullable<System.Single>() {HasValue = true}, w = new System.Nullable<System.Single>() {HasValue = true}});
        return (GameSparks.RT.RTData)data;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Nullable<UnityEngine.Vector2> GetVector2(GameSparks.RT.RTData data, uint index)
    {
        var val_4;
        float val_7;
        uint val_10 = index;
        System.Nullable<GameSparks.RT.RTVector> val_1 = data.GetRTVector(index:  val_10 = index);
        if(val_4.supportsTrackableAttachments == false)
        {
                return 0;
        }
        
        System.Nullable<GameSparks.RT.RTVector> val_6 = data.GetRTVector(index:  val_10);
        val_10 = 1152921517591263632;
        UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  val_7, y:  val_7);
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static GameSparks.RT.RTData SetVector3(GameSparks.RT.RTData data, uint index, UnityEngine.Vector3 vector3)
    {
        GameSparks.RT.RTData val_1 = data.SetRTVector(index:  index, value:  new GameSparks.RT.RTVector() {x = new System.Nullable<System.Single>() {HasValue = true}, y = new System.Nullable<System.Single>() {HasValue = true}, z = new System.Nullable<System.Single>() {HasValue = true}, w = new System.Nullable<System.Single>() {HasValue = true}});
        return (GameSparks.RT.RTData)data;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Nullable<UnityEngine.Vector3> GetVector3(GameSparks.RT.RTData data, uint index)
    {
        var val_4;
        uint val_9;
        var val_11;
        val_9 = index;
        System.Nullable<GameSparks.RT.RTVector> val_1 = data.GetRTVector(index:  val_9);
        val_11 = public System.Boolean System.Nullable<GameSparks.RT.RTVector>::get_HasValue();
        if(val_4.supportsTrackableAttachments == false)
        {
                return 0;
        }
        
        System.Nullable<GameSparks.RT.RTVector> val_6 = data.GetRTVector(index:  val_9);
        val_11 = public System.Boolean System.Nullable<System.Single>::get_HasValue();
        if(( & 1) == 0)
        {
                return 0;
        }
        
        val_4 = 0;
        val_11 = public System.Void System.Nullable<UnityEngine.Vector3>::.ctor(UnityEngine.Vector3 value);
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static GameSparks.RT.RTData SetVector4(GameSparks.RT.RTData data, uint index, UnityEngine.Vector4 vector4)
    {
        GameSparks.RT.RTData val_1 = data.SetRTVector(index:  index, value:  new GameSparks.RT.RTVector() {x = new System.Nullable<System.Single>() {HasValue = true}, y = new System.Nullable<System.Single>() {HasValue = true}, z = new System.Nullable<System.Single>() {HasValue = true}, w = new System.Nullable<System.Single>() {HasValue = true}});
        return (GameSparks.RT.RTData)data;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Nullable<UnityEngine.Vector4> GetVector4(GameSparks.RT.RTData data, uint index)
    {
        var val_4;
        var val_9;
        var val_11;
        val_9 = data;
        System.Nullable<GameSparks.RT.RTVector> val_1 = val_9.GetRTVector(index:  index);
        bool val_5 = val_4.supportsTrackableAttachments;
        if(val_5 != false)
        {
                System.Nullable<GameSparks.RT.RTVector> val_6 = val_9.GetRTVector(index:  index);
            val_11;
            if((val_11 & 1) != 0)
        {
                val_4 = 0;
            val_11 = X8;
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            return (System.Nullable<UnityEngine.Vector4>)val_5;
        }
        
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        return (System.Nullable<UnityEngine.Vector4>)val_5;
    }

}
