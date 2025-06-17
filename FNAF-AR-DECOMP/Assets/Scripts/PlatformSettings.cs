using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public abstract class AkWwiseInitializationSettings.PlatformSettings : AkCommonPlatformSettings
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<string> IgnorePropertyNameList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.List<string> GlobalPropertyNameList;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.HashSet<string> _GlobalPropertyHashSet;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.HashSet<string> GlobalPropertyHashSet { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void IgnorePropertyValue(string propertyPath)
    {
        if((this.IsPropertyIgnored(propertyPath:  propertyPath)) != false)
        {
                return;
        }
        
        this.IgnorePropertyNameList.Add(item:  propertyPath);
        this.SetUseGlobalPropertyValue(propertyPath:  propertyPath, use:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsPropertyIgnored(string propertyPath)
    {
        if(this.IgnorePropertyNameList != null)
        {
                return this.IgnorePropertyNameList.Contains(item:  propertyPath);
        }
        
        return this.IgnorePropertyNameList.Contains(item:  propertyPath);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected AkWwiseInitializationSettings.PlatformSettings()
    {
        var val_3;
        this.IgnorePropertyNameList = new System.Collections.Generic.List<System.String>();
        this.GlobalPropertyNameList = new System.Collections.Generic.List<System.String>();
        val_3 = null;
        val_3 = null;
        this.SetGlobalPropertyValues(enumerable:  AkWwiseInitializationSettings.AllGlobalValues);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetUseGlobalPropertyValue(string propertyPath, bool use)
    {
        if(((this.IsUsingGlobalPropertyValue(propertyPath:  propertyPath)) ^ use) == false)
        {
                return;
        }
        
        if(this.GlobalPropertyNameList == null)
        {
            goto label_2;
        }
        
        if(use == false)
        {
            goto label_3;
        }
        
        label_5:
        this.GlobalPropertyNameList.Add(item:  propertyPath);
        goto label_4;
        label_2:
        if(use == true)
        {
            goto label_5;
        }
        
        label_3:
        bool val_3 = this.GlobalPropertyNameList.Remove(item:  propertyPath);
        label_4:
        this._GlobalPropertyHashSet = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetGlobalPropertyValues(System.Collections.IEnumerable enumerable)
    {
        var val_17;
        string val_20;
        var val_21;
        var val_22;
        var val_19 = 0;
        val_19 = val_19 + 1;
        System.Collections.IEnumerator val_2 = enumerable.GetEnumerator();
        val_17 = 1152921504685174784;
        label_21:
        var val_20 = 0;
        val_20 = val_20 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_21 = 0;
        val_21 = val_21 + 1;
        object val_6 = val_2.Current;
        if(val_6 != null)
        {
                var val_7 = (null == null) ? (val_6) : 0;
        }
        else
        {
                val_20 = 0;
        }
        
        if((this.IsUsingGlobalPropertyValue(propertyPath:  val_20)) == true)
        {
            goto label_21;
        }
        
        this.GlobalPropertyNameList.Add(item:  val_20);
        goto label_21;
        label_11:
        val_21 = 0;
        val_22 = 69;
        if(val_2 != null)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            val_2.Dispose();
        }
        
        if( == 69)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_21 = ???;
        val_22 = ???;
        val_17 = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsUsingGlobalPropertyValue(string propertyPath)
    {
        if(this.GlobalPropertyNameList != null)
        {
                return this.GlobalPropertyNameList.Contains(item:  propertyPath);
        }
        
        return this.GlobalPropertyNameList.Contains(item:  propertyPath);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.HashSet<string> get_GlobalPropertyHashSet()
    {
        System.Collections.Generic.HashSet<System.String> val_2 = this._GlobalPropertyHashSet;
        if(val_2 != null)
        {
                return val_2;
        }
        
        System.Collections.Generic.HashSet<System.String> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.HashSet<System.String>(collection:  this.GlobalPropertyNameList);
        this._GlobalPropertyHashSet = val_2;
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_GlobalPropertyHashSet(System.Collections.Generic.HashSet<string> value)
    {
        this._GlobalPropertyHashSet = value;
    }

}
