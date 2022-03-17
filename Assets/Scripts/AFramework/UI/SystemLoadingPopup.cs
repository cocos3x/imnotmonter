using UnityEngine;

namespace AFramework.UI
{
    public class SystemLoadingPopup : BaseUIMenu
    {
        // Fields
        private TMPro.TextMeshProUGUI mWaitText;
        
        // Methods
        private void Awake()
        {
            float val_7;
            float val_8;
            float val_14;
            float val_15;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            mem[1152921510086658236] = 3;
            536887303 = new UnityEngine.GameObject(name:  -1610609995);
            SynchronizationContextBehavoir val_2 = 536887303.AddComponent<SynchronizationContextBehavoir>();
            UnityEngine.Transform val_3 = 536887303.transform;
            UnityEngine.Transform val_4 = this.transform;
            536887303.SetParent(p:  1184843952);
            UnityEngine.Transform val_5 = 536887303.transform;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            536887303.localPosition = new UnityEngine.Vector3() {x = val_7, y = val_8, z = 0f};
            UnityEngine.Transform val_9 = 536887303.transform;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.one;
            536887303.localScale = new UnityEngine.Vector3() {x = val_7, y = val_8, z = 0f};
            UnityEngine.Color val_11 = new UnityEngine.Color(r:  val_10.x, g:  val_10.y, b:  null, a:  null);
            UnityEngine.Transform val_12 = 536887303.GetComponent<UnityEngine.Transform>();
            UnityEngine.Vector2 val_13 = UnityEngine.Vector2.zero;
            536887303.anchorMin = new UnityEngine.Vector2() {x = val_14, y = val_15};
            UnityEngine.Vector2 val_16 = UnityEngine.Vector2.one;
            536887303.anchorMax = new UnityEngine.Vector2() {x = val_14, y = val_15};
            UnityEngine.Vector2 val_17 = UnityEngine.Vector2.zero;
            536887303.anchoredPosition = new UnityEngine.Vector2() {x = val_14, y = val_15};
            536887303 = new UnityEngine.GameObject(name:  -1610602593);
            SynchronizationContextBehavoir val_19 = 536887303.AddComponent<SynchronizationContextBehavoir>();
            UnityEngine.Transform val_20 = 536887303.transform;
            UnityEngine.Transform val_21 = this.transform;
            536887303.SetParent(p:  1184843952);
            UnityEngine.Transform val_22 = 536887303.transform;
            UnityEngine.Vector2 val_23 = UnityEngine.Vector2.zero;
            536887303.localPosition = new UnityEngine.Vector3() {x = val_14, y = val_15, z = 0f};
            UnityEngine.Color val_24 = UnityEngine.Color.white;
            if(536887303 != 0)
            {
                    536887303.enableWordWrapping = false;
            }
            else
            {
                    536887303.enableWordWrapping = false;
            }
            
            536887303.alignment = 514;
            val_34 = 22709744;
            var val_32 = 18075776;
            val_32 = 4894160 + val_32;
            if(val_32 == 0)
            {
                    mem2[0] = 1;
            }
            
            val_35 = 536884619;
            if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_35 = 536884619;
            }
            
            if(mem[536884711] != 0)
            {
                    val_33 = 4894344 + 18075593;
                if(val_33 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_36 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_36 = 536884619;
            }
            
                UnityEngine.Rect val_27 = val_11.r.rect;
                float val_28 = width;
                if(val_33 == 0)
            {
                    mem2[0] = 1;
            }
            
                val_37 = 536884619;
                if(((mem[536884806] & true) == 0) && (mem[536884735] == 0))
            {
                    val_37 = 536884619;
            }
            
                UnityEngine.Rect val_29 = val_11.r.rect;
                float val_31 = UnityEngine.Mathf.Min(a:  height, b:  val_29.m_YMin);
                float val_33 = 1080f;
                val_33 = 1184831896 / val_33;
                val_32 = val_33 * 80f;
            }
            else
            {
                
            }
            
            536887303.fontSize = val_24.r;
            this.mWaitText = 536887303;
        }
        private void Update()
        {
            UnityEngine.Transform val_1 = this.transform;
            this.SetAsLastSibling();
            float val_2 = UnityEngine.Time.unscaledTime;
            if(this < 0)
            {
                    -1610611787 = -1610612561;
            }
            
            if(this < 0)
            {
                    -1610611787 = -1610612561;
            }
            
            string val_3 = -1610606595(-1610606595) + -1610612561(-1610612561) + -1610612561(-1610612561);
            this.mWaitText.text = -1610606595;
        }
        public SystemLoadingPopup()
        {
        
        }
    
    }

}
