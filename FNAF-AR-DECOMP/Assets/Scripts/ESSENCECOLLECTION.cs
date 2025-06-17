using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public sealed class CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION : IMessage<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION>, IMessage, IEquatable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION>, IDeepCloneable<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION> _parser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.UnknownFieldSet _unknownFields;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int DetectFieldNumber = 1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT detect_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int PhantasmFieldNumber = 2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM phantasm_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EssenceRewardFieldNumber = 3;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.ESSENCEREWARD essenceReward_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int EssenceMinRewardFieldNumber = 4;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private double essenceMinReward_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int CloakDecloakFieldNumber = 5;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK cloakDecloak_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int GeigerCounterFieldNumber = 6;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.GEIGERCOUNTER geigerCounter_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ParticleVacuumFieldNumber = 7;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM particleVacuum_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int MotesFieldNumber = 8;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES motes_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ThreatPillsFieldNumber = 9;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS threatPills_;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public const int ThreatCollectionFieldNumber = 10;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION threatCollection_;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION> Parser { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.Descriptor { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT Detect { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM Phantasm { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.ESSENCEREWARD EssenceReward { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double EssenceMinReward { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK CloakDecloak { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.GEIGERCOUNTER GeigerCounter { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM ParticleVacuum { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES Motes { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS ThreatPills { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION ThreatCollection { get; set; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.MessageParser<ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION> get_Parser()
    {
        null = null;
        return (Google.Protobuf.MessageParser<ESSENCECOLLECTION>)CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.ThreatCollectionFieldNumber;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Google.Protobuf.Reflection.MessageDescriptor get_Descriptor()
    {
        var val_4 = 0;
        val_4 = val_4 + 1;
        return CONFIG_DATA.Types.ENTRY.Descriptor.NestedTypes.Item[8];
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Google.Protobuf.Reflection.MessageDescriptor pb::Google.Protobuf.IMessage.get_Descriptor()
    {
        return CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Descriptor;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION other)
    {
        PHANTASM val_11;
        ESSENCEREWARD val_12;
        CLOAKDECLOAK val_13;
        GEIGERCOUNTER val_14;
        PARTICLEVACUUM val_15;
        MOTES val_16;
        THREATPILLS val_17;
        THREATCOLLECTION val_18;
        if(other.detect_ == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_11;
        }
        
        label_12:
        label_11:
        this.detect_ = other.detect_.Clone();
        val_11 = other.phantasm_;
        this.phantasm_ = val_11.Clone();
        val_12 = other.essenceReward_;
        this.essenceReward_ = val_12.Clone();
        this.essenceMinReward_ = other.essenceMinReward_;
        val_13 = other.cloakDecloak_;
        this.cloakDecloak_ = val_13.Clone();
        val_14 = other.geigerCounter_;
        this.geigerCounter_ = val_14.Clone();
        val_15 = other.particleVacuum_;
        this.particleVacuum_ = val_15.Clone();
        val_16 = other.motes_;
        this.motes_ = val_16.Clone();
        val_17 = other.threatPills_;
        this.threatPills_ = val_17.Clone();
        val_18 = other.threatCollection_;
        this.threatCollection_ = val_18.Clone();
        this._unknownFields = Google.Protobuf.UnknownFieldSet.Clone(other:  other._unknownFields);
        return;
        label_1:
        if(this != null)
        {
            goto label_11;
        }
        
        goto label_12;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION Clone()
    {
        return (ESSENCECOLLECTION)new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION(other:  this);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT get_Detect()
    {
        return (DETECT)this.detect_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Detect(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT value)
    {
        this.detect_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM get_Phantasm()
    {
        return (PHANTASM)this.phantasm_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Phantasm(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM value)
    {
        this.phantasm_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.ESSENCEREWARD get_EssenceReward()
    {
        return (ESSENCEREWARD)this.essenceReward_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EssenceReward(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.ESSENCEREWARD value)
    {
        this.essenceReward_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public double get_EssenceMinReward()
    {
        return (double)this.essenceMinReward_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_EssenceMinReward(double value)
    {
        this.essenceMinReward_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK get_CloakDecloak()
    {
        return (CLOAKDECLOAK)this.cloakDecloak_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_CloakDecloak(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK value)
    {
        this.cloakDecloak_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.GEIGERCOUNTER get_GeigerCounter()
    {
        return (GEIGERCOUNTER)this.geigerCounter_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_GeigerCounter(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.GEIGERCOUNTER value)
    {
        this.geigerCounter_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM get_ParticleVacuum()
    {
        return (PARTICLEVACUUM)this.particleVacuum_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ParticleVacuum(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM value)
    {
        this.particleVacuum_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES get_Motes()
    {
        return (MOTES)this.motes_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_Motes(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES value)
    {
        this.motes_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS get_ThreatPills()
    {
        return (THREATPILLS)this.threatPills_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ThreatPills(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS value)
    {
        this.threatPills_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION get_ThreatCollection()
    {
        return (THREATCOLLECTION)this.threatCollection_;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void set_ThreatCollection(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION value)
    {
        this.threatCollection_ = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override bool Equals(object other)
    {
        ESSENCECOLLECTION val_1;
        if(other != null)
        {
                other = (null == null) ? other : 0;
            return this.Equals(other:  val_1 = 0);
        }
        
        return this.Equals(other:  val_1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Equals(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION other)
    {
        var val_11;
        if(other == null)
        {
            goto label_15;
        }
        
        if(other == this)
        {
            goto label_2;
        }
        
        if((((((((((System.Object.Equals(objA:  this.detect_, objB:  other.detect_)) != false) && ((System.Object.Equals(objA:  this.phantasm_, objB:  other.phantasm_)) != false)) && ((System.Object.Equals(objA:  this.essenceReward_, objB:  other.essenceReward_)) != false)) && ((Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer & 1) != 0)) && ((System.Object.Equals(objA:  this.cloakDecloak_, objB:  other.cloakDecloak_)) != false)) && ((System.Object.Equals(objA:  this.geigerCounter_, objB:  other.geigerCounter_)) != false)) && ((System.Object.Equals(objA:  this.particleVacuum_, objB:  other.particleVacuum_)) != false)) && ((System.Object.Equals(objA:  this.motes_, objB:  other.motes_)) != false)) && ((System.Object.Equals(objA:  this.threatPills_, objB:  other.threatPills_)) != false))
        {
                if((System.Object.Equals(objA:  this.threatCollection_, objB:  other.threatCollection_)) != false)
        {
                return System.Object.Equals(objA:  this._unknownFields, objB:  other._unknownFields);
        }
        
        }
        
        label_15:
        val_11 = 0;
        return (bool)val_11;
        label_2:
        val_11 = 1;
        return (bool)val_11;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override int GetHashCode()
    {
        var val_4;
        if(this.detect_ != null)
        {
                val_4 = this.detect_ ^ 1;
        }
        else
        {
                val_4 = 1;
        }
        
        if(this.phantasm_ != null)
        {
                val_4 = this.phantasm_ ^ val_4;
        }
        
        if(this.essenceReward_ != null)
        {
                val_4 = this.essenceReward_ ^ val_4;
        }
        
        if(this.essenceMinReward_ != 0f)
        {
                val_4 = Google.Protobuf.Collections.ProtobufEqualityComparers.BitwiseDoubleEqualityComparer ^ val_4;
        }
        
        if(this.cloakDecloak_ != null)
        {
                val_4 = this.cloakDecloak_ ^ val_4;
        }
        
        if(this.geigerCounter_ != null)
        {
                val_4 = this.geigerCounter_ ^ val_4;
        }
        
        if(this.particleVacuum_ != null)
        {
                val_4 = this.particleVacuum_ ^ val_4;
        }
        
        if(this.motes_ != null)
        {
                val_4 = this.motes_ ^ val_4;
        }
        
        if(this.threatPills_ != null)
        {
                val_4 = this.threatPills_ ^ val_4;
        }
        
        if(this.threatCollection_ != null)
        {
                val_4 = this.threatCollection_ ^ val_4;
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
        DETECT val_1;
        PHANTASM val_2;
        ESSENCEREWARD val_3;
        double val_4;
        CLOAKDECLOAK val_5;
        GEIGERCOUNTER val_6;
        PARTICLEVACUUM val_7;
        MOTES val_8;
        THREATPILLS val_9;
        THREATCOLLECTION val_10;
        if(this.detect_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  10);
            val_1 = this.detect_;
        }
        else
        {
                0.WriteRawTag(b1:  10);
            val_1 = this.detect_;
        }
        
            output.WriteMessage(value:  val_1);
        }
        
        if(this.phantasm_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  18);
            val_2 = this.phantasm_;
        }
        else
        {
                0.WriteRawTag(b1:  18);
            val_2 = this.phantasm_;
        }
        
            output.WriteMessage(value:  val_2);
        }
        
        if(this.essenceReward_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  26);
            val_3 = this.essenceReward_;
        }
        else
        {
                0.WriteRawTag(b1:  26);
            val_3 = this.essenceReward_;
        }
        
            output.WriteMessage(value:  val_3);
        }
        
        if(this.essenceMinReward_ != 0f)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  33);
            val_4 = this.essenceMinReward_;
        }
        else
        {
                0.WriteRawTag(b1:  33);
            val_4 = this.essenceMinReward_;
        }
        
            output.WriteDouble(value:  val_4);
        }
        
        if(this.cloakDecloak_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  42);
            val_5 = this.cloakDecloak_;
        }
        else
        {
                0.WriteRawTag(b1:  42);
            val_5 = this.cloakDecloak_;
        }
        
            output.WriteMessage(value:  val_5);
        }
        
        if(this.geigerCounter_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  50);
            val_6 = this.geigerCounter_;
        }
        else
        {
                0.WriteRawTag(b1:  50);
            val_6 = this.geigerCounter_;
        }
        
            output.WriteMessage(value:  val_6);
        }
        
        if(this.particleVacuum_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  58);
            val_7 = this.particleVacuum_;
        }
        else
        {
                0.WriteRawTag(b1:  58);
            val_7 = this.particleVacuum_;
        }
        
            output.WriteMessage(value:  val_7);
        }
        
        if(this.motes_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  66);
            val_8 = this.motes_;
        }
        else
        {
                0.WriteRawTag(b1:  66);
            val_8 = this.motes_;
        }
        
            output.WriteMessage(value:  val_8);
        }
        
        if(this.threatPills_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  74);
            val_9 = this.threatPills_;
        }
        else
        {
                0.WriteRawTag(b1:  74);
            val_9 = this.threatPills_;
        }
        
            output.WriteMessage(value:  val_9);
        }
        
        if(this.threatCollection_ != null)
        {
                if(output != null)
        {
                output.WriteRawTag(b1:  82);
            val_10 = this.threatCollection_;
        }
        else
        {
                0.WriteRawTag(b1:  82);
            val_10 = this.threatCollection_;
        }
        
            output.WriteMessage(value:  val_10);
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
        var val_20;
        var val_21;
        if(this.detect_ != null)
        {
                val_20 = (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.detect_)) + 1;
        }
        else
        {
                val_20 = 0;
        }
        
        if(this.phantasm_ != null)
        {
                val_20 = (val_20 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.phantasm_))) + 1;
        }
        
        ESSENCEREWARD val_19 = this.essenceReward_;
        if(val_19 != null)
        {
                int val_5 = val_20 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  val_19));
            val_20 = val_5 + 1;
        }
        
        val_5 = val_20 + 9;
        val_19 = (this.essenceMinReward_ == 0f) ? (val_20) : (val_5);
        if(this.cloakDecloak_ != null)
        {
                val_21 = (val_19 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.cloakDecloak_))) + 1;
        }
        
        if(this.geigerCounter_ != null)
        {
                val_21 = (val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.geigerCounter_))) + 1;
        }
        
        if(this.particleVacuum_ != null)
        {
                val_21 = (val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.particleVacuum_))) + 1;
        }
        
        if(this.motes_ != null)
        {
                val_21 = (val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.motes_))) + 1;
        }
        
        if(this.threatPills_ != null)
        {
                val_21 = (val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.threatPills_))) + 1;
        }
        
        if(this.threatCollection_ != null)
        {
                val_21 = (val_21 + (Google.Protobuf.CodedOutputStream.ComputeMessageSize(value:  this.threatCollection_))) + 1;
        }
        
        if(this._unknownFields == null)
        {
                return (int)val_21;
        }
        
        val_21 = this._unknownFields.CalculateSize() + val_21;
        return (int)val_21;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(ProtoData.CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION other)
    {
        THREATCOLLECTION val_11;
        DETECT val_12;
        DETECT val_13;
        PHANTASM val_14;
        PHANTASM val_15;
        ESSENCEREWARD val_16;
        ESSENCEREWARD val_17;
        CLOAKDECLOAK val_18;
        CLOAKDECLOAK val_19;
        GEIGERCOUNTER val_20;
        GEIGERCOUNTER val_21;
        PARTICLEVACUUM val_22;
        PARTICLEVACUUM val_23;
        MOTES val_24;
        MOTES val_25;
        THREATPILLS val_26;
        THREATPILLS val_27;
        THREATCOLLECTION val_28;
        if(other == null)
        {
                return;
        }
        
        val_12 = other.detect_;
        if(val_12 != null)
        {
                val_13 = this.detect_;
            if(val_13 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT val_1 = null;
            val_13 = val_1;
            val_1 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT();
            this.detect_ = val_13;
            val_12 = other.detect_;
        }
        
            val_1.MergeFrom(other:  val_12);
        }
        
        val_14 = other.phantasm_;
        if(val_14 != null)
        {
                val_15 = this.phantasm_;
            if(val_15 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM val_2 = null;
            val_15 = val_2;
            val_2 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM();
            this.phantasm_ = val_15;
            val_14 = other.phantasm_;
        }
        
            val_2.MergeFrom(other:  val_14);
        }
        
        val_16 = other.essenceReward_;
        if(val_16 != null)
        {
                val_17 = this.essenceReward_;
            if(val_17 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.ESSENCEREWARD val_3 = null;
            val_17 = val_3;
            val_3 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.ESSENCEREWARD();
            this.essenceReward_ = val_17;
            val_16 = other.essenceReward_;
        }
        
            val_3.MergeFrom(other:  val_16);
        }
        
        if(other.essenceMinReward_ != 0f)
        {
                this.essenceMinReward_ = other.essenceMinReward_;
        }
        
        val_18 = other.cloakDecloak_;
        if(val_18 != null)
        {
                val_19 = this.cloakDecloak_;
            if(val_19 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK val_4 = null;
            val_19 = val_4;
            val_4 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK();
            this.cloakDecloak_ = val_19;
            val_18 = other.cloakDecloak_;
        }
        
            val_4.MergeFrom(other:  val_18);
        }
        
        val_20 = other.geigerCounter_;
        if(val_20 != null)
        {
                val_21 = this.geigerCounter_;
            if(val_21 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.GEIGERCOUNTER val_5 = null;
            val_21 = val_5;
            val_5 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.GEIGERCOUNTER();
            this.geigerCounter_ = val_21;
            val_20 = other.geigerCounter_;
        }
        
            val_5.MergeFrom(other:  val_20);
        }
        
        val_22 = other.particleVacuum_;
        if(val_22 != null)
        {
                val_23 = this.particleVacuum_;
            if(val_23 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM val_6 = null;
            val_23 = val_6;
            val_6 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM();
            this.particleVacuum_ = val_23;
            val_22 = other.particleVacuum_;
        }
        
            val_6.MergeFrom(other:  val_22);
        }
        
        val_24 = other.motes_;
        if(val_24 != null)
        {
                val_25 = this.motes_;
            if(val_25 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES val_7 = null;
            val_25 = val_7;
            val_7 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES();
            this.motes_ = val_25;
            val_24 = other.motes_;
        }
        
            val_7.MergeFrom(other:  val_24);
        }
        
        val_26 = other.threatPills_;
        if(val_26 != null)
        {
                val_27 = this.threatPills_;
            if(val_27 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS val_8 = null;
            val_27 = val_8;
            val_8 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS();
            this.threatPills_ = val_27;
            val_26 = other.threatPills_;
        }
        
            val_8.MergeFrom(other:  val_26);
        }
        
        val_11 = other.threatCollection_;
        if(val_11 != null)
        {
                val_28 = this.threatCollection_;
            if(val_28 == null)
        {
                CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION val_9 = null;
            val_28 = val_9;
            val_9 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION();
            this.threatCollection_ = val_28;
            val_11 = other.threatCollection_;
        }
        
            val_9.MergeFrom(other:  val_11);
        }
        
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFrom(unknownFields:  this._unknownFields, other:  other._unknownFields);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void MergeFrom(Google.Protobuf.CodedInputStream input)
    {
        PHANTASM val_13;
        goto label_44;
        label_48:
        if(18264 > 42)
        {
            goto label_2;
        }
        
        if(18264 > 18)
        {
            goto label_3;
        }
        
        if(18264 == 10)
        {
            goto label_4;
        }
        
        if(18264 != 18)
        {
            goto label_23;
        }
        
        val_13 = this.phantasm_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM val_1 = null;
        val_13 = val_1;
        val_1 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PHANTASM();
        this.phantasm_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_2:
        if(18264 > 58)
        {
            goto label_9;
        }
        
        if(18264 == 50)
        {
            goto label_10;
        }
        
        if(18264 != 58)
        {
            goto label_23;
        }
        
        val_13 = this.particleVacuum_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM val_2 = null;
        val_13 = val_2;
        val_2 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.PARTICLEVACUUM();
        this.particleVacuum_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_3:
        if(18264 == 26)
        {
            goto label_15;
        }
        
        if(18264 == 33)
        {
            goto label_16;
        }
        
        if(18264 != 42)
        {
            goto label_23;
        }
        
        val_13 = this.cloakDecloak_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK val_3 = null;
        val_13 = val_3;
        val_3 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.CLOAKDECLOAK();
        this.cloakDecloak_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_9:
        if(18264 == 66)
        {
            goto label_21;
        }
        
        if(18264 == 74)
        {
            goto label_22;
        }
        
        if(18264 != 82)
        {
            goto label_23;
        }
        
        val_13 = this.threatCollection_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION val_4 = null;
        val_13 = val_4;
        val_4 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATCOLLECTION();
        this.threatCollection_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_23:
        this._unknownFields = Google.Protobuf.UnknownFieldSet.MergeFieldFrom(unknownFields:  this._unknownFields, input:  input);
        goto label_44;
        label_4:
        val_13 = this.detect_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT val_6 = null;
        val_13 = val_6;
        val_6 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.DETECT();
        this.detect_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_10:
        val_13 = this.geigerCounter_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.GEIGERCOUNTER val_7 = null;
        val_13 = val_7;
        val_7 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.GEIGERCOUNTER();
        this.geigerCounter_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_16:
        this.essenceMinReward_ = input.ReadDouble();
        goto label_44;
        label_22:
        val_13 = this.threatPills_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS val_9 = null;
        val_13 = val_9;
        val_9 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.THREATPILLS();
        this.threatPills_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_15:
        val_13 = this.essenceReward_;
        if(val_13 != null)
        {
            goto label_39;
        }
        
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.ESSENCEREWARD val_10 = null;
        val_13 = val_10;
        val_10 = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.ESSENCEREWARD();
        this.essenceReward_ = val_13;
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_21:
        val_13 = this.motes_;
        if(val_13 == null)
        {
            goto label_42;
        }
        
        label_39:
        if(input != null)
        {
            goto label_45;
        }
        
        label_46:
        label_45:
        input.ReadMessage(builder:  val_13);
        goto label_44;
        label_42:
        this.motes_ = new CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.Types.MOTES();
        if(input != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_44:
        if(input.ReadTag() != 0)
        {
            goto label_48;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION()
    {
        null = null;
        CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.ThreatCollectionFieldNumber = new Google.Protobuf.MessageParser<ESSENCECOLLECTION>(factory:  new System.Func<ESSENCECOLLECTION>(object:  CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.<>c.<>9, method:  ESSENCECOLLECTION CONFIG_DATA.Types.ENTRY.Types.ESSENCECOLLECTION.<>c::<.cctor>b__71_0()));
    }

}
