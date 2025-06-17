using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class AnimatronicModsData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, int> _modsDict;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> modsDict { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, int> get_modsDict()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Int32>)this._modsDict;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicModsData()
        {
            this._modsDict = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AnimatronicModsData(System.Collections.Generic.Dictionary<string, int> modsDict)
        {
            var val_1 = (modsDict == 0) ? 0 : (this);
            if(modsDict != null)
            {
                    mem2[0] = modsDict;
                return;
            }
            
            System.ArgumentNullException val_2 = new System.ArgumentNullException(paramName:  "modsDict");
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddEntry(string modName, int number)
        {
            this._modsDict.Add(key:  modName, value:  number);
        }
    
    }

}
