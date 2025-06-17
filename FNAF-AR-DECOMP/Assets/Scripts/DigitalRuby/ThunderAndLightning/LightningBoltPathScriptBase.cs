using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public abstract class LightningBoltPathScriptBase : LightningBoltPrefabScriptBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<UnityEngine.GameObject> LightningPath;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.List<UnityEngine.GameObject> currentPathObjects;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.List<UnityEngine.GameObject> GetCurrentPathObjects()
        {
            this.currentPathObjects.Clear();
            if(this.LightningPath == null)
            {
                    return (System.Collections.Generic.List<UnityEngine.GameObject>)this.currentPathObjects;
            }
            
            List.Enumerator<T> val_1 = this.LightningPath.GetEnumerator();
            do
            {
                if(((-1500938568) & 1) == 0)
            {
                    return (System.Collections.Generic.List<UnityEngine.GameObject>)this.currentPathObjects;
            }
            
                GameUI.EmailUIDataHandler val_2 = 0.emailUIDataHandler;
            }
            while(val_2 == 0);
            
            if(val_2.activeInHierarchy != false)
            {
                    this.currentPathObjects.Add(item:  val_2);
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override DigitalRuby.ThunderAndLightning.LightningBoltParameters OnCreateParameters()
        {
            var val_2 = null;
            val_1.Generator = DigitalRuby.ThunderAndLightning.LightningGenerator.GeneratorInstance;
            return (DigitalRuby.ThunderAndLightning.LightningBoltParameters)30311.OnCreateParameters();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected LightningBoltPathScriptBase()
        {
            this.currentPathObjects = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
    
    }

}
