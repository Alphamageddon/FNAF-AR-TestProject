using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class GuideUtils
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Collections.Generic.Dictionary<string, Systems.Guide.UI.IGuideArrow> guideArrows;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Systems.Guide.UI.ITutorialScrim GetScrim()
    {
        GameUI.DialogHandler_Shared val_1 = UnityEngine.Object.FindObjectOfType<GameUI.DialogHandler_Shared>();
        if(val_1 != null)
        {
                return val_1.TutorialScrim;
        }
        
        return val_1.TutorialScrim;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Systems.Guide.UI.IGuideArrow GetPreInstantiatedArrow(string prefabName)
    {
        UnityEngine.Transform val_3 = UnityEngine.Object.FindObjectOfType<GameUI.DialogHandler_Shared>().GuideArrowCanvas.Find(n:  prefabName);
        if(val_3 == 0)
        {
                return 0;
        }
        
        if(val_3 != null)
        {
                return val_3.GetComponent<Systems.Guide.UI.GuideArrowBehaviour>();
        }
        
        return val_3.GetComponent<Systems.Guide.UI.GuideArrowBehaviour>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool TryGetArrowPrefab(string prefabName, out UnityEngine.GameObject result)
    {
        UnityEngine.Object val_6;
        UnityEngine.GameObject val_7;
        UnityEngine.GameObject val_1 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  prefabName);
        if(val_1 != 0)
        {
                val_6 = val_1.GetComponent<Systems.Guide.UI.GuideArrowBehaviour>();
            var val_5 = (val_6 == 0) ? (val_1) : 0;
        }
        else
        {
                val_7 = 0;
            val_6 = 0;
        }
        
        result = val_7;
        val_6 = val_6 & 1;
        return (bool)val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static Systems.Guide.UI.IGuideArrow InstantiateArrowForTarget(UnityEngine.Transform target, UnityEngine.GameObject arrowPrefab)
    {
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  arrowPrefab);
        val_3.transform.SetParent(p:  UnityEngine.Object.FindObjectOfType<GameUI.DialogHandler_Shared>().GuideArrowCanvas);
        string val_5 = arrowPrefab.name;
        if(val_3 != null)
        {
                val_3.name = val_5;
            return val_3.GetComponent<Systems.Guide.UI.GuideArrowBehaviour>();
        }
        
        0.name = val_5;
        return val_3.GetComponent<Systems.Guide.UI.GuideArrowBehaviour>();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void ReparentArrowCanvasToTargetsRenderMode(UnityEngine.Transform target)
    {
        UnityEngine.Camera val_8;
        UnityEngine.Canvas val_3 = UnityEngine.Object.FindObjectOfType<GameUI.DialogHandler_Shared>().GuideArrowCanvas.GetComponent<UnityEngine.Canvas>();
        UnityEngine.Canvas val_4 = GuideUtils.GetCanvasParent(t:  target);
        val_3.renderMode = val_4.renderMode;
        if(val_4.renderMode == 1)
        {
                val_8 = val_4.worldCamera;
        }
        else
        {
                val_8 = 0;
        }
        
        val_3.worldCamera = val_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityEngine.Canvas GetCanvasParent(UnityEngine.Transform t)
    {
        UnityEngine.Object val_5;
        goto label_6;
        label_11:
        val_5 = t.GetComponent<UnityEngine.Canvas>();
        if(val_5 != 0)
        {
                return (UnityEngine.Canvas)val_5;
        }
        
        label_6:
        if(t.parent != 0)
        {
            goto label_11;
        }
        
        val_5 = 0;
        return (UnityEngine.Canvas)val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static bool TryGetButton(string heirarchyPath, out UnityEngine.UI.Button button)
    {
        GameUI.IllumixButton val_6;
        UnityEngine.GameObject val_1 = GuideUtils.FindGameObjectInHeirarchy(path:  heirarchyPath);
        if(val_1 == 0)
        {
            goto label_5;
        }
        
        UnityEngine.UI.Button val_3 = val_1.GetComponent<UnityEngine.UI.Button>();
        button = val_3;
        if(val_3 != 0)
        {
            goto label_9;
        }
        
        val_6 = val_1.GetComponent<GameUI.IllumixButton>();
        button = val_6;
        return UnityEngine.Object.op_Inequality(x:  val_6 = button, y:  0);
        label_5:
        button = 0;
        return false;
        label_9:
        return UnityEngine.Object.op_Inequality(x:  val_6, y:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static UnityEngine.GameObject FindGameObjectInHeirarchy(string path)
    {
        string val_10;
        var val_11;
        char[] val_1 = new char[1];
        val_1[0] = '.';
        val_10 = path.Split(separator:  val_1);
        if(UnityEngine.SceneManagement.SceneManager.sceneCount < 1)
        {
            goto label_4;
        }
        
        var val_12 = 0;
        label_13:
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
        var val_11 = 0;
        label_11:
        if(val_11 >= (???))
        {
            goto label_6;
        }
        
        val_11 = val_11 + 1;
        if((System.String.op_Equality(a:  ???.name, b:  val_10[0])) == false)
        {
            goto label_11;
        }
        
        return (UnityEngine.GameObject)GuideUtils._FindObjectInPathTree(host:  ???, pathElements:  val_10, index:  1);
        label_6:
        val_12 = val_12 + 1;
        if(val_12 < UnityEngine.SceneManagement.SceneManager.sceneCount)
        {
            goto label_13;
        }
        
        label_4:
        val_10 = "Could not evaluate root gameObject \"" + val_10[0] + "\"";
        ConsoleLogger.LogError(className:  "GuideUtils", functionName:  "FindGameObjectInHeirarchy", logString:  val_10);
        val_11 = 0;
        return (UnityEngine.GameObject)GuideUtils._FindObjectInPathTree(host:  ???, pathElements:  val_10, index:  1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static UnityEngine.GameObject _FindObjectInPathTree(UnityEngine.GameObject host, string[] pathElements, int index)
    {
        var val_10;
        string val_11;
        var val_12;
        string val_13;
        int val_14;
        val_10 = index;
        val_11 = pathElements;
        val_12 = host;
        val_13 = 25450;
        goto label_0;
        label_13:
        UnityEngine.Transform val_1 = val_12.transform;
        var val_10 = 0;
        label_8:
        if(val_10 >= val_1.childCount)
        {
            goto label_3;
        }
        
        val_12 = val_1.GetChild(index:  0).gameObject;
        val_10 = val_10 + 1;
        if((System.String.op_Equality(a:  val_12.name, b:  null)) == false)
        {
            goto label_8;
        }
        
        val_10 = val_10 + 1;
        label_0:
        if(val_10 < pathElements.Length)
        {
            goto label_13;
        }
        
        return (UnityEngine.GameObject)val_12;
        label_3:
        val_14 = pathElements.Length;
        if(val_10 >= val_14)
        {
                val_14 = pathElements.Length;
        }
        
        string[] val_8 = new string[5];
        val_8[0] = "Could not evaluate path element \"";
        val_8[1] = null;
        val_13 = "\" under host \"";
        val_8[2] = val_13;
        val_8[3] = val_11[(long)val_10 - 1];
        val_8[4] = "\"";
        val_11 = +val_8;
        ConsoleLogger.LogError(className:  "GuideUtils", functionName:  "FindObjectInPathTree", logString:  val_11);
        val_12 = 0;
        return (UnityEngine.GameObject)val_12;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static GuideUtils()
    {
        GuideUtils.guideArrows = new System.Collections.Generic.Dictionary<System.String, Systems.Guide.UI.IGuideArrow>();
    }

}
