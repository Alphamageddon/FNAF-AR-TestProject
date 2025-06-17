using UnityEngine;

namespace Alerts.Server
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static class PlayerAlertDataGenerator
    {
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public static Alerts.Data.PlayerAlertData GeneratePlayerAlertData(Systems.Server.ServerData data)
        {
            System.Collections.Generic.HashSet<System.String> val_2 = Alerts.Server.PlayerAlertDataGenerator.GenerateFiredAlerts(firedAlerts:  data.GetStringList(key:  "firedAlerts"));
            System.Collections.Generic.HashSet<System.String> val_4 = Alerts.Server.PlayerAlertDataGenerator.GenerateNonRepeatableAlerts(nonRepeatableAlerts:  data.GetStringList(key:  "nonRepeatableAlerts"));
            Alerts.Data.PlayerAlertData val_7 = new Alerts.Data.PlayerAlertData();
            if(val_7 != null)
            {
                    .firedAlerts = val_2;
                .nonRepeatableAlerts = val_4;
            }
            else
            {
                    mem[16] = val_2;
                mem[24] = val_4;
            }
            
            .cooldownTimers = Alerts.Server.PlayerAlertDataGenerator.GenerateCooldownTimers(cooldownTimers:  data.GetServerDataList(key:  "cooldownTimers"));
            return val_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<string> GenerateFiredAlerts(System.Collections.Generic.List<string> firedAlerts)
        {
            System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
            int val_2 = firedAlerts.Count;
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            var val_5 = 0;
            do
            {
                bool val_4 = val_1.Add(item:  firedAlerts.Item[0]);
                val_5 = val_5 + 1;
            }
            while(val_2 != val_5);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.HashSet<string> GenerateNonRepeatableAlerts(System.Collections.Generic.List<string> nonRepeatableAlerts)
        {
            System.Collections.Generic.HashSet<System.String> val_1 = new System.Collections.Generic.HashSet<System.String>();
            int val_2 = nonRepeatableAlerts.Count;
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            var val_5 = 0;
            do
            {
                bool val_4 = val_1.Add(item:  nonRepeatableAlerts.Item[0]);
                val_5 = val_5 + 1;
            }
            while(val_2 != val_5);
            
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static System.Collections.Generic.Dictionary<string, long> GenerateCooldownTimers(System.Collections.Generic.List<Systems.Server.ServerData> cooldownTimers)
        {
            string val_7;
            System.Collections.Generic.Dictionary<System.String, System.Int64> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int64>();
            int val_2 = cooldownTimers.Count;
            if(val_2 < 1)
            {
                    return val_1;
            }
            
            var val_7 = 0;
            do
            {
                Systems.Server.ServerData val_3 = cooldownTimers.Item[0];
                if(val_3 != null)
            {
                    val_7 = val_3.GetString(key:  "alertId");
            }
            else
            {
                    val_7 = val_3.GetString(key:  "alertId");
            }
            
                System.Nullable<System.Int64> val_6 = val_3.GetLong(key:  "cooldown");
                val_1.Add(key:  val_7, value:  null);
                val_7 = val_7 + 1;
            }
            while(val_2 != val_7);
            
            return val_1;
        }
    
    }

}
