using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SaveChunkGetter : EntitySaveChunkGetter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SaveChunkGetter(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> GetSaveGameChunks()
        {
            var val_10;
            var val_11;
            System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> val_1 = new System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk>();
            var val_10 = 0;
            val_10 = val_10 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = this._animatronicEntityDomain.<container>k__BackingField._animatronicEntities.GetEnumerator();
            label_20:
            var val_11 = 0;
            val_11 = val_11 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            new AnimatronicEntity.SaveGameChunk() = new AnimatronicEntity.SaveGameChunk(animatronicEntity:  val_3.Current);
            val_1.Add(item:  new AnimatronicEntity.SaveGameChunk());
            goto label_20;
            label_13:
            val_10 = 0;
            val_11 = 69;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_13 = 0;
                val_13 = val_13 + 1;
                val_3.Dispose();
            }
            
            if( == 69)
            {
                    return val_1;
            }
            
            if( == false)
            {
                    return val_1;
            }
            
            return val_1;
        }
    
    }

}
