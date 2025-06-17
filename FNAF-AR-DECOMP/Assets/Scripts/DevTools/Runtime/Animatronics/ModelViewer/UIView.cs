using UnityEngine;

namespace DevTools.Runtime.Animatronics.ModelViewer
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly string ClassName;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _uiRoot;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _toggleControlsButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _topPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _bottomPanel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Dropdown _animatronicSelector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _spawnDespawnButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _spawnDespawnButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Dropdown _subModeSelector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _playStopButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _playStopButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _loopAnimationButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _loopAnimationButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _flashlightButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _flashlightButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _eyesToggleButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _eyesToggleButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _cloakToggleButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _cloakToggleButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Button _changeModeButton;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text _changeModeButtonText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> OnAnimatronicSpawnRequested;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnAnimatronicDespawnRequested;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> OnSubModeSelectionChanged;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action<string> OnPlayStopRequested;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnToggleAnimationLooping;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnToggleFlashlight;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnToggleEyes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnToggleCloak;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnToggleViewerMode;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAnimatronicSpawnRequested(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAnimatronicSpawnRequested, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicSpawnRequested != 1152921525513609832);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAnimatronicSpawnRequested(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAnimatronicSpawnRequested, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicSpawnRequested != 1152921525513746408);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnAnimatronicDespawnRequested(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnAnimatronicDespawnRequested, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicDespawnRequested != 1152921525513882992);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnAnimatronicDespawnRequested(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnAnimatronicDespawnRequested, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnAnimatronicDespawnRequested != 1152921525514019568);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnSubModeSelectionChanged(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnSubModeSelectionChanged, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSubModeSelectionChanged != 1152921525514156152);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnSubModeSelectionChanged(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnSubModeSelectionChanged, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnSubModeSelectionChanged != 1152921525514292728);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnPlayStopRequested(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnPlayStopRequested, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPlayStopRequested != 1152921525514429312);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnPlayStopRequested(System.Action<string> value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnPlayStopRequested, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnPlayStopRequested != 1152921525514565888);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnToggleAnimationLooping(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnToggleAnimationLooping, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleAnimationLooping != 1152921525514702472);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnToggleAnimationLooping(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnToggleAnimationLooping, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleAnimationLooping != 1152921525514839048);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnToggleFlashlight(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnToggleFlashlight, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleFlashlight != 1152921525514975632);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnToggleFlashlight(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnToggleFlashlight, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleFlashlight != 1152921525515112208);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnToggleEyes(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnToggleEyes, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleEyes != 1152921525515248792);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnToggleEyes(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnToggleEyes, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleEyes != 1152921525515385368);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnToggleCloak(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnToggleCloak, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleCloak != 1152921525515521952);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnToggleCloak(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnToggleCloak, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleCloak != 1152921525515658528);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void add_OnToggleViewerMode(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.OnToggleViewerMode, b:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleViewerMode != 1152921525515795112);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void remove_OnToggleViewerMode(System.Action value)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.OnToggleViewerMode, value:  value);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.OnToggleViewerMode != 1152921525515931688);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UIView()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static UIView()
        {
            DevTools.Runtime.Animatronics.ModelViewer.UIView.ClassName = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
        }
    
    }

}
