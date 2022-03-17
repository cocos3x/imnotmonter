using UnityEngine;
public class IAPManager : SingletonMonoBehaviour<IAPManager>, IStoreListener
{
    // Fields
    private static UnityEngine.Purchasing.IStoreController m_StoreController;
    private static UnityEngine.Purchasing.IExtensionProvider m_StoreExtensionProvider;
    public string removeAds;
    public string buyMoney;
    public string buyTapes;
    
    // Methods
    private void Start()
    {
        System.Collections.IEnumerator val_1 = this.WaitFetchCompleted();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  516557488);
    }
    private System.Collections.IEnumerator WaitFetchCompleted()
    {
        536899351 = new IAPManager.<WaitFetchCompleted>d__6(<>1__state:  0);
        mem[536899367] = this;
    }
    private void InitIAP()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_2 = mem[3221266323] + 8.Trim();
        this.removeAds = mem[3221266323] + 8;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_4 = mem[3221266323] + 12.Trim();
        this.buyMoney = mem[3221266323] + 12;
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_6 = mem[3221266323] + 16.Trim();
        this.buyTapes = mem[3221266323] + 16;
        if(mem[536888065] != 0)
        {
                return;
        }
        
        R4.InitializePurchasing();
    }
    public void InitializePurchasing()
    {
        var val_8;
        string val_9;
        var val_8 = 4836007;
        val_8 = 18163612 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        if(mem[536888065] != 0)
        {
                mem[536888065] = mem[mem[536888065] + 4];
            mem[536888065] = mem[536888065] + 4;
            return;
        }
        
        UnityEngine.Purchasing.StandardPurchasingModule val_1 = UnityEngine.Purchasing.StandardPurchasingModule.Instance();
        val_8 = mem[mem[3221271781] + 186];
        val_8 = mem[3221271781] + 186;
        if(val_8 == 1)
        {
                val_8 = mem[mem[3221271781] + 186];
            val_8 = mem[3221271781] + 186;
        }
        
        UnityEngine.Purchasing.ConfigurationBuilder val_2 = UnityEngine.Purchasing.ConfigurationBuilder.Instance(first:  0, rest:  mem[3221271781] + 92);
        if(0 != 0)
        {
                UnityEngine.Purchasing.ConfigurationBuilder val_3 = 0.AddProduct(id:  this.removeAds, type:  1);
            UnityEngine.Purchasing.ConfigurationBuilder val_4 = 0.AddProduct(id:  this.buyMoney, type:  0);
            val_9 = this.buyTapes;
        }
        else
        {
                UnityEngine.Purchasing.ConfigurationBuilder val_5 = 0.AddProduct(id:  this.removeAds, type:  1);
            UnityEngine.Purchasing.ConfigurationBuilder val_6 = 0.AddProduct(id:  this.buyMoney, type:  0);
            val_9 = this.buyTapes;
        }
        
        UnityEngine.Purchasing.ConfigurationBuilder val_7 = 0.AddProduct(id:  val_9, type:  0);
        UnityEngine.Purchasing.UnityPurchasing.Initialize(listener:  516913968, builder:  0);
    }
    public bool IsInitialized()
    {
        if(mem[536888065] == 0)
        {
                return false;
        }
        
        if((mem[536888065] + 4) != 0)
        {
                mem[536888065] + 4 = 1;
        }
        
        return true;
    }
    public void BuyRemoveAds()
    {
        this.BuyProductID(productId:  this.removeAds);
    }
    public void BuyMoney()
    {
        this.BuyProductID(productId:  this.buyMoney);
    }
    public void BuyTape()
    {
        this.BuyProductID(productId:  this.buyTapes);
    }
    public string GetProducePriceFromStore(string id)
    {
        string val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_5 = id;
        val_6 = 22776880;
        if(mem[536888065] == 0)
        {
                return;
        }
        
        var val_4 = mem[536888065];
        if((mem[536888065] + 178) == 0)
        {
            goto label_2;
        }
        
        val_5 = 0;
        label_4:
        val_7 = mem[mem[536888065] + 88 + 0];
        val_7 = mem[536888065] + 88 + 0;
        if(val_7 == 536888747)
        {
            goto label_3;
        }
        
        val_5 = val_5 + 1;
        if(((uint)val_5 & 65535) < (mem[536888065] + 178))
        {
            goto label_4;
        }
        
        label_2:
        val_8 = mem[536888065];
        goto label_5;
        label_3:
        var val_1 = (mem[536888065] + 88) + 0;
        val_4 = val_4 + (((mem[536888065] + 88 + 0) + 4) << 3);
        val_8 = val_4 + 188;
        label_5:
        if(mem[536888065] == 0)
        {
                return;
        }
        
        var val_5 = mem[536888065];
        if((mem[536888065] + 178) == 0)
        {
            goto label_8;
        }
        
        val_7 = 0;
        label_10:
        val_5 = 0;
        if((mem[536888065] + 88 + 0) == 536888747)
        {
            goto label_9;
        }
        
        val_7 = val_7 + 1;
        val_5 = (uint)val_7 & 65535;
        if(val_5 < (mem[536888065] + 178))
        {
            goto label_10;
        }
        
        label_8:
        val_9 = mem[536888065];
        goto label_11;
        label_9:
        var val_2 = (mem[536888065] + 88) + 0;
        val_5 = val_5 + (((mem[536888065] + 88 + 0) + 4) << 3);
        val_9 = val_5 + 188;
        label_11:
        UnityEngine.Purchasing.Product val_3 = mem[536888065].WithID(id:  val_5);
        val_6 = (mem[536888065] + 12) + 8;
    }
    private void BuyProductID(string productId)
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_5 = 4835267;
        val_5 = 18164352 + val_5;
        if(val_5 == 0)
        {
                mem2[0] = 1;
        }
        
        if(mem[536888065] != 0)
        {
                mem[536888065] = mem[mem[536888065] + 4];
            mem[536888065] = mem[536888065] + 4;
            goto label_2;
        }
        
        val_5 = 22782648;
        goto label_5;
        label_2:
        var val_6 = mem[536888065];
        if((mem[536888065] + 178) == 0)
        {
            goto label_6;
        }
        
        val_6 = 0;
        label_8:
        val_7 = 0;
        if((mem[536888065] + 88 + 0) == 536888747)
        {
            goto label_7;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < (mem[536888065] + 178))
        {
            goto label_8;
        }
        
        label_6:
        val_8 = mem[536888065];
        goto label_9;
        label_7:
        var val_1 = (mem[536888065] + 88) + 0;
        val_6 = val_6 + (((mem[536888065] + 88 + 0) + 4) << 3);
        val_8 = val_6 + 188;
        label_9:
        UnityEngine.Purchasing.Product val_2 = mem[536888065].WithID(id:  productId);
        if(mem[536888065] != 0)
        {
                mem[536888065] + 88 + 0 = mem[536888065];
            mem[536888065] = mem[mem[536888065] + 16];
            mem[536888065] = mem[536888065] + 16;
            goto label_11;
        }
        
        val_5 = 22782652;
        label_5:
        UnityEngine.Debug.Log(message:  -1610609849);
        return;
        label_11:
        string val_3 = System.String.Format(format:  -1610605167, arg0:  mem[536888065] + 8 + 8);
        UnityEngine.Debug.Log(message:  -1610605167);
        if((mem[536888065] + 178) == 0)
        {
            goto label_18;
        }
        
        val_6 = 0;
        label_20:
        val_7 = 0;
        if((mem[536888065] + 88 + 0) == 536888747)
        {
            goto label_19;
        }
        
        val_6 = val_6 + 1;
        val_7 = (uint)val_6 & 65535;
        if(val_7 < (mem[536888065] + 178))
        {
            goto label_20;
        }
        
        label_18:
        val_9 = mem[536888065];
        goto ((mem[536888065] + ((mem[536888065] + 88 + 0) + 4) << 3) + 196);
        label_19:
        var val_4 = (mem[536888065] + 88) + 0;
        var val_7 = (mem[536888065] + 88 + 0) + 4;
        val_7 = mem[536888065] + (val_7 << 3);
        val_9 = val_7 + 196;
        goto ((mem[536888065] + ((mem[536888065] + 88 + 0) + 4) << 3) + 196);
    }
    public void RestorePurchases()
    {
        object val_9;
        var val_10;
        var val_11;
        var val_12;
        object val_13;
        System.Action<System.Boolean> val_14;
        var val_15;
        var val_9 = 4833875;
        val_9 = 18165744 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        if(mem[536888065] != 0)
        {
                mem[536888065] = mem[mem[536888065] + 4];
            mem[536888065] = mem[536888065] + 4;
            goto label_2;
        }
        
        label_20:
        UnityEngine.Debug.Log(message:  -1610604905);
        return;
        label_2:
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 == 8)
        {
            goto label_6;
        }
        
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        if(0 != 1)
        {
            goto label_7;
        }
        
        label_6:
        UnityEngine.Debug.Log(message:  -1610604899);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700885.Show(mess:  -1610604907, callBack:  0);
        if((mem[536888065] + 4 + 178) == 0)
        {
            goto label_12;
        }
        
        val_9 = 0;
        label_14:
        if((mem[536888065] + 4 + 88 + 0) == mem[3221278615])
        {
            goto label_13;
        }
        
        val_9 = val_9 + 1;
        if(((uint)val_9 & 65535) < (mem[536888065] + 4 + 178))
        {
            goto label_14;
        }
        
        label_12:
        val_10 = mem[536888065] + 4;
        goto label_15;
        label_7:
        UnityEngine.RuntimePlatform val_4 = UnityEngine.Application.platform;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        string val_5 = -1610604903(-1610604903) + 536893139;
        if(((mem[536885944] & true) != 0) || (mem[536885873] != 0))
        {
            goto label_20;
        }
        
        goto label_20;
        label_13:
        var val_6 = (mem[536888065] + 4 + 88) + 0;
        var val_10 = (mem[536888065] + 4 + 88 + 0) + 4;
        val_10 = val_10 + mem[3221278643];
        val_10 = (mem[536888065] + 4) + (val_10 << 3);
        val_10 = val_10 + 188;
        label_15:
        val_11 = 22718404;
        val_12 = 536899347;
        if(((mem[536899534] & true) == 0) && (mem[536899463] == 0))
        {
                val_12 = 536899347;
        }
        
        val_13 = mem[536899439];
        val_14 = mem[mem[536899439] + 8];
        val_14 = mem[536899439] + 8;
        if(val_14 == 0)
        {
                if(((mem[536899534] & true) == 0) && (mem[536899463] == 0))
        {
                val_13 = mem[536899439];
        }
        
            val_9 = mem[mem[536899439]];
            val_9 = val_13;
            val_14 = 536873261;
            val_14 = new System.Action<System.Boolean>(object:  val_9, method:  new IntPtr(1610677065));
            mem2[0] = val_14;
        }
        
        var val_11 = mem[536888065] + 4;
        if((mem[536888065] + 4 + 178) == 0)
        {
            goto label_27;
        }
        
        val_11 = 0;
        label_29:
        val_9 = 0;
        if((mem[536888065] + 4 + 88 + 0) == 536888005)
        {
            goto label_28;
        }
        
        val_11 = val_11 + 1;
        val_9 = (uint)val_11 & 65535;
        if(val_9 < (mem[536888065] + 4 + 178))
        {
            goto label_29;
        }
        
        label_27:
        val_15 = mem[536888065] + 4;
        return;
        label_28:
        var val_8 = (mem[536888065] + 4 + 88) + 0;
        val_11 = val_11 + (((mem[536888065] + 4 + 88 + 0) + 4) << 3);
        val_15 = val_11 + 188;
    }
    public void OnInitialized(UnityEngine.Purchasing.IStoreController controller, UnityEngine.Purchasing.IExtensionProvider extensions)
    {
        UnityEngine.Purchasing.IExtensionProvider val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_10 = extensions;
        UnityEngine.Debug.Log(message:  -1610605741);
        mem2[0] = controller;
        mem2[0] = val_10;
        var val_10 = 0;
        val_10 = val_10 + 1;
        val_12 = val_10;
        var val_11 = 0;
        val_11 = val_11 + 1;
        val_13 = val_10;
        val_11 = 0;
        val_11 = val_11 + 1;
        val_14 = val_10;
        UnityEngine.Purchasing.IStoreController val_12 = controller;
        if((controller + 178) == 0)
        {
            goto label_19;
        }
        
        val_11 = 0;
        label_21:
        if((controller + 88 + 0) == 536888747)
        {
            goto label_20;
        }
        
        val_11 = val_11 + 1;
        if(((uint)val_11 & 65535) < (controller + 178))
        {
            goto label_21;
        }
        
        label_19:
        val_15 = controller;
        goto label_22;
        label_20:
        var val_4 = (controller + 88) + 0;
        val_12 = val_12 + (((controller + 88 + 0) + 4) << 3);
        val_15 = val_12 + 188;
        label_22:
        val_16 = 0;
        var val_5 = (controller + 16) + 16;
        goto label_24;
        label_37:
        if(((controller + 16 + 16) + 0 + 24) != 0)
        {
                val_11 = mem[(controller + 16 + 16) + 0 + 8];
            val_11 = (controller + 16 + 16) + 0 + 8;
            if(((controller + 16 + 16) + 0 + 8 + 16) == 2)
        {
                val_10 = 0;
            UnityEngine.MonoBehaviour.print(message:  -1610604273);
            if(val_10 != 0)
        {
                if((val_10.ContainsKey(key:  (controller + 16 + 16) + 0 + 8 + 12)) != false)
        {
                UnityEngine.Purchasing.IStoreExtension val_7 = val_10.Item[(controller + 16 + 16) + 0 + 8 + 12];
            val_10 = val_10;
        }
        
        }
        
            UnityEngine.Purchasing.SubscriptionManager val_8 = 536894705;
            val_11 = val_8;
            val_8 = new UnityEngine.Purchasing.SubscriptionManager(product:  (controller + 16 + 16) + 0, intro_json:  val_10);
            UnityEngine.Purchasing.SubscriptionInfo val_9 = val_11.getSubscriptionInfo();
        }
        
        }
        
        val_16 = 1;
        label_24:
        if(val_16 < (controller + 16 + 12))
        {
            goto label_37;
        }
    
    }
    public void OnInitializeFailed(UnityEngine.Purchasing.InitializationFailureReason error)
    {
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        string val_1 = -1610605743(-1610605743) + 536888945;
        UnityEngine.Debug.Log(message:  -1610605743);
    }
    public UnityEngine.Purchasing.PurchaseProcessingResult ProcessPurchase(UnityEngine.Purchasing.PurchaseEventArgs args)
    {
        var val_18;
        UnityEngine.Purchasing.ProductDefinition val_19;
        val_18 = System.String.Equals(a:  args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField, b:  this.removeAds, comparisonType:  4);
        val_19 = args.<purchasedProduct>k__BackingField.<definition>k__BackingField;
        if(val_18 != false)
        {
                string val_2 = System.String.Format(format:  -1610605217, arg0:  args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610605217);
            API.IsRemoveAds = true;
            GameTool.EventDispatcherExtension.PostEvent(sender:  518185520, eventID:  13);
            WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701127.HideBanner();
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700885.Show(mess:  -1610597963, callBack:  0);
            return;
        }
        
        val_19 = args.<purchasedProduct>k__BackingField.<definition>k__BackingField;
        if((System.String.Equals(a:  args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField, b:  this.buyMoney, comparisonType:  4)) == false)
        {
            goto label_16;
        }
        
        string val_6 = System.String.Format(format:  -1610605217, arg0:  args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField);
        UnityEngine.Debug.Log(message:  -1610605217);
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_19;
        }
        
        val_18 = -1073708883.Coin;
        goto label_20;
        label_16:
        val_18 = System.String.Equals(a:  args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField, b:  this.buyTapes, comparisonType:  4);
        if(val_18 == false)
        {
            goto label_23;
        }
        
        string val_10 = System.String.Format(format:  -1610605217, arg0:  args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField);
        UnityEngine.Debug.Log(message:  -1610605217);
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_26;
        }
        
        val_18 = -1073708883.Diamond;
        goto label_27;
        label_23:
        string val_13 = System.String.Format(format:  -1610605219, arg0:  args.<purchasedProduct>k__BackingField.<definition>k__BackingField.<id>k__BackingField);
        UnityEngine.Debug.Log(message:  -1610605219);
        return;
        label_19:
        val_18 = -1073708883.Coin;
        label_20:
        -1073708883.Coin = val_18 + 50000;
        goto label_31;
        label_26:
        val_18 = -1073708883.Diamond;
        label_27:
        -1073708883.Diamond = val_18 + 30;
        label_31:
        GameTool.EventDispatcherExtension.PostEvent(sender:  518185520, eventID:  8);
    }
    public void OnPurchaseFailed(UnityEngine.Purchasing.Product product, UnityEngine.Purchasing.PurchaseFailureReason failureReason)
    {
        string val_1 = System.String.Format(format:  -1610605679, arg0:  product.<definition>k__BackingField.<storeSpecificId>k__BackingField, arg1:  536892319);
        UnityEngine.Debug.Log(message:  -1610605679);
    }
    public IAPManager()
    {
        this.removeAds = -1610601261;
        this.buyMoney = -1610601263;
        this.buyTapes = -1610601259;
    }

}
