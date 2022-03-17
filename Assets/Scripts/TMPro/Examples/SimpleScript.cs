using UnityEngine;

namespace TMPro.Examples
{
    public class SimpleScript : MonoBehaviour
    {
        // Fields
        private TMPro.TextMeshPro m_textMeshPro;
        private const string label = "The <#0050FF>count is: </color>{0:2}";
        private float m_frame;
        
        // Methods
        private void Start()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SynchronizationContextBehavoir val_2 = this.AddComponent<SynchronizationContextBehavoir>();
            this.m_textMeshPro = this;
            this.fontSize = null;
            this.alignment = 514;
            this.enableWordWrapping = false;
        }
        private void Update()
        {
            this.m_textMeshPro.SetText(sourceText:  -1610603977, arg0:  null);
            float val_1 = UnityEngine.Time.deltaTime;
            uint val_2 = 0;
            val_2 = this.m_frame + val_2;
            this.m_frame = val_2;
        }
        public SimpleScript()
        {
        
        }
    
    }

}
