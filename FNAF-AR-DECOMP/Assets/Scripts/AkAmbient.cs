using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class AkAmbient : AkEvent
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static System.Collections.Generic.Dictionary<uint, AkMultiPosEvent> multiPosEventTree;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkMultiPositionType MultiPositionType;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public MultiPositionTypeLabel multiPositionTypeLabel;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAmbientLargeModePositioner[] LargeModePositions;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Collections.Generic.List<UnityEngine.Vector3> multiPositionArray;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnEnable()
    {
        AkAmbient val_14;
        var val_15;
        var val_16;
        var val_17;
        val_14 = this;
        if(this.multiPositionTypeLabel != 2)
        {
                return;
        }
        
        val_15 = 0;
        goto label_3;
        label_7:
        T val_14 = this.gameObject.GetComponents<AkGameObj>()[0];
        val_14.enabled = false;
        val_15 = 1;
        label_3:
        if(val_15 < val_2.Length)
        {
            goto label_7;
        }
        
        val_16 = null;
        val_16 = null;
        uint val_3 = val_14.Id;
        if((AkAmbient.multiPosEventTree.TryGetValue(key:  val_3, value: out  0)) == false)
        {
            goto label_12;
        }
        
        if((15026800.Contains(item:  this)) == true)
        {
            goto label_18;
        }
        
        15026800.Add(item:  this);
        goto label_18;
        label_12:
        AkMultiPosEvent val_7 = new AkMultiPosEvent();
        (AkMultiPosEvent)[1152921519426457184].list.Add(item:  this);
        val_17 = null;
        val_17 = null;
        AkAmbient.multiPosEventTree.Add(key:  val_3.Id, value:  val_7);
        label_18:
        AkPositionArray val_9 = AkAmbient.multiPosEventTree.BuildMultiDirectionArray(eventPosList:  val_7);
        val_14 = this.MultiPositionType;
        AKRESULT val_13 = AkSoundEngine.SetMultiplePositions(in_GameObjectID:  (AkMultiPosEvent)[1152921519426457184].list.Item[0].gameObject, in_pPositions:  val_9, in_NumPositions:  val_9.Count, in_eMultiPositionType:  val_14);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    protected override void Start()
    {
        var val_9;
        var val_10;
        var val_11;
        val_9 = this;
        this.Start();
        if(this.multiPositionTypeLabel == 1)
        {
            goto label_1;
        }
        
        if(this.multiPositionTypeLabel != 0)
        {
                return;
        }
        
        val_9 = this.gameObject.GetComponents<AkGameObj>();
        val_10 = 0;
        goto label_4;
        label_8:
        val_9[0].enabled = true;
        val_10 = 1;
        label_4:
        if(val_10 < val_2.Length)
        {
            goto label_8;
        }
        
        return;
        label_1:
        val_11 = 0;
        goto label_10;
        label_14:
        this.gameObject.GetComponents<AkGameObj>()[0].enabled = false;
        val_11 = 1;
        label_10:
        if(val_11 < val_4.Length)
        {
            goto label_14;
        }
        
        AkPositionArray val_5 = this.BuildAkPositionArray();
        AKRESULT val_8 = AkSoundEngine.SetMultiplePositions(in_GameObjectID:  this.gameObject, in_pPositions:  val_5, in_NumPositions:  val_5.Count, in_eMultiPositionType:  this.MultiPositionType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void OnDisable()
    {
        var val_12;
        var val_13;
        if(this.multiPositionTypeLabel != 2)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        AkMultiPosEvent val_2 = AkAmbient.multiPosEventTree.Item[X21.Id];
        if(val_2.list.Count == 1)
        {
                val_13 = null;
            val_13 = null;
            bool val_5 = AkAmbient.multiPosEventTree.Remove(key:  val_2.Id);
            return;
        }
        
        AkPositionArray val_7 = val_2.list.Remove(item:  this).BuildMultiDirectionArray(eventPosList:  val_2);
        AKRESULT val_11 = AkSoundEngine.SetMultiplePositions(in_GameObjectID:  val_2.list.Item[0].gameObject, in_pPositions:  val_7, in_NumPositions:  val_7.Count, in_eMultiPositionType:  this.MultiPositionType);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public override void HandleEvent(UnityEngine.GameObject in_gameObject)
    {
        var val_7;
        if(this.multiPositionTypeLabel != 2)
        {
            goto label_1;
        }
        
        val_7 = null;
        val_7 = null;
        AkMultiPosEvent val_2 = AkAmbient.multiPosEventTree.Item[Id];
        if(val_2.eventIsPlaying == false)
        {
            goto label_7;
        }
        
        return;
        label_1:
        this.HandleEvent(in_gameObject:  in_gameObject);
        return;
        label_7:
        val_2.eventIsPlaying = true;
        UnityEngine.GameObject val_4 = val_2.list.Item[0].gameObject;
        mem[1152921519427110456] = val_4;
        if((public AkAmbient System.Collections.Generic.List<AkAmbient>::get_Item(int index)) != 0)
        {
                X22.ExecuteAction(gameObject:  val_4, actionOnEventType:  val_2, transitionDuration:  (int)S8 * 1000, curveInterpolation:  this);
            return;
        }
        
        mem[1152921519427166976] = val_2;
        mem[1152921519427166984] = public System.Void AkMultiPosEvent::FinishedPlaying(object in_cookie, AkCallbackType in_type, object in_info);
        mem[1152921519427166960] = public System.Void AkMultiPosEvent::FinishedPlaying(object in_cookie, AkCallbackType in_type, object in_info);
        mem[1152921519427110448] = X22.Post(gameObject:  val_4, flags:  1, callback:  new AkCallbackManager.EventCallback(), cookie:  0);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void OnDrawGizmosSelected()
    {
        UnityEngine.Vector3 val_2 = this.transform.position;
        UnityEngine.Gizmos.DrawIcon(center:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, name:  "WwiseAudioSpeaker.png", allowScaling:  false);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkPositionArray BuildMultiDirectionArray(AkMultiPosEvent eventPosList)
    {
        var val_13;
        AkPositionArray val_2 = new AkPositionArray(in_Count:  eventPosList.list.Count);
        val_13 = 0;
        goto label_3;
        label_15:
        UnityEngine.Vector3 val_5 = eventPosList.list.Item[0].transform.position;
        UnityEngine.Vector3 val_8 = eventPosList.list.Item[0].transform.forward;
        UnityEngine.Vector3 val_11 = eventPosList.list.Item[0].transform.up;
        val_2.Add(in_Pos:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, in_Forward:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, in_Top:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z, z = ???});
        val_13 = 1;
        label_3:
        if(val_13 < eventPosList.list.Count)
        {
            goto label_15;
        }
        
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private AkPositionArray BuildAkPositionArray()
    {
        var val_13;
        var val_14;
        System.Collections.Generic.List<AkAmbientLargeModePositioner> val_1 = new System.Collections.Generic.List<AkAmbientLargeModePositioner>();
        val_13 = 0;
        goto label_1;
        label_15:
        if(this.LargeModePositions[0] != 0)
        {
                if((val_1.Contains(item:  this.LargeModePositions[0])) != true)
        {
                val_1.Add(item:  this.LargeModePositions[0]);
        }
        
        }
        
        val_13 = 1;
        label_1:
        if(val_13 < this.LargeModePositions.Length)
        {
            goto label_15;
        }
        
        AkPositionArray val_5 = new AkPositionArray(in_Count:  val_1.Count);
        val_14 = 0;
        goto label_17;
        label_26:
        UnityEngine.Vector3 val_7 = val_1.Item[0].Position;
        UnityEngine.Vector3 val_9 = val_1.Item[0].Forward;
        UnityEngine.Vector3 val_11 = val_1.Item[0].Up;
        val_5.Add(in_Pos:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, in_Forward:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, in_Top:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.z, z = ???});
        val_14 = 1;
        label_17:
        if(val_14 < val_1.Count)
        {
            goto label_26;
        }
        
        return val_5;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public AkAmbient()
    {
        this.MultiPositionType = 1;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static AkAmbient()
    {
        AkTriggerBase.Trigger.__error = new System.Collections.Generic.Dictionary<System.UInt32, AkMultiPosEvent>();
    }

}
