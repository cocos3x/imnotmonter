using UnityEngine;
public class GameMenu : SingletonMonoBehaviour<GameMenu>
{
    // Fields
    private TMPro.TextMeshProUGUI levelTxt;
    private UnityEngine.UI.Button replayButton;
    private UnityEngine.UI.Button pauseButton;
    private UnityEngine.UI.Button skipLevelButton;
    private UnityEngine.GameObject mix;
    private UnityEngine.GameObject nonMix;
    private Spine.Unity.SkeletonGraphic bossTextSkeleton;
    
    // Methods
    private void Start()
    {
        this.ResetElements();
        536896275 = new UnityEngine.Events.UnityAction(object:  808181136, method:  new IntPtr(1610681645));
        this.replayButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  808181136, method:  new IntPtr(1610681647));
        this.pauseButton.m_OnClick.AddListener(call:  536896275);
        536896275 = new UnityEngine.Events.UnityAction(object:  808181136, method:  new IntPtr(1610681649));
        this.skipLevelButton.m_OnClick.AddListener(call:  536896275);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  808181136, method:  new IntPtr(1610681651));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  808181136, eventID:  28, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  808181136, method:  new IntPtr(1610681653));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  808181136, eventID:  34, callback:  536873423);
        this.CheckShowBtSkipLevel();
    }
    private void OnEnable()
    {
        var val_5;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) != 0)
        {
                object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
            val_5 = (-1073708883.IsOldUser) ^ 1;
        }
        else
        {
                val_5 = 0;
        }
        
        this.mix.SetActive(value:  false);
        this.nonMix.SetActive(value:  val_5 ^ 1);
    }
    public void ResetElements()
    {
        var val_15;
        TMPro.TextMeshProUGUI val_16;
        val_15 = 22740800;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) == 0)
        {
            goto label_2;
        }
        
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) != 1)
        {
            goto label_4;
        }
        
        val_16 = this.levelTxt;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_6 = -1073708883.CurrentLevelPinPull;
        goto label_8;
        label_2:
        val_16 = this.levelTxt;
        object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_8 = -1073708883.CurrentLevelRope;
        goto label_8;
        label_4:
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) != 2)
        {
            goto label_10;
        }
        
        val_16 = this.levelTxt;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        label_8:
        string val_13 = -1073708883.CurrentLevelCutRope.ToString();
        string val_14 = -1610606733(-1610606733) + 808458644;
        val_15 = -1610606733;
        val_16.text = -1610606733;
        label_10:
        this.replayButton.interactable = true;
        this.pauseButton.interactable = true;
        this.skipLevelButton.interactable = true;
        this.CheckShowBtSkipLevel();
    }
    public void DisableButtonOnHuggyMove()
    {
        this.skipLevelButton.interactable = false;
    }
    private void ReplayButtonClick()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        mem[3221258461] = 0;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) == 0)
        {
            goto label_3;
        }
        
        label_24:
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) == 1)
        {
                WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536873261 = new System.Action<System.Boolean>(object:  808731536, method:  new IntPtr(1610681657));
            -1073701127.ShowFull(onClosed:  536873261, interPlaceID:  4);
        }
        
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) != 2)
        {
                return;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  808731536, method:  new IntPtr(1610681659));
        -1073701127.ShowFull(onClosed:  536873261, interPlaceID:  4);
        return;
        label_3:
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(mem[3221266371] == false)
        {
                return;
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if(mem[3221266319] != false)
        {
                return;
        }
        
        }
        
        object val_15 = AFramework.ManualSingletonMono<System.Object>.I;
        WorldTimeAPI val_17 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((-1073708883.CurrentLevelRope) <= (mem[3221266267] + 16))
        {
            goto label_18;
        }
        
        WorldTimeAPI val_18 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536873261 = new System.Action<System.Boolean>(object:  808731536, method:  new IntPtr(1610681655));
        -1073701127.ShowFull(onClosed:  536873261, interPlaceID:  4);
        goto label_24;
        label_18:
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_24;
        }
        
        this.replayButton.interactable = false;
        WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700957.SpawLevel();
        goto label_24;
    }
    private void PauseButtonClick()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) == 0)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if(mem[3221266371] == false)
        {
                return;
        }
        
        }
        
        mem2[0] = 0;
        AFramework.UI.BaseUIMenu val_4 = AFramework.UI.CanvasManager.Push(identifier:  -1610605279, initParams:  null);
    }
    private void SkipButtonClick()
    {
        var val_6;
        object val_7;
        System.Action<System.Boolean> val_8;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) == 0)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            if(mem[3221266371] == false)
        {
                return;
        }
        
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_6 = 536899143;
        if(((mem[536899330] & true) == 0) && (mem[536899259] == 0))
        {
                val_6 = 536899143;
        }
        
        val_7 = mem[536899235];
        val_8 = mem[mem[536899235] + 4];
        val_8 = mem[536899235] + 4;
        if(val_8 == 0)
        {
                if(((mem[536899330] & true) == 0) && (mem[536899259] == 0))
        {
                val_7 = mem[536899235];
        }
        
            val_8 = 536873261;
            val_8 = new System.Action<System.Boolean>(object:  val_7, method:  new IntPtr(1610681665));
            mem2[0] = val_8;
        }
        
        -1073701127.ShowReward(callBack:  536873261, rewardPlaceID:  10);
    }
    private void CheckShowBtSkipLevel()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.GameMode) != 0)
        {
            goto label_2;
        }
        
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_4 = -1073708883.CurrentLevelRope;
        val_4 = val_4 - 4294967290;
        if(val_4 == 0)
        {
            goto label_4;
        }
        
        label_2:
        UnityEngine.GameObject val_5 = this.skipLevelButton.gameObject;
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        label_10:
        this.skipLevelButton.SetActive(value:  true);
        return;
        label_4:
        UnityEngine.GameObject val_7 = this.skipLevelButton.gameObject;
        if(this.skipLevelButton != 0)
        {
            goto label_10;
        }
        
        goto label_10;
    }
    public void ShowTextBossFight(float time = 0)
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610608773, value:  536893745);
    }
    private System.Collections.IEnumerator DelayShowTextBossFight(float time)
    {
        GameMenu.<DelayShowTextBossFight>d__16 val_1 = 536899149;
        val_1 = new GameMenu.<DelayShowTextBossFight>d__16(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536899169] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536899165] = R1;
    }
    public void ShowTextBossDefeat(float time = 0)
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610608775, value:  536893745);
    }
    private System.Collections.IEnumerator DelayShowTextBossDefeat(float time)
    {
        GameMenu.<DelayShowTextBossDefeat>d__18 val_1 = 536899147;
        val_1 = new GameMenu.<DelayShowTextBossDefeat>d__18(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536899167] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536899163] = R1;
    }
    public GameMenu()
    {
    
    }
    private void <Start>b__7_0()
    {
        this.ReplayButtonClick();
    }
    private void <Start>b__7_1()
    {
        this.PauseButtonClick();
    }
    private void <Start>b__7_2()
    {
        this.SkipButtonClick();
    }
    private void <Start>b__7_3(UnityEngine.Component sender, object param)
    {
        this.ResetElements();
    }
    private void <Start>b__7_4(UnityEngine.Component sender, object param)
    {
        this.DisableButtonOnHuggyMove();
    }
    private void <ReplayButtonClick>b__11_0(bool success)
    {
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        R4 + 16.interactable = false;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700957.SpawLevel();
    }
    private void <ReplayButtonClick>b__11_1(bool success)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(mem[3221266279] == true)
        {
                return;
        }
        
        if((R5 + 12) == 0)
        {
                R5 + 12 = mem[R5 + 13];
            R5 + 12 = R5 + 13;
            goto label_2;
        }
        
        return;
        label_2:
        R4 + 16.interactable = false;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        R6.SpawnNextLevel();
    }
    private void <ReplayButtonClick>b__11_2(bool success)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((-1073701079.CanLoadLevel()) == false)
        {
                return;
        }
        
        this.replayButton.interactable = false;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.SpawnNextLevel();
    }

}
