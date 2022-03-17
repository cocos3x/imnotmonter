using UnityEngine;

namespace TMPro.Examples
{
    public class TextConsoleSimulator : MonoBehaviour
    {
        // Fields
        private TMPro.TMP_Text m_TextComponent;
        private bool hasTextChanged;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            Weight val_2 = this.GetComponent<Weight>();
            this.m_TextComponent = this;
        }
        private void Start()
        {
            System.Collections.IEnumerator val_1 = this.RevealCharacters(textComponent:  this.m_TextComponent);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  959806448);
        }
        private void OnEnable()
        {
            if(((mem[536895194] & true) == 0) && (mem[536895123] == 0))
            {
                    536895007 = 536895007;
            }
            
            536873315 = new System.Action<SdkConfiguration>(object:  959922544, method:  new IntPtr(1610683775));
            mem[536895099] + 44.Add(rhs:  536873315);
        }
        private void OnDisable()
        {
            if(((mem[536895194] & true) == 0) && (mem[536895123] == 0))
            {
                    536895007 = 536895007;
            }
            
            536873315 = new System.Action<SdkConfiguration>(object:  960034544, method:  new IntPtr(1610683775));
            mem[536895099] + 44.Remove(rhs:  536873315);
        }
        private void ON_TEXT_CHANGED(UnityEngine.Object obj)
        {
            this.hasTextChanged = true;
        }
        private System.Collections.IEnumerator RevealCharacters(TMPro.TMP_Text textComponent)
        {
            TextConsoleSimulator.<RevealCharacters>d__7 val_1 = 536901801;
            val_1 = new TextConsoleSimulator.<RevealCharacters>d__7(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536901821] = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            mem[536901817] = textComponent;
        }
        private System.Collections.IEnumerator RevealWords(TMPro.TMP_Text textComponent)
        {
            536901803 = new TextConsoleSimulator.<RevealWords>d__8(<>1__state:  0);
            mem[536901819] = textComponent;
        }
        public TextConsoleSimulator()
        {
        
        }
    
    }

}
