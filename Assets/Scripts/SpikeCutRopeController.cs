using UnityEngine;
public class SpikeCutRopeController : MonoBehaviour
{
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_21;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_3 = collision.gameObject;
        val_21 = collision;
        bool val_4 = val_21.CompareTag(tag:  -1610607703);
        if((-1073701079.CanCheck()) == false)
        {
            goto label_4;
        }
        
        if(val_4 != false)
        {
                val_21 = 22742212;
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].Dead();
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  1);
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701079.Lose();
        }
        
        UnityEngine.GameObject val_8 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_23;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266339].Dead();
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.Lose();
        goto label_23;
        label_4:
        if(val_4 != false)
        {
                WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  1);
        }
        
        UnityEngine.GameObject val_13 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610605337)) != false)
        {
                WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].Dead();
        }
        
        label_23:
        UnityEngine.GameObject val_16 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610608497)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_18 = collision.GetComponent<UnityEngine.Transform>();
        collision.Dead(enemyDeadBy:  0);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_20 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609911, volume:  null);
    }
    public SpikeCutRopeController()
    {
    
    }

}
