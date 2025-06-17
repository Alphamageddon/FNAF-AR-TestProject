using UnityEngine;

namespace VLB_Samples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class LightGenerator : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int CountX;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int CountY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float OffsetUnits;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float PositionY;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool NoiseEnabled;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool AddLight;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Generate()
        {
            int val_46;
            string val_47;
            System.Type[] val_48;
            int val_49;
            var val_50;
            var val_51;
            var val_53;
            var val_54;
            float val_56;
            float val_58;
            bool val_59;
            val_46 = this.CountX;
            if(val_46 < 1)
            {
                    return;
            }
            
            object val_49 = 0;
            label_82:
            if(this.CountY < 1)
            {
                goto label_2;
            }
            
            object val_48 = 0;
            label_81:
            object[] val_1 = new object[4];
            val_1[0] = "Light_";
            if(this.AddLight == false)
            {
                goto label_7;
            }
            
            val_1[1] = val_49;
            val_1[2] = "_";
            val_1[3] = val_48;
            val_47 = +val_1;
            val_48 = new System.Type[3];
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_48 == null)
            {
                goto label_19;
            }
            
            if(val_4 != null)
            {
                goto label_20;
            }
            
            goto label_37;
            label_7:
            val_1[1] = val_49;
            val_1[2] = "_";
            val_1[3] = val_48;
            val_47 = +val_1;
            System.Type[] val_6 = new System.Type[2];
            val_48 = val_6;
            System.Type val_7 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            if(val_48 == null)
            {
                goto label_33;
            }
            
            if(val_7 != null)
            {
                goto label_34;
            }
            
            goto label_47;
            label_19:
            if(val_4 == null)
            {
                goto label_37;
            }
            
            label_20:
            label_37:
            val_48[0] = val_4;
            val_48[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            val_48[2] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            goto label_45;
            label_33:
            if(val_7 == null)
            {
                goto label_47;
            }
            
            label_34:
            label_47:
            val_48[0] = val_7;
            val_48[1] = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            label_45:
            UnityEngine.GameObject val_11 = new UnityEngine.GameObject(name:  val_47, components:  val_6);
            float val_46 = this.OffsetUnits;
            float val_13 = val_46 * 0f;
            val_46 = val_46 * 0f;
            val_11.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_49 = UnityEngine.Random.Range(min:  0, max:  104);
            float val_47 = (float)UnityEngine.Random.Range(min:  44, max:  45);
            val_47 = val_47 + 90f;
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.Euler(x:  val_47, y:  (float)val_49, z:  0f);
            val_11.transform.rotation = new UnityEngine.Quaternion() {x = val_17.x, y = val_17.y, z = val_17.z, w = val_17.w};
            VLB.VolumetricLightBeam val_18 = val_11.GetComponent<VLB.VolumetricLightBeam>();
            if(this.AddLight == false)
            {
                goto label_59;
            }
            
            UnityEngine.Light val_19 = val_11.GetComponent<UnityEngine.Light>();
            if(val_19 == null)
            {
                goto label_61;
            }
            
            val_19.type = 0;
            float val_20 = UnityEngine.Random.value;
            val_51 = UnityEngine.Random.value;
            float val_22 = UnityEngine.Random.value;
            val_53 = val_51;
            val_54 = 1f;
            goto label_62;
            label_59:
            float val_23 = UnityEngine.Random.value;
            val_51 = UnityEngine.Random.value;
            float val_25 = UnityEngine.Random.value;
            val_50 = 0;
            val_18.color = 0;
            mem2[0] = val_50;
            mem2[0] = 0;
            float val_26 = UnityEngine.Random.Range(min:  3f, max:  8f);
            if(val_18 == null)
            {
                goto label_64;
            }
            
            val_18.fallOffEnd = val_26;
            val_56 = UnityEngine.Random.Range(min:  10f, max:  90f);
            goto label_65;
            label_61:
            val_19.type = 0;
            float val_28 = UnityEngine.Random.value;
            val_51 = UnityEngine.Random.value;
            float val_30 = UnityEngine.Random.value;
            val_53 = val_51;
            val_54 = 1f;
            label_62:
            val_19.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            val_19.range = UnityEngine.Random.Range(min:  3f, max:  8f);
            val_19.intensity = UnityEngine.Random.Range(min:  0.2f, max:  5f);
            val_19.spotAngle = UnityEngine.Random.Range(min:  10f, max:  90f);
            val_49 = VLB.Config.Instance;
            if(val_34.geometryOverrideLayer != false)
            {
                    VLB.Config val_35 = VLB.Config.Instance;
                val_49 = val_35.geometryLayerID;
                int val_36 = val_49 & 31;
                val_50 = 1;
                val_36 = val_50 << val_36;
                val_19.cullingMask = ~val_36;
            }
            
            val_58 = UnityEngine.Random.Range(min:  0f, max:  0.1f);
            if(val_18 != null)
            {
                goto label_77;
            }
            
            mem[80] = val_58;
            mem[88] = UnityEngine.Random.Range(min:  12, max:  36);
            val_18.fresnelPow = UnityEngine.Random.Range(min:  1f, max:  7.5f);
            val_59 = this.NoiseEnabled;
            goto label_78;
            label_64:
            mem[112] = val_26;
            val_56 = UnityEngine.Random.Range(min:  10f, max:  90f);
            label_65:
            val_18.spotAngle = val_56;
            val_58 = UnityEngine.Random.Range(min:  0f, max:  0.1f);
            label_77:
            val_18.coneRadiusStart = val_58;
            val_18.geomCustomSides = UnityEngine.Random.Range(min:  12, max:  36);
            val_18.fresnelPow = UnityEngine.Random.Range(min:  1f, max:  7.5f);
            val_59 = this.NoiseEnabled;
            label_78:
            val_18.noiseEnabled = val_59;
            VLB_Samples.Rotater val_44 = val_11.GetComponent<VLB_Samples.Rotater>();
            int val_45 = UnityEngine.Random.Range(min:  499, max:  244);
            val_48 = val_48 + 1;
            val_44.EulerSpeed = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            if(val_48 < this.CountY)
            {
                goto label_81;
            }
            
            val_46 = this.CountX;
            label_2:
            val_49 = val_49 + 1;
            if(val_49 < val_46)
            {
                goto label_82;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public LightGenerator()
        {
            this.CountX = 10;
            this.CountY = 10;
            this.OffsetUnits = 1f;
            this.PositionY = 1f;
            this.AddLight = true;
        }
    
    }

}
