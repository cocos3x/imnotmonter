using UnityEngine;
public class Roll : MonoBehaviour
{
    // Fields
    private UnityEngine.Rigidbody rb;
    public Roll.RollDirection Direction;
    private float velocity;
    public bool Invert;
    
    // Methods
    private void Start()
    {
        this.velocity = 1f;
        UnityEngine.GameObject val_1 = this.gameObject;
        Weight val_2 = this.GetComponent<Weight>();
        this.rb = this;
    }
    private void Update()
    {
    
    }
    public void FixedUpdate()
    {
        UnityEngine.Rigidbody val_1;
        UnityEngine.ForceMode val_2;
        var val_3;
        float val_4;
        var val_5;
        if(this.Invert == false)
        {
                -1f = 1f;
        }
        
        if(this.Direction == 2)
        {
            goto label_0;
        }
        
        if(this.Direction == 1)
        {
            goto label_1;
        }
        
        if(this.Direction != 0)
        {
                return;
        }
        
        val_1 = this.rb;
        -1f = (-1f) * this.velocity;
        val_2 = 0;
        val_3 = -1f;
        val_4 = 0;
        goto label_4;
        label_0:
        -1f = (-1f) * this.velocity;
        val_3 = 0;
        val_4 = 0;
        val_5 = -1f;
        goto label_6;
        label_1:
        val_1 = this.rb;
        -1f = (-1f) * this.velocity;
        val_2 = 0;
        val_3 = 0;
        val_4 = -1f;
        label_4:
        val_5 = 0;
        label_6:
        val_1.AddRelativeTorque(torque:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = 0f}, mode:  val_2);
    }
    public Roll()
    {
    
    }

}
