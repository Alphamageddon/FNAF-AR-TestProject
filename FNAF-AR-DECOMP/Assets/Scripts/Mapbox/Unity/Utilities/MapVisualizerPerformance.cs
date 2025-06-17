using UnityEngine;

namespace Mapbox.Unity.Utilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapVisualizerPerformance : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Diagnostics.Stopwatch _sw;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMap _map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Mapbox.Unity.Map.AbstractMapVisualizer _mapVisualizer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int TestCount;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _currentTest;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public float TotalTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _firstRun;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            this._currentTest = 1;
            this.TotalTime = 0f;
            Mapbox.Unity.Map.AbstractMap val_1 = UnityEngine.Object.FindObjectOfType<Mapbox.Unity.Map.AbstractMap>();
            this._map = val_1;
            Mapbox.Unity.Map.AbstractMapVisualizer val_2 = val_1.MapVisualizer;
            this._mapVisualizer = val_2;
            val_2.add_OnMapVisualizerStateChanged(value:  new System.Action<Mapbox.Unity.Map.ModuleState>(object:  this, method:  System.Void Mapbox.Unity.Utilities.MapVisualizerPerformance::<Awake>b__7_0(Mapbox.Unity.Map.ModuleState s)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Run()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapVisualizerPerformance()
        {
            this._sw = new System.Diagnostics.Stopwatch();
            this.TestCount = 11;
            this._currentTest = 1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <Awake>b__7_0(Mapbox.Unity.Map.ModuleState s)
        {
            object val_8;
            object val_9;
            int val_10;
            val_9 = this;
            if(s != 2)
            {
                    if(s != 1)
            {
                    return;
            }
            
                this._sw.Reset();
                this._sw.Start();
                return;
            }
            
            this._sw.Stop();
            val_10 = this._currentTest;
            if(val_10 >= 2)
            {
                    float val_8 = (float)this._sw.ElapsedMilliseconds;
                val_8 = this.TotalTime + val_8;
                this.TotalTime = val_8;
                object[] val_2 = new object[4];
                val_2[0] = "Test ";
                val_2[1] = this._currentTest;
                val_2[2] = ": ";
                val_8 = this._sw.ElapsedMilliseconds;
                val_2[3] = val_8;
                val_10 = null;
                UnityEngine.Debug.Log(message:  +val_2);
            }
            else
            {
                    this._firstRun = (float)this._sw.ElapsedMilliseconds;
            }
            
            int val_9 = this._currentTest;
            if(this.TestCount > val_9)
            {
                    val_9 = val_9 + 1;
                this._currentTest = val_9;
                this.Invoke(methodName:  "Run", time:  1f);
                return;
            }
            
            if(val_9 < 2)
            {
                    return;
            }
            
            object[] val_6 = new object[4];
            val_6[0] = "First Run:        ";
            val_6[1] = this._firstRun;
            val_8 = " \r\nRest Average: ";
            val_6[2] = val_8;
            int val_10 = this._currentTest;
            float val_11 = this.TotalTime;
            val_10 = val_10 - 1;
            val_11 = val_11 / (float)val_10;
            val_6[3] = val_11;
            val_9 = +val_6;
            UnityEngine.Debug.Log(message:  val_9);
        }
    
    }

}
