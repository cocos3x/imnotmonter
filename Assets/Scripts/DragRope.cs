using UnityEngine;
public class DragRope : MonoBehaviour
{
    // Fields
    private CutTheRope.Script.RopeCutter _ropeCutter;
    private bool candrag;
    public bool Movex;
    private UnityEngine.RaycastHit2D ray;
    private UnityEngine.Rigidbody2D rgbd;
    private UnityEngine.Transform rope;
    private UnityEngine.Vector2 startpos;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.rope.GetComponent<UnityEngine.Transform>();
        this.rgbd = this.rope;
        CutTheRope.Script.RopeCutter val_2 = UnityEngine.Object.FindObjectOfType<CutTheRope.Script.RopeCutter>();
        this._ropeCutter = -1073688263;
    }
    private void OnMouseDown()
    {
        float val_3;
        float val_4;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_6 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_3, z = val_4});
        this.startpos = val_3;
        mem[1152921509496256980] = val_4;
        if(this.Movex != false)
        {
                this.CheckX();
            return;
        }
        
        this.CheckY();
    }
    private void CheckX()
    {
        var val_2;
        UnityEngine.Vector3 val_1 = position;
        var val_3 = val_2;
        val_3 = this.startpos - val_3;
        float val_4 = System.Math.Abs(val_3);
        if(this.rope > 0)
        {
                return;
        }
        
        this.candrag = true;
        this._ropeCutter.cancut = false;
    }
    private void CheckY()
    {
        var val_2;
        UnityEngine.Vector3 val_1 = position;
        var val_3 = val_2;
        val_3 = S16 - val_3;
        float val_4 = System.Math.Abs(val_3);
        if(this.rope > 0)
        {
                return;
        }
        
        this.candrag = true;
        this._ropeCutter.cancut = false;
    }
    private void OnMouseDrag()
    {
        if(this.candrag == false)
        {
                return;
        }
        
        if(this.Movex != false)
        {
                this.DragX();
            return;
        }
        
        this.DragY();
    }
    private void OnMouseUp()
    {
        if(this.candrag == false)
        {
                return;
        }
        
        this.candrag = false;
        this._ropeCutter.cancut = true;
    }
    private void DragX()
    {
        float val_3;
        float val_4;
        float val_16;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_6 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_3, z = val_4});
        UnityEngine.Vector2 val_16 = this.startpos;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        UnityEngine.RaycastHit2D val_8 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 1.342164E-17f, y = val_3}, direction:  new UnityEngine.Vector2() {x = val_4, y = val_3});
        float val_9 = val_8.m_Distance + 16;
        mem[1152921509496866116] = val_8.m_Distance;
        UnityEngine.Collider2D val_10 = this.ray.collider;
        if(this.ray == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_12 = this.ray.transform;
        if((this.ray.CompareTag(tag:  -1610604849)) == false)
        {
                return;
        }
        
        val_16 = val_8.m_Collider - val_16;
        UnityEngine.Vector3 val_14 = position;
        val_16 = val_16 + this.startpos;
        this.rgbd.MovePosition(position:  new UnityEngine.Vector2() {x = val_16, y = val_4});
    }
    private void DragY()
    {
        float val_3;
        float val_4;
        float val_16;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_6 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_3, z = val_4});
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        UnityEngine.RaycastHit2D val_8 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 1.352784E-17f, y = val_3}, direction:  new UnityEngine.Vector2() {x = val_4, y = val_3});
        float val_9 = val_8.m_Distance + 16;
        mem[1152921509496994500] = val_8.m_Distance;
        UnityEngine.Collider2D val_10 = this.ray.collider;
        if(this.ray == 0)
        {
                return;
        }
        
        UnityEngine.Transform val_12 = this.ray.transform;
        if((this.ray.CompareTag(tag:  -1610604849)) == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_15 = position;
        val_16 = val_3;
        val_15.x = (val_8.m_Collider - S16) + val_15.x;
        this.rgbd.MovePosition(position:  new UnityEngine.Vector2() {x = val_16, y = val_15.x});
    }
    public DragRope()
    {
        this.Movex = true;
    }

}
