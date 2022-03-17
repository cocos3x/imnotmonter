using UnityEngine;
public class NotEnughtCoinPopup : BaseUIMenu
{
    // Fields
    private UnityEngine.GameObject moneyContent;
    private UnityEngine.GameObject diamondContent;
    private TMPro.TextMeshProUGUI txtcoin;
    private TMPro.TextMeshProUGUI txtDiamond;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button outsideCloseButton;
    private UnityEngine.UI.Button getMoneyBtn;
    private UnityEngine.UI.Button getDiamondBtn;
    private bool isMoney;
    
    // Methods
    public override void Init(object[] initParams)
    {
        var val_4;
        this.Init(initParams:  initParams);
        object val_4 = initParams[0];
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        this.isMoney = null;
        UnityEngine.GameObject val_1 = this.moneyContent.gameObject;
        if(null != 0)
        {
                this.moneyContent.SetActive(value:  true);
            UnityEngine.GameObject val_2 = this.diamondContent.gameObject;
            val_4 = 0;
        }
        else
        {
                this.moneyContent.SetActive(value:  false);
            UnityEngine.GameObject val_3 = this.diamondContent.gameObject;
            val_4 = 1;
        }
        
        this.diamondContent.SetActive(value:  true);
    }
    private void Start()
    {
        var val_15;
        var val_16;
        536896275 = new UnityEngine.Events.UnityAction(object:  830715920, method:  new IntPtr(1610681977));
        this.closeButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  830715920, method:  new IntPtr(1610681979));
        this.outsideCloseButton.m_OnClick.AddListener(call:  536896275);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_4 = mem[3221266267] + 8;
        string val_5 = val_4.ToString();
        string val_6 = -1610611917(-1610611917) + val_4;
        val_15 = mem[mem[3221271783] + 186];
        val_15 = mem[3221271783] + 186;
        if(val_15 == 1)
        {
                val_15 = mem[mem[3221271783] + 186];
            val_15 = mem[3221271783] + 186;
        }
        
        string val_7 = System.String.Format(format:  -1610611917, args:  mem[3221271783] + 92);
        this.txtcoin.text = -1610611917;
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_9 = mem[3221266267] + 12;
        string val_10 = val_9.ToString();
        string val_11 = -1610611917(-1610611917) + val_9;
        val_16 = mem[mem[3221271783] + 186];
        val_16 = mem[3221271783] + 186;
        if(val_16 == 1)
        {
                val_16 = mem[mem[3221271783] + 186];
            val_16 = mem[3221271783] + 186;
        }
        
        string val_12 = System.String.Format(format:  -1610611917, args:  mem[3221271783] + 92);
        this.txtDiamond.text = -1610611917;
        536896275 = new UnityEngine.Events.UnityAction(object:  830715920, method:  new IntPtr(1610681981));
        this.getMoneyBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  830715920, method:  new IntPtr(1610681983));
        this.getDiamondBtn.m_OnClick.AddListener(call:  536896275);
    }
    private void CloseButtonClick()
    {
        goto typeof(NotEnughtCoinPopup).__il2cppRuntimeField_E4;
    }
    private void GetMoneyRewardClick()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  830980880, method:  new IntPtr(1610681985));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  2);
    }
    private void GetDiamondRewardClick()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  831092880, method:  new IntPtr(1610681987));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  3);
    }
    public NotEnughtCoinPopup()
    {
    
    }
    private void <Start>b__10_0()
    {
        goto typeof(NotEnughtCoinPopup).__il2cppRuntimeField_E4;
    }
    private void <Start>b__10_1()
    {
        goto typeof(NotEnughtCoinPopup).__il2cppRuntimeField_E4;
    }
    private void <Start>b__10_2()
    {
        this.GetMoneyRewardClick();
    }
    private void <Start>b__10_3()
    {
        this.GetDiamondRewardClick();
    }
    private void <GetMoneyRewardClick>b__12_0(bool success)
    {
        if(success == false)
        {
                return;
        }
        
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073708883.Coin = (mem[3221266267] + 8) + (-1073708883.Coin);
        GameTool.EventDispatcherExtension.PostEvent(sender:  831764880, eventID:  8);
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_7 = mem[3221266267] + 8;
        string val_8 = val_7.ToString();
        string val_9 = -1610602435(-1610602435) + val_7 + -1610612397(-1610612397);
        -1073700885.Show(mess:  -1610602435, callBack:  0);
    }
    private void <GetDiamondRewardClick>b__13_0(bool success)
    {
        if(success == false)
        {
                return;
        }
        
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073708883.Diamond = (mem[3221266267] + 12) + (-1073708883.Diamond);
        GameTool.EventDispatcherExtension.PostEvent(sender:  831876880, eventID:  8);
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_7 = mem[3221266267] + 12;
        string val_8 = val_7.ToString();
        string val_9 = -1610602435(-1610602435) + val_7 + -1610612293(-1610612293);
        -1073700885.Show(mess:  -1610602435, callBack:  0);
    }

}
