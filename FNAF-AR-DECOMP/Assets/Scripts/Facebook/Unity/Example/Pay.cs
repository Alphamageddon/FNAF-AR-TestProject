using UnityEngine;

namespace Facebook.Unity.Example
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal class Pay : MenuBase
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string payProduct;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override void GetGui()
        {
            this.LabelAndTextField(label:  "Product: ", text: ref  this.payProduct);
            if((this.Button(label:  "Call Pay")) != false)
            {
                    this.CallFBPay();
            }
            
            UnityEngine.GUILayout.Space(pixels:  10f);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CallFBPay()
        {
            FB.Canvas.Pay(product:  this.payProduct, action:  "purchaseitem", quantity:  1, quantityMin:  new System.Nullable<System.Int32>() {HasValue = false}, quantityMax:  new System.Nullable<System.Int32>() {HasValue = false}, requestId:  0, pricepointId:  0, testCurrency:  0, callback:  new Facebook.Unity.FacebookDelegate<Facebook.Unity.IPayResult>(object:  this, method:  System.Void Facebook.Unity.Example.MenuBase::HandleResult(Facebook.Unity.IResult result)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Pay()
        {
            this.payProduct = System.String.alignConst;
        }
    
    }

}
