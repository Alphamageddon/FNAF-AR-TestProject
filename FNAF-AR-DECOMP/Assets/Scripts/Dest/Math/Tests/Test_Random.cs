using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_Random : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Dest.Math.Rand rand;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Readme;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int IntMin;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int IntMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool UseUnityRandom;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.rand = new Dest.Math.Rand();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGUI()
        {
            var val_20;
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            if((UnityEngine.GUILayout.Button(text:  "Test Int", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
            {
                    this.TestInt();
            }
            
            if((UnityEngine.GUILayout.Button(text:  "Test Int Max", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
            {
                    this.TestIntMax();
            }
            
            if((UnityEngine.GUILayout.Button(text:  "Test Int Range", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
            {
                    this.TestIntRange();
            }
            
            if((UnityEngine.GUILayout.Button(text:  "Test Float", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
            {
                    this.TestFloat();
            }
            
            if((UnityEngine.GUILayout.Button(text:  "Test Byte", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
            {
                    this.TestByte();
            }
            
            if((UnityEngine.GUILayout.Button(text:  "Test Bool", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
            {
                    this.TestBool();
            }
            
            if((UnityEngine.GUILayout.Button(text:  "Test Color32", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
            {
                    this.TestColor32();
            }
            
            UnityEngine.GUILayout.EndHorizontal();
            if(this._data == null)
            {
                    return;
            }
            
            float val_20 = (float)UnityEngine.Screen.height;
            val_20 = val_20 + (-30f);
            val_20 = 0;
            goto label_9;
            label_16:
            float val_22 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  this._data[0]);
            val_22 = (val_20 / 20f) + val_22;
            if(val_22 > (float)UnityEngine.Screen.height)
            {
                    float val_19 = 0f.System.IConvertible.ToSingle(provider:  0);
                val_19 = val_19 + 100f;
                0.distance = val_19;
            }
            
            val_20 = 1;
            label_9:
            if(val_20 < this._data.Length)
            {
                goto label_16;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TestInt()
        {
            var val_5;
            this._data = new string[0];
            if(this.Count < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            label_11:
            if(this.UseUnityRandom != false)
            {
                    val_5 = -2147483648;
                int val_2 = UnityEngine.Random.Range(min:  -2147483648, max:  2147483647);
            }
            else
            {
                    val_5 = this.rand;
            }
            
            string val_4 = val_5.NextInt().ToString();
            if(this._data == null)
            {
                goto label_5;
            }
            
            if(val_4 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_4 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            this._data[0] = val_4;
            val_5 = val_5 + 1;
            if(val_5 < this.Count)
            {
                goto label_11;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TestIntMax()
        {
            var val_5;
            this._data = new string[0];
            if(this.Count < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            label_11:
            if(this.UseUnityRandom != false)
            {
                    val_5 = 0;
                int val_2 = UnityEngine.Random.Range(min:  0, max:  this.IntMax);
            }
            else
            {
                    val_5 = this.rand;
            }
            
            string val_4 = val_5.NextInt(max:  this.IntMax).ToString();
            if(this._data == null)
            {
                goto label_5;
            }
            
            if(val_4 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_4 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            this._data[0] = val_4;
            val_5 = val_5 + 1;
            if(val_5 < this.Count)
            {
                goto label_11;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TestIntRange()
        {
            int val_5;
            this._data = new string[0];
            if(this.Count < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            label_11:
            if(this.UseUnityRandom != false)
            {
                    val_5 = this.IntMin;
                int val_2 = UnityEngine.Random.Range(min:  val_5, max:  this.IntMax);
            }
            else
            {
                    val_5 = this.rand;
            }
            
            string val_4 = val_5.NextInt(min:  this.IntMin, max:  this.IntMax).ToString();
            if(this._data == null)
            {
                goto label_5;
            }
            
            if(val_4 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_4 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            this._data[0] = val_4;
            val_5 = val_5 + 1;
            if(val_5 < this.Count)
            {
                goto label_11;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TestFloat()
        {
            this._data = new string[0];
            if(this.Count < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            label_11:
            if(this.UseUnityRandom != false)
            {
                    float val_2 = UnityEngine.Random.value;
            }
            
            string val_4 = this.rand.NextFloat().ToString();
            if(this._data == null)
            {
                goto label_5;
            }
            
            if(val_4 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_4 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            this._data[0] = val_4;
            val_5 = val_5 + 1;
            if(val_5 < this.Count)
            {
                goto label_11;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TestByte()
        {
            this._data = new string[0];
            if(this.Count < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            label_9:
            string val_3 = this.rand.NextByte().ToString();
            if(this._data == null)
            {
                goto label_3;
            }
            
            if(val_3 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_3 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            this._data[0] = val_3;
            val_4 = val_4 + 1;
            if(val_4 < this.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TestBool()
        {
            this._data = new string[0];
            if(this.Count < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            label_9:
            string val_4 = this.rand.NextBool().ToString();
            if(this._data == null)
            {
                goto label_3;
            }
            
            if(val_4 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_4 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            this._data[0] = val_4;
            val_5 = val_5 + 1;
            if(val_5 < this.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TestColor32()
        {
            this._data = new string[0];
            if(this.Count < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            label_9:
            UnityEngine.Color32 val_2 = this.rand.RandomColor32Opaque();
            string val_6 = System.String.Format(format:  "({0},{1},{2})", arg0:  val_2.r.ToString(), arg1:  val_2.g.ToString(), arg2:  val_2.b.ToString());
            if(this._data == null)
            {
                goto label_3;
            }
            
            if(val_6 != null)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(val_6 == null)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            this._data[0] = val_6;
            val_7 = val_7 + 1;
            if(val_7 < this.Count)
            {
                goto label_9;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_Random()
        {
            this.Readme = "Press Play To Launch";
        }
    
    }

}
