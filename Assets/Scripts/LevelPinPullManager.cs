using UnityEngine;
public class LevelPinPullManager : SingletonMonoBehaviour<LevelPinPullManager>
{
    // Fields
    public string levelPrefabPath;
    public CharacterPinPullBase charBase;
    public HuggyPinPullController huggyControl;
    private int totalCoinOfLevel;
    private int totalStickBarrie;
    private int totalEnemy;
    private int currentStickBarrie;
    private int currentEnemy;
    public bool allStickBarrieMove;
    public bool allEnemyDead;
    private UnityEngine.GameObject levelSpawn;
    
    // Methods
    public void SpawnLevel(int id)
    {
        UnityEngine.GameObject val_5 = this.levelSpawn;
        if(val_5 != 0)
        {
                this.charBase = 0;
            this.huggyControl = 0;
            UnityEngine.GameObject val_2 = val_5.gameObject;
            val_5 = val_5;
            UnityEngine.Object.Destroy(obj:  val_5);
        }
        
        System.Collections.IEnumerator val_3 = this.WaitLevelSpawn(id:  id);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  642564368);
    }
    private System.Collections.IEnumerator WaitLevelSpawn(int id)
    {
        LevelPinPullManager.<WaitLevelSpawn>d__12 val_1 = 536899555;
        val_1 = new LevelPinPullManager.<WaitLevelSpawn>d__12(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536899575] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536899571] = id;
    }
    public void ApartFromCoin()
    {
        int val_2 = this.totalCoinOfLevel;
        if(val_2 < 1)
        {
                return;
        }
        
        val_2 = val_2 - 1;
        this.totalCoinOfLevel = val_2;
        if(val_2 > 0)
        {
                return;
        }
        
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Lose();
    }
    public void ApartTotalStickBarrie()
    {
        if(this.currentStickBarrie >= 1)
        {
                this.currentStickBarrie = this.currentStickBarrie - 1;
            this.currentStickBarrie = this.currentStickBarrie;
        }
        
        if(this.currentStickBarrie > 0)
        {
                return;
        }
        
        this.allStickBarrieMove = true;
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
    public void WaitDoneEnemyTargetMoveCharacter()
    {
        this.StopCoroutine(methodName:  -1610602601);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610602601);
    }
    private System.Collections.IEnumerator WaitEnemyTargetMoveCharacter()
    {
        536899553 = new LevelPinPullManager.<WaitEnemyTargetMoveCharacter>d__18(<>1__state:  0);
        mem[536899569] = this;
    }
    public void WaitAllStickMoveCharacter()
    {
        this.StopCoroutine(methodName:  -1610602613);
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610602613);
    }
    private System.Collections.IEnumerator WaitAllStickBarrieMoveCharacter()
    {
        536899551 = new LevelPinPullManager.<WaitAllStickBarrieMoveCharacter>d__20(<>1__state:  0);
        mem[536899567] = this;
    }
    public LevelPinPullManager()
    {
        this.levelPrefabPath = -1610605363;
    }
    private bool <WaitEnemyTargetMoveCharacter>b__18_0()
    {
        if(this.charBase.countEnemyTargetPlayer > 0)
        {
                return false;
        }
        
        if((R4 + 45) != 0)
        {
                R4 + 45 = 1;
        }
        
        return true;
    }
    private bool <WaitAllStickBarrieMoveCharacter>b__20_0()
    {
        if(this.allStickBarrieMove == false)
        {
                return true;
        }
        
        if(this.charBase.countEnemyTargetPlayer > 0)
        {
                return true;
        }
        
        if(this.allEnemyDead == true)
        {
                0 = 1;
        }
        
        return true;
    }

}
