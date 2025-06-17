using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class ProfileUIActions.<>c__DisplayClass19_0
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameUI.ProfileUIActions <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public string payload;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public ProfileUIActions.<>c__DisplayClass19_0()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <ShareFriendCode>b__0(Game.Localization.ILocalization localization)
    {
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.<>4__this._masterDomain.eventExposer.OnGetSocialInviteExplicitContent(payload:  new GetSocialInviteContent() {Title = localization.GetLocalizedString(localizedStringId:  "ui_friendcode_share_title", originalString:  "ui_friendcode_share_title"), Description = this.payload});
    }

}
