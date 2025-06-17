using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SROptions
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly SROptions _current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private SROptionsPropertyChanged PropertyChanged;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static SROptions Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static SROptions get_Current()
    {
        null = null;
        return (SROptions)SROptions._current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void add_PropertyChanged(SROptionsPropertyChanged value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.PropertyChanged, b:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.PropertyChanged != 1152921519009041312);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void remove_PropertyChanged(SROptionsPropertyChanged value)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.PropertyChanged, value:  value);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.PropertyChanged != 1152921519009177888);
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnPropertyChanged(string propertyName)
    {
        if(this.PropertyChanged == null)
        {
                return;
        }
        
        this.PropertyChanged.Invoke(sender:  this, propertyName:  propertyName);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SROptions()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static SROptions()
    {
        SROptions._current = new SROptions();
    }

}
