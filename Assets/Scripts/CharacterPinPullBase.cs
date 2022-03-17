using UnityEngine;
public class CharacterPinPullBase : MonoBehaviour
{
    // Fields
    protected CharacterAnimationController animationController;
    protected UnityEngine.BoxCollider2D myCollider;
    protected UnityEngine.Rigidbody2D myRigidbody;
    protected UnityEngine.CircleCollider2D groundCollider;
    private UnityEngine.GameObject mainSkeletonObject;
    private Spine.Unity.SkeletonRenderSeparator mainSkeletonRenderSeparator;
    private TextEffect textEffect;
    protected bool facingLeft;
    private float scaleCharacter;
    public int countEnemyTargetPlayer;
    protected bool canAim;
    protected bool isDead;
    protected bool canMove;
    protected bool isRunning;
    private float moveSpeed;
    private float directionMove;
    protected bool isFalling;
    private CharacterPinPullBase.TypeCollisionWin typeCollisionWin;
    private TypeCharacterPinPullDie typeCharacterDie;
    private float timeWaitWin;
    
    // Methods
    private void Start()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinSelectedID);
        this.SetupStart();
    }
    private void OnEnable()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinSelectedID);
    }
    private void Update()
    {
        if(this.isDead == true)
        {
                return;
        }
        
        this.SetAnimationMove();
    }
    private void FixedUpdate()
    {
        if(this.isDead == true)
        {
                return;
        }
        
        R4.MoveVelocity();
        R4.CheckFalling();
    }
    private void SetupStart()
    {
        this.canAim = true;
        this.mainSkeletonRenderSeparator.enabled = false;
        this.SetScale();
    }
    private void SetSkin(int id)
    {
        string val_1 = id.ToString();
        System.Collections.IEnumerator val_2 = this.animationController.WaitSetSkin(skinName:  618298140);
        UnityEngine.Coroutine val_3 = this.animationController.StartCoroutine(routine:  this.animationController);
    }
    public void SetOrderLayer(int id)
    {
        this.animationController.meshSkeleton.sortingOrder = id;
    }
    public void SetSortingLayer(string value)
    {
        UnityEngine.MeshRenderer val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        val_10 = this.animationController.meshSkeleton;
        val_10.sortingLayerName = value;
        UnityEngine.Transform val_1 = this.mainSkeletonObject.transform;
        System.Collections.IEnumerator val_2 = this.mainSkeletonObject.GetEnumerator();
        label_25:
        var val_11 = 0;
        val_10 = 0;
        val_11 = val_11 + 1;
        val_10 = (uint)val_11 & 65535;
        val_11 = this.mainSkeletonObject;
        if(this.mainSkeletonObject == 0)
        {
            goto label_10;
        }
        
        var val_12 = 0;
        val_12 = val_12 + 1;
        val_12 = this.mainSkeletonObject;
        UnityEngine.Transform val_5 = 0.GetComponent<UnityEngine.Transform>();
        if(0 == 0)
        {
            goto label_25;
        }
        
        UnityEngine.Transform val_7 = 0.GetComponent<UnityEngine.Transform>();
        UnityEngine.MeshRenderer val_8 = 0.MeshRenderer;
        0.sortingLayerName = value;
        goto label_25;
        label_10:
        val_13 = 22711796;
        if(this.mainSkeletonObject != 0)
        {
                val_13 = 0;
            val_13 = val_13 + 1;
            val_14 = this.mainSkeletonObject;
        }
        
        if(1 == 0)
        {
                return;
        }
        
        var val_10 = 1 - 1;
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
        
        string val_1 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873];
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    public void Win()
    {
        this.canAim = false;
        if(this.typeCollisionWin != 0)
        {
                this.WaitWin();
            return;
        }
        
        this.Invoke(methodName:  -1610602589, time:  null);
    }
    private void WaitWin()
    {
        var val_10;
        var val_11;
        var val_12;
        this.canMove = false;
        this.myRigidbody.constraints = 5;
        if(this.typeCollisionWin == 2)
        {
            goto label_2;
        }
        
        if(this.typeCollisionWin == 1)
        {
            goto label_3;
        }
        
        if(this.typeCollisionWin != 0)
        {
                return;
        }
        
        val_10 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_10 = 536884781;
        }
        
        string val_1 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 32(mem[536884873] + 32);
        536882991 = new System.Action(object:  619105040, method:  new IntPtr(1610678683));
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  false, timeScale:  null, _callBack:  1065353216);
        this.textEffect.SetScale();
        this.textEffect.ShowEffect();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(methodName:  -1610608769);
        return;
        label_2:
        val_11 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_11 = 536884781;
        }
        
        string val_4 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 56(mem[536884873] + 56);
        536882991 = new System.Action(object:  619105040, method:  new IntPtr(1610678687));
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  false, timeScale:  null, _callBack:  1065353216);
        this.textEffect.SetScale();
        this.textEffect.ShowEffect();
        return;
        label_3:
        val_12 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_12 = 536884781;
        }
        
        string val_6 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 60(mem[536884873] + 60);
        536882991 = new System.Action(object:  619105040, method:  new IntPtr(1610678685));
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610604847, volume:  null);
    }
    private System.Collections.IEnumerator DelaySoundCollectCoin()
    {
        536898265 = new CharacterPinPullBase.<DelaySoundCollectCoin>d__32(<>1__state:  0);
    }
    public void Lose()
    {
        var val_5;
        if(this.canAim == false)
        {
                return;
        }
        
        this.canMove = false;
        this.canAim = false;
        this.myRigidbody.constraints = 5;
        val_5 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_5 = 536884781;
        }
        
        string val_1 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 12 + 20(mem[536884873] + 12 + 20);
        536882991 = new System.Action(object:  619374096, method:  new IntPtr(1610678689));
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610606315, volume:  null);
    }
    public void Dead()
    {
        bool val_12;
        CharacterAnimationController val_13;
        var val_14;
        System.Action val_15;
        var val_22;
        var val_23;
        if(this.canAim == false)
        {
                return;
        }
        
        if((this.isDead & true) == 0)
        {
                return;
        }
        
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        val_12 = false;
        if((-1073708883.Vibrate) != false)
        {
                MoreMountains.NiceVibrations.MMVibrationManager.Haptic(type:  5, defaultToRegularVibrate:  false, alsoRumble:  false, coroutineSupport:  0, controllerID:  0);
        }
        
        this.canMove = val_12;
        this.canAim = true;
        this.isDead = true;
        UnityEngine.GameObject val_3 = this.groundCollider.gameObject;
        this.groundCollider.layer = 14;
        this.myRigidbody.constraints = 5;
        this.myCollider.enabled = false;
        if(this.typeCharacterDie > 3)
        {
            goto label_27;
        }
        
        var val_4 = 5956492 + (5956492 + (this.typeCharacterDie) << 2);
        if(this.typeCharacterDie == 3)
        {
                5956492 + (this.typeCharacterDie) << 2 = (5956492 + (this.typeCharacterDie) << 2) & ((5956492 + (this.typeCharacterDie) << 2) << (5956492 + (this.typeCharacterDie) << 2));
            5956492 + (this.typeCharacterDie) << 2 = (5956492 + (this.typeCharacterDie) << 2) & (((int)IP) >> 1);
            5956492 + (this.typeCharacterDie) << 2 = (5956492 + (this.typeCharacterDie) << 2) & ((IP) << 2);
            5956492 + (this.typeCharacterDie) << 2 = (5956492 + (this.typeCharacterDie) << 2) & (((int)IP) >> 2);
        }
        
        val_13 = this.animationController;
        val_14 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_14 = 536884781;
        }
        
        string val_5 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 12 + 20(mem[536884873] + 12 + 20);
        val_12 = mem[536884873] + 28;
        val_15 = 536882991;
        val_15 = new System.Action(object:  619531152, method:  new IntPtr(1610678691));
        SetAnimation(name:  null, loop:  false, timeScale:  null, _callBack:  1065353216);
        if(this.typeCharacterDie != 2)
        {
            goto label_27;
        }
        
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_31;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_22 = -1073701113;
        val_23 = 22786324;
        goto label_30;
        label_27:
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
            goto label_31;
        }
        
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_22 = -1073701113;
        val_23 = 22789100;
        label_30:
        val_22.Shot(clip:  -1610606619, volume:  null);
        label_31:
        GameTool.EventDispatcherExtension.PostEvent(sender:  619531152, eventID:  6);
    }
    public void SetTypeWin(CharacterPinPullBase.TypeCollisionWin typeWin)
    {
        this.typeCollisionWin = typeWin;
    }
    public void SetTypeDie(TypeCharacterPinPullDie typeDie)
    {
        this.typeCharacterDie = typeDie;
    }
    public void SetMove(bool value)
    {
        this.canMove = value;
    }
    private void SetAnimationMove()
    {
        var val_2;
        var val_3;
        var val_5;
        if(this.canMove == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_1 = velocity;
        float val_5 = System.Math.Abs(val_2);
        if(this.myRigidbody > 0)
        {
            goto label_3;
        }
        
        var val_6 = val_3;
        val_6 = val_6 & (~2147483648);
        if(this.myRigidbody <= 0)
        {
            goto label_4;
        }
        
        label_3:
        if(this.isRunning == true)
        {
                return;
        }
        
        this.isRunning = true;
        val_5 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_5 = 536884781;
        }
        
        string val_4 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 8(mem[536884873] + 8);
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  true, timeScale:  0.1f, _callBack:  1065353216);
        return;
        label_4:
        if(this.isRunning == false)
        {
                return;
        }
        
        this.isRunning = false;
        this.Idle();
    }
    private void MoveVelocity()
    {
        float val_2;
        if(this.canMove == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_1 = velocity;
        float val_3 = this.moveSpeed;
        val_3 = val_3 * this.directionMove;
        this.myRigidbody.velocity = new UnityEngine.Vector2() {x = val_3, y = val_2};
    }
    public void ChangeDirectionMove(bool isLeft)
    {
        this.facingLeft = isLeft;
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
    public bool CanTarget()
    {
        if(this.countEnemyTargetPlayer > 0)
        {
                return false;
        }
        
        if(this.isFalling == false)
        {
                this.isFalling = 1;
            return (bool)this.isFalling;
        }
        
        return false;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        float val_4;
        if(this.isDead != false)
        {
                return;
        }
        
        if(this.canAim == false)
        {
                return;
        }
        
        if((collision.CompareTag(tag:  -1610607699)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = collision.transform;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Transform val_5 = collision.transform;
        UnityEngine.Vector3 val_6 = position;
        if(collision > 0)
        {
                0 = 1;
        }
        
        this.facingLeft = true;
        this.SetScale();
        this.typeCollisionWin = 1;
        this.Win();
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266327].Win();
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Win(delayTime:  val_4);
    }
    public CharacterPinPullBase()
    {
        this.scaleCharacter = 0.25f;
        this.moveSpeed = 1f;
        this.directionMove = 1f;
        this.timeWaitWin = 0.5f;
    }
    private void <WaitWin>b__31_0()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        string val_1 = Berry.Utils.Utils.GetRandom<System.String>(collection:  mem[536884873] + 20);
        string val_2 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 20(mem[536884873] + 20);
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  true, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610606617, volume:  null);
    }
    private void <WaitWin>b__31_1()
    {
        var val_5;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266327].Untie();
        this.mainSkeletonRenderSeparator.enabled = true;
        val_5 = 536884781;
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                val_5 = 536884781;
        }
        
        string val_2 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 52(mem[536884873] + 52);
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610606617, volume:  null);
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  621002128, eventID:  34);
        this.textEffect.SetScale();
        this.textEffect.ShowEffect();
    }
    private void <WaitWin>b__31_2()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        string val_1 = Berry.Utils.Utils.GetRandom<System.String>(collection:  mem[536884873] + 20);
        string val_2 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 20(mem[536884873] + 20);
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  true, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610606617, volume:  null);
    }
    private void <Lose>b__33_0()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        string val_1 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 16 + 20(mem[536884873] + 16 + 20);
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    private void <Dead>b__34_0()
    {
        if(((mem[536884968] & true) == 0) && (mem[536884897] == 0))
        {
                536884781 = 536884781;
        }
        
        string val_1 = mem[536884873] + 28(mem[536884873] + 28) + mem[536884873] + 16 + 20(mem[536884873] + 16 + 20);
        this.animationController.SetAnimation(name:  mem[536884873] + 28, loop:  true, timeScale:  null, _callBack:  1065353216);
    }

}
