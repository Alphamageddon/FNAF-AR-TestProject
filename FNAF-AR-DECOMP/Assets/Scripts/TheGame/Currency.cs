using UnityEngine;

namespace TheGame
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Currency
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string FAZ_TOKEN = "FAZ_TOKENS";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PARTS = "PARTS";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string ESSENCE = "ESSENCE";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string REALMONEY = "REAL_MONEY";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PF_FAZ_TOKEN = "FC";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PF_PARTS = "PA";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PF_ESSENCE = "RE";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public const string PF_REALMONEY = "RM";
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetCurrencyString(TheGame.Currency.CurrencyType type)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = null;
            val_1 = null;
            if(Game.Server.ServerDomain.CurrentServer != 2)
            {
                goto label_3;
            }
            
            if(type >= 4)
            {
                goto label_8;
            }
            
            val_2 = 66464704;
            goto label_6;
            label_3:
            if(type >= 4)
            {
                goto label_8;
            }
            
            val_2 = 66464736;
            label_6:
            val_3 = mem[val_2 + (type) << 3];
            val_3 = val_2 + (type) << 3;
            return (string)val_3;
            label_8:
            val_3 = "";
            return (string)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string GetGSCurrencyString(TheGame.Currency.CurrencyType type)
        {
            var val_1;
            if(type <= 3)
            {
                    val_1 = mem[66464736 + (type) << 3];
                val_1 = 66464736 + (type) << 3;
                return (string)val_1;
            }
            
            val_1 = "";
            return (string)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static string GetPFCurrencyString(TheGame.Currency.CurrencyType type)
        {
            var val_1;
            if(type <= 3)
            {
                    val_1 = mem[66464704 + (type) << 3];
                val_1 = 66464704 + (type) << 3;
                return (string)val_1;
            }
            
            val_1 = "";
            return (string)val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static TheGame.Currency.CurrencyType GetTypeForString(string currencyString)
        {
            string val_7;
            string val_8;
            string val_9;
            string val_10;
            var val_11;
            string val_12;
            val_7 = currencyString;
            uint val_1 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_7);
            if(val_1 > 2013590992)
            {
                goto label_1;
            }
            
            if(val_1 > 569881281)
            {
                goto label_2;
            }
            
            if(val_1 == 107734685)
            {
                goto label_3;
            }
            
            if(val_1 != 569881281)
            {
                goto label_22;
            }
            
            val_8 = "FAZ_TOKENS";
            goto label_5;
            label_1:
            if(val_1 > (-2049741042))
            {
                goto label_6;
            }
            
            if(val_1 == (-2147155352))
            {
                goto label_7;
            }
            
            if(val_1 != (-2049741042))
            {
                goto label_22;
            }
            
            val_8 = "FC";
            label_5:
            if((System.String.op_Equality(a:  val_7, b:  val_8)) == false)
            {
                goto label_22;
            }
            
            goto label_10;
            label_2:
            if(val_1 == 805308234)
            {
                goto label_11;
            }
            
            if(val_1 != 2013590992)
            {
                goto label_22;
            }
            
            val_9 = "RE";
            goto label_13;
            label_6:
            if(val_1 == (-1244527034))
            {
                goto label_14;
            }
            
            if(val_1 != (-283434427))
            {
                goto label_22;
            }
            
            val_10 = "PARTS";
            goto label_16;
            label_3:
            val_9 = "ESSENCE";
            label_13:
            if((System.String.op_Equality(a:  val_7, b:  val_9)) == false)
            {
                goto label_22;
            }
            
            val_11 = 2;
            return (CurrencyType)val_11;
            label_7:
            val_12 = "RM";
            goto label_19;
            label_11:
            val_10 = "PA";
            label_16:
            if((System.String.op_Equality(a:  val_7, b:  val_10)) == false)
            {
                goto label_22;
            }
            
            val_11 = 1;
            return (CurrencyType)val_11;
            label_14:
            val_12 = "REAL_MONEY";
            label_19:
            if((System.String.op_Equality(a:  val_7, b:  val_12)) != false)
            {
                    val_11 = 3;
                return (CurrencyType)val_11;
            }
            
            label_22:
            val_7 = "No currency corresponding to " + val_7;
            ConsoleLogger.LogError(className:  "Currency", functionName:  "GetTypeForString", logString:  val_7);
            label_10:
            val_11 = 0;
            return (CurrencyType)val_11;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Currency()
        {
        
        }
    
    }

}
