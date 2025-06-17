using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TrafficUvAnimator : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Material[] Materials;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float Speed;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 _offset;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            UnityEngine.Vector2 val_3;
            var val_4;
            val_3 = this._offset;
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_1 * this.Speed;
            val_1 = val_3 + val_1;
            1152921519866064804 = new UnityEngine.Vector2(x:  val_1, y:  0.2f);
            val_4 = 0;
            goto label_1;
            label_5:
            val_3 = this._offset;
            this.Materials[0].SetTextureOffset(name:  "_MainTex", value:  new UnityEngine.Vector2() {x = val_3, y = V9.16B});
            val_4 = 1;
            label_1:
            if(val_4 < this.Materials.Length)
            {
                goto label_5;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TrafficUvAnimator()
        {
        
        }
    
    }

}
