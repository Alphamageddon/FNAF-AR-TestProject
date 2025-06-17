using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshPro m_TextMeshPro;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera m_Camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool m_isHoveringObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_selectedLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_lastCharIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_lastWordIndex;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.m_TextMeshPro = this.gameObject.GetComponent<TMPro.TextMeshPro>();
            this.m_Camera = UnityEngine.Camera.main;
            if(this.m_TextMeshPro == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            var val_65;
            float val_66;
            UnityEngine.Camera val_67;
            var val_68;
            var val_69;
            float val_70;
            float val_71;
            float val_72;
            int val_73;
            var val_74;
            val_65 = this;
            this.m_isHoveringObject = false;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_66 = val_2.x;
            val_67 = UnityEngine.Camera.main;
            if((TMPro.TMP_TextUtilities.IsIntersectingRectTransform(rectTransform:  this.m_TextMeshPro.rectTransform, position:  new UnityEngine.Vector3() {x = val_66, y = val_2.y, z = val_2.z}, camera:  val_67)) != false)
            {
                    this.m_isHoveringObject = true;
            }
            else
            {
                    if(this.m_isHoveringObject == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
            int val_7 = TMPro.TMP_TextUtilities.FindIntersectingCharacter(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, camera:  UnityEngine.Camera.main, visibleOnly:  true);
            if((val_7 != 1) && (val_7 != this.m_lastCharIndex))
            {
                    if((UnityEngine.Input.GetKey(key:  48)) != true)
            {
                    if((UnityEngine.Input.GetKey(key:  47)) == false)
            {
                goto label_12;
            }
            
            }
            
                this.m_lastCharIndex = val_7;
                TMPro.TMP_TextInfo val_10 = this.m_TextMeshPro.textInfo;
                var val_11 = val_10.characterInfo + ((long)val_7 * 344);
                val_68 = mem[((long)(int)(val_7) * 344) + val_10.characterInfo + 88];
                val_68 = ((long)(int)(val_7) * 344) + val_10.characterInfo + 88;
                TMPro.TMP_TextInfo val_12 = this.m_TextMeshPro.textInfo;
                var val_13 = val_12.characterInfo + ((long)val_7 * 344);
                int val_14 = UnityEngine.Random.Range(min:  0, max:  255);
                int val_15 = UnityEngine.Random.Range(min:  0, max:  255);
                int val_16 = UnityEngine.Random.Range(min:  0, max:  255);
                TMPro.TMP_TextInfo val_17 = this.m_TextMeshPro.textInfo;
                var val_18 = val_17.meshInfo + (val_68 * 72);
                var val_19 = ((((long)(int)(val_7) * 344) + val_10.characterInfo + 88 * 72) + val_17.meshInfo + 88) + ((((long)(int)(val_7) * 344) + val_12.characterInfo + 108) << 2);
                mem2[0] = 0;
                var val_20 = (((long)(int)(val_7) * 344) + val_12.characterInfo + 108) + 1;
                var val_21 = ((((long)(int)(val_7) * 344) + val_10.characterInfo + 88 * 72) + val_17.meshInfo + 88) + (((long)(int)((((long)(int)(val_7) * 344) + val_12.characterInfo + 108 + 1))) << 2);
                mem2[0] = 0;
                val_69 = (long)(((long)(int)(val_7) * 344) + val_12.characterInfo + 108) + 2;
                var val_23 = ((((long)(int)(val_7) * 344) + val_10.characterInfo + 88 * 72) + val_17.meshInfo + 88) + (((long)(int)((((long)(int)(val_7) * 344) + val_12.characterInfo + 108 + 2))) << 2);
                mem2[0] = 0;
                var val_24 = (((long)(int)(val_7) * 344) + val_12.characterInfo + 108) + 3;
                var val_25 = ((((long)(int)(val_7) * 344) + val_10.characterInfo + 88 * 72) + val_17.meshInfo + 88) + (((long)(int)((((long)(int)(val_7) * 344) + val_12.characterInfo + 108 + 3))) << 2);
                mem2[0] = 0;
                TMPro.TMP_TextInfo val_26 = this.m_TextMeshPro.textInfo;
                var val_27 = val_26.meshInfo + (val_68 * 72);
                (((long)(int)(val_7) * 344) + val_10.characterInfo + 88 * 72) + val_26.meshInfo + 32.colors32 = (((long)(int)(val_7) * 344) + val_10.characterInfo + 88 * 72) + val_17.meshInfo + 88;
            }
            
            label_12:
            UnityEngine.Vector3 val_28 = UnityEngine.Input.mousePosition;
            val_70 = val_28.x;
            val_71 = val_28.y;
            val_72 = val_28.z;
            int val_29 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = val_70, y = val_71, z = val_72}, camera:  this.m_Camera);
            if(val_29 == 1)
            {
                goto label_37;
            }
            
            label_40:
            val_73 = val_29;
            if(val_29 != this.m_selectedLink)
            {
                goto label_38;
            }
            
            goto label_39;
            label_37:
            if(this.m_selectedLink == 1)
            {
                goto label_40;
            }
            
            label_38:
            val_73 = 0;
            this.m_selectedLink = val_73;
            label_39:
            if((val_29 != 1) && (val_29 != val_73))
            {
                    this.m_selectedLink = val_29;
                TMPro.TMP_TextInfo val_30 = this.m_TextMeshPro.textInfo;
                var val_31 = val_30.linkInfo + ((long)val_29 * 40);
                string[] val_32 = new string[5];
                val_32[0] = "Link ID: \"";
                val_32[1] = ;
                val_32[2] = "\"   Link Text: \"";
                val_32[3] = ;
                val_32[4] = "\"";
                UnityEngine.Debug.Log(message:  +val_32);
                UnityEngine.Vector3 val_34 = UnityEngine.Vector3.zero;
                UnityEngine.Vector3 val_36 = UnityEngine.Input.mousePosition;
                val_72 = val_36.z;
                UnityEngine.Vector2 val_37 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_72});
                val_70 = val_37.x;
                val_71 = val_37.y;
                bool val_38 = UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle(rect:  this.m_TextMeshPro.rectTransform, screenPoint:  new UnityEngine.Vector2() {x = val_70, y = val_71}, cam:  this.m_Camera, worldPoint: out  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z});
                if((System.String.op_Equality(a:  ((long)(int)(val_29) * 40) + val_30.linkInfo + 32, b:  "id_01")) != true)
            {
                    bool val_40 = System.String.op_Equality(a:  ((long)(int)(val_29) * 40) + val_30.linkInfo + 32, b:  "id_02");
            }
            
            }
            
            UnityEngine.Vector3 val_41 = UnityEngine.Input.mousePosition;
            val_66 = val_41.x;
            val_67 = UnityEngine.Camera.main;
            int val_43 = TMPro.TMP_TextUtilities.FindIntersectingWord(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = val_66, y = val_41.y, z = val_41.z}, camera:  val_67);
            if(val_43 == 1)
            {
                    return;
            }
            
            if(val_43 == this.m_lastWordIndex)
            {
                    return;
            }
            
            this.m_lastWordIndex = val_43;
            TMPro.TMP_TextInfo val_44 = this.m_TextMeshPro.textInfo;
            var val_65 = 24;
            val_65 = val_44.wordInfo + ((long)val_43 * val_65);
            val_68 = mem[((long)(int)(val_43) * 24) + val_44.wordInfo + 40];
            val_68 = ((long)(int)(val_43) * 24) + val_44.wordInfo + 40;
            TMPro.TMP_TextInfo val_46 = this.m_TextMeshPro.textInfo;
            var val_47 = val_46.characterInfo + (val_68 * 344);
            UnityEngine.Vector3 val_48 = this.m_TextMeshPro.transform.TransformPoint(position:  new UnityEngine.Vector3() {x = (((long)(int)(val_43) * 24) + val_44.wordInfo + 40 * 344) + val_46.characterInfo + 284, y = (((long)(int)(val_43) * 24) + val_44.wordInfo + 40 * 344) + val_46.characterInfo + 288, z = (((long)(int)(val_43) * 24) + val_44.wordInfo + 40 * 344) + val_46.characterInfo + 292});
            val_66 = val_48.x;
            UnityEngine.Vector3 val_50 = UnityEngine.Camera.main.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_66, y = val_48.y, z = val_48.z});
            TMPro.TMP_TextInfo val_51 = this.m_TextMeshPro.textInfo;
            TMPro.TMP_MeshInfo val_66 = val_51.meshInfo[0];
            int val_53 = UnityEngine.Random.Range(min:  0, max:  255);
            int val_54 = UnityEngine.Random.Range(min:  0, max:  255);
            val_74 = 0;
            val_69 = 344;
            goto label_92;
            label_102:
            TMPro.TMP_TextInfo val_55 = UnityEngine.Random.Range(min:  0, max:  255).textInfo;
            var val_57 = val_55.characterInfo + (((long)val_68 + val_74) * 344);
            TMPro.TMP_MeshInfo val_58 = val_66 + ((((long)(int)((((long)(int)(val_43) * 24) + val_44.wordInfo + 40 + val_74)) * 344) + val_55.characterInfo + 108) << 2);
            tangents = 0;
            var val_59 = (((long)(int)((((long)(int)(val_43) * 24) + val_44.wordInfo + 40 + val_74)) * 344) + val_55.characterInfo + 108) + 1;
            TMPro.TMP_MeshInfo val_60 = val_66 + (((long)(int)((((long)(int)((((long)(int)(val_43) * 24) + val_44.wordInfo + 40 + val_74)) * 344) + val_55.characterInfo + 108 + 1))) << 2);
            tangents = 0;
            var val_61 = (((long)(int)((((long)(int)(val_43) * 24) + val_44.wordInfo + 40 + val_74)) * 344) + val_55.characterInfo + 108) + 2;
            TMPro.TMP_MeshInfo val_62 = val_66 + (((long)(int)((((long)(int)((((long)(int)(val_43) * 24) + val_44.wordInfo + 40 + val_74)) * 344) + val_55.characterInfo + 108 + 2))) << 2);
            tangents = 0;
            var val_63 = (((long)(int)((((long)(int)(val_43) * 24) + val_44.wordInfo + 40 + val_74)) * 344) + val_55.characterInfo + 108) + 3;
            TMPro.TMP_MeshInfo val_64 = val_66 + (((long)(int)((((long)(int)((((long)(int)(val_43) * 24) + val_44.wordInfo + 40 + val_74)) * 344) + val_55.characterInfo + 108 + 3))) << 2);
            val_74 = 1;
            tangents = 0;
            label_92:
            val_67 = this.m_TextMeshPro;
            if(val_74 < (((long)(int)(val_43) * 24) + val_44.wordInfo + 48))
            {
                goto label_102;
            }
            
            val_65 = val_67;
            val_65.colors32 = val_66;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Debug.Log(message:  "OnPointerEnter()");
            this.m_isHoveringObject = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Debug.Log(message:  "OnPointerExit()");
            this.m_isHoveringObject = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMP_TextSelector_A()
        {
            this.m_selectedLink = 0;
            this.m_lastCharIndex = 0;
            this.m_lastWordIndex = 0;
        }
    
    }

}
