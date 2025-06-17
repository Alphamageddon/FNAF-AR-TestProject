using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreBadgeActivator
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject _badgeParent;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HideBadge()
        {
            this._badgeParent.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowBadge()
        {
            this._badgeParent.SetActive(value:  true);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreBadgeActivator(UnityEngine.GameObject inboxBadgeParent)
        {
            this._badgeParent = inboxBadgeParent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(UnityEngine.GameObject badgeParent)
        {
            this._badgeParent = badgeParent;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._badgeParent = 0;
        }
    
    }

}
