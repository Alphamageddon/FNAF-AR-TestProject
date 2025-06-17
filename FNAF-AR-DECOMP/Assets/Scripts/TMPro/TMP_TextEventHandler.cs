using UnityEngine;

namespace TMPro
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_TextEventHandler.CharacterSelectionEvent m_OnCharacterSelection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_TextEventHandler.SpriteSelectionEvent m_OnSpriteSelection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_TextEventHandler.WordSelectionEvent m_OnWordSelection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_TextEventHandler.LineSelectionEvent m_OnLineSelection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_TextEventHandler.LinkSelectionEvent m_OnLinkSelection;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TMP_Text m_TextComponent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera m_Camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Canvas m_Canvas;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_selectedLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_lastCharIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_lastWordIndex;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int m_lastLineIndex;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.CharacterSelectionEvent onCharacterSelection { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.SpriteSelectionEvent onSpriteSelection { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.WordSelectionEvent onWordSelection { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.LineSelectionEvent onLineSelection { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.LinkSelectionEvent onLinkSelection { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.CharacterSelectionEvent get_onCharacterSelection()
        {
            return (CharacterSelectionEvent)this.m_OnCharacterSelection;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_onCharacterSelection(TMPro.TMP_TextEventHandler.CharacterSelectionEvent value)
        {
            this.m_OnCharacterSelection = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.SpriteSelectionEvent get_onSpriteSelection()
        {
            return (SpriteSelectionEvent)this.m_OnSpriteSelection;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_onSpriteSelection(TMPro.TMP_TextEventHandler.SpriteSelectionEvent value)
        {
            this.m_OnSpriteSelection = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.WordSelectionEvent get_onWordSelection()
        {
            return (WordSelectionEvent)this.m_OnWordSelection;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_onWordSelection(TMPro.TMP_TextEventHandler.WordSelectionEvent value)
        {
            this.m_OnWordSelection = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.LineSelectionEvent get_onLineSelection()
        {
            return (LineSelectionEvent)this.m_OnLineSelection;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_onLineSelection(TMPro.TMP_TextEventHandler.LineSelectionEvent value)
        {
            this.m_OnLineSelection = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler.LinkSelectionEvent get_onLinkSelection()
        {
            return (LinkSelectionEvent)this.m_OnLinkSelection;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_onLinkSelection(TMPro.TMP_TextEventHandler.LinkSelectionEvent value)
        {
            this.m_OnLinkSelection = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            TMPro.TMP_Text val_2 = this.gameObject.GetComponent<TMPro.TMP_Text>();
            this.m_TextComponent = val_2;
            if((System.Type.op_Equality(left:  val_2.GetType(), right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) != false)
            {
                    UnityEngine.Canvas val_7 = this.gameObject.GetComponentInParent<UnityEngine.Canvas>();
                this.m_Canvas = val_7;
                if(val_7 == 0)
            {
                    return;
            }
            
                if(this.m_Canvas.renderMode == 0)
            {
                goto label_14;
            }
            
                UnityEngine.Camera val_10 = this.m_Canvas.worldCamera;
            }
            
            label_14:
            this.m_Camera = UnityEngine.Camera.main;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LateUpdate()
        {
            UnityEngine.Camera val_29;
            float val_30;
            var val_31;
            TMPro.TMP_CharacterInfo[] val_32;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_29 = this.m_Camera;
            val_30 = val_2.x;
            if((TMPro.TMP_TextUtilities.IsIntersectingRectTransform(rectTransform:  this.m_TextComponent.rectTransform, position:  new UnityEngine.Vector3() {x = val_30, y = val_2.y, z = val_2.z}, camera:  val_29)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
            int val_5 = TMPro.TMP_TextUtilities.FindIntersectingCharacter(text:  this.m_TextComponent, position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, camera:  this.m_Camera, visibleOnly:  true);
            if((val_5 == 1) || (val_5 == this.m_lastCharIndex))
            {
                goto label_19;
            }
            
            this.m_lastCharIndex = val_5;
            TMPro.TMP_TextInfo val_6 = this.m_TextComponent.textInfo;
            var val_7 = val_6.characterInfo + ((long)val_5 * 344);
            if((((long)(int)(val_5) * 344) + val_6.characterInfo + 40) == 1)
            {
                goto label_13;
            }
            
            if((((long)(int)(val_5) * 344) + val_6.characterInfo + 40) != 0)
            {
                goto label_19;
            }
            
            TMPro.TMP_TextInfo val_8 = this.m_TextComponent.textInfo;
            var val_9 = val_8.characterInfo + ((long)val_5 * 344);
            this.SendOnCharacterSelection(character:  ((long)(int)(val_5) * 344) + val_8.characterInfo + 32, characterIndex:  val_5);
            goto label_19;
            label_13:
            TMPro.TMP_TextInfo val_10 = this.m_TextComponent.textInfo;
            var val_11 = val_10.characterInfo + ((long)val_5 * 344);
            this.SendOnSpriteSelection(character:  ((long)(int)(val_5) * 344) + val_10.characterInfo + 32, characterIndex:  val_5);
            label_19:
            UnityEngine.Vector3 val_12 = UnityEngine.Input.mousePosition;
            int val_13 = TMPro.TMP_TextUtilities.FindIntersectingWord(text:  this.m_TextComponent, position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z}, camera:  this.m_Camera);
            if((val_13 != 1) && (val_13 != this.m_lastWordIndex))
            {
                    this.m_lastWordIndex = val_13;
                TMPro.TMP_TextInfo val_14 = this.m_TextComponent.textInfo;
                var val_29 = 24;
                val_29 = val_14.wordInfo + ((long)val_13 * val_29);
                this.SendOnWordSelection(word:  ((long)(int)(val_13) * 24) + val_14.wordInfo + 32, charIndex:  ((long)(int)(val_13) * 24) + val_14.wordInfo + 32, length:  ((long)(int)(val_13) * 24) + val_14.wordInfo + 48);
            }
            
            UnityEngine.Vector3 val_15 = UnityEngine.Input.mousePosition;
            int val_16 = TMPro.TMP_TextUtilities.FindIntersectingLine(text:  this.m_TextComponent, position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, camera:  this.m_Camera);
            if((val_16 == 1) || (val_16 == this.m_lastLineIndex))
            {
                goto label_35;
            }
            
            this.m_lastLineIndex = val_16;
            TMPro.TMP_TextInfo val_17 = this.m_TextComponent.textInfo;
            var val_18 = val_17.lineInfo + ((long)val_16 * 92);
            char[] val_19 = new char[0];
            if((((long)(int)(val_16) * 92) + val_17.lineInfo + 36) < 1)
            {
                goto label_44;
            }
            
            val_31 = 0;
            label_51:
            TMPro.TMP_TextInfo val_20 = this.m_TextComponent.textInfo;
            val_32 = val_20.characterInfo;
            if(val_31 >= val_20.characterInfo.Length)
            {
                goto label_44;
            }
            
            TMPro.TMP_TextInfo val_21 = this.m_TextComponent.textInfo;
            var val_23 = val_21.characterInfo + (((long)(((long)(int)(val_16) * 92) + val_17.lineInfo + 52) + val_31) * 344);
            val_32 = mem[((long)(int)((((long)(int)(val_16) * 92) + val_17.lineInfo + 52 + val_31)) * 344) + val_21.characterInfo + 32];
            val_32 = ((long)(int)((((long)(int)(val_16) * 92) + val_17.lineInfo + 52 + val_31)) * 344) + val_21.characterInfo + 32;
            mem2[0] = val_32;
            val_31 = val_31 + 1;
            if(val_31 < ((long)((long)(int)(val_16) * 92) + val_17.lineInfo + 36))
            {
                goto label_51;
            }
            
            label_44:
            this.SendOnLineSelection(line:  0.CreateString(val:  val_19), charIndex:  ((long)(int)(val_16) * 92) + val_17.lineInfo + 52, length:  (long)((long)(int)(val_16) * 92) + val_17.lineInfo + 36);
            label_35:
            UnityEngine.Vector3 val_25 = UnityEngine.Input.mousePosition;
            val_29 = this.m_Camera;
            val_30 = val_25.x;
            int val_26 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  this.m_TextComponent, position:  new UnityEngine.Vector3() {x = val_30, y = val_25.y, z = val_25.z}, camera:  val_29);
            if(val_26 == 1)
            {
                    return;
            }
            
            if(val_26 == this.m_selectedLink)
            {
                    return;
            }
            
            this.m_selectedLink = val_26;
            TMPro.TMP_TextInfo val_27 = this.m_TextComponent.textInfo;
            var val_28 = val_27.linkInfo + ((long)val_26 * 40);
            val_29 = ;
            this.SendOnLinkSelection(linkID:  ((long)(int)(val_26) * 40) + val_27.linkInfo + 32, linkText:  ((long)(int)(val_26) * 40) + val_27.linkInfo + 32, linkIndex:  val_26);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendOnCharacterSelection(char character, int characterIndex)
        {
            if(this.m_OnCharacterSelection == null)
            {
                    return;
            }
            
            this.m_OnCharacterSelection.Invoke(arg0:  character, arg1:  characterIndex);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendOnSpriteSelection(char character, int characterIndex)
        {
            if(this.m_OnSpriteSelection == null)
            {
                    return;
            }
            
            this.m_OnSpriteSelection.Invoke(arg0:  character, arg1:  characterIndex);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendOnWordSelection(string word, int charIndex, int length)
        {
            if(this.m_OnWordSelection == null)
            {
                    return;
            }
            
            this.m_OnWordSelection.Invoke(arg0:  word, arg1:  charIndex, arg2:  length);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendOnLineSelection(string line, int charIndex, int length)
        {
            if(this.m_OnLineSelection == null)
            {
                    return;
            }
            
            this.m_OnLineSelection.Invoke(arg0:  line, arg1:  charIndex, arg2:  length);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
        {
            if(this.m_OnLinkSelection == null)
            {
                    return;
            }
            
            this.m_OnLinkSelection.Invoke(arg0:  linkID, arg1:  linkText, arg2:  linkIndex);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMP_TextEventHandler()
        {
            this.m_OnCharacterSelection = new TMP_TextEventHandler.CharacterSelectionEvent();
            this.m_OnSpriteSelection = new TMP_TextEventHandler.SpriteSelectionEvent();
            this.m_OnWordSelection = new TMP_TextEventHandler.WordSelectionEvent();
            this.m_OnLineSelection = new TMP_TextEventHandler.LineSelectionEvent();
            this.m_OnLinkSelection = new TMP_TextEventHandler.LinkSelectionEvent();
            this.m_selectedLink = 0;
            this.m_lastCharIndex = 0;
            this.m_lastWordIndex = 0;
            this.m_lastLineIndex = 0;
        }
    
    }

}
