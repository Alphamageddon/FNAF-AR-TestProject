using UnityEngine;

namespace GameAnalyticsSDK.Setup
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Studio
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <Name>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <ID>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<GameAnalyticsSDK.Setup.Game> <Games>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ID { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameAnalyticsSDK.Setup.Game> Games { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_Name()
        {
            return (string)this.<Name>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_ID()
        {
            return (string)this.<ID>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_ID(string value)
        {
            this.<ID>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameAnalyticsSDK.Setup.Game> get_Games()
        {
            return (System.Collections.Generic.List<GameAnalyticsSDK.Setup.Game>)this.<Games>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_Games(System.Collections.Generic.List<GameAnalyticsSDK.Setup.Game> value)
        {
            this.<Games>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Studio(string name, string id, System.Collections.Generic.List<GameAnalyticsSDK.Setup.Game> games)
        {
            val_1 = new System.Object();
            this.<Name>k__BackingField = name;
            this.<ID>k__BackingField = val_1;
            this.<Games>k__BackingField = games;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string[] GetStudioNames(System.Collections.Generic.List<GameAnalyticsSDK.Setup.Studio> studios, bool addFirstEmpty = True)
        {
            string val_16;
            var val_17;
            var val_18;
            string val_19;
            if(studios == null)
            {
                goto label_1;
            }
            
            if(addFirstEmpty == false)
            {
                goto label_2;
            }
            
            int val_2 = studios.Count + 1;
            val_17 = new string[0];
            val_17[0] = "-";
            val_16 = "";
            if(studios.Count < 1)
            {
                    return (System.String[])val_17;
            }
            
            val_18 = 1152921526134241040;
            var val_16 = 0;
            do
            {
                GameAnalyticsSDK.Setup.Studio val_5 = studios.Item[0];
                val_19 = val_5.<Name>k__BackingField(val_5.<Name>k__BackingField) + val_16;
                val_16 = val_16 + 1;
                val_17[(long)val_16] = val_19;
                val_16 = val_16 + " ";
            }
            while(val_16 < studios.Count);
            
            return (System.String[])val_17;
            label_1:
            val_17 = new string[1];
            val_17[0] = "-";
            return (System.String[])val_17;
            label_2:
            val_17 = new string[0];
            val_16 = "";
            if(studios.Count < 1)
            {
                    return (System.String[])val_17;
            }
            
            val_18 = 1152921526134241040;
            var val_17 = 0;
            label_27:
            GameAnalyticsSDK.Setup.Studio val_12 = studios.Item[0];
            val_19 = val_12.<Name>k__BackingField(val_12.<Name>k__BackingField) + val_16;
            if(val_17 == null)
            {
                goto label_21;
            }
            
            if(val_19 != null)
            {
                goto label_22;
            }
            
            goto label_25;
            label_21:
            if(val_19 == null)
            {
                goto label_25;
            }
            
            label_22:
            label_25:
            val_17[0] = val_19;
            val_16 = val_16 + " ";
            val_17 = val_17 + 1;
            if(val_17 < studios.Count)
            {
                goto label_27;
            }
            
            return (System.String[])val_17;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static string[] GetGameNames(int index, System.Collections.Generic.List<GameAnalyticsSDK.Setup.Studio> studios)
        {
            string val_13;
            var val_14;
            var val_15;
            val_13 = studios;
            if(val_13 == null)
            {
                goto label_3;
            }
            
            GameAnalyticsSDK.Setup.Studio val_1 = val_13.Item[index];
            if((val_1.<Games>k__BackingField) == null)
            {
                goto label_3;
            }
            
            GameAnalyticsSDK.Setup.Studio val_2 = val_13.Item[index];
            int val_4 = (val_2.<Games>k__BackingField.Count) + 1;
            val_14 = new string[0];
            val_14[0] = "-";
            val_15 = 1;
            goto label_10;
            label_19:
            GameAnalyticsSDK.Setup.Studio val_6 = val_13.Item[index];
            GameAnalyticsSDK.Setup.Game val_7 = val_6.<Games>k__BackingField.Item[W23];
            val_14[1] = val_7.<Name>k__BackingField(val_7.<Name>k__BackingField) + "";
            string val_9 = "" + " ";
            val_15 = 2;
            label_10:
            GameAnalyticsSDK.Setup.Studio val_10 = val_13.Item[index];
            if((val_15 - 1) < (val_10.<Games>k__BackingField.Count))
            {
                goto label_19;
            }
            
            return (System.String[])val_14;
            label_3:
            val_14 = new string[1];
            val_13 = "-";
            val_14[0] = val_13;
            return (System.String[])val_14;
        }
    
    }

}
