using UnityEngine;

namespace DigitalRuby.ThunderAndLightning
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightningBoltTransformTrackerScript : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.LightningBoltPrefabScript LightningScript;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform StartTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform EndTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DigitalRuby.ThunderAndLightning.RangeOfFloats ScaleLimit;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<UnityEngine.Transform, DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo> transformStartPositions;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            if(this.LightningScript == 0)
            {
                    return;
            }
            
            this.LightningScript.RemoveAllListeners();
            this.LightningScript.AddListener(call:  new UnityEngine.Events.UnityAction<DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo>(object:  this, method:  public System.Void DigitalRuby.ThunderAndLightning.LightningBoltTransformTrackerScript::CustomTransformHandler(DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo state)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static float AngleBetweenVector2(UnityEngine.Vector2 vec1, UnityEngine.Vector2 vec2)
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = vec2.x, y = vec2.y}, b:  new UnityEngine.Vector2() {x = vec1.x, y = vec1.y});
            UnityEngine.Vector2 val_2 = val_1.x.normalized;
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.right;
            float val_6 = UnityEngine.Mathf.Sign(f:  vec2.y - vec1.y);
            val_6 = (UnityEngine.Vector2.Angle(from:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, to:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) * val_6;
            return (float)val_6;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static void UpdateTransform(DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo state, DigitalRuby.ThunderAndLightning.LightningBoltPrefabScript script, DigitalRuby.ThunderAndLightning.RangeOfFloats scaleLimit)
        {
            float val_48;
            UnityEngine.Transform val_49;
            UnityEngine.Transform val_50;
            UnityEngine.Vector3 val_51;
            float val_55;
            float val_56;
            float val_58;
            float val_59;
            float val_60;
            float val_61;
            var val_66;
            val_48 = scaleLimit.Maximum;
            val_49 = state;
            val_50 = state.Transform;
            if(val_50 == 0)
            {
                    return;
            }
            
            val_50 = state.StartTransform;
            if(val_50 == 0)
            {
                    return;
            }
            
            if(state.EndTransform == 0)
            {
                    val_50 = state.StartTransform;
                UnityEngine.Vector3 val_4 = val_50.position;
                val_51 = state.BoltStartPosition;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_51, y = V11.16B, z = V10.16B});
                val_48 = val_5.x;
                val_55 = val_5.y;
                val_56 = val_5.z;
                if(state.Transform != null)
            {
                goto label_15;
            }
            
            }
            else
            {
                    bool val_6 = state.EndTransform.orthographic;
                UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = state.BoltStartPosition, y = V10.16B, z = V11.16B});
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = state.BoltEndPosition, y = V3.16B, z = V11.16B});
                UnityEngine.Vector3 val_10 = state.StartTransform.position;
                UnityEngine.Vector2 val_11 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
                UnityEngine.Vector3 val_12 = state.EndTransform.position;
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
                UnityEngine.Vector3 val_15 = UnityEngine.Vector3.forward;
                UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.AngleAxis(angle:  (DigitalRuby.ThunderAndLightning.LightningBoltTransformTrackerScript.AngleBetweenVector2(vec1:  new UnityEngine.Vector2() {x = val_11.x, y = val_11.y}, vec2:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y})) - (DigitalRuby.ThunderAndLightning.LightningBoltTransformTrackerScript.AngleBetweenVector2(vec1:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, vec2:  new UnityEngine.Vector2() {x = val_8.x, y = val_8.y})), axis:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
                UnityEngine.Vector2 val_18 = new UnityEngine.Vector2(x:  state.BoltStartPosition, y:  val_17.y);
                UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  state.BoltEndPosition, y:  val_17.y);
                UnityEngine.Vector3 val_21 = state.StartTransform.position;
                UnityEngine.Vector3 val_22 = state.StartTransform.position;
                UnityEngine.Vector2 val_23 = new UnityEngine.Vector2(x:  val_21.x, y:  val_22.z);
                UnityEngine.Vector3 val_24 = state.EndTransform.position;
                UnityEngine.Vector3 val_25 = state.EndTransform.position;
                UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_24.x, y:  val_25.z);
                UnityEngine.Vector3 val_28 = UnityEngine.Vector3.up;
                val_58 = (DigitalRuby.ThunderAndLightning.LightningBoltTransformTrackerScript.AngleBetweenVector2(vec1:  new UnityEngine.Vector2() {x = val_23.x, y = val_23.y}, vec2:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y})) - (DigitalRuby.ThunderAndLightning.LightningBoltTransformTrackerScript.AngleBetweenVector2(vec1:  new UnityEngine.Vector2() {x = val_18.x, y = val_18.y}, vec2:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y}));
                val_59 = val_28.x;
                val_60 = val_28.y;
                val_61 = val_28.z;
                UnityEngine.Quaternion val_29 = UnityEngine.Quaternion.AngleAxis(angle:  val_58, axis:  new UnityEngine.Vector3() {x = val_59, y = val_60, z = val_61});
                state.Transform.rotation = new UnityEngine.Quaternion() {x = val_37.x, y = val_37.y, z = val_37.z, w = val_37.w};
                val_50 = 1152921504840871936;
                float val_38 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = state.BoltStartPosition, y = val_37.z, z = val_35.z}, b:  new UnityEngine.Vector3() {x = state.BoltEndPosition, y = val_35.y, z = val_37.x});
                UnityEngine.Vector3 val_39 = state.EndTransform.position;
                float val_48 = val_39.y;
                val_51 = val_37.z;
                UnityEngine.Vector3 val_40 = state.StartTransform.position;
                float val_47 = val_48;
                val_66 = null;
                val_66 = null;
                val_47 = (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_39.x, y = val_47, z = val_39.z}, b:  new UnityEngine.Vector3() {x = val_40.x, y = val_40.y, z = val_40.z})) / val_38;
                val_48 = (val_38 < 0) ? 1f : (val_47);
                state.Transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector3 val_43 = UnityEngine.Vector3.op_Multiply(d:  UnityEngine.Mathf.Clamp(value:  val_48, min:  scaleLimit.Minimum, max:  val_48), a:  new UnityEngine.Vector3() {x = state.BoltStartPosition, y = val_37.w, z = val_48});
                UnityEngine.Vector3 val_44 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_37.x, y = val_37.y, z = val_51, w = val_37.w}, point:  new UnityEngine.Vector3() {x = val_43.x, y = val_43.y, z = val_43.z});
                val_49 = state.Transform;
                UnityEngine.Vector3 val_45 = state.StartTransform.position;
                UnityEngine.Vector3 val_46 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, b:  new UnityEngine.Vector3() {x = val_44.x, y = val_44.y, z = val_44.z});
                val_48 = val_46.x;
                val_55 = val_46.y;
                val_56 = val_46.z;
            }
            
            label_15:
            val_49.position = new UnityEngine.Vector3() {x = val_48, y = val_55, z = val_56};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CustomTransformHandler(DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo state)
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this.LightningScript == 0)
            {
                    UnityEngine.Debug.LogError(message:  "LightningScript property must be set to non-null.");
                return;
            }
            
            if((state.<State>k__BackingField) == 0)
            {
                goto label_8;
            }
            
            if((state.<State>k__BackingField) != 1)
            {
                goto label_9;
            }
            
            DigitalRuby.ThunderAndLightning.LightningBoltTransformTrackerScript.UpdateTransform(state:  state, script:  this.LightningScript, scaleLimit:  new DigitalRuby.ThunderAndLightning.RangeOfFloats() {Minimum = this.ScaleLimit});
            return;
            label_8:
            state.StartTransform = this.StartTarget;
            state.EndTransform = this.EndTarget;
            this.transformStartPositions.set_Item(key:  this.EndTarget.transform, value:  state);
            return;
            label_9:
            bool val_5 = this.transformStartPositions.Remove(key:  this.transform);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightningBoltTransformTrackerScript()
        {
            this.ScaleLimit = new DigitalRuby.ThunderAndLightning.RangeOfFloats();
            this.transformStartPositions = new System.Collections.Generic.Dictionary<UnityEngine.Transform, DigitalRuby.ThunderAndLightning.LightningCustomTransformStateInfo>();
        }
    
    }

}
