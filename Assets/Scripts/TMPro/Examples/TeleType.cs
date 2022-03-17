using UnityEngine;

namespace TMPro.Examples
{
    public class TeleType : MonoBehaviour
    {
        // Fields
        private string label01;
        private string label02;
        private TMPro.TMP_Text m_textMeshPro;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.m_textMeshPro = this;
            mem[this.m_textMeshPro].enableWordWrapping = true;
            mem[this.m_textMeshPro].alignment = 258;
        }
        private System.Collections.IEnumerator Start()
        {
            536901781 = new TeleType.<Start>d__4(<>1__state:  0);
            mem[536901797] = this;
        }
        public TeleType()
        {
            this.label01 = -1610608359;
            this.label02 = -1610608357;
        }
    
    }

}
