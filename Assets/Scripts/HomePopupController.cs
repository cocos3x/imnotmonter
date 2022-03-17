using UnityEngine;
public class HomePopupController : BaseUIMenu
{
    // Fields
    private AnimToolUI.AnimUIManager animUIManager;
    private readonly string cutRescueName;
    private TMPro.TextMeshProUGUI levelTxt;
    private UnityEngine.GameObject[] listNotifi;
    private TMPro.TextMeshProUGUI modeName;
    private readonly string pinPullName;
    private UnityEngine.UI.Button playBtn;
    private readonly string ropeRescueName;
    private UnityEngine.UI.Button selectLevelBtn;
    
    // Methods
    public override void Init(object[] initParams)
    {
        this.Init(initParams:  initParams);
        this.CheckMode();
    }
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  815321488, method:  new IntPtr(1610681777));
        this.selectLevelBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  815321488, method:  new IntPtr(1610681779));
        this.playBtn.m_OnClick.AddListener(call:  536896275);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  815321488, method:  new IntPtr(1610681781));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  815321488, eventID:  27, callback:  536873423);
    }
    public void CloseClick()
    {
        goto typeof(HomePopupController).__il2cppRuntimeField_E4;
    }
    private void CloseEvent()
    {
    
    }
    private void CheckMode()
    {
        string val_16;
        TMPro.TextMeshProUGUI val_17;
        var val_19;
        this.playBtn.interactable = true;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_4;
        }
        
        val_16 = 22740800;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_6;
        }
        
        label_4:
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_5 = -1073708883.GameMode;
        if(val_5 == 2)
        {
            goto label_8;
        }
        
        if(val_5 == 1)
        {
            goto label_9;
        }
        
        if(val_5 != 0)
        {
                return;
        }
        
        val_16 = this.ropeRescueName;
        this.modeName.text = val_16;
        val_17 = this.levelTxt;
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_7 = -1073708883.LevelRopeUnlocked;
        goto label_18;
        label_6:
        val_17 = this.levelTxt;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_9 = -1073708883.CurrentLevelUnlocked;
        val_9 = val_9 + 1;
        goto label_15;
        label_8:
        val_16 = this.modeName;
        val_16.text = this.cutRescueName;
        val_17 = this.levelTxt;
        object val_10 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_11 = -1073708883.LevelCutRopeUnlocked;
        goto label_18;
        label_9:
        val_16 = this.pinPullName;
        this.modeName.text = val_16;
        val_17 = this.levelTxt;
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_13 = -1073708883.LevelPinPullUnlocked;
        label_18:
        val_13 = val_13 + 1;
        val_19;
        label_15:
        string val_14 = val_13.ToString();
        string val_15 = -1610606675(-1610606675) + 815706896;
        val_17.text = -1610606675;
    }
    private void CheckNotifi()
    {
        goto label_1;
        label_5:
        1152921506690760672.SetActive(value:  false);
        0 = 1;
        label_1:
        if(0 < 1152921506690760672)
        {
            goto label_5;
        }
        
        if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  2)) == 0)
        {
                this.listNotifi[0].SetActive(value:  true);
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        System.Collections.Generic.List<System.Int32> val_3 = -1073708883.ListSkinUnlocked;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if(mem[3221258425] < mem[3221258425])
        {
                object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
            System.Collections.Generic.List<System.Int32> val_6 = -1073708883.ListHuggyUnlocked;
            object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
            if(mem[3221258425] < mem[3221258429])
        {
                if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  2)) == 0)
        {
                this.listNotifi[0].SetActive(value:  true);
        }
        
        }
        
        }
        
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsUnlockAllDeco()) == false)
        {
                return;
        }
        
        if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  2)) != 0)
        {
                return;
        }
        
        this.listNotifi[0].SetActive(value:  true);
    }
    public void OpenSelectLevel()
    {
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Push(identifier:  -1610605283, initParams:  null);
    }
    public void PlayGame()
    {
        var val_58;
        var val_59;
        var val_60;
        this.playBtn.interactable = false;
        val_58 = 22742128;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) == 0)
        {
            goto label_4;
        }
        
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.IsOldUser) == false)
        {
            goto label_6;
        }
        
        label_4:
        val_58 = 22740800;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_5 = -1073708883.GameMode;
        if(val_5 == 2)
        {
            goto label_8;
        }
        
        if(val_5 == 1)
        {
            goto label_9;
        }
        
        if(val_5 != 0)
        {
                return;
        }
        
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.LevelRopeUnlocked) >= (-1073708883.NumberRopeLevel))
        {
            goto label_43;
        }
        
        object val_10 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CurrentLevelRope = (-1073708883.LevelRopeUnlocked) + 1;
        goto label_27;
        label_6:
        object val_14 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelUnlocked) >= (-1073708883.NumberMixLevel))
        {
            goto label_19;
        }
        
        object val_18 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_19 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CurrentLevel = -1073708883.CurrentLevelUnlocked;
        WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_22 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_24 = (mem[3221266339] + 12) + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_23) << 2) + 16) == 0)
        {
            goto label_27;
        }
        
        WorldTimeAPI val_25 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_26 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_28 = (mem[3221266339] + 12) + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_27) << 2) + 16) != 1)
        {
            goto label_33;
        }
        
        label_27:
        WorldTimeAPI val_29 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneRopeRescue();
        return;
        label_8:
        object val_30 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_32 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.LevelCutRopeUnlocked) >= (-1073708883.NumberCutRopeLevel))
        {
            goto label_43;
        }
        
        object val_34 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_35 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CurrentLevelCutRope = (-1073708883.LevelCutRopeUnlocked) + 1;
        label_62:
        WorldTimeAPI val_38 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneCutRescue();
        return;
        label_9:
        object val_39 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_41 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.LevelPinPullUnlocked) >= (-1073708883.NumberPinpullLevel))
        {
            goto label_43;
        }
        
        object val_43 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_44 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.CurrentLevelPinPull = (-1073708883.LevelPinPullUnlocked) + 1;
        goto label_46;
        label_43:
        WorldTimeAPI val_47 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_59 = -1073700885;
        val_60 = 22783808;
        goto label_48;
        label_19:
        WorldTimeAPI val_48 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_59 = -1073700885;
        val_60 = 22783812;
        label_48:
        val_59.Show(mess:  -1610609267, callBack:  0);
        return;
        label_33:
        WorldTimeAPI val_49 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_50 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_52 = (mem[3221266339] + 12) + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_51) << 2) + 16) != 2)
        {
            goto label_55;
        }
        
        label_46:
        WorldTimeAPI val_53 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadScenePinPull();
        return;
        label_55:
        WorldTimeAPI val_54 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_55 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_57 = (mem[3221266339] + 12) + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_56) << 2) + 16) == 3)
        {
            goto label_62;
        }
    
    }
    public HomePopupController()
    {
        this.cutRescueName = -1610609729;
        this.pinPullName = -1610605479;
        this.ropeRescueName = -1610607967;
    }
    private void <Start>b__10_0()
    {
        this.OpenSelectLevel();
    }
    private void <Start>b__10_1()
    {
        this.PlayGame();
    }
    private void <Start>b__10_2(UnityEngine.Component sender, object param)
    {
        this.CheckMode();
    }

}
