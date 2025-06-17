using UnityEngine;

namespace Game.ItemDefinition.Data.DataDefinitions
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DeviceData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Description;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool Stackable;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int StreakToUnlock;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.DeviceData.DeviceCategory Type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.LureData LureData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.ExtraBatteryData ExtraBatteryData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.SuperShockerData SuperShockerData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.SalvageScannerData SalvageScannerData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Data.DataDefinitions.EMFData EMFData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double expirationTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int count;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int Order;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DeviceData(ProtoData.DEVICES_DATA.Types.ENTRY data)
        {
            int val_16;
            int val_17;
            DeviceData.<>c__DisplayClass15_0 val_1 = new DeviceData.<>c__DisplayClass15_0();
            .data = data;
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[24] = this;
            }
            
            this.Id = (DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data.DeviceLogical;
            GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  val_1, method:  System.Void DeviceData.<>c__DisplayClass15_0::<.ctor>b__0(Game.Localization.ILocalization localization)));
            this.Stackable = (DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data.MTX.Stackable;
            this.StreakToUnlock = (int)(DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data.MTX.MinStreak;
            if(((DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data) != null)
            {
                    val_16 = (int)(DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data.Order;
            }
            else
            {
                    val_16 = 0;
            }
            
            this.Order = val_16;
            if(((DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data) == null)
            {
                goto label_15;
            }
            
            EXPIRATION val_10 = (DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data.Expiration;
            if(val_10 == null)
            {
                goto label_15;
            }
            
            double val_11 = val_10.Seconds;
            goto label_16;
            label_15:
            label_16:
            this.expirationTime = 0.South;
            if(((DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data) == null)
            {
                goto label_19;
            }
            
            EXPIRATION val_13 = (DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data.Expiration;
            if(val_13 == null)
            {
                goto label_19;
            }
            
            double val_14 = val_13.Count;
            goto label_20;
            label_19:
            label_20:
            if(((-774691648) & 1) != 0)
            {
                    val_17 = (int)0.South;
            }
            else
            {
                    val_17 = 0;
            }
            
            this.count = val_17;
            this.LoadEffects(data:  (DeviceData.<>c__DisplayClass15_0)[1152921525307039968].data);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public double GetMaxTime()
        {
            DeviceCategory val_1 = this.Type;
            if(val_1 == 0)
            {
                    return (double)(double)this.LureData.SpawnMax;
            }
            
            val_1 = val_1 - 3;
            if(val_1 >= 4)
            {
                    return (double)(double)this.LureData.SpawnMax;
            }
            
            return (double)this.expirationTime;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadEffects(ProtoData.DEVICES_DATA.Types.ENTRY data)
        {
            DeviceCategory val_9;
            var val_10;
            Game.ItemDefinition.Data.DataDefinitions.ExtraBatteryData val_11;
            DeviceCategory val_12;
            Game.ItemDefinition.Data.DataDefinitions.SuperShockerData val_13;
            Game.ItemDefinition.Data.DataDefinitions.SalvageScannerData val_14;
            Game.ItemDefinition.Data.DataDefinitions.EMFData val_15;
            string val_2 = data.Effects.Type;
            DeviceCategory val_3 = val_2.GetTypeForString(type:  val_2);
            val_9 = val_3;
            this.Type = val_9;
            if(val_9 != 0)
            {
                    val_10 = 0;
            }
            else
            {
                    Game.ItemDefinition.Data.DataDefinitions.LureData val_4 = val_3.InitializeLureData(data:  data);
                val_9 = this.Type;
            }
            
            this.LureData = val_4;
            if(val_9 == 1)
            {
                    Game.ItemDefinition.Data.DataDefinitions.ExtraBatteryData val_5 = val_4.InitializeBatteryData(data:  data);
            }
            else
            {
                    val_11 = 0;
            }
            
            val_12 = this.Type;
            this.ExtraBatteryData = val_11;
            if(val_12 == 2)
            {
                    Game.ItemDefinition.Data.DataDefinitions.SuperShockerData val_6 = this.InitializeSuperShockerData(data:  data);
                val_12 = this.Type;
            }
            else
            {
                    val_13 = 0;
            }
            
            this.SuperShockerData = val_13;
            if(val_12 == 4)
            {
                    Game.ItemDefinition.Data.DataDefinitions.SalvageScannerData val_7 = this.InitializeSalvageScannerData(data:  data);
            }
            else
            {
                    val_14 = 0;
            }
            
            this.SalvageScannerData = val_14;
            if(this.Type == 6)
            {
                    Game.ItemDefinition.Data.DataDefinitions.EMFData val_8 = this.InitializeEMFData(data:  data);
            }
            else
            {
                    val_15 = 0;
            }
            
            this.EMFData = val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.LureData InitializeLureData(ProtoData.DEVICES_DATA.Types.ENTRY data)
        {
            var val_14;
            float val_15;
            float val_16;
            string val_17;
            Game.ItemDefinition.Data.DataDefinitions.LureData val_1 = null;
            val_14 = val_1;
            val_1 = new Game.ItemDefinition.Data.DataDefinitions.LureData();
            EFFECTS val_2 = data.Effects;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            LURE val_3 = val_2.Lure;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            double val_4 = val_3.Min;
            goto label_4;
            label_3:
            label_4:
            val_15 = 0f;
            if(((-774134464) & 1) != 0)
            {
                    val_15 = (float)0.South;
            }
            
            .SpawnMin = val_15;
            EFFECTS val_6 = data.Effects;
            if(val_6 == null)
            {
                goto label_9;
            }
            
            LURE val_7 = val_6.Lure;
            if(val_7 == null)
            {
                goto label_9;
            }
            
            double val_8 = val_7.Max;
            goto label_10;
            label_9:
            label_10:
            val_16 = 0f;
            if(((-774134464) & 1) != 0)
            {
                    val_16 = (float)0.South;
            }
            
            .SpawnMax = val_16;
            EFFECTS val_10 = data.Effects;
            if(val_10 == null)
            {
                goto label_14;
            }
            
            LURE val_11 = val_10.Lure;
            if(val_11 == null)
            {
                goto label_14;
            }
            
            string val_12 = val_11.AnimatronicLured;
            var val_13 = (val_12 == null) ? "" : (val_12);
            if(val_10 != null)
            {
                    if(val_14 != null)
            {
                goto label_17;
            }
            
            }
            
            val_14 = 0;
            goto label_17;
            label_14:
            val_17 = "";
            label_17:
            .AnimatronicLured = val_17;
            return (Game.ItemDefinition.Data.DataDefinitions.LureData)val_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.ExtraBatteryData InitializeBatteryData(ProtoData.DEVICES_DATA.Types.ENTRY data)
        {
            var val_14;
            float val_15;
            float val_16;
            Game.ItemDefinition.Data.DataDefinitions.ExtraBatteryData val_1 = null;
            val_14 = val_1;
            val_1 = new Game.ItemDefinition.Data.DataDefinitions.ExtraBatteryData();
            if(data == null)
            {
                goto label_3;
            }
            
            EFFECTS val_3 = data.Effects;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            EXTRABATTERY val_4 = val_3.ExtraBattery;
            if(val_4 == null)
            {
                goto label_3;
            }
            
            double val_5 = val_4.BatteryBonus;
            val_14 = (data == 0) ? 0 : (val_14);
            goto label_4;
            label_3:
            label_4:
            val_15 = 0f;
            if(((-773952832) & 1) != 0)
            {
                    val_15 = (float)0.South;
            }
            
            .Bonus = val_15;
            EFFECTS val_7 = data.Effects;
            if(val_7 == null)
            {
                goto label_9;
            }
            
            EXTRABATTERY val_8 = val_7.ExtraBattery;
            if(val_8 == null)
            {
                goto label_9;
            }
            
            double val_9 = val_8.BatteryActivate;
            goto label_10;
            label_9:
            label_10:
            val_16 = 0f;
            if(((-773952832) & 1) != 0)
            {
                    val_16 = (float)0.South;
            }
            
            .Activate = val_16;
            .Duration = (float)data.Effects.ExtraBattery.BatteryDur;
            return (Game.ItemDefinition.Data.DataDefinitions.ExtraBatteryData)val_14;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.SuperShockerData InitializeSuperShockerData(ProtoData.DEVICES_DATA.Types.ENTRY data)
        {
            float val_6;
            EFFECTS val_2 = data.Effects;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            SUPERSHOCKER val_3 = val_2.SuperShocker;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            double val_4 = val_3.SetRecharge;
            goto label_4;
            label_3:
            label_4:
            val_6 = 0f;
            if(((-773791680) & 1) != 0)
            {
                    val_6 = (float)0.South;
            }
            
            .SetRecharge = val_6;
            return (Game.ItemDefinition.Data.DataDefinitions.SuperShockerData)new Game.ItemDefinition.Data.DataDefinitions.SuperShockerData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.SalvageScannerData InitializeSalvageScannerData(ProtoData.DEVICES_DATA.Types.ENTRY data)
        {
            float val_14;
            float val_15;
            float val_16;
            EFFECTS val_2 = data.Effects;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            SALVAGESCANNER val_3 = val_2.SalvageScanner;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            double val_4 = val_3.PartsBonus;
            goto label_4;
            label_3:
            label_4:
            val_14 = 0f;
            if(((-773630528) & 1) != 0)
            {
                    val_14 = (float)0.South;
            }
            
            .PartsBonus = val_14;
            EFFECTS val_6 = data.Effects;
            if(val_6 == null)
            {
                goto label_9;
            }
            
            SALVAGESCANNER val_7 = val_6.SalvageScanner;
            if(val_7 == null)
            {
                goto label_9;
            }
            
            double val_8 = val_7.StuffBonus;
            goto label_10;
            label_9:
            label_10:
            val_15 = 0f;
            if(((-773630528) & 1) != 0)
            {
                    val_15 = (float)0.South;
            }
            
            .StuffBonus = val_15;
            EFFECTS val_10 = data.Effects;
            if(val_10 == null)
            {
                goto label_14;
            }
            
            SALVAGESCANNER val_11 = val_10.SalvageScanner;
            if(val_11 == null)
            {
                goto label_14;
            }
            
            double val_12 = val_11.MalfunctionBonus;
            goto label_15;
            label_14:
            label_15:
            val_16 = 0f;
            if(((-773630528) & 1) != 0)
            {
                    val_16 = (float)0.South;
            }
            
            .MalfunctionBonus = val_16;
            return (Game.ItemDefinition.Data.DataDefinitions.SalvageScannerData)new Game.ItemDefinition.Data.DataDefinitions.SalvageScannerData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.EMFData InitializeEMFData(ProtoData.DEVICES_DATA.Types.ENTRY data)
        {
            float val_6;
            EFFECTS val_2 = data.Effects;
            if(val_2 == null)
            {
                goto label_3;
            }
            
            EMFMETER val_3 = val_2.EMFMeter;
            if(val_3 == null)
            {
                goto label_3;
            }
            
            double val_4 = val_3.RarityBonus;
            goto label_4;
            label_3:
            label_4:
            val_6 = 0f;
            if(((-773469376) & 1) != 0)
            {
                    val_6 = (float)0.South;
            }
            
            .RarityBonus = val_6;
            return (Game.ItemDefinition.Data.DataDefinitions.EMFData)new Game.ItemDefinition.Data.DataDefinitions.EMFData();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.ItemDefinition.Data.DataDefinitions.DeviceData.DeviceCategory GetTypeForString(string type)
        {
            DeviceCategory val_1 = 0;
            bool val_2 = System.Enum.TryParse<DeviceCategory>(value:  type, result: out  val_1);
            return val_1;
        }
    
    }

}
