using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_UiFrameRateCounter : MonoBehaviour
    {
        // Fields
        public float UpdateInterval;
        private float m_LastInterval;
        private int m_Frames;
        public TMPro.Examples.TMP_UiFrameRateCounter.FpsCounterAnchorPositions AnchorPosition;
        private string htmlColorTag;
        private const string fpsLabel = "{0:2}</color> <#8080ff>FPS \n<#FF8000>{1:2} <#8080ff>MS";
        private TMPro.TextMeshProUGUI m_TextMeshPro;
        private UnityEngine.RectTransform m_frameCounter_transform;
        private TMPro.Examples.TMP_UiFrameRateCounter.FpsCounterAnchorPositions last_AnchorPosition;
        
        // Methods
        private void Awake()
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            UnityEngine.Application.targetFrameRate = 1000;
            536887303 = new UnityEngine.GameObject(name:  -1610608015);
            SynchronizationContextBehavoir val_3 = 536887303.AddComponent<SynchronizationContextBehavoir>();
            this.m_frameCounter_transform = 536887303;
            UnityEngine.Transform val_4 = this.transform;
            this.m_frameCounter_transform.SetParent(parent:  956016368, worldPositionStays:  false);
            SynchronizationContextBehavoir val_5 = 536887303.AddComponent<SynchronizationContextBehavoir>();
            this.m_TextMeshPro = 536887303;
            TMPro.TMP_SpriteAsset val_6 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608043);
            this.m_TextMeshPro.font = -1610608043;
            TMPro.TMP_SpriteAsset val_7 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608037);
            this.m_TextMeshPro.enableWordWrapping = false;
            this.m_TextMeshPro.fontSize = null;
            this.m_TextMeshPro.isOverlay = true;
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
            TMP_UiFrameRateCounter.FpsCounterAnchorPositions val_5;
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
        private void Set_FrameCounter_Position(TMPro.Examples.TMP_UiFrameRateCounter.FpsCounterAnchorPositions anchor_position)
        {
            var val_2;
            var val_3;
            if(anchor_position > 3)
            {
                    return;
            }
            
            var val_1 = 4924240 + (4924240 + (anchor_position) << 2);
            if(anchor_position == 3)
            {
                    4924240 = 4924240;
                4924240 = 4924240 & (((int)IP) >> 1);
                4924240 = 4924240 & (((IP) << (32-4924240 + (anchor_position) << 2)) | ((IP) << 4924240 + (anchor_position) << 2));
                4924240 = 4924240 & (4924240 >> R2);
            }
            
            this.m_TextMeshPro.alignment = 257;
            this.m_frameCounter_transform.pivot = new UnityEngine.Vector2() {x = 0f, y = 1f};
            this.m_frameCounter_transform.anchorMin = new UnityEngine.Vector2() {x = 0.01f, y = 0.99f};
            this.m_frameCounter_transform.anchorMax = new UnityEngine.Vector2() {x = 0.01f, y = 0.99f};
            val_2 = 0;
            val_3 = 1065353216;
            R4 + 36 + 36 + 36.anchoredPosition = new UnityEngine.Vector2() {x = 1f, y = 0f};
        }
        public TMP_UiFrameRateCounter()
        {
            this.AnchorPosition = 2;
            this.UpdateInterval = 5f;
        }
    
    }

}
