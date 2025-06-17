using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class SSTools : MonoBehaviour
{
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void ShowMessage(string msg, SSTools.Position position, SSTools.Time time)
    {
        UnityEngine.Object val_14 = UnityEngine.Resources.Load(path:  "Message");
        if(val_14 != null)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        val_14 = 0;
        label_2:
        UnityEngine.GameObject val_5 = val_14.gameObject.transform.GetChild(index:  0).gameObject;
        UnityEngine.UI.Text val_11 = val_5.gameObject.transform.GetChild(index:  0).GetChild(index:  0).gameObject.GetComponent<UnityEngine.UI.Text>();
        SSTools.SetPosition(rectTransform:  val_5.GetComponent<UnityEngine.RectTransform>(), position:  position);
        SSTools.RemoveClone(clone:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_14), time:  time);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void SetPosition(UnityEngine.RectTransform rectTransform, SSTools.Position position)
    {
        float val_6;
        if(position != 0)
        {
                UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  0.5f, y:  0f);
            rectTransform.anchorMin = new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
            UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  0.5f, y:  0f);
            rectTransform.anchorMax = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            val_6 = 100f;
        }
        else
        {
                UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0.5f, y:  1f);
            rectTransform.anchorMin = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0.5f, y:  1f);
            rectTransform.anchorMax = new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
            val_6 = -100f;
        }
        
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void RemoveClone(UnityEngine.GameObject clone, SSTools.Time time)
    {
        UnityEngine.Object val_3;
        if(time == 2)
        {
                val_3 = clone.gameObject;
        }
        else
        {
                val_3 = clone.gameObject;
            if(time == 1)
        {
            
        }
        
        }
        
        UnityEngine.Object.Destroy(obj:  val_3, t:  3f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public SSTools()
    {
    
    }

}
