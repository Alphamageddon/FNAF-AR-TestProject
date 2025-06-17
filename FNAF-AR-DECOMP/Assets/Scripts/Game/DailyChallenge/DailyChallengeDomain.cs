using UnityEngine;

namespace Game.DailyChallenge
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class DailyChallengeDomain : AsyncInterfaceAccess<Game.DailyChallenge.IDailyChallengeDomain>, IDailyChallengeDomain
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.EventExposer _eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.Server.ServerDomain _serverDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.DailyChallenge.Data.MasterDataConnector _masterDataConnector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Purchasing.IExtensionProvider extensions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.DailyChallenge.DailyChallengeDomainSROptions _debugOptions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly Game.DailyChallenge.Container.DailyChallengeContainer <DailyChallengeContainer>k__BackingField;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.DailyChallenge.Container.DailyChallengeContainer DailyChallengeContainer { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool IsReady { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.DailyChallenge.IDailyChallengeDomain GetPublicInterface { get; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.DailyChallenge.Container.DailyChallengeContainer get_DailyChallengeContainer()
        {
            return (Game.DailyChallenge.Container.DailyChallengeContainer)this.<DailyChallengeContainer>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override bool get_IsReady()
        {
            Game.DailyChallenge.Data.MasterDataConnector val_2;
            var val_3;
            val_2 = this;
            if((this._masterDataConnector.<HasRewardsDataLoaded>k__BackingField) != false)
            {
                    val_2 = this._masterDataConnector;
                var val_1 = ((this._masterDataConnector.<HasChallengeDataLoaded>k__BackingField) == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        protected override Game.DailyChallenge.IDailyChallengeDomain get_GetPublicInterface()
        {
            return (Game.DailyChallenge.IDailyChallengeDomain)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public DailyChallengeDomain(Game.MasterData.MasterDataDomain masterDataDomain, Game.Server.ServerDomain serverDomain, Master.EventExposer exposer)
        {
            this._eventExposer = exposer;
            this._serverDomain = serverDomain;
            Game.DailyChallenge.Container.DailyChallengeContainer val_1 = new Game.DailyChallenge.Container.DailyChallengeContainer(eventExposer:  exposer);
            this.<DailyChallengeContainer>k__BackingField = val_1;
            this._masterDataConnector = new Game.DailyChallenge.Data.MasterDataConnector(masterDataDomain:  masterDataDomain, dailyChallengeContainer:  val_1, callback:  new System.Action(object:  this, method:  System.Void Utilities.AsyncInterfaceAccess<Game.DailyChallenge.IDailyChallengeDomain>::TryToDispatchPublicInterface()));
            Game.DailyChallenge.DailyChallengeDomainSROptions val_4 = new Game.DailyChallenge.DailyChallengeDomainSROptions();
            ._dailyChallengeDomain = this;
            this._debugOptions = val_4;
            DevTools.Runtime.DebugMenu.ShowHideSROptions.RegisterMenuSection(sectionName:  "Daily Challenge", sectionMenuObject:  val_4, defaultToOn:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CompleteDailyChallenges()
        {
            this._serverDomain.debugCompleteDailyChallengeRequester.CompleteDailyChallenges();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void RefreshDailyChallenges()
        {
            this._serverDomain.debugDailyChallengeForceRefresh.RefreshDailyChallenges();
        }
    
    }

}
