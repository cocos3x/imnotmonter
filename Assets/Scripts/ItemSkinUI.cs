using UnityEngine;
public class ItemSkinUI : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject buttonCoin;
    private UnityEngine.GameObject buttonList;
    private UnityEngine.GameObject buttonTape;
    private UnityEngine.UI.Image icon;
    private UnityEngine.GameObject iconLock;
    private int idItem;
    public int idSkin;
    private UnityEngine.GameObject selet;
    private UnityEngine.GameObject seleted;
    private TMPro.TextMeshProUGUI txtCoin;
    private TMPro.TextMeshProUGUI txtTape;
    private typeSkin typeskin;
    private int typeUnlock;
    private int price;
    
    // Methods
    private void Start()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  820921104, method:  new IntPtr(1610681865));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  820921104, eventID:  26, callback:  536873423);
    }
    private void OnEnable()
    {
        this.InitSkin();
        this.CheckBtn();
    }
    private void Init()
    {
        this.InitSkin();
        this.CheckBtn();
    }
    private void CheckBtn()
    {
        TMPro.TextMeshProUGUI val_10;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.typeskin == 0)
        {
            goto label_2;
        }
        
        if((-1073708883.CheckSkinHuggyUnlock(id:  this.idSkin)) == false)
        {
            goto label_10;
        }
        
        this.buttonList.SetActive(value:  false);
        this.iconLock.SetActive(value:  false);
        this.selet.SetActive(value:  false);
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_4 = -1073708883.SkinHuggySelectedID;
        goto label_8;
        label_2:
        if((-1073708883.CheckSkinUnlock(id:  this.idSkin)) == false)
        {
            goto label_10;
        }
        
        this.buttonList.SetActive(value:  false);
        this.iconLock.SetActive(value:  false);
        this.selet.SetActive(value:  false);
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_7 = -1073708883.SkinSelectedID;
        label_8:
        if(val_7 == this.idSkin)
        {
                0 = 1;
        }
        
        if(val_7 != this.idSkin)
        {
                0 = 0;
        }
        
        this.seleted.SetActive(value:  false);
        return;
        label_10:
        this.buttonList.SetActive(value:  true);
        this.iconLock.SetActive(value:  true);
        this.seleted.SetActive(value:  false);
        this.selet.SetActive(value:  false);
        if(this.typeUnlock != 0)
        {
                this.buttonCoin.SetActive(value:  false);
            this.buttonTape.SetActive(value:  true);
            val_10 = this.txtTape;
        }
        else
        {
                this.buttonCoin.SetActive(value:  true);
            this.buttonTape.SetActive(value:  false);
            val_10 = this.txtCoin;
        }
        
        string val_8 = this.price.ToString();
        val_10.text = this.price;
    }
    public void SellectClick()
    {
        var val_20;
        var val_21;
        int val_22;
        float val_23;
        var val_24;
        val_20 = 22740800;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        val_21 = -1073708883;
        val_22 = this.idSkin;
        if(this.typeskin == 0)
        {
            goto label_2;
        }
        
        if((val_21.CheckSkinHuggyUnlock(id:  val_22)) == false)
        {
            goto label_12;
        }
        
        this.selet.SetActive(value:  true);
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.SkinHuggySelectedID = val_22;
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610605331, volume:  null);
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        string val_7 = val_22.ToString();
        val_23 = 4.018176E-38f;
        536874379.Add(key:  -1610602887, value:  821520692);
        val_20 = 22793316;
        -1073700879.TrackEvent(eventName:  -1610604511, parameters:  536874379);
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_21 = -1073700879;
        val_22 = 536874379;
        val_22 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        string val_10 = val_22.ToString();
        val_22.Add(key:  -1610605243, value:  821520692);
        val_24 = -1610604511;
        goto label_11;
        label_2:
        if((val_21.CheckSkinUnlock(id:  val_22)) == false)
        {
            goto label_12;
        }
        
        this.selet.SetActive(value:  true);
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.SkinSelectedID = val_22;
        WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610605331, volume:  null);
        WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_20 = -1073700879;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        string val_16 = val_22.ToString();
        val_15.Add(key:  -1610602895, value:  821520692);
        val_23 = 4.037059E-38f;
        val_20.TrackEvent(eventName:  -1610604511, parameters:  536874379);
        WorldTimeAPI val_17 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_21 = -1073700879;
        System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation> val_18 = 536874379;
        val_22 = val_18;
        val_18 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        string val_19 = val_22.ToString();
        val_22.Add(key:  -1610605245, value:  821520692);
        val_24 = -1610604511;
        label_11:
        val_21.TrackEvent(eventName:  -1610604511, parameters:  536874379);
        goto label_20;
        label_12:
        this.seleted.SetActive(value:  false);
        this.selet.SetActive(value:  true);
        label_20:
        GameTool.EventDispatcherExtension.PostEvent(sender:  821520656, eventID:  26, param:  536888987);
    }
    private void InitSkin()
    {
        int val_17;
        int val_18;
        int val_19;
        int val_20;
        int val_21;
        var val_22;
        int val_23;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(this.typeskin == 0)
        {
            goto label_3;
        }
        
        var val_15 = mem[3221266291] + 12 + 12;
        if(val_15 == 0)
        {
            goto label_5;
        }
        
        val_17 = this.idItem;
        if(val_17 >= val_15)
        {
            goto label_6;
        }
        
        if(val_15 > val_17)
        {
            goto label_8;
        }
        
        goto label_8;
        label_3:
        var val_16 = mem[3221266291] + 8 + 12;
        if(val_16 == 0)
        {
            goto label_10;
        }
        
        val_18 = this.idItem;
        if(val_18 >= val_16)
        {
            goto label_11;
        }
        
        if(val_16 > val_18)
        {
            goto label_13;
        }
        
        goto label_13;
        label_5:
        val_19 = 0;
        goto label_14;
        label_6:
        val_17 = val_15 - 1;
        label_8:
        val_15 = (mem[3221266291] + 12) + (val_17 << 2);
        val_19 = mem[(mem[3221266291] + 12 + ((mem[3221266291] + 12 + 12 - 1)) << 2) + 16];
        val_19 = (mem[3221266291] + 12 + ((mem[3221266291] + 12 + 12 - 1)) << 2) + 16;
        label_14:
        this.idSkin = val_19;
        if((UnityEngine.Object.op_Implicit(exists:  this.icon)) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_20 = this.idSkin;
            UnityEngine.Sprite val_4 = -1073700965.LoadHuggy(id:  val_20);
            this.icon.sprite = -1073700965;
        }
        
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_6 = (mem[3221266291] + 28) + (this.idItem << 2);
        this.typeUnlock = (mem[3221266291] + 28 + (this.idItem) << 2) + 16;
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_21 = this.idItem;
        val_22 = mem[mem[3221266291] + 24];
        val_22 = mem[3221266291] + 24;
        goto label_26;
        label_10:
        val_23 = 0;
        goto label_27;
        label_11:
        val_18 = val_16 - 1;
        label_13:
        val_16 = (mem[3221266291] + 8) + (val_18 << 2);
        val_23 = mem[(mem[3221266291] + 8 + ((mem[3221266291] + 8 + 12 - 1)) << 2) + 16];
        val_23 = (mem[3221266291] + 8 + ((mem[3221266291] + 8 + 12 - 1)) << 2) + 16;
        label_27:
        this.idSkin = val_23;
        if((UnityEngine.Object.op_Implicit(exists:  this.icon)) != false)
        {
                WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_20 = this.idSkin;
            UnityEngine.Sprite val_10 = -1073700965.LoadIcon(id:  val_20);
            this.icon.sprite = -1073700965;
        }
        
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_12 = (mem[3221266291] + 16) + (this.idItem << 2);
        this.typeUnlock = (mem[3221266291] + 16 + (this.idItem) << 2) + 16;
        WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_21 = this.idItem;
        val_22 = mem[mem[3221266291] + 20];
        val_22 = mem[3221266291] + 20;
        label_26:
        int val_14 = val_22 + (val_21 << 2);
        val_14 = val_14 + 16;
        this.price = val_14;
    }
    public void CheckSllectSkin(int idSlelected)
    {
        idSlelected = (this.idSkin - idSlelected) >> 5;
        this.selet.SetActive(value:  idSlelected);
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_13 = this.idSkin;
        if(this.typeskin != 0)
        {
                val_13 = (-1073708883.CheckSkinHuggyUnlock(id:  val_13)) ^ 1;
            this.iconLock.SetActive(value:  val_13);
            object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_5 = -1073708883.SkinHuggySelectedID;
            val_5 = val_5 - this.idSkin;
            this.seleted.SetActive(value:  val_5 >> 5);
            WinPopup val_7 = AFramework.SingletonUI<WinPopup>.I;
            -1073700805.ShowHuggySkinSlect(skinid:  idSlelected);
            return;
        }
        
        val_13 = (-1073708883.CheckSkinUnlock(id:  val_13)) ^ 1;
        this.iconLock.SetActive(value:  val_13);
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_10 = -1073708883.SkinSelectedID;
        val_10 = val_10 - this.idSkin;
        this.seleted.SetActive(value:  val_10 >> 5);
        WinPopup val_12 = AFramework.SingletonUI<WinPopup>.I;
        -1073700805.ShowSkinSlect(skinid:  idSlelected);
    }
    public void ClickBuy()
    {
        int val_24;
        var val_25;
        System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation> val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        int val_31;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if(this.typeUnlock == 0)
        {
            goto label_2;
        }
        
        int val_2 = -1073708883.Diamond;
        if(val_2 >= this.price)
        {
            goto label_3;
        }
        
        val_2.DiamondClick();
        return;
        label_2:
        int val_3 = -1073708883.Coin;
        if(val_3 >= this.price)
        {
            goto label_4;
        }
        
        val_3.MoneyClick();
        return;
        label_3:
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        val_24 = this.idSkin;
        string val_6 = val_24.ToString();
        if(this.typeskin == 0)
        {
            goto label_6;
        }
        
        536874379.Add(key:  -1610602947, value:  val_24);
        -1073700879.TrackEvent(eventName:  -1610604511, parameters:  536874379);
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.UnlockSkinHuggy(id:  val_24);
        goto label_9;
        label_4:
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        val_24 = this;
        if(this.typeskin == 0)
        {
            goto label_11;
        }
        
        -1073708883.UnlockSkinHuggy(id:  this.idSkin);
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_25 = -1073700879;
        val_26 = 536874379;
        val_26 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        string val_11 = this.idSkin.ToString();
        val_27 = 1152921509723781556;
        val_28 = -1073733909;
        val_29 = 22796444;
        goto label_13;
        label_6:
        536874379.Add(key:  -1610602953, value:  val_24);
        -1073700879.TrackEvent(eventName:  -1610604511, parameters:  536874379);
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.UnlockSkin(id:  val_24);
        label_9:
        object val_13 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_30 = -1073708883.Diamond;
            val_31 = this.price;
        }
        else
        {
                val_30 = -1073708883.Diamond;
            val_31 = this.price;
        }
        
        -1073708883.Diamond = val_30 - val_31;
        goto label_18;
        label_11:
        -1073708883.UnlockSkin(id:  this.idSkin);
        WorldTimeAPI val_17 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_25 = -1073700879;
        val_26 = 536874379;
        val_26 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        string val_19 = this.idSkin.ToString();
        val_27 = 1152921509723781556;
        val_28 = -1073733909;
        val_29 = 22796432;
        label_13:
        val_26.Add(key:  -1610602953, value:  821967284);
        val_25.TrackEvent(eventName:  -1610604511, parameters:  536874379);
        object val_20 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_30 = -1073708883.Coin;
            val_31 = this.price;
        }
        else
        {
                val_30 = -1073708883.Coin;
            val_31 = this.price;
        }
        
        -1073708883.Coin = val_30 - val_31;
        label_18:
        GameTool.EventDispatcherExtension.PostEvent(sender:  821967248, eventID:  8);
        this.SellectClick();
        this.CheckBtn();
    }
    private void MoneyClick()
    {
        mem[536882227] = 536884213;
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Push(identifier:  -1610605285, initParams:  536882211);
    }
    private void DiamondClick()
    {
        mem[536882227] = 536884213;
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Push(identifier:  -1610605285, initParams:  536882211);
    }
    public ItemSkinUI()
    {
    
    }
    private void <Start>b__14_0(UnityEngine.Component sender, object param)
    {
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        this.CheckSllectSkin(idSlelected:  19169280);
    }

}
