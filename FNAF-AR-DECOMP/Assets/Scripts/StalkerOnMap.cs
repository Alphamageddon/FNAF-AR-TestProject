using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
public class StalkerOnMap : MonoBehaviour
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Map.AbstractMap map;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject stalkerPrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float stalkerScale;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject playerPrefab;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float playerScale;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Utils.Vector2d stalkerLocationMeters;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject stalkerObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.GameObject playerObject;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isMapInitialized;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool isAttacking;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private float attackTimer;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Location.ILocationProvider _locationProvider;
    
    // Properties
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Utils.Vector2d stalkerLocationLatLong { get; }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Location.ILocationProvider LocationProvider { get; }
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Utils.Vector2d get_stalkerLocationLatLong()
    {
        return Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = this.stalkerLocationMeters});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Unity.Location.ILocationProvider get_LocationProvider()
    {
        if(this._locationProvider != null)
        {
                return val_2;
        }
        
        Mapbox.Unity.Location.ILocationProvider val_2 = Mapbox.Unity.Location.LocationProviderFactory.Instance.DefaultLocationProvider;
        this._locationProvider = val_2;
        return val_2;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private Mapbox.Utils.Vector2d GetMapCenterMeters()
    {
        if(this.isMapInitialized == false)
        {
                return Mapbox.Utils.Vector2d.zero;
        }
        
        Mapbox.Utils.Vector2d val_1 = this.map.CenterLatitudeLongitude;
        return Mapbox.Unity.Utilities.Conversions.LatLonToMeters(v:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y});
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void RecenterMap()
    {
        double val_5;
        double val_6;
        if(this.isMapInitialized == false)
        {
                return;
        }
        
        Mapbox.Utils.Vector2d val_1 = this.map.CenterLatitudeLongitude;
        var val_8 = 0;
        val_8 = val_8 + 1;
        Mapbox.Unity.Location.Location val_4 = this.LocationProvider.CurrentLocation;
        Mapbox.Utils.Vector2d val_7 = Mapbox.Utils.Vector2d.Lerp(from:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, to:  new Mapbox.Utils.Vector2d() {x = val_5, y = val_6}, t:  0.00999999977648258);
        this = this.map;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private bool IsNearCenter()
    {
        Mapbox.Utils.Vector2d val_1 = this.GetMapCenterMeters();
        Mapbox.Utils.Vector2d val_2 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = this.stalkerLocationMeters});
        return (bool)(val_2.x.magnitude < 0) ? 1 : 0;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InitStalker()
    {
        UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.stalkerPrefab);
        this.stalkerObject = val_1;
        UnityEngine.Vector3 val_3 = this.GetCurrentStalkerPosition();
        val_1.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.stalkerObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void InitPlayer()
    {
        UnityEngine.GameObject val_1 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.playerPrefab);
        this.playerObject = val_1;
        UnityEngine.Vector3 val_3 = this.GetCurrentPlayerPosition();
        val_1.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        this.playerObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void SetRandomStalkerLocationAroundMapCenter()
    {
        Mapbox.Utils.Vector2d val_1 = this.GetMapCenterMeters();
        this.stalkerLocationMeters = val_1;
        mem[1152921519089173864] = val_1.y;
        float val_3 = ((UnityEngine.Random.Range(min:  0, max:  2)) == 0) ? -1f : 1f;
        float val_6 = UnityEngine.Random.Range(min:  25f, max:  50f);
        val_6 = val_3 * val_6;
        double val_8 = (double)val_6;
        val_8 = this.stalkerLocationMeters + val_8;
        this.stalkerLocationMeters = val_8;
        float val_7 = UnityEngine.Random.Range(min:  25f, max:  50f);
        val_7 = (((UnityEngine.Random.Range(min:  0, max:  2)) == 0) ? -1f : 1f) * val_7;
        double val_9 = (double)val_7;
        val_9 = val_3 + val_9;
        mem[1152921519089173864] = val_9;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 GetCurrentStalkerPosition()
    {
        var val_8;
        if(this.isMapInitialized == false)
        {
                return UnityEngine.Vector3.zero;
        }
        
        Mapbox.Utils.Vector2d val_1 = Mapbox.Unity.Utilities.Conversions.MetersToLatLon(m:  new Mapbox.Utils.Vector2d() {x = this.stalkerLocationMeters});
        val_8 = ???;
        goto typeof(Mapbox.Unity.Map.AbstractMap).__il2cppRuntimeField_398;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private UnityEngine.Vector3 GetCurrentPlayerPosition()
    {
        var val_3;
        var val_4;
        if(this.isMapInitialized == false)
        {
                return UnityEngine.Vector3.zero;
        }
        
        if(this.map != null)
        {
                Mapbox.Utils.Vector2d val_1 = this.map.CenterLatitudeLongitude;
            val_3 = val_1.x;
            val_4 = val_1.y;
        }
        else
        {
                Mapbox.Utils.Vector2d val_2 = 0.CenterLatitudeLongitude;
            val_3 = val_2.x;
            val_4 = val_2.y;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdateStalkerPosition()
    {
        float val_6;
        var val_7;
        if(this.isAttacking == false)
        {
            goto label_0;
        }
        
        val_6 = this.attackTimer;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = val_6 - val_1;
        this.attackTimer = val_1;
        if(val_1 > 0f)
        {
                return;
        }
        
        this.SetRandomStalkerLocationAroundMapCenter();
        this.isAttacking = false;
        this.attackTimer = 0f;
        val_7 = 1;
        goto label_3;
        label_0:
        if(this.IsNearCenter() == false)
        {
            goto label_4;
        }
        
        this.isAttacking = true;
        this.attackTimer = 3f;
        val_7 = 0;
        label_3:
        this.stalkerObject.SetActive(value:  false);
        return;
        label_4:
        UnityEngine.Vector3 val_4 = this.GetCurrentStalkerPosition();
        val_6 = val_4.x;
        this.stalkerObject.transform.localPosition = new UnityEngine.Vector3() {x = val_6, y = val_4.y, z = val_4.z};
        this.stalkerObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void UpdatePlayerPosition()
    {
        UnityEngine.Vector3 val_2 = this.GetCurrentPlayerPosition();
        this.playerObject.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.playerObject.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void MoveStalkerTowardsMapCenter()
    {
        if(this.isMapInitialized == false)
        {
                return;
        }
        
        Mapbox.Utils.Vector2d val_1 = this.GetMapCenterMeters();
        Mapbox.Utils.Vector2d val_2 = Mapbox.Utils.Vector2d.op_Subtraction(a:  new Mapbox.Utils.Vector2d() {x = val_1.x, y = val_1.y}, b:  new Mapbox.Utils.Vector2d() {x = this.stalkerLocationMeters});
        Mapbox.Utils.Vector2d val_3 = Mapbox.Utils.Vector2d.op_Multiply(a:  new Mapbox.Utils.Vector2d() {x = val_2.x, y = val_2.y}, d:  3);
        Mapbox.Utils.Vector2d val_5 = Mapbox.Utils.Vector2d.op_Multiply(a:  new Mapbox.Utils.Vector2d() {x = val_3.x, y = val_3.y}, d:  (double)UnityEngine.Time.deltaTime);
        Mapbox.Utils.Vector2d val_6 = Mapbox.Utils.Vector2d.op_Addition(a:  new Mapbox.Utils.Vector2d() {x = this.stalkerLocationMeters, y = V9.16B}, b:  new Mapbox.Utils.Vector2d() {x = val_5.x, y = val_5.y});
        this.stalkerLocationMeters = val_6;
        mem[1152921519089832168] = val_6.y;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Start()
    {
        this.map.add_OnInitialized(value:  new System.Action(object:  this, method:  System.Void StalkerOnMap::<Start>b__27_0()));
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void Update()
    {
        if(this.isMapInitialized == false)
        {
                return;
        }
        
        this.RecenterMap();
        if(this.isMapInitialized == false)
        {
                return;
        }
        
        this.MoveStalkerTowardsMapCenter();
        this.UpdatePlayerPosition();
        this.UpdateStalkerPosition();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public StalkerOnMap()
    {
        this.stalkerScale = 100f;
        this.playerScale = 100f;
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    private void <Start>b__27_0()
    {
        this.isMapInitialized = true;
        this.SetRandomStalkerLocationAroundMapCenter();
        this.InitStalker();
        this.InitPlayer();
    }

}
