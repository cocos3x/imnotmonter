using UnityEngine;
public class ChatController : MonoBehaviour
{
    // Fields
    public TMPro.TMP_InputField ChatInputField;
    public TMPro.TMP_Text ChatDisplayOutput;
    public UnityEngine.UI.Scrollbar ChatScrollbar;
    
    // Methods
    private void OnEnable()
    {
        536880159 = new UnityEngine.Events.UnityAction<WheelPiece>(object:  861625488, method:  new IntPtr(1610682409));
        this.ChatInputField.m_OnSubmit.AddListener(call:  536880159);
    }
    private void OnDisable()
    {
        536880159 = new UnityEngine.Events.UnityAction<WheelPiece>(object:  861753872, method:  new IntPtr(1610682409));
        this.ChatInputField.m_OnSubmit.RemoveListener(call:  536880159);
    }
    private void AddToChatOutput(string newText)
    {
        var val_12;
        TMPro.TMP_Text val_13;
        this.ChatInputField.text = mem[536894675];
        System.DateTime val_1 = System.DateTime.Now;
        mem[536882417] = -1610602385;
        string val_3 = ???.Hour.ToString(format:  -1610600947);
        mem[536882421] = ;
        mem[536882425] = -1610610741;
        string val_5 = ???.Minute.ToString(format:  -1610600947);
        mem[536882429] = ;
        mem[536882433] = -1610610741;
        string val_7 = ???.Second.ToString(format:  -1610600947);
        mem[536882437] = ;
        val_12 = -1610610633;
        mem[536882441] = val_12;
        mem[536882445] = newText;
        string val_8 = +536882401;
        val_13 = this.ChatDisplayOutput;
        if(val_13 != 0)
        {
                val_13 = this.ChatDisplayOutput;
            val_12 = System.String.op_Equality(a:  this.ChatDisplayOutput, b:  mem[536894675]);
            if(val_12 != false)
        {
            
        }
        else
        {
                string val_11 = val_13 + -1610612685(-1610612685) + 536882401;
        }
        
        }
        
        this.ChatInputField.ActivateInputField();
        this.ChatScrollbar.value = null;
    }
    public ChatController()
    {
    
    }

}
