using UnityEngine;

namespace SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class IxSceneRecognitionVisualizer : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.GameObject textObject;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.UI.Text text;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const float DECAY = 0.9;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, float> smoothedLabelScore;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.Dictionary<string, float> updatedLabels;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float totalCount;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private string UpdateSmoothedProbs(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSceneRecognition recognition)
        {
            var val_12;
            float val_13;
            float val_14;
            var val_15;
            string val_16;
            this.updatedLabels.Clear();
            val_12 = 0;
            val_13 = 0f;
            goto label_2;
            label_12:
            val_14 = mem[X27 + 32];
            val_14 = X27 + 32;
            this.updatedLabels.set_Item(key:  recognition.SceneLabels.Length + 32, value:  val_14);
            if((this.smoothedLabelScore.ContainsKey(key:  recognition.SceneLabels.Length + 32)) != true)
            {
                    this.smoothedLabelScore.set_Item(key:  recognition.SceneLabels.Length + 32, value:  0f);
            }
            
            val_13 = val_13 + (X27 + 32);
            val_12 = 1;
            label_2:
            if(val_12 < recognition.SceneLabels.Length)
            {
                goto label_12;
            }
            
            val_15 = "";
            System.Collections.Generic.List<System.String> val_3 = null;
            val_16 = val_3;
            val_3 = new System.Collections.Generic.List<System.String>(collection:  this.smoothedLabelScore.Keys);
            List.Enumerator<T> val_4 = val_3.GetEnumerator();
            goto label_19;
            label_20:
            val_16 = 0.emailUIDataHandler;
            float val_13 = this.smoothedLabelScore.Item[val_16];
            float val_12 = 0f;
            float val_9 = val_13 * 0.9f;
            val_12 = val_9 + val_12;
            val_13 = ((this.updatedLabels.TryGetValue(key:  val_16, value: out  float val_7 = 1.143612E+11f)) != true) ? (val_12) : (val_9);
            this.smoothedLabelScore.set_Item(key:  val_16, value:  val_13);
            if(val_13 > 0f)
            {
                    val_15 = val_16;
            }
            
            label_19:
            if((1372914536 & 1) != 0)
            {
                goto label_20;
            }
            
            float val_14 = this.totalCount;
            val_14 = val_14 * 0.9f;
            val_14 = val_13 + val_14;
            this.totalCount = val_14;
            return (string)val_15;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void IxSceneRecognitionDelivererOnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSceneRecognition recognition)
        {
            UnityEngine.UI.Text val_20;
            object val_21;
            val_20 = this;
            UnityEngine.Vector3 val_2 = this._camera.transform.right;
            UnityEngine.Vector3 val_4 = this._camera.transform.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = 0f, z = val_2.z}, d:  UnityEngine.Mathf.Sign(f:  val_4.y));
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, rhs:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_10 = this._camera.transform.forward;
            float val_20 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, to:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_13 = this._camera.transform.forward;
            val_20 = val_20 * (UnityEngine.Mathf.Sign(f:  val_13.y));
            if((val_20 > (-25f)) && (val_20 < 0))
            {
                    val_21 = this.UpdateSmoothedProbs(recognition:  new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSceneRecognition() {SceneLabels = recognition.SceneLabels, SceneProbs = recognition.SceneProbs});
                if(recognition.SceneLabels.Length == 0)
            {
                    return;
            }
            
                object[] val_16 = new object[4];
                val_16[0] = "Smoothed label: ";
                val_16[1] = val_21;
                val_16[2] = "\nPitch: ";
                val_21 = val_20;
                val_16[3] = val_21;
                val_20 = +val_16;
                if(this.text != null)
            {
                    return;
            }
            
                return;
            }
            
            val_20 = this.text;
            object[] val_18 = new object[4];
            val_21 = val_18;
            val_21[0] = "Out of recommended pitch! Top label: ";
            val_21[1] = mem[recognition.SceneLabels + 32];
            val_21[2] = "\nPitch: ";
            val_21[3] = val_20;
            string val_19 = +val_18;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Start()
        {
            this.text = this.textObject.GetComponent<UnityEngine.UI.Text>();
            this._camera = this.GetComponentInParent<UnityEngine.XR.ARFoundation.ARSessionOrigin>().gameObject.GetComponentInChildren<UnityEngine.Camera>();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnEnable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer.add_UpdatedEvent(value:  new IxSceneRecognitionDeliverer.Update(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSceneRecognitionVisualizer::IxSceneRecognitionDelivererOnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSceneRecognition recognition)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void OnDisable()
        {
            SharedTechAssets.Scripts.IllumixEngine.IxSceneRecognitionDeliverer.add_UpdatedEvent(value:  new IxSceneRecognitionDeliverer.Update(object:  this, method:  System.Void SharedTechAssets.Scripts.IllumixEngine.IllumixDemoVisuals.IxSceneRecognitionVisualizer::IxSceneRecognitionDelivererOnUpdatedEvent(SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxSceneRecognition recognition)));
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public IxSceneRecognitionVisualizer()
        {
            this.smoothedLabelScore = new System.Collections.Generic.Dictionary<System.String, System.Single>();
            this.updatedLabels = new System.Collections.Generic.Dictionary<System.String, System.Single>();
        }
    
    }

}
