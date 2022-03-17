using UnityEngine;
public class DragRopeWithMouse : MonoBehaviour
{
    // Fields
    public RopeRescueCut rope;
    private UnityEngine.Transform firstSegment;
    
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
        float val_4;
        float val_5;
        if((UnityEngine.Object.op_Implicit(exists:  this.rope)) == false)
        {
                return;
        }
        
        UnityEngine.Camera val_2 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_3 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_7 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_5});
        UnityEngine.Transform val_8 = this.firstSegment.GetComponent<UnityEngine.Transform>();
        this.firstSegment.MovePosition(position:  new UnityEngine.Vector2() {x = val_4, y = val_5});
    }
    public DragRopeWithMouse()
    {
    
    }

}
