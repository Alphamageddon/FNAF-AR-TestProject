using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class Domain : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.MasterDomain masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string stunWeaponReadyText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string stunWeaponDepletedText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string stunWeaponRechargeTextPrefix;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.List<GameUI.ProfileAvatarSet> profileAvatarConfigs;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private readonly float collectionTotalTime;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopStageView <WorkshopStage>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.GameUIData gameUIData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.RewardCollectorView rewardCollector;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AppRestart.AppRestarter _appRestarter;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.WorkshopStageView WorkshopStage { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.WorkshopStageView get_WorkshopStage()
        {
            return (GameUI.WorkshopStageView)this.<WorkshopStage>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_WorkshopStage(GameUI.WorkshopStageView value)
        {
            this.<WorkshopStage>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetWorkshopLookupAsync(WorkshopSceneLookupTable workshopSceneLookupTable)
        {
            this.<WorkshopStage>k__BackingField = workshopSceneLookupTable.WorkshopStage;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void EventExposer_AttackSequenceReadyForUi(Game.AttackSequence.Encounters.EncounterResult obj)
        {
            this.UpdateEncounterResultData(obj:  obj);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void AddSubscriptions()
        {
            this.masterDomain.eventExposer.add_AttackSequenceReadyForUi(value:  new System.Action<Game.AttackSequence.Encounters.EncounterResult>(object:  this, method:  System.Void GameUI.Domain::EventExposer_AttackSequenceReadyForUi(Game.AttackSequence.Encounters.EncounterResult obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RemoveSubscriptions()
        {
            if(this.masterDomain.eventExposer == null)
            {
                    return;
            }
            
            this.masterDomain.eventExposer.remove_AttackSequenceReadyForUi(value:  new System.Action<Game.AttackSequence.Encounters.EncounterResult>(object:  this, method:  System.Void GameUI.Domain::EventExposer_AttackSequenceReadyForUi(Game.AttackSequence.Encounters.EncounterResult obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Initialize()
        {
            SceneLookupTableAccess.ReturnWorkshopSceneLookupTable val_2 = 1152921505163927552;
            val_2 = new SceneLookupTableAccess.ReturnWorkshopSceneLookupTable(object:  this, method:  System.Void GameUI.Domain::GetWorkshopLookupAsync(WorkshopSceneLookupTable workshopSceneLookupTable));
            this.masterDomain.SceneLookupTableAccess.GetWorkshopSceneLookupTableAsync(returnWorkshopSceneLookupTableCallback:  val_2);
            this.rewardCollector = new GameUI.RewardCollectorView(masterDomain:  this.masterDomain);
            GameUI.AppRestart.AppRestarter val_4 = new GameUI.AppRestart.AppRestarter();
            this._appRestarter = val_4;
            val_4.Setup(events:  this.masterDomain.eventExposer);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateEncounterResultData(Game.AttackSequence.Encounters.EncounterResult obj)
        {
            AnimatronicEntity.AnimatronicEntity val_2 = this.masterDomain.AnimatronicEntityDomain.container.GetEntity(entityId:  obj.EntityId);
            if(val_2 == null)
            {
                goto label_4;
            }
            
            if(this != null)
            {
                goto label_6;
            }
            
            label_7:
            label_6:
            this.SetEncounterResult(result:  obj, rewardDataV3:  val_2.rewardDataV3);
            return;
            label_4:
            if(this != null)
            {
                goto label_6;
            }
            
            goto label_7;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void CollectRewards()
        {
            this.rewardCollector.CollectRewards(collectionTime:  this.collectionTotalTime);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.Initialize();
            this.AddSubscriptions();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this.rewardCollector.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            this.RemoveSubscriptions();
            X20.OnDestroy();
            this._appRestarter.Teardown();
            this._appRestarter = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Domain()
        {
            this.collectionTotalTime = 1f;
        }
    
    }

}
