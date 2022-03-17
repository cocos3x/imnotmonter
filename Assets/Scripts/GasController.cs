using UnityEngine;
public class GasController : Unit
{
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        var val_18;
        var val_19;
        if(true != 0)
        {
                return;
        }
        
        val_18 = 22742156;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_19 = 0;
        if(mem[3221266273] != false)
        {
                if(mem[3221266271] == false)
        {
                mem[3221266271] = mem[3221266272];
        }
        
            if(mem[3221266271] == false)
        {
                val_19 = mem[3221266271] >> 5;
        }
        
        }
        
        bool val_2 = R4.CompareTag(tag:  -1610607699);
        if(val_19 == false)
        {
            goto label_4;
        }
        
        if(val_2 != false)
        {
                val_19 = 22742224;
            WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem2[0] = 3;
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
            WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Lose();
            WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
        }
        
        if((R4.CompareTag(tag:  -1610605337)) == false)
        {
            goto label_27;
        }
        
        val_19 = 22742224;
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem2[0] = 3;
        WorldTimeAPI val_9 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Dead();
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Lose();
        goto label_27;
        label_4:
        if(val_2 != false)
        {
                val_18 = 22742224;
            WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem2[0] = 3;
            WorldTimeAPI val_12 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead();
        }
        
        if((R4.CompareTag(tag:  -1610605337)) != false)
        {
                val_18 = 22742224;
            WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem2[0] = 3;
            WorldTimeAPI val_15 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Dead();
        }
        
        label_27:
        if((R4.CompareTag(tag:  -1610608497)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_17 = R4.GetComponent<UnityEngine.Transform>();
        if(R4 != 0)
        {
                mem2[0] = 3;
        }
        else
        {
                mem[68] = 3;
        }
        
        R4.Dead();
    }
    public GasController()
    {
    
    }

}
