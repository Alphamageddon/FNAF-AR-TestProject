using UnityEngine;

namespace TMPro.Examples
{
    [System.Runtime.InteropServices.ComVisibleAttribute]
    public class TMPro_InstructionOverlay : MonoBehaviour
    {
        // Fields
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro.Examples.TMPro_InstructionOverlay.FpsCounterAnchorPositions AnchorPosition;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextMeshPro m_TextMeshPro;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private TMPro.TextContainer m_textContainer;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Transform m_frameCounter_transform;
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private UnityEngine.Camera m_camera;
        
        // Methods
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Awake()
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            this.m_camera = UnityEngine.Camera.main;
            UnityEngine.GameObject val_3 = new UnityEngine.GameObject(name:  "Frame Counter");
            UnityEngine.Transform val_4 = val_3.transform;
            this.m_frameCounter_transform = val_4;
            val_4.parent = this.m_camera.transform;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            this.m_frameCounter_transform.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            TMPro.TextMeshPro val_7 = val_3.AddComponent<TMPro.TextMeshPro>();
            this.m_TextMeshPro = val_7;
            val_7.font = UnityEngine.Resources.Load<TMPro.TMP_FontAsset>(path:  "Fonts & Materials/LiberationSans SDF");
            UnityEngine.Material val_9 = UnityEngine.Resources.Load<UnityEngine.Material>(path:  "Fonts & Materials/LiberationSans SDF - Overlay");
            this.m_TextMeshPro.fontSize = 30f;
            this.m_TextMeshPro.isOverlay = true;
            this.m_textContainer = val_3.GetComponent<TMPro.TextContainer>();
            this.Set_FrameCounter_Position(anchor_position:  this.AnchorPosition);
            this.m_TextMeshPro.text = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        private void Set_FrameCounter_Position(TMPro.Examples.TMPro_InstructionOverlay.FpsCounterAnchorPositions anchor_position)
        {
            UnityEngine.Camera val_2 = this;
            if(anchor_position > 3)
            {
                    return;
            }
            
            var val_2 = 52945888 + (anchor_position) << 2;
            val_2 = val_2 + 52945888;
            goto (52945888 + (anchor_position) << 2 + 52945888);
        }
        [System.Runtime.InteropServices.ComVisibleAttribute]
        public TMPro_InstructionOverlay()
        {
            this.AnchorPosition = 1;
        }
    
    }

}
