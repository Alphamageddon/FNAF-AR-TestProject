using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class PrefabChild : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject domain;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Init(UnityEngine.GameObject receivedDomain)
    {
        this.domain = receivedDomain;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PrefabChild()
    {
    
    }

}
