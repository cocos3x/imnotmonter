using UnityEngine;
public class BalancingMovement : MonoBehaviour
{
    // Fields
    private UnityEngine.Rigidbody2D rb;
    private float angle;
    private float wise;
    private int deadFrames;
    private int deadFramesCount;
    
    // Methods
    private void Start()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        Weight val_2 = this.GetComponent<Weight>();
        this.rb = this;
    }
    private void FixedUpdate()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.rb)) == false)
        {
                return;
        }
        
        int val_2 = this.deadFramesCount;
        if(val_2 > this.deadFrames)
        {
                this.rb.MoveRotation(angle:  null);
            this.angle = this.angle;
            if(this.rb < 0)
        {
                if(this.rb > 0)
        {
                return;
        }
        
        }
        
            this.deadFramesCount = 0;
            this.wise = -this.wise;
            return;
        }
        
        val_2 = val_2 + 1;
        this.deadFramesCount = val_2;
    }
    public BalancingMovement()
    {
        this.wise = 1f;
        this.deadFrames = 10;
    }

}
