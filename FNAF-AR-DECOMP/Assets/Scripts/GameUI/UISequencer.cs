using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class UISequencer
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.UISequenceData uiSequenceData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.IUISequence currentSequence;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Queue<GameUI.IUISequence> sequences;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Action OnComplete;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UISequencer()
        {
            this.sequences = new System.Collections.Generic.Queue<GameUI.IUISequence>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Iterate()
        {
            var val_4;
            if(this.currentSequence != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                val_4 = 3;
                this.currentSequence.TeardownSequence();
            }
            
            GameUI.IUISequence val_2 = this.sequences.Dequeue();
            this.currentSequence = val_2;
            if(val_2 == null)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_4 = 0;
            val_2.StartSequence(data:  this.uiSequenceData);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void LoadSequencer(System.Collections.Generic.List<UnityEngine.GameObject> sequencesToLoad)
        {
            var val_7 = this;
            this.sequences.Clear();
            List.Enumerator<T> val_1 = sequencesToLoad.GetEnumerator();
            label_7:
            if(((-1171595592) & 1) == 0)
            {
                    return;
            }
            
            this.AddSequence(sequence:  0.emailUIDataHandler.GetComponent(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())));
            goto label_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void AddSequence(GameUI.IUISequence sequence)
        {
            this.sequences.Enqueue(item:  sequence);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void StartSequencer(GameUI.UISequenceData data, System.Action OnComplete)
        {
            this.uiSequenceData = data;
            this.OnComplete = OnComplete;
            this.Iterate();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateSequencer()
        {
            if(this.currentSequence == null)
            {
                    return;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.currentSequence.UpdateSequence();
            if(this.currentSequence == null)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(this.currentSequence.IsSequenceDone() == false)
            {
                    return;
            }
            
            if(this.sequences != null)
            {
                    if(this.sequences.Count == 0)
            {
                goto label_13;
            }
            
            }
            
            this.Iterate();
            return;
            label_13:
            if(this.currentSequence != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                this.currentSequence.TeardownSequence();
            }
            
            this.currentSequence = 0;
            if(this.OnComplete == null)
            {
                    return;
            }
            
            this.OnComplete.Invoke();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        internal void OnDestroy()
        {
            if(this.currentSequence != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.currentSequence.TeardownSequence();
            }
            
            if(this.sequences != null)
            {
                    this.sequences.Clear();
            }
            
            this.sequences = 0;
        }
    
    }

}
