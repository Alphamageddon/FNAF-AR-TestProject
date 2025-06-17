using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D : IMessage<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D>, IMessage, IEquatable<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D>, IDeepCloneable<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int BundleFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string bundle_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PrefabFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string prefab_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MapIconFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string mapIcon_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Bundle { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string Prefab { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string MapIcon { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ANIMATRONIC3D>)PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D.MapIconFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return PLUSHSUIT_DATA.Types.ARTASSETS.Descriptor.NestedTypes.Item[1];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D()
    {
        this.bundle_ = "";
        this.prefab_ = "";
        this.mapIcon_ = "";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D other)
    {
        if(other != null)
        {
                this.bundle_ = other.bundle_;
            this.prefab_ = other.prefab_;
            this.mapIcon_ = other.mapIcon_;
        }
        else
        {
                this.bundle_ = 15026800;
            this.prefab_ = 64;
            this.mapIcon_ = 69077560;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D Clone()
    {
        return (ANIMATRONIC3D)new PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Bundle()
    {
        return (string)this.bundle_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Bundle(string value)
    {
        this.bundle_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_Prefab()
    {
        return (string)this.prefab_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Prefab(string value)
    {
        this.prefab_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string get_MapIcon()
    {
        return (string)this.mapIcon_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_MapIcon(string value)
    {
        this.mapIcon_ = Google.Protobuf.ProtoPreconditions.CheckNotNull<System.String>(value:  value, name:  "value");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ANIMATRONIC3D val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D other)
    {
        var val_4;
        if(other == null)
        {
            goto label_3;
        }
        
        if(other == this)
        {
            goto label_1;
        }
        
        if((System.String.op_Inequality(a:  this.bundle_, b:  other.bundle_)) != true)
        {
                if((System.String.op_Inequality(a:  this.prefab_, b:  other.prefab_)) != true)
        {
                if((System.String.op_Inequality(a:  this.mapIcon_, b:  other.mapIcon_)) == false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        label_3:
        val_4 = 0;
        return (bool)val_4;
        label_1:
        val_4 = 1;
        return (bool)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        var val_5;
        if(this.bundle_.Length != 0)
        {
                val_4 = this.bundle_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.prefab_.Length != 0)
        {
                val_4 = this.prefab_ ^ val_4;
        }
        
        val_5 = 0;
        if(this.mapIcon_.Length != 0)
        {
                val_4 = this.mapIcon_ ^ val_4;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_4;
        }
        
        val_4 = this._unknownFields ^ val_4;
        return (int)val_4;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        string val_4;
        string val_5;
        string val_6;
        if(this.bundle_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_4 = this.bundle_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_4 = this.bundle_;
        }
        
            output.WriteString(value:  val_4);
        }
        
        if(this.prefab_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_5 = this.prefab_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_5 = this.prefab_;
        }
        
            output.WriteString(value:  val_5);
        }
        
        if(this.mapIcon_.Length != 0)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_6 = this.mapIcon_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_6 = this.mapIcon_;
        }
        
            output.WriteString(value:  val_6);
        }
        
        if(this._unknownFields == null)
        {
                return;
        }
        
        this._unknownFields.WriteTo(output:  output);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int CalculateSize()
    {
        var val_10;
        if(this.bundle_.Length != 0)
        {
                val_10 = (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.bundle_)) + 1;
        }
        else
        {
                val_10 = 0;
        }
        
        if(this.prefab_.Length != 0)
        {
                val_10 = (val_10 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.prefab_))) + 1;
        }
        
        if(this.mapIcon_.Length != 0)
        {
                val_10 = (val_10 + (Google.Protobuf.CodedOutputStream.ComputeStringSize(value:  this.mapIcon_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_10;
        }
        
        val_10 = this._unknownFields.CalculateSize() + val_10;
        return (int)val_10;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.bundle_.Length != 0)
        {
                this.Bundle = other.bundle_;
        }
        
        if(other.prefab_.Length != 0)
        {
                this.Prefab = other.prefab_;
        }
        
        if(other.mapIcon_.Length != 0)
        {
                this.MapIcon = other.mapIcon_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_11;
        label_12:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        label_11:
        uint val_2 = input.ReadTag();
        if(val_2 <= 17)
        {
            goto label_2;
        }
        
        if(val_2 == 18)
        {
            goto label_3;
        }
        
        if(val_2 != 26)
        {
            goto label_12;
        }
        
        this.MapIcon = input.ReadString();
        goto label_11;
        label_2:
        if(val_2 != 10)
        {
            goto label_7;
        }
        
        this.Bundle = input.ReadString();
        goto label_11;
        label_3:
        this.Prefab = input.ReadString();
        goto label_11;
        label_7:
        if(val_2 != 0)
        {
            goto label_12;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D()
    {
        null = null;
        PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D.MapIconFieldNumber = new Google.Protobuf.MessageParser<ANIMATRONIC3D>(factory:  new System.Func<ANIMATRONIC3D>(object:  PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D.<>c.<>9, method:  ANIMATRONIC3D PLUSHSUIT_DATA.Types.ARTASSETS.Types.ANIMATRONIC3D.<>c::<.cctor>b__35_0()));
    }

}
