using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class GraphRequest : MenuBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string apiQuery;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Texture2D profilePic;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void GetGui()
        {
            object val_16;
            var val_17;
            var val_18;
            val_16 = this;
            if(UnityEngine.GUI.enabled != false)
            {
                    val_17 = Facebook.Unity.FB.IsLoggedIn;
                val_18 = 1;
            }
            else
            {
                    val_18 = 0;
                val_17 = 0;
            }
            
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Basic Request - Me")) != false)
            {
                    Facebook.Unity.FB.API(query:  "/me", method:  0, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)), formData:  0);
            }
            
            if((this.Button(label:  "Retrieve Profile Photo")) != false)
            {
                    Facebook.Unity.FB.API(query:  "/me/picture", method:  0, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  this, method:  System.Void Facebook.Unity.Example.GraphRequest::ProfilePhotoCallback(Facebook.Unity.IGraphResult result)), formData:  0);
            }
            
            if((this.Button(label:  "Take and Upload screenshot")) != false)
            {
                    UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.TakeScreenshot());
            }
            
            this.LabelAndTextField(label:  "Request", text: ref  this.apiQuery);
            if((this.Button(label:  "Custom Request")) != false)
            {
                    Facebook.Unity.FB.API(query:  this.apiQuery, method:  0, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IGraphResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)), formData:  0);
            }
            
            if(this.profilePic != 0)
            {
                    val_16 = this.profilePic;
                UnityEngine.GUILayout.Box(image:  val_16, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            }
            
            UnityEngine.GUI.enabled = false;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ProfilePhotoCallback(Facebook.Unity.IGraphResult result)
        {
            UnityEngine.Object val_6;
            var val_9 = 0;
            val_9 = val_9 + 1;
            if((System.String.IsNullOrEmpty(value:  result.Error)) != false)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_6 = result.Texture;
                if(val_6 != 0)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                this.profilePic = result.Texture;
            }
            
            }
            
            this.HandleResult(result:  result);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.IEnumerator TakeScreenshot()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new GraphRequest.<TakeScreenshot>d__4();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GraphRequest()
        {
            this.apiQuery = System.String.alignConst;
        }
    
    }

}
