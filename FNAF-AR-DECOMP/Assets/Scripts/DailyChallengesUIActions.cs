using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class DailyChallengesUIActions : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GameUI.IllumixButton _collectRewardsButton;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GameUI.DailyChallengesUIView _dailyChallengesUIView;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GameUI.IllumixButton _moreInfoButton;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Game.Server.ServerDomain _serverDomain;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SelectCollectRewardsButton()
    {
        this._serverDomain.collectDailyChallengeRewardsRequester.RequestRewardCollection();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SelectMoreInfoButton()
    {
        this._dailyChallengesUIView.SelectMoreInfoButton();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        if(Master.MasterDomain.GetDomain() == null)
        {
            goto label_1;
        }
        
        if(this != null)
        {
            goto label_7;
        }
        
        label_8:
        label_7:
        this._serverDomain = val_1.serverDomain;
        this._collectRewardsButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void DailyChallengesUIActions::SelectCollectRewardsButton()));
        this._moreInfoButton.onClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void DailyChallengesUIActions::SelectMoreInfoButton()));
        return;
        label_1:
        if(this != null)
        {
            goto label_7;
        }
        
        goto label_8;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDestroy()
    {
        this._collectRewardsButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void DailyChallengesUIActions::SelectCollectRewardsButton()));
        this._moreInfoButton.onClick.RemoveListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void DailyChallengesUIActions::SelectMoreInfoButton()));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DailyChallengesUIActions()
    {
    
    }

}
