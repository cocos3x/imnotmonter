using UnityEngine;
public class GachaPopup : BaseUIMenu
{
    // Fields
    private TMPro.TextMeshProUGUI txt_CountTimeFree;
    private TMPro.TextMeshProUGUI txt_valueReward;
    private UnityEngine.GameObject objTimeFree;
    private UnityEngine.UI.Button btn_Free;
    private UnityEngine.UI.Button btn_AdsRoll;
    private UnityEngine.UI.Button btn_Close;
    private UnityEngine.UI.Button btn_x2Btn;
    private UnityEngine.UI.Button btn_nothanksBtn;
    private Spine.Unity.SkeletonGraphic skeGacha;
    private UnityEngine.Animator anim_BallGacha;
    private UnityEngine.GameObject rewardPanel;
    private UnityEngine.UI.Image img_iconReward;
    private float timeRemaining;
    private int indexReward;
    private int[] listType;
    private int[] listValue;
    
    // Methods
    private void Start()
    {
        var val_9;
        UnityEngine.Events.UnityAction val_10;
        val_9 = 22716284;
        536896275 = new UnityEngine.Events.UnityAction(object:  757350032, method:  new IntPtr(1610680913));
        this.btn_Free.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  757350032, method:  new IntPtr(1610680915));
        this.btn_AdsRoll.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  757350032, method:  new IntPtr(1610680917));
        this.btn_x2Btn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  757350032, method:  new IntPtr(1610680919));
        this.btn_nothanksBtn.m_OnClick.AddListener(call:  536896275);
        val_10 = 536896275;
        val_10 = new UnityEngine.Events.UnityAction(object:  757350032, method:  new IntPtr(1610680921));
        this.btn_Close.m_OnClick.AddListener(call:  536896275);
        if(this.listType != null)
        {
                this.listType = this.listValue;
            return;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        this.listValue = mem[3221266283] + 12;
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        this.listType = mem[3221266283] + 16;
    }
    private void OnEnable()
    {
        this.CheckTimeSpin();
        this.SetAnimGacha(name:  -1610600013, loop:  true, _callBack:  0);
        this.rewardPanel.SetActive(value:  false);
        WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
        -1073700805.MoveCharAndHuggyInGacha();
    }
    private void RollAds()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  757696912, method:  new IntPtr(1610680923));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  11);
    }
    private void Roll()
    {
        this.btn_Close.interactable = false;
        UnityEngine.GameObject val_1 = this.btn_Free.gameObject;
        this.btn_Free.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.btn_AdsRoll.gameObject;
        this.btn_AdsRoll.SetActive(value:  false);
        536882991 = new System.Action(object:  757821200, method:  new IntPtr(1610680925));
        this.SetAnimGacha(name:  -1610598595, loop:  false, _callBack:  536882991);
    }
    private void ResetGacha()
    {
        this.anim_BallGacha.Play(stateName:  -1610609977, layer:  0, normalizedTime:  null);
        this.CheckTimeSpin();
    }
    private void ShowPanelReward()
    {
        this.rewardPanel.SetActive(value:  true);
        this.SetUIReward();
    }
    private void CheckTimeCompletedGacha()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        bool val_2 = System.String.op_Equality(a:  mem[3221258437] + 76, b:  -1610612735);
        if(val_2 != true)
        {
                if(val_2 > false)
        {
                return;
        }
        
        }
        
        System.DateTime val_3 = System.DateTime.Now;
        string val_4 = ???.ToString();
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.TimeSpin = 758173840;
    }
    private void SetAnimGacha(string name, bool loop, System.Action _callBack)
    {
        536899139 = new GachaPopup.<>c__DisplayClass23_0();
        mem[536899147] = _callBack;
        Spine.AnimationState val_2 = this.skeGacha.AnimationState;
        Spine.TrackEntry val_3 = this.skeGacha.SetAnimation(trackIndex:  0, animationName:  name, loop:  loop);
        536897929 = new AnimationState.TrackEntryDelegate(object:  536899139, method:  new IntPtr(1610680931));
        this.skeGacha.add_Complete(value:  536897929);
    }
    private void CheckTimeSpin()
    {
        var val_6;
        var val_7;
        var val_17;
        var val_18;
        this.btn_Close.interactable = true;
        val_17 = 22740800;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((System.String.op_Equality(a:  mem[3221258437] + 76, b:  -1610612735)) == false)
        {
            goto label_4;
        }
        
        UnityEngine.GameObject val_3 = this.btn_Free.gameObject;
        if(this.btn_Free != 0)
        {
            goto label_16;
        }
        
        goto label_16;
        label_4:
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        System.DateTime val_5 = System.DateTime.Parse(s:  758451072);
        val_17 = val_7;
        System.DateTime val_8 = System.DateTime.Now;
        System.TimeSpan val_9 = Subtract(value:  new System.DateTime() {dateData = 1152921509660265352});
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        double val_11 = val_6.TotalSeconds;
        var val_17 = 3600;
        val_17 = (mem[3221266283] + 8) * val_17;
        this.timeRemaining = (float)val_17 - S0;
        UnityEngine.GameObject val_13 = this.btn_Free.gameObject;
        if(this.btn_Free <= 0)
        {
            goto label_16;
        }
        
        this.btn_Free.SetActive(value:  false);
        UnityEngine.GameObject val_14 = this.btn_AdsRoll.gameObject;
        this.btn_AdsRoll.SetActive(value:  true);
        val_18 = 1;
        goto label_20;
        label_16:
        this.btn_Free.SetActive(value:  true);
        UnityEngine.GameObject val_15 = this.btn_AdsRoll.gameObject;
        this.btn_AdsRoll.SetActive(value:  false);
        val_18 = 0;
        label_20:
        this.objTimeFree.SetActive(value:  false);
        this.StopAllCoroutines();
        UnityEngine.Coroutine val_16 = this.StartCoroutine(methodName:  -1610603445);
    }
    private System.Collections.IEnumerator TimeCountDownSpin()
    {
        536899141 = new GachaPopup.<TimeCountDownSpin>d__25(<>1__state:  0);
        mem[536899157] = this;
    }
    private void SetTime()
    {
        float val_6 = 3600f;
        float val_7 = this.timeRemaining;
        val_6 = val_7 / val_6;
        float val_9 = 60f;
        val_7 = ((float)UnityEngine.Mathf.FloorToInt(f:  val_6)) * val_9;
        float val_2 = val_7 * val_9;
        float val_8 = this.timeRemaining;
        val_8 = val_8 - val_2;
        val_9 = val_8 / val_9;
        int val_3 = UnityEngine.Mathf.FloorToInt(f:  val_9);
        float val_10 = this.timeRemaining;
        val_10 = val_10 - val_2;
        int val_4 = UnityEngine.Mathf.FloorToInt(f:  val_10);
        string val_5 = System.String.Format(format:  -1610597101, arg0:  536893745, arg1:  536893745, arg2:  536893745);
        this.txt_CountTimeFree.text = -1610597101;
    }
    private void ClosePanel()
    {
        WinPopup val_1 = AFramework.SingletonUI<WinPopup>.I;
        -1073700811.ShowDeco(value:  true);
        AFramework.UI.BaseUIMenu val_2 = AFramework.UI.CanvasManager.Push(identifier:  -1610605291, initParams:  null);
        WinPopup val_3 = AFramework.SingletonUI<WinPopup>.I;
        -1073700805.ShowMainSkin(IsShowPlayer:  true, playerSit:  true, _callBack:  0);
    }
    private int Random()
    {
        var val_5;
        var val_6;
        var val_7;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_5 = 0;
        int val_2 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  100);
        float val_4 = 0f;
        val_6 = (mem[3221266283] + 20) + 16;
        goto label_3;
        label_11:
        if(val_2 != val_5)
        {
                if(val_2 <= val_5)
        {
                if((mem[3221266283] + 20 + 12) <= val_5)
        {
                val_7 = mem[(mem[3221266283] + 20 + 16)];
            val_7 = val_6;
        }
        
            float val_3 = val_4 + val_7;
            if((mem[3221266283] + 20 + 12) > val_5)
        {
                return 0;
        }
        
        }
        
            if((mem[3221266283] + 20 + 12) <= val_5)
        {
                val_7 = mem[(mem[3221266283] + 20 + 16)];
            val_7 = val_6;
        }
        
            val_4 = val_4 + val_7;
        }
        
        val_6 = val_6 + 4;
        val_5 = 1;
        label_3:
        if(val_5 < (mem[3221266283] + 20 + 12))
        {
            goto label_11;
        }
        
        return 0;
    }
    public void GetX2RewardClick()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  759059984, method:  new IntPtr(1610680927));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  5);
    }
    public void GetRewardClick()
    {
        System.Int32[] val_24;
        var val_25;
        System.Int32[] val_26;
        var val_27;
        string val_29;
        var val_30;
        var val_31;
        val_24 = this.listType;
        int val_23 = val_24[this.indexReward];
        if(val_23 <= 3)
        {
                var val_1 = 18610460 + (18610460 + (this.listType[this.indexReward][0]) << 2);
            if(val_23 == 3)
        {
                18610460 + (this.listType[this.indexReward][0]) << 2 = (18610460 + (this.listType[this.indexReward][0]) << 2) & ((18610460 + (this.listType[this.indexReward][0]) << 2) << (18610460 + (this.listType[this.indexReward][0]) << 2));
            18610460 + (this.listType[this.indexReward][0]) << 2 = (18610460 + (this.listType[this.indexReward][0]) << 2) & (((R4) << (32-1)) | ((R4) << 1));
            18610460 + (this.listType[this.indexReward][0]) << 2 = (18610460 + (this.listType[this.indexReward][0]) << 2) & (((R8) << (32-5)) | ((R8) << 5));
        }
        
            object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
            System.Int32[] val_25 = this.listValue;
            val_25 = mem[mem[3221258437] + 16];
            val_25 = mem[3221258437] + 16;
            val_25 = val_25[this.indexReward] + val_25;
            mem2[0] = val_25;
            -1073708883.Save();
            WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_26 = this.listValue;
            val_27 = -1073700885;
            string val_19 = ToString();
            val_29 = ;
            val_30 = -1610602435;
            val_31 = 22777556;
            string val_20 = -1610602435(-1610602435) + val_29 + -1610612397(-1610612397);
            val_24 = val_30;
            val_27.Show(mess:  -1610602435, callBack:  0);
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  759360400, eventID:  8);
        this.rewardPanel.SetActive(value:  false);
        this.ResetGacha();
    }
    private void OnApplicationFocus(bool focus)
    {
        if(focus == false)
        {
                return;
        }
        
        this.CheckTimeSpin();
    }
    private void SetUIReward()
    {
        string val_1 = this.listValue[this.indexReward][16].ToString();
        this.txt_valueReward.text = this.listValue[this.indexReward][16];
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(this.listType[this.indexReward] == 0)
        {
                24 = 20;
        }
        
        this.img_iconReward.sprite = mem[3221266351];
    }
    public GachaPopup()
    {
    
    }
    private void <Start>b__16_0()
    {
        this.Roll();
    }
    private void <Start>b__16_1()
    {
        this.RollAds();
    }
    private void <Start>b__16_2()
    {
        this.GetX2RewardClick();
    }
    private void <Start>b__16_3()
    {
        this.GetRewardClick();
    }
    private void <Start>b__16_4()
    {
        this.ClosePanel();
    }
    private void <RollAds>b__18_0(bool ss)
    {
        if(ss == false)
        {
                return;
        }
        
        this.Roll();
    }
    private void <Roll>b__19_0()
    {
        this.SetAnimGacha(name:  -1610600013, loop:  true, _callBack:  0);
        this.anim_BallGacha.Play(stateName:  -1610609975, layer:  0, normalizedTime:  null);
        this.CheckTimeCompletedGacha();
        this.indexReward = this.Random();
        this.Invoke(methodName:  -1610604575, time:  null);
    }
    private void <GetX2RewardClick>b__29_0(bool success)
    {
        System.Int32[] val_21;
        var val_22;
        System.Int32[] val_23;
        var val_24;
        int val_25;
        var val_26;
        var val_27;
        var val_28;
        val_21 = 23000500;
        if(success == false)
        {
                return;
        }
        
        val_21 = this.listType;
        int val_21 = val_21[this.indexReward];
        if(val_21 <= 3)
        {
                var val_1 = 18612884 + (18612884 + (this.listType[this.indexReward][0]) << 2);
            if(val_21 == 3)
        {
                18612884 + (this.listType[this.indexReward][0]) << 2 = (18612884 + (this.listType[this.indexReward][0]) << 2) & ((18612884 + (this.listType[this.indexReward][0]) << 2) << (18612884 + (this.listType[this.indexReward][0]) << 2));
            18612884 + (this.listType[this.indexReward][0]) << 2 = (18612884 + (this.listType[this.indexReward][0]) << 2) & (((R4) << (32-1)) | ((R4) << 1));
            18612884 + (this.listType[this.indexReward][0]) << 2 = (18612884 + (this.listType[this.indexReward][0]) << 2) & (((R4) << (32-3)) | ((R4) << 3));
            18612884 + (this.listType[this.indexReward][0]) << 2 = (18612884 + (this.listType[this.indexReward][0]) << 2) & ((((((18612884 + (this.listType[this.indexReward][0]) << 2 & (18612884 + (this.listType[this.indexReward][0]) << 2) << 18612884 + (this.listType[this.indexReward][0]) << 2) & ((R4) << (32-1)) | ((R4) << ) << (32-R2)) | (((((18612884 + (this.listType[this.indexReward][0]) << 2 & (18612884 + (this.listType[this.indexReward][0]) << 2) << 18612884 + (this.listType[this.indexReward][0]) << 2) & ((R4) << (32-1)) | ((R4) << ) << R2));
        }
        
            object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
            System.Int32[] val_23 = this.listValue;
            val_22 = mem[mem[3221258437] + 16];
            val_22 = mem[3221258437] + 16;
            val_23 = val_22 + (val_23[this.indexReward] << 1);
            mem2[0] = val_23;
            -1073708883.Save();
            WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_23 = this.listValue;
            val_24 = -1073700885;
            val_25 = val_23[this.indexReward];
             =  << 1;
            string val_18 = ToString();
            val_26;
            val_27 = -1610602435;
            val_28 = 22777556;
            string val_19 = -1610602435(-1610602435) + 761129228 + -1610612397(-1610612397);
            val_21 = val_27;
            val_24.Show(mess:  -1610602435, callBack:  0);
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  761141264, eventID:  8);
        this.rewardPanel.SetActive(value:  false);
        this.ResetGacha();
    }

}
