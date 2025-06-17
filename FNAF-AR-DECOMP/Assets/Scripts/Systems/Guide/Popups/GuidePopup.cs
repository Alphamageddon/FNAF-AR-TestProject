using UnityEngine;

namespace Systems.Guide.Popups
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GuidePopup : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _popupName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private P7.CanvasFlow.Storyboard _storyboard;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private P7.CanvasFlow.CanvasController _controller;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _active;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this._storyboard = this.gameObject.GetComponent<P7.CanvasFlow.Storyboard>();
            this._masterDomain.eventExposer.add_GuidePopupRequested(value:  new System.Action<System.String>(object:  this, method:  System.Void Systems.Guide.Popups.GuidePopup::EventExposer_OnGuidePopupRequested(string popupName)));
            this._masterDomain.eventExposer.add_GuidePopupDismissed(value:  new System.Action<System.String>(object:  this, method:  System.Void Systems.Guide.Popups.GuidePopup::EventExposer_OnGuidePopupDismissed(string popupName)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnGuidePopupRequested(string popupName)
        {
            if(this._active == true)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  this._popupName, b:  popupName)) != false)
            {
                    return;
            }
            
            this._active = true;
            this._storyboard.StoryboardWillDismiss.AddListener(call:  new UnityEngine.Events.UnityAction<P7.CanvasFlow.StoryboardTransition>(object:  this, method:  System.Void Systems.Guide.Popups.GuidePopup::OnPopupClosing(P7.CanvasFlow.StoryboardTransition transition)));
            this._storyboard.StoryboardWillPresentInitialCanvasController.AddListener(call:  new UnityEngine.Events.UnityAction<P7.CanvasFlow.StoryboardTransition>(object:  this, method:  System.Void Systems.Guide.Popups.GuidePopup::OnInitialController(P7.CanvasFlow.StoryboardTransition transition)));
            this._storyboard.Present();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_OnGuidePopupDismissed(string popupName)
        {
            if(this._active == false)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  this._popupName, b:  popupName)) != false)
            {
                    return;
            }
            
            this._storyboard.PerformTransitionWithUserIdentifierFromStoryboardable(userIdentifier:  "Dismiss", storyboardable:  this._controller);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnPopupClosing(P7.CanvasFlow.StoryboardTransition transition)
        {
            this._storyboard.StoryboardWillDismiss.RemoveListener(call:  new UnityEngine.Events.UnityAction<P7.CanvasFlow.StoryboardTransition>(object:  this, method:  System.Void Systems.Guide.Popups.GuidePopup::OnPopupClosing(P7.CanvasFlow.StoryboardTransition transition)));
            this._masterDomain.eventExposer.CloseGuidePopup(popupName:  this._popupName);
            this._active = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnInitialController(P7.CanvasFlow.StoryboardTransition transition)
        {
            this._controller = transition.DestinationCanvasController();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GuidePopup()
        {
        
        }
    
    }

}
