using UnityEngine;

namespace Mapbox.Tokens
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapboxToken
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Code;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Tokens.TokenMetadata TokenMetadata;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Tokens.MapboxTokenStatus Status;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool HasError;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ErrorMessage;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Mapbox.Tokens.MapboxToken FromResponseData(byte[] data)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if((data == null) || (data.Length <= 0))
            {
                goto label_2;
            }
            
            .Status = 5;
            null = new Mapbox.Tokens.MapboxToken();
            val_13 = Mapbox.Json.JsonConvert.DeserializeObject<Mapbox.Tokens.MapboxToken>(value:  System.Text.Encoding.UTF8);
            long val_6 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_3.Code)});
            if((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  val_6)) == false)
            {
                goto label_13;
            }
            
            val_3.Status = val_6;
            return (Mapbox.Tokens.MapboxToken)val_14;
            label_2:
            Mapbox.Tokens.MapboxToken val_9 = null;
            val_14 = val_9;
            .Status = 5;
            val_9 = new Mapbox.Tokens.MapboxToken();
            if(val_14 != null)
            {
                    .HasError = true;
            }
            else
            {
                    .HasError = true;
            }
            
            .ErrorMessage = "No data received from token endpoint.";
            return (Mapbox.Tokens.MapboxToken)val_14;
            label_13:
            new System.Exception() = new System.Exception(message:  System.String.Format(format:  "could not convert token.code \'{0}\' to MapboxTokenStatus", arg0:  val_3.Code));
            val_15 = 0;
            val_16 = new System.Exception();
            if(val_15 == 1)
            {
                    if((null & 1) != 0)
            {
                    val_3.HasError = true;
                val_3.ErrorMessage = 1152921504618721280;
                return (Mapbox.Tokens.MapboxToken)val_14;
            }
            
                mem[8] = null;
                val_16 = 8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapboxToken()
        {
            this.Status = 5;
        }
    
    }

}
