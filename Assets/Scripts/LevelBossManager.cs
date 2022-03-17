using UnityEngine;
public class LevelBossManager : SingletonMonoBehaviour<LevelBossManager>
{
    // Fields
    private System.Collections.Generic.List<MapBossInfo> infoMaps;
    private UnityEngine.Camera cameraMain;
    private BossRopeRescueController bossController;
    private PlayerController playerController;
    public bool camMoving;
    
    // Properties
    public int TotalHeathBoss { get; }
    
    // Methods
    public int get_TotalHeathBoss()
    {
        if(this.infoMaps != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    private void Start()
    {
        if(this.cameraMain == 0)
        {
                UnityEngine.Camera val_2 = UnityEngine.Camera.main;
            this.cameraMain = 0;
        }
        
        UnityEngine.Transform val_3 = this.cameraMain.transform;
        if(this.cameraMain == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector3 val_4 = position;
        this.cameraMain.position = new UnityEngine.Vector3() {x = R4, y = R6, z = R7};
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701045.ShowTextBossFight(time:  val_4.x);
    }
    public void MoveMap(int indexMap)
    {
        float val_2;
        float val_3;
        float val_4;
        if(true <= indexMap)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + (indexMap << 2);
        UnityEngine.Vector3 val_1 = position;
        this.bossController.MoveToPos(posMove:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
        val_2 = indexMap;
        UnityEngine.Coroutine val_5 = this.StartCoroutine(methodName:  -1610608789, value:  536888987);
    }
    private System.Collections.IEnumerator DelayMoveCamera(int indexMap)
    {
        LevelBossManager.<DelayMoveCamera>d__9 val_1 = 536899543;
        val_1 = new LevelBossManager.<DelayMoveCamera>d__9(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536899559] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536899563] = indexMap;
    }
    public LevelBossManager()
    {
    
    }
    private void <DelayMoveCamera>b__9_1()
    {
        this.camMoving = false;
    }

}
