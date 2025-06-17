using UnityEngine;

namespace Master
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SceneLookupTableAccess : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private WorkshopSceneLookupTable _workshopSceneLookupTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private CameraSceneLookupTable _cameraSceneLookupTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapSceneLookupTable _mapSceneLookupTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.SplashSceneLookupTable _splashSceneLookupTable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Master.SceneLookupTableAccess.ReturnWorkshopSceneLookupTable> _returnWorkshopSceneLookupTableCallbacks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Master.SceneLookupTableAccess.ReturnCameraSceneLookupTable> _returnCameraSceneLookupTableCallbacks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Master.SceneLookupTableAccess.ReturnMapSceneLookupTable> _returnMapSceneLookupTableCallbacks;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<Master.SceneLookupTableAccess.ReturnSplashSceneLookupTable> _returnSplashSceneLookupTableCallbacks;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetWorkshopSceneLookupTableAsync(Master.SceneLookupTableAccess.ReturnWorkshopSceneLookupTable returnWorkshopSceneLookupTableCallback)
        {
            this.AddWorkshopSceneLookupTableCallback(returnWorkshopSceneLookupTableCallback:  returnWorkshopSceneLookupTableCallback);
            this.TryCallWorkshopSceneLookupTableCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetCameraSceneLookupTableAsync(Master.SceneLookupTableAccess.ReturnCameraSceneLookupTable returnCameraSceneLookupTableCallback)
        {
            this.AddCameraSceneLookupTableCallback(returnCameraSceneLookupTableCallback:  returnCameraSceneLookupTableCallback);
            this.TryCallCameraSceneLookupTableCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetMapSceneLookupTableAsync(Master.SceneLookupTableAccess.ReturnMapSceneLookupTable returnMapSceneLookupTableCallback)
        {
            this.AddMapSceneLookupTableCallback(returnMapSceneLookupTableCallback:  returnMapSceneLookupTableCallback);
            this.TryCallMapSceneLookupTableCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void GetSplashSceneLookupTableAsync(Master.SceneLookupTableAccess.ReturnSplashSceneLookupTable returnSplashSceneLookupTableCallback)
        {
            this.AddSplashSceneLookupTableCallback(returnSplashSceneLookupTableCallback:  returnSplashSceneLookupTableCallback);
            this.TryCallSplashSceneLookupTableCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddWorkshopSceneLookupTableCallback(Master.SceneLookupTableAccess.ReturnWorkshopSceneLookupTable returnWorkshopSceneLookupTableCallback)
        {
            this._returnWorkshopSceneLookupTableCallbacks.Add(item:  returnWorkshopSceneLookupTableCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryCallWorkshopSceneLookupTableCallbacks()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._workshopSceneLookupTable)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this._returnWorkshopSceneLookupTableCallbacks.GetEnumerator();
            label_7:
            if((1500665800 & 1) == 0)
            {
                goto label_5;
            }
            
            0.emailUIDataHandler.Invoke(workshopSceneLookupTable:  this._workshopSceneLookupTable);
            goto label_7;
            label_5:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523287381960});
            this = this._returnWorkshopSceneLookupTableCallbacks;
            this.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddCameraSceneLookupTableCallback(Master.SceneLookupTableAccess.ReturnCameraSceneLookupTable returnCameraSceneLookupTableCallback)
        {
            this._returnCameraSceneLookupTableCallbacks.Add(item:  returnCameraSceneLookupTableCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryCallCameraSceneLookupTableCallbacks()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._cameraSceneLookupTable)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this._returnCameraSceneLookupTableCallbacks.GetEnumerator();
            label_7:
            if((1500961480 & 1) == 0)
            {
                goto label_5;
            }
            
            0.emailUIDataHandler.Invoke(cameraSceneLookupTable:  this._cameraSceneLookupTable);
            goto label_7;
            label_5:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523287677640});
            this = this._returnCameraSceneLookupTableCallbacks;
            this.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddMapSceneLookupTableCallback(Master.SceneLookupTableAccess.ReturnMapSceneLookupTable returnMapSceneLookupTableCallback)
        {
            this._returnMapSceneLookupTableCallbacks.Add(item:  returnMapSceneLookupTableCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryCallMapSceneLookupTableCallbacks()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._mapSceneLookupTable)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this._returnMapSceneLookupTableCallbacks.GetEnumerator();
            label_7:
            if((1501257160 & 1) == 0)
            {
                goto label_5;
            }
            
            0.emailUIDataHandler.Invoke(mapSceneLookupTable:  this._mapSceneLookupTable);
            goto label_7;
            label_5:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523287973320});
            this = this._returnMapSceneLookupTableCallbacks;
            this.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddSplashSceneLookupTableCallback(Master.SceneLookupTableAccess.ReturnSplashSceneLookupTable returnSplashSceneLookupTableCallback)
        {
            this._returnSplashSceneLookupTableCallbacks.Add(item:  returnSplashSceneLookupTableCallback);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TryCallSplashSceneLookupTableCallbacks()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._splashSceneLookupTable)) == false)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this._returnSplashSceneLookupTableCallbacks.GetEnumerator();
            label_7:
            if((1501552840 & 1) == 0)
            {
                goto label_5;
            }
            
            0.emailUIDataHandler.Invoke(splashSceneLookupTable:  this._splashSceneLookupTable);
            goto label_7;
            label_5:
            long val_4 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921523288269000});
            this = this._returnSplashSceneLookupTableCallbacks;
            this.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.TryCallWorkshopSceneLookupTableCallbacks();
            this.TryCallCameraSceneLookupTableCallbacks();
            this.TryCallSplashSceneLookupTableCallbacks();
            this.TryCallMapSceneLookupTableCallbacks();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SceneLookupTableAccess()
        {
            this._returnWorkshopSceneLookupTableCallbacks = new System.Collections.Generic.List<ReturnWorkshopSceneLookupTable>();
            this._returnCameraSceneLookupTableCallbacks = new System.Collections.Generic.List<ReturnCameraSceneLookupTable>();
            this._returnMapSceneLookupTableCallbacks = new System.Collections.Generic.List<ReturnMapSceneLookupTable>();
            this._returnSplashSceneLookupTableCallbacks = new System.Collections.Generic.List<ReturnSplashSceneLookupTable>();
        }
    
    }

}
