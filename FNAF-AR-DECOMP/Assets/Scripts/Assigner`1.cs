using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private static class ReflectionUtils.Assigner<T>
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static T Assign(ref T left, T right)
    {
        left = right;
        return (object)right;
    }

}
