using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GameSparksTestUI : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Collections.Generic.Queue<string> myLogQueue;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string myLog;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string fbToken;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string dismissMessageId;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int itemHeight = 30;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private const int itemWidth = 200;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool testing;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool working;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool result;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int counter;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int numTest;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public UnityEngine.Texture cursor;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        UnityEngine.Application.add_logMessageReceivedThreaded(value:  new Application.LogCallback(object:  this, method:  System.Void GameSparksTestUI::HandleLog(string logString, string stackTrace, UnityEngine.LogType logType)));
        UnityEngine.Screen.orientation = 5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        GameSparks.Api.GSMessageHandler._AllMessages = new System.Action<GameSparks.Api.Messages.GSMessage>(object:  this, method:  System.Void GameSparksTestUI::HandleGameSparksMessageReceived(GameSparks.Api.Messages.GSMessage message));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void HandleGameSparksMessageReceived(GameSparks.Api.Messages.GSMessage message)
    {
        this.HandleLog(logString:  "MSG:"("MSG:") + message.JSONString);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void HandleLog(string logString)
    {
        IntPtr val_5;
        GameSparksTestUI.<>c__DisplayClass15_0 val_1 = new GameSparksTestUI.<>c__DisplayClass15_0();
        if(val_1 != null)
        {
                .<>4__this = this;
        }
        else
        {
                mem[16] = this;
        }
        
        .logString = logString;
        System.Action val_3 = null;
        val_5 = System.Void GameSparksTestUI.<>c__DisplayClass15_0::<HandleLog>b__0();
        val_3 = new System.Action(object:  val_1, method:  val_5);
        var val_5 = 0;
        val_5 = val_5 + 1;
        val_5 = 15;
        GameSparks.Core.GS.GSPlatform.ExecuteOnMainThread(action:  val_3);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void HandleLog(string logString, string stackTrace, UnityEngine.LogType logType)
    {
        var val_5;
        if(this.myLogQueue.Count >= 31)
        {
                string val_2 = this.myLogQueue.Dequeue();
        }
        
        this.myLogQueue.Enqueue(item:  logString);
        this.myLog = "";
        val_5 = 0;
        goto label_6;
        label_9:
        val_5 = 1;
        this.myLog = this.myLog + "\n\n" + this.myLogQueue.ToArray()[0];
        label_6:
        if(val_5 < val_3.Length)
        {
            goto label_9;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnGUI()
    {
        string val_141;
        var val_142;
        var val_144;
        string val_146;
        UnityEngine.GUI.skin.label.alignment = 4;
        UnityEngine.GUI.skin.textField.alignment = 4;
        UnityEngine.GUI.skin.textArea.alignment = 6;
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_10 = new UnityEngine.GUILayoutOption[2];
        val_10[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_10[1] = UnityEngine.GUILayout.Height(height:  30f);
        UnityEngine.GUILayout.Label(text:  (GameSparks.Core.GS.Available != true) ? "AVAILABLE" : "NOT AVAILABLE", options:  val_10);
        UnityEngine.GUILayoutOption[] val_15 = new UnityEngine.GUILayoutOption[2];
        val_15[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_15[1] = UnityEngine.GUILayout.Height(height:  30f);
        UnityEngine.GUILayout.Label(text:  "SDK Version: "("SDK Version: ") + GameSparks.Core.GS.Version, options:  val_15);
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayoutOption[] val_20 = new UnityEngine.GUILayoutOption[2];
        val_20[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_20[1] = UnityEngine.GUILayout.Height(height:  30f);
        UnityEngine.GUILayout.Label(text:  (GameSparks.Core.GS.Authenticated != true) ? "AUTHENTICATED" : "NOT AUTHENTICATED", options:  val_20);
        UnityEngine.GUILayoutOption[] val_23 = new UnityEngine.GUILayoutOption[2];
        val_23[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_23[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "Clear Log", options:  val_23)) != false)
        {
                this.myLog = "";
            this.myLogQueue.Clear();
        }
        
        UnityEngine.GUILayoutOption[] val_27 = new UnityEngine.GUILayoutOption[2];
        val_27[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_27[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "Logout", options:  val_27)) != false)
        {
                GameSparks.Core.GS.Reset();
        }
        
        UnityEngine.GUILayoutOption[] val_31 = new UnityEngine.GUILayoutOption[2];
        val_31[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_31[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "Disconnect", options:  val_31)) != false)
        {
                GameSparks.Core.GS.Disconnect();
        }
        
        if(GameSparks.Core.GS.Available != true)
        {
                UnityEngine.GUILayoutOption[] val_36 = new UnityEngine.GUILayoutOption[2];
            val_36[0] = UnityEngine.GUILayout.Width(width:  200f);
            val_36[1] = UnityEngine.GUILayout.Height(height:  30f);
            if((UnityEngine.GUILayout.Button(text:  "Reconnect", options:  val_36)) != false)
        {
                GameSparks.Core.GS.Reconnect();
        }
        
        }
        
        UnityEngine.GUILayoutOption[] val_40 = new UnityEngine.GUILayoutOption[2];
        val_40[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_40[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "DeviceAuthenticationRequest", options:  val_40)) != false)
        {
                new GameSparks.Api.Requests.DeviceAuthenticationRequest().Send(callback:  new System.Action<GameSparks.Api.Responses.AuthenticationResponse>(object:  this, method:  System.Void GameSparksTestUI::<OnGUI>b__17_0(GameSparks.Api.Responses.AuthenticationResponse response)));
        }
        
        UnityEngine.GUILayoutOption[] val_46 = new UnityEngine.GUILayoutOption[2];
        val_46[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_46[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "durableAccountDetailsRequest", options:  val_46)) != false)
        {
                new GameSparks.Api.Requests.AccountDetailsRequest().SetDurable(durable:  true).Send(callback:  0);
        }
        
        UnityEngine.GUILayoutOption[] val_52 = new UnityEngine.GUILayoutOption[2];
        val_52[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_52[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "accountDetailsRequest", options:  val_52)) != false)
        {
                new GameSparks.Api.Requests.AccountDetailsRequest().Send(callback:  new System.Action<GameSparks.Api.Responses.AccountDetailsResponse>(object:  this, method:  System.Void GameSparksTestUI::<OnGUI>b__17_1(GameSparks.Api.Responses.AccountDetailsResponse response)));
        }
        
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_59 = new UnityEngine.GUILayoutOption[2];
        val_59[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_59[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "facebookConnectRequest", options:  val_59)) != false)
        {
                val_141 = this;
            new GameSparks.Api.Requests.FacebookConnectRequest().SetAccessToken(accessToken:  this.fbToken).Send(callback:  new System.Action<GameSparks.Api.Responses.AuthenticationResponse>(object:  this, method:  System.Void GameSparksTestUI::<OnGUI>b__17_2(GameSparks.Api.Responses.AuthenticationResponse response)));
        }
        else
        {
                val_141 = this.fbToken;
        }
        
        UnityEngine.GUILayoutOption[] val_66 = new UnityEngine.GUILayoutOption[2];
        val_66[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_66[1] = UnityEngine.GUILayout.Height(height:  30f);
        mem2[0] = UnityEngine.GUILayout.TextField(text:  mem[this.fbToken], options:  val_66);
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayoutOption[] val_70 = new UnityEngine.GUILayoutOption[2];
        val_70[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_70[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "listAchievementsRequest", options:  val_70)) != false)
        {
                new GameSparks.Api.Requests.ListAchievementsRequest().Send(callback:  new System.Action<GameSparks.Api.Responses.ListAchievementsResponse>(object:  this, method:  System.Void GameSparksTestUI::<OnGUI>b__17_3(GameSparks.Api.Responses.ListAchievementsResponse response)));
        }
        
        UnityEngine.GUILayoutOption[] val_76 = new UnityEngine.GUILayoutOption[2];
        val_76[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_76[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "listGameFriendsRequest", options:  val_76)) != false)
        {
                new GameSparks.Api.Requests.ListGameFriendsRequest().Send(callback:  new System.Action<GameSparks.Api.Responses.ListGameFriendsResponse>(object:  this, method:  System.Void GameSparksTestUI::<OnGUI>b__17_4(GameSparks.Api.Responses.ListGameFriendsResponse response)));
        }
        
        UnityEngine.GUILayoutOption[] val_82 = new UnityEngine.GUILayoutOption[2];
        val_82[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_82[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "listVirtualGoodsRequest", options:  val_82)) != false)
        {
                new GameSparks.Api.Requests.ListVirtualGoodsRequest().Send(callback:  new System.Action<GameSparks.Api.Responses.ListVirtualGoodsResponse>(object:  this, method:  System.Void GameSparksTestUI::<OnGUI>b__17_5(GameSparks.Api.Responses.ListVirtualGoodsResponse response)));
        }
        
        UnityEngine.GUILayoutOption[] val_88 = new UnityEngine.GUILayoutOption[2];
        val_88[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_88[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "listChallengeTypeRequest", options:  val_88)) != false)
        {
                new GameSparks.Api.Requests.ListChallengeTypeRequest().Send(callback:  new System.Action<GameSparks.Api.Responses.ListChallengeTypeResponse>(object:  this, method:  System.Void GameSparksTestUI::<OnGUI>b__17_6(GameSparks.Api.Responses.ListChallengeTypeResponse response)));
        }
        
        UnityEngine.GUILayoutOption[] val_94 = new UnityEngine.GUILayoutOption[2];
        val_94[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_94[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "authenticationRequest", options:  val_94)) == false)
        {
            goto label_154;
        }
        
        GameSparks.Api.Requests.AuthenticationRequest val_100 = new GameSparks.Api.Requests.AuthenticationRequest().SetUserName(userName:  "gabs").SetPassword(password:  "gabs");
        val_142 = null;
        val_142 = null;
        if((GameSparksTestUI.<>c.<>9__17_7) == null)
        {
            goto label_159;
        }
        
        label_215:
        val_100.Send(callback:  GameSparksTestUI.<>c.<>9__17_7);
        label_154:
        UnityEngine.GUILayoutOption[] val_101 = new UnityEngine.GUILayoutOption[2];
        val_101[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_101[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "leaderboardData", options:  val_101)) == false)
        {
            goto label_168;
        }
        
        GameSparks.Api.Requests.LeaderboardDataRequest val_107 = new GameSparks.Api.Requests.LeaderboardDataRequest().SetLeaderboardShortCode(leaderboardShortCode:  "HSCORE").SetEntryCount(entryCount:  10);
        val_144 = null;
        val_144 = null;
        if((GameSparksTestUI.<>c.<>9__17_8) == null)
        {
            goto label_173;
        }
        
        label_219:
        val_107.Send(callback:  GameSparksTestUI.<>c.<>9__17_8);
        label_168:
        UnityEngine.GUILayoutOption[] val_108 = new UnityEngine.GUILayoutOption[2];
        val_108[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_108[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "listMessageRequest", options:  val_108)) != false)
        {
                new GameSparks.Api.Requests.ListMessageRequest().Send(callback:  new System.Action<GameSparks.Api.Responses.ListMessageResponse>(object:  this, method:  System.Void GameSparksTestUI::<OnGUI>b__17_9(GameSparks.Api.Responses.ListMessageResponse response)));
        }
        
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayoutOption[] val_115 = new UnityEngine.GUILayoutOption[2];
        val_115[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_115[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "dismissMessageRequest", options:  val_115)) != false)
        {
                val_146 = this;
            new GameSparks.Api.Requests.DismissMessageRequest().SetMessageId(messageId:  this.dismissMessageId).Send(callback:  new System.Action<GameSparks.Api.Responses.DismissMessageResponse>(object:  this, method:  System.Void GameSparksTestUI::<OnGUI>b__17_10(GameSparks.Api.Responses.DismissMessageResponse response)));
        }
        else
        {
                val_146 = this.dismissMessageId;
        }
        
        UnityEngine.GUILayoutOption[] val_122 = new UnityEngine.GUILayoutOption[2];
        val_122[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_122[1] = UnityEngine.GUILayout.Height(height:  30f);
        mem2[0] = UnityEngine.GUILayout.TextField(text:  mem[this.dismissMessageId], options:  val_122);
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayoutOption[] val_129 = new UnityEngine.GUILayoutOption[2];
        val_129[0] = UnityEngine.GUILayout.Width(width:  200f);
        val_129[1] = UnityEngine.GUILayout.Height(height:  30f);
        if((UnityEngine.GUILayout.Button(text:  "TRACE " + (GameSparks.Core.GS.TraceMessages != true) ? "ON" : "OFF"((GameSparks.Core.GS.TraceMessages != true) ? "ON" : "OFF"), options:  val_129)) != false)
        {
                bool val_133 = GameSparks.Core.GS.TraceMessages;
            val_133 = (~val_133) & 1;
            GameSparks.Core.GS.TraceMessages = val_133;
        }
        
        int val_136 = UnityEngine.Screen.width - 425;
        int val_137 = UnityEngine.Screen.height - 10;
        string val_138 = UnityEngine.GUI.TextArea(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  this.myLog);
        return;
        label_159:
        GameSparksTestUI.<>c.<>9__17_7 = new System.Action<GameSparks.Api.Responses.AuthenticationResponse>(object:  GameSparksTestUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameSparksTestUI.<>c::<OnGUI>b__17_7(GameSparks.Api.Responses.AuthenticationResponse AR));
        if(val_100 != null)
        {
            goto label_215;
        }
        
        goto label_215;
        label_173:
        GameSparksTestUI.<>c.<>9__17_8 = new System.Action<GameSparks.Api.Responses.LeaderboardDataResponse>(object:  GameSparksTestUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameSparksTestUI.<>c::<OnGUI>b__17_8(GameSparks.Api.Responses.LeaderboardDataResponse leadResponse));
        if(val_107 != null)
        {
            goto label_219;
        }
        
        goto label_219;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Update()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameSparksTestUI()
    {
        this.myLogQueue = new System.Collections.Generic.Queue<System.String>();
        this.myLog = "";
        this.fbToken = "accessToken";
        this.dismissMessageId = "messageId";
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnGUI>b__17_0(GameSparks.Api.Responses.AuthenticationResponse response)
    {
        this.HandleLog(logString:  "DeviceAuthenticationRequest.JSON:"("DeviceAuthenticationRequest.JSON:") + response.JSONString);
        if(response != null)
        {
                this.HandleLog(logString:  "DeviceAuthenticationRequest.HasErrors:"("DeviceAuthenticationRequest.HasErrors:") + response.HasErrors.ToString());
        }
        else
        {
                this.HandleLog(logString:  "DeviceAuthenticationRequest.HasErrors:"("DeviceAuthenticationRequest.HasErrors:") + response.HasErrors.ToString());
        }
        
        this.HandleLog(logString:  "DeviceAuthenticationRequest.UserId:"("DeviceAuthenticationRequest.UserId:") + response.UserId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnGUI>b__17_1(GameSparks.Api.Responses.AccountDetailsResponse response)
    {
        this.HandleLog(logString:  "AccountDetailsRequest.UserId:"("AccountDetailsRequest.UserId:") + response.UserId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnGUI>b__17_2(GameSparks.Api.Responses.AuthenticationResponse response)
    {
        if(response != null)
        {
                this.HandleLog(logString:  "FacebookConnectRequest.HasErrors:"("FacebookConnectRequest.HasErrors:") + response.HasErrors.ToString());
        }
        else
        {
                this.HandleLog(logString:  "FacebookConnectRequest.HasErrors:"("FacebookConnectRequest.HasErrors:") + 0.HasErrors.ToString());
        }
        
        this.HandleLog(logString:  "FacebookConnectRequest.UserId:"("FacebookConnectRequest.UserId:") + response.UserId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnGUI>b__17_3(GameSparks.Api.Responses.ListAchievementsResponse response)
    {
        var val_16;
        var val_17;
        var val_20;
        var val_21;
        val_16 = 1152921504689487872;
        val_17 = response.Achievements.GetEnumerator();
        label_15:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_17.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        this.HandleLog(logString:  "ListAchievementsRequest:shortCode:"("ListAchievementsRequest:shortCode:") + val_17.Current.ShortCode);
        goto label_15;
        label_8:
        val_20 = 0;
        val_21 = 63;
        if(val_17 == null)
        {
            
        }
        else
        {
                var val_20 = 0;
            val_20 = val_20 + 1;
            val_17.Dispose();
        }
        
        if( == 63)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_17 = ???;
        val_21 = ???;
        val_16 = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnGUI>b__17_4(GameSparks.Api.Responses.ListGameFriendsResponse response)
    {
        var val_16;
        var val_17;
        var val_20;
        var val_21;
        val_16 = 1152921504689487872;
        val_17 = response.Friends.GetEnumerator();
        label_15:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_17.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        this.HandleLog(logString:  "ListGameFriendsRequest.DisplayName:"("ListGameFriendsRequest.DisplayName:") + val_17.Current.DisplayName);
        goto label_15;
        label_8:
        val_20 = 0;
        val_21 = 63;
        if(val_17 == null)
        {
            
        }
        else
        {
                var val_20 = 0;
            val_20 = val_20 + 1;
            val_17.Dispose();
        }
        
        if( == 63)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_17 = ???;
        val_21 = ???;
        val_16 = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnGUI>b__17_5(GameSparks.Api.Responses.ListVirtualGoodsResponse response)
    {
        var val_16;
        var val_17;
        var val_20;
        var val_21;
        val_16 = 1152921504689487872;
        val_17 = response.VirtualGoods.GetEnumerator();
        label_15:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_17.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        this.HandleLog(logString:  "ListVirtualGoodsRequest.Description:"("ListVirtualGoodsRequest.Description:") + val_17.Current.Description);
        goto label_15;
        label_8:
        val_20 = 0;
        val_21 = 63;
        if(val_17 == null)
        {
            
        }
        else
        {
                var val_20 = 0;
            val_20 = val_20 + 1;
            val_17.Dispose();
        }
        
        if( == 63)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_17 = ???;
        val_21 = ???;
        val_16 = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnGUI>b__17_6(GameSparks.Api.Responses.ListChallengeTypeResponse response)
    {
        var val_16;
        var val_17;
        var val_20;
        var val_21;
        val_16 = 1152921504689487872;
        val_17 = response.ChallengeTemplates.GetEnumerator();
        label_15:
        var val_18 = 0;
        val_18 = val_18 + 1;
        if(val_17.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_19 = 0;
        val_19 = val_19 + 1;
        this.HandleLog(logString:  "ListAchievementsRequest.Challenge:"("ListAchievementsRequest.Challenge:") + val_17.Current.ChallengeShortCode);
        goto label_15;
        label_8:
        val_20 = 0;
        val_21 = 63;
        if(val_17 == null)
        {
            
        }
        else
        {
                var val_20 = 0;
            val_20 = val_20 + 1;
            val_17.Dispose();
        }
        
        if( == 63)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_17 = ???;
        val_21 = ???;
        val_16 = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnGUI>b__17_9(GameSparks.Api.Responses.ListMessageResponse response)
    {
        var val_17;
        var val_18;
        var val_21;
        var val_22;
        val_17 = 1152921504689487872;
        val_18 = response.MessageList.GetEnumerator();
        label_15:
        var val_19 = 0;
        val_19 = val_19 + 1;
        if(val_18.MoveNext() == false)
        {
            goto label_8;
        }
        
        var val_20 = 0;
        val_20 = val_20 + 1;
        this.HandleLog(logString:  "ListMessageRequest.MessageList:"("ListMessageRequest.MessageList:") + val_18.Current.GetString(name:  "messageId")(val_18.Current.GetString(name:  "messageId")));
        goto label_15;
        label_8:
        val_21 = 0;
        val_22 = 68;
        if(val_18 == null)
        {
            
        }
        else
        {
                var val_21 = 0;
            val_21 = val_21 + 1;
            val_18.Dispose();
        }
        
        if( == 68)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
        
        val_18 = ???;
        val_22 = ???;
        val_17 = ???;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <OnGUI>b__17_10(GameSparks.Api.Responses.DismissMessageResponse response)
    {
        this.HandleLog(logString:  "DismissMessageRequest.HasErrors:"("DismissMessageRequest.HasErrors:") + response.HasErrors.ToString());
    }

}
