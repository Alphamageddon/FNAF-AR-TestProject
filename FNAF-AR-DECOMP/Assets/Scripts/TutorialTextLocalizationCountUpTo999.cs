using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class TutorialTextLocalizationCountUpTo999 : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int hourOriginNumber;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int hourMidNumber;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int hourTargetNumber;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int yearOriginNumber;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int yearTargetNumber;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float initialDelay;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float countToMidTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float accelerateUpTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _element1Obj;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _element2Obj;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TextMeshProUGUI _element1;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TMPro.TextMeshProUGUI _element2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject _elementButton;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _stateIndex;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float _ticker;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string _element1LocString;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string _element2LocString;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int _currentVisibleNumber;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this._stateIndex = 0;
        this._ticker = 0f;
        this._elementButton.SetActive(value:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        int val_3;
        float val_4;
        int val_5;
        int val_6;
        this.UpdateVisibility();
        this.UpdateText();
        float val_1 = UnityEngine.Time.deltaTime;
        val_3 = this._stateIndex;
        val_1 = this._ticker + val_1;
        this._ticker = val_1;
        if(val_1 <= 0f)
        {
            goto label_6;
        }
        
        if(val_3 > 3)
        {
            goto label_1;
        }
        
        var val_3 = 52947988 + (this._stateIndex) << 2;
        val_3 = val_3 + 52947988;
        goto (52947988 + (this._stateIndex) << 2 + 52947988);
        label_1:
        val_4 = 0f;
        if((val_1 > ) && (val_3 <= 2))
        {
                if(val_3 == 1)
        {
                Master.MasterDomain val_2 = Master.MasterDomain.GetDomain();
            val_2.eventExposer.OnTutorialUIEvent(eventId:  2);
            val_5 = this._stateIndex;
        }
        
            val_6 = val_5 + 1;
            this._stateIndex = val_6;
            this._ticker = 0f;
        }
        
        label_6:
        if(val_6 != 3)
        {
                return;
        }
        
        if(this._currentVisibleNumber != this.yearTargetNumber)
        {
                return;
        }
        
        this._elementButton.SetActive(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float GetStateTime(int index)
    {
        if(index > 3)
        {
                return 0f;
        }
        
        var val_1 = 52948004 + (index) << 2;
        val_1 = val_1 + 52948004;
        goto (52948004 + (index) << 2 + 52948004);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateVisibility()
    {
        this._element1Obj.SetActive(value:  (this._stateIndex != 3) ? 1 : 0);
        this._element2Obj.SetActive(value:  (this._stateIndex == 3) ? 1 : 0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int CalculateVisibleNumber()
    {
        float val_3;
        float val_4;
        float val_5;
        if(this._stateIndex <= 3)
        {
                var val_3 = 52948020 + (this._stateIndex) << 2;
            val_3 = val_3 + 52948020;
        }
        else
        {
                val_3 = 0f;
            float val_2 = UnityEngine.Mathf.Clamp01(value:  this._ticker /);
            val_2 = val_2 * val_2;
            if(this._stateIndex <= 3)
        {
                var val_4 = 52948036 + (this._stateIndex) << 2;
            val_4 = val_4 + 52948036;
        }
        else
        {
                val_4 = 0f;
            val_5 = 0f;
             =  - ;
            val_2 = val_2 * ;
            val_2 =  + val_2;
            val_2 = val_2 + (1E-05f);
            this._currentVisibleNumber = (int)val_2;
            return (int)(int)val_2;
        }
        
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateText()
    {
        System.String[] val_18;
        string val_19;
        string val_1 = (this._stateIndex == 3) ? this._element2LocString : this._element1LocString;
        var val_2 = (this._stateIndex == 3) ? this._element2 : this._element1;
        Game.Localization.LocalizationDomain val_3 = Game.Localization.LocalizationDomain.Instance;
        var val_18 = 0;
        val_18 = val_18 + 1;
        string val_6 = val_3.ILocalization.GetLocalizedString(localizedStringId:  val_1, originalString:  val_2.text);
        val_18 = val_6;
        if((System.String.IsNullOrEmpty(value:  val_6)) == false)
        {
            goto label_8;
        }
        
        string[] val_8 = new string[6];
        val_18 = val_8;
        val_18[0] = "Can\'t find loc string. localizationId:\'";
        val_18[1] = val_1;
        val_18[2] = "\' originalString:";
        val_18[3] = val_2.text;
        val_18[4] = " GameObject:";
        val_18[5] = TutorialTextLocalizationCountUpTo999.GetTransformHierarchy(transform:  this.transform);
        ConsoleLogger.LogError(className:  "TutorialTextLocalizationCountUpTo999", functionName:  "UpdateText", logString:  +val_8);
        if(val_2 == 0)
        {
            goto label_31;
        }
        
        val_19 = val_2.text;
        goto label_34;
        label_8:
        val_19 = val_18.Replace(oldValue:  "###", newValue:  this.CalculateVisibleNumber().ToString());
        if(val_2 != 0)
        {
            goto label_34;
        }
        
        goto label_35;
        label_31:
        val_19 = val_2.text;
        label_35:
        label_34:
        val_2.text = val_19;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static string GetTransformHierarchy(UnityEngine.Transform transform)
    {
        if((UnityEngine.Object.op_Implicit(exists:  transform.parent)) == false)
        {
                return "";
        }
        
        return transform.parent + "/"("/") + transform.name;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TutorialTextLocalizationCountUpTo999()
    {
        this.hourOriginNumber = ;
        this.hourMidNumber = ;
        this.hourTargetNumber = 4294967796;
        this.yearOriginNumber = 1;
        this.yearTargetNumber = 999;
        this.initialDelay = 1.5f;
        this.countToMidTime = 1f;
        this.accelerateUpTime = 0f;
    }

}
