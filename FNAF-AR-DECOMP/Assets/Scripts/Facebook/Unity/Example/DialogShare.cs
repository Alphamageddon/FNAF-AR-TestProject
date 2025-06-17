using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class DialogShare : MenuBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string shareLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string shareTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string shareDescription;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string shareImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string feedTo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string feedLink;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string feedTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string feedCaption;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string feedDescription;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string feedImage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string feedMediaSource;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool ShowDialogModeSelector()
        {
            return true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void GetGui()
        {
            var val_38;
            string val_39;
            string val_40;
            var val_41;
            var val_42;
            string val_43;
            string val_44;
            string val_45;
            string val_46;
            System.Uri val_47;
            val_38 = 1152921504865099776;
            bool val_1 = UnityEngine.GUI.enabled;
            if((this.Button(label:  "Share - Link")) != false)
            {
                    Facebook.Unity.FB.ShareLink(contentURL:  new System.Uri(uriString:  "https://developers.facebook.com/"), contentTitle:  "", contentDescription:  "", photoURL:  0, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            }
            
            if((this.Button(label:  "Share - Link Photo")) != false)
            {
                    Facebook.Unity.FB.ShareLink(contentURL:  new System.Uri(uriString:  "https://developers.facebook.com/"), contentTitle:  "Link Share", contentDescription:  "Look I\'m sharing a link", photoURL:  new System.Uri(uriString:  "http://i.imgur.com/j4M7vCO.jpg"), callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            }
            
            val_39 = "Link";
            this.LabelAndTextField(label:  "Link", text: ref  this.shareLink);
            this.LabelAndTextField(label:  "Title", text: ref  this.shareTitle);
            val_40 = "Description";
            this.LabelAndTextField(label:  "Description", text: ref  this.shareDescription);
            this.LabelAndTextField(label:  "Image", text: ref  this.shareImage);
            if((this.Button(label:  "Share - Custom")) == false)
            {
                goto label_9;
            }
            
            Facebook.Unity.FB.ShareLink(contentURL:  new System.Uri(uriString:  this.shareLink), contentTitle:  this.shareTitle, contentDescription:  this.shareDescription, photoURL:  new System.Uri(uriString:  this.shareImage), callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            val_40 = val_40;
            val_39 = "Link";
            val_38 = val_38;
            if(val_1 == true)
            {
                goto label_12;
            }
            
            label_14:
            val_41 = 0;
            val_42 = 0;
            goto label_20;
            label_9:
            if(val_1 == false)
            {
                goto label_14;
            }
            
            label_12:
            if(Facebook.Unity.Constants.IsEditor == false)
            {
                goto label_15;
            }
            
            if(Facebook.Unity.Constants.IsEditor == false)
            {
                goto label_16;
            }
            
            val_42 = Facebook.Unity.FB.IsLoggedIn;
            goto label_19;
            label_15:
            val_41 = 1;
            val_42 = 1;
            goto label_20;
            label_16:
            val_42 = 0;
            label_19:
            val_41 = 1;
            label_20:
            UnityEngine.GUI.enabled = false;
            if((this.Button(label:  "Feed Share - No To")) != false)
            {
                    Facebook.Unity.FB.FeedShare(toId:  System.String.alignConst, link:  new System.Uri(uriString:  "https://developers.facebook.com/"), linkName:  "Test Title", linkCaption:  "Test caption", linkDescription:  "Test Description", picture:  new System.Uri(uriString:  "http://i.imgur.com/zkYlB.jpg"), mediaSource:  System.String.alignConst, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
                val_40 = val_40;
            }
            
            val_43 = this.feedTo;
            this.LabelAndTextField(label:  "To", text: ref  val_43);
            val_44 = this.feedLink;
            this.LabelAndTextField(label:  val_39, text: ref  val_44);
            val_45 = this.feedTitle;
            this.LabelAndTextField(label:  "Title", text: ref  val_45);
            this.LabelAndTextField(label:  "Caption", text: ref  this.feedCaption);
            val_46 = this.feedDescription;
            this.LabelAndTextField(label:  val_40, text: ref  val_46);
            this.LabelAndTextField(label:  "Image", text: ref  this.feedImage);
            this.LabelAndTextField(label:  "Media Source", text: ref  this.feedMediaSource);
            if((this.Button(label:  "Feed Share - Custom")) != false)
            {
                    val_43 = mem[this.feedTo];
                val_47 = 0;
                if((System.String.IsNullOrEmpty(value:  mem[this.feedLink])) != true)
            {
                    System.Uri val_33 = null;
                val_47 = val_33;
                val_33 = new System.Uri(uriString:  mem[this.feedLink]);
            }
            
                val_45 = mem[this.feedTitle];
                val_44 = mem[this.feedDescription];
                val_46 = 0;
                if((System.String.IsNullOrEmpty(value:  mem[this.feedImage])) != true)
            {
                    System.Uri val_35 = null;
                val_46 = val_35;
                val_35 = new System.Uri(uriString:  mem[this.feedImage]);
            }
            
                Facebook.Unity.FB.FeedShare(toId:  val_43, link:  val_33, linkName:  val_45, linkCaption:  mem[this.feedCaption], linkDescription:  val_44, picture:  val_35, mediaSource:  this.feedMediaSource, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IShareResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
                val_41 = val_41;
            }
            
            UnityEngine.GUI.enabled = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DialogShare()
        {
            this.shareLink = "https://developers.facebook.com/";
            this.shareTitle = "Link Title";
            this.shareDescription = "Link Description";
            this.shareImage = "http://i.imgur.com/j4M7vCO.jpg";
            this.feedTo = System.String.alignConst;
            this.feedLink = "https://developers.facebook.com/";
            this.feedTitle = "Test Title";
            this.feedCaption = "Test Caption";
            this.feedDescription = "Test Description";
            this.feedImage = "http://i.imgur.com/zkYlB.jpg";
            this.feedMediaSource = System.String.alignConst;
        }
    
    }

}
