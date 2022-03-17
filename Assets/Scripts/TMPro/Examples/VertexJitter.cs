using UnityEngine;

namespace TMPro.Examples
{
    public class VertexJitter : MonoBehaviour
    {
        // Fields
        public float AngleMultiplier;
        public float SpeedMultiplier;
        public float CurveScale;
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
            
            536873315 = new System.Action<SdkConfiguration>(object:  966103920, method:  new IntPtr(1610683877));
            mem[536895099] + 44.Add(rhs:  536873315);
        }
        private void OnDisable()
        {
            if(((mem[536895194] & true) == 0) && (mem[536895123] == 0))
            {
                    536895007 = 536895007;
            }
            
            536873315 = new System.Action<SdkConfiguration>(object:  966215920, method:  new IntPtr(1610683877));
            mem[536895099] + 44.Remove(rhs:  536873315);
        }
        private void Start()
        {
            System.Collections.IEnumerator val_1 = this.AnimateVertexColors();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  966327920);
        }
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            bool val_1 = UnityEngine.Object.op_Equality(x:  obj, y:  this.m_TextComponent);
            if(val_1 == true)
            {
                    val_1 = true;
                this.hasTextChanged = val_1;
            }
        
        }
        private System.Collections.IEnumerator AnimateVertexColors()
        {
            536902331 = new VertexJitter.<AnimateVertexColors>d__11(<>1__state:  0);
            mem[536902347] = this;
        }
        public VertexJitter()
        {
            this.AngleMultiplier = 1f;
            this.SpeedMultiplier = 1f;
            this.CurveScale = 1f;
        }
    
    }

}
