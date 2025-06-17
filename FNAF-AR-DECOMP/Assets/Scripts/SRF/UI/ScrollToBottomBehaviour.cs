using UnityEngine;

namespace SRF.UI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ScrollToBottomBehaviour : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.ScrollRect _scrollRect;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.CanvasGroup _canvasGroup;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Start()
        {
            object val_5;
            if(this._scrollRect != 0)
            {
                goto label_3;
            }
            
            val_5 = "[ScrollToBottomBehaviour] ScrollRect not set";
            goto label_6;
            label_3:
            if(this._canvasGroup != 0)
            {
                goto label_9;
            }
            
            val_5 = "[ScrollToBottomBehaviour] CanvasGroup not set";
            label_6:
            UnityEngine.Debug.LogError(message:  val_5);
            return;
            label_9:
            this._scrollRect.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<UnityEngine.Vector2>(object:  this, method:  System.Void SRF.UI.ScrollToBottomBehaviour::OnScrollRectValueChanged(UnityEngine.Vector2 position)));
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Trigger()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0f, y:  0f);
            this._scrollRect.normalizedPosition = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnScrollRectValueChanged(UnityEngine.Vector2 position)
        {
            this.Refresh();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Refresh()
        {
            var val_3;
            if(this._scrollRect == 0)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_2 = this._scrollRect.normalizedPosition;
            if(val_2.y < 0)
            {
                    val_3 = 0;
            }
            else
            {
                    val_3 = 1;
            }
            
            this.SetVisible(truth:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetVisible(bool truth)
        {
            UnityEngine.CanvasGroup val_1;
            var val_2;
            if(this._canvasGroup == null)
            {
                goto label_0;
            }
            
            if(truth == false)
            {
                goto label_1;
            }
            
            label_5:
            this._canvasGroup.alpha = 1f;
            this._canvasGroup.interactable = true;
            val_1 = this._canvasGroup;
            val_2 = 1;
            goto label_4;
            label_0:
            if(truth == true)
            {
                goto label_5;
            }
            
            label_1:
            this._canvasGroup.alpha = 0f;
            this._canvasGroup.interactable = false;
            val_1 = this._canvasGroup;
            val_2 = 0;
            label_4:
            val_1.blocksRaycasts = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ScrollToBottomBehaviour()
        {
        
        }
    
    }

}
