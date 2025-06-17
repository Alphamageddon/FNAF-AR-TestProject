using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class PrefabChildSpawner : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject domain;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private PrefabChild prefabChild;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        if(this.prefabChild != 0)
        {
                0 = UnityEngine.Object.Instantiate<PrefabChild>(original:  this.prefabChild, parent:  this.transform);
        }
        
        if(this.domain == 0)
        {
                return;
        }
        
        if(0 == null)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_3.domain = this.domain;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PrefabChildSpawner()
    {
    
    }

}
