using UnityEngine;
public class LotteryPopup : BaseUIMenu
{
    // Fields
    private UnityEngine.UI.Image bestPrizeImageDisplayCharacter;
    private UnityEngine.UI.Button closeButton;
    private int currentOpenRewardTurn;
    public int idSkinBestPrize;
    private readonly System.Collections.Generic.List<int> listIdSkinBestPrizeAvailable;
    public System.Collections.Generic.List<LotteryPopup.ItemLotteryConfig> listItemLotteryConfigs;
    public LotterySlotController[] listLottery;
    private readonly int maxOpenRewardTurn;
    private bool isClose;
    
    // Methods
    private void Start()
    {
        var val_7;
        UnityEngine.Events.UnityAction val_8;
        var val_9;
        LotterySlotController[] val_10;
        UnityEngine.GameObject val_1 = this.closeButton.gameObject;
        this.closeButton.SetActive(value:  false);
        val_7 = 22716284;
        val_8 = 536896275;
        val_9 = 0;
        val_8 = new UnityEngine.Events.UnityAction(object:  766995088, method:  new IntPtr(1610681031));
        this.closeButton.m_OnClick.AddListener(call:  536896275);
        this.CheckListIDSkinBestPrizeAvailable();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  -1610608801);
        val_10 = this.listLottery;
        goto label_5;
        label_15:
        536899639 = new LotteryPopup.<>c__DisplayClass9_0();
        mem[536899651] = this;
        LotterySlotController[] val_7 = val_10[16];
        mem[536899647] = null;
        536896275 = new UnityEngine.Events.UnityAction(object:  536899639, method:  new IntPtr(1610681037));
        LotterySlotController[].__il2cppRuntimeField_byval_arg + 176.AddListener(call:  536896275);
        val_7 = val_7;
        val_8 = mem[LotterySlotController[].__il2cppRuntimeField_namespaze + 176];
        val_8 = LotterySlotController[].__il2cppRuntimeField_namespaze + 176;
        536896275 = new UnityEngine.Events.UnityAction(object:  536899639, method:  new IntPtr(1610681039));
        val_8.AddListener(call:  536896275);
        val_10 = val_10;
        val_9 = 1;
        label_5:
        if(val_9 < val_8)
        {
            goto label_15;
        }
    
    }
    private void OnEnable()
    {
        this.CheckListIDSkinBestPrizeAvailable();
        this.Invoke(methodName:  -1610607421, time:  null);
    }
    private void OnDisable()
    {
        this.StopAllCoroutines();
    }
    public override void Init(object[] initParams)
    {
        this.Init(initParams:  initParams);
    }
    private void InitData()
    {
        int val_2;
        this.isClose = false;
        UnityEngine.GameObject val_1 = this.closeButton.gameObject;
        val_2 = 0;
        this.closeButton.SetActive(value:  false);
        this.closeButton.enabled = true;
        this.StopAllCoroutines();
        this.currentOpenRewardTurn = val_2;
        goto label_3;
        label_8:
        if(null != null)
        {
                1152921506792900064.CloseBox();
        }
        else
        {
                0.CloseBox();
        }
        
        1152921506792900064.EnableAnimation();
        val_2 = 1;
        label_3:
        if(val_2 < 1152921506792900064)
        {
            goto label_8;
        }
        
        this.ShowListBtn();
    }
    private void ShowListBtn()
    {
        goto label_1;
        label_9:
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266315] + 16) != 0)
        {
                1152921506792900064.ShowNomal();
        }
        else
        {
                1152921506792900064.ShowOnlyAds();
        }
        
        0 = 1;
        label_1:
        if(0 < 1152921506792900064)
        {
            goto label_9;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266315] + 16) != 0)
        {
                return;
        }
        
        System.Collections.IEnumerator val_3 = this.DelayShowHome();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  767804944);
    }
    private System.Collections.IEnumerator DelayShowHome()
    {
        536899645 = new LotteryPopup.<DelayShowHome>d__15(<>1__state:  0);
        mem[536899661] = this;
    }
    private void OpenBoxClick(LotterySlotController slot)
    {
        LotteryPopup.<>c__DisplayClass16_0 val_1 = 536899637;
        val_1 = new LotteryPopup.<>c__DisplayClass16_0();
        if(val_1 != 0)
        {
                mem[536899645] = this;
        }
        else
        {
                mem[8] = this;
        }
        
        mem[536899649] = slot;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  536899637, method:  new IntPtr(1610681055));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  13);
    }
    private void OpenBoxNormalClick(LotterySlotController slot)
    {
        this.SetOpenBoxReward(slot:  slot, isAds:  false);
        System.Collections.IEnumerator val_1 = this.DelayShowHome();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  768190096);
        this.SetUpWithAnotherBoxOpen();
    }
    private void SetOpenBoxReward(LotterySlotController slot, bool isAds = False)
    {
        var val_15;
        var val_16;
        int val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        LotteryPopup.TypeItemLottery val_22;
        int val_15 = this.currentOpenRewardTurn;
        val_15 = val_15 + 1;
        this.currentOpenRewardTurn = val_15;
        if(isAds == false)
        {
            goto label_1;
        }
        
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_15 = mem[3221266315];
        if((-1073708883.CountRewardLottery) >= (mem[3221266315] + 8))
        {
            goto label_5;
        }
        
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_6;
        }
        
        val_15 = -1073708883.CountRewardLottery;
        goto label_7;
        label_1:
        this.CheckOpenAllLottery();
        goto label_11;
        label_6:
        val_15 = -1073708883.CountRewardLottery;
        label_7:
        -1073708883.CountRewardLottery = val_15 + 1;
        label_5:
        this.CheckOpenAllLottery();
        bool val_8 = this.CheckRewardSkin();
        if((val_8 != false) && (val_8 >= true))
        {
                if(val_8 <= true)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            slot.OpenBox(type:  0, value:  this.idSkinBestPrize);
            this.listIdSkinBestPrizeAvailable.Clear();
            return;
        }
        
        label_11:
        int val_9 = this.RandomRateReward();
        if(val_9 <= val_9)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + (val_9 << 2);
        val_16 = mem[(0 + (val_9) << 2) + 16];
        val_16 = (0 + (val_9) << 2) + 16;
        if(((0 + (val_9) << 2) + 16 + 12) != 2)
        {
            goto label_20;
        }
        
        if(((0 + (val_9) << 2) + 16 + 12) < 1)
        {
            goto label_22;
        }
        
        val_17 = this.idSkinBestPrize;
        goto label_35;
        label_20:
        val_15 = mem[(0 + (val_9) << 2) + 16 + 16];
        val_15 = (0 + (val_9) << 2) + 16 + 16;
        if(val_15 == 0)
        {
            goto label_24;
        }
        
        val_18 = val_15;
        val_19 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  (0 + (val_9) << 2) + 16 + 16 + 12);
        goto label_25;
        label_22:
        if(((0 + (val_9) << 2) + 16 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = 2621443;
        if(val_16 == 0)
        {
            goto label_28;
        }
        
        val_20 = -1610611231;
        val_21 = val_20;
        goto label_29;
        label_24:
        val_18 = val_15;
        val_19 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  (0 + (val_9) << 2) + 16 + 16 + 12);
        label_25:
        var val_12 = val_15 + (val_19 << 2);
        val_22 = mem[(0 + (val_9) << 2) + 16 + 12];
        val_22 = (0 + (val_9) << 2) + 16 + 12;
        val_17 = mem[((0 + (val_9) << 2) + 16 + 16 + (val_11) << 2) + 16];
        val_17 = ((0 + (val_9) << 2) + 16 + 16 + (val_11) << 2) + 16;
        goto label_31;
        label_28:
        val_21 = 2621443;
        val_20 = 2621443;
        label_29:
        var val_14 = val_21 + ((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  static_value_0028000F)) << 2);
        val_17 = mem[(val_21 + (val_13) << 2) + 16];
        val_17 = (val_21 + (val_13) << 2) + 16;
        label_35:
        val_22 = static_value_0028000F;
        label_31:
        slot.OpenBox(type:  val_22, value:  val_17);
    }
    private void SetUpWithAnotherBoxOpen()
    {
        var val_1 = 0;
        if(this.listLottery != null)
        {
                return;
        }
    
    }
    private void CloseButtonClick()
    {
        var val_8;
        if(this.isClose == true)
        {
                return;
        }
        
        this.isClose = true;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
        if((System.String.op_Equality(a:  768649244, b:  -1610607723)) == false)
        {
            goto label_9;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_7;
        }
        
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_9;
        }
        
        label_7:
        val_8 = 22791776;
        goto label_12;
        label_9:
        val_8 = 22791756;
        label_12:
        AFramework.UI.BaseUIMenu val_7 = AFramework.UI.CanvasManager.Push(identifier:  -1610605291, initParams:  null);
    }
    private System.Collections.IEnumerator DelayActiveCloseButton()
    {
        536899641 = new LotteryPopup.<DelayActiveCloseButton>d__21(<>1__state:  0);
        mem[536899657] = this;
    }
    private void CheckListIDSkinBestPrizeAvailable()
    {
        var val_3;
        var val_4;
        System.Collections.Generic.List<System.Int32> val_5;
        var val_6;
        this.listIdSkinBestPrizeAvailable.Clear();
        val_3 = 0;
        goto label_2;
        label_13:
        val_4 = 536887293;
        if(((mem[536887480] & true) == 0) && (mem[536887409] == 0))
        {
                val_4 = 536887293;
        }
        
        if((mem[536887385] + 12) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = mem[536887385] + 8;
        val_3 = val_3 + 0;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        val_5 = -1073708883;
        if((val_5.CheckSkinUnlock(id:  (mem[536887385] + 8 + 0) + 16)) != true)
        {
                val_5 = this.listIdSkinBestPrizeAvailable;
            val_5.Add(item:  (mem[536887385] + 8 + 0) + 16);
        }
        
        val_3 = 1;
        label_2:
        val_6 = 536887293;
        if(((mem[536887480] & true) == 0) && (mem[536887409] == 0))
        {
                val_6 = 536887293;
        }
        
        if(val_3 < (mem[536887385] + 12))
        {
            goto label_13;
        }
        
        this.CheckBestPrizeFrame();
    }
    private void CheckBestPrizeFrame()
    {
        UnityEngine.GameObject val_1 = this.bestPrizeImageDisplayCharacter.gameObject;
        if(this.listIdSkinBestPrizeAvailable >= 1)
        {
                this.bestPrizeImageDisplayCharacter.SetActive(value:  true);
            int val_2 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  1);
            if(val_2 <= val_2)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_3 = val_3 + (val_2 << 2);
            this.idSkinBestPrize = (0 + (val_2) << 2) + 16;
            this.SetSkin(skinId:  (0 + (val_2) << 2) + 16);
            return;
        }
        
        this.bestPrizeImageDisplayCharacter.SetActive(value:  false);
    }
    private void SetSkin(int skinId)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Sprite val_2 = -1073700965.LoadIcon(id:  skinId);
        this.bestPrizeImageDisplayCharacter.sprite = -1073700965;
    }
    private int RandomRateReward()
    {
        var val_2;
        System.Collections.Generic.List<ItemLotteryConfig> val_3;
        float val_1 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
        float val_4 = 0f;
        val_2 = 4;
        goto label_1;
        label_15:
        if(0 <= 22999928)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(2621443 != 0)
        {
                if(2621443 >= 0)
        {
                if(0 <= 22999928)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_3 = 2621443;
            var val_3 = static_value_0028000B;
            val_3 = val_4 + val_3;
            if(val_3 < 0)
        {
                return 0;
        }
        
        }
        
            if(0 <= 22999928)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_4 = val_4 + static_value_0028000B;
        }
        
        val_2 = 5;
        label_1:
        val_3 = this.listItemLotteryConfigs;
        if((val_2 - 4) < 0)
        {
            goto label_15;
        }
        
        return 0;
    }
    private bool CheckRewardSkin()
    {
        var val_5;
        if(this.currentOpenRewardTurn != this.maxOpenRewardTurn)
        {
                object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
            WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_5 = 0;
            if((-1073708883.CountRewardLottery) < (mem[3221266315] + 8))
        {
                return (bool)val_5;
        }
        
        }
        
        this.currentOpenRewardTurn = 0;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CountRewardLottery = 0;
        val_5 = 1;
        return (bool)val_5;
    }
    private void CheckOpenAllLottery()
    {
        if(this.currentOpenRewardTurn < this.maxOpenRewardTurn)
        {
                return;
        }
        
        R4.StopCoroutine(methodName:  -1610608797);
        UnityEngine.Coroutine val_1 = R4.StartCoroutine(methodName:  -1610608797);
    }
    private System.Collections.IEnumerator DelayCloseIfOpenAll()
    {
        536899643 = new LotteryPopup.<DelayCloseIfOpenAll>d__28(<>1__state:  0);
        mem[536899659] = this;
    }
    public LotteryPopup()
    {
        536877987 = new System.Collections.Generic.List<System.Int32>();
        this.listIdSkinBestPrizeAvailable = 536877987;
        536878623 = new System.Collections.Generic.List<Page>();
        this.listItemLotteryConfigs = 536878623;
        this.maxOpenRewardTurn = 4;
    }
    private void <Start>b__9_0()
    {
        this.CloseButtonClick();
    }

}
