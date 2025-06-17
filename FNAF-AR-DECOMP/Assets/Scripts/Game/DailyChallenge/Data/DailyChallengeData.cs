using UnityEngine;

namespace Game.DailyChallenge.Data
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengeData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Id;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Name;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Description;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string Type;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SubType;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ActionIconRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string SubTypeIconRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string ChallengeArtIconRef;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int CurrentCompletion;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public int MaxCompletion;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeData(ProtoData.DAILY_CHALLENGE_DATA.Types.ENTRY data)
        {
            var val_15;
            var val_16;
            this.Id = data.Logical;
            if(data != null)
            {
                    string val_2 = data.DailyChallengeNameLocRef;
                this.Name = (val_2 == null) ? "" : (val_2);
                string val_4 = data.DailyChallengeDescriptionLocRef;
                this.Description = (val_4 == null) ? "" : (val_4);
                string val_6 = data.DailyChallengeArtLocRef;
            }
            else
            {
                    val_15 = 0;
                this.Name = "";
                this.Description = "";
            }
            
            this.ChallengeArtIconRef = (val_15 == 0) ? "" : (val_15);
            if(data != null)
            {
                    this.Type = data.ActionType;
            }
            else
            {
                    this.Type = 0.ActionType;
            }
            
            this.SubType = data.SubType;
            this.CurrentCompletion = 0;
            this.MaxCompletion = 0;
            if(data != null)
            {
                    string val_11 = data.ActionIconRef;
                this.ActionIconRef = (val_11 == null) ? "" : (val_11);
                string val_13 = data.SubTypeIconRef;
            }
            else
            {
                    val_16 = 0;
                this.ActionIconRef = "";
            }
            
            this.SubTypeIconRef = (val_16 == 0) ? "" : (val_16);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeData(Game.DailyChallenge.Data.DailyChallengeData orig)
        {
            if(orig != null)
            {
                    this.Id = orig.Id;
                this.LocalizeStrings(name:  orig.Name, description:  orig.Description);
                this.Type = orig.Type;
                this.SubType = orig.SubType;
                this.ActionIconRef = orig.ActionIconRef;
            }
            else
            {
                    this.Id = 11993091;
                this.LocalizeStrings(name:  15026800, description:  64);
                this.Type = 69077560;
                this.SubType = 0;
                this.ActionIconRef = 4194311;
            }
            
            this.CurrentCompletion = 0;
            this.MaxCompletion = 0;
            this.SubTypeIconRef = orig.SubTypeIconRef;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool IsComplete()
        {
            if(this.MaxCompletion < 1)
            {
                    return false;
            }
            
            return (bool)(this.CurrentCompletion >= this.MaxCompletion) ? 1 : 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void UpdateCompletion(int currentCompletion, int maxCompletion)
        {
            this.CurrentCompletion = currentCompletion;
            this.MaxCompletion = maxCompletion;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LocalizeStrings(string name, string description)
        {
            var val_11;
            var val_12;
            var val_13;
            Game.Localization.ILocalization val_15;
            var val_16;
            string val_14 = description;
            string val_12 = name;
            val_11 = this;
            if(Game.Localization.LocalizationDomain.Instance == null)
            {
                goto label_1;
            }
            
            var val_2 = (val_1.ILocalization == 0) ? 0 : (val_11);
            if(val_1.ILocalization == null)
            {
                goto label_2;
            }
            
            string val_3 = (val_12 != null) ? (val_12) : "";
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_6;
            label_2:
            val_12 = 0;
            label_1:
            val_13 = val_11;
            goto label_7;
            label_6:
            val_12 = val_1.ILocalization;
            string val_5 = val_12.GetLocalizedString(localizedStringId:  val_3, originalString:  val_3);
            label_7:
            val_12 = (val_5 == null) ? (val_12) : (val_5);
            mem2[0] = val_12;
            if(Game.Localization.LocalizationDomain.Instance == null)
            {
                goto label_15;
            }
            
            val_15 = val_6.ILocalization;
            if(val_15 == null)
            {
                goto label_10;
            }
            
            string val_8 = (val_14 != null) ? (val_14) : "";
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_14;
            label_10:
            val_16 = 0;
            goto label_15;
            label_14:
            val_16 = val_15;
            string val_10 = val_16.GetLocalizedString(localizedStringId:  val_8, originalString:  val_8);
            val_11 = (val_15 == 0) ? 0 : (val_11);
            label_15:
            val_14 = (val_10 == null) ? (val_14) : (val_10);
            mem2[0] = val_14;
        }
    
    }

}
