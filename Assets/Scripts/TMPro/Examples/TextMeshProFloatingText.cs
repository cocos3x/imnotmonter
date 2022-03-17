using UnityEngine;

namespace TMPro.Examples
{
    public class TextMeshProFloatingText : MonoBehaviour
    {
        // Fields
        public UnityEngine.Font TheFont;
        private UnityEngine.GameObject m_floatingText;
        private TMPro.TextMeshPro m_textMeshPro;
        private UnityEngine.TextMesh m_textMesh;
        private UnityEngine.Transform m_transform;
        private UnityEngine.Transform m_floatingText_Transform;
        private UnityEngine.Transform m_cameraTransform;
        private UnityEngine.Vector3 lastPOS;
        private UnityEngine.Quaternion lastRotation;
        public int SpawnType;
        public bool IsTextObjectScaleStatic;
        private static UnityEngine.WaitForEndOfFrame k_WaitForEndOfFrame;
        private static UnityEngine.WaitForSeconds[] k_WaitForSecondsRandom;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            this.m_transform = this;
            string val_2 = this.name;
            string val_3 = 962225264 + -1610612369(-1610612369);
            UnityEngine.GameObject val_4 = 536887303;
            val_4 = new UnityEngine.GameObject(name:  962225264);
            this.m_floatingText = val_4;
            UnityEngine.Camera val_5 = UnityEngine.Camera.main;
            UnityEngine.Transform val_6 = 0.transform;
            this.m_cameraTransform = 0;
        }
        private void Start()
        {
            float val_5;
            float val_6;
            float val_7;
            float val_13;
            TMPro.Examples.TextMeshProFloatingText val_29;
            UnityEngine.TextMesh val_30;
            float val_31;
            float val_32;
            TMPro.Examples.TextMeshProFloatingText val_33;
            var val_34;
            val_29 = this;
            if(this.SpawnType != 1)
            {
                    if(this.SpawnType != 0)
            {
                    return;
            }
            
                SynchronizationContextBehavoir val_1 = this.m_floatingText.AddComponent<SynchronizationContextBehavoir>();
                val_30 = val_29;
                this.m_textMeshPro = this.m_floatingText;
                UnityEngine.RectTransform val_2 = this.m_textMeshPro.rectTransform;
                this.m_textMeshPro.sizeDelta = new UnityEngine.Vector2() {x = 3f, y = 3f};
                UnityEngine.Transform val_3 = this.m_floatingText.transform;
                this.m_floatingText_Transform = this.m_floatingText;
                UnityEngine.Vector3 val_4 = position;
                float val_31 = 15f;
                float val_30 = 0f;
                float val_29 = val_6;
                val_29 = val_29 + val_30;
                val_30 = val_7 + val_30;
                val_31 = val_5 + val_31;
                this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_29};
                this.m_textMeshPro.alignment = 514;
                UnityEngine.Color32 val_11 = new UnityEngine.Color32(r:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, g:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, b:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, a:  255);
                UnityEngine.Color val_12 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 216, g = 42, b = 92, a = 57});
                val_31 = val_7;
                val_32 = val_5;
                val_29 = val_6;
                this.m_textMeshPro.fontSize = val_12.r;
                val_33 = val_29;
                this.m_textMeshPro.enableKerning = false;
                if(mem[1152921509864167992] == true)
            {
                    mem[1152921509864167992] = 1;
            }
            
                this.m_textMeshPro.isTextObjectScaleStatic = true;
                val_34 = val_33;
                System.Collections.IEnumerator val_14 = this.DisplayTextMeshProFloatingText();
            }
            else
            {
                    UnityEngine.Transform val_15 = this.m_floatingText.transform;
                this.m_floatingText_Transform = this.m_floatingText;
                UnityEngine.Vector3 val_16 = position;
                float val_34 = 15f;
                float val_33 = 0f;
                float val_32 = val_6;
                val_32 = val_32 + val_33;
                val_33 = val_7 + val_33;
                val_34 = val_5 + val_34;
                this.m_floatingText_Transform.position = new UnityEngine.Vector3() {x = val_33, y = val_34, z = val_32};
                SynchronizationContextBehavoir val_17 = this.m_floatingText.AddComponent<SynchronizationContextBehavoir>();
                this.m_textMesh = this.m_floatingText;
                TMPro.TMP_SpriteAsset val_18 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608035);
                this.m_textMesh.font = -1610608035;
                UnityEngine.Transform val_19 = this.m_textMesh.GetComponent<UnityEngine.Transform>();
                UnityEngine.Font val_20 = this.m_textMesh.font;
                UnityEngine.Material val_21 = this.m_textMesh.material;
                this.m_textMesh.sharedMaterial = this.m_textMesh;
                val_30 = this.m_textMesh;
                val_29 = 255;
                UnityEngine.Color32 val_25 = new UnityEngine.Color32(r:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, g:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, b:  (int)(UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  255)) & 255, a:  255);
                UnityEngine.Color val_26 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 216, g = 42, b = 92, a = 57});
                val_32 = val_7;
                val_31 = val_5;
                val_30.color = new UnityEngine.Color() {r = val_32, g = val_31, b = val_6, a = val_13};
                val_33 = val_29;
                this.m_textMesh.anchor = 7;
                this.m_textMesh.fontSize = 24;
                val_34 = val_33;
                System.Collections.IEnumerator val_27 = this.DisplayTextMeshFloatingText();
            }
            
            UnityEngine.Coroutine val_28 = this.StartCoroutine(routine:  962353648);
        }
        public System.Collections.IEnumerator DisplayTextMeshProFloatingText()
        {
            536901825 = new TextMeshProFloatingText.<DisplayTextMeshProFloatingText>d__15(<>1__state:  0);
            mem[536901841] = this;
        }
        public System.Collections.IEnumerator DisplayTextMeshFloatingText()
        {
            536901823 = new TextMeshProFloatingText.<DisplayTextMeshFloatingText>d__16(<>1__state:  0);
            mem[536901839] = this;
        }
        public TextMeshProFloatingText()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        }
        private static TextMeshProFloatingText()
        {
            UnityEngine.WaitForEndOfFrame val_1 = 536896839;
            val_1 = new UnityEngine.WaitForEndOfFrame();
            mem2[0] = val_1;
            UnityEngine.WaitForSeconds val_2 = 536896849;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882641] = val_2;
            UnityEngine.WaitForSeconds val_3 = 536896849;
            val_3 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882645] = val_3;
            UnityEngine.WaitForSeconds val_4 = 536896849;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882649] = val_4;
            UnityEngine.WaitForSeconds val_5 = 536896849;
            val_5 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882653] = val_5;
            UnityEngine.WaitForSeconds val_6 = 536896849;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882657] = val_6;
            UnityEngine.WaitForSeconds val_7 = 536896849;
            val_7 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882661] = val_7;
            UnityEngine.WaitForSeconds val_8 = 536896849;
            val_8 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882665] = val_8;
            UnityEngine.WaitForSeconds val_9 = 536896849;
            val_9 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882669] = val_9;
            UnityEngine.WaitForSeconds val_10 = 536896849;
            val_10 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882673] = val_10;
            UnityEngine.WaitForSeconds val_11 = 536896849;
            val_11 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882677] = val_11;
            UnityEngine.WaitForSeconds val_12 = 536896849;
            val_12 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882681] = val_12;
            UnityEngine.WaitForSeconds val_13 = 536896849;
            val_13 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882685] = val_13;
            UnityEngine.WaitForSeconds val_14 = 536896849;
            val_14 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882689] = val_14;
            UnityEngine.WaitForSeconds val_15 = 536896849;
            val_15 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882693] = val_15;
            UnityEngine.WaitForSeconds val_16 = 536896849;
            val_16 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882697] = val_16;
            UnityEngine.WaitForSeconds val_17 = 536896849;
            val_17 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882701] = val_17;
            UnityEngine.WaitForSeconds val_18 = 536896849;
            val_18 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882705] = val_18;
            UnityEngine.WaitForSeconds val_19 = 536896849;
            val_19 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882709] = val_19;
            UnityEngine.WaitForSeconds val_20 = 536896849;
            val_20 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882713] = val_20;
            UnityEngine.WaitForSeconds val_21 = 536896849;
            val_21 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem[536882717] = val_21;
            mem2[0] = 536882625;
        }
    
    }

}
