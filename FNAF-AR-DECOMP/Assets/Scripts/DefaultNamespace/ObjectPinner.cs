using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class ObjectPinner : IObjDetectAccepter
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.GeometryCameraHandler _cameraHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private com.illumix.IntVector3.IntVector3Cache _cache;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float shortSideInches;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float longSideInches;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private DefaultNamespace.ObjectDetectionDebugVisualizer _debugVisualizer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _camera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Vector3 lastCameraPos;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler _dataHandler;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler> _geometryHandlers;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser _dispenser;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _resolution;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3> points;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private float _boxSizeInches;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static int predId;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private int[] intBuffer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.ScreenOrientation lastOrientation;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Matrix4x4 lastCameraWorldTransform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Matrix4x4 lastCameraProjectionMatrix;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(UnityEngine.Camera camera, com.illumix.IntVector3.IntVector3Cache cache, DefaultNamespace.ObjectDetectionDebugVisualizer debugVisualizer, System.Collections.Generic.List<SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.ISemanticGeometryHandler> geometryHandlers, SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser dispenser)
        {
            SharedTechAssets.Scripts.TechInterfaces.Dispensers.ObjectPinEventDispenser val_18;
            SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler val_19;
            var val_20;
            val_18 = dispenser;
            this._camera = camera;
            DefaultNamespace.GeometryCameraHandler val_1 = new DefaultNamespace.GeometryCameraHandler();
            this._cameraHandler = val_1;
            ._mainCamera = camera;
            val_1.SetupCamera();
            this._debugVisualizer = debugVisualizer;
            this.points = new System.Collections.Generic.HashSet<com.illumix.IntVector3.IntVector3>();
            this._cache = cache;
            float val_18 = (float)UnityEngine.Screen.width;
            float val_19 = (float)UnityEngine.Screen.height;
            val_18 = val_18 / UnityEngine.Screen.dpi;
            val_19 = val_19 / UnityEngine.Screen.dpi;
            this.shortSideInches = System.Math.Min(val1:  val_18, val2:  val_19);
            SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler val_15 = 0;
            this.longSideInches = System.Math.Max(val1:  (float)UnityEngine.Screen.width / UnityEngine.Screen.dpi, val2:  (float)UnityEngine.Screen.height / UnityEngine.Screen.dpi);
            this._geometryHandlers = geometryHandlers;
            val_19 = val_15;
            val_15 = new SharedTechAssets.Scripts.ObjectPinner.GeometryHandler.GeometryToDataHandler();
            this._dataHandler = val_19;
            this._dispenser = val_18;
            val_20 = 0;
            goto label_4;
            label_8:
            val_18 = this._dataHandler;
            val_19 = this._geometryHandlers.Item[0];
            val_20 = 1;
            label_4:
            if(val_20 < geometryHandlers.Count)
            {
                goto label_8;
            }
        
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] CreateIxObjDetections(string[] objects, float[] minX, float[] minY, float[] maxX, float[] maxY, float[] confidences)
        {
            System.String[] val_4 = objects;
            SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[] val_2 = new SharedTechAssets.Scripts.IllumixEngine.IllumixObjects.IxObjectDetection[0];
            if(objects.Length < 1)
            {
                    return val_2;
            }
            
            System.String[] val_3 = val_4[32];
            System.Single[] val_4 = minX[32];
            System.Single[] val_5 = minY[32];
            System.Single[] val_6 = maxX[32];
            var val_9 = 0;
            System.Single[] val_7 = maxY[32];
            System.Single[] val_8 = confidences[32];
            do
            {
                val_4 = val_4;
                val_9 = val_9 + 1;
                mem2[0] = 0;
                val_2[32] = 0;
            }
            while((objects.Length & 4294967295) != val_9);
            
            return val_2;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private System.Collections.Generic.List<UnityEngine.Vector2> GetPointsToRayCast(float minX, float minY, float maxX, float maxY, bool isLandscape)
        {
            float val_22;
            float val_23;
            int val_24;
            val_22 = maxY;
            val_23 = minY;
            float val_20 = minX;
            val_24 = this;
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            float val_2 = (isLandscape != true) ? this.longSideInches : this.shortSideInches;
            maxX = maxX - val_20;
            maxX = maxX * val_2;
            float val_3 = maxX / this._boxSizeInches;
            float val_4 = (isLandscape != true) ? this.shortSideInches : this.longSideInches;
            if(val_3 >= 0)
            {
                    float val_5 = val_22 - val_23;
                val_5 = val_5 * val_4;
                val_5 = val_5 / this._boxSizeInches;
                if(val_5 >= 0)
            {
                    val_24 = (int)val_3;
                if(val_24 < (1.401298E-45f))
            {
                    return val_1;
            }
            
                val_3 = val_3 - (float)val_24;
                val_5 = val_5 - (float)(int)val_5;
                val_3 = this._boxSizeInches * val_3;
                val_3 = val_3 / val_2;
                float val_6 = this._boxSizeInches / val_2;
                float val_7 = this._boxSizeInches * val_5;
                val_22 = this._boxSizeInches / val_4;
                val_7 = val_7 / val_4;
                val_3 = val_3 * 0.5f;
                val_7 = val_7 * 0.5f;
                val_3 = val_3 + val_20;
                val_7 = val_7 + val_23;
                var val_26 = 0;
                val_20 = (val_6 * 0.5f) + val_3;
                val_23 = (val_22 * 0.5f) + val_7;
                do
            {
                if((int)val_5 >= (1.401298E-45f))
            {
                    float val_21 = 0f;
                val_21 = val_6 * val_21;
                var val_25 = 0;
                do
            {
                float val_22 = 0f;
                val_22 = val_22 * val_22;
                float val_23 = (float)UnityEngine.Screen.width;
                float val_24 = (float)UnityEngine.Screen.height;
                val_22 = val_23 + val_22;
                val_23 = (val_20 + val_21) * val_23;
                val_24 = val_22 * val_24;
                UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_23, y:  val_24);
                val_1.Add(item:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
                val_25 = val_25 + 1;
            }
            while((int)val_5 != val_25);
            
            }
            
                val_26 = val_26 + 1;
            }
            while(val_26 != val_24);
            
                return val_1;
            }
            
            }
            
            val_23 = (val_20 + maxX) * 0.5f;
            float val_27 = (float)UnityEngine.Screen.width;
            float val_28 = (float)UnityEngine.Screen.height;
            val_27 = val_23 * val_27;
            val_28 = ((val_23 + val_22) * 0.5f) * val_28;
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  val_27, y:  val_28);
            val_1.Add(item:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            return val_1;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void DropPin(string obj, UnityEngine.Vector3 worldPoint)
        {
            var val_11;
            UnityEngine.GameObject val_1 = new UnityEngine.GameObject();
            if(val_1 != null)
            {
                    val_11 = val_1.AddComponent<UnityEngine.TextMesh>();
            }
            else
            {
                    val_11 = val_1.AddComponent<UnityEngine.TextMesh>();
            }
            
            UnityEngine.MeshRenderer val_4 = val_1.AddComponent<UnityEngine.MeshRenderer>();
            if(val_11 != null)
            {
                    val_11.text = obj;
                val_11.fontSize = 20;
            }
            else
            {
                    val_11.text = obj;
                val_11.fontSize = 20;
            }
            
            val_11.characterSize = 0.02f;
            val_1.transform.position = new UnityEngine.Vector3() {x = worldPoint.x, y = worldPoint.y, z = worldPoint.z};
            val_1.transform.LookAt(target:  this._camera.transform);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_1.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDetectionUpdateEvent(string[] objects, float[] minX, float[] minY, float[] maxX, float[] maxY, float[] confidences)
        {
            float val_15;
            float val_16;
            float val_17;
            System.Single[] val_29;
            System.Single[] val_30;
            System.Single[] val_31;
            System.Single[] val_32;
            DefaultNamespace.ObjectDetectionDebugVisualizer val_33;
            System.String[] val_34;
            var val_35;
            System.Int32[] val_36;
            float val_38;
            float val_39;
            float val_40;
            float val_41;
            var val_42;
            var val_43;
            System.String[] val_44;
            bool val_45;
            System.Single[] val_46;
            DefaultNamespace.ObjectDetectionDebugVisualizer val_47;
            val_29 = maxY;
            val_30 = maxX;
            val_31 = minY;
            val_32 = minX;
            val_33 = this;
            val_34 = objects;
            UnityEngine.GameObject val_6 = 0;
            if(val_34 == 0)
            {
                    val_34 = objects;
            }
            
            val_35 = (objects + 24) & 4294967295;
            int[] val_1 = new int[0];
            val_36 = val_1;
            if((objects + 24) < 1)
            {
                goto label_2;
            }
            
            var val_29 = 0;
            label_56:
            val_38 = val_32[val_29];
            val_39 = val_31[val_29];
            val_40 = val_30[val_29];
            val_41 = val_39;
            System.Collections.Generic.List<UnityEngine.Vector2> val_2 = this.GetPointsToRayCast(minX:  val_38, minY:  val_41, maxX:  val_40, maxY:  val_29[val_29], isLandscape:  false);
            System.Collections.Generic.List<UnityEngine.RaycastHit> val_3 = new System.Collections.Generic.List<UnityEngine.RaycastHit>();
            System.Collections.Generic.HashSet<UnityEngine.GameObject> val_4 = new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
            val_42 = 0;
            goto label_11;
            label_18:
            UnityEngine.Vector2 val_5 = val_2.Item[0];
            val_38 = val_5.x;
            val_39 = val_5.y;
            val_41 = val_39;
            if((this._cameraHandler.AttemptRaycast(screenPoint:  new UnityEngine.Vector2() {x = val_38, y = val_41}, hit: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, go: out  val_6)) != false)
            {
                    val_3.Add(item:  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}});
                bool val_8 = val_4.Add(item:  val_6);
            }
            
            val_42 = 1;
            label_11:
            if(val_42 < val_2.Count)
            {
                goto label_18;
            }
            
            val_35 = public System.Int32 System.Collections.Generic.List<UnityEngine.RaycastHit>::get_Count();
            if(val_3.Count < 1)
            {
                goto label_20;
            }
            
            val_43 = null;
            val_44 = objects;
            goto label_26;
            label_20:
            val_30 = val_30;
            val_29 = val_29;
            val_32 = val_32;
            val_31 = val_31;
            if(val_29 >= val_1.Length)
            {
                    val_35 = 0;
            }
            
            val_45 = 2;
            goto label_55;
            label_26:
            if( == 0)
            {
                    val_44 = objects;
            }
            
            if(val_29 >= (objects + 24))
            {
                    val_44 = objects;
            }
            
            System.String[] val_11 = val_44 + 0;
            val_46 = confidences;
            if(val_46 == 0)
            {
                    val_46 = confidences;
            }
            
            if(val_29 >= (confidences + 24))
            {
                    val_46 = confidences;
            }
            
            System.Single[] val_12 = val_46 + 0;
            this._dispenser.SendBeginEvent(id:  DefaultNamespace.ObjectPinner.predId, label:  (objects + 0) + 32, confidence:  (confidences + 0) + 32);
            this._dataHandler.Redirect(goList:  new System.Collections.Generic.List<UnityEngine.GameObject>(collection:  val_4), hits:  val_3, label:  (objects + 0) + 32, confidence:  (confidences + 0) + 32, labelId:  DefaultNamespace.ObjectPinner.predId);
            val_36 = val_36;
            this._dispenser.SendEndEvent();
            int val_28 = DefaultNamespace.ObjectPinner.predId;
            val_28 = val_28 + 1;
            DefaultNamespace.ObjectPinner.predId = val_28;
            val_30 = val_30;
            val_29 = val_29;
            val_31 = val_31;
            UnityEngine.RaycastHit val_14 = val_3.Item[0];
            float val_18 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.lastCameraPos, y = val_39, z = val_40}, b:  new UnityEngine.Vector3() {x = val_15, y = val_17, z = val_16});
            val_32 = val_32;
            this._cameraHandler.SetCameraParameters(lastCameraProjectionMatrix:  new UnityEngine.Matrix4x4() {m00 = this.lastCameraProjectionMatrix, m10 = this.lastCameraProjectionMatrix, m20 = this.lastCameraProjectionMatrix, m30 = this.lastCameraProjectionMatrix, m01 = this.lastCameraProjectionMatrix + 16, m11 = this.lastCameraProjectionMatrix + 16, m21 = this.lastCameraProjectionMatrix + 16, m31 = this.lastCameraProjectionMatrix + 16, m02 = this.lastCameraProjectionMatrix + 32, m12 = this.lastCameraProjectionMatrix + 32, m22 = this.lastCameraProjectionMatrix + 32, m32 = this.lastCameraProjectionMatrix + 32, m03 = this.lastCameraProjectionMatrix + 48, m13 = this.lastCameraProjectionMatrix + 48, m23 = this.lastCameraProjectionMatrix + 48, m33 = this.lastCameraProjectionMatrix + 48}, lastCameraWorldTransform:  new UnityEngine.Matrix4x4() {m00 = this.lastCameraWorldTransform, m10 = this.lastCameraWorldTransform, m20 = this.lastCameraWorldTransform, m30 = this.lastCameraWorldTransform, m01 = this.lastCameraWorldTransform + 16, m11 = this.lastCameraWorldTransform + 16, m21 = this.lastCameraWorldTransform + 16, m31 = this.lastCameraWorldTransform + 16, m02 = this.lastCameraWorldTransform + 32, m12 = this.lastCameraWorldTransform + 32, m22 = this.lastCameraWorldTransform + 32, m32 = this.lastCameraWorldTransform + 32, m03 = this.lastCameraWorldTransform + 48, m13 = this.lastCameraWorldTransform + 48, m23 = this.lastCameraWorldTransform + 48, m33 = this.lastCameraWorldTransform + 48});
            UnityEngine.Vector3 val_19 = this._cameraHandler.ComputeViewportToWorldPoint(screenPoint:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_40 = val_19.z;
            UnityEngine.Vector3 val_20 = this._cameraHandler.ComputeViewportToWorldPoint(screenPoint:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_38 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_40}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            this._cameraHandler.ResetCameraParameters();
            if(val_29 >= (objects + 24))
            {
                    val_35 = 0;
            }
            
            val_45 = DefaultNamespace.ObjectSizeFilter.isSizeAnomaly(obj:  (objects + 0) + 32, size:  val_38);
            if(val_29 >= val_1.Length)
            {
                    val_35 = 0;
            }
            
            label_55:
            System.Int32[] val_23 = val_36 + 0;
            val_29 = val_29 + 1;
            mem2[0] = val_45;
            if(val_29 != val_35)
            {
                goto label_56;
            }
            
            label_2:
            val_47 = this._debugVisualizer;
            if(val_47 == 0)
            {
                    return;
            }
            
            val_47 = this._debugVisualizer;
            if(val_47.isActiveAndEnabled == false)
            {
                    return;
            }
            
            val_33 = this._debugVisualizer;
            val_33.IxObjectDetectionDelivererOnUpdatedEvent(detections:  this.CreateIxObjDetections(objects:  objects, minX:  val_32, minY:  val_31, maxX:  val_30, maxY:  val_29, confidences:  confidences), isFiltered:  val_1);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public com.illumix.IntVector3.IntVector3 DiscretizeVertex(UnityEngine.Vector3 vertex)
        {
            var val_7 = 0;
            do
            {
                float val_5 = this._resolution;
                val_5 = System.Math.Abs(vertex.x) / val_5;
                int val_6 = (int)val_5;
                val_5 = val_5 - (float)val_6;
                val_6 = ((val_5 > 0.5f) ? 1 : 0) + val_6;
                int val_2 = (vertex.x < 0) ? (-val_6) : (val_6);
                val_2 = val_2 << 1;
                val_7 = val_7 + 1;
                this.intBuffer[val_7] = val_2;
            }
            while(val_7 != 3);
            
            return (com.illumix.IntVector3.IntVector3)this._cache.GenerateIntVector(x:  this.intBuffer[0], y:  this.intBuffer[1], z:  this.intBuffer[2]);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void OnDetectionBeganEvent()
        {
            var val_4;
            var val_5;
            var val_6;
            UnityEngine.Matrix4x4 val_7;
            var val_9;
            var val_10;
            var val_11;
            UnityEngine.Matrix4x4 val_12;
            UnityEngine.Vector3 val_2 = this._camera.transform.position;
            this.lastCameraPos = val_2;
            mem[1152921524705502476] = val_2.y;
            mem[1152921524705502480] = val_2.z;
            UnityEngine.Matrix4x4 val_3 = this._camera.worldToCameraMatrix;
            mem[1152921524705502596] = val_4;
            mem[1152921524705502580] = val_5;
            mem[1152921524705502564] = val_6;
            this.lastCameraWorldTransform = val_7;
            UnityEngine.Matrix4x4 val_8 = this._camera.projectionMatrix;
            mem[1152921524705502660] = val_9;
            mem[1152921524705502644] = val_10;
            mem[1152921524705502628] = val_11;
            this.lastCameraProjectionMatrix = val_12;
            this.lastOrientation = UnityEngine.Screen.orientation;
            this._cameraHandler.SetCameraPosition();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public ObjectPinner()
        {
            this._resolution = 0.05f;
            this._boxSizeInches = 0.25f;
            this.intBuffer = new int[3];
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private static ObjectPinner()
        {
        
        }
    
    }

}
