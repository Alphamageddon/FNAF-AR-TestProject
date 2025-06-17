using UnityEngine;

namespace Game.EssenceCollection.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MasterDataConnector
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Detect_DistanceFromCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Detect_ARObjectToEssenceDelay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Detect_MaxEssenceTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Detect_OverrideCooldown;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Detect_MinConfidence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Detect_BaseDisplayChance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Phantasm_ThreatCheckFrequency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CloakDecloak_DecloakDelay;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CloakDecloak_CenterOfScreenMinX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CloakDecloak_CenterOfScreenMaxX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CloakDecloak_CenterOfScreenMinY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float CloakDecloak_CenterOfScreenMaxY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GeigerCounter_MaxAngleDetect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GeigerCounter_MinTickInSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float GeigerCounter_MaxTickInSeconds;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParticleVacuum_DetachFrequency;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParticleVacuum_MaximumDetached;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParticleVacuum_CollectDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParticleVacuum_CollectDistanceMote;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParticleVacuum_CollectDistanceThreat;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParticleVacuum_CollectionScreenPointX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ParticleVacuum_CollectionScreenPointY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Motes_MaxVisibleMotesPerEssence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Motes_MaxDegradeMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Motes_MinDegradeMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Motes_MinDegradeDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Motes_MaxDegradeDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Mote_CollectionFlushBatchTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Mote_CollectTimeToWaitToSeeIfMoreMotesComingIn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThreatPills_MaxVisibleThreatPillsPerEssence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThreatPills_MaxDegradeMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThreatPills_MinDegradeMultiplier;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThreatPills_MinDegradeDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThreatPills_MaxDegradeDistance;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThreatCollection_ThreatPercentPerThreatPill;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThreatCollection_DropPerSecond;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float ThreatCollection_ConsecutiveThreatPercentMult;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Master.SceneLookupTableAccess <_sceneLookupTableAccess>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.MasterData.MasterDataDomain <_masterDataDomain>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.CONFIG_DATA.Types.ENTRY <_configDataEntry>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ESSENCE_TYPES_DATA <_essenceTypesData>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool MasterDataInitialized { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.CONFIG_DATA.Types.ENTRY ConfigDataEntry { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SceneLookupTableAccess _sceneLookupTableAccess { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain _masterDataDomain { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.CONFIG_DATA.Types.ENTRY _configDataEntry { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ESSENCE_TYPES_DATA _essenceTypesData { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_MasterDataInitialized()
        {
            if((this.<_configDataEntry>k__BackingField) == null)
            {
                    return false;
            }
            
            return (bool)((this.<_essenceTypesData>k__BackingField) != 0) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.CONFIG_DATA.Types.ENTRY get_ConfigDataEntry()
        {
            return (ENTRY)this.<_configDataEntry>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SceneLookupTableAccess get__sceneLookupTableAccess()
        {
            return (Master.SceneLookupTableAccess)this.<_sceneLookupTableAccess>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MasterData.MasterDataDomain get__masterDataDomain()
        {
            return (Game.MasterData.MasterDataDomain)this.<_masterDataDomain>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.CONFIG_DATA.Types.ENTRY get__configDataEntry()
        {
            return (ENTRY)this.<_configDataEntry>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__configDataEntry(ProtoData.CONFIG_DATA.Types.ENTRY value)
        {
            this.<_configDataEntry>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ESSENCE_TYPES_DATA get__essenceTypesData()
        {
            return (ProtoData.ESSENCE_TYPES_DATA)this.<_essenceTypesData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set__essenceTypesData(ProtoData.ESSENCE_TYPES_DATA value)
        {
            this.<_essenceTypesData>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MasterDataConnector(Master.SceneLookupTableAccess sceneLookupTableAccess, Game.MasterData.MasterDataDomain masterDataDomain)
        {
            this.Detect_DistanceFromCamera = ;
            this.Detect_ARObjectToEssenceDelay = ;
            this.Detect_MaxEssenceTime = 1.5f;
            this.Detect_OverrideCooldown = 15f;
            this.Detect_MinConfidence = ;
            this.Detect_BaseDisplayChance = ;
            this.Phantasm_ThreatCheckFrequency = 5f;
            this.CloakDecloak_DecloakDelay = 0.5f;
            this.Motes_MinDegradeMultiplier = 1f;
            this.ParticleVacuum_MaximumDetached = ;
            this.ParticleVacuum_CollectDistance = ;
            this.ParticleVacuum_CollectDistanceMote = 0.5f;
            this.ParticleVacuum_CollectDistanceThreat = 0.5f;
            this.ParticleVacuum_CollectionScreenPointX = ;
            this.ParticleVacuum_CollectionScreenPointY = ;
            this.Motes_MaxVisibleMotesPerEssence = 50f;
            this.Motes_MaxDegradeMultiplier = 10f;
            this.ThreatPills_MaxDegradeMultiplier = 0f;
            this.ThreatPills_MinDegradeMultiplier = 1f;
            this.ThreatPills_MaxDegradeDistance = 2f;
            this.ThreatCollection_ThreatPercentPerThreatPill = 7.346868E-41f;
            this.CloakDecloak_CenterOfScreenMinX = ;
            this.CloakDecloak_CenterOfScreenMaxX = ;
            this.CloakDecloak_CenterOfScreenMinY = 0.1f;
            this.CloakDecloak_CenterOfScreenMaxY = 0.9f;
            this.GeigerCounter_MaxAngleDetect = ;
            this.GeigerCounter_MinTickInSeconds = ;
            this.GeigerCounter_MaxTickInSeconds = 1f;
            this.ParticleVacuum_DetachFrequency = 0.25f;
            this.Motes_MaxDegradeDistance = ;
            this.Mote_CollectionFlushBatchTime = ;
            this.Mote_CollectTimeToWaitToSeeIfMoreMotesComingIn = 0.5f;
            this.ThreatPills_MaxVisibleThreatPillsPerEssence = 5f;
            this.ThreatCollection_DropPerSecond = 0.05f;
            this.ThreatCollection_ConsecutiveThreatPercentMult = 7.346868E-41f;
            val_1 = new System.Object();
            this.<_sceneLookupTableAccess>k__BackingField = sceneLookupTableAccess;
            this.<_masterDataDomain>k__BackingField = val_1;
            val_1.GetAccessToData.GetConfigDataEntryAsync(returnConfigDataEntryCallback:  new GetAccessToData.ReturnConfigDataEntry(object:  this, method:  System.Void Game.EssenceCollection.Data.MasterDataConnector::SetConfigDataEntry(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)));
            this.<_masterDataDomain>k__BackingField.GetAccessToData.GetEssenceTypesDataAsync(returnEssenceTypesDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.ESSENCE_TYPES_DATA>(object:  this, method:  System.Void Game.EssenceCollection.Data.MasterDataConnector::SetEssenceTypesData(ProtoData.ESSENCE_TYPES_DATA essenceTypesData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetConfigDataEntry(ProtoData.CONFIG_DATA.Types.ENTRY configDataEntry)
        {
            this.<_configDataEntry>k__BackingField = configDataEntry;
            this.FixupFromMasterData();
            this.<_sceneLookupTableAccess>k__BackingField.GetCameraSceneLookupTableAsync(returnCameraSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnCameraSceneLookupTable(object:  this, method:  System.Void Game.EssenceCollection.Data.MasterDataConnector::SetArObjectDetectionValuesFromConfig(CameraSceneLookupTable cameraSceneLookupTable)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetEssenceTypesData(ProtoData.ESSENCE_TYPES_DATA essenceTypesData)
        {
            this.<_essenceTypesData>k__BackingField = essenceTypesData;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY GetEssenceTypesDataForType(string essenceType)
        {
            var val_9;
            var val_12;
            var val_13;
            var val_14;
            val_9 = this;
            if((this.<_essenceTypesData>k__BackingField) == null)
            {
                goto label_33;
            }
            
            val_9 = this.<_essenceTypesData>k__BackingField.Entries.GetEnumerator();
            label_16:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_9.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = val_9.Current;
            if((System.String.op_Equality(a:  val_12.NodeType.Logical, b:  essenceType)) == false)
            {
                goto label_16;
            }
            
            val_13 = 0;
            val_14 = 81;
            if(val_9 != null)
            {
                goto label_19;
            }
            
            goto label_26;
            label_8:
            val_13 = 0;
            val_12 = 0;
            val_14 = 79;
            if(val_9 != null)
            {
                goto label_19;
            }
            
            goto label_26;
            label_19:
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_9.Dispose();
            label_26:
            if( != 79)
            {
                    if( == 81)
            {
                    return (ENTRY)val_12;
            }
            
            }
            
            label_33:
            val_12 = 0;
            return (ENTRY)val_12;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetArObjectDetectionValuesFromConfig(CameraSceneLookupTable cameraSceneLookupTable)
        {
            if((this.<_configDataEntry>k__BackingField.EssenceCollection) == null)
            {
                    return;
            }
            
            if((this.<_configDataEntry>k__BackingField.EssenceCollection.Detect) == null)
            {
                    return;
            }
            
            this = cameraSceneLookupTable.ObjectDetectionManagerConfig;
            double val_8 = 1000;
            val_8 = (this.<_configDataEntry>k__BackingField.EssenceCollection.Detect.ObjectDetectionPeriod) * val_8;
            val_4.updateFrequency = (int)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupFromMasterData()
        {
            this.FixupDetect();
            this.FixupPhantasm();
            this.FixupCloakDecloak();
            this.FixupGeigerCounter();
            this.FixupParticleVacuum();
            this.FixupMotes();
            this.FixupThreatPills();
            this.FixupThreatCollection();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupDetect()
        {
            float val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            ESSENCECOLLECTION val_1 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            DETECT val_2 = val_1.Detect;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            double val_3 = val_2.DistanceFromCamera;
            goto label_4;
            label_3:
            label_4:
            if(((-754756928) & 1) != 0)
            {
                    val_25 = (float)0.South;
                val_26 = 0;
            }
            else
            {
                    val_26 = 0;
            }
            
            if(((-754756872) & 1) != 0)
            {
                    this.Detect_DistanceFromCamera = 0f;
            }
            
            ESSENCECOLLECTION val_5 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_5 == null)
            {
                goto label_10;
            }
            
            DETECT val_6 = val_5.Detect;
            if(val_6 == null)
            {
                goto label_10;
            }
            
            double val_7 = val_6.ARObjectToEssenceDelay;
            goto label_11;
            label_10:
            label_11:
            if(((-754756928) & 1) != 0)
            {
                    val_25 = (float)0.South;
                val_27 = 0;
            }
            else
            {
                    val_27 = 0;
            }
            
            if(((-754756880) & 1) != 0)
            {
                    this.Detect_ARObjectToEssenceDelay = 0f;
            }
            
            ESSENCECOLLECTION val_9 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_9 == null)
            {
                goto label_17;
            }
            
            DETECT val_10 = val_9.Detect;
            if(val_10 == null)
            {
                goto label_17;
            }
            
            double val_11 = val_10.EssenceObjectDur;
            goto label_18;
            label_17:
            label_18:
            if(((-754756928) & 1) != 0)
            {
                    val_25 = (float)0.South;
                val_28 = 0;
            }
            else
            {
                    val_28 = 0;
            }
            
            if(((-754756888) & 1) != 0)
            {
                    this.Detect_MaxEssenceTime = 0f;
            }
            
            ESSENCECOLLECTION val_13 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_13 == null)
            {
                goto label_24;
            }
            
            DETECT val_14 = val_13.Detect;
            if(val_14 == null)
            {
                goto label_24;
            }
            
            double val_15 = val_14.OverrideCooldown;
            goto label_25;
            label_24:
            label_25:
            if(((-754756928) & 1) != 0)
            {
                    val_25 = (float)0.South;
                val_29 = 0;
            }
            else
            {
                    val_29 = 0;
            }
            
            if(((-754756896) & 1) != 0)
            {
                    this.Detect_OverrideCooldown = 0f;
            }
            
            ESSENCECOLLECTION val_17 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_17 == null)
            {
                goto label_31;
            }
            
            DETECT val_18 = val_17.Detect;
            if(val_18 == null)
            {
                goto label_31;
            }
            
            double val_19 = val_18.Confidence;
            goto label_32;
            label_31:
            label_32:
            if(((-754756928) & 1) != 0)
            {
                    val_25 = (float)0.South;
                val_30 = 0;
            }
            else
            {
                    val_30 = 0;
            }
            
            if(((-754756904) & 1) != 0)
            {
                    this.Detect_MinConfidence = 0f;
            }
            
            ESSENCECOLLECTION val_21 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_21 == null)
            {
                goto label_38;
            }
            
            DETECT val_22 = val_21.Detect;
            if(val_22 == null)
            {
                goto label_38;
            }
            
            double val_23 = val_22.BaseDisplayChance;
            goto label_39;
            label_38:
            label_39:
            if(((-754756928) & 1) != 0)
            {
                    val_25 = (float)0.South;
                val_31 = 0;
            }
            else
            {
                    val_31 = 0;
            }
            
            if(((-754756912) & 1) == 0)
            {
                    return;
            }
            
            this.Detect_BaseDisplayChance = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupPhantasm()
        {
            var val_5;
            ESSENCECOLLECTION val_1 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            PHANTASM val_2 = val_1.Phantasm;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            double val_3 = val_2.Period;
            goto label_4;
            label_3:
            label_4:
            if(((-754558864) & 1) != 0)
            {
                    double val_4 = 0.South;
                val_5 = 0;
            }
            else
            {
                    val_5 = 0;
            }
            
            if(((-754558840) & 1) == 0)
            {
                    return;
            }
            
            this.Phantasm_ThreatCheckFrequency = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupCloakDecloak()
        {
            float val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            ESSENCECOLLECTION val_1 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            CLOAKDECLOAK val_2 = val_1.CloakDecloak;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            double val_3 = val_2.DelayInSecondsBeforeDecloak;
            goto label_4;
            label_3:
            label_4:
            if(((-754373184) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_22 = 0;
            }
            else
            {
                    val_22 = 0;
            }
            
            if(((-754373128) & 1) != 0)
            {
                    this.CloakDecloak_DecloakDelay = 0f;
            }
            
            ESSENCECOLLECTION val_5 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_5 == null)
            {
                goto label_10;
            }
            
            CLOAKDECLOAK val_6 = val_5.CloakDecloak;
            if(val_6 == null)
            {
                goto label_10;
            }
            
            double val_7 = val_6.CenterOfScreenMinX;
            goto label_11;
            label_10:
            label_11:
            if(((-754373184) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_23 = 0;
            }
            else
            {
                    val_23 = 0;
            }
            
            ESSENCECOLLECTION val_9 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_9 == null)
            {
                goto label_16;
            }
            
            CLOAKDECLOAK val_10 = val_9.CloakDecloak;
            if(val_10 == null)
            {
                goto label_16;
            }
            
            double val_11 = val_10.CenterOfScreenMaxX;
            goto label_17;
            label_16:
            label_17:
            if(((-754373184) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_24 = 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            ESSENCECOLLECTION val_13 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_13 == null)
            {
                goto label_22;
            }
            
            CLOAKDECLOAK val_14 = val_13.CloakDecloak;
            if(val_14 == null)
            {
                goto label_22;
            }
            
            double val_15 = val_14.CenterOfScreenMinY;
            goto label_23;
            label_22:
            label_23:
            if(((-754373184) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_25 = 0;
            }
            else
            {
                    val_25 = 0;
            }
            
            ESSENCECOLLECTION val_17 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_17 == null)
            {
                goto label_28;
            }
            
            CLOAKDECLOAK val_18 = val_17.CloakDecloak;
            if(val_18 == null)
            {
                goto label_28;
            }
            
            double val_19 = val_18.CenterOfScreenMaxY;
            goto label_29;
            label_28:
            label_29:
            if(((-754373184) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_26 = 0;
            }
            else
            {
                    val_26 = 0;
            }
            
            if(((-754373136) & 1) != 0)
            {
                    this.CloakDecloak_CenterOfScreenMinX = 0f;
            }
            
            if(((-754373144) & 1) != 0)
            {
                    this.CloakDecloak_CenterOfScreenMaxX = 0f;
            }
            
            if(((-754373152) & 1) != 0)
            {
                    this.CloakDecloak_CenterOfScreenMinY = 0f;
            }
            
            if(((-754373160) & 1) == 0)
            {
                    return;
            }
            
            this.CloakDecloak_CenterOfScreenMaxY = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupGeigerCounter()
        {
            float val_13;
            var val_14;
            var val_15;
            var val_16;
            ESSENCECOLLECTION val_1 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            GEIGERCOUNTER val_2 = val_1.GeigerCounter;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            double val_3 = val_2.MaxAngleDetect;
            goto label_4;
            label_3:
            label_4:
            if(((-754162864) & 1) != 0)
            {
                    val_13 = (float)0.South;
                val_14 = 0;
            }
            else
            {
                    val_14 = 0;
            }
            
            if(((-754162824) & 1) != 0)
            {
                    this.GeigerCounter_MaxAngleDetect = 0f;
            }
            
            ESSENCECOLLECTION val_5 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_5 == null)
            {
                goto label_10;
            }
            
            GEIGERCOUNTER val_6 = val_5.GeigerCounter;
            if(val_6 == null)
            {
                goto label_10;
            }
            
            double val_7 = val_6.MinTickInSeconds;
            goto label_11;
            label_10:
            label_11:
            if(((-754162864) & 1) != 0)
            {
                    val_13 = (float)0.South;
                val_15 = 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            if(((-754162832) & 1) != 0)
            {
                    this.GeigerCounter_MinTickInSeconds = 0f;
            }
            
            ESSENCECOLLECTION val_9 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_9 == null)
            {
                goto label_17;
            }
            
            GEIGERCOUNTER val_10 = val_9.GeigerCounter;
            if(val_10 == null)
            {
                goto label_17;
            }
            
            double val_11 = val_10.MaxTickInSeconds;
            goto label_18;
            label_17:
            label_18:
            if(((-754162864) & 1) != 0)
            {
                    val_13 = (float)0.South;
                val_16 = 0;
            }
            else
            {
                    val_16 = 0;
            }
            
            if(((-754162840) & 1) == 0)
            {
                    return;
            }
            
            this.GeigerCounter_MaxTickInSeconds = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupParticleVacuum()
        {
            float val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            ESSENCECOLLECTION val_1 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            PARTICLEVACUUM val_2 = val_1.ParticleVacuum;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            double val_3 = val_2.DetachFrequency;
            goto label_4;
            label_3:
            label_4:
            if(((-753928016) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_30 = 0;
            }
            else
            {
                    val_30 = 0;
            }
            
            if(((-753927944) & 1) != 0)
            {
                    this.ParticleVacuum_DetachFrequency = 0f;
            }
            
            ESSENCECOLLECTION val_5 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_5 == null)
            {
                goto label_10;
            }
            
            PARTICLEVACUUM val_6 = val_5.ParticleVacuum;
            if(val_6 == null)
            {
                goto label_10;
            }
            
            double val_7 = val_6.MaximumDetached;
            goto label_11;
            label_10:
            label_11:
            if(((-753928016) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_31 = 0;
            }
            else
            {
                    val_31 = 0;
            }
            
            if(((-753927960) & 1) != 0)
            {
                    this.ParticleVacuum_MaximumDetached = 0f;
            }
            
            ESSENCECOLLECTION val_9 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_9 == null)
            {
                goto label_17;
            }
            
            PARTICLEVACUUM val_10 = val_9.ParticleVacuum;
            if(val_10 == null)
            {
                goto label_17;
            }
            
            double val_11 = val_10.CollectDistance;
            goto label_18;
            label_17:
            label_18:
            if(((-753928016) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_32 = 0;
            }
            else
            {
                    val_32 = 0;
            }
            
            if(((-753927968) & 1) != 0)
            {
                    this.ParticleVacuum_CollectDistance = 0f;
            }
            
            ESSENCECOLLECTION val_13 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_13 == null)
            {
                goto label_24;
            }
            
            PARTICLEVACUUM val_14 = val_13.ParticleVacuum;
            if(val_14 == null)
            {
                goto label_24;
            }
            
            double val_15 = val_14.CollectDistanceMote;
            goto label_25;
            label_24:
            label_25:
            if(((-753928016) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_33 = 0;
            }
            else
            {
                    val_33 = 0;
            }
            
            if(((-753927976) & 1) != 0)
            {
                    this.ParticleVacuum_CollectDistanceMote = 0f;
            }
            
            ESSENCECOLLECTION val_17 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_17 == null)
            {
                goto label_31;
            }
            
            PARTICLEVACUUM val_18 = val_17.ParticleVacuum;
            if(val_18 == null)
            {
                goto label_31;
            }
            
            double val_19 = val_18.CollectDistanceThreat;
            goto label_32;
            label_31:
            label_32:
            if(((-753928016) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_34 = 0;
            }
            else
            {
                    val_34 = 0;
            }
            
            if(((-753927984) & 1) != 0)
            {
                    this.ParticleVacuum_CollectDistanceThreat = 0f;
            }
            
            ESSENCECOLLECTION val_21 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_21 == null)
            {
                goto label_38;
            }
            
            PARTICLEVACUUM val_22 = val_21.ParticleVacuum;
            if(val_22 == null)
            {
                goto label_38;
            }
            
            double val_23 = val_22.CollectionScreenPointX;
            goto label_39;
            label_38:
            label_39:
            if(((-753928016) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_35 = 0;
            }
            else
            {
                    val_35 = 0;
            }
            
            ESSENCECOLLECTION val_25 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_25 == null)
            {
                goto label_44;
            }
            
            PARTICLEVACUUM val_26 = val_25.ParticleVacuum;
            if(val_26 == null)
            {
                goto label_44;
            }
            
            double val_27 = val_26.CollectionScreenPointY;
            goto label_45;
            label_44:
            label_45:
            if(((-753928016) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_36 = 0;
            }
            else
            {
                    val_36 = 0;
            }
            
            if(((-753927992) & 1) != 0)
            {
                    this.ParticleVacuum_CollectionScreenPointX = 0f;
            }
            
            if(((-753928000) & 1) == 0)
            {
                    return;
            }
            
            this.ParticleVacuum_CollectionScreenPointY = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupMotes()
        {
            float val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            float val_35;
            ESSENCECOLLECTION val_1 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            MOTES val_2 = val_1.Motes;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            double val_3 = val_2.MaxVisibleMotesPerEssence;
            goto label_4;
            label_3:
            label_4:
            if(((-753643968) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_30 = 0;
            }
            else
            {
                    val_30 = 0;
            }
            
            if(((-753643912) & 1) != 0)
            {
                    this.Motes_MaxVisibleMotesPerEssence = 0f;
            }
            
            ESSENCECOLLECTION val_5 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_5 == null)
            {
                goto label_10;
            }
            
            MOTES val_6 = val_5.Motes;
            if(val_6 == null)
            {
                goto label_10;
            }
            
            double val_7 = val_6.MaxDegradeMultiplier;
            goto label_11;
            label_10:
            label_11:
            if(((-753643968) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_31 = 0;
            }
            else
            {
                    val_31 = 0;
            }
            
            ESSENCECOLLECTION val_9 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_9 == null)
            {
                goto label_16;
            }
            
            MOTES val_10 = val_9.Motes;
            if(val_10 == null)
            {
                goto label_16;
            }
            
            double val_11 = val_10.MinDegradeMultiplier;
            goto label_17;
            label_16:
            label_17:
            if(((-753643968) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_32 = 0;
            }
            else
            {
                    val_32 = 0;
            }
            
            ESSENCECOLLECTION val_13 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_13 == null)
            {
                goto label_22;
            }
            
            MOTES val_14 = val_13.Motes;
            if(val_14 == null)
            {
                goto label_22;
            }
            
            double val_15 = val_14.MinDegradeDistance;
            goto label_23;
            label_22:
            label_23:
            if(((-753643968) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_33 = 0;
            }
            else
            {
                    val_33 = 0;
            }
            
            ESSENCECOLLECTION val_17 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_17 == null)
            {
                goto label_28;
            }
            
            MOTES val_18 = val_17.Motes;
            if(val_18 == null)
            {
                goto label_28;
            }
            
            double val_19 = val_18.MaxDegradeDistance;
            goto label_29;
            label_28:
            label_29:
            if(((-753643968) & 1) != 0)
            {
                    val_29 = (float)0.South;
                val_34 = 0;
            }
            else
            {
                    val_34 = 0;
            }
            
            ESSENCECOLLECTION val_21 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_21 == null)
            {
                goto label_34;
            }
            
            MOTES val_22 = val_21.Motes;
            if(val_22 == null)
            {
                goto label_34;
            }
            
            double val_23 = val_22.CollectFlushBatchTime;
            goto label_35;
            label_34:
            label_35:
            if(((-753643968) & 1) != 0)
            {
                    double val_24 = 0.South;
            }
            else
            {
                    val_29 = (double)this.Mote_CollectionFlushBatchTime;
            }
            
            val_35 = (float)val_29;
            this.Mote_CollectionFlushBatchTime = val_35;
            ESSENCECOLLECTION val_25 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_25 == null)
            {
                goto label_40;
            }
            
            MOTES val_26 = val_25.Motes;
            if(val_26 == null)
            {
                goto label_40;
            }
            
            double val_27 = val_26.CollectTimeToWaitToSeeIfMoreMotesComingIn;
            goto label_41;
            label_40:
            label_41:
            if(((-753643968) & 1) != 0)
            {
                    double val_28 = 0.South;
            }
            else
            {
                    val_35 = (double)this.Mote_CollectTimeToWaitToSeeIfMoreMotesComingIn;
            }
            
            this.Mote_CollectTimeToWaitToSeeIfMoreMotesComingIn = (float)val_35;
            if(((-753643920) & 1) != 0)
            {
                    this.Motes_MaxDegradeMultiplier = (float)val_35;
            }
            
            if(((-753643928) & 1) != 0)
            {
                    this.Motes_MinDegradeMultiplier = (float)val_35;
            }
            
            if(((-753643936) & 1) != 0)
            {
                    this.Motes_MinDegradeDistance = (float)val_35;
            }
            
            if(((-753643944) & 1) == 0)
            {
                    return;
            }
            
            this.Motes_MaxDegradeDistance = (float)val_35;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupThreatPills()
        {
            float val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            ESSENCECOLLECTION val_1 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            THREATPILLS val_2 = val_1.ThreatPills;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            double val_3 = val_2.MaxVisibleThreatPillsPerEssence;
            goto label_4;
            label_3:
            label_4:
            if(((-753384512) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_22 = 0;
            }
            else
            {
                    val_22 = 0;
            }
            
            if(((-753384456) & 1) != 0)
            {
                    this.ThreatPills_MaxVisibleThreatPillsPerEssence = 0f;
            }
            
            ESSENCECOLLECTION val_5 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_5 == null)
            {
                goto label_10;
            }
            
            THREATPILLS val_6 = val_5.ThreatPills;
            if(val_6 == null)
            {
                goto label_10;
            }
            
            double val_7 = val_6.MaxDegradeMultiplier;
            goto label_11;
            label_10:
            label_11:
            if(((-753384512) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_23 = 0;
            }
            else
            {
                    val_23 = 0;
            }
            
            ESSENCECOLLECTION val_9 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_9 == null)
            {
                goto label_16;
            }
            
            THREATPILLS val_10 = val_9.ThreatPills;
            if(val_10 == null)
            {
                goto label_16;
            }
            
            double val_11 = val_10.MinDegradeMultiplier;
            goto label_17;
            label_16:
            label_17:
            if(((-753384512) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_24 = 0;
            }
            else
            {
                    val_24 = 0;
            }
            
            ESSENCECOLLECTION val_13 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_13 == null)
            {
                goto label_22;
            }
            
            THREATPILLS val_14 = val_13.ThreatPills;
            if(val_14 == null)
            {
                goto label_22;
            }
            
            double val_15 = val_14.MinDegradeDistance;
            goto label_23;
            label_22:
            label_23:
            if(((-753384512) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_25 = 0;
            }
            else
            {
                    val_25 = 0;
            }
            
            ESSENCECOLLECTION val_17 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_17 == null)
            {
                goto label_28;
            }
            
            THREATPILLS val_18 = val_17.ThreatPills;
            if(val_18 == null)
            {
                goto label_28;
            }
            
            double val_19 = val_18.MaxDegradeDistance;
            goto label_29;
            label_28:
            label_29:
            if(((-753384512) & 1) != 0)
            {
                    val_21 = (float)0.South;
                val_26 = 0;
            }
            else
            {
                    val_26 = 0;
            }
            
            if(((-753384464) & 1) != 0)
            {
                    this.ThreatPills_MaxDegradeMultiplier = 0f;
            }
            
            if(((-753384472) & 1) != 0)
            {
                    this.ThreatPills_MinDegradeMultiplier = 0f;
            }
            
            if(((-753384480) & 1) != 0)
            {
                    this.ThreatPills_MinDegradeDistance = 0f;
            }
            
            if(((-753384488) & 1) == 0)
            {
                    return;
            }
            
            this.ThreatPills_MaxDegradeDistance = 0f;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void FixupThreatCollection()
        {
            float val_13;
            var val_14;
            var val_15;
            var val_16;
            ESSENCECOLLECTION val_1 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_1 == null)
            {
                goto label_3;
            }
            
            THREATCOLLECTION val_2 = val_1.ThreatCollection;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            double val_3 = val_2.ThreatPercentPerThreatPill;
            goto label_4;
            label_3:
            label_4:
            if(((-753174192) & 1) != 0)
            {
                    val_13 = (float)0.South;
                val_14 = 0;
            }
            else
            {
                    val_14 = 0;
            }
            
            if(((-753174152) & 1) != 0)
            {
                    this.ThreatCollection_ThreatPercentPerThreatPill = 0f;
            }
            
            ESSENCECOLLECTION val_5 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_5 == null)
            {
                goto label_10;
            }
            
            THREATCOLLECTION val_6 = val_5.ThreatCollection;
            if(val_6 == null)
            {
                goto label_10;
            }
            
            double val_7 = val_6.DropPerSecond;
            goto label_11;
            label_10:
            label_11:
            if(((-753174192) & 1) != 0)
            {
                    val_13 = (float)0.South;
                val_15 = 0;
            }
            else
            {
                    val_15 = 0;
            }
            
            if(((-753174160) & 1) != 0)
            {
                    this.ThreatCollection_DropPerSecond = 0f;
            }
            
            ESSENCECOLLECTION val_9 = this.<_configDataEntry>k__BackingField.EssenceCollection;
            if(val_9 == null)
            {
                goto label_17;
            }
            
            THREATCOLLECTION val_10 = val_9.ThreatCollection;
            if(val_10 == null)
            {
                goto label_17;
            }
            
            double val_11 = val_10.ConsecutiveThreatPercentMult;
            goto label_18;
            label_17:
            label_18:
            if(((-753174192) & 1) != 0)
            {
                    val_13 = (float)0.South;
                val_16 = 0;
            }
            else
            {
                    val_16 = 0;
            }
            
            if(((-753174168) & 1) == 0)
            {
                    return;
            }
            
            this.ThreatCollection_ConsecutiveThreatPercentMult = 0f;
        }
    
    }

}
