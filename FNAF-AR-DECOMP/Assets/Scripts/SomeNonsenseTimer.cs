using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SomeNonsenseTimer : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _gameObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float lifetime;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        UnityEngine.Object.Destroy(obj:  this._gameObject, t:  this.lifetime);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SomeNonsenseTimer()
    {
        this.lifetime = 3f;
    }

}
