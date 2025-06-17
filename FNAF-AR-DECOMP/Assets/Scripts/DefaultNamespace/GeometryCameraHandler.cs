using UnityEngine;

namespace DefaultNamespace
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class GeometryCameraHandler
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _geometryCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera _mainCamera;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int GEOMETRY_LAYER = 18;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const int GEOMETRY_LAYER_MASK = 262144;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.RaycastHit defaultHit;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void Setup(UnityEngine.Camera mainCamera)
        {
            this._mainCamera = mainCamera;
            this.SetupCamera();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void SetupCamera()
        {
            UnityEngine.Camera val_2 = new UnityEngine.GameObject(name:  "GeometryCamera").AddComponent<UnityEngine.Camera>();
            this._geometryCamera = val_2;
            val_2.cullingMask = 262144;
            this._geometryCamera.clearFlags = 2;
            this._geometryCamera.backgroundColor = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            this._geometryCamera.enabled = false;
            this._geometryCamera.depth = -1f;
            this._geometryCamera.fieldOfView = this._mainCamera.fieldOfView;
            this._geometryCamera.nearClipPlane = this._mainCamera.nearClipPlane;
            this._geometryCamera.farClipPlane = this._mainCamera.farClipPlane;
            this._geometryCamera.useOcclusionCulling = true;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCameraPosition()
        {
            UnityEngine.Vector3 val_3 = this._mainCamera.transform.position;
            this._geometryCamera.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Quaternion val_6 = this._mainCamera.transform.rotation;
            this._geometryCamera.transform.rotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void SetCameraParameters(UnityEngine.Matrix4x4 lastCameraProjectionMatrix, UnityEngine.Matrix4x4 lastCameraWorldTransform)
        {
            this._geometryCamera.projectionMatrix = new UnityEngine.Matrix4x4() {m00 = lastCameraProjectionMatrix.m00, m01 = lastCameraProjectionMatrix.m01, m02 = lastCameraProjectionMatrix.m02, m03 = lastCameraProjectionMatrix.m03};
            this._geometryCamera.worldToCameraMatrix = new UnityEngine.Matrix4x4() {m00 = lastCameraWorldTransform.m00, m01 = lastCameraWorldTransform.m01, m02 = lastCameraWorldTransform.m02, m03 = lastCameraWorldTransform.m03};
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public void ResetCameraParameters()
        {
            this._geometryCamera.ResetProjectionMatrix();
            this._geometryCamera.ResetWorldToCameraMatrix();
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public UnityEngine.Vector3 ComputeViewportToWorldPoint(UnityEngine.Vector3 screenPoint)
        {
            if(this._geometryCamera != null)
            {
                    return this._geometryCamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = screenPoint.x, y = screenPoint.y, z = screenPoint.z});
            }
            
            return this._geometryCamera.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = screenPoint.x, y = screenPoint.y, z = screenPoint.z});
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public bool AttemptRaycast(UnityEngine.Vector2 screenPoint, out UnityEngine.RaycastHit hit, out UnityEngine.GameObject go)
        {
            float val_3;
            float val_4;
            var val_7;
            var val_8;
            val_7 = this;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = screenPoint.x, y = screenPoint.y});
            UnityEngine.Ray val_2 = this._geometryCamera.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
            if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_4, y = val_4, z = val_4}, m_Direction = new UnityEngine.Vector3() {x = val_4, y = val_3, z = val_3}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = hit.m_Point.x, y = hit.m_Point.y, z = hit.m_Point.z}, m_Normal = new UnityEngine.Vector3() {x = hit.m_Normal.x, y = hit.m_Normal.y, z = hit.m_Normal.z}, m_FaceID = hit.m_FaceID, m_Distance = hit.m_Distance, m_UV = new UnityEngine.Vector2() {x = hit.m_UV.x, y = hit.m_UV.y}, m_Collider = hit.m_Collider}, maxDistance:  Infinityf, layerMask:  262144)) != false)
            {
                    go = hit.m_Point.x.gameObject;
                val_8 = 1;
                return (bool)val_8;
            }
            
            go = 0;
            val_8 = 0;
            hit.m_Collider = -30271616;
            hit.m_UV.x = ;
            hit.m_Point.x = this.defaultHit;
            hit.m_Normal.y = val_1.y;
            return (bool)val_8;
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public GeometryCameraHandler()
        {
        
        }
    
    }

}
