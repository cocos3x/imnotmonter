using UnityEngine;

namespace TMPro.Examples
{
    public class ShaderPropAnimator : MonoBehaviour
    {
        // Fields
        private UnityEngine.Renderer m_Renderer;
        private UnityEngine.Material m_Material;
        public UnityEngine.AnimationCurve GlowCurve;
        public float m_frame;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.m_Renderer = this;
            UnityEngine.Material val_2 = this.m_Renderer.material;
            this.m_Material = this.m_Renderer;
        }
        private void Start()
        {
            System.Collections.IEnumerator val_1 = this.AnimateProperties();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  949359600);
        }
        private System.Collections.IEnumerator AnimateProperties()
        {
            536901027 = new ShaderPropAnimator.<AnimateProperties>d__6(<>1__state:  0);
            mem[536901043] = this;
        }
        public ShaderPropAnimator()
        {
        
        }
    
    }

}
