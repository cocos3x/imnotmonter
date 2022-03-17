using UnityEngine;
public class ToastMgr : SingletonMonoBehaviour<ToastMgr>
{
    // Fields
    private UnityEngine.UI.Text toastText;
    private UnityEngine.GameObject panel;
    
    // Methods
    public void Show(string mess, System.Action callBack)
    {
        this.panel.SetActive(value:  true);
        if(this.toastText == 0)
        {
            
        }
    
    }
    public ToastMgr()
    {
    
    }

}
