using UnityEngine;

namespace SharedTechAssets.Scripts.TSDF2
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SurfaceVerticesUpdater
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TSDF2.TSDF_Manager domain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SurfaceVerticesUpdater(SharedTechAssets.Scripts.TSDF2.TSDF_Manager tsdfDomain)
        {
            this.domain = tsdfDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateVertices()
        {
            this.UpdateCachedBlocks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateCachedBlocks()
        {
            var val_4;
            SharedTechAssets.Scripts.TSDF2.SurfaceVerticesUpdater val_24;
            var val_25;
            var val_26;
            var val_31;
            var val_33;
            val_24 = this;
            System.Collections.Generic.List<com.illumix.IntVector3.IntVector3> val_1 = new System.Collections.Generic.List<com.illumix.IntVector3.IntVector3>();
            HashSet.Enumerator<T> val_2 = X23.GetEnumerator();
            val_25 = 0;
            label_44:
            if((1255399680 & 1) == 0)
            {
                goto label_3;
            }
            
            GameUI.EmailUIDataHandler val_5 = val_4.emailUIDataHandler;
            System.Collections.Generic.Dictionary<com.illumix.IntVector3.IntVector3, System.Boolean> val_6 = X20.Item[val_5];
            if((X22.ContainsKey(key:  val_5)) != true)
            {
                    X22.set_Item(key:  val_5, value:  this.domain.MakeNewVoxelBlock());
            }
            
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_11 = val_6.Keys.GetEnumerator();
            label_26:
            if((1255399648 & 1) == 0)
            {
                goto label_12;
            }
            
            GameUI.EmailUIDataHandler val_12 = val_4.emailUIDataHandler;
            if(val_6.Item[val_12] == false)
            {
                goto label_14;
            }
            
            if((val_9.tsdfCoords.Add(item:  val_12)) == false)
            {
                goto label_26;
            }
            
            Add(item:  this.domain.GenerateTuple(coord:  val_12, isAdd:  true, isSeparator:  false));
            goto label_26;
            label_14:
            if((val_9.tsdfCoords.Remove(item:  val_12)) == false)
            {
                goto label_26;
            }
            
            Add(item:  this.domain.GenerateTuple(coord:  val_12, isAdd:  false, isSeparator:  false));
            goto label_26;
            label_12:
            val_26 = 265;
            long val_18 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523042115808});
            if((( == 0) ? 265 : ()) != 265)
            {
                goto label_38;
            }
            
            if(X22 != 0)
            {
                goto label_42;
            }
            
            goto label_40;
            label_38:
            if(X22 != 0)
            {
                goto label_42;
            }
            
            label_40:
            label_42:
            X22.set_Item(key:  val_5, value:  X22.Item[val_5]);
            val_1.Add(item:  val_5);
            goto label_44;
            label_3:
            val_31 = 311;
            long val_20 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523042115840});
            this.domain.Clear();
            val_33 = 0;
            goto label_62;
            label_67:
            X20.Item[val_1.Item[0]].Clear();
            val_33 = 1;
            label_62:
            if(val_33 < val_1.Count)
            {
                goto label_67;
            }
        
        }
    
    }

}
