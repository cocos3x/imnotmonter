using UnityEngine;

namespace TMPro.Examples
{
    public class TMPro_InstructionOverlay : MonoBehaviour
    {
        // Fields
        public TMPro.Examples.TMPro_InstructionOverlay.FpsCounterAnchorPositions AnchorPosition;
        private const string instructions = "Camera Control - <#ffff00>Shift + RMB\n</color>Zoom - <#ffff00>Mouse wheel.";
        private TMPro.TextMeshPro m_TextMeshPro;
        private TMPro.TextContainer m_textContainer;
        private UnityEngine.Transform m_frameCounter_transform;
        private UnityEngine.Camera m_camera;
        
        // Methods
        private void Awake()
        {
            float val_7;
            if(this.enabled == false)
            {
                    return;
            }
            
            UnityEngine.Camera val_2 = UnityEngine.Camera.main;
            this.m_camera = 0;
            536887303 = new UnityEngine.GameObject(name:  -1610608015);
            UnityEngine.Transform val_4 = 536887303.transform;
            this.m_frameCounter_transform = 536887303;
            UnityEngine.Transform val_5 = this.m_camera.transform;
            this.m_frameCounter_transform.parent = 0;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            this.m_frameCounter_transform.localRotation = new UnityEngine.Quaternion() {x = val_7, y = R4, z = R5, w = ???};
            SynchronizationContextBehavoir val_8 = 536887303.AddComponent<SynchronizationContextBehavoir>();
            this.m_TextMeshPro = 536887303;
            TMPro.TMP_SpriteAsset val_9 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608043);
            this.m_TextMeshPro.font = -1610608043;
            TMPro.TMP_SpriteAsset val_10 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608037);
            this.m_TextMeshPro.fontSize = val_6.x;
            this.m_TextMeshPro.isOverlay = true;
            Weight val_11 = 536887303.GetComponent<Weight>();
            this.m_textContainer = 536887303;
            this.Set_FrameCounter_Position(anchor_position:  this.AnchorPosition);
            this.m_TextMeshPro.text = -1610609707;
        }
        private void Set_FrameCounter_Position(TMPro.Examples.TMPro_InstructionOverlay.FpsCounterAnchorPositions anchor_position)
        {
            float val_3;
            float val_4;
            float val_5;
            var val_6;
            UnityEngine.Transform val_7;
            float val_8;
            var val_9;
            var val_10;
            var val_13;
            if(anchor_position > 3)
            {
                    return;
            }
            
            var val_1 = 4926404 + (4926404 + (anchor_position) << 2);
            if(anchor_position == 3)
            {
                    4926404 = 4926404;
                4926404 = 4926404 & (((int)IP) >> 4926404);
                4926404 = 4926404 & ((R8) >> 1);
                4926404 = 4926404 & (4926404 << 2);
            }
            
            val_6 = 0;
            this.m_textContainer.anchorPosition = 0;
            val_7 = this.m_frameCounter_transform;
            val_8 = this.m_camera;
            val_9 = 17096;
            val_9 = 1120403456;
            val_10 = 0;
            val_13 = 1065353216;
            UnityEngine.Vector3 val_2 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {y = 1f, z = 0f});
            val_7.position = new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5};
        }
        public TMPro_InstructionOverlay()
        {
            this.AnchorPosition = 1;
        }
    
    }

}
