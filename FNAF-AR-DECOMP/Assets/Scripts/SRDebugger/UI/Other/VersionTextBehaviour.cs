using UnityEngine;

namespace SRDebugger.UI.Other
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class VersionTextBehaviour : SRMonoBehaviourEx
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Format;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.UI.Text Text;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void Start()
        {
            this.Start();
            string val_1 = System.String.Format(format:  this.Format, arg0:  "1.7.1");
            if(this.Text == null)
            {
                
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public VersionTextBehaviour()
        {
            this.Format = "SRDebugger {0}";
        }
    
    }

}
