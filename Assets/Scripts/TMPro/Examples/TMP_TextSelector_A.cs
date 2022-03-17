using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_TextSelector_A : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
    {
        // Fields
        private TMPro.TextMeshPro m_TextMeshPro;
        private UnityEngine.Camera m_Camera;
        private bool m_isHoveringObject;
        private int m_selectedLink;
        private int m_lastCharIndex;
        private int m_lastWordIndex;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            Weight val_2 = this.GetComponent<Weight>();
            this.m_TextMeshPro = this;
            UnityEngine.Camera val_3 = UnityEngine.Camera.main;
            mem[1152921509855588096] = 0;
            if(this.m_TextMeshPro == 0)
            {
                
            }
        
        }
        private void LateUpdate()
        {
            float val_3;
            float val_4;
            float val_5;
            TMPro.Examples.TMP_TextSelector_A val_52;
            var val_53;
            UnityEngine.RectTransform val_54;
            float val_55;
            float val_56;
            float val_57;
            TMPro.Examples.TMP_TextSelector_A val_58;
            var val_59;
            val_52 = this;
            this.m_isHoveringObject = false;
            val_53 = 0;
            UnityEngine.RectTransform val_1 = this.m_TextMeshPro.rectTransform;
            val_54 = this.m_TextMeshPro;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_55 = val_3;
            val_56 = val_4;
            UnityEngine.Camera val_6 = UnityEngine.Camera.main;
            if((TMPro.TMP_TextUtilities.IsIntersectingRectTransform(rectTransform:  val_54, position:  new UnityEngine.Vector3() {x = val_55, y = val_56, z = val_5}, camera:  0)) != false)
            {
                    this.m_isHoveringObject = true;
            }
            else
            {
                    if(this.m_isHoveringObject == false)
            {
                    return;
            }
            
            }
            
            UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
            UnityEngine.Camera val_9 = UnityEngine.Camera.main;
            int val_10 = TMPro.TMP_TextUtilities.FindIntersectingCharacter(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7}, camera:  0, visibleOnly:  true);
            if(val_10 != 1)
            {
                    0 = val_10;
                val_10 = this.m_lastCharIndex;
            }
            
            if(0 != val_10)
            {
                goto label_9;
            }
            
            label_51:
            UnityEngine.Vector3 val_11 = UnityEngine.Input.mousePosition;
            int val_12 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}, camera:  this.m_Camera);
            val_52 = val_52;
            if(val_12 == 1)
            {
                goto label_12;
            }
            
            if(val_12 == mem[1152921509855724680])
            {
                goto label_23;
            }
            
            mem[1152921509855724680] = val_12;
            int val_13 = (val_12 << 3) - val_12;
            val_13 = this.m_TextMeshPro + (val_13 << 2);
            TMPro.TextMeshPro val_14 = val_13 + 16;
            UnityEngine.RectTransform val_15 = this.m_TextMeshPro.rectTransform;
            UnityEngine.Vector3 val_16 = UnityEngine.Input.mousePosition;
            val_57 = val_4;
            bool val_17 = UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle(rect:  this.m_TextMeshPro, screenPoint:  new UnityEngine.Vector2() {x = val_3, y = val_57}, cam:  this.m_Camera, worldPoint: out  new UnityEngine.Vector3() {x = 0.0001045861f, y = 0f, z = 0f});
            string val_18 = GetLinkID();
            if(953898312 == 0)
            {
                goto label_23;
            }
            
            if((System.String.op_Equality(a:  953898312, b:  -1610600021)) == true)
            {
                goto label_23;
            }
            
            bool val_20 = System.String.op_Equality(a:  953898312, b:  -1610600019);
            goto label_23;
            label_12:
            if(mem[1152921509855724680] != 1)
            {
                    mem[1152921509855724680] = 0;
                mem[1152921509855724680] = mem[1152921509855724680];
            }
            
            label_23:
            val_54 = this.m_TextMeshPro;
            val_53 = 0;
            UnityEngine.Vector3 val_21 = UnityEngine.Input.mousePosition;
            UnityEngine.Camera val_22 = UnityEngine.Camera.main;
            int val_23 = TMPro.TMP_TextUtilities.FindIntersectingWord(text:  val_54, position:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7}, camera:  0);
            if(val_23 != 1)
            {
                    0 = val_23;
                val_23 = mem[1152921509855724688];
            }
            
            if(0 != val_23)
            {
                goto label_26;
            }
            
            return;
            label_9:
            if((UnityEngine.Input.GetKey(key:  304)) != true)
            {
                    if((UnityEngine.Input.GetKey(key:  303)) == false)
            {
                goto label_51;
            }
            
            }
            
            this.m_lastCharIndex = 0;
            int val_27 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255);
            UnityEngine.Color32 val_29 = new UnityEngine.Color32(r:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, g:  (int)val_27 & 255, b:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, a:  255);
            var val_30 = 0f + 0;
            int val_31 = val_27 + (val_30 << 3);
            var val_32 = ((val_27 + ((0f + 0)) << 3) + 44) + 0;
            mem2[0] = val_29.r;
            var val_34 = ((val_27 + ((0f + 0)) << 3) + 44) + ((0 + 1) << 2);
            mem2[0] = val_29.r;
            var val_36 = ((val_27 + ((0f + 0)) << 3) + 44) + ((0 + 2) << 2);
            mem2[0] = val_29.r;
            var val_38 = ((val_27 + ((0f + 0)) << 3) + 44) + ((0 + 3) << 2);
            mem2[0] = val_29.r;
            byte val_39 = val_29.r + (val_30 << 3);
            (val_29.r + ((0f + 0)) << 3) + 16.colors32 = (val_27 + ((0f + 0)) << 3) + 44;
            goto label_51;
            label_26:
            mem[1152921509855724688] = 0;
            var val_40 = R6 + (0 << 4);
            UnityEngine.Transform val_41 = this.m_TextMeshPro.transform;
            UnityEngine.Vector3 val_42 = TransformPoint(position:  new UnityEngine.Vector3() {x = this.m_TextMeshPro, y = 2.522337E-44f, z = 1.21913E-43f});
            UnityEngine.Camera val_43 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_44 = WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_3, z = val_4});
            val_58 = val_52;
            val_59 = 0;
            UnityEngine.Color32 val_48 = new UnityEngine.Color32(r:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, g:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, b:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, a:  255);
            var val_56 = 356;
            val_56 = ((R6 + (val_23) << 4) + 20) * val_56;
            var val_49 = val_56 + 72;
            goto label_67;
            label_77:
            var val_57 = (R6 + (val_23) << 4) + 20;
            val_57 = val_57 + val_59;
            var val_58 = val_46 + 668 + 44 + (((R6 + (val_23) << 4) + 20 * 356) + 72);
            var val_50 = val_4 + (val_58 << 2);
            mem2[0] = val_48.r;
            var val_52 = val_4 + ((val_58 + 1) << 2);
            val_58 = val_52;
            mem2[0] = val_48.r;
            var val_54 = val_4 + ((val_58 + 2) << 2);
            val_58 = val_58 + 3;
            mem2[0] = val_48.r;
            var val_55 = val_4 + (val_58 << 2);
            val_49 = val_49 + 356;
            val_59 = 1;
            mem2[0] = val_48.r;
            label_67:
            if(val_59 < ((R6 + (val_23) << 4) + 28))
            {
                goto label_77;
            }
            
            this.m_TextMeshPro.colors32 = val_4;
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Debug.Log(message:  -1610605687);
            this.m_isHoveringObject = true;
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Debug.Log(message:  -1610605685);
            this.m_isHoveringObject = false;
        }
        public TMP_TextSelector_A()
        {
            this.m_selectedLink = 0;
            this.m_lastCharIndex = 0;
            this.m_lastWordIndex = 0;
        }
    
    }

}
