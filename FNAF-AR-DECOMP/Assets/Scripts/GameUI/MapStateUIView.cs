using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class MapStateUIView : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.MapStateUIActions _mapStateUIActions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SequentialRewardsDialog _sequentialRewardsDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Map _dialogHandler_Map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private MapMode.MapInputController _inputController;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.MapMode.PlayerTarget _playerTarget;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SequentialRewardsDisplayHandler _sequentialRewardsDisplayHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Game.AssetManagement.Icons.IIconLookup iconLookup;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdateProfileIcon()
        {
            UnityEngine.Sprite val_4;
            GameUI.Domain val_1 = this._masterDomain.gameUIDomain;
            if((val_1.profileAvatarConfigs.Find(match:  new System.Predicate<GameUI.ProfileAvatarSet>(object:  this, method:  System.Boolean GameUI.MapStateUIView::<UpdateProfileIcon>b__8_0(GameUI.ProfileAvatarSet x)))) != null)
            {
                    val_4 = val_3.sprite;
            }
            else
            {
                    val_4 = 0;
            }
            
            this._playerTarget.SetProfileIcon(icon:  val_4);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnAnimatronicSelected(MapMode.GeoPositionObject.MapAnimatronic animatronic)
        {
            this._mapStateUIActions.AnimatronicSelected(animatronic:  animatronic);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void UpdatePlayerFX()
        {
            this._playerTarget.ShowRadioJammer(show:  (this._masterDomain.devicesDomain.AllPlayerDevices.active.Jammer.Count > 0) ? 1 : 0);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMapSceneLookupTableLoaded(MapSceneLookupTable table)
        {
            System.Action<MapMode.GeoPositionObject.MapAnimatronic> val_7;
            if(table != null)
            {
                    this._playerTarget = table.PlayerTarget;
            }
            else
            {
                    this._playerTarget = 0.PlayerTarget;
            }
            
            MapMode.MapInputController val_3 = table.MapInputController;
            this._inputController = val_3;
            val_7 = System.Delegate.Combine(a:  val_3.AnimatronicTapped, b:  new System.Action<MapMode.GeoPositionObject.MapAnimatronic>(object:  this, method:  System.Void GameUI.MapStateUIView::OnAnimatronicSelected(MapMode.GeoPositionObject.MapAnimatronic animatronic)));
            if(val_3 == null)
            {
                goto label_4;
            }
            
            if(val_7 != null)
            {
                goto label_5;
            }
            
            goto label_8;
            label_4:
            if(val_7 == null)
            {
                goto label_8;
            }
            
            label_5:
            if(null != null)
            {
                    val_7 = 0;
            }
            
            label_8:
            val_3.AnimatronicTapped = val_7;
            this.UpdateProfileIcon();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GetAsync(Game.AssetManagement.Icons.IIconLookup obj)
        {
            this.iconLookup = obj;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            this._masterDomain = Master.MasterDomain.GetDomain();
            val_1.GameAssetManagementDomain.IconLookupAccess.GetInterfaceAsync(callback:  new System.Action<Game.AssetManagement.Icons.IIconLookup>(object:  this, method:  System.Void GameUI.MapStateUIView::GetAsync(Game.AssetManagement.Icons.IIconLookup obj)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            GameUI.SequentialRewardsDialog val_14;
            System.Action val_15;
            GameUI.SequentialRewardsDisplayData val_1 = new GameUI.SequentialRewardsDisplayData();
            if(val_1 != null)
            {
                    .dialogHandler_Map = this._dialogHandler_Map;
                val_14 = this._sequentialRewardsDialog;
            }
            else
            {
                    mem[16] = this._dialogHandler_Map;
                val_14 = this._sequentialRewardsDialog;
            }
            
            .sequentialRewardsDialog = val_14;
            GameUI.Domain val_2 = this._masterDomain.gameUIDomain;
            .sequentialRewardDataModel = 16;
            .eventExposer = this._masterDomain.eventExposer;
            .sequentialRewardRequester = this._masterDomain.serverDomain.sequentialRewardRequester;
            .iconLookup = this.iconLookup;
            .itemDefinitions = this._masterDomain.ItemDefinitionDomain.ItemDefinitions;
            GameUI.Domain val_4 = this._masterDomain.gameUIDomain;
            .serverGameUIDataModel = this.iconLookup;
            .gameDisplayChanger = this._masterDomain.theGameDomain.gameDisplayChanger;
            this._sequentialRewardsDisplayHandler = new GameUI.SequentialRewardsDisplayHandler(sequentialRewardsDisplayData:  val_1);
            this._masterDomain.SceneLookupTableAccess.GetMapSceneLookupTableAsync(returnMapSceneLookupTableCallback:  new SceneLookupTableAccess.ReturnMapSceneLookupTable(object:  this, method:  System.Void GameUI.MapStateUIView::OnMapSceneLookupTableLoaded(MapSceneLookupTable table)));
            this._masterDomain.eventExposer.add_PlayerAvatarUpdated(value:  new System.Action(object:  this, method:  System.Void GameUI.MapStateUIView::UpdateProfileIcon()));
            val_15 = System.Delegate.Combine(a:  this._masterDomain.devicesDomain.AllPlayerDevices.OnDataUpdated, b:  new System.Action(object:  this, method:  System.Void GameUI.MapStateUIView::UpdatePlayerFX()));
            if(this._masterDomain.devicesDomain.AllPlayerDevices == null)
            {
                goto label_21;
            }
            
            if(val_15 != null)
            {
                goto label_22;
            }
            
            goto label_25;
            label_21:
            if(val_15 == null)
            {
                goto label_25;
            }
            
            label_22:
            if(null != null)
            {
                    val_15 = 0;
            }
            
            label_25:
            this._masterDomain.devicesDomain.AllPlayerDevices.OnDataUpdated = val_15;
            this._masterDomain.serverDomain.dailyChallengeDataRequester.RequestDailyChallenges();
            this.UpdatePlayerFX();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Update()
        {
            this._sequentialRewardsDisplayHandler.Update();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDestroy()
        {
            System.Action val_7;
            System.Action<MapMode.GeoPositionObject.MapAnimatronic> val_8;
            if((this._masterDomain != null) && (this._masterDomain.eventExposer != null))
            {
                    this._masterDomain.eventExposer.remove_PlayerAvatarUpdated(value:  new System.Action(object:  this, method:  System.Void GameUI.MapStateUIView::UpdateProfileIcon()));
            }
            
            this._sequentialRewardsDisplayHandler.OnDestroy();
            val_7 = System.Delegate.Remove(source:  this._masterDomain.devicesDomain.AllPlayerDevices.OnDataUpdated, value:  new System.Action(object:  this, method:  System.Void GameUI.MapStateUIView::UpdatePlayerFX()));
            if(this._masterDomain.devicesDomain.AllPlayerDevices == null)
            {
                goto label_7;
            }
            
            if(val_7 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_7 == null)
            {
                goto label_11;
            }
            
            label_8:
            if(null != null)
            {
                    val_7 = 0;
            }
            
            label_11:
            this._masterDomain.devicesDomain.AllPlayerDevices.OnDataUpdated = val_7;
            val_8 = System.Delegate.Remove(source:  this._inputController.AnimatronicTapped, value:  new System.Action<MapMode.GeoPositionObject.MapAnimatronic>(object:  this, method:  System.Void GameUI.MapStateUIView::OnAnimatronicSelected(MapMode.GeoPositionObject.MapAnimatronic animatronic)));
            if(this._inputController == null)
            {
                goto label_13;
            }
            
            if(val_8 != null)
            {
                goto label_14;
            }
            
            goto label_17;
            label_13:
            if(val_8 == null)
            {
                goto label_17;
            }
            
            label_14:
            if(null != null)
            {
                    val_8 = 0;
            }
            
            label_17:
            this._inputController.AnimatronicTapped = val_8;
            this._masterDomain = 0;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public MapStateUIView()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool <UpdateProfileIcon>b__8_0(GameUI.ProfileAvatarSet x)
        {
            Server.LoginDomain val_2 = this._masterDomain.theGameDomain.loginDomain;
            if(val_2.playerProfile != null)
            {
                    return System.String.op_Equality(a:  x.id, b:  val_2.playerProfile.avatarId);
            }
            
            return System.String.op_Equality(a:  x.id, b:  val_2.playerProfile.avatarId);
        }
    
    }

}
