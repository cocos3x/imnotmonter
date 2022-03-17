using UnityEngine;
public class RopeSystem : MonoBehaviour
{
    // Fields
    public UnityEngine.LineRenderer ropeRenderer;
    public UnityEngine.LayerMask ropeLayerMask;
    public UnityEngine.Transform ropeHingeAnchor;
    private bool ropeAttached;
    private UnityEngine.Vector2 playerPosition;
    private System.Collections.Generic.List<UnityEngine.Vector2> ropePositions;
    private float ropeMaxCastDistance;
    private bool isColliding;
    private System.Collections.Generic.Dictionary<int, int> wrapPointsLookup;
    
    // Methods
    private void Awake()
    {
        this.ropeAttached = true;
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        this.playerPosition = new UnityEngine.Vector2();
        mem[1152921509562867760] = ???;
        UnityEngine.Vector3 val_3 = position;
        this.ropePositions.Add(item:  new UnityEngine.Vector2() {x = R6, y = R7});
        this.wrapPointsLookup.Add(key:  this.ropePositions - 1, value:  0);
    }
    private UnityEngine.Vector2 GetClosestColliderPointFromRaycastHit(UnityEngine.RaycastHit2D hit, UnityEngine.PolygonCollider2D polyCollider)
    {
        var val_2;
        var val_11;
        var val_12;
        RopeSystem val_14;
        System.Collections.Generic.IEnumerable<TSource> val_15;
        var val_16;
        object val_17;
        System.Func<System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector2>, System.Single> val_18;
        RopeSystem val_19;
        var val_20;
        RopeSystem.<>c__DisplayClass10_0 val_1 = 536900827;
        val_1 = new RopeSystem.<>c__DisplayClass10_0();
        mem[536900835] = hit.m_Centroid.y;
        mem[536900839] = hit.m_Point.x;
        mem[536900843] = hit.m_Point.y;
        mem[536900847] = hit.m_Normal.x;
        mem[536900851] = hit.m_Normal.y;
        mem[536900855] = hit.m_Distance;
        mem[536900859] = hit.m_Fraction;
        mem[536900863] = hit.m_Collider;
        mem[536900867] = polyCollider;
        if(val_1 != 0)
        {
                val_15 = val_1;
            mem[536900871] = val_2;
        }
        else
        {
                val_15 = 44;
            mem[44] = val_2;
        }
        
        UnityEngine.Vector2[] val_3 = val_15.points;
        536875571 = new System.Func<UnityEngine.Vector2, System.Single>(object:  536900827, method:  new IntPtr(1610679383));
        536875573 = new System.Func<UnityEngine.Vector2, UnityEngine.Vector2>(object:  536900827, method:  new IntPtr(1610679385));
        System.Collections.Generic.Dictionary<TKey, TElement> val_6 = System.Linq.Enumerable.ToDictionary<UnityEngine.Vector2, System.Single, UnityEngine.Vector2>(source:  val_15, keySelector:  536875571, elementSelector:  536875573);
        val_16 = 536900823;
        if(((mem[536901010] & true) == 0) && (mem[536900939] == 0))
        {
                val_16 = 536900823;
        }
        
        val_17 = mem[536900915];
        val_18 = mem[mem[536900915] + 4];
        val_18 = mem[536900915] + 4;
        if(val_18 == 0)
        {
                if(((mem[536901010] & true) == 0) && (mem[536900939] == 0))
        {
                val_17 = mem[536900915];
        }
        
            val_18 = 536875327;
            val_18 = new System.Func<System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector2>, System.Single>(object:  val_17, method:  new IntPtr(1610679391));
            mem2[0] = val_18;
        }
        
        System.Linq.IOrderedEnumerable<TSource> val_8 = System.Linq.Enumerable.OrderBy<System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector2>, System.Single>(source:  val_15, keySelector:  536875327);
        if((System.Linq.Enumerable.Any<System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector2>>(source:  val_15)) != false)
        {
                System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector2> val_10 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.Single, UnityEngine.Vector2>>(source:  661173888);
            val_19 = val_11;
            val_20 = val_12;
        }
        else
        {
                UnityEngine.Vector2 val_13 = UnityEngine.Vector2.zero;
            val_19 = val_14;
            val_20 = val_11;
        }
        
        this = val_19;
        mem[1152921509563000212] = val_20;
        return new UnityEngine.Vector2() {x = val_13.x, y = val_13.y};
    }
    private void Update()
    {
        float val_3;
        float val_5;
        var val_25;
        float val_26;
        float val_27;
        var val_28;
        var val_29;
        val_25 = this;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_4 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_6 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = 0f, y = val_3, z = val_5});
        UnityEngine.Transform val_7 = this.transform;
        UnityEngine.Vector3 val_8 = position;
        var val_25 = val_3;
        float val_26 = val_5;
        val_25 = val_3 - val_25;
        val_26 = val_5 - val_26;
        float val_27 = 6.283185f;
        val_27 = val_26 + val_27;
        float val_28 = 57.29578f;
        val_28 = val_26 * val_28;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(x:  val_28, y:  val_8.y, z:  val_26 = val_27);
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.right;
        UnityEngine.Vector3 val_11 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 3.258444E-15f, y = R4, z = R5, w = R6}, point:  new UnityEngine.Vector3() {x = ???, y = val_3, z = val_5});
        UnityEngine.Transform val_12 = this.transform;
        UnityEngine.Vector3 val_13 = position;
        val_28 = val_25;
        this.playerPosition = val_3;
        mem[1152921509563136816] = val_5;
        if(val_3 >= 1)
        {
                UnityEngine.Vector2 val_14 = System.Linq.Enumerable.Last<UnityEngine.Vector2>(source:  661310384);
            float val_29 = val_5;
            val_29 = val_29 - mem[1152921509563136816];
            UnityEngine.Vector2 val_15 = val_3 - this.playerPosition;
            UnityEngine.Vector2 val_16 = normalized;
            float val_17 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = this.playerPosition, y = mem[1152921509563136816]}, b:  new UnityEngine.Vector2() {x = val_3, y = val_5});
            val_28 = val_25;
            int val_18 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.ropeLayerMask});
            float val_30 = -0.1f;
            val_30 = this.playerPosition + val_30;
            UnityEngine.RaycastHit2D val_19 = UnityEngine.Physics2D.Raycast(origin:  new UnityEngine.Vector2() {x = 3.258444E-15f, y = this.playerPosition}, direction:  new UnityEngine.Vector2() {x = mem[1152921509563136816], y = val_3}, distance:  val_30, layerMask:  val_5);
            val_26 = mem[val_19.m_Fraction + (16) + (4)];
            val_25 = val_28;
            if((UnityEngine.RaycastHit2D.op_Implicit(hit:  new UnityEngine.RaycastHit2D() {m_Centroid = new UnityEngine.Vector2() {}, m_Point = new UnityEngine.Vector2() {}, m_Normal = new UnityEngine.Vector2() {x = val_27, y = val_26}, m_Distance = mem[val_19.m_Fraction + (16) + (8)], m_Fraction = mem[val_19.m_Fraction + (16) + (12)], m_Collider = mem[val_19.m_Fraction + (16) + (16)]})) != false)
        {
                val_29 = 0;
            UnityEngine.Collider2D val_21 = mem[val_19.m_Fraction + (0)].collider;
            if(661310416 != 0)
        {
                val_29 = 0;
        }
        
            if(0 != 0)
        {
                UnityEngine.Vector2 val_23 = GetClosestColliderPointFromRaycastHit(hit:  new UnityEngine.RaycastHit2D() {m_Centroid = new UnityEngine.Vector2() {y = mem[val_19.m_Fraction + (0)]}, m_Point = new UnityEngine.Vector2() {x = mem[val_19.m_Fraction + (4)]}, m_Normal = new UnityEngine.Vector2() {y = val_27}, m_Distance = mem[val_19.m_Fraction + (16) + (4)]}, polyCollider:  null);
            val_26 = this.ropePositions;
            val_26.Add(item:  new UnityEngine.Vector2() {x = val_3, y = val_5});
            this.wrapPointsLookup.Add(key:  this.ropePositions - 1, value:  0);
        }
        
        }
        
        }
        
        this.UpdateRopePositions();
        this.HandleRopeUnwrap();
    }
    private void ResetRope1(UnityEngine.Vector2 _closestPointToHit)
    {
    
    }
    private void ResetRope()
    {
        float val_3;
        float val_4;
        float val_5;
        this.ropeRenderer.positionCount = 2;
        UnityEngine.Transform val_1 = this.ropeRenderer.transform;
        UnityEngine.Vector3 val_2 = position;
        this.ropeRenderer.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
        UnityEngine.Transform val_6 = this.transform;
        UnityEngine.Vector3 val_7 = position;
        this.ropeRenderer.SetPosition(index:  1, position:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
        this.ropePositions.Clear();
        this.wrapPointsLookup.Clear();
    }
    private void SetCrosshairPosition(float aimAngle)
    {
        UnityEngine.Transform val_1 = this.transform;
        UnityEngine.Vector3 val_2 = position;
        UnityEngine.Transform val_3 = this.transform;
        UnityEngine.Vector3 val_4 = position;
    }
    private void UpdateRopePositions()
    {
        float val_9;
        float val_10;
        float val_19;
        float val_20;
        UnityEngine.LineRenderer val_21;
        System.Collections.Generic.List<UnityEngine.Vector2> val_22;
        var val_23;
        var val_24;
        float val_25;
        float val_26;
        if(this.ropeAttached == false)
        {
                return;
        }
        
        this.ropeRenderer.positionCount = this.ropePositions + 1;
        val_20 = 0f;
        int val_2 = this.ropeRenderer.positionCount;
        val_2 = val_2 - 1;
        if(val_2 < 0)
        {
                return;
        }
        
        var val_3 = 8 + (val_2 << 3);
        label_30:
        int val_4 = val_2 - 1;
        int val_5 = this.ropeRenderer.positionCount;
        val_21 = this.ropeRenderer;
        if(val_2 != val_5)
        {
            goto label_7;
        }
        
        UnityEngine.Transform val_6 = this.ropeRenderer.transform;
        UnityEngine.Vector3 val_7 = position;
        val_20 = 0;
        val_21.SetPosition(index:  val_4, position:  new UnityEngine.Vector3() {x = R5, y = R6, z = ???});
        goto label_23;
        label_7:
        if(val_5 <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_21.SetPosition(index:  val_4, position:  new UnityEngine.Vector3() {x = 0 + (8 + (val_2) << 3), y = 0 + (8 + (val_2) << 3) + 4, z = val_20});
        if(val_2 != val_21)
        {
                if(val_21 != 1)
        {
            goto label_17;
        }
        
        }
        
        val_22 = this.ropePositions;
        if(val_22 == 0)
        {
            goto label_18;
        }
        
        if(val_4 != 0)
        {
                val_23 = 1;
        }
        
        val_24 = val_4 - 1;
        goto label_19;
        label_18:
        val_22 = this.ropePositions;
        if(val_22 == 0)
        {
            goto label_20;
        }
        
        val_24 = val_21 - 1;
        if(val_21 != 0)
        {
                val_23 = 1;
        }
        
        goto label_21;
        label_17:
        UnityEngine.Vector2 val_8 = System.Linq.Enumerable.Last<UnityEngine.Vector2>(source:  661877248);
        val_19 = val_9;
        val_21 = val_10;
        if((val_2 - 2) != (this.ropePositions.IndexOf(item:  new UnityEngine.Vector2() {x = val_19, y = val_21})))
        {
            goto label_23;
        }
        
        UnityEngine.Vector2 val_13 = System.Linq.Enumerable.Last<UnityEngine.Vector2>(source:  661877248);
        val_21 = val_9;
        UnityEngine.Transform val_14 = this.ropeHingeAnchor.transform;
        val_19 = this.ropeHingeAnchor;
        val_25 = val_21;
        val_26 = val_10;
        goto label_26;
        label_20:
        val_24 = -1;
        val_22 = 0;
        if(0 > val_24)
        {
                val_23 = 1;
        }
        
        label_21:
        label_19:
        if(1 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_17 = 0;
        val_17 = val_17 + 4294967288;
        val_19 = mem[(0 + 4294967288) + 16];
        val_19 = (0 + 4294967288) + 16;
        UnityEngine.Transform val_15 = this.ropeHingeAnchor.transform;
        val_25 = val_19;
        val_26 = val_21;
        label_26:
        this.ropeHingeAnchor.position = new UnityEngine.Vector3() {x = val_25, y = val_26, z = 0f};
        label_23:
        val_3 = val_3 - 8;
        if((val_2 - 2) > 1)
        {
            goto label_30;
        }
    
    }
    private void HandleRopeUnwrap()
    {
        System.Collections.Generic.List<UnityEngine.Vector2> val_13;
        var val_14;
        bool val_15;
        float val_16;
        bool val_17;
        System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_18;
        int val_19;
        var val_20;
        var val_21;
        if(true < 2)
        {
                return;
        }
        
        val_13 = this.ropePositions;
        if(val_13 == 0)
        {
            goto label_3;
        }
        
        val_14 = -1;
        goto label_4;
        label_3:
        val_13 = this.ropePositions;
        val_14 = -1;
        if(val_13 == 0)
        {
            goto label_5;
        }
        
        label_4:
        label_33:
        if(true <= val_14)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = val_13 - 1;
        val_12 = val_12 + 4294967288;
        if(val_12 <= val_1)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + (val_1 << 3);
        float val_14 = (0 + ((this.ropePositions - 1)) << 3) + 16;
        float val_15 = (0 + ((this.ropePositions - 1)) << 3) + 20;
        val_14 = val_14 - ((0 + 4294967288) + 16);
        val_15 = val_15 - ((0 + 4294967288) + 20);
        float val_2 = (0 + 4294967288) + 16.sqrMagnitude;
        float val_3 = val_14.sqrMagnitude;
        float val_4 = 662079360 * 662079352;
        if(mem[536890411] >= _TYPE_MAX_)
        {
                float val_17 = val_4;
        }
        
        if(mem[536890411] >= 0)
        {
                float val_16 = val_15;
            val_16 = ((0 + 4294967288) + 20) * val_16;
            val_17 = val_16 / val_17;
            val_15 = mem[536890482];
            if((val_15 & true) == 0)
        {
                val_15 = mem[536890411];
        }
        
            val_16 = (UnityEngine.Mathf.Clamp(value:  val_17, min:  null, max:  val_14)) * 57.29578f;
        }
        else
        {
                val_16 = 0f;
        }
        
        UnityEngine.Vector2 val_18 = this.playerPosition;
        val_18 = val_18 - ((0 + 4294967288) + 16);
        val_4 = val_4 - ((0 + 4294967288) + 20);
        float val_6 = (0 + 4294967288) + 16.sqrMagnitude;
        float val_7 = val_18.sqrMagnitude;
        if(mem[536890411] >= _TYPE_MAX_)
        {
                float val_20 = 662079360 * 662079352;
        }
        
        if(mem[536890411] >= 0)
        {
                float val_19 = val_4;
            val_19 = ((0 + 4294967288) + 20) * val_19;
            val_20 = val_19 / val_20;
            val_17 = mem[536890482];
            if((val_17 & true) == 0)
        {
                val_17 = mem[536890411];
        }
        
            float val_10 = (UnityEngine.Mathf.Clamp(value:  val_20, min:  null, max:  val_18)) * 57.29578f;
        }
        
        int val_11 = this.wrapPointsLookup.Item[val_1];
        if(this.wrapPointsLookup >= 0)
        {
            goto label_26;
        }
        
        if(val_11 == 1)
        {
            goto label_30;
        }
        
        val_18 = this.wrapPointsLookup;
        val_19 = val_1;
        val_20 = 0;
        val_21 = 22724700;
        goto label_29;
        label_26:
        if(val_11 == 1)
        {
            goto label_30;
        }
        
        val_18 = this.wrapPointsLookup;
        val_19 = val_1;
        val_20 = 1;
        val_21 = 22724700;
        label_29:
        val_18.set_Item(key:  val_19, value:  1);
        return;
        label_30:
        this.UnwrapRopePosition(anchorIndex:  -1, hingeIndex:  val_1);
        return;
        label_5:
        if(this.ropePositions != 0)
        {
            goto label_33;
        }
    
    }
    private void UnwrapRopePosition(int anchorIndex, int hingeIndex)
    {
        if(true <= anchorIndex)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (anchorIndex << 3);
        bool val_1 = this.wrapPointsLookup.Remove(key:  hingeIndex);
        this.ropePositions.RemoveAt(index:  hingeIndex);
        UnityEngine.Transform val_2 = this.ropeHingeAnchor.transform;
        this.ropeHingeAnchor.position = new UnityEngine.Vector3() {x = (0 + (anchorIndex) << 3) + 16, y = SB, z = 0f};
    }
    private void OnTriggerStay2D(UnityEngine.Collider2D colliderStay)
    {
        this.isColliding = true;
    }
    private void OnTriggerExit2D(UnityEngine.Collider2D colliderOnExit)
    {
        this.isColliding = false;
    }
    public RopeSystem()
    {
        536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        this.ropePositions = 536878507;
        this.ropeMaxCastDistance = 20f;
        536874209 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>();
        this.wrapPointsLookup = 536874209;
    }

}
