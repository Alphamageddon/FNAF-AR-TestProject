using UnityEngine;

namespace Game.AttackSequence.Static
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class StaticConfigs
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static readonly Game.AttackSequence.Static.StaticConfig NullConfig;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly System.Collections.Generic.Dictionary<string, Game.AttackSequence.Static.StaticConfig> _staticConfigs;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AttackSequence.Static.StaticConfig GetStaticConfig(string profileId)
        {
            string val_3;
            Game.AttackSequence.Static.StaticConfig val_4;
            var val_5;
            val_3 = profileId;
            if((this._staticConfigs.ContainsKey(key:  val_3)) != false)
            {
                    Game.AttackSequence.Static.StaticConfig val_2 = this._staticConfigs.Item[val_3];
                return val_4;
            }
            
            val_3 = 1152921505276493824;
            val_5 = null;
            val_5 = null;
            val_4 = Game.AttackSequence.Static.StaticConfigs.NullConfig;
            return val_4;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public StaticConfigs(Game.MasterData.MasterDataDomain masterDataDomain)
        {
            this._staticConfigs = new System.Collections.Generic.Dictionary<System.String, Game.AttackSequence.Static.StaticConfig>();
            masterDataDomain.GetAccessToData.GetStaticDataAsync(returnStaticDataCallback:  new GetAccessToData.ReturnAnyData<ProtoData.STATIC_DATA>(object:  this, method:  System.Void Game.AttackSequence.Static.StaticConfigs::StaticDataReady(ProtoData.STATIC_DATA staticData)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void StaticDataReady(ProtoData.STATIC_DATA staticData)
        {
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_30;
            val_25 = staticData;
            if(val_25 == null)
            {
                    return;
            }
            
            val_26 = 1152921504689487872;
            val_27 = 1152921505276174336;
            val_25 = val_25.Entries.GetEnumerator();
            label_19:
            var val_26 = 0;
            val_26 = val_26 + 1;
            if(val_25.MoveNext() == false)
            {
                goto label_8;
            }
            
            var val_27 = 0;
            val_27 = val_27 + 1;
            T val_6 = val_25.Current;
            if(((val_6 == 0) || ((System.String.IsNullOrWhiteSpace(value:  val_6.Profile)) == true)) || ((this._staticConfigs.ContainsKey(key:  val_6.Profile)) == true))
            {
                goto label_19;
            }
            
            new Game.AttackSequence.Static.StaticConfig() = new Game.AttackSequence.Static.StaticConfig(entry:  val_6);
            this._staticConfigs.Add(key:  val_6.Profile, value:  new Game.AttackSequence.Static.StaticConfig());
            goto label_19;
            label_8:
            val_30 = 0;
            val_24 = 105;
            if(val_25 == null)
            {
                
            }
            else
            {
                    var val_28 = 0;
                val_28 = val_28 + 1;
                val_25.Dispose();
            }
            
            if( == 105)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
            
            val_25 = ???;
            val_24 = ???;
            val_26 = ???;
            val_27 = ???;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static StaticConfigs()
        {
            Game.AttackSequence.Static.StaticConfigs.NullConfig = new Game.AttackSequence.Static.StaticConfig(entry:  0);
        }
    
    }

}
