using UnityEngine;
public class LevelCutRopeController : MonoBehaviour
{
    // Fields
    public int totalRope;
    public int totalHuggyRope;
    public int totalEnemy;
    public HuggyCutRopeBase huggyBase;
    public MistressCutRopeController mistressControl;
    
    // Methods
    public void FindAll()
    {
        this.totalRope = 0;
        this.totalHuggyRope = 0;
        this.totalEnemy = 0;
        this.FindTotalRope();
        this.FindTotalHuggyRope();
        this.FindTotalEnemy();
    }
    private void FindTotalRope()
    {
        var val_2;
        T[] val_1 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
        val_2 = 0;
        goto label_3;
        label_7:
        val_2 = 1;
        if((mem[3221279069] + 36) != 0)
        {
                mem[3221279069] + 36 = this.totalRope;
            mem[3221279069] + 36 = (mem[3221279069] + 36) + 1;
            this.totalRope = mem[3221279069] + 36;
        }
        
        label_3:
        if(val_2 < mem[3221279065])
        {
            goto label_7;
        }
    
    }
    private void FindTotalHuggyRope()
    {
        var val_2;
        T[] val_1 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
        val_2 = 0;
        goto label_3;
        label_7:
        val_2 = 1;
        if((mem[3221279069] + 38) != 0)
        {
                mem[3221279069] + 38 = this.totalHuggyRope;
            mem[3221279069] + 38 = (mem[3221279069] + 38) + 1;
            this.totalHuggyRope = mem[3221279069] + 38;
        }
        
        label_3:
        if(val_2 < mem[3221279065])
        {
            goto label_7;
        }
    
    }
    private void FindTotalEnemy()
    {
        T[] val_1 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
        this.totalEnemy = mem[3221279049];
    }
    public LevelCutRopeController()
    {
    
    }

}
