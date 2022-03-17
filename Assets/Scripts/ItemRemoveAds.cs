using UnityEngine;
public class ItemRemoveAds : MonoBehaviour
{
    // Methods
    private void OnEnable()
    {
        this.ActiveItem(value:  API.IsRemoveAds ^ 1);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  751952400, method:  new IntPtr(1610680815));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  751952400, eventID:  13, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  752064400, method:  new IntPtr(1610680817));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  752064400, eventID:  13, callback:  536873423);
    }
    private void ActiveItem(bool value)
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        this.SetActive(value:  value);
    }
    public ItemRemoveAds()
    {
    
    }
    private void <OnEnable>b__0_0(UnityEngine.Component c, object o)
    {
        this.ActiveItem(value:  API.IsRemoveAds ^ 1);
    }
    private void <OnDisable>b__1_0(UnityEngine.Component c, object o)
    {
        this.ActiveItem(value:  API.IsRemoveAds ^ 1);
    }

}
