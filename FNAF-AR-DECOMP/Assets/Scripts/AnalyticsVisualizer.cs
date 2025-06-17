using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AnalyticsVisualizer : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly string PlayerPrefsStartGameOpenKey;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AnalyticsVisualizerElement[] _elements;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Systems.Analytics.AnalyticsHistory _history;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void InjectHistory(Systems.Analytics.AnalyticsHistory history)
    {
        this._history = history;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Show()
    {
        null = null;
        UnityEngine.PlayerPrefs.SetInt(key:  AnalyticsVisualizer.PlayerPrefsStartGameOpenKey, value:  1);
        this.gameObject.SetActive(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Hide()
    {
        null = null;
        UnityEngine.PlayerPrefs.SetInt(key:  AnalyticsVisualizer.PlayerPrefsStartGameOpenKey, value:  0);
        this.gameObject.SetActive(value:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Update()
    {
        if(this._history == null)
        {
                return;
        }
        
        this.UpdateVisualElements();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateVisualElements()
    {
        var val_5;
        System.Collections.Generic.LinkedListNode<T> val_2 = this._history.Entries.Last;
        val_5 = 0;
        goto label_3;
        label_9:
        AnalyticsVisualizerElement val_5 = this._elements[0];
        if(val_2 != null)
        {
                Entry val_3 = val_2.Value;
            val_3.ConfigureElementContent(element:  val_5, entry:  val_3);
            val_3.ChangeElementVisibility(element:  val_5, value:  true);
            System.Collections.Generic.LinkedListNode<T> val_4 = val_2.Previous;
        }
        else
        {
                this.ChangeElementVisibility(element:  val_5, value:  false);
        }
        
        val_5 = 1;
        label_3:
        if(val_5 < this._elements.Length)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ConfigureElementContent(AnalyticsVisualizerElement element, Systems.Analytics.AnalyticsHistory.Entry entry)
    {
        ulong val_4;
        UnityEngine.UI.Image val_12;
        var val_13;
        var val_14;
        float val_15;
        float val_16;
        val_12 = element;
        Dictionary.Enumerator<TKey, TValue> val_1 = entry.metadata.GetEnumerator();
        label_23:
        if((1411145216 & 1) == 0)
        {
            goto label_3;
        }
        
        UnityEngine.XR.ARSubsystems.TrackableId val_5 = val_4.trackableId;
        string[] val_6 = new string[6];
        val_6[0] = "";
        val_6[1] = "(";
        val_6[2] = val_5.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.String>::get_Key());
        val_6[3] = ": ";
        val_6[4] = ;
        val_6[5] = ") ";
        string val_8 = +val_6;
        goto label_23;
        label_3:
        val_13 = 0;
        val_14 = 1;
        long val_9 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921518902894080});
        object[] val_10 = new object[4];
        val_4 = entry.timestamp;
        val_10[0] = val_4;
        val_10[1] = entry.key;
        val_10[2] = entry.mode;
        val_10[3] = "";
        element._caption.text = System.String.Format(format:  "{0} : {1} ({2})\n{3}", args:  val_10);
        if(entry.mode == 0)
        {
            goto label_53;
        }
        
        if(entry.mode == 1)
        {
            goto label_54;
        }
        
        if(entry.mode != 2)
        {
                return;
        }
        
        val_12 = element._background;
        val_15 = 0.25f;
        val_4 = 0;
        val_16 = 0.75f;
        goto label_57;
        label_53:
        val_12 = element._background;
        val_4 = 0;
        val_16 = 0.75f;
        val_15 = 0.2f;
        goto label_57;
        label_54:
        val_12 = element._background;
        val_16 = 0.75f;
        val_15 = 0.25f;
        val_4 = 0;
        label_57:
        val_12.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ChangeElementVisibility(AnalyticsVisualizerElement element, bool value)
    {
        bool val_1 = value;
        element._caption.enabled = val_1;
        element._background.enabled = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AnalyticsVisualizer()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AnalyticsVisualizer()
    {
        AnalyticsVisualizer.PlayerPrefsStartGameOpenKey = "AnalyticsVisualizer_OpenWhenGameStarts";
    }

}
