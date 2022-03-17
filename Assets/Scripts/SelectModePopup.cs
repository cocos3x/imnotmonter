using UnityEngine;
public class SelectModePopup : BaseUIMenu
{
    // Fields
    private UnityEngine.UI.Button ropeRescueModeButton;
    private UnityEngine.UI.Button pinPullModeButton;
    private UnityEngine.UI.Button cutRescueButton;
    private ItemSelectModeController[] listItemSelectMode;
    private UnityEngine.UI.Button closeButton;
    private UnityEngine.UI.Button settingBtn;
    private AnimToolUI.AnimUIManager animUIManager;
    private UnityEngine.UI.ScrollRect scrollRect;
    private bool isClosing;
    private float[] steps;
    
    // Methods
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  838792848, method:  new IntPtr(1610682099));
        this.settingBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  838792848, method:  new IntPtr(1610682101));
        this.ropeRescueModeButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  838792848, method:  new IntPtr(1610682103));
        this.pinPullModeButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  838792848, method:  new IntPtr(1610682105));
        this.cutRescueButton.m_OnClick.AddListener(call:  536896275);
    }
    private void OnEnable()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.RopeTapeBonusReward = 0;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.StopShot();
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701127.ShowBanner(position:  1, bannerPlaceID:  0);
        this.isClosing = false;
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  838937616, method:  new IntPtr(1610682107));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  838937616, eventID:  8, callback:  536873423);
        this.Invoke(methodName:  -1610604629, time:  null);
        this.Invoke(methodName:  -1610609365, time:  null);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  839049616, method:  new IntPtr(1610682109));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  839049616, eventID:  8, callback:  536873423);
    }
    public override void Init(object[] initParams)
    {
        this.Init(initParams:  initParams);
    }
    private void OnSettingClick()
    {
        mem2[0] = 1;
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Push(identifier:  -1610605279, initParams:  null);
    }
    private void SelectModeButtonClick(ModeGameType modeGameType)
    {
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        val_35 = 22999979;
        if(modeGameType == 0)
        {
            goto label_1;
        }
        
        if(modeGameType == 2)
        {
            goto label_2;
        }
        
        if(modeGameType != 1)
        {
                return;
        }
        
        val_36 = 22740800;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        val_37 = -1073708883.RopeRescuelUnlocked;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        val_38 = 0;
        if(val_37 == true)
        {
            goto label_14;
        }
        
        val_39 = 22742128;
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_35 = mem[3221266299];
        if((-1073708883.Diamond) >= (mem[3221266299] + 12))
        {
            goto label_9;
        }
        
        val_40 = 536882211;
        val_41 = 22709536;
        goto label_21;
        label_1:
        val_36 = 22740800;
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        val_37 = -1073708883.PinPullUnlocked;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        if(val_37 == false)
        {
            goto label_13;
        }
        
        val_38 = 1;
        goto label_14;
        label_2:
        val_36 = 22740800;
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        val_37 = -1073708883.CutRescuelUnlocked;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        if(val_37 == false)
        {
            goto label_17;
        }
        
        val_38 = 2;
        label_14:
        -1073708883.GameMode = 2;
        this.CloseButtonClick();
        return;
        label_13:
        val_39 = 22742128;
        WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_35 = mem[3221266299];
        if((-1073708883.Diamond) >= (mem[3221266299] + 8))
        {
            goto label_20;
        }
        
        val_40 = 536882211;
        val_41 = 22709536;
        goto label_21;
        label_17:
        val_39 = 22742128;
        WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_35 = mem[3221266299];
        if((-1073708883.Diamond) >= (mem[3221266299] + 16))
        {
            goto label_24;
        }
        
        val_40 = 536882211;
        val_41 = 22709536;
        label_21:
        mem[536882227] = val_41;
        AFramework.UI.BaseUIMenu val_16 = AFramework.UI.CanvasManager.Push(identifier:  -1610605285, initParams:  536882211);
        return;
        label_9:
        object val_17 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.RopeRescuelUnlocked = true;
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        val_42 = -1073708883.Diamond;
        WorldTimeAPI val_20 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_43 = mem[mem[3221266299] + 12];
        val_43 = mem[3221266299] + 12;
        -1073708883.Diamond = val_42 - val_43;
        GameTool.EventDispatcherExtension.PostEvent(sender:  839463440, eventID:  8);
        GameTool.EventDispatcherExtension.PostEvent(sender:  839463440, eventID:  31);
        WorldTimeAPI val_22 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_44 = -1073700885;
        val_45 = 22792628;
        goto label_44;
        label_20:
        object val_23 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.PinPullUnlocked = true;
        object val_24 = AFramework.ManualSingletonMono<System.Object>.I;
        val_42 = -1073708883.Diamond;
        WorldTimeAPI val_26 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_43 = mem[mem[3221266299] + 8];
        val_43 = mem[3221266299] + 8;
        -1073708883.Diamond = val_42 - val_43;
        GameTool.EventDispatcherExtension.PostEvent(sender:  839463440, eventID:  8);
        GameTool.EventDispatcherExtension.PostEvent(sender:  839463440, eventID:  31);
        WorldTimeAPI val_28 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_44 = -1073700885;
        val_45 = 22791608;
        goto label_44;
        label_24:
        object val_29 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CutRescuelUnlocked = true;
        object val_30 = AFramework.ManualSingletonMono<System.Object>.I;
        val_42 = -1073708883.Diamond;
        WorldTimeAPI val_32 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_43 = mem[mem[3221266299] + 16];
        val_43 = mem[3221266299] + 16;
        -1073708883.Diamond = val_42 - val_43;
        GameTool.EventDispatcherExtension.PostEvent(sender:  839463440, eventID:  8);
        GameTool.EventDispatcherExtension.PostEvent(sender:  839463440, eventID:  31);
        WorldTimeAPI val_34 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_44 = -1073700885;
        val_45 = 22784384;
        label_44:
        val_44.Show(mess:  -1610608981, callBack:  0);
    }
    private void CheckAllItemSelectMode()
    {
        goto label_0;
        label_4:
        1152921506822577120.CheckUnlockMode();
        0 = 1;
        label_0:
        if(0 < 1152921506822577120)
        {
            goto label_4;
        }
    
    }
    private void CloseButtonClick()
    {
        var val_3;
        if(this.isClosing != false)
        {
                return;
        }
        
        this.isClosing = true;
        this.animUIManager.CloseAnim();
        536882991 = new System.Action(object:  839777552, method:  new IntPtr(1610682093));
        System.Delegate val_2 = System.Delegate.Combine(a:  this.animUIManager.OnClose, b:  536882991);
        val_3 = this.animUIManager.OnClose;
        if(val_3 != 0)
        {
                if(null == 536882991)
        {
            goto label_6;
        }
        
        }
        
        val_3 = 0;
        label_6:
        mem2[0] = val_3;
    }
    private void CloseEvent()
    {
        var val_5;
        536882991 = new System.Action(object:  839910032, method:  new IntPtr(1610682093));
        System.Delegate val_2 = System.Delegate.Remove(source:  this.animUIManager.OnClose, value:  536882991);
        val_5 = this.animUIManager.OnClose;
        if(val_5 != 0)
        {
                if(null == 536882991)
        {
            goto label_4;
        }
        
        }
        
        val_5 = 0;
        label_4:
        mem2[0] = val_5;
        GameTool.EventDispatcherExtension.PostEvent(sender:  839910032, eventID:  27);
        WinPopup val_3 = AFramework.SingletonUI<WinPopup>.I;
        -1073700811.ShowDeco(value:  true);
        AFramework.UI.BaseUIMenu val_4 = AFramework.UI.CanvasManager.Push(identifier:  -1610605291, initParams:  null);
        this.CheckClose();
    }
    private void CheckClose()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        string val_2 = val_1.m_Handle.name;
        if((val_1.m_Handle.Contains(value:  -1610604415)) == false)
        {
                return;
        }
        
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_5 = -1073708883.GameMode;
        if(val_5 == 2)
        {
            goto label_6;
        }
        
        if(val_5 == 1)
        {
            goto label_7;
        }
        
        if(val_5 != 0)
        {
                return;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadScenePinPull();
        return;
        label_6:
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneCutRescue();
        return;
        label_7:
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneRopeRescue();
    }
    public SelectModePopup()
    {
        this.steps = 536882357;
    }
    private void <Start>b__9_0()
    {
        this.OnSettingClick();
    }
    private void <Start>b__9_1()
    {
        this.SelectModeButtonClick(modeGameType:  1);
    }
    private void <Start>b__9_2()
    {
        this.SelectModeButtonClick(modeGameType:  0);
    }
    private void <Start>b__9_3()
    {
        this.SelectModeButtonClick(modeGameType:  2);
    }
    private void <OnEnable>b__10_0(UnityEngine.Component o, object sender)
    {
        this.CheckAllItemSelectMode();
    }
    private void <OnDisable>b__11_0(UnityEngine.Component o, object sender)
    {
        this.CheckAllItemSelectMode();
    }

}
