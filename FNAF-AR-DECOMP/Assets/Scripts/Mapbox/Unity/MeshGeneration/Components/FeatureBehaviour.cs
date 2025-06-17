using UnityEngine;

namespace Mapbox.Unity.MeshGeneration.Components
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class FeatureBehaviour : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.VectorEntity VectorEntity;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Transform Transform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity Data;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public string DataString;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowDebugData()
        {
            var val_5;
            System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_7;
            val_5 = null;
            val_5 = null;
            val_7 = FeatureBehaviour.<>c.<>9__4_0;
            if(val_7 == null)
            {
                    System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String> val_1 = null;
                val_7 = val_1;
                val_1 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(object:  FeatureBehaviour.<>c.__il2cppRuntimeField_static_fields, method:  System.String FeatureBehaviour.<>c::<ShowDebugData>b__4_0(System.Collections.Generic.KeyValuePair<string, object> x));
                FeatureBehaviour.<>c.<>9__4_0 = val_7;
            }
            
            this.DataString = System.String.Join(separator:  "\r\n", value:  System.Linq.Enumerable.ToArray<System.String>(source:  System.Linq.Enumerable.Select<System.Collections.Generic.KeyValuePair<System.String, System.Object>, System.String>(source:  this.Data.Properties, selector:  val_1)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ShowDataPoints()
        {
            var val_3;
            var val_14;
            var val_15;
            val_14 = this;
            List.Enumerator<T> val_1 = this.VectorEntity.Feature.Points.GetEnumerator();
            goto label_4;
            label_14:
            GameUI.EmailUIDataHandler val_4 = val_3.emailUIDataHandler;
            val_15 = 0;
            goto label_5;
            label_13:
            UnityEngine.GameObject val_5 = UnityEngine.GameObject.CreatePrimitive(type:  0);
            val_5.name = 0.ToString();
            val_5.transform.SetParent(parent:  this.transform, worldPositionStays:  false);
            UnityEngine.Vector3 val_10 = val_4.Item[0];
            val_5.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            val_15 = 1;
            label_5:
            if(val_15 < val_4.Count)
            {
                goto label_13;
            }
            
            label_4:
            if(((-2015627760) & 1) != 0)
            {
                goto label_14;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(Mapbox.Unity.MeshGeneration.Data.VectorEntity ve)
        {
            this.VectorEntity = ve;
            this.Transform = this.transform;
            this.Data = ve.Feature;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Initialize(Mapbox.Unity.MeshGeneration.Data.VectorFeatureUnity feature)
        {
            this.Transform = this.transform;
            this.Data = feature;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public FeatureBehaviour()
        {
        
        }
    
    }

}
