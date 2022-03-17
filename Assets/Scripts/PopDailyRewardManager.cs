using UnityEngine;
public class PopDailyRewardManager : BaseUIMenu
{
    // Fields
    private UnityEngine.GameObject[] blackObject;
    private UnityEngine.GameObject[] canGetObj;
    private UnityEngine.UI.Button claimButton;
    private UnityEngine.UI.Button claimX2Button;
    private UnityEngine.GameObject[] coinDay;
    private TMPro.TextMeshProUGUI[] coinTxt;
    private UnityEngine.Transform content;
    private TMPro.TextMeshProUGUI[] dayTxt;
    private UnityEngine.GameObject[] diamonDay;
    private TMPro.TextMeshProUGUI[] diamonTxt;
    private UnityEngine.UI.Button getstkinBtn;
    private UnityEngine.GameObject listBtn;
    private UnityEngine.GameObject[] skinDay;
    private UnityEngine.UI.Image[] skinImg;
    
    // Methods
    private void OnEnable()
    {
        this.Init();
        this.claimButton.interactable = true;
        this.claimX2Button.interactable = true;
        this.getstkinBtn.interactable = true;
        UnityEngine.GameObject val_1 = this.claimButton.gameObject;
        this.claimButton.SetActive(value:  true);
        UnityEngine.GameObject val_2 = this.claimButton.gameObject;
        this.claimButton.SetActive(value:  false);
        this.CheckCollectInDay();
        UnityEngine.GameObject val_3 = this.listBtn.gameObject;
        this.listBtn.SetActive(value:  true);
    }
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  832887568, method:  new IntPtr(1610682027));
        this.claimButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  832887568, method:  new IntPtr(1610682029));
        this.getstkinBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  832887568, method:  new IntPtr(1610682031));
        this.claimX2Button.m_OnClick.AddListener(call:  536896275);
    }
    private void Init()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        Weight val_2 = this.GetComponent<Weight>();
        mem[1152921509734838436] = this;
    }
    private void Load()
    {
        this.CheckCollectInDay();
    }
    private void ShowBtnOnHasSkin()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_3 = -1073708883.IndexOfDayDaily;
        if((-1073708883.CheckSkinUnlock(id:  val_3.GetSkinId(i:  val_3))) != false)
        {
                UnityEngine.GameObject val_6 = this.claimX2Button.gameObject;
            this.claimX2Button.SetActive(value:  true);
            UnityEngine.GameObject val_7 = this.getstkinBtn.gameObject;
            this.getstkinBtn.SetActive(value:  false);
            UnityEngine.GameObject val_8 = this.claimButton.gameObject;
            this.claimButton.SetActive(value:  false);
            this.Invoke(methodName:  -1610604589, time:  null);
            return;
        }
        
        UnityEngine.GameObject val_9 = this.claimButton.gameObject;
        this.claimButton.SetActive(value:  false);
        UnityEngine.GameObject val_10 = this.claimX2Button.gameObject;
        this.claimX2Button.SetActive(value:  false);
        UnityEngine.GameObject val_11 = this.getstkinBtn.gameObject;
        this.getstkinBtn.SetActive(value:  true);
    }
    private int GetDiamon(int i)
    {
        var val_16;
        if(i > 6)
        {
                return 0;
        }
        
        var val_1 = 18784008 + (18784008 + (i) << 2);
        if(i == 6)
        {
                18784008 = 18784008 & ((IP) << 18784008);
            18784008 = 18784008 & (((int)IP) >> (18784008 & (IP) << 18784008));
            18784008 = i * 18784008;
            18784008 = 18784008 & (((int)IP) >> 1);
            18784008 = 18784008 & (i << 2);
            18784008 = 18784008 & ((IP) >> 18784008 + (i) << 2);
            18784008 = 18784008 & (((i) << (32-18784008 + (i) << 2)) | ((i) << 18784008 + (i) << 2));
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_16 = mem[3221266275] + 16;
        return (int);
    }
    private int GetCoin(int i)
    {
        var val_16;
        if(i > 6)
        {
                return 0;
        }
        
        var val_1 = 18784548 + (18784548 + (i) << 2);
        if(i == 6)
        {
                18784548 = 18784548 & ((IP) << 18784548);
            18784548 = 18784548 & (((int)IP) >> (18784548 & (IP) << 18784548));
            18784548 = i * 18784548;
            18784548 = 18784548 & (((int)IP) >> 1);
            18784548 = 18784548 & (i << 2);
            18784548 = 18784548 & ((IP) >> 18784548 + (i) << 2);
            18784548 = 18784548 & (((i) << (32-18784548 + (i) << 2)) | ((i) << 18784548 + (i) << 2));
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_16 = mem[3221266275] + 12;
        return (int);
    }
    private int GetSkinId(int i)
    {
        var val_16;
        if(i > 6)
        {
                return 1;
        }
        
        var val_1 = 18783468 + (18783468 + (i) << 2);
        if(i == 6)
        {
                18783468 = 18783468 & ((IP) << 18783468);
            18783468 = 18783468 & (((int)IP) >> (18783468 & (IP) << 18783468));
            18783468 = i * 18783468;
            18783468 = 18783468 & (((int)IP) >> 1);
            18783468 = 18783468 & (i << 2);
            18783468 = 18783468 & ((IP) >> 18783468 + (i) << 2);
            18783468 = 18783468 & (((i) << (32-18783468 + (i) << 2)) | ((i) << 18783468 + (i) << 2));
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_16 = mem[3221266275] + 8;
        return (int);
    }
    private string GetDayName(int i)
    {
        var val_1;
        if(i <= 6)
        {
                val_1 = mem[22291120 + (i) << 2];
            val_1 = 22291120 + (i) << 2;
            return;
        }
        
        val_1 = 22784624;
    }
    private UnityEngine.Sprite GetImgSkin(int i)
    {
        var val_16;
        int val_17;
        if(i > 6)
        {
                return;
        }
        
        var val_1 = 18785320 + (18785320 + (i) << 2);
        if(i == 6)
        {
                18785320 = 18785320 & ((IP) << 18785320);
            18785320 = 18785320 & ((((18785320 & (IP) << 18785320)) << (32-(18785320 & (IP) << 18785320))) | (((18785320 & (IP) << 18785320)) << (18785320 & (IP) << 18785320)));
            mem2[0] = ((18785320 & (IP) << 18785320) & (((18785320 & (IP) << 18785320)) << (32-(18785320 & (IP) << 18785320))) | (((18785320 & (IP) << 18785320)) << (18785320 & (IP) << 18785320))) + IP;
            (((18785320 & (IP) << 18785320) & (((18785320 & (IP) << 18785320)) << (32-(18785320 & (IP) << 18785320))) | (((18785320 & (IP) << 18785320)) << (18785320 & (IP) << 18785320))) + IP) & ((R8) << 2) = ((((18785320 & (IP) << 18785320) & (((18785320 & (IP) << 18785320)) << (32-(18785320 & (IP) << 18785320))) | (((18785320 & (IP) << 18785320)) << (18785320 & (IP) << 18785320))) + IP) & ((R8) << 2)) & (i >> (18785320 + (i) << 2));
            (((18785320 & (IP) << 18785320) & (((18785320 & (IP) << 18785320)) << (32-(18785320 & (IP) << 18785320))) | (((18785320 & (IP) << 18785320)) << (18785320 & (IP) << 18785320))) + IP) & ((R8) << 2) = ((((18785320 & (IP) << 18785320) & (((18785320 & (IP) << 18785320)) << (32-(18785320 & (IP) << 18785320))) | (((18785320 & (IP) << 18785320)) << (18785320 & (IP) << 18785320))) + IP) & ((R8) << 2)) & (((((18785320 & (IP) << 18785320) & (((18785320 & (IP) << 18785320)) << (32-(18785320 & (IP) << 18785320))) | (((18785320 & (IP) << 18785320)) << (18785320 & (IP) << 18785320))) + IP) & ((R8) << 2)) >> 3);
            (((18785320 & (IP) << 18785320) & (((18785320 & (IP) << 18785320)) << (32-(18785320 & (IP) << 18785320))) | (((18785320 & (IP) << 18785320)) << (18785320 & (IP) << 18785320))) + IP) & ((R8) << 2) = ((((18785320 & (IP) << 18785320) & (((18785320 & (IP) << 18785320)) << (32-(18785320 & (IP) << 18785320))) | (((18785320 & (IP) << 18785320)) << (18785320 & (IP) << 18785320))) + IP) & ((R8) << 2)) & (((IP) << (32-3)) | ((IP) << 3));
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_16 = -1073700965;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_17 = mem[mem[3221266275] + 8];
        val_17 = mem[3221266275] + 8;
        if( != 0)
        {
                return val_16.LoadIcon(id:  null);
        }
        
        return val_16.LoadIcon(id:  null);
    }
    private void CheckCollectInDay()
    {
        var val_28;
        UnityEngine.GameObject val_29;
        var val_30;
        var val_31;
        var val_32;
        val_28 = this;
        this.ShowBtnOnHasSkin();
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_43 = 0;
        if((-1073708883.IndexOfDayDaily) > 6)
        {
                return;
        }
        
        label_56:
        string val_4 = System.String.Format(format:  -1610611913, arg0:  536888987);
        this.diamonTxt[val_43].text = -1610611913;
        int val_5 = this.coinTxt[val_43].GetCoin(i:  0);
        string val_6 = System.String.Format(format:  -1610611913, arg0:  536888987);
        this.coinTxt[val_43].text = -1610611913;
        UnityEngine.Sprite val_7 = this.skinImg[val_43].GetImgSkin(i:  0);
        this.skinImg[val_43].sprite = this.skinImg[val_43];
        if(val_43 != 6)
        {
            goto label_12;
        }
        
        UnityEngine.GameObject val_32 = this.skinDay[6];
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_33 = this.GetSkinId(i:  6);
        val_33 = (-1073708883.CheckSkinUnlock(id:  val_33)) ^ 1;
        val_32.SetActive(value:  val_33);
        if((val_32.GetCoin(i:  6)) > 0)
        {
                0 = 1;
        }
        
        this.coinDay[6].SetActive(value:  true);
        val_29 = this.diamonDay[6];
        val_30 = 6;
        goto label_22;
        label_12:
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        UnityEngine.GameObject val_35 = this.skinDay[val_43];
        if((-1073708883.CheckSkinUnlock(id:  this.GetSkinId(i:  0))) == false)
        {
            goto label_27;
        }
        
        val_35.SetActive(value:  false);
        if((this.coinDay[val_43].GetCoin(i:  0)) > 0)
        {
                0 = 1;
        }
        
        this.coinDay[val_43].SetActive(value:  true);
        val_30 = val_43;
        val_29 = this.diamonDay[val_43];
        label_22:
        if((this.diamonDay[val_43].GetDiamon(i:  0)) > 0)
        {
                val_31 = 1;
        }
        
        goto label_34;
        label_27:
        val_35.SetActive(value:  true);
        this.coinDay[val_43].SetActive(value:  false);
        val_31 = 0;
        label_34:
        this.diamonDay[val_43].SetActive(value:  false);
        string val_17 = this.dayTxt[val_43].GetDayName(i:  0);
        this.dayTxt[val_43].text = this.dayTxt[val_43];
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        if(val_43 < (-1073708883.IndexOfDayDaily))
        {
                0 = 1;
        }
        
        this.blackObject[val_43].SetActive(value:  true);
        System.DateTime val_20 = System.DateTime.Now;
        object val_23 = AFramework.ManualSingletonMono<System.Object>.I;
        val_32 = 0;
        if(val_43 == (-1073708883.IndexOfDayDaily))
        {
                object val_25 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_27 = (-1073708883.DayClamReward) - (this.diamonTxt[val_43].GetDiamon(i:  0).DayOfYear);
            if((-1073708883) != 0)
        {
                val_32 = 1;
        }
        
        }
        
        this.canGetObj[val_43].SetActive(value:  true);
        val_43 = val_43 + 1;
        val_28 = val_28;
        if(val_43 != 7)
        {
            goto label_56;
        }
    
    }
    public void ClaimClick()
    {
        var val_11;
        UnityEngine.GameObject val_1 = this.listBtn.gameObject;
        this.listBtn.SetActive(value:  false);
        this.CancelInvoke(methodName:  -1610604589);
        this.ClaimDaillyReward(x2:  1);
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_11 = -1073708883.IndexOfDayDaily;
        }
        else
        {
                val_11 = -1073708883.IndexOfDayDaily;
        }
        
        -1073708883.IndexOfDayDaily = val_11 + 1;
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        System.DateTime val_7 = System.DateTime.Now;
        -1073708883.DayClamReward = ???.DayOfYear;
        this.CheckCollectInDay();
        System.Collections.IEnumerator val_9 = this.Close();
        UnityEngine.Coroutine val_10 = this.StartCoroutine(routine:  835232272);
    }
    public void ClaimX2Click()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  835348368, method:  new IntPtr(1610682033));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  8);
    }
    private void ShowDaily()
    {
        this.CheckCollectInDay();
    }
    private void ClaimDaillyReward(int x2)
    {
        PopDailyRewardManager val_59;
        int val_60;
        int val_61;
        int val_62;
        int val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        var val_74;
        var val_75;
        var val_76;
        val_59 = this;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_2 = -1073708883.IndexOfDayDaily;
        val_60 = val_2;
        int val_3 = val_2.GetCoin(i:  val_2);
        val_61 = val_3 * x2;
        int val_4 = val_3.GetDiamon(i:  val_60);
        val_62 = val_4 * x2;
        int val_5 = val_4.GetSkinId(i:  val_60);
        val_63 = val_5;
        if((val_5.GetSkinId(i:  val_60)) == 0)
        {
            goto label_2;
        }
        
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CheckSkinUnlock(id:  this.GetSkinId(i:  val_60))) == false)
        {
            goto label_4;
        }
        
        val_59 = val_59;
        label_2:
        val_60 = 22740800;
        if(val_61 < 1)
        {
            goto label_5;
        }
        
        object val_10 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_6;
        }
        
        val_64 = -1073708883.Coin;
        goto label_7;
        label_4:
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        val_59 = val_59;
        if(val_62 >= 1)
        {
            goto label_8;
        }
        
        if(val_61 < 1)
        {
            goto label_9;
        }
        
        -1073708883.UnlockSkin(id:  val_63);
        object val_13 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.SkinSelectedID = val_63;
        object val_14 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_12;
        }
        
        val_65 = -1073708883.Coin;
        goto label_13;
        label_6:
        val_64 = -1073708883.Coin;
        label_7:
        -1073708883.Coin = val_64 + val_61;
        WorldTimeAPI val_18 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_19 = val_61.ToString();
        string val_20 = -1610602435(-1610602435) + 835560328 + -1610612397(-1610612397);
        -1073700885.Show(mess:  -1610602435, callBack:  0);
        val_62 = val_62;
        label_5:
        if(val_62 < 1)
        {
            goto label_15;
        }
        
        object val_21 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_66 = -1073708883.Diamond;
            val_60 = val_62;
        }
        else
        {
                val_66 = -1073708883.Diamond;
            val_60 = val_62;
        }
        
        -1073708883.Diamond = val_66 + val_60;
        WorldTimeAPI val_25 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_26 = val_62.ToString();
        string val_27 = -1610602435(-1610602435) + 835560324 + -1610612433(-1610612433);
        val_67 = -1610602435;
        goto label_19;
        label_8:
        -1073708883.UnlockSkin(id:  val_63);
        object val_28 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.SkinSelectedID = val_63;
        object val_29 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_22;
        }
        
        val_68 = -1073708883.Coin;
        goto label_23;
        label_9:
        -1073708883.UnlockSkin(id:  val_63);
        object val_31 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.SkinSelectedID = val_63;
        if(val_62 < 1)
        {
            goto label_26;
        }
        
        object val_32 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_27;
        }
        
        val_69 = -1073708883.Diamond;
        goto label_28;
        label_12:
        val_65 = -1073708883.Coin;
        label_13:
        -1073708883.Coin = val_65 + val_61;
        val_60 = 22742348;
        WorldTimeAPI val_36 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_70 = -1073700885;
        string val_37 = val_61.ToString();
        val_71;
        val_72 = -1610602435;
        val_73 = 22777556;
        goto label_29;
        label_22:
        val_68 = -1073708883.Coin;
        label_23:
        -1073708883.Coin = val_68 + val_61;
        val_61 = 22742348;
        WorldTimeAPI val_40 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_41 = val_61.ToString();
        val_63 = 4.03822E-38f;
        string val_42 = -1610602435(-1610602435) + 835560328 + -1610612397(-1610612397);
        -1073700885.Show(mess:  -1610602435, callBack:  0);
        object val_43 = AFramework.ManualSingletonMono<System.Object>.I;
        val_60 = -1073708883.Diamond.GetDiamon(i:  val_60);
        -1073708883.Diamond = val_60;
        WorldTimeAPI val_46 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_47 = val_62.ToString();
        string val_48 = -1610602435(-1610602435) + 835560324 + -1610612433(-1610612433);
        -1073700885.Show(mess:  -1610602435, callBack:  0);
        val_74 = -1073700885;
        WorldTimeAPI val_49 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_59 = val_59;
        goto label_34;
        label_26:
        WorldTimeAPI val_50 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_75 = -1073700885;
        val_76 = 22796436;
        goto label_36;
        label_27:
        val_69 = -1073708883.Diamond;
        label_28:
        -1073708883.Diamond = val_69 + val_62;
        val_60 = 22742348;
        WorldTimeAPI val_53 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_70 = -1073700885;
        string val_54 = val_62.ToString();
        val_71;
        val_72 = -1610602435;
        val_73 = 22777484;
        label_29:
        string val_55 = -1610602435(-1610602435) + 835560324 + -1610612433(-1610612433);
        val_70.Show(mess:  -1610602435, callBack:  0);
        WorldTimeAPI val_56 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        label_34:
        val_75 = val_60;
        val_76 = 22796440;
        label_36:
        label_19:
        val_75.Show(mess:  -1610602949, callBack:  0);
        label_15:
        GameTool.EventDispatcherExtension.PostEvent(sender:  835572368, eventID:  10);
        GameTool.EventDispatcherExtension.PostEvent(sender:  835572368, eventID:  8);
    }
    private System.Collections.IEnumerator Close()
    {
        536900407 = new PopDailyRewardManager.<Close>d__29(<>1__state:  0);
        mem[536900423] = this;
    }
    private void CloseEvent()
    {
        var val_3;
        536882991 = new System.Action(object:  835796368, method:  new IntPtr(1610682021));
        System.Delegate val_2 = System.Delegate.Remove(source:  R5 + 44, value:  536882991);
        val_3 = R5 + 44;
        if(val_3 != 0)
        {
                if(val_3 == 536882991)
        {
            goto label_4;
        }
        
        }
        
        val_3 = 0;
        label_4:
        mem2[0] = val_3;
        goto typeof(PopDailyRewardManager).__il2cppRuntimeField_E4;
    }
    private void ShowBtn()
    {
        UnityEngine.GameObject val_1 = this.claimButton.gameObject;
        this.claimButton.SetActive(value:  true);
    }
    public PopDailyRewardManager()
    {
    
    }
    private void <Start>b__15_0()
    {
        this.ClaimClick();
    }
    private void <Start>b__15_1()
    {
        this.ClaimClick();
    }
    private void <Start>b__15_2()
    {
        this.ClaimX2Click();
    }
    private void <ClaimX2Click>b__26_0(bool success)
    {
        int val_14;
        var val_15;
        val_14 = 23000817;
        if(success == false)
        {
                return;
        }
        
        this.ClaimDaillyReward(x2:  2);
        UnityEngine.GameObject val_1 = this.getstkinBtn.gameObject;
        this.getstkinBtn.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.claimButton.gameObject;
        this.claimButton.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.claimX2Button.gameObject;
        this.claimX2Button.SetActive(value:  false);
        this.CancelInvoke(methodName:  -1610604589);
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_15 = -1073708883.IndexOfDayDaily;
        }
        else
        {
                val_15 = -1073708883.IndexOfDayDaily;
        }
        
        -1073708883.IndexOfDayDaily = val_15 + 1;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        System.DateTime val_9 = System.DateTime.Now;
        val_14 = ???.DayOfYear;
        -1073708883.DayClamReward = val_14;
        this.CheckCollectInDay();
        UnityEngine.GameObject val_11 = this.listBtn.gameObject;
        this.listBtn.SetActive(value:  false);
        System.Collections.IEnumerator val_12 = this.Close();
        UnityEngine.Coroutine val_13 = this.StartCoroutine(routine:  836492944);
    }

}
