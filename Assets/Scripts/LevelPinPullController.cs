using UnityEngine;
public class LevelPinPullController : MonoBehaviour
{
    // Fields
    public int totalCoin;
    public int totalStickBarrie;
    public int totalEnemy;
    public CharacterPinPullBase charBase;
    public HuggyPinPullController huggyControl;
    
    // Methods
    private void Start()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.RopeTapeBonusReward = 0;
    }
    public void FindAll()
    {
        this.totalCoin = 0;
        this.totalStickBarrie = 0;
        this.totalEnemy = 0;
        this.FindTotalCoin();
        this.FindTotalStickBarrie();
        this.FindTotalEnemy();
        this.FindCharacter();
    }
    private void FindTotalCoin()
    {
        T[] val_1 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
        this.totalCoin = mem[3221279047];
    }
    private void FindTotalStickBarrie()
    {
        var val_3;
        var val_4;
        T[] val_1 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
        T[] val_2 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
        val_3 = 0;
        goto label_3;
        label_7:
        val_3 = 1;
        if((mem[3221279071] + 28) != 0)
        {
                mem[3221279071] + 28 = this.totalStickBarrie;
            mem[3221279071] + 28 = (mem[3221279071] + 28) + 1;
            this.totalStickBarrie = mem[3221279071] + 28;
        }
        
        label_3:
        if(val_3 < mem[3221279067])
        {
            goto label_7;
        }
        
        var val_3 = (-1073688239) + 16;
        val_4 = 0;
        goto label_8;
        label_12:
        val_4 = 1;
        if(((-1073688239 + 16) + 0 + 28) != 0)
        {
                (-1073688239 + 16) + 0 + 28 = this.totalStickBarrie;
            (-1073688239 + 16) + 0 + 28 = ((-1073688239 + 16) + 0 + 28) + 1;
            this.totalStickBarrie = (-1073688239 + 16) + 0 + 28;
        }
        
        label_8:
        if(val_4 < mem[3221279069])
        {
            goto label_12;
        }
    
    }
    private void FindTotalEnemy()
    {
        T[] val_1 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
        this.totalEnemy = mem[3221279051];
    }
    private void FindCharacter()
    {
        var val_8;
        UnityEngine.GameObject val_1 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  -1610605337);
        val_8 = 22713552;
        if((-1610605337) != 0)
        {
                Weight val_3 = -1610605337.GetComponent<Weight>();
            this.charBase = -1610605337;
        }
        
        UnityEngine.GameObject val_4 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  -1610607699);
        if((-1610607699) == 0)
        {
                return;
        }
        
        Weight val_6 = -1610607699.GetComponent<Weight>();
        this.huggyControl = -1610607699;
    }
    public LevelPinPullController()
    {
    
    }

}
