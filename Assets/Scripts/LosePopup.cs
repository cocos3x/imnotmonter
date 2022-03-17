using UnityEngine;
public class LosePopup : BaseUIMenu
{
    // Fields
    private UnityEngine.UI.Button skipLevelBtn;
    private UnityEngine.UI.Button replayButton;
    private UnityEngine.UI.Button backHomeButton;
    private Spine.Unity.SkeletonGraphic victoryTextSkeleton;
    private string characterMode;
    
    // Methods
    private void Start()
    {
        536896275 = new UnityEngine.Events.UnityAction(object:  762179216, method:  new IntPtr(1610680965));
        this.skipLevelBtn.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  762179216, method:  new IntPtr(1610680967));
        this.replayButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  762179216, method:  new IntPtr(1610680969));
        this.backHomeButton.m_OnClick.AddListener(call:  536896275);
    }
    private void OnEnable()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        mem[3221258461] = 0;
        this.CheckMode();
        this.AddTracking();
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610606569, volume:  null);
        System.Collections.IEnumerator val_3 = this.ShowVictoryText();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  762315792);
    }
    private System.Collections.IEnumerator ShowVictoryText()
    {
        536899635 = new LosePopup.<ShowVictoryText>d__7(<>1__state:  0);
        mem[536899651] = this;
    }
    public override void Init(object[] initParams)
    {
        this.Init(initParams:  initParams);
    }
    private void AddTracking()
    {
        var val_16;
        var val_17;
        var val_18;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_2 = -1073708883.GameMode;
        if(val_2 == 2)
        {
            goto label_2;
        }
        
        if(val_2 == 1)
        {
            goto label_3;
        }
        
        if(val_2 != 0)
        {
                return;
        }
        
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_16 = -1073700879;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_6 = -1073708883.LevelRopePlayed.ToString();
        val_17;
        val_18 = 22792108;
        goto label_8;
        label_2:
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_16 = -1073700879;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_10 = -1073708883.LevelCutRopePlayed.ToString();
        val_17;
        val_18 = 22782868;
        goto label_8;
        label_3:
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_16 = -1073700879;
        object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_14 = -1073708883.LevelPinPullPlayed.ToString();
        val_17;
        val_18 = 22791340;
        label_8:
        string val_15 = -1610605499(-1610605499) + 762713500;
        val_16.TrackEvent(eventName:  -1610605499);
    }
    private void OpenHome()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        this.backHomeButton.interactable = false;
    }
    private void CheckMode()
    {
        var val_8;
        var val_9;
        string val_10;
        var val_11;
        val_8 = 22740800;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) != 0)
        {
                object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
            if((-1073708883.GameMode) != 1)
        {
                object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
            if((-1073708883.GameMode) != 2)
        {
                return;
        }
        
        }
        
            val_9 = 536884781;
            if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_9 = 536884781;
        }
        
            val_10 = mem[mem[536884873] + 28];
            val_10 = mem[536884873] + 28;
        }
        else
        {
                val_11 = 536884781;
            if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_11 = 536884781;
        }
        
            val_10 = mem[mem[536884873] + 24];
            val_10 = mem[536884873] + 24;
        }
        
        this.characterMode = val_10;
    }
    private void SkipLevel()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  763069712, method:  new IntPtr(1610680975));
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  10);
    }
    private void ReplayButtonClick()
    {
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700957.SpawLevel();
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.SpawnNextLevel();
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701079.SpawnNextLevel();
        }
    
    }
    public LosePopup()
    {
        this.characterMode = -1610612735;
    }
    private void <Start>b__5_0()
    {
        this.SkipLevel();
    }
    private void <Start>b__5_1()
    {
        this.ReplayButtonClick();
    }
    private void <Start>b__5_2()
    {
        this.OpenHome();
    }
    private bool <ShowVictoryText>b__7_0()
    {
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.victoryTextSkeleton);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Implicit(exists:  this.victoryTextSkeleton);
        }
        
        return UnityEngine.Object.op_Implicit(exists:  this.victoryTextSkeleton);
    }
    private void <ShowVictoryText>b__7_1()
    {
        MixSkinManager.SetAnimation(ske:  this.victoryTextSkeleton, name:  -1610600013, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    private void <SkipLevel>b__12_0(bool success)
    {
        var val_114;
        var val_115;
        var val_116;
        var val_117;
        var val_118;
        var val_119;
        if(success == false)
        {
                return;
        }
        
        val_114 = 22742128;
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
        val_114 = 22740800;
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
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelRope) > (-1073708883.LevelRopeUnlocked))
        {
                WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            object val_12 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_13 = -1073708883.LevelRopePlayed;
            val_13 = val_13 - 1;
            string val_14 = val_13.ToString();
            string val_15 = -1610605109(-1610605109) + 763970060;
            -1073700879.TrackEvent(eventName:  -1610605109);
            object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
            object val_17 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.LevelRopeUnlocked = -1073708883.CurrentLevelRope;
        }
        
        object val_19 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_19;
        }
        
        val_115 = -1073708883.CurrentLevelRope;
        goto label_20;
        label_6:
        object val_21 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_21;
        }
        
        val_116 = -1073708883.CurrentLevel;
        goto label_22;
        label_8:
        object val_23 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_25 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelCutRope) > (-1073708883.LevelCutRopeUnlocked))
        {
                WorldTimeAPI val_27 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            object val_28 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_29 = -1073708883.LevelCutRopePlayed;
            val_29 = val_29 - 1;
            string val_30 = val_29.ToString();
            string val_31 = -1610609735(-1610609735) + 763970060;
            -1073700879.TrackEvent(eventName:  -1610609735);
            object val_32 = AFramework.ManualSingletonMono<System.Object>.I;
            object val_33 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.LevelCutRopeUnlocked = -1073708883.CurrentLevelCutRope;
        }
        
        object val_35 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_30;
        }
        
        val_117 = -1073708883.CurrentLevelCutRope;
        goto label_31;
        label_9:
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        object val_38 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_40 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelPinPull) > (-1073708883.LevelPinPullUnlocked))
        {
                WorldTimeAPI val_42 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            object val_43 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_44 = -1073708883.LevelPinPullPlayed;
            val_44 = val_44 - 1;
            string val_45 = val_44.ToString();
            string val_46 = -1610605493(-1610605493) + 763970060;
            -1073700879.TrackEvent(eventName:  -1610605493);
            object val_47 = AFramework.ManualSingletonMono<System.Object>.I;
            object val_48 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.LevelPinPullUnlocked = -1073708883.CurrentLevelPinPull;
        }
        
        object val_50 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_40;
        }
        
        val_118 = -1073708883.CurrentLevelPinPull;
        goto label_41;
        label_21:
        val_116 = -1073708883.CurrentLevel;
        label_22:
        -1073708883.CurrentLevel = val_116 + 1;
        object val_54 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_56 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevel) > (-1073708883.CurrentLevelUnlocked))
        {
                object val_58 = AFramework.ManualSingletonMono<System.Object>.I;
            object val_59 = AFramework.ManualSingletonMono<System.Object>.I;
            -1073708883.CurrentLevelUnlocked = -1073708883.CurrentLevel;
        }
        
        WorldTimeAPI val_61 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_119 = mem[mem[3221266339] + 12];
        val_119 = mem[3221266339] + 12;
        object val_62 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_64 = val_119 + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_63) << 2) + 16) == 0)
        {
            goto label_52;
        }
        
        WorldTimeAPI val_65 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_119 = mem[mem[3221266339] + 12];
        val_119 = mem[3221266339] + 12;
        object val_66 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_68 = val_119 + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_67) << 2) + 16) != 1)
        {
            goto label_58;
        }
        
        label_52:
        WorldTimeAPI val_69 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneRopeRescue();
        return;
        label_58:
        WorldTimeAPI val_70 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_119 = mem[mem[3221266339] + 12];
        val_119 = mem[3221266339] + 12;
        object val_71 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_73 = val_119 + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_72) << 2) + 16) != 2)
        {
            goto label_66;
        }
        
        WorldTimeAPI val_74 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadScenePinPull();
        return;
        label_30:
        val_117 = -1073708883.CurrentLevelCutRope;
        label_31:
        -1073708883.CurrentLevelCutRope = val_117 + 1;
        object val_77 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_79 = AFramework.ManualSingletonMono<System.Object>.I;
        val_119 = -1073708883;
        if((-1073708883.LevelCutRopeUnlocked) < val_119.NumberCutRopeLevel)
        {
            goto label_71;
        }
        
        object val_81 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_83 = AFramework.ManualSingletonMono<System.Object>.I;
        val_119 = -1073708883;
        if((-1073708883.CurrentLevelCutRope) > val_119.LevelCutRopeUnlocked)
        {
            goto label_90;
        }
        
        label_71:
        WorldTimeAPI val_85 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.SpawnNextLevel();
        return;
        label_66:
        WorldTimeAPI val_86 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_87 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_89 = (mem[3221266339] + 12) + ((-1073708883.CurrentLevel) << 2);
        if(((mem[3221266339] + 12 + (val_88) << 2) + 16) != 3)
        {
                return;
        }
        
        WorldTimeAPI val_90 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneCutRescue();
        return;
        label_19:
        val_115 = -1073708883.CurrentLevelRope;
        label_20:
        -1073708883.CurrentLevelRope = val_115 + 1;
        object val_93 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_95 = AFramework.ManualSingletonMono<System.Object>.I;
        val_119 = -1073708883;
        if((-1073708883.LevelRopeUnlocked) < val_119.NumberRopeLevel)
        {
            goto label_87;
        }
        
        object val_97 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_99 = AFramework.ManualSingletonMono<System.Object>.I;
        val_119 = -1073708883;
        if((-1073708883.CurrentLevelRope) > val_119.LevelRopeUnlocked)
        {
            goto label_90;
        }
        
        label_87:
        WorldTimeAPI val_101 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700957.SpawLevel();
        return;
        label_40:
        val_118 = -1073708883.CurrentLevelPinPull;
        label_41:
        -1073708883.CurrentLevelPinPull = val_118 + 1;
        object val_104 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_106 = AFramework.ManualSingletonMono<System.Object>.I;
        val_119 = -1073708883;
        if((-1073708883.LevelPinPullUnlocked) < val_119.NumberPinpullLevel)
        {
            goto label_98;
        }
        
        object val_108 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_110 = AFramework.ManualSingletonMono<System.Object>.I;
        val_119 = -1073708883;
        if((-1073708883.CurrentLevelPinPull) <= val_119.LevelPinPullUnlocked)
        {
            goto label_98;
        }
        
        label_90:
        WorldTimeAPI val_112 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700919.LoadSceneHome();
        return;
        label_98:
        WorldTimeAPI val_113 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.SpawnNextLevel();
    }

}
