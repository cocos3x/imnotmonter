using UnityEngine;
public class LavaController : Unit
{
    // Fields
    private UnityEngine.GameObject lavarChildObject;
    private UnityEngine.GameObject stoneObject;
    
    // Methods
    private void SetupStart()
    {
        this.lavarChildObject.SetActive(value:  true);
        this.stoneObject.SetActive(value:  false);
    }
    protected override void SetStatusForChangeStone()
    {
        this.SetStatusForChangeStone();
        this.lavarChildObject.SetActive(value:  false);
        this.stoneObject.SetActive(value:  true);
    }
    private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        float val_8;
        var val_9;
        var val_10;
        if(this != 0)
        {
                UnityEngine.Vector2 val_1 = velocity;
            val_8 = -2f;
            if(this > 0)
        {
                return;
        }
        
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_9 = -1073701113;
            val_10 = 22793624;
        }
        else
        {
                UnityEngine.Vector2 val_5 = velocity;
            val_8 = -2f;
            if(this > 0)
        {
                return;
        }
        
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return;
        }
        
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            val_9 = -1073701113;
            val_10 = 22788904;
        }
        
        val_9.Shot(clip:  -1610606717, volume:  val_8);
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_19;
        var val_20;
        if(true != 0)
        {
                return;
        }
        
        val_20 = 22742156;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        bool val_3 = R4.CompareTag(tag:  -1610607699);
        if((-1073701037.CanCheck()) == false)
        {
            goto label_3;
        }
        
        if(val_3 != false)
        {
                val_19 = 22742224;
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem2[0] = 1;
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Lose();
            WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
        }
        
        if((R4.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_26;
        }
        
        val_19 = 22742224;
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem2[0] = 1;
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Dead();
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Lose();
        goto label_26;
        label_3:
        if(val_3 != false)
        {
                val_20 = 22742224;
            WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem2[0] = 1;
            WorldTimeAPI val_13 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
        }
        
        if((R4.CompareTag(tag:  -1610605337)) != false)
        {
                val_20 = 22742224;
            WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem2[0] = 1;
            WorldTimeAPI val_16 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Dead();
        }
        
        label_26:
        if((R4.CompareTag(tag:  -1610608497)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_18 = R4.GetComponent<UnityEngine.Transform>();
        if(R4 != 0)
        {
                mem2[0] = 1;
        }
        else
        {
                mem[68] = 1;
        }
        
        R4.Dead();
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D collision)
    {
        if(true != 0)
        {
                return;
        }
        
        if((R5.CompareTag(tag:  -1610604361)) != true)
        {
                if((R5.CompareTag(tag:  -1610602581)) == false)
        {
                return;
        }
        
        }
        
        R4.ChangeStone();
    }
    public LavaController()
    {
    
    }

}
