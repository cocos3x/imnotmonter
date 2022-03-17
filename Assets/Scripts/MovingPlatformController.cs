using UnityEngine;
public class MovingPlatformController : MonoBehaviour
{
    // Fields
    private bool canMove;
    private int z;
    private UnityEngine.Transform pos1;
    private UnityEngine.Transform pos2;
    private UnityEngine.Transform pos;
    private float speed;
    
    // Methods
    private void ResetPos()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        this.position = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
    }
    private void Start()
    {
        if(this.pos1 == 0)
        {
                return;
        }
        
        R4 + 20.parent = 0;
        R4 + 24.parent = 0;
        var val_2 = R4 + 28;
        mem2[0] = R4 + 20;
    }
    private void Update()
    {
        float val_5;
        float val_6;
        float val_7;
        var val_19;
        if(this.canMove == false)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.transform;
        val_19 = this;
        if(this.pos1 != 0)
        {
                UnityEngine.Transform val_3 = this.transform;
            UnityEngine.Vector3 val_4 = position;
            UnityEngine.Vector3 val_8 = position;
            float val_9 = UnityEngine.Time.deltaTime;
            float val_19 = this.speed;
            val_19 = 0 * val_19;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = 5.507112E-17f, y = val_6, z = val_5}, target:  new UnityEngine.Vector3() {x = val_7, y = val_6, z = val_5}, maxDistanceDelta:  val_19);
            this.position = new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_7};
            UnityEngine.Transform val_11 = this.transform;
            UnityEngine.Vector3 val_12 = position;
            UnityEngine.Vector3 val_13 = position;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_7}, rhs:  new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_7})) != false)
        {
                this.pos = this.pos2;
        }
        
            UnityEngine.Transform val_15 = this.pos1.transform;
            val_19 = 0;
            UnityEngine.Vector3 val_16 = position;
            UnityEngine.Vector3 val_17 = position;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_7}, rhs:  new UnityEngine.Vector3() {x = val_6, y = val_5, z = val_7})) == false)
        {
                return;
        }
        
            this.pos = this.pos1;
            return;
        }
        
        this.Rotate(xAngle:  (float)this.z, yAngle:  null, zAngle:  null);
    }
    public MovingPlatformController()
    {
        this.speed = 1f;
        this.canMove = true;
    }

}
