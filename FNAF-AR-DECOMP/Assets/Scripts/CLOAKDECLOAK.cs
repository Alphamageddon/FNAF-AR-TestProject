using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DelayInSecondsBeforeDecloakFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double delayInSecondsBeforeDecloak_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CenterOfScreenMinXFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double centerOfScreenMinX_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CenterOfScreenMaxXFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double centerOfScreenMaxX_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CenterOfScreenMinYFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double centerOfScreenMinY_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CenterOfScreenMaxYFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double centerOfScreenMaxY_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double DelayInSecondsBeforeDecloak { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CenterOfScreenMinX { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CenterOfScreenMaxX { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CenterOfScreenMinY { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double CenterOfScreenMaxY { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<CLOAKDECLOAK>)CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK.CenterOfScreenMaxYFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Descriptor.NestedTypes.Item[2];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK other)
    {
        if(other != null)
        {
                this.delayInSecondsBeforeDecloak_ = other.delayInSecondsBeforeDecloak_;
            this.centerOfScreenMinX_ = other.centerOfScreenMinX_;
            this.centerOfScreenMaxX_ = other.centerOfScreenMaxX_;
            this.centerOfScreenMinY_ = other.centerOfScreenMinY_;
            this.centerOfScreenMaxY_ = other.centerOfScreenMaxY_;
        }
        else
        {
                this.delayInSecondsBeforeDecloak_ = 7.42422564692724E-317;
            this.centerOfScreenMinX_ = 3.16202013338398E-322;
            this.centerOfScreenMaxX_ = 3.41288492945375E-316;
            this.centerOfScreenMinY_ = 1.33509863819657E-307;
            this.centerOfScreenMaxY_ = 3.75487155418531E-308;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK Clone()
    {
        return (CLOAKDECLOAK)new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_DelayInSecondsBeforeDecloak()
    {
        return (double)this.delayInSecondsBeforeDecloak_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_DelayInSecondsBeforeDecloak(double value)
    {
        this.delayInSecondsBeforeDecloak_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CenterOfScreenMinX()
    {
        return (double)this.centerOfScreenMinX_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CenterOfScreenMinX(double value)
    {
        this.centerOfScreenMinX_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CenterOfScreenMaxX()
    {
        return (double)this.centerOfScreenMaxX_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CenterOfScreenMaxX(double value)
    {
        this.centerOfScreenMaxX_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CenterOfScreenMinY()
    {
        return (double)this.centerOfScreenMinY_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CenterOfScreenMinY(double value)
    {
        this.centerOfScreenMinY_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_CenterOfScreenMaxY()
    {
        return (double)this.centerOfScreenMaxY_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CenterOfScreenMaxY(double value)
    {
        this.centerOfScreenMaxY_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        CLOAKDECLOAK val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK other)
    {
        var val_6;
        double val_7;
        var val_8;
        if(other == null)
        {
            goto label_22;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        val_7 = this.delayInSecondsBeforeDecloak_;
        val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
        if((val_6 & 1) != 0)
        {
                val_7 = this.centerOfScreenMinX_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.centerOfScreenMaxX_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.centerOfScreenMinY_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                val_7 = this.centerOfScreenMaxY_;
            val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer;
            if((val_6 & 1) != 0)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        }
        
        }
        
        }
        
        label_22:
        val_8 = 0;
        return (bool)val_8;
        label_2:
        val_8 = 1;
        return (bool)val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_6;
        if(this.delayInSecondsBeforeDecloak_ == 0f)
        {
                val_6 = 1;
        }
        else
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ 1;
        }
        
        if(this.centerOfScreenMinX_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.centerOfScreenMaxX_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.centerOfScreenMinY_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this.centerOfScreenMaxY_ != 0f)
        {
                val_6 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_6;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_6;
        }
        
        val_6 = this._unknownFields ^ val_6;
        return (int)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override string ToString()
    {
        return Google.Protobuf.JsonFormatter.ToDiagnosticString(message:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void WriteTo(Google.Protobuf.CodedOutputStream output)
    {
        double val_1;
        double val_2;
        double val_3;
        double val_4;
        double val_5;
        if(this.delayInSecondsBeforeDecloak_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  9);
            val_1 = this.delayInSecondsBeforeDecloak_;
        }
        else
        {
                0.WriteRawTag(b1:  9);
            val_1 = this.delayInSecondsBeforeDecloak_;
        }
        
            output.WriteDouble(value:  val_1);
        }
        
        if(this.centerOfScreenMinX_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  17);
            val_2 = this.centerOfScreenMinX_;
        }
        else
        {
                0.WriteRawTag(b1:  17);
            val_2 = this.centerOfScreenMinX_;
        }
        
            output.WriteDouble(value:  val_2);
        }
        
        if(this.centerOfScreenMaxX_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  25);
            val_3 = this.centerOfScreenMaxX_;
        }
        else
        {
                0.WriteRawTag(b1:  25);
            val_3 = this.centerOfScreenMaxX_;
        }
        
            output.WriteDouble(value:  val_3);
        }
        
        if(this.centerOfScreenMinY_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.centerOfScreenMinY_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.centerOfScreenMinY_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.centerOfScreenMaxY_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  41);
            val_5 = this.centerOfScreenMaxY_;
        }
        else
        {
                0.WriteRawTag(b1:  41);
            val_5 = this.centerOfScreenMaxY_;
        }
        
            output.WriteDouble(value:  val_5);
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
        var val_5;
        var val_1 = (this.delayInSecondsBeforeDecloak_ == 0f) ? 0 : 9;
        var val_2 = val_1 + 9;
        val_1 = (this.centerOfScreenMinX_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.centerOfScreenMaxX_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        val_1 = (this.centerOfScreenMinY_ == 0f) ? (val_1) : (val_2);
        val_2 = val_1 + 9;
        if(this._unknownFields == null)
        {
                return (int)val_5;
        }
        
        val_5 = this._unknownFields.CalculateSize() + ((this.centerOfScreenMaxY_ == 0f) ? (val_1) : (val_2));
        return (int)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK other)
    {
        if(other == null)
        {
                return;
        }
        
        if(other.delayInSecondsBeforeDecloak_ != 0f)
        {
                this.delayInSecondsBeforeDecloak_ = other.delayInSecondsBeforeDecloak_;
        }
        
        if(other.centerOfScreenMinX_ != 0f)
        {
                this.centerOfScreenMinX_ = other.centerOfScreenMinX_;
        }
        
        if(other.centerOfScreenMaxX_ != 0f)
        {
                this.centerOfScreenMaxX_ = other.centerOfScreenMaxX_;
        }
        
        if(other.centerOfScreenMinY_ != 0f)
        {
                this.centerOfScreenMinY_ = other.centerOfScreenMinY_;
        }
        
        if(other.centerOfScreenMaxY_ != 0f)
        {
                this.centerOfScreenMaxY_ = other.centerOfScreenMaxY_;
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        goto label_15;
        label_18:
        if(this > 17)
        {
            goto label_1;
        }
        
        if(this == 9)
        {
            goto label_2;
        }
        
        if(this != 17)
        {
            goto label_8;
        }
        
        this.centerOfScreenMinX_ = input.ReadDouble();
        goto label_15;
        label_1:
        if(this == 25)
        {
            goto label_6;
        }
        
        if(this == 33)
        {
            goto label_7;
        }
        
        if(this != 41)
        {
            goto label_8;
        }
        
        this.centerOfScreenMaxY_ = input.ReadDouble();
        goto label_15;
        label_8:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_15;
        label_2:
        this.delayInSecondsBeforeDecloak_ = input.ReadDouble();
        goto label_15;
        label_7:
        this.centerOfScreenMinY_ = input.ReadDouble();
        goto label_15;
        label_6:
        this.centerOfScreenMaxX_ = input.ReadDouble();
        label_15:
        if(input.ReadTag() != 0)
        {
            goto label_18;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK.CenterOfScreenMaxYFieldNumber = new Google.Protobuf.MessageParser<CLOAKDECLOAK>(factory:  new System.Func<CLOAKDECLOAK>(object:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK.<>c.<>9, method:  CLOAKDECLOAK CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK.<>c::<.cctor>b__45_0()));
    }

}
