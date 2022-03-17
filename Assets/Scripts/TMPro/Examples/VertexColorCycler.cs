using UnityEngine;

namespace TMPro.Examples
{
    public class VertexColorCycler : MonoBehaviour
    {
        // Fields
        private TMPro.TMP_Text m_TextComponent;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.m_TextComponent = this;
        }
        private void Start()
        {
            System.Collections.IEnumerator val_1 = this.AnimateVertexColors();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  964451440);
        }
        private System.Collections.IEnumerator AnimateVertexColors()
        {
            536902329 = new VertexColorCycler.<AnimateVertexColors>d__3(<>1__state:  0);
            mem[536902345] = this;
        }
        public VertexColorCycler()
        {
        
        }
    
    }

}
