using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_NumericalLinearSystem : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Readme;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _textfield;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _size;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[,] _A;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _B;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _X;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _message;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this.SetSize(size:  2);
            this._textfield = this._size.ToString();
            this._message = System.String.alignConst;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGUI()
        {
            UnityEngine.GUILayoutOption[] val_27;
            System.String[] val_30;
            val_27 = 1152921518805521584;
            int val_6 = 0;
            UnityEngine.GUILayout.Label(text:  "System Size: ", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            this._textfield = UnityEngine.GUILayout.TextField(text:  this._textfield, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            if((UnityEngine.GUILayout.Button(text:  "Set Size", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
            {
                    if((val_6 >= 1) && ((System.Int32.TryParse(s:  this._textfield, result: out  val_6)) != false))
            {
                    this.SetSize(size:  0);
            }
            
            }
            
            UnityEngine.GUILayout.Space(pixels:  20f);
            UnityEngine.GUILayout.BeginVertical(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            if(this._size < 1)
            {
                goto label_4;
            }
            
            var val_30 = 0;
            label_35:
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            if(this._size < 1)
            {
                goto label_5;
            }
            
            var val_28 = 0;
            label_17:
            UnityEngine.GUILayoutOption[] val_11 = new UnityEngine.GUILayoutOption[1];
            UnityEngine.GUILayoutOption val_12 = UnityEngine.GUILayout.Width(width:  50f);
            if(val_11 == null)
            {
                goto label_9;
            }
            
            if(val_12 != null)
            {
                goto label_10;
            }
            
            goto label_13;
            label_9:
            if(val_12 == null)
            {
                goto label_13;
            }
            
            label_10:
            label_13:
            val_11[0] = val_12;
            this._A[0 + ((val_11.Length + 16) * 0)] = UnityEngine.GUILayout.TextField(text:  this._A[0 + ((this._size + 16) * 0)], options:  val_11);
            val_28 = val_28 + 1;
            if(val_28 < this._size)
            {
                goto label_17;
            }
            
            label_5:
            UnityEngine.GUILayoutOption[] val_15 = new UnityEngine.GUILayoutOption[1];
            UnityEngine.GUILayoutOption val_16 = UnityEngine.GUILayout.Width(width:  50f);
            if(val_15 == null)
            {
                goto label_18;
            }
            
            if(val_16 != null)
            {
                goto label_19;
            }
            
            goto label_22;
            label_18:
            if(val_16 == null)
            {
                goto label_22;
            }
            
            label_19:
            label_22:
            val_15[0] = val_16;
            UnityEngine.GUILayout.Label(text:  " ", options:  val_15);
            val_30 = this._B;
            UnityEngine.GUILayoutOption[] val_17 = new UnityEngine.GUILayoutOption[1];
            val_27 = val_17;
            UnityEngine.GUILayoutOption val_18 = UnityEngine.GUILayout.Width(width:  50f);
            if(val_27 == null)
            {
                goto label_26;
            }
            
            if(val_18 != null)
            {
                goto label_27;
            }
            
            goto label_30;
            label_26:
            if(val_18 == null)
            {
                goto label_30;
            }
            
            label_27:
            label_30:
            val_27[0] = val_18;
            mem2[0] = UnityEngine.GUILayout.TextField(text:  val_30[0], options:  val_17);
            UnityEngine.GUILayout.EndHorizontal();
            val_30 = val_30 + 1;
            if(val_30 < this._size)
            {
                goto label_35;
            }
            
            label_4:
            UnityEngine.GUILayout.EndVertical();
            UnityEngine.GUILayout.Space(pixels:  20f);
            if((UnityEngine.GUILayout.Button(text:  "Solve System", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
            {
                    this.SolveSystem();
            }
            
            UnityEngine.GUILayout.Space(pixels:  20f);
            UnityEngine.GUILayout.BeginVertical(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            if(this._size < 1)
            {
                goto label_37;
            }
            
            label_46:
            UnityEngine.GUILayoutOption[] val_23 = new UnityEngine.GUILayoutOption[1];
            val_27 = val_23;
            UnityEngine.GUILayoutOption val_24 = UnityEngine.GUILayout.Width(width:  50f);
            if(val_27 == null)
            {
                goto label_40;
            }
            
            if(val_24 != null)
            {
                goto label_41;
            }
            
            goto label_44;
            label_40:
            if(val_24 == null)
            {
                goto label_44;
            }
            
            label_41:
            label_44:
            val_27[0] = val_24;
            string val_25 = UnityEngine.GUILayout.TextField(text:  this._X[0], options:  val_23);
            val_30 = 0 + 1;
            if(val_30 < this._size)
            {
                goto label_46;
            }
            
            label_37:
            UnityEngine.GUILayout.EndVertical();
            UnityEngine.GUILayout.Space(pixels:  20f);
            UnityEngine.GUILayout.Label(text:  this._message, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetSize(int size)
        {
            int val_4 = size;
            this._size = val_4;
            this._A = null;
            this._B = new string[0];
            this._X = new string[0];
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            label_16:
            var val_4 = 0;
            do
            {
                val_4 = val_4 + 1;
                this._A[val_4 + (val_5 * ((long)(int)(size) + 16))] = "0";
            }
            while(val_4 != val_4);
            
            this._B[val_5] = "0";
            val_4 = System.String.alignConst;
            if(this._X == null)
            {
                goto label_10;
            }
            
            if(val_4 != 0)
            {
                goto label_11;
            }
            
            goto label_14;
            label_10:
            if(val_4 == 0)
            {
                goto label_14;
            }
            
            label_11:
            label_14:
            val_5 = val_5 + 1;
            this._X[val_5] = val_4;
            if(val_5 != val_4)
            {
                goto label_16;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SolveSystem()
        {
            System.Single[] val_12;
            string val_13;
            System.String[] val_14;
            System.String[] val_15;
            System.String[,] val_16;
            System.Single[] val_9 = 0;
            float[] val_1 = new float[0];
            val_12 = val_1;
            if(this._size < 1)
            {
                goto label_1;
            }
            
            val_13 = "Table contains not a number";
            val_14 = 0;
            label_16:
            if(this._size < 1)
            {
                goto label_2;
            }
            
            var val_15 = 0;
            val_15 = 0;
            label_10:
            val_16 = this._A;
            if((System.Single.TryParse(s:  val_16[0 + ((this._size + 16) * val_15)], result: out  float val_3 = 1.395752E+37f)) == false)
            {
                goto label_29;
            }
            
            val_16 = 0;
            mem2[0] = val_16;
            val_15 = val_15 + 1;
            if(val_15 < this._size)
            {
                goto label_10;
            }
            
            label_2:
            val_15 = this._B;
            if((System.Single.TryParse(s:  val_15[0], result: out  float val_7 = 1.395752E+37f)) == false)
            {
                goto label_29;
            }
            
            val_15 = 0;
            val_12[0] = 0f;
            val_14 = val_14 + 1;
            if(val_14 < this._size)
            {
                goto label_16;
            }
            
            label_1:
            if((Dest.Math.LinearSystem.Solve(A:  null, B:  val_1, X: out  val_9)) == false)
            {
                goto label_17;
            }
            
            if(this._size < 1)
            {
                goto label_18;
            }
            
            val_13 = "System successfuly solved";
            label_27:
            val_14 = this._X;
            string val_13 = (val_9 + 0) + 32.ToString();
            if(val_14 == null)
            {
                goto label_21;
            }
            
            if(val_13 != null)
            {
                goto label_22;
            }
            
            goto label_25;
            label_21:
            if(val_13 == null)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            val_14[0] = val_13;
            val_12 = 0 + 1;
            if(val_12 < this._size)
            {
                goto label_27;
            }
            
            goto label_29;
            label_17:
            val_13 = "System has no solution";
            goto label_29;
            label_18:
            val_13 = "System successfuly solved";
            label_29:
            this._message = val_13;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_NumericalLinearSystem()
        {
            this.Readme = "Press Play To Launch";
        }
    
    }

}
