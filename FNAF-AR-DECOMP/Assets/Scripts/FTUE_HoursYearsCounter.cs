using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class FTUE_HoursYearsCounter : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string _tickAudioEventName;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GlitchFtue GlitchScript;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TextMeshProUGUI TextObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float waitTimer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float counterRate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float counterTimerMax;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string hoursLocTextKey;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string yearsLocTextKey;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float minDelayBetweenAudioTicks;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Game.Audio.IAudioPlayer _audioPlayer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int hours;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float t;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int years;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float yearRate;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float counterTimer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string hoursLocText;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string yearsLocText;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string outputString;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool completed;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public float percentage;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float startingPercentage;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float timeOfLastAudioTick;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float startTime;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.startingPercentage = this.GlitchScript.Chance;
        Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void FTUE_HoursYearsCounter::<Start>b__23_0(Game.Localization.ILocalization localization)));
        this.startTime = UnityEngine.Time.time;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_12;
        string val_13;
        string val_14;
        string val_15;
        var val_16;
        if(this.completed != true)
        {
                val_12 = this.waitTimer;
            if(val_12 > 0f)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = val_12 - val_1;
            this.waitTimer = val_1;
        }
        else
        {
                val_12 = this.counterTimer;
            float val_2 = UnityEngine.Time.deltaTime;
            val_2 = this.counterRate * val_2;
            val_2 = val_12 - val_2;
            this.counterTimer = val_2;
            if(val_2 <= 0f)
        {
                this.counterTimer = this.counterTimerMax;
            if(this.hours <= 49)
        {
                val_12 = this.t;
            val_13 = this.hoursLocText;
            this.t = val_12;
            this.hours = (int)val_12;
            val_14 = "###";
            val_15 = this.hours.ToString();
        }
        else
        {
                UnityEngine.Color val_4 = UnityEngine.Color.red;
            this.TextObject.fontMaterial.EnableKeyword(keyword:  "GLOW_ON");
            val_16 = null;
            val_16 = null;
            this.TextObject.fontMaterial.SetFloat(nameID:  TMPro.ShaderUtilities.ID_GlowPower, value:  0.2f);
            UnityEngine.Color val_8 = UnityEngine.Color.red;
            UnityEngine.Vector4 val_9 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
            this.TextObject.fontMaterial.SetVector(nameID:  TMPro.ShaderUtilities.ID_GlowColor, value:  new UnityEngine.Vector4() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w});
            val_12 = this.t;
            this.years = (int)val_12;
            this.t = val_12;
            if((int)val_12 >= (1.399897E-42f))
        {
                this.years = 999;
            this.completed = true;
        }
        
            val_13 = this.years.ToString();
            val_14 = "###";
            val_15 = val_13;
        }
        
            this.outputString = this.yearsLocText.Replace(oldValue:  val_14, newValue:  val_15);
            this.TryAudioTick();
        }
        
        }
        
        }
        
        this.TextObject.text = this.outputString;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void updateTextColor(bool isEternal)
    {
        int val_11;
        var val_12;
        int val_13;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        int val_22;
        var val_23;
        val_11 = isEternal;
        if(val_11 != false)
        {
                UnityEngine.Color val_1 = UnityEngine.Color.red;
            this.TextObject.fontMaterial.EnableKeyword(keyword:  "GLOW_ON");
            val_12 = null;
            val_12 = null;
            val_11 = TMPro.ShaderUtilities.ID_GlowPower;
            this.TextObject.fontMaterial.SetFloat(nameID:  val_11, value:  0.2f);
            UnityEngine.Material val_4 = this.TextObject.fontMaterial;
            val_13 = TMPro.ShaderUtilities.ID_GlowColor;
            UnityEngine.Color val_5 = UnityEngine.Color.red;
            UnityEngine.Vector4 val_6 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
            val_18 = val_6.x;
            val_19 = val_6.y;
            val_20 = val_6.z;
            val_21 = val_6.w;
            val_22 = val_13;
        }
        else
        {
                UnityEngine.Color val_7 = UnityEngine.Color.white;
            val_13 = this.TextObject.fontMaterial;
            val_23 = null;
            val_23 = null;
            UnityEngine.Color val_9 = UnityEngine.Color.white;
            UnityEngine.Vector4 val_10 = UnityEngine.Color.op_Implicit(c:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
            val_18 = val_10.x;
            val_19 = val_10.y;
            val_20 = val_10.z;
            val_21 = val_10.w;
            val_22 = TMPro.ShaderUtilities.ID_GlowColor;
        }
        
        val_13.SetVector(nameID:  val_22, value:  new UnityEngine.Vector4() {x = val_18, y = val_19, z = val_20, w = val_21});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InvokeAudio()
    {
        var val_2 = 0;
        val_2 = val_2 + 1;
        this._audioPlayer.RaiseGameEventForModeByName(name:  this._tickAudioEventName, emitter:  1);
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
        val_1.GameAudioDomain.AudioPlayer.GetInterfaceAsync(callback:  new System.Action<Game.Audio.IAudioPlayer>(object:  this, method:  System.Void FTUE_HoursYearsCounter::<RetrieveAndInvokeAudio>b__27_0(Game.Audio.IAudioPlayer audioPlayer)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void TryAudioTick()
    {
        float val_3 = this.timeOfLastAudioTick;
        val_3 = val_3 + this.minDelayBetweenAudioTicks;
        if(UnityEngine.Time.time < val_3)
        {
                return;
        }
        
        this.timeOfLastAudioTick = UnityEngine.Time.time;
        this.RetrieveAndInvokeAudio();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public FTUE_HoursYearsCounter()
    {
        this.waitTimer = 10f;
        this.counterRate = 10f;
        this.counterTimerMax = 10f;
        this.minDelayBetweenAudioTicks = 0.04f;
        this.hours = 24;
        this.t = 24f;
        this.years = 50;
        this.counterTimer = 5f;
        this.hoursLocTextKey = "";
        this.yearsLocTextKey = "";
        this.hoursLocText = "";
        this.yearsLocText = "";
        this.outputString = "24 hours*";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <Start>b__23_0(Game.Localization.ILocalization localization)
    {
        var val_7 = 0;
        val_7 = val_7 + 1;
        this.hoursLocText = localization.GetLocalizedString(localizedStringId:  this.hoursLocTextKey, originalString:  this.hoursLocTextKey);
        var val_8 = 0;
        val_8 = val_8 + 1;
        this.yearsLocText = localization.GetLocalizedString(localizedStringId:  this.yearsLocTextKey, originalString:  this.yearsLocTextKey);
        string val_6 = this.hoursLocText.Replace(oldValue:  "###", newValue:  this.hours.ToString());
        this.outputString = val_6;
        this.TextObject.text = val_6;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <RetrieveAndInvokeAudio>b__27_0(Game.Audio.IAudioPlayer audioPlayer)
    {
        this._audioPlayer = audioPlayer;
        this.InvokeAudio();
    }

}
