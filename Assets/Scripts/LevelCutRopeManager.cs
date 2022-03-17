using UnityEngine;
public class LevelCutRopeManager : SingletonMonoBehaviour<LevelCutRopeManager>
{
    // Fields
    public bool allRopeCut;
    public bool allHuggyRopeCut;
    public bool allEnemyDead;
    private int currentRope;
    private int currentHuggyRope;
    private int currentEnemy;
    public HuggyCutRopeBase huggyBase;
    public string levelPrefabPath;
    private UnityEngine.GameObject levelSpawn;
    public MistressCutRopeController mistressControl;
    private int totalRope;
    private int totalHuggyRope;
    private int totalEnemy;
    
    // Methods
    public void SpawnLevel(int id)
    {
        UnityEngine.GameObject val_5 = this.levelSpawn;
        if(val_5 != 0)
        {
                this.huggyBase = 0;
            this.mistressControl = 0;
            UnityEngine.GameObject val_2 = val_5.gameObject;
            val_5 = val_5;
            UnityEngine.Object.Destroy(obj:  val_5);
        }
        
        System.Collections.IEnumerator val_3 = this.WaitLevelSpawn(id:  id);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  607845392);
    }
    private void StartLevelTracking()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_4 = -1073708883.CurrentLevelCutRope.ToString();
        string val_5 = -1610609739(-1610609739) + 607949460;
        -1073700879.TrackEvent(eventName:  -1610609739);
        object val_6 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_8 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.CurrentLevelCutRope) <= (-1073708883.LevelCutRopePlayed))
        {
                return;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        object val_11 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_13 = -1073708883.CurrentLevelCutRope.ToString();
        string val_14 = -1610609737(-1610609737) + 607949460;
        -1073700879.TrackEvent(eventName:  -1610609737);
        object val_15 = AFramework.ManualSingletonMono<System.Object>.I;
        object val_16 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.LevelCutRopePlayed = -1073708883.CurrentLevelCutRope;
    }
    private System.Collections.IEnumerator WaitLevelSpawn(int id)
    {
        LevelCutRopeManager.<WaitLevelSpawn>d__15 val_1 = 536899547;
        val_1 = new LevelCutRopeManager.<WaitLevelSpawn>d__15(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536899567] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536899563] = id;
    }
    public void ApartTotalRope()
    {
        if(this.currentRope >= 1)
        {
                this.currentRope = this.currentRope - 1;
            this.currentRope = this.currentRope;
        }
        
        if(this.currentRope > 0)
        {
                return;
        }
        
        this.allRopeCut = true;
    }
    public void ApartTotalHuggyRope()
    {
        if(this.currentHuggyRope >= 1)
        {
                this.currentHuggyRope = this.currentHuggyRope - 1;
            this.currentHuggyRope = this.currentHuggyRope;
        }
        
        if(this.currentHuggyRope > 0)
        {
                return;
        }
        
        this.allHuggyRopeCut = true;
    }
    public void ApartTotalEnemy()
    {
        if(this.currentEnemy >= 1)
        {
                this.currentEnemy = this.currentEnemy - 1;
            this.currentEnemy = this.currentEnemy;
        }
        
        if(this.currentEnemy > 0)
        {
                return;
        }
        
        this.allEnemyDead = true;
    }
    public void ActiveChild(bool active)
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Transform val_2 = this.GetChild(index:  0);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  active);
    }
    public void WaitDoneMoveHuggy()
    {
        this.StopCoroutine(methodName:  -1610602599);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610602599);
    }
    private System.Collections.IEnumerator WaitMoveHuggy()
    {
        536899549 = new LevelCutRopeManager.<WaitMoveHuggy>d__21(<>1__state:  0);
        mem[536899565] = this;
    }
    public void WaitAllRopeCutDoneMoveHuggy()
    {
        this.StopCoroutine(methodName:  -1610602615);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610602615);
    }
    private System.Collections.IEnumerator WaitAllRopeCutMoveHuggy()
    {
        536899545 = new LevelCutRopeManager.<WaitAllRopeCutMoveHuggy>d__23(<>1__state:  0);
        mem[536899561] = this;
    }
    public LevelCutRopeManager()
    {
        this.levelPrefabPath = -1610608971;
    }
    private bool <WaitMoveHuggy>b__21_0()
    {
        if(this.huggyBase.countEnemyTargetPlayer < 1)
        {
                0 = 1;
        }
        
        return true;
    }
    private bool <WaitAllRopeCutMoveHuggy>b__23_0()
    {
        if(this.allRopeCut == false)
        {
                this = 0;
            return (bool)this;
        }
        
        if(256 < 1)
        {
                0 = 1;
        }
        
        return true;
    }

}
