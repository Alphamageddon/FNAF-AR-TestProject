using UnityEngine;

namespace PlayFab
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PlayFabError
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ApiEndpoint;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int HttpCode;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string HttpStatus;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFab.PlayFabErrorCode Error;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ErrorMessage;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> ErrorDetails;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public object CustomData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Text.StringBuilder _tempSb;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public override string ToString()
        {
            PlayFab.PlayFabErrorCode val_5;
            var val_21;
            var val_22;
            string val_23;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(this.ErrorDetails == null)
            {
                goto label_20;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_2 = this.ErrorDetails.GetEnumerator();
            label_8:
            if(((-390073632) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_6 = val_5.trackableId;
            System.Text.StringBuilder val_8 = val_1.Append(value:  val_6.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.List<System.String>>::get_Key()));
            System.Text.StringBuilder val_9 = val_1.Append(value:  ": ");
            System.Text.StringBuilder val_12 = val_1.Append(value:  System.String.Join(separator:  ", ", value:  val_6.m_SubId1.ToArray()));
            System.Text.StringBuilder val_13 = val_1.Append(value:  " | ");
            goto label_8;
            label_2:
            val_21 = 0;
            val_22 = 1;
            long val_14 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525691609824});
            label_20:
            object[] val_15 = new object[5];
            val_15[0] = this.ApiEndpoint;
            val_5 = this.Error;
            val_15[1] = val_5;
            val_15[2] = this.ErrorMessage;
            val_15[3] = this.HttpCode;
            val_15[4] = this.HttpStatus;
            if(val_1.Length > 0)
            {
                    val_23 = " - Details: "(" - Details: ") + val_1 + ")";
                return (string)System.String.Format(format:  "{0} PlayFabError({1}, {2}, {3} {4}", args:  val_15)(System.String.Format(format:  "{0} PlayFabError({1}, {2}, {3} {4}", args:  val_15)) + val_23;
            }
            
            val_23 = ")";
            return (string)System.String.Format(format:  "{0} PlayFabError({1}, {2}, {3} {4}", args:  val_15)(System.String.Format(format:  "{0} PlayFabError({1}, {2}, {3} {4}", args:  val_15)) + val_23;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string GenerateErrorReport()
        {
            var val_18;
            var val_31;
            PlayFab.PlayFabErrorCode val_32;
            string val_33;
            string val_34;
            var val_35;
            var val_36;
            var val_37;
            val_31 = 1152921505286504448;
            if((mem[-1]) == 0)
            {
                    mem2[-1] = new System.Text.StringBuilder();
            }
            
            mem[-1].Length = 0;
            val_32 = mem[-1].Append(value:  this.ApiEndpoint).Append(value:  ": ");
            if((System.String.IsNullOrEmpty(value:  this.ErrorMessage)) != false)
            {
                    val_32 = this.Error;
                val_33 = val_32.ToString();
                mem2[0] = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = val_32});
                System.Text.StringBuilder val_13 = val_32.Append(value:  "Http Code: ").Append(value:  this.HttpCode.ToString()).Append(value:  "\nHttp Status: ").Append(value:  this.HttpStatus).Append(value:  "\nError: ").Append(value:  val_33);
                val_34 = "\n";
            }
            else
            {
                    val_34 = this.ErrorMessage;
            }
            
            System.Text.StringBuilder val_14 = val_32.Append(value:  val_34);
            if(this.ErrorDetails == null)
            {
                goto label_44;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_15 = this.ErrorDetails.GetEnumerator();
            val_35 = 0;
            val_36 = 0;
            label_36:
            if(((-389760576) & 1) == 0)
            {
                goto label_18;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_19 = val_18.trackableId;
            List.Enumerator<T> val_20 = val_19.m_SubId1.GetEnumerator();
            label_25:
            if(((-389760624) & 1) == 0)
            {
                goto label_20;
            }
            
            System.Text.StringBuilder val_26 = mem[-1].Append(value:  "\n").Append(value:  val_19.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Collections.Generic.List<System.String>>::get_Key())).Append(value:  ": ").Append(value:  val_18.emailUIDataHandler);
            goto label_25;
            label_20:
            val_37 = val_36;
            long val_27 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525691922832});
            if((((322 == 0) ? 322 : 322) == 322) || ( == 0))
            {
                goto label_36;
            }
            
            goto label_36;
            label_18:
            val_31 = 1152921505286504448;
            val_33 = 347;
            val_34 = public System.Void Dictionary.Enumerator<System.String, System.Collections.Generic.List<System.String>>::Dispose();
            long val_29 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921525691922880});
            if((( != 0) && (322 != 0)) && (322 != 347))
            {
                    val_34 = 0;
            }
            
            label_44:
            if((mem[-1]) != 0)
            {
                    return (string)mem[-1];
            }
            
            return (string)mem[-1];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PlayFabError()
        {
        
        }
    
    }

}
