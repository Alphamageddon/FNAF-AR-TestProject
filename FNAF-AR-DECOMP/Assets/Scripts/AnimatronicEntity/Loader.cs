using UnityEngine;

namespace AnimatronicEntity
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Loader
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<AnimatronicEntity.Loader.LoadedArgs> LoadedEvent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private AnimatronicEntity.AnimatronicEntityDomain _animatronicEntityDomain;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_LoadedEvent(System.Action<AnimatronicEntity.Loader.LoadedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.LoadedEvent, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoadedEvent != 1152921525032905584);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_LoadedEvent(System.Action<AnimatronicEntity.Loader.LoadedArgs> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.LoadedEvent, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.LoadedEvent != 1152921525033042160);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Loader(AnimatronicEntity.AnimatronicEntityDomain animatronicEntityDomain)
        {
            this._animatronicEntityDomain = animatronicEntityDomain;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ParseAndLoadNewEntities(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> saveGameChunks, out System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> entitiesAdded, out System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> entitiesKept, out System.Collections.Generic.HashSet<string> loadedEntityIds)
        {
            var val_6;
            var val_14 = 1152921525033424800;
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_1 = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
            entitiesAdded = val_1;
            System.Collections.Generic.HashSet<System.String> val_2 = new System.Collections.Generic.HashSet<System.String>();
            loadedEntityIds = val_2;
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_3 = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
            entitiesKept = val_3;
            List.Enumerator<T> val_4 = saveGameChunks.GetEnumerator();
            label_17:
            if(((-1048314944) & 1) == 0)
            {
                    return;
            }
            
            bool val_8 = val_2.Add(item:  val_7._masterDomain);
            if((this._animatronicEntityDomain.<container>k__BackingField.ContainsEntity(entityId:  val_7._masterDomain)) == false)
            {
                goto label_7;
            }
            
            val_3.Add(item:  this._animatronicEntityDomain.<container>k__BackingField.GetEntity(entityId:  val_7._masterDomain));
            goto label_17;
            label_7:
            AnimatronicEntity.AnimatronicEntity val_11 = this._animatronicEntityDomain.<creator>k__BackingField.CreateEntity(saveGameChunk:  val_6.emailUIDataHandler);
            this._animatronicEntityDomain.<container>k__BackingField.AddEntity(entity:  val_11);
            val_1.Add(item:  val_11);
            goto label_17;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PruneOldEntities(System.Collections.Generic.HashSet<string> loadedEntityIds)
        {
            var val_13;
            var val_14;
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_1 = new System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity>();
            var val_13 = 0;
            val_13 = val_13 + 1;
            System.Collections.Generic.IEnumerator<T> val_3 = this._animatronicEntityDomain.<container>k__BackingField._animatronicEntities.GetEnumerator();
            label_23:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            if((loadedEntityIds.Contains(item:  val_7 + 40)) == true)
            {
                goto label_23;
            }
            
            val_1.Add(item:  val_3.Current);
            goto label_23;
            label_13:
            val_13 = 0;
            val_14 = 78;
            if(val_3 == null)
            {
                
            }
            else
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_3.Dispose();
            }
            
            if( != 78)
            {
                goto label_36;
            }
            
            if(val_1 != null)
            {
                goto label_40;
            }
            
            goto label_38;
            label_36:
            if( != false)
            {
                    val_13 = 0;
            }
            
            if(val_1 != null)
            {
                goto label_40;
            }
            
            label_38:
            label_40:
            List.Enumerator<T> val_10 = val_1.GetEnumerator();
            label_44:
            if(((-1048080184) & 1) == 0)
            {
                goto label_45;
            }
            
            this._animatronicEntityDomain.<container>k__BackingField.RemoveEntity(entity:  0.emailUIDataHandler);
            goto label_44;
            label_45:
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525033603272});
            if( == 0)
            {
                    return;
            }
            
            if(139 == 0)
            {
                    return;
            }
            
            if(139 == 139)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadSaveGameChunks(System.Collections.Generic.List<AnimatronicEntity.SaveGameChunk> saveGameChunks)
        {
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_5;
            System.Collections.Generic.HashSet<System.String> val_3 = 0;
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_2 = 0;
            System.Collections.Generic.List<AnimatronicEntity.AnimatronicEntity> val_1 = 0;
            this.ParseAndLoadNewEntities(saveGameChunks:  saveGameChunks, entitiesAdded: out  val_1, entitiesKept: out  val_2, loadedEntityIds: out  val_3);
            this.PruneOldEntities(loadedEntityIds:  val_3);
            if(this.LoadedEvent == null)
            {
                    return;
            }
            
            Loader.LoadedArgs val_4 = new Loader.LoadedArgs();
            if(val_4 != null)
            {
                    .newEntitiesAdded = val_1;
                val_5 = val_2;
            }
            else
            {
                    mem[16] = val_1;
                val_5 = val_2;
            }
            
            .existingEntitiesKept = val_5;
            this.LoadedEvent.Invoke(obj:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RegisterLoadedEvent(System.Action<AnimatronicEntity.Loader.LoadedArgs> callback)
        {
            this.LoadedEvent = callback;
        }
    
    }

}
