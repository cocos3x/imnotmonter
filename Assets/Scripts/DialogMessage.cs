using UnityEngine;
public class DialogMessage : SingletonMonoBehaviour<DialogMessage>
{
    // Fields
    private UnityEngine.UI.Text tileText;
    private UnityEngine.UI.Text messageText;
    private UnityEngine.UI.Text noText;
    private UnityEngine.UI.Text yesText;
    private UnityEngine.GameObject dialogPanel;
    private UnityEngine.GameObject okObj;
    private UnityEngine.GameObject yesObj;
    private UnityEngine.GameObject noObj;
    private System.Action okAction;
    private System.Action cancelAction;
    
    // Methods
    public void OpenDialog(string title, string message, System.Action okAction)
    {
        this.dialogPanel.SetActive(value:  true);
        this.okAction = okAction;
        this.yesObj.SetActive(value:  false);
        this.noObj.SetActive(value:  false);
        this.okObj.SetActive(value:  true);
    }
    public void OpenDialog(string title, string message, string no, string yes, System.Action okAction, System.Action cancelAction)
    {
        this.dialogPanel.SetActive(value:  true);
        this.okAction = okAction;
        this.cancelAction = cancelAction;
        this.yesObj.SetActive(value:  true);
        this.noObj.SetActive(value:  true);
        this.okObj.SetActive(value:  false);
    }
    public void OnPressOkButton()
    {
        this.dialogPanel.SetActive(value:  false);
        if(this.okAction == 0)
        {
                return;
        }
        
        this.okAction.Invoke();
    }
    public void OnPressCancelButton()
    {
        this.dialogPanel.SetActive(value:  false);
        if(this.cancelAction == 0)
        {
                return;
        }
        
        this.cancelAction.Invoke();
    }
    public void OnPressCloseButton()
    {
        this.dialogPanel.SetActive(value:  false);
        if(this.cancelAction == 0)
        {
                return;
        }
        
        this.cancelAction.Invoke();
    }
    public DialogMessage()
    {
    
    }

}
