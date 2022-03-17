using UnityEngine;
public class FanRopeHand : MonoBehaviour
{
    // Fields
    private float myForce;
    private bool isLeft;
    private UnityEngine.Vector2 forceDirection;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector2 val_3;
        var val_4;
        if(this.isLeft != false)
        {
                UnityEngine.Vector2 val_1 = UnityEngine.Vector2.left;
        }
        else
        {
                UnityEngine.Vector2 val_2 = UnityEngine.Vector2.right;
        }
        
        this.forceDirection = val_3;
        mem[1152921509592098472] = val_4;
    }
    private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
    {
        UnityEngine.GameObject val_1 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610607725)) == true)
        {
            goto label_3;
        }
        
        UnityEngine.GameObject val_3 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610609907)) == false)
        {
            goto label_6;
        }
        
        label_3:
        UnityEngine.GameObject val_5 = collision.gameObject;
        Weight val_6 = collision.GetComponent<Weight>();
        float val_13 = this.myForce;
        float val_7 = val_13 * S4;
        val_13 = val_13 * this.forceDirection;
        collision.AddForce(force:  new UnityEngine.Vector2() {x = val_13, y = val_7});
        label_6:
        UnityEngine.GameObject val_8 = collision.gameObject;
        if((collision.CompareTag(tag:  -1610609907)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_10 = collision.transform;
        UnityEngine.Transform val_11 = collision.parent;
        UnityEngine.Transform val_12 = collision.GetComponent<UnityEngine.Transform>();
        float val_14 = this.myForce;
        val_7 = val_14 * val_7;
        val_14 = val_14 * this.forceDirection;
        collision.AddForce(force:  new UnityEngine.Vector2() {x = val_14, y = val_7});
    }
    public FanRopeHand()
    {
    
    }

}
