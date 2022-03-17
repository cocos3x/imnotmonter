using UnityEngine;
public class LevelRopeProgressNotes : SingletonMonoBehaviour<LevelRopeProgressNotes>
{
    // Fields
    private System.Collections.Generic.List<LevelNote> levelNotes;
    private LevelRopeData data;
    private bool canDeative;
    public bool isDeactive;
    private int startStep;
    private int addedLVStep;
    private static bool isGotData;
    private bool showedBanner;
    
    // Methods
    private void Awake()
    {
        if(mem[536889689] == 0)
        {
                mem[536889689] = 1;
            mem2[0] = mem[536889689];
        }
    
    }
    private void Start()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((mem[3221266339] + 8) != 0)
        {
                object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
            if((-1073708883.IsOldUser) == false)
        {
                return;
        }
        
        }
        
        this.LoadLevelProgress(isEnd:  false);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  828342288, method:  new IntPtr(1610681943));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  828342288, eventID:  33, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  828342288, method:  new IntPtr(1610681945));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  828342288, eventID:  4, callback:  536873423);
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelRope) <= (-1073708883.NumberRopeLevel))
        {
                return;
        }
        
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Transform val_11 = this.GetChild(index:  0);
        UnityEngine.GameObject val_12 = this.gameObject;
        this.SetActive(value:  false);
    }
    public void LoadLevelProgress(bool isEnd = False)
    {
        var val_11;
        int val_12;
        var val_13;
        LevelRopeType val_14;
        var val_15;
        LevelRopeType val_16;
        var val_17;
        int val_18;
        var val_9 = 4729953;
        val_9 = 18269916 + val_9;
        if(val_9 == 0)
        {
                mem2[0] = 1;
        }
        
        val_11 = 22740800;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        val_12 = -1073708883;
        val_13 = 0;
        int val_2 = val_12.CurrentLevelRope;
        val_2 = val_2 - 1;
        this.startStep = 4294967295;
        val_2 = val_2 - 4294967295;
        this.addedLVStep = val_2;
        goto label_3;
        label_27:
        val_14 = val_13 + this.startStep;
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_4 = val_14 + 1;
        int val_5 = -1073708883.NumberRopeLevel;
        if(val_14 >= val_5)
        {
            goto label_5;
        }
        
        val_12 = this.addedLVStep;
        if(val_13 >= val_12)
        {
            goto label_6;
        }
        
        if(val_5 <= val_13)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + 0;
        val_15 = mem[(0 + 0) + 16];
        val_15 = (0 + 0) + 16;
        val_12 = val_13 + this.startStep;
        LevelRopeInfo val_11 = this.data.listLevelRope[val_12];
        val_14 = this.data.listLevelRope[(val_13 + this.startStep)][0].levelType;
        val_16 = val_14;
        val_17 = 1;
        goto label_14;
        label_5:
        if(val_5 <= val_13)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + 0;
        val_12 = mem[(0 + 0) + 16];
        val_12 = (0 + 0) + 16;
        val_16 = 0;
        val_17 = 0;
        val_18 = val_4;
        goto label_18;
        label_6:
        if(val_5 <= val_13)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + 0;
        val_15 = mem[(0 + 0) + 16];
        val_15 = (0 + 0) + 16;
        LevelRopeInfo val_14 = this.data.listLevelRope[val_13 + this.startStep];
        val_14 = this.data.listLevelRope[(val_13 + this.startStep)][0].levelType;
        val_11 = 22740800;
        if(val_13 != val_12)
        {
                0 = 0;
        }
        
        val_16 = val_14;
        if(val_13 == val_12)
        {
                val_17 = 2;
        }
        
        label_14:
        val_18 = val_4;
        label_18:
        val_15.UpdateRopeImage(levelType:  val_16, levelState:  2, level:  val_18);
        val_13 = 1;
        label_3:
        if(val_13 < val_15)
        {
            goto label_27;
        }
        
        System.Collections.IEnumerator val_7 = this.DeactiveChild();
        UnityEngine.Coroutine val_8 = this.StartCoroutine(routine:  828568976);
    }
    public LevelRopeType GetLevelMode()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        var val_3 = -1073708883.CurrentLevelRope;
        val_3 = val_3 - 1;
        if(this.data.listLevelRope[val_3] != 0)
        {
                return;
        }
    
    }
    private void SetLineValue(int value)
    {
    
    }
    private void SetCanDeactive()
    {
        this.canDeative = true;
    }
    private System.Collections.IEnumerator DeactiveChild()
    {
        536899559 = new LevelRopeProgressNotes.<DeactiveChild>d__13(<>1__state:  0);
        mem[536899575] = this;
    }
    public void ActiveChild(bool active)
    {
        if(active == true)
        {
                return;
        }
        
        if(this.canDeative == false)
        {
                return;
        }
        
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
        this.enabled = false;
    }
    public void ForceDisable()
    {
    
    }
    public void ShowAnimVictory()
    {
        goto label_1;
        label_33:
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_2 = -1073708883.GameMode;
        if(val_2 == 0)
        {
                if(val_2 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_4 = -1073708883.CurrentLevelRope;
            if((-1895825179) == val_4)
        {
                if(val_4 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            2621443.ShowAnimCheck();
        }
        
        }
        
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_6 = -1073708883.GameMode;
        if(val_6 == 1)
        {
                if(val_6 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            object val_7 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_8 = -1073708883.CurrentLevelPinPull;
            if((-1895825179) == val_8)
        {
                if(val_8 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            2621443.ShowAnimCheck();
        }
        
        }
        
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_10 = -1073708883.GameMode;
        if(val_10 == 2)
        {
                if(val_10 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_12 = -1073708883.CurrentLevelCutRope;
            if((-1895825179) == val_12)
        {
                if(val_12 <= R7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            2621443.ShowAnimCheck();
        }
        
        }
        
        4 = 5;
        label_1:
        if((4 - 4) < 2621443)
        {
            goto label_33;
        }
    
    }
    public LevelRopeProgressNotes()
    {
        536878055 = new System.Collections.Generic.List<Page>();
        this.levelNotes = 536878055;
    }
    private void <Start>b__8_0(UnityEngine.Component sender, object param)
    {
        this.LoadLevelProgress(isEnd:  false);
    }
    private void <Start>b__8_1(UnityEngine.Component sender, object param)
    {
        this.ShowAnimVictory();
    }

}
