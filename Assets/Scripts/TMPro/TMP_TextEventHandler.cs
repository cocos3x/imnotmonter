using UnityEngine;

namespace TMPro
{
    public class TMP_TextEventHandler : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
    {
        // Fields
        private TMPro.TMP_TextEventHandler.CharacterSelectionEvent m_OnCharacterSelection;
        private TMPro.TMP_TextEventHandler.SpriteSelectionEvent m_OnSpriteSelection;
        private TMPro.TMP_TextEventHandler.WordSelectionEvent m_OnWordSelection;
        private TMPro.TMP_TextEventHandler.LineSelectionEvent m_OnLineSelection;
        private TMPro.TMP_TextEventHandler.LinkSelectionEvent m_OnLinkSelection;
        private TMPro.TMP_Text m_TextComponent;
        private UnityEngine.Camera m_Camera;
        private UnityEngine.Canvas m_Canvas;
        private int m_selectedLink;
        private int m_lastCharIndex;
        private int m_lastWordIndex;
        private int m_lastLineIndex;
        
        // Properties
        public TMPro.TMP_TextEventHandler.CharacterSelectionEvent onCharacterSelection { get; set; }
        public TMPro.TMP_TextEventHandler.SpriteSelectionEvent onSpriteSelection { get; set; }
        public TMPro.TMP_TextEventHandler.WordSelectionEvent onWordSelection { get; set; }
        public TMPro.TMP_TextEventHandler.LineSelectionEvent onLineSelection { get; set; }
        public TMPro.TMP_TextEventHandler.LinkSelectionEvent onLinkSelection { get; set; }
        
