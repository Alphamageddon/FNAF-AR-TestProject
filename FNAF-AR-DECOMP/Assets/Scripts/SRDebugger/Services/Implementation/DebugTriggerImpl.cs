using UnityEngine;

namespace SRDebugger.Services.Implementation
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DebugTriggerImpl : SRServiceBase<SRDebugger.Services.IDebugTriggerService>, IDebugTriggerService
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.PinAlignment _position;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SRDebugger.UI.Other.TriggerRoot _trigger;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsEnabled { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.PinAlignment Position { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool get_IsEnabled()
        {
            if(this._trigger == 0)
            {
                    return false;
            }
            
            UnityEngine.GameObject val_2 = this._trigger.CachedGameObject;
            if(val_2 != null)
            {
                    return val_2.activeSelf;
            }
            
            return val_2.activeSelf;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_IsEnabled(bool value)
        {
            if(value != false)
            {
                    if(this._trigger == 0)
            {
                    this.CreateTrigger();
            }
            
            }
            
            if(this._trigger == 0)
            {
                    return;
            }
            
            this._trigger.CachedGameObject.SetActive(value:  value);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SRDebugger.PinAlignment get_Position()
        {
            return (SRDebugger.PinAlignment)this._position;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_Position(SRDebugger.PinAlignment value)
        {
            if(this._trigger != 0)
            {
                    SRDebugger.Services.Implementation.DebugTriggerImpl.SetTriggerPosition(t:  this._trigger.TriggerTransform, position:  value);
            }
            
            this._position = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Awake()
        {
            this.Awake();
            UnityEngine.Object.DontDestroyOnLoad(target:  this.CachedGameObject);
            this.CachedTransform.SetParent(parent:  SRF.Hierarchy.Get(key:  "SRDebugger"), worldPositionStays:  true);
            this.name = "Trigger";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CreateTrigger()
        {
            SRDebugger.UI.Other.TriggerRoot val_1 = UnityEngine.Resources.Load<SRDebugger.UI.Other.TriggerRoot>(path:  "SRDebugger/UI/Prefabs/Trigger");
            if(val_1 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "[SRDebugger] Error loading trigger prefab");
                return;
            }
            
            SRDebugger.UI.Other.TriggerRoot val_3 = SRInstantiate.Instantiate<SRDebugger.UI.Other.TriggerRoot>(prefab:  val_1);
            this._trigger = val_3;
            val_3.CachedTransform.SetParent(parent:  this.CachedTransform, worldPositionStays:  true);
            SRDebugger.Services.Implementation.DebugTriggerImpl.SetTriggerPosition(t:  this._trigger.TriggerTransform, position:  this._position);
            TriggerBehaviours val_7 = SRDebugger.Settings.Instance.TriggerBehaviour;
            if(val_7 == 2)
            {
                goto label_10;
            }
            
            if(val_7 == 1)
            {
                goto label_11;
            }
            
            if(val_7 == 0)
            {
                goto label_12;
            }
            
            System.Exception val_8 = null;
            this = val_8;
            val_8 = new System.Exception(message:  "Unhandled TriggerBehaviour");
            label_10:
            mem2[0] = 2;
            label_12:
            (System.Exception)[1152921522988121440]._remoteStackIndex + 96.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  val_8, method:  System.Void SRDebugger.Services.Implementation.DebugTriggerImpl::OnTriggerButtonClick()));
            if(((System.Exception)[1152921522988121440]._remoteStackIndex + 80) != 0)
            {
                goto label_25;
            }
            
            label_26:
            label_25:
            (System.Exception)[1152921522988121440]._remoteStackIndex + 80.gameObject.SetActive(value:  false);
            bool val_12 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
            UnityEngine.SceneManagement.SceneManager.add_activeSceneChanged(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  0, method:  static System.Void SRDebugger.Services.Implementation.DebugTriggerImpl::OnActiveSceneChanged(UnityEngine.SceneManagement.Scene s1, UnityEngine.SceneManagement.Scene s2)));
            return;
            label_11:
            this._trigger.TapHoldButton.onLongPress.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void SRDebugger.Services.Implementation.DebugTriggerImpl::OnTriggerButtonClick()));
            if(this._trigger.TripleTapButton != null)
            {
                goto label_25;
            }
            
            goto label_26;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void OnDestroy()
        {
            UnityEngine.SceneManagement.SceneManager.remove_activeSceneChanged(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>(object:  0, method:  static System.Void SRDebugger.Services.Implementation.DebugTriggerImpl::OnActiveSceneChanged(UnityEngine.SceneManagement.Scene s1, UnityEngine.SceneManagement.Scene s2)));
            this.OnDestroy();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void OnActiveSceneChanged(UnityEngine.SceneManagement.Scene s1, UnityEngine.SceneManagement.Scene s2)
        {
            bool val_1 = SRDebugger.Internal.SRDebuggerUtil.EnsureEventSystemExists();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnTriggerButtonClick()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void SetTriggerPosition(UnityEngine.RectTransform t, SRDebugger.PinAlignment position)
        {
            float val_4;
            float val_5;
            val_4 = 0f;
            if(position <= 6)
            {
                    var val_4 = 52952508 + (position) << 2;
                val_4 = val_4 + 52952508;
            }
            else
            {
                    val_5 = 0f;
                if(position <= 7)
            {
                    var val_5 = 1;
                val_5 = val_5 << position;
                if((val_5 & 42) != 0)
            {
                    val_4 = 1f;
            }
            else
            {
                    val_5 = val_5 & 192;
                if(val_5 != 0)
            {
                    val_4 = 0.5f;
            }
            
            }
            
            }
            
                UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_4, y:  val_5);
                t.pivot = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  val_4, y:  val_5);
                t.anchorMin = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
                t.anchorMax = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DebugTriggerImpl()
        {
        
        }
    
    }

}
