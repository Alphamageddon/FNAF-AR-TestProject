using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AnimatronicMaterialController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject revealPlane;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject eyeRevealPlane;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Material[] bodyMaterials;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Material[] eyeMaterials;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Material[] minWearAndTearMaterials;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Material[] maxWearAndTearMaterials;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float eyeGlowMultiplier;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _eyeGlowStrength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _eyeOverrideSwitch;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float wearAndTearPercentage;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float offset;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<float>[] _minValueLists;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<float>[] _maxValueLists;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private readonly System.Collections.Generic.List<string> _parameterNames;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isRevealPlaneNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isBodyMaterialsNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isEyeMaterialsNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _isWearAndTearMaterialsNull;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _shouldPerformRepairInterpolation;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int PlanePosition;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int PlaneNormal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int GlowAmount;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int GlowFlicker;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int OverrideColor;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int OverrideSwitch;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int GrungeSmearBalance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly int GrungeDirtBalance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool _hasEyeColorOverride;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Color _eyeColorOverride;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.SkinnedMeshRenderer _renderer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.MaterialPropertyBlock _propertyBlock;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Material[] _materials;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        var val_10;
        UnityEngine.Material[] val_20;
        var val_21;
        val_20 = this.minWearAndTearMaterials;
        this._isRevealPlaneNull = UnityEngine.Object.op_Equality(x:  this.revealPlane, y:  0);
        this._isBodyMaterialsNull = (this.bodyMaterials == null) ? 1 : 0;
        this._isEyeMaterialsNull = (this.eyeMaterials == null) ? 1 : 0;
        this._isWearAndTearMaterialsNull = (val_20 == null) ? 1 : 0;
        if(val_20 == null)
        {
                if(this.maxWearAndTearMaterials == null)
        {
            goto label_4;
        }
        
        }
        
        val_21 = 0;
        goto label_5;
        label_51:
        System.Collections.Generic.List<System.Single> val_6 = new System.Collections.Generic.List<System.Single>();
        if(this._minValueLists == null)
        {
            goto label_6;
        }
        
        if(val_6 != null)
        {
            goto label_7;
        }
        
        goto label_10;
        label_6:
        if(val_6 == null)
        {
            goto label_10;
        }
        
        label_7:
        label_10:
        this._minValueLists[0] = val_6;
        System.Collections.Generic.List<System.Single> val_7 = new System.Collections.Generic.List<System.Single>();
        if(this._maxValueLists == null)
        {
            goto label_12;
        }
        
        if(val_7 != null)
        {
            goto label_13;
        }
        
        goto label_16;
        label_12:
        if(val_7 == null)
        {
            goto label_16;
        }
        
        label_13:
        label_16:
        this._maxValueLists[0] = val_7;
        List.Enumerator<T> val_8 = this._parameterNames.GetEnumerator();
        label_32:
        if((1354452480 & 1) == 0)
        {
            goto label_33;
        }
        
        GameUI.EmailUIDataHandler val_11 = val_10.emailUIDataHandler;
        this._minValueLists[0].Add(item:  this.minWearAndTearMaterials[0].GetFloat(name:  val_11));
        this._maxValueLists[0].Add(item:  this.maxWearAndTearMaterials[0].GetFloat(name:  val_11));
        goto label_32;
        label_33:
        long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518846201344});
        if(((216 == 0) ? 216 : 216) == 216)
        {
            
        }
        
        val_20 = this.minWearAndTearMaterials;
        val_21 = 1;
        label_5:
        if(val_21 < this.minWearAndTearMaterials.Length)
        {
            goto label_51;
        }
        
        label_4:
        UnityEngine.SkinnedMeshRenderer val_16 = this.GetComponent<UnityEngine.SkinnedMeshRenderer>();
        this._renderer = val_16;
        this._materials = val_16.sharedMaterials;
        this._propertyBlock = new UnityEngine.MaterialPropertyBlock();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LateUpdate()
    {
        if(this._isRevealPlaneNull == true)
        {
                return;
        }
        
        if(this._isBodyMaterialsNull == true)
        {
                return;
        }
        
        if(this._isEyeMaterialsNull != false)
        {
                return;
        }
        
        if(this._shouldPerformRepairInterpolation != false)
        {
                float val_1 = this.wearAndTearPercentage;
            if(val_1 > 0f)
        {
                val_1 = val_1 + (-1f);
            this.wearAndTearPercentage = val_1;
        }
        else
        {
                this._shouldPerformRepairInterpolation = false;
        }
        
        }
        
        this.SetBodyMaterialProperties();
        this.SetEyeMaterialProperties();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetBodyMaterialProperties()
    {
        var val_14;
        var val_15;
        int val_16;
        float val_17;
        float val_18;
        UnityEngine.Vector3 val_2 = this.revealPlane.transform.position;
        UnityEngine.Vector3 val_4 = this.revealPlane.transform.forward;
        val_14 = 0;
        goto label_5;
        label_34:
        this._propertyBlock.Clear();
        val_15 = null;
        val_15 = null;
        this._propertyBlock.SetVector(nameID:  AnimatronicMaterialController.PlanePosition, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        val_16 = AnimatronicMaterialController.PlaneNormal;
        this._propertyBlock.SetVector(nameID:  val_16, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        if(this._isWearAndTearMaterialsNull == true)
        {
            goto label_13;
        }
        
        val_16 = this.minWearAndTearMaterials;
        if(val_14 >= this.minWearAndTearMaterials.Length)
        {
            goto label_13;
        }
        
        val_16 = 0;
        goto label_14;
        label_29:
        val_17 = this._minValueLists[0].Item[0];
        val_18 = this._maxValueLists[0].Item[0];
        if((this._parameterNames.Item[0].Contains(value:  "Offset")) != false)
        {
                val_18 = this.offset;
            val_17 = val_18;
        }
        
        this._propertyBlock.SetFloat(name:  this._parameterNames.Item[0], value:  UnityEngine.Mathf.Lerp(a:  val_17, b:  val_18, t:  this.wearAndTearPercentage / 100f));
        val_16 = 1;
        label_14:
        if(val_16 < this._parameterNames.Count)
        {
            goto label_29;
        }
        
        label_13:
        this._renderer.SetPropertyBlock(properties:  this._propertyBlock, materialIndex:  this.GetMaterialIndex(material:  this.bodyMaterials[0]));
        val_14 = 1;
        label_5:
        if(val_14 < this.bodyMaterials.Length)
        {
            goto label_34;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetEyeMaterialProperties()
    {
        var val_10;
        var val_11;
        UnityEngine.MaterialPropertyBlock val_12;
        float val_13;
        var val_14;
        UnityEngine.Vector3 val_2 = this.eyeRevealPlane.transform.position;
        UnityEngine.Vector3 val_4 = this.eyeRevealPlane.transform.forward;
        val_10 = 0;
        goto label_5;
        label_25:
        this._propertyBlock.Clear();
        val_11 = null;
        val_11 = null;
        this._propertyBlock.SetVector(nameID:  AnimatronicMaterialController.PlanePosition, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        this._propertyBlock.SetVector(nameID:  AnimatronicMaterialController.PlaneNormal, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        UnityEngine.Vector3 val_6 = this.revealPlane.transform.localScale;
        val_6.x = val_6.x * this.eyeGlowMultiplier;
        val_6.x = val_6.x * this._eyeGlowStrength;
        this._propertyBlock.SetFloat(nameID:  AnimatronicMaterialController.GlowAmount, value:  val_6.x);
        this._propertyBlock.SetFloat(nameID:  AnimatronicMaterialController.GlowFlicker, value:  val_6.y);
        this._propertyBlock.SetColor(nameID:  AnimatronicMaterialController.OverrideColor, value:  new UnityEngine.Color() {r = this._eyeColorOverride, g = val_6.x, b = this.eyeGlowMultiplier, a = this._eyeGlowStrength});
        val_12 = this._propertyBlock;
        val_13 = this._eyeOverrideSwitch;
        val_12.SetFloat(nameID:  AnimatronicMaterialController.OverrideSwitch, value:  val_13);
        if(this._isWearAndTearMaterialsNull != true)
        {
                val_14 = null;
            val_14 = null;
            float val_7 = this.wearAndTearPercentage / 100f;
            val_7 = val_7 * 0.75f;
            this._propertyBlock.SetFloat(nameID:  AnimatronicMaterialController.GrungeDirtBalance, value:  val_7);
            val_12 = this._propertyBlock;
            val_13 = this.wearAndTearPercentage;
            float val_8 = val_13 / 100f;
            val_8 = val_8 * 0.25f;
            val_12.SetFloat(nameID:  AnimatronicMaterialController.GrungeSmearBalance, value:  val_8);
        }
        
        this._renderer.SetPropertyBlock(properties:  this._propertyBlock, materialIndex:  this.GetMaterialIndex(material:  this.eyeMaterials[0]));
        val_10 = 1;
        label_5:
        if(val_10 < this.eyeMaterials.Length)
        {
            goto label_25;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void PerformRepairInterpolation()
    {
        float val_1 = this.wearAndTearPercentage;
        if(val_1 > 0f)
        {
                val_1 = val_1 + (-1f);
            this.wearAndTearPercentage = val_1;
            return;
        }
        
        this._shouldPerformRepairInterpolation = false;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int GetMaterialIndex(UnityEngine.Object material)
    {
        var val_3;
        var val_4;
        val_3 = 0;
        val_4 = 0;
        goto label_1;
        label_7:
        val_3 = 1;
        label_1:
        if(val_3 < this._materials.Length)
        {
            goto label_7;
        }
        
        return (int)(material != this._materials[0]) ? (val_3) : (val_4);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsGlowing()
    {
        return UnityEngine.Mathf.Approximately(a:  this._eyeGlowStrength, b:  1f);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool IsColorOverriden()
    {
        var val_3;
        if((UnityEngine.Mathf.Approximately(a:  this._eyeOverrideSwitch, b:  1f)) != false)
        {
                var val_2 = (this._hasEyeColorOverride == true) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void StartEyeColorOverride(UnityEngine.Color color)
    {
        this._eyeColorOverride = color;
        mem[1152921518848499268] = color.g;
        mem[1152921518848499272] = color.b;
        mem[1152921518848499276] = color.a;
        this._hasEyeColorOverride = true;
        this._eyeOverrideSwitch = 1f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void EndEyeColorOverride()
    {
        this._hasEyeColorOverride = false;
        this._eyeOverrideSwitch = 0f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Color GetEyeColorOverride()
    {
        return new UnityEngine.Color() {r = this._eyeColorOverride};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetEyeGlowIntensity(float intensity)
    {
        this.eyeGlowMultiplier = (intensity < 0f) ? 1f : intensity;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void SetEyeGlow(bool eyeGlowEnabled)
    {
        this._eyeGlowStrength = (eyeGlowEnabled != true) ? 1f : 0f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void TriggerRepairInterpolation()
    {
        this._shouldPerformRepairInterpolation = true;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AnimatronicMaterialController()
    {
        this.eyeGlowMultiplier = 1f;
        this._minValueLists = new System.Collections.Generic.List<System.Single>[5];
        this._maxValueLists = new System.Collections.Generic.List<System.Single>[5];
        System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
        if(val_3 != null)
        {
                val_3.Add(item:  "_PaintsRoughness");
        }
        else
        {
                val_3.Add(item:  "_PaintsRoughness");
        }
        
        val_3.Add(item:  "_PaintsDirtBalance");
        if(val_3 != null)
        {
                val_3.Add(item:  "_PaintsDirtScratchesBalance");
        }
        else
        {
                val_3.Add(item:  "_PaintsDirtScratchesBalance");
        }
        
        val_3.Add(item:  "_PaintsDirtScratchesContrast");
        if(val_3 != null)
        {
                val_3.Add(item:  "_PaintsScratchesOffset");
        }
        else
        {
                val_3.Add(item:  "_PaintsScratchesOffset");
        }
        
        val_3.Add(item:  "_WearCurvatureBalance");
        if(val_3 != null)
        {
                val_3.Add(item:  "_WearCurveGrimeTiling");
        }
        else
        {
                val_3.Add(item:  "_WearCurveGrimeTiling");
        }
        
        val_3.Add(item:  "_WearGrungeBalance");
        if(val_3 != null)
        {
                val_3.Add(item:  "_WearGrungeOffset");
        }
        else
        {
                val_3.Add(item:  "_WearGrungeOffset");
        }
        
        val_3.Add(item:  "_WearGrungeTiling");
        if(val_3 != null)
        {
                val_3.Add(item:  "_WearScratchesBalance");
        }
        else
        {
                val_3.Add(item:  "_WearScratchesBalance");
        }
        
        val_3.Add(item:  "_MetalOilRoughness");
        if(val_3 != null)
        {
                val_3.Add(item:  "_MetalOilSmearBalance");
        }
        else
        {
                val_3.Add(item:  "_MetalOilSmearBalance");
        }
        
        val_3.Add(item:  "_MetalOilScratchesTiling");
        if(val_3 != null)
        {
                val_3.Add(item:  "_VertScale");
        }
        else
        {
                val_3.Add(item:  "_VertScale");
        }
        
        val_3.Add(item:  "_VertDisplace");
        this._parameterNames = val_3;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AnimatronicMaterialController()
    {
        AnimatronicMaterialController.PlanePosition = UnityEngine.Shader.PropertyToID(name:  "_PlanePosition");
        AnimatronicMaterialController.PlaneNormal = UnityEngine.Shader.PropertyToID(name:  "_PlaneNormal");
        AnimatronicMaterialController.GlowAmount = UnityEngine.Shader.PropertyToID(name:  "_GlowAmount");
        AnimatronicMaterialController.GlowFlicker = UnityEngine.Shader.PropertyToID(name:  "_GlowFlicker");
        AnimatronicMaterialController.OverrideColor = UnityEngine.Shader.PropertyToID(name:  "_ExterminateColor");
        AnimatronicMaterialController.OverrideSwitch = UnityEngine.Shader.PropertyToID(name:  "_ExterminateSwitch");
        AnimatronicMaterialController.GrungeSmearBalance = UnityEngine.Shader.PropertyToID(name:  "_GrungeSmearBalance");
        AnimatronicMaterialController.GrungeDirtBalance = UnityEngine.Shader.PropertyToID(name:  "_GrungeDirtBalance");
    }

}
