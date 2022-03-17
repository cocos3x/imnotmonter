using UnityEngine;
public class ArrowController : MonoBehaviour
{
    // Fields
    private bool canMove;
    private bool seeCharacter;
    private UnityEngine.Vector2 dir;
    private float currentTimeDelay;
    private UnityEngine.GameObject arrow;
    private float moveSpeed;
    private float delayTime;
    private float findDistance;
    protected UnityEngine.LayerMask raycastLayer;
    
    // Methods
    private void Start()
    {
        this.currentTimeDelay = this.delayTime;
    }
    private void Update()
    {
        this.FindTarget();
    }
    private void FindTarget()
    {
        float val_3;
        float val_8;
        int val_9;
        float val_20;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = eulerAngles;
        float val_35 = 90f;
        float val_32 = val_3;
        val_32 = val_32 + val_35;
        val_32 = val_32 * 0.01745329f;
        float val_33 = val_32;
        UnityEngine.Transform val_4 = this.transform;
        val_33 = val_33 * 0.12f;
        UnityEngine.Vector3 val_5 = eulerAngles;
        var val_34 = val_3;
        val_34 = val_34 + val_35;
        val_34 = val_34 * 0.01745329f;
        val_35 = val_34 * 0.12f;
        UnityEngine.Transform val_6 = this.transform;
        UnityEngine.Vector3 val_7 = position;
        val_33 = val_33 + val_8;
        val_35 = val_35 + val_9;
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Vector3 val_11 = up;
        int val_12 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.raycastLayer});
        UnityEngine.RaycastHit2D val_13 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 8.688894E-16f, y = val_33}, direction:  new UnityEngine.Vector2() {x = val_35, y = val_8}, distance:  val_11.x, layerMask:  val_9);
        UnityEngine.Transform val_14 = this.transform;
        UnityEngine.Vector3 val_15 = up;
        UnityEngine.Color val_16 = UnityEngine.Color.blue;
        UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_33, y = val_35, z = 0f}, dir:  new UnityEngine.Vector3() {x = val_8 * this.findDistance, y = val_9 * this.findDistance, z = val_3 * this.findDistance}, color:  new UnityEngine.Color() {r = val_8, g = val_9, b = val_3, a = val_20});
        if((UnityEngine.RaycastHit2D.op_Implicit(hit:  new UnityEngine.RaycastHit2D() {m_Centroid = new UnityEngine.Vector2() {}, m_Point = new UnityEngine.Vector2() {}, m_Normal = new UnityEngine.Vector2() {y = mem[val_13.m_Fraction + (16) + (4)]}, m_Distance = mem[val_13.m_Fraction + (16) + (8)], m_Fraction = mem[val_13.m_Fraction + (16) + (12)], m_Collider = mem[val_13.m_Fraction + (16) + (16)]})) == false)
        {
            goto label_19;
        }
        
        UnityEngine.Collider2D val_22 = mem[val_13.m_Fraction + (0)].collider;
        UnityEngine.GameObject val_23 = mem[val_13.m_Fraction + (0)].gameObject;
        if((mem[val_13.m_Fraction + (0)].CompareTag(tag:  -1610605337)) == true)
        {
            goto label_16;
        }
        
        UnityEngine.Collider2D val_25 = mem[val_13.m_Fraction + (0)].collider;
        UnityEngine.GameObject val_26 = mem[val_13.m_Fraction + (0)].gameObject;
        if((mem[val_13.m_Fraction + (0)].CompareTag(tag:  -1610608497)) == true)
        {
            goto label_16;
        }
        
        UnityEngine.Collider2D val_28 = mem[val_13.m_Fraction + (0)].collider;
        UnityEngine.GameObject val_29 = mem[val_13.m_Fraction + (0)].gameObject;
        if((mem[val_13.m_Fraction + (0)].CompareTag(tag:  -1610607699)) == false)
        {
            goto label_19;
        }
        
        label_16:
        mem[1152921509547384860] = 1;
        label_19:
        if(mem[1152921509547384860] == 0)
        {
                return;
        }
        
        float val_31 = UnityEngine.Time.deltaTime;
        uint val_36 = 0;
        val_36 = mem[1152921509547384872] - val_36;
        mem[1152921509547384872] = val_36;
        if(mem[1152921509547384860] <= 0)
        {
                0 = this;
            this.MoveArrow();
        }
    
    }
    public void ResetCanMove()
    {
        this.canMove = false;
        this.currentTimeDelay = this.delayTime;
    }
    private void MoveArrow()
    {
        var val_4;
        var val_5;
        var val_6;
        Weight val_1 = this.arrow.GetComponent<Weight>();
        this.arrow.isTrigger = false;
        UnityEngine.Transform val_2 = this.arrow.transform;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        var val_15 = val_5;
        UnityEngine.Transform val_7 = this.transform;
        UnityEngine.Vector3 val_8 = localScale;
        var val_14 = val_4;
        float val_9 = val_15 * val_14;
        float val_10 = val_6 * val_14;
        val_14 = val_4 * val_14;
        val_15 = val_9 * this.moveSpeed;
        float val_13 = UnityEngine.Time.deltaTime;
        uint val_16 = 0;
        val_10 = (val_10 * this.moveSpeed) * val_16;
        val_9 = val_15 * val_16;
        val_16 = (val_14 * this.moveSpeed) * val_16;
        this.arrow.Translate(translation:  new UnityEngine.Vector3() {y = val_9, z = val_10});
    }
    public ArrowController()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.right;
        this.dir = new UnityEngine.Vector2();
        mem[1152921509547737252] = ???;
    }

}
