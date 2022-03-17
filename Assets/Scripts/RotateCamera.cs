using UnityEngine;
public class RotateCamera : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform target;
    public float distance;
    private UnityEngine.Vector2 _startPosition;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = eulerAngles;
        this._startPosition = new UnityEngine.Vector2();
        mem[1152921509778441384] = ???;
    }
    private void LateUpdate()
    {
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        if((UnityEngine.Object.op_Implicit(exists:  this.target)) == false)
        {
                return;
        }
        
        object val_2 = Singleton<System.Object>.Instance;
        float val_12 = mem[3221266523];
        float val_13 = mem[3221266527];
        val_12 = this._startPosition + val_12;
        val_13 = S6 + val_13;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  val_12, y:  null, z:  val_13);
        UnityEngine.Transform val_8 = this.transform;
        this.rotation = new UnityEngine.Quaternion() {x = val_4, y = val_5, z = val_6, w = val_7};
        UnityEngine.Vector3 val_9 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 1.806001E-07f, y = val_4, z = val_5, w = val_6}, point:  new UnityEngine.Vector3() {x = val_7, y = 0f, z = 0f});
        UnityEngine.Vector3 val_10 = position;
        float val_14 = val_4;
        float val_15 = val_5;
        float val_16 = val_6;
        val_14 = val_4 + val_14;
        val_15 = val_5 + val_15;
        val_16 = val_6 + val_16;
        UnityEngine.Transform val_11 = this.transform;
        this.position = new UnityEngine.Vector3() {x = val_14, y = val_15, z = val_16};
    }
    private void FixedUpdate()
    {
    
    }
    public RotateCamera()
    {
        this.distance = 5f;
    }

}
