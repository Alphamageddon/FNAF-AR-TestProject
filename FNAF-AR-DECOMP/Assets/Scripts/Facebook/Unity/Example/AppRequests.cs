using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class AppRequests : MenuBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string requestMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string requestTo;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string requestFilter;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string requestExcludes;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string requestMax;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string requestData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string requestTitle;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string requestObjectID;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int selectedAction;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string[] actionTypeStrings;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void GetGui()
        {
            string val_54;
            int val_55;
            var val_56;
            string val_57;
            Facebook.Unity.OGActionType val_58;
            System.Collections.Generic.IEnumerable<System.String> val_59;
            System.Collections.Generic.IEnumerable<System.Object> val_60;
            System.Collections.Generic.IEnumerable<System.String> val_61;
            var val_62;
            if((this.Button(label:  "Select - Filter None")) != false)
            {
                    Facebook.Unity.FB.AppRequest(message:  "Test Message", to:  0, filters:  0, excludeIds:  0, maxRecipients:  new System.Nullable<System.Int32>() {HasValue = false}, data:  "", title:  "", callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            }
            
            if((this.Button(label:  "Select - Filter app_users")) != false)
            {
                    System.Collections.Generic.List<System.Object> val_4 = new System.Collections.Generic.List<System.Object>();
                val_4.Add(item:  "app_users");
                Facebook.Unity.FB.AppRequest(message:  "Test Message", to:  0, filters:  val_4, excludeIds:  0, maxRecipients:  new System.Nullable<System.Int32>() {HasValue = false}, data:  System.String.alignConst, title:  System.String.alignConst, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            }
            
            if((this.Button(label:  "Select - Filter app_non_users")) != false)
            {
                    System.Collections.Generic.List<System.Object> val_7 = new System.Collections.Generic.List<System.Object>();
                val_7.Add(item:  "app_non_users");
                Facebook.Unity.FB.AppRequest(message:  "Test Message", to:  0, filters:  val_7, excludeIds:  0, maxRecipients:  new System.Nullable<System.Int32>() {HasValue = false}, data:  System.String.alignConst, title:  System.String.alignConst, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
            }
            
            this.LabelAndTextField(label:  "Message: ", text: ref  this.requestMessage);
            this.LabelAndTextField(label:  "To (optional): ", text: ref  this.requestTo);
            this.LabelAndTextField(label:  "Filter (optional): ", text: ref  this.requestFilter);
            val_54 = this.requestExcludes;
            this.LabelAndTextField(label:  "Exclude Ids (optional): ", text: ref  val_54);
            this.LabelAndTextField(label:  "Filters: ", text: ref  val_54);
            this.LabelAndTextField(label:  "Max Recipients (optional): ", text: ref  this.requestMax);
            this.LabelAndTextField(label:  "Data (optional): ", text: ref  this.requestData);
            this.LabelAndTextField(label:  "Title (optional): ", text: ref  this.requestTitle);
            UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayoutOption[] val_19 = new UnityEngine.GUILayoutOption[1];
            float val_20 = this.ScaleFactor;
            val_20 = val_20 * 200f;
            val_19[0] = UnityEngine.GUILayout.MaxWidth(maxWidth:  val_20);
            UnityEngine.GUILayout.Label(text:  "Request Action (optional): ", style:  this.LabelStyle, options:  val_19);
            val_55 = this.selectedAction;
            UnityEngine.GUILayoutOption[] val_23 = new UnityEngine.GUILayoutOption[2];
            float val_25 = this.ScaleFactor;
            val_25 = ((Facebook.Unity.Constants.IsMobile != true) ? 60f : 24f) * val_25;
            val_23[0] = UnityEngine.GUILayout.MinHeight(minHeight:  val_25);
            if(Facebook.Unity.Constants.IsMobile != false)
            {
                    val_56 = UnityEngine.Screen.width - 30;
            }
            else
            {
                    val_56 = 700;
            }
            
            val_23[1] = UnityEngine.GUILayout.MaxWidth(maxWidth:  (float)700 - 150);
            this.selectedAction = UnityEngine.GUILayout.Toolbar(selected:  val_55, texts:  this.actionTypeStrings, style:  this.ButtonStyle, options:  val_23);
            UnityEngine.GUILayout.EndHorizontal();
            val_57 = this.requestObjectID;
            this.LabelAndTextField(label:  "Request Object ID (optional): ", text: ref  val_57);
            if((this.Button(label:  "Custom App Request")) == false)
            {
                    return;
            }
            
            System.Nullable<Facebook.Unity.OGActionType> val_35 = this.GetSelectedOGActionType();
            val_55 = this.requestMessage;
            if(((-1681988088) & 1) != 0)
            {
                    val_58;
                val_59 = 0;
                if((System.String.IsNullOrEmpty(value:  mem[this.requestTo])) != true)
            {
                    char[] val_37 = new char[1];
                val_37[0] = ',';
                val_59 = mem[this.requestTo].Split(separator:  val_37);
            }
            
                val_57 = this.requestTitle;
                Facebook.Unity.FB.AppRequest(message:  val_55, actionType:  val_35.HasValue, objectId:  mem[this.requestObjectID], to:  val_59, data:  this.requestData, title:  val_57, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
                return;
            }
            
            val_57 = 0;
            if((System.String.IsNullOrEmpty(value:  mem[this.requestTo])) != true)
            {
                    char[] val_41 = new char[1];
                val_41[0] = ',';
                val_57 = mem[this.requestTo].Split(separator:  val_41);
            }
            
            val_60 = 0;
            if((System.String.IsNullOrEmpty(value:  mem[this.requestFilter])) != true)
            {
                    char[] val_44 = new char[1];
                val_44[0] = ',';
                val_60 = System.Linq.Enumerable.ToList<System.Object>(source:  System.Linq.Enumerable.OfType<System.Object>(source:  mem[this.requestFilter].Split(separator:  val_44)));
            }
            
            val_61 = 0;
            if((System.String.IsNullOrEmpty(value:  mem[this.requestExcludes])) != true)
            {
                    val_62 = mem[this.requestExcludes];
                char[] val_49 = new char[1];
                val_49[0] = ',';
                val_61 = val_62.Split(separator:  val_49);
            }
            
            if((System.String.IsNullOrEmpty(value:  mem[this.requestMax])) != false)
            {
                
            }
            else
            {
                    int val_52 = System.Int32.Parse(s:  mem[this.requestMax]);
            }
            
            val_58 = this.requestTitle;
            Facebook.Unity.FB.AppRequest(message:  val_55, to:  val_57, filters:  val_60, excludeIds:  val_61, maxRecipients:  new System.Nullable<System.Int32>() {HasValue = false}, data:  this.requestData, title:  val_58, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IAppRequestResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Nullable<Facebook.Unity.OGActionType> GetSelectedOGActionType()
        {
            string val_10;
            var val_11;
            string val_10 = this.actionTypeStrings[this.selectedAction];
            val_10 = 0.ToString();
            long val_2 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime());
            if((System.String.op_Equality(a:  val_10, b:  val_10)) != false)
            {
                    val_11 = 1152921517558629936;
                return 0;
            }
            
            val_10 = 1.ToString();
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1});
            if((System.String.op_Equality(a:  val_10, b:  val_10)) != false)
            {
                    val_11 = 1152921517558629936;
                return 0;
            }
            
            val_10 = 2.ToString();
            long val_8 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 2});
            if((System.String.op_Equality(a:  val_10, b:  val_10)) == false)
            {
                    return 0;
            }
            
            val_11 = 1152921517558629936;
            return 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public AppRequests()
        {
            this.requestMessage = System.String.alignConst;
            this.requestTo = System.String.alignConst;
            this.requestFilter = System.String.alignConst;
            this.requestExcludes = System.String.alignConst;
            this.requestMax = System.String.alignConst;
            this.requestData = System.String.alignConst;
            this.requestTitle = System.String.alignConst;
            this.requestObjectID = System.String.alignConst;
            string[] val_1 = new string[4];
            val_1[0] = "NONE";
            long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime());
            val_1[1] = 0.ToString();
            long val_5 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1});
            val_1[2] = 1.ToString();
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 2});
            val_1[3] = 2.ToString();
            this.actionTypeStrings = val_1;
        }
    
    }

}
