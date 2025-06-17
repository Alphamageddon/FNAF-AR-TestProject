using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AtlasInfo : ScriptableObject
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.AtlasEntity> Textures;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.AtlasEntity> Roofs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Events.UnityEvent m_OnValidate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.AtlasEntityType AtlasEntityType;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddOnValidateEvent(UnityEngine.Events.UnityAction action)
        {
            this.m_OnValidate.AddListener(call:  action);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void OnValidate()
        {
            float val_3;
            System.Collections.Generic.List<Mapbox.Unity.MeshGeneration.Data.AtlasEntity> val_14;
            var val_16;
            float val_17;
            var val_18;
            System.Collections.Generic.List<System.String> val_19;
            Master.MasterDomain val_20;
            var val_21;
            Game.ItemDefinition.Container.ItemDefinitions val_23;
            var val_24;
            var val_25;
            System.Collections.Generic.List<System.String> val_26;
            float val_27;
            var val_28;
            float val_29;
            float val_30;
            float val_31;
            var val_32;
            System.Collections.Generic.List<System.String> val_33;
            float val_34;
            float val_35;
            val_14 = this;
            if(this.m_OnValidate != null)
            {
                    this.m_OnValidate.Invoke();
            }
            
            if(this.AtlasEntityType != 0)
            {
                goto label_42;
            }
            
            List.Enumerator<T> val_1 = this.Textures.GetEnumerator();
            val_16 = 1152921519718245744;
            val_17 = 1f;
            goto label_4;
            label_17:
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            if(val_4 != null)
            {
                    val_18 = val_4;
                val_19 = val_4._emailIdsToBeSetToReadOnServer;
            }
            else
            {
                    val_19 = 0;
                val_18 = 48;
            }
            
            val_20 = val_4._masterDomain;
            if(val_4 != null)
            {
                    val_21 = val_4;
            }
            else
            {
                    val_21 = val_4;
            }
            
            if(val_4 != null)
            {
                    float val_5 = val_3 * S11;
                val_5 = val_5 / val_3;
                val_23 = val_5 * 0f;
                val_4._itemDefinitions = val_23;
            }
            else
            {
                    float val_6 = val_3 * S11;
                val_6 = val_6 / val_3;
                val_23 = val_6 * 0f;
                mem[56] = val_23;
                val_24 = 0;
            }
            
            if(val_4 != null)
            {
                    val_25 = val_4;
                val_26 = val_4._emailIdsToBeDeletedOnServer;
            }
            else
            {
                    val_26 = 1.85775E-36f;
                val_25 = 40;
            }
            
            if(val_4 != null)
            {
                    val_6 = val_23 * val_26;
                val_6 = val_6 / val_23;
                val_27 = val_6 * 0f;
                mem2[0] = val_27;
                val_28 = 0;
                val_29 = 1.85775E-36f;
            }
            else
            {
                    val_6 = val_23 * val_26;
                val_6 = val_6 / val_23;
                val_27 = val_6 * 0f;
                mem2[0] = val_27;
                val_28 = 0;
                val_29 = 1.85775E-36f;
                val_30 = mem[val_4 + 44];
                val_30 = val_4 + 44;
            }
            
            val_31 = val_27;
            float val_7 = val_17 - val_29;
            val_7 = val_7 - val_30;
            float val_14 = 0f;
            val_7 = val_7 * (val_31 / val_27);
            val_14 = val_7 * val_14;
            mem2[0] = val_14;
            label_4:
            if(((-2026169152) & 1) != 0)
            {
                goto label_17;
            }
            
            return;
            label_42:
            val_14 = this.Textures;
            List.Enumerator<T> val_10 = val_14.GetEnumerator();
            val_20 = 1152921519718244720;
            val_16 = 56;
            goto label_44;
            label_52:
            val_14 = val_3.emailUIDataHandler;
            if(val_14 != null)
            {
                    val_32 = val_14;
                val_33 = val_11._emailIdsToBeSetToReadOnServer;
                val_34 = mem[val_11 + 48 + 8];
                val_34 = val_11 + 48 + 8;
            }
            else
            {
                    val_34 = mem[56];
                val_33 = 0;
                val_32 = 48;
            }
            
            if(val_14 != null)
            {
                    float val_15 = 0f;
                val_15 = val_34 / val_15;
                val_15 = val_15 * val_3;
                val_35 = val_15 / val_3;
                mem2[0] = val_35;
            }
            else
            {
                    float val_16 = 0f;
                val_16 = val_34 / val_16;
                val_16 = val_16 * val_3;
                val_35 = val_16 / val_3;
                mem2[0] = val_35;
                val_25 = 0;
            }
            
            val_31 = val_35;
            float val_17 = 0f;
            val_17 = val_34 / val_17;
            val_17 = val_17 * val_31;
            val_17 = val_17 / val_35;
            val_11._emailIdsToBeDeletedOnServer = val_17;
            label_44:
            if(((-2026169152) & 1) != 0)
            {
                goto label_52;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AtlasInfo()
        {
            this.m_OnValidate = new UnityEngine.Events.UnityEvent();
        }
    
    }

}
