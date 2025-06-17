using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    [Serializable]
    public class AnimatronicConfigData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.ItemDefinition.Data.DataDefinitions.CPUData <CpuData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.ItemDefinition.Data.DataDefinitions.PlushSuitData <PlushSuitData>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.ItemDefinition.Data.DataDefinitions.AttackProfile <AttackProfile>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.CPUData CpuData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.PlushSuitData PlushSuitData { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.AttackProfile AttackProfile { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.CPUData get_CpuData()
        {
            return (Game.ItemDefinition.Data.DataDefinitions.CPUData)this.<CpuData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.PlushSuitData get_PlushSuitData()
        {
            return (Game.ItemDefinition.Data.DataDefinitions.PlushSuitData)this.<PlushSuitData>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.AttackProfile get_AttackProfile()
        {
            return (Game.ItemDefinition.Data.DataDefinitions.AttackProfile)this.<AttackProfile>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicConfigData(AnimatronicEntity.AnimatronicConfigData animatronicConfigData)
        {
            if(animatronicConfigData != null)
            {
                    this.<CpuData>k__BackingField = animatronicConfigData.<CpuData>k__BackingField;
                this.<PlushSuitData>k__BackingField = animatronicConfigData.<PlushSuitData>k__BackingField;
            }
            else
            {
                    this.<CpuData>k__BackingField = 11993091;
                this.<PlushSuitData>k__BackingField = 15026800;
            }
            
            this.<AttackProfile>k__BackingField = animatronicConfigData.<AttackProfile>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicConfigData(Game.ItemDefinition.Data.DataDefinitions.CPUData cpuData, Game.ItemDefinition.Data.DataDefinitions.PlushSuitData plushSuitData, Game.ItemDefinition.Data.DataDefinitions.AttackProfile attackProfile)
        {
            val_1 = new System.Object();
            this.<CpuData>k__BackingField = cpuData;
            this.<PlushSuitData>k__BackingField = val_1;
            this.<AttackProfile>k__BackingField = attackProfile;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            return this.<CpuData>k__BackingField.ToString()(this.<CpuData>k__BackingField.ToString()) + this.<PlushSuitData>k__BackingField.ToString()(this.<PlushSuitData>k__BackingField.ToString());
        }
    
    }

}
