using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LinkClickHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _text;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Link _dialogHandler_Link;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _shouldOpenPrompt;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetData(TMPro.TextMeshProUGUI text, GameUI.DialogHandler_Link dialogHandlerLink, bool shouldOpenPrompt)
        {
            this._text = text;
            this._dialogHandler_Link = dialogHandlerLink;
            this._shouldOpenPrompt = shouldOpenPrompt;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            if(this._text == 0)
            {
                    ConsoleLogger.LogError(className:  "LinkClickHandler", functionName:  "OnPointerClick", logString:  "Data not set!");
                return;
            }
            
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            int val_3 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  this._text, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, camera:  this._camera);
            if(val_3 == 1)
            {
                    return;
            }
            
            TMPro.TMP_TextInfo val_4 = this._text.textInfo;
            var val_5 = val_4.linkInfo + ((long)val_3 * 40);
            if(this._shouldOpenPrompt != false)
            {
                    this = this._dialogHandler_Link;
                this.ShowConfirmDialog(URL:  ((long)(int)(val_3) * 40) + val_4.linkInfo + 32);
                return;
            }
            
            UnityEngine.Application.OpenURL(url:  ((long)(int)(val_3) * 40) + val_4.linkInfo + 32);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            TMPro.TextMeshProUGUI val_1 = this.GetComponent<TMPro.TextMeshProUGUI>();
            this._text = val_1;
            if(val_1 == 0)
            {
                    ConsoleLogger.LogError(className:  "LinkClickHandler", functionName:  "Start", logString:  "LinkClickHandler not set on a TextMeshProUGUI!");
                return;
            }
            
            if(this._text.canvas.renderMode != 1)
            {
                    return;
            }
            
            this._camera = this._text.canvas.worldCamera;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LinkClickHandler()
        {
        
        }
    
    }

}
