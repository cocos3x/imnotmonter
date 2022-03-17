using UnityEngine;
public class Emitter : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject Projectile;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        float val_6;
        float val_7;
        float val_8;
        float val_12;
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return;
        }
        
        DropdownItem val_2 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this.Projectile);
        UnityEngine.Transform val_3 = this.Projectile.transform;
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = position;
        this.Projectile.position = new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8};
        Weight val_9 = this.Projectile.GetComponent<Weight>();
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Quaternion val_11 = rotation;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_14 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 1.203352E-07f, y = R4, z = R6, w = R7}, point:  new UnityEngine.Vector3() {x = val_12});
        float val_17 = -500f;
        float val_15 = val_7;
        float val_16 = val_8;
        val_15 = val_15 * val_17;
        val_16 = val_16 * val_17;
        val_17 = val_6 * val_17;
        this.Projectile.AddForce(force:  new UnityEngine.Vector3() {x = val_17, y = val_15, z = val_16}, mode:  0);
    }
    public Emitter()
    {
    
    }

}
