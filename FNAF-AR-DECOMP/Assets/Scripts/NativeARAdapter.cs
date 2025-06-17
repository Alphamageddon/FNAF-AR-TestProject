using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class NativeARAdapter
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.XR.ARFoundation.ARPointCloudManager m_ARPointCloudManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.XR.ARFoundation.ARPlaneManager m_ARPlaneManager;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool firstTime;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TimeUpdateDispenser earlyTimeDispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private TimeUpdateDispenser lateTimeDispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private ARPlaneDispenser planeDispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private PointDispenser pointDispenser;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int prevCount;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 prevFirst;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3[] pointsBuffer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static NativeARAdapter.SessionSetupComplete SessionSetupCompletedEvent;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Setup(TimeUpdateDispenser earlyTimeDispenser, TimeUpdateDispenser lateTimeDispenser, PointDispenser pointDispenser, ARPlaneDispenser planeDispenser, UnityEngine.XR.ARFoundation.ARPointCloudManager pointCloudManager, UnityEngine.XR.ARFoundation.ARPlaneManager planeManager)
    {
        this.earlyTimeDispenser = earlyTimeDispenser;
        this.lateTimeDispenser = lateTimeDispenser;
        this.planeDispenser = planeDispenser;
        this.pointDispenser = pointDispenser;
        this.m_ARPointCloudManager = pointCloudManager;
        pointCloudManager.add_pointCloudsChanged(value:  new System.Action<UnityEngine.XR.ARFoundation.ARPointCloudChangedEventArgs>(object:  this, method:  System.Void NativeARAdapter::PointCloudUpdated(UnityEngine.XR.ARFoundation.ARPointCloudChangedEventArgs args)));
        this.m_ARPlaneManager = planeManager;
        planeManager.add_planesChanged(value:  new System.Action<UnityEngine.XR.ARFoundation.ARPlanesChangedEventArgs>(object:  this, method:  System.Void NativeARAdapter::PlanesUpdated(UnityEngine.XR.ARFoundation.ARPlanesChangedEventArgs args)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public void Teardown()
    {
        this.m_ARPointCloudManager.remove_pointCloudsChanged(value:  new System.Action<UnityEngine.XR.ARFoundation.ARPointCloudChangedEventArgs>(object:  this, method:  System.Void NativeARAdapter::PointCloudUpdated(UnityEngine.XR.ARFoundation.ARPointCloudChangedEventArgs args)));
        this.m_ARPlaneManager.remove_planesChanged(value:  new System.Action<UnityEngine.XR.ARFoundation.ARPlanesChangedEventArgs>(object:  this, method:  System.Void NativeARAdapter::PlanesUpdated(UnityEngine.XR.ARFoundation.ARPlanesChangedEventArgs args)));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void PlanesUpdated(UnityEngine.XR.ARFoundation.ARPlanesChangedEventArgs args)
    {
        var val_9;
        UnityEngine.XR.ARFoundation.ARPlane val_10;
        var val_11;
        val_9 = 0;
        goto label_1;
        label_5:
        val_10 = args.<added>k__BackingField.emailUIDataHandler.Item[0];
        this.planeDispenser.SendPlaneAddedEvent(plane:  val_10);
        val_9 = 1;
        label_1:
        if(val_9 < (args.<added>k__BackingField.emailUIDataHandler.Count))
        {
            goto label_5;
        }
        
        val_11 = 0;
        goto label_6;
        label_10:
        val_10 = args.<added>k__BackingField.emailUIDataHandler.Item[0];
        this.planeDispenser.SendPlaneRemovedEvent(plane:  val_10);
        val_11 = 1;
        label_6:
        if(val_11 < (args.<added>k__BackingField.emailUIDataHandler.Count))
        {
            goto label_10;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void add_SessionSetupCompletedEvent(NativeARAdapter.SessionSetupComplete value)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  NativeARAdapter.SessionSetupCompletedEvent, b:  value);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public static void remove_SessionSetupCompletedEvent(NativeARAdapter.SessionSetupComplete value)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  NativeARAdapter.SessionSetupCompletedEvent, value:  value);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private static System.Type GetTypeFromHandle(IntPtr handle)
    {
        var val_7;
        object[] val_3 = new object[1];
        val_3[0] = handle;
        if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()).GetMethod(name:  "GetTypeFromHandleUnsafe", bindingAttr:  40).Invoke(obj:  0, parameters:  val_3)) == null)
        {
                return (System.Type)val_7;
        }
        
        val_7 = 0;
        return (System.Type)val_7;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void PointCloudUpdated(UnityEngine.XR.ARFoundation.ARPointCloudChangedEventArgs args)
    {
        TimeUpdateDispenser val_13;
        TimeUpdateDispenser val_14;
        UnityEngine.Vector3[] val_15;
        val_13 = this;
        val_14 = args.<added>k__BackingField.emailUIDataHandler;
        val_14.AddRange(collection:  args.<added>k__BackingField);
        GameUI.EmailUIDataHandler val_2 = args.<added>k__BackingField.emailUIDataHandler;
        if(val_2.Count == 0)
        {
                return;
        }
        
        if(this.firstTime != false)
        {
                UnityEngine.XR.ARFoundation.ARSession val_4 = UnityEngine.Object.FindObjectOfType<UnityEngine.XR.ARFoundation.ARSession>();
            if(val_4 == 0)
        {
                ConsoleLogger.LogError(className:  "NativeARAdapter", functionName:  "PointCloudUpdated", logString:  "ERROR: ARSession GameObject not found!");
        }
        
            UnityCVManager_Android.Instance.SetupSession(p:  val_4.subsystem.nativePtr);
            if(NativeARAdapter.SessionSetupCompletedEvent != null)
        {
                NativeARAdapter.SessionSetupCompletedEvent.Invoke();
        }
        
            this.firstTime = false;
        }
        
        val_14 = this.earlyTimeDispenser;
        val_14.SendTimeUpdateEvent();
        if(val_2.Count != 1)
        {
                ConsoleLogger.LogError(className:  "NativeARAdapter", functionName:  "PointCloudUpdated", logString:  "# of PC != 1");
        }
        
        Unity.Collections.NativeArray<UnityEngine.Vector3> val_11 = val_2.Item[0].positions;
        this.pointsBuffer = ;
        if((((???) != 0) && (this.prevCount != this.pointsBuffer.Length)) && ((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = this.prevFirst, y = V9.16B, z = V10.16B}, rhs:  new UnityEngine.Vector3() {x = this.pointsBuffer[0], y = this.pointsBuffer[0], z = this.pointsBuffer[0]})) != true))
        {
                val_15 = this.pointsBuffer;
            this.prevFirst = this.pointsBuffer[0];
            mem[1152921518921053652] = this.pointsBuffer[0];
            if(this.pointsBuffer == null)
        {
                val_15 = this.pointsBuffer;
        }
        
            val_14 = this.pointDispenser;
            this.prevCount = this.pointsBuffer.Length;
            val_14.SendPointUpdateEvent(pointData:  val_15);
        }
        
        val_13 = this.lateTimeDispenser;
        val_13.SendTimeUpdateEvent();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public NativeARAdapter()
    {
        this.firstTime = true;
    }

}
