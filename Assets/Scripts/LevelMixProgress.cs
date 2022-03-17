using UnityEngine;
public class LevelMixProgress : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<LevelNode> levelNode;
    
    // Methods
    private void Start()
    {
        this.LoadLevelProgress(isEnd:  false);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  663309712, method:  new IntPtr(1610679411));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  663309712, eventID:  33, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  663309712, method:  new IntPtr(1610679413));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  663309712, eventID:  4, callback:  536873423);
        object val_3 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_5 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelRope) <= (-1073708883.NumberRopeLevel))
        {
                return;
        }
        
        UnityEngine.Transform val_7 = this.transform;
        UnityEngine.Transform val_8 = this.GetChild(index:  0);
        UnityEngine.GameObject val_9 = this.gameObject;
        this.SetActive(value:  false);
    }
    public void LoadLevelProgress(bool isEnd = False)
    {
        var val_11;
        var val_12;
        var val_13;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_2 = -1073708883.CurrentLevel;
        val_11 = 4;
        val_2 = (val_2 >> 1) + (val_2 >> 31);
        val_12 = val_2 + (val_2 << 2);
        goto label_2;
        label_14:
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        val_13 = 0;
        int val_5 = -1073708883.CurrentLevel;
        val_5 = val_5 - 4294967290;
        val_5 = val_5 - 5368709110;
        if((-1073708883) >= val_5)
        {
                object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
            int val_7 = -1073708883.CurrentLevel;
            val_7 = val_7 - 4294967290;
            val_7 = val_7 - 5368709110;
            if((-1073708883) == val_7)
        {
                val_13 = 1;
        }
        
        }
        
        if(val_7 <= (-1073708883))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        var val_9 = (mem[3221266339] + 12) + (val_12 << 2);
        mem[5368709126].UpdateImage(levelType:  (mem[3221266339] + 12 + ((((val_2 >> 1) + (val_2) >> 31) + (((val_2 >> 1) + (val_2) >> 31)) << 2)) << 2) + 16, levelState:  1, level:  -1073708883);
        val_11 = 5;
        val_12 = val_12 + 1;
        label_2:
        if((val_11 - 4) < mem[5368709126])
        {
            goto label_14;
        }
    
    }
    public void ShowAnimVictory()
    {
        var val_4;
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        int val_2 = -1073708883.CurrentLevel;
        val_4 = 4;
        goto label_2;
        label_8:
        if(val_2 <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(397949923 == (val_2 - 4294967295))
        {
            goto label_6;
        }
        
        val_4 = 5;
        label_2:
        if((val_4 - 4) < 397949923)
        {
            goto label_8;
        }
        
        return;
        label_6:
        if(397949923 <= R6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        2621443.ShowAnimCheck();
    }
    public LevelMixProgress()
    {
        536878051 = new System.Collections.Generic.List<Page>();
        this.levelNode = 536878051;
    }
    private void <Start>b__1_0(UnityEngine.Component sender, object param)
    {
        this.LoadLevelProgress(isEnd:  false);
    }
    private void <Start>b__1_1(UnityEngine.Component sender, object param)
    {
        this.ShowAnimVictory();
    }

}
