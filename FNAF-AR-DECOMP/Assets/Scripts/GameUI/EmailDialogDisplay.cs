using UnityEngine;

namespace GameUI
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class EmailDialogDisplay : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.DialogHandler_Inbox dialogHandler_Inbox;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI toText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI fromText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI subjectText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI dateTimeText;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AttachmentRewardCell attachmentRewardCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AttachmentAudioCell attachmentAudioCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.AttachmentImageCell attachmentImageCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshProUGUI attachmentBodyCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform emailMessageParent;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform senderAndSubjectReference;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private Master.MasterDomain _masterDomain;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.EmailData emailData;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private GameUI.RewardV3Translator _rewardV3Translator;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.GameObject attachmentLinkToStoreCellPrefab;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int _backButtonId;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void RefreshDisplay()
        {
            this.ClearEmail();
            if(this.HasLinkToStore() != false)
            {
                    this.LoadLinkToStoreAsset(loadCompleteAction:  new System.Action(object:  this, method:  System.Void GameUI.EmailDialogDisplay::ConstructEmailHeaderAndCells()));
                return;
            }
            
            this.ConstructEmailHeaderAndCells();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ClearEmail()
        {
            var val_13;
            var val_14;
            this.toText.text = System.String.alignConst;
            this.fromText.text = System.String.alignConst;
            this.subjectText.text = System.String.alignConst;
            this.dateTimeText.text = System.String.alignConst;
            this.attachmentLinkToStoreCellPrefab = 0;
            System.Collections.IEnumerator val_1 = this.emailMessageParent.GetEnumerator();
            goto label_24;
            label_31:
            var val_13 = 0;
            val_13 = val_13 + 1;
            object val_3 = val_1.Current;
            if(0.gameObject != 0)
            {
                    if(0 != this.senderAndSubjectReference)
            {
                    UnityEngine.Object.Destroy(obj:  0.gameObject);
            }
            
            }
            
            label_24:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_1.MoveNext() == true)
            {
                goto label_31;
            }
            
            val_13 = 0;
            val_14 = 163;
            if(val_1 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_1.Dispose();
            }
            
            if( == 163)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private bool HasLinkToStore()
        {
            GameUI.EmailData val_4;
            var val_5;
            val_4 = this;
            if((System.String.IsNullOrEmpty(value:  this.emailData.templateBundle)) != false)
            {
                    val_5 = 0;
            }
            else
            {
                    val_4 = this.emailData;
                bool val_2 = System.String.IsNullOrEmpty(value:  this.emailData.templatePrefab);
                val_5 = val_2 ^ 1;
            }
            
            val_2 = val_5;
            return (bool)val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void LoadLinkToStoreAsset(System.Action loadCompleteAction)
        {
            EmailDialogDisplay.<>c__DisplayClass19_0 val_1 = new EmailDialogDisplay.<>c__DisplayClass19_0();
            if(val_1 != null)
            {
                    .<>4__this = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .loadCompleteAction = loadCompleteAction;
            .assetName = this.emailData.templatePrefab;
            .assetBundleName = this.emailData.templateBundle;
            Master.MasterDomain val_2 = Master.MasterDomain.GetDomain();
            val_2.GameAssetManagementDomain.AssetCacheAccess.GetInterfaceAsync(callback:  new System.Action<Systems.AssetManagement.Assets.IAssetCache>(object:  val_1, method:  System.Void EmailDialogDisplay.<>c__DisplayClass19_0::<LoadLinkToStoreAsset>b__0(Systems.AssetManagement.Assets.IAssetCache assetCache)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void ConstructEmailHeaderAndCells()
        {
            this.GenerateHeader();
            this.GenerateLinkToStoreCell();
            this.GenerateImageCell();
            this.GenerateBodyText();
            this.GenerateAudioCell();
            this.GenerateRewardsCells();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateHeader()
        {
            Game.Localization.LocalizationDomain.Instance.Localization.GetInterfaceAsync(callback:  new System.Action<Game.Localization.ILocalization>(object:  this, method:  System.Void GameUI.EmailDialogDisplay::<GenerateHeader>b__21_0(Game.Localization.ILocalization localization)));
            this.dateTimeText.text = this.emailData.GetTimeStamp();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateRewardsCells()
        {
            var val_5;
            GameUI.RewardV3Translator val_33;
            var val_34;
            var val_35;
            val_33 = this._rewardV3Translator;
            if(val_33 == null)
            {
                    GameUI.RewardV3Translator val_1 = null;
                val_33 = val_1;
                val_1 = new GameUI.RewardV3Translator(masterDomain:  this._masterDomain);
                this._rewardV3Translator = val_33;
            }
            
            val_34 = val_1.GetCPUCellDescriptions(rewardDataV3:  this.emailData.rewardDataV3);
            List.Enumerator<T> val_3 = val_34.GetEnumerator();
            label_6:
            if(((-1350169232) & 1) == 0)
            {
                goto label_5;
            }
            
            this.GenerateRewardsCell(itemUiDescription:  val_5.emailUIDataHandler);
            goto label_6;
            label_5:
            long val_7 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524731514224});
            List.Enumerator<T> val_10 = this._rewardV3Translator.GetPlushSuitCellDescriptions(rewardDataV3:  this.emailData.rewardDataV3).GetEnumerator();
            label_15:
            if(((-1350169232) & 1) == 0)
            {
                goto label_14;
            }
            
            this.GenerateRewardsCell(itemUiDescription:  val_5.emailUIDataHandler);
            goto label_15;
            label_14:
            val_35 = 0;
            long val_12 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524731514224});
            if(((165 == 0) ? 165 : 165) == 165)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_35 = 0;
            }
            
            }
            
            List.Enumerator<T> val_15 = this._rewardV3Translator.GetModCellDescriptions(rewardDataV3:  this.emailData.rewardDataV3).GetEnumerator();
            label_26:
            if(((-1350169232) & 1) == 0)
            {
                goto label_27;
            }
            
            this.GenerateRewardsCell(itemUiDescription:  val_5.emailUIDataHandler);
            goto label_26;
            label_27:
            long val_17 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524731514224});
            if(((235 == 0) ? 235 : 235) == 235)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_35 = 0;
            }
            
            }
            
            List.Enumerator<T> val_20 = this._rewardV3Translator.GetCoinDescriptions(rewardDataV3:  this.emailData.rewardDataV3).GetEnumerator();
            label_37:
            if(((-1350169232) & 1) == 0)
            {
                goto label_38;
            }
            
            this.GenerateRewardsCell(itemUiDescription:  val_5.emailUIDataHandler);
            goto label_37;
            label_38:
            long val_22 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524731514224});
            if(((307 == 0) ? 307 : 307) == 307)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_35 = 0;
            }
            
            }
            
            List.Enumerator<T> val_25 = this._rewardV3Translator.GetPartsCellDescriptions(rewardDataV3:  this.emailData.rewardDataV3).GetEnumerator();
            label_48:
            if(((-1350169232) & 1) == 0)
            {
                goto label_49;
            }
            
            this.GenerateRewardsCell(itemUiDescription:  val_5.emailUIDataHandler);
            goto label_48;
            label_49:
            long val_27 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524731514224});
            if(((379 == 0) ? 379 : 379) == 379)
            {
                
            }
            else
            {
                    if( != 0)
            {
                    val_35 = 0;
            }
            
            }
            
            List.Enumerator<T> val_30 = this._rewardV3Translator.GetEssenceOnLossCellDescriptions(rewardDataV3:  this.emailData.rewardDataV3).GetEnumerator();
            label_59:
            if(((-1350169232) & 1) == 0)
            {
                goto label_60;
            }
            
            this.GenerateRewardsCell(itemUiDescription:  val_5.emailUIDataHandler);
            goto label_59;
            label_60:
            long val_32 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921524731514224});
            if( == 0)
            {
                    return;
            }
            
            if(451 == 0)
            {
                    return;
            }
            
            if(451 == 451)
            {
                    return;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateRewardsCell(GameUI.ItemUIDescription itemUiDescription)
        {
            string val_2;
            int val_3;
            if(itemUiDescription != null)
            {
                    val_2 = itemUiDescription.displayName;
                val_3 = itemUiDescription.number;
            }
            else
            {
                    val_2 = 69077560;
                val_3 = 0;
            }
            
            UnityEngine.Object.Instantiate<GameUI.AttachmentRewardCell>(original:  this.attachmentRewardCellPrefab, parent:  this.emailMessageParent).SetData(rewardName:  val_2, amount:  0, categorySprite:  itemUiDescription.sprite);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateAudioCell()
        {
            if(this.emailData.audioItem == null)
            {
                    return;
            }
            
            UnityEngine.Object.Instantiate<GameUI.AttachmentAudioCell>(original:  this.attachmentAudioCellPrefab, parent:  this.emailMessageParent).SetData(audioItem:  this.emailData.audioItem, audioClip:  0, playString:  "Play", PlayAttachmentAudio:  new System.Action<GameUI.AttachmentAudioCell>(object:  this, method:  System.Void GameUI.EmailDialogDisplay::PlayAudioAttachment(GameUI.AttachmentAudioCell attachmentAudioCell)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateBodyText()
        {
            GameUI.EmailData val_4;
            string val_5;
            GameUI.EmailData val_6;
            Game.Localization.LocalizationDomain val_1 = Game.Localization.LocalizationDomain.Instance;
            val_4 = this.emailData;
            if(val_4 == null)
            {
                goto label_4;
            }
            
            val_5 = this.emailData.messageString;
            val_6 = val_4;
            goto label_7;
            label_4:
            val_6 = this.emailData;
            val_5 = this.emailData.messageString;
            if(val_6 == null)
            {
                goto label_6;
            }
            
            val_4 = val_6;
            goto label_7;
            label_6:
            val_4 = this.emailData;
            if(val_4 == null)
            {
                goto label_8;
            }
            
            label_7:
            var val_5 = 0;
            val_5 = val_5 + 1;
            UnityEngine.Object.Instantiate<TMPro.TextMeshProUGUI>(original:  this.attachmentBodyCellPrefab, parent:  this.emailMessageParent).text = val_1.ILocalization.GetLocalizedString(localizedStringId:  val_5, originalString:  this.emailData.messageString, replacementTokens:  this.emailData.tokens);
            return;
            label_8:
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateLinkToStoreCell()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this.attachmentLinkToStoreCellPrefab)) == false)
            {
                    return;
            }
            
            if(this.HasLinkToStore() == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.attachmentLinkToStoreCellPrefab, parent:  this.emailMessageParent);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void GenerateImageCell()
        {
            if(this.emailData.imageItem == null)
            {
                    return;
            }
            
            UnityEngine.Object.Instantiate<GameUI.AttachmentImageCell>(original:  this.attachmentImageCellPrefab, parent:  this.emailMessageParent).SetData(sprite:  0, tapToExpandString:  "[Tap To Expand]", TapToExpandImage:  new System.Action<UnityEngine.Sprite>(object:  this, method:  System.Void GameUI.EmailDialogDisplay::TapToExpandImage(UnityEngine.Sprite sprite)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void TapToExpandImage(UnityEngine.Sprite sprite)
        {
            this.dialogHandler_Inbox.ShowImageDialog(sprite:  sprite);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void PlayAudioAttachment(GameUI.AttachmentAudioCell attachmentAudioCell)
        {
            attachmentAudioCell.PlayAudioClip();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void CloseEmail()
        {
            this.gameObject.SetActive(value:  false);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetEmail(GameUI.EmailData email, Master.MasterDomain masterDomain)
        {
            this._masterDomain = masterDomain;
            this.emailData = email;
            this.RefreshDisplay();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            this._backButtonId = Systems.Android.AndroidBackButtonHandler.PushBackButtonAction(backButtonAction:  new System.Action(object:  this, method:  System.Void GameUI.EmailDialogDisplay::CloseEmail()));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            BackButtonStackEntry val_1 = Systems.Android.AndroidBackButtonHandler.RemoveBackButtonActionById(backButtonId:  this._backButtonId);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public EmailDialogDisplay()
        {
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void <GenerateHeader>b__21_0(Game.Localization.ILocalization localization)
        {
            GameUI.EmailData val_4;
            string val_5;
            GameUI.EmailData val_6;
            GameUI.EmailData val_8;
            string val_9;
            GameUI.EmailData val_10;
            GameUI.EmailData val_12;
            string val_13;
            GameUI.EmailData val_14;
            val_4 = this.emailData;
            if(val_4 == null)
            {
                goto label_1;
            }
            
            val_5 = this.emailData.recipientString;
            val_6 = val_4;
            goto label_4;
            label_1:
            val_6 = this.emailData;
            val_5 = this.emailData.recipientString;
            if(val_6 == null)
            {
                goto label_3;
            }
            
            val_4 = val_6;
            goto label_4;
            label_3:
            val_4 = this.emailData;
            if(val_4 == null)
            {
                goto label_27;
            }
            
            label_4:
            var val_7 = 0;
            val_7 = val_7 + 1;
            this.toText.text = localization.GetLocalizedString(localizedStringId:  val_5, originalString:  this.emailData.recipientString, replacementTokens:  this.emailData.tokens);
            val_8 = this.emailData;
            if(val_8 == null)
            {
                goto label_12;
            }
            
            val_9 = this.emailData.fromString;
            val_10 = val_8;
            goto label_15;
            label_12:
            val_10 = this.emailData;
            val_9 = this.emailData.fromString;
            if(val_10 == null)
            {
                goto label_14;
            }
            
            val_8 = val_10;
            goto label_15;
            label_14:
            val_8 = this.emailData;
            if(val_8 == null)
            {
                goto label_27;
            }
            
            label_15:
            var val_8 = 0;
            val_8 = val_8 + 1;
            this.fromText.text = localization.GetLocalizedString(localizedStringId:  val_9, originalString:  this.emailData.fromString, replacementTokens:  this.emailData.tokens);
            val_12 = this.emailData;
            if(val_12 == null)
            {
                goto label_23;
            }
            
            val_13 = this.emailData.subjectString;
            val_14 = val_12;
            goto label_26;
            label_23:
            val_14 = this.emailData;
            val_13 = this.emailData.subjectString;
            if(val_14 == null)
            {
                goto label_25;
            }
            
            val_12 = val_14;
            goto label_26;
            label_25:
            val_12 = this.emailData;
            if(val_12 == null)
            {
                goto label_27;
            }
            
            label_26:
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.subjectText.text = localization.GetLocalizedString(localizedStringId:  val_13, originalString:  this.emailData.subjectString, replacementTokens:  this.emailData.tokens);
            return;
            label_27:
        }
    
    }

}
