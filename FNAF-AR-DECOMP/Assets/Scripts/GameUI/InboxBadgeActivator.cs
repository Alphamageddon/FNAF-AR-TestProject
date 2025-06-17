using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class InboxBadgeActivator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _badgeParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI _badgeLabel;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void HideBadge()
        {
            this._badgeParent.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ShowBadge()
        {
            this._badgeParent.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateDisplay(string msg)
        {
            this._badgeLabel.text = msg;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public InboxBadgeActivator(UnityEngine.GameObject inboxBadgeParent, TMPro.TextMeshProUGUI inboxBadgeLabel)
        {
            this._badgeParent = inboxBadgeParent;
            this._badgeLabel = inboxBadgeLabel;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(UnityEngine.GameObject badgeParent, TMPro.TextMeshProUGUI badgeLabel)
        {
            this._badgeParent = badgeParent;
            this._badgeLabel = badgeLabel;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._badgeParent = 0;
            this._badgeLabel = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetBadgeValue(int count)
        {
            if(count > 0)
            {
                    this.ShowBadge();
                this.UpdateDisplay(msg:  count.ToString());
                return;
            }
            
            this.HideBadge();
        }
    
    }

}
