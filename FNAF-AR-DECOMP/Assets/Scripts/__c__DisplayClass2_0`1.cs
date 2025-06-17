using UnityEngine;
[System.Runtime.InteropServices.ComVisibleAttribute]
private sealed class Geocoder.<>c__DisplayClass2_0<T>
{
    // Fields
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Mapbox.Geocoding.Geocoder <>4__this;
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public System.Action<Mapbox.Geocoding.ReverseGeocodeResponse> callback;
    
    // Methods
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public Geocoder.<>c__DisplayClass2_0<T>()
    {
        if(this != null)
        {
                return;
        }
    
    }
    [System.Runtime.InteropServices.ComVisibleAttribute]
    internal void <Geocode>b__0(Mapbox.Platform.Response response)
    {
        System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
        val_1.Invoke(obj:  val_1.Deserialize<Mapbox.Geocoding.ReverseGeocodeResponse>(str:  val_1));
    }

}
