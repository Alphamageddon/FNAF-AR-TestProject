using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private class Runnable.Routine : IEnumerator
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <ID>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <Stop>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool m_bMoveNext;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.IEnumerator m_Enumerator;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int ID { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Stop { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public object Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int get_ID()
    {
        return (int)this.<ID>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_ID(int value)
    {
        this.<ID>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_Stop()
    {
        return (bool)this.<Stop>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Stop(bool value)
    {
        this.<Stop>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Runnable.Routine(System.Collections.IEnumerator a_enumerator)
    {
        var val_5;
        int val_6;
        this.m_Enumerator = a_enumerator;
        UnityEngine.Coroutine val_2 = Mapbox.Unity.Utilities.Runnable.Instance.StartCoroutine(routine:  this);
        this.<Stop>k__BackingField = false;
        val_5 = Mapbox.Unity.Utilities.Runnable.Instance;
        if(val_5 != null)
        {
                val_6 = val_3.m_NextRoutineId;
        }
        else
        {
                val_5 = 32;
            val_6 = 64;
        }
        
        mem[32] = 65;
        this.<ID>k__BackingField = 64;
        Mapbox.Unity.Utilities.Runnable val_4 = Mapbox.Unity.Utilities.Runnable.Instance;
        val_4.m_Routines.set_Item(key:  this.<ID>k__BackingField, value:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public object get_Current()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.m_Enumerator.Current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool MoveNext()
    {
        var val_7;
        var val_7 = 0;
        val_7 = val_7 + 1;
        bool val_2 = this.m_Enumerator.MoveNext();
        this.m_bMoveNext = val_2;
        if(val_2 != false)
        {
                if((this.<Stop>k__BackingField) != false)
        {
                this.m_bMoveNext = false;
        }
        else
        {
                if(val_2 != false)
        {
                val_7 = 1;
            return (bool)(this.m_bMoveNext == true) ? 1 : 0;
        }
        
        }
        
        }
        
        Mapbox.Unity.Utilities.Runnable val_4 = Mapbox.Unity.Utilities.Runnable.Instance;
        bool val_5 = val_4.m_Routines.Remove(key:  this.<ID>k__BackingField);
        return (bool)(this.m_bMoveNext == true) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Reset()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.m_Enumerator.Reset();
    }

}
