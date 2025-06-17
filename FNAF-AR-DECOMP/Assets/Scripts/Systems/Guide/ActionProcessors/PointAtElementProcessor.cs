using UnityEngine;

namespace Systems.Guide.ActionProcessors
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PointAtElementProcessor
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static void StartAction(Systems.Guide.GuideNode node, Systems.Guide.GuideActionSharedContext actionSharedContext, bool show)
        {
            UnityEngine.Transform val_34;
            float val_35;
            string val_36;
            val_34 = show;
            UnityEngine.GameObject val_11 = 0;
            System.String[] val_1 = Systems.Guide.ArgParser.PrepArgs(args:  node.ActionArgs);
            string val_2 = Systems.Guide.ArgParser.GetString(args:  val_1, index:  0, fallback:  System.String.alignConst);
            string val_3 = Systems.Guide.ArgParser.GetString(args:  val_1, index:  1, fallback:  System.String.alignConst);
            float val_35 = Systems.Guide.ArgParser.GetFloat(args:  val_1, index:  2, fallback:  1f);
            val_35 = Systems.Guide.ArgParser.GetFloat(args:  val_1, index:  3, fallback:  0f);
            val_36 = GuideUtils.GetPreInstantiatedArrow(prefabName:  val_2);
            if((val_36 == null) || (val_34 == true))
            {
                goto label_5;
            }
            
            var val_34 = 0;
            val_34 = val_34 + 1;
            goto label_10;
            label_5:
            if((GuideUtils.TryGetButton(heirarchyPath:  val_3, button: out  0)) == false)
            {
                goto label_13;
            }
            
            val_34 = val_8.transform;
            if(val_36 == null)
            {
                    if((GuideUtils.TryGetArrowPrefab(prefabName:  val_2, result: out  val_11)) == false)
            {
                goto label_46;
            }
            
                val_36 = GuideUtils.InstantiateArrowForTarget(target:  val_34, arrowPrefab:  val_11);
            }
            
            GuideUtils.ReparentArrowCanvasToTargetsRenderMode(target:  val_34);
            UnityEngine.Vector3 val_15 = val_8.transform.position;
            UnityEngine.RectTransform val_17 = val_8.gameObject.GetComponent<UnityEngine.RectTransform>();
            UnityEngine.Rect val_18 = val_17.rect;
            UnityEngine.Rect val_19 = val_17.rect;
            UnityEngine.Vector2 val_20 = new UnityEngine.Vector2(x:  val_18.m_XMin, y:  val_19.m_XMin);
            val_35 = val_35 * val_18.m_XMin;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.forward;
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.AngleAxis(angle:  val_35, axis:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.right;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
            UnityEngine.Vector3 val_26 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_22.x, y = val_22.y, z = val_22.z, w = val_22.w}, point:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z}, d:  val_35);
            UnityEngine.Vector2 val_28 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            float val_36 = Systems.Guide.ArgParser.GetFloat(args:  val_1, index:  4, fallback:  1f);
            val_35 = val_35;
            UnityEngine.Vector3 val_30 = val_8.transform.lossyScale;
            val_36 = val_36 * val_30.x;
            var val_37 = 0;
            val_37 = val_37 + 1;
            goto label_41;
            label_13:
            label_46:
            val_36 = "Could not find PointAtElementProcessor target \"" + val_3 + "\", ignoring action";
            ConsoleLogger.LogError(className:  "PointAtElementProcessor", functionName:  "StartAction", logString:  val_36);
            return;
            label_10:
            val_36.Hide();
            return;
            label_41:
            val_36.ShowWithTarget(worldPos:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, canvasOffset:  new UnityEngine.Vector2() {x = val_28.x, y = val_28.y}, rotation:  val_35, scaling:  val_36);
        }
    
    }

}
