using UnityEngine;
public class EnvMapAnimator : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 RotationSpeeds;
    private TMPro.TMP_Text m_textMeshPro;
    private UnityEngine.Material m_material;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.m_textMeshPro = this;
        this.m_material = this.m_textMeshPro;
    }
    private System.Collections.IEnumerator Start()
    {
        536898853 = new EnvMapAnimator.<Start>d__4(<>1__state:  0);
        mem[536898869] = this;
    }
    public EnvMapAnimator()
    {
    
    }

}
