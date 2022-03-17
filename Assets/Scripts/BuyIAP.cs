using UnityEngine;
public class BuyIAP : MonoBehaviour
{
    // Fields
    public BuyIAP.ItemType itemType;
    public UnityEngine.UI.Text priceText;
    public UnityEngine.UI.Text boughtTxt;
    private UnityEngine.GameObject messagePanel;
    
    // Methods
    private void OnEnable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  514251952, method:  new IntPtr(1610677011));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  514251952, eventID:  11, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  514363952, method:  new IntPtr(1610677013));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  514363952, eventID:  11, callback:  536873423);
    }
    private void Start()
    {
        System.Collections.IEnumerator val_1 = this.LoadPriceRoutine();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  514475952);
    }
    private void ShowText()
    {
    
    }
    public void CLickBuy()
    {
        if(this.itemType == 2)
        {
            goto label_1;
        }
        
        if(this.itemType == 1)
        {
            goto label_2;
        }
        
        if(this.itemType != 0)
        {
                return;
        }
        
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701017.BuyRemoveAds();
        return;
        label_1:
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701017.BuyTape();
        return;
        label_2:
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701017.BuyMoney();
    }
    private System.Collections.IEnumerator LoadPriceRoutine()
    {
        536898167 = new BuyIAP.<LoadPriceRoutine>d__10(<>1__state:  0);
        mem[536898183] = this;
    }
    private void BuyPremiumWithAd()
    {
    
    }
    public BuyIAP()
    {
    
    }
    private void <OnEnable>b__5_0(UnityEngine.Component sender, object param)
    {
    
    }
    private void <OnDisable>b__6_0(UnityEngine.Component sender, object param)
    {
    
    }

}
