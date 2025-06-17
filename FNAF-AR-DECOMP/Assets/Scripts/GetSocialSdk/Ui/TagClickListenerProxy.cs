using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TagClickListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<string> _tagClickListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TagClickListenerProxy(System.Action<string> tagClickListener)
        {
            this._tagClickListener = tagClickListener;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onTagClicked(string tag)
        {
            TagClickListenerProxy.<>c__DisplayClass2_0 val_1 = new TagClickListenerProxy.<>c__DisplayClass2_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .tag = tag;
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  new System.Action(object:  val_1, method:  System.Void TagClickListenerProxy.<>c__DisplayClass2_0::<onTagClicked>b__0()));
        }
    
    }

}
