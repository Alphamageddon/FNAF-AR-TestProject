using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UICellManager<T, U, V>
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected System.Collections.Generic.List<T> _cells;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void GenerateCells(T prefab, UnityEngine.Transform parent, int numCells)
        {
            int val_1 = numCells;
            if(val_1 < 1)
            {
                    return;
            }
            
            do
            {
                val_1 = val_1 - 1;
            }
            while(val_1 != 0);
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void ClearCells()
        {
            var val_1;
            var val_2;
            var val_7;
            var val_8;
            var val_9;
            label_6:
            if(((-1162025264) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Object.Destroy(obj:  val_2.emailUIDataHandler.gameObject);
            goto label_6;
            label_2:
            val_7 = 0;
            val_8 = 61;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 56;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 56 + 286) == 0)
            {
                goto label_15;
            }
            
            var val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 56 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_14:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 56 + 176 + 8) + -8) == null)
            {
                goto label_13;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (__RuntimeMethodHiddenParam + 24 + 192 + 56 + 286))
            {
                goto label_14;
            }
            
            goto label_15;
            label_13:
            val_9 = ((__RuntimeMethodHiddenParam + 24 + 192 + 56) + (((__RuntimeMethodHiddenParam + 24 + 192 + 56 + 176 + 8)) << 4)) + 296;
            label_15:
            val_2.Dispose();
            if(this != null)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SetDatas(V[] datas)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = 0;
            goto label_1;
            label_12:
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 72];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 72;
            if(val_2 >= datas.Length)
            {
                    val_3 = 0;
            }
            
            V val_1 = datas[0];
            var val_4 = X23;
            if((X23 + 286) == 0)
            {
                goto label_7;
            }
            
            var val_2 = X23 + 176;
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_9:
            if(((X23 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 96))
            {
                goto label_8;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < (X23 + 286))
            {
                goto label_9;
            }
            
            label_7:
            val_3 = 0;
            goto label_10;
            label_8:
            val_4 = val_4 + (((X23 + 176 + 8)) << 4);
            val_4 = val_4 + 296;
            label_10:
            val_2 = 1;
            label_1:
            if(val_2 < datas.Length)
            {
                goto label_12;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SetData(V data, int index)
        {
            var val_2;
            if(69750784 > index)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 72];
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 72;
                var val_2 = 0;
                val_2 = val_2 + 1;
                val_2 = 0;
            }
            else
            {
                    ConsoleLogger.LogError(className:  "UICellManager", functionName:  "SetData", logString:  "Index out of bounds!");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SetIcons(UnityEngine.Sprite[] sprites)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = 0;
            goto label_1;
            label_12:
            val_3 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 72];
            val_3 = __RuntimeMethodHiddenParam + 24 + 192 + 72;
            if(val_2 >= sprites.Length)
            {
                    val_3 = 0;
            }
            
            UnityEngine.Sprite val_1 = sprites[0];
            var val_5 = X23;
            if((X23 + 286) == 0)
            {
                goto label_7;
            }
            
            var val_2 = X23 + 176;
            var val_3 = 0;
            val_2 = val_2 + 8;
            label_9:
            if(((X23 + 176 + 8) + -8) == (__RuntimeMethodHiddenParam + 24 + 192 + 96))
            {
                goto label_8;
            }
            
            val_3 = val_3 + 1;
            val_2 = val_2 + 16;
            if(val_3 < (X23 + 286))
            {
                goto label_9;
            }
            
            label_7:
            val_3 = 1;
            goto label_10;
            label_8:
            var val_4 = val_2;
            val_4 = val_4 + 1;
            val_5 = val_5 + val_4;
            val_4 = val_5 + 296;
            label_10:
            val_2 = 1;
            label_1:
            if(val_2 < sprites.Length)
            {
                goto label_12;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected void SetIcon(UnityEngine.Sprite icon, int index)
        {
            var val_2;
            if(69750784 > index)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 72];
                val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 72;
                var val_2 = 0;
                val_2 = val_2 + 1;
                val_2 = 1;
            }
            else
            {
                    ConsoleLogger.LogError(className:  "UICellManager", functionName:  "SetIcon", logString:  "Index out of bounds!");
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UICellManager<T, U, V>()
        {
            mem[1152921524920410944] = __RuntimeMethodHiddenParam + 24 + 192 + 128;
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
