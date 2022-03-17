using UnityEngine;
public class EnemyRedGreenLightController : MonoBehaviour
{
    // Fields
    private CharacterAnimationController characterAnimationControl;
    private UnityEngine.SpriteRenderer shadowFakeSprireRender;
    private Spine.Unity.SkeletonAnimation mainSkeleton;
    private Spine.Unity.SkeletonAnimation deadSkeleton;
    private bool customLayer;
    private bool isDead;
    private bool <isShooting>k__BackingField;
    
    // Properties
    public bool isShooting { get; set; }
    
    // Methods
    public bool get_isShooting()
    {
        return (bool)this.<isShooting>k__BackingField;
    }
    private void set_isShooting(bool value)
    {
        this.<isShooting>k__BackingField = value;
    }
    private void Start()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  679199248, method:  new IntPtr(1610679663));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  536873423, eventID:  21, callback:  536873423);
        if(this.customLayer == true)
        {
                return;
        }
        
        R4.SetOrderLayer();
    }
    public void Shoot()
    {
        var val_4;
        if((this.<isShooting>k__BackingField) == false)
        {
                this.<isShooting>k__BackingField = this.isDead;
            goto label_1;
        }
        
        return;
        label_1:
        this.<isShooting>k__BackingField = true;
        val_4 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_4 = 536884781;
        }
        
        536882991 = new System.Action(object:  679315344, method:  new IntPtr(1610679665));
        this.characterAnimationControl.SetAnimation(name:  mem[536884873] + 76, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610607853, volume:  null);
    }
    public void Idle()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        this.characterAnimationControl.SetAnimation(name:  mem[536884873] + 68, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    private void SetOrderLayer()
    {
        var val_3;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        float val_7 = 100f;
        val_7 = val_3 * val_7;
        int val_4 = UnityEngine.Mathf.RoundToInt(f:  val_7);
        int val_5 = 0 - val_4;
        this.characterAnimationControl.SetOrderLayer(value:  val_5);
        UnityEngine.Transform val_6 = this.deadSkeleton.GetComponent<UnityEngine.Transform>();
        this.deadSkeleton.sortingOrder = val_5;
        this.shadowFakeSprireRender.sortingOrder = ~val_4;
    }
    public void Dead()
    {
        float val_9;
        var val_12;
        this.isDead = true;
        UnityEngine.GameObject val_1 = this.mainSkeleton.gameObject;
        this.mainSkeleton.SetActive(value:  false);
        UnityEngine.GameObject val_2 = this.deadSkeleton.gameObject;
        this.deadSkeleton.SetActive(value:  true);
        this.SetAnimationForSkeletonDead();
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_5 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  6).ToString();
        string val_6 = -1610609931(-1610609931) + 679684364;
        UnityEngine.Transform val_7 = this.transform;
        UnityEngine.Vector3 val_8 = position;
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Vector3 val_11 = position;
        float val_16 = 2f;
        val_16 = val_12 + val_16;
        UnityEngine.GameObject val_13 = -1073701087.GetItem(key:  -1610609931, position:  new UnityEngine.Vector3() {x = val_9, y = val_16, z = 0f});
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608733, volume:  val_16);
    }
    private void SetAnimationForSkeletonDead()
    {
        Spine.Animation val_1 = this.deadSkeleton.FindAnimation(animationName:  -1610600803);
        if(this.deadSkeleton == 0)
        {
                return;
        }
        
        Spine.AnimationState val_2 = this.deadSkeleton.AnimationState;
        Spine.TrackEntry val_3 = this.deadSkeleton.SetAnimation(trackIndex:  0, animationName:  -1610600803, loop:  false);
        mem2[0] = 1065353216;
    }
    public EnemyRedGreenLightController()
    {
    
    }
    private void <Start>b__10_0(UnityEngine.Component sender, object param)
    {
        this.Shoot();
    }
    private void <Shoot>b__11_0()
    {
        this.<isShooting>k__BackingField = false;
        this.Idle();
    }

}
