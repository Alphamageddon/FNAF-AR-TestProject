using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TutorialTextLocalizationFlicker : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TutorialTextLocalizationFlicker.State[] _states;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _maxCycles;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _ticker;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _visibleElement;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _flickerCount;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._visibleElement = 0;
        this._flickerCount = 0;
        this.ResetTicker(state:  this._states[0]);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this._ticker - val_1;
        this._ticker = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        this.OnTickerFinished();
        this.ResetTicker(state:  this._states[this._visibleElement]);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnTickerFinished()
    {
        State val_4;
        var val_5;
        State[] val_6;
        var val_7;
        val_4 = this;
        if(this._visibleElement == 0)
        {
                int val_4 = this._flickerCount;
            if(this._maxCycles != 0)
        {
                if(val_4 >= this._maxCycles)
        {
                return;
        }
        
        }
        
            val_4 = val_4 + 1;
            this._flickerCount = val_4;
        }
        
        State val_5 = this._states[this._visibleElement];
        val_5 = 0;
        goto label_6;
        label_10:
        this._states[this._visibleElement][0].elements[0].SetActive(value:  false);
        val_5 = 1;
        label_6:
        if(val_5 < this._states[this._visibleElement][0].elements.Length)
        {
            goto label_10;
        }
        
        val_6 = this._states;
        if(this._states == null)
        {
                val_6 = this._states;
        }
        
        int val_1 = this._visibleElement + 1;
        int val_3 = val_1 - ((val_1 / this._states.Length) * this._states.Length);
        this._visibleElement = val_3;
        State val_7 = val_6[(long)val_3];
        val_4 = this._states[this._visibleElement];
        if(this._states[this._visibleElement][0].invokeAudio != null)
        {
                this._states[this._visibleElement][0].invokeAudio.RetrieveAndInvokeAudio();
        }
        
        val_7 = 0;
        goto label_19;
        label_23:
        val_4 = this._states[(long)(int)((this._visibleElement + 1) - (((this._visibleElement + 1) / this._states.Length) * this._states.Length))][0].elements[0];
        val_4.SetActive(value:  true);
        val_7 = 1;
        label_19:
        if(val_7 < (this._states[(long)(int)((this._visibleElement + 1) - (((this._visibleElement + 1) / this._states.Length) * this._states.Length))][0].elements.Length))
        {
            goto label_23;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ResetTicker(TutorialTextLocalizationFlicker.State state)
    {
        float val_2;
        if(state != null)
        {
                val_2 = state.minTime;
        }
        else
        {
                val_2 = 2.105703E-38f;
        }
        
        this._ticker = UnityEngine.Random.Range(min:  val_2, max:  state.maxTime);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TutorialTextLocalizationFlicker()
    {
    
    }

}
