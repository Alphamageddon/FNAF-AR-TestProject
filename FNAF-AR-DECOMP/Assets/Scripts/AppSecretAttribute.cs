using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AppSecretAttribute : PropertyAttribute
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string <Name>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Name { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Name()
    {
        return (string)this.<Name>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Name(string value)
    {
        this.<Name>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppSecretAttribute()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AppSecretAttribute(string name)
    {
        this.<Name>k__BackingField = name;
    }

}
