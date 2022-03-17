using UnityEngine;
public class SimpleRotation : MonoBehaviour
{
    // Fields
    public Water2D.Water2D_Spawner water2d;
    private UnityEngine.Rigidbody2D rb;
    private float angle;
    private float wise;
    private int deadFrames;
    private int deadFramesCount;
    private bool canRotate;
    
    // Methods
    private void Start()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        Weight val_2 = this.GetComponent<Weight>();
        this.rb = this;
    }
    private void FixedUpdate()
    {
        if(this.canRotate == false)
        {
                return;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.rb)) == false)
        {
                return;
        }
        
        int val_2 = this.deadFramesCount;
        if(val_2 > this.deadFrames)
        {
                this.rb.MoveRotation(angle:  null);
            this.angle = this.angle;
            if(this.rb >= 0)
        {
                this.wise = -this.wise;
            this.deadFramesCount = 0;
            this.wise = this.wise;
        }
        
            if(this.rb <= 0)
        {
                this.wise = -this.wise;
            this.rb = false;
            this.canRotate = this.rb;
            this.wise = this.wise;
        }
        
            return;
        }
        
        val_2 = val_2 + 1;
        this.deadFramesCount = val_2;
    }
    public void StartRotation()
    {
        this.canRotate = true;
        UnityEngine.MonoBehaviour.print(message:  -1610600655);
    }
    public SimpleRotation()
    {
        this.wise = 1f;
        this.deadFrames = 10;
    }

}
