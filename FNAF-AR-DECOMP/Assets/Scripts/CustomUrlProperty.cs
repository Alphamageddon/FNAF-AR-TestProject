using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
[Serializable]
public class CustomUrlProperty
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string UrlName;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool UseCustomUrl;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Url;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CustomUrlProperty(string urlName)
    {
        this.UrlName = "";
        this.Url = "";
        this.UrlName = urlName;
    }

}
