using UnityEngine;
private class RecolorTree.TreeNode
{
    // Fields
    private Ferr.RecolorTree.TreePoint point;
    private Ferr.RecolorTree.TreeNode left;
    private Ferr.RecolorTree.TreeNode right;
    
    // Properties
    public bool IsLeaf { get; }
    
    // Methods
    public bool get_IsLeaf()
    {
        if(this.left == 0)
        {
                0 = this.right;
        }
        
        if(this.left == 0)
        {
                0 = 0 >> 5;
        }
        
        return (bool)0;
    }
    public RecolorTree.TreeNode(Ferr.RecolorTree.TreeSettings aSettings, System.Collections.Generic.List<Ferr.RecolorTree.TreePoint> aPoints, int aDepth)
    {
        var val_10;
        int val_11;
        var val_12;
        var val_13;
        var val_14;
        System.Collections.Generic.IComparer<T> val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        RecolorTree.TreeNode val_22;
        var val_23;
        val_10 = this;
        val_11 = aDepth;
        val_12 = val_1;
        val_13 = aSettings;
        val_1 = new System.Object();
        int val_2 = val_13.GetAxis(aDepth:  val_11);
        if(val_2 == 2)
        {
            goto label_2;
        }
        
        if(val_2 == 1)
        {
            goto label_3;
        }
        
        if(val_2 != 0)
        {
            goto label_4;
        }
        
        val_14 = 536892547;
        if(((mem[536892734] & true) == 0) && (mem[536892663] == 0))
        {
                val_14 = 536892547;
        }
        
        val_15 = mem[mem[536892639]];
        val_15 = mem[536892639];
        goto label_10;
        label_2:
        val_16 = 536892547;
        if(((mem[536892734] & true) == 0) && (mem[536892663] == 0))
        {
                val_16 = 536892547;
        }
        
        val_15 = mem[mem[536892639] + 8];
        val_15 = mem[536892639] + 8;
        goto label_10;
        label_3:
        val_17 = 536892547;
        if(((mem[536892734] & true) == 0) && (mem[536892663] == 0))
        {
                val_17 = 536892547;
        }
        
        val_15 = mem[mem[536892639] + 4];
        val_15 = mem[536892639] + 4;
        label_10:
        val_12.Sort(comparer:  val_15);
        label_4:
        if(val_12 != 0)
        {
                val_18 = val_12;
            val_20 = val_12;
        }
        else
        {
                val_18 = 12;
            val_20 = 0;
            val_19 = 0;
        }
        
        if(val_19 <= 0)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + 0;
        this.point = (0 + 0) + 16;
        if(val_12 != 0)
        {
                System.Collections.Generic.List<T> val_3 = val_12.GetRange(index:  0, count:  0);
            val_21 = val_12;
        }
        else
        {
                val_12 = 0;
            System.Collections.Generic.List<T> val_4 = 0.GetRange(index:  0, count:  0);
            val_21 = 0;
            val_22 = 0;
        }
        
        int val_5 = 0 + 1;
        System.Collections.Generic.List<T> val_7 = val_12.GetRange(index:  val_5, count:  val_22 - val_5);
        val_23 = val_12;
        if(0 >= 1)
        {
                int val_8 = val_11 + 1;
            val_22 = 536900711;
            this.left = val_22;
        }
        
        if(0 >= 1)
        {
                int val_9 = val_11 + 1;
            this.right = 536900711;
        }
        
        var val_10 = FP - 28;
    }
    public void GetNearest(Ferr.RecolorTree.TreeSettings aSettings, int aDepth, UnityEngine.Vector3 aPt, ref Ferr.RecolorTree.TreePoint aClosest, ref float aClosestDist)
    {
        RecolorTree.TreeNode val_11;
        var val_12;
        int val_13;
        float val_14;
        float val_15;
        float val_16;
        var val_17;
        var val_18;
        float val_19;
        var val_20;
        var val_21;
        float val_22;
        float val_23;
        val_11 = this;
        val_12 = val_11;
        val_13 = aDepth;
        val_14 = aPt.z;
        val_15 = aPt.y;
        if(this.left == 0)
        {
                this.left = this.right;
        }
        
        val_16 = aClosest;
        if(this.left == 0)
        {
            goto label_0;
        }
        
        int val_1 = aSettings.GetAxis(aDepth:  val_13);
        if(val_1 == 2)
        {
            goto label_2;
        }
        
        if(val_1 == 1)
        {
            goto label_3;
        }
        
        if(val_1 != 0)
        {
            goto label_4;
        }
        
        val_17 = aPt.x;
        if(mem[1152921510132348664] != 0)
        {
            goto label_8;
        }
        
        goto label_8;
        label_2:
        val_17 = val_14;
        if(this.point != 0)
        {
            goto label_8;
        }
        
        goto label_8;
        label_3:
        val_17 = val_15;
        label_8:
        val_14 = aPt.z;
        if(this.point >= 0)
        {
            goto label_10;
        }
        
        label_4:
        val_18 = val_16;
        val_19 = val_15;
        val_20 = 1152921510132348672;
        goto label_11;
        label_10:
        val_18 = val_16;
        val_19 = val_15;
        val_20 = 1152921510132348668;
        val_12 = 1152921510132348672;
        label_11:
        if(val_20 == 0)
        {
                val_20 = val_12;
        }
        
        if(val_20 != 0)
        {
                val_15 = val_12;
        }
        
        aDepth = val_13 + 1;
        val_11 = aPt.x;
        val_16 = aClosestDist;
        val_13 = val_11;
        UnityEngine.Vector3 val_8 = this.point.point;
        float val_2 = S2 - val_19;
        val_8 = val_8 - val_11;
        float val_3 = S4 - val_14;
        float val_4 = val_8.sqrMagnitude;
        if(this.point < 0)
        {
                aClosest = this.point;
            aClosestDist = 1230522328;
        }
        
        if(val_15 == 0)
        {
                return;
        }
        
        if(val_1 == 2)
        {
            goto label_19;
        }
        
        if(val_1 == 1)
        {
            goto label_20;
        }
        
        if(val_1 != 0)
        {
            goto label_21;
        }
        
        val_21 = this.point.point - val_11;
        goto label_23;
        label_19:
        val_21 = S26 - val_14;
        goto label_23;
        label_20:
        val_21 = S24 - val_19;
        label_23:
        val_22 = System.Math.Abs(val_21);
        goto label_24;
        label_21:
        val_22 = 0f;
        label_24:
        val_22 = val_22 * val_22;
        if(val_1 > 0)
        {
                return;
        }
        
        return;
        label_0:
        float val_9 = aPt.x;
        float val_5 = S4 - val_15;
        val_9 = this.point.point - val_9;
        float val_6 = S6 - val_14;
        float val_7 = val_9.sqrMagnitude;
        val_23 = 1230522328;
        if(aClosest != 0)
        {
                if(aClosest >= 0)
        {
                return;
        }
        
        }
        
        aClosest = this.point;
        aClosestDist = val_23;
    }
    public void Draw(Ferr.RecolorTree.TreeSettings aSettings, int aDepth, UnityEngine.Vector3 aPt)
    {
        float val_4;
        float val_5;
        float val_6;
        int val_17;
        var val_18;
        float val_19;
        float val_20;
        float val_21;
        UnityEngine.Vector3 val_22;
        val_17 = aDepth;
        int val_1 = aSettings.GetAxis(aDepth:  val_17);
        if(val_1 == 2)
        {
            goto label_1;
        }
        
        if(val_1 == 1)
        {
            goto label_2;
        }
        
        if(val_1 != 0)
        {
            goto label_3;
        }
        
        UnityEngine.Color val_2 = UnityEngine.Color.red;
        UnityEngine.Gizmos.color = new UnityEngine.Color();
        val_18 = 0;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.left;
        var val_17 = val_4;
        var val_18 = val_5;
        var val_19 = val_6;
        val_17 = this.point.point + val_17;
        val_18 = S18 + val_18;
        val_19 = S20 + val_19;
        val_19 = val_17;
        val_20 = val_18;
        val_21 = val_19;
        val_22 = this.point.point;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.right;
        goto label_9;
        label_1:
        UnityEngine.Color val_8 = UnityEngine.Color.blue;
        UnityEngine.Gizmos.color = new UnityEngine.Color();
        val_18 = 0;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.forward;
        var val_20 = val_4;
        var val_21 = val_5;
        var val_22 = val_6;
        val_20 = this.point.point + val_20;
        val_21 = S18 + val_21;
        val_22 = S20 + val_22;
        val_19 = val_20;
        val_20 = val_21;
        val_21 = val_22;
        val_22 = this.point.point;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.back;
        goto label_9;
        label_2:
        UnityEngine.Color val_11 = UnityEngine.Color.green;
        UnityEngine.Gizmos.color = new UnityEngine.Color();
        val_18 = 0;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
        float val_23 = val_4;
        float val_24 = val_5;
        float val_25 = val_6;
        val_23 = this.point.point + val_23;
        val_24 = S18 + val_24;
        val_25 = S20 + val_25;
        val_19 = val_23;
        val_20 = val_24;
        val_21 = val_25;
        val_22 = this.point.point;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.down;
        label_9:
        float val_26 = val_4;
        float val_27 = val_5;
        val_26 = val_22 + val_26;
        val_27 = S18 + val_27;
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21}, to:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = S20 + val_6});
        val_17 = val_17;
        label_3:
        if(this.left != 0)
        {
                int val_15 = val_17 + 1;
            UnityEngine.Gizmos.color = new UnityEngine.Color() {r = mem[this.point.data + (0)], g = mem[this.point.data + (4)], b = mem[this.point.data + (8)], a = mem[this.point.data + (12)]};
            val_21 = this.point.point;
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_21, y = 0f, z = this.point}, to:  new UnityEngine.Vector3() {x = this.left.point.point, y = mem[this.point.data + (0)], z = mem[this.point.data + (4)]});
        }
        
        if(this.right == 0)
        {
                return;
        }
        
        int val_16 = val_17 + 1;
        UnityEngine.Gizmos.color = new UnityEngine.Color() {r = mem[this.point.data + (0)], g = mem[this.point.data + (4)], b = mem[this.point.data + (8)], a = mem[this.point.data + (12)]};
        UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = mem[this.point.point + (0)], y = mem[this.point.point + (4)], z = mem[this.point.point + (8)]}, to:  new UnityEngine.Vector3() {x = this.right.point.point, y = mem[this.point.data + (0)], z = mem[this.point.data + (4)]});
    }

}
