using UnityEngine;
public class GamePinPullManager : SingletonMonoBehaviour<GamePinPullManager>
{
    // Fields
    private bool <IsWin>k__BackingField;
    private bool <IsLose>k__BackingField;
    private bool <IsPlaying>k__BackingField;
    public int currentLevel;
    public bool WaitingSpawnLevel;
    public bool canReSpawnGameMenu;
    
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
        AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Init(dataPath:  -1610605257, defaultMenuIdentifier:  -1610606485);
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        mem[3221258461] = 1;
        this.StartGame();
    }
    private void StartGame()
    {
        int val_5;
        if((this.<IsPlaying>k__BackingField) != true)
        {
                this.WaitingSpawnLevel = true;
            if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) != false)
        {
                object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
            val_5 = this;
            this.currentLevel = -1073708883.CurrentLevelPinPull;
        }
        else
        {
                val_5 = this.currentLevel;
        }
        
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700989.SpawnLevel(id:  val_5);
            this.<IsPlaying>k__BackingField = true;
        }
        
        this.StartLevelTracking();
    }
    private void StartLevelTracking()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_4 = -1073708883.CurrentLevelPinPull.ToString();
        string val_5 = -1610605497(-1610605497) + 638177556;
        -1073700879.TrackEvent(eventName:  -1610605497);
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelPinPull) <= (-1073708883.LevelPinPullPlayed))
        {
                return;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_13 = -1073708883.CurrentLevelPinPull.ToString();
        string val_14 = -1610605495(-1610605495) + 638177556;
        -1073700879.TrackEvent(eventName:  -1610605495);
        object val_15 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.LevelPinPullPlayed = -1073708883.CurrentLevelPinPull;
    }
    public void SpawnNextLevel()
    {
        int val_11;
        this.CancelInvoke();
        if(this.canReSpawnGameMenu != false)
        {
                AFramework.UI.BaseUIMenu val_1 = AFramework.UI.CanvasManager.Init(dataPath:  -1610605257, defaultMenuIdentifier:  -1610606485);
        }
        
        this.<IsPlaying>k__BackingField = false;
        this.WaitingSpawnLevel = true;
        this.canReSpawnGameMenu = false;
        this.StartLevelTracking();
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536882991 = new System.Action(object:  638301584, method:  new IntPtr(1610679007));
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
            this.currentLevel = -1073708883.CurrentLevelPinPull;
        }
        else
        {
                val_11 = this.currentLevel;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700989.SpawnLevel(id:  val_11);
        this.Invoke(methodName:  -1610602597, time:  null);
    }
    private void WaitPlayingGame()
    {
        this.<IsPlaying>k__BackingField = true;
        this.<IsWin>k__BackingField = false;
        this.<IsLose>k__BackingField = false;
    }
    public void Win(float delayTime = 2)
    {
        if((this.<IsWin>k__BackingField) == true)
        {
                return;
        }
        
        if((R4 + 14) == 0)
        {
                return;
        }
        
        mem2[0] = 1;
        R4.Invoke(methodName:  -1610608795, time:  delayTime);
        R4.Invoke(methodName:  -1610608771, time:  delayTime);
        GameTool.EventDispatcherExtension.PostEvent(sender:  R4, eventID:  4);
    }
    private void DelayShowWin()
    {
        var val_8 = 22742224;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  mem[3221266323])) != false)
        {
                WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].SetSortingLayer(value:  -1610603225);
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((UnityEngine.Object.op_Implicit(exists:  mem[3221266327])) != false)
        {
                WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_8 = mem[mem[3221266327] + 12];
            val_8 = mem[3221266327] + 12;
            val_8.SetSortingLayer(value:  -1610603225);
        }
        
        this.canReSpawnGameMenu = true;
        GameTool.EventDispatcherExtension.PostEvent(sender:  638637584, eventID:  32);
        AFramework.UI.BaseUIMenu val_7 = AFramework.UI.CanvasManager.Push(identifier:  -1610605271, initParams:  null);
    }
    public void Lose()
    {
        if((this.<IsLose>k__BackingField) == true)
        {
                return;
        }
        
        if((R4 + 14) == 0)
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
        
        -1073701101.MoveToCharacter(isWin:  true);
    }
    public void DelayShowLose()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].SetSortingLayer(value:  -1610603225);
        this.canReSpawnGameMenu = true;
        GameTool.EventDispatcherExtension.PostEvent(sender:  638973584, eventID:  32);
        AFramework.UI.BaseUIMenu val_2 = AFramework.UI.CanvasManager.Push(identifier:  -1610605289, initParams:  null);
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
    public GamePinPullManager()
    {
    
    }
    private void <SpawnNextLevel>b__18_0()
    {
        int val_9;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701101.ResetPosCamera();
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266217] = 1;
        if((AFramework.ManualSingletonMono<System.Object>.IsInstanceValid()) != false)
        {
                object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
            val_9 = this;
            this.currentLevel = -1073708883.CurrentLevelPinPull;
        }
        else
        {
                val_9 = this.currentLevel;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700989.SpawnLevel(id:  val_9);
        GameTool.EventDispatcherExtension.PostEvent(sender:  639421584, eventID:  28);
        GameTool.EventDispatcherExtension.PostEvent(sender:  639421584, eventID:  29);
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536882991 = new System.Action(object:  639421584, method:  new IntPtr(1610679009));
        -1073700871.EndFade(action:  536882991);
    }
    private void <SpawnNextLevel>b__18_1()
    {
        this.<IsPlaying>k__BackingField = true;
        this.<IsWin>k__BackingField = false;
        this.<IsLose>k__BackingField = false;
    }

}