        // Methods
        public TMPro.TMP_TextEventHandler.CharacterSelectionEvent get_onCharacterSelection()
        {
        
        }
        public void set_onCharacterSelection(TMPro.TMP_TextEventHandler.CharacterSelectionEvent value)
        {
            this.m_OnCharacterSelection = value;
        }
        public TMPro.TMP_TextEventHandler.SpriteSelectionEvent get_onSpriteSelection()
        {
        
        }
        public void set_onSpriteSelection(TMPro.TMP_TextEventHandler.SpriteSelectionEvent value)
        {
            this.m_OnSpriteSelection = value;
        }
        public TMPro.TMP_TextEventHandler.WordSelectionEvent get_onWordSelection()
        {
        
        }
        public void set_onWordSelection(TMPro.TMP_TextEventHandler.WordSelectionEvent value)
        {
            this.m_OnWordSelection = value;
        }
        public TMPro.TMP_TextEventHandler.LineSelectionEvent get_onLineSelection()
        {
        
        }
        public void set_onLineSelection(TMPro.TMP_TextEventHandler.LineSelectionEvent value)
        {
            this.m_OnLineSelection = value;
        }
        public TMPro.TMP_TextEventHandler.LinkSelectionEvent get_onLinkSelection()
        {
        
        }
        public void set_onLinkSelection(TMPro.TMP_TextEventHandler.LinkSelectionEvent value)
        {
            this.m_OnLinkSelection = value;
        }
        private void Awake()
        {
            UnityEngine.Canvas val_13;
            UnityEngine.Canvas val_14;
            UnityEngine.Camera val_15;
            UnityEngine.GameObject val_1 = this.gameObject;
            Weight val_2 = this.GetComponent<Weight>();
            this.m_TextComponent = this;
            System.Type val_3 = this.GetType();
            val_13 = 1073766193;
            System.Type val_4 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073766193)});
            if((System.Type.op_Equality(left:  942607344, right:  1073766193)) == false)
            {
                goto label_5;
            }
            
            UnityEngine.GameObject val_6 = this.gameObject;
            object val_7 = this.GetComponentInParent<System.Object>();
            this.m_Canvas = this;
            val_14 = this.m_Canvas;
            if(942607344 == 0)
            {
                    return;
            }
            
            val_13 = this.m_Canvas;
            UnityEngine.RenderMode val_9 = this.renderMode;
            if(val_13 == 0)
            {
                goto label_11;
            }
            
            val_15 = this.m_Canvas;
            UnityEngine.Camera val_10 = this.worldCamera;
            goto label_13;
            label_5:
            val_15 = 0;
            UnityEngine.Camera val_11 = UnityEngine.Camera.main;
            label_13:
            this.m_Camera = val_15;
            return;
            label_11:
            this.m_Camera = 0;
        }
        private void LateUpdate()
        {
            float val_3;
            float val_4;
            float val_5;
            int val_19;
            int val_20;
            TMPro.TMP_Text val_22;
            UnityEngine.RectTransform val_23;
            float val_24;
            UnityEngine.Camera val_25;
            val_22 = 0;
            UnityEngine.RectTransform val_1 = this.m_TextComponent.rectTransform;
            val_23 = this.m_TextComponent;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            val_24 = val_3;
            val_25 = this.m_Camera;
            if((TMPro.TMP_TextUtilities.IsIntersectingRectTransform(rectTransform:  val_23, position:  new UnityEngine.Vector3() {x = val_24, y = val_4, z = val_5}, camera:  val_25)) == false)
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_7 = UnityEngine.Input.mousePosition;
            int val_8 = TMPro.TMP_TextUtilities.FindIntersectingCharacter(text:  this.m_TextComponent, position:  new UnityEngine.Vector3() {x = R4, y = R5, z = R7}, camera:  this.m_Camera, visibleOnly:  true);
            if(val_8 != 1)
            {
                    this.m_Camera = val_8;
                val_8 = this.m_lastCharIndex;
            }
            
            if(this.m_Camera != val_8)
            {
                goto label_7;
            }
            
            label_59:
            UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
            int val_10 = TMPro.TMP_TextUtilities.FindIntersectingWord(text:  this.m_TextComponent, position:  new UnityEngine.Vector3() {x = R4, y = R5, z = R7}, camera:  this.m_Camera);
            if(val_10 != 1)
            {
                    this.m_Camera = val_10;
                val_10 = this.m_lastWordIndex;
            }
            
            if(this.m_Camera != val_10)
            {
                goto label_10;
            }
            
            label_37:
            UnityEngine.Vector3 val_11 = UnityEngine.Input.mousePosition;
            int val_12 = TMPro.TMP_TextUtilities.FindIntersectingLine(text:  this.m_TextComponent, position:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7}, camera:  this.m_Camera);
            if(val_12 != 1)
            {
                    this.m_Camera = val_12;
                val_12 = this.m_lastLineIndex;
            }
            
            if(this.m_Camera != val_12)
            {
                goto label_13;
            }
            
            label_54:
            val_22 = this.m_TextComponent;
            val_25 = 0;
            UnityEngine.Vector3 val_13 = UnityEngine.Input.mousePosition;
            int val_14 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  val_22, position:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7}, camera:  this.m_Camera);
            if(val_14 != 1)
            {
                    this.m_Camera = val_14;
                val_14 = this.m_selectedLink;
            }
            
            if(this.m_Camera == val_14)
            {
                    return;
            }
            
            this.m_selectedLink = this.m_Camera;
            string val_16 = GetLinkID();
            val_23 = ;
            string val_17 = GetLinkText();
            this.SendOnLinkSelection(linkID:  943108664, linkText:  943108664, linkIndex:  this.m_Camera);
            return;
            label_4:
            this.m_selectedLink = 0;
            this.m_lastCharIndex = 0;
            this.m_lastWordIndex = 0;
            this.m_lastLineIndex = 0;
            return;
            label_7:
            this.m_lastCharIndex = this.m_Camera;
            if(0 == 1)
            {
                goto label_26;
            }
            
            if(0 != 0)
            {
                goto label_59;
            }
            
            this.SendOnCharacterSelection(character:  ' ', characterIndex:  this.m_Camera);
            goto label_59;
            label_10:
            this.m_lastWordIndex = this.m_Camera;
            string val_18 = GetWord();
            this.SendOnWordSelection(word:  943108696, charIndex:  val_20, length:  val_19);
            goto label_37;
            label_13:
            this.m_lastLineIndex = this.m_Camera;
            if(1 < 1)
            {
                goto label_46;
            }
            
            var val_23 = 0;
            var val_24 = 29863626768;
            label_53:
            if(val_23 >= 29863626752)
            {
                goto label_46;
            }
            
            var val_22 = 83886592;
            val_22 = val_22 + val_23;
            val_23 = val_23 + 1;
            mem[536881809] = null;
            val_24 = val_24 + 356;
            if(val_23 < 1)
            {
                goto label_53;
            }
            
            label_46:
            string val_21 = 0.CreateString(val:  536881793);
            this.SendOnLineSelection(line:  null, charIndex:  83886592, length:  1);
            goto label_54;
            label_26:
            this.SendOnSpriteSelection(character:  ' ', characterIndex:  this.m_Camera);
            goto label_59;
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
        
        }
        private void SendOnCharacterSelection(char character, int characterIndex)
        {
            if(this.m_OnCharacterSelection == 0)
            {
                    return;
            }
            
            this.m_OnCharacterSelection.Invoke(arg0:  character, arg1:  characterIndex);
        }
        private void SendOnSpriteSelection(char character, int characterIndex)
        {
            if(this.m_OnSpriteSelection == 0)
            {
                    return;
            }
            
            this.m_OnSpriteSelection.Invoke(arg0:  character, arg1:  characterIndex);
        }
        private void SendOnWordSelection(string word, int charIndex, int length)
        {
            if(this.m_OnWordSelection == 0)
            {
                    return;
            }
            
            this.m_OnWordSelection.Invoke(arg0:  word, arg1:  charIndex, arg2:  length);
        }
        private void SendOnLineSelection(string line, int charIndex, int length)
        {
            if(this.m_OnLineSelection == 0)
            {
                    return;
            }
            
            this.m_OnLineSelection.Invoke(arg0:  line, arg1:  charIndex, arg2:  length);
        }
        private void SendOnLinkSelection(string linkID, string linkText, int linkIndex)
        {
            if(this.m_OnLinkSelection == 0)
            {
                    return;
            }
            
            this.m_OnLinkSelection.Invoke(arg0:  linkID, arg1:  linkText, arg2:  linkIndex);
        }
        public TMP_TextEventHandler()
        {
            TMP_TextEventHandler.CharacterSelectionEvent val_1 = 536901705;
            val_1 = new TMP_TextEventHandler.CharacterSelectionEvent();
            this.m_OnCharacterSelection = val_1;
            TMP_TextEventHandler.SpriteSelectionEvent val_2 = 536901717;
            val_2 = new TMP_TextEventHandler.SpriteSelectionEvent();
            this.m_OnSpriteSelection = val_2;
            TMP_TextEventHandler.WordSelectionEvent val_3 = 536901721;
            val_3 = new TMP_TextEventHandler.WordSelectionEvent();
            this.m_OnWordSelection = val_3;
            TMP_TextEventHandler.LineSelectionEvent val_4 = 536901709;
            val_4 = new TMP_TextEventHandler.LineSelectionEvent();
            this.m_OnLineSelection = val_4;
            TMP_TextEventHandler.LinkSelectionEvent val_5 = 536901713;
            val_5 = new TMP_TextEventHandler.LinkSelectionEvent();
            this.m_OnLinkSelection = val_5;
            this.m_selectedLink = 0;
            this.m_lastCharIndex = 0;
            this.m_lastWordIndex = 0;
            this.m_lastLineIndex = 0;
        }
    
    }

}
