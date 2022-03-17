using UnityEngine;
public class ItemDecoUI : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject buttonCoin;
    private UnityEngine.GameObject buttonList;
    private UnityEngine.GameObject buttonTape;
    private UnityEngine.UI.Image icon;
    private UnityEngine.GameObject iconLock;
    private UnityEngine.GameObject selet;
    private UnityEngine.GameObject seleted;
    private TMPro.TextMeshProUGUI txtCoin;
    private TMPro.TextMeshProUGUI txtTape;
    private DecoType decoType;
    private int idDeco;
    private int myPrice;
    
    // Methods
    private void OnEnable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  817004048, method:  new IntPtr(1610681799));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  817004048, eventID:  37, callback:  536873423);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  817116048, method:  new IntPtr(1610681801));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  817116048, eventID:  37, callback:  536873423);
    }
    public void InitData(DecoType type, int id, UnityEngine.Sprite spriteIcon)
    {
        this.decoType = type;
        this.idDeco = id;
        this.icon.sprite = spriteIcon;
        this.selet.SetActive(value:  false);
        this.CheckShowButton();
    }
    private void CheckShowButton()
    {
        UnityEngine.GameObject val_9;
        DecoType val_10;
        var val_11;
        TMPro.TextMeshProUGUI val_12;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsUnlockDeco(type:  this.decoType, id:  this.idDeco)) != false)
        {
                this.buttonList.SetActive(value:  false);
            val_9 = this.seleted;
            object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
            val_10 = this.decoType;
            val_11 = -1073708883;
            val_9.SetActive(value:  val_11.IsSelectDeco(type:  val_10, id:  this.idDeco));
            this.iconLock.SetActive(value:  false);
            return;
        }
        
        this.iconLock.SetActive(value:  true);
        this.seleted.SetActive(value:  false);
        val_9 = 0;
        this.buttonList.SetActive(value:  true);
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        val_10 = this.idDeco;
        TypeBuy val_7 = -1073708883.TypeBuyDeco(type:  this.decoType, id:  val_10, price: out  int val_6 = 817418124);
        if((-1073708883) != 0)
        {
                this.buttonCoin.SetActive(value:  false);
            this.buttonTape.SetActive(value:  true);
            val_12 = this.txtTape;
        }
        else
        {
                this.buttonCoin.SetActive(value:  true);
            this.buttonTape.SetActive(value:  false);
            val_12 = this.txtCoin;
        }
        
        string val_8 = 0.ToString();
        val_11;
        val_12.text = 817418124;
        this.myPrice = 0;
    }
    public void ItemTap()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsUnlockDeco(type:  this.decoType, id:  this.idDeco)) == false)
        {
                return;
        }
        
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        bool val_4 = -1073708883.SetSelectDeco(type:  this.decoType, id:  this.idDeco);
        this.CheckShowButton();
        object val_5 = AFramework.SingletonUI<System.Object>.instance;
        -1073700809.ChangeDeco(decoType:  this.decoType, idDeco:  this.idDeco);
        GameTool.EventDispatcherExtension.PostEvent(sender:  817611792, eventID:  37);
    }
    public void BuyWithCoins()
    {
        var val_12;
        int val_13;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.Coin) < this.myPrice)
        {
                mem[536882227] = 536884213;
            AFramework.UI.BaseUIMenu val_3 = AFramework.UI.CanvasManager.Push(identifier:  -1610605285, initParams:  536882211);
            return;
        }
        
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_12 = -1073708883.Coin;
            val_13 = this.myPrice;
        }
        else
        {
                val_12 = -1073708883.Coin;
            val_13 = this.myPrice;
        }
        
        -1073708883.Coin = val_12 - val_13;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.UnlockDeco(type:  this.decoType, id:  this.idDeco);
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        bool val_10 = -1073708883.SetSelectDeco(type:  this.decoType, id:  this.idDeco);
        this.CheckShowButton();
        object val_11 = AFramework.SingletonUI<System.Object>.instance;
        -1073700809.ChangeDeco(decoType:  this.decoType, idDeco:  this.idDeco);
        GameTool.EventDispatcherExtension.PostEvent(sender:  817748368, eventID:  37);
        GameTool.EventDispatcherExtension.PostEvent(sender:  817748368, eventID:  8);
    }
    public void BuyWithTapes()
    {
        var val_12;
        int val_13;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.Diamond) < this.myPrice)
        {
                mem[536882227] = 536884213;
            AFramework.UI.BaseUIMenu val_3 = AFramework.UI.CanvasManager.Push(identifier:  -1610605285, initParams:  536882211);
            return;
        }
        
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_12 = -1073708883.Diamond;
            val_13 = this.myPrice;
        }
        else
        {
                val_12 = -1073708883.Diamond;
            val_13 = this.myPrice;
        }
        
        -1073708883.Diamond = val_12 - val_13;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.UnlockDeco(type:  this.decoType, id:  this.idDeco);
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        bool val_10 = -1073708883.SetSelectDeco(type:  this.decoType, id:  this.idDeco);
        object val_11 = AFramework.SingletonUI<System.Object>.instance;
        -1073700809.ChangeDeco(decoType:  this.decoType, idDeco:  this.idDeco);
        this.CheckShowButton();
        GameTool.EventDispatcherExtension.PostEvent(sender:  817884944, eventID:  37);
        GameTool.EventDispatcherExtension.PostEvent(sender:  817884944, eventID:  8);
    }
    public ItemDecoUI()
    {
    
    }
    private void <OnEnable>b__12_0(UnityEngine.Component sender, object param)
    {
        this.CheckShowButton();
    }
    private void <OnDisable>b__13_0(UnityEngine.Component sender, object param)
    {
        this.CheckShowButton();
    }

}
