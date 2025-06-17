using UnityEngine;

namespace Game.EssenceCollection.Data.EssenceNodes
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EssenceNode
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY <EssenceTypesEntry>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.EssenceCollection.Visuals.EssenceVisual <_essenceVisual>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numInitialMotesToSpawn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numInitialThreatPillsToSpawn;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numRemainingMotes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numRemainingThreatPills;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<string> _moteIds;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.EssenceVisual EssenceVisual { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY EssenceTypesEntry { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumInitialMotesToSpawn { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumInitialThreatPillsToSpawn { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumRemainingMotes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int NumRemainingThreatPills { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string id { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.EssenceVisual _essenceVisual { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.EssenceCollection.Visuals.EssenceVisual get_EssenceVisual()
        {
            return (Game.EssenceCollection.Visuals.EssenceVisual)this.<_essenceVisual>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY get_EssenceTypesEntry()
        {
            return (ENTRY)this.<EssenceTypesEntry>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_EssenceTypesEntry(ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY value)
        {
            this.<EssenceTypesEntry>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumInitialMotesToSpawn()
        {
            return (int)this._numInitialMotesToSpawn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumInitialThreatPillsToSpawn()
        {
            return (int)this._numInitialThreatPillsToSpawn;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumRemainingMotes()
        {
            return (int)this._numRemainingMotes;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int get_NumRemainingThreatPills()
        {
            return (int)this._numRemainingThreatPills;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_id()
        {
            return (string)this._id;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.EssenceCollection.Visuals.EssenceVisual get__essenceVisual()
        {
            return (Game.EssenceCollection.Visuals.EssenceVisual)this.<_essenceVisual>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceNode(Game.EssenceCollection.Visuals.EssenceVisual essenceVisual, int numTotalMotes, int numTotalThreatPills, string id, string type, System.Collections.Generic.List<string> moteIds)
        {
            val_1 = new System.Object();
            this.<_essenceVisual>k__BackingField = essenceVisual;
            this._numInitialMotesToSpawn = 0;
            this._numInitialThreatPillsToSpawn = 0;
            this._numRemainingMotes = numTotalMotes;
            this._numRemainingThreatPills = numTotalThreatPills;
            this._id = val_1;
            this._type = type;
            this._moteIds = moteIds;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EssenceNode(Game.EssenceCollection.Visuals.EssenceVisual essenceVisual, ProtoData.ESSENCE_TYPES_DATA.Types.ENTRY essenceTypesEntry, string id, string type, System.Collections.Generic.List<string> moteIds)
        {
            int val_18;
            int val_19;
            int val_20;
            int val_21;
            val_1 = new System.Object();
            this.<EssenceTypesEntry>k__BackingField = val_1;
            this.<_essenceVisual>k__BackingField = essenceVisual;
            MOTEOVERRIDES val_2 = val_1.MoteOverrides;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            SPAWNBEHAVIOR val_3 = val_2.SpawnBehavior;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            double val_4 = val_3.StartingMotesPerNode;
            goto label_4;
            label_3:
            label_4:
            if(((-747861648) & 1) != 0)
            {
                    val_18 = (int)0.South;
            }
            else
            {
                    val_18 = 0;
            }
            
            this._numInitialMotesToSpawn = val_18;
            THREATPILLOVERRIDES val_6 = val_1.ThreatPillOverrides;
            if(val_6 == null)
            {
                goto label_9;
            }
            
            SPAWNBEHAVIOR val_7 = val_6.SpawnBehavior;
            if(val_7 == null)
            {
                goto label_9;
            }
            
            double val_8 = val_7.StartingThreatPillsPerNode;
            goto label_10;
            label_9:
            label_10:
            if(((-747861648) & 1) != 0)
            {
                    val_19 = (int)0.South;
            }
            else
            {
                    val_19 = 0;
            }
            
            this._numInitialThreatPillsToSpawn = val_19;
            MOTEOVERRIDES val_10 = val_1.MoteOverrides;
            if(val_10 == null)
            {
                goto label_15;
            }
            
            SPAWNBEHAVIOR val_11 = val_10.SpawnBehavior;
            if(val_11 == null)
            {
                goto label_15;
            }
            
            double val_12 = val_11.MaxMotesPerNode;
            goto label_16;
            label_15:
            label_16:
            if(((-747861648) & 1) != 0)
            {
                    val_20 = (int)0.South;
            }
            else
            {
                    val_20 = 0;
            }
            
            val_20 = val_20 - this._numInitialMotesToSpawn;
            this._numRemainingMotes = val_20;
            THREATPILLOVERRIDES val_14 = val_1.ThreatPillOverrides;
            if(val_14 == null)
            {
                goto label_21;
            }
            
            SPAWNBEHAVIOR val_15 = val_14.SpawnBehavior;
            if(val_15 == null)
            {
                goto label_21;
            }
            
            double val_16 = val_15.MaxThreatPillsPerNode;
            goto label_22;
            label_21:
            label_22:
            if(((-747861648) & 1) != 0)
            {
                    val_21 = (int)0.South;
            }
            else
            {
                    val_21 = 0;
            }
            
            this._id = id;
            this._type = type;
            this._moteIds = moteIds;
            val_21 = val_21 - this._numInitialThreatPillsToSpawn;
            this._numRemainingThreatPills = val_21;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string CollectMoteFromPool()
        {
            var val_3;
            if(this._moteIds.Count >= 1)
            {
                    val_3 = this._moteIds.Item[0];
                this._moteIds.RemoveAt(index:  0);
                return (string)val_3;
            }
            
            val_3 = 0;
            return (string)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ObtainMotes(int numMotes)
        {
            int val_4 = this._numInitialMotesToSpawn;
            int val_5 = this._numRemainingMotes;
            val_4 = val_4 - (UnityEngine.Mathf.Clamp(value:  numMotes, min:  0, max:  this._numInitialMotesToSpawn));
            val_5 = val_5 - (UnityEngine.Mathf.Clamp(value:  numMotes - this._numInitialMotesToSpawn, min:  0, max:  this._numRemainingMotes));
            this._numInitialMotesToSpawn = val_4;
            this._numRemainingMotes = val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ObtainThreatPills(int numThreatPills)
        {
            int val_4 = this._numInitialThreatPillsToSpawn;
            int val_5 = this._numRemainingThreatPills;
            val_4 = val_4 - (UnityEngine.Mathf.Clamp(value:  numThreatPills, min:  0, max:  this._numInitialThreatPillsToSpawn));
            val_5 = val_5 - (UnityEngine.Mathf.Clamp(value:  numThreatPills - this._numInitialThreatPillsToSpawn, min:  0, max:  this._numRemainingThreatPills));
            this._numInitialThreatPillsToSpawn = val_4;
            this._numRemainingThreatPills = val_5;
        }
    
    }

}
