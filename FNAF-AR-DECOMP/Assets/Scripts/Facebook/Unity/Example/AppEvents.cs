using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AppEvents : MenuBase
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void GetGui()
        {
            if((this.Button(label:  "Log FB App Event")) == false)
            {
                    return;
            }
            
            mem[1152921520103625816] = "Logged FB.AppEvent";
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_2.Add(key:  "fb_description", value:  "Clicked \'Log AppEvent\' button");
            Facebook.Unity.FB.LogAppEvent(logEvent:  "fb_mobile_achievement_unlocked", valueToSum:  new System.Nullable<System.Single>() {HasValue = false}, parameters:  val_2);
            Facebook.Unity.Example.LogView.AddLog(log:  "You may see results showing up at https://www.facebook.com/analytics/"("You may see results showing up at https://www.facebook.com/analytics/") + Facebook.Unity.FB.AppId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppEvents()
        {
        
        }
    
    }

}
