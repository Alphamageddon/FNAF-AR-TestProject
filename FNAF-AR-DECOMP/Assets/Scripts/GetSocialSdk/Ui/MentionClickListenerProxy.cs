using UnityEngine;

namespace GetSocialSdk.Ui
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MentionClickListenerProxy : JavaInterfaceProxy
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Action<string> _onMentionClickListener;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MentionClickListenerProxy(System.Action<string> onMentionClickListener)
        {
            this._onMentionClickListener = onMentionClickListener;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void onMentionClicked(string userId)
        {
            MentionClickListenerProxy.<>c__DisplayClass2_0 val_1 = new MentionClickListenerProxy.<>c__DisplayClass2_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            .userId = userId;
            GetSocialSdk.Core.MainThreadExecutor.Queue(action:  new System.Action(object:  val_1, method:  System.Void MentionClickListenerProxy.<>c__DisplayClass2_0::<onMentionClicked>b__0()));
        }
    
    }

}
