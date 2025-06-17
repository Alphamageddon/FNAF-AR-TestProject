using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class ChatController : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TMP_InputField TMP_ChatInput;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public TMPro.TMP_Text TMP_ChatOutput;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.UI.Scrollbar ChatScrollbar;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        this.TMP_ChatInput.onSubmit.AddListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void ChatController::AddToChatOutput(string newText)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        this.TMP_ChatInput.onSubmit.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.String>(object:  this, method:  System.Void ChatController::AddToChatOutput(string newText)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void AddToChatOutput(string newText)
    {
        this.TMP_ChatInput.text = System.String.alignConst;
        System.DateTime val_1 = System.DateTime.Now;
        string[] val_2 = new string[10];
        string val_3 = this.TMP_ChatOutput.text;
        if(val_2 == null)
        {
            goto label_5;
        }
        
        if(val_3 != null)
        {
            goto label_6;
        }
        
        goto label_9;
        label_5:
        if(val_3 == null)
        {
            goto label_9;
        }
        
        label_6:
        label_9:
        val_2[0] = val_3;
        val_2[1] = "[<#FFFF80>";
        val_2[2] = val_1.dateData.Hour.ToString(format:  "d2");
        val_2[3] = ":";
        val_2[4] = val_1.dateData.Minute.ToString(format:  "d2");
        val_2[5] = ":";
        val_2[6] = val_1.dateData.Second.ToString(format:  "d2");
        val_2[7] = "</color>] ";
        val_2[8] = newText;
        val_2[9] = "\n";
        this.TMP_ChatOutput.text = +val_2;
        this.TMP_ChatInput.ActivateInputField();
        this.ChatScrollbar.value = 0f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ChatController()
    {
    
    }

}
