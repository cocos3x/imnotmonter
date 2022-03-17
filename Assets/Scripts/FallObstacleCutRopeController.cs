using UnityEngine;
public class FallObstacleCutRopeController : MonoBehaviour
{
    // Fields
    private UnityEngine.Rigidbody2D myBody;
    private FallObstacleCutRopeController.TypeObstacle typeItem;
    public bool isFalling;
    public bool isMoving;
    private bool disabledEffect;
    
    // Methods
    private void FixedUpdate()
    {
        this.CheckFalling();
        this.CheckMoving();
    }
    private void CheckFalling()
    {
        UnityEngine.Vector2 val_1 = velocity;
        if(this.myBody <= 0)
        {
                0 = 1;
        }
        
        this.isFalling = true;
    }
    private void CheckMoving()
    {
        UnityEngine.Vector2 val_1 = 0.velocity;
        float val_2 = 0.magnitude;
        if(this.myBody >= 0)
        {
                0 = 1;
        }
        
        this.isMoving = true;
    }
    private void BraekObstacle(bool breakable)
    {
        bool val_1 = this.CompareTag(tag:  -1610602529);
        if(val_1 == false)
        {
                return;
        }
        
        if(breakable == false)
        {
                val_1 = this.isMoving;
        }
        
        if(val_1 == false)
        {
                return;
        }
        
        this.BreakVFX();
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  false);
    }
    private void BreakVFX()
    {
        var val_13;
        var val_14;
        var val_15;
        var val_20;
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        if(this.typeItem == 3)
        {
            goto label_2;
        }
        
        if(this.typeItem == 2)
        {
            goto label_3;
        }
        
        if(this.typeItem != 1)
        {
                return;
        }
        
        val_13 = 22742080;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_14 = -1073701087;
        UnityEngine.Transform val_3 = this.transform;
        val_15 = 0;
        UnityEngine.Vector3 val_4 = position;
        val_20 = 22782408;
        goto label_10;
        label_2:
        val_13 = 22742080;
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_14 = -1073701087;
        UnityEngine.Transform val_6 = this.transform;
        val_15 = 0;
        UnityEngine.Vector3 val_7 = position;
        val_20 = 22782596;
        goto label_10;
        label_3:
        val_13 = 22742080;
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_14 = -1073701087;
        UnityEngine.Transform val_9 = this.transform;
        val_15 = 0;
        UnityEngine.Vector3 val_10 = position;
        val_20 = 22797212;
        label_10:
        UnityEngine.GameObject val_11 = val_14.GetItem(key:  -1610602559, position:  new UnityEngine.Vector3() {x = R4, y = R6});
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_13.Despaw(go:  -1073701087, delay:  val_10.x);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        UnityEngine.Rigidbody2D val_16 = 22968914;
        if(this.isFalling == false)
        {
                this.isFalling = this.isMoving;
            return;
        }
        
        if((collision.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_2 = collision.GetComponent<UnityEngine.Transform>();
            val_16 = collision;
            val_16.Dead(enemyDeadBy:  0);
            this.BraekObstacle(breakable:  true);
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_16 = -1073701113;
            val_16.Shot(clip:  -1610609911, volume:  null);
        }
        
            if(this.typeItem == 4)
        {
                val_16 = this.myBody;
            val_16.mass = null;
        }
        
        }
        
        if((collision.CompareTag(tag:  -1610607703)) != false)
        {
                WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  1);
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_16 = -1073701079;
            val_16.Lose();
            this.BraekObstacle(breakable:  true);
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_16 = -1073701113;
            val_16.Shot(clip:  -1610608667, volume:  null);
        }
        
        }
        
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
                return;
        }
        
        val_16 = 22742212;
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266339].Dead();
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266327].Dead(huggyDeadType:  1);
        WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.Lose();
        this.BraekObstacle(breakable:  true);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610608667, volume:  null);
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        float val_16;
        float val_17;
        float val_24;
        var val_25;
        var val_26;
        UnityEngine.GameObject val_1 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610609921)) != false)
        {
                if(this.isFalling == false)
        {
                this.isFalling = this.isMoving;
            goto label_4;
        }
        
            UnityEngine.GameObject val_3 = collision.gameObject;
            Weight val_4 = collision.GetComponent<Weight>();
            collision.Detonate();
        }
        
        label_4:
        UnityEngine.GameObject val_5 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610605165)) != false)
        {
                UnityEngine.GameObject val_7 = collision.gameObject;
            Weight val_8 = collision.GetComponent<Weight>();
            if(collision != 0)
        {
                collision = this;
            -1073688991 = 1;
            this.BraekObstacle(breakable:  true);
        }
        
        }
        
        UnityEngine.GameObject val_9 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610602529)) != false)
        {
                this.BraekObstacle(breakable:  false);
        }
        
        UnityEngine.GameObject val_11 = collision.gameObject;
        val_24 = collision;
        if(val_24.layer != 10)
        {
                return;
        }
        
        int val_13 = collision.GetContacts(contacts:  536881843);
        var val_14 = 536881843 + 16;
        UnityEngine.Vector2 val_15 = point;
        val_24 = val_16;
        if(this.typeItem == 5)
        {
            goto label_23;
        }
        
        if(this.typeItem != 4)
        {
            goto label_24;
        }
        
        WorldTimeAPI val_18 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_19 = -1073701087.GetItem(key:  -1610606847, position:  new UnityEngine.Vector3() {x = val_24, y = val_17, z = 0f});
        WorldTimeAPI val_20 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_25 = -1073701113;
        val_26 = 22789620;
        goto label_30;
        label_23:
        WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_22 = -1073701087.GetItem(key:  -1610606847, position:  new UnityEngine.Vector3() {x = val_24, y = val_17, z = 0f});
        WorldTimeAPI val_23 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_25 = -1073701113;
        val_26 = 22789616;
        goto label_30;
        label_24:
        WorldTimeAPI val_24 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_25 = -1073701113;
        val_26 = 22797280;
        label_30:
        val_25.Shot(clip:  -1610602525, volume:  val_15.x);
    }
    public FallObstacleCutRopeController()
    {
    
    }

}
