using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public static class AkRoomPortalManager
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.List<AkRoom> m_UpdatedRooms;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.List<AkRoomPortal> m_Portals;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static readonly System.Collections.Generic.List<AkRoomPortal> m_PortalsToUpdate;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RegisterPortal(AkRoomPortal portal)
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if((AkRoomPortalManager.m_Portals.Contains(item:  portal)) != false)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        AkRoomPortalManager.m_Portals.Add(item:  portal);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void UnregisterPortal(AkRoomPortal portal)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = null;
        val_5 = null;
        if((AkRoomPortalManager.m_Portals.Contains(item:  portal)) != false)
        {
                val_6 = null;
            val_6 = null;
            bool val_2 = AkRoomPortalManager.m_Portals.Remove(item:  portal);
        }
        
        val_7 = null;
        val_7 = null;
        if((AkRoomPortalManager.m_PortalsToUpdate.Contains(item:  portal)) == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        bool val_4 = AkRoomPortalManager.m_PortalsToUpdate.Remove(item:  portal);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void RegisterRoomUpdate(AkRoom room)
    {
        var val_3;
        AkRoom val_12;
        var val_13;
        var val_14;
        var val_15;
        val_12 = room;
        val_13 = null;
        val_13 = null;
        AkRoomPortalManager.m_UpdatedRooms.Add(item:  val_12);
        List.Enumerator<T> val_1 = AkRoomPortalManager.m_Portals.GetEnumerator();
        do
        {
            label_21:
            if((1910917200 & 1) == 0)
        {
                return;
        }
        
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            val_14 = null;
            val_14 = null;
        }
        while((AkRoomPortalManager.m_PortalsToUpdate.Contains(item:  val_4)) == true);
        
        if(val_12 != val_4.frontRoom)
        {
                if(val_12 != val_4.backRoom)
        {
            goto label_21;
        }
        
        }
        
        val_15 = null;
        val_15 = null;
        AkRoomPortalManager.m_PortalsToUpdate.Add(item:  val_4);
        goto label_21;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void UpdatePortals()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        List.Enumerator<T> val_1 = AkRoomPortalManager.m_PortalsToUpdate.GetEnumerator();
        label_6:
        if((1911059976 & 1) == 0)
        {
            goto label_4;
        }
        
        0.emailUIDataHandler.UpdateSoundEngineRoomIDs();
        goto label_6;
        label_4:
        long val_3 = UnityEngine.Timeline.DiscreteTime.op_Explicit(b:  new UnityEngine.Timeline.DiscreteTime() {m_DiscreteTime = 1152921519402808840});
        val_6 = null;
        val_6 = null;
        AkRoomPortalManager.m_UpdatedRooms.Clear();
        AkRoomPortalManager.m_PortalsToUpdate.Clear();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkRoomPortalManager()
    {
        AkRoomPortalManager.m_UpdatedRooms = new System.Collections.Generic.List<AkRoom>();
        AkRoomPortalManager.m_Portals = new System.Collections.Generic.List<AkRoomPortal>();
        AkRoomPortalManager.m_PortalsToUpdate = new System.Collections.Generic.List<AkRoomPortal>();
    }

}
