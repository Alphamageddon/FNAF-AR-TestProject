using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AREnvironmentSetupSequencer : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AREnvironmentSetupSequence[] sequences;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool sequencesStarted;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int currentSequenceIndex;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        goto label_0;
        label_4:
        AREnvironmentSetupSequence val_1 = this.sequences[0];
        0 = 1;
        label_0:
        if(0 < this.sequences.Length)
        {
            goto label_4;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        var val_7;
        var val_8;
        var val_9;
        val_7 = this;
        if(this.sequencesStarted != true)
        {
                if(this.sequences.Length != 0)
        {
                this.currentSequenceIndex = 0;
            AREnvironmentSetupSequence val_7 = this.sequences[0];
            this.sequencesStarted = true;
        }
        else
        {
                if(this.sequencesStarted == false)
        {
                return;
        }
        
        }
        
        }
        
        if(this.currentSequenceIndex >= this.sequences.Length)
        {
                return;
        }
        
        if(this.currentSequenceIndex >= this.sequences.Length)
        {
                val_8 = 0;
        }
        
        if((this.sequences[this.currentSequenceIndex] & 1) == 0)
        {
                return;
        }
        
        int val_1 = this.currentSequenceIndex + 1;
        this.currentSequenceIndex = val_1;
        if(val_1 >= this.sequences.Length)
        {
                return;
        }
        
        if(this.currentSequenceIndex >= this.sequences.Length)
        {
                val_9 = 0;
        }
        
        AREnvironmentSetupSequence val_9 = this.sequences[this.currentSequenceIndex];
        val_7 = ???;
        goto typeof(AREnvironmentSetupSequence).__il2cppRuntimeField_178;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void LateUpdate()
    {
        if(this.sequencesStarted == false)
        {
                return;
        }
        
        if(this.currentSequenceIndex >= this.sequences.Length)
        {
                return;
        }
        
        AREnvironmentSetupSequence val_6 = this.sequences[this.currentSequenceIndex];
        this = ???;
        goto typeof(AREnvironmentSetupSequence).__il2cppRuntimeField_1B8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AREnvironmentSetupSequencer()
    {
    
    }

}
