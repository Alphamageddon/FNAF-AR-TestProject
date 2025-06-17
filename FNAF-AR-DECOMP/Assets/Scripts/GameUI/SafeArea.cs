using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SafeArea : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ConformX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool ConformY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SafeArea.SimDevice Sim;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform Panel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Rect LastSafeArea;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Rect[] NSA_iPhoneX;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.Panel = this.GetComponent<UnityEngine.RectTransform>();
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            UnityEngine.Rect val_1 = UnityEngine.Screen.safeArea;
            if((UnityEngine.Rect.op_Inequality(lhs:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height}, rhs:  new UnityEngine.Rect() {m_XMin = this.LastSafeArea})) == false)
            {
                    return;
            }
            
            this.ApplySafeArea(r:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Rect GetSafeArea()
        {
            return UnityEngine.Screen.safeArea;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ApplySafeArea(UnityEngine.Rect r)
        {
            float val_16;
            this.LastSafeArea = r;
            mem[1152921524918050764] = r.m_YMin;
            mem[1152921524918050768] = r.m_Width;
            mem[1152921524918050772] = r.m_Height;
            if(this.ConformX != true)
            {
                    r.m_XMin.distance = 0f;
                val_16 = (float)UnityEngine.Screen.width;
            }
            
            if(this.ConformY != true)
            {
                    val_16 = (float)UnityEngine.Screen.height;
            }
            
            UnityEngine.Vector2 val_3 = r.m_XMin.position;
            float val_16 = val_3.x;
            float val_17 = val_3.y;
            UnityEngine.Vector2 val_4 = r.m_XMin.position;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            float val_18 = val_5.x;
            float val_19 = val_5.y;
            val_16 = val_16 / (float)UnityEngine.Screen.width;
            val_17 = val_17 / (float)UnityEngine.Screen.height;
            val_18 = val_18 / (float)UnityEngine.Screen.width;
            val_19 = val_19 / (float)UnityEngine.Screen.height;
            this.Panel.anchorMin = new UnityEngine.Vector2() {x = val_16, y = val_17};
            this.Panel.anchorMax = new UnityEngine.Vector2() {x = val_18, y = val_19};
            object[] val_10 = new object[7];
            string val_11 = this.name;
            if(val_10 == null)
            {
                goto label_7;
            }
            
            if(val_11 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_11 == null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            val_10[0] = val_11;
            float val_12 = r.m_XMin.System.IConvertible.ToSingle(provider:  0);
            val_10[1] = val_12;
            val_10[2] = val_12;
            val_10[3] = val_12;
            val_10[4] = val_12;
            val_10[5] = UnityEngine.Screen.width;
            val_10[6] = UnityEngine.Screen.height;
            string val_15 = System.String.Format(format:  "New safe area applied to {0}: x={1}, y={2}, w={3}, h={4} on full extents w={5}, h={6}", args:  val_10);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SafeArea()
        {
            this.ConformX = true;
            this.ConformY = true;
            this.LastSafeArea = 0;
            mem[1152921524918211996] = 0;
            mem[1152921524918212004] = 0;
            UnityEngine.Rect[] val_1 = new UnityEngine.Rect[2];
            val_1[0] = 0;
            val_1[0] = 0;
            val_1[0] = 0;
            val_1[0] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            this.NSA_iPhoneX = val_1;
        }
    
    }

}
