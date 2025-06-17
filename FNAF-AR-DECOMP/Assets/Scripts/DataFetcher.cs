using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DataFetcher : ScriptableObject
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected Mapbox.Unity.MapboxAccess _fileSource;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnEnable()
    {
        this._fileSource = Mapbox.Unity.MapboxAccess.Instance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DataFetcher()
    {
    
    }

}
