using UnityEngine;
public static class Ferr2D_Triangulator
{
    // Methods
    public static System.Collections.Generic.List<int> GetIndices(ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints, bool aTreatAsPath, bool aInvert, UnityEngine.Vector2 aInvertBorderSize, float aVertGridSpacing = 0)
    {
        var val_1;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        System.Collections.Generic.List<UnityEngine.Vector2> val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        val_39 = 1152921509347996832;
        UnityEngine.Vector4 val_2 = Ferr2D_Triangulator.GetBounds(aPoints:  446138496);
        val_40 = val_3;
        val_41 = val_4;
        val_42 = val_5;
        val_43 = val_6;
        Ferr2D_Triangulator.SplitEdges(aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_7 = 446182560, aMaxDist:  val_2.x);
        536878175 = new System.Collections.Generic.List<SingleRange>(capacity:  mem[aPoints + 12]);
        val_44 = 16;
        val_45 = 0;
        goto label_3;
        label_10:
        if((mem[aPoints + 12]) <= val_45)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_43 = mem[aPoints + 8];
        val_43 = val_43 + val_44;
        if((mem[aPoints + 12]) <= val_45)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        int val_44 = mem[aPoints + 8];
        val_44 = val_44 + val_44;
        val_47 = R7;
        536891967 = new FerrPoly2Tri.PolygonPoint(x:  null, y:  null, aId:  val_44);
        536878175.Add(item:  536891967);
        val_39 = val_39;
        val_44 = 24;
        val_45 = 1;
        label_3:
        if(val_45 < (mem[aPoints + 12]))
        {
            goto label_10;
        }
        
        if(aInvert != false)
        {
                float val_10 = val_41 - val_43;
            float val_11 = val_42 - val_40;
            if(aInvert == false)
        {
                aInvertBorderSize.y = val_10;
        }
        
            val_10 = val_43 - aInvertBorderSize.y;
            if(aInvert == false)
        {
                aInvertBorderSize.x = val_11;
        }
        
            val_11 = val_40 - aInvertBorderSize.x;
            aPoints.Add(item:  new UnityEngine.Vector2() {x = val_11, y = val_10});
            float val_12 = val_42 + aInvertBorderSize.x;
            aPoints.Add(item:  new UnityEngine.Vector2() {x = val_12, y = val_10});
            float val_13 = val_41 + aInvertBorderSize.y;
            aPoints.Add(item:  new UnityEngine.Vector2() {x = val_12, y = val_13});
            aPoints.Add(item:  new UnityEngine.Vector2() {x = val_11, y = val_13});
            536878175 = new System.Collections.Generic.List<SingleRange>(capacity:  4);
            var val_47 = 3;
            do
        {
            if(aPoints != 0)
        {
                val_48 = mem[aPoints + 12];
            val_49 = val_48;
        }
        else
        {
                val_49 = 0;
            val_48 = 0;
        }
        
            val_49 = val_49 + val_47;
            if(val_48 <= val_49)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_45 = mem[aPoints + 8];
            val_45 = val_45 + (val_49 << 3);
            if(aPoints != 0)
        {
                val_50 = mem[aPoints + 12];
            val_44 = val_50;
        }
        else
        {
                val_44 = 0;
            val_50 = 0;
        }
        
            var val_15 = val_44 + val_47;
            if(val_50 <= val_15)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            int val_46 = mem[aPoints + 8];
            val_46 = val_46 + (val_15 << 3);
            val_47 = val_44;
            536891967 = new FerrPoly2Tri.PolygonPoint(x:  null, y:  null, aId:  val_46);
            536878175.Add(item:  536891967);
            val_47 = val_47 + 1;
        }
        while(536878175 != 0);
        
            FerrPoly2Tri.Polygon val_17 = 536891953;
            val_51 = val_17;
            val_17 = new FerrPoly2Tri.Polygon(points:  536878175);
            FerrPoly2Tri.Polygon val_18 = 536891953;
            val_18 = new FerrPoly2Tri.Polygon(points:  536878175);
            val_52 = val_18;
            val_51.AddHole(poly:  536891953);
        }
        else
        {
                FerrPoly2Tri.Polygon val_19 = 536891953;
            val_52 = 536878175;
            val_51 = val_19;
            val_19 = new FerrPoly2Tri.Polygon(points:  536878175);
        }
        
        if(aInvert > false)
        {
                if(aInvert != false)
        {
                val_52 = aPoints;
            UnityEngine.Vector4 val_20 = Ferr2D_Triangulator.GetBounds(aPoints:  446138496);
            val_40 = val_3;
            val_41 = val_4;
            val_42 = val_5;
            val_43 = val_6;
        }
        
            val_43 = val_43 + val_1;
            if(aInvert <= false)
        {
                val_40 = val_40 + val_1;
            val_44 = 0;
            do
        {
            if(aInvert <= false)
        {
                var val_48 = val_40;
            do
        {
            536895819 = new FerrPoly2Tri.TriangulationPoint(x:  null, y:  null, aId:  val_52);
            if((val_51.IsPointInside(p:  536895819)) != false)
        {
                val_51.AddSteinerPoint(point:  536895819);
        }
        
            val_48 = val_48 + val_1;
        }
        while(val_51 <= 0);
        
        }
        
            val_43 = val_43 + val_1;
        }
        while(val_51 <= 0);
        
        }
        
        }
        
        FerrPoly2Tri.P2T.Triangulate(p:  536891953);
        aPoints.Clear();
        if((mem[536891989] + 178) == 0)
        {
            goto label_40;
        }
        
        val_44 = 0;
        label_42:
        if((mem[536891989] + 88 + 0) == 536875885)
        {
            goto label_41;
        }
        
        val_44 = val_44 + 1;
        if(((uint)val_44 & 65535) < (mem[536891989] + 178))
        {
            goto label_42;
        }
        
        label_40:
        val_53 = mem[536891989];
        goto label_43;
        label_41:
        var val_23 = (mem[536891989] + 88) + 0;
        var val_49 = (mem[536891989] + 88 + 0) + 4;
        val_49 = mem[536891989] + (val_49 << 3);
        val_53 = val_49 + 188;
        label_43:
        536877987 = new System.Collections.Generic.List<System.Int32>(capacity:  mem[536891989] + (mem[536891989] << 1));
        FerrPoly2Tri.TriangulationPoint val_50 = mem[536891989];
        if((mem[536891989] + 178) == 0)
        {
            goto label_46;
        }
        
        val_51 = 0;
        label_48:
        val_44 = 0;
        if((mem[536891989] + 88 + 0) == 536876367)
        {
            goto label_47;
        }
        
        val_51 = val_51 + 1;
        val_44 = (uint)val_51 & 65535;
        if(val_44 < (mem[536891989] + 178))
        {
            goto label_48;
        }
        
        label_46:
        val_54 = mem[536891989];
        goto label_49;
        label_47:
        var val_26 = (mem[536891989] + 88) + 0;
        val_50 = val_50 + (((mem[536891989] + 88 + 0) + 4) << 3);
        val_54 = val_50 + 188;
        label_49:
        var val_54 = 0;
        label_76:
        FerrPoly2Tri.TriangulationPoint val_51 = mem[536891989];
        if((mem[536891989] + 178) == 0)
        {
            goto label_51;
        }
        
        val_51 = 0;
        label_53:
        val_44 = 0;
        if((mem[536891989] + 88 + 0) == 536888219)
        {
            goto label_52;
        }
        
        val_51 = val_51 + 1;
        val_44 = (uint)val_51 & 65535;
        if(val_44 < (mem[536891989] + 178))
        {
            goto label_53;
        }
        
        label_51:
        val_55 = mem[536891989];
        goto label_54;
        label_52:
        var val_27 = (mem[536891989] + 88) + 0;
        val_51 = val_51 + (((mem[536891989] + 88 + 0) + 4) << 3);
        val_55 = val_51 + 188;
        label_54:
        if(mem[536891989] == 0)
        {
            goto label_55;
        }
        
        FerrPoly2Tri.TriangulationPoint val_53 = mem[536891989];
        if((mem[536891989] + 178) == 0)
        {
            goto label_57;
        }
        
        var val_52 = 0;
        label_59:
        if((mem[536891989] + 88 + 0) == 536876649)
        {
            goto label_58;
        }
        
        val_52 = val_52 + 1;
        if(((uint)val_52 & 65535) < (mem[536891989] + 178))
        {
            goto label_59;
        }
        
        label_57:
        val_56 = mem[536891989];
        val_57 = val_39;
        goto label_60;
        label_58:
        var val_28 = (mem[536891989] + 88) + 0;
        val_57 = val_39;
        val_53 = val_53 + (((mem[536891989] + 88 + 0) + 4) << 3);
        val_56 = val_53 + 188;
        label_60:
        FerrPoly2Tri.TriangulationPoint val_29 = mem[536891989] + 8;
        FerrPoly2Tri.TriangulationPoint val_30 = val_29.Item[0];
        FerrPoly2Tri.TriangulationPoint val_31 = mem[536891989].PointCWFrom(point:  val_29);
        FerrPoly2Tri.TriangulationPoint val_32 = mem[536891989].PointCWFrom(point:  mem[536891989]);
        float val_33 = val_29.Xf;
        float val_34 = val_29.Yf;
        val_57.Add(item:  new UnityEngine.Vector2() {x = val_29, y = val_29});
        float val_35 = mem[536891989].Xf;
        float val_36 = mem[536891989].Yf;
        aPoints.Add(item:  new UnityEngine.Vector2() {x = mem[536891989], y = mem[536891989]});
        float val_37 = mem[536891989].Xf;
        float val_38 = mem[536891989].Yf;
        aPoints.Add(item:  new UnityEngine.Vector2() {x = mem[536891989], y = mem[536891989]});
        1.085117E-19f.Add(item:  0);
        1.085117E-19f.Add(item:  val_54 + 1);
        val_54 = val_54 + 3;
        1.085117E-19f.Add(item:  val_54 + 2);
        goto label_76;
        label_55:
        if(mem[536891989] == 0)
        {
            goto label_77;
        }
        
        FerrPoly2Tri.TriangulationPoint val_55 = mem[536891989];
        if((mem[536891989] + 178) == 0)
        {
            goto label_78;
        }
        
        val_51 = 0;
        label_80:
        val_44 = 0;
        if((mem[536891989] + 88 + 0) == 536888187)
        {
            goto label_79;
        }
        
        val_51 = val_51 + 1;
        val_44 = (uint)val_51 & 65535;
        if(val_44 < (mem[536891989] + 178))
        {
            goto label_80;
        }
        
        label_78:
        val_58 = mem[536891989];
        val_59 = val_58;
        goto label_81;
        label_79:
        var val_41 = (mem[536891989] + 88) + 0;
        val_58 = mem[536891989];
        val_55 = val_55 + (((mem[536891989] + 88 + 0) + 4) << 3);
        val_59 = val_55 + 188;
        label_81:
        label_77:
        if(1 == 0)
        {
                return;
        }
        
        var val_42 = 1 - 1;
    }
    private static void SplitEdges(ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints, float aMaxDist)
    {
        var val_8;
        var val_11 = 0;
        float val_1 = R1 * R1;
        label_16:
        do
        {
            var val_9 = aPoints + 12;
            val_9 = val_9 - 1;
            if(val_11 >= val_9)
        {
                return;
        }
        
            if((aPoints + 12) <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_10 = aPoints + 8;
            val_10 = val_10 + 0;
            val_11 = val_11 + 1;
            if((aPoints + 12) <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_12 = aPoints + 8;
            float val_14 = (aPoints + 8 + 0) + 20;
            val_12 = val_12 + (val_11 << 3);
            float val_13 = (aPoints + 8 + ((0 + 1)) << 3) + 16;
            val_13 = ((aPoints + 8 + 0) + 16) - val_13;
            val_14 = val_14 - ((aPoints + 8 + ((0 + 1)) << 3) + 20);
            float val_2 = val_13.sqrMagnitude;
        }
        while((aPoints + 12) <= val_11);
        
        if((aPoints + 12) >= _TYPE_MAX_)
        {
                val_8 = 446258576;
        }
        
        val_8 = val_8 / R1;
        if((aPoints + 12) <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_16 = (int)val_8;
        var val_15 = aPoints + 8;
        val_15 = val_15 + 0;
        val_16 = val_16 + 2;
        if((aPoints + 12) <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(val_16 >= 2)
        {
                var val_17 = aPoints + 8;
            val_17 = val_17 + (val_11 << 3);
            float val_3 = aPoints - ((aPoints + 8 + 0) + 20);
            float val_4 = ((aPoints + 8 + ((0 + 1)) << 3) + 16) - ((aPoints + 8 + 0) + 16);
            do
        {
            float val_18 = 1f;
            val_18 = val_18 / (float)val_16;
            float val_6 = UnityEngine.Mathf.Clamp01(value:  val_18);
            aPoints.Insert(index:  val_11 + 0, item:  new UnityEngine.Vector2() {x = (aPoints + 8 + 0) + 16, y = (aPoints + 8 + 0) + 20});
        }
        while((val_16 + 1) != 1);
        
        }
        
        val_19 = val_19 + val_16;
        int val_8 = val_19 + 1;
        goto label_16;
    }
    public static System.Collections.Generic.List<int> GetSegmentsUnder(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aX, float aY, bool aIgnoreLast)
    {
        int val_14;
        int val_15;
        val_14 = aIgnoreLast;
        System.Collections.Generic.List<System.Int32> val_1 = 536877987;
        val_1 = new System.Collections.Generic.List<System.Int32>();
        val_15 = 0;
        if(R3 != 0)
        {
                R3 = 4;
        }
        
        goto label_1;
        label_19:
        val_15 = R2 + 1;
        if(val_15 < val_1)
        {
                val_14 = val_15;
        }
        
        if((-1073714351) <= R2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = 0 + 16;
        if((-1073714351) <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = 0 + (val_14 << 3);
        if((-1073714351) < 0)
        {
                val_14 = R2;
        }
        
        if((-1073714351) <= R2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = 0 + 16;
        if((-1073714351) <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0 + (val_14 << 3);
        if((-1073714351) <= val_14)
        {
                R2 = val_14;
        }
        
        if((-1073714351) <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = 0 + (val_14 << 3);
        if((-1073714351) <= val_14)
        {
                if(val_6 <= R2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_7 = 0 + (R2 << 3);
            if(val_6 > R2)
        {
                if(val_7 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_8 = 0 + (val_14 << 3);
            if(val_7 <= R2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_9 = 0 + (R2 << 3);
            if(val_7 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_10 = 0 + (val_14 << 3);
            if(val_7 <= R2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_11 = 0 + (R2 << 3);
            if(val_7 <= val_14)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = val_15 + (val_14 << 3);
            bool val_12 = val_14 - ((0 + (R2) << 3) + 16);
            float val_16 = (0 + (R2) << 3) + 16;
            val_16 = ((0 + ((R2 + 1)) << 3) + 16) - val_16;
            val_16 = val_12 / val_16;
            float val_13 = UnityEngine.Mathf.Lerp(a:  val_16, b:  aY, t:  val_12);
            if(val_7 < 0)
        {
                if(val_1 != 0)
        {
                val_14 = 22737108;
            val_1.Add(item:  val_14);
        }
        else
        {
                val_14 = 22737108;
            val_1.Add(item:  val_14);
        }
        
            val_1.Add(item:  R2);
        }
        
        }
        
        }
        
        label_1:
        if(val_15 < (R2 - 4))
        {
            goto label_19;
        }
    
    }
    public static int CountSegmentsUnder(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aX, float aY, bool aIgnoreLast)
    {
        var val_3;
        if(R3 != 0)
        {
                R3 = 4;
        }
        
        var val_15 = 0;
        label_18:
        val_3 = 16;
        goto label_1;
        label_17:
        val_3 = 24;
        label_1:
        var val_1 = 0 - 4;
        if(val_15 >= val_1)
        {
                return 1;
        }
        
        val_15 = val_15 + 1;
        if(val_15 < val_1)
        {
                0 = val_15;
        }
        
        if(0 <= val_15)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_2 = 0 + val_3;
        if(0 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_3 = 0 + (0 << 3);
        if(0 < 0)
        {
                0 = val_15;
        }
        
        if(0 <= val_15)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_4 = 0 + val_3;
        if(0 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 0 + (0 << 3);
        if(0 > 0)
        {
                0 = val_15;
        }
        
        if(0 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_6 = 0 + 0;
        if(0 > 0)
        {
            goto label_17;
        }
        
        if(val_6 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_7 = 0 + 0;
        if(val_6 <= 0)
        {
            goto label_17;
        }
        
        if(val_7 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_8 = 0 + 0;
        if(val_7 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_9 = 0 + 0;
        if(val_7 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_10 = 0 + 0;
        if(val_7 <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_11 = 0 + 0;
        if(val_7 <= 0)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + 0;
        bool val_12 = aIgnoreLast - ((0 + 0) + 16);
        float val_17 = (0 + 0) + 16;
        val_17 = ((0 + 0) + 16) - val_17;
        val_17 = val_12 / val_17;
        float val_13 = UnityEngine.Mathf.Lerp(a:  val_17, b:  aY, t:  val_12);
        if(val_7 >= 0)
        {
            goto label_17;
        }
        
        var val_14 = val_15 + 1;
        goto label_18;
    }
    public static UnityEngine.Vector4 GetBounds(System.Collections.Generic.List<UnityEngine.Vector2> aPoints)
    {
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        float val_15;
        val_10 = 23000434;
        if((R1 + 12) > 0)
        {
                val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
            var val_10 = 16;
            do
        {
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
        }
        
            if((R1 + 12) > 0)
        {
                val_12 = val_11 + val_10;
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
            val_12 = mem[(R1 + 8 + 16)];
            val_12 = val_11 + val_10;
        }
        
        }
        
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
        }
        
            if((R1 + 12) < 0)
        {
                val_13 = val_11 + val_10;
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
            val_13 = mem[(R1 + 8 + 16)];
            val_13 = val_11 + val_10;
        }
        
        }
        
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
        }
        
            var val_5 = val_11 + val_10;
            if((R1 + 12) < 0)
        {
                val_14 = (R1 + 8 + 16) + 4;
            if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
            var val_6 = val_11 + val_10;
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
        
            var val_7 = val_11 + val_10;
            if((R1 + 12) > 0)
        {
                if((R1 + 12) <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_11 = mem[R1 + 8];
            val_11 = R1 + 8;
        }
        
            var val_8 = val_11 + val_10;
            val_15 = mem[(R1 + 8 + 16) + 4];
            val_15 = (R1 + 8 + 16) + 4;
        }
        
            val_10 = 0 + 1;
            val_10 = val_10 + 8;
        }
        while(val_10 < (R1 + 12));
        
        }
        
        aPoints = new UnityEngine.Vector4(x:  null, y:  null, z:  null, w:  null);
        return new UnityEngine.Vector4();
    }
    public static bool PtInTri(UnityEngine.Vector2 aTri1, UnityEngine.Vector2 aTri2, UnityEngine.Vector2 aTri3, UnityEngine.Vector2 aPt)
    {
        float val_7 = aTri1.x;
        float val_8 = aTri3.x;
        float val_6 = aTri1.y;
        float val_9 = aPt.y;
        float val_1 = val_8 - val_7;
        float val_11 = aTri3.y;
        float val_2 = val_9 - val_6;
        float val_3 = val_11 - val_6;
        float val_4 = aPt.x - val_7;
        float val_10 = aTri2.x;
        val_6 = aTri2.y - val_6;
        val_1 = val_1 * val_2;
        val_7 = (val_10 - val_7) * val_2;
        if()
        {
                0 = 1;
        }
        
        if()
        {
                0 = 1;
        }
        
        if(1 == 1)
        {
                0 = 0;
            return (bool)0;
        }
        
        val_8 = val_8 - val_10;
        val_9 = val_9 - aTri2.y;
        val_10 = aPt.x - val_10;
        val_11 = val_11 - aTri2.y;
        val_8 = val_8 * val_9;
        if(1 <= 1)
        {
                0 = 1;
        }
        
        if(1 > 1)
        {
                0 = 1;
        }
        
        return false;
    }
    public static UnityEngine.Vector2 LineIntersectionPoint(UnityEngine.Vector2 aStart1, UnityEngine.Vector2 aEnd1, UnityEngine.Vector2 aStart2, UnityEngine.Vector2 aEnd2)
    {
        var val_1;
        float val_4 = aEnd2.y;
        float val_5 = aEnd1.y;
        float val_10 = aStart2.y;
        float val_8 = aEnd2.x;
        float val_9 = aEnd1.x;
        val_4 = val_10 - val_4;
        var val_6 = val_1;
        val_5 = aStart1.y - val_5;
        float val_7 = aStart2.x;
        val_6 = val_6 - val_8;
        val_7 = val_7 - val_9;
        val_8 = val_4 * val_8;
        val_9 = val_5 * val_9;
        val_10 = val_7 * val_4;
        val_4 = val_4 * val_9;
        val_4 = val_4 / val_10;
        mem2[0] = val_4;
        mem2[0] = (val_7 * val_8) / val_10;
        return new UnityEngine.Vector2() {x = val_4};
    }
    public static bool IsClockwise(UnityEngine.Vector2 aPt1, UnityEngine.Vector2 aPt2, UnityEngine.Vector2 aPt3)
    {
        float val_3 = aPt1.x;
        float val_1 = aPt3.y;
        float val_2 = aPt2.x;
        float val_4 = aPt1.y;
        val_1 = val_1 - val_4;
        val_2 = val_2 - val_3;
        val_3 = aPt3.x - val_3;
        val_4 = aPt2.y - val_4;
        val_1 = val_2 * val_1;
        if()
        {
                0 = 1;
        }
        
        return true;
    }
    private static UnityEngine.Vector2 GetCircumcenter(System.Collections.Generic.List<UnityEngine.Vector2> aPoints, System.Collections.Generic.List<int> aTris, int aTri)
    {
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        if((aTri + 12) <= R3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = aTri + 8;
        val_15 = val_15 + (R3 << 2);
        if(val_15 <= ((aTri + 8 + (R3) << 2) + 16))
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + (((aTri + 8 + (R3) << 2) + 16) << 3);
        var val_1 = R3 + 1;
        if((aTri + 12) <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_17 = aTri + 8;
        val_17 = val_17 + (val_1 << 2);
        if((aTri + 12) <= ((aTri + 8 + ((R3 + 1)) << 2) + 16))
        {
                var val_18 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = val_18 + (((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3);
        var val_27 = (0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 20;
        if((aTri + 12) <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_19 = aTri + 8;
        val_19 = val_19 + (val_1 << 2);
        if((aTri + 12) <= ((aTri + 8 + ((R3 + 1)) << 2) + 16))
        {
                var val_20 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_20 = val_20 + (((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3);
        var val_2 = R3 + 2;
        if((aTri + 12) <= val_2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_21 = aTri + 8;
        val_21 = val_21 + (val_2 << 2);
        if((aTri + 12) <= ((aTri + 8 + ((R3 + 2)) << 2) + 16))
        {
                var val_22 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_22 = val_22 + (((aTri + 8 + ((R3 + 2)) << 2) + 16) << 3);
        if((aTri + 12) <= R3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_23 = aTri + 8;
        val_23 = val_23 + (R3 << 2);
        if((aTri + 12) <= ((aTri + 8 + (R3) << 2) + 16))
        {
                var val_24 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_24 = val_24 + (((aTri + 8 + (R3) << 2) + 16) << 3);
        if((aTri + 12) <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_25 = aTri + 8;
        val_25 = val_25 + (val_1 << 2);
        if((aTri + 12) <= ((aTri + 8 + ((R3 + 1)) << 2) + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_26 = (0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 16;
        val_26 = val_26 + (((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3);
        var val_32 = ((0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 16 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 16;
        var val_31 = ((0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 16 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 20;
        if((aTri + 12) <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_28 = aTri + 8;
        val_27 = ((0 + ((aTri + 8 + (R3) << 2) + 16) << 3) + 20) + val_27;
        val_28 = val_28 + (val_1 << 2);
        if((aTri + 12) <= ((aTri + 8 + ((R3 + 1)) << 2) + 16))
        {
                var val_29 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        float val_6 = val_27 * 0.5f;
        float val_7 = (((0 + ((aTri + 8 + (R3) << 2) + 16) << 3) + 16) + ((0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 16)) * 0.5f;
        float val_8 = (((0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 20) + ((0 + ((aTri + 8 + ((R3 + 2)) << 2) + 16) << 3) + 20)) * 0.5f;
        val_29 = val_29 + (((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3);
        float val_9 = (val_26 + ((0 + ((aTri + 8 + ((R3 + 2)) << 2) + 16) << 3) + 16)) * 0.5f;
        val_15 = mem[(0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 16];
        val_15 = (0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 16;
        val_16 = mem[(0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 20];
        val_16 = (0 + ((aTri + 8 + ((R3 + 1)) << 2) + 16) << 3) + 20;
        val_17 = val_2;
        if((aTri + 12) <= val_17)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = val_6;
        var val_30 = aTri + 8;
        val_19 = val_7;
        val_30 = val_30 + (val_17 << 2);
        val_31 = SB - val_31;
        val_32 = ((0 + ((aTri + 8 + (R3) << 2) + 16) << 3) + 16) - val_32;
        if(R3 <= ((aTri + 8 + ((R3 + 2)) << 2) + 16))
        {
                var val_33 = 0;
            val_17 = val_16;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_19 = val_19;
            val_15 = val_15;
            val_18 = val_18;
            val_16 = val_17;
        }
        
        float val_34 = val_15;
        val_33 = val_33 + (((aTri + 8 + ((R3 + 2)) << 2) + 16) << 3);
        val_34 = val_34 - ((0 + ((aTri + 8 + ((R3 + 2)) << 2) + 16) << 3) + 16);
        float val_35 = val_16;
        val_35 = val_35 - ((0 + ((aTri + 8 + ((R3 + 2)) << 2) + 16) << 3) + 20);
        val_34 = val_8 - val_34;
        val_35 = val_9 + val_35;
        UnityEngine.Vector2 val_12 = Ferr2D_Triangulator.LineIntersectionPoint(aStart1:  new UnityEngine.Vector2() {x = 6.861035E-23f, y = val_19}, aEnd1:  new UnityEngine.Vector2() {x = val_18, y = val_7 + val_31}, aStart2:  new UnityEngine.Vector2() {x = val_6 - val_32, y = val_9}, aEnd2:  new UnityEngine.Vector2() {x = val_8, y = val_35});
        return new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
    }
    private static bool EdgeFlip(System.Collections.Generic.List<UnityEngine.Vector2> aPoints, System.Collections.Generic.List<int> aTris, int aTri)
    {
        var val_7;
        var val_8;
        int val_12;
        int val_13;
        int val_14;
        System.Collections.Generic.List<UnityEngine.Vector2> val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        System.Collections.Generic.List<UnityEngine.Vector2> val_21;
        val_12 = aTris;
        536877987 = new System.Collections.Generic.List<System.Int32>(capacity:  3);
        System.Collections.Generic.List<System.Int32> val_2 = 536877987;
        val_2 = new System.Collections.Generic.List<System.Int32>(capacity:  3);
        536877987 = new System.Collections.Generic.List<System.Int32>(capacity:  3);
        System.Collections.Generic.List<System.Int32> val_4 = 536877987;
        val_4 = new System.Collections.Generic.List<System.Int32>(capacity:  3);
        val_1.Clear();
        if(536877987 <= aTri)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + (aTri << 2);
        val_1.Add(item:  (0 + (aTri) << 2) + 16);
        val_13 = aTri + 1;
        if(536877987 <= val_13)
        {
                var val_14 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_14 = val_14 + (val_13 << 2);
        val_1.Add(item:  (0 + ((aTri + 1)) << 2) + 16);
        int val_5 = aTri + 2;
        if(536877987 <= val_5)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = val_15 + (val_5 << 2);
        val_1.Add(item:  (0 + ((aTri + 2)) << 2) + 16);
        val_14 = aTri;
        UnityEngine.Vector2 val_6 = Ferr2D_Triangulator.GetCircumcenter(aPoints:  447207744, aTris:  aPoints, aTri:  val_12);
        if(mem[536877999] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_15 = aPoints;
        if(val_15 == 0)
        {
                val_15 = aPoints;
        }
        
        if((aPoints + 12) <= (mem[536877995] + 16))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_15 = aPoints;
        }
        
        var val_16 = aPoints + 8;
        val_16 = val_16 + ((mem[536877995] + 16) << 3);
        val_16 = 0;
        float val_17 = (aPoints + 8 + (mem[536877995] + 16) << 3) + 16;
        float val_18 = (aPoints + 8 + (mem[536877995] + 16) << 3) + 20;
        val_17 = val_17 - val_7;
        val_18 = val_18 - val_8;
        float val_9 = UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_17, y = val_18});
        goto label_13;
        label_62:
        if(val_16 == val_14)
        {
            goto label_56;
        }
        
        val_3.Clear();
        val_4.Clear();
        val_2.Clear();
        if(val_2 <= val_16)
        {
                var val_19 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_19 = val_19 + 0;
        val_2.Add(item:  (0 + 0) + 16);
        int val_10 = val_16 + 1;
        if(val_2 <= val_10)
        {
                var val_20 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_20 = val_20 + (val_10 << 2);
        val_2.Add(item:  (0 + ((val_16 + 1)) << 2) + 16);
        if(val_2 <= 2)
        {
                var val_21 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_21 = val_21 + 8;
        val_2.Add(item:  (0 + 8) + 16);
        var val_26 = 0;
        do
        {
            val_17 = 0;
            do
        {
            if(mem[536877999] <= val_26)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_22 = mem[536877995];
            val_22 = val_22 + 0;
            if(mem[536877999] <= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_23 = mem[536877995];
            val_23 = val_23 + 0;
            if(((mem[536877995] + 0) + 16) == ((mem[536877995] + 0) + 16))
        {
                if(mem[536877999] <= val_26)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_24 = mem[536877995];
            val_24 = val_24 + 0;
            val_3.Add(item:  (mem[536877995] + 0) + 16);
            val_17 = val_17 + 1;
        }
        
            val_13 = 0 + 1;
        }
        while(val_13 != 3);
        
            if(val_17 == 0)
        {
                if(mem[536877999] <= val_26)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_25 = mem[536877995];
            val_25 = val_25 + 0;
            val_4.Add(item:  (mem[536877995] + 0) + 16);
        }
        
            val_26 = val_26 + 1;
        }
        while(val_26 != 3);
        
        val_18 = val_4;
        if(val_18 == 0)
        {
                val_18 = val_4;
        }
        
        if((mem[536877999] != 1) || (mem[536877999] != 2))
        {
            goto label_51;
        }
        
        var val_27 = 4;
        label_50:
        var val_11 = val_27 - 4;
        if(mem[536877999] <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(mem[536877999] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[536877995] + 16) == (mem[536877995] + 16))
        {
            goto label_45;
        }
        
        if(mem[536877999] <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(mem[536877999] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[536877995] + 16) == (mem[536877995] + 20))
        {
            goto label_45;
        }
        
        if(mem[536877999] <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = 1.085117E-19f;
        if(val_13 == 0)
        {
                val_13 = 1.085117E-19f;
        }
        
        if(mem[536877999] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((mem[536877995] + 16) != (mem[536877995] + 16))
        {
            goto label_49;
        }
        
        label_45:
        val_27 = val_27 + 1;
        if(val_11 < 2)
        {
            goto label_50;
        }
        
        goto label_51;
        label_49:
        if(mem[536877999] <= val_11)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4.Add(item:  mem[536877995] + 16);
        label_51:
        val_19 = val_4;
        val_12 = val_12;
        if(val_19 == 0)
        {
                val_19 = val_4;
        }
        
        val_14 = aTri;
        val_20 = val_16;
        if((mem[536877999] != 2) || (mem[536877999] != 2))
        {
            goto label_56;
        }
        
        if(mem[536877999] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_21 = aPoints;
        if(val_21 == 0)
        {
                val_21 = aPoints;
        }
        
        if((aPoints + 12) <= (mem[536877995] + 20))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_21 = aPoints;
        }
        
        var val_28 = aPoints + 8;
        val_28 = val_28 + ((mem[536877995] + 20) << 3);
        float val_29 = (aPoints + 8 + (mem[536877995] + 20) << 3) + 16;
        float val_30 = (aPoints + 8 + (mem[536877995] + 20) << 3) + 20;
        val_29 = val_29 - val_7;
        val_30 = val_30 - val_8;
        float val_12 = UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_29, y = val_30});
        val_20 = val_16;
        if((aPoints + 12) < 0)
        {
            goto label_60;
        }
        
        label_56:
        val_16 = val_20 + 3;
        label_13:
        if(val_16 < (aTris + 12))
        {
            goto label_62;
        }
        
        return false;
        label_60:
        if(mem[536877999] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12.set_Item(index:  val_14, value:  mem[536877995] + 16);
        if(mem[536877999] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12.set_Item(index:  val_13, value:  mem[536877995] + 16);
        if(mem[536877999] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12.set_Item(index:  val_5, value:  mem[536877995] + 20);
        if(mem[536877999] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12.set_Item(index:  0, value:  mem[536877995] + 20);
        if(mem[536877999] <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12.set_Item(index:  val_10, value:  mem[536877995] + 20);
        if(mem[536877999] == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12.set_Item(index:  2, value:  mem[536877995] + 16);
        return false;
    }
    private static int GetSurroundingTri(System.Collections.Generic.List<UnityEngine.Vector2> aPoints, System.Collections.Generic.List<int> aTris, UnityEngine.Vector2 aPt)
    {
        var val_2 = 0;
        goto label_1;
        label_11:
        if(true <= val_2)
        {
                var val_2 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_2 = val_2 + 0;
        if(val_2 <= ((0 + 0) + 16))
        {
                var val_3 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + (((0 + 0) + 16) << 3);
        if(aTris <= 1)
        {
                var val_4 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 0;
        if(aTris <= ((0 + 0) + 20))
        {
                var val_5 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_5 = val_5 + (((0 + 0) + 20) << 3);
        if(aTris <= 2)
        {
                var val_6 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + 0;
        if(aTris <= ((0 + 0) + 24))
        {
                var val_7 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_7 = val_7 + (((0 + 0) + 24) << 3);
        bool val_1 = Ferr2D_Triangulator.PtInTri(aTri1:  new UnityEngine.Vector2() {x = (0 + ((0 + 0) + 16) << 3) + 16, y = (0 + ((0 + 0) + 16) << 3) + 20}, aTri2:  new UnityEngine.Vector2() {x = (0 + ((0 + 0) + 20) << 3) + 16, y = (0 + ((0 + 0) + 20) << 3) + 20}, aTri3:  new UnityEngine.Vector2() {x = (0 + ((0 + 0) + 24) << 3) + 16, y = aTris}, aPt:  new UnityEngine.Vector2() {x = aPt.x, y = aPt.y});
        if(val_1 == true)
        {
                return 0;
        }
        
        val_2 = 3;
        label_1:
        if(val_2 < val_1)
        {
            goto label_11;
        }
        
        return 0;
    }

}
