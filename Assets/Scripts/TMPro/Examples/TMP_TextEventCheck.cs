using UnityEngine;

namespace TMPro.Examples
{
    public class TMP_TextEventCheck : MonoBehaviour
    {
        // Fields
        public TMPro.TMP_TextEventHandler TextEventHandler;
        private TMPro.TMP_Text m_TextComponent;
        
        // Methods
        private void OnEnable()
        {
            if(this.TextEventHandler == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.TextEventHandler.GetComponent<UnityEngine.Transform>();
            this.m_TextComponent = this.TextEventHandler;
            536880173 = new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  952499568, method:  new IntPtr(1610683687));
            this.TextEventHandler.m_OnCharacterSelection.AddListener(call:  536880173);
            536880173 = new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  952499568, method:  new IntPtr(1610683689));
            this.TextEventHandler.m_OnSpriteSelection.AddListener(call:  536880173);
            536880185 = new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  952499568, method:  new IntPtr(1610683691));
            this.TextEventHandler.m_OnWordSelection.AddListener(call:  536880185);
            536880185 = new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  952499568, method:  new IntPtr(1610683693));
            this.TextEventHandler.m_OnLineSelection.AddListener(call:  536880185);
            536880187 = new UnityEngine.Events.UnityAction<System.String, System.String, System.Int32>(object:  952499568, method:  new IntPtr(1610683695));
            this.TextEventHandler.m_OnLinkSelection.AddListener(call:  536880187);
        }
        private void OnDisable()
        {
            if(this.TextEventHandler == 0)
            {
                    return;
            }
            
            536880173 = new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  952701680, method:  new IntPtr(1610683687));
            this.TextEventHandler.m_OnCharacterSelection.RemoveListener(call:  536880173);
            536880173 = new UnityEngine.Events.UnityAction<System.Char, System.Int32>(object:  952701680, method:  new IntPtr(1610683689));
            this.TextEventHandler.m_OnSpriteSelection.RemoveListener(call:  536880173);
            536880185 = new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  952701680, method:  new IntPtr(1610683691));
            this.TextEventHandler.m_OnWordSelection.RemoveListener(call:  536880185);
            536880185 = new UnityEngine.Events.UnityAction<System.String, System.Int32, System.Int32>(object:  952701680, method:  new IntPtr(1610683693));
            this.TextEventHandler.m_OnLineSelection.RemoveListener(call:  536880185);
            536880187 = new UnityEngine.Events.UnityAction<System.String, System.String, System.Int32>(object:  952701680, method:  new IntPtr(1610683695));
            this.TextEventHandler.m_OnLinkSelection.RemoveListener(call:  536880187);
        }
        private void OnCharacterSelection(char c, int index)
        {
            mem[536882417] = -1610609367;
            string val_1 = c.ToString();
            mem[536882421] = ;
            mem[536882425] = -1610602223;
            string val_2 = index.ToString();
            mem[536882429] = ;
            mem[536882433] = -1610612363;
            string val_3 = +536882401;
            UnityEngine.Debug.Log(message:  536882401);
        }
        private void OnSpriteSelection(char c, int index)
        {
            mem[536882417] = -1610604407;
            string val_1 = c.ToString();
            mem[536882421] = ;
            mem[536882425] = -1610602223;
            string val_2 = index.ToString();
            mem[536882429] = ;
            mem[536882433] = -1610612363;
            string val_3 = +536882401;
            UnityEngine.Debug.Log(message:  536882401);
        }
        private void OnWordSelection(string word, int firstCharacterIndex, int length)
        {
            mem[536882417] = -1610602523;
            mem[536882421] = word;
            mem[536882425] = -1610602203;
            string val_1 = firstCharacterIndex.ToString();
            mem[536882429] = ;
            mem[536882433] = -1610612419;
            string val_2 = length.ToString();
            mem[536882437] = ;
            mem[536882441] = -1610612363;
            string val_3 = +536882401;
            UnityEngine.Debug.Log(message:  536882401);
        }
        private void OnLineSelection(string lineText, int firstCharacterIndex, int length)
        {
            mem[536882417] = -1610606653;
            mem[536882421] = lineText;
            mem[536882425] = -1610602203;
            string val_1 = firstCharacterIndex.ToString();
            mem[536882429] = ;
            mem[536882433] = -1610612419;
            string val_2 = length.ToString();
            mem[536882437] = ;
            mem[536882441] = -1610612363;
            string val_3 = +536882401;
            UnityEngine.Debug.Log(message:  536882401);
        }
        private void OnLinkSelection(string linkID, string linkText, int linkIndex)
        {
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.m_TextComponent, y:  0);
            mem[536882417] = -1610606633;
            string val_2 = linkIndex.ToString();
            mem[536882421] = ;
            mem[536882425] = -1610612279;
            mem[536882429] = linkID;
            mem[536882433] = -1610602225;
            mem[536882437] = linkText;
            mem[536882441] = -1610612229;
            string val_3 = +536882401;
            UnityEngine.Debug.Log(message:  536882401);
        }
        public TMP_TextEventCheck()
        {
        
        }
    
    }

}
