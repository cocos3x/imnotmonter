using UnityEngine;
public class CutTheRopeManager : SingletonMonoBehaviour<CutTheRopeManager>
{
    // Fields
    public bool canReSpawnGameMenu;
    public int currentLevel;
    public bool WaitingSpawnLevel;
    private bool <IsWin>k__BackingField;
    private bool <IsLose>k__BackingField;
    private bool <IsPlaying>k__BackingField;
    
    // Properties
    public bool IsWin { get; set; }
    public bool IsLose { get; set; }
    public bool IsPlaying { get; set; }
    
    // Methods
    public bool get_IsWin()
    {
        return (bool)this.<IsWin>k__BackingField;
    }
    private void set_IsWin(bool value)
    {
        this.<IsWin>k__BackingField = value;
    }
    public bool get_IsLose()
    {
        return (bool)this.<IsLose>k__BackingField;
    }
    private void set_IsLose(bool value)
    {
        this.<IsLose>k__BackingField = value;
    }
    public bool get_IsPlaying()
    {
        return (bool)this.<IsPlaying>k__BackingField;
    }
    private void set_IsPlaying(bool value)
    {
        this.<IsPlaying>k__BackingField = value;
    }
    public override void Awake()
    {
        this.Awake();
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Init(dataPath:  -1610605257, defaultMenuIdentifier:  -1610606489);
        this.StartGame();
    }
    private void StartGame()
    {
        int val_6;
        if((this.<IsPlaying>k__BackingField) == true)
        {
                return;
        }
        
        mem2[0] = 1;
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) != false)
        {
                object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
            val_6 = R4;
            mem2[0] = -1073708883.CurrentLevelCutRope;
        }
        else
        {
                val_6 = R4 + 16;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700997.SpawnLevel(id:  val_6);
        mem2[0] = 1;
    }
    public void SpawnNextLevel()
    {
        int val_11;
        this.CancelInvoke();
        if(this.canReSpawnGameMenu != false)
        {
                AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Init(dataPath:  -1610605257, defaultMenuIdentifier:  -1610606489);
        }
        
        this.<IsPlaying>k__BackingField = false;
        this.canReSpawnGameMenu = false;
        this.WaitingSpawnLevel = true;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536882991 = new System.Action(object:  592746256, method:  new IntPtr(1610678255));
            -1073700871.StartFade(action:  536882991);
            return;
        }
        
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701101.ResetPosCamera();
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266217] = 1;
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) != false)
        {
                object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
            val_11 = this;
            this.currentLevel = -1073708883.CurrentLevelCutRope;
        }
        else
        {
                val_11 = this.currentLevel;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700997.SpawnLevel(id:  val_11);
        this.Invoke(methodName:  -1610602597, time:  null);
    }
    private void WaitPlayingGame()
    {
        this.<IsPlaying>k__BackingField = true;
        this.<IsWin>k__BackingField = false;
        this.<IsLose>k__BackingField = false;
    }
    public bool CanCheck()
    {
        if((this.<IsPlaying>k__BackingField) == false)
        {
                return false;
        }
        
        if((this.<IsWin>k__BackingField) != false)
        {
                return false;
        }
        
        bool val_1 = this.<IsLose>k__BackingField;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public bool CanLoadLevel()
    {
        if(this.WaitingSpawnLevel == false)
        {
                this.WaitingSpawnLevel = this.<IsWin>k__BackingField;
            goto label_0;
        }
        
        return false;
        label_0:
        bool val_1 = this.<IsLose>k__BackingField;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public void Win(float delayTime = 2)
    {
        if((this.<IsWin>k__BackingField) == true)
        {
                return;
        }
        
        if((R4 + 23) == 0)
        {
                return;
        }
        
        mem2[0] = 1;
        R4.Invoke(methodName:  -1610608795, time:  delayTime);
        R4.Invoke(methodName:  -1610608771, time:  delayTime);
        GameTool.EventDispatcherExtension.PostEvent(sender:  R4, eventID:  4);
    }
    public void Lose()
    {
        if((this.<IsLose>k__BackingField) == true)
        {
                return;
        }
        
        if((R4 + 23) == 0)
        {
                return;
        }
        
        if((R4 + 21) != 0)
        {
                return;
        }
        
        mem2[0] = 1;
        R4.Invoke(methodName:  -1610608795, time:  null);
        R4.Invoke(methodName:  -1610608779, time:  null);
        GameTool.EventDispatcherExtension.PostEvent(sender:  R4, eventID:  5);
    }
    public void DelayFollowCharacter()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266217] = 0;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((this.<IsWin>k__BackingField) == true)
        {
                this.<IsWin>k__BackingField = 1;
        }
        
        -1073701107.MoveToCharacter(isWin:  true);
    }
    private void DelayShowWin()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  mem[3221266327])) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].SetSortingLayer(value:  -1610603225);
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  mem[3221266339])) != false)
        {
                WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].SetSortingLayer(value:  -1610603225);
        }
        
        this.canReSpawnGameMenu = true;
        GameTool.EventDispatcherExtension.PostEvent(sender:  593530256, eventID:  32);
        AFramework.UI.BaseUIMenu val_7 = AFramework.UI.CanvasManager.Push(identifier:  -1610605271, initParams:  null);
    }
    public void DelayShowLose()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266327].SetSortingLayer(value:  -1610603225);
        this.canReSpawnGameMenu = true;
        GameTool.EventDispatcherExtension.PostEvent(sender:  593642256, eventID:  32);
        AFramework.UI.BaseUIMenu val_2 = AFramework.UI.CanvasManager.Push(identifier:  -1610605289, initParams:  null);
    }
    public CutTheRopeManager()
    {
    
    }
    private void <SpawnNextLevel>b__17_0()
    {
        var val_12;
        int val_13;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701107.ResetPosCamera();
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266217] = 1;
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) != false)
        {
                object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_5 = -1073708883.CurrentLevelCutRope;
            val_12 = this;
            val_13 = val_5;
            this.currentLevel = val_5;
        }
        else
        {
                val_12 = this;
            val_13 = this.currentLevel;
        }
        
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        if(val_13 > (-1073708883.NumberCutRopeLevel))
        {
                WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700919.LoadSceneHome();
        }
        else
        {
                WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700997.SpawnLevel(id:  this.currentLevel);
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  593866256, eventID:  28);
        GameTool.EventDispatcherExtension.PostEvent(sender:  593866256, eventID:  29);
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536882991 = new System.Action(object:  593866256, method:  new IntPtr(1610678257));
        -1073700871.EndFade(action:  536882991);
    }
    private void <SpawnNextLevel>b__17_1()
    {
        this.<IsPlaying>k__BackingField = true;
        this.<IsWin>k__BackingField = false;
        this.<IsLose>k__BackingField = false;
    }

}
