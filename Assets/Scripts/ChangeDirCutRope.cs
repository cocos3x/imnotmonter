using UnityEngine;
public class ChangeDirCutRope : MonoBehaviour
{
    // Fields
    private bool isLeft;
    
    // Methods
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        if((collision.CompareTag(tag:  -1610607703)) == false)
        {
                return;
        }
        
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if(this.isLeft == true)
        {
                this.isLeft = 1;
        }
        
        mem[3221266327].ChangeDirectionMove(isLeft:  true);
        UnityEngine.GameObject val_3 = this.gameObject;
        this.SetActive(value:  false);
    }
    public ChangeDirCutRope()
    {
    
    }

}
