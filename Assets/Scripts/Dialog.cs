using UnityEngine;
public class Dialog : SingletonResource<Dialog>
{
    // Fields
    private UnityEngine.UI.Text tileText;
    private UnityEngine.UI.Text messageText;
    private UnityEngine.UI.Text noText;
    private UnityEngine.UI.Text yesText;
    private UnityEngine.GameObject yesObj;
    private UnityEngine.GameObject noObj;
    private System.Action okAction;
    private System.Action cancelAction;
    
    // Methods
    public void OpenDialog(string title, string message, string yes, System.Action okAction)
    {
        this.okAction = okAction;
        this.yesObj.SetActive(value:  true);
        this.noObj.SetActive(value:  false);
    }
    public void OpenDialog(string title, string message, string no, string yes, System.Action okAction, System.Action cancelAction)
    {
        this.okAction = okAction;
        this.cancelAction = cancelAction;
        this.yesObj.SetActive(value:  true);
        this.noObj.SetActive(value:  true);
    }
    public void OnPressOkButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  513029552);
        if(this.okAction == 0)
        {
                return;
        }
        
        this.okAction.Invoke();
    }
    public void OnPressCancelButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  513149744);
        if(this.cancelAction == 0)
        {
                return;
        }
        
        this.cancelAction.Invoke();
    }
    public void OnPressCloseButton()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  513269936);
        if(this.cancelAction == 0)
        {
                return;
        }
        
        this.cancelAction.Invoke();
    }
    public Dialog()
    {
        if((mem[536879688] & true) != 0)
        {
                return;
        }
        
        if(mem[536879617] != 0)
        {
                return;
        }
    
    }

}
