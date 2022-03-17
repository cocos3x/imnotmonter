using UnityEngine;
public class EnemyCutRopeController : MonoBehaviour
{
    // Fields
    protected CharacterAnimationController animationController;
    protected UnityEngine.BoxCollider2D myCollider;
    protected UnityEngine.Rigidbody2D myRigidbody;
    protected UnityEngine.CircleCollider2D groundCollider;
    protected Spine.Unity.Examples.SkeletonRagdoll2D ragdoll;
    protected Spine.Unity.SkeletonDataAsset deadSkeletonDataAsset;
    protected Spine.Unity.SkeletonAnimation skeletonAnimation;
    private UnityEngine.GameObject mainSkeletonObject;
    private float scaleCharacter;
    protected bool facingLeft;
    protected bool canAim;
    protected bool isDead;
    protected bool canMove;
    protected bool isRunning;
    private float moveSpeed;
    private float directionMove;
    protected bool isFalling;
    protected bool isAttacking;
    protected UnityEngine.GameObject targetObject;
    protected bool isHuggyTarget;
    protected UnityEngine.LayerMask raycastLayer;
    private bool canCheck;
    
    // Methods
    protected void Start()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  596805520, method:  new IntPtr(1610678345));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  536873423, eventID:  4, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  596805520, method:  new IntPtr(1610678347));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  536873423, eventID:  5, callback:  536873423);
        this.canAim = true;
        this.SetScale();
    }
    protected void Update()
    {
        if(this.isDead == true)
        {
                return;
        }
        
        if((R4 + 80) == 0)
        {
                return;
        }
        
        R4.Raycast();
        R4.SetAnimationMove();
    }
    protected void FixedUpdate()
    {
        if(this.isDead == true)
        {
                return;
        }
        
        if((R4 + 80) == 0)
        {
                return;
        }
        
        R4.MoveToTargetObject();
        R4.CheckFalling();
    }
    protected void SetupStart()
    {
        this.canAim = true;
        this.SetScale();
    }
    protected void SetSkin()
    {
        if(((mem[536884966] & true) == 0) && (mem[536884895] == 0))
        {
                536884779 = 536884779;
        }
        
        string val_2 = Berry.Utils.Utils.GetRandom<System.Int32>(collection:  mem[536884871] + 48).ToString();
        string val_3 = mem[536884871] + 8(mem[536884871] + 8) + 597245588;
        mem[536882417] = mem[536884871] + 8;
        mem[536882421] = -1610604243;
        this.animationController.SetSkinMix(skinName:  536882401);
    }
    private void SetScale()
    {
        float val_4;
        var val_5;
        float val_6;
        if(this.facingLeft != false)
        {
                this.directionMove = -1f;
            UnityEngine.Transform val_1 = this.mainSkeletonObject.transform;
            val_4 = this.scaleCharacter;
            val_5 = val_4 ^ 2147483648;
            val_6 = val_5;
        }
        else
        {
                this.directionMove = 1f;
            val_5 = 0;
            UnityEngine.Transform val_2 = this.mainSkeletonObject.transform;
            val_4 = this.scaleCharacter;
            val_6 = val_4;
        }
        
        this.mainSkeletonObject.localScale = new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_4};
    }
    public void Idle()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        this.animationController.SetAnimation(name:  mem[536884873] + 68, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    public void Dead(EnemyDeadBy enemyDeadBy = 0)
    {
        var val_8;
        var val_9;
        var val_10;
        CharacterAnimationController val_11;
        var val_12;
        string val_13;
        val_8 = 22968809;
        if((this.canAim != false) && (this.isDead != true))
        {
                this.isAttacking = false;
            this.isDead = true;
            this.canMove = false;
            this.canCheck = false;
            UnityEngine.GameObject val_1 = this.groundCollider.gameObject;
            this.groundCollider.layer = 14;
            this.myCollider.enabled = false;
            this.myRigidbody.constraints = 5;
            this.animationController.SetOrderLayer(value:  0);
            if((this.targetObject != 0) && ((this.targetObject.CompareTag(tag:  -1610607703)) != false))
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_9 = mem[3221266327];
            if(val_9 != 0)
        {
                val_10 = mem[mem[3221266327] + 20];
            val_10 = mem[3221266327] + 20;
        }
        else
        {
                val_9 = 20;
            val_10 = 1;
        }
        
            mem[20] = 0;
        }
        
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_8 = -1073700997;
            val_8.ApartTotalEnemy();
            if(enemyDeadBy <= 3)
        {
                var val_6 = 3627344 + (3627344 + (enemyDeadBy) << 2);
            if(enemyDeadBy == 3)
        {
                3627344 = 3627344 & (((int)IP) >> 32);
            3627344 = 3627344 & (3627344 << 3627344);
            3627344 = 3627344 & (((int)IP) >> ((3627344 & ((int)IP) >> 32) & ((3627344 & ((int)IP) >> 32)) << (3627344 & ((int)IP) >> 32)));
            3627344 = 3627344 & (3627344 << 3627344);
        }
        
            val_11 = this.animationController;
            val_12 = 536884781;
            if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_12 = 536884781;
        }
        
            val_13 = mem[mem[536884873] + 88];
            val_13 = mem[536884873] + 88;
            SetAnimation(name:  null, loop:  false, timeScale:  null, _callBack:  1065353216);
        }
        
        }
        
        var val_7 = FP - 16;
    }
    protected void AudioDead(TypeEnemyPinPullDie type)
    {
    
    }
    private void CancelAll()
    {
        if(this.isDead == true)
        {
                return;
        }
        
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        R4 + 68 + -48.constraints = 5;
        UnityEngine.Coroutine val_1 = R4.StartCoroutine(methodName:  -1610602591);
    }
    private System.Collections.IEnumerator WaitToIdle()
    {
        536898807 = new EnemyCutRopeController.<WaitToIdle>d__32(<>1__state:  0);
        mem[536898823] = this;
    }
    public void SetMove(bool value)
    {
        this.canMove = value;
    }
    private void SetAnimationMove()
    {
        var val_2;
        var val_3;
        var val_4;
        if(this.canMove == false)
        {
                return;
        }
        
        if(this.isFalling == false)
        {
                this.isFalling = this.isAttacking;
            goto label_2;
        }
        
        return;
        label_2:
        UnityEngine.Vector2 val_1 = velocity;
        float val_4 = System.Math.Abs(val_2);
        if(this.myRigidbody > 0)
        {
            goto label_4;
        }
        
        var val_5 = val_3;
        val_5 = val_5 & (~2147483648);
        if(this.myRigidbody <= 0)
        {
            goto label_5;
        }
        
        label_4:
        if(this.isRunning == true)
        {
                return;
        }
        
        this.isRunning = true;
        val_4 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_4 = 536884781;
        }
        
        this.animationController.SetAnimation(name:  mem[536884873] + 72, loop:  true, timeScale:  0.05f, _callBack:  1065353216);
        return;
        label_5:
        if(this.isRunning == false)
        {
                return;
        }
        
        this.isRunning = false;
        this.Idle();
    }
    private void MoveToTargetObject()
    {
        float val_2;
        float val_6;
        var val_14;
        float val_15;
        if(this.canMove == false)
        {
                return;
        }
        
        if(this.isFalling == false)
        {
                this.isFalling = this.isAttacking;
            goto label_2;
        }
        
        return;
        label_2:
        UnityEngine.Vector2 val_1 = velocity;
        if(this.targetObject == 0)
        {
            goto label_6;
        }
        
        this.ChangeDirectionMoveWithTarget();
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Transform val_7 = this.targetObject.transform;
        UnityEngine.Vector3 val_8 = position;
        var val_14 = val_6;
        val_14 = val_6 - val_14;
        float val_15 = System.Math.Abs(val_14);
        if(this.targetObject <= 0)
        {
            goto label_10;
        }
        
        UnityEngine.Transform val_9 = this.targetObject.transform;
        UnityEngine.Vector3 val_10 = position;
        var val_18 = val_6;
        UnityEngine.Transform val_11 = this.transform;
        UnityEngine.Vector3 val_12 = position;
        float val_16 = val_6;
        float val_17 = val_2;
        val_16 = val_18 - val_16;
        val_17 = val_2 - val_17;
        val_16.Normalize();
        val_18 = val_16 * this.moveSpeed;
        UnityEngine.Vector2 val_13 = velocity;
        val_14 = val_18;
        val_15 = val_2;
        goto label_16;
        label_6:
        this.myRigidbody.velocity = new UnityEngine.Vector2() {x = 0f, y = val_2};
        this.canMove = false;
        return;
        label_10:
        val_14 = 0;
        val_15 = val_2;
        label_16:
        this.myRigidbody.velocity = new UnityEngine.Vector2() {x = 0f, y = val_15};
    }
    protected void ChangeDirectionMoveWithTarget()
    {
        if(this.targetObject == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.targetObject.transform;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Transform val_5 = this.transform;
        UnityEngine.Vector3 val_6 = position;
        if(this < 0)
        {
                0 = 1;
        }
        
        this.facingLeft = true;
        this.SetScale();
    }
    protected void ChangeDirectionMove()
    {
        bool val_1 = this.facingLeft;
        val_1 = val_1 ^ 1;
        this.facingLeft = val_1;
        this.SetScale();
    }
    public void JumpWithSpring()
    {
        if(this.isDead == true)
        {
                return;
        }
        
        this.canMove = false;
        this.Idle();
    }
    private void CheckFalling()
    {
        UnityEngine.Vector2 val_1 = velocity;
        if(this.myRigidbody <= 0)
        {
                0 = 1;
        }
        
        this.isFalling = true;
    }
    protected void Attack()
    {
        var val_4;
        if(this.isAttacking == true)
        {
                return;
        }
        
        this.isAttacking = true;
        this.canMove = false;
        this.isRunning = false;
        val_4 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_4 = 536884781;
        }
        
        536882991 = new System.Action(object:  599038608, method:  new IntPtr(1610678351));
        this.animationController.SetAnimation(name:  mem[536884873] + 76, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608685, volume:  null);
    }
    protected void Raycast()
    {
        float val_3;
        int val_4;
        EnemyCutRopeController val_59;
        EnemyCutRopeController val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        val_59 = this;
        if(this.isAttacking == true)
        {
                return;
        }
        
        UnityEngine.Bounds val_1 = bounds;
        UnityEngine.Vector3 val_2 = center;
        float val_59 = val_3;
        UnityEngine.Bounds val_5 = bounds;
        UnityEngine.Vector3 val_6 = extents;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.left;
        float val_61 = 0.1f;
        float val_8 = val_3 + val_61;
        val_59 = val_59 - val_8;
        int val_9 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.raycastLayer});
        UnityEngine.RaycastHit2D val_10 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 1.976656E-17f, y = val_59}, direction:  new UnityEngine.Vector2() {x = val_4, y = val_3}, distance:  val_8, layerMask:  val_4);
        UnityEngine.Vector2 val_11 = point;
        UnityEngine.Color val_12 = UnityEngine.Color.red;
        float val_60 = val_4;
        val_60 = val_4 - val_60;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_59, y = val_4, z = 0f}, dir:  new UnityEngine.Vector3() {x = val_3 - val_59, y = val_60, z = 0f}, color:  new UnityEngine.Color() {r = val_3});
        UnityEngine.Bounds val_14 = bounds;
        UnityEngine.Vector3 val_15 = center;
        UnityEngine.Bounds val_16 = bounds;
        mem2[0] = val_16.m_Extents.z;
        UnityEngine.Vector3 val_17 = extents;
        UnityEngine.Vector2 val_18 = UnityEngine.Vector2.right;
        float val_19 = val_3 + val_61;
        val_61 = val_3 + val_19;
        int val_20 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.raycastLayer});
        UnityEngine.RaycastHit2D val_21 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 1.976656E-17f, y = val_61}, direction:  new UnityEngine.Vector2() {x = val_4, y = val_3}, distance:  val_19, layerMask:  val_4);
        UnityEngine.Vector2 val_22 = point;
        UnityEngine.Color val_23 = UnityEngine.Color.red;
        float val_62 = val_4;
        val_62 = val_4 - val_62;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_61, y = val_4, z = 0f}, dir:  new UnityEngine.Vector3() {x = val_3 - val_61, y = val_62, z = val_21.m_Collider}, color:  new UnityEngine.Color());
        UnityEngine.Collider2D val_25 = mem[val_21.m_Distance + (8)].collider;
        val_60 = val_59;
        if(599150784 == 0)
        {
            goto label_26;
        }
        
        UnityEngine.Collider2D val_28 = mem[val_21.m_Distance + (8)].collider;
        val_59;
        bool val_29 = mem[val_21.m_Distance + (8)].CompareTag(tag:  -1610605337);
        if(mem[1152921509500977236] != 0)
        {
            goto label_17;
        }
        
        if(val_29 != false)
        {
                val_59 = 0;
            UnityEngine.Collider2D val_30 = mem[val_21.m_Distance + (8)].collider;
            UnityEngine.GameObject val_31 = mem[val_21.m_Distance + (8)].gameObject;
            mem[1152921509500977236] = ;
            mem[1152921509500977240] = val_59;
            mem[1152921509500977219] = 1;
        }
        
        UnityEngine.Collider2D val_32 = mem[val_21.m_Distance + (8)].collider;
        if((mem[val_21.m_Distance + (8)].CompareTag(tag:  -1610607703)) == true)
        {
            goto label_21;
        }
        
        goto label_26;
        label_17:
        if(val_29 == true)
        {
                val_29 = mem[1152921509500977240];
        }
        
        if(val_29 != 0)
        {
            goto label_23;
        }
        
        label_58:
        UnityEngine.Collider2D val_34 = mem[val_21.m_Distance + (8)].collider;
        if(((mem[val_21.m_Distance + (8)].CompareTag(tag:  -1610607703)) == false) || (mem[1152921509500977240] != 0))
        {
            goto label_26;
        }
        
        label_21:
        UnityEngine.Collider2D val_36 = mem[val_21.m_Distance + (8)].collider;
        UnityEngine.GameObject val_37 = mem[val_21.m_Distance + (8)].gameObject;
        mem[1152921509500977236] = ;
        WorldTimeAPI val_38 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_61 = mem[3221266327];
        if(val_61 != 0)
        {
                val_62 = mem[mem[3221266327] + 20];
            val_62 = mem[3221266327] + 20;
        }
        else
        {
                val_61 = 20;
            val_62 = 1;
        }
        
        mem[20] = 2;
        mem[1152921509500977240] = 1;
        mem[1152921509500977219] = 1;
        label_26:
        UnityEngine.Collider2D val_39 = mem[val_21.m_Distance + (0)].collider;
        if(599150776 == 0)
        {
                return;
        }
        
        UnityEngine.Collider2D val_42 = mem[val_21.m_Distance + (0)].collider;
        val_59;
        bool val_43 = mem[val_21.m_Distance + (0)].CompareTag(tag:  -1610605337);
        if(599150784 != 0)
        {
            goto label_37;
        }
        
        if(val_43 != false)
        {
                val_59 = 0;
            UnityEngine.Collider2D val_44 = mem[val_21.m_Distance + (0)].collider;
            UnityEngine.GameObject val_45 = mem[val_21.m_Distance + (0)].gameObject;
            mem[1152921509500977236] = ;
            mem[1152921509500977240] = val_59;
            mem[1152921509500977219] = 1;
        }
        
        UnityEngine.Collider2D val_46 = mem[val_21.m_Distance + (0)].collider;
        if((mem[val_21.m_Distance + (0)].CompareTag(tag:  -1610607703)) == true)
        {
            goto label_41;
        }
        
        return;
        label_37:
        if(val_43 == true)
        {
                val_43 = mem[1152921509500977240];
        }
        
        if(val_43 != 0)
        {
            goto label_43;
        }
        
        label_60:
        UnityEngine.Collider2D val_48 = mem[val_21.m_Distance + (0)].collider;
        if((mem[val_21.m_Distance + (0)].CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
        if(mem[1152921509500977240] != 0)
        {
                return;
        }
        
        label_41:
        UnityEngine.Collider2D val_50 = mem[val_21.m_Distance + (0)].collider;
        UnityEngine.GameObject val_51 = mem[val_21.m_Distance + (0)].gameObject;
        mem[1152921509500977236] = ;
        WorldTimeAPI val_52 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_63 = mem[3221266327];
        if(val_63 != 0)
        {
                val_64 = mem[mem[3221266327] + 20];
            val_64 = mem[3221266327] + 20;
        }
        else
        {
                val_63 = 20;
            val_64 = mem[20];
        }
        
        mem[20] = 3;
        mem[1152921509500977240] = 1;
        mem[1152921509500977219] = 1;
        return;
        label_23:
        WorldTimeAPI val_53 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_65 = mem[3221266327];
        if(val_65 == 0)
        {
            goto label_52;
        }
        
        val_66 = mem[mem[3221266327] + 20];
        val_66 = mem[3221266327] + 20;
        goto label_53;
        label_43:
        WorldTimeAPI val_54 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_67 = mem[3221266327];
        if(val_67 == 0)
        {
            goto label_55;
        }
        
        val_68 = mem[mem[3221266327] + 20];
        val_68 = mem[3221266327] + 20;
        goto label_56;
        label_52:
        val_65 = 20;
        val_66 = mem[20];
        label_53:
        mem[20] = 2;
        UnityEngine.Collider2D val_55 = mem[val_21.m_Distance + (8)].collider;
        UnityEngine.GameObject val_56 = mem[val_21.m_Distance + (8)].gameObject;
        mem[1152921509500977236] = ;
        mem[1152921509500977240] = 0;
        mem[1152921509500977219] = 1;
        goto label_58;
        label_55:
        val_67 = 20;
        val_68 = mem[20];
        label_56:
        mem[20] = 1;
        UnityEngine.Collider2D val_57 = mem[val_21.m_Distance + (0)].collider;
        UnityEngine.GameObject val_58 = mem[val_21.m_Distance + (0)].gameObject;
        mem[1152921509500977236] = ;
        mem[1152921509500977240] = 0;
        mem[1152921509500977219] = 1;
        goto label_60;
    }
    public void SetTypeDie(TypeEnemyPinPullDie typeDie)
    {
    
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        float val_4;
        if((collision.CompareTag(tag:  -1610605337)) != true)
        {
                if((collision.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector2 val_3 = velocity;
        22968817 = this.myRigidbody;
        22968817.velocity = new UnityEngine.Vector2() {x = 0f, y = val_4};
        this.Attack();
    }
    private void RemoveRigidbody()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        UnityEngine.Object.Destroy(obj:  599539856);
        UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
        this.enabled = false;
    }
    private void LaunchRagDoll()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        UnityEngine.Object.Destroy(obj:  599664144);
        UnityEngine.GameObject val_2 = this.groundCollider.gameObject;
        this.groundCollider.SetActive(value:  false);
        this.mainSkeletonObject.SetActive(value:  false);
        UnityEngine.GameObject val_3 = this.ragdoll.gameObject;
        this.ragdoll.SetActive(value:  true);
    }
    public void SetSkeletonDataAsset(Spine.Unity.SkeletonAnimation ske, Spine.Unity.SkeletonDataAsset asset, string skinName)
    {
        if(ske != 0)
        {
                mem2[0] = asset;
        }
        else
        {
                mem[12] = asset;
        }
        
        mem2[0] = skinName;
        this.ragdoll.Apply();
        goto typeof(Spine.Unity.SkeletonAnimation).__il2cppRuntimeField_104;
    }
    public EnemyCutRopeController()
    {
        this.scaleCharacter = 0.26f;
        this.moveSpeed = 1f;
        this.directionMove = 1f;
        this.isHuggyTarget = true;
        this.canCheck = true;
    }
    private void <Start>b__22_0(UnityEngine.Component o, object sender)
    {
        this.CancelAll();
    }
    private void <Start>b__22_1(UnityEngine.Component o, object sender)
    {
        this.CancelAll();
    }
    private bool <WaitToIdle>b__32_0()
    {
        bool val_1 = this.isAttacking;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    private void <Attack>b__40_0()
    {
        this.Idle();
        this.targetObject = 0;
        mem[1152921509502228305] = 0;
    }

}
