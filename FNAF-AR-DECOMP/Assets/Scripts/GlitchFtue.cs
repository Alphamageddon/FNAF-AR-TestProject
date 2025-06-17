using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GlitchFtue : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string _flickerAudioEventName;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Chance;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Min;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Max;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float Speed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _timer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject FuntimeContent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.GameObject EternalContent;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Funtime_Glitch;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool isEternal;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float FuntimeGlitchStrength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float EternalGlitchStrength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchSpectrumOffset SpectrumOffset_Fx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchNoiseDigital NoiseDigital_Fx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Ibuprogames.VideoGlitchesAsset.VideoGlitchShift Shift_Fx;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TextMeshProUGUI FuntimeEternal_TMPro;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TextMeshProUGUI Package_TMPro;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Rendering.PostProcessing.PostProcessVolume volume;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string FuntimeLocKey;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string EternalLocKey;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Game.Audio.IAudioPlayer _audioPlayer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _spectrumOffset_Strength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _noiseDigital_Strength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _shift_Strength;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Rendering.PostProcessing.Bloom bloomSettings;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string _funtimeLocString;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string _eternalLocString;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._spectrumOffset_Strength = true;
        this._noiseDigital_Strength = true;
        this._shift_Strength = true;
        if((this.volume.profile.TryGetSettings<UnityEngine.Rendering.PostProcessing.Bloom>(outSetting: out  this.bloomSettings)) != false)
        {
                Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GlitchFtue::<Start>b__27_0(Game.Localization.ILocalization localization)));
            return;
        }
        
        this.enabled = false;
        UnityEngine.Debug.Log(message:  "GlitchFtue.cs Error: Can\'t load Bloom settings");
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_19;
        var val_20;
        int val_21;
        float val_23;
        float val_24;
        var val_25;
        var val_26;
        val_19 = this._timer;
        if(val_19 >= 0)
        {
            goto label_1;
        }
        
        float val_19 = this.Chance;
        val_19 = val_19 / 100f;
        val_19 = val_19 * this.Max;
        if((UnityEngine.Random.Range(min:  this.Min, max:  this.Max)) <= val_19)
        {
            goto label_2;
        }
        
        this.isEternal = false;
        this.FuntimeContent.SetActive(value:  true);
        this.EternalContent.SetActive(value:  false);
        this.FuntimeEternal_TMPro.text = this._funtimeLocString;
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        UnityEngine.Material val_3 = this.FuntimeEternal_TMPro.fontMaterial;
        if(this.Funtime_Glitch == false)
        {
            goto label_8;
        }
        
        val_20 = null;
        val_20 = null;
        val_21 = TMPro.ShaderUtilities.ID_GlowColor;
        UnityEngine.Color val_4 = UnityEngine.Color.white;
        UnityEngine.Vector4 val_5 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
        val_23 = val_5.z;
        val_3.SetVector(nameID:  val_21, value:  new UnityEngine.Vector4() {x = val_5.x, y = val_5.y, z = val_23, w = val_5.w});
        val_24 = this.FuntimeGlitchStrength;
        goto label_32;
        label_2:
        if(this.isEternal != true)
        {
                this.RetrieveAndInvokeAudio();
        }
        
        this.isEternal = true;
        this.FuntimeContent.SetActive(value:  false);
        this.EternalContent.SetActive(value:  true);
        this.FuntimeEternal_TMPro.text = this._eternalLocString;
        UnityEngine.Color val_6 = UnityEngine.Color.red;
        this.FuntimeEternal_TMPro.fontMaterial.EnableKeyword(keyword:  "GLOW_ON");
        val_25 = null;
        val_25 = null;
        this.FuntimeEternal_TMPro.fontMaterial.SetFloat(nameID:  TMPro.ShaderUtilities.ID_GlowPower, value:  0.5f);
        UnityEngine.Color val_10 = UnityEngine.Color.red;
        UnityEngine.Vector4 val_11 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a});
        val_23 = val_11.z;
        this.FuntimeEternal_TMPro.fontMaterial.SetVector(nameID:  TMPro.ShaderUtilities.ID_GlowColor, value:  new UnityEngine.Vector4() {x = val_11.x, y = val_11.y, z = val_23, w = val_11.w});
        this.Package_TMPro.fontMaterial.EnableKeyword(keyword:  "GLOW_ON");
        val_21 = this.Package_TMPro.fontMaterial;
        val_21.SetFloat(nameID:  TMPro.ShaderUtilities.ID_GlowPower, value:  0.5f);
        mem2[0] = 1086324736;
        val_24 = this.EternalGlitchStrength;
        goto label_32;
        label_8:
        val_3.DisableKeyword(keyword:  "GLOW_ON");
        val_26 = null;
        val_26 = null;
        val_21 = TMPro.ShaderUtilities.ID_GlowColor;
        UnityEngine.Color val_15 = UnityEngine.Color.white;
        UnityEngine.Vector4 val_16 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a});
        val_23 = val_16.z;
        this.FuntimeEternal_TMPro.fontMaterial.SetVector(nameID:  val_21, value:  new UnityEngine.Vector4() {x = val_16.x, y = val_16.y, z = val_23, w = val_16.w});
        this.Package_TMPro.fontMaterial.DisableKeyword(keyword:  "GLOW_ON");
        mem2[0] = 1082130432;
        val_24 = 0f;
        label_32:
        this.GlitchControl(value:  val_24);
        val_19 = 10f;
        this._timer = 10f;
        label_1:
        float val_18 = UnityEngine.Time.deltaTime;
        val_18 = this.Speed * val_18;
        val_18 = val_19 - val_18;
        this._timer = val_18;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SwapPackageTextFields()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        UnityEngine.RectTransform val_1 = this.FuntimeEternal_TMPro.rectTransform;
        UnityEngine.RectTransform val_2 = this.Package_TMPro.rectTransform;
        UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0f, y:  0.5f);
        if(val_1 != null)
        {
                val_1.pivot = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector3 val_4 = val_1.localPosition;
            val_11 = val_4.y;
            val_12 = val_1;
        }
        else
        {
                0.pivot = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            UnityEngine.Vector3 val_5 = 0.localPosition;
            val_11 = val_5.y;
            val_12 = 0;
        }
        
        UnityEngine.Vector3 val_6 = val_12.localPosition;
        val_12.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  1f, y:  0.5f);
        if(val_2 != null)
        {
                val_2.pivot = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            UnityEngine.Vector3 val_8 = val_2.localPosition;
            val_13 = val_8.y;
            val_14 = val_2;
        }
        else
        {
                0.pivot = new UnityEngine.Vector2() {x = val_7.x, y = val_7.y};
            UnityEngine.Vector3 val_9 = 0.localPosition;
            val_13 = val_9.y;
            val_14 = 0;
        }
        
        UnityEngine.Vector3 val_10 = val_14.localPosition;
        val_14.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void GlitchControl(float value)
    {
        this.SpectrumOffset_Fx.Strength = UnityEngine.Mathf.Lerp(a:  0f, b:  this._spectrumOffset_Strength, t:  value);
        this.NoiseDigital_Fx.Strength = UnityEngine.Mathf.Lerp(a:  0f, b:  this._noiseDigital_Strength, t:  value);
        this.Shift_Fx.Strength = UnityEngine.Mathf.Lerp(a:  0f, b:  this._shift_Strength, t:  value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InvokeAudio()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this._audioPlayer.RaiseGameEventForModeByName(name:  this._flickerAudioEventName, emitter:  1);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RetrieveAndInvokeAudio()
    {
        if(this._audioPlayer != null)
        {
                this.InvokeAudio();
            return;
        }
        
        Master.MasterDomain val_1 = Master.MasterDomain.GetDomain();
        val_1.GameAudioDomain.AudioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void GlitchFtue::<RetrieveAndInvokeAudio>b__32_0(Game.Audio.IAudioPlayer audioPlayer)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GlitchFtue()
    {
        this.Max = 0f;
        this.Speed = 1f;
        this._timer = 10f;
        this.FuntimeGlitchStrength = 1f;
        this.EternalGlitchStrength = 1f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <Start>b__27_0(Game.Localization.ILocalization localization)
    {
        var val_8 = 0;
        val_8 = val_8 + 1;
        this._funtimeLocString = localization.GetLocalizedString(localizedStringId:  this.FuntimeLocKey, originalString:  this.FuntimeLocKey);
        var val_9 = 0;
        val_9 = val_9 + 1;
        this._eternalLocString = localization.GetLocalizedString(localizedStringId:  this.EternalLocKey, originalString:  this.EternalLocKey);
        var val_10 = 0;
        val_10 = val_10 + 1;
        if((localization.CurrentLanguage - 1) > 4)
        {
                return;
        }
        
        this.SwapPackageTextFields();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <RetrieveAndInvokeAudio>b__32_0(Game.Audio.IAudioPlayer audioPlayer)
    {
        this._audioPlayer = audioPlayer;
        this.InvokeAudio();
    }

}
