using UnityEngine;
public class FrostController : Unit
{
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_36;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_36 = -1073701037.CanCheck();
        bool val_3 = collision.CompareTag(tag:  -1610607699);
        if(val_36 == false)
        {
            goto label_3;
        }
        
        if(val_3 != false)
        {
                WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem2[0] = 2;
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Lose();
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
            UnityEngine.Transform val_8 = collision.transform;
            UnityEngine.Transform val_9 = this.parent;
            UnityEngine.GameObject val_10 = collision.gameObject;
            val_36 = this;
            this.SetActive(value:  false);
        }
        
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_32;
        }
        
        WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem2[0] = 2;
        WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Dead();
        WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Lose();
        goto label_22;
        label_3:
        if(val_3 != false)
        {
                WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem2[0] = 2;
            WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            UnityEngine.Transform val_17 = collision.transform;
            UnityEngine.Transform val_18 = this.parent;
            UnityEngine.GameObject val_19 = collision.gameObject;
            val_36 = this;
            this.SetActive(value:  false);
        }
        
        if((collision.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_32;
        }
        
        WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem2[0] = 2;
        WorldTimeAPI val_22 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Dead();
        label_22:
        UnityEngine.Transform val_23 = collision.transform;
        UnityEngine.Transform val_24 = this.parent;
        UnityEngine.GameObject val_25 = collision.gameObject;
        val_36 = this;
        this.SetActive(value:  false);
        label_32:
        if((collision.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_27 = collision.GetComponent<UnityEngine.Transform>();
            if(collision != 0)
        {
                mem2[0] = 2;
        }
        else
        {
                mem[68] = 2;
        }
        
            collision.Dead();
            UnityEngine.Transform val_28 = collision.transform;
            UnityEngine.Transform val_29 = this.parent;
            UnityEngine.GameObject val_30 = collision.gameObject;
            val_36 = this;
            this.SetActive(value:  false);
        }
        
        if((collision.CompareTag(tag:  -1610606719)) != true)
        {
                if((collision.CompareTag(tag:  -1610602581)) == false)
        {
                return;
        }
        
        }
        
        UnityEngine.Transform val_33 = collision.transform;
        UnityEngine.Transform val_34 = this.parent;
        UnityEngine.GameObject val_35 = collision.gameObject;
        this.SetActive(value:  false);
    }
    public FrostController()
    {
    
    }

}
