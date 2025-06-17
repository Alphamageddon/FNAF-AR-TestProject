using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GuideVisualizer : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static readonly string PlayerPrefsStartGameOpenKey;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GuideVisualizerElement[] _elements;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Systems.Guide.GuideHistory _history;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void ChangeDriver(Systems.Guide.GuideNodeDriver driver)
    {
        if(this._history != null)
        {
                this._history.Teardown();
            this._history = 0;
        }
        
        Systems.Guide.GuideHistory val_1 = new Systems.Guide.GuideHistory();
        this._history = val_1;
        val_1.Setup(driver:  driver);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Show()
    {
        null = null;
        UnityEngine.PlayerPrefs.SetInt(key:  GuideVisualizer.PlayerPrefsStartGameOpenKey, value:  1);
        this.gameObject.SetActive(value:  true);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Hide()
    {
        null = null;
        UnityEngine.PlayerPrefs.SetInt(key:  GuideVisualizer.PlayerPrefsStartGameOpenKey, value:  0);
        this.gameObject.SetActive(value:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Update()
    {
        if(this._history == null)
        {
                return;
        }
        
        this._history.UpdateFrame();
        this.UpdateVisualElements();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateVisualElements()
    {
        var val_2;
        var val_3;
        GuideVisualizerElement val_4;
        val_2 = 0;
        goto label_1;
        label_9:
        GuideVisualizerElement val_2 = this._elements[0];
        if(val_2 < val_1.Length)
        {
                this.ConfigureElementContent(element:  val_2, node:  new NodeContext() {node = this._history.DeliverableContext[0], state = this._history.DeliverableContext[0]});
            val_3 = 1;
            val_4 = val_2;
        }
        else
        {
                val_4 = val_2;
            val_3 = 0;
        }
        
        this.ChangeElementVisibility(element:  val_4, value:  false);
        val_2 = 1;
        label_1:
        if(val_2 < this._elements.Length)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ConfigureElementContent(GuideVisualizerElement element, Systems.Guide.GuideHistory.NodeContext node)
    {
        var val_9;
        string val_10;
        GuideVisualizerElement val_11;
        float val_12;
        float val_13;
        val_9 = 0;
        val_10 = "";
        goto label_1;
        label_13:
        int val_2 = node.node.Events.Length + 32;
        mem2[0] = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_2});
        val_10 = val_10 + " "(val_10 + " ") + val_2.ToString();
        if((node.node.EventArgs != null) && (val_9 < node.node.EventArgs.Length))
        {
                val_10 = val_10 + ":"(":") + node.node.EventArgs.Length + 32(node.node.EventArgs.Length + 32);
        }
        
        val_9 = 1;
        label_1:
        if(val_9 < node.node.Events.Length)
        {
            goto label_13;
        }
        
        val_11 = element;
        object[] val_7 = new object[5];
        if(val_7 == null)
        {
            goto label_15;
        }
        
        if(node.state != 0)
        {
            goto label_16;
        }
        
        goto label_19;
        label_15:
        if(node.state == 0)
        {
            goto label_19;
        }
        
        label_16:
        label_19:
        val_7[0] = node.state;
        val_7[1] = node.node.Uid;
        val_7[2] = val_10;
        val_7[3] = node.node.Action;
        val_7[4] = node.node.ActionArgs;
        element + 32.text = System.String.Format(format:  "{0}: {1}\n{2}\n{3}({4})", args:  val_7);
        if(node.state == 0)
        {
            goto label_34;
        }
        
        if(node.state == 1)
        {
            goto label_35;
        }
        
        if(node.state != 2)
        {
                return;
        }
        
        val_11 = mem[element + 24];
        val_11 = element + 24;
        val_12 = 0.25f;
        val_13 = 0f;
        return;
        label_34:
        val_11 = mem[element + 24];
        val_11 = element + 24;
        val_13 = 0.5f;
        val_12 = 0.25f;
        return;
        label_35:
        val_11 = mem[element + 24];
        val_11 = element + 24;
        val_13 = 0.5f;
        val_12 = 0.25f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void ChangeElementVisibility(GuideVisualizerElement element, bool value)
    {
        bool val_1 = value;
        element._caption.enabled = val_1;
        element._background.enabled = val_1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GuideVisualizer()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static GuideVisualizer()
    {
        GuideVisualizer.PlayerPrefsStartGameOpenKey = "GuideVisualizer_OpenWhenGameStarts";
    }

}
