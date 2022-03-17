using UnityEngine;
public class TouchManager : MonoBehaviour
{
    // Fields
    private UnityEngine.LayerMask layerMaskBarrier;
    private UnityEngine.Vector2 mousePosStart;
    private UnityEngine.Vector2 mousePosEnd;
    private StickBarrier barrier;
    private StickBarrierMoveTrackController barrierMoveTrack;
    
    // Methods
    private void Update()
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        if((-1073701037.CanCheck()) == false)
        {
                return;
        }
        
        R4.CheckTouch();
    }
    private void CheckTouch()
    {
        float val_6;
        float val_7;
        TouchManager val_59;
        var val_60;
        var val_62;
        var val_63;
        val_59 = this;
        UnityEngine.EventSystems.EventSystem val_1 = UnityEngine.EventSystems.EventSystem.current;
        if((0.IsPointerOverGameObject() != true) && ((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false))
        {
                UnityEngine.Camera val_4 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_9 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_6, z = val_7});
            mem[1152921509546191136] = val_6;
            mem[1152921509546191140] = val_7;
            UnityEngine.Transform val_10 = this.transform;
            UnityEngine.Vector3 val_11 = forward;
            float val_59 = val_6;
            int val_12 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = mem[1152921509546191132]});
            val_59 = val_59 ^ 2147483648;
            UnityEngine.RaycastHit2D val_14 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 8.056922E-16f, y = val_6}, direction:  new UnityEngine.Vector2() {x = val_7, y = val_59}, distance:  val_11.x, layerMask:  val_7 ^ 2147483648);
            UnityEngine.Collider2D val_15 = mem[val_14.m_Normal.y + (0)].collider;
            val_59 = val_59;
            if(644364776 != 0)
        {
                UnityEngine.Collider2D val_17 = mem[val_14.m_Normal.y + (0)].collider;
            if((mem[val_14.m_Normal.y + (0)].CompareTag(tag:  -1610604369)) != false)
        {
                UnityEngine.Collider2D val_19 = mem[val_14.m_Normal.y + (0)].collider;
            UnityEngine.Transform val_20 = mem[val_14.m_Normal.y + (0)].GetComponent<UnityEngine.Transform>();
            mem[1152921509546191152] = ;
            mem[val_14.m_Normal.y + (0)].BarrieTarget();
        }
        
            UnityEngine.Collider2D val_21 = mem[val_14.m_Normal.y + (0)].collider;
            if((mem[val_14.m_Normal.y + (0)].CompareTag(tag:  -1610604367)) != false)
        {
                UnityEngine.Collider2D val_23 = mem[val_14.m_Normal.y + (0)].collider;
            UnityEngine.Transform val_24 = mem[val_14.m_Normal.y + (0)].GetComponent<UnityEngine.Transform>();
            mem[1152921509546191156] = ;
        }
        
            UnityEngine.Collider2D val_25 = mem[val_14.m_Normal.y + (0)].collider;
            if((mem[val_14.m_Normal.y + (0)].CompareTag(tag:  -1610604365)) != false)
        {
                UnityEngine.Collider2D val_27 = mem[val_14.m_Normal.y + (0)].collider;
            UnityEngine.Transform val_28 = mem[val_14.m_Normal.y + (0)].transform;
            UnityEngine.Transform val_29 = mem[val_14.m_Normal.y + (0)].parent;
            UnityEngine.Transform val_30 = mem[val_14.m_Normal.y + (0)].GetChild(index:  0);
            UnityEngine.Transform val_31 = mem[val_14.m_Normal.y + (0)].GetComponent<UnityEngine.Transform>();
            mem[1152921509546191156] = ;
        }
        
            if(644364776 == 0)
        {
                if(644364776 == 0)
        {
            goto label_32;
        }
        
        }
        
            if((SingletonMonoBehaviour<TransitionFX>.Exists()) != false)
        {
                WorldTimeAPI val_35 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            -1073701113.Shot(clip:  -1610609335, volume:  val_11.x);
        }
        
        }
        
        }
        
        label_32:
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
            goto label_34;
        }
        
        val_60 = val_59;
        val_62 = 0;
        UnityEngine.Camera val_37 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_38 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_39 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = R5, z = R6});
        val_59 = val_60;
        val_63 = val_60;
        if((UnityEngine.Object.op_Implicit(exists:  644364776)) == false)
        {
            goto label_38;
        }
        
        float val_41 = mem[val_14.m_Normal.y + (0)].AngleOfPathMove();
        float val_42 = this.AngleEndMouseWithBarrie();
        uint val_60 = 644376848;
        if(mem[1152921509546191152] == 0)
        {
            goto label_40;
        }
        
        val_60 = val_60 - 644364776;
        float val_61 = System.Math.Abs(val_60);
        if(mem[1152921509546191152] > 0)
        {
            goto label_41;
        }
        
        label_40:
        mem[val_14.m_Normal.y + (0)].MoveActivated();
        label_41:
        mem[val_14.m_Normal.y + (0)].BarrieNotTarget();
        label_38:
        if((UnityEngine.Object.op_Implicit(exists:  644364776)) != false)
        {
                mem[val_14.m_Normal.y + (0)].MoveActivated();
        }
        
        mem[1152921509546191152] = 0;
        mem[1152921509546191156] = 0;
        label_34:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
                return;
        }
        
        UnityEngine.Camera val_45 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_46 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_47 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = R5, z = R6});
        UnityEngine.Vector2 val_48 = UnityEngine.Vector2.zero;
        UnityEngine.RaycastHit2D val_49 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 8.056922E-16f, y = val_6}, direction:  new UnityEngine.Vector2() {x = val_7, y = val_6});
        UnityEngine.Collider2D val_50 = mem[val_49.m_Normal.x + (0)].collider;
        if(644364736 == 0)
        {
                return;
        }
        
        UnityEngine.Collider2D val_52 = mem[val_49.m_Normal.x + (0)].collider;
        string val_53 = mem[val_49.m_Normal.x + (0)].tag;
        if((System.String.op_Equality(a:  644364736, b:  -1610606635)) == false)
        {
                return;
        }
        
        UnityEngine.Collider2D val_55 = mem[val_49.m_Normal.x + (0)].collider;
        UnityEngine.Transform val_56 = mem[val_49.m_Normal.x + (0)].transform;
        UnityEngine.Transform val_57 = mem[val_49.m_Normal.x + (0)].parent;
        UnityEngine.GameObject val_58 = mem[val_49.m_Normal.x + (0)].gameObject;
        UnityEngine.Object.Destroy(obj:  644364736);
    }
    private float AngleEndMouseWithBarrie()
    {
        float val_4;
        float val_5;
        bool val_10;
        float val_11;
        UnityEngine.Vector2 val_10 = this.mousePosStart;
        val_10 = this.mousePosEnd - val_10;
        UnityEngine.Transform val_2 = this.barrier.transform;
        UnityEngine.Vector3 val_3 = up;
        val_5 = S22 - S18;
        val_4 = val_10;
        float val_6 = val_4.sqrMagnitude;
        float val_7 = -val_4.sqrMagnitude;
        if(mem[536890411] >= _TYPE_MAX_)
        {
                float val_12 = 644480908 * 644480920;
        }
        
        if(mem[536890411] >= 0)
        {
                float val_11 = -val_5;
            val_11 = val_5 * val_11;
            val_12 = val_11 / val_12;
            val_10 = mem[536890482];
            if((val_10 & true) == 0)
        {
                val_10 = mem[536890411];
        }
        
            val_11 = (UnityEngine.Mathf.Clamp(value:  val_12, min:  val_3.y, max:  -val_4)) * 57.29578f;
            return val_11;
        }
        
        val_11 = 0f;
        return val_11;
    }
    private float AngleEndMouseWithBarrieMoveTrack()
    {
        bool val_8;
        float val_9;
        UnityEngine.Vector2 val_8 = this.mousePosStart;
        val_8 = this.mousePosEnd - val_8;
        UnityEngine.Transform val_2 = this.barrierMoveTrack.transform;
        UnityEngine.Vector3 val_3 = right;
        float val_4 = val_8.sqrMagnitude;
        float val_5 = ???.sqrMagnitude;
        if(mem[536890411] >= _TYPE_MAX_)
        {
                float val_10 = 644601100 * 644601112;
        }
        
        if(mem[536890411] >= 0)
        {
                float val_9 = ???;
            val_9 = (S22 - S18) * val_9;
            val_10 = val_9 / val_10;
            val_8 = mem[536890482];
            if((val_8 & true) == 0)
        {
                val_8 = mem[536890411];
        }
        
            val_9 = (UnityEngine.Mathf.Clamp(value:  val_10, min:  val_3.y, max:  ???)) * 57.29578f;
            return val_9;
        }
        
        val_9 = 0f;
        return val_9;
    }
    public TouchManager()
    {
    
    }

}
