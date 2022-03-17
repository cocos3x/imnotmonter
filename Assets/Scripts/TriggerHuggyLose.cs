using UnityEngine;
public class TriggerHuggyLose : MonoBehaviour
{
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D coll)
    {
        if((coll.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266327].Dead(huggyDeadType:  1);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701079.Lose();
    }
    public TriggerHuggyLose()
    {
    
    }

}
