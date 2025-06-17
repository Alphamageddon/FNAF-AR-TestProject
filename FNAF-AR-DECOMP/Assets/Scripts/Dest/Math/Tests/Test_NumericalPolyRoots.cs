using UnityEngine;

namespace Dest.Math.Tests
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Test_NumericalPolyRoots : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Readme;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _linear;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _quadratic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _cubic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _quartic;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] _poly;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _linearMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _quadraticMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _cubicMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _quarticMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string _polyMessage;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            System.String[] val_1 = this.CreateArray(size:  1);
            this._linear = val_1;
            System.String[] val_2 = val_1.CreateArray(size:  2);
            this._quadratic = val_2;
            System.String[] val_3 = val_2.CreateArray(size:  3);
            this._cubic = val_3;
            System.String[] val_4 = val_3.CreateArray(size:  4);
            this._quartic = val_4;
            this._poly = val_4.CreateArray(size:  5);
            this._quarticMessage = "Press \'Solve\' to solve equation";
            this._polyMessage = "Press \'Solve\' to solve equation";
            this._quadraticMessage = "Press \'Solve\' to solve equation";
            this._cubicMessage = "Press \'Solve\' to solve equation";
            this._linearMessage = "Press \'Solve\' to solve equation";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnGUI()
        {
            UnityEngine.GUILayout.Space(pixels:  20f);
            this.Draw(coeffs:  this._linear, message: ref  this._linearMessage);
            this.Draw(coeffs:  this._quadratic, message: ref  this._quadraticMessage);
            this.Draw(coeffs:  this._cubic, message: ref  this._cubicMessage);
            this.Draw(coeffs:  this._quartic, message: ref  this._quarticMessage);
            this.Draw(coeffs:  this._poly, message: ref  this._polyMessage);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Draw(string[] coeffs, ref string message)
        {
            int val_18;
            string val_19;
            UnityEngine.GUILayoutOption[] val_20;
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayoutOption val_2 = UnityEngine.GUILayout.Width(width:  35f);
            val_18 = coeffs.Length;
            int val_3 = val_18 - 1;
            if((val_3 & 2147483648) != 0)
            {
                goto label_2;
            }
            
            goto label_3;
            label_22:
            val_18 = coeffs.Length;
            label_3:
            UnityEngine.GUILayoutOption[] val_4 = new UnityEngine.GUILayoutOption[1];
            if(val_4 == null)
            {
                goto label_5;
            }
            
            if(val_2 != null)
            {
                goto label_6;
            }
            
            goto label_9;
            label_5:
            if(val_2 == null)
            {
                goto label_9;
            }
            
            label_6:
            label_9:
            val_4[0] = val_2;
            mem2[0] = UnityEngine.GUILayout.TextField(text:  coeffs[(long)val_3], options:  val_4);
            if(val_3 != 0)
            {
                    val_19 = "x^" + val_3.ToString() + " + "(" + ");
            }
            else
            {
                    val_19 = " = 0";
            }
            
            UnityEngine.GUILayoutOption[] val_8 = new UnityEngine.GUILayoutOption[1];
            if(val_8 == null)
            {
                goto label_16;
            }
            
            if(val_2 != null)
            {
                goto label_17;
            }
            
            goto label_20;
            label_16:
            if(val_2 == null)
            {
                goto label_20;
            }
            
            label_17:
            label_20:
            val_8[0] = val_2;
            UnityEngine.GUILayout.Label(text:  val_19, options:  val_8);
            int val_20 = val_3;
            val_20 = val_20 - 1;
            if((val_20 & 2147483648) == 0)
            {
                goto label_22;
            }
            
            label_2:
            UnityEngine.GUILayout.Space(pixels:  10f);
            UnityEngine.GUILayoutOption[] val_9 = new UnityEngine.GUILayoutOption[1];
            val_20 = val_9;
            val_20[0] = UnityEngine.GUILayout.Width(width:  100f);
            if((UnityEngine.GUILayout.Button(text:  "Solve", options:  val_9)) == false)
            {
                goto label_34;
            }
            
            float[] val_12 = new float[0];
            val_20 = val_12;
            if(coeffs.Length < 1)
            {
                goto label_28;
            }
            
            label_33:
            if((System.Single.TryParse(s:  coeffs[0], result: out  float val_13 = 1.883436E+37f)) == false)
            {
                goto label_30;
            }
            
            val_20[0] = 0f;
            if((0 + 1) < coeffs.Length)
            {
                goto label_33;
            }
            
            label_28:
            this.Solve(array:  val_12, message: ref  string val_16 = message);
            goto label_34;
            label_30:
            message = coeffs[0x0] + 32(coeffs[0x0] + 32) + " is not a number!"(" is not a number!");
            label_34:
            UnityEngine.GUILayout.Space(pixels:  10f);
            UnityEngine.GUILayout.Label(text:  message, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.EndHorizontal();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] CreateArray(int size)
        {
            var val_2;
            size = size + 1;
            string[] val_1 = new string[0];
            val_2 = 0;
            goto label_1;
            label_6:
            val_2 = 1;
            val_1[0] = "0";
            label_1:
            if(val_2 < val_1.Length)
            {
                goto label_6;
            }
            
            return (System.String[])val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Solve(float[] array, ref string message)
        {
            Dest.Math.Polynomial val_21;
            float val_22;
            var val_23;
            var val_24;
            System.Single[] val_8 = 0;
            if((array.Length - 2) > 3)
            {
                goto label_2;
            }
            
            var val_24 = 52957164;
            val_24 = (52957164 + ((array.Length - 2)) << 2) + val_24;
            goto (52957164 + ((array.Length - 2)) << 2 + 52957164);
            label_2:
            int val_5 = array.Length - 1;
            Dest.Math.Polynomial val_6 = null;
            val_21 = val_6;
            val_6 = new Dest.Math.Polynomial(degree:  val_5);
            if((val_5 & 2147483648) == 0)
            {
                    do
            {
                val_23 = 0;
                val_22 = array[val_23];
                val_6.set_Item(index:  0, value:  val_22);
            }
            while((val_23 + 1) <= val_5);
            
            }
            
            if((Dest.Math.RootFinder.Polynomial(poly:  val_6, roots: out  val_8, digits:  6, epsilon:  1E-05f)) == false)
            {
                goto label_93;
            }
            
            message = "RootCount: "("RootCount: ") + 15026800;
            val_23 = "   X";
            val_24 = 0;
            goto label_15;
            label_37:
            string[] val_11 = new string[5];
            if(val_11 == null)
            {
                goto label_16;
            }
            
            if(message != null)
            {
                goto label_17;
            }
            
            goto label_20;
            label_16:
            if(message == null)
            {
                goto label_20;
            }
            
            label_17:
            label_20:
            val_11[0] = message;
            val_11[1] = "   X";
            val_11[2] = 0.ToString();
            val_11[3] = "=";
            val_11[4] = (val_8 + 0) + 32.ToString();
            message = +val_11;
            val_24 = 1;
            label_15:
            val_21 = val_8;
            if(val_24 < 15026800)
            {
                goto label_37;
            }
            
            return;
            label_93:
            message = "Has no solution";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Test_NumericalPolyRoots()
        {
            this.Readme = "Press Play To Launch";
        }
    
    }

}
