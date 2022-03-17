using UnityEngine;
public class SpinManager : BaseUIMenu
{
    // Fields
    private readonly int fullCircles;
    private readonly System.Collections.Generic.List<int> sectorsAngles;
    private UnityEngine.UI.Button btnSpin;
    private UnityEngine.UI.Button btnSpinAds;
    private UnityEngine.GameObject Circle;
    private UnityEngine.GameObject che;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.Sprite coinbe;
    private UnityEngine.Sprite cointo;
    private float currentLerpRotationTime;
    private UnityEngine.Sprite diamon;
    private float finalAngle;
    private UnityEngine.UI.Button getButton;
    private UnityEngine.UI.Button getX2Button;
    private UnityEngine.UI.Image imgReward;
    private int index;
    private bool isStarted;
    private bool justFreeSpin;
    private ItemSpin[] listItemSpin;
    private int[] listType;
    private int[] listValue;
    private UnityEngine.UI.Button nothankButton;
    private UnityEngine.GameObject RewardPanel;
    private UnityEngine.GameObject x2Btn;
    private UnityEngine.GameObject nothanksBtn;
    private UnityEngine.GameObject getSkinBtn;
    private UnityEngine.GameObject lisBtn;
    private UnityEngine.Sprite skin1;
    private UnityEngine.Sprite skin2;
    private UnityEngine.UI.Image skinReward;
    private float startAngle;
    private float timeRemaining;
    private TMPro.TextMeshProUGUI txtNumberSpin;
    private TMPro.TextMeshProUGUI txtReward;
    
