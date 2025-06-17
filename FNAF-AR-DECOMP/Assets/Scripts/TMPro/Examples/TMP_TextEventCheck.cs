using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TMP_TextEventCheck : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.TMP_TextEventHandler TextEventHandler;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            if(this.TextEventHandler == 0)
            {
                    return;
            }
            
            this.TextEventHandler.m_OnCharacterSelection.AddListener(call:  new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnCharacterSelection(char c, int index)));
            this.TextEventHandler.m_OnSpriteSelection.AddListener(call:  new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnSpriteSelection(char c, int index)));
            this.TextEventHandler.m_OnWordSelection.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnWordSelection(string word, int firstCharacterIndex, int length)));
            this.TextEventHandler.m_OnLineSelection.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnLineSelection(string lineText, int firstCharacterIndex, int length)));
            this.TextEventHandler.m_OnLinkSelection.AddListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnLinkSelection(string linkID, string linkText, int linkIndex)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            if(this.TextEventHandler == 0)
            {
                    return;
            }
            
            this.TextEventHandler.m_OnCharacterSelection.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnCharacterSelection(char c, int index)));
            this.TextEventHandler.m_OnSpriteSelection.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnSpriteSelection(char c, int index)));
            this.TextEventHandler.m_OnWordSelection.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnWordSelection(string word, int firstCharacterIndex, int length)));
            this.TextEventHandler.m_OnLineSelection.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnLineSelection(string lineText, int firstCharacterIndex, int length)));
            this.TextEventHandler.m_OnLinkSelection.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String, System.String, System.Int32>(object:  this, method:  System.Void TMPro.Examples.TMP_TextEventCheck::OnLinkSelection(string linkID, string linkText, int linkIndex)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnCharacterSelection(char c, int index)
        {
            object[] val_1 = new object[5];
            val_1[0] = "Character [";
            val_1[1] = ;
            val_1[2] = "] at Index: ";
            val_1[3] = index;
            val_1[4] = " has been selected.";
            UnityEngine.Debug.Log(message:  +val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnSpriteSelection(char c, int index)
        {
            object[] val_1 = new object[5];
            val_1[0] = "Sprite [";
            val_1[1] = ;
            val_1[2] = "] at Index: ";
            val_1[3] = index;
            val_1[4] = " has been selected.";
            UnityEngine.Debug.Log(message:  +val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnWordSelection(string word, int firstCharacterIndex, int length)
        {
            object[] val_1 = new object[7];
            val_1[0] = "Word [";
            val_1[1] = word;
            val_1[2] = "] with first character index of ";
            val_1[3] = firstCharacterIndex;
            val_1[4] = " and length of ";
            val_1[5] = length;
            val_1[6] = " has been selected.";
            UnityEngine.Debug.Log(message:  +val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
        {
            object[] val_1 = new object[7];
            val_1[0] = "Line [";
            val_1[1] = lineText;
            val_1[2] = "] with first character index of ";
            val_1[3] = firstCharacterIndex;
            val_1[4] = " and length of ";
            val_1[5] = length;
            val_1[6] = " has been selected.";
            UnityEngine.Debug.Log(message:  +val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnLinkSelection(string linkID, string linkText, int linkIndex)
        {
            object[] val_1 = new object[7];
            val_1[0] = "Link Index: ";
            val_1[1] = linkIndex;
            val_1[2] = " with ID [";
            val_1[3] = linkID;
            val_1[4] = "] and Text \"";
            val_1[5] = linkText;
            val_1[6] = "\" has been selected.";
            UnityEngine.Debug.Log(message:  +val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMP_TextEventCheck()
        {
        
        }
    
    }

}
