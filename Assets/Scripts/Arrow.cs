using UnityEngine;
public class Arrow : MonoBehaviour
{
    // Fields
    private ArrowController arrowController;
    private UnityEngine.Rigidbody2D myBody;
    private float force;
    
    // Methods
    public void ForceWithDirection()
    {
        float val_3;
        float val_4;
        UnityEngine.Transform val_1 = this.myBody.transform;
        UnityEngine.Vector3 val_2 = up;
        float val_7 = val_3;
        float val_8 = val_4;
        val_7 = val_7 * this.force;
        val_8 = val_8 * this.force;
        this.myBody.AddForce(force:  new UnityEngine.Vector2() {x = val_7, y = val_8}, mode:  1);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609885, volume:  val_7);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_28;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_3 = collision.gameObject;
        val_28 = collision;
        bool val_4 = val_28.CompareTag(tag:  -1610607699);
        if((-1073701037.CanCheck()) == false)
        {
            goto label_4;
        }
        
        if(val_4 != false)
        {
                val_28 = 22742224;
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Lose();
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608667, volume:  null);
        }
        
        }
        
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_29;
        }
        
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Dead();
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Lose();
        goto label_18;
        label_4:
        if(val_4 != false)
        {
                WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608667, volume:  null);
        }
        
        }
        
        UnityEngine.GameObject val_16 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_29;
        }
        
        WorldTimeAPI val_18 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Dead();
        label_18:
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_20 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608667, volume:  null);
        }
        
        label_29:
        UnityEngine.GameObject val_21 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_23 = collision.GetComponent<UnityEngine.Transform>();
            collision.Dead();
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_25 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610608667, volume:  null);
        }
        
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowController)) != false)
        {
                this.arrowController.canMove = false;
            this.arrowController.currentTimeDelay = this.arrowController.delayTime;
        }
        
        UnityEngine.GameObject val_27 = collision.gameObject;
        this.SetActive(value:  false);
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.arrowController)) != false)
        {
                this.arrowController.canMove = false;
            this.arrowController.currentTimeDelay = this.arrowController.delayTime;
        }
        
        UnityEngine.GameObject val_2 = this.gameObject;
        this.SetActive(value:  false);
    }
    public Arrow()
    {
        this.force = 8f;
    }

}
