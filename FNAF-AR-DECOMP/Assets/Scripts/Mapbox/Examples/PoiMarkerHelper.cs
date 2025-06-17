using UnityEngine;

namespace Mapbox.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class PoiMarkerHelper : MonoBehaviour, IFeaturePropertySettable
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, object> _props;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Set(System.Collections.Generic.Dictionary<string, object> props)
        {
            this._props = props;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnMouseUpAsButton()
        {
            Dictionary.Enumerator<TKey, TValue> val_1 = this._props.GetEnumerator();
            label_5:
            if(((-1927848664) & 1) == 0)
            {
                    return;
            }
            
            UnityEngine.XR.ARSubsystems.TrackableId val_2 = 0.trackableId;
            UnityEngine.Debug.Log(message:  val_2.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Object>::get_Key())(val_2.m_SubId1.System.IConvertible.ToUInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Object>::get_Key())) + ":"(":") + val_2.m_SubId1);
            goto label_5;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public PoiMarkerHelper()
        {
        
        }
    
    }

}
