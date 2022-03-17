using UnityEngine;
public class GameRopeManager : SingletonMonoBehaviour<GameRopeManager>
{
    // Fields
    private bool <IsWin>k__BackingField;
    private bool <IsLose>k__BackingField;
    private UnityEngine.GameObject ObjTutorial;
    private bool canShowTut;
    
    // Properties
    public bool IsWin { get; set; }
    public bool IsLose { get; set; }
    
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
    private void Start()
    {
        var val_18;
        var val_19;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_18 = -1073701053;
        var val_18 = mem[536891407];
        val_18 = val_18 & 512;
        if(mem[3221266267] == 0)
        {
            goto label_2;
        }
        
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.ObjTutorial, y:  0);
        if(val_2 == false)
        {
            goto label_11;
        }
        
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_5 = -1073708883.CurrentLevelRope.ToString();
        val_18 = 22789004;
        string val_6 = -1610606667(-1610606667) + 741706376;
        if((UnityEngine.PlayerPrefs.GetInt(key:  -1610606667, defaultValue:  0)) == 0)
        {
            goto label_7;
        }
        
        this.canShowTut = false;
        goto label_11;
        label_2:
        label_26:
        if(this.ObjTutorial == 0)
        {
            goto label_11;
        }
        
        label_25:
        this.Invoke(methodName:  -1610604565, time:  null);
        return;
        label_11:
        val_2.PlayGame();
        return;
        label_7:
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_11 = -1073708883.CurrentLevelRope.ToString();
        string val_12 = -1610606667(-1610606667) + 741706376;
        UnityEngine.PlayerPrefs.SetInt(key:  -1610606667, value:  1);
        val_19 = 0;
        goto label_14;
        label_24:
        val_19 = 1;
        this.canShowTut = false;
        label_14:
        WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(val_19 >= (mem[3221266267] + 24 + 12))
        {
            goto label_26;
        }
        
        WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_15 = (mem[3221266267] + 24) + 4;
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        if(((mem[3221266267] + 24 + 4) + 16) != (-1073708883.CurrentLevelRope))
        {
            goto label_24;
        }
        
        this.canShowTut = true;
        goto label_25;
    }
    private void ShowTutorial()
    {
        this.ObjTutorial.SetActive(value:  true);
    }
    public void PlayGame()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266371] = 1;
    }
    private void OnEnable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  742066704, method:  new IntPtr(1610680655));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  742066704, eventID:  4, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  742066704, method:  new IntPtr(1610680657));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  742066704, eventID:  5, callback:  536873423);
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.RopeCoinBonusReward = 0;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.RopeTapeBonusReward = 0;
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  742178704, method:  new IntPtr(1610680659));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  742178704, eventID:  4, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  742178704, method:  new IntPtr(1610680661));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  742178704, eventID:  5, callback:  536873423);
    }
    private void DelayShowWin()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266355] = 1;
        GameTool.EventDispatcherExtension.PostEvent(sender:  742290704, eventID:  32);
        AFramework.UI.BaseUIMenu val_2 = AFramework.UI.CanvasManager.Push(identifier:  -1610605271, initParams:  null);
    }
    public void LevelCompleted()
    {
        if((this.<IsLose>k__BackingField) == false)
        {
                this.<IsLose>k__BackingField = this.<IsWin>k__BackingField;
            goto label_1;
        }
        
        return;
        label_1:
        this.<IsWin>k__BackingField = true;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266371] = 0;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536882991 = new System.Action(object:  742402704, method:  new IntPtr(1610680649));
        -1073700933.SetAnimWin(_callBack:  536882991);
    }
    private void ZoomCam()
    {
        var val_5;
        var val_6;
        var val_7;
        UnityEngine.Debug.Log(message:  -1610602397);
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_3 = -1073700933.transform;
        UnityEngine.Vector3 val_4 = position;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        536882991 = new System.Action(object:  742514704, method:  new IntPtr(1610680663));
        float val_12 = 0f;
        float val_13 = 0.343f;
        val_12 = val_7 + val_12;
        val_13 = val_6 + val_13;
        if(((-1073708883.CurrentLevelRope) - 4294967290) == 0)
        {
                18106660 = 18106664;
        }
        
        float val_14 = 0f;
        val_14 = val_5 + val_14;
        -1073700957.ZoomCamera(posCamMove:  new UnityEngine.Vector3() {x = val_14, y = val_13, z = val_12}, timeZoom:  val_12, timeDelay:  val_4.y, _callback:  1067030938);
    }
    public void LevelFailed()
    {
        var val_7;
        float val_8;
        float val_9;
        var val_11;
        object val_12;
        System.Action val_13;
        if((this.<IsLose>k__BackingField) == false)
        {
                this.<IsLose>k__BackingField = this.<IsWin>k__BackingField;
            goto label_1;
        }
        
        return;
        label_1:
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266371] = 0;
        this.<IsLose>k__BackingField = true;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700933.SetAimLose();
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Transform val_5 = -1073700933.transform;
        UnityEngine.Vector3 val_6 = position;
        float val_12 = val_8;
        float val_11 = val_9;
        float val_13 = 0f;
        val_11 = 536899153;
        if(((mem[536899340] & true) == 0) && (mem[536899269] == 0))
        {
                val_11 = 536899153;
        }
        
        val_11 = val_11 + val_13;
        val_12 = mem[536899245];
        val_12 = val_12 + 0.343f;
        val_13 = val_7 + val_13;
        val_13 = mem[mem[536899245] + 4];
        val_13 = mem[536899245] + 4;
        if(val_13 == 0)
        {
                if(((mem[536899340] & true) == 0) && (mem[536899269] == 0))
        {
                val_12 = mem[536899245];
        }
        
            val_13 = 536882991;
            val_13 = new System.Action(object:  val_12, method:  new IntPtr(1610680669));
            mem2[0] = val_13;
        }
        
        -1073700957.ZoomCamera(posCamMove:  new UnityEngine.Vector3() {x = val_13, y = val_12, z = val_11}, timeZoom:  val_6.x, timeDelay:  val_6.y, _callback:  1060320051);
    }
    public GameRopeManager()
    {
    
    }
    private void <OnEnable>b__13_0(UnityEngine.Component comp, object param)
    {
        this.LevelCompleted();
    }
    private void <OnEnable>b__13_1(UnityEngine.Component comp, object param)
    {
        this.LevelFailed();
    }
    private void <OnDisable>b__14_0(UnityEngine.Component comp, object param)
    {
        this.LevelCompleted();
    }
    private void <OnDisable>b__14_1(UnityEngine.Component comp, object param)
    {
        this.LevelFailed();
    }
    private void <ZoomCam>b__17_0()
    {
        this.Invoke(methodName:  -1610608771, time:  null);
    }

}
