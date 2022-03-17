using UnityEngine;
public class ArrowCutRope : MonoBehaviour
{
    // Fields
    private ArrowController arrowController;
    private UnityEngine.Rigidbody2D myBody;
    private float force;
    
    // Methods
    public void ForceWithDirection(int dir = 1)
    {
        float val_3;
        var val_4;
        UnityEngine.Transform val_1 = this.myBody.transform;
        UnityEngine.Vector3 val_2 = right;
        float val_8 = (float)dir;
        float val_7 = val_3;
        val_7 = val_7 * val_8;
        val_8 = val_4 * val_8;
        val_7 = val_7 * this.force;
        val_8 = val_8 * this.force;
        this.myBody.AddForce(force:  new UnityEngine.Vector2() {x = val_8, y = val_7}, mode:  1);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609885, volume:  val_8);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_31;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_3 = collision.gameObject;
        val_31 = collision;
        bool val_4 = val_31.CompareTag(tag:  -1610607703);
        if((-1073701079.CanCheck()) == false)
        {
            goto label_4;
        }
        
        if(val_4 != false)
        {
                val_31 = 22742212;
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  1);
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].Dead();
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701079.Lose();
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608667, volume:  null);
        }
        
            UnityEngine.GameObject val_10 = collision.gameObject;
            this.SetActive(value:  false);
        }
        
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_28;
        }
        
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266339].Dead();
        WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.Lose();
        goto label_19;
        label_4:
        if(val_4 != false)
        {
                WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  1);
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608667, volume:  null);
        }
        
            UnityEngine.GameObject val_17 = collision.gameObject;
            this.SetActive(value:  false);
        }
        
        UnityEngine.GameObject val_18 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_28;
        }
        
        WorldTimeAPI val_20 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266339].Dead();
        label_19:
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_22 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608667, volume:  null);
        }
        
        UnityEngine.GameObject val_23 = collision.gameObject;
        this.SetActive(value:  false);
        label_28:
        UnityEngine.GameObject val_24 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_26 = collision.GetComponent<UnityEngine.Transform>();
            collision.Dead(enemyDeadBy:  0);
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_28 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610609911, volume:  null);
        }
        
            UnityEngine.GameObject val_29 = collision.gameObject;
            this.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowController)) == false)
        {
                return;
        }
        
        this.arrowController.canMove = false;
        this.arrowController.currentTimeDelay = this.arrowController.delayTime;
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        UnityEngine.GameObject val_1 = collision.gameObject;
        string val_2 = collision.name;
        UnityEngine.Debug.Log(message:  collision);
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowController)) != false)
        {
                this.arrowController.canMove = false;
            this.arrowController.currentTimeDelay = this.arrowController.delayTime;
        }
        
        UnityEngine.GameObject val_4 = this.gameObject;
        this.SetActive(value:  false);
    }
    public ArrowCutRope()
    {
        this.force = 35f;
    }

}
