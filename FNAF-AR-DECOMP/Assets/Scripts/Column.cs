using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TableMapping.Column
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Reflection.PropertyInfo _prop;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string <Name>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Type <ColumnType>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string <Collation>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <IsAutoInc>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <IsAutoGuid>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <IsPK>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.IEnumerable<SQLite4Unity3d.IndexedAttribute> <Indices>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool <IsNullable>k__BackingField;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Nullable<int> <MaxStringLength>k__BackingField;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Name { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string PropertyName { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Type ColumnType { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Collation { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsAutoInc { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsAutoGuid { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsPK { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.IEnumerable<SQLite4Unity3d.IndexedAttribute> Indices { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsNullable { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Nullable<int> MaxStringLength { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Name()
    {
        return (string)this.<Name>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_Name(string value)
    {
        this.<Name>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_PropertyName()
    {
        if(this._prop == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Type get_ColumnType()
    {
        return (System.Type)this.<ColumnType>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_ColumnType(System.Type value)
    {
        this.<ColumnType>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Collation()
    {
        return (string)this.<Collation>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_Collation(string value)
    {
        this.<Collation>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsAutoInc()
    {
        return (bool)this.<IsAutoInc>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_IsAutoInc(bool value)
    {
        this.<IsAutoInc>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsAutoGuid()
    {
        return (bool)this.<IsAutoGuid>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_IsAutoGuid(bool value)
    {
        this.<IsAutoGuid>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsPK()
    {
        return (bool)this.<IsPK>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_IsPK(bool value)
    {
        this.<IsPK>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.IEnumerable<SQLite4Unity3d.IndexedAttribute> get_Indices()
    {
        return (System.Collections.Generic.IEnumerable<SQLite4Unity3d.IndexedAttribute>)this.<Indices>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Indices(System.Collections.Generic.IEnumerable<SQLite4Unity3d.IndexedAttribute> value)
    {
        this.<Indices>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_IsNullable()
    {
        return (bool)this.<IsNullable>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_IsNullable(bool value)
    {
        this.<IsNullable>k__BackingField = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Nullable<int> get_MaxStringLength()
    {
        return (System.Nullable<System.Int32>)this.<MaxStringLength>k__BackingField;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void set_MaxStringLength(System.Nullable<int> value)
    {
        this.<MaxStringLength>k__BackingField = value.HasValue;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TableMapping.Column(System.Reflection.PropertyInfo prop, SQLite4Unity3d.CreateFlags createFlags = 0)
    {
        var val_21;
        System.Type val_22;
        var val_23;
        bool val_24;
        var val_25;
        bool val_26;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        val_21 = public static System.Object System.Linq.Enumerable::FirstOrDefault<System.Object>(System.Collections.Generic.IEnumerable<TSource> source);
        if((System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  prop)) != null)
        {
                val_21 = 0;
        }
        
        this._prop = prop;
        this.<Name>k__BackingField = prop;
        if((System.Nullable.GetUnderlyingType(nullableType:  prop)) == null)
        {
                val_22 = prop;
        }
        
        this.<ColumnType>k__BackingField = val_22;
        this.<Collation>k__BackingField = SQLite4Unity3d.Orm.Collation(p:  prop);
        if((SQLite4Unity3d.Orm.IsPK(p:  prop)) != false)
        {
                val_23 = 1;
        }
        else
        {
                if((createFlags & 1) == 0)
        {
                val_23 = 0;
        }
        
        }
        
        this.<IsPK>k__BackingField = ((System.String.Compare(strA:  prop, strB:  "Id", comparisonType:  5)) == 0) ? 1 : 0;
        if((SQLite4Unity3d.Orm.IsAutoInc(p:  prop)) != true)
        {
                if(((createFlags & 4) == 0) || ((this.<IsPK>k__BackingField) == false))
        {
            goto label_14;
        }
        
        }
        
        bool val_13 = System.Type.op_Equality(left:  this.<ColumnType>k__BackingField, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        this.<IsAutoGuid>k__BackingField = val_13;
        val_24 = val_13 ^ 1;
        val_25 = 1;
        goto label_17;
        label_14:
        val_25 = 0;
        val_24 = false;
        this.<IsAutoGuid>k__BackingField = false;
        label_17:
        val_24 = val_24 | val_25;
        this.<IsAutoInc>k__BackingField = val_24;
        System.Collections.Generic.IEnumerable<SQLite4Unity3d.IndexedAttribute> val_14 = SQLite4Unity3d.Orm.GetIndices(p:  prop);
        this.<Indices>k__BackingField = val_14;
        if((System.Linq.Enumerable.Any<SQLite4Unity3d.IndexedAttribute>(source:  val_14)) == false)
        {
            goto label_18;
        }
        
        label_29:
        label_22:
        if((this.<IsPK>k__BackingField) == false)
        {
            goto label_19;
        }
        
        val_26 = 0;
        goto label_20;
        label_18:
        if(((createFlags & 2) == 0) || ((this.<IsPK>k__BackingField) == true))
        {
            goto label_22;
        }
        
        if((this.<Name>k__BackingField.EndsWith(value:  "Id", comparisonType:  5)) == false)
        {
            goto label_29;
        }
        
        SQLite4Unity3d.IndexedAttribute[] val_17 = new SQLite4Unity3d.IndexedAttribute[1];
        val_17[0] = new SQLite4Unity3d.IndexedAttribute();
        this.<Indices>k__BackingField = val_17;
        goto label_29;
        label_19:
        val_26 = (~(SQLite4Unity3d.Orm.IsMarkedNotNull(p:  prop))) & 1;
        label_20:
        this.<IsNullable>k__BackingField = val_26;
        System.Nullable<System.Int32> val_20 = SQLite4Unity3d.Orm.MaxStringLength(p:  prop);
        this.<MaxStringLength>k__BackingField = val_20;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetValue(object obj, object val)
    {
        if(this._prop == null)
        {
            
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public object GetValue(object obj)
    {
        if(this._prop == null)
        {
            
        }
    
    }

}
