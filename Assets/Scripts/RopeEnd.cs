using UnityEngine;
public class RopeEnd : MonoBehaviour
{
    // Fields
    private UnityEngine.Rigidbody _rigidBody;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this._rigidBody = this;
    }
    private void Update()
    {
    
    }
    private void FixedUpdate()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this._rigidBody)) == false)
        {
                return;
        }
        
        object val_2 = Singleton<System.Object>.Instance;
        float val_3 = -4f;
        float val_4 = 4f;
        val_3 = mem[3221266527] * val_3;
        val_4 = mem[3221266523] * val_4;
        this._rigidBody.AddForce(force:  new UnityEngine.Vector3() {x = val_4, y = 0f, z = val_3});
    }
    public RopeEnd()
    {
    
    }

}
