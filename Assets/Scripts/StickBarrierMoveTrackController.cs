using UnityEngine;
public class StickBarrierMoveTrackController : MonoBehaviour
{
    // Fields
    private PlatformMoveController platformMoveController;
    private UnityEngine.SpriteRenderer mainSpriteRender;
    private UnityEngine.SpriteRenderer physicSpriteRender;
    private UnityEngine.Rigidbody2D physicRigidbody2D;
    public bool canApartTotalStick;
    private float speedMove;
    private float timeDelayActivated;
    private bool isCanActivated;
    
    // Methods
    private void Awake()
    {
        this.SetColliderForPhysicCollider();
    }
    private void FixedUpdate()
    {
        this.MovePhysicCollider();
    }
    public void MoveActivated()
    {
        if(this.isCanActivated == false)
        {
                return;
        }
        
        this.platformMoveController.MoveByScriptActivated();
        this.SetTimeDelayActivated();
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610602609);
        if(this.canApartTotalStick != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073700989.ApartTotalStickBarrie();
            this.canApartTotalStick = false;
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610604363, volume:  null);
    }
    private void SetTimeDelayActivated()
    {
        float val_1 = this.platformMoveController.TimeMoveNextIndex();
        this.timeDelayActivated = this.platformMoveController;
    }
    private System.Collections.IEnumerator WaitCanActivated()
    {
        536901503 = new StickBarrierMoveTrackController.<WaitCanActivated>d__12(<>1__state:  0);
        mem[536901519] = this;
    }
    public float AngleOfPathMove()
    {
        float val_2;
        float val_3;
        PlatformMoveController val_13;
        bool val_15;
        float val_16;
        val_13 = this.platformMoveController;
        if(val_13 != 0)
        {
            
        }
        else
        {
                val_13 = this.platformMoveController;
            if(val_13 == 0)
        {
                val_13 = 0;
        }
        
        }
        
        UnityEngine.Vector3 val_1 = GetPositionOfIndex(index:  0);
        float val_14 = val_2;
        float val_13 = val_3;
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Transform val_6 = this.transform;
        val_13 = val_13 - val_3;
        val_14 = val_14 - val_2;
        if(R4 == 0)
        {
            goto label_5;
        }
        
        UnityEngine.Vector3 val_7 = right;
        val_3 = val_13;
        val_2 = val_14;
        label_15:
        float val_8 = val_2.sqrMagnitude;
        float val_9 = -val_2.sqrMagnitude;
        if(mem[536890411] >= _TYPE_MAX_)
        {
                float val_16 = 652813700 * 652813712;
        }
        
        if(mem[536890411] >= 0)
        {
                float val_15 = -val_3;
            val_15 = val_3 * val_15;
            val_16 = val_15 / val_16;
            val_15 = mem[536890482];
            if((val_15 & true) == 0)
        {
                val_15 = mem[536890411];
        }
        
            val_16 = (UnityEngine.Mathf.Clamp(value:  val_16, min:  val_7.y, max:  -val_2)) * 57.29578f;
            return val_16;
        }
        
        val_16 = 0f;
        return val_16;
        label_5:
        UnityEngine.Vector3 val_12 = val_2.right;
        val_3 = val_13;
        val_2 = val_14;
        goto label_15;
    }
    public void SetColliderForPhysicCollider()
    {
        float val_2;
        float val_3;
        float val_7;
        float val_11;
        UnityEngine.Vector2 val_1 = size;
        this.physicSpriteRender.size = new UnityEngine.Vector2() {x = val_2, y = val_3};
        UnityEngine.Transform val_4 = this.physicSpriteRender.transform;
        UnityEngine.Transform val_5 = this.mainSpriteRender.transform;
        UnityEngine.Vector3 val_6 = localPosition;
        this.physicSpriteRender.localPosition = new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_7};
        UnityEngine.Transform val_8 = this.physicSpriteRender.transform;
        UnityEngine.Transform val_9 = this.mainSpriteRender.transform;
        UnityEngine.Quaternion val_10 = localRotation;
        this.physicSpriteRender.localRotation = new UnityEngine.Quaternion() {x = val_2, y = val_3, z = val_7, w = val_11};
        UnityEngine.Transform val_12 = this.physicSpriteRender.transform;
        UnityEngine.Transform val_13 = this.mainSpriteRender.transform;
        UnityEngine.Vector3 val_14 = localScale;
        this.physicSpriteRender.localScale = new UnityEngine.Vector3() {x = R4, y = R6, z = R7};
    }
    private void MovePhysicCollider()
    {
        var val_3;
        float val_4;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Transform val_5 = this.physicRigidbody2D.transform;
        UnityEngine.Vector3 val_6 = position;
        var val_10 = val_3;
        float val_11 = val_4;
        val_10 = val_3 - val_10;
        val_11 = val_4 - val_11;
        float val_9 = UnityEngine.Time.fixedDeltaTime;
        uint val_12 = 0;
        val_11 = (val_11 * this.speedMove) * val_12;
        val_12 = (val_10 * this.speedMove) * val_12;
        this.physicRigidbody2D.velocity = new UnityEngine.Vector2() {y = val_11};
    }
    public StickBarrierMoveTrackController()
    {
        this.speedMove = 2000f;
        this.canApartTotalStick = true;
        this.isCanActivated = true;
    }

}
