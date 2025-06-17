using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class ConsoleBase : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int DpiScalingFactor = 160;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Stack<string> menuStack;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string lastResponse;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector2 scrollPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<float> scaleFactor;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GUIStyle textStyle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GUIStyle buttonStyle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GUIStyle textInputStyle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GUIStyle labelStyle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D <LastResponseTexture>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static int ButtonHeight { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static int MainWindowWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static int MainWindowFullWidth { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static int MarginFix { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static System.Collections.Generic.Stack<string> MenuStack { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected string Status { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Texture2D LastResponseTexture { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected string LastResponse { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector2 ScrollPosition { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float ScaleFactor { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int FontSize { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.GUIStyle TextStyle { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.GUIStyle ButtonStyle { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.GUIStyle TextInputStyle { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.GUIStyle LabelStyle { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static int get_ButtonHeight()
        {
            return (int)(Facebook.Unity.Constants.IsMobile != true) ? 60 : 24;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static int get_MainWindowWidth()
        {
            var val_3;
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    val_3 = UnityEngine.Screen.width - 30;
                return 700;
            }
            
            val_3 = 700;
            return 700;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static int get_MainWindowFullWidth()
        {
            if(Facebook.Unity.Constants.IsMobile == false)
            {
                    return 760;
            }
            
            return UnityEngine.Screen.width;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static int get_MarginFix()
        {
            return (int)(Facebook.Unity.Constants.IsMobile != true) ? 0 : 48;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static System.Collections.Generic.Stack<string> get_MenuStack()
        {
            null = null;
            return (System.Collections.Generic.Stack<System.String>)Facebook.Unity.Example.ConsoleBase.menuStack;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected static void set_MenuStack(System.Collections.Generic.Stack<string> value)
        {
            null = null;
            Facebook.Unity.Example.ConsoleBase.menuStack = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected string get_Status()
        {
            return (string)this.status;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_Status(string value)
        {
            this.status = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Texture2D get_LastResponseTexture()
        {
            return (UnityEngine.Texture2D)this.<LastResponseTexture>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_LastResponseTexture(UnityEngine.Texture2D value)
        {
            this.<LastResponseTexture>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected string get_LastResponse()
        {
            return (string)this.lastResponse;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_LastResponse(string value)
        {
            this.lastResponse = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.Vector2 get_ScrollPosition()
        {
            return new UnityEngine.Vector2() {x = this.scrollPosition};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void set_ScrollPosition(UnityEngine.Vector2 value)
        {
            this.scrollPosition = value;
            mem[1152921520098690460] = value.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected float get_ScaleFactor()
        {
            if((this.scaleFactor & 1) != 0)
            {
                    return (float)val_1;
            }
            
            float val_1 = UnityEngine.Screen.dpi;
            val_1 = val_1 / 160f;
            mem2[0] = 0;
            return (float)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected int get_FontSize()
        {
            float val_3;
            float val_6;
            double val_7;
            float val_2 = this.ScaleFactor * 16f;
            if(val_2 >= 0f)
            {
                goto label_3;
            }
            
            if((double)val_2 != (-0.5))
            {
                goto label_4;
            }
            
            val_6 = val_3;
            val_7 = -1;
            goto label_5;
            label_3:
            if((double)val_2 != 0.5)
            {
                    return (int)(int)(double)val_2 + 0.5;
            }
            
            val_6 = val_3;
            val_7 = 1;
            label_5:
            val_7 = val_6 + val_7;
            val_6 = (((long)val_6 & 1) != 0) ? (val_6) : (val_7);
            return (int)(int)(double)val_2 + 0.5;
            label_4:
            double val_4 = (double)val_2 + (-0.5);
            return (int)(int)(double)val_2 + 0.5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.GUIStyle get_TextStyle()
        {
            UnityEngine.GUIStyle val_6 = this.textStyle;
            if(val_6 != null)
            {
                    return val_6;
            }
            
            UnityEngine.GUIStyle val_3 = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.textArea);
            this.textStyle = val_3;
            val_3.alignment = 0;
            this.textStyle.wordWrap = true;
            this.textStyle.padding = new UnityEngine.RectOffset(left:  10, right:  10, top:  10, bottom:  10);
            this.textStyle.stretchHeight = true;
            this.textStyle.stretchWidth = false;
            this.textStyle.fontSize = this.FontSize;
            val_6 = this.textStyle;
            return val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.GUIStyle get_ButtonStyle()
        {
            UnityEngine.GUIStyle val_5 = this.buttonStyle;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            UnityEngine.GUIStyle val_3 = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.button);
            this.buttonStyle = val_3;
            val_3.fontSize = this.FontSize;
            val_5 = this.buttonStyle;
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.GUIStyle get_TextInputStyle()
        {
            UnityEngine.GUIStyle val_5 = this.textInputStyle;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            UnityEngine.GUIStyle val_3 = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.textField);
            this.textInputStyle = val_3;
            val_3.fontSize = this.FontSize;
            val_5 = this.textInputStyle;
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected UnityEngine.GUIStyle get_LabelStyle()
        {
            UnityEngine.GUIStyle val_5 = this.labelStyle;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            UnityEngine.GUIStyle val_3 = new UnityEngine.GUIStyle(other:  UnityEngine.GUI.skin.label);
            this.labelStyle = val_3;
            val_3.fontSize = this.FontSize;
            val_5 = this.labelStyle;
            return val_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected virtual void Awake()
        {
            UnityEngine.Application.targetFrameRate = 60;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool Button(string label)
        {
            UnityEngine.GUILayoutOption[] val_2 = new UnityEngine.GUILayoutOption[2];
            float val_4 = this.ScaleFactor;
            val_4 = ((Facebook.Unity.Constants.IsMobile != true) ? 60f : 24f) * val_4;
            UnityEngine.GUILayoutOption val_6 = UnityEngine.GUILayout.MinHeight(minHeight:  val_4);
            if(val_2 == null)
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
            val_2[0] = val_6;
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    int val_9 = UnityEngine.Screen.width - 30;
            }
            
            val_2[1] = UnityEngine.GUILayout.MaxWidth(maxWidth:  700f);
            return UnityEngine.GUILayout.Button(text:  label, style:  this.ButtonStyle, options:  val_2);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void LabelAndTextField(string label, ref string text)
        {
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayoutOption[] val_3 = new UnityEngine.GUILayoutOption[1];
            float val_4 = this.ScaleFactor;
            val_4 = val_4 * 200f;
            UnityEngine.GUILayoutOption val_5 = UnityEngine.GUILayout.MaxWidth(maxWidth:  val_4);
            if(val_3 == null)
            {
                goto label_1;
            }
            
            if(val_5 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_5 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_3[0] = val_5;
            UnityEngine.GUILayout.Label(text:  label, style:  this.LabelStyle, options:  val_3);
            UnityEngine.GUILayoutOption[] val_7 = new UnityEngine.GUILayoutOption[1];
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    int val_10 = UnityEngine.Screen.width - 180;
            }
            
            UnityEngine.GUILayoutOption val_11 = UnityEngine.GUILayout.MaxWidth(maxWidth:  550f);
            if(val_7 == null)
            {
                goto label_11;
            }
            
            if(val_11 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_11 == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_7[0] = val_11;
            text = UnityEngine.GUILayout.TextField(text:  text, style:  this.TextInputStyle, options:  val_7);
            UnityEngine.GUILayout.EndHorizontal();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected bool IsHorizontalLayout()
        {
            return (bool)(UnityEngine.Screen.orientation == 3) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SwitchMenu(System.Type menuClass)
        {
            null = null;
            Facebook.Unity.Example.ConsoleBase.menuStack.Push(item:  this.GetType());
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  menuClass);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void GoBack()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((System.Linq.Enumerable.Any<System.String>(source:  Facebook.Unity.Example.ConsoleBase.menuStack)) == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  Facebook.Unity.Example.ConsoleBase.menuStack.Pop());
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ConsoleBase()
        {
            this.status = "Ready";
            this.lastResponse = System.String.alignConst;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.scrollPosition = val_1;
            mem[1152921520100583724] = val_1.y;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ConsoleBase()
        {
            Facebook.Unity.Example.ConsoleBase.menuStack = new System.Collections.Generic.Stack<System.String>();
        }
    
    }

}
