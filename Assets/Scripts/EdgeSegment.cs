using UnityEngine;
public class Ferr2DT_PathTerrain.EdgeSegment
{
    // Fields
    public Ferr2DT_TerrainDirection direction;
    public int start;
    public int end;
    public bool closed;
    public Ferr2DPath path;
    public float startDistance;
    public float length;
    public int smoothStart;
    public int smoothEnd;
    private System.Collections.Generic.List<UnityEngine.Vector2> pathVerts;
    
    // Methods
    public Ferr2DT_PathTerrain.EdgeSegment(Ferr2DPath aPath, int aStart, int aEnd, bool aClosed, Ferr2DT_TerrainDirection aDirection)
    {
        this.path = aPath;
        mem[1152921509353595364] = aClosed;
        mem[1152921509353595352] = aDirection;
        mem[1152921509353595356] = aStart;
        mem[1152921509353595360] = aEnd;
    }
    public void UpdateData()
    {
        Ferr2DPath val_12;
        var val_13;
        System.Collections.Generic.List<UnityEngine.Vector2> val_1 = this.path.GetFinalPath();
        this.pathVerts = this.path;
        this.smoothStart = this.path.GetSmoothIndex(aRawIndex:  this.start);
        this.smoothEnd = this.path.GetSmoothIndex(aRawIndex:  this.end);
        Ferr.PathDistanceMask val_4 = this.path.DistanceMask;
        if(this.path <= this.smoothStart)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = this.path;
        val_12 = val_12 + ((this.smoothStart + (this.smoothStart << 1)) << 2);
        this.startDistance = (0 + ((this.smoothStart + (this.smoothStart) << 1)) << 2) + 16;
        Ferr.PathDistanceMask val_6 = val_12.DistanceMask;
        if(this.closed != false)
        {
                float val_7 = val_12.GetTotalDistance();
            val_13 = val_12;
        }
        else
        {
                val_12 = this.smoothEnd;
            if(val_12 <= val_12)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_13 = val_13 + ((val_12 + (val_12 << 1)) << 2);
            val_13 = mem[(0 + ((this.smoothEnd + (this.smoothEnd) << 1)) << 2) + 16];
            val_13 = (0 + ((this.smoothEnd + (this.smoothEnd) << 1)) << 2) + 16;
        }
        
        float val_9 = val_13 - this.startDistance;
        this.length = val_9;
        if(val_12 >= 0)
        {
                return;
        }
        
        Ferr.PathDistanceMask val_10 = this.path.DistanceMask;
        float val_11 = this.path.GetTotalDistance();
        Ferr2DPath val_14 = this.path;
        val_14 = val_9 + val_14;
        this.length = val_14;
    }
    public void Sample(float aDistance, out UnityEngine.Vector2 aPoint, out UnityEngine.Vector2 aNormal, out Ferr2D_PointData aData)
    {
        this.Sample(aDistance:  aDistance, aSmoothIndex: out  int val_1 = 452114672, aSmoothPercent: out  float val_2 = 1.001099E-22f, aPoint: out  new UnityEngine.Vector2() {x = 1.001099E-22f, y = 1.004133E-22f}, aNormal: out  new UnityEngine.Vector2() {x = 1.004389E-22f, y = aNormal.y}, aData: out  new Ferr2D_PointData());
    }
    public void Sample(float aDistance, out int aSmoothIndex, out float aSmoothPercent, out UnityEngine.Vector2 aPoint, out UnityEngine.Vector2 aNormal, out Ferr2D_PointData aData)
    {
        float val_10;
        var val_11;
        float val_26;
        var val_27;
        int val_41;
        System.Collections.Generic.List<UnityEngine.Vector2> val_42;
        var val_43;
        var val_44;
        Ferr2DPath val_45;
        float val_46;
        var val_47;
        var val_48;
        var val_53;
        var val_54;
        float val_55;
        val_41 = 1152921509354241264;
        float val_41 = this.startDistance;
        val_42 = aNormal.y;
        val_43 = aNormal.x;
        val_41 = val_41 + this.length;
        Ferr.PathDistanceMask val_1 = this.path.DistanceMask;
        if(this.path != 0)
        {
                this.path = 1;
        }
        
        int val_3 = this.path.GetSmoothPointIndexAtDistance(aDistance:  val_41, aPercent: out  float val_2 = 1.023329E-22f, aWrap:  true);
        aSmoothPercent = val_3;
        if(val_3 <= val_3)
        {
                var val_42 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_42 = val_42 + (val_3 << 3);
        val_42 = this.pathVerts;
        val_41 = aSmoothPercent;
        var val_43 = 1;
        int val_5 = Ferr.PathUtil.WrapIndex(aIndex:  val_41 + 1, aCount:  1, aClosed:  true);
        if(val_5 <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_43 = val_43 + (val_5 << 3);
        float val_6 = UnityEngine.Mathf.Clamp01(value:  val_41);
        float val_7 = ((1 + (val_5) << 3) + 16) - ((0 + (val_3) << 3) + 16);
        float val_8 = ((1 + (val_5) << 3) + 20) - 452431072;
        aPoint.y = (0 + (val_3) << 3) + 16;
        mem[1152921509354249428] = 452431072;
        if(val_5 == val_5)
        {
                label_38:
            val_44 = aNormal.y;
            if(aSmoothPercent == 1152921509354249423)
        {
                UnityEngine.Vector2 val_9 = Ferr.PathUtil.GetPointNormal(i:  452378856, aPath:  0, aClosed:  this.pathVerts);
            val_45 = aNormal.x;
            val_46 = val_10;
            val_47 = val_11;
            float val_12 = Ferr.PathUtil.GetParallelOffset(i:  0, aPath:  this.pathVerts, aClosed:  this.pathVerts);
            val_48 = 0;
        }
        else
        {
                val_42 = this.pathVerts;
            UnityEngine.Vector2 val_28 = Ferr.PathUtil.GetPointNormal(i:  452378856, aPath:  null, aClosed:  val_42);
            val_46 = ;
            val_47 = val_11;
            float val_29 = Ferr.PathUtil.GetParallelOffset(i:  null, aPath:  this.pathVerts, aClosed:  val_42);
            val_48 = ;
            val_45 = aNormal.x;
        }
        
            val_53 = val_46 * val_48;
            val_54 = val_47 * val_48;
            val_55 = val_53;
        }
        else
        {
                if(val_5 == val_5)
        {
                if(this.closed == true)
        {
            goto label_38;
        }
        
        }
        
            val_44 = aNormal.y;
            UnityEngine.Vector2 val_31 = Ferr.PathUtil.GetSegmentNormal(i:  452378856, aPath:  null, aClosed:  this.pathVerts);
            val_55 = ;
            val_54 = val_11;
            val_45 = aNormal.x;
        }
        
        aNormal.x = val_55;
        mem[1152921509354253508] = val_54;
        Ferr2D_PointData val_32 = GetDataAtDistance(aDist:  val_31.x);
        val_10 = val_26;
        mem[1152921509354257592] = val_27;
        aNormal.y = val_10;
    }
    public void SampleSmoothVert(int aSmoothIndex, out UnityEngine.Vector2 aPoint, out UnityEngine.Vector2 aNormal, out Ferr2D_PointData aData)
    {
        float val_7;
        var val_8;
        var val_10;
        int val_18;
        System.Collections.Generic.List<UnityEngine.Vector2> val_19;
        Ferr2DPath val_20;
        System.Collections.Generic.List<UnityEngine.Vector2> val_21;
        System.Collections.Generic.List<UnityEngine.Vector2> val_23;
        if(this.smoothEnd >= this.smoothStart)
        {
            goto label_1;
        }
        
        if((this.smoothEnd >= aSmoothIndex) || (this.smoothStart <= aSmoothIndex))
        {
            goto label_3;
        }
        
        val_18 = aSmoothIndex - this.smoothEnd;
        if(val_18 < (this.smoothStart - aSmoothIndex))
        {
                val_19 = this.smoothEnd;
        }
        
        goto label_6;
        label_1:
        if(this.closed == false)
        {
            goto label_5;
        }
        
        label_3:
        val_19 = aSmoothIndex;
        goto label_6;
        label_5:
        val_18 = this.smoothStart;
        int val_2 = UnityEngine.Mathf.Clamp(value:  aSmoothIndex, min:  val_18, max:  this.smoothEnd);
        val_19 = val_2;
        label_6:
        if(val_2 <= val_19)
        {
                var val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = val_18 + (val_19 << 3);
        val_20 = this.path;
        Ferr.PathDistanceMask val_3 = val_20.DistanceMask;
        if(val_20 <= val_19)
        {
                var val_19 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_4 = val_19 + (val_19 << 1);
        val_19 = val_19 + (val_4 << 2);
        Ferr.PathDistanceMask val_5 = this.path.DistanceMask;
        if(this.path <= val_19)
        {
                var val_20 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_20 = val_20 + (val_4 << 2);
        Ferr2D_PointData val_6 = GetData(aRawIndex:  val_20, aPercent:  null);
        mem[1152921509354602712] = val_8;
        aNormal.x = val_7;
        if(this.closed == false)
        {
            goto label_16;
        }
        
        label_26:
        UnityEngine.Vector2 val_9 = Ferr.PathUtil.GetPointNormal(i:  452736248, aPath:  val_19, aClosed:  this.pathVerts);
        Ferr.PathDistanceMask val_11 = this.path.DistanceMask;
        if(val_20 != 0)
        {
                val_20 = 1;
        }
        
        if((this.path.IsRawPoint(aSmoothIndex:  val_19, aClosed:  true)) == false)
        {
                return;
        }
        
        float val_13 = Ferr.PathUtil.GetParallelOffset(i:  val_19, aPath:  this.pathVerts, aClosed:  true);
        float val_21 = val_19;
        val_21 = val_7 * val_21;
        mem[1152921509354598644] = val_10 * val_21;
        aPoint.y = val_21;
        return;
        label_16:
        if(val_19 != this.smoothStart)
        {
            goto label_24;
        }
        
        val_21 = this.pathVerts;
        val_23 = val_19;
        goto label_25;
        label_24:
        if(val_19 != this.smoothEnd)
        {
            goto label_26;
        }
        
        val_23 = Ferr.PathUtil.WrapIndex(aIndex:  val_19 - 1, aCount:  0, aClosed:  true);
        val_21 = this.pathVerts;
        label_25:
        UnityEngine.Vector2 val_17 = Ferr.PathUtil.GetSegmentNormal(i:  452736248, aPath:  val_23, aClosed:  val_21);
        aPoint.y = val_7;
        mem[1152921509354598644] = val_10;
    }
    public bool ContainsIndex(int aRawIndex)
    {
        if(this.closed == true)
        {
                return (bool)1;
        }
        
        if(this.end < this.start)
        {
                if(this.start <= aRawIndex)
        {
                0 = 1;
        }
        
            if(this.end > aRawIndex)
        {
                0 = 1;
        }
        
            1 = 1;
            return (bool)1;
        }
        
        if(this.start <= aRawIndex)
        {
                0 = 1;
        }
        
        if(this.end > aRawIndex)
        {
                0 = 1;
        }
        
        return true;
    }
    public float GetOffsetLength(Ferr2DT_SegmentDescription aDesc, bool aInvert, UnityEngine.Vector2 aUpUV)
    {
        var val_8;
        float val_9;
        var val_10;
        int val_11;
        var val_12;
        float val_13;
        var val_14;
        float val_15;
        val_8 = this;
        val_9 = this.length;
        if(this.closed == true)
        {
                return (float)val_13;
        }
        
        float val_1 = this.path.GetInteriorAngle(aRawIndex:  this.end);
        if(this.path > 0)
        {
                val_8 = 1;
        }
        
        float val_2 = this.path.GetInteriorAngle(aRawIndex:  this.start);
        if(this.path > 0)
        {
                val_10 = 1;
        }
        
        if(aInvert != false)
        {
                if(aInvert <= false)
        {
                val_10 = 1;
        }
        
            if(aInvert <= false)
        {
                val_8 = 1;
        }
        
        }
        
        if(aDesc != 0)
        {
                val_11 = 0;
            float val_3 = aDesc.GetLeftCapOffset(aInner:  true, aUnitsPerUV:  new UnityEngine.Vector2() {x = aUpUV.x, y = aUpUV.y}, aId:  val_11);
            val_12 = aDesc;
            float val_4 = aDesc.GetRightCapOffset(aInner:  true, aUnitsPerUV:  new UnityEngine.Vector2() {x = aUpUV.x, y = aUpUV.y}, aId:  val_11);
            val_13 = aDesc._capOffset;
            val_14 = aDesc;
            val_15 = val_13;
        }
        else
        {
                val_11 = 0;
            float val_5 = 0.GetLeftCapOffset(aInner:  true, aUnitsPerUV:  new UnityEngine.Vector2() {x = aUpUV.x, y = aUpUV.y}, aId:  val_11);
            val_8 = 20;
            val_12 = 0;
            float val_6 = 0.GetRightCapOffset(aInner:  true, aUnitsPerUV:  new UnityEngine.Vector2() {x = aUpUV.x, y = aUpUV.y}, aId:  val_11);
            val_15 = 1.401298E-45f;
            val_14 = 0;
            val_13 = 1.401298E-45f;
        }
        
        val_13 = val_12 + val_13;
        val_13 = (val_15 + val_14) + val_13;
        val_9 = val_9 + val_13;
        return (float)val_13;
    }
    public static System.Collections.Generic.List<Ferr2DT_PathTerrain.EdgeSegment> CreateEdgeSegments(Ferr2DPath aPath, bool aSplitCorners)
    {
        Ferr2DPath val_17;
        System.Collections.Generic.List<Page> val_18;
        var val_19;
        var val_20;
        int val_21;
        float val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        val_17 = aPath;
        val_18 = 536878617;
        val_18 = new System.Collections.Generic.List<Page>();
        if(val_17 == 0)
        {
            goto label_1;
        }
        
        val_19 = val_17;
        if(22998722 != 0)
        {
            goto label_29;
        }
        
        label_30:
        int val_18 = val_17.Count;
        val_18 = val_18 - 1;
        label_29:
        if(aSplitCorners == false)
        {
            goto label_3;
        }
        
        Ferr2DT_TerrainDirection val_3 = Ferr2DT_PathTerrain.GetSegmentDirection(aPath:  val_17, aIndex:  0);
        object val_4 = 536898989;
        val_20 = val_4;
        val_4 = new System.Object();
        int val_19 = 1;
        mem[536899009] = 0;
        mem[536898997] = val_17;
        mem[536899001] = 0;
        mem[536899005] = val_19;
        mem[536899013] = val_17;
        if(val_18 >= 2)
        {
                do
        {
            Ferr2DT_TerrainDirection val_5 = Ferr2DT_PathTerrain.GetSegmentDirection(aPath:  val_17, aIndex:  1);
            if(val_17 != 0)
        {
                val_21 = val_17.Count;
        }
        else
        {
                val_21 = val_17.Count;
        }
        
            val_19 = val_19 + 1;
            val_22 = aPath + 16;
            int val_8 = Ferr.PathUtil.WrapIndex(aIndex:  val_19, aCount:  val_21, aClosed:  aPath + 16);
            if(mem[536898997] == val_17)
        {
                val_17 = val_17;
        }
        else
        {
                val_18.Add(item:  536898989);
            object val_9 = 536898989;
            val_20 = val_9;
            val_9 = new System.Object();
            val_17 = val_17;
            mem[536899009] = 0;
            mem[536898997] = val_17;
            mem[536899001] = val_19;
            mem[536899005] = val_8;
            mem[536899013] = val_17;
            if(val_20 == 0)
        {
                val_20 = 0;
        }
        
        }
        
            mem[16] = val_8;
            val_19 = val_22;
        }
        while(val_18 != val_19);
        
        }
        
        val_18 = val_18;
        val_18.Add(item:  0);
        if(val_19 == 0)
        {
            goto label_15;
        }
        
        val_23 = val_18;
        if(mem[536878629] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_24 = val_18;
        if(mem[536878629] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_20 = mem[536878625];
        val_20 = val_20 + ((mem[536878629] - 1) << 2);
        if((mem[536878625] + 16 + 8) != ((mem[536878625] + ((mem[536878629] - 1)) << 2) + 16 + 8))
        {
            goto label_31;
        }
        
        if(mem[536878629] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_25 = mem[536878625];
        if(mem[536878629] != 1)
        {
            goto label_23;
        }
        
        mem2[0] = 1;
        goto label_31;
        label_3:
        if(val_17 == 0)
        {
            goto label_26;
        }
        
        val_26 = 1;
        if((aPath + 16) != 0)
        {
            goto label_27;
        }
        
        goto label_32;
        label_1:
        int val_11 = 0.Count;
        if(mem[16] != 0)
        {
            goto label_29;
        }
        
        goto label_30;
        label_15:
        val_24 = val_18 + 8;
        val_23 = val_18 + 12;
        goto label_31;
        label_26:
        if((aPath + 16) == 0)
        {
            goto label_32;
        }
        
        val_26 = mem[aPath + 16];
        val_26 = aPath + 16;
        label_27:
        object val_12 = 536898989;
        val_27 = val_12;
        val_24 = 0;
        val_12 = new System.Object();
        mem[536899009] = val_26;
        mem[536898997] = val_24;
        mem[536899001] = val_24;
        mem[536899005] = val_24;
        mem[536899013] = val_17;
        goto label_33;
        label_32:
        System.Collections.Generic.List<UnityEngine.Vector2> val_13 = 0.GetFinalPath();
        val_22 = 0f;
        val_24 = mem[aPath + 16];
        val_24 = aPath + 16;
        object val_14 = 536898989;
        val_27 = val_14;
        val_28 = 0;
        val_14 = new System.Object();
        mem[536899009] = val_24;
        mem[536898997] = val_28;
        mem[536899001] = val_28;
        mem[536899005] = val_22 - 1;
        mem[536899013] = val_17;
        label_33:
        this.UpdateData();
        val_18.Add(item:  536898989);
        return;
        label_23:
        if(mem[536878629] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_25 = mem[536878625];
        }
        
        val_25 = val_25 + ((mem[536878629] - 1) << 2);
        mem2[0] = (mem[536878625] + ((mem[536878629] - 1)) << 2) + 16 + 12;
        val_18.RemoveAt(index:  mem[536878629] - 1);
        label_31:
        val_28 = 0;
        goto label_42;
        label_46:
        if(val_18 <= val_28)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_21 = mem[536878625];
        val_21 = val_21 + 0;
        (mem[536878625] + 0) + 16.UpdateData();
        val_28 = 1;
        label_42:
        if(val_28 < mem[536878629])
        {
            goto label_46;
        }
    
    }

}