    // Methods
    private void OnEnable()
    {
        this.CheckTimeSpin();
        this.ScaleUp();
        this.che.SetActive(value:  false);
        this.lisBtn.SetActive(value:  true);
        this.SetDataSpin();
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        float val_2 = -1073708883.StartAngleSpin;
        this.startAngle = -2.007854f;
        UnityEngine.Transform val_3 = this.Circle.transform;
        this.Circle.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = this.startAngle};
    }
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  845998736, method:  new IntPtr(1610682207));
        this.btnSpin.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  845998736, method:  new IntPtr(1610682209));
        this.btnSpinAds.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  845998736, method:  new IntPtr(1610682211));
        this.closeButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  845998736, method:  new IntPtr(1610682213));
        this.nothankButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  845998736, method:  new IntPtr(1610682215));
        this.getX2Button.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  845998736, method:  new IntPtr(1610682217));
        this.getButton.m_OnClick.AddListener(call:  536896275);
    }
    private void CheckTimeSpin()
    {
        var val_8;
        var val_9;
        var val_21;
        var val_22;
        TMPro.TextMeshProUGUI val_23;
        var val_25;
        this.RewardPanel.SetActive(value:  false);
        val_21 = 22740800;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_2 = -1073708883.TimeSpin;
        if((System.String.op_Equality(a:  -1073708883, b:  -1610612735)) == false)
        {
            goto label_3;
        }
        
        UnityEngine.GameObject val_4 = this.btnSpin.gameObject;
        if(this.btnSpin != 0)
        {
            goto label_17;
        }
        
        goto label_17;
        label_3:
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_6 = -1073708883.TimeSpin;
        System.DateTime val_7 = System.DateTime.Parse(s:  846176504);
        val_21 = val_9;
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_22 = -1073700851;
        if(mem[3221266457] == false)
        {
            goto label_11;
        }
        
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_22 = -1073700851;
        System.DateTime val_12 = GetCurrentDateTime();
        System.TimeSpan val_13 = Subtract(value:  new System.DateTime() {dateData = 1152921509747990784});
        WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        double val_15 = val_8.TotalSeconds;
        var val_21 = 3600;
        val_21 = (mem[3221266283] + 8) * val_21;
        this.timeRemaining = (float)val_21 - S0;
        UnityEngine.GameObject val_17 = this.btnSpin.gameObject;
        if(this.btnSpin <= 0)
        {
            goto label_17;
        }
        
        this.btnSpin.SetActive(value:  false);
        UnityEngine.GameObject val_18 = this.btnSpinAds.gameObject;
        this.btnSpinAds.SetActive(value:  true);
        goto label_20;
        label_17:
        this.btnSpin.SetActive(value:  true);
        UnityEngine.GameObject val_19 = this.btnSpinAds.gameObject;
        this.btnSpinAds.SetActive(value:  false);
        val_23 = this.txtNumberSpin;
        val_25 = 22792244;
        goto label_24;
        label_11:
        val_23 = this.txtNumberSpin;
        val_25 = 22790144;
        label_24:
        val_23.text = -1610606097;
        label_20:
        this.StopAllCoroutines();
        UnityEngine.Coroutine val_20 = this.StartCoroutine(methodName:  -1610603445);
    }
    private void RestartTimeSpin()
    {
        var val_16;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(mem[3221266457] == false)
        {
            goto label_2;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        System.DateTime val_3 = GetCurrentDateTime();
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        val_16 = -1073708883;
        goto label_4;
        label_2:
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_6 = -1073708883.TimeSpin;
        if((System.String.op_Equality(a:  -1073708883, b:  -1610612735)) == false)
        {
            goto label_6;
        }
        
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        val_16 = -1073708883;
        System.DateTime val_9 = System.DateTime.Now;
        label_4:
        string val_10 = ???.ToString();
        val_16.TimeSpin = 846329480;
        label_17:
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_16 = mem[3221266283] + 8;
        val_16 = val_16 * 3600;
        this.timeRemaining = (float)val_16;
        UnityEngine.GameObject val_12 = this.btnSpin.gameObject;
        this.btnSpin.SetActive(value:  false);
        UnityEngine.GameObject val_13 = this.btnSpinAds.gameObject;
        this.btnSpinAds.SetActive(value:  true);
        GameTool.EventDispatcherExtension.PostEvent(sender:  846341520, eventID:  8);
        System.Collections.IEnumerator val_14 = this.TimeCountDownSpin();
        UnityEngine.Coroutine val_15 = this.StartCoroutine(routine:  846341520);
        return;
        label_6:
        this.txtNumberSpin.text = -1610605047;
        goto label_17;
    }
    private System.Collections.IEnumerator TimeCountDownSpin()
    {
        536901391 = new SpinManager.<TimeCountDownSpin>d__38(<>1__state:  0);
        mem[536901407] = this;
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
        this.txtNumberSpin.text = -1610597101;
    }
    private void CheckViewObjSpin()
    {
        this.lisBtn.SetActive(value:  true);
        if(this.justFreeSpin != false)
        {
                this.justFreeSpin = false;
            this.RestartTimeSpin();
            return;
        }
        
        UnityEngine.GameObject val_1 = this.btnSpin.gameObject;
        this.btnSpin.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.btnSpinAds.gameObject;
        this.btnSpinAds.SetActive(value:  true);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(mem[3221266457] != false)
        {
                UnityEngine.GameObject val_4 = this.txtNumberSpin.gameObject;
            this.txtNumberSpin.SetActive(value:  true);
            return;
        }
        
        this.txtNumberSpin.text = -1610606097;
    }
    private void Update()
    {
        float val_9;
        float val_10;
        float val_11;
        if(this.isStarted == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        uint val_9 = 0;
        val_9 = this.currentLerpRotationTime + val_9;
        this.currentLerpRotationTime = val_9;
        if(this.isStarted <= false)
        {
            goto label_2;
        }
        
        val_9 = this.finalAngle;
        goto label_3;
        label_2:
        UnityEngine.Transform val_2 = this.Circle.transform;
        UnityEngine.Vector3 val_3 = eulerAngles;
        val_10 = this.finalAngle;
        if(this.Circle != 0)
        {
            goto label_6;
        }
        
        label_3:
        this.isStarted = false;
        this.currentLerpRotationTime = 10f;
        this.startAngle = val_10;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.StartAngleSpin = val_10;
        this.Invoke(methodName:  -1610604571, time:  val_10);
        val_11 = this.finalAngle;
        label_6:
        float val_10 = this.currentLerpRotationTime;
        val_10 = val_10 / 10f;
        val_10 = val_10 * (val_10 * val_10);
        val_10 = val_10 * 10f;
        float val_7 = UnityEngine.Mathf.Lerp(a:  val_11, b:  val_3.y, t:  val_10);
        UnityEngine.Transform val_8 = this.Circle.transform;
        this.Circle.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = this.startAngle};
    }
    private void ScaleUp()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        Weight val_2 = this.GetComponent<Weight>();
        mem[1152921509748785444] = this;
    }
    private System.Collections.IEnumerator ShowNothanks()
    {
        536901389 = new SpinManager.<ShowNothanks>d__43(<>1__state:  0);
        mem[536901405] = this;
    }
    private void SetDataSpin()
    {
        var val_18;
        var val_19;
        ItemSpin val_20;
        var val_21;
        var val_22;
        val_18 = this;
        if(this.listType != null)
        {
                val_19 = val_18;
            this.listType = this.listValue;
            goto label_1;
        }
        
        val_20 = 22742128;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_19 = val_18;
        this.listValue = mem[3221266283] + 12;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        this.listType = mem[3221266283] + 16;
        label_1:
        val_21 = 0;
        goto label_6;
        label_33:
        string val_18 = mem[mem[3221266283] + 12 + 12];
        val_18 = val_18 + 16;
        string val_3 = val_18.ToString();
        string val_4 = -1610611917(-1610611917) + val_18;
        val_22 = -1610611917;
        if((mem[mem[3221266283] + 16 + 12] + 16) == 2)
        {
                object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
            if((-1073708883.CheckSkinUnlock(id:  12)) != false)
        {
                WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            string val_8 = mem[3221266283] + 24;
            string val_9 = val_8.ToString();
            string val_10 = -1610611917(-1610611917) + val_8;
            val_22 = -1610611917;
        }
        else
        {
                val_22 = -1610604529;
        }
        
        }
        
        if((mem[mem[3221266283] + 16 + 12] + 16) == 3)
        {
                object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
            if((-1073708883.CheckSkinUnlock(id:  16)) != false)
        {
                WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            string val_14 = mem[3221266283] + 24;
            string val_15 = val_14.ToString();
            string val_16 = -1610611917(-1610611917) + val_14;
            val_22 = -1610611917;
        }
        else
        {
                val_22 = -1610604529;
        }
        
        }
        
        val_20 = this.listItemSpin[val_21];
        UnityEngine.Sprite val_17 = this.GetImgIcon(type:  mem[mem[3221266283] + 16 + 12] + 16, valua:  mem[mem[3221266283] + 12 + 12] + 16);
        val_20.SetData(_img:  847346704, _amount:  -1610604529, showtext:  true);
        val_21 = 1;
        val_19 = 1152921509749161084;
        val_18 = val_18;
        label_6:
        if(val_21 < val_20)
        {
            goto label_33;
        }
    
    }
    private UnityEngine.Sprite GetImgIcon(int type, int valua = 1)
    {
        UnityEngine.Sprite val_6;
        if(type <= 3)
        {
                var val_1 = 18365704 + (18365704 + (type) << 2);
            if(type == 3)
        {
                18365704 = 18365704;
            18365704 = 18365704;
            18365704 = 18365704 & ((R8) >> 32);
            18365704 = 18365704 & (((R8) << (32-as. 
            
        
        
        
        
        
           
        )) | ((R8) << as. 
            
        
        
        
        
        
           
        ));
        }
        
            if(valua >= 1000)
        {
                val_6 = this.cointo;
            return;
        }
        
        }
        
        val_6 = this.coinbe;
    }
    public void Spin()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610598087, volume:  null);
        this.currentLerpRotationTime = 0f;
        this.che.SetActive(value:  true);
        this.index = this.che.Random();
        string val_3 = this.index.ToString();
        string val_4 = -1610607439(-1610607439) + 847734636;
        UnityEngine.Debug.Log(message:  -1610607439);
        if((-1610607439) <= this.index)
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + (this.index << 2);
        if(val_8 <= this.index)
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + (this.index << 2);
        int val_10 = this.fullCircles;
        val_10 = val_10 * 360;
        float val_11 = (float)UnityEngine.Random.Range(minInclusive:  ((0 + (this.index) << 2) + 16) - 12, maxExclusive:  ((0 + (this.index) << 2) + 16) + 12);
        this.isStarted = true;
        val_11 = val_11 + (float)val_10;
        this.finalAngle = -val_11;
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
    private void ShowReward()
    {
        UnityEngine.Sprite val_25;
        UnityEngine.UI.Image val_26;
        TMPro.TextMeshProUGUI val_27;
        this.che.SetActive(value:  false);
        this.lisBtn.SetActive(value:  false);
        int val_24 = this.listType[this.index];
        if(val_24 > 3)
        {
            goto label_5;
        }
        
        var val_1 = 18367008 + (18367008 + (this.listType[this.index][0]) << 2);
        if(val_24 == 3)
        {
                18367008 + (this.listType[this.index][0]) << 2 = (18367008 + (this.listType[this.index][0]) << 2) & ((18367008 + (this.listType[this.index][0]) << 2) << (18367008 + (this.listType[this.index][0]) << 2));
            18367008 + (this.listType[this.index][0]) << 2 = (18367008 + (this.listType[this.index][0]) << 2) & ((18367008 + (this.listType[this.index][0]) << 2) >> 32);
            18367008 + (this.listType[this.index][0]) << 2 = (18367008 + (this.listType[this.index][0]) << 2) & ((R8) << 18367008);
            18367008 + (this.listType[this.index][0]) << 2 = (18367008 + (this.listType[this.index][0]) << 2) & (((int)IP) >> 18367008);
        }
        
        val_25 = this.coinbe;
        goto label_6;
        label_5:
        val_26 = this.imgReward;
        val_26.sprite = this.cointo;
        goto label_8;
        label_6:
        this.imgReward.sprite = ;
        UnityEngine.GameObject val_2 = this.imgReward.gameObject;
        this.imgReward.SetActive(value:  true);
        UnityEngine.GameObject val_3 = this.skinReward.gameObject;
        this.skinReward.SetActive(value:  false);
        val_27 = this.txtReward;
        string val_11 = ToString();
        string val_12 = -1610611917(-1610611917) + ;
        val_26 = -1610611917;
        text = -1610611917;
        label_8:
        this.RewardPanel.SetActive(value:  true);
        System.Collections.IEnumerator val_13 = this.ShowNothanks();
        UnityEngine.Coroutine val_14 = this.StartCoroutine(routine:  848159248);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610604267, volume:  null);
    }
    private void CloseEvent()
    {
        var val_3;
        536882991 = new System.Action(object:  848459664, method:  new IntPtr(1610682193));
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
        goto typeof(SpinManager).__il2cppRuntimeField_E4;
    }
    public void CloseClick()
    {
        bool val_3;
        static_value_015EF3F8.CloseAnim();
        536882991 = new System.Action(object:  848571664, method:  new IntPtr(1610682193));
        System.Delegate val_2 = System.Delegate.Combine(a:  static_value_015EF424, b:  536882991);
        val_3 = static_value_015EF424;
        if(val_3 != false)
        {
                if(val_3 == true)
        {
            goto label_5;
        }
        
        }
        
        val_3 = false;
        label_5:
    }
    public void StartSpinClick(bool ads)
    {
        var val_8;
        if(ads != false)
        {
                WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536873261 = new System.Action<System.Boolean>(object:  848687760, method:  new IntPtr(1610682219));
            -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  4);
            return;
        }
        
        UnityEngine.GameObject val_3 = this.btnSpin.gameObject;
        this.btnSpin.SetActive(value:  false);
        this.justFreeSpin = true;
        this.Spin();
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) != 0)
        {
                val_8 = -1073708883.NumberSpin;
        }
        else
        {
                val_8 = -1073708883.NumberSpin;
        }
        
        -1073708883.NumberSpin = val_8 + 1;
    }
    public void GetX2RewardClick()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  848803856, method:  new IntPtr(1610682221));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  5);
    }
    public void GetRewardClick()
    {
        System.Int32[] val_29;
        var val_30;
        System.Int32[] val_31;
        var val_32;
        string val_34;
        var val_35;
        var val_36;
        val_29 = this.listType;
        int val_28 = val_29[this.index];
        if(val_28 <= 3)
        {
                var val_1 = 18369876 + (18369876 + (this.listType[this.index][0]) << 2);
            if(val_28 == 3)
        {
                18369876 + (this.listType[this.index][0]) << 2 = (18369876 + (this.listType[this.index][0]) << 2) & ((18369876 + (this.listType[this.index][0]) << 2) << (18369876 + (this.listType[this.index][0]) << 2));
            18369876 + (this.listType[this.index][0]) << 2 = (18369876 + (this.listType[this.index][0]) << 2) & (((int)R8) >> 3);
        }
        
            object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
            val_30 = -1073708883.Coin;
            -1073708883.Coin = this.listValue[this.index] + val_30;
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_31 = this.listValue;
            val_32 = -1073700885;
            string val_24 = ToString();
            val_34 = ;
            val_35 = -1610602435;
            val_36 = 22777556;
            string val_25 = -1610602435(-1610602435) + val_34 + -1610612397(-1610612397);
            val_29 = val_35;
            val_32.Show(mess:  -1610602435, callBack:  0);
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  849104272, eventID:  8);
        this.RewardPanel.SetActive(value:  false);
        this.CheckViewObjSpin();
    }
    private void OnApplicationFocus(bool focus)
    {
        if(focus == false)
        {
                return;
        }
        
        this.CheckTimeSpin();
    }
    public SpinManager()
    {
        var val_2;
        this.fullCircles = 8;
        536877987 = new System.Collections.Generic.List<System.Int32>();
        if(536877987 != 0)
        {
                val_2 = 22737108;
            536877987.Add(item:  22);
            536877987.Add(item:  68);
            536877987.Add(item:  112);
            536877987.Add(item:  158);
            536877987.Add(item:  202);
            536877987.Add(item:  258);
            536877987.Add(item:  292);
        }
        else
        {
                val_2 = 22737108;
            536877987.Add(item:  22);
            536877987.Add(item:  68);
            536877987.Add(item:  112);
            536877987.Add(item:  158);
            536877987.Add(item:  202);
            536877987.Add(item:  258);
            536877987.Add(item:  292);
        }
        
        536877987.Add(item:  338);
        this.sectorsAngles = 536877987;
    }
    private void <Start>b__35_0()
    {
        this.StartSpinClick(ads:  false);
    }
    private void <Start>b__35_1()
    {
        this.StartSpinClick(ads:  true);
    }
    private void <Start>b__35_2()
    {
        this.CloseClick();
    }
    private void <Start>b__35_3()
    {
        this.GetRewardClick();
    }
    private void <Start>b__35_4()
    {
        this.GetX2RewardClick();
    }
    private void <Start>b__35_5()
    {
        this.GetRewardClick();
    }
    private void <StartSpinClick>b__51_0(bool success)
    {
        if(success == false)
        {
                return;
        }
        
        this.Spin();
    }
    private void <GetX2RewardClick>b__52_0(bool success)
    {
        System.Int32[] val_26;
        var val_27;
        System.Int32[] val_28;
        var val_29;
        int val_30;
        var val_31;
        var val_32;
        var val_33;
        val_26 = 23000061;
        if(success == false)
        {
                return;
        }
        
        val_26 = this.listType;
        int val_26 = val_26[this.index];
        if(val_26 <= 3)
        {
                var val_1 = 18371964 + (18371964 + (this.listType[this.index][0]) << 2);
            if(val_26 == 3)
        {
                18371964 + (this.listType[this.index][0]) << 2 = (18371964 + (this.listType[this.index][0]) << 2) & ((18371964 + (this.listType[this.index][0]) << 2) << (18371964 + (this.listType[this.index][0]) << 2));
            18371964 + (this.listType[this.index][0]) << 2 = (18371964 + (this.listType[this.index][0]) << 2) & (((int)IP) >> R2);
        }
        
            object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
            val_27 = -1073708883.Coin;
            -1073708883.Coin = val_27 + (this.listValue[this.index] << 1);
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_28 = this.listValue;
            val_29 = -1073700885;
            val_30 = val_28[this.index];
             =  << 1;
            string val_23 = ToString();
            val_31;
            val_32 = -1610602435;
            val_33 = 22777556;
            string val_24 = -1610602435(-1610602435) + 850589068 + -1610612397(-1610612397);
            val_26 = val_32;
            val_29.Show(mess:  -1610602435, callBack:  0);
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  850601104, eventID:  8);
        this.RewardPanel.SetActive(value:  false);
        this.CheckViewObjSpin();
    }

}
