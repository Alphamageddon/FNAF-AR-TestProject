using UnityEngine;

namespace Systems.Android
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class AndroidBackButtonHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int nextId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Stack<Systems.Android.AndroidBackButtonHandler.BackButtonStackEntry> _backButtonStack;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int nextPauseId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<int> _activePausers;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int PushBackButtonAction(System.Action backButtonAction)
        {
            null = null;
            AndroidBackButtonHandler.BackButtonStackEntry val_1 = new AndroidBackButtonHandler.BackButtonStackEntry();
            if(val_1 != null)
            {
                    .Id = Systems.Android.AndroidBackButtonHandler.nextId;
            }
            else
            {
                    mem[16] = Systems.Android.AndroidBackButtonHandler.nextId;
            }
            
            .BackButtonAction = backButtonAction;
            Systems.Android.AndroidBackButtonHandler._backButtonStack.Push(item:  val_1);
            int val_2 = Systems.Android.AndroidBackButtonHandler.nextId;
            val_2 = val_2 + 1;
            Systems.Android.AndroidBackButtonHandler.nextId = val_2;
            return (int)Systems.Android.AndroidBackButtonHandler.nextId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Systems.Android.AndroidBackButtonHandler.BackButtonStackEntry PopBackButtonAction()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(Systems.Android.AndroidBackButtonHandler._backButtonStack.Count < 1)
            {
                    return 0;
            }
            
            val_4 = null;
            val_4 = null;
            if(Systems.Android.AndroidBackButtonHandler._backButtonStack.Peek() != null)
            {
                    return Systems.Android.AndroidBackButtonHandler.RemoveBackButtonActionById(backButtonId:  val_2.Id);
            }
            
            return Systems.Android.AndroidBackButtonHandler.RemoveBackButtonActionById(backButtonId:  val_2.Id);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Systems.Android.AndroidBackButtonHandler.BackButtonStackEntry RemoveBackButtonActionById(int backButtonId)
        {
            var val_3;
            BackButtonStackEntry val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            BackButtonStackEntry val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_14 = backButtonId;
            val_15 = null;
            val_15 = null;
            if(Systems.Android.AndroidBackButtonHandler._backButtonStack.Count < 1)
            {
                    return 0;
            }
            
            val_16 = null;
            val_16 = null;
            Stack.Enumerator<T> val_2 = Systems.Android.AndroidBackButtonHandler._backButtonStack.GetEnumerator();
            label_10:
            if((1654138560 & 1) == 0)
            {
                goto label_8;
            }
            
            if(val_3 != val_14)
            {
                goto label_10;
            }
            
            val_17 = 0;
            val_18 = 1;
            val_19 = 1;
            val_20 = 1;
            goto label_12;
            label_8:
            val_17 = 0;
            val_20 = 0;
            val_18 = 1;
            val_19 = 1;
            label_12:
            if( == 0)
            {
                    return 0;
            }
            
            System.Collections.Generic.Stack<BackButtonStackEntry> val_6 = new System.Collections.Generic.Stack<BackButtonStackEntry>();
            val_19 = 1152921523440829520;
            goto label_18;
            label_28:
            val_6.Push(item:  null);
            label_18:
            val_21 = null;
            val_21 = null;
            if(Systems.Android.AndroidBackButtonHandler._backButtonStack.Count <= 0)
            {
                goto label_23;
            }
            
            val_22 = null;
            val_22 = null;
            BackButtonStackEntry val_8 = Systems.Android.AndroidBackButtonHandler._backButtonStack.Pop();
            if(val_8.Id != val_14)
            {
                goto label_28;
            }
            
            goto label_29;
            label_35:
            val_23 = null;
            val_14 = val_6.Pop();
            val_23 = null;
            Systems.Android.AndroidBackButtonHandler._backButtonStack.Push(item:  val_14);
            label_23:
            if(val_6.Count >= 1)
            {
                goto label_35;
            }
            
            return 0;
            label_41:
            val_24 = mem[???];
            val_24 = ???;
            if((((val_24 + 295) & 2) != 0) && ((val_24 + 216) == 0))
            {
                    val_24 = mem[???];
                val_24 = ???;
            }
            
            val_24 + 184 + 8.Push(item:  ???.Pop());
            label_29:
            if((???.Count) >= 1)
            {
                goto label_41;
            }
            
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ClearAllBackButtonActions()
        {
            null = null;
            Systems.Android.AndroidBackButtonHandler._backButtonStack.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static int Pause()
        {
            null = null;
            bool val_1 = Systems.Android.AndroidBackButtonHandler._activePausers.Add(item:  Systems.Android.AndroidBackButtonHandler.nextPauseId);
            int val_2 = Systems.Android.AndroidBackButtonHandler.nextPauseId;
            val_2 = val_2 + 1;
            Systems.Android.AndroidBackButtonHandler.nextPauseId = val_2;
            return (int)Systems.Android.AndroidBackButtonHandler.nextPauseId;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Unpause(int pauseId)
        {
            null = null;
            bool val_1 = Systems.Android.AndroidBackButtonHandler._activePausers.Remove(item:  pauseId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void ClearAllPause()
        {
            null = null;
            Systems.Android.AndroidBackButtonHandler._activePausers.Clear();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void Update()
        {
            null = null;
            if(Systems.Android.AndroidBackButtonHandler._activePausers.Count > 0)
            {
                    return;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  27)) == false)
            {
                    return;
            }
            
            if(Systems.Android.AndroidBackButtonHandler.PopBackButtonAction() == null)
            {
                    return;
            }
            
            if(val_3.BackButtonAction == null)
            {
                    return;
            }
            
            val_3.BackButtonAction.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static AndroidBackButtonHandler()
        {
            Systems.Android.AndroidBackButtonHandler.nextId = 100;
            Systems.Android.AndroidBackButtonHandler._backButtonStack = new System.Collections.Generic.Stack<BackButtonStackEntry>();
            Systems.Android.AndroidBackButtonHandler.nextPauseId = 1000;
            Systems.Android.AndroidBackButtonHandler._activePausers = new System.Collections.Generic.HashSet<System.Int32>();
        }
    
    }

}
