using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.RectTransform TextPopup_Prefab_01;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RectTransform m_TextPopup_RectTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI m_TextPopup_TMPComponent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string k_LinkText = "You have selected link <#ffff00>";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string k_WordText = "Word Index: <#ffff00>";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI m_TextMeshPro;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Canvas m_Canvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera m_Camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool isHoveringObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_selectedWord;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_selectedLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_lastIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Matrix4x4 m_matrix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_MeshInfo[] m_cachedMeshInfoVertexData;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            UnityEngine.Camera val_11;
            this.m_TextMeshPro = this.gameObject.GetComponent<TMPro.TextMeshProUGUI>();
            UnityEngine.Canvas val_4 = this.gameObject.GetComponentInParent<UnityEngine.Canvas>();
            this.m_Canvas = val_4;
            if(val_4.renderMode != 0)
            {
                    UnityEngine.Camera val_6 = this.m_Canvas.worldCamera;
            }
            else
            {
                    val_11 = 0;
            }
            
            this.m_Camera = val_11;
            UnityEngine.RectTransform val_7 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.TextPopup_Prefab_01);
            this.m_TextPopup_RectTransform = val_7;
            val_7.SetParent(parent:  this.m_Canvas.transform, worldPositionStays:  false);
            this.m_TextPopup_TMPComponent = this.m_TextPopup_RectTransform.GetComponentInChildren<TMPro.TextMeshProUGUI>();
            this.m_TextPopup_RectTransform.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Add(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.TMP_TextSelector_B::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            null = null;
            TMPro.TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(rhs:  new System.Action<UnityEngine.Object>(object:  this, method:  System.Void TMPro.Examples.TMP_TextSelector_B::ON_TEXT_CHANGED(UnityEngine.Object obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            if(obj != this.m_TextMeshPro)
            {
                    return;
            }
            
            this.m_cachedMeshInfoVertexData = this.m_TextMeshPro.textInfo.CopyMeshInfoVertexData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            var val_30;
            var val_31;
            var val_32;
            UnityEngine.Matrix4x4 val_33;
            TMPro.TextMeshProUGUI val_98;
            var val_99;
            float val_100;
            float val_101;
            float val_102;
            int val_103;
            var val_104;
            float val_105;
            var val_106;
            var val_107;
            float val_108;
            int val_109;
            UnityEngine.Camera val_110;
            float val_111;
            float val_112;
            int val_113;
            string val_114;
            val_98 = this;
            if(this.isHoveringObject == false)
            {
                goto label_1;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            val_99 = 1152921505046835200;
            val_100 = val_1.x;
            val_101 = val_1.y;
            val_102 = val_1.z;
            int val_2 = TMPro.TMP_TextUtilities.FindIntersectingCharacter(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = val_100, y = val_101, z = val_102}, camera:  this.m_Camera, visibleOnly:  true);
            if(val_2 == 1)
            {
                goto label_4;
            }
            
            val_103 = val_2;
            if(val_2 != this.m_lastIndex)
            {
                    this.RestoreCachedVertexAttributes(index:  this.m_lastIndex);
                val_103 = 0;
                this.m_lastIndex = val_103;
            }
            
            if(val_2 == val_103)
            {
                goto label_70;
            }
            
            if((UnityEngine.Input.GetKey(key:  48)) != true)
            {
                    if((UnityEngine.Input.GetKey(key:  47)) == false)
            {
                goto label_70;
            }
            
            }
            
            this.m_lastIndex = val_2;
            TMPro.TMP_TextInfo val_5 = this.m_TextMeshPro.textInfo;
            var val_6 = val_5.characterInfo + ((long)val_2 * 344);
            TMPro.TMP_TextInfo val_7 = this.m_TextMeshPro.textInfo;
            var val_8 = val_7.characterInfo + ((long)val_2 * 344);
            var val_97 = ((long)(int)(val_2) * 344) + val_7.characterInfo + 108;
            TMPro.TMP_TextInfo val_9 = this.m_TextMeshPro.textInfo;
            var val_10 = val_9.meshInfo + ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88) * 72);
            val_104 = mem[(((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 24];
            val_104 = (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 24;
            if(val_97 >= val_104)
            {
                    val_104 = mem[(((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 24];
                val_104 = (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 24;
            }
            
            var val_11 = ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48) + (val_97 * 12);
            var val_13 = ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48) + (((long)val_97 + 2) * 12);
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32, y = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4, z = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  2f);
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            UnityEngine.Vector3 val_17 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_16.x, y = val_16.y});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32, y = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4, z = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            mem2[0] = val_18.x;
            mem2[0] = val_18.y;
            mem2[0] = val_18.z;
            var val_20 = ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48) + (((long)val_97 + 1) * 12);
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            mem2[0] = val_21.x;
            mem2[0] = val_21.y;
            mem2[0] = val_21.z;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            mem2[0] = val_22.x;
            mem2[0] = val_22.y;
            mem2[0] = val_22.z;
            val_97 = ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48) + (((long)val_97 + 3) * 12);
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            mem2[0] = val_24.x;
            mem2[0] = val_24.y;
            mem2[0] = val_24.z;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_26 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, d:  1.5f);
            val_105 = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32;
            UnityEngine.Matrix4x4 val_29 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, q:  new UnityEngine.Quaternion() {x = val_26.x, y = val_26.y, z = val_26.z, w = val_26.w}, s:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.z});
            mem[1152921524674476536] = val_30;
            mem[1152921524674476520] = val_31;
            mem[1152921524674476504] = val_32;
            this.m_matrix = val_33;
            mem2[0] = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32;
            mem2[0] = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4;
            mem2[0] = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8;
            mem2[0] = val_105;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32, y = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4, z = (((long)(int)(val_2) * 344) + val_7.characterInfo + 108 * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            mem2[0] = val_34.x;
            mem2[0] = val_34.y;
            mem2[0] = val_34.z;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32, y = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            mem2[0] = val_35.x;
            mem2[0] = val_35.y;
            mem2[0] = val_35.z;
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_105, y = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4, z = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            val_99 = 1152921505046835200;
            mem2[0] = val_36.x;
            mem2[0] = val_36.y;
            mem2[0] = val_36.z;
            val_100 = mem[((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32];
            val_100 = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32;
            val_102 = mem[((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8];
            val_102 = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 8;
            val_101 = mem[((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4];
            val_101 = ((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3)) * 12) + (((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 32 + 4;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_100, y = val_101, z = val_102}, b:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            mem2[0] = val_37.x;
            mem2[0] = val_37.y;
            mem2[0] = val_37.z;
            TMPro.TMP_TextInfo val_38 = this.m_TextMeshPro.textInfo;
            val_106 = ((long)(int)(val_2) * 344) + val_5.characterInfo + 88;
            val_107 = val_97;
            var val_39 = val_38.meshInfo + (val_106 * 72);
            var val_40 = ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_38.meshInfo + 88) + ((((long)(int)(val_2) * 344) + val_7.characterInfo + 108) << 2);
            mem2[0] = 0;
            var val_41 = ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_38.meshInfo + 88) + (((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 1))) << 2);
            mem2[0] = 0;
            var val_42 = ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_38.meshInfo + 88) + (((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 2))) << 2);
            mem2[0] = 0;
            var val_43 = ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_38.meshInfo + 88) + (((long)(int)((((long)(int)(val_2) * 344) + val_7.characterInfo + 108 + 3))) << 2);
            mem2[0] = 0;
            TMPro.TMP_TextInfo val_44 = this.m_TextMeshPro.textInfo;
            var val_46 = (val_44.meshInfo + (val_106 * 72)) + 32;
            var val_47 = ((((long)(int)(val_2) * 344) + val_5.characterInfo + 88 * 72) + val_9.meshInfo + 48 + 24) - 4;
            if(this.m_TextMeshPro != null)
            {
                goto label_70;
            }
            
            goto label_70;
            label_1:
            if(this.m_lastIndex == 1)
            {
                    return;
            }
            
            this.RestoreCachedVertexAttributes(index:  this.m_lastIndex);
            this.m_lastIndex = 0;
            return;
            label_4:
            this.RestoreCachedVertexAttributes(index:  this.m_lastIndex);
            this.m_lastIndex = 0;
            label_70:
            UnityEngine.Vector3 val_48 = UnityEngine.Input.mousePosition;
            val_108 = val_48.x;
            int val_49 = TMPro.TMP_TextUtilities.FindIntersectingWord(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = val_108, y = val_48.y, z = val_48.z}, camera:  this.m_Camera);
            if((this.m_TextPopup_RectTransform == 0) || (this.m_selectedWord == 1))
            {
                goto label_78;
            }
            
            if(val_49 == 1)
            {
                goto label_79;
            }
            
            val_109 = val_49;
            if(val_49 == this.m_selectedWord)
            {
                goto label_80;
            }
            
            label_79:
            TMPro.TMP_TextInfo val_51 = this.m_TextMeshPro.textInfo;
            var val_98 = 24;
            val_98 = val_51.wordInfo + (this.m_selectedWord * val_98);
            var val_99 = (this.m_selectedWord * 24) + val_51.wordInfo + 48;
            if(val_99 >= 1)
            {
                    val_107 = 72;
                do
            {
                TMPro.TMP_TextInfo val_52 = this.m_TextMeshPro.textInfo;
                var val_53 = val_52.characterInfo + (((long)(this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344);
                TMPro.TMP_TextInfo val_54 = this.m_TextMeshPro.textInfo;
                var val_55 = val_54.characterInfo + (((long)(this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344);
                TMPro.TMP_TextInfo val_56 = this.m_TextMeshPro.textInfo;
                var val_57 = val_56.meshInfo + ((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_52.characterInfo + 88) * 72);
                val_105 = mem[(((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_52.characterInfo + 88 * 72) + val_56.meshInfo + 88];
                val_105 = (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_52.characterInfo + 88 * 72) + val_56.meshInfo + 88;
                var val_58 = val_105 + ((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_54.characterInfo + 108) << 2);
                val_108 = 1.33333f;
                UnityEngine.Color32 val_59 = TMPro.TMPro_ExtensionMethods.Tint(c1:  new UnityEngine.Color32() {r = ((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_52.characterInfo + 88 * 72) + val_56.meshInfo + 88 + (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 3 + 32, g = ((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_52.characterInfo + 88 * 72) + val_56.meshInfo + 88 + (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 3 + 32, b = ((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_52.characterInfo + 88 * 72) + val_56.meshInfo + 88 + (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 3 + 32, a = ((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_52.characterInfo + 88 * 72) + val_56.meshInfo + 88 + (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 3 + 32}, tint:  1.33333f);
                mem2[0] = val_59.r;
                mem[1] = val_59.g;
                mem[2] = val_59.b;
                mem[3] = val_59.a;
                var val_60 = (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_54.characterInfo + 108) + 1;
                var val_61 = val_105 + (((long)(int)((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_54.characterInfo + 108 + 1))) << 2);
                mem2[0] = val_59.r;
                mem[1] = val_59.g;
                mem[2] = val_59.b;
                mem[3] = val_59.a;
                var val_62 = (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_54.characterInfo + 108) + 2;
                var val_63 = val_105 + (((long)(int)((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_54.characterInfo + 108 + 2))) << 2);
                mem2[0] = val_59.r;
                mem[1] = val_59.g;
                mem[2] = val_59.b;
                mem[3] = val_59.a;
                var val_64 = (((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_54.characterInfo + 108) + 3;
                var val_65 = val_105 + (((long)(int)((((long)(int)((this.m_selectedWord * 24) + val_51.wordInfo + 40) * 344) + val_54.characterInfo + 108 + 3))) << 2);
                val_99 = val_99 - 1;
                val_106 = ((this.m_selectedWord * 24) + val_51.wordInfo + 40) + 1;
                mem2[0] = val_59.r;
                mem[1] = val_59.g;
                mem[2] = val_59.b;
                mem[3] = val_59.a;
            }
            while(val_99 != 0);
            
            }
            
            this.m_selectedWord = 0;
            val_99 = 1152921505046835200;
            label_78:
            if(val_49 == 1)
            {
                goto label_109;
            }
            
            val_109 = this.m_selectedWord;
            label_80:
            if(((val_49 != val_109) && ((UnityEngine.Input.GetKey(key:  48)) != true)) && ((UnityEngine.Input.GetKey(key:  47)) != true))
            {
                    this.m_selectedWord = val_49;
                TMPro.TMP_TextInfo val_68 = this.m_TextMeshPro.textInfo;
                var val_100 = 24;
                val_100 = val_68.wordInfo + ((long)val_49 * val_100);
                var val_101 = ((long)(int)(val_49) * 24) + val_68.wordInfo + 48;
                if(val_101 >= 1)
            {
                    var val_102 = ((long)(int)(val_49) * 24) + val_68.wordInfo + 40;
                val_106 = 344;
                do
            {
                TMPro.TMP_TextInfo val_69 = this.m_TextMeshPro.textInfo;
                var val_70 = val_69.characterInfo + ((long)val_102 * 344);
                TMPro.TMP_TextInfo val_71 = this.m_TextMeshPro.textInfo;
                var val_72 = val_71.characterInfo + ((long)val_102 * 344);
                TMPro.TMP_TextInfo val_73 = this.m_TextMeshPro.textInfo;
                var val_74 = val_73.meshInfo + ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_69.characterInfo + 88) * 72);
                var val_75 = ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_69.characterInfo + 88 * 72) + val_73.meshInfo + 88) + ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_71.characterInfo + 108) << 2);
                val_108 = 0.75f;
                UnityEngine.Color32 val_76 = TMPro.TMPro_ExtensionMethods.Tint(c1:  new UnityEngine.Color32() {r = ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_69.characterInfo + 88 * 72) + val_73.meshInfo + 88 + (((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 3 + 32, g = ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_69.characterInfo + 88 * 72) + val_73.meshInfo + 88 + (((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 3 + 32, b = ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_69.characterInfo + 88 * 72) + val_73.meshInfo + 88 + (((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 3 + 32, a = ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_69.characterInfo + 88 * 72) + val_73.meshInfo + 88 + (((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 3 + 32}, tint:  val_108);
                mem2[0] = val_76.r;
                mem[1] = val_76.g;
                mem[2] = val_76.b;
                mem[3] = val_76.a;
                var val_77 = (((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_71.characterInfo + 108) + 1;
                var val_78 = ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_69.characterInfo + 88 * 72) + val_73.meshInfo + 88) + (((long)(int)((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_71.characterInfo + 108 + 1))) << 2);
                mem2[0] = val_76.r;
                mem[1] = val_76.g;
                mem[2] = val_76.b;
                mem[3] = val_76.a;
                val_105 = (long)(((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_71.characterInfo + 108) + 2;
                var val_80 = ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_69.characterInfo + 88 * 72) + val_73.meshInfo + 88) + (((long)(int)((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_71.characterInfo + 108 + 2))) << 2);
                mem2[0] = val_76.r;
                mem[1] = val_76.g;
                mem[2] = val_76.b;
                mem[3] = val_76.a;
                val_107 = (long)(((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_71.characterInfo + 108) + 3;
                var val_82 = ((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_69.characterInfo + 88 * 72) + val_73.meshInfo + 88) + (((long)(int)((((long)(int)(((long)(int)(val_49) * 24) + val_68.wordInfo + 40) * 344) + val_71.characterInfo + 108 + 3))) << 2);
                val_101 = val_101 - 1;
                val_102 = val_102 + 1;
                mem2[0] = val_76.r;
                mem[1] = val_76.g;
                mem[2] = val_76.b;
                mem[3] = val_76.a;
            }
            while(val_101 != 0);
            
            }
            
                val_99 = val_99;
            }
            
            label_109:
            UnityEngine.Vector3 val_83 = UnityEngine.Input.mousePosition;
            val_110 = this.m_Camera;
            val_111 = val_83.x;
            val_112 = val_83.z;
            int val_84 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = val_111, y = val_83.y, z = val_112}, camera:  val_110);
            if(val_84 == 1)
            {
                goto label_137;
            }
            
            label_140:
            val_113 = val_84;
            if(val_84 != this.m_selectedLink)
            {
                goto label_138;
            }
            
            goto label_139;
            label_137:
            if(this.m_selectedLink == 1)
            {
                goto label_140;
            }
            
            label_138:
            val_110 = this.m_TextPopup_RectTransform.gameObject;
            val_110.SetActive(value:  false);
            val_113 = 0;
            this.m_selectedLink = val_113;
            label_139:
            if(val_84 == 1)
            {
                    return;
            }
            
            if(val_84 == val_113)
            {
                    return;
            }
            
            this.m_selectedLink = val_84;
            TMPro.TMP_TextInfo val_86 = this.m_TextMeshPro.textInfo;
            var val_87 = val_86.linkInfo + ((long)val_84 * 40);
            UnityEngine.Vector3 val_88 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_90 = UnityEngine.Input.mousePosition;
            val_112 = val_90.z;
            UnityEngine.Vector2 val_91 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_90.x, y = val_90.y, z = val_112});
            val_110 = this.m_Camera;
            val_111 = val_91.x;
            bool val_92 = UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle(rect:  this.m_TextMeshPro.rectTransform, screenPoint:  new UnityEngine.Vector2() {x = val_111, y = val_91.y}, cam:  val_110, worldPoint: out  new UnityEngine.Vector3() {x = val_88.x, y = val_88.y, z = val_88.z});
            if((System.String.op_Equality(a:  ((long)(int)(val_84) * 40) + val_86.linkInfo + 32, b:  "id_01")) != false)
            {
                    val_111 = val_88.x;
                val_112 = val_88.z;
                this.m_TextPopup_RectTransform.position = new UnityEngine.Vector3() {x = val_111, y = val_88.y, z = val_112};
                this.m_TextPopup_RectTransform.gameObject.SetActive(value:  true);
                val_98 = this.m_TextPopup_TMPComponent;
                val_114 = "You have selected link <#ffff00> ID 01";
            }
            else
            {
                    if((System.String.op_Equality(a:  ((long)(int)(val_84) * 40) + val_86.linkInfo + 32, b:  "id_02")) == false)
            {
                    return;
            }
            
                val_111 = val_88.x;
                val_112 = val_88.z;
                this.m_TextPopup_RectTransform.position = new UnityEngine.Vector3() {x = val_111, y = val_88.y, z = val_112};
                this.m_TextPopup_RectTransform.gameObject.SetActive(value:  true);
                val_98 = this.m_TextPopup_TMPComponent;
                val_114 = "You have selected link <#ffff00> ID 02";
            }
            
            val_98.text = val_114;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.isHoveringObject = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.isHoveringObject = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RestoreCachedVertexAttributes(int index)
        {
            if(index == 1)
            {
                    return;
            }
            
            TMPro.TMP_TextInfo val_1 = this.m_TextMeshPro.textInfo;
            int val_84 = val_1.characterCount;
            val_84 = val_84 - 1;
            if(val_84 < index)
            {
                    return;
            }
            
            TMPro.TMP_TextInfo val_2 = this.m_TextMeshPro.textInfo;
            var val_3 = val_2.characterInfo + ((long)index * 344);
            TMPro.TMP_TextInfo val_4 = this.m_TextMeshPro.textInfo;
            var val_5 = val_4.characterInfo + ((long)index * 344);
            var val_6 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            TMPro.TMP_TextInfo val_7 = this.m_TextMeshPro.textInfo;
            var val_8 = val_7.meshInfo + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            var val_85 = 12;
            val_85 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48) + ((((long)(int)(index) * 344) + val_4.characterInfo + 108) * val_85);
            var val_86 = 12;
            val_86 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_7.meshInfo + 48) + ((((long)(int)(index) * 344) + val_4.characterInfo + 108) * val_86);
            mem2[0] = (((long)(int)(index) * 344) + val_4.characterInfo + 108 * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            mem2[0] = (((long)(int)(index) * 344) + val_4.characterInfo + 108 * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32 + 4;
            mem2[0] = (((long)(int)(index) * 344) + val_4.characterInfo + 108 * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            var val_87 = 12;
            val_87 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)(((long)(int)(index) * 344) + val_4.characterInfo + 108) + 1) * val_87);
            var val_88 = 12;
            val_88 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_7.meshInfo + 48) + (((long)(((long)(int)(index) * 344) + val_4.characterInfo + 108) + 1) * val_88);
            mem2[0] = ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1)) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            mem2[0] = ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1)) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1)) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            var val_89 = 12;
            val_89 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)(((long)(int)(index) * 344) + val_4.characterInfo + 108) + 2) * val_89);
            var val_90 = 12;
            val_90 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_7.meshInfo + 48) + (((long)(((long)(int)(index) * 344) + val_4.characterInfo + 108) + 2) * val_90);
            mem2[0] = ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2)) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            mem2[0] = ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2)) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2)) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            var val_91 = 12;
            val_91 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)(((long)(int)(index) * 344) + val_4.characterInfo + 108) + 3) * val_91);
            var val_92 = 12;
            val_92 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_7.meshInfo + 48) + (((long)(((long)(int)(index) * 344) + val_4.characterInfo + 108) + 3) * val_92);
            mem2[0] = ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3)) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            mem2[0] = ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3)) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3)) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            TMPro.TMP_TextInfo val_12 = this.m_TextMeshPro.textInfo;
            var val_13 = val_12.meshInfo + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            var val_14 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            var val_15 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88) + ((((long)(int)(index) * 344) + val_4.characterInfo + 108) << 2);
            var val_16 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_12.meshInfo + 88) + ((((long)(int)(index) * 344) + val_4.characterInfo + 108) << 2);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88 + (((long)(int)(index) * 344) + val_4.characterInfo + 108) << 2) + 32;
            var val_17 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 2);
            var val_18 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_12.meshInfo + 88) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 2);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 2) + 32;
            var val_19 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 2);
            var val_20 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_12.meshInfo + 88) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 2);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 2) + 32;
            var val_21 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 2);
            var val_22 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_12.meshInfo + 88) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 2);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 2) + 32;
            var val_23 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            TMPro.TMP_TextInfo val_24 = this.m_TextMeshPro.textInfo;
            var val_25 = val_24.meshInfo + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            var val_26 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72) + ((((long)(int)(index) * 344) + val_4.characterInfo + 108) << 3);
            var val_27 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_24.meshInfo + 72) + ((((long)(int)(index) * 344) + val_4.characterInfo + 108) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + (((long)(int)(index) * 344) + val_4.characterInfo + 108) << 3) + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + (((long)(int)(index) * 344) + val_4.characterInfo + 108) << 3) + 32 + 4;
            var val_28 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 3);
            var val_29 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_24.meshInfo + 72) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 3) + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 3) + 32 + 4;
            var val_30 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 3);
            var val_31 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_24.meshInfo + 72) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 3) + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 3) + 32 + 4;
            var val_32 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 3);
            var val_33 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_24.meshInfo + 72) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 3) + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 3) + 32 + 4;
            var val_34 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            TMPro.TMP_TextInfo val_35 = this.m_TextMeshPro.textInfo;
            var val_36 = val_35.meshInfo + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            var val_37 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80) + ((((long)(int)(index) * 344) + val_4.characterInfo + 108) << 3);
            var val_38 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_35.meshInfo + 80) + ((((long)(int)(index) * 344) + val_4.characterInfo + 108) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + (((long)(int)(index) * 344) + val_4.characterInfo + 108) << 3) + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + (((long)(int)(index) * 344) + val_4.characterInfo + 108) << 3) + 32 + 4;
            var val_39 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 3);
            var val_40 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_35.meshInfo + 80) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 3) + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 1))) << 3) + 32 + 4;
            var val_41 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 3);
            var val_42 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_35.meshInfo + 80) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 3) + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 2))) << 3) + 32 + 4;
            var val_43 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 3);
            var val_44 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_35.meshInfo + 80) + (((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 3) + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((long)(int)(index) * 344) + val_4.characterInfo + 108 + 3))) << 3) + 32 + 4;
            var val_46 = (((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24) < 0) ? (((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24) + 3) : ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24);
            var val_47 = val_46 & 4294967292;
            val_46 = val_47 - 4;
            var val_93 = 12;
            val_93 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48) + ((long)val_46 * val_93);
            var val_94 = 12;
            val_94 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_7.meshInfo + 48) + ((long)val_46 * val_94);
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            var val_95 = 12;
            val_95 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)val_47 - 3) * val_95);
            var val_96 = 12;
            val_96 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_7.meshInfo + 48) + (((long)val_47 - 3) * val_96);
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            var val_97 = 12;
            val_97 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)val_47 - 2) * val_97);
            var val_98 = 12;
            val_98 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_7.meshInfo + 48) + (((long)val_47 - 2) * val_98);
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            var val_99 = 12;
            val_99 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48) + (((long)val_47 - 1) * val_99);
            var val_100 = 12;
            val_100 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_7.meshInfo + 48) + (((long)val_47 - 1) * val_100);
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 32 + 4;
            mem2[0] = ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo) * 12) + (((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 40;
            var val_51 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            TMPro.TMP_TextInfo val_52 = this.m_TextMeshPro.textInfo;
            var val_53 = val_52.meshInfo + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            var val_54 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 2);
            var val_55 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_52.meshInfo + 88) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 2);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            var val_56 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 2);
            var val_57 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_52.meshInfo + 88) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 2);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            var val_58 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 2);
            var val_59 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_52.meshInfo + 88) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 2);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            var val_60 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 2);
            var val_61 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_52.meshInfo + 88) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 2);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 88 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            var val_62 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            TMPro.TMP_TextInfo val_63 = this.m_TextMeshPro.textInfo;
            var val_64 = val_63.meshInfo + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            var val_65 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            var val_66 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_63.meshInfo + 72) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32 + 4;
            var val_67 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            var val_68 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_63.meshInfo + 72) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32 + 4;
            var val_69 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            var val_70 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_63.meshInfo + 72) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32 + 4;
            var val_71 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            var val_72 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_63.meshInfo + 72) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 72 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32 + 4;
            var val_73 = this.m_cachedMeshInfoVertexData + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            TMPro.TMP_TextInfo val_74 = this.m_TextMeshPro.textInfo;
            var val_75 = val_74.meshInfo + ((((long)(int)(index) * 344) + val_2.characterInfo + 88) * 72);
            var val_76 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            var val_77 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_74.meshInfo + 80) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32 + 4;
            var val_78 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            var val_79 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_74.meshInfo + 80) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32 + 4;
            var val_80 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            var val_81 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_74.meshInfo + 80) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32 + 4;
            var val_82 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            var val_83 = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + val_74.meshInfo + 80) + (((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 48 + 24 < 0x0 ? ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfo)) << 3);
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32;
            mem2[0] = ((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshInfoVertexData + 80 + ((long)(int)((((((long)(int)(index) * 344) + val_2.characterInfo + 88 * 72) + this.m_cachedMeshIn + 32 + 4;
            if(this.m_TextMeshPro == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMP_TextSelector_B()
        {
            this.m_selectedWord = 0;
            this.m_selectedLink = 0;
            this.m_lastIndex = 0;
        }
    
    }

}
