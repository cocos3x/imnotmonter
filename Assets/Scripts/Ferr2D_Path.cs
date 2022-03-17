using UnityEngine;
public class Ferr2D_Path : MonoBehaviour
{
    // Fields
    public bool closed;
    public System.Collections.Generic.List<UnityEngine.Vector2> pathVerts;
    
    // Properties
    public int Count { get; }
    
    // Methods
    public int get_Count()
    {
        if(this.pathVerts != 0)
        {
                return (int)true;
        }
        
        return (int)true;
    }
    public void ReCenter()
    {
        float val_2;
        var val_3;
        float val_21;
        var val_23;
        var val_24;
        var val_25;
        System.Collections.Generic.List<UnityEngine.Vector2> val_26;
        var val_28;
        val_23 = 0;
        UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
        val_24 = val_3;
        val_25 = val_2;
        var val_23 = val_24;
        goto label_1;
        label_6:
        val_26 = this.pathVerts;
        if(val_26 != 0)
        {
            
        }
        else
        {
                val_26 = 0;
        }
        
        if(val_23 >= mem[23000412])
        {
            goto label_4;
        }
        
        label_7:
        if(440939804 <= val_23)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_22 = 0;
        val_23 = 1;
        val_22 = val_22 + 16;
        val_25 = val_2 + val_22;
        val_23 = val_23 + ((0 + 16) + 4);
        val_24 = val_23;
        label_1:
        if(this.pathVerts == 0)
        {
            goto label_6;
        }
        
        if(val_23 < val_22)
        {
            goto label_7;
        }
        
        label_4:
        float val_25 = (float)val_22;
        UnityEngine.Transform val_4 = this.transform;
        UnityEngine.Vector3 val_5 = position;
        float val_26 = val_2;
        UnityEngine.Transform val_6 = this.transform;
        UnityEngine.Vector3 val_7 = position;
        UnityEngine.GameObject val_8 = this.gameObject;
        var val_24 = val_24;
        UnityEngine.Transform val_9 = this.transform;
        val_24 = val_24 / val_25;
        val_25 = val_25 / val_25;
        UnityEngine.Vector3 val_10 = position;
        var val_27 = val_2;
        UnityEngine.GameObject val_11 = this.gameObject;
        val_26 = val_25 + val_26;
        val_28 = 0;
        float val_12 = val_24 + val_3;
        UnityEngine.Transform val_13 = this.transform;
        UnityEngine.Vector3 val_14 = position;
        val_27 = val_26 - val_27;
        goto label_14;
        label_18:
        if(440939804 <= val_28)
        {
                float val_28 = 0f;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_28 = val_28 + 16;
        float val_29 = val_28;
        float val_30 = (0 + 16) + 4;
        val_29 = val_29 - val_27;
        val_30 = val_30 - (val_12 - val_3);
        this.pathVerts.set_Item(index:  0, value:  new UnityEngine.Vector2() {x = val_29, y = val_30});
        val_28 = 1;
        label_14:
        if(val_28 < this.pathVerts)
        {
            goto label_18;
        }
        
        UnityEngine.GameObject val_16 = this.gameObject;
        UnityEngine.Transform val_17 = this.transform;
        UnityEngine.GameObject val_18 = this.gameObject;
        UnityEngine.Transform val_19 = this.transform;
        UnityEngine.Vector3 val_20 = position;
        this.position = new UnityEngine.Vector3() {x = val_26, y = val_12, z = val_21};
        this.UpdateDependants(aFullUpdate:  true);
    }
    public void UpdateDependants(bool aFullUpdate)
    {
        var val_4;
        var val_5;
        var val_6;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_4 = 0;
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073757721)});
        val_5 = 1073757721;
        UnityEngine.Component[] val_3 = this.GetComponents(type:  1073757721);
        goto label_4;
        label_12:
        val_5 = Ferr2D_Path.__il2cppRuntimeField_byval_arg;
        if(0 == 0)
        {
            goto label_7;
        }
        
        var val_6 = 0;
        label_9:
        if(1179403647 == 536886809)
        {
            goto label_8;
        }
        
        val_6 = val_6 + 1;
        if(((uint)val_6 & 65535) < 0)
        {
            goto label_9;
        }
        
        label_7:
        val_6 = val_5;
        goto label_10;
        label_8:
        var val_4 = 0 + 0;
        label_10:
        val_4 = 1;
        label_4:
        if(val_4 < this.closed)
        {
            goto label_12;
        }
    
    }
    public void UpdateColliders()
    {
        var val_4;
        var val_5;
        UnityEngine.GameObject val_1 = this.gameObject;
        val_4 = 0;
        System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073757685)});
        UnityEngine.Component[] val_3 = this.GetComponents(type:  1073757685);
        goto label_4;
        label_11:
        if(this <= val_4)
        {
                val_5 = 0;
        }
        
        if(this.pathVerts.SyncRoot == 0)
        {
            goto label_8;
        }
        
        val_5 = 536886773;
        if((mem[this.pathVerts.SyncRoot] + 180) < mem[536886953])
        {
            goto label_8;
        }
        
        var val_4 = mem[this.pathVerts.SyncRoot] + 100;
        val_4 = val_4 + (mem[536886953] << 2);
        if(((mem[this.pathVerts.SyncRoot] + 100 + (mem[536886953]) << 2) + -4) != val_5)
        {
            goto label_8;
        }
        
        if((mem[this.pathVerts.SyncRoot + 178]) != 0)
        {
                this.pathVerts.SyncRoot.RecreateCollider();
        }
        
        val_4 = 1;
        label_4:
        if(val_4 < this.closed)
        {
            goto label_11;
        }
        
        return;
        label_8:
    }
    public void Add(UnityEngine.Vector2 aPoint)
    {
        this.pathVerts.Add(item:  new UnityEngine.Vector2() {x = aPoint.x, y = aPoint.y});
    }
    public int GetClosestSeg(UnityEngine.Vector2 aPoint)
    {
        float val_4;
        float val_5;
        Ferr2D_Path val_9;
        bool val_10;
        System.Collections.Generic.List<UnityEngine.Vector2> val_11;
        var val_12;
        float val_13;
        var val_14;
        var val_15;
        var val_16;
        val_9 = this;
        if(0 < 1)
        {
            goto label_2;
        }
        
        val_10 = this.closed;
        bool val_1 = val_10 - 1;
        if(0 < 1)
        {
            goto label_4;
        }
        
        var val_10 = 0;
        var val_14 = 16;
        float val_9 = aPoint.y;
        do
        {
            val_11 = this.pathVerts;
            if(this.pathVerts == 0)
        {
                val_11 = this.pathVerts;
        }
        
            val_9 = val_9 - 1;
            val_10 = val_10 + 1;
            if(this.pathVerts != 0)
        {
                val_10 - val_9 = val_10;
        }
        
            val_12 = val_10 - 1;
            if(val_9 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(16 <= (val_10 - val_9))
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_11 = val_11 + ((val_10 - val_9) << 3);
            UnityEngine.Vector2 val_3 = Ferr2D_Path.GetClosetPointOnLine(aStart:  new UnityEngine.Vector2() {x = 4.300943E-23f, y = 3.673424E-39f}, aEnd:  new UnityEngine.Vector2() {x = 1.401298E-45f, y = (0 + ((0 + 1)) << 3) + 16}, aPoint:  new UnityEngine.Vector2() {x = (0 + ((0 + 1)) << 3) + 20, y = aPoint.x}, aClamp:  aPoint.y);
            float val_12 = val_4;
            float val_13 = val_5;
            val_12 = aPoint.x - val_12;
            val_13 = val_9 - val_13;
            float val_6 = val_12.SqrMagnitude();
            val_9 = val_9;
            val_10 = val_12 + 1;
            val_14 = val_14 + 8;
            if(16 < 0)
        {
                val_13 = 441449248;
            val_14 = val_12;
        }
        
        }
        while(val_10 != 0);
        
        goto label_11;
        label_2:
        val_14 = 0;
        goto label_21;
        label_4:
        val_13 = 3.402823E+38f;
        val_14 = 0;
        label_11:
        if(this.closed != true)
        {
                val_10 = this.pathVerts;
            if(val_10 != 0)
        {
                val_16 = this.closed;
        }
        else
        {
                val_12 = 12;
            val_16 = 0;
            val_15 = 0;
        }
        
            if(val_15 <= (-1))
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = val_15 + 4294967288;
            float val_17 = (0 + 4294967288) + 16;
            float val_16 = (0 + 4294967288) + 20;
            val_16 = aPoint.y - val_16;
            val_17 = aPoint.x - val_17;
            float val_7 = val_17.SqrMagnitude();
            if(441449248 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            float val_18 = 3.673424E-39f;
            float val_19 = 1.401298E-45f;
            val_18 = aPoint.x - val_18;
            val_19 = aPoint.y - val_19;
            float val_8 = val_18.SqrMagnitude();
        }
        
        label_21:
        return (int);
    }
    public System.Collections.Generic.List<UnityEngine.Vector2> GetVertsRaw()
    {
        536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  this.pathVerts);
    }
    public System.Collections.Generic.List<UnityEngine.Vector2> GetVertsSmoothed(float aSplitDistance, bool aSplitCorners, bool aInverted)
    {
        bool val_10;
        var val_11;
        System.Collections.Generic.List<UnityEngine.Vector2> val_12;
        System.Collections.Generic.List<UnityEngine.Vector2> val_13;
        System.Collections.Generic.IEnumerable<T> val_14;
        val_10 = R3;
        val_11 = aInverted;
        val_12 = 536878507;
        val_12 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        val_13 = this.pathVerts;
        if(val_11 == false)
        {
            goto label_1;
        }
        
        System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_3 = Ferr2D_Path.GetSegments(aPath:  val_13, aSegDirections: out  System.Collections.Generic.List<Ferr2DT_TerrainDirection> val_2 = 441738792, aOverrides:  0, aInvert:  false, aClosed:  false);
        val_11 = val_13;
        if(this.closed != false)
        {
                bool val_6 = Ferr2D_Path.CloseEnds(aPath:  this.pathVerts, aSegmentList: ref  System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_4 = 441738788, aSegmentDirections: ref  System.Collections.Generic.List<Ferr2DT_TerrainDirection> val_5 = 441738792, aCorners:  true, aInverted:  val_10);
        }
        
        if(val_6 >= true)
        {
            goto label_4;
        }
        
        val_13 = this.pathVerts;
        goto label_5;
        label_1:
        label_5:
        System.Collections.Generic.List<UnityEngine.Vector2> val_7 = Ferr2D_Path.SmoothSegment(aSegment:  val_13, aSplitDistance:  aSplitDistance, aClosed:  aSplitCorners);
        val_12 = val_13;
        if(this.closed == false)
        {
                return;
        }
        
        if(this.closed != true)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = 2621443;
        val_12.Add(item:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f});
        return;
        label_4:
        var val_11 = 0;
        val_10 = 22739680;
        do
        {
            if(val_6 <= val_11)
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_10 = val_10 + 0;
            System.Collections.Generic.List<T> val_8 = Ferr2D_Path.IndicesToList<UnityEngine.Vector2>(aData:  this.pathVerts, aIndices:  (0 + 0) + 16);
            System.Collections.Generic.List<UnityEngine.Vector2> val_9 = Ferr2D_Path.SmoothSegment(aSegment:  this.pathVerts, aSplitDistance:  aSplitDistance, aClosed:  aSplitCorners);
            val_14 = this.pathVerts;
            if((val_11 != 0) && (this.pathVerts >= 1))
        {
                val_14.RemoveAt(index:  0);
        }
        
            val_12.AddRange(collection:  val_14);
            val_11 = val_11 + 1;
        }
        while(val_11 < val_12);
    
    }
    public UnityEngine.Rect GetBounds()
    {
        UnityEngine.Rect val_1 = Ferr2D_Path.GetBounds(aFrom:  441871280);
        return new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height};
    }
    public static UnityEngine.Vector2 GetNormal(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, int i, bool aClosed)
    {
        var val_3;
        var val_4;
        var val_11;
        float val_12;
        float val_13;
        float val_15;
        float val_16;
        var val_17;
        float val_18;
        float val_19;
        val_11 = aClosed;
        if((i + 12) <= 1)
        {
            goto label_2;
        }
        
        if((((i + 12) - 1) != val_11) || (R3 == 0))
        {
            goto label_4;
        }
        
        val_12 = mem[i + 8];
        val_12 = i + 8;
        goto label_5;
        label_2:
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.up;
        val_15 = val_3;
        val_16 = val_4;
        goto label_6;
        label_4:
        if((i + 12) <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = (i + 8) + (val_11 << 3);
        label_5:
        val_12 = val_12 + 16;
        UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
        bool val_6 = val_11 - 1;
        if(val_6 <= true)
        {
            goto label_8;
        }
        
        if((i + 12) <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_17 = (i + 8) + (val_6 << 3);
        goto label_10;
        label_8:
        if(R3 == 0)
        {
            goto label_11;
        }
        
        if((i + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_17 = (i + 8) + (((i + 12) - 2) << 3);
        label_10:
        label_21:
        UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
        val_11 = val_11 + 1;
        var val_9 = (i + 12) - 1;
        if(val_11 <= val_9)
        {
            goto label_13;
        }
        
        if(R3 == 0)
        {
            goto label_14;
        }
        
        if((i + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = mem[i + 8 + 24];
        val_18 = i + 8 + 24;
        goto label_16;
        label_13:
        if((i + 12) <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = i + 8;
        val_11 = val_11 + (val_11 << 3);
        val_18 = mem[(i + 8 + ((aClosed + 1)) << 3) + 16];
        val_18 = (i + 8 + ((aClosed + 1)) << 3) + 16;
        label_16:
        val_19 = val_9;
        goto label_18;
        label_14:
        if((i + 12) <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_12 = i + 8;
        val_12 = val_12 + (val_6 << 3);
        float val_13 = (i + 8 + ((aClosed - 1)) << 3) + 16;
        var val_14 = (i + 8 + ((aClosed - 1)) << 3) + 20;
        val_13 = val_13 - val_12;
        val_13 = val_12 - val_13;
        val_14 = val_14 - (???);
        val_18 = val_13;
        val_19 = (???) - val_14;
        label_18:
        float val_17 = ???;
        float val_15 = val_18;
        float val_16 = val_12;
        val_19 = val_19 - val_17;
        val_15 = val_15 - val_16;
        val_16 = ((i + 8 + ((i + 12 - 2)) << 3) + 16) - val_16;
        val_17 = 0 - val_17;
        val_16.Normalize();
        val_15.Normalize();
        var val_18 = val_19;
        float val_19 = val_16;
        val_18 = val_18 - val_17;
        val_19 = val_19 - val_15;
        val_13 = val_18 * 0.5f;
        val_19 = val_19 * 0.5f;
        val_13.Normalize();
        val_15 = val_13;
        val_16 = val_19;
        label_6:
        mem2[0] = val_15;
        mem2[0] = val_16;
        return new UnityEngine.Vector2() {x = val_13, y = val_8.y};
        label_11:
        bool val_10 = val_11 + 1;
        if((i + 12) <= val_10)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_20 = i + 8;
        val_20 = val_20 + (val_10 << 3);
        float val_21 = (i + 8 + ((aClosed + 1)) << 3) + 16;
        float val_23 = ???;
        var val_22 = (i + 8 + ((aClosed + 1)) << 3) + 20;
        val_21 = val_21 - val_12;
        val_22 = val_22 - val_23;
        val_21 = val_12 - val_21;
        val_23 = val_23 - val_22;
        goto label_21;
    }
    public static UnityEngine.Vector2 CubicGetNormal(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, int i, float aPercentage, bool aClosed)
    {
        float val_3;
        float val_4;
        UnityEngine.Vector2 val_2 = Ferr2D_Path.CubicGetPt(aSegment:  442107560, i:  i, aPercentage:  aPercentage, aClosed:  aClosed);
        float val_6 = 0.01f;
        val_6 = R3 + val_6;
        UnityEngine.Vector2 val_5 = Ferr2D_Path.CubicGetPt(aSegment:  442107560, i:  i, aPercentage:  val_6, aClosed:  aClosed);
        float val_7 = val_3;
        float val_8 = val_4;
        val_7 = val_7 - val_3;
        val_8 = val_8 - val_4;
        val_3 = val_7;
        val_4 = val_8;
        val_3.Normalize();
        mem2[0] = val_4;
        mem2[0] = -val_3;
        return new UnityEngine.Vector2() {x = -val_3, y = val_5.y};
    }
    public static UnityEngine.Vector2 CubicGetPt(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, int i, float aPercentage, bool aClosed)
    {
        var val_1;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        if(val_1 == 0)
        {
            goto label_1;
        }
        
        val_30 = aClosed - 1;
        if(val_30 <= true)
        {
            goto label_2;
        }
        
        val_31 = i;
        val_32 = mem[i + 12];
        val_32 = i + 12;
        goto label_4;
        label_1:
        val_31 = i;
        val_30 = UnityEngine.Mathf.Clamp(value:  aClosed - 1, min:  0, max:  (i + 12) - 1);
        val_33 = UnityEngine.Mathf.Clamp(value:  aClosed + 1, min:  0, max:  (i + 12) - 1);
        val_34 = UnityEngine.Mathf.Clamp(value:  aClosed + 2, min:  0, max:  (i + 12) - 1);
        val_32 = mem[i + 12];
        val_32 = i + 12;
        goto label_6;
        label_2:
        val_31 = i;
        val_32 = mem[i + 12];
        val_32 = i + 12;
        val_30 = val_32 - 1;
        label_4:
        var val_11 = val_32 - 1;
        bool val_12 = aClosed + 1;
        bool val_13 = aClosed + 2;
        val_33 = val_11;
        val_34 = val_11;
        label_6:
        if(val_32 <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_32 = mem[i + 12];
            val_32 = i + 12;
        }
        
        val_35 = mem[i + 8];
        val_35 = i + 8;
        var val_14 = val_35 + (val_30 << 3);
        if(val_32 <= aClosed)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_35 = mem[i + 8];
            val_35 = i + 8;
            val_32 = mem[i + 12];
            val_32 = i + 12;
        }
        
        var val_15 = val_35 + (aClosed << 3);
        float val_30 = (i + 8 + (aClosed) << 3) + 16;
        if(val_32 <= val_33)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_35 = mem[i + 8];
            val_35 = i + 8;
            val_32 = mem[i + 12];
            val_32 = i + 12;
        }
        
        var val_16 = val_35 + (val_33 << 3);
        var val_29 = (i + 8 + ((i + 12 - 1)) << 3) + 16;
        if(val_32 <= val_34)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_35 = mem[i + 8];
            val_35 = i + 8;
            val_32 = mem[i + 12];
            val_32 = i + 12;
        }
        
        var val_17 = val_35 + (val_34 << 3);
        float val_18 = ((i + 8 + ((i + 12 - 1)) << 3) + 16) - val_30;
        float val_19 = R3 * R3;
        var val_28 = (i + 8 + ((i + 12 - 1)) << 3) + 16;
        val_28 = val_28 - val_29;
        val_28 = val_28 - ((i + 8 + ((i + 12 - 1)) << 3) + 16);
        val_28 = val_28 + val_30;
        val_18 = val_18 - val_28;
        float val_20 = val_28 * R3;
        if(val_32 <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_35 = mem[i + 8];
            val_35 = i + 8;
            val_32 = mem[i + 12];
            val_32 = i + 12;
        }
        
        val_29 = val_29 - ((i + 8 + ((i + 12 - 1)) << 3) + 16);
        var val_22 = val_35 + (val_30 << 3);
        if(val_32 <= aClosed)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_35 = mem[i + 8];
            val_35 = i + 8;
            val_32 = mem[i + 12];
            val_32 = i + 12;
        }
        
        var val_23 = val_35 + (aClosed << 3);
        if(val_32 <= val_33)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_35 = mem[i + 8];
            val_35 = i + 8;
            val_32 = mem[i + 12];
            val_32 = i + 12;
        }
        
        val_30 = (val_19 * val_18) + val_30;
        var val_24 = val_35 + (val_33 << 3);
        if(val_32 <= val_34)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_35 = mem[i + 8];
            val_35 = i + 8;
        }
        
        val_35 = val_35 + (val_34 << 3);
        float val_25 = ((i + 8 + ((i + 12 - 1)) << 3) + 20) - ((i + 8 + (aClosed) << 3) + 20);
        float val_26 = ((i + 8 + ((i + 12 - 1)) << 3) + 20) - ((i + 8 + ((i + 12 - 1)) << 3) + 20);
        var val_31 = (i + 8 + ((i + 12 - 1)) << 3) + 20;
        val_31 = val_31 - ((i + 8 + ((i + 12 - 1)) << 3) + 20);
        mem2[0] = val_30;
        val_31 = val_31 - ((i + 8 + ((i + 12 - 1)) << 3) + 20);
        val_31 = val_31 + ((i + 8 + (aClosed) << 3) + 20);
        val_25 = val_25 - val_31;
        val_31 = val_31 * R3;
        val_25 = val_19 * val_25;
        float val_27 = val_25 + ((i + 8 + (aClosed) << 3) + 20);
        mem2[0] = val_27;
        return new UnityEngine.Vector2() {x = val_27};
    }
    public static UnityEngine.Vector2 HermiteGetNormal(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, int i, float aPercentage, bool aClosed, float aTension = 0, float aBias = 0)
    {
        float val_3;
        float val_4;
        var val_6;
        var val_7;
        float val_1 = UnityEngine.Mathf.Clamp01(value:  aPercentage);
        UnityEngine.Vector2 val_5 = Ferr2D_Path.HermiteGetPtTangent(aSegment:  442347952, i:  i, aPercentage:  val_3, aClosed:  aClosed, aTension:  aTension, aBias:  val_4);
        var val_11 = val_6;
        val_11 = val_11 ^ 2147483648;
        val_7 = val_11;
        val_6 = val_7;
        UnityEngine.Vector2 val_8 = normalized;
        return new UnityEngine.Vector2() {x = val_8.x, y = val_8.y};
    }
    public static UnityEngine.Vector2 HermiteGetPt(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, int i, float aPercentage, bool aClosed, float aTension = 0, float aBias = 0)
    {
        var val_1;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        if(val_1 == 0)
        {
            goto label_1;
        }
        
        val_25 = aClosed - 1;
        if(val_25 <= true)
        {
            goto label_2;
        }
        
        if(i != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_1:
        val_26 = i;
        val_25 = UnityEngine.Mathf.Clamp(value:  aClosed - 1, min:  0, max:  (i + 12) - 1);
        int val_7 = UnityEngine.Mathf.Clamp(value:  aClosed + 1, min:  0, max:  (i + 12) - 1);
        val_27 = UnityEngine.Mathf.Clamp(value:  aClosed + 2, min:  0, max:  (i + 12) - 1);
        val_28 = mem[i + 12];
        val_28 = i + 12;
        goto label_6;
        label_2:
        val_25 = (i + 12) - 2;
        label_4:
        val_26 = i;
        bool val_11 = aClosed + 1;
        val_28 = mem[i + 12];
        val_28 = i + 12;
        bool val_12 = aClosed + 2;
        val_27 = val_28;
        label_6:
        if(val_28 <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        val_29 = mem[i + 8];
        val_29 = i + 8;
        var val_13 = val_29 + (val_25 << 3);
        if(val_28 <= aClosed)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        var val_14 = val_29 + (aClosed << 3);
        val_30 = val_28;
        if(val_28 <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_30 = val_28;
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        val_30 = val_29 + (val_30 << 3);
        if(val_28 <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        var val_17 = val_29 + (val_27 << 3);
        if(val_28 <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        var val_19 = val_29 + (val_25 << 3);
        if(val_28 <= aClosed)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        var val_20 = val_29 + (aClosed << 3);
        val_31 = val_28;
        if(val_28 <= val_31)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_31 = val_28;
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        val_31 = val_29 + (val_31 << 3);
        if(val_28 <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
        }
        
        var val_21 = val_29 + (val_27 << 3);
        mem2[0] = (i + 8 + ((i + 12 - 2)) << 3) + 16;
        mem2[0] = (i + 8 + ((i + 12 - 2)) << 3) + 20;
        return new UnityEngine.Vector2() {x = Ferr2D_Path.Hermite(v1:  Ferr2D_Path.Hermite(v1:  aPercentage, v2:  aTension, v3:  aBias, v4:  null, aPercentage:  null, aTension:  null, aBias:  null), v2:  aTension, v3:  aBias, v4:  null, aPercentage:  null, aTension:  null, aBias:  null), y = aTension};
    }
    public static UnityEngine.Vector2 HermiteGetPtTangent(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, int i, float aPercentage, bool aClosed, float aTension = 0, float aBias = 0)
    {
        var val_1;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        if(val_1 == 0)
        {
            goto label_1;
        }
        
        val_25 = aClosed - 1;
        if(val_25 <= true)
        {
            goto label_2;
        }
        
        if(i != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_1:
        val_26 = i;
        val_25 = UnityEngine.Mathf.Clamp(value:  aClosed - 1, min:  0, max:  (i + 12) - 1);
        int val_7 = UnityEngine.Mathf.Clamp(value:  aClosed + 1, min:  0, max:  (i + 12) - 1);
        val_27 = UnityEngine.Mathf.Clamp(value:  aClosed + 2, min:  0, max:  (i + 12) - 1);
        val_28 = mem[i + 12];
        val_28 = i + 12;
        goto label_6;
        label_2:
        val_25 = (i + 12) - 2;
        label_4:
        val_26 = i;
        bool val_11 = aClosed + 1;
        val_28 = mem[i + 12];
        val_28 = i + 12;
        bool val_12 = aClosed + 2;
        val_27 = val_28;
        label_6:
        if(val_28 <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        val_29 = mem[i + 8];
        val_29 = i + 8;
        var val_13 = val_29 + (val_25 << 3);
        if(val_28 <= aClosed)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        var val_14 = val_29 + (aClosed << 3);
        val_30 = val_28;
        if(val_28 <= val_30)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_30 = val_28;
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        val_30 = val_29 + (val_30 << 3);
        if(val_28 <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        var val_17 = val_29 + (val_27 << 3);
        if(val_28 <= val_25)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        var val_19 = val_29 + (val_25 << 3);
        if(val_28 <= aClosed)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        var val_20 = val_29 + (aClosed << 3);
        val_31 = val_28;
        if(val_28 <= val_31)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_31 = val_28;
            val_29 = mem[i + 8];
            val_29 = i + 8;
            val_28 = mem[i + 12];
            val_28 = i + 12;
        }
        
        val_31 = val_29 + (val_31 << 3);
        if(val_28 <= val_27)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_29 = mem[i + 8];
            val_29 = i + 8;
        }
        
        var val_21 = val_29 + (val_27 << 3);
        mem2[0] = (i + 8 + ((i + 12 - 2)) << 3) + 16;
        mem2[0] = (i + 8 + ((i + 12 - 2)) << 3) + 20;
        return new UnityEngine.Vector2() {x = Ferr2D_Path.HermiteSlope(v1:  Ferr2D_Path.HermiteSlope(v1:  aPercentage, v2:  aTension, v3:  aBias, v4:  null, aPercentage:  null, aTension:  null, aBias:  null), v2:  aTension, v3:  aBias, v4:  null, aPercentage:  null, aTension:  null, aBias:  null), y = aTension};
    }
    public static float HermiteGetFloat(System.Collections.Generic.List<float> aSegment, int i, float aPercentage, bool aClosed, float aTension = 0, float aBias = 0)
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        if(R3 == 0)
        {
            goto label_1;
        }
        
        val_20 = i - 1;
        if(val_20 <= 1)
        {
            goto label_2;
        }
        
        if(aSegment != 0)
        {
            goto label_4;
        }
        
        goto label_4;
        label_1:
        val_21 = aSegment;
        val_20 = UnityEngine.Mathf.Clamp(value:  i - 1, min:  0, max:  i - 1);
        val_22 = UnityEngine.Mathf.Clamp(value:  i + 1, min:  0, max:  (aSegment + 12) - 1);
        val_23 = UnityEngine.Mathf.Clamp(value:  i + 2, min:  0, max:  (aSegment + 12) - 1);
        val_24 = mem[aSegment + 12];
        val_24 = aSegment + 12;
        goto label_6;
        label_2:
        val_20 = true - 2;
        label_4:
        val_21 = aSegment;
        int val_10 = i + 1;
        int val_11 = i + 2;
        val_22 = R3;
        val_23 = R3;
        label_6:
        if(R3 <= val_20)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_24 = mem[aSegment + 12];
            val_24 = aSegment + 12;
        }
        
        var val_12 = R3 + (val_20 << 2);
        if(val_24 <= i)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_13 = R3 + (i << 2);
        if(val_24 <= val_22)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_14 = R3 + (val_22 << 2);
        if(val_24 <= val_23)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_17 = R3 + (val_23 << 2);
        return (float)Ferr2D_Path.Hermite(v1:  aPercentage, v2:  aTension, v3:  aBias, v4:  null, aPercentage:  null, aTension:  null, aBias:  null);
    }
    private static float Cubic(float v1, float v2, float v3, float v4, float aPercentage)
    {
        var val_1;
        var val_6 = R2;
        var val_5 = R3;
        val_5 = val_5 - val_6;
        float val_3 = 0 - R1;
        val_6 = val_6 - 0;
        val_5 = val_5 - 0;
        val_5 = val_5 + R1;
        val_3 = val_3 - val_5;
        val_5 = val_5 * val_1;
        val_3 = (val_1 * val_1) * val_3;
        return (float)val_3 + R1;
    }
    private static float Linear(float v1, float v2, float aPercentage)
    {
        var val_1 = R1;
        val_1 = val_1 - 0;
        return (float)0;
    }
    private static float Hermite(float v1, float v2, float v3, float v4, float aPercentage, float aTension, float aBias)
    {
        var val_1;
        var val_2;
        var val_3;
        float val_21 = 1f;
        var val_17 = val_1;
        var val_20 = val_2;
        var val_18 = val_3;
        uint val_16 = 0;
        float val_4 = R2 - R1;
        float val_5 = val_20 * val_20;
        val_16 = R1 - val_16;
        float val_6 = val_21 - val_17;
        val_17 = val_17 + val_21;
        val_18 = val_21 - val_18;
        var val_19 = R3;
        val_19 = val_19 - R2;
        float val_7 = val_5 * val_20;
        float val_8 = val_4 * val_6;
        val_16 = val_16 * val_17;
        float val_9 = val_5 + val_5;
        val_17 = val_4 * val_17;
        val_6 = val_19 * val_6;
        float val_10 = val_5 * 3f;
        val_8 = val_18 * val_8;
        float val_11 = val_7 + val_7;
        val_9 = val_7 - val_9;
        val_16 = val_18 * val_16;
        val_17 = val_18 * val_17;
        float val_12 = val_18 * val_6;
        val_8 = val_8 * 0.5f;
        val_20 = val_9 + val_20;
        val_12 = val_12 * 0.5f;
        val_21 = (val_11 - val_10) + val_21;
        val_20 = val_20 * val_8;
        float val_14 = val_7 - val_5;
        return (float)val_10 - val_11;
    }
    private static float HermiteSlope(float v1, float v2, float v3, float v4, float aPercentage, float aTension, float aBias)
    {
        var val_1;
        var val_2;
        var val_3;
        float val_18 = 1f;
        var val_13 = val_1;
        var val_14 = val_2;
        var val_12 = R3;
        var val_17 = val_3;
        val_12 = val_12 - R2;
        float val_16 = 3f;
        float val_4 = val_17 * val_17;
        float val_5 = val_18 - val_14;
        val_13 = val_18 - val_13;
        val_14 = val_14 + val_18;
        uint val_15 = 0;
        val_15 = R1 - val_15;
        val_16 = val_4 * val_16;
        val_5 = val_13 * val_5;
        val_14 = val_13 * val_14;
        val_13 = val_12 * val_5;
        val_5 = (R2 - R1) * val_5;
        float val_8 = val_16 - (val_17 + val_17);
        val_13 = val_13 * 0.5f;
        float val_9 = val_17 * 6f;
        val_17 = val_4 * 6f;
        val_18 = val_16 + val_18;
        val_5 = val_5 * 0.5f;
        val_8 = val_8 * val_13;
        float val_10 = val_17 - val_9;
        return (float)val_9 - val_17;
    }
    public static Ferr2DT_TerrainDirection GetDirection(UnityEngine.Vector2 aOne, UnityEngine.Vector2 aTwo)
    {
        float val_1 = aTwo.y;
        val_1 = aOne.y - val_1;
        float val_2 = aTwo.x;
        val_2 = aOne.x - val_2;
        float val_3 = System.Math.Abs(val_1);
        float val_4 = System.Math.Abs(val_2);
        if()
        {
                1 = 2;
        }
        
        if(>=0)
        {
                3 = 0;
        }
    
    }
    public static Ferr2DT_TerrainDirection GetDirection(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, int i, bool aInvert, bool aClosed = False, System.Collections.Generic.List<Ferr2DT_TerrainDirection> aOverrides)
    {
        var val_3;
        var val_4;
        var val_6;
        val_3 = aInvert;
        val_4 = i;
        if(true < 1)
        {
                return;
        }
        
        if(val_4 > 1)
        {
                0 = 1;
        }
        
        bool val_1 = aClosed ^ 1;
        if(val_4 > 1)
        {
                0 = val_4;
        }
        
        if(val_4 == 1)
        {
                0 = true - 2;
        }
        
        if(val_4 > 1)
        {
                1 = val_4 + 1;
        }
        
        if(1 == 0)
        {
                val_6 = 1;
        }
        
        if((aOverrides == 0) || (1 < true))
        {
            goto label_4;
        }
        
        if(1 <= 0)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (0 << 2);
        var val_4 = (0 + ((true - 2)) << 2) + 16;
        if(val_4 != 100)
        {
            goto label_6;
        }
        
        label_4:
        val_4 = val_4 - 1;
        if(aClosed == false)
        {
                val_4 = 0 - 1;
        }
        
        if(val_6 <= val_4)
        {
                val_4 = val_6;
        }
        
        if(1 <= val_4)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 8;
        val_6 = mem[(0 + 8) + 16];
        val_6 = (0 + 8) + 16;
        if(1 <= 0)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = val_6;
        val_6 = val_6 + (0 << 3);
        val_7 = val_7 - ((0 + ((true - 2)) << 3) + 16);
        float val_8 = System.Math.Abs(val_7);
        float val_9 = System.Math.Abs(1 - ((0 + ((true - 2)) << 3) + 20));
        if(1 <= 0)
        {
            goto label_9;
        }
        
        if(1 <= 0)
        {
            goto label_10;
        }
        
        if(val_3 == true)
        {
                1 = 2;
        }
        
        return;
        label_9:
        if(1 >= 0)
        {
            goto label_13;
        }
        
        if(val_3 == true)
        {
                3 = 0;
        }
        
        return;
        label_10:
        if(val_3 == true)
        {
                2 = 1;
        }
        
        return;
        label_13:
        if(val_3 == true)
        {
                val_3 = 3;
        }
        
        return;
        label_6:
        if(1 > 0)
        {
                return;
        }
        
        var val_10 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_10 = val_10 + (0 << 2);
    }
    public static Ferr2DT_TerrainDirection GetDirection(System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<int> aSegment, int i, bool aInvert, bool aClosed = False, System.Collections.Generic.List<Ferr2DT_TerrainDirection> aOverrides)
    {
        var val_3;
        var val_5;
        val_3 = i;
        if(true < 1)
        {
                return;
        }
        
        if(val_3 > 1)
        {
                0 = 1;
        }
        
        bool val_1 = aClosed ^ 1;
        if(val_3 > 1)
        {
                0 = val_3;
        }
        
        if(val_3 == 1)
        {
                0 = true - 2;
        }
        
        if(val_3 > 1)
        {
                1 = val_3 + 1;
        }
        
        if(1 == 0)
        {
                val_5 = 1;
        }
        
        if((aOverrides == 0) || (1 < true))
        {
            goto label_4;
        }
        
        if(1 <= 0)
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (0 << 2);
        var val_4 = (0 + ((true - 2)) << 2) + 16;
        if(val_4 != 100)
        {
            goto label_6;
        }
        
        label_4:
        val_4 = val_4 - 1;
        if(aClosed == false)
        {
                val_4 = 0 - 1;
        }
        
        if(val_5 <= val_4)
        {
                val_4 = val_5;
        }
        
        if(1 <= val_4)
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + 4;
        if(val_5 <= ((0 + 4) + 16))
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + (((0 + 4) + 16) << 3);
        val_5 = mem[(0 + ((0 + 4) + 16) << 3) + 16];
        val_5 = (0 + ((0 + 4) + 16) << 3) + 16;
        val_3 = mem[(0 + ((0 + 4) + 16) << 3) + 20];
        val_3 = (0 + ((0 + 4) + 16) << 3) + 20;
        if(1 <= 0)
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (0 << 2);
        if(val_7 <= ((0 + ((true - 2)) << 2) + 16))
        {
                var val_8 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_9 = val_5;
        val_8 = val_8 + (((0 + ((true - 2)) << 2) + 16) << 3);
        val_9 = val_9 - ((0 + ((0 + ((true - 2)) << 2) + 16) << 3) + 16);
        float val_10 = System.Math.Abs(val_9);
        float val_11 = System.Math.Abs(val_3 - ((0 + ((0 + ((true - 2)) << 2) + 16) << 3) + 20));
        if(val_7 <= ((0 + ((true - 2)) << 2) + 16))
        {
            goto label_13;
        }
        
        if(val_7 <= ((0 + ((true - 2)) << 2) + 16))
        {
            goto label_14;
        }
        
        if(aInvert == true)
        {
                1 = 2;
        }
        
        return;
        label_13:
        if(val_7 >= 0)
        {
            goto label_17;
        }
        
        if(aInvert == true)
        {
                3 = 0;
        }
        
        return;
        label_14:
        if(aInvert == true)
        {
                2 = 1;
        }
        
        return;
        label_17:
        if(aInvert == true)
        {
                aInvert = 3;
        }
        
        return;
        label_6:
        if(1 > 0)
        {
                return;
        }
        
        var val_12 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_12 = val_12 + (0 << 2);
    }
    public static bool IsSplit(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, int i, System.Collections.Generic.List<Ferr2DT_TerrainDirection> aOverrides)
    {
        var val_17;
        var val_18;
        val_17 = aOverrides;
        val_18 = 0;
        if(i == 0)
        {
                return true;
        }
        
        var val_1 = true - 1;
        if(val_1 == i)
        {
                return true;
        }
        
        if(val_17 != 0)
        {
                if(val_1 >= true)
        {
            goto label_5;
        }
        
        }
        
        if(true <= i)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_2 = i - 1;
        var val_3 = val_1 + (i << 3);
        if(0 <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = val_1 + (val_2 << 3);
        var val_17 = ((true - 1) + (i) << 3) + 16;
        val_17 = val_17 - (((true - 1) + ((i - 1)) << 3) + 16);
        val_17 = i + 1;
        float val_18 = System.Math.Abs(val_17);
        float val_19 = System.Math.Abs((((true - 1) + (i) << 3) + 20) - (((true - 1) + ((i - 1)) << 3) + 20));
        if(0 <= val_2)
        {
                1 = 2;
        }
        
        if(0 >= 0)
        {
                3 = 0;
        }
        
        if(0 <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = val_1 + (val_17 << 3);
        if(0 <= i)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = val_1 + (i << 3);
        var val_20 = ((true - 1) + ((i + 1)) << 3) + 16;
        val_20 = val_20 - (((true - 1) + (i) << 3) + 16);
        float val_21 = System.Math.Abs(val_20);
        float val_22 = System.Math.Abs((((true - 1) + (i) << 3) + 20) - (((true - 1) + (i) << 3) + 20));
        label_20:
        if(0 <= i)
        {
                1 = 2;
        }
        
        if(0 >= 0)
        {
                3 = 0;
        }
        
        label_22:
        val_23 = val_23 - 2;
        if(0 != i)
        {
                val_18 = 1;
        }
        
        return true;
        label_5:
        int val_9 = i - 1;
        if(val_1 <= val_9)
        {
                var val_24 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_24 = val_24 + (val_9 << 2);
        if(((0 + ((i - 1)) << 2) + 16) == 100)
        {
                if(val_24 <= i)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_10 = val_1 + (i << 3);
            if(0 <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_11 = val_1 + (val_9 << 3);
            var val_25 = ((true - 1) + (i) << 3) + 16;
            val_25 = val_25 - (((true - 1) + ((i - 1)) << 3) + 16);
            float val_26 = System.Math.Abs(val_25);
            float val_27 = System.Math.Abs((((true - 1) + (i) << 3) + 20) - (((true - 1) + ((i - 1)) << 3) + 20));
            if(0 <= val_9)
        {
                1 = 2;
        }
        
            if(0 >= 0)
        {
                3 = 0;
        }
        
        }
        else
        {
                if(val_24 <= val_9)
        {
                var val_28 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_28 = val_28 + (val_9 << 2);
        }
        
        }
        
        if(val_28 <= i)
        {
                var val_29 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_29 = val_29 + (i << 2);
        if(((0 + (i) << 2) + 16) != 100)
        {
            goto label_17;
        }
        
        int val_13 = i + 1;
        if(((0 + (i) << 2) + 16) <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_14 = val_1 + (val_13 << 3);
        if(0 <= i)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = val_1 + (i << 3);
        var val_30 = ((true - 1) + ((i + 1)) << 3) + 16;
        val_30 = val_30 - (((true - 1) + (i) << 3) + 16);
        float val_31 = System.Math.Abs(val_30);
        float val_32 = System.Math.Abs(SB - (((true - 1) + (i) << 3) + 20));
        goto label_20;
        label_17:
        if(val_1 > i)
        {
            goto label_22;
        }
        
        var val_33 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        val_33 = val_33 + (i << 2);
        goto label_22;
    }
    public static System.Collections.Generic.List<System.Collections.Generic.List<int>> GetSegments(System.Collections.Generic.List<UnityEngine.Vector2> aPath, out System.Collections.Generic.List<Ferr2DT_TerrainDirection> aSegDirections, System.Collections.Generic.List<Ferr2DT_TerrainDirection> aOverrides, bool aInvert = False, bool aClosed = False)
    {
        System.Collections.Generic.List<System.Int32> val_8;
        var val_9;
        var val_10;
        var val_11;
        536877657 = new System.Collections.Generic.List<Page>();
        val_8 = 536877987;
        val_8 = new System.Collections.Generic.List<System.Int32>();
        536877873 = new System.Collections.Generic.List<UnityEngine.RuntimePlatform>();
        aSegDirections = 536877873;
        val_9 = 536877657;
        val_10 = 0;
        val_11 = 0;
        goto label_1;
        label_8:
        val_8.Add(item:  0);
        if((Ferr2D_Path.IsSplit(aSegment:  aPath, i:  0, aOverrides:  aOverrides)) != false)
        {
                val_9.Add(item:  536877987);
            Ferr2DT_TerrainDirection val_5 = Ferr2D_Path.GetDirection(aSegment:  aPath, i:  0, aInvert:  aInvert, aClosed:  aClosed, aOverrides:  aOverrides);
            aSegDirections.Add(item:  aPath);
            val_8 = 536877987;
            val_8 = new System.Collections.Generic.List<System.Int32>();
            val_8.Add(item:  0);
            val_11 = val_10;
            val_9 = val_9;
        }
        
        val_10 = 1;
        label_1:
        if(val_10 < val_8)
        {
            goto label_8;
        }
        
        val_9.Add(item:  536877987);
        Ferr2DT_TerrainDirection val_7 = Ferr2D_Path.GetDirection(aSegment:  aPath, i:  0, aInvert:  aInvert, aClosed:  aClosed, aOverrides:  aOverrides);
        aSegDirections.Add(item:  aPath);
    }
    public static System.Collections.Generic.List<UnityEngine.Vector2> SmoothSegment(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, float aSplitDistance, bool aClosed)
    {
        float val_7;
        float val_8;
        System.Collections.Generic.IEnumerable<T> val_9;
        var val_10;
        var val_11;
        var val_12;
        float val_15;
        var val_16;
        val_9 = aSegment;
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = 536878507;
        val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  val_9);
        var val_10 = ???;
        val_10 = val_10 ^ 1;
        val_1 = val_1 - val_10;
        if(val_1 < 1)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector2> val_11 = val_1;
        val_10 = 0;
        val_11 = 0;
        val_11 = val_11 - 1;
        label_14:
        if(val_11 != val_11)
        {
            goto label_3;
        }
        
        val_12 = 0;
        if((???) != 0)
        {
            goto label_6;
        }
        
        val_12 = (???) - 1;
        goto label_6;
        label_3:
        val_12 = val_11 + 1;
        label_6:
        if(val_11 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = val_10 + 0;
        val_15 = mem[((??? ^ 1) + 0) + 16];
        val_15 = ((??? ^ 1) + 0) + 16;
        if(0 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = val_10 + (val_12 << 3);
        float val_13 = val_15;
        float val_4 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_13, y = ((??? ^ 1) + 0) + 20}, b:  new UnityEngine.Vector2() {x = ((??? ^ 1) + ((val_11 + 1)) << 3) + 16});
        var val_12 = val_13;
        val_12 = val_12 / aClosed;
        if((int)val_12 >= 1)
        {
                val_13 = (int)val_12 + 1;
            val_16 = val_1;
            do
        {
            float val_14 = 1f;
            val_14 = val_14 / (float)val_13;
            UnityEngine.Vector2 val_6 = Ferr2D_Path.HermiteGetPt(aSegment:  443918528, i:  val_9, aPercentage:  val_14, aClosed:  false, aTension:  null, aBias:  null);
            if(val_16 == 0)
        {
                val_16 = val_1;
        }
        
            val_16.Insert(index:  (val_10 + 1) + 0, item:  new UnityEngine.Vector2() {x = val_7, y = val_8});
            val_15 = 1;
        }
        while((int)val_12 != 1);
        
            val_9 = val_9;
            val_11 = val_11;
            val_10 = val_10 + (int)val_12;
        }
        
        val_11 = val_11 + 1;
        val_10 = val_10 + 1;
        if(val_11 != val_1)
        {
            goto label_14;
        }
    
    }
    public static void SmoothSegment(System.Collections.Generic.List<UnityEngine.Vector2> aSegment, System.Collections.Generic.List<float> aScales, float aSplitDistance, bool aClosed, out System.Collections.Generic.List<UnityEngine.Vector2> aNewSegment, out System.Collections.Generic.List<float> aNewScales)
    {
        System.Collections.Generic.IEnumerable<T> val_10;
        var val_11;
        System.Collections.Generic.IEnumerable<T> val_12;
        System.Collections.Generic.List<UnityEngine.Vector2> val_13;
        System.Collections.Generic.List<System.Single> val_14;
        float val_15;
        var val_16;
        val_10 = aSegment;
        val_11 = aClosed;
        val_12 = aScales;
        val_13 = 536878507;
        val_13 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  val_10);
        val_14 = 536878291;
        val_15 = -1073712551;
        val_14 = new System.Collections.Generic.List<System.Single>(collection:  val_12);
        System.Collections.Generic.List<UnityEngine.Vector2> val_11 = aNewSegment;
        val_11 = val_11 ^ 1;
        val_14 = val_14 - val_11;
        if(val_14 < 1)
        {
            goto label_2;
        }
        
        System.Collections.Generic.List<System.Single> val_12 = val_14;
        val_16 = 0;
        val_12 = val_12 - 1;
        label_14:
        if(0 != val_12)
        {
            goto label_3;
        }
        
        val_11 = 0;
        if(aNewSegment != 0)
        {
            goto label_6;
        }
        
        val_11 = aNewSegment - 1;
        goto label_6;
        label_3:
        val_11 = 0 + 1;
        label_6:
        if(val_12 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = val_11 + 0;
        if(0 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = val_11 + (val_11 << 3);
        val_15 = mem[((aNewSegment ^ 1) + ((0 + 1)) << 3) + 16];
        val_15 = ((aNewSegment ^ 1) + ((0 + 1)) << 3) + 16;
        float val_14 = ((aNewSegment ^ 1) + 0) + 16;
        float val_6 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_14, y = ((aNewSegment ^ 1) + 0) + 20}, b:  new UnityEngine.Vector2() {x = val_15, y = 5.13837E-23f});
        var val_13 = val_14;
        val_13 = val_13 / val_11;
        if((int)val_13 >= 1)
        {
                val_14 = (int)val_13 + 1;
            var val_7 = val_16 + 1;
            do
        {
            val_11 = 1;
            float val_15 = 1f;
            val_15 = val_15 / (float)val_14;
            UnityEngine.Vector2 val_8 = Ferr2D_Path.HermiteGetPt(aSegment:  444050896, i:  val_10, aPercentage:  val_15, aClosed:  false, aTension:  null, aBias:  null);
            val_12 = (int)val_13;
            int val_10 = val_13 + 0;
            val_13.Insert(index:  val_10, item:  new UnityEngine.Vector2() {x = val_12, y = 1.085184E-19f});
            val_14 = val_14;
            val_15 = val_12;
            val_14.Insert(index:  val_10, item:  Ferr2D_Path.HermiteGetFloat(aSegment:  val_12, i:  0, aPercentage:  val_8.x, aClosed:  val_15, aTension:  val_8.y, aBias:  null));
            val_10 = val_10;
        }
        while((int)val_13 != val_11);
        
            val_16 = val_16 + (int)val_13;
        }
        
        var val_16 = 0;
        val_16 = val_16 + 1;
        val_13 = val_13;
        val_16 = val_16 + 1;
        if(val_16 != val_14)
        {
            goto label_14;
        }
        
        label_2:
        aNewScales = val_13;
        mem2[0] = val_14;
    }
    public static bool CloseEnds(System.Collections.Generic.List<UnityEngine.Vector2> aPath, ref System.Collections.Generic.List<System.Collections.Generic.List<int>> aSegmentList, ref System.Collections.Generic.List<Ferr2DT_TerrainDirection> aSegmentDirections, bool aCorners, bool aInverted)
    {
        System.Collections.Generic.List<System.Int32> val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        bool val_16;
        var val_17;
        int val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        val_7 = aPath;
        if((mem[aSegmentList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[aSegmentList + 8] + 16 + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[aSegmentList + 8] + 16 + 8) <= (mem[aSegmentList + 8] + 16 + 8 + 16))
        {
                var val_9 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_9 + ((mem[aSegmentList + 8] + 16 + 8 + 16) << 3);
        if((mem[aSegmentList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[aSegmentList + 8] + 16 + 12) <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(((0 + (mem[aSegmentList + 8] + 16 + 8 + 16) << 3) + 16) <= (mem[aSegmentList + 8] + 16 + 8 + 20))
        {
                var val_10 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_10 = val_10 + ((mem[aSegmentList + 8] + 16 + 8 + 20) << 3);
        if(aSegmentList != 0)
        {
                val_8 = mem[aSegmentList + 12];
            val_9 = val_8;
        }
        else
        {
                val_9 = 0;
            val_8 = 0;
        }
        
        if(val_8 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = mem[aSegmentList + 8];
        val_11 = val_11 + 4294967292;
        if(aSegmentList != 0)
        {
                val_10 = mem[aSegmentList + 12];
            val_11 = val_10;
        }
        else
        {
                val_11 = 0;
            val_10 = 0;
        }
        
        if(val_10 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_12 = mem[aSegmentList + 8];
        val_12 = val_12 + 4294967292;
        var val_13 = (mem[aSegmentList + 8] + 4294967292) + 16 + 12;
        val_13 = val_13 - 1;
        if(((mem[aSegmentList + 8] + 4294967292) + 16 + 12) <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_14 = (mem[aSegmentList + 8] + 4294967292) + 16 + 8;
        val_14 = val_14 + (val_13 << 2);
        if(((0 + (mem[aSegmentList + 8] + 16 + 8 + 20) << 3) + 16) <= (((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 1)) << 2) + 16))
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + ((((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 1)) << 2) + 16) << 3);
        if(aSegmentList != 0)
        {
                val_12 = mem[aSegmentList + 12];
            val_13 = val_12;
        }
        else
        {
                val_13 = 0;
            val_12 = 0;
        }
        
        if(val_12 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_16 = mem[aSegmentList + 8];
        val_16 = val_16 + 4294967292;
        if(aSegmentList != 0)
        {
                val_14 = mem[aSegmentList + 12];
            val_15 = val_14;
        }
        else
        {
                val_15 = 0;
            val_14 = 0;
        }
        
        if(val_14 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_17 = mem[aSegmentList + 8];
        val_17 = val_17 + 4294967292;
        var val_18 = (mem[aSegmentList + 8] + 4294967292) + 16 + 12;
        val_18 = val_18 - 2;
        if(((mem[aSegmentList + 8] + 4294967292) + 16 + 12) <= val_18)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_19 = (mem[aSegmentList + 8] + 4294967292) + 16 + 8;
        val_19 = val_19 + (val_18 << 2);
        val_16 = mem[((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 2)) << 2) + 16];
        val_16 = ((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 2)) << 2) + 16;
        if(((0 + (mem[aSegmentList + 8] + 16 + 8 + 20) << 3) + 16) <= val_16)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        bool val_20 = aCorners;
        if(val_20 == false)
        {
            goto label_32;
        }
        
        var val_21 = (0 + (mem[aSegmentList + 8] + 16 + 8 + 20) << 3) + 16;
        val_20 = val_20 + (val_16 << 3);
        val_21 = ((0 + (mem[aSegmentList + 8] + 16 + 8 + 16) << 3) + 16) - val_21;
        var val_23 = (0 + (mem[aSegmentList + 8] + 16 + 8 + 20) << 3) + 20;
        var val_25 = (aCorners + (((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 2)) << 2) + 16) << 3) + 16;
        var val_22 = (0 + (mem[aSegmentList + 8] + 16 + 8 + 20) << 3) + 16;
        val_22 = val_22 - ((0 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 1)) << 2) + 16) << 3) + 20);
        val_23 = ((0 + (mem[aSegmentList + 8] + 16 + 8 + 16) << 3) + 20) - val_23;
        float val_24 = System.Math.Abs(val_21);
        val_25 = val_25 - ((0 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 1)) << 2) + 16) << 3) + 16);
        float val_26 = System.Math.Abs(val_23);
        float val_27 = System.Math.Abs(((0 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 1)) << 2) + 16) << 3) + 20) - ((0 + (mem[aSegmentList + 8] + 16 + 8 + 16) << 3) + 20));
        float val_28 = System.Math.Abs(val_22);
        float val_29 = System.Math.Abs(((0 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 1)) << 2) + 16) << 3) + 16) - ((0 + (mem[aSegmentList + 8] + 16 + 8 + 16) << 3) + 16));
        float val_30 = System.Math.Abs(val_25);
        if(val_20 <= false)
        {
                1 = 2;
        }
        
        if(val_20 >= 0)
        {
                3 = 0;
        }
        
        if(val_20 <= false)
        {
                val_7 = 2;
        }
        
        if(val_20 >= 0)
        {
                3 = 0;
        }
        
        if(val_20 <= false)
        {
                1 = 2;
        }
        
        if(val_20 >= 0)
        {
                3 = 0;
        }
        
        if(0 == 0)
        {
            goto label_34;
        }
        
        if(0 != 0)
        {
                0 = 1;
        }
        
        val_16 = mem[aSegmentList + 8] + 16 + 8 + 16;
        if(0 == 0)
        {
            goto label_36;
        }
        
        if((mem[aSegmentList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_31 = mem[aSegmentList + 8];
        val_31 = val_31 + (((mem[aSegmentList + 12]) - 1) << 2);
        val_17 = mem[(mem[aSegmentList + 8] + ((mem[aSegmentList + 12] - 1)) << 2) + 16];
        val_17 = (mem[aSegmentList + 8] + ((mem[aSegmentList + 12] - 1)) << 2) + 16;
        val_18 = val_16;
        val_19 = 22737108;
        goto label_39;
        label_32:
        if((mem[aSegmentList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_17 = mem[mem[aSegmentList + 8] + 16];
        val_17 = mem[aSegmentList + 8] + 16;
        val_18 = mem[aSegmentList + 8] + 16 + 8 + 16;
        val_19 = 22737108;
        label_39:
        val_17.Add(item:  val_18);
        return true;
        label_34:
        if((mem[aSegmentList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        mem[aSegmentList + 8] + 16.Insert(index:  0, item:  ((mem[aSegmentList + 8] + 4294967292) + 16 + 8 + (((mem[aSegmentList + 8] + 4294967292) + 16 + 12 - 1)) << 2) + 16);
        return true;
        label_36:
        if((mem[aSegmentList + 12]) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(aSegmentList != 0)
        {
                val_20 = mem[aSegmentList + 12];
            val_21 = val_20;
        }
        else
        {
                val_7 = 12;
            val_21 = 0;
            val_20 = 0;
        }
        
        if(val_20 <= (-1))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_34 = mem[aSegmentList + 8];
        val_34 = val_34 + 4294967292;
        val_16 = mem[(mem[aSegmentList + 8] + 4294967292) + 16];
        val_16 = (mem[aSegmentList + 8] + 4294967292) + 16;
        mem[aSegmentList + 8] + 16.InsertRange(index:  0, collection:  val_16);
        if(aSegmentList != 0)
        {
                val_22 = mem[aSegmentList + 12];
        }
        else
        {
                val_22 = 0;
        }
        
        aSegmentList.RemoveAt(index:  val_22 - 1);
        if(aSegmentDirections != 0)
        {
                val_23 = mem[aSegmentDirections + 12];
            val_23 = aSegmentDirections + 12;
        }
        else
        {
                val_23 = 0;
        }
        
        aSegmentDirections.RemoveAt(index:  val_23 - 1);
        return true;
    }
    public static System.Collections.Generic.List<T> IndicesToList<T>(System.Collections.Generic.List<T> aData, System.Collections.Generic.List<int> aIndices)
    {
        var val_1 = mem[__RuntimeMethodHiddenParam + 24];
        val_1 = __RuntimeMethodHiddenParam + 24;
        if(val_1 < 1)
        {
                return;
        }
        
        var val_2 = 0;
        do
        {
            if(val_1 <= val_2)
        {
                var val_1 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_1 = val_1 + 0;
            val_1 = aData;
            val_2 = val_2 + 1;
        }
        while(val_2 < val_1);
    
    }
    public static void IndicesToPath(System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<float> aScales, System.Collections.Generic.List<int> aIndices, out System.Collections.Generic.List<UnityEngine.Vector2> aNewPath, out System.Collections.Generic.List<float> aNewScales)
    {
        System.Collections.Generic.List<UnityEngine.Vector2> val_3;
        var val_4;
        System.Collections.Generic.List<System.Single> val_5;
        var val_6;
        var val_8;
        var val_9;
        val_3 = aPath;
        val_4 = aIndices;
        val_5 = aScales;
        536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  SL);
        mem2[0] = 536878507;
        536878291 = new System.Collections.Generic.List<System.Single>();
        aNewScales = 536878291;
        if(aNewScales < 1)
        {
                return;
        }
        
        do
        {
            var val_3 = 4 - 4;
            if(aNewScales <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= (3.673424E-39f))
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_6 = val_6 + 20971544;
            aNewPath.Add(item:  new UnityEngine.Vector2() {x = (0 + 20971544) + 16, y = 3.673424E-39f});
            if(aNewPath <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_5 = val_5;
            if(2621443 < 0)
        {
                val_4 = val_4;
            if(((0 + 20971544) + 16) <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(0 <= ((0 + 20971544) + 16 + 16))
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_7 = val_7 + (((0 + 20971544) + 16 + 16) << 2);
            val_8 = (0 + ((0 + 20971544) + 16 + 16) << 2) + 16;
            val_9 = 22738600;
        }
        else
        {
                val_4 = val_4;
            val_8 = 1065353216;
            val_9 = 22738600;
        }
        
            aNewScales.Add(item:  null);
            val_3 = val_3;
            val_6 = 4 + 1;
        }
        while((4 - 3) < aNewScales);
    
    }
    public static UnityEngine.Vector2 GetClosetPointOnLine(UnityEngine.Vector2 aStart, UnityEngine.Vector2 aEnd, UnityEngine.Vector2 aPoint, bool aClamp)
    {
        var val_2;
        float val_6;
        float val_6 = aPoint.x;
        bool val_1 = aClamp - aEnd.x;
        val_6 = val_6 - aEnd.x;
        float val_3 = aPoint.y - aStart.y;
        float val_4 = aEnd.y - aStart.y;
        val_1 = val_6 * val_1;
        val_6 = val_1 / (val_6 * val_6);
        if(val_2 != 0)
        {
                if(val_2 < 0)
        {
                val_6 = 0f;
        }
        else
        {
                if(val_2 > 0)
        {
                val_6 = 1f;
        }
        
        }
        
        }
        
        mem2[0] = aEnd.x;
        mem2[0] = aStart.y;
        return new UnityEngine.Vector2() {x = aEnd.x};
    }
    public static UnityEngine.Rect GetBounds(System.Collections.Generic.List<UnityEngine.Vector2> aFrom)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_10 = 23000420;
        if((R1 != 0) && ((R1 + 12) >= 1))
        {
                var val_11 = 16;
            do
        {
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
            if((R1 + 12) < 0)
        {
                val_12 = val_11 + val_11;
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
            val_12 = mem[(R1 + 8 + 16)];
            val_12 = val_11 + val_11;
        }
        
        }
        
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
        }
        
            if((R1 + 12) > 0)
        {
                val_13 = val_11 + val_11;
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
            val_13 = mem[(R1 + 8 + 16)];
            val_13 = val_11 + val_11;
        }
        
        }
        
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
        }
        
            var val_5 = val_11 + val_11;
            if((R1 + 12) > 0)
        {
                val_14 = (R1 + 8 + 16) + 4;
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
            var val_6 = val_11 + val_11;
            val_14 = mem[(R1 + 8 + 16) + 4];
            val_14 = (R1 + 8 + 16) + 4;
        }
        
        }
        
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
        }
        
            val_11 = val_11 + val_11;
            if((R1 + 12) < 0)
        {
                val_15 = (R1 + 8 + 16) + 4;
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_10 = R1 + 8;
            val_10 = val_10 + val_11;
            val_15 = mem[(R1 + 8 + 16) + 4];
            val_15 = (R1 + 8 + 16) + 4;
        }
        
        }
        
            val_10 = 0 + 1;
            val_11 = val_11 + 8;
        }
        while(val_10 < (R1 + 12));
        
            float val_7 = val_12 - val_13;
            float val_8 = val_14 - val_15;
        }
        
        aFrom = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
        return new UnityEngine.Rect();
    }
    public static UnityEngine.Vector2 LineIntersectionPoint(UnityEngine.Vector2 ps1, UnityEngine.Vector2 pe1, UnityEngine.Vector2 ps2, UnityEngine.Vector2 pe2)
    {
        var val_3;
        float val_9;
        float val_9 = pe1.x;
        float val_10 = ps2.y;
        float val_1 = ps2.x - val_9;
        float val_8 = pe2.x;
        float val_2 = val_10 - pe2.y;
        float val_5 = val_3 - val_8;
        float val_6 = val_1 * val_2;
        if()
        {
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            return new UnityEngine.Vector2() {x = val_9, y = val_8};
        }
        
        val_8 = val_2 * val_8;
        val_9 = (ps1.y - pe1.y) * val_9;
        val_10 = val_1 * val_8;
        val_2 = val_2 * val_9;
        val_9 = val_10 / val_6;
        val_2 = val_2 / val_6;
        mem2[0] = val_2;
        mem2[0] = val_9;
        return new UnityEngine.Vector2() {x = val_9, y = val_8};
    }
    public static bool LineSegmentIntersection(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4)
    {
        var val_6;
        float val_8 = p1.y;
        float val_6 = p2.y;
        float val_9 = p1.x;
        val_6 = val_6 - val_8;
        float val_7 = p2.x;
        val_7 = val_7 - val_9;
        float val_3 = val_6 * (p3.x - p4.x);
        if()
        {
                return false;
        }
        
        val_8 = val_8 - p3.y;
        val_6 = 0;
        float val_5 = val_7 * val_8;
        val_9 = (val_9 - p3.x) * (p3.y - p4.y);
        if()
        {
            goto label_0;
        }
        
        if( || (<0))
        {
            goto label_2;
        }
        
        if()
        {
                0 = 1;
        }
        
        if(>=0)
        {
                0 = 1;
        }
        
        return true;
        label_0:
        if(>=0)
        {
                0 = 1;
        }
        
        if()
        {
                val_6 = 1;
        }
        
        val_6 = 1;
        label_2:
        if(>=0)
        {
                0 = 1;
        }
        
        if()
        {
                0 = 1;
        }
        
        val_6 = val_6 & 1;
        return (bool)val_6;
    }
    public static bool LineSegmentIntersectionNoOverlap(UnityEngine.Vector2 p1, UnityEngine.Vector2 p2, UnityEngine.Vector2 p3, UnityEngine.Vector2 p4)
    {
        var val_6;
        float val_8 = p1.y;
        float val_6 = p2.y;
        float val_9 = p1.x;
        val_6 = val_6 - val_8;
        float val_7 = p2.x;
        val_7 = val_7 - val_9;
        float val_3 = val_6 * (p3.x - p4.x);
        if()
        {
                return false;
        }
        
        val_8 = val_8 - p3.y;
        val_6 = 0;
        float val_5 = val_7 * val_8;
        val_9 = (val_9 - p3.x) * (p3.y - p4.y);
        if()
        {
                if()
        {
                0 = 1;
        }
        
            if()
        {
                val_6 = 1;
        }
        
            val_6 = 1;
        }
        else
        {
                if( && )
        {
                if()
        {
                0 = 1;
        }
        
            if()
        {
                0 = 1;
        }
        
            return true;
        }
        
        }
        
        if()
        {
                0 = 1;
        }
        
        if()
        {
                0 = 1;
        }
        
        val_6 = 1 & val_6;
        return (bool)val_6;
    }
    public static float GetDistanceFromPath(System.Collections.Generic.List<UnityEngine.Vector2> aPath, UnityEngine.Vector2 aPoint, bool aClosed)
    {
        var val_3;
        var val_4;
        float val_7;
        float val_8;
        System.Collections.Generic.List<UnityEngine.Vector2> val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        float val_15;
        float val_16;
        val_10 = aPath;
        val_11 = aClosed;
        if(23000421 < 2)
        {
            goto label_2;
        }
        
        bool val_1 = val_11 ^ 1;
        bool val_2 = 23000421 - val_1;
        if(val_2 < true)
        {
            goto label_3;
        }
        
        val_1 = 0 - val_1;
        val_1 = 23000421 + val_1;
        val_1 = val_1 - 1;
        val_11 = 0;
        val_13 = 16;
        goto label_4;
        label_7:
        val_10 = val_10;
        val_11 = val_4;
        val_12 = mem[aPath + 12];
        val_12 = aPath + 12;
        val_13 = val_3 + 8;
        label_4:
        val_4 = val_11 + 1;
        if(val_12 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_12 = mem[aPath + 12];
            val_12 = aPath + 12;
        }
        
        val_14 = mem[aPath + 8];
        val_14 = aPath + 8;
        val_3 = val_13;
        if(val_12 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_14 = mem[aPath + 8];
            val_14 = aPath + 8;
        }
        
        val_14 = val_14 + (val_12 << 3);
        UnityEngine.Vector2 val_6 = Ferr2D_Path.GetClosetPointOnLine(aStart:  new UnityEngine.Vector2() {x = 5.655438E-23f, y = aPath + 8 + (val_3 + 8)}, aEnd:  new UnityEngine.Vector2() {x = aPath + 8 + (val_3 + 8) + 4, y = (aPath + 8 + (aPath + 12) << 3) + 16}, aPoint:  new UnityEngine.Vector2() {x = (aPath + 8 + (aPath + 12) << 3) + 20, y = aPoint.x}, aClamp:  aPoint.y);
        float val_10 = val_7;
        float val_11 = val_8;
        val_10 = aPoint.x - val_10;
        val_11 = aPoint.y - val_11;
        float val_9 = val_10.SqrMagnitude();
        if(val_12 < 0)
        {
                val_15 = 445169024;
        }
        
        if(val_1 != val_11)
        {
            goto label_7;
        }
        
        goto label_8;
        label_2:
        val_16 = 3.402823E+38f;
        return (float)val_16;
        label_3:
        val_15 = 3.402823E+38f;
        label_8:
        if(val_2 < _TYPE_MAX_)
        {
                return (float)val_16;
        }
        
        val_16 = 2139095039;
        return (float)val_16;
    }
    public static UnityEngine.Vector2 GetSegmentNormal(int i, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
    {
        var val_6;
        var val_7;
        val_6 = aPath;
        int val_6 = aClosed + 12;
        if(val_6 <= 1)
        {
            goto label_2;
        }
        
        if(R3 == 0)
        {
            goto label_3;
        }
        
        val_7 = val_6;
        goto label_4;
        label_2:
        UnityEngine.Vector2 val_2 = UnityEngine.Vector2.up;
        goto label_5;
        label_3:
        val_6 = val_6 - 1;
        val_7 = UnityEngine.Mathf.Min(a:  val_6 + 1, b:  val_6);
        label_4:
        if((aClosed + 12) <= val_7)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = aClosed + 8;
        val_7 = val_7 + (val_7 << 3);
        if(R3 == 0)
        {
                if(((aClosed + 12) - 1) == val_6)
        {
                val_6 = (aClosed + 12) - 2;
        }
        
        }
        
        if((aClosed + 12) <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = aClosed + 8;
        var val_9 = (aClosed + 8 + (val_3) << 3) + 20;
        val_8 = val_8 + (val_6 << 3);
        float val_10 = (aClosed + 8 + ((aClosed + 12 - 2)) << 3) + 16;
        val_9 = val_9 - ((aClosed + 8 + ((aClosed + 12 - 2)) << 3) + 20);
        val_10 = ((aClosed + 8 + (val_3) << 3) + 16) - val_10;
        UnityEngine.Vector2 val_5 = normalized;
        label_5:
        mem2[0] = ???;
        mem2[0] = ???;
        return new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
    }
    public static float GetSegmentLength(System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed = False)
    {
        float val_6;
        float val_9;
        var val_10;
        val_6 = 0f;
        if(aPath == 0)
        {
                return (float)val_10;
        }
        
        if(true < 2)
        {
                return (float)val_10;
        }
        
        float val_7 = 2.242078E-44f;
        var val_6 = 0;
        do
        {
            if(true <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_6 = val_6 + 1;
            val_9 = mem[aClosed + 16];
            val_9 = aClosed + 16;
            if(0 <= val_6)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            bool val_1 = aClosed + val_7;
            float val_2 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_9, y = aClosed + 16 + 4}, b:  new UnityEngine.Vector2() {x = (aClosed + 16) + 8});
            val_10 = val_9;
            val_7 = val_7 + 8;
            val_6 = 0f + val_10;
            var val_3 = val_9 - 1;
        }
        while(val_6 < val_3);
        
        if(aClosed == false)
        {
                return (float)val_10;
        }
        
        if(val_9 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = 0 - 1;
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = val_3 + (val_9 << 3);
        float val_5 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = (aClosed + 16 - 1) + 16, y = val_7}, b:  new UnityEngine.Vector2() {x = ((aClosed + 16 - 1) + ((0 - 1)) << 3) + 16});
        val_10 = (aClosed + 16 - 1) + 16;
        val_6 = val_6 + val_10;
        return (float)val_10;
    }
    public static float GetSegmentLengthToIndex(System.Collections.Generic.List<UnityEngine.Vector2> aPath, int aIndex)
    {
        if(aPath == 0)
        {
                return (float)2621443;
        }
        
        if(true < 2)
        {
                return (float)2621443;
        }
        
        if(aIndex >= 1)
        {
                aIndex = 0;
        }
        
        if(aIndex < 1)
        {
                return (float)2621443;
        }
        
        var val_3 = 0;
        do
        {
            if(true <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_3 = val_3 + 1;
            if(0 <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_1 = aIndex + 16;
            float val_2 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f}, b:  new UnityEngine.Vector2() {x = (aIndex + 16) + 8});
            0f = 0f + 2621443;
            if(val_3 < aIndex)
        {
                1 = 2621442;
        }
        
        }
        while(val_3 < 1);
        
        return (float)2621443;
    }
    public static UnityEngine.Vector2 LinearGetPt(System.Collections.Generic.List<UnityEngine.Vector2> aPath, int aIndex, float aPercent, bool aClosed)
    {
        var val_2;
        float val_9;
        int val_10;
        float val_11;
        var val_12;
        var val_14;
        var val_15;
        val_9 = R3;
        val_10 = aClosed;
        val_11 = 23000425;
        if(aIndex == 0)
        {
            goto label_1;
        }
        
        if((aIndex + 12) <= 1)
        {
            goto label_2;
        }
        
        int val_3 = UnityEngine.Mathf.Clamp(value:  val_10, min:  0, max:  (aIndex + 12) - 1);
        val_10 = mem[aIndex + 12];
        val_10 = aIndex + 12;
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        val_3 = val_3 + 1;
        val_12 = val_10;
        goto label_4;
        label_1:
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        goto label_5;
        label_2:
        if((aIndex + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = mem[aIndex + 8 + 16];
        val_14 = aIndex + 8 + 16;
        label_5:
        mem2[0] = val_14;
        mem2[0] = aIndex;
        return new UnityEngine.Vector2() {x = val_11};
        label_3:
        val_12 = UnityEngine.Mathf.Min(a:  val_10 - 1, b:  val_3 + 1);
        val_10 = mem[aIndex + 12];
        val_10 = aIndex + 12;
        label_4:
        if(val_10 <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_10 = mem[aIndex + 12];
            val_10 = aIndex + 12;
        }
        
        val_15 = mem[aIndex + 8];
        val_15 = aIndex + 8;
        var val_8 = val_15 + (val_3 << 3);
        val_9 = mem[(aIndex + 8 + (val_3) << 3) + 16];
        val_9 = (aIndex + 8 + (val_3) << 3) + 16;
        val_11 = mem[(aIndex + 8 + (val_3) << 3) + 20];
        val_11 = (aIndex + 8 + (val_3) << 3) + 20;
        if(val_10 <= val_12)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_15 = mem[aIndex + 8];
            val_15 = aIndex + 8;
        }
        
        val_15 = val_15 + (val_12 << 3);
        var val_9 = (aIndex + 8 + (val_7) << 3) + 16;
        var val_10 = (aIndex + 8 + (val_7) << 3) + 20;
        val_9 = val_9 - val_9;
        val_10 = val_10 - val_11;
        mem2[0] = val_9;
        mem2[0] = val_11;
        return new UnityEngine.Vector2() {x = val_11};
    }
    public static UnityEngine.Vector2 LinearGetNormal(System.Collections.Generic.List<UnityEngine.Vector2> aPath, int aIndex, float aPercent, bool aClosed)
    {
        var val_2;
        float val_5;
        float val_6;
        int val_15;
        bool val_16;
        float val_17;
        var val_19;
        val_15 = aClosed;
        if(aIndex == 0)
        {
            goto label_1;
        }
        
        if((aIndex + 12) <= 1)
        {
            goto label_2;
        }
        
        int val_3 = UnityEngine.Mathf.Clamp(value:  val_15, min:  0, max:  (aIndex + 12) - 1);
        val_15 = val_3;
        if(val_2 == 0)
        {
            goto label_3;
        }
        
        val_3 = val_15 + 1;
        val_16 = aIndex + 12;
        goto label_4;
        label_1:
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
        val_19 = val_5;
        goto label_5;
        label_2:
        if((aIndex + 12) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = mem[aIndex + 8 + 16];
        val_19 = aIndex + 8 + 16;
        label_5:
        mem2[0] = val_19;
        mem2[0] = aIndex;
        return new UnityEngine.Vector2() {x = val_17, y = val_11.y};
        label_3:
        val_16 = UnityEngine.Mathf.Min(a:  (aIndex + 12) - 1, b:  val_15 + 1);
        label_4:
        UnityEngine.Vector2 val_10 = Ferr2D_Path.GetNormal(aSegment:  445769992, i:  aIndex, aClosed:  val_15);
        UnityEngine.Vector2 val_11 = Ferr2D_Path.GetNormal(aSegment:  445769992, i:  aIndex, aClosed:  val_16);
        float val_12 = UnityEngine.Mathf.Clamp01(value:  val_11.x);
        val_17 = val_6 - val_6;
        float val_13 = val_5 - val_5;
        mem2[0] = val_6;
        mem2[0] = val_5;
        return new UnityEngine.Vector2() {x = val_17, y = val_11.y};
    }
    public static void PathGlobalPercentToLocal(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aPercent, out int aLocalPoint, out float aLocalPercent, float aPathLength = 0, bool aClosed = False)
    {
        var val_1;
        bool val_9;
        var val_10;
        float val_11;
        var val_12;
        var val_13;
        var val_14;
        val_9 = aClosed;
        val_10 = 1152921509347764736;
        val_11 = 1f;
        if(val_1 != 0)
        {
                val_12 = 445946416 - (float)(int)445946416;
            aLocalPercent = 0f;
            mem2[0] = 0f;
            if(val_1 == 0)
        {
                System.Collections.Generic.List<UnityEngine.Vector2> val_10 = aPath;
            float val_3 = Ferr2D_Path.GetSegmentLength(aPath:  val_10, aClosed:  false);
            val_13 = val_10;
        }
        
            val_12 = val_12 * val_13;
            float val_11 = 0f;
            val_14 = 16;
            val_10 = val_10 - val_1 ^ 1;
            do
        {
            val_11 = val_11 + 1;
            if(val_11 >= val_10)
        {
                return;
        }
        
            if(val_10 <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if(val_10 <= val_10)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_12 = val_12 + 3567603712;
            float val_5 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f}, b:  new UnityEngine.Vector2() {x = (0 + 3567603712) + 16, y = aClosed});
            val_14 = val_14 + 8;
            float val_6 = 0 + 2621443;
        }
        while(val_10 < val_10);
        
            val_9 = val_9;
            aLocalPercent = val_11;
            val_11 = (val_12 - 0) / 2621443;
        }
        else
        {
                aLocalPercent = UnityEngine.Mathf.Max(a:  0, b:  true - 2);
        }
        
        mem2[0] = val_11;
    }
    public Ferr2D_Path()
    {
        536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
        this.pathVerts = 536878507;
    }

}
