using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StarDisplay : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.GameObject> stars;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetStars(int numStars)
        {
            var val_4 = 0;
            goto label_1;
            label_5:
            this.stars.Item[0].SetActive(value:  (val_4 < numStars) ? 1 : 0);
            val_4 = 1;
            label_1:
            if(val_4 < this.stars.Count)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StarDisplay()
        {
        
        }
    
    }

}
