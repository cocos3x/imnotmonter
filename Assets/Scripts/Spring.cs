using UnityEngine;
public class Spring : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform postMove;
    private float jumpPower;
    private Spine.Unity.SkeletonAnimation ske;
    private float delayTime;
    
    // Methods
    private System.Collections.IEnumerator Jump(UnityEngine.Collider2D other)
    {
        Spring.<Jump>d__4 val_1 = 536901443;
        val_1 = new Spring.<Jump>d__4(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536901459] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536901463] = other;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D other)
    {
        System.Collections.IEnumerator val_1 = this.Jump(other:  other);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  615411856);
    }
    public Spring()
    {
        this.jumpPower = 1.25f;
    }

}
