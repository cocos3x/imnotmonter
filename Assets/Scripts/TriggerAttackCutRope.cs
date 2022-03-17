using UnityEngine;
public class TriggerAttackCutRope : MonoBehaviour
{
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if((collision.CompareTag(tag:  -1610605337)) != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266339].Dead();
            WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266327].Dead(huggyDeadType:  1);
            WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701079.Lose();
        }
        
        if((collision.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266339].Dead();
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266327].Dead(huggyDeadType:  1);
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.Lose();
    }
    public TriggerAttackCutRope()
    {
    
    }

}
