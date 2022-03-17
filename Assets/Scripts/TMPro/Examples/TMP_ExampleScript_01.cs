using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_ExampleScript_01 : MonoBehaviour
    {
        // Fields
        public TMPro.Examples.TMP_ExampleScript_01.objectType ObjectType;
        public bool isStatic;
        private TMPro.TMP_Text m_text;
        private const string k_label = "The count is <#0080ff>{0}</color>";
        private int count;
        
        // Methods
        private void Awake()
        {
            float val_9;
            float val_10;
            TMPro.TMP_Text val_12;
            TMPro.TMP_Text val_13;
            var val_14;
            if(this.ObjectType == 0)
            {
                goto label_1;
            }
            
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            val_12 = this;
            if(this != 0)
            {
                goto label_5;
            }
            
            UnityEngine.GameObject val_2 = this.gameObject;
            val_13 = this;
            val_14 = 22760248;
            goto label_4;
            label_1:
            UnityEngine.Transform val_3 = this.GetComponent<UnityEngine.Transform>();
            val_12 = this;
            if(this != 0)
            {
                goto label_5;
            }
            
            UnityEngine.GameObject val_4 = this.gameObject;
            val_13 = this;
            val_14 = 22760240;
            label_4:
            SynchronizationContextBehavoir val_5 = this.AddComponent<SynchronizationContextBehavoir>();
            val_12 = val_13;
            label_5:
            this.m_text = val_12;
            TMPro.TMP_SpriteAsset val_6 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608047);
            this.font = -1610608047;
            TMPro.TMP_SpriteAsset val_7 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608045);
            this.fontSize = null;
            UnityEngine.Vector2 val_8 = GetPreferredValues(width:  null, height:  null);
            UnityEngine.RectTransform val_11 = this.rectTransform;
            this.sizeDelta = new UnityEngine.Vector2() {x = val_9, y = val_10};
        }
        private void Update()
        {
            if(this.isStatic == true)
            {
                    return;
            }
            
            R4 + 20.SetText(sourceText:  -1610603839, arg0:  4294967f);
            var val_1 = R4 + 24;
            val_1 = val_1 + 1;
            mem2[0] = val_1;
        }
        public TMP_ExampleScript_01()
        {
        
        }
    
    }

}
