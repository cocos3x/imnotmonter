using UnityEngine;
public class TrapSpikeController : MonoBehaviour
{
    // Fields
    private UnityEngine.BoxCollider2D myCollider;
    private Spine.Unity.SkeletonAnimation trapSkeleton;
    
    // Methods
    private void CloseTrap()
    {
        this.myCollider.enabled = false;
        MixSkinManager.SetAnimation(ske:  this.trapSkeleton, name:  -1610601365, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610609959, volume:  null);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_19;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.GameObject val_3 = collision.gameObject;
        val_19 = collision;
        bool val_4 = val_19.CompareTag(tag:  -1610607699);
        if((-1073701037.CanCheck()) == false)
        {
            goto label_4;
        }
        
        if(val_4 != false)
        {
                val_19 = 22742224;
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Lose();
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
            this.CloseTrap();
        }
        
        UnityEngine.GameObject val_8 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_23;
        }
        
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Dead();
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Lose();
        goto label_17;
        label_4:
        if(val_4 != false)
        {
                WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            this.CloseTrap();
        }
        
        UnityEngine.GameObject val_13 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_23;
        }
        
        WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Dead();
        label_17:
        this.CloseTrap();
        label_23:
        UnityEngine.GameObject val_16 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610608497)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_18 = collision.GetComponent<UnityEngine.Transform>();
        collision.Dead();
        this.CloseTrap();
    }
    public TrapSpikeController()
    {
    
    }

}
