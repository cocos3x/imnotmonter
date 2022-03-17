using UnityEngine;
public abstract class EnemyPinPullBase : MonoBehaviour
{
    // Fields
    protected CharacterAnimationController animationController;
    protected UnityEngine.BoxCollider2D myCollider;
    protected UnityEngine.Rigidbody2D myRigidbody;
    protected UnityEngine.CircleCollider2D groundCollider;
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
    protected UnityEngine.LayerMask raycastLayer;
    private bool canCheck;
    private TypeEnemyPinPullDie typeEnemyPinPullDie;
    
    // Methods
    protected virtual void Start()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  622867856, method:  new IntPtr(1610678761));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  536873423, eventID:  4, callback:  536873423);
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  622867856, method:  new IntPtr(1610678763));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  536873423, eventID:  5, callback:  536873423);
        goto typeof(EnemyPinPullBase).__il2cppRuntimeField_F4;
    }
    protected virtual void Update()
    {
        if(this.isDead == true)
        {
                return;
        }
        
        if((R4 + 64) == 0)
        {
                return;
        }
        
        R4.SetAnimationMove();
    }
    protected virtual void FixedUpdate()
    {
        if(this.isDead == true)
        {
                return;
        }
        
        if((R4 + 64) == 0)
        {
                return;
        }
        
        R4.MoveToTargetObject();
        R4.CheckFalling();
    }
    protected virtual void SetupStart()
    {
        this.canAim = true;
        this.SetScale();
    }
    protected virtual void SetSkin()
    {
        if(((mem[536884966] & true) == 0) && (mem[536884895] == 0))
        {
                536884779 = 536884779;
        }
        
        string val_2 = Berry.Utils.Utils.GetRandom<System.Int32>(collection:  mem[536884871] + 48).ToString();
        string val_3 = mem[536884871] + 8(mem[536884871] + 8) + 623307924;
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
    public void Dead()
    {
        CharacterAnimationController val_7;
        var val_8;
        string val_9;
        var val_14;
        if(this.canAim == false)
        {
                return;
        }
        
        if((this.isDead & true) == 0)
        {
                return;
        }
        
        this.isAttacking = false;
        this.isDead = true;
        this.canMove = false;
        this.canCheck = false;
        UnityEngine.GameObject val_1 = this.groundCollider.gameObject;
        this.groundCollider.layer = 14;
        this.myCollider.enabled = false;
        this.myRigidbody.constraints = 5;
        this.animationController.SetOrderLayer(value:  0);
        if(this.typeEnemyPinPullDie <= 4)
        {
                var val_2 = 3638220 + (3638220 + (this.typeEnemyPinPullDie) << 2);
            if(this.typeEnemyPinPullDie == 4)
        {
                3638220 + (this.typeEnemyPinPullDie) << 2 = (3638220 + (this.typeEnemyPinPullDie) << 2) & (this << (3638220 + (this.typeEnemyPinPullDie) << 2));
            3638220 + (this.typeEnemyPinPullDie) << 2 = (3638220 + (this.typeEnemyPinPullDie) << 2) & ((3638220 + (this.typeEnemyPinPullDie) << 2) >> (3638220 + (this.typeEnemyPinPullDie) << 2));
            3638220 + (this.typeEnemyPinPullDie) << 2 = (3638220 + (this.typeEnemyPinPullDie) << 2) & ((IP) << 1);
            3638220 + (this.typeEnemyPinPullDie) << 2 = (3638220 + (this.typeEnemyPinPullDie) << 2) & (((int)R8) >> 1);
            3638220 + (this.typeEnemyPinPullDie) << 2 = (3638220 + (this.typeEnemyPinPullDie) << 2) & 2494951488;
        }
        
            val_7 = this.animationController;
            val_8 = 536884781;
            if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_8 = 536884781;
        }
        
            val_9 = mem[mem[536884873] + 80];
            val_9 = mem[536884873] + 80;
            SetAnimation(name:  null, loop:  false, timeScale:  null, _callBack:  1065353216);
        }
        
        if((this.targetObject != 0) && ((this.targetObject.CompareTag(tag:  -1610605337)) != false))
        {
                WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_14 = mem[3221266323];
            if(val_14 != 0)
        {
                val_9 = mem[mem[3221266323] + 48];
            val_9 = mem[3221266323] + 48;
        }
        else
        {
                val_14 = 48;
            val_9 = 1835037;
        }
        
            mem[48] = 1835036;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700989.ApartTotalEnemy();
    }
    protected virtual void AudioDead(TypeEnemyPinPullDie type)
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
        R4 + 56 + -36.constraints = 5;
        UnityEngine.Coroutine val_1 = R4.StartCoroutine(methodName:  -1610602591);
    }
    private System.Collections.IEnumerator WaitToIdle()
    {
        536898811 = new EnemyPinPullBase.<WaitToIdle>d__29(<>1__state:  0);
        mem[536898827] = this;
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
    private void CheckFalling()
    {
        UnityEngine.Vector2 val_1 = velocity;
        if(this.myRigidbody <= 0)
        {
                0 = 1;
        }
        
        this.isFalling = true;
    }
    protected abstract void Attack(); // 0
    protected virtual void Raycast()
    {
    
    }
    public void SetTypeDie(TypeEnemyPinPullDie typeDie)
    {
        this.typeEnemyPinPullDie = typeDie;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        float val_4;
        if((collision.CompareTag(tag:  -1610605337)) != true)
        {
                if((collision.CompareTag(tag:  -1610607699)) == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Vector2 val_3 = velocity;
        22968840 = this.myRigidbody;
        22968840.velocity = new UnityEngine.Vector2() {x = 0f, y = val_4};
    }
    protected EnemyPinPullBase()
    {
        this.scaleCharacter = 0.26f;
        this.moveSpeed = 1f;
        this.directionMove = 1f;
        this.canCheck = true;
    }
    private void <Start>b__19_0(UnityEngine.Component o, object sender)
    {
        this.CancelAll();
    }
    private void <Start>b__19_1(UnityEngine.Component o, object sender)
    {
        this.CancelAll();
    }
    private bool <WaitToIdle>b__29_0()
    {
        bool val_1 = this.isAttacking;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }

}
