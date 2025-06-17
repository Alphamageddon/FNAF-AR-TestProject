using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class SRInstantiate
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static T Instantiate<T>(T prefab)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.GameObject Instantiate(UnityEngine.GameObject prefab)
    {
        return UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  prefab);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static T Instantiate<T>(T prefab, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation)
    {
        goto __RuntimeMethodHiddenParam + 48;
    }

}
