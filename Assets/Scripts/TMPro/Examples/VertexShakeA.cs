using UnityEngine;

namespace TMPro.Examples
{
    public class VertexShakeA : MonoBehaviour
    {
        // Fields
        public float AngleMultiplier;
        public float SpeedMultiplier;
        public float ScaleMultiplier;
        public float RotationMultiplier;
        private TMPro.TMP_Text m_TextComponent;
        private bool hasTextChanged;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.m_TextComponent = this;
        }
        private void OnEnable()
        {
            if(((mem[536895194] & true) == 0) && (mem[536895123] == 0))
            {
                    536895007 = 536895007;
            }
            
            536873315 = new System.Action<SdkConfiguration>(object:  967781104, method:  new IntPtr(1610683903));
            mem[536895099] + 44.Add(rhs:  536873315);
        }
        private void OnDisable()
        {
            if(((mem[536895194] & true) == 0) && (mem[536895123] == 0))
            {
                    536895007 = 536895007;
            }
            
            536873315 = new System.Action<SdkConfiguration>(object:  967893104, method:  new IntPtr(1610683903));
            mem[536895099] + 44.Remove(rhs:  536873315);
        }
        private void Start()
        {
            System.Collections.IEnumerator val_1 = this.AnimateVertexColors();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  968005104);
        }
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  this.m_TextComponent);
            if(val_1 == true)
            {
                    val_1 = true;
                this.hasTextChanged = val_1;
            }
        
        }
        private System.Collections.IEnumerator AnimateVertexColors()
        {
            536902335 = new VertexShakeA.<AnimateVertexColors>d__11(<>1__state:  0);
            mem[536902351] = this;
        }
        public VertexShakeA()
        {
        
        }
    
    }

}
