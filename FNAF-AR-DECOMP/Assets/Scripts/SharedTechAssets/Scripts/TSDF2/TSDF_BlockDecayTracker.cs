using UnityEngine;

namespace SharedTechAssets.Scripts.TSDF2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TSDF_BlockDecayTracker
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.TSDF_Config2 _config;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.TSDF_Manager _domain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, long> _timeSinceLastBlockUpdate;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> _blockKeysToRemove;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TSDF_BlockDecayTracker(SharedTechAssets.Scripts.TSDF2.TSDF_Manager domain)
        {
            this._domain = domain;
            this._config = domain.config;
            this._timeSinceLastBlockUpdate = new System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Int64>();
            this._blockKeysToRemove = new System.Collections.Generic.List<com.illumix.IntVector3.IntVector3>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateTimes()
        {
            var val_9;
            var val_10;
            System.DateTime val_1 = System.DateTime.UtcNow;
            long val_3 = (-2972493582642298179) + val_1.dateData.Ticks;
            HashSet.Enumerator<T> val_6 = X21.GetEnumerator();
            label_7:
            if((1255736344 & 1) == 0)
            {
                goto label_5;
            }
            
            this._timeSinceLastBlockUpdate.set_Item(key:  0.emailUIDataHandler, value:  (val_3 >> 23) + (val_3 >> 63));
            goto label_7;
            label_5:
            val_9 = 0;
            val_10 = 1;
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523042452504});
            if(( & 1) != 0)
            {
                    return;
            }
            
            if( == 0)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void QueryBlocksToRemove()
        {
            var val_9;
            var val_26;
            var val_27;
            var val_32;
            var val_34;
            System.DateTime val_1 = System.DateTime.UtcNow;
            long val_3 = (-2972493582642298179) + val_1.dateData.Ticks;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_7 = this._timeSinceLastBlockUpdate.Keys.GetEnumerator();
            val_26 = 0;
            label_33:
            if((1255944576 & 1) == 0)
            {
                goto label_5;
            }
            
            GameUI.EmailUIDataHandler val_10 = val_9.emailUIDataHandler;
            if((((val_3 >> 23) + (val_3 >> 63)) - this._timeSinceLastBlockUpdate.Item[val_10]) <= this._config.timeToDecay)
            {
                goto label_33;
            }
            
            bool val_13 = this._domain.Add(item:  val_10);
            if((this._domain.TryGetValue(key:  val_10, value: out  0)) == false)
            {
                goto label_15;
            }
            
            HashSet.Enumerator<T> val_18 = 11993091.GetEnumerator();
            label_22:
            if((1255944544 & 1) == 0)
            {
                goto label_20;
            }
            
            this._domain.Item[val_10].set_Item(key:  val_9.emailUIDataHandler, value:  false);
            goto label_22;
            label_20:
            val_27 = 239;
            long val_20 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523042660704});
            if((( == 0) ? 239 : ()) == 239)
            {
                
            }
            
            11993091.Clear();
            label_15:
            this._domain.data.Item[val_10].Clear();
            this._blockKeysToRemove.Add(item:  val_10);
            goto label_33;
            label_5:
            val_32 = 298;
            long val_22 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523042660736});
            val_34 = 0;
            goto label_57;
            label_61:
            bool val_24 = this._timeSinceLastBlockUpdate.Remove(key:  this._blockKeysToRemove.Item[0]);
            val_34 = 1;
            label_57:
            if(val_34 < this._blockKeysToRemove.Count)
            {
                goto label_61;
            }
            
            this._blockKeysToRemove.Clear();
        }
    
    }

}
