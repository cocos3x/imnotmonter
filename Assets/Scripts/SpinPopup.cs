using UnityEngine;
public class SpinPopup : SingletonUI<SpinPopup>
{
    // Fields
    private SpinInfo itemSpinDataInfo;
    private PickerWheel wheel;
    private UnityEngine.UI.Button spinButton;
    private UnityEngine.UI.Button spinAdsButton;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.GameObject lockClickSpiningPanel;
    private float timeRemaining;
    private bool isFreeSpin;
    private UnityEngine.GameObject rewardPanel;
    private UnityEngine.GameObject rewardItem;
    private UnityEngine.GameObject rewardSkin;
    private UnityEngine.UI.Image rewardItemIconImage;
    private UnityEngine.UI.Image rewardSkinIconImage;
    private TMPro.TextMeshProUGUI rewardItemValueText;
    private UnityEngine.UI.Button getItRewardButton;
    private UnityEngine.UI.Button getX2RewardButton;
    private UnityEngine.UI.Button noThanksButton;
    private ItemSpinInfo itemReward;
    private int pieceIndex;
    private UnityEngine.Sprite coinIconSprite;
    private UnityEngine.Sprite diamondIconSprite;
    private UnityEngine.Sprite[] listSkinSprites;
    
    // Methods
    private void Awake()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  781444752, method:  new IntPtr(1610681247));
        this.spinButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  781444752, method:  new IntPtr(1610681249));
        this.spinAdsButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  781444752, method:  new IntPtr(1610681251));
        this.closeButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  781444752, method:  new IntPtr(1610681253));
        this.getItRewardButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  781444752, method:  new IntPtr(1610681255));
        this.getX2RewardButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  781444752, method:  new IntPtr(1610681257));
        this.noThanksButton.m_OnClick.AddListener(call:  536896275);
    }
    private void Start()
    {
        this.GetData();
        this.SetData();
    }
    private void OnEnable()
    {
        this.CheckTimeSpin();
    }
    public override void Init(object[] initParams)
    {
        this.Init(initParams:  initParams);
    }
    private void GetData()
    {
        var val_5;
        var val_6;
        var val_7;
        val_5 = this;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        this.itemSpinDataInfo.listItemSpin = 536882125;
        val_6 = 4;
        val_7 = 16;
        goto label_9;
        label_22:
        ItemSpinInfo val_4 = 536889301;
        val_4 = new ItemSpinInfo();
        mem[536889313] = mem[3221266283] + 16 + 16;
        mem[536889317] = mem[3221266283] + 12 + 16;
        mem[536889321] = mem[3221266283] + 20 + 16;
        this.itemSpinDataInfo.listItemSpin[0] = val_4;
        val_7 = 20;
        val_6 = 5;
        val_5 = val_5;
        label_9:
        if((val_6 - 4) < this.itemSpinDataInfo.listItemSpin[val_7])
        {
            goto label_22;
        }
    
    }
    private void SetData()
    {
        this.wheel.SetData(itemInfo:  this.itemSpinDataInfo);
    }
    private void CheckTimeSpin()
    {
        var val_8;
        var val_22;
        bool val_23;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_2 = -1073708883.TimeSpin;
        if((System.String.op_Equality(a:  -1073708883, b:  -1610612735)) == false)
        {
            goto label_2;
        }
        
        UnityEngine.GameObject val_4 = this.spinButton.gameObject;
        if(this.spinButton != 0)
        {
            goto label_16;
        }
        
        goto label_16;
        label_2:
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_6 = -1073708883.TimeSpin;
        System.DateTime val_7 = System.DateTime.Parse(s:  782440568);
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_22 = -1073700851;
        if(mem[3221266457] == false)
        {
            goto label_10;
        }
        
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_22 = -1073700851;
        System.DateTime val_12 = GetCurrentDateTime();
        System.TimeSpan val_13 = Subtract(value:  new System.DateTime() {dateData = 1152921509684254848});
        WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        double val_15 = val_8.TotalSeconds;
        var val_22 = 3600;
        val_22 = (mem[3221266283] + 8) * val_22;
        this.timeRemaining = (float)val_22 - S0;
        UnityEngine.GameObject val_17 = this.spinButton.gameObject;
        if(this.spinButton <= 0)
        {
            goto label_16;
        }
        
        this.spinButton.SetActive(value:  false);
        val_23 = 0;
        UnityEngine.GameObject val_18 = this.spinAdsButton.gameObject;
        this.spinAdsButton.SetActive(value:  true);
        goto label_23;
        label_16:
        this.spinButton.SetActive(value:  true);
        UnityEngine.GameObject val_19 = this.spinAdsButton.gameObject;
        this.spinAdsButton.SetActive(value:  false);
        this.wheel.SetNotifText(value:  -1610605047);
        val_23 = 1;
        goto label_23;
        label_10:
        val_23 = false;
        this.wheel.SetNotifText(value:  -1610606097);
        label_23:
        this.isFreeSpin = val_23;
        this.wheel.StopAllCoroutines();
        System.Collections.IEnumerator val_20 = this.TimeCountDownSpin();
        UnityEngine.Coroutine val_21 = this.wheel.StartCoroutine(routine:  782452624);
    }
    private void RestartTimeSpin()
    {
        var val_14;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(mem[3221266457] != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            System.DateTime val_3 = GetCurrentDateTime();
            object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
            string val_5 = ???.ToString();
            val_14;
            -1073708883.TimeSpin = 782589456;
        }
        else
        {
                object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
            System.DateTime val_7 = System.DateTime.Now;
            string val_8 = ???.ToString();
            val_14;
            -1073708883.TimeSpin = 782589448;
            this.wheel.SetNotifText(value:  -1610606097);
        }
        
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_14 = mem[3221266283] + 8;
        val_14 = val_14 * 3600;
        this.isFreeSpin = false;
        this.timeRemaining = (float)val_14;
        UnityEngine.GameObject val_10 = this.spinButton.gameObject;
        this.spinButton.SetActive(value:  false);
        UnityEngine.GameObject val_11 = this.spinAdsButton.gameObject;
        this.spinAdsButton.SetActive(value:  true);
        GameTool.EventDispatcherExtension.PostEvent(sender:  782601488, eventID:  8);
        System.Collections.IEnumerator val_12 = this.TimeCountDownSpin();
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  782601488);
    }
    private System.Collections.IEnumerator TimeCountDownSpin()
    {
        536901399 = new SpinPopup.<TimeCountDownSpin>d__30(<>1__state:  0);
        mem[536901415] = this;
    }
    private void SpinButtonClick(bool isAds)
    {
        var val_5;
        object val_6;
        UnityEngine.Events.UnityAction val_7;
        if(this.wheel._isSpinning != false)
        {
                return;
        }
        
        this.lockClickSpiningPanel.SetActive(value:  true);
        if(isAds != false)
        {
                WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536873261 = new System.Action<System.Boolean>(object:  782858256, method:  new IntPtr(1610681259));
            -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  4);
            return;
        }
        
        if(this.isFreeSpin == true)
        {
                this.isFreeSpin = this;
            this.RestartTimeSpin();
        }
        
        val_5 = 536901393;
        if(((mem[536901580] & true) == 0) && (mem[536901509] == 0))
        {
                val_5 = 536901393;
        }
        
        val_6 = mem[536901485];
        val_7 = mem[mem[536901485] + 8];
        val_7 = mem[536901485] + 8;
        if(val_7 == 0)
        {
                if(((mem[536901580] & true) == 0) && (mem[536901509] == 0))
        {
                val_6 = mem[536901485];
        }
        
            val_7 = 536896275;
            val_7 = new UnityEngine.Events.UnityAction(object:  val_6, method:  new IntPtr(1610681285));
            mem2[0] = val_7;
        }
        
        this.wheel.onSpinStartEvent = val_7;
        536880163 = new UnityEngine.Events.UnityAction<WheelPiece>(object:  782858256, method:  new IntPtr(1610681263));
        this.wheel.onSpinEndEvent = 536880163;
        this.wheel.Spin();
    }
    private void CloseButtonClick()
    {
        goto typeof(SpinPopup).__il2cppRuntimeField_E4;
    }
    private void RewardSpin(int index)
    {
        ItemSpinInfo val_15;
        UnityEngine.UI.Image val_16;
        UnityEngine.Sprite val_17;
        TMPro.TextMeshProUGUI val_18;
        int val_19;
        this.StopCoroutine(methodName:  -1610608777);
        UnityEngine.GameObject val_1 = this.noThanksButton.gameObject;
        this.noThanksButton.SetActive(value:  false);
        this.rewardPanel.SetActive(value:  true);
        this.rewardItem.SetActive(value:  false);
        this.rewardSkin.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.getItRewardButton.gameObject;
        this.getItRewardButton.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.getX2RewardButton.gameObject;
        this.getX2RewardButton.SetActive(value:  false);
        this.itemReward = this.itemSpinDataInfo.listItemSpin[index];
        val_15 = this.itemReward;
        if(this.itemSpinDataInfo.listItemSpin[index][0].itemType == 0)
        {
            goto label_14;
        }
        
        if(this.itemSpinDataInfo.listItemSpin[index][0].itemType == 2)
        {
            goto label_15;
        }
        
        if(this.itemSpinDataInfo.listItemSpin[index][0].itemType != 1)
        {
            goto label_41;
        }
        
        val_16 = this.rewardItemIconImage;
        val_17 = this.coinIconSprite;
        goto label_17;
        label_14:
        val_16 = this.rewardItemIconImage;
        val_17 = this.diamondIconSprite;
        label_17:
        val_16.sprite = val_17;
        val_18 = this.rewardItemValueText;
        val_19 = this.itemReward.rewardValue;
        goto label_20;
        label_15:
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
            goto label_21;
        }
        
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CheckSkinUnlock(id:  this.itemSpinDataInfo.listItemSpin[index][0].rewardValue)) == false)
        {
            goto label_24;
        }
        
        label_21:
        this.rewardItemIconImage.sprite = this.coinIconSprite;
        val_18 = this.rewardItemValueText;
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_19 = mem[3221266283] + 24;
        label_20:
        string val_8 = val_19.ToString();
        val_15 = val_19;
        val_18.text = val_15;
        this.rewardItem.SetActive(value:  true);
        UnityEngine.GameObject val_9 = this.getX2RewardButton.gameObject;
        this.getX2RewardButton.SetActive(value:  true);
        UnityEngine.Coroutine val_10 = this.StartCoroutine(methodName:  -1610608777);
        label_41:
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610604267, volume:  null);
        return;
        label_24:
        this.rewardSkinIconImage.sprite = this.listSkinSprites[this.itemReward.rewardValue];
        this.rewardSkin.SetActive(value:  true);
        UnityEngine.GameObject val_13 = this.getItRewardButton.gameObject;
        this.getItRewardButton.SetActive(value:  true);
        goto label_41;
    }
    private System.Collections.IEnumerator DelayShowNoThanks()
    {
        536901397 = new SpinPopup.<DelayShowNoThanks>d__34(<>1__state:  0);
        mem[536901413] = this;
    }
    private void GetItRewardButtonClick()
    {
        var val_25;
        ItemSpinInfo val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        val_25 = -1610612735;
        val_26 = this.itemReward;
        if(this.itemReward != 0)
        {
            goto label_1;
        }
        
        val_26 = this.itemReward;
        if(val_26 == 0)
        {
            goto label_2;
        }
        
        label_1:
        if(this.itemReward.itemType == 0)
        {
            goto label_3;
        }
        
        if(this.itemReward.itemType == 2)
        {
            goto label_4;
        }
        
        if(this.itemReward.itemType != 1)
        {
            goto label_29;
        }
        
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
            goto label_6;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_7;
        }
        
        val_27 = -1073708883.Coin;
        goto label_8;
        label_4:
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
            goto label_9;
        }
        
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CheckSkinUnlock(id:  this.itemReward.rewardValue)) == false)
        {
            goto label_11;
        }
        
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_28 = mem[3221266283];
        val_29 = -1073708883;
        goto label_14;
        label_3:
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
            goto label_15;
        }
        
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_16;
        }
        
        val_30 = -1073708883.Diamond;
        goto label_17;
        label_9:
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_28 = mem[3221266283];
        val_29 = -1073708883;
        label_14:
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        if(val_29 != 0)
        {
                val_31 = val_29.Coin;
        }
        else
        {
                val_31 = val_29.Coin;
        }
        
        val_29.Coin = val_31 + (mem[3221266283] + 24);
        if((mem[3221266283] + 24) >= 2)
        {
            goto label_22;
        }
        
        val_32 = 536888987;
        goto label_23;
        label_22:
        val_33 = 536888987;
        goto label_24;
        label_11:
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.UnlockSkin(id:  this.itemReward.rewardValue);
        object val_17 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.SkinSelectedID = this.itemReward.rewardValue;
        val_25 = -1610602429;
        goto label_29;
        label_7:
        val_27 = -1073708883.Coin;
        label_8:
        -1073708883.Coin = val_27 + this.itemReward.rewardValue;
        label_6:
        if(this.itemReward.rewardValue >= 2)
        {
            goto label_30;
        }
        
        val_32 = 536888987;
        label_23:
        val_34 = val_32;
        val_35 = 22797476;
        goto label_34;
        label_30:
        val_33 = 536888987;
        label_24:
        val_34 = val_33;
        val_35 = 22797480;
        goto label_34;
        label_16:
        val_30 = -1073708883.Diamond;
        label_17:
        -1073708883.Diamond = val_30 + this.itemReward.rewardValue;
        label_15:
        if(this.itemReward.rewardValue < 2)
        {
                val_34 = 536888987;
            val_35 = 22797484;
        }
        else
        {
                val_34 = 536888987;
            val_35 = 22797488;
        }
        
        label_34:
        string val_22 = System.String.Format(format:  -1610602421, arg0:  536888987);
        val_25 = val_35;
        label_29:
        this.wheel.UpdateDisplay(index:  this.pieceIndex);
        WorldTimeAPI val_23 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700885.Show(mess:  -1610602421, callBack:  0);
        UnityEngine.GameObject val_24 = this.rewardPanel.gameObject;
        this.rewardPanel.SetActive(value:  false);
        GameTool.EventDispatcherExtension.PostEvent(sender:  783699472, eventID:  8);
        return;
        label_2:
    }
    private void GetX2RewardButtonClick()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  783840144, method:  new IntPtr(1610681265));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  5);
    }
    private void NoThanksButtonClick()
    {
        this.GetItRewardButtonClick();
    }
    public SpinPopup()
    {
    
    }
    private void <Awake>b__22_0()
    {
        this.SpinButtonClick(isAds:  false);
    }
    private void <Awake>b__22_1()
    {
        this.SpinButtonClick(isAds:  true);
    }
    private void <Awake>b__22_2()
    {
        goto typeof(SpinPopup).__il2cppRuntimeField_E4;
    }
    private void <Awake>b__22_3()
    {
        this.GetItRewardButtonClick();
    }
    private void <Awake>b__22_4()
    {
        this.GetX2RewardButtonClick();
    }
    private void <Awake>b__22_5()
    {
        this.GetItRewardButtonClick();
    }
    private void <SpinButtonClick>b__31_0(bool success)
    {
        var val_3;
        object val_4;
        UnityEngine.Events.UnityAction val_5;
        if(success != false)
        {
                val_3 = 536901393;
            if(((mem[536901580] & true) == 0) && (mem[536901509] == 0))
        {
                val_3 = 536901393;
        }
        
            val_4 = mem[536901485];
            val_5 = mem[mem[536901485] + 4];
            val_5 = mem[536901485] + 4;
            if(val_5 == 0)
        {
                if(((mem[536901580] & true) == 0) && (mem[536901509] == 0))
        {
                val_4 = mem[536901485];
        }
        
            val_5 = 536896275;
            val_5 = new UnityEngine.Events.UnityAction(object:  val_4, method:  new IntPtr(1610681283));
            mem2[0] = val_5;
        }
        
            this.wheel.onSpinStartEvent = val_5;
            536880163 = new UnityEngine.Events.UnityAction<WheelPiece>(object:  784864528, method:  new IntPtr(1610681261));
            this.wheel.onSpinEndEvent = 536880163;
            this.wheel.Spin();
            return;
        }
        
        this.lockClickSpiningPanel.SetActive(value:  false);
    }
    private void <SpinButtonClick>b__31_4(WheelPiece piece)
    {
        this.pieceIndex = piece.Index;
        this.RewardSpin(index:  piece.Index);
        this.lockClickSpiningPanel.SetActive(value:  false);
        UnityEngine.Debug.Log(message:  -1610609249);
    }
    private void <SpinButtonClick>b__31_2(WheelPiece piece)
    {
        this.pieceIndex = piece.Index;
        this.RewardSpin(index:  piece.Index);
        this.lockClickSpiningPanel.SetActive(value:  false);
        UnityEngine.Debug.Log(message:  -1610609249);
    }
    private void <GetX2RewardButtonClick>b__36_0(bool success)
    {
        var val_25;
        var val_26;
        ItemSpinInfo val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        val_25 = 23000076;
        if(success == false)
        {
                return;
        }
        
        this.StopCoroutine(methodName:  -1610608777);
        UnityEngine.GameObject val_1 = this.noThanksButton.gameObject;
        this.noThanksButton.SetActive(value:  true);
        val_26 = -1610612735;
        val_27 = this.itemReward;
        if(this.itemReward != 0)
        {
            goto label_4;
        }
        
        val_27 = this.itemReward;
        if(val_27 == 0)
        {
            goto label_5;
        }
        
        label_4:
        if(this.itemReward.itemType == 0)
        {
            goto label_6;
        }
        
        if(this.itemReward.itemType == 2)
        {
            goto label_7;
        }
        
        if(this.itemReward.itemType != 1)
        {
            goto label_31;
        }
        
        val_28 = this.itemReward.rewardValue << 1;
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
            goto label_9;
        }
        
        val_29 = -1073708883;
        goto label_10;
        label_7:
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
            goto label_11;
        }
        
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CheckSkinUnlock(id:  this.itemReward.rewardValue)) == false)
        {
            goto label_13;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_30 = mem[mem[3221266283] + 24];
        val_30 = mem[3221266283] + 24;
        val_29 = -1073708883;
        goto label_16;
        label_6:
        int val_7 = this.itemReward.rewardValue << 1;
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) == false)
        {
            goto label_17;
        }
        
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_18;
        }
        
        val_31 = -1073708883.Diamond;
        goto label_19;
        label_11:
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_30 = mem[mem[3221266283] + 24];
        val_30 = mem[3221266283] + 24;
        val_29 = -1073708883;
        label_16:
        val_28 = val_30 << 1;
        label_10:
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        if(val_29 != 0)
        {
                val_32 = val_29.Coin;
        }
        else
        {
                val_32 = val_29.Coin;
        }
        
        val_29.Coin = val_32 + val_28;
        label_9:
        if(val_28 >= 2)
        {
            goto label_24;
        }
        
        val_33 = 536888987;
        val_34 = 22797476;
        goto label_33;
        label_24:
        val_33 = 536888987;
        val_34 = 22797480;
        goto label_33;
        label_13:
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.UnlockSkin(id:  this.itemReward.rewardValue);
        object val_17 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.SkinSelectedID = this.itemReward.rewardValue;
        val_26 = -1610602429;
        goto label_31;
        label_18:
        val_31 = -1073708883.Diamond;
        label_19:
        -1073708883.Diamond = val_31 + val_7;
        label_17:
        if(val_7 < 2)
        {
                val_33 = 536888987;
            val_34 = 22797484;
        }
        else
        {
                val_33 = 536888987;
            val_34 = 22797488;
        }
        
        label_33:
        string val_20 = System.String.Format(format:  -1610602421, arg0:  536888987);
        val_26 = val_34;
        label_31:
        this.wheel.UpdateDisplay(index:  this.pieceIndex);
        WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_25 = -1073700885;
        val_25.Show(mess:  -1610602421, callBack:  0);
        UnityEngine.GameObject val_22 = this.rewardPanel.gameObject;
        this.rewardPanel.SetActive(value:  false);
        GameTool.EventDispatcherExtension.PostEvent(sender:  785282448, eventID:  8);
        return;
        label_5:
    }

}
