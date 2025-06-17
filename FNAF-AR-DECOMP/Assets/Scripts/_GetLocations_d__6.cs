using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class LocationLogReader.<GetLocations>d__6 : IEnumerator<Mapbox.Unity.Location.Location>, IEnumerator, IDisposable
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private int <>1__state;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Location.Location <>2__current;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Unity.Location.LocationLogReader <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private string[] <tokens>5__2;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Location.Location System.Collections.Generic.IEnumerator<Mapbox.Unity.Location.Location>.Current { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public LocationLogReader.<GetLocations>d__6(int <>1__state)
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
        var val_2;
        var val_46;
        var val_47;
        System.IO.TextReader val_48;
        System.String[] val_49;
        var val_50;
        int val_51;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        val_46 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_47 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_47;
        }
        
        this.<>1__state = 0;
        goto label_23;
        label_1:
        this.<>1__state = 0;
        this.<tokens>5__2 = 0;
        goto label_23;
        label_17:
        label_22:
        val_48 = this.<>4__this._textReader;
        if(val_48 != null)
        {
                val_48 = 0;
        }
        
        val_46 = 0;
        val_48.DiscardBufferedData();
        label_23:
        if((this.<>4__this._textReader) != null)
        {
                if((System.String.IsNullOrEmpty(value:  this.<>4__this._textReader)) == false)
        {
            goto label_16;
        }
        
        }
        
        if((this.<>4__this._textReader) == null)
        {
            goto label_17;
        }
        
        goto label_22;
        label_16:
        if((this.<>4__this._textReader.StartsWith(value:  "#")) == true)
        {
            goto label_23;
        }
        
        System.String[] val_9 = this.<>4__this._textReader.Split(separator:  ToCharArray());
        val_49 = this;
        this.<tokens>5__2 = val_9;
        val_50 = val_9.HeaderNames;
        if(val_9.Length == val_10.Length)
        {
            goto label_27;
        }
        
        UnityEngine.Debug.LogError(message:  "unsupported log file");
        val_51 = 1;
        goto label_30;
        label_2:
        val_49 = this.<tokens>5__2;
        this.<>1__state = 0;
        label_27:
        bool val_12 = System.Boolean.Parse(value:  mem[this.<tokens>5__2] + 32);
        bool val_14 = System.Boolean.Parse(value:  mem[this.<tokens>5__2] + 40);
        bool val_16 = System.Boolean.Parse(value:  mem[this.<tokens>5__2] + 48);
        bool val_18 = System.Boolean.Parse(value:  mem[this.<tokens>5__2] + 56);
        if((System.DateTime.TryParseExact(s:  mem[this.<tokens>5__2] + 80, format:  "yyyyMMdd-HHmmss.fff", provider:  X21, style:  64, result: out  new System.DateTime())) != false)
        {
                double val_20 = Mapbox.Utils.UnixTimestampUtils.To(date:  new System.DateTime());
        }
        
        if((System.DateTime.TryParseExact(s:  mem[this.<tokens>5__2] + 88, format:  "yyyyMMdd-HHmmss.fff", provider:  X21, style:  64, result: out  new System.DateTime())) != false)
        {
                double val_22 = Mapbox.Utils.UnixTimestampUtils.To(date:  new System.DateTime());
        }
        
        if(((System.Double.TryParse(s:  mem[this.<tokens>5__2] + 96, style:  511, provider:  1152921504617603072, result: out  double val_23 = 1.28823409707913E-231)) != false) && ((System.Double.TryParse(s:  mem[this.<tokens>5__2] + 104, style:  511, provider:  mem[this.<tokens>5__2] + 96, result: out  double val_25 = 1.28823409707913E-231)) != false))
        {
                val_2 = 0;
            Mapbox.Utils.Vector2d val_27 = new Mapbox.Utils.Vector2d(x:  0, y:  0);
        }
        else
        {
                Mapbox.Utils.Vector2d val_28 = Mapbox.Utils.Vector2d.zero;
        }
        
        var val_31 = ((System.Single.TryParse(s:  mem[this.<tokens>5__2] + 112, style:  511, provider:  0, result: out  float val_29 = -1.564972E-33f)) != true) ? 0f : 0f;
        var val_34 = ((System.Single.TryParse(s:  mem[this.<tokens>5__2] + 120, style:  511, provider:  0, result: out  float val_32 = -1.564971E-33f)) != true) ? 0f : 0f;
        var val_37 = ((System.Single.TryParse(s:  mem[this.<tokens>5__2] + 128, style:  511, provider:  0, result: out  float val_35 = -1.56497E-33f)) != true) ? 0f : 0f;
        val_53 = 0;
        if((System.Single.TryParse(s:  mem[this.<tokens>5__2] + 136, style:  511, provider:  0, result: out  float val_38 = -1.564969E-33f)) != false)
        {
                float val_46 = 0f;
            val_2 = 0;
            val_46 = val_46 / 3.6f;
            val_53 = val_2;
        }
        
        if((System.Boolean.TryParse(value:  mem[this.<tokens>5__2] + 144, result: out  false)) != false)
        {
                val_2 = 0;
            val_54 = val_2;
        }
        else
        {
                val_54 = 0;
        }
        
        val_55 = 0;
        if((System.Int32.TryParse(s:  mem[this.<tokens>5__2] + 152, result: out  0)) != false)
        {
                val_2 = 0;
            val_55 = val_2;
        }
        
        val_56 = 0;
        if((System.Int32.TryParse(s:  mem[this.<tokens>5__2] + 160, result: out  0)) != false)
        {
                val_2 = 0;
            val_56 = val_2;
        }
        
        val_51 = 2;
        label_30:
        val_47 = 1;
        this.<>1__state = val_51;
        return (bool)val_47;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Location.Location System.Collections.Generic.IEnumerator<Mapbox.Unity.Location.Location>.get_Current()
    {
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private object System.Collections.IEnumerator.get_Current()
    {
        return -1995860120;
    }

}
