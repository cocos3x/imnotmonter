using UnityEngine;

namespace Ferr
{
    public static class PathUtil
    {
        // Methods
        public static bool IsClockwise(System.Collections.Generic.List<UnityEngine.Vector2> aPoly)
        {
            var val_3;
            var val_4;
            val_3 = 0;
            val_4 = 16;
            goto label_1;
            label_7:
            var val_4 = 1;
            var val_5 = R6;
            if(R6 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 - 1;
            val_5 = 0 + (val_5 << 3);
            if(R6 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(R6 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = 0 + (val_5 << 3);
            if(R6 <= val_4)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + val_4;
            float val_3 = ((0 + (R6) << 3) + 16) - (0 + val_4);
            val_3 = val_4 + 1;
            val_4 = 24;
            var val_7 = (0 + val_4) + 4;
            val_7 = ((0 + (R6) << 3) + 20) + val_7;
            label_1:
            if(val_3 < R6)
            {
                goto label_7;
            }
            
            if(val_3 > R6)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static void SortPointsClockwise(ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints)
        {
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.Average(aPoints:  1255993352);
            Ferr.PathUtil.SortPointsClockwise(aPoints: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_2 = 1256037376, aCenter:  new UnityEngine.Vector2());
        }
        public static void SortPointsClockwise(ref System.Collections.Generic.List<UnityEngine.Vector2> aPoints, UnityEngine.Vector2 aCenter)
        {
            536900259 = new PathUtil.<>c__DisplayClass6_0();
            mem[536900267] = aCenter.x;
            mem[536900271] = aCenter.y;
            536873805 = new System.Comparison<UnityEngine.Vector2>(object:  536900259, method:  new IntPtr(1610688647));
            aPoints.Sort(comparison:  536873805);
        }
        public static float GetLength(System.Collections.Generic.List<UnityEngine.Vector3> aPath, bool aClosed)
        {
            var val_2;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            float val_14;
            val_7 = aPath;
            bool val_1 = aClosed ^ 1;
            aClosed = 23000523 - val_1;
            if(aClosed < true)
            {
                goto label_2;
            }
            
            val_1 = 0 - val_1;
            val_1 = 23000523 + val_1;
            val_9 = 0;
            val_10 = 0;
            val_1 = val_1 - 1;
            goto label_3;
            label_6:
            val_10 = 1;
            val_11 = R8;
            val_8 = mem[R8 + 12];
            val_8 = R8 + 12;
            val_9 = val_2 + 12;
            label_3:
            if(val_8 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_8 = mem[R8 + 12];
                val_8 = R8 + 12;
            }
            
            val_12 = mem[R8 + 8];
            val_12 = R8 + 8;
            val_2 = val_9;
            var val_4 = (val_12 + val_9) + 16;
            if(val_8 <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_12 = mem[R8 + 8];
                val_12 = R8 + 8;
            }
            
            val_12 = val_12 + ((val_8 + (val_8 << 1)) << 2);
            float val_6 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = mem[((R8 + 8 + (val_2 + 12)) + 16) + (0)], y = mem[((R8 + 8 + (val_2 + 12)) + 16) + (4)], z = mem[((R8 + 8 + (val_2 + 12)) + 16) + (8)]}, b:  new UnityEngine.Vector3() {x = (R8 + 8 + ((R8 + 12 + (R8 + 12) << 1)) << 2) + 16, y = (R8 + 8 + ((R8 + 12 + (R8 + 12) << 1)) << 2) + 20, z = (R8 + 8 + ((R8 + 12 + (R8 + 12) << 1)) << 2) + 24});
            val_14 = 0f + (mem[((R8 + 8 + (val_2 + 12)) + 16) + (0)]);
            if(val_1 != val_10)
            {
                goto label_6;
            }
            
            return (float)S0;
            label_2:
            val_14 = 0f;
            return (float)S0;
        }
        public static float GetLength(System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            var val_4;
            var val_5;
            float val_7;
            bool val_1 = aClosed ^ 1;
            aClosed = R6 - val_1;
            if(aClosed < true)
            {
                goto label_2;
            }
            
            val_1 = 0 - val_1;
            val_1 = R6 + val_1;
            val_4 = 16;
            val_5 = 0;
            val_1 = val_1 - 1;
            goto label_3;
            label_6:
            val_5 = 1;
            val_4 = 24;
            label_3:
            if(R6 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(R6 <= R6)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + (R6 << 3);
            float val_2 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = 0f, y = 7.286752E-44f}, b:  new UnityEngine.Vector2() {x = (0 + (R6) << 3) + 16});
            val_7 = 0f + 0;
            if(val_1 != val_5)
            {
                goto label_6;
            }
            
            return (float)S0;
            label_2:
            val_7 = 0f;
            return (float)S0;
        }
        public static UnityEngine.Rect GetBounds(System.Collections.Generic.List<UnityEngine.Vector2> aPoints, UnityEngine.Vector4 aPadding)
        {
            var val_7;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if((aPadding.x != 0f) && ((aPadding.x + 12) >= 1))
            {
                    var val_10 = 0;
                var val_11 = 16;
                do
            {
                if((aPadding.x + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = mem[aPadding.x + 8];
                val_9 = aPadding.x + 8;
                if((aPadding.x + 12) < 0)
            {
                    val_10 = val_9 + val_11;
                if((aPadding.x + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_9 = mem[aPadding.x + 8];
                val_9 = aPadding.x + 8;
                val_10 = mem[(aPadding.x + 8 + 16)];
                val_10 = val_9 + val_11;
            }
            
            }
            
                if((aPadding.x + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_9 = mem[aPadding.x + 8];
                val_9 = aPadding.x + 8;
            }
            
                if((aPadding.x + 12) > val_10)
            {
                    val_11 = val_9 + val_11;
                if((aPadding.x + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_9 = mem[aPadding.x + 8];
                val_9 = aPadding.x + 8;
                val_11 = mem[(aPadding.x + 8 + 16)];
                val_11 = val_9 + val_11;
            }
            
            }
            
                if((aPadding.x + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_9 = mem[aPadding.x + 8];
                val_9 = aPadding.x + 8;
            }
            
                var val_5 = val_9 + val_11;
                if((aPadding.x + 12) > val_10)
            {
                    val_12 = (aPadding.x + 8 + 16) + 4;
                if((aPadding.x + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_9 = mem[aPadding.x + 8];
                val_9 = aPadding.x + 8;
                var val_6 = val_9 + val_11;
                val_12 = mem[(aPadding.x + 8 + 16) + 4];
                val_12 = (aPadding.x + 8 + 16) + 4;
            }
            
            }
            
                if((aPadding.x + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_9 = mem[aPadding.x + 8];
                val_9 = aPadding.x + 8;
            }
            
                val_9 = val_9 + val_11;
                if((aPadding.x + 12) < 0)
            {
                    val_13 = (aPadding.x + 8 + 16) + 4;
                if((aPadding.x + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_9 = aPadding.x + 8;
                val_9 = val_9 + val_11;
                val_13 = mem[(aPadding.x + 8 + 16) + 4];
                val_13 = (aPadding.x + 8 + 16) + 4;
            }
            
            }
            
                val_10 = val_10 + 1;
                val_11 = val_11 + 8;
            }
            while(val_10 < (aPadding.x + 12));
            
                float val_12 = aPadding.y;
                float val_13 = aPadding.w;
                val_12 = val_11 - val_12;
                val_13 = val_10 + val_13;
                var val_14 = val_7;
                val_14 = val_12 - val_14;
                val_13 = val_13 - val_12;
                float val_15 = aPadding.z;
                val_15 = val_13 + val_15;
                val_15 = val_15 - val_14;
            }
            
            aPoints = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            return new UnityEngine.Rect();
        }
        public static UnityEngine.Vector2 Average(System.Collections.Generic.List<UnityEngine.Vector2> aPoints)
        {
            var val_2;
            var val_3;
            var val_4;
            float val_5;
            float val_6;
            var val_7;
            float val_8;
            val_4 = 0;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            val_6 = val_2;
            val_7 = 16;
            val_8 = val_3;
            goto label_1;
            label_4:
            if( <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = 1;
            var val_4 = R1 + 8;
            val_4 = val_4 + val_7;
            val_7 = 24;
            var val_5 = (R1 + 8 + val_7) + 4;
            val_5 = val_5 / ((float)R1 + 12);
            val_5 = val_4 / ((float)R1 + 12);
            val_8 = val_8 + val_5;
            val_6 = val_6 + val_5;
            label_1:
            if(val_4 < (R1 + 12))
            {
                goto label_4;
            }
            
            mem2[0] = val_6;
            mem2[0] = val_8;
            return new UnityEngine.Vector2() {x = val_5, y = val_1.y};
        }
        public static float GetInteriorAngle(int i, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            float val_12;
            var val_14;
            var val_15;
            var val_16;
            val_12 = 180f;
            if(R7 < 2)
            {
                    return val_12;
            }
            
            if(aClosed == false)
            {
                goto label_3;
            }
            
            var val_1 = R7 + R7;
            label_10:
            if(R7 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            label_18:
            var val_2 = R6 + (R7 << 3);
            val_14 = 0;
            val_15 = mem[(R6 + (R7) << 3) + 16];
            val_15 = (R6 + (R7) << 3) + 16;
            if(R7 == 0)
            {
                goto label_11;
            }
            
            int val_3 = i - 1;
            if(aClosed == false)
            {
                goto label_6;
            }
            
            var val_4 = R7 + R7;
            val_15 = val_15;
            val_14 = R7;
            goto label_11;
            label_3:
            if(i != 0)
            {
                    23000527 = R7 - 1;
            }
            
            if(23000527 == i)
            {
                    return val_12;
            }
            
            if(i <= 1)
            {
                goto label_18;
            }
            
            if(R7 > i)
            {
                    23000527 = i;
            }
            
            goto label_10;
            label_6:
            if(val_3 >= 0)
            {
                    if(val_3 >= R7)
            {
                    val_3 = R7 - 1;
            }
            
                val_14 = val_3;
            }
            
            label_11:
            if(R7 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_15 = val_15;
            }
            
            var val_5 = val_15 + (val_14 << 3);
            val_16 = 0;
            float val_11 = ((R6 + (R7) << 3) + 16 + ((R7 - 1)) << 3) + 16;
            float val_12 = ((R6 + (R7) << 3) + 16 + ((R7 - 1)) << 3) + 20;
            val_11 = val_11 - val_15;
            val_12 = val_12 - ((R6 + (R7) << 3) + 20);
            if(R7 != 0)
            {
                    int val_6 = i + 1;
                if(aClosed != false)
            {
                    var val_7 = R7 + R7;
                val_16 = R7;
            }
            else
            {
                    if(val_6 >= 0)
            {
                    if(val_6 >= R7)
            {
                    val_6 = R7 - 1;
            }
            
                val_16 = val_6;
            }
            
            }
            
            }
            
            if(R7 <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = val_15 + (val_16 << 3);
            float val_13 = ((R6 + (R7) << 3) + 16 + ((R7 - 1)) << 3) + 16;
            float val_14 = ((R6 + (R7) << 3) + 16 + ((R7 - 1)) << 3) + 20;
            val_13 = val_13 - val_15;
            val_14 = val_14 - ((R6 + (R7) << 3) + 20);
            val_11.Normalize();
            val_13.Normalize();
            float val_9 = Ferr.PathUtil.SignedAngle(v1:  new UnityEngine.Vector2() {x = val_11, y = val_12}, v2:  new UnityEngine.Vector2() {x = val_13, y = val_14});
            float val_15 = -180f;
            val_15 = (val_11 + val_15) + val_15;
            if(R7 > val_16)
            {
                    val_11 = val_15;
            }
            
            val_12 = -val_11;
            return val_12;
        }
        public static UnityEngine.Vector2 GetPointNormal(int i, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            var val_3;
            var val_4;
            var val_13;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            if(val_13 <= 1)
            {
                goto label_2;
            }
            
            if(val_13 != 2)
            {
                goto label_3;
            }
            
            label_7:
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.GetSegmentNormal(i:  1256834440, aPath:  aPath, aClosed:  aClosed);
            goto label_4;
            label_2:
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.up;
            label_4:
            label_21:
            mem2[0] = val_3;
            mem2[0] = val_4;
            return new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
            label_3:
            if(R3 == 0)
            {
                goto label_5;
            }
            
            var val_5 = val_13 + val_13;
            val_16 = val_13;
            goto label_6;
            label_5:
            if(aPath != 0)
            {
                    23000528 = val_13 - 1;
            }
            
            if(23000528 == aPath)
            {
                goto label_7;
            }
            
            if(aPath < 0)
            {
                goto label_8;
            }
            
            if(val_13 > aPath)
            {
                    val_16 = aPath;
            }
            
            label_6:
            if(val_13 > val_16)
            {
                goto label_10;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            goto label_10;
            label_8:
            val_16 = 0;
            label_10:
            val_17 = mem[aClosed + 8];
            val_17 = aClosed + 8;
            var val_6 = val_17 + 0;
            val_18 = 0;
            val_19 = mem[(aClosed + 8 + 0) + 16];
            val_19 = (aClosed + 8 + 0) + 16;
            val_20 = mem[(aClosed + 8 + 0) + 20];
            val_20 = (aClosed + 8 + 0) + 20;
            if(val_13 != 0)
            {
                    System.Collections.Generic.List<UnityEngine.Vector2> val_7 = aPath - 1;
                if(R3 != 0)
            {
                    var val_8 = val_13 + val_13;
                val_19 = val_19;
                val_18 = val_13;
                val_20 = val_20;
            }
            else
            {
                    if(val_7 >= 0)
            {
                    if(val_7 >= val_13)
            {
                    val_7 = val_13 - 1;
            }
            
                val_18 = val_7;
            }
            
            }
            
            }
            
            if(val_13 <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_20 = val_20;
                val_19 = val_19;
                val_17 = mem[aClosed + 8];
                val_17 = aClosed + 8;
                val_13 = mem[aClosed + 12];
                val_13 = aClosed + 12;
            }
            
            var val_9 = val_17 + (val_18 << 3);
            val_21 = 0;
            float val_13 = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16;
            float val_14 = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 20;
            val_13 = val_13 - val_19;
            val_14 = val_14 - val_20;
            if(val_13 != 0)
            {
                    System.Collections.Generic.List<UnityEngine.Vector2> val_10 = aPath + 1;
                if(R3 != 0)
            {
                    var val_11 = val_13 + val_13;
                val_21 = val_13;
            }
            else
            {
                    if(val_10 >= 0)
            {
                    if(val_10 >= val_13)
            {
                    val_10 = val_13 - 1;
            }
            
                val_21 = val_10;
            }
            
            }
            
            }
            
            if(val_13 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[aClosed + 8];
                val_17 = aClosed + 8;
            }
            
            var val_12 = val_17 + (val_21 << 3);
            float val_15 = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16;
            float val_16 = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 20;
            val_15 = val_15 - val_19;
            val_16 = val_16 - val_20;
            val_13.Normalize();
            val_15.Normalize();
            float val_17 = val_16;
            float val_18 = val_13;
            val_17 = val_17 - val_14;
            val_18 = val_18 - val_15;
            val_17 = val_17 * 0.5f;
            val_18 = val_18 * 0.5f;
            val_17.Normalize();
            goto label_21;
        }
        public static UnityEngine.Vector2 GetPointNormalWeighted(int i, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            var val_7;
            var val_8;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            float val_24;
            float val_25;
            var val_26;
            float val_27;
            float val_28;
            val_19 = mem[aClosed + 12];
            val_19 = aClosed + 12;
            if(val_19 <= 1)
            {
                goto label_2;
            }
            
            if(R3 == 0)
            {
                goto label_3;
            }
            
            var val_1 = val_19 + val_19;
            label_19:
            if(val_19 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_19 = mem[aClosed + 12];
                val_19 = aClosed + 12;
            }
            
            label_20:
            val_20 = mem[aClosed + 8];
            val_20 = aClosed + 8;
            var val_2 = val_20 + (val_19 << 3);
            val_21 = 0;
            val_22 = mem[(aClosed + 8 + (aClosed + 12) << 3) + 16];
            val_22 = (aClosed + 8 + (aClosed + 12) << 3) + 16;
            val_23 = mem[(aClosed + 8 + (aClosed + 12) << 3) + 20];
            val_23 = (aClosed + 8 + (aClosed + 12) << 3) + 20;
            if(val_19 == 0)
            {
                goto label_11;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_3 = aPath - 1;
            if(R3 == 0)
            {
                goto label_6;
            }
            
            var val_4 = val_19 + val_19;
            val_22 = val_22;
            val_21 = val_19;
            val_23 = val_23;
            goto label_11;
            label_2:
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.up;
            goto label_8;
            label_3:
            if((val_19 - 1) != aPath)
            {
                goto label_9;
            }
            
            UnityEngine.Vector2 val_6 = Ferr.PathUtil.GetSegmentNormal(i:  1256954632, aPath:  aPath, aClosed:  aClosed);
            label_8:
            val_27 = val_7;
            val_28 = val_8;
            goto label_10;
            label_6:
            if(val_3 >= 0)
            {
                    if(val_3 >= val_19)
            {
                    val_3 = val_19 - 1;
            }
            
                val_21 = val_3;
            }
            
            label_11:
            if(val_19 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_23 = val_23;
                val_22 = val_22;
                val_20 = mem[aClosed + 8];
                val_20 = aClosed + 8;
                val_19 = mem[aClosed + 12];
                val_19 = aClosed + 12;
            }
            
            var val_9 = val_20 + (val_21 << 3);
            val_26 = 0;
            float val_19 = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16;
            float val_20 = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 20;
            val_19 = val_19 - val_22;
            val_20 = val_20 - val_23;
            if(val_19 != 0)
            {
                    System.Collections.Generic.List<UnityEngine.Vector2> val_10 = aPath + 1;
                if(R3 != 0)
            {
                    var val_11 = val_19 + val_19;
                val_26 = val_19;
            }
            else
            {
                    if(val_10 >= 0)
            {
                    if(val_10 >= val_19)
            {
                    val_10 = val_19 - 1;
            }
            
                val_26 = val_10;
            }
            
            }
            
            }
            
            if(val_19 <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_20 = mem[aClosed + 8];
                val_20 = aClosed + 8;
            }
            
            var val_12 = val_20 + (val_26 << 3);
            float val_21 = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16;
            float val_22 = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 20;
            val_21 = val_21 - val_22;
            val_22 = val_22 - val_23;
            float val_13 = val_19.magnitude;
            float val_14 = val_21.magnitude;
            float val_23 = val_19;
            float val_24 = val_22;
            float val_15 = 1256954656 + 1256954648;
            float val_25 = val_20;
            val_23 = val_23 / 1256954656;
            val_24 = val_24 / 1256954648;
            val_15 = 1256954648 / val_15;
            float val_17 = val_15 * val_24;
            val_25 = val_25 / 1256954656;
            val_24 = val_21 / 1256954648;
            val_25 = -val_25;
            val_17.Normalize();
            val_27 = val_17;
            val_28 = (1256954656 / val_15) * val_23;
            label_10:
            mem2[0] = val_27;
            mem2[0] = val_28;
            return new UnityEngine.Vector2() {x = val_24, y = val_25};
            label_9:
            if(aPath <= 1)
            {
                goto label_20;
            }
            
            if(val_19 > aPath)
            {
                    val_19 - 1 = aPath;
            }
            
            goto label_19;
        }
        public static UnityEngine.Vector3 GetPointNormal3D(int i, System.Collections.Generic.List<UnityEngine.Vector3> aPath, bool aClosed)
        {
            float val_3;
            float val_4;
            float val_13;
            float val_17;
            float val_18;
            float val_19;
            var val_20;
            var val_21;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_17 = R3;
            val_18 = 23000530;
            val_19 = aPath;
            val_20 = mem[aClosed + 12];
            val_20 = aClosed + 12;
            if(val_20 <= 1)
            {
                goto label_2;
            }
            
            if(val_17 == 0)
            {
                goto label_3;
            }
            
            var val_1 = val_20 + val_20;
            val_21 = val_20;
            goto label_4;
            label_2:
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
            mem2[0] = val_4;
            mem2[0] = val_3;
            return new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
            label_3:
            if(val_19 < 0)
            {
                goto label_6;
            }
            
            if(val_20 <= val_19)
            {
                    val_21 = val_20 - 1;
            }
            
            label_4:
            if(val_20 > val_21)
            {
                goto label_8;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_25 = mem[aClosed + 12];
            val_25 = aClosed + 12;
            goto label_8;
            label_6:
            val_21 = 0;
            label_8:
            var val_5 = val_21 + 0;
            val_26 = mem[aClosed + 8];
            val_26 = aClosed + 8;
            val_27 = 0;
            val_5 = val_26 + (val_5 << 2);
            if(val_20 != 0)
            {
                    System.Collections.Generic.List<UnityEngine.Vector3> val_6 = val_19 - 1;
                if(val_17 != 0)
            {
                    var val_7 = val_20 + val_20;
                val_27 = val_20;
            }
            else
            {
                    if(val_6 >= 0)
            {
                    if(val_6 >= val_20)
            {
                    val_6 = val_20 - 1;
            }
            
                val_27 = val_6;
            }
            
            }
            
            }
            
            if(val_20 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_26 = mem[aClosed + 8];
                val_26 = aClosed + 8;
                val_25 = mem[aClosed + 12];
                val_25 = aClosed + 12;
            }
            
            var val_8 = val_27 + (val_27 << 1);
            val_28 = 0;
            val_8 = val_26 + (val_8 << 2);
            float val_17 = (aClosed + 8 + (((aClosed + 12 - 1) + ((aClosed + 12 - 1)) << 1)) << 2) + 16;
            float val_18 = (aClosed + 8 + (((aClosed + 12 - 1) + ((aClosed + 12 - 1)) << 1)) << 2) + 20;
            float val_19 = (aClosed + 8 + (((aClosed + 12 - 1) + ((aClosed + 12 - 1)) << 1)) << 2) + 24;
            val_17 = ((aClosed + 8 + ((val_21 + 0)) << 2) + 16) - val_17;
            val_18 = ((aClosed + 8 + ((val_21 + 0)) << 2) + 20) - val_18;
            val_19 = ((aClosed + 8 + ((val_21 + 0)) << 2) + 24) - val_19;
            if(val_25 != 0)
            {
                    System.Collections.Generic.List<UnityEngine.Vector3> val_9 = val_19 + 1;
                if(val_17 != 0)
            {
                    var val_10 = val_25 + val_25;
                val_28 = val_25;
            }
            else
            {
                    if(val_9 >= 0)
            {
                    if(val_9 >= val_25)
            {
                    val_9 = val_25 - 1;
            }
            
                val_28 = val_9;
            }
            
            }
            
            }
            
            if(val_25 <= val_28)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_26 = mem[aClosed + 8];
                val_26 = aClosed + 8;
            }
            
            var val_11 = val_28 + (val_28 << 1);
            val_29 = 0;
            val_11 = val_26 + (val_11 << 2);
            float val_20 = (aClosed + 8 + (((aClosed + 12 - 1) + ((aClosed + 12 - 1)) << 1)) << 2) + 16;
            float val_21 = (aClosed + 8 + (((aClosed + 12 - 1) + ((aClosed + 12 - 1)) << 1)) << 2) + 20;
            float val_22 = (aClosed + 8 + (((aClosed + 12 - 1) + ((aClosed + 12 - 1)) << 1)) << 2) + 24;
            val_20 = val_20 - ((aClosed + 8 + ((val_21 + 0)) << 2) + 16);
            val_21 = val_21 - ((aClosed + 8 + ((val_21 + 0)) << 2) + 20);
            val_22 = val_22 - ((aClosed + 8 + ((val_21 + 0)) << 2) + 24);
            val_17.Normalize();
            val_20.Normalize();
            float val_23 = val_20;
            float val_24 = val_21;
            val_23 = val_17 + val_23;
            float val_25 = val_22;
            val_24 = val_18 + val_24;
            val_25 = val_20 + val_25;
            val_23.Normalize();
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 7780396f, y = val_23, z = val_24}, rhs:  new UnityEngine.Vector3() {x = val_25, y = val_25, z = val_18});
            float val_26 = val_23;
            val_18 = (aClosed + 8 + ((val_21 + 0)) << 2) + 16;
            float val_27 = val_24;
            val_26 = val_26 + ((aClosed + 8 + ((val_21 + 0)) << 2) + 16);
            val_27 = val_27 + ((aClosed + 8 + ((val_21 + 0)) << 2) + 20);
            val_17 = val_13;
            val_19 = val_4;
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = (aClosed + 8 + ((val_21 + 0)) << 2) + 16, y = (aClosed + 8 + ((val_21 + 0)) << 2) + 20, z = (aClosed + 8 + ((val_21 + 0)) << 2) + 24}, to:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_25 + ((aClosed + 8 + ((val_21 + 0)) << 2) + 24)});
            float val_28 = val_25;
            float val_29 = val_18;
            val_28 = val_28 + ((aClosed + 8 + ((val_21 + 0)) << 2) + 16);
            val_29 = val_29 + ((aClosed + 8 + ((val_21 + 0)) << 2) + 20);
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_18, y = (aClosed + 8 + ((val_21 + 0)) << 2) + 20, z = (aClosed + 8 + ((val_21 + 0)) << 2) + 24}, to:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_20 + ((aClosed + 8 + ((val_21 + 0)) << 2) + 24)});
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 7780396f, y = val_3, z = val_17}, rhs:  new UnityEngine.Vector3() {x = val_19, y = val_23, z = val_24});
            val_3.Normalize();
            mem2[0] = val_4;
            mem2[0] = val_3;
            return new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        }
        public static UnityEngine.Vector2 GetPointTangent(int i, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            var val_2;
            var val_3;
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.GetPointNormal(i:  1257195064, aPath:  aPath, aClosed:  aClosed);
            var val_4 = val_2;
            val_4 = val_4 ^ 2147483648;
            mem2[0] = val_3;
            mem2[0] = val_4;
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public static UnityEngine.Vector2 GetSegmentTangent(int i, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            var val_2;
            var val_3;
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.GetSegmentNormal(i:  1257315256, aPath:  aPath, aClosed:  aClosed);
            var val_4 = val_2;
            val_4 = val_4 ^ 2147483648;
            mem2[0] = val_3;
            mem2[0] = val_4;
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public static UnityEngine.Vector2 GetSegmentNormal(int i, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_12 = aPath;
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            if(val_13 <= 1)
            {
                goto label_2;
            }
            
            if(R3 == 0)
            {
                goto label_3;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = val_12 + 1;
            var val_2 = val_13 + val_13;
            val_14 = val_13;
            goto label_4;
            label_2:
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.up;
            goto label_5;
            label_3:
            if((val_13 - 1) != val_12)
            {
                goto label_6;
            }
            
            val_17 = 0;
            if(val_12 < 0)
            {
                goto label_7;
            }
            
            val_18 = val_12;
            if(val_13 > val_12)
            {
                goto label_9;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            val_18 = val_12;
            goto label_9;
            label_6:
            System.Collections.Generic.List<UnityEngine.Vector2> val_5 = val_12 + 1;
            if(val_5 <= 1)
            {
                goto label_10;
            }
            
            if(val_5 < val_13)
            {
                    val_14 = val_5;
            }
            
            label_4:
            if(val_13 > val_14)
            {
                goto label_12;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            goto label_12;
            label_7:
            val_18 = 0;
            label_9:
            val_19 = mem[aClosed + 8];
            val_19 = aClosed + 8;
            var val_6 = val_19 + 0;
            System.Collections.Generic.List<UnityEngine.Vector2> val_7 = val_12 - 1;
            val_20 = mem[(aClosed + 8 + 0) + 16];
            val_20 = (aClosed + 8 + 0) + 16;
            val_21 = mem[(aClosed + 8 + 0) + 20];
            val_21 = (aClosed + 8 + 0) + 20;
            if((val_7 >= 0) && (val_13 != 0))
            {
                    if(val_7 >= val_13)
            {
                    val_7 = val_13 - 1;
            }
            
                val_17 = val_7;
            }
            
            if(val_13 <= val_17)
            {
                    val_12 = val_21;
                val_13 = val_20;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_19 = mem[aClosed + 8];
                val_19 = aClosed + 8;
                val_20 = val_13;
                val_21 = val_12;
            }
            
            val_22 = val_19 + (val_17 << 3);
            goto label_16;
            label_10:
            val_14 = 0;
            label_12:
            val_23 = mem[aClosed + 8];
            val_23 = aClosed + 8;
            var val_8 = val_23 + 0;
            val_24 = 0;
            val_20 = mem[(aClosed + 8 + 0) + 16];
            val_20 = (aClosed + 8 + 0) + 16;
            val_21 = mem[(aClosed + 8 + 0) + 20];
            val_21 = (aClosed + 8 + 0) + 20;
            if(val_13 != 0)
            {
                    if(R3 != 0)
            {
                    val_12 = val_20;
                var val_9 = val_13 + val_13;
                val_21 = val_21;
                val_20 = val_12;
                val_24 = val_13;
            }
            else
            {
                    if(val_12 >= 0)
            {
                    if(val_13 <= val_12)
            {
                    val_12 = val_13 - 1;
            }
            
                val_24 = val_12;
            }
            
            }
            
            }
            
            if(val_13 <= val_24)
            {
                    val_12 = val_21;
                val_13 = val_20;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_23 = mem[aClosed + 8];
                val_23 = aClosed + 8;
                val_20 = val_13;
                val_21 = val_12;
            }
            
            val_22 = val_23 + (val_24 << 3);
            label_16:
            val_22 = val_22 + 16;
            var val_11 = val_22;
            float val_12 = ((aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16) + 4;
            val_11 = val_20 - val_11;
            val_12 = val_21 - val_12;
            UnityEngine.Vector2 val_10 = normalized;
            label_5:
            mem2[0] = ???;
            mem2[0] = ???;
            return new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> GetNormals(System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  23000532);
            if(536878507 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                UnityEngine.Vector2 val_2 = Ferr.PathUtil.GetPointNormal(i:  1257555620, aPath:  0, aClosed:  aPath);
                536878507.Add(item:  new UnityEngine.Vector2() {x = R4, y = R5});
                val_3 = val_3 + 1;
            }
            while(val_3 < 536878507);
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> GetSegmentNormals(System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  23000533);
            if(536878507 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                UnityEngine.Vector2 val_2 = Ferr.PathUtil.GetSegmentNormal(i:  1257675812, aPath:  0, aClosed:  aPath);
                536878507.Add(item:  new UnityEngine.Vector2() {x = R4, y = R5});
                val_3 = val_3 + 1;
            }
            while(val_3 < 536878507);
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> GetNormalsWeighted(System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  23000534);
            if(536878507 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                UnityEngine.Vector2 val_2 = Ferr.PathUtil.GetPointNormalWeighted(i:  1257796004, aPath:  0, aClosed:  aPath);
                536878507.Add(item:  new UnityEngine.Vector2() {x = R4, y = R5});
                val_3 = val_3 + 1;
            }
            while(val_3 < 536878507);
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector3> GetNormals3D(System.Collections.Generic.List<UnityEngine.Vector3> aPath, bool aClosed)
        {
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  23000535);
            if(536878517 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            do
            {
                UnityEngine.Vector3 val_2 = Ferr.PathUtil.GetPointNormal3D(i:  1257916192, aPath:  0, aClosed:  aPath);
                536878517.Add(item:  new UnityEngine.Vector3() {x = R4, y = R5, z = R8});
                val_3 = val_3 + 1;
            }
            while(val_3 < 536878517);
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> NormalsToTangents(System.Collections.Generic.List<UnityEngine.Vector2> aNormals)
        {
            float val_2;
            var val_4;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  R6);
            if(536878507 < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            var val_3 = 16;
            do
            {
                if(536878507 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = mem[3221255787];
                val_2 = mem[3221255791];
                if(0 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_4 = 2621443;
            }
            
                536878507.Add(item:  new UnityEngine.Vector2() {x = val_2, y = -3.673424E-39f});
                val_2 = val_2 + 1;
                val_3 = val_3 + 8;
            }
            while(val_2 < 536878507);
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> TangentsToNormals(System.Collections.Generic.List<UnityEngine.Vector2> aTangents)
        {
            var val_3;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  R6);
            if(536878507 < 1)
            {
                    return;
            }
            
            var val_3 = 0;
            var val_4 = 16;
            do
            {
                if(536878507 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = mem[R6 + 16];
                val_3 = R6 + 16;
                if(0 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_3 = 2621443;
            }
            
                536878507.Add(item:  new UnityEngine.Vector2() {x = (R6 + 16 + 4) ^ 2147483648, y = 3.673424E-39f});
                val_3 = val_3 + 1;
                val_4 = val_4 + 8;
            }
            while(val_3 < 536878507);
        
        }
        public static float GetSegmentLength(int i, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            var val_7;
            var val_9;
            float val_10;
            var val_12;
            val_7 = 23000538;
            if(R7 < 2)
            {
                goto label_2;
            }
            
            int val_1 = i + 1;
            if(aClosed == false)
            {
                goto label_3;
            }
            
            var val_2 = R7 + R7;
            val_9 = R7;
            goto label_4;
            label_2:
            val_10 = 0f;
            return (float)val_10;
            label_3:
            if(val_1 < 0)
            {
                goto label_6;
            }
            
            if(val_1 >= R7)
            {
                    val_9 = R7 - 1;
            }
            
            label_4:
            if(R7 > val_9)
            {
                goto label_8;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            goto label_8;
            label_6:
            val_9 = 0;
            label_8:
            var val_3 = SB + 0;
            val_7 = 0;
            val_12 = mem[(SB + 0) + 16];
            val_12 = (SB + 0) + 16;
            if(R7 != 0)
            {
                    if(aClosed != false)
            {
                    var val_4 = R7 + R7;
                val_12 = val_12;
                val_7 = R7;
            }
            else
            {
                    if(i >= 0)
            {
                    if(R7 <= i)
            {
                    i = R7 - 1;
            }
            
                val_7 = i;
            }
            
            }
            
            }
            
            if(R7 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_12 = val_12;
            }
            
            var val_5 = SB + (val_7 << 3);
            float val_8 = (SB + 0) + 20;
            float val_7 = (SB + ((R7 - 1)) << 3) + 16;
            val_7 = val_12 - val_7;
            val_8 = val_8 - ((SB + ((R7 - 1)) << 3) + 20);
            float val_6 = val_7.magnitude;
            val_10 = 1258276768;
            return (float)val_10;
        }
        public static int GetClosestSegment(System.Collections.Generic.List<UnityEngine.Vector2> aPath, UnityEngine.Vector2 aPoint, bool aClosed)
        {
            var val_3;
            var val_4;
            float val_7;
            float val_8;
            System.Collections.Generic.List<UnityEngine.Vector2> val_10;
            var val_11;
            var val_12;
            float val_14;
            var val_15;
            float val_16;
            var val_17;
            float val_18;
            val_10 = aPath;
            val_11 = 23000539;
            val_12 = 0;
            if(R8 == 1)
            {
                    return (int)val_12;
            }
            
            val_12 = 0;
            if(R8 < 2)
            {
                    return (int)val_12;
            }
            
            bool val_1 = aClosed ^ 1;
            bool val_2 = R8 - val_1;
            if(val_2 < true)
            {
                    return (int)val_12;
            }
            
            val_1 = 0 - val_1;
            val_1 = R8 + val_1;
            val_14 = 3.402823E+38f;
            val_1 = val_1 - 1;
            val_15 = 0;
            val_11 = 16;
            goto label_5;
            label_8:
            val_10 = val_10;
            val_15 = val_4;
            val_16 = mem[aPath + 12];
            val_16 = aPath + 12;
            val_11 = val_3 + 8;
            if(val_2 < 0)
            {
                    val_14 = S0;
            }
            
            label_5:
            val_4 = val_15 + 1;
            if(val_16 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_16 = mem[aPath + 12];
                val_16 = aPath + 12;
            }
            
            val_17 = mem[aPath + 8];
            val_17 = aPath + 8;
            val_3 = val_11;
            if(val_16 <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[aPath + 8];
                val_17 = aPath + 8;
            }
            
            val_17 = val_17 + (val_16 << 3);
            val_18 = mem[(aPath + 8 + (aPath + 12) << 3) + 16];
            val_18 = (aPath + 8 + (aPath + 12) << 3) + 16;
            UnityEngine.Vector2 val_6 = Ferr.PathUtil.GetClosetPointOnLine(aStart:  new UnityEngine.Vector2() {x = 8494360f, y = aPath + 8 + (val_3 + 8)}, aEnd:  new UnityEngine.Vector2() {x = aPath + 8 + (val_3 + 8) + 4, y = val_18}, aPoint:  new UnityEngine.Vector2() {x = val_16, y = aPoint.x}, aClamp:  aPoint.y);
            float val_10 = val_7;
            float val_11 = val_8;
            val_10 = aPoint.x - val_10;
            val_11 = aPoint.y - val_11;
            float val_9 = val_10.SqrMagnitude();
            if(val_16 < 0)
            {
                    val_12 = val_15;
            }
            
            if(val_1 != val_15)
            {
                goto label_8;
            }
            
            return (int)val_12;
        }
        public static int GetClosestPoint(System.Collections.Generic.List<UnityEngine.Vector2> aPoints, UnityEngine.Vector2 aPoint, int aIgnore = -1)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = aIgnore;
            val_3 = aPoint.y;
            val_4 = 0;
            if(0 < 1)
            {
                    return (int)val_4;
            }
            
            if(0 == 1)
            {
                    return (int)val_4;
            }
            
            var val_5 = 0;
            val_3;
            do
            {
                if(0 <= val_5)
            {
                    float val_2 = 0f;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + 16;
                float val_3 = val_2;
                float val_4 = (0 + 16) + 4;
                val_3 = aPoint.x - val_3;
                val_4 = val_3 - val_4;
                float val_1 = val_3.SqrMagnitude();
                val_2 = 16 + 8;
                if(0 < 0)
            {
                    3.402823E+38f = 1258517160;
                val_4 = val_5;
            }
            
                val_5 = val_5 + 1;
            }
            while(val_5 < val_3);
            
            return (int)val_4;
        }
        public static float GetDistanceFromPath(System.Collections.Generic.List<UnityEngine.Vector2> aPath, UnityEngine.Vector2 aPoint, bool aClosed)
        {
            float val_1 = Ferr.PathUtil.GetDistanceFromPathSq(aPath:  aPath, aPoint:  new UnityEngine.Vector2() {x = aPoint.x, y = aPoint.y}, aClosed:  aClosed);
            if(<_TYPE_MAX_)
            {
                    aPath = aPath;
                return (float)aPath;
            }
        
        }
        public static float GetDistanceFromPathSq(System.Collections.Generic.List<UnityEngine.Vector2> aPath, UnityEngine.Vector2 aPoint, bool aClosed)
        {
            var val_3;
            var val_4;
            float val_7;
            float val_8;
            System.Collections.Generic.List<UnityEngine.Vector2> val_10;
            var val_11;
            var val_12;
            float val_13;
            var val_14;
            var val_15;
            val_10 = aPath;
            val_11 = aClosed;
            val_13 = 3.402823E+38f;
            if(23000541 < 2)
            {
                    return (float)1258757536;
            }
            
            bool val_1 = val_11 ^ 1;
            if((23000541 - val_1) < true)
            {
                    return (float)1258757536;
            }
            
            val_1 = 0 - val_1;
            val_1 = 23000541 + val_1;
            val_1 = val_1 - 1;
            val_11 = 0;
            val_14 = 16;
            goto label_4;
            label_7:
            val_10 = val_10;
            val_11 = val_4;
            val_12 = mem[aPath + 12];
            val_12 = aPath + 12;
            val_14 = val_3 + 8;
            label_4:
            val_4 = val_11 + 1;
            if(val_12 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_12 = mem[aPath + 12];
                val_12 = aPath + 12;
            }
            
            val_15 = mem[aPath + 8];
            val_15 = aPath + 8;
            val_3 = val_14;
            if(val_12 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_15 = mem[aPath + 8];
                val_15 = aPath + 8;
            }
            
            val_15 = val_15 + (val_12 << 3);
            UnityEngine.Vector2 val_6 = Ferr.PathUtil.GetClosetPointOnLine(aStart:  new UnityEngine.Vector2() {x = 8854936f, y = aPath + 8 + (val_3 + 8)}, aEnd:  new UnityEngine.Vector2() {x = aPath + 8 + (val_3 + 8) + 4, y = (aPath + 8 + (aPath + 12) << 3) + 16}, aPoint:  new UnityEngine.Vector2() {x = (aPath + 8 + (aPath + 12) << 3) + 20, y = aPoint.x}, aClamp:  aPoint.y);
            float val_10 = val_7;
            float val_11 = val_8;
            val_10 = aPoint.x - val_10;
            val_11 = aPoint.y - val_11;
            float val_9 = val_10.SqrMagnitude();
            if(val_12 < 0)
            {
                    val_13 = 1258757536;
            }
            
            if(val_1 != val_11)
            {
                goto label_7;
            }
            
            return (float)1258757536;
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
        public static UnityEngine.Vector3 GetClosetPointOnLine(UnityEngine.Vector3 aStart, UnityEngine.Vector3 aEnd, UnityEngine.Vector3 aPoint, bool aClamp)
        {
            var val_2;
            float val_10;
            float val_9 = aEnd.z;
            val_9 = val_9 - aStart.z;
            float val_3 = aPoint.y - aStart.y;
            float val_4 = aEnd.y - aStart.y;
            float val_6 = val_9 * val_9;
            bool val_7 = aClamp - aEnd.x;
            float val_8 = aPoint.x - aEnd.x;
            val_10 = (val_9 * (aPoint.z - aStart.z)) / val_6;
            if(val_2 != 0)
            {
                    if(val_2 < 0)
            {
                    val_10 = 0f;
            }
            else
            {
                    if(val_2 > 0)
            {
                    val_10 = 1f;
            }
            
            }
            
            }
            
            mem2[0] = aStart.y;
            mem2[0] = aStart.z;
            mem2[0] = aEnd.x;
            return new UnityEngine.Vector3() {x = aStart.z, y = val_6, z = aStart.y};
        }
        public static float GetDistanceFromLine(UnityEngine.Vector2 aStart, UnityEngine.Vector2 aEnd, UnityEngine.Vector2 aPoint, bool aClamp)
        {
            float val_2;
            float val_3;
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.GetClosetPointOnLine(aStart:  new UnityEngine.Vector2() {x = 9195064f, y = aStart.x}, aEnd:  new UnityEngine.Vector2() {x = aStart.y, y = aEnd.x}, aPoint:  new UnityEngine.Vector2() {x = aEnd.y, y = aPoint.x}, aClamp:  aPoint.y);
            return (float)UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = aPoint.x, y = aPoint.y}, b:  new UnityEngine.Vector2() {x = val_2, y = val_3});
        }
        public static float GetSqDistanceFromLine(UnityEngine.Vector2 aStart, UnityEngine.Vector2 aEnd, UnityEngine.Vector2 aPoint, bool aClamp)
        {
            float val_2;
            float val_3;
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.GetClosetPointOnLine(aStart:  new UnityEngine.Vector2() {x = 9307064f, y = aStart.x}, aEnd:  new UnityEngine.Vector2() {x = aStart.y, y = aEnd.x}, aPoint:  new UnityEngine.Vector2() {x = aEnd.y, y = aPoint.x}, aClamp:  aPoint.y);
            float val_5 = aPoint.y;
            float val_6 = val_3;
            val_5 = val_5 - val_2;
            val_6 = aPoint.x - val_6;
            val_2 = val_5;
            val_3 = val_6;
            return (float)val_3.sqrMagnitude;
        }
        public static UnityEngine.Vector2 LineIntersectionPoint(UnityEngine.Vector2 aLine1Pt1, UnityEngine.Vector2 aLine1Pt2, UnityEngine.Vector2 aLine2Pt1, UnityEngine.Vector2 aLine2Pt2)
        {
            var val_3;
            float val_9;
            float val_9 = aLine1Pt2.x;
            float val_10 = aLine2Pt1.y;
            float val_1 = aLine2Pt1.x - val_9;
            float val_8 = aLine2Pt2.x;
            float val_2 = val_10 - aLine2Pt2.y;
            float val_5 = val_3 - val_8;
            float val_6 = val_1 * val_2;
            if()
            {
                    UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
                return new UnityEngine.Vector2() {x = val_9, y = val_8};
            }
            
            val_8 = val_2 * val_8;
            val_9 = (aLine1Pt1.y - aLine1Pt2.y) * val_9;
            val_10 = val_1 * val_8;
            val_2 = val_2 * val_9;
            val_9 = val_10 / val_6;
            val_2 = val_2 / val_6;
            mem2[0] = val_2;
            mem2[0] = val_9;
            return new UnityEngine.Vector2() {x = val_9, y = val_8};
        }
        public static bool LineSegmentIntersection(UnityEngine.Vector2 aLine1Start, UnityEngine.Vector2 aLine1End, UnityEngine.Vector2 aLine2Start, UnityEngine.Vector2 aLine2End)
        {
            var val_6;
            float val_8 = aLine1Start.y;
            float val_6 = aLine1End.y;
            float val_9 = aLine1Start.x;
            val_6 = val_6 - val_8;
            float val_7 = aLine1End.x;
            val_7 = val_7 - val_9;
            float val_3 = val_6 * (aLine2Start.x - aLine2End.x);
            if()
            {
                    return false;
            }
            
            val_8 = val_8 - aLine2Start.y;
            val_6 = 0;
            float val_5 = val_7 * val_8;
            val_9 = (val_9 - aLine2Start.x) * (aLine2Start.y - aLine2End.y);
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
        public static System.Collections.Generic.List<Ferr.PathUtil.Intersection> GetIntersections(UnityEngine.Vector2 aLineStart, UnityEngine.Vector2 aLineEnd, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed, bool aGetPoints)
        {
            var val_3;
            int val_4;
            float val_10;
            float val_11;
            var val_14;
            int val_15;
            var val_16;
            float val_18;
            float val_19;
            float val_20;
            536878635 = new System.Collections.Generic.List<Intersection>();
            bool val_2 = aClosed ^ 1;
            val_14 = R8 - val_2;
            if(val_14 < true)
            {
                    return;
            }
            
            val_2 = 0 - val_2;
            val_15 = 0;
            val_2 = R8 + val_2;
            val_16 = 16;
            val_2 = val_2 - 1;
            goto label_3;
            label_13:
            val_16 = val_3 + 8;
            val_15 = val_4;
            label_3:
            if(R8 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = val_15 + 1;
            val_3 = val_16;
            if(R8 == 0)
            {
                goto label_5;
            }
            
            if(aClosed == false)
            {
                goto label_6;
            }
            
            var val_6 = R8 + R8;
            val_14 = R8;
            val_19 = val_14;
            goto label_8;
            label_5:
            val_19 = 0;
            goto label_8;
            label_6:
            if(val_5 >= R8)
            {
                    val_19 = R8 - 1;
            }
            
            label_8:
            val_4 = val_5;
            if(R8 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = R7 + (val_19 << 3);
            val_20 = mem[(R7 + ((R8 - 1)) << 3) + 16];
            val_20 = (R7 + ((R8 - 1)) << 3) + 16;
            if((Ferr.PathUtil.LineSegmentIntersection(aLine1Start:  new UnityEngine.Vector2() {x = aLineStart.x, y = aLineStart.y}, aLine1End:  new UnityEngine.Vector2() {x = aLineEnd.x, y = aLineEnd.y}, aLine2Start:  new UnityEngine.Vector2() {x = R7 + (val_3 + 8), y = R7 + (val_3 + 8) + 4}, aLine2End:  new UnityEngine.Vector2() {x = val_20, y = (R7 + ((R8 - 1)) << 3) + 20})) != false)
            {
                    val_19 = 0;
                val_18 = 0;
                if(aGetPoints != false)
            {
                    UnityEngine.Vector2 val_9 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 9647140f, y = aLineStart.x}, aLine1Pt2:  new UnityEngine.Vector2() {x = aLineStart.y, y = aLineEnd.x}, aLine2Pt1:  new UnityEngine.Vector2() {x = aLineEnd.y, y = R7 + (val_3 + 8)}, aLine2Pt2:  new UnityEngine.Vector2() {x = R7 + (val_3 + 8) + 4, y = val_20});
                val_19 = val_10;
                val_18 = val_11;
            }
            
                val_1.Add(item:  new Intersection() {segmentIndex = val_15, point = new UnityEngine.Vector2() {x = val_19, y = val_18}});
            }
            
            if(val_2 != val_15)
            {
                goto label_13;
            }
        
        }
        public static System.Collections.Generic.List<int> GetSegmentsUnder(System.Collections.Generic.List<UnityEngine.Vector2> aPath, UnityEngine.Vector2 aPoint)
        {
            var val_9;
            int val_10;
            var val_11;
            536877987 = new System.Collections.Generic.List<System.Int32>();
            val_9 = 536877987;
            val_10 = 0;
            val_11 = 16;
            goto label_1;
            label_19:
            if(aPoint.x <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = 0 + val_11;
            if(aPoint.x <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = 0 + (aPoint.x << 3);
            if(aPoint.x < 0)
            {
                    aPoint.x = val_10;
            }
            
            if(aPoint.x <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = val_11;
            val_13 = 0 + val_13;
            if(aPoint.x <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = 0 + (aPoint.x << 3);
            if(aPoint.x <= aPoint.x)
            {
                    val_10 = aPoint.x;
            }
            
            if(aPoint.x <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = 0 + 0;
            val_9 = val_9;
            if(aPoint.x <= aPoint.x)
            {
                    if(val_5 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_6 = 0 + (val_10 << 3);
                if(val_5 > val_10)
            {
                    if(val_6 <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_7 = 0 + 0;
                if(val_6 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_8 = 0 + (val_10 << 3);
                if(val_6 <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_9 = 0 + 0;
                if(val_6 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_10 = 0 + (val_10 << 3);
                if(val_6 <= aPoint.x)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_14 = val_14 + 0;
                float val_11 = aPoint.x - ((0 + 0) + 16);
                float val_15 = (0 + 0) + 16;
                val_15 = ((0 + (aPoint.x) << 3) + 16) - val_15;
                val_15 = val_11 / val_15;
                float val_12 = UnityEngine.Mathf.Lerp(a:  val_15, b:  null, t:  val_11);
                if(val_6 < 0)
            {
                    if(val_9 != 0)
            {
                    val_9.Add(item:  0);
            }
            else
            {
                    val_9.Add(item:  0);
            }
            
                val_9.Add(item:  val_10);
            }
            
            }
            
            }
            
            val_10 = 1;
            val_11 = val_11 + 8;
            label_1:
            if((1.401298E-45f) < aPoint.x)
            {
                goto label_19;
            }
        
        }
        public static int CountSegmentsUnder(System.Collections.Generic.List<UnityEngine.Vector2> aPath, UnityEngine.Vector2 aPoint)
        {
            var val_5;
            var val_14 = 0;
            label_18:
            val_5 = 16 + 0;
            goto label_1;
            label_17:
            val_5 = val_5 + 8;
            label_1:
            if(val_14 >= aPoint.x)
            {
                    return 0;
            }
            
            val_14 = val_14 + 1;
            if(aPoint.x <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = 0 + val_5;
            if(aPoint.x <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = 0 + (aPoint.x << 3);
            if(aPoint.x < 0)
            {
                    aPoint.x = val_14;
            }
            
            if(aPoint.x <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = 0 + val_5;
            if(aPoint.x <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = 0 + (aPoint.x << 3);
            if(aPoint.x > aPoint.x)
            {
                    aPoint.x = val_14;
            }
            
            if(aPoint.x <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = 0 + 0;
            if(aPoint.x > aPoint.x)
            {
                goto label_17;
            }
            
            if(val_5 <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = 0 + 0;
            if(val_5 < aPoint.x)
            {
                goto label_17;
            }
            
            if(val_6 <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = 0 + 0;
            if(val_6 <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = 0 + 0;
            if(val_6 <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = 0 + 0;
            if(val_6 <= aPoint.x)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = 0 + 0;
            if(val_6 <= aPoint.x)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + 0;
            float val_11 = aPoint.x - ((0 + 0) + 16);
            float val_16 = (0 + 0) + 16;
            val_16 = ((0 + 0) + 16) - val_16;
            val_16 = val_11 / val_16;
            float val_12 = UnityEngine.Mathf.Lerp(a:  val_16, b:  null, t:  val_11);
            if(val_6 > aPoint.x)
            {
                goto label_17;
            }
            
            var val_13 = val_14 + 1;
            goto label_18;
        }
        public static bool IsInPoly(System.Collections.Generic.List<UnityEngine.Vector2> aPoly, UnityEngine.Vector2 aPoint)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_9;
            val_3 = aPoint.y;
            val_4 = 0;
            label_19:
            val_5 = 16 + 0;
            goto label_1;
            label_18:
            val_5 = val_5 + 8;
            label_1:
            if(val_4 >= 23000545)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            if(23000545 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = 0 + val_5;
            if(23000545 <= 23000545)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = 0 + 184004360;
            if(23000545 < 0)
            {
                    23000545 = val_4;
            }
            
            if(23000545 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = 0 + val_5;
            if(23000545 <= 23000545)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = 0 + 184004360;
            if(23000545 > 23000545)
            {
                    val_3 = val_4;
            }
            
            if(23000545 <= 23000545)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = 0 + 0;
            if(23000545 > 23000545)
            {
                goto label_18;
            }
            
            if(val_5 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = 0 + 0;
            if(val_5 < val_3)
            {
                goto label_18;
            }
            
            if(val_6 <= 23000545)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = 0 + 0;
            if(val_6 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = 0 + 0;
            if(val_6 <= 23000545)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = 0 + 0;
            if(val_6 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = 0 + 0;
            if(val_6 <= 23000545)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + 0;
            float val_11 = aPoint.x - ((0 + 0) + 16);
            float val_15 = (0 + 0) + 16;
            val_15 = ((0 + 0) + 16) - val_15;
            val_15 = val_11 / val_15;
            float val_12 = UnityEngine.Mathf.Lerp(a:  val_15, b:  null, t:  val_11);
            if(val_6 == 23000545)
            {
                goto label_17;
            }
            
            if(val_6 > 23000545)
            {
                goto label_18;
            }
            
            var val_13 = val_4 + 1;
            goto label_19;
            label_3:
            val_9 = 0;
            goto label_20;
            label_17:
            val_9 = 1;
            label_20:
            val_9 = val_9 & 1;
            return (bool)val_9;
        }
        public static Ferr.PathUtil.PathSide IsInPoly(System.Collections.Generic.List<UnityEngine.Vector2> aIsPoly, System.Collections.Generic.List<UnityEngine.Vector2> aInPoly)
        {
            float val_3;
            float val_5;
            float val_9;
            float val_10;
            float val_11;
            var val_12;
            var val_16;
            var val_18;
            val_9 = aIsPoly;
            val_10 = aInPoly;
            val_11 = 0f;
            UnityEngine.Rect val_1 = Ferr.PathUtil.GetBounds(aPoints:  1260034568, aPadding:  new UnityEngine.Vector4() {x = val_10, y = 0f, z = 0f, w = val_11});
            UnityEngine.Rect val_2 = Ferr.PathUtil.GetBounds(aPoints:  1260034568, aPadding:  new UnityEngine.Vector4() {x = val_9, y = 0f, z = 0f, w = val_11});
            bool val_4 = Overlaps(other:  new UnityEngine.Rect() {m_Height = val_3});
            if(val_4 == false)
            {
                    return;
            }
            
            goto label_2;
            label_12:
            if(val_11 >= 1260034568)
            {
                goto label_3;
            }
            
            label_13:
            if(1260034584 <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(1260034584 <= )
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = 16;
            label_10:
            if(0 >= )
            {
                goto label_7;
            }
            
            if( <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = 2621443;
            if( <= )
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_18 = mem[aInPoly + 8];
                val_18 = aInPoly + 8;
            }
            
            var val_6 = val_18 + 1490342080;
            val_10 = val_10;
            val_16 = val_16 + 8;
            val_12 = 1 + 1;
            if((Ferr.PathUtil.LineSegmentIntersection(aLine1Start:  new UnityEngine.Vector2() {x = val_5, y = val_4}, aLine1End:  new UnityEngine.Vector2() {x = mem[1152921511652190936], y = 1.013199E+07f}, aLine2Start:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f}, aLine2End:  new UnityEngine.Vector2() {x = (aInPoly + 8 + 1490342080) + 16})) == false)
            {
                goto label_10;
            }
            
            return;
            label_7:
            val_9 = val_9;
            val_11 = 1;
            label_2:
            if(val_9 == 0)
            {
                goto label_12;
            }
            
            val_12 = mem[aIsPoly + 12];
            val_12 = aIsPoly + 12;
            if(val_11 < val_12)
            {
                goto label_13;
            }
            
            label_3:
            if(val_12 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_8 = Ferr.PathUtil.IsInPoly(aPoly:  val_10, aPoint:  new UnityEngine.Vector2() {x = aIsPoly + 8 + 16, y = R3});
            val_8 = val_8 ^ 1;
        }
        public static UnityEngine.Vector2 GetBezierPoint(int i, float aPercent, System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<Ferr.PointControl> aControls, bool aClosed)
        {
            var val_1;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            if(val_13 == 0)
            {
                goto label_2;
            }
            
            if(val_1 == 0)
            {
                goto label_3;
            }
            
            var val_2 = val_13 + val_13;
            var val_3 = val_13 + 1;
            val_14 = val_13;
            var val_4 = val_13 + val_13;
            val_15 = val_13;
            goto label_8;
            label_2:
            val_15 = 0;
            val_14 = 0;
            goto label_5;
            label_3:
            if(aPath <= 1)
            {
                goto label_6;
            }
            
            if(val_13 <= aPath)
            {
                    val_14 = val_13 - 1;
            }
            
            val_16 = val_14 + 1;
            if(val_16 >= 0)
            {
                goto label_7;
            }
            
            val_15 = 0;
            goto label_8;
            label_6:
            val_14 = 0;
            val_16 = 1;
            label_7:
            if(val_16 >= val_13)
            {
                    val_15 = val_13 - 1;
            }
            
            label_8:
            if(val_13 > val_14)
            {
                goto label_9;
            }
            
            label_5:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            label_9:
            val_17 = mem[aClosed + 8];
            val_17 = aClosed + 8;
            var val_6 = val_17 + 0;
            if(val_13 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[aClosed + 8];
                val_17 = aClosed + 8;
            }
            
            val_17 = val_17 + (val_15 << 3);
            if((val_5 + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = val_5 + 8;
            val_12 = val_12 + 0;
            if((val_5 + 12) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = val_5 + 8;
            val_13 = val_13 + (val_15 << 2);
            float val_14 = (val_5 + 8 + ((aClosed + 12 - 1)) << 2) + 16 + 20;
            float val_15 = (val_5 + 8 + ((aClosed + 12 - 1)) << 2) + 16 + 24;
            val_14 = ((aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16) + val_14;
            val_15 = ((aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 20) + val_15;
            UnityEngine.Vector2 val_9 = Ferr.PathUtil.BezierPoint(p1:  new UnityEngine.Vector2() {x = 1.026038E+07f, y = (aClosed + 8 + 0) + 16}, c1:  new UnityEngine.Vector2() {x = (aClosed + 8 + 0) + 20, y = ((aClosed + 8 + 0) + 16) + ((val_5 + 8 + 0) + 16 + 12)}, c2:  new UnityEngine.Vector2() {x = ((aClosed + 8 + 0) + 20) + ((val_5 + 8 + 0) + 16 + 16), y = val_14}, p2:  new UnityEngine.Vector2() {x = val_15, y = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16}, aPercent:  val_14);
            return new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        }
        public static UnityEngine.Vector2 GetBezierNormal(int i, float aPercent, System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<Ferr.PointControl> aControls, bool aClosed)
        {
            var val_1;
            var val_10;
            var val_11;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            if(val_13 == 0)
            {
                goto label_2;
            }
            
            if(val_1 == 0)
            {
                goto label_3;
            }
            
            var val_2 = val_13 + val_13;
            var val_3 = val_13 + 1;
            val_14 = val_13;
            var val_4 = val_13 + val_13;
            val_15 = val_13;
            goto label_8;
            label_2:
            val_15 = 0;
            val_14 = 0;
            goto label_5;
            label_3:
            if(aPath <= 1)
            {
                goto label_6;
            }
            
            if(val_13 <= aPath)
            {
                    val_14 = val_13 - 1;
            }
            
            val_16 = val_14 + 1;
            if(val_16 >= 0)
            {
                goto label_7;
            }
            
            val_15 = 0;
            goto label_8;
            label_6:
            val_14 = 0;
            val_16 = 1;
            label_7:
            if(val_16 >= val_13)
            {
                    val_15 = val_13 - 1;
            }
            
            label_8:
            if(val_13 > val_14)
            {
                goto label_9;
            }
            
            label_5:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            label_9:
            val_17 = mem[aClosed + 8];
            val_17 = aClosed + 8;
            var val_6 = val_17 + 0;
            if(val_13 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[aClosed + 8];
                val_17 = aClosed + 8;
            }
            
            val_17 = val_17 + (val_15 << 3);
            if((val_5 + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = val_5 + 8;
            val_12 = val_12 + 0;
            if((val_5 + 12) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = val_5 + 8;
            val_13 = val_13 + (val_15 << 2);
            float val_14 = (val_5 + 8 + ((aClosed + 12 - 1)) << 2) + 16 + 20;
            float val_15 = (val_5 + 8 + ((aClosed + 12 - 1)) << 2) + 16 + 24;
            val_14 = ((aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16) + val_14;
            val_15 = ((aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 20) + val_15;
            UnityEngine.Vector2 val_9 = Ferr.PathUtil.BezierTangent(p1:  new UnityEngine.Vector2() {x = 1.038877E+07f, y = (aClosed + 8 + 0) + 16}, c1:  new UnityEngine.Vector2() {x = (aClosed + 8 + 0) + 20, y = ((aClosed + 8 + 0) + 16) + ((val_5 + 8 + 0) + 16 + 12)}, c2:  new UnityEngine.Vector2() {x = ((aClosed + 8 + 0) + 20) + ((val_5 + 8 + 0) + 16 + 16), y = val_14}, p2:  new UnityEngine.Vector2() {x = val_15, y = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16}, aPercent:  val_14);
            var val_16 = val_10;
            val_16 = val_16 ^ 2147483648;
            mem2[0] = val_11;
            mem2[0] = val_16;
            return new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        }
        public static UnityEngine.Vector2 GetBezierTangent(int i, float aPercent, System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<Ferr.PointControl> aControls, bool aClosed)
        {
            var val_1;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            if(val_13 == 0)
            {
                goto label_2;
            }
            
            if(val_1 == 0)
            {
                goto label_3;
            }
            
            var val_2 = val_13 + val_13;
            var val_3 = val_13 + 1;
            val_14 = val_13;
            var val_4 = val_13 + val_13;
            val_15 = val_13;
            goto label_8;
            label_2:
            val_15 = 0;
            val_14 = 0;
            goto label_5;
            label_3:
            if(aPath <= 1)
            {
                goto label_6;
            }
            
            if(val_13 <= aPath)
            {
                    val_14 = val_13 - 1;
            }
            
            val_16 = val_14 + 1;
            if(val_16 >= 0)
            {
                goto label_7;
            }
            
            val_15 = 0;
            goto label_8;
            label_6:
            val_14 = 0;
            val_16 = 1;
            label_7:
            if(val_16 >= val_13)
            {
                    val_15 = val_13 - 1;
            }
            
            label_8:
            if(val_13 > val_14)
            {
                goto label_9;
            }
            
            label_5:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_13 = mem[aClosed + 12];
            val_13 = aClosed + 12;
            label_9:
            val_17 = mem[aClosed + 8];
            val_17 = aClosed + 8;
            var val_6 = val_17 + 0;
            if(val_13 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[aClosed + 8];
                val_17 = aClosed + 8;
            }
            
            val_17 = val_17 + (val_15 << 3);
            if((val_5 + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = val_5 + 8;
            val_12 = val_12 + 0;
            if((val_5 + 12) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = val_5 + 8;
            val_13 = val_13 + (val_15 << 2);
            float val_14 = (val_5 + 8 + ((aClosed + 12 - 1)) << 2) + 16 + 20;
            float val_15 = (val_5 + 8 + ((aClosed + 12 - 1)) << 2) + 16 + 24;
            val_14 = ((aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16) + val_14;
            val_15 = ((aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 20) + val_15;
            UnityEngine.Vector2 val_9 = Ferr.PathUtil.BezierTangent(p1:  new UnityEngine.Vector2() {x = 1.051715E+07f, y = (aClosed + 8 + 0) + 16}, c1:  new UnityEngine.Vector2() {x = (aClosed + 8 + 0) + 20, y = ((aClosed + 8 + 0) + 16) + ((val_5 + 8 + 0) + 16 + 12)}, c2:  new UnityEngine.Vector2() {x = ((aClosed + 8 + 0) + 20) + ((val_5 + 8 + 0) + 16 + 16), y = val_14}, p2:  new UnityEngine.Vector2() {x = val_15, y = (aClosed + 8 + ((aClosed + 12 - 1)) << 3) + 16}, aPercent:  val_14);
            return new UnityEngine.Vector2() {x = val_9.x, y = val_9.y};
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> SmoothBezier(System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<Ferr.PointControl> aControls, float aSplitDistance, bool aClosed)
        {
            float val_8;
            float val_9;
            System.Collections.Generic.List<UnityEngine.Vector2> val_10;
            var val_11;
            float val_12;
            float val_13;
            float val_14;
            float val_15;
            var val_16;
            var val_17;
            val_10 = aPath;
            val_11 = R3;
            val_12 = aClosed;
            val_13 = 23000550;
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = 536878507;
            val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            var val_2 = val_11 ^ 1;
            val_1 = val_1 - val_2;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            label_23:
            val_14 = 0 + 1;
            val_15 = val_2;
            if(val_14 <= 0)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + 0;
            if(((0 + 0) + 16 + 28) != 4)
            {
                goto label_10;
            }
            
            if(((0 + 0) + 16 + 28) <= val_15)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (val_15 << 2);
            val_13 = mem[(0 + ((R3 ^ 1)) << 2) + 16];
            val_13 = (0 + ((R3 ^ 1)) << 2) + 16;
            if(((0 + ((R3 ^ 1)) << 2) + 16 + 28) != 4)
            {
                goto label_10;
            }
            
            if(((0 + ((R3 ^ 1)) << 2) + 16 + 28) <= 0)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + 0;
            val_1.Add(item:  new UnityEngine.Vector2() {x = (0 + 0) + 16, y = val_13});
            goto label_20;
            label_10:
            if(((0 + 0) + 16 + 28) <= 0)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + 0;
            if(val_2 <= 0)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + 0;
            val_13 = mem[(0 + 0) + 16];
            val_13 = (0 + 0) + 16;
            float val_16 = (0 + 0) + 16 + 12;
            float val_15 = (0 + 0) + 16 + 16;
            if(((0 + 0) + 16) <= val_15)
            {
                    var val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = ((0 + 0) + 20) + val_15;
            val_16 = ((0 + 0) + 16) + val_16;
            val_17 = val_17 + (val_15 << 3);
            if(val_2 <= val_15)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_16;
            val_18 = val_18 + (val_15 << 2);
            float val_3 = ((0 + ((R3 ^ 1)) << 3) + 20) + ((0 + ((R3 ^ 1)) << 2) + 16 + 24);
            float val_4 = ((0 + ((R3 ^ 1)) << 3) + 16) + ((0 + ((R3 ^ 1)) << 2) + 16 + 20);
            float val_5 = Ferr.PathUtil.BezierLengthSlow(p1:  new UnityEngine.Vector2() {x = (0 + 0) + 16, y = (0 + 0) + 20}, c1:  new UnityEngine.Vector2() {x = val_12, y = val_15}, c2:  new UnityEngine.Vector2() {x = val_4, y = val_3}, p2:  new UnityEngine.Vector2() {x = (0 + ((R3 ^ 1)) << 3) + 16, y = (0 + ((R3 ^ 1)) << 3) + 20}, count:  4);
            var val_19 = (0 + 0) + 16;
            val_19 = val_19 / val_12;
            int val_6 = UnityEngine.Mathf.Max(a:  1, b:  (int)val_19);
            val_14 = 1.085184E-19f;
            if(val_6 >= 1)
            {
                    var val_21 = 0;
                do
            {
                val_13 = val_15;
                float val_20 = 0f;
                val_20 = val_20 / (float)val_6;
                UnityEngine.Vector2 val_7 = Ferr.PathUtil.BezierPoint(p1:  new UnityEngine.Vector2() {x = 1.064554E+07f, y = (0 + 0) + 16}, c1:  new UnityEngine.Vector2() {x = (0 + 0) + 20, y = val_12}, c2:  new UnityEngine.Vector2() {x = val_15, y = val_4}, p2:  new UnityEngine.Vector2() {x = val_3, y = (0 + ((R3 ^ 1)) << 3) + 16}, aPercent:  val_20);
                val_15 = val_8;
                if(val_14 == 0)
            {
                    val_14 = 1.085184E-19f;
            }
            
                val_14.Add(item:  new UnityEngine.Vector2() {x = val_15, y = val_9});
                val_21 = val_21 + 1;
                val_12 = val_12;
            }
            while(val_6 != val_21);
            
            }
            
            label_20:
            val_11 = val_14;
            val_10 = val_10;
            if(val_11 != val_1)
            {
                goto label_23;
            }
            
            label_2:
            if(val_11 != 0)
            {
                    return;
            }
            
            if(val_10 != 0)
            {
                    val_16 = mem[aPath + 12];
                val_16 = aPath + 12;
                val_17 = val_16;
            }
            else
            {
                    val_17 = mem[aPath + 12];
                val_17 = aPath + 12;
                val_16 = mem[aPath + 12];
                val_16 = aPath + 12;
            }
            
            val_17 = val_17 - 1;
            if(val_16 <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_22 = aPath + 8;
            val_12 = val_1;
            val_22 = val_22 + (val_17 << 3);
            val_12.Add(item:  new UnityEngine.Vector2() {x = (aPath + 8 + ((aPath + 12 - 1)) << 3) + 16, y = val_13});
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> SmoothBezierNormals(System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<Ferr.PointControl> aControls, float aSplitDistance, bool aClosed)
        {
            var val_8;
            float val_9;
            System.Collections.Generic.List<UnityEngine.Vector2> val_18;
            System.Collections.Generic.List<Ferr.PointControl> val_19;
            System.Collections.Generic.List<Ferr.PointControl> val_20;
            float val_22;
            float val_23;
            var val_24;
            var val_25;
            var val_26;
            val_18 = aPath;
            val_19 = R3;
            val_20 = aClosed;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            var val_2 = val_19 ^ 1;
            536878507 = 536878507 - val_2;
            if(536878507 < 1)
            {
                goto label_2;
            }
            
            label_23:
            if(val_18 != 0)
            {
                    var val_3 = 0 + 1;
                val_22 = aControls;
            }
            else
            {
                    val_22 = val_2;
            }
            
            val_20 = aControls;
            if(aControls <= 0)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + 0;
            if((aControls + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_17 = aControls + 8;
            val_17 = val_17 + 0;
            if(val_17 <= val_22)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + (val_22 << 3);
            if((aControls + 12) <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = aControls + 8;
            val_19 = val_19 + (val_22 << 2);
            float val_20 = (0 + 0) + 20;
            float val_21 = (0 + 0) + 16;
            if((aControls + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_22 = aControls + 8;
            val_20 = val_20 + ((aControls + 8 + 0) + 16 + 16);
            val_21 = val_21 + ((aControls + 8 + 0) + 16 + 12);
            float val_5 = ((0 + ((R3 ^ 1)) << 3) + 20) + ((aControls + 8 + ((R3 ^ 1)) << 2) + 16 + 24);
            val_22 = val_22 + 0;
            float val_6 = ((0 + ((R3 ^ 1)) << 3) + 16) + ((aControls + 8 + ((R3 ^ 1)) << 2) + 16 + 20);
            val_23 = val_20;
            if(((aControls + 8 + 0) + 16 + 28) != 4)
            {
                goto label_17;
            }
            
            if((aControls + 12) <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_23 = aControls + 8;
            val_23 = val_23 + (val_22 << 2);
            if(((aControls + 8 + ((R3 ^ 1)) << 2) + 16 + 28) != 4)
            {
                goto label_17;
            }
            
            UnityEngine.Vector2 val_7 = Ferr.PathUtil.BezierTangent(p1:  new UnityEngine.Vector2() {x = 1.077392E+07f, y = (0 + 0) + 16}, c1:  new UnityEngine.Vector2() {x = (0 + 0) + 20, y = val_21}, c2:  new UnityEngine.Vector2() {x = val_23, y = val_6}, p2:  new UnityEngine.Vector2() {x = val_5, y = (0 + ((R3 ^ 1)) << 3) + 16}, aPercent:  aSplitDistance);
            val_20 = val_8 ^ 2147483648;
            val_1.Add(item:  new UnityEngine.Vector2() {x = val_9, y = val_20});
            goto label_20;
            label_17:
            float val_10 = Ferr.PathUtil.BezierLengthSlow(p1:  new UnityEngine.Vector2() {x = (0 + 0) + 16, y = (0 + 0) + 20}, c1:  new UnityEngine.Vector2() {x = val_21, y = val_23}, c2:  new UnityEngine.Vector2() {x = val_6, y = val_5}, p2:  new UnityEngine.Vector2() {x = (0 + ((R3 ^ 1)) << 3) + 16, y = (0 + ((R3 ^ 1)) << 3) + 20}, count:  4);
            var val_24 = (0 + 0) + 16;
            val_24 = val_24 / val_20;
            int val_11 = UnityEngine.Mathf.Max(a:  1, b:  (int)val_24);
            val_23 = 1.085184E-19f;
            if(val_11 >= 1)
            {
                    val_20 = val_11;
                var val_26 = 0;
                do
            {
                float val_25 = 0f;
                val_25 = val_25 / (float)val_20;
                UnityEngine.Vector2 val_12 = Ferr.PathUtil.BezierTangent(p1:  new UnityEngine.Vector2() {x = 1.077392E+07f, y = (0 + 0) + 16}, c1:  new UnityEngine.Vector2() {x = (0 + 0) + 20, y = val_21}, c2:  new UnityEngine.Vector2() {x = val_23, y = val_6}, p2:  new UnityEngine.Vector2() {x = val_5, y = (0 + ((R3 ^ 1)) << 3) + 16}, aPercent:  val_25);
                val_22 = val_8 ^ 2147483648;
                if(val_23 == 0)
            {
                    val_23 = 1.085184E-19f;
            }
            
                val_23.Add(item:  new UnityEngine.Vector2() {x = val_9, y = val_22});
                val_26 = val_26 + 1;
            }
            while(val_20 != val_26);
            
            }
            
            label_20:
            val_19 = 0 + 1;
            val_18 = val_18;
            if(val_19 < 536878507)
            {
                goto label_23;
            }
            
            label_2:
            if(val_19 != 0)
            {
                    return;
            }
            
            val_19 = aControls;
            if(val_18 != 0)
            {
                    val_24 = mem[aPath + 12];
                val_24 = aPath + 12;
                val_25 = val_24;
            }
            else
            {
                    val_25 = mem[aPath + 12];
                val_25 = aPath + 12;
                val_24 = mem[aPath + 12];
                val_24 = aPath + 12;
            }
            
            val_25 = val_25 - 2;
            if(val_24 <= val_25)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_24 = mem[aPath + 12];
                val_24 = aPath + 12;
            }
            
            var val_27 = aPath + 8;
            val_27 = val_27 + (val_25 << 3);
            val_22 = mem[(aPath + 8 + ((aPath + 12 - 2)) << 3) + 16];
            val_22 = (aPath + 8 + ((aPath + 12 - 2)) << 3) + 16;
            var val_13 = val_24 - 2;
            if((aControls + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_28 = aControls + 8;
            val_28 = val_28 + (val_13 << 2);
            float val_30 = (aControls + 8 + ((aPath + 12 - 2)) << 2) + 16 + 12;
            float val_29 = (aControls + 8 + ((aPath + 12 - 2)) << 2) + 16 + 16;
            var val_14 = (aPath + 12) - 1;
            val_26 = val_14;
            if((aPath + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_26 = (aPath + 12) - 1;
            }
            
            var val_31 = aPath + 8;
            val_29 = ((aPath + 8 + ((aPath + 12 - 2)) << 3) + 20) + val_29;
            val_30 = val_22 + val_30;
            val_31 = val_31 + (val_14 << 3);
            val_18 = mem[(aPath + 8 + ((aPath + 12 - 1)) << 3) + 16];
            val_18 = (aPath + 8 + ((aPath + 12 - 1)) << 3) + 16;
            if((aControls + 12) <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_32 = aControls + 8;
            val_32 = val_32 + (val_26 << 2);
            float val_33 = (aControls + 8 + ((aPath + 12 - 1)) << 2) + 16 + 20;
            float val_34 = (aControls + 8 + ((aPath + 12 - 1)) << 2) + 16 + 24;
            val_33 = val_18 + val_33;
            val_34 = 536878507 + val_34;
            UnityEngine.Vector2 val_15 = Ferr.PathUtil.BezierTangent(p1:  new UnityEngine.Vector2() {x = 1.077392E+07f, y = val_22}, c1:  new UnityEngine.Vector2() {x = (aPath + 8 + ((aPath + 12 - 2)) << 3) + 20, y = val_30}, c2:  new UnityEngine.Vector2() {x = val_29, y = val_33}, p2:  new UnityEngine.Vector2() {x = val_34, y = val_18}, aPercent:  val_33);
            val_20 = val_8 ^ 2147483648;
            val_1.Add(item:  new UnityEngine.Vector2() {x = val_9, y = val_20});
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> SmoothBezierTangents(System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<Ferr.PointControl> aControls, float aSplitDistance, bool aClosed)
        {
            float val_7;
            float val_8;
            System.Collections.Generic.List<UnityEngine.Vector2> val_10;
            System.Collections.Generic.List<Ferr.PointControl> val_11;
            float val_12;
            float val_14;
            float val_15;
            float val_16;
            var val_17;
            var val_18;
            var val_19;
            val_10 = aPath;
            val_11 = aControls;
            val_12 = 23000552;
            System.Collections.Generic.List<UnityEngine.Vector2> val_1 = 536878507;
            val_1 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            var val_12 = ???;
            val_12 = val_12 ^ 1;
            val_1 = val_1 - val_12;
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            label_23:
            if(val_10 != 0)
            {
                    var val_2 = 0 + 1;
                val_14 = R7;
            }
            else
            {
                    val_14 = val_12;
            }
            
            if(R7 <= 0)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + 0;
            if(((0 + 0) + 20) <= 0)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + 0;
            if(val_14 <= val_14)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + (val_14 << 3);
            if(((0 + 0) + 16) <= val_14)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + (val_14 << 2);
            float val_17 = (0 + 0) + 20;
            float val_18 = (0 + 0) + 16;
            if(((0 + ((??? ^ 1)) << 3) + 16) <= 0)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + ((0 + 0) + 16 + 16);
            val_18 = val_18 + ((0 + 0) + 16 + 12);
            val_19 = val_19 + 0;
            float val_5 = ((0 + ((??? ^ 1)) << 3) + 16) + ((0 + ((??? ^ 1)) << 2) + 16 + 20);
            val_12 = val_17;
            val_15 = val_18;
            val_16 = ((0 + ((??? ^ 1)) << 3) + 20) + ((0 + ((??? ^ 1)) << 2) + 16 + 24);
            if(((0 + 0) + 16 + 28) != 4)
            {
                goto label_17;
            }
            
            if(((0 + 0) + 16 + 28) <= val_14)
            {
                    var val_20 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_20 = val_20 + (val_14 << 2);
            if(((0 + ((??? ^ 1)) << 2) + 16 + 28) != 4)
            {
                goto label_17;
            }
            
            UnityEngine.Vector2 val_6 = Ferr.PathUtil.BezierTangent(p1:  new UnityEngine.Vector2() {x = 1.09023E+07f, y = (0 + 0) + 16}, c1:  new UnityEngine.Vector2() {x = (0 + 0) + 20, y = val_15}, c2:  new UnityEngine.Vector2() {x = val_12, y = val_5}, p2:  new UnityEngine.Vector2() {x = val_16, y = (0 + ((??? ^ 1)) << 3) + 16}, aPercent:  aSplitDistance);
            val_15 = val_8;
            val_1.Add(item:  new UnityEngine.Vector2() {x = val_7, y = val_15});
            goto label_20;
            label_17:
            float val_9 = Ferr.PathUtil.BezierLengthSlow(p1:  new UnityEngine.Vector2() {x = (0 + 0) + 16, y = (0 + 0) + 20}, c1:  new UnityEngine.Vector2() {x = val_15, y = val_12}, c2:  new UnityEngine.Vector2() {x = val_5, y = val_16}, p2:  new UnityEngine.Vector2() {x = (0 + ((??? ^ 1)) << 3) + 16, y = (0 + ((??? ^ 1)) << 3) + 20}, count:  4);
            var val_21 = (0 + 0) + 16;
            val_21 = val_21 / aClosed;
            int val_10 = UnityEngine.Mathf.Max(a:  1, b:  (int)val_21);
            val_16 = 1.085184E-19f;
            if(val_10 >= 1)
            {
                    var val_23 = 0;
                do
            {
                float val_22 = 0f;
                val_22 = val_22 / (float)val_10;
                UnityEngine.Vector2 val_11 = Ferr.PathUtil.BezierTangent(p1:  new UnityEngine.Vector2() {x = 1.09023E+07f, y = (0 + 0) + 16}, c1:  new UnityEngine.Vector2() {x = (0 + 0) + 20, y = val_15}, c2:  new UnityEngine.Vector2() {x = val_12, y = val_5}, p2:  new UnityEngine.Vector2() {x = val_16, y = (0 + ((??? ^ 1)) << 3) + 16}, aPercent:  val_22);
                val_14 = val_8;
                if(val_16 == 0)
            {
                    val_16 = 1.085184E-19f;
            }
            
                val_16.Add(item:  new UnityEngine.Vector2() {x = val_7, y = val_14});
                val_23 = val_23 + 1;
                val_15 = val_15;
                val_12 = val_12;
            }
            while(val_10 != val_23);
            
            }
            
            label_20:
            val_10 = val_10;
            val_11 = val_11;
            if((0 + 1) < val_1)
            {
                goto label_23;
            }
            
            label_2:
            val_17 = val_1;
            if((???) != 0)
            {
                    return;
            }
            
            if(val_10 != 0)
            {
                    val_18 = mem[aPath + 12];
                val_18 = aPath + 12;
                val_19 = val_18;
            }
            else
            {
                    val_19 = mem[aPath + 12];
                val_19 = aPath + 12;
                val_17 = val_1;
                val_18 = mem[aPath + 12];
                val_18 = aPath + 12;
            }
            
            val_19 = val_19 - 1;
            if(val_18 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = val_1;
            }
            
            var val_24 = aPath + 8;
            val_24 = val_24 + (val_19 << 3);
            val_1.Add(item:  new UnityEngine.Vector2() {x = (aPath + 8 + ((aPath + 12 - 1)) << 3) + 16, y = val_12});
        }
        public static UnityEngine.Vector2 BezierPoint(UnityEngine.Vector2 p1, UnityEngine.Vector2 c1, UnityEngine.Vector2 c2, UnityEngine.Vector2 p2, float aPercent)
        {
            var val_1;
            float val_5;
            float val_6 = 1f;
            var val_8 = val_1;
            float val_7 = 3f;
            float val_2 = val_8 * val_8;
            val_6 = val_6 - val_8;
            float val_3 = val_6 * val_6;
            float val_4 = val_3 * val_7;
            val_7 = val_6 * val_7;
            val_6 = val_6 * val_3;
            val_4 = val_4 * val_8;
            val_7 = val_2 * val_7;
            val_8 = val_2 * val_8;
            val_3 = val_4 * c2.x;
            val_4 = val_4 * c1.y;
            mem2[0] = val_3;
            mem2[0] = val_4;
            return new UnityEngine.Vector2() {x = val_5};
        }
        public static UnityEngine.Vector2 BezierTangent(UnityEngine.Vector2 p1, UnityEngine.Vector2 c1, UnityEngine.Vector2 c2, UnityEngine.Vector2 p2, float aPercent)
        {
            var val_1;
            float val_7 = 6f;
            float val_8 = 9f;
            float val_2 = val_1 * val_1;
            val_7 = val_1 * val_7;
            val_8 = val_2 * val_8;
            val_2 = val_2 * 3f;
            float val_3 = val_7 - val_8;
            float val_9 = c2.y;
            val_7 = val_7 - val_2;
            val_9 = val_3 * val_9;
            float val_4 = val_3 * p2.x;
            val_8 = val_8 + 3f;
            val_7 = val_7 + (-3f);
            UnityEngine.Vector2 val_6 = normalized;
            return new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        public static UnityEngine.Vector2 BezierNormal(UnityEngine.Vector2 p1, UnityEngine.Vector2 c1, UnityEngine.Vector2 c2, UnityEngine.Vector2 p2, float aPercent)
        {
            float val_1;
            var val_4;
            var val_5;
            UnityEngine.Vector2 val_3 = Ferr.PathUtil.BezierTangent(p1:  new UnityEngine.Vector2() {x = 1.124651E+07f, y = p1.y}, c1:  new UnityEngine.Vector2() {x = c1.x, y = c1.y}, c2:  new UnityEngine.Vector2() {x = c2.x, y = c2.y}, p2:  new UnityEngine.Vector2() {x = p2.x, y = p2.y}, aPercent:  val_1);
            var val_6 = val_4;
            val_6 = val_6 ^ 2147483648;
            mem2[0] = val_5;
            mem2[0] = val_6;
            return new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
        }
        public static float BezierLength(UnityEngine.Vector2 p1, UnityEngine.Vector2 c1, UnityEngine.Vector2 c2, UnityEngine.Vector2 p2)
        {
            return (float)Ferr.PathUtil.BezierLengthSlow(p1:  new UnityEngine.Vector2() {x = p1.x, y = p1.y}, c1:  new UnityEngine.Vector2() {x = c1.x, y = c1.y}, c2:  new UnityEngine.Vector2() {x = c2.x, y = c2.y}, p2:  new UnityEngine.Vector2() {x = p2.x, y = p2.y}, count:  4);
        }
        public static float BezierLengthSlow(UnityEngine.Vector2 p1, UnityEngine.Vector2 c1, UnityEngine.Vector2 c2, UnityEngine.Vector2 p2, int count = 200)
        {
            float val_3;
            float val_4;
            float val_6;
            if(count >= 2)
            {
                    var val_7 = 1;
                do
            {
                float val_6 = 1f;
                val_6 = val_6 / ((float)count + (-1f));
                UnityEngine.Vector2 val_2 = Ferr.PathUtil.BezierPoint(p1:  new UnityEngine.Vector2() {x = 1.14705E+07f, y = p1.x}, c1:  new UnityEngine.Vector2() {x = p1.y, y = c1.x}, c2:  new UnityEngine.Vector2() {x = c1.y, y = c2.x}, p2:  new UnityEngine.Vector2() {x = c2.y, y = p2.x}, aPercent:  val_6);
                float val_5 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = p1.x, y = p1.y}, b:  new UnityEngine.Vector2() {x = val_3, y = val_4});
                val_7 = val_7 + 1;
                val_6 = 0f + p1.x;
            }
            while(count != val_7);
            
                return (float)S0;
            }
            
            val_6 = 0f;
            return (float)S0;
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> IndicesToPath(System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<int> aIndices)
        {
            var val_2;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  R7);
            if(536878507 < 1)
            {
                    return;
            }
            
            do
            {
                if(536878507 <= 0)
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
                536878507.Add(item:  new UnityEngine.Vector2() {x = (0 + ((0 + 0) + 16) << 3) + 16, y = R5});
                val_2 = 0 + 1;
            }
            while(val_2 < 536878507);
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> SimplifyPath(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aTolerance)
        {
            var val_9;
            float val_10;
            System.Collections.Generic.IEnumerable<T> val_11;
            float val_14;
            System.Collections.Generic.IEnumerable<T> val_15;
            var val_16;
            System.Collections.Generic.List<UnityEngine.Vector2> val_17;
            var val_18;
            var val_19;
            val_11 = aPath;
            if(0 <= 2)
            {
                goto label_2;
            }
            
            var val_1 = 16 + 0;
            var val_2 = 0 + 1;
            label_6:
            var val_3 = val_2 - 2;
            if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = 6.018898E-36f;
            if(0 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = val_1 - 8;
            val_2 = val_2 - 1;
            if(val_3 < 2)
            {
                goto label_5;
            }
            
            var val_5 = 16 + val_1;
            uint val_19 = 83886592;
            var val_20 = (16 + (16 + 0)) + -8;
            val_19 = val_19 - ((16 + (16 + 0)) + -4);
            val_20 = 22965384 - val_20;
            val_19 = val_19 * val_19;
            if(val_3 < 0)
            {
                goto label_6;
            }
            
            label_5:
            var val_6 = val_2 - 1;
            if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_11;
            if(val_6 < 2)
            {
                goto label_9;
            }
            
            do
            {
                var val_7 = 2 - 1;
                if((16 + ((16 + 0) - 8) + 4) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_15 = val_15;
                UnityEngine.Vector2 val_8 = Ferr.PathUtil.GetClosetPointOnLine(aStart:  new UnityEngine.Vector2() {x = 1.171497E+07f, y = 4.085283E-38f}, aEnd:  new UnityEngine.Vector2() {x = ???, y = 16 + ((16 + 0) - 8)}, aPoint:  new UnityEngine.Vector2() {x = 16 + ((16 + 0) - 8) + 4, y = 0f}, aClamp:  true);
                uint val_21 = 52;
                float val_22 = val_10;
                val_21 = val_9 - val_21;
                val_22 = val_22 - 0;
                float val_11 = val_22.sqrMagnitude;
                val_14 = 24 + 8;
                val_11 = 2 + 1;
                if((16 + ((16 + 0) - 8) + 4) > val_7)
            {
                    0f = 1261617552;
                val_16 = val_7;
            }
            
            }
            while(val_2 != val_11);
            
            goto label_12;
            label_2:
            val_17 = 536878507;
            val_17 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  val_11);
            return;
            label_9:
            val_16 = 0;
            label_12:
            val_17 = 536878507;
            val_17 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            if(val_16 == 1)
            {
                goto label_15;
            }
            
            float val_14 = R1 * R1;
            if(val_16 <= 1)
            {
                goto label_15;
            }
            
            val_18 = 22739688;
            System.Collections.Generic.List<T> val_16 = val_15.GetRange(index:  0, count:  val_16 + 1);
            val_19 = R1;
            System.Collections.Generic.List<T> val_18 = val_15.GetRange(index:  0, count:  val_15 - val_16);
            val_15.RemoveAt(index:  0);
            if(val_17 == 0)
            {
                goto label_19;
            }
            
            val_17.AddRange(collection:  val_15);
            goto label_20;
            label_15:
            if(val_17 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = 2621443;
            val_19 = 22739676;
            val_17.Add(item:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 6.018898E-36f});
            if(val_17 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17.Add(item:  new UnityEngine.Vector2() {x = 0 + ((16 + 0) - 8), y = 0 + ((16 + 0) - 8) + 4});
            return;
            label_19:
            val_17.AddRange(collection:  val_15);
            label_20:
            val_17.AddRange(collection:  val_15);
        }
        public static System.Collections.Generic.List<UnityEngine.Vector3> To3D(System.Collections.Generic.List<UnityEngine.Vector2> aPath, Ferr.PathUtil.ConvertOptions aOptions = 0, float aAxisValue = 0)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            float val_6;
            float val_7;
            var val_8;
            var val_9;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_2 = 0;
            val_3 = 16;
            goto label_1;
            label_14:
            if(aOptions == 1)
            {
                goto label_2;
            }
            
            if(aOptions != 0)
            {
                goto label_3;
            }
            
            if(536878517 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= val_2)
            {
                goto label_5;
            }
            
            val_4 = mem[3221255895];
            goto label_6;
            label_2:
            if(536878517 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= val_2)
            {
                goto label_8;
            }
            
            val_5 = mem[3221255895];
            goto label_9;
            label_5:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_4 = 1;
            label_6:
            val_6 = mem[3221255891];
            val_7 = val_4;
            val_8 = 22739752;
            val_9 = ???;
            goto label_11;
            label_8:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_5 = 1;
            label_9:
            val_6 = mem[3221255891];
            val_9 = val_5;
            val_8 = 22739752;
            val_7 = ???;
            label_11:
            536878517.Add(item:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = 1.401298E-45f});
            label_3:
            val_3 = 24;
            val_2 = 1;
            label_1:
            if(val_2 < 536878517)
            {
                goto label_14;
            }
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector3> To3D(System.Collections.Generic.List<UnityEngine.Vector2> aPath, UnityEngine.Matrix4x4 aMat, Ferr.PathUtil.ConvertOptions aOptions = 0, float aAxisValue = 0)
        {
            float val_1;
            float val_4;
            float val_5;
            float val_6;
            System.Collections.Generic.List<UnityEngine.Vector2> val_8;
            float val_9;
            float val_10;
            System.Collections.Generic.List<UnityEngine.Vector3> val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_8 = aPath;
            val_9 = aMat.m13;
            val_10 = aMat.m23;
            val_11 = 536878517;
            val_11 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            val_12 = 16;
            val_13 = 0;
            goto label_1;
            label_14:
            if(aOptions == 1)
            {
                goto label_2;
            }
            
            if(aOptions != 0)
            {
                goto label_11;
            }
            
            if(val_1 <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= val_13)
            {
                goto label_5;
            }
            
            val_14 = mem[3221255895];
            goto label_6;
            label_2:
            if(val_1 <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= val_13)
            {
                goto label_8;
            }
            
            val_15 = mem[3221255895];
            goto label_9;
            label_5:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_14 = 1;
            label_6:
            UnityEngine.Vector3 val_3 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 1.196759E+07f, y = mem[3221255891], z = 1.401298E-45f});
            val_11 = val_11;
            val_10 = val_4;
            val_9 = val_5;
            val_11.Add(item:  new UnityEngine.Vector3() {x = val_10, y = val_9, z = val_6});
            val_8 = val_8;
            goto label_11;
            label_8:
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_15 = 1;
            label_9:
            UnityEngine.Vector3 val_7 = MultiplyPoint3x4(point:  new UnityEngine.Vector3() {x = 1.196759E+07f, y = mem[3221255891], z = val_1});
            val_9 = val_4;
            val_10 = val_5;
            val_11.Add(item:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = val_6});
            label_11:
            val_12 = 24;
            val_13 = 1;
            label_1:
            if(val_13 < val_11)
            {
                goto label_14;
            }
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> Reverse(System.Collections.Generic.List<UnityEngine.Vector2> aPath)
        {
            float val_4;
            var val_6;
            var val_7;
            int val_2 = R6;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  val_2);
            val_2 = 536878507 - 1;
            if(val_2 < 0)
            {
                    return;
            }
            
            val_6 = 8 + (536878507 << 3);
            val_7 = 536878507 - 2;
            goto label_4;
            label_7:
            val_6 = val_6 - 8;
            val_7 = val_7 - 1;
            label_4:
            if(536878507 <= 8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = mem[0 + ((8 + (536878507..ctor(capacity:  R6)) << 3) - 8)];
            val_4 = 0 + ((8 + (536878507..ctor(capacity:  R6)) << 3) - 8);
            536878507.Add(item:  new UnityEngine.Vector2() {x = val_4, y = 0 + ((8 + (536878507..ctor(capacity:  R6)) << 3) - 8) + 4});
            if(val_7 >= 0)
            {
                goto label_7;
            }
        
        }
        public static void Reverse<T>(ref System.Collections.Generic.List<T> aPath)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = __RuntimeMethodHiddenParam;
            val_5 = 1152921510163972960;
            val_6 = 0;
            val_7 = 0;
            goto label_0;
            label_7:
            val_5 = aPath;
            val_6 = val_6 + 1;
            val_4 = val_4;
            val_7 = -1;
            label_0:
            var val_4 = val_5;
            val_4 = val_4 + (val_4 >> 31);
            if(val_6 < (val_4 >> 1))
            {
                goto label_7;
            }
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> Subdivide(System.Collections.Generic.List<UnityEngine.Vector2> aPath, int aCuts, bool aClosed)
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_6;
            bool val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_6 = aPath;
            val_7 = aClosed;
            val_8 = aCuts;
            if(val_6 != 0)
            {
                    val_10 = aCuts;
            }
            else
            {
                    val_10 = 0;
                val_9 = 0;
            }
            
            val_9 = val_9 - 1;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  0);
            bool val_6 = false;
            val_6 = val_6 - val_7 ^ 1;
            if(val_6 >= true)
            {
                    val_8 = val_8 + 1;
                do
            {
                if(val_6 != 0)
            {
                    val_11 = 0 + 1;
                val_12 = 0;
                val_13 = val_12;
            }
            else
            {
                    val_11 = 0 + 1;
                val_13 = 0;
                val_12 = 0;
            }
            
                if(val_12 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_7 = aPath + 8;
                val_7 = val_7 + 0;
                if(0 <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(val_8 >= 1)
            {
                    var val_10 = 0;
                var val_8 = aPath + 8;
                val_8 = val_8 + 0;
                System.Collections.Generic.List<UnityEngine.Vector2> val_3 = val_6 - ((aPath + 8 + 0) + 20);
                float val_4 = ((aPath + 8 + 0) + 16) - ((aPath + 8 + 0) + 16);
                do
            {
                float val_9 = 0f;
                val_9 = val_9 / (float)val_8;
                float val_5 = UnityEngine.Mathf.Clamp01(value:  val_9);
                536878507.Add(item:  new UnityEngine.Vector2() {x = (aPath + 8 + 0) + 16, y = (aPath + 8 + 0) + 20});
                val_10 = val_10 + 1;
            }
            while(val_8 != val_10);
            
            }
            
                val_7 = val_11;
                val_6 = val_6;
            }
            while(val_11 < val_6);
            
            }
            
            if(val_7 == true)
            {
                    return;
            }
            
            if(val_6 != 0)
            {
                    val_14 = 0;
                val_15 = val_14;
            }
            else
            {
                    val_7 = 12;
                val_15 = 0;
                val_14 = 0;
            }
            
            if(val_14 <= (-1))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_11 = aPath + 8;
            val_11 = val_11 + 4294967288;
            536878507.Add(item:  new UnityEngine.Vector2() {x = (aPath + 8 + 4294967288) + 16, y = val_6});
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> SubdivideDistance(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aCutDistance, bool aClosed)
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_8;
            float val_9;
            var val_10;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_8 = aPath;
            val_9 = R2;
            val_10 = aClosed;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  23000559);
            var val_2 = val_9 ^ 1;
            536878507 = 536878507 - val_2;
            if(536878507 >= 1)
            {
                    do
            {
                if(val_8 != 0)
            {
                    var val_3 = 0 + 1;
                val_12 = 23000559;
            }
            else
            {
                    val_12 = val_2;
            }
            
                if(23000559 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_5 = 0 + 0;
                if(23000559 <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_13 = mem[aPath + 8];
                val_13 = aPath + 8;
            }
            
                val_13 = val_13 + (val_12 << 3);
                val_9 = mem[(aPath + 8 + ((R2 ^ 1)) << 3) + 16];
                val_9 = (aPath + 8 + ((R2 ^ 1)) << 3) + 16;
                float val_6 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = (0 + 0) + 16, y = (0 + 0) + 20}, b:  new UnityEngine.Vector2() {x = val_9, y = (aPath + 8 + ((R2 ^ 1)) << 3) + 20});
                float val_11 = (0 + 0) + 16;
                val_11 = val_10 / val_11;
                float val_7 = UnityEngine.Mathf.Max(a:  val_11, b:  null);
                if((int)1065353216 >= 1)
            {
                    var val_13 = 0;
                float val_8 = ((aPath + 8 + ((R2 ^ 1)) << 3) + 20) - ((0 + 0) + 20);
                float val_9 = val_9 - ((0 + 0) + 16);
                do
            {
                float val_12 = 0f;
                val_12 = val_12 / (float)(int)1065353216;
                float val_10 = UnityEngine.Mathf.Clamp01(value:  val_12);
                val_9 = (0 + 0) + 16;
                536878507.Add(item:  new UnityEngine.Vector2() {x = val_9, y = (0 + 0) + 20});
                val_13 = val_13 + 1;
            }
            while((int)1065353216 != val_13);
            
            }
            
                val_10 = 0 + 1;
                val_8 = val_8;
            }
            while(val_10 < 536878507);
            
            }
            
            if(val_9 != 0)
            {
                    return;
            }
            
            if(val_8 != 0)
            {
                    val_14 = mem[aPath + 12];
                val_14 = aPath + 12;
                val_15 = val_14;
            }
            else
            {
                    val_15 = mem[aPath + 12];
                val_15 = aPath + 12;
                val_14 = mem[aPath + 12];
                val_14 = aPath + 12;
            }
            
            val_15 = val_15 - 1;
            if(val_14 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_14 = aPath + 8;
            val_14 = val_14 + (val_15 << 3);
            536878507.Add(item:  new UnityEngine.Vector2() {x = (aPath + 8 + ((aPath + 12 - 1)) << 3) + 16, y = val_8});
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> SubdivideEnsureDistance(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aMaxDistance, bool aClosed)
        {
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  aPath);
            Ferr.PathUtil.SubdivideEnsureDistance(aPath: ref  System.Collections.Generic.List<UnityEngine.Vector2> val_2 = 1262475156, aMaxDistance:  aMaxDistance, aClosed:  aClosed);
        }
        public static void SubdivideEnsureDistance(ref System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aMaxDistance, bool aClosed)
        {
            float val_7;
            System.Collections.Generic.List<UnityEngine.Vector2> val_8;
            var val_9;
            var val_10;
            var val_11;
            float val_12;
            var val_13;
            val_7 = R2;
            int val_8 = mem[aPath + 12];
            val_8 = val_8 - val_7 ^ 1;
            if(val_8 < 1)
            {
                    return;
            }
            
            bool val_2 = aClosed * aClosed;
            label_15:
            val_8 = aPath;
            if(val_8 == 0)
            {
                goto label_3;
            }
            
            val_9 = 0 + 1;
            val_10 = mem[aPath + 12];
            goto label_4;
            label_3:
            val_9 = 0 + 1;
            val_10 = mem[aPath + 12];
            val_8 = aPath;
            if(val_8 == 0)
            {
                goto label_5;
            }
            
            label_4:
            val_11 = val_10;
            if((mem[aPath + 12]) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = mem[aPath + 8];
            val_9 = val_9 + 0;
            val_7 = mem[(mem[aPath + 8] + 0) + 20];
            val_7 = (mem[aPath + 8] + 0) + 20;
            if((mem[aPath + 12]) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = mem[aPath + 8];
            val_10 = val_10 + (val_11 << 3);
            var val_12 = (mem[aPath + 8] + (mem[aPath + 12]) << 3) + 16;
            var val_11 = (mem[aPath + 8] + (mem[aPath + 12]) << 3) + 20;
            float val_4 = val_7 - val_11;
            float val_5 = ((mem[aPath + 8] + 0) + 16) - val_12.sqrMagnitude;
            if((mem[aPath + 12]) <= val_11)
            {
                goto label_11;
            }
            
            if((mem[aPath + 12]) >= _TYPE_MAX_)
            {
                    val_12 = 1262595264;
            }
            
            val_12 = val_12 / aClosed;
            int val_6 = UnityEngine.Mathf.CeilToInt(f:  val_12);
            if(val_6 < 2)
            {
                goto label_11;
            }
            
            val_11 = val_6;
            val_11 = val_11 - val_7;
            val_12 = val_12 - ((mem[aPath + 8] + 0) + 16);
            val_6 = val_6 - 1;
            do
            {
                float val_13 = 1f;
                val_13 = val_13 / (float)val_11;
                val_7 = val_7;
                aPath.Insert(index:  0 + 1, item:  new UnityEngine.Vector2() {x = (mem[aPath + 8] + 0) + 16, y = val_7});
                val_9 = 1 + 1;
            }
            while(val_11 != val_9);
            
            val_13 = val_11 + 0;
            int val_14 = val_8;
            val_14 = val_6 + val_14;
            goto label_14;
            label_11:
            val_13 = val_9;
            label_14:
            if(val_13 < val_14)
            {
                goto label_15;
            }
            
            return;
            label_5:
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> ScalePathByNormals(float aScale, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed, float aClampCornerCompensation = 3, bool aMergeIntersections = False)
        {
            var val_1;
            float val_7;
            float val_8;
            System.Collections.Generic.IEnumerable<T> val_24;
            var val_25;
            System.Collections.Generic.List<UnityEngine.Vector2> val_26;
            System.Collections.Generic.List<UnityEngine.Vector2> val_27;
            var val_28;
            var val_29;
            bool val_30;
            float val_31;
            System.Collections.Generic.List<UnityEngine.Vector2> val_32;
            var val_33;
            bool val_34;
            float val_35;
            val_24 = aClosed;
            if(val_1 == 0)
            {
                goto label_1;
            }
            
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(collection:  val_24);
            System.Collections.Generic.List<UnityEngine.Vector2> val_3 = aPath * aPath;
            bool val_25 = aMergeIntersections;
            val_25 = 0;
            val_25 = val_25 ^ 1;
            val_24 = 536878507;
            val_25 = 0 - val_25;
            goto label_12;
            label_14:
            if(R8 < 4)
            {
                goto label_16;
            }
            
            bool val_26 = val_25;
            val_25 = R8;
            val_26 = R8 + val_26;
            if(val_26 < true)
            {
                goto label_12;
            }
            
            goto label_5;
            label_11:
            val_26 = mem[536878519];
            label_5:
            val_27 = val_26;
            if(val_26 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_26 = mem[536878519];
            }
            
            val_28 = mem[536878515];
            var val_5 = val_28 + 0;
            if(val_26 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_28 = mem[536878515];
            }
            
            val_28 = val_28 + (val_27 << 3);
            UnityEngine.Vector2 val_6 = Ferr.PathUtil.GetPointNormal(i:  1262715392, aPath:  0, aClosed:  true);
            UnityEngine.Vector2 val_9 = Ferr.PathUtil.GetPointNormal(i:  1262715392, aPath:  val_27, aClosed:  true);
            float val_27 = val_8;
            val_27 = val_27 + SB;
            float val_28 = val_7;
            val_28 = val_28 + ((mem[536878515] + (mem[536878519]) << 3) + 16);
            UnityEngine.Vector2 val_12 = Ferr.PathUtil.LineIntersectionPoint(aLine1Pt1:  new UnityEngine.Vector2() {x = 1.28128E+07f, y = (mem[536878515] + 0) + 16}, aLine1Pt2:  new UnityEngine.Vector2() {x = (mem[536878515] + 0) + 20, y = val_7 + ((mem[536878515] + 0) + 16)}, aLine2Pt1:  new UnityEngine.Vector2() {x = val_8 + ((mem[536878515] + 0) + 20), y = (mem[536878515] + (mem[536878519]) << 3) + 16}, aLine2Pt2:  new UnityEngine.Vector2() {y = val_28});
            float val_29 = val_7;
            float val_30 = val_8;
            val_29 = val_29 - ((mem[536878515] + 0) + 16);
            val_30 = val_30 - ((mem[536878515] + 0) + 20);
            float val_13 = UnityEngine.Vector2.SqrMagnitude(a:  new UnityEngine.Vector2() {x = val_29, y = val_30});
            if(val_26 >= 0)
            {
                goto label_8;
            }
            
            float val_14 = ((mem[536878515] + 0) + 16) + ((mem[536878515] + (mem[536878519]) << 3) + 16);
            float val_15 = ((mem[536878515] + 0) + 20) + SB;
            val_14 = val_14 * 0.5f;
            val_15 = val_15 * 0.5f;
            val_24.set_Item(index:  val_27, value:  new UnityEngine.Vector2() {x = val_14, y = val_15});
            val_24.RemoveAt(index:  0);
            val_24 = val_24;
            if(mem[536878519] < 4)
            {
                goto label_9;
            }
            
            val_29 = 0;
            val_25 = ???;
            val_30 = val_26 - 1;
            goto label_10;
            label_8:
            val_24 = val_24;
            val_25 = ???;
            val_29 = 0 + 1;
            val_30 = val_26;
            label_10:
            if(val_29 < val_30)
            {
                goto label_11;
            }
            
            goto label_12;
            label_9:
            val_25 = ???;
            label_12:
            val_31 = mem[536878519];
            if(val_31 != val_25)
            {
                goto label_14;
            }
            
            goto label_16;
            label_1:
            if(val_24 != true)
            {
                    val_24 = 0;
            }
            
            label_16:
            val_32 = 536878507;
            val_32 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  0);
            if(0 < 1)
            {
                    return;
            }
            
            var val_34 = 0;
            var val_35 = 16;
            do
            {
                UnityEngine.Vector2 val_17 = Ferr.PathUtil.GetPointNormal(i:  1262715392, aPath:  0, aClosed:  false);
                UnityEngine.Vector2 val_18 = Ferr.PathUtil.GetSegmentNormal(i:  1262715392, aPath:  0, aClosed:  false);
                val_8 = val_8;
                val_7 = val_7;
                float val_19 = val_7.sqrMagnitude;
                float val_20 = val_7.sqrMagnitude;
                if(mem[536890411] >= _TYPE_MAX_)
            {
                    float val_32 = 1262715392 * 1262715384;
            }
            
                val_33 = 0;
                if(mem[536890411] >= 0)
            {
                    float val_31 = val_8;
                val_31 = val_8 * val_31;
                val_32 = val_31 / val_32;
                float val_22 = UnityEngine.Mathf.Clamp(value:  val_32, min:  val_18.y, max:  val_7);
                val_34 = mem[536890482];
                if((val_34 & true) == 0)
            {
                    val_34 = mem[536890411];
            }
            
                val_33 = val_22 * 57.29578f;
            }
            
                val_22 = val_33 * 0.01745329f;
                val_35 = 1f / val_22;
                if(val_34 > 0)
            {
                    float val_23 = UnityEngine.Mathf.Min(a:  val_35, b:  val_18.y);
                val_35 = ???;
            }
            
                System.Collections.Generic.List<UnityEngine.Vector2> val_24 = val_35 * aPath;
                if(0 <= val_34)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                float val_33 = 0f;
                val_32 = val_32;
                val_33 = val_33 + val_35;
                val_31 = (0 + 16) + 4;
                val_32.Add(item:  new UnityEngine.Vector2() {x = val_33, y = val_31});
                val_34 = val_34 + 1;
                val_35 = val_35 + 8;
            }
            while(val_34 < 0);
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> ScalePathToPoint(UnityEngine.Vector2 aPt, float aScale, System.Collections.Generic.List<UnityEngine.Vector2> aPoints, bool aClosed)
        {
            float val_2;
            float val_3;
            int val_4;
            val_2 = aPt.x;
            val_3 = aPoints;
            val_4 = mem[aClosed + 12];
            val_4 = aClosed + 12;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  val_4);
            if((aClosed + 12) < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            var val_6 = 16;
            val_3 = 4.022026E-38f;
            do
            {
                if((aClosed + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_2 = aClosed + 8;
                val_2 = val_2 + val_6;
                var val_3 = (aClosed + 8 + 16) + 4;
                var val_4 = val_2;
                val_3 = val_3 - aPt.y;
                val_4 = val_4 - val_2;
                val_4 = aPt.y;
                val_2 = val_2;
                536878507.Add(item:  new UnityEngine.Vector2() {x = val_2, y = val_4});
                val_5 = val_5 + 1;
                val_6 = val_6 + 8;
            }
            while(val_5 < (aClosed + 12));
        
        }
        public static void OffsetPathSegments(System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed, UnityEngine.Vector2 aOffset, System.Func<int, bool> aSegmentMask)
        {
            float val_3;
            float val_4;
            var val_19;
            float val_20;
            var val_21;
            System.Func<System.Int32, System.Boolean> val_22;
            int val_23;
            float val_24;
            bool val_25;
            var val_26;
            int val_27;
            bool val_28;
            bool val_29;
            var val_30;
            var val_31;
            var val_32;
            val_19 = 0;
            float val_1 = aOffset.x.magnitude;
            val_20 = ;
            UnityEngine.Vector2 val_2 = normalized;
            val_21 = aClosed ^ 1;
            if((1262959872 != 0) && (val_21 != true))
            {
                    val_19 = ;
            }
            
            val_22 = aSegmentMask;
            UnityEngine.Vector2 val_5 = Ferr.PathUtil.GetSegmentNormal(i:  1262959856, aPath:  1262959872, aClosed:  aPath);
            val_23 = 0;
            val_24 = val_3;
            if(val_21 != true)
            {
                    var val_6 = (aPath + 12) + (aPath + 12);
                val_23 = aPath + 12;
            }
            
            if(val_22 != 0)
            {
                    val_25 = val_22.Invoke(arg:  val_23);
            }
            else
            {
                    val_25 = 0.Invoke(arg:  val_23);
            }
            
            val_26 = 0;
            UnityEngine.Vector2 val_10 = Ferr.PathUtil.GetSegmentNormal(i:  1262959856, aPath:  0, aClosed:  aPath);
            if((aPath + 12) < 1)
            {
                    return;
            }
            
            label_19:
            val_21 = 1;
            val_27 = 0;
            if((aPath + 12) != 0)
            {
                    if(aClosed != false)
            {
                    var val_11 = (aPath + 12) + (aPath + 12);
                val_27 = aPath + 12;
            }
            else
            {
                    if(val_21 >= 0)
            {
                    if(val_21 >= (aPath + 12))
            {
                    val_27 = (aPath + 12) - 1;
            }
            
            }
            
            }
            
            }
            
            val_22 = val_3;
            val_28 = aSegmentMask.Invoke(arg:  val_27);
            UnityEngine.Vector2 val_13 = Ferr.PathUtil.GetSegmentNormal(i:  1262959856, aPath:  val_27, aClosed:  aPath);
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
            if(((val_22.Invoke(arg:  0)) & true) != 0)
            {
                goto label_13;
            }
            
            val_29 = val_28;
            if((val_25 & true) != 0)
            {
                goto label_14;
            }
            
            float val_17 = val_24;
            val_17 = val_3 + val_17;
            float val_18 = val_4;
            val_18 = val_4 + val_18;
            UnityEngine.Vector2 val_15 = normalized;
            val_30 = val_4;
            val_31 = val_3;
            goto label_15;
            label_13:
            if((val_25 & true) != 0)
            {
                goto label_16;
            }
            
            val_32 = val_4;
            val_29 = val_28;
            val_30 = val_22 ^ 2147483648;
            goto label_17;
            label_14:
            val_30 = val_24;
            val_32 = val_4 ^ 2147483648;
            label_17:
            val_31 = val_32;
            label_15:
            if((aPath + 12) <= val_26)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_19 = aPath + 8;
            float val_16 = val_4 * val_30;
            val_19 = val_19 + 16;
            val_16 = 1262959872 / val_16;
            aPath.set_Item(index:  0, value:  new UnityEngine.Vector2() {x = val_19, y = (aPath + 8 + 16) + 4});
            val_28 = val_29;
            label_16:
            val_24 = 16 + 8;
            val_20 = val_3;
            val_26 = val_21;
            if(val_21 < (aPath + 12))
            {
                goto label_19;
            }
        
        }
        public static System.Collections.Generic.List<UnityEngine.Vector2> RoundCorners(System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<Ferr.PointControl> aControls, bool aClosed, System.Collections.Generic.List<float> aRadii, float aSegmentSize = 1)
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_4;
            var val_5;
            float val_6;
            val_4 = 536878507;
            val_4 = new System.Collections.Generic.List<UnityEngine.Vector2>(capacity:  23000565);
            if(val_4 < 1)
            {
                    return;
            }
            
            val_5 = 0;
            var val_6 = 16;
            var val_7 = 16;
            label_12:
            if(val_4 <= val_5)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + val_7;
            if(val_4 > val_5)
            {
                    if((aClosed == true) || (val_5 != aClosed))
            {
                goto label_7;
            }
            
            }
            
            if(aClosed <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = 2621443;
            val_4.Add(item:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f});
            goto label_10;
            label_7:
            if(aClosed <= val_5)
            {
                    float val_5 = 0f;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_5 = val_5 + val_7;
                val_6 = mem[(0 + 16)];
                val_6 = val_5;
            }
            
            Ferr.PathUtil.AddRoundCorners(aCornerId:  0, aPath:  aPath, aControls:  aControls, aClosed:  aClosed, aTo: ref  val_4, aRadius:  val_6, aSegmentSize:  null);
            label_10:
            val_5 = val_5 + 1;
            val_6 = val_6 + 8;
            val_7 = val_7 + 4;
            if(val_5 < val_5)
            {
                goto label_12;
            }
        
        }
        public static void AddRoundCorners(int aCornerId, System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<Ferr.PointControl> aControls, bool aClosed, ref System.Collections.Generic.List<UnityEngine.Vector2> aTo, float aRadius, float aSegmentSize = 1)
        {
            var val_1;
            var val_16;
            var val_36;
            System.Collections.Generic.List<UnityEngine.Vector2> val_37;
            float val_38;
            float val_39;
            float val_40;
            var val_41;
            var val_43;
            var val_44;
            float val_46;
            float val_47;
            float val_48;
            float val_49;
            bool val_50;
            float val_51;
            val_36 = aClosed;
            var val_39 = 0;
            if(val_36 == false)
            {
                goto label_2;
            }
            
            if(aPath != 0)
            {
                goto label_7;
            }
            
            goto label_7;
            label_2:
            if(aCornerId == 0)
            {
                goto label_5;
            }
            
            val_39 = val_39 - 1;
            if(val_39 != aCornerId)
            {
                goto label_7;
            }
            
            val_37 = aTo;
            goto label_9;
            label_5:
            val_37 = aTo;
            label_9:
            if(aTo <= aCornerId)
            {
                    var val_40 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_40 = val_40 + (aCornerId << 3);
            val_38 = mem[(0 + (aCornerId) << 3) + 16];
            val_38 = (0 + (aCornerId) << 3) + 16;
            val_39 = val_38;
            val_40 = (0 + (aCornerId) << 3) + 20;
            val_41 = 22739676;
            goto label_12;
            label_7:
            if(23000566 == 0)
            {
                goto label_13;
            }
            
            int val_2 = aCornerId - 1;
            if(val_36 == false)
            {
                goto label_14;
            }
            
            var val_3 = 23000566 + 23000566;
            int val_4 = aCornerId + 1;
            val_43 = 23000566;
            var val_5 = 23000566 + 23000566;
            val_44 = 23000566;
            goto label_19;
            label_13:
            val_43 = 0;
            goto label_18;
            label_14:
            val_43 = 0;
            if(val_2 >= 0)
            {
                    if(val_2 >= 23000566)
            {
                    val_2 = 23000566 - 1;
            }
            
                val_43 = val_2;
            }
            
            int val_6 = aCornerId + 1;
            if(val_6 < 0)
            {
                goto label_18;
            }
            
            if(val_6 >= 23000566)
            {
                    val_44 = 23000566 - 1;
            }
            
            goto label_19;
            label_18:
            val_44 = 0;
            label_19:
            if(23000566 <= aCornerId)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = 0 + (aCornerId << 3);
            if(23000566 <= val_43)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = 0 + 0;
            val_38 = mem[(0 + 0) + 16];
            val_38 = (0 + 0) + 16;
            val_46 = mem[(0 + 0) + 20];
            val_46 = (0 + 0) + 20;
            if(23000566 <= val_44)
            {
                    var val_41 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_41 = val_41 + 0;
            val_47 = mem[(0 + 0) + 16];
            val_47 = (0 + 0) + 16;
            val_48 = mem[(0 + 0) + 20];
            val_48 = (0 + 0) + 20;
            if(aControls != 0)
            {
                    if((aControls + 12) <= val_43)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_42 = aControls + 8;
                val_42 = val_42 + 0;
                var val_44 = (aControls + 8 + 0) + 16 + 12;
                var val_43 = (aControls + 8 + 0) + 16 + 16;
                if((aControls + 12) <= val_44)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_45 = aControls + 8;
                val_43 = val_46 + val_43;
                val_44 = val_38 + val_44;
                val_45 = val_45 + 0;
                var val_46 = (aControls + 8 + 0) + 16 + 20;
                var val_47 = (aControls + 8 + 0) + 16 + 24;
                val_46 = val_47 + val_46;
                val_49 = (0 + (aCornerId) << 3) + 20;
                val_47 = val_48 + val_47;
                val_46 = val_43;
                val_38 = val_44;
                val_47 = val_46;
                val_48 = val_47;
            }
            else
            {
                    val_49 = (0 + (aCornerId) << 3) + 20;
            }
            
            float val_49 = val_47;
            float val_48 = val_48;
            float val_50 = val_46;
            float val_51 = val_38;
            val_48 = val_48 - val_49;
            val_49 = val_49 - ((0 + (aCornerId) << 3) + 16);
            val_50 = val_50 - val_49;
            val_51 = val_51 - ((0 + (aCornerId) << 3) + 16);
            float val_9 = val_51.magnitude;
            float val_10 = val_49.magnitude;
            float val_52 = val_51;
            float val_53 = val_50;
            float val_54 = val_49;
            float val_55 = val_48;
            val_52 = val_52 / 1263228880;
            val_53 = val_53 / 1263228880;
            val_54 = val_54 / 1263228872;
            val_55 = val_55 / 1263228872;
            float val_11 = UnityEngine.Mathf.Min(a:  val_52, b:  aSegmentSize);
            float val_12 = val_52.sqrMagnitude;
            float val_13 = val_54.sqrMagnitude;
            val_36 = 22713020;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    float val_57 = 1263228896 * 1263228888;
            }
            
            if(mem[536890411] >= 0)
            {
                    float val_56 = val_55;
                val_56 = val_53 * val_56;
                val_57 = val_56 / val_57;
                float val_15 = UnityEngine.Mathf.Clamp(value:  val_57, min:  aSegmentSize, max:  val_54);
                val_50 = mem[536890482];
                if((val_50 & true) == 0)
            {
                    val_50 = mem[536890411];
            }
            
                val_15 = val_15 * 57.29578f;
                val_51 = val_15 * 0.01745329f;
            }
            else
            {
                    val_51 = 0f;
            }
            
            float val_58 = -3.141593f;
            val_58 = val_51 + val_58;
            float val_59 = System.Math.Abs(val_58);
            if(mem[536890411] < 0)
            {
                goto label_39;
            }
            
            float val_60 = System.Math.Abs(val_51);
            if(mem[536890411] >= 0)
            {
                goto label_42;
            }
            
            label_39:
            val_37 = aTo;
            val_40 = val_49;
            val_41 = 22739676;
            val_39 = (0 + (aCornerId) << 3) + 16;
            label_12:
            val_37.Add(item:  new UnityEngine.Vector2() {x = val_39, y = val_40});
            return;
            label_42:
            float val_18 = val_51 * 0.5f;
            var val_61 = val_18;
            val_61 = (1263228880 / 2.1f) * val_61;
            if(mem[536890411] < 0)
            {
                    val_1 = val_61;
            }
            
            float val_62 = val_18;
            val_62 = val_1 / (val_1 / val_62);
            float val_20 = UnityEngine.Mathf.Clamp01(value:  val_62);
            float val_21 = val_55 - val_53;
            float val_22 = val_54 - val_52;
            UnityEngine.Vector2 val_23 = val_52.normalized;
            UnityEngine.Vector2 val_24 = UnityEngine.Vector2.right;
            float val_25 = val_1 / val_18;
            float val_63 = (0 + (aCornerId) << 3) + 16;
            float val_64 = val_49;
            val_63 = val_63 - ((0 + (aCornerId) << 3) + 16);
            val_64 = val_64 - val_49;
            float val_26 = Ferr.PathUtil.SignedAngle(v1:  new UnityEngine.Vector2() {x = val_63, y = val_64}, v2:  new UnityEngine.Vector2() {x = val_52, y = val_53});
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.right;
            var val_65 = val_62;
            float val_66 = 3.141593f;
            val_65 = val_65 + val_65;
            val_65 = val_65 / val_66;
            float val_29 = ((0 + (aCornerId) << 3) + 16) - ((0 + (aCornerId) << 3) + 16);
            val_66 = val_1 * val_66;
            val_65 = val_66 * val_65;
            float val_32 = Ferr.PathUtil.SignedAngle(v1:  new UnityEngine.Vector2() {x = val_29, y = val_49 - val_49}, v2:  new UnityEngine.Vector2() {x = val_52, y = val_53});
            float val_35 = val_29 + (-180f);
            float val_36 = val_53 * val_54;
            val_35 = val_35 + (-180f);
            if(mem[536890411] > 0)
            {
                    val_63 = (val_63 + (-180f)) + (-180f);
            }
            
            if(mem[536890411] > 0)
            {
                    val_29 = val_35;
            }
            
            val_29 = val_29 * (-0.01745329f);
            float val_37 = val_63 * (-0.01745329f);
            int val_38 = ((int)(val_65 / val_16) + 0.5f) + (((int)(val_65 / val_16) + 0.5f) >> 31);
            val_38 = val_38 & (~1);
            val_38 = ((int)(val_65 / val_16) + 0.5f) - val_38;
            if(val_38 == 1)
            {
                    (int)(val_65 / val_16) + 0.5f = ((int)(val_65 / val_16) + 0.5f) + 1;
            }
            
            if(val_38 <= 1)
            {
                    if(val_38 > 1)
            {
                    do
            {
                val_29 = val_29 + (-6.283185f);
            }
            while(val_38 > 1);
            
            }
            
            }
        
        }
        public static UnityEngine.Vector2 GetRoundedCornerEnd(int aCornerId, System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<Ferr.PointControl> aControls, bool aClosed, float aRadius, bool aGetBeginning)
        {
            var val_1;
            var val_15;
            int val_18;
            float val_19;
            var val_20;
            float val_21;
            var val_23;
            var val_24;
            var val_25;
            float val_27;
            float val_28;
            int val_29;
            bool val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            val_18 = aCornerId;
            val_19 = aClosed;
            val_20 = aControls;
            val_21 = aPath;
            var val_17 = 0;
            if(aGetBeginning == false)
            {
                goto label_2;
            }
            
            if(val_20 != 0)
            {
                goto label_4;
            }
            
            goto label_4;
            label_2:
            if(val_21 == 0)
            {
                goto label_5;
            }
            
            val_17 = val_17 - 1;
            if(val_17 == val_21)
            {
                goto label_11;
            }
            
            label_4:
            if(R5 == 0)
            {
                goto label_8;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_2 = val_21 - 1;
            if(aGetBeginning == false)
            {
                goto label_9;
            }
            
            var val_3 = R5 + R5;
            System.Collections.Generic.List<UnityEngine.Vector2> val_4 = val_21 + 1;
            val_23 = R5;
            var val_5 = R5 + R5;
            val_24 = R5;
            goto label_10;
            label_5:
            label_11:
            if(val_17 <= val_21)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + (val_21 << 3);
            return new UnityEngine.Vector2() {x = val_32};
            label_8:
            val_23 = 0;
            val_24 = 0;
            label_10:
            val_25 = val_19;
            goto label_17;
            label_9:
            val_23 = 0;
            if(val_2 >= 0)
            {
                    if(val_2 >= R5)
            {
                    val_2 = R5 - 1;
            }
            
                val_23 = val_2;
            }
            
            System.Collections.Generic.List<UnityEngine.Vector2> val_6 = val_21 + 1;
            val_25 = val_19;
            if(val_6 >= 0)
            {
                    if(val_6 >= R5)
            {
                    val_24 = R5 - 1;
            }
            
            }
            else
            {
                    val_24 = 0;
            }
            
            label_17:
            if(R5 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            aPath = 0 + (val_21 << 3);
            if(R5 <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = 0 + (val_23 << 3);
            val_21 = mem[(0 + ((R5 - 1)) << 3) + 16];
            val_21 = (0 + ((R5 - 1)) << 3) + 16;
            if(R5 <= val_24)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + 0;
            val_27 = mem[(0 + 0) + 16];
            val_27 = (0 + 0) + 16;
            val_28 = mem[(0 + 0) + 20];
            val_28 = (0 + 0) + 20;
            if(val_25 != false)
            {
                    if((aClosed + 12) <= val_23)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_20 = aClosed + 8;
                val_20 = val_20 + (val_23 << 2);
                var val_22 = (aClosed + 8 + ((R5 - 1)) << 2) + 16 + 12;
                var val_21 = (aClosed + 8 + ((R5 - 1)) << 2) + 16 + 16;
                if((aClosed + 12) <= val_24)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_23 = aClosed + 8;
                val_21 = val_19 + val_21;
                val_22 = val_21 + val_22;
                val_23 = val_23 + 0;
                var val_24 = (aClosed + 8 + 0) + 16 + 20;
                var val_25 = (aClosed + 8 + 0) + 16 + 24;
                val_24 = val_27 + val_24;
                val_29 = val_18;
                val_25 = val_28 + val_25;
                val_19 = val_21;
                val_21 = val_22;
                val_27 = val_24;
                val_28 = val_25;
            }
            else
            {
                    val_29 = val_18;
            }
            
            float val_26 = val_27;
            float val_28 = val_28;
            float val_29 = val_19;
            float val_27 = val_21;
            val_26 = val_26 - ((0 + (aPath) << 3) + 16);
            val_27 = val_27 - ((0 + (aPath) << 3) + 16);
            val_28 = val_28 - ((0 + (aPath) << 3) + 20);
            val_29 = val_29 - ((0 + (aPath) << 3) + 20);
            float val_8 = val_27.magnitude;
            float val_9 = val_26.magnitude;
            float val_30 = val_27;
            float val_31 = val_29;
            float val_32 = val_26;
            float val_33 = val_28;
            val_30 = val_30 / 1263361328;
            val_31 = val_31 / 1263361328;
            val_32 = val_32 / 1263361320;
            val_33 = val_33 / 1263361320;
            float val_10 = UnityEngine.Mathf.Min(a:  val_30, b:  null);
            val_18 = static_value_015E7AA9;
            float val_11 = val_30.sqrMagnitude;
            float val_12 = val_32.sqrMagnitude;
            val_20 = 22713020;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    float val_35 = 1263361344 * 1263361336;
            }
            
            if(mem[536890411] >= 0)
            {
                    float val_34 = val_33;
                val_34 = val_31 * val_34;
                val_35 = val_34 / val_35;
                float val_14 = UnityEngine.Mathf.Clamp(value:  val_35, min:  null, max:  val_32);
                val_30 = mem[536890482];
                if((val_30 & true) == 0)
            {
                    val_30 = mem[536890411];
            }
            
                val_14 = val_14 * 57.29578f;
                val_31 = val_14 * 0.01745329f;
            }
            else
            {
                    val_31 = 0f;
            }
            
            float val_36 = -3.141593f;
            val_36 = val_31 + val_36;
            float val_37 = System.Math.Abs(val_36);
            if(mem[536890411] < 0)
            {
                goto label_37;
            }
            
            float val_38 = System.Math.Abs(val_31);
            if(mem[536890411] >= 0)
            {
                goto label_40;
            }
            
            label_37:
            mem2[0] = (0 + (aPath) << 3) + 16;
            mem2[0] = (0 + (aPath) << 3) + 20;
            return new UnityEngine.Vector2() {x = val_32};
            label_40:
            float val_39 = 0.5f;
            val_39 = val_31 * val_39;
            var val_40 = val_39;
            val_40 = (1263361328 / 2.1f) * val_40;
            if(mem[536890411] < 0)
            {
                    val_1 = val_40;
            }
            
            val_32 = val_1 / val_39;
            if(val_15 != 0)
            {
                    val_33 = val_30;
                val_34 = val_31;
            }
            else
            {
                    val_33 = val_32;
                val_34 = val_33;
            }
            
            mem2[0] = (0 + (aPath) << 3) + 16;
            mem2[0] = (0 + (aPath) << 3) + 20;
            return new UnityEngine.Vector2() {x = val_32};
        }
        public static void GizmoDraw(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aVertSize, bool aClosed, bool aDrawLine = True, float aArrowSize = 0.1)
        {
            var val_2;
            var val_4;
            float val_14;
            float val_15;
            var val_16;
            float val_21;
            System.Collections.Generic.List<UnityEngine.Vector2> val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            float val_28;
            float val_29;
            var val_30;
            var val_31;
            float val_32;
            float val_33;
            float val_34;
            val_21 = R3;
            bool val_1 = aDrawLine ^ 1;
            System.Collections.Generic.List<UnityEngine.Vector2> val_3 = aPath - val_1;
            if((val_3 < 1) || (val_21 == 0))
            {
                goto label_3;
            }
            
            val_23 = aPath;
            val_1 = 0 - val_1;
            val_1 = aPath + val_1;
            val_24 = 16;
            val_21 = 0;
            val_1 = val_1 - 1;
            goto label_4;
            label_7:
            val_23 = aPath;
            val_21 = SB;
            val_25 = mem[aPath + 12];
            val_25 = aPath + 12;
            val_24 = val_4 + 8;
            label_4:
            if(val_25 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_25 = mem[aPath + 12];
                val_25 = aPath + 12;
            }
            
            val_26 = mem[aPath + 8];
            val_26 = aPath + 8;
            val_27 = val_21 + 1;
            val_4 = val_24;
            val_28 = mem[aPath + 8 + (val_4 + 8)];
            val_28 = aPath + 8 + (val_4 + 8);
            if(val_25 <= val_25)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_26 = mem[aPath + 8];
                val_26 = aPath + 8;
            }
            
            var val_5 = val_26 + (val_25 << 3);
            val_29 = mem[(aPath + 8 + (aPath + 12) << 3) + 16];
            val_29 = (aPath + 8 + (aPath + 12) << 3) + 16;
            UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_28, y = aPath + 8 + (val_4 + 8) + 4, z = 0f}, to:  new UnityEngine.Vector3() {x = val_29, y = (aPath + 8 + (aPath + 12) << 3) + 20, z = 0f});
            if(val_1 != val_21)
            {
                goto label_7;
            }
            
            label_3:
            if((val_1 > val_21) && (val_3 >= 1))
            {
                    do
            {
                val_30 = mem[aPath + 12];
                val_30 = aPath + 12;
                val_26 = 0 + 1;
                var val_18 = val_30;
                if(val_30 <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_30 = mem[aPath + 12];
                val_30 = aPath + 12;
            }
            
                val_31 = mem[aPath + 8];
                val_31 = aPath + 8;
                val_18 = val_31 + (val_18 << 3);
                val_27 = mem[(aPath + 8 + (aPath + 12) << 3) + 20];
                val_27 = (aPath + 8 + (aPath + 12) << 3) + 20;
                if(val_30 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_31 = mem[aPath + 8];
                val_31 = aPath + 8;
                val_30 = mem[aPath + 12];
                val_30 = aPath + 12;
            }
            
                val_32 = ((aPath + 8 + (aPath + 12) << 3) + 16) - (val_31 + 16);
                val_33 = val_27 - ((aPath + 8 + 16) + 4);
                if(val_30 > 0)
            {
                    val_31 = val_31 + 0;
                val_34 = val_31 + 16;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_32 = val_32;
                val_33 = val_33;
                val_34 = (aPath + 8) + 16;
            }
            
                val_32.Normalize();
                float val_7 = val_33 * val_2;
                float val_8 = val_32 * val_2;
                val_21 = (aPath + 8 + 16) + 4;
                float val_9 = val_34 + val_7;
                val_9 = val_9 - val_8;
                float val_10 = ((aPath + 8 + 16) + 4) - val_8;
                val_10 = val_10 - val_7;
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_34, y = val_21, z = 0f}, to:  new UnityEngine.Vector3() {x = val_9, y = val_10, z = 0f});
                float val_11 = val_34 - val_7;
                val_11 = val_11 - val_8;
                float val_12 = ((aPath + 8 + 16) + 4) + val_8;
                val_12 = val_12 - val_7;
                UnityEngine.Gizmos.DrawLine(from:  new UnityEngine.Vector3() {x = val_34, y = val_21, z = 0f}, to:  new UnityEngine.Vector3() {x = val_11, y = val_12, z = 0f});
                val_28 = 16 + 8;
                val_29 = val_26;
            }
            while(val_3 != val_26);
            
            }
            
            if(val_3 <= val_26)
            {
                    return;
            }
            
            if((aPath + 12) < 1)
            {
                    return;
            }
            
            val_26 = 0;
            var val_21 = 0;
            do
            {
                if((aPath + 12) <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_28 = mem[aPath + 8 + 16];
                val_28 = aPath + 8 + 16;
                val_29 = mem[aPath + 8 + 16 + 4];
                val_29 = aPath + 8 + 16 + 4;
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
                float val_19 = val_14;
                float val_20 = val_15;
                val_19 = val_19 * aClosed;
                val_20 = val_20 * aClosed;
                UnityEngine.Gizmos.DrawCube(center:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = 0f}, size:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_16 * aClosed});
                val_21 = val_21 + 1;
                val_21 = 16 + 8;
            }
            while(val_21 < (aPath + 12));
        
        }
        public static bool ClipLine(UnityEngine.Rect aClipRect, UnityEngine.Vector2 aStart, UnityEngine.Vector2 aEnd, out UnityEngine.Vector2 aStartResult, out UnityEngine.Vector2 aEndResult)
        {
            var val_5;
            var val_6;
            float val_21;
            float val_22;
            var val_23;
            var val_24;
            var val_25;
            float val_26;
            var val_27;
            val_21 = aClipRect.m_YMin;
            val_22 = aClipRect.m_Width;
            PathUtil.OutCode val_1 = Ferr.PathUtil.ComputeOutCode(aBounds:  new UnityEngine.Rect() {m_XMin = aClipRect.m_XMin, m_YMin = val_21, m_Width = aClipRect.m_Width, m_Height = aClipRect.m_Height}, aPos:  new UnityEngine.Vector2() {x = aStart.x, y = aStart.y});
            PathUtil.OutCode val_2 = Ferr.PathUtil.ComputeOutCode(aBounds:  new UnityEngine.Rect() {m_XMin = aClipRect.m_XMin, m_YMin = val_21, m_Width = val_22, m_Height = aClipRect.m_Height}, aPos:  new UnityEngine.Vector2() {x = aEnd.x, y = aEnd.y});
            val_23 = aClipRect.m_XMin;
            aStartResult.x = aStart.x;
            mem[1152921510165476436] = aStart.y;
            aStartResult.y = aEnd.x;
            mem[1152921510165480532] = aEnd.y;
            val_24 = 1;
            if()
            {
                    return (bool)val_24;
            }
            
            label_13:
            if((aClipRect.m_XMin & val_23) > 0f)
            {
                goto label_1;
            }
            
            val_25 = 0;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            if(aClipRect.m_XMin > 0f)
            {
                    val_23 = aClipRect.m_XMin;
            }
            
            if(val_23 != (1.121039E-44f))
            {
                goto label_2;
            }
            
            if(val_23 != (5.605194E-45f))
            {
                goto label_3;
            }
            
            if(val_23 != (2.802597E-45f))
            {
                goto label_4;
            }
            
            if(val_23 != (1.401298E-45f))
            {
                goto label_5;
            }
            
            val_21 = val_5;
            val_22 = val_6;
            goto label_12;
            label_2:
            float val_7 = aClipRect.m_XMin.yMax;
            uint val_21 = 1263618104;
            float val_22 = mem[1152921510165476436];
            val_21 = val_21 - val_22;
            val_26;
            val_22 = mem[1152921510165480532] - val_22;
            val_25 = 0;
            val_21 = (aStartResult.y - aStartResult.x) * val_21;
            val_21 = val_21 / val_22;
            val_21 = aStartResult.x + val_21;
            val_21 = val_21;
            float val_9 = aClipRect.m_XMin.yMax;
            goto label_7;
            label_3:
            float val_10 = aClipRect.m_XMin.yMin;
            uint val_23 = 1263618104;
            float val_24 = mem[1152921510165476436];
            val_23 = val_23 - val_24;
            val_26;
            val_24 = mem[1152921510165480532] - val_24;
            val_25 = 0;
            val_23 = (aStartResult.y - aStartResult.x) * val_23;
            val_23 = val_23 / val_24;
            val_23 = aStartResult.x + val_23;
            val_21 = val_23;
            float val_12 = aClipRect.m_XMin.yMin;
            label_7:
            val_22 = val_26;
            label_12:
            if(val_23 != aClipRect.m_XMin)
            {
                goto label_8;
            }
            
            aStartResult.x = val_21;
            mem[1152921510165476436] = val_22;
            PathUtil.OutCode val_13 = Ferr.PathUtil.ComputeOutCode(aBounds:  new UnityEngine.Rect() {m_XMin = aClipRect.m_XMin, m_YMin = val_21, m_Width = aClipRect.m_Width, m_Height = aClipRect.m_Height}, aPos:  new UnityEngine.Vector2() {x = val_21, y = val_22});
            if(val_23 != aClipRect.m_XMin)
            {
                goto label_13;
            }
            
            goto label_10;
            label_4:
            float val_14 = aClipRect.m_XMin.xMax;
            uint val_25 = 1263618104;
            float val_26 = aStartResult.x;
            val_25 = val_25 - val_26;
            val_27;
            val_26 = aStartResult.y - val_26;
            val_25 = (mem[1152921510165480532] - mem[1152921510165476436]) * val_25;
            val_25 = val_25 / val_26;
            val_25 = mem[1152921510165476436] + val_25;
            float val_16 = aClipRect.m_XMin.xMax;
            goto label_12;
            label_5:
            float val_17 = aClipRect.m_XMin.xMin;
            uint val_27 = 1263618104;
            float val_28 = aStartResult.x;
            val_27 = val_27 - val_28;
            val_27;
            val_28 = aStartResult.y - val_28;
            val_27 = (mem[1152921510165480532] - mem[1152921510165476436]) * val_27;
            val_27 = val_27 / val_28;
            val_27 = mem[1152921510165476436] + val_27;
            float val_19 = aClipRect.m_XMin.xMin;
            goto label_12;
            label_8:
            aStartResult.y = val_21;
            mem[1152921510165480532] = val_22;
            PathUtil.OutCode val_20 = Ferr.PathUtil.ComputeOutCode(aBounds:  new UnityEngine.Rect() {m_XMin = aClipRect.m_XMin, m_YMin = val_21, m_Width = aClipRect.m_Width, m_Height = aClipRect.m_Height}, aPos:  new UnityEngine.Vector2() {x = val_21, y = val_22});
            val_23 = aClipRect.m_XMin;
            if(val_23 != aClipRect.m_XMin)
            {
                goto label_13;
            }
            
            label_10:
            val_24 = 1;
            return (bool)val_24;
            label_1:
            val_24 = 0;
            return (bool)val_24;
        }
        private static Ferr.PathUtil.OutCode ComputeOutCode(UnityEngine.Rect aBounds, UnityEngine.Vector2 aPos)
        {
            var val_5;
            float val_1 = aBounds.m_XMin.xMin;
            val_5 = 1;
            if()
            {
                    float val_2 = aBounds.m_XMin.xMax;
                if(<0)
            {
                    val_5 = 2;
            }
            
            }
            
            float val_3 = aBounds.m_XMin.yMin;
            if()
            {
                    var val_4 = val_5 | 4;
                return;
            }
            
            float val_5 = aBounds.m_XMin.yMax;
            if(<0)
            {
                    val_5 = val_5 | 8;
            }
        
        }
        public static float GetParallelOffset(int i, System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            float val_2;
            var val_3;
            bool val_10;
            float val_11;
            UnityEngine.Vector2 val_1 = Ferr.PathUtil.GetSegmentNormal(i:  1263862600, aPath:  i, aClosed:  aPath);
            UnityEngine.Vector2 val_4 = Ferr.PathUtil.GetPointNormal(i:  1263862600, aPath:  i, aClosed:  aPath);
            val_3 = val_3;
            float val_5 = val_2.sqrMagnitude;
            float val_6 = val_2.sqrMagnitude;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    float val_11 = 1263862600 * 1263862592;
            }
            
            if(mem[536890411] >= 0)
            {
                    float val_10 = val_3;
                val_10 = val_3 * val_10;
                val_11 = val_10 / val_11;
                float val_8 = UnityEngine.Mathf.Clamp(value:  val_11, min:  val_4.y, max:  val_2);
                val_10 = mem[536890482];
                if((val_10 & true) == 0)
            {
                    val_10 = mem[536890411];
            }
            
                val_8 = val_8 * 57.29578f;
                val_11 = val_8 * 0.01745329f;
            }
            else
            {
                    val_11 = 0f;
            }
            
            float val_12 = 1f;
            val_12 = val_12 / 0;
            return (float)UnityEngine.Mathf.Min(a:  val_12, b:  val_4.y);
        }
        public static bool IsInnerCorner(System.Collections.Generic.List<UnityEngine.Vector2> aFirst, System.Collections.Generic.List<UnityEngine.Vector2> aSecond)
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            if(aFirst != 0)
            {
                    val_1 = aFirst;
                val_3 = true;
            }
            else
            {
                    val_1 = 12;
                val_3 = 0;
                val_2 = 0;
            }
            
            if(val_2 <= (-1))
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 4294967288;
            if(aFirst != 0)
            {
                    val_5 = val_1;
            }
            else
            {
                    val_5 = 0;
                val_4 = 0;
            }
            
            if(val_4 <= (-2))
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 4294967280;
            var val_4 = (0 + 4294967280) + 16;
            var val_3 = (0 + 4294967280) + 20;
            val_3 = val_3 - SB;
            val_4 = val_4 - ((0 + 4294967288) + 16);
            if(val_2 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_5 = 0f;
            float val_6 = 7.286752E-44f;
            val_5 = val_5 - ((0 + 4294967288) + 16);
            val_6 = val_6 - SB;
            val_5 = val_3 * val_5;
            if(val_2 > 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static float SignedAngle(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
        {
            bool val_6;
            float val_7;
            float val_6 = v2.y;
            val_6 = v1.x * val_6;
            float val_1 = UnityEngine.Mathf.Sign(f:  val_6);
            float val_2 = v1.x.sqrMagnitude;
            float val_3 = v2.x.sqrMagnitude;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    float val_8 = 1264107080 * 1264107072;
            }
            
            if(mem[536890411] >= 0)
            {
                    float val_7 = v2.y;
                val_7 = v1.y * val_7;
                val_8 = val_7 / val_8;
                val_6 = mem[536890482];
                if((val_6 & true) == 0)
            {
                    val_6 = mem[536890411];
            }
            
                val_7 = (UnityEngine.Mathf.Clamp(value:  val_8, min:  null, max:  v2.x)) * 57.29578f;
            }
            else
            {
                    val_7 = 0f;
            }
            
            val_7 = val_6 * val_7;
            return (float)val_7;
        }
        public static float ClockwiseAngle(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
        {
            float val_1 = Ferr.PathUtil.SignedAngle(v1:  new UnityEngine.Vector2() {x = v1.x, y = v1.y}, v2:  new UnityEngine.Vector2() {x = v2.x, y = v2.y});
            float val_3 = -180f;
            val_3 = (v1.x + val_3) + val_3;
            if()
            {
                    v1.x = val_3;
            }
            
            var val_4 = v1.x;
            val_4 = val_4 ^ 2147483648;
            return (float)val_3;
        }
        public static float CounterclockwiseAngle(UnityEngine.Vector2 v1, UnityEngine.Vector2 v2)
        {
            float val_1 = Ferr.PathUtil.SignedAngle(v1:  new UnityEngine.Vector2() {x = v2.x, y = v2.y}, v2:  new UnityEngine.Vector2() {x = v1.x, y = v1.y});
            float val_3 = -180f;
            val_3 = (v2.x + val_3) + val_3;
            if()
            {
                    v2.x = val_3;
            }
            
            var val_4 = v2.x;
            val_4 = val_4 ^ 2147483648;
            return (float)val_3;
        }
        public static int WrapIndex(int aIndex, int aCount, bool aClosed)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            if(aCount == 0)
            {
                    return (int)val_2;
            }
            
            if(aClosed != false)
            {
                    int val_1 = aCount + aCount;
                val_3 = aCount;
            }
            else
            {
                    if(aIndex < 0)
            {
                    return (int)val_2;
            }
            
                if(aIndex >= aCount)
            {
                    val_3 = aCount - 1;
            }
            
            }
            
            val_2 = val_3;
            return (int)val_2;
        }
        public static int IndexDistance(int aIndexStart, int aIndexEnd, int aCount, bool aClosed)
        {
            if(aCount == 0)
            {
                    aIndexStart = 0;
                return (int)aIndexStart;
            }
            
            aIndexStart = aIndexEnd - aIndexStart;
            if(aCount < 0)
            {
                    aIndexStart = aIndexStart + aCount;
            }
            
            return (int)aIndexStart;
        }
    
    }

}
