using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_FrameRateCounter : MonoBehaviour
    {
        // Fields
        public float UpdateInterval;
        private float m_LastInterval;
        private int m_Frames;
        public TMPro.Examples.TMP_FrameRateCounter.FpsCounterAnchorPositions AnchorPosition;
        private string htmlColorTag;
        private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";
        private TMPro.TextMeshPro m_TextMeshPro;
        private UnityEngine.Transform m_frameCounter_transform;
        private UnityEngine.Camera m_camera;
        private TMPro.Examples.TMP_FrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition;
        
        // Methods
        private void Awake()
        {
            float val_10;
            if(this.enabled == false)
            {
                    return;
            }
            
            UnityEngine.Camera val_2 = UnityEngine.Camera.main;
            this.m_camera = 0;
            UnityEngine.Application.targetFrameRate = 9999;
            536887303 = new UnityEngine.GameObject(name:  -1610608015);
            SynchronizationContextBehavoir val_4 = 536887303.AddComponent<SynchronizationContextBehavoir>();
            this.m_TextMeshPro = 536887303;
            TMPro.TMP_SpriteAsset val_5 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608043);
            this.m_TextMeshPro.font = -1610608043;
            TMPro.TMP_SpriteAsset val_6 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608037);
            UnityEngine.Transform val_7 = 536887303.transform;
            this.m_frameCounter_transform = 536887303;
            UnityEngine.Transform val_8 = this.m_camera.transform;
            this.m_frameCounter_transform.SetParent(p:  0);
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
            this.m_frameCounter_transform.localRotation = new UnityEngine.Quaternion() {x = val_10, y = R4, z = R5, w = ???};
            this.m_TextMeshPro.enableWordWrapping = false;
            this.m_TextMeshPro.fontSize = val_9.x;
            this.Set_FrameCounter_Position(anchor_position:  this.AnchorPosition);
            this.last_AnchorPosition = this.AnchorPosition;
        }
        private void Start()
        {
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            this.m_LastInterval = 0f;
            this.m_Frames = 0;
        }
        private void Update()
        {
            TMP_FrameRateCounter.FpsCounterAnchorPositions val_5;
            float val_6;
            string val_7;
            val_5 = this.AnchorPosition;
            if(val_5 != this.last_AnchorPosition)
            {
                    this.Set_FrameCounter_Position(anchor_position:  val_5);
                val_5 = this.AnchorPosition;
            }
            
            int val_5 = this.m_Frames;
            this.last_AnchorPosition = val_5;
            val_5 = val_5 + 1;
            this.m_Frames = val_5;
            float val_1 = UnityEngine.Time.realtimeSinceStartup;
            float val_6 = this.UpdateInterval;
            float val_7 = this.m_LastInterval;
            val_6 = val_7 + val_6;
            if(val_5 <= this.last_AnchorPosition)
            {
                    return;
            }
            
            val_7 = 0 - val_7;
            float val_3 = UnityEngine.Mathf.Max(a:  val_7, b:  null);
            val_6 = 30f;
            float val_8 = 1000f;
            if(val_5 < 0)
            {
                    val_7 = 22781264;
            }
            else
            {
                    val_6 = 10f;
                if(val_5 < 0)
            {
                    val_7 = 22781260;
            }
            else
            {
                    val_7 = 22781256;
            }
            
            }
            
            this.htmlColorTag = val_7;
            val_8 = val_8 / ((float)this.m_Frames / val_7);
            string val_4 = this.htmlColorTag + -1610597095(-1610597095);
            this.m_TextMeshPro.SetText(sourceText:  this.htmlColorTag, arg0:  val_6, arg1:  null);
            this.m_LastInterval = 0;
            this.m_Frames = 0;
        }
        private void Set_FrameCounter_Position(TMPro.Examples.TMP_FrameRateCounter.FpsCounterAnchorPositions anchor_position)
        {
            TMPro.TextMeshPro val_8;
            float val_9;
            var val_10;
            UnityEngine.Transform val_11;
            float val_12;
            var val_13;
            var val_14;
            var val_17;
            val_8 = this.m_TextMeshPro;
            UnityEngine.Vector4 val_1 = new UnityEngine.Vector4(x:  null, y:  null, z:  null, w:  null);
            val_8.margin = new UnityEngine.Vector4() {x = val_1.x, y = val_1.y, z = val_1.z, w = val_9};
            if(anchor_position > 3)
            {
                    return;
            }
            
            var val_2 = 4897544 + (4897544 + (anchor_position) << 2);
            if(anchor_position == 3)
            {
                    4897544 = 4897544;
                4897544 = IP * 4897544;
                4897544 = 4897544 & 238039196;
                4897544 = 4897544 & (4897544 >> 3);
            }
            
            this.m_TextMeshPro.alignment = 257;
            UnityEngine.RectTransform val_3 = this.m_TextMeshPro.rectTransform;
            val_10 = 0;
            this.m_TextMeshPro.pivot = new UnityEngine.Vector2() {x = 0f, y = 1f};
            val_11 = this.m_frameCounter_transform;
            val_12 = this.m_camera;
            val_13 = 17096;
            val_13 = 1120403456;
            val_14 = 0;
            val_17 = 1065353216;
            UnityEngine.Vector3 val_7 = val_1.x.ViewportToWorldPoint(position:  new UnityEngine.Vector3() {y = 1f, z = 0f});
            val_8 = val_1.y;
            val_9 = val_1.z;
            position = new UnityEngine.Vector3() {x = val_1.x, y = val_8, z = val_9};
        }
        public TMP_FrameRateCounter()
        {
            this.AnchorPosition = 2;
            this.UpdateInterval = 5f;
        }
    
    }

}
