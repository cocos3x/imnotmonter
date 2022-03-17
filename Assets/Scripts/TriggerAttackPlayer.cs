using UnityEngine;
public class TriggerAttackPlayer : MonoBehaviour
{
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if((collision.CompareTag(tag:  -1610605337)) != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            mem[3221266323].Dead();
            WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701037.Lose();
        }
        
        if((collision.CompareTag(tag:  -1610607699)) == false)
        {
                return;
        }
        
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266327].Dead();
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266323].Lose();
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701037.Lose();
    }
    public TriggerAttackPlayer()
    {
    
    }

}
