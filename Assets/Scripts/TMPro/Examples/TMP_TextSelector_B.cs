using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_TextSelector_B : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
    {
        // Fields
        public UnityEngine.RectTransform TextPopup_Prefab_01;
        private UnityEngine.RectTransform m_TextPopup_RectTransform;
        private TMPro.TextMeshProUGUI m_TextPopup_TMPComponent;
        private const string k_LinkText = "You have selected link <#ffff00>";
        private const string k_WordText = "Word Index: <#ffff00>";
        private TMPro.TextMeshProUGUI m_TextMeshPro;
        private UnityEngine.Canvas m_Canvas;
        private UnityEngine.Camera m_Camera;
        private bool isHoveringObject;
        private int m_selectedWord;
        private int m_selectedLink;
        private int m_lastIndex;
        private UnityEngine.Matrix4x4 m_matrix;
        private TMPro.TMP_MeshInfo[] m_cachedMeshInfoVertexData;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            Weight val_2 = this.GetComponent<Weight>();
            this.m_TextMeshPro = this;
            UnityEngine.GameObject val_3 = this.gameObject;
            object val_4 = this.GetComponentInParent<System.Object>();
            this.m_Canvas = this;
            UnityEngine.RenderMode val_5 = this.renderMode;
            if(this.m_Canvas != 0)
            {
                    UnityEngine.Camera val_6 = this.worldCamera;
                this.m_Camera = this.m_Canvas;
            }
            else
            {
                    this.m_Camera = 0;
            }
            
            DropdownItem val_7 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this.TextPopup_Prefab_01);
            this.m_TextPopup_RectTransform = this.TextPopup_Prefab_01;
            UnityEngine.Transform val_8 = this.transform;
            this.m_TextPopup_RectTransform.SetParent(parent:  954403440, worldPositionStays:  false);
            UnityEngine.UI.Toggle val_9 = this.m_TextPopup_RectTransform.GetComponentInChildren<UnityEngine.UI.Toggle>();
            this.m_TextPopup_TMPComponent = this.m_TextPopup_RectTransform;
            UnityEngine.GameObject val_10 = this.m_TextPopup_RectTransform.gameObject;
            this.m_TextPopup_RectTransform.SetActive(value:  false);
        }
        private void OnEnable()
        {
            if(((mem[536895194] & true) == 0) && (mem[536895123] == 0))
            {
                    536895007 = 536895007;
            }
            
            536873315 = new System.Action<SdkConfiguration>(object:  954519536, method:  new IntPtr(1610683717));
            mem[536895099] + 44.Add(rhs:  536873315);
        }
        private void OnDisable()
        {
            if(((mem[536895194] & true) == 0) && (mem[536895123] == 0))
            {
                    536895007 = 536895007;
            }
            
            536873315 = new System.Action<SdkConfiguration>(object:  954631536, method:  new IntPtr(1610683717));
            mem[536895099] + 44.Remove(rhs:  536873315);
        }
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            if(obj != this.m_TextMeshPro)
            {
                    return;
            }
            
            TMPro.TMP_MeshInfo[] val_2 = this.m_TextMeshPro.CopyMeshInfoVertexData();
            this.m_cachedMeshInfoVertexData = this.m_TextMeshPro;
        }
        private void LateUpdate()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_33;
            TMPro.Examples.TMP_TextSelector_B val_103;
            float val_104;
            var val_105;
            TMPro.TextMeshProUGUI val_106;
            TMPro.TextMeshProUGUI val_107;
            var val_108;
            var val_109;
            var val_110;
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            var val_115;
            var val_116;
            var val_117;
            var val_118;
            var val_119;
            var val_120;
            var val_121;
            var val_122;
            var val_123;
            var val_124;
            var val_125;
            var val_126;
            var val_127;
            var val_128;
            var val_129;
            float val_130;
            float val_131;
            UnityEngine.Camera val_132;
            TMPro.TextMeshProUGUI val_133;
            var val_135;
            val_103 = this;
            if(this.isHoveringObject == false)
            {
                goto label_1;
            }
            
            UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
            val_104 = val_2;
            int val_5 = TMPro.TMP_TextUtilities.FindIntersectingCharacter(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = val_104, y = val_3, z = val_4}, camera:  this.m_Camera, visibleOnly:  true);
            if(val_5 == 1)
            {
                goto label_4;
            }
            
            if(val_5 == this.m_lastIndex)
            {
                goto label_61;
            }
            
            this.RestoreCachedVertexAttributes(index:  this.m_lastIndex);
            this.m_lastIndex = 0;
            if((UnityEngine.Input.GetKey(key:  304)) != true)
            {
                    if((UnityEngine.Input.GetKey(key:  303)) == false)
            {
                goto label_61;
            }
            
            }
            
            this.m_lastIndex = val_5;
            TMPro.TextMeshProUGUI val_106 = this.m_TextMeshPro;
            float val_107 = 0f;
            var val_8 = 0 + 0;
            val_8 = val_106 + (val_8 << 3);
            if(val_8 <= val_107)
            {
                    val_105 = mem[this.m_TextMeshPro + 12];
                val_105 = this.m_TextMeshPro + 12;
            }
            
            var val_10 = val_107 + 2;
            TMPro.TextMeshProUGUI val_11 = val_106 + ((val_107 + 0) << 2);
            if(val_105 <= val_10)
            {
                    val_105 = mem[this.m_TextMeshPro + 12];
                val_105 = this.m_TextMeshPro + 12;
            }
            
            val_106 = val_11 + 16;
            TMPro.TextMeshProUGUI val_13 = val_11 + 24;
            val_107 = val_11 + 20;
            TMPro.TextMeshProUGUI val_14 = val_106 + ((val_10 + (val_10 << 1)) << 2);
            val_1.x = S16 + val_1.x;
            val_1.z = S18 + val_1.z;
            float val_15 = val_1.x * 0.5f;
            float val_16 = val_1.z * 0.5f;
            if(val_105 <= val_107)
            {
                    val_106 = val_106;
                val_105 = mem[this.m_TextMeshPro + 12];
                val_105 = this.m_TextMeshPro + 12;
            }
            
            if(val_105 <= val_107)
            {
                    val_106 = val_106;
                val_107 = val_107;
            }
            
            mem2[0] = val_106 - val_15;
            mem2[0] = 1152921504838422528 - val_16;
            mem2[0] = null;
            val_108 = mem[this.m_TextMeshPro + 12];
            val_108 = this.m_TextMeshPro + 12;
            var val_19 = val_107 + 1;
            if(val_108 <= val_19)
            {
                    val_108 = mem[this.m_TextMeshPro + 12];
                val_108 = this.m_TextMeshPro + 12;
            }
            
            val_106 = val_106 + ((val_19 + (val_19 << 1)) << 2);
            val_109 = ((this.m_TextMeshPro + (((0f + 1) + ((0f + 1)) << 1)) << 2) + 24) - 4;
            val_110 = ((this.m_TextMeshPro + (((0f + 1) + ((0f + 1)) << 1)) << 2) + 24) - 8;
            if(val_108 <= val_19)
            {
                    val_110 = val_110;
                val_109 = val_109;
            }
            
            mem2[0] = ((this.m_TextMeshPro + (((0f + 1) + ((0f + 1)) << 1)) << 2) + 24 + -8) - val_15;
            val_107 = val_14 + 24;
            mem2[0] = ((this.m_TextMeshPro + (((0f + 1) + ((0f + 1)) << 1)) << 2) + 24 + -4) - val_16;
            TMPro.TextMeshProUGUI val_23 = val_14 + 20;
            mem2[0] = val_107;
            val_14 = val_14 + 16;
            val_111 = mem[this.m_TextMeshPro + 12];
            val_111 = this.m_TextMeshPro + 12;
            if(val_111 <= val_10)
            {
                    val_111 = mem[this.m_TextMeshPro + 12];
                val_111 = this.m_TextMeshPro + 12;
            }
            
            mem2[0] = 1152921504838422528 - val_15;
            mem2[0] = 1152921504838422528 - val_16;
            mem2[0] = null;
            val_112 = mem[this.m_TextMeshPro + 12];
            val_112 = this.m_TextMeshPro + 12;
            if(val_112 <= 3)
            {
                    val_112 = mem[this.m_TextMeshPro + 12];
                val_112 = this.m_TextMeshPro + 12;
            }
            
            TMPro.TextMeshProUGUI val_26 = val_106 + 36;
            var val_27 = ((this.m_TextMeshPro + 36) + 24) - 4;
            var val_28 = ((this.m_TextMeshPro + 36) + 24) - 8;
            mem2[0] = ((this.m_TextMeshPro + 36) + 24 + -8) - val_15;
            mem2[0] = ((this.m_TextMeshPro + 36) + 24 + -4) - val_16;
            mem2[0] = (this.m_TextMeshPro + 36) + 24;
            UnityEngine.Vector3 val_31 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.one;
            float val_110 = 1.5f;
            float val_108 = val_2;
            float val_109 = val_3;
            val_108 = val_108 * val_110;
            val_109 = val_109 * val_110;
            val_110 = val_4 * val_110;
            UnityEngine.Matrix4x4 val_35 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0.000112386f, y = val_2, z = val_3}, q:  new UnityEngine.Quaternion() {x = val_4, y = val_2, z = val_3, w = val_4}, s:  new UnityEngine.Vector3() {x = val_33, y = val_108, z = val_109});
            float val_36 = val_35.m11 + 32;
            val_103 = mem[val_35.m13 + 116];
            val_103 = val_35.m13 + 116;
            float val_37 = val_35.m11 + 16;
            var val_39 = val_103 + 68;
            var val_40 = val_103 + 84;
            var val_41 = val_103 + 100;
            mem2[0] = val_35.m13 + 60;
            mem2[0] = 0;
            float val_42 = val_35.m13 + 120;
            mem2[0] = val_103 + 52;
            val_113 = mem[val_35.m13 + 124];
            val_113 = val_35.m13 + 124;
            val_114 = mem[val_35.m13 + 128];
            val_114 = val_35.m13 + 128;
            if((val_35.m13 + 36) <= (val_35.m13 + 112))
            {
                    mem2[0] = val_113;
                val_113 = mem[val_35.m13 + 32];
                val_113 = val_35.m13 + 32;
                val_114 = val_114;
            }
            
            mem2[0] = val_35.m13 + 120;
            mem2[0] = val_113;
            mem2[0] = val_114;
            float val_43 = val_35.m13 + 120;
            val_115 = mem[val_35.m13 + 120];
            val_115 = val_35.m13 + 120;
            val_116 = mem[val_35.m13 + 128];
            val_116 = val_35.m13 + 128;
            if((val_35.m13 + 36) <= (val_35.m13 + 100))
            {
                    mem2[0] = val_115;
                val_115 = mem[val_35.m13 + 32];
                val_115 = val_35.m13 + 32;
                val_116 = val_116;
            }
            
            mem2[0] = val_115;
            val_104 = val_35.m13 + 36;
            mem2[0] = val_35.m13 + 124;
            mem2[0] = val_116;
            float val_44 = val_35.m13 + 120;
            val_117 = mem[val_35.m13 + 124];
            val_117 = val_35.m13 + 124;
            val_118 = mem[val_35.m13 + 128];
            val_118 = val_35.m13 + 128;
            if(val_104 <= (val_35.m13 + 108))
            {
                    mem2[0] = val_117;
                val_117 = mem[val_35.m13 + 32];
                val_117 = val_35.m13 + 32;
                val_118 = val_118;
            }
            
            mem2[0] = val_35.m13 + 120;
            mem2[0] = val_117;
            mem2[0] = val_118;
            float val_45 = val_35.m13 + 120;
            val_119 = val_35.m13 + 72;
            val_120 = mem[val_35.m13 + 128];
            val_120 = val_35.m13 + 128;
            if(val_104 <= (val_35.m13 + 96))
            {
                    val_119 = mem[val_35.m13 + 72];
                val_119 = val_35.m13 + 72;
                val_120 = val_120;
            }
            
            mem2[0] = val_35.m13 + 120;
            mem2[0] = val_35.m13 + 124;
            mem2[0] = val_120;
            val_121 = mem[val_35.m13 + 36];
            val_121 = val_104;
            if(val_121 <= (val_35.m13 + 112))
            {
                    val_121 = mem[val_35.m13 + 36];
                val_121 = val_104;
            }
            
            val_122 = mem[val_35.m13 + 88];
            val_122 = val_35.m13 + 88;
            val_123 = mem[val_35.m13 + 104];
            val_123 = val_35.m13 + 104;
            float val_111 = 0f;
            if(val_121 <= (val_35.m13 + 112))
            {
                    val_123 = mem[val_35.m13 + 104];
                val_123 = val_35.m13 + 104;
                val_122 = mem[val_35.m13 + 88];
                val_122 = val_35.m13 + 88;
            }
            
            mem2[0] = val_15 + val_123;
            mem2[0] = val_16 + val_122;
            mem2[0] = (val_35.m13 + 60) + val_111;
            val_124 = mem[val_35.m13 + 36];
            val_124 = val_104;
            if(val_124 <= (val_35.m13 + 100))
            {
                    val_124 = mem[val_35.m13 + 36];
                val_124 = val_104;
            }
            
            val_125 = mem[val_35.m13 + 84];
            val_125 = val_35.m13 + 84;
            val_126 = mem[val_35.m13 + 80];
            val_126 = val_35.m13 + 80;
            if(val_124 <= (val_35.m13 + 100))
            {
                    val_126 = mem[val_35.m13 + 80];
                val_126 = val_35.m13 + 80;
                val_125 = mem[val_35.m13 + 84];
                val_125 = val_35.m13 + 84;
            }
            
            mem2[0] = val_15 + val_126;
            mem2[0] = val_16 + val_125;
            mem2[0] = (val_35.m13 + 48) + val_111;
            val_127 = mem[val_35.m13 + 36];
            val_127 = val_104;
            if(val_127 <= (val_35.m13 + 108))
            {
                    val_127 = mem[val_35.m13 + 36];
                val_127 = val_104;
            }
            
            val_128 = mem[val_35.m13 + 76];
            val_128 = val_35.m13 + 76;
            if(val_127 <= (val_35.m13 + 108))
            {
                    val_128 = mem[val_35.m13 + 76];
                val_128 = val_35.m13 + 76;
            }
            
            mem2[0] = val_15 + (val_35.m13 + 52);
            mem2[0] = val_16 + (val_35.m13 + 56);
            mem2[0] = val_128 + val_111;
            val_129 = mem[val_35.m13 + 36];
            val_129 = val_104;
            if(val_129 <= (val_35.m13 + 96))
            {
                    val_129 = mem[val_35.m13 + 36];
                val_129 = val_104;
            }
            
            val_111 = (val_35.m13 + 72) + val_111;
            val_16 = val_16 + (val_35.m13 + 44);
            val_15 = val_15 + (val_35.m13 + 40);
            mem2[0] = val_15;
            mem2[0] = val_16;
            mem2[0] = val_111;
            mem2[0] = 0;
            float val_55 = val_35.m32 - 88;
            mem2[0] = 255;
            var val_112 = val_35.m13 + 64;
            val_112 = (val_35.m13 + 116 + 24 + 668 + 64) + (val_112 << 3);
            var val_56 = ((val_35.m13 + 116 + 24 + 668 + 64 + (val_35.m13 + 64) << 3) + 44) + ((val_35.m13 + 112) << 2);
            mem2[0] = val_35.m32 + -88;
            var val_57 = ((val_35.m13 + 116 + 24 + 668 + 64 + (val_35.m13 + 64) << 3) + 44) + ((val_35.m13 + 100) << 2);
            mem2[0] = val_35.m32 + -88;
            var val_58 = ((val_35.m13 + 116 + 24 + 668 + 64 + (val_35.m13 + 64) << 3) + 44) + ((val_35.m13 + 108) << 2);
            mem2[0] = val_35.m32 + -88;
            var val_59 = ((val_35.m13 + 116 + 24 + 668 + 64 + (val_35.m13 + 64) << 3) + 44) + ((val_35.m13 + 96) << 2);
            mem2[0] = val_35.m32 + -88;
            var val_113 = val_35.m13 + 64;
            val_113 = (val_35.m13 + 116 + 24 + 668 + 64) + (val_113 << 3);
            float val_60 = val_35.m32 - 128;
            var val_61 = val_113 + 16;
            var val_62 = val_104 - 4;
            if((val_35.m13 + 116 + 24) != 0)
            {
                goto label_61;
            }
            
            goto label_61;
            label_1:
            if(this.m_lastIndex == 1)
            {
                    return;
            }
            
            this.RestoreCachedVertexAttributes(index:  this.m_lastIndex);
            this.m_lastIndex = 0;
            return;
            label_4:
            this.RestoreCachedVertexAttributes(index:  this.m_lastIndex);
            this.m_lastIndex = 0;
            label_61:
            TMPro.TextMeshProUGUI val_117 = this.m_TextMeshPro;
            var val_118 = 0;
            UnityEngine.Vector3 val_63 = UnityEngine.Input.mousePosition;
            int val_64 = TMPro.TMP_TextUtilities.FindIntersectingWord(text:  val_117, position:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7}, camera:  this.m_Camera);
            bool val_65 = UnityEngine.Object.op_Inequality(x:  this.m_TextPopup_RectTransform, y:  0);
            if(val_65 == true)
            {
                    val_65 = this.m_selectedWord;
            }
            
            if(val_65 != 1)
            {
                goto label_68;
            }
            
            label_120:
            if(val_64 != 1)
            {
                    val_65 = this.m_selectedWord;
            }
            
            if(val_64 != val_65)
            {
                goto label_69;
            }
            
            label_148:
            val_130 = 0;
            UnityEngine.Vector3 val_66 = UnityEngine.Input.mousePosition;
            int val_67 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  this.m_TextMeshPro, position:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7}, camera:  this.m_Camera);
            if(val_67 == 1)
            {
                goto label_72;
            }
            
            if(val_67 != this.m_selectedLink)
            {
                goto label_73;
            }
            
            return;
            label_72:
            if(this.m_selectedLink == 1)
            {
                    return;
            }
            
            label_73:
            UnityEngine.GameObject val_68 = this.m_TextPopup_RectTransform.gameObject;
            this.m_TextPopup_RectTransform.SetActive(value:  false);
            this.m_selectedLink = 0;
            if(val_67 == 1)
            {
                    return;
            }
            
            this.m_selectedLink = val_67;
            int val_69 = (val_67 << 3) - val_67;
            val_69 = this.m_TextMeshPro + (val_69 << 2);
            TMPro.TextMeshProUGUI val_70 = val_69 + 16;
            val_130 = 0f;
            UnityEngine.RectTransform val_71 = this.m_TextMeshPro.rectTransform;
            UnityEngine.Vector3 val_72 = UnityEngine.Input.mousePosition;
            val_131 = val_3;
            val_132 = this.m_Camera;
            bool val_73 = UnityEngine.RectTransformUtility.ScreenPointToWorldPointInRectangle(rect:  this.m_TextMeshPro, screenPoint:  new UnityEngine.Vector2() {x = val_2, y = val_131}, cam:  val_132, worldPoint: out  new UnityEngine.Vector3() {x = 0.0001123861f, y = val_130, z = val_4});
            string val_74 = GetLinkID();
            if(954970344 == 0)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  954970344, b:  -1610600021)) == false)
            {
                goto label_87;
            }
            
            val_132 = this.m_TextPopup_RectTransform;
            val_132.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.GameObject val_76 = this.m_TextPopup_RectTransform.gameObject;
            this.m_TextPopup_RectTransform.SetActive(value:  true);
            val_133 = this.m_TextPopup_TMPComponent;
            val_135 = 22797492;
            goto label_92;
            label_68:
            if(val_64 != 1)
            {
                    if(val_64 == val_65)
            {
                goto label_148;
            }
            
            }
            
            var val_77 = (val_64 + 48) + (this.m_selectedWord << 4);
            if(((val_64 + 48 + (this.m_selectedWord) << 4) + 28) >= 1)
            {
                    var val_114 = (val_64 + 48 + (this.m_selectedWord) << 4) + 20;
                var val_78 = val_114 * 356;
                do
            {
                var val_79 = R7 + val_78;
                TMPro.TextMeshProUGUI val_80 = this.m_TextMeshPro + val_78;
                var val_81 = ((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52) + (((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52) << 2);
                val_81 = this.m_TextMeshPro + (val_81 << 3);
                var val_82 = ((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52) + 0;
                UnityEngine.Color32 val_83 = TMPro.TMPro_ExtensionMethods.Tint(c1:  new UnityEngine.Color32() {r = ((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52 + 0) + 16, g = ((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52 + 0) + 16, b = ((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52 + 0) + 16, a = ((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52 + 0) + 16}, tint:  val_63.x);
                mem2[0] = val_83.r;
                mem[1] = val_83.g;
                mem[2] = val_83.b;
                mem[3] = val_83.a;
                var val_85 = ((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52) + ((val_118 + 1) << 2);
                val_103 = val_103;
                mem2[0] = val_83.r;
                mem[1] = val_83.g;
                mem[2] = val_83.b;
                mem[3] = val_83.a;
                var val_87 = ((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52) + ((val_118 + 2) << 2);
                var val_88 = val_118 + 3;
                mem2[0] = val_83.r;
                mem[1] = val_83.g;
                mem[2] = val_83.b;
                mem[3] = val_83.a;
                var val_115 = (val_64 + 48 + (this.m_selectedWord) << 4) + 28;
                var val_89 = ((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52) + (val_88 << 2);
                val_114 = val_114 + 1;
                val_78 = val_78 + 356;
                val_115 = val_115 - 1;
                mem2[0] = val_83.r;
                mem[1] = val_83.g;
                mem[2] = val_83.b;
                mem[3] = val_83.a;
            }
            while(((R7 + ((val_64 + 48 + (this.m_selectedWord) << 4) + 20 * 356)) + 52 + 12) != val_88);
            
            }
            
            this.m_selectedWord = 0;
            goto label_120;
            label_69:
            if(((UnityEngine.Input.GetKey(key:  304)) == true) || ((UnityEngine.Input.GetKey(key:  303)) == true))
            {
                goto label_148;
            }
            
            this.m_selectedWord = val_64;
            TMPro.TextMeshProUGUI val_92 = this.m_TextMeshPro + (val_64 << 4);
            if(val_118 >= 1)
            {
                    TMPro.TextMeshProUGUI val_93 = val_117 * 356;
                do
            {
                TMPro.TextMeshProUGUI val_116 = this.m_TextMeshPro;
                TMPro.TextMeshProUGUI val_94 = val_116 + val_93;
                TMPro.TextMeshProUGUI val_95 = val_116 + val_93;
                int val_96 = val_64 + (val_64 << 2);
                val_96 = this.m_TextMeshPro + (val_96 << 3);
                TMPro.TextMeshProUGUI val_97 = this.m_TextMeshPro + (val_116 << 2);
                UnityEngine.Color32 val_98 = TMPro.TMPro_ExtensionMethods.Tint(c1:  new UnityEngine.Color32() {r = val_96, g = val_96, b = val_96, a = val_96}, tint:  val_63.x);
                mem2[0] = val_98.r;
                mem[1] = val_98.g;
                mem[2] = val_98.b;
                mem[3] = val_98.a;
                TMPro.TextMeshProUGUI val_100 = this.m_TextMeshPro + ((val_116 + 1) << 2);
                mem2[0] = val_98.r;
                mem[1] = val_98.g;
                mem[2] = val_98.b;
                mem[3] = val_98.a;
                val_116 = val_116 + 3;
                mem2[0] = val_98.r;
                mem[1] = val_98.g;
                mem[2] = val_98.b;
                mem[3] = val_98.a;
                TMPro.TextMeshProUGUI val_103 = this.m_TextMeshPro + (val_116 << 2);
                val_117 = val_117 + 1;
                val_93 = val_93 + 356;
                val_118 = val_118 - 1;
                mem2[0] = val_98.r;
                mem[1] = val_98.g;
                mem[2] = val_98.b;
                mem[3] = val_98.a;
            }
            while((this.m_TextMeshPro + ((val_116 + 2) << 2)) != val_116);
            
            }
            
            if(this.m_TextMeshPro != 0)
            {
                goto label_148;
            }
            
            goto label_148;
            label_87:
            if((System.String.op_Equality(a:  954970344, b:  -1610600019)) == false)
            {
                    return;
            }
            
            val_132 = this.m_TextPopup_RectTransform;
            val_132.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.GameObject val_105 = this.m_TextPopup_RectTransform.gameObject;
            this.m_TextPopup_RectTransform.SetActive(value:  true);
            val_133 = this.m_TextPopup_TMPComponent;
            val_135 = 22797496;
            label_92:
            val_133.text = -1610602417;
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.isHoveringObject = true;
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.isHoveringObject = false;
        }
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public void OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        private void RestoreCachedVertexAttributes(int index)
        {
            if(index == 1)
            {
                    return;
            }
            
            if(1152921509857545199 < index)
            {
                    return;
            }
            
            var val_1 = 0 + 0;
            TMPro.TMP_MeshInfo val_71 = this.m_cachedMeshInfoVertexData[val_1 << 3];
            var val_73 = val_1;
            val_73 = this.m_cachedMeshInfoVertexData[1] + (val_73 << 3);
            var val_2 = 0f + 0;
            TMPro.TMP_MeshInfo val_3 = val_71 + (val_2 << 2);
            UnityEngine.Vector2[] val_4 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).uvs2) + (val_2 << 2);
            var val_5 = 0f + 1;
            var val_6 = val_5 + (val_5 << 1);
            TMPro.TMP_MeshInfo val_7 = val_71 + (val_6 << 2);
            UnityEngine.Vector2[] val_8 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).uvs2) + (val_6 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 1) + ((0f + 1)) << 1)) << 2) + 16;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 1) + ((0f + 1)) << 1)) << 2) + 20;
            Length = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 1) + ((0f + 1)) << 1)) << 2) + 24;
            TMPro.TMP_MeshInfo val_9 = val_71 + 24;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 24) + 16;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 24) + 20;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 24) + 24;
            var val_10 = 0f + 3;
            var val_11 = val_10 + (val_10 << 1);
            TMPro.TMP_MeshInfo val_12 = val_71 + (val_11 << 2);
            UnityEngine.Vector2[] val_13 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).uvs2) + (val_11 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 16;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 20;
            Length = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 24;
            var val_74 = val_1;
            val_74 = ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 16) + (val_74 << 3);
            TMPro.TMP_MeshInfo val_75 = this.m_cachedMeshInfoVertexData[val_1 << 3];
            var val_14 = (((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 16 + ((0 + 0)) << 3) + 44) + 0;
            mem2[0] = mem[this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0].mesh + 16];
            TMPro.TMP_MeshInfo val_15 = val_75 + (val_5 << 2);
            var val_16 = (((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 16 + ((0 + 0)) << 3) + 44) + (val_5 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((0f + 1)) << 2).tangents;
            var val_17 = (((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 16 + ((0 + 0)) << 3) + 44) + 8;
            mem2[0] = mem[this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0].vertices + 16];
            TMPro.TMP_MeshInfo val_18 = val_75 + (val_10 << 2);
            var val_19 = (((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((0f + 3) + ((0f + 3)) << 1)) << 2) + 16 + ((0 + 0)) << 3) + 44) + (val_10 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((0f + 3)) << 2).tangents;
            TMPro.TMP_MeshInfo val_76 = this.m_cachedMeshInfoVertexData[val_1 << 3];
            var val_78 = val_1;
            val_78 = this.m_cachedMeshInfoVertexData[1] + (val_78 << 3);
            mem2[0] = mem[this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0].mesh + 16];
            mem2[0] = mem[this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0].mesh + 20];
            TMPro.TMP_MeshInfo val_20 = val_76 + (val_5 << 3);
            UnityEngine.Material val_21 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).material) + (val_5 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((0f + 1)) << 3).tangents;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((0f + 1)) << 3).uvs0;
            mem2[0] = mem[this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0].tangents + 16];
            mem2[0] = mem[this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0].tangents + 20];
            TMPro.TMP_MeshInfo val_22 = val_76 + (val_10 << 3);
            UnityEngine.Material val_23 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).material) + (val_10 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((0f + 3)) << 3).tangents;
            TMPro.TMP_MeshInfo val_79 = this.m_cachedMeshInfoVertexData[val_1 << 3];
            var val_81 = val_1;
            val_81 = this.m_cachedMeshInfoVertexData[1] + (val_81 << 3);
            var val_24 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 40]) + 0;
            mem2[0] = mem[this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0].mesh + 16];
            mem2[0] = mem[this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0].mesh + 20];
            TMPro.TMP_MeshInfo val_25 = val_79 + (val_5 << 3);
            var val_26 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 40]) + (val_5 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((0f + 1)) << 3).tangents;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((0f + 1)) << 3).uvs0;
            var val_27 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 40]) + 16;
            mem2[0] = mem[this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0].tangents + 16];
            TMPro.TMP_MeshInfo val_28 = val_79 + (val_10 << 3);
            var val_29 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 40]) + (val_10 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((0f + 3)) << 3).tangents;
            var val_30 = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12) >> 31;
            val_30 = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12) + (val_30 >> 30);
            val_30 = val_30 & (~3);
            var val_31 = val_30 - 4;
            var val_32 = val_31 + (val_31 << 1);
            TMPro.TMP_MeshInfo val_33 = val_71 + (val_32 << 2);
            UnityEngine.Vector2[] val_34 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).uvs2) + (val_32 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) -  + 16;
            var val_35 = val_30 - 3;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) -  + 20;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) -  + 24;
            var val_36 = val_35 + (val_35 << 1);
            TMPro.TMP_MeshInfo val_37 = val_71 + (val_36 << 2);
            UnityEngine.Vector2[] val_38 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).uvs2) + (val_36 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) -  + 16;
            var val_39 = val_30 - 2;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) -  + 20;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) -  + 24;
            val_39 = val_39 + (val_39 << 1);
            TMPro.TMP_MeshInfo val_40 = val_71 + (val_39 << 2);
            UnityEngine.Vector2[] val_41 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).uvs2) + (val_39 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) -  + 16;
            var val_42 = val_30 - 1;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) -  + 20;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + (((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) -  + 24;
            var val_43 = val_42 + (val_42 << 1);
            TMPro.TMP_MeshInfo val_45 = (val_71 + (val_43 << 2)) + 16;
            UnityEngine.Vector2[] val_46 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).uvs2) + (val_43 << 2);
            val_46 = val_46 + 16;
            TMPro.TMP_MeshInfo val_82 = this.m_cachedMeshInfoVertexData[val_1 << 3];
            var val_84 = val_1;
            val_84 = this.m_cachedMeshInfoVertexData[1] + (val_84 << 3);
            TMPro.TMP_MeshInfo val_47 = val_82 + (val_31 << 2);
            var val_48 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 44]) + (val_31 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 4.tangents;
            TMPro.TMP_MeshInfo val_49 = val_82 + (val_35 << 2);
            var val_50 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 44]) + (val_35 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 3.tangents;
            TMPro.TMP_MeshInfo val_51 = val_82 + (val_39 << 2);
            var val_52 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 44]) + (val_39 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 2.tangents;
            TMPro.TMP_MeshInfo val_53 = val_82 + (val_42 << 2);
            var val_54 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 44]) + (val_42 << 2);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 1.tangents;
            TMPro.TMP_MeshInfo val_85 = this.m_cachedMeshInfoVertexData[val_1 << 3];
            var val_87 = val_1;
            val_87 = this.m_cachedMeshInfoVertexData[1] + (val_87 << 3);
            TMPro.TMP_MeshInfo val_55 = val_85 + (val_31 << 3);
            UnityEngine.Material val_56 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).material) + (val_31 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 4.tangents;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 4.uvs0;
            TMPro.TMP_MeshInfo val_57 = val_85 + (val_35 << 3);
            UnityEngine.Material val_58 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).material) + (val_35 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 3.tangents;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 3.uvs0;
            TMPro.TMP_MeshInfo val_59 = val_85 + (val_39 << 3);
            UnityEngine.Material val_60 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).material) + (val_39 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 2.tangents;
            TMPro.TMP_MeshInfo val_61 = val_85 + (val_42 << 3);
            UnityEngine.Material val_62 = ((this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3).material) + (val_42 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 1.tangents;
            TMPro.TMP_MeshInfo val_88 = this.m_cachedMeshInfoVertexData[val_1 << 3];
            var val_90 = val_1;
            val_90 = this.m_cachedMeshInfoVertexData[1] + (val_90 << 3);
            TMPro.TMP_MeshInfo val_63 = val_88 + (val_31 << 3);
            var val_64 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 40]) + (val_31 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 4.tangents;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 4.uvs0;
            TMPro.TMP_MeshInfo val_65 = val_88 + (val_35 << 3);
            var val_66 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 40]) + (val_35 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 3.tangents;
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 3.uvs0;
            TMPro.TMP_MeshInfo val_67 = val_88 + (val_39 << 3);
            var val_68 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 40]) + (val_39 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 2.tangents;
            TMPro.TMP_MeshInfo val_69 = val_88 + (val_42 << 3);
            var val_70 = (mem[(this.m_cachedMeshInfoVertexData[1] + ((0 + 0)) << 3) + 40]) + (val_42 << 3);
            mem2[0] = (this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + ((((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 + ((this.m_cachedMeshInfoVertexData[((0 + 0)) << 3][0] + 12 >> 31)) >> 30) & (~3)) - 1.tangents;
            if(this.m_TextMeshPro == 0)
            {
                
            }
        
        }
        public TMP_TextSelector_B()
        {
            this.m_selectedWord = 0;
            this.m_selectedLink = 0;
            this.m_lastIndex = 0;
        }
    
    }

}
