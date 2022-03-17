using UnityEngine;
public class RopeSlefMovementControl : MonoBehaviour
{
    // Fields
    public RopeRescueCut rope;
    private UnityEngine.Transform firstSegment;
    private float elapsedTime;
    
    // Methods
    private void Start()
    {
        RopeRescueCut val_7 = this.rope;
        if((UnityEngine.Object.op_Implicit(exists:  val_7 = this.rope)) == true)
        {
                return;
        }
        
        UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
        this.rope = this;
        val_7 = this.rope;
        if((UnityEngine.Object.op_Implicit(exists:  val_7)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Transform val_5 = this.GetChild(index:  0);
        this.firstSegment = this.rope;
        UnityEngine.Transform val_6 = this.GetComponent<UnityEngine.Transform>();
        this.isKinematic = true;
    }
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        uint val_4 = 0;
        val_4 = this.elapsedTime + val_4;
        this.elapsedTime = val_4;
        if((UnityEngine.Object.op_Implicit(exists:  this.rope)) == false)
        {
                return;
        }
        
        UnityEngine.Transform val_3 = this.firstSegment.GetComponent<UnityEngine.Transform>();
        float val_5 = this.elapsedTime;
        val_5 = val_5 + val_5;
        this.firstSegment.velocity = new UnityEngine.Vector2() {x = val_5, y = 0f};
    }
    public RopeSlefMovementControl()
    {
    
    }

}
