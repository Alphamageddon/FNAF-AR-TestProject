using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class GameSparksRTUnity : MonoBehaviour, IRTSessionListener
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private GameSparks.RT.IRTSession session;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action<int> m_OnPlayerConnect;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action<int> m_OnPlayerDisconnect;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action<bool> m_OnReady;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Action<GameSparks.RT.RTPacket> m_OnPacket;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static GameSparksRTUnity instance;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static GameSparksRTUnity Instance { get; set; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Nullable<int> PeerId { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<int> ActivePeers { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool Ready { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static GameSparksRTUnity get_Instance()
    {
        GameSparksRTUnity val_5 = GameSparksRTUnity.instance;
        if(val_5 != 0)
        {
                return (GameSparksRTUnity)GameSparksRTUnity.instance;
        }
        
        GameSparksRTUnity.instance = new UnityEngine.GameObject(name:  "GameSparksRTUnity").AddComponent<GameSparksRTUnity>();
        val_5 = GameSparksRTUnity.instance.gameObject;
        UnityEngine.Object.DontDestroyOnLoad(target:  val_5);
        return (GameSparksRTUnity)GameSparksRTUnity.instance;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static void set_Instance(GameSparksRTUnity value)
    {
        if(GameSparksRTUnity.instance != 0)
        {
                if(GameSparksRTUnity.instance != value)
        {
                UnityEngine.Object.Destroy(obj:  GameSparksRTUnity.instance.gameObject);
        }
        
        }
        
        GameSparksRTUnity.instance = value;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Awake()
    {
        GameSparksRTUnity.instance = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Configure(GameSparks.Api.Messages.MatchFoundMessage message, System.Action<int> OnPlayerConnect, System.Action<int> OnPlayerDisconnect, System.Action<bool> OnReady, System.Action<GameSparks.RT.RTPacket> OnPacket)
    {
        string val_6;
        System.Nullable<System.Int32> val_1 = message.Port;
        if((1578696344 & 1) == 0)
        {
            goto label_2;
        }
        
        if(message == null)
        {
            goto label_3;
        }
        
        val_6 = message.Host;
        goto label_4;
        label_2:
        UnityEngine.Debug.Log(message:  "Response does not contain a port, exiting.");
        return;
        label_3:
        val_6 = 0.Host;
        label_4:
        System.Nullable<System.Int32> val_4 = message.Port;
        this.Configure(host:  val_6, port:  1578696344, accessToken:  message.AccessToken, OnPlayerConnect:  OnPlayerConnect, OnPlayerDisconnect:  OnPlayerDisconnect, OnReady:  OnReady, OnPacket:  OnPacket);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Configure(GameSparks.Api.Responses.FindMatchResponse response, System.Action<int> OnPlayerConnect, System.Action<int> OnPlayerDisconnect, System.Action<bool> OnReady, System.Action<GameSparks.RT.RTPacket> OnPacket)
    {
        string val_6;
        System.Nullable<System.Int32> val_1 = response.Port;
        if((1578873880 & 1) == 0)
        {
            goto label_2;
        }
        
        if(response == null)
        {
            goto label_3;
        }
        
        val_6 = response.Host;
        goto label_4;
        label_2:
        UnityEngine.Debug.Log(message:  "Response does not contain a port, exiting.");
        return;
        label_3:
        val_6 = 0.Host;
        label_4:
        System.Nullable<System.Int32> val_4 = response.Port;
        this.Configure(host:  val_6, port:  1578873880, accessToken:  response.AccessToken, OnPlayerConnect:  OnPlayerConnect, OnPlayerDisconnect:  OnPlayerDisconnect, OnReady:  OnReady, OnPacket:  OnPacket);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Configure(string host, int port, string accessToken, System.Action<int> OnPlayerConnect, System.Action<int> OnPlayerDisconnect, System.Action<bool> OnReady, System.Action<GameSparks.RT.RTPacket> OnPacket)
    {
        this.m_OnPlayerConnect = OnPlayerConnect;
        this.m_OnPlayerDisconnect = OnPlayerDisconnect;
        this.m_OnReady = OnReady;
        this.m_OnPacket = OnPacket;
        if(this.session != null)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            this.session.Stop();
        }
        
        this.session = GameSparks.RT.GameSparksRT.SessionBuilder().SetHost(host:  host).SetPort(port:  port).SetConnectToken(connectToken:  accessToken).SetListener(listener:  this).Build();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Connect()
    {
        if(this.session != null)
        {
                UnityEngine.Debug.Log(message:  "Starting Session");
            var val_2 = 0;
            val_2 = val_2 + 1;
        }
        else
        {
                UnityEngine.Debug.Log(message:  "Cannot start Session");
            return;
        }
        
        this.session.Start();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Disconnect()
    {
        if(this.session == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.session.Stop();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Nullable<int> get_PeerId()
    {
        if(this.session == null)
        {
                return 0;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.session.PeerId;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<int> get_ActivePeers()
    {
        if(this.session == null)
        {
                return 0;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.session.ActivePeers;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public bool get_Ready()
    {
        if(this.session == null)
        {
                return false;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.session.Ready;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int SendData(int opCode, GameSparks.RT.GameSparksRT.DeliveryIntent deliveryIntent, GameSparks.RT.RTData structuredData, int[] targetPlayers)
    {
        if(this.session == null)
        {
                return 0;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.session.SendRTData(opCode:  opCode, deliveryIntent:  deliveryIntent, data:  structuredData, targetPlayers:  targetPlayers);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int SendBytes(int opCode, GameSparks.RT.GameSparksRT.DeliveryIntent deliveryIntent, System.ArraySegment<byte> unstructuredData, int[] targetPlayers)
    {
        if(this.session == null)
        {
                return 0;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        return this.session.SendBytes(opCode:  opCode, deliveryIntent:  deliveryIntent, payload:  new System.ArraySegment<System.Byte>() {_count = unstructuredData._count}, targetPlayers:  targetPlayers);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public int SendRTDataAndBytes(int opCode, GameSparks.RT.GameSparksRT.DeliveryIntent deliveryIntent, System.ArraySegment<byte> unstructuredData, GameSparks.RT.RTData structuredData, int[] targetPlayers)
    {
        var val_4;
        if(this.session != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
        }
        else
        {
                val_4 = 0;
            return (int)val_4.SendRTDataAndBytes(opCode:  opCode, intent:  deliveryIntent, payload:  new System.Nullable<System.ArraySegment<System.Byte>>() {HasValue = true}, data:  targetPlayers, targetPlayers:  X6);
        }
        
        val_4 = this.session;
        return (int)val_4.SendRTDataAndBytes(opCode:  opCode, intent:  deliveryIntent, payload:  new System.Nullable<System.ArraySegment<System.Byte>>() {HasValue = true}, data:  targetPlayers, targetPlayers:  X6);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDestroy()
    {
        this.Disconnect();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this.session == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.session.Update();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnPlayerConnect(int peerId)
    {
        if(this.m_OnPlayerConnect == null)
        {
                return;
        }
        
        this.m_OnPlayerConnect.Invoke(obj:  peerId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnPlayerDisconnect(int peerId)
    {
        if(this.m_OnPlayerDisconnect == null)
        {
                return;
        }
        
        this.m_OnPlayerDisconnect.Invoke(obj:  peerId);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnReady(bool ready)
    {
        if(this.m_OnReady == null)
        {
                return;
        }
        
        ready = ready;
        this.m_OnReady.Invoke(obj:  ready);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnPacket(GameSparks.RT.RTPacket packet)
    {
        var val_2 = 1152921519072873680;
        if(this.m_OnPacket == null)
        {
                return;
        }
        
        this.m_OnPacket.Invoke(obj:  new GameSparks.RT.RTPacket() {OpCode = packet.OpCode, StreamLength = packet.StreamLength, PacketSize = packet.PacketSize});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public GameSparksRTUnity()
    {
    
    }

}
