using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class SequentialRewardsDisplayData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.DialogHandler_Map dialogHandler_Map;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.SequentialRewardsDialog sequentialRewardsDialog;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.SequentialRewardDataModel sequentialRewardDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Master.EventExposer eventExposer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.ItemDefinition.Container.ItemDefinitions itemDefinitions;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.AssetManagement.Icons.IIconLookup iconLookup;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Game.Server.SequentialRewardRequester sequentialRewardRequester;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ServerGameUIDataModel serverGameUIDataModel;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TheGame.GameDisplayChanger gameDisplayChanger;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SequentialRewardsDisplayData()
        {
        
        }
    
    }

}
