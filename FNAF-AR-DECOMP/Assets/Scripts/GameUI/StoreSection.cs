using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreSection : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI TitleText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform SectionContents;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.StoreDomain.Data.DataDefinitions.StoreSectionData.DisplayType Type;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(Game.StoreDomain.Data.DataDefinitions.StoreSectionData data, Game.Store.StoreDomain storeDomain)
        {
            this.TitleText.text = data.DisplayName;
            this.Type = data.Type;
            this.Reset();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddItem(UnityEngine.Transform transform)
        {
            transform.SetParent(parent:  this.SectionContents, worldPositionStays:  false);
            if(this.gameObject.activeSelf != false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Reset()
        {
            var val_13;
            var val_14;
            var val_15;
            System.Collections.IEnumerator val_1 = this.SectionContents.GetEnumerator();
            label_21:
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_1.MoveNext() == false)
            {
                goto label_7;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_13 = val_1.Current;
            if(val_13 != null)
            {
                
            }
            
            if(val_13 != null)
            {
                    val_13 = 0;
            }
            
            UnityEngine.Object.Destroy(obj:  val_13.gameObject);
            goto label_21;
            label_7:
            val_14 = 0;
            val_15 = 62;
            if(val_1 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_1.Dispose();
            }
            
            this.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreSection()
        {
        
        }
    
    }

}
