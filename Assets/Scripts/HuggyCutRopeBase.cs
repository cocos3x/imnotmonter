using UnityEngine;
public class HuggyCutRopeBase : MonoBehaviour
{
    // Fields
    protected EnemyAnimController animationController;
    protected bool canAim;
    protected bool canMove;
    public int countEnemyTargetPlayer;
    private float directionMove;
    private UnityEngine.Transform groundedEffect;
    protected bool facingLeft;
    protected UnityEngine.CircleCollider2D groundCollider;
    protected bool isDead;
    public bool untied;
    protected bool isFalling;
    private bool isFalled;
    protected bool isRunning;
    private UnityEngine.GameObject mainSkeletonObject;
    private readonly float moveSpeed;
    protected UnityEngine.BoxCollider2D myCollider;
    protected UnityEngine.Rigidbody2D myRigidbody;
    private readonly float scaleCharacter;
    public UnityEngine.HingeJoint2D[] listHinge;
    private HuggyDeadType deadType;
    private UnityEngine.GameObject tutorialHand;
    
    // Methods
    private void Start()
    {
        this.SetupStart();
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinHuggySelectedID);
        this.Invoke(methodName:  -1610609039, time:  null);
    }
    private void OnEnable()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        this.SetSkin(id:  -1073708883.SkinHuggySelectedID);
    }
    private void CountHinge()
    {
        T[] val_1 = this.GetComponents<UnityEngine.PolygonCollider2D>();
        this.listHinge = this;
    }
    private void Update()
    {
        var val_2;
        var val_3;
        var val_5;
        if(this.isDead != false)
        {
                if(this.deadType != 2)
        {
                return;
        }
        
            UnityEngine.Vector2 val_1 = velocity;
            float val_5 = System.Math.Abs(val_2);
            if(this.myRigidbody > 0)
        {
                return;
        }
        
            var val_6 = val_3;
            val_6 = val_6 & (~2147483648);
            if(this.myRigidbody > 0)
        {
                return;
        }
        
            val_5 = 536887951;
            if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_5 = 536887951;
        }
        
            this.animationController.SetAnimation(name:  mem[536888043] + 52 + 20, loop:  false, timeScale:  0.05f, _callBack:  1065353216);
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701079.Lose();
            this.deadType = 0;
            return;
        }
        
        this.SetAnimationMove();
    }
    private void SetupStart()
    {
        var val_1;
        this.canAim = true;
        this.deadType = 0;
        this.SetScale();
        val_1 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_1 = 536887951;
        }
        
        this.animationController.SetAnimation(name:  mem[536888043] + 72, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    private void SetSkin(int id)
    {
        string val_1 = id.ToString();
        this.animationController.SetSkin(skinName:  602072348);
    }
    public void SetMove(bool value)
    {
        this.canMove = true;
    }
    private void SetAnimationMove()
    {
        var val_2;
        var val_3;
        var val_6;
        if(this.untied == false)
        {
                return;
        }
        
        if(this.isFalling != false)
        {
                return;
        }
        
        if(this.countEnemyTargetPlayer >= 1)
        {
                this.Idle();
            return;
        }
        
        if(this.canMove == false)
        {
                return;
        }
        
        UnityEngine.Vector2 val_1 = velocity;
        float val_6 = System.Math.Abs(val_2);
        if(this.myRigidbody > 0)
        {
            goto label_6;
        }
        
        var val_7 = val_3;
        val_7 = val_7 & (~2147483648);
        if(this.myRigidbody <= 0)
        {
            goto label_7;
        }
        
        label_6:
        if(this.isRunning != true)
        {
                return;
        }
        
        this.isRunning = true;
        val_6 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_6 = 536887951;
        }
        
        string val_4 = Berry.Utils.Utils.GetRandom<System.String>(collection:  mem[536888043] + 84);
        this.animationController.SetAnimation(name:  mem[536888043] + 84, loop:  true, timeScale:  0.05f, _callBack:  1067869798);
        return;
        label_7:
        if(this.isRunning == false)
        {
                return;
        }
        
        this.isRunning = false;
        this.Dead(huggyDeadType:  1);
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.Lose();
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
    public void SetSortingLayer(string value)
    {
        this.animationController.SetSortingLayer(value:  value);
    }
    private void CheckFalling()
    {
        var val_3;
        UnityEngine.Vector2 val_1 = velocity;
        if(this.myRigidbody > 0)
        {
                this.isFalling = false;
            return;
        }
        
        this.isFalling = true;
        if(this.untied == true)
        {
                this.untied = this.canMove;
        }
        
        if(this.untied == false)
        {
                return;
        }
        
        this.isRunning = false;
        val_3 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_3 = 536887951;
        }
        
        this.animationController.SetAnimation(name:  mem[536888043] + 80 + 16, loop:  false, timeScale:  -0.5f, _callBack:  1065353216);
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
        var val_1;
        if(this.isDead == true)
        {
                return;
        }
        
        val_1 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_1 = 536887951;
        }
        
        this.animationController.SetAnimation(name:  mem[536888043] + 40, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    public void Fall()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.tutorialHand)) != false)
        {
                UnityEngine.GameObject val_2 = this.tutorialHand.gameObject;
            this.tutorialHand.SetActive(value:  false);
        }
        
        this.isFalled = true;
        GameTool.EventDispatcherExtension.PostEvent(sender:  603066384, eventID:  34);
    }
    public void Untie()
    {
        var val_2;
        if(this.untied == true)
        {
                return;
        }
        
        GameTool.EventDispatcherExtension.PostEvent(sender:  603190672, eventID:  34);
        this.Invoke(methodName:  -1610605341, time:  null);
        val_2 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_2 = 536887951;
        }
        
        536882991 = new System.Action(object:  603190672, method:  new IntPtr(1610678433));
        this.animationController.SetAnimation(name:  mem[536888043] + 76 + 20, loop:  false, timeScale:  null, _callBack:  1065353216);
    }
    private void PlayUntieSFX()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610602911, volume:  null);
    }
    private void MoveVelocity()
    {
        float val_2;
        if(this.canMove == true)
        {
                this.canMove = this.untied;
            goto label_0;
        }
        
        return;
        label_0:
        if(this.isFalling == true)
        {
                return;
        }
        
        if(this.countEnemyTargetPlayer > 0)
        {
                return;
        }
        
        UnityEngine.Vector2 val_1 = velocity;
        float val_3 = this.directionMove;
        val_3 = this.moveSpeed * val_3;
        this.myRigidbody.velocity = new UnityEngine.Vector2() {x = val_3, y = val_2};
    }
    public void ChangeDirectionMove(bool isLeft)
    {
        this.facingLeft = isLeft;
        this.SetScale();
    }
    public void JumpWithSpring()
    {
        var val_1;
        if(this.isDead == true)
        {
                return;
        }
        
        this.canMove = false;
        this.isRunning = false;
        val_1 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_1 = 536887951;
        }
        
        this.animationController.SetAnimation(name:  mem[536888043] + 80 + 16, loop:  false, timeScale:  null, _callBack:  1065353216);
    }
    public void Win()
    {
        this.isDead = true;
        this.canAim = false;
        this.WaitWin();
    }
    private void WaitWin()
    {
        var val_2;
        this.canMove = false;
        this.myRigidbody.constraints = 5;
        val_2 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_2 = 536887951;
        }
        
        string val_1 = Berry.Utils.Utils.GetRandom<System.String>(collection:  mem[536888043] + 68);
        this.animationController.SetAnimation(name:  mem[536888043] + 68, loop:  true, timeScale:  null, _callBack:  1065353216);
    }
    public void Lose()
    {
        var val_2;
        if(this.canAim == false)
        {
                return;
        }
        
        this.canAim = false;
        this.canMove = false;
        this.myRigidbody.constraints = 5;
        val_2 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_2 = 536887951;
        }
        
        this.animationController.SetAnimation(name:  mem[536888043] + 44, loop:  false, timeScale:  null, _callBack:  1065353216);
        bool val_1 = SingletonMonoBehaviour<TransitionFX>.Exists();
    }
    public void Dead(HuggyDeadType huggyDeadType = 1)
    {
        UnityEngine.BoxCollider2D val_7;
        EnemyAnimController val_8;
        var val_9;
        string val_10;
        var val_11;
        EnemyAnimController val_12;
        var val_13;
        var val_14;
        var val_15;
        val_7 = 22999593;
        if(this.canAim == false)
        {
                return;
        }
        
        if(this.isDead != true)
        {
                return;
        }
        
        this.isDead = true;
        this.canAim = false;
        this.canMove = false;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266339].Dead();
        UnityEngine.GameObject val_2 = this.groundCollider.gameObject;
        this.groundCollider.layer = 14;
        this.myRigidbody.constraints = 5;
        val_7 = this.myCollider;
        val_7.enabled = false;
        if(this.untied == false)
        {
            goto label_9;
        }
        
        if(huggyDeadType != 1)
        {
            goto label_10;
        }
        
        val_8 = this.animationController;
        val_9 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_9 = 536887951;
        }
        
        val_10 = mem[mem[536888043] + 44];
        val_10 = mem[536888043] + 44;
        goto label_13;
        label_9:
        if(huggyDeadType != 1)
        {
            goto label_14;
        }
        
        val_8 = this.animationController;
        val_11 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_11 = 536887951;
        }
        
        val_10 = mem[mem[536888043] + 48];
        val_10 = mem[536888043] + 48;
        label_13:
        val_8.SetAnimation(name:  val_10, loop:  false, timeScale:  null, _callBack:  1065353216);
        return;
        label_10:
        if(huggyDeadType != 2)
        {
                return;
        }
        
        val_12 = this.animationController;
        val_13 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_13 = 536887951;
        }
        
        val_7 = mem[mem[536888043] + 52 + 20];
        val_7 = mem[536888043] + 52 + 20;
        goto label_24;
        label_14:
        if(huggyDeadType != 2)
        {
                return;
        }
        
        val_14 = 0;
        UnityEngine.GameObject val_3 = this.gameObject;
        Weight val_4 = this.GetComponent<Weight>();
        goto label_27;
        label_32:
        Spine.Timeline val_5 = this.countEnemyTargetPlayer.Item[0];
        this.countEnemyTargetPlayer.enabled = false;
        val_14 = 1;
        label_27:
        if(val_14 < this.countEnemyTargetPlayer.Count)
        {
            goto label_32;
        }
        
        val_12 = this.animationController;
        val_15 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_15 = 536887951;
        }
        
        val_7 = mem[mem[536888043] + 52 + 16];
        val_7 = mem[536888043] + 52 + 16;
        label_24:
        val_12.SetAnimation(name:  val_7, loop:  false, timeScale:  null, _callBack:  1065353216);
        this.deadType = 2;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_4;
        if(this.isDead == true)
        {
                return;
        }
        
        if((R4 + 16) == 0)
        {
                return;
        }
        
        val_4 = 0;
        if((R5.CompareTag(tag:  -1610605337)) == false)
        {
                return;
        }
        
        mem2[0] = 1;
        mem2[0] = val_4;
        R4.WaitWin();
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266339].Win();
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.Win(delayTime:  null);
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        UnityEngine.GameObject val_1 = collision.gameObject;
        if(collision.layer != 10)
        {
                return;
        }
        
        if(this.isFalled == false)
        {
                return;
        }
        
        if(this.isRunning == false)
        {
                this.isRunning = this.isDead;
            goto label_5;
        }
        
        return;
        label_5:
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610605335, volume:  null);
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.GameObject val_6 = -1073701087.GetItem(key:  -1610607859, position:  new UnityEngine.Vector3() {x = R4, y = R6});
    }
    public HuggyCutRopeBase()
    {
        this.moveSpeed = 1.3f;
        this.directionMove = 1f;
        this.scaleCharacter = 0.25f;
    }
    private void <Untie>b__35_0()
    {
        this.untied = true;
        this.Idle();
    }

}
