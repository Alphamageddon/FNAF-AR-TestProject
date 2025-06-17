using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public struct GameUIData
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EmailUIDataHandler <emailUIDataHandler>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ServerGameUIDataModel <serverGameUIDataModel>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.WorkshopSlotDataModel <workshopSlotDataModel>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.PopDownDataModel <popDownDataModel>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ResultsDataModel <rewardDataModel>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.ButtonConfigs <buttonConfigs>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.IllumixButtonBlackBoard <illumixButtonBlackBoard>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.MainDisplayBlackboard <mainDisplayBlackboard>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string <storeSectionToScrollTo>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.GameUIMasterDataConnector <gameUIMasterDataConnector>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.FriendCodeModel <friendCodeModel>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.SequentialRewardDataModel <sequentialRewardDataModel>k__BackingField;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.FTUEUIBlackboard ftueUIBlackboard;
        
        // Properties
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.EmailUIDataHandler emailUIDataHandler { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ServerGameUIDataModel serverGameUIDataModel { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.WorkshopSlotDataModel workshopSlotDataModel { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.PopDownDataModel popDownDataModel { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ResultsDataModel rewardDataModel { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ButtonConfigs buttonConfigs { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.IllumixButtonBlackBoard illumixButtonBlackBoard { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.MainDisplayBlackboard mainDisplayBlackboard { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string storeSectionToScrollTo { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.GameUIMasterDataConnector gameUIMasterDataConnector { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.FriendCodeModel friendCodeModel { get; set; }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.SequentialRewardDataModel sequentialRewardDataModel { get; set; }
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_emailUIDataHandler(GameUI.EmailUIDataHandler value)
        {
            this.<workshopSlotDataModel>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.EmailUIDataHandler get_emailUIDataHandler()
        {
            return (GameUI.EmailUIDataHandler)this.<workshopSlotDataModel>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_serverGameUIDataModel(GameUI.ServerGameUIDataModel value)
        {
            this.<popDownDataModel>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ServerGameUIDataModel get_serverGameUIDataModel()
        {
            return (GameUI.ServerGameUIDataModel)this.<popDownDataModel>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_workshopSlotDataModel(GameUI.WorkshopSlotDataModel value)
        {
            this.<rewardDataModel>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.WorkshopSlotDataModel get_workshopSlotDataModel()
        {
            return (GameUI.WorkshopSlotDataModel)this.<rewardDataModel>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_popDownDataModel(GameUI.PopDownDataModel value)
        {
            this.<buttonConfigs>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.PopDownDataModel get_popDownDataModel()
        {
            return (GameUI.PopDownDataModel)this.<buttonConfigs>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_rewardDataModel(GameUI.ResultsDataModel value)
        {
            this.<illumixButtonBlackBoard>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ResultsDataModel get_rewardDataModel()
        {
            return (GameUI.ResultsDataModel)this.<illumixButtonBlackBoard>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_buttonConfigs(GameUI.ButtonConfigs value)
        {
            this.<mainDisplayBlackboard>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.ButtonConfigs get_buttonConfigs()
        {
            return (GameUI.ButtonConfigs)this.<mainDisplayBlackboard>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_illumixButtonBlackBoard(GameUI.IllumixButtonBlackBoard value)
        {
            this.<storeSectionToScrollTo>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.IllumixButtonBlackBoard get_illumixButtonBlackBoard()
        {
            return (GameUI.IllumixButtonBlackBoard)this.<storeSectionToScrollTo>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_mainDisplayBlackboard(GameUI.MainDisplayBlackboard value)
        {
            this.<gameUIMasterDataConnector>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.MainDisplayBlackboard get_mainDisplayBlackboard()
        {
            return (GameUI.MainDisplayBlackboard)this.<gameUIMasterDataConnector>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void set_storeSectionToScrollTo(string value)
        {
            this.<friendCodeModel>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string get_storeSectionToScrollTo()
        {
            return (string)this.<friendCodeModel>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_gameUIMasterDataConnector(GameUI.GameUIMasterDataConnector value)
        {
            this.<sequentialRewardDataModel>k__BackingField = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.GameUIMasterDataConnector get_gameUIMasterDataConnector()
        {
            return (GameUI.GameUIMasterDataConnector)this.<sequentialRewardDataModel>k__BackingField;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_friendCodeModel(GameUI.FriendCodeModel value)
        {
            this.ftueUIBlackboard = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.FriendCodeModel get_friendCodeModel()
        {
            return (GameUI.FriendCodeModel)this.ftueUIBlackboard;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void set_sequentialRewardDataModel(GameUI.SequentialRewardDataModel value)
        {
            mem[1152921524776672696] = value;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUI.SequentialRewardDataModel get_sequentialRewardDataModel()
        {
            return (GameUI.SequentialRewardDataModel)this;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GameUIData(Master.MasterDomain masterDomain)
        {
        
        }
    
    }

}
