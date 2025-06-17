using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class CachingWebFileSource.MemoryCacheAsyncRequest : IAsyncRequest
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string <RequestUrl>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string RequestUrl { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsCompleted { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Utilities.HttpRequestType RequestType { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_RequestUrl()
    {
        return (string)this.<RequestUrl>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_RequestUrl(string value)
    {
        this.<RequestUrl>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CachingWebFileSource.MemoryCacheAsyncRequest(string requestUrl)
    {
        this.<RequestUrl>k__BackingField = requestUrl;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsCompleted()
    {
        return true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Utilities.HttpRequestType get_RequestType()
    {
        return 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Cancel()
    {
    
    }

}
