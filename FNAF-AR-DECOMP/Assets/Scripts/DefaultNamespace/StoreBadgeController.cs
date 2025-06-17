using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StoreBadgeController
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string RECALL_COUNT_KEY = "recallCount";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string STORE_BADGE_ON_KEY = "storeBadgeOnKey";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int RECALLS_TO_SHOW_BADGE = 5;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool _badgeShowing;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _numRecalls;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.StoreBadgeActivator _storeBadgeActivator;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StoreBadgeController(GameUI.StoreBadgeActivator activator)
        {
            this._storeBadgeActivator = activator;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Teardown()
        {
            this._storeBadgeActivator = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup()
        {
            int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  "storeBadgeOnKey", defaultValue:  0);
            this._badgeShowing = (val_1 == 1) ? 1 : 0;
            if(val_1 == 1)
            {
                    this._storeBadgeActivator.ShowBadge();
            }
            
            this._numRecalls = UnityEngine.PlayerPrefs.GetInt(key:  "recallCount", defaultValue:  0);
            this.ValidatePlayerPrefs();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ValidatePlayerPrefs()
        {
            if(this._numRecalls < 6)
            {
                    return;
            }
            
            this._numRecalls = 0;
            UnityEngine.PlayerPrefs.SetInt(key:  "recallCount", value:  0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleRecallIncrement()
        {
            if(this._badgeShowing == true)
            {
                    return;
            }
            
            int val_1 = this._numRecalls + 1;
            this._numRecalls = val_1;
            UnityEngine.PlayerPrefs.SetInt(key:  "recallCount", value:  val_1);
            if(this._numRecalls != 5)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.SetInt(key:  "storeBadgeOnKey", value:  1);
            this._badgeShowing = true;
            this._storeBadgeActivator.ShowBadge();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void HandleStoreOpened()
        {
            if(this._badgeShowing != false)
            {
                    this._numRecalls = 0;
                this._badgeShowing = false;
                UnityEngine.PlayerPrefs.SetInt(key:  "storeBadgeOnKey", value:  0);
                UnityEngine.PlayerPrefs.SetInt(key:  "recallCount", value:  0);
                this._storeBadgeActivator.HideBadge();
                return;
            }
            
            if(this._numRecalls == 0)
            {
                    return;
            }
            
            this._numRecalls = 0;
            UnityEngine.PlayerPrefs.SetInt(key:  "recallCount", value:  0);
        }
    
    }

}
