using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class DeviceLocationProvider.<PollLocationRoutine>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Location.DeviceLocationProvider <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <maxWait>5__2;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private System.Globalization.CultureInfo <invariantCulture>5__3;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public DeviceLocationProvider.<PollLocationRoutine>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.IDisposable.Dispose()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool MoveNext()
    {
        Mapbox.Unity.Location.DeviceLocationProvider val_53;
        UnityEngine.WaitForSeconds val_56;
        int val_57;
        string val_59;
        float val_62;
        int val_67;
        Mapbox.Utils.CircularBuffer<Mapbox.Utils.Vector2d> val_72;
        double val_81;
        double val_83;
        double val_85;
        double val_88;
        int val_89;
        int val_90;
        int val_92;
        var val_93;
        if((this.<>1__state) > 4)
        {
            goto label_1;
        }
        
        var val_64 = 52951904 + (this.<>1__state) << 2;
        val_53 = this.<>4__this;
        val_64 = val_64 + 52951904;
        goto (52951904 + (this.<>1__state) << 2 + 52951904);
        label_1:
        val_57 = 0;
        return (bool)val_57;
        val_85 = ;
        val_83 = this.<>4__this + 32;
        this.<>4__this._lastPositions.Add(item:  new Mapbox.Utils.Vector2d() {x = val_85, y = val_83});
        if((this.<>4__this._lastPositions.Count) >= (this.<>4__this._maxLastPositions))
        {
            goto label_134;
        }
        
        val_72 = ;
        goto label_135;
        label_134:
        Mapbox.Utils.Vector2d val_45 = this.<>4__this._lastPositions.Item[0];
        val_81 = val_45.x;
        Mapbox.Utils.Vector2d val_47 = this.<>4__this._lastPositions.Item[(this.<>4__this._maxLastPositions) - 1];
        val_62 = val_47.x;
        Mapbox.CheapRulerCs.CheapRuler val_48 = null;
        val_88 = val_81;
        val_48 = new Mapbox.CheapRulerCs.CheapRuler(latitude:  val_88, outputUnits:  3);
        double[] val_49 = new double[2];
        val_59 = val_49;
        val_89 = val_49.Length;
        if(val_89 == 0)
        {
                val_89 = val_49.Length;
        }
        
        val_59[0] = val_45.y;
        val_59[1] = val_81;
        double[] val_50 = new double[2];
        val_90 = val_50.Length;
        if(val_90 == 0)
        {
                val_90 = val_50.Length;
        }
        
        val_50[0] = val_47.y;
        val_50[1] = val_62;
        if((val_48.Distance(a:  val_49, b:  val_50)) < (this.<>4__this._minDistanceOldestNewestPosition))
        {
            goto label_145;
        }
        
        val_92 = (this.<>4__this._maxLastPositions) - 1;
        float[] val_52 = new float[0];
        if((this.<>4__this._maxLastPositions) >= 2)
        {
                int val_76 = 1;
            do
        {
            Mapbox.Utils.Vector2d val_53 = this.<>4__this._lastPositions.Item[1];
            double val_78 = val_53.x;
            val_76 = val_76 - 1;
            Mapbox.Utils.Vector2d val_54 = this.<>4__this._lastPositions.Item[val_76];
            int val_55 = val_76 + 1;
            Mapbox.Utils.Vector2d val_56 = this.<>4__this._lastPositions.Item[val_55];
            val_55 = val_55 - 1;
            val_92 = val_55;
            Mapbox.Utils.Vector2d val_57 = this.<>4__this._lastPositions.Item[val_92];
            val_81 = val_56.y - val_57.y;
            float val_77 = -(val_78 - val_54.x);
            val_77 = val_77 * 180;
            val_77 = val_77 / 3.14159265358979;
            val_77 = val_77 + 90;
            double val_59 = val_77 + 360;
            val_77 = (val_77 < 0) ? (val_59) : (val_77);
            val_59 = val_77 + (-360);
            val_78 = (val_77 < 360) ? (val_77) : (val_59);
            if(val_55 >= val_52.Length)
        {
                val_92 = 0;
        }
        
            val_52[(long)val_76] = (float)val_78;
        }
        while((val_55 + 2) < (this.<>4__this._maxLastPositions));
        
            val_93 = val_53;
            val_59 = this.<>4__this._userHeadingSmoothing;
            val_72 = ;
        }
        else
        {
                val_93 = val_53;
            val_59 = this.<>4__this._userHeadingSmoothing;
            val_72 = ;
        }
        
        if(val_52.Length == 0)
        {
                val_92 = 0;
        }
        
        val_62 = val_52[0];
        val_59.Add(angle:  (double)val_62);
        var val_61 = ((float)(double)val_62 < 180f) ? 1 : 0;
        val_88 = (52951848 + (float)(double)val_62 < 180f ? 1 : 0) + (float)(double)val_62;
        label_135:
        mem2[0] = val_88;
        mem[120] = 1;
        label_145:
        System.DateTime val_62 = System.DateTime.UtcNow;
        mem2[0] = Mapbox.Utils.UnixTimestampUtils.To(date:  new System.DateTime() {dateData = val_62.dateData});
        val_53.SendLocation(location:  new Mapbox.Unity.Location.Location() {LatitudeLongitude = new Mapbox.Utils.Vector2d() {x = val_33.x, y = val_34.y}, IsLocationServiceInitializing = false, IsLocationServiceEnabled = false, IsLocationUpdated = false, HasGpsFix = new System.Nullable<System.Boolean>() {HasValue = false}, SatellitesInView = new System.Nullable<System.Int32>() {HasValue = false}, SatellitesUsed = new System.Nullable<System.Int32>() {HasValue = false}, SpeedMetersPerSecond = new System.Nullable<System.Single>() {HasValue = false}, IsUserHeadingUpdated = false});
        val_56 = this.<>4__this._waitUpdateTime;
        val_67 = 4;
        val_57 = 1;
        this.<>1__state = val_67;
        this.<>2__current = val_56;
        return (bool)val_57;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
