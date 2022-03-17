using UnityEngine;

namespace Ferr
{
    [Serializable]
    public class PathDistanceMask : List<Ferr.PathDMPoint>
    {
        // Fields
        private int _indexCount;
        
        // Properties
        public int IndexCount { get; }
        
        // Methods
        public int get_IndexCount()
        {
            return (int)this._indexCount;
        }
        public PathDistanceMask(System.Collections.Generic.List<UnityEngine.Vector2> aPath, bool aClosed)
        {
            int val_7;
            bool val_8;
            System.Collections.Generic.List<UnityEngine.Vector2> val_9;
            float val_10;
            float val_11;
            float val_12;
            var val_15;
            float val_16;
            var val_17;
            var val_18;
            var val_19;
            int val_20;
            var val_21;
            var val_22;
            int val_23;
            var val_24;
            val_7 = this;
            val_8 = aClosed;
            val_9 = aPath;
            int val_1 = 22999440 + 1;
            int val_6 = val_7;
            if(val_6 <= 0)
            {
                goto label_4;
            }
            
            val_10 = mem[(22999440 + 1) + 16];
            val_10 = (22999440 + 1) + 16;
            val_11 = mem[(22999440 + 1) + 20];
            val_11 = (22999440 + 1) + 20;
            val_12 = val_8 ^ 1;
            this._indexCount = val_6;
            val_6 = val_6 - val_12;
            if(val_6 < 1)
            {
                goto label_5;
            }
            
            var val_8 = 16;
            var val_7 = 0;
            do
            {
                if(R6 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + 1;
                val_11 = mem[aPath + 16 + 4];
                val_11 = aPath + 16 + 4;
                if(R6 <= R6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_15 = mem[aPath + 8];
                val_15 = aPath + 8;
            }
            
                var val_2 = val_15 + (R6 << 3);
                val_10 = val_7;
                float val_3 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = 6016616f, y = val_11}, b:  new UnityEngine.Vector2() {x = (aPath + 8 + (R6) << 3) + 16});
                val_12 = 0;
                val_7.Add(item:  new Ferr.PathDMPoint() {distance = 0f, percent = 0f, index = val_7 - 1});
                val_16 = 0f + 1253547216;
                val_9 = val_9;
                val_8 = val_8 + 8;
                val_17 = mem[aPath + 12];
                val_17 = aPath + 12;
            }
            while(val_7 != val_6);
            
            val_7 = val_7;
            val_8 = val_8;
            goto label_11;
            label_4:
            val_18 = 0;
            val_19 = 0;
            val_20 = 0;
            val_21 = 22737788;
            goto label_14;
            label_5:
            val_16 = 0f;
            label_11:
            if(val_8 != false)
            {
                    if(R6 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                float val_5 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = val_12}, b:  new UnityEngine.Vector2() {x = val_10, y = val_11});
                uint val_9 = 2621443;
                val_9 = val_16 + val_9;
                val_22 = 536878129;
                val_23 = val_6 - 1;
                val_24 = val_9;
            }
            else
            {
                    val_24 = 0;
                val_23 = R6 - 2;
                val_22 = 536878129;
            }
            
            val_18 = val_24;
            val_19 = 1065353216;
            val_20 = val_23;
            val_21 = 22737788;
            label_14:
            val_7.Add(item:  new Ferr.PathDMPoint() {distance = 0f, percent = 1f, index = val_20});
        }
        public PathDistanceMask(System.Collections.Generic.List<UnityEngine.Vector3> aPath, bool aClosed)
        {
            int val_5;
            var val_7;
            var val_8;
            var val_9;
            int val_10;
            var val_11;
            var val_12;
            int val_13;
            val_5 = this;
            int val_1 = 22999441 + 1;
            int val_6 = val_5;
            if(val_6 <= 0)
            {
                goto label_4;
            }
            
            bool val_5 = aClosed;
            this._indexCount = val_6;
            val_5 = val_5 ^ 1;
            val_6 = val_6 - val_5;
            if(val_6 < 1)
            {
                goto label_5;
            }
            
            float val_10 = 0f;
            var val_11 = 0;
            int val_7 = 0;
            do
            {
                if(val_5 <= val_7)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_7 = val_7 + 1;
                val_8 = val_8 + val_11;
                int val_2 = Ferr.PathUtil.WrapIndex(aIndex:  val_7, aCount:  val_5, aClosed:  aClosed);
                if(val_2 <= val_2)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_5 = val_2 + (val_2 << 1);
                val_9 = val_9 + (val_5 << 2);
                float val_3 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = (0 + 0) + 16, y = (0 + 0) + 20, z = (0 + 0) + 24}, b:  new UnityEngine.Vector3() {x = (0 + ((val_2 + (val_2) << 1)) << 2) + 16, y = (0 + ((val_2 + (val_2) << 1)) << 2) + 20, z = (0 + ((val_2 + (val_2) << 1)) << 2) + 24});
                val_5 = val_5;
                this.Add(item:  new Ferr.PathDMPoint() {distance = 0f, percent = 0f, index = val_7 - 1});
                val_10 = val_10 + ((0 + 0) + 16);
                val_11 = val_11 + 12;
            }
            while(val_7 != val_6);
            
            val_7 = val_10;
            goto label_11;
            label_4:
            val_8 = 0;
            val_9 = 0;
            val_10 = 0;
            val_11 = 22737788;
            goto label_14;
            label_5:
            val_7 = 0;
            label_11:
            if(aClosed == false)
            {
                goto label_15;
            }
            
            val_12 = 536878129;
            val_13 = val_6 - 1;
            if(mem[536878316] != true)
            {
                goto label_16;
            }
            
            goto label_19;
            label_15:
            val_12 = 536878129;
            val_13 = val_5 - 2;
            if((mem[536878316] & true) != 0)
            {
                goto label_19;
            }
            
            label_16:
            label_19:
            val_8 = val_7;
            val_9 = 1065353216;
            val_10 = val_13;
            val_11 = 22737788;
            label_14:
            val_5.Add(item:  new Ferr.PathDMPoint() {distance = 0f, percent = 1f, index = val_10});
        }
        public PathDistanceMask(System.Collections.Generic.List<UnityEngine.Vector2> aPath, System.Collections.Generic.List<int> aMapping, bool aClosed)
        {
            Ferr.PathDistanceMask val_10;
            System.Collections.Generic.List<Ferr.PathDMPoint> val_11;
            System.Collections.Generic.List<UnityEngine.Vector2> val_12;
            float val_13;
            int val_14;
            var val_15;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_10 = this;
            val_11 = aMapping;
            val_12 = aPath;
            val_13 = 4.012819E-38f;
            val_11 = new System.Collections.Generic.List<Ferr.PathDMPoint>();
            if(val_11 <= 0)
            {
                goto label_4;
            }
            
            bool val_1 = aClosed ^ 1;
            this._indexCount = val_11;
            val_11 = val_11 - val_1;
            if(val_11 < 1)
            {
                goto label_5;
            }
            
            float val_15 = 0f;
            var val_16 = 16;
            val_14 = 0;
            var val_14 = 0;
            val_15 = 0;
            do
            {
                val_1 = val_11 - 1;
                if(val_14 < val_1)
            {
                    float val_2 = val_14 + 1;
                if(val_11 <= val_2)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13 = val_13 + (val_2 << 2);
                if(val_14 == ((0 + ((val_14 + 1)) << 2) + 16))
            {
                    val_15 = 0;
                val_14 = val_2;
            }
            
            }
            
                if(val_14 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_14 = val_14 + 1;
                if(val_14 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_17 = mem[aPath + 8];
                val_17 = aPath + 8;
            }
            
                var val_3 = val_17 + (val_14 << 3);
                float val_4 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_2, y = aPath + 16 + 4}, b:  new UnityEngine.Vector2() {x = (aPath + 8 + ((val_14 + 1)) << 3) + 16, y = aClosed});
                val_10 = val_10;
                this.Add(item:  new Ferr.PathDMPoint() {distance = 0f, percent = 0f, index = val_14});
                val_15 = val_15 + val_2;
                val_11 = val_11;
                val_16 = val_16 + 8;
                val_12 = val_12;
            }
            while(val_11 != val_14);
            
            val_18 = val_15;
            val_13 = 4.012819E-38f;
            goto label_14;
            label_4:
            val_11.Add(item:  new Ferr.PathDMPoint() {distance = 0f, percent = 0f});
            return;
            label_5:
            val_18 = 0;
            label_14:
            if(aClosed != false)
            {
                    val_11.Add(item:  new Ferr.PathDMPoint() {distance = 0f, percent = 1f, index = val_1 - 1});
            }
            else
            {
                    val_11.Add(item:  new Ferr.PathDMPoint() {distance = 0f, percent = 1f, index = val_1 - 2});
            }
            
            float val_7 = this.GetTotalDistance();
            var val_17 = 536878129;
            int val_8 = val_17 - 2;
            if(val_8 < 0)
            {
                    return;
            }
            
            val_17 = val_17 + 1073756258;
            val_20 = 1253791696;
            var val_9 = R6 - 1;
            var val_10 = val_17 << 2;
            val_12 = 22737804;
            do
            {
                if(val_17 <= val_9)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_18 = val_18 + (val_9 << 2);
                if(((0 + ((R6 - 1)) << 2) + 16) > val_8)
            {
                    if(536878129 <= (val_8 + 1))
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = val_9 - 1;
                val_19 = val_19 + val_10;
                val_20 = mem[(0 + ((536878129 + 1073756258) << 2)) + 4];
                val_20 = (0 + ((536878129 + 1073756258) << 2)) + 4;
            }
            
                if(536878129 <= val_8)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                float val_20 = 0 + ((536878129 + 1073756258) << 2) + -4;
                val_20 = (0 + ((536878129 + 1073756258) << 2) + -8) - val_20;
                val_20 = val_20 / (val_20 - val_20);
                val_11.set_Item(index:  val_8, value:  new Ferr.PathDMPoint() {distance = 0 + ((536878129 + 1073756258) << 2) + -8, percent = val_20, index = 0 + ((536878129 + 1073756258) << 2)});
                val_8 = val_8 - 1;
                val_19 = val_10 - 12;
            }
            while(val_8 > 1);
        
        }
        public float GetTotalDistance()
        {
            float val_2;
            bool val_1 = true;
            if(val_1 >= 1)
            {
                    val_1 = val_1 + 2;
                val_1 = R1 + (val_1 << 2);
                val_2 = mem[(R1 + ((true + 2)) << 2) + 4];
                val_2 = (R1 + ((true + 2)) << 2) + 4;
                return val_2;
            }
            
            val_2 = 0f;
            return val_2;
        }
        public float DistanceBetweenSmoothIndices(int aSmoothVertStart, int aSmoothVertEnd)
        {
            var val_4;
            var val_6;
            val_4 = aSmoothVertEnd;
            if(val_4 < aSmoothVertStart)
            {
                    if(true <= aSmoothVertStart)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = aSmoothVertStart + (aSmoothVertStart << 1);
                val_3 = val_3 + (val_4 << 2);
                float val_1 = this.GetTotalDistance();
                if(this <= aSmoothVertStart)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_4 = val_4 + (val_4 << 2);
                var val_5 = (0 + ((aSmoothVertStart + (aSmoothVertStart) << 1)) << 2) + 16;
                val_5 = 1254023888 - val_5;
                val_6 = ((0 + ((aSmoothVertStart + (aSmoothVertStart) << 1)) << 2) + 16) + val_5;
                return (float)val_6;
            }
            
            if(true <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            aSmoothVertEnd = val_4 + (val_4 << 1);
            aSmoothVertEnd = aSmoothVertStart + (aSmoothVertEnd << 2);
            if(0 <= aSmoothVertStart)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_2 = aSmoothVertStart + (aSmoothVertStart << 1);
            val_2 = aSmoothVertStart + (val_2 << 2);
            val_6 = ((aSmoothVertStart + ((aSmoothVertEnd + (aSmoothVertEnd) << 1)) << 2) + 16) - ((aSmoothVertStart + ((aSmoothVertStart + (aSmoothVertStart) << 1)) << 2) + 16);
            return (float)val_6;
        }
        public float DistanceBetweenDistances(float aStartDistance, float aEndDistance)
        {
            var val_3;
            if()
            {
                    float val_1 = this.GetTotalDistance();
                uint val_2 = 1254135888;
                val_2 = val_2 - R1;
                val_3 = val_2 + R2;
                return (float)val_3;
            }
            
            val_3 = R2 - R1;
            return (float)val_3;
        }
        public UnityEngine.Vector2 GetPointAtPercent(System.Collections.Generic.List<UnityEngine.Vector2> aSmoothPoints, int aRawIndex, float aPercent)
        {
            var val_5;
            var val_17;
            float val_19;
            var val_20;
            float val_21;
            var val_23;
            var val_24;
            int val_17 = R3;
            UnityEngine.Debug.Log(message:  -1610602913);
            int val_15 = val_17;
            int val_1 = aSmoothPoints.GetSmoothIndexAt(aRawIndex:  val_15);
            val_17 = val_1;
            if(val_15 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_17 + (val_17 << 1);
            var val_2 = 0 + (val_19 << 2);
            val_20 = mem[(0 + ((val_1 + (val_1) << 1)) << 2) + 20];
            val_20 = (0 + ((val_1 + (val_1) << 1)) << 2) + 20;
            val_21 = val_20;
            if(val_15 <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_3 = 0 + (val_19 << 2);
                val_21 = mem[(0 + ((val_1 + (val_1) << 1)) << 2) + 20];
                val_21 = (0 + ((val_1 + (val_1) << 1)) << 2) + 20;
            }
            
            int val_4 = val_17 + 1;
            if(val_4 >= val_15)
            {
                goto label_15;
            }
            
            val_19 = 32 + (val_19 << 2);
            label_11:
            val_17 = val_4;
            if(val_15 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = 0 + val_19;
            if(((0 + (32 + ((val_1 + (val_1) << 1)) << 2)) + 4) != val_17)
            {
                goto label_7;
            }
            
            if(((0 + (32 + ((val_1 + (val_1) << 1)) << 2)) + 4) <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(((0 + (32 + ((val_1 + (val_1) << 1)) << 2)) + 4) >= val_17)
            {
                goto label_9;
            }
            
            if(((0 + (32 + ((val_1 + (val_1) << 1)) << 2)) + 4) <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + 12;
            val_20 = mem[(0 + (32 + ((val_1 + (val_1) << 1)) << 2))];
            val_20 = 0 + val_19;
            if((val_17 + 1) < ((0 + (32 + ((val_1 + (val_1) << 1)) << 2)) + 4))
            {
                goto label_11;
            }
            
            goto label_15;
            label_7:
            val_21 = 1f;
            goto label_15;
            label_9:
            if(((0 + (32 + ((val_1 + (val_1) << 1)) << 2)) + 4) > val_17)
            {
                    val_21 = 0 + val_19;
            }
            else
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_16 = val_16 + val_19;
                val_21 = mem[(0 + (32 + ((val_1 + (val_1) << 1)) << 2))];
                val_21 = val_16;
            }
            
            label_15:
            val_23 = mem[aRawIndex + 12];
            val_23 = aRawIndex + 12;
            val_17 = val_17 - 1;
            if(val_23 <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_23 = mem[aRawIndex + 12];
                val_23 = aRawIndex + 12;
            }
            
            val_24 = mem[aRawIndex + 8];
            val_24 = aRawIndex + 8;
            var val_9 = val_24 + (val_17 << 3);
            if(val_23 <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_24 = mem[aRawIndex + 8];
                val_24 = aRawIndex + 8;
            }
            
            float val_10 = val_21 - val_20;
            val_24 = val_24 + (val_17 << 3);
            val_10 = (val_5 - val_20) / val_10;
            float val_12 = UnityEngine.Mathf.Clamp01(value:  val_10);
            float val_13 = ((aRawIndex + 8 + ((val_1 + 1)) << 3) + 20) - val_19;
            float val_14 = ((aRawIndex + 8 + ((val_1 + 1)) << 3) + 16) - ((aRawIndex + 8 + (((val_1 + 1) - 1)) << 3) + 16);
            mem[1152921510156066260] = val_19;
            this = (aRawIndex + 8 + (((val_1 + 1) - 1)) << 3) + 16;
            return new UnityEngine.Vector2() {x = val_19};
        }
        public UnityEngine.Vector2 GetPointAtDistance(System.Collections.Generic.List<UnityEngine.Vector2> aPoints, float aDistance, bool aClosed)
        {
            bool val_1;
            int val_6;
            int val_3 = aPoints.GetSmoothPointIndexAtDistance(aDistance:  aDistance, aPercent: out  R3, aWrap:  true);
            val_6 = mem[aClosed + 12];
            val_6 = aClosed + 12;
            if(val_6 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_6 = mem[aClosed + 12];
                val_6 = aClosed + 12;
            }
            
            var val_6 = aClosed + 8;
            val_6 = val_6 + (val_3 << 3);
            int val_5 = Ferr.PathUtil.WrapIndex(aIndex:  val_3 + 1, aCount:  val_6, aClosed:  val_1);
            if((aClosed + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = aClosed + 8;
            val_7 = val_7 + (val_5 << 3);
            var val_8 = (aClosed + 8 + (val_5) << 3) + 16;
            var val_9 = (aClosed + 8 + (val_5) << 3) + 20;
            val_8 = val_8 - ((aClosed + 8 + (val_3) << 3) + 16);
            val_9 = val_9 - ((aClosed + 8 + (val_3) << 3) + 20);
            this = (aClosed + 8 + (val_3) << 3) + 16;
            mem[1152921510156186452] = (aClosed + 8 + (val_3) << 3) + 20;
            return new UnityEngine.Vector2() {x = (aClosed + 8 + (val_3) << 3) + 20};
        }
        public UnityEngine.Vector3 GetPointAtDistance(System.Collections.Generic.List<UnityEngine.Vector3> aPoints, float aDistance, bool aClosed)
        {
            bool val_1;
            int val_7;
            int val_3 = aPoints.GetSmoothPointIndexAtDistance(aDistance:  aDistance, aPercent: out  R3, aWrap:  true);
            val_7 = mem[aClosed + 12];
            val_7 = aClosed + 12;
            if(val_7 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_7 = mem[aClosed + 12];
                val_7 = aClosed + 12;
            }
            
            var val_7 = aClosed + 8;
            val_7 = val_7 + ((val_3 + (val_3 << 1)) << 2);
            int val_6 = Ferr.PathUtil.WrapIndex(aIndex:  val_3 + 1, aCount:  val_7, aClosed:  val_1);
            if((aClosed + 12) <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = aClosed + 8;
            val_7 = val_6 + (val_6 << 1);
            val_8 = val_8 + (val_7 << 2);
            float val_9 = (aClosed + 8 + ((val_6 + (val_6) << 1)) << 2) + 16;
            float val_10 = (aClosed + 8 + ((val_6 + (val_6) << 1)) << 2) + 20;
            var val_11 = (aClosed + 8 + ((val_6 + (val_6) << 1)) << 2) + 24;
            val_9 = val_9 - ((aClosed + 8 + ((val_3 + (val_3) << 1)) << 2) + 16);
            val_10 = val_10 - ((aClosed + 8 + ((val_3 + (val_3) << 1)) << 2) + 20);
            val_11 = val_11 - ((aClosed + 8 + ((val_3 + (val_3) << 1)) << 2) + 24);
            this = (aClosed + 8 + ((val_3 + (val_3) << 1)) << 2) + 16;
            mem[1152921510156306644] = (aClosed + 8 + ((val_3 + (val_3) << 1)) << 2) + 20;
            mem[1152921510156306648] = (aClosed + 8 + ((val_3 + (val_3) << 1)) << 2) + 24;
            return new UnityEngine.Vector3() {x = val_9, z = val_10};
        }
        public UnityEngine.Vector2 GetNormAtDistance(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aDistance, bool aClosed)
        {
            UnityEngine.Vector2 val_4 = Ferr.PathUtil.GetSegmentNormal(i:  1254600520, aPath:  aPath.GetSmoothPointIndexAtDistance(aDistance:  aDistance, aPercent: out  R3, aWrap:  true), aClosed:  aClosed);
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public UnityEngine.Vector2 GetNormWeightedAtDistance(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aDistance, bool aClosed)
        {
            Ferr.PathDistanceMask val_6;
            float val_7;
            int val_3 = aPath.GetSmoothPointIndexAtDistance(aDistance:  aDistance, aPercent: out  R3, aWrap:  true);
            UnityEngine.Vector2 val_4 = Ferr.PathUtil.GetPointNormalWeighted(i:  1254720708, aPath:  val_3, aClosed:  aClosed);
            UnityEngine.Vector2 val_8 = Ferr.PathUtil.GetPointNormalWeighted(i:  1254720708, aPath:  val_3 + 1, aClosed:  aClosed);
            float val_9 = val_6;
            var val_10 = val_7;
            val_9 = val_9 - val_6;
            val_10 = val_10 - val_7;
            this = val_6;
            mem[1152921510156547028] = val_7;
            return new UnityEngine.Vector2() {x = val_9, y = val_8.y};
        }
        public UnityEngine.Vector2 GetTangentAtDistance(System.Collections.Generic.List<UnityEngine.Vector2> aPath, float aDistance, bool aClosed)
        {
            UnityEngine.Vector2 val_4 = Ferr.PathUtil.GetSegmentTangent(i:  1254840904, aPath:  aPath.GetSmoothPointIndexAtDistance(aDistance:  aDistance, aPercent: out  R3, aWrap:  true), aClosed:  aClosed);
            return new UnityEngine.Vector2() {x = val_4.x, y = val_4.y};
        }
        public float GetDistanceAtIndex(int aRawIndex)
        {
            if(true < 1)
            {
                    return this.GetTotalDistance();
            }
            
            var val_2 = 0;
            label_4:
            if(true <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = 0 + 0;
            if(((0 + 0) + 24) == aRawIndex)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            22999448 = 0 + 12;
            if(val_2 < 0)
            {
                goto label_4;
            }
            
            return this.GetTotalDistance();
            label_3:
            if(((0 + 0) + 24) <= val_2)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            return (float)S0;
        }
        public int GetSmoothIndexAt(int aRawIndex)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = 22999449;
            val_2 = 0;
            if(true < 1)
            {
                    return (int)val_2;
            }
            
            val_3 = 0;
            val_1 = 24;
            label_4:
            if(true <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 == aRawIndex)
            {
                goto label_3;
            }
            
            val_3 = val_3 + 1;
            val_1 = val_1 + 12;
            if(val_3 < 0)
            {
                goto label_4;
            }
            
            return (int)val_2;
            label_3:
            val_2 = val_3;
            return (int)val_2;
        }
        public int GetRawPointIndexAtDistance(float aDistance, out float aPercent, bool aWrap)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_4 = R3;
            val_5 = aWrap;
            val_6 = 1152921510157043344;
            float val_1 = this.GetTotalDistance();
            if(val_4 != 0)
            {
                    uint val_12 = 1255229072;
                val_12 = 1255197072 + val_12;
            }
            
            val_7 = 0;
            mem2[0] = val_7;
            if(val_4 >= 0)
            {
                goto label_2;
            }
            
            if(val_4 <= 0)
            {
                    return (int)val_7;
            }
            
            label_7:
            val_4 = -1;
            var val_13 = 0;
            label_6:
            if(val_4 != val_13)
            {
                    val_7 = 1;
            }
            
            if(val_7 == val_4)
            {
                goto label_4;
            }
            
            var val_2 = val_4 - val_13;
            val_2 = val_2 + (val_2 >> 31);
            val_13 = val_13 + (val_2 >> 1);
            if(this <= val_13)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + ((val_13 + (val_13 << 1)) << 2);
            if(this < 0)
            {
                goto label_6;
            }
            
            goto label_7;
            label_2:
            mem2[0] = 1065353216;
            val_7 = this._indexCount - 1;
            return (int)val_7;
            label_4:
            if(val_7 <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = val_13 + 0;
            var val_5 = 0 + (val_4 << 2);
            if(val_7 > val_13)
            {
                goto label_10;
            }
            
            if(val_5 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_4 + 4294967294;
            var val_6 = 0 + (val_6 << 2);
            if(val_5 >= val_4)
            {
                goto label_12;
            }
            
            label_10:
            val_5 = 536882211;
            mem[536882227] = 536893745;
            float val_7 = this.GetTotalDistance();
            mem[536882231] = 536893745;
            if(536882231 <= val_13)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + (val_4 << 2);
            val_6 = 536893745;
            mem[536882235] = val_6;
            if(536882235 <= val_4)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + ((val_4 + 4294967294) << 2);
            mem[536882239] = 536893745;
            UnityEngine.Debug.LogFormat(format:  -1610605591, args:  536882211);
            val_7 = 0;
            return (int)val_7;
            label_12:
            if(val_6 <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = 0 + (val_4 << 2);
            if(val_6 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = 0 + (val_6 << 2);
            if(val_6 <= val_13)
            {
                    var val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + (val_4 << 2);
            float val_18 = (0 + ((0 + 0)) << 2) + 16;
            val_18 = ((0 + ((val_4 + 4294967294)) << 2) + 16) - val_18;
            val_18 = (val_12 - ((0 + ((0 + 0)) << 2) + 16)) / val_18;
            mem2[0] = val_18;
            if(val_17 <= val_13)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + (val_4 << 2);
            val_7 = mem[(0 + ((0 + 0)) << 2) + 24];
            val_7 = (0 + ((0 + 0)) << 2) + 24;
            return (int)val_7;
        }
        public int GetSmoothPointIndexAtDistance(float aDistance, out float aPercent, bool aWrap)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_12 = R3;
            val_13 = aWrap;
            val_14 = 22999451;
            float val_1 = this.GetTotalDistance();
            if(val_12 != 0)
            {
                    val_14 = this;
                uint val_13 = 1255349136;
                val_13 = 1255317136 + val_13;
            }
            
            val_15 = 0;
            mem2[0] = val_15;
            if(val_12 >= 0)
            {
                goto label_2;
            }
            
            if(val_12 <= 0)
            {
                    return (int)val_15;
            }
            
            label_7:
            val_14 = val_13 - 1;
            var val_14 = 0;
            label_6:
            val_15 = val_14;
            if(val_14 != val_14)
            {
                    val_13 = 1;
            }
            
            if(val_13 == val_14)
            {
                goto label_4;
            }
            
            float val_3 = val_14 - val_15;
            val_3 = val_3 + (val_3 >> 31);
            val_14 = val_15 + (val_3 >> 1);
            if(val_14 <= val_14)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + ((val_14 + (val_14 << 1)) << 2);
            if(val_14 < 0)
            {
                goto label_6;
            }
            
            goto label_7;
            label_2:
            mem2[0] = 1065353216;
            val_15 = this._indexCount - 1;
            return (int)val_15;
            label_4:
            if(val_13 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = val_15 + 0;
            var val_6 = 0 + (val_5 << 2);
            if(val_13 > val_15)
            {
                goto label_10;
            }
            
            if(val_6 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_14 + (val_14 << 1);
            var val_7 = 0 + (val_12 << 2);
            if(val_6 >= val_14)
            {
                goto label_12;
            }
            
            label_10:
            val_13 = 536882211;
            mem[536882227] = 536893745;
            float val_8 = this.GetTotalDistance();
            val_12 = 536893745;
            mem[536882231] = val_12;
            if(536882231 <= val_15)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + (val_5 << 2);
            mem[536882235] = 536893745;
            if((1.085666E-19f) <= val_14)
            {
                    var val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + ((val_14 + (val_14 << 1)) << 2);
            mem[536882239] = 536893745;
            UnityEngine.Debug.LogFormat(format:  -1610605591, args:  536882211);
            val_15 = 0;
            return (int)val_15;
            label_12:
            if(val_7 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = 0 + (val_5 << 2);
            if(val_7 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_11 = 0 + (val_12 << 2);
            if(val_7 <= val_15)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + (val_5 << 2);
            float val_19 = (0 + ((val_15 + 0)) << 2) + 16;
            val_19 = ((0 + ((((1255317136 + 1255349136) - 1) + (((1255317136 + 1255349136) - 1)) << 1)) << 2) + 16) - val_19;
            val_19 = (val_13 - ((0 + ((val_15 + 0)) << 2) + 16)) / val_19;
            mem2[0] = val_19;
            return (int)val_15;
        }
        public bool IsRawPoint(int aSmoothIndex, bool aClosed)
        {
            int val_3 = aSmoothIndex;
            if(val_3 == 0)
            {
                    return true;
            }
            
            if(true <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_1 = val_3 + (val_3 << 1);
            val_3 = val_3 - 1;
            val_1 = aSmoothIndex + (val_1 << 2);
            if(0 <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_2 = val_3 + (val_3 << 1);
            val_2 = aSmoothIndex + (val_2 << 2);
            var val_4 = (aSmoothIndex + (((aSmoothIndex - 1) + ((aSmoothIndex - 1)) << 1)) << 2) + 24;
            val_4 = ((aSmoothIndex + ((aSmoothIndex + (aSmoothIndex) << 1)) << 2) + 24) - val_4;
            if(0 != val_3)
            {
                    val_4 = 1;
            }
            
            return true;
        }
        public Ferr.PathDMPoint GetDataAtDistance(float aDistance, bool aWrap)
        {
            Ferr.PathDistanceMask val_19;
            float val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            int val_26;
            float val_27;
            var val_28;
            var val_29;
            val_19 = R2;
            float val_1 = aWrap.GetTotalDistance();
            if(R3 != 0)
            {
                    val_20 = aWrap + R2;
                val_19 = val_20;
            }
            
            var val_2 = (aWrap + 12) - 1;
            label_5:
            var val_19 = 0;
            label_4:
            if(val_2 != val_19)
            {
                    aWrap + 12 = 1;
            }
            
            if((aWrap + 12) == val_2)
            {
                goto label_2;
            }
            
            var val_3 = val_2 - val_19;
            val_3 = val_3 + (val_3 >> 31);
            val_19 = val_19 + (val_3 >> 1);
            if((aWrap + 12) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_20 = aWrap + 8;
            val_20 = val_20 + ((val_19 + (val_19 << 1)) << 2);
            if((aWrap + 12) < 0)
            {
                goto label_4;
            }
            
            goto label_5;
            label_2:
            val_21 = mem[aWrap + 12];
            val_21 = aWrap + 12;
            if(val_21 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_21 = mem[aWrap + 12];
                val_21 = aWrap + 12;
            }
            
            val_22 = mem[aWrap + 8];
            val_22 = aWrap + 8;
            var val_5 = val_19 + 0;
            var val_6 = val_22 + (val_5 << 2);
            var val_21 = (aWrap + 8 + ((0 + 0)) << 2) + 16;
            if(val_21 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_22 = mem[aWrap + 8];
                val_22 = aWrap + 8;
                val_21 = mem[aWrap + 12];
                val_21 = aWrap + 12;
            }
            
            var val_7 = val_2 + (val_2 << 1);
            var val_8 = val_22 + (val_7 << 2);
            var val_22 = (aWrap + 8 + (((aWrap + 12 - 1) + ((aWrap + 12 - 1)) << 1)) << 2) + 16;
            if(val_21 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_22 = mem[aWrap + 8];
                val_22 = aWrap + 8;
                val_21 = mem[aWrap + 12];
                val_21 = aWrap + 12;
            }
            
            var val_9 = val_22 + (val_5 << 2);
            if(val_21 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_22 = mem[aWrap + 8];
                val_22 = aWrap + 8;
                val_21 = mem[aWrap + 12];
                val_21 = aWrap + 12;
            }
            
            val_21 = val_19 - val_21;
            var val_10 = val_22 + (val_5 << 2);
            val_22 = val_22 - ((aWrap + 8 + ((0 + 0)) << 2) + 16);
            if(val_21 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_22 = mem[aWrap + 8];
                val_22 = aWrap + 8;
                val_21 = mem[aWrap + 12];
                val_21 = aWrap + 12;
            }
            
            val_21 = val_21 / val_22;
            var val_11 = val_22 + (val_7 << 2);
            if(((aWrap + 8 + ((0 + 0)) << 2) + 24) == ((aWrap + 8 + (((aWrap + 12 - 1) + ((aWrap + 12 - 1)) << 1)) << 2) + 24))
            {
                    if(val_21 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_23 = mem[aWrap + 8];
                val_23 = aWrap + 8;
                val_24 = mem[aWrap + 12];
                val_24 = aWrap + 12;
            }
            
                var val_12 = val_23 + (val_5 << 2);
                val_25 = mem[(aWrap + 8 + ((0 + 0)) << 2) + 24];
                val_25 = (aWrap + 8 + ((0 + 0)) << 2) + 24;
                if(val_24 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_23 = mem[aWrap + 8];
                val_23 = aWrap + 8;
                val_24 = mem[aWrap + 12];
                val_24 = aWrap + 12;
            }
            
                var val_13 = val_23 + (val_5 << 2);
                if(val_24 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_23 = mem[aWrap + 8];
                val_23 = aWrap + 8;
            }
            
                val_23 = val_23 + (val_7 << 2);
                val_26 = val_21;
                val_27 = mem[(aWrap + 8 + (((aWrap + 12 - 1) + ((aWrap + 12 - 1)) << 1)) << 2) + 20];
                val_27 = (aWrap + 8 + (((aWrap + 12 - 1) + ((aWrap + 12 - 1)) << 1)) << 2) + 20;
                float val_14 = UnityEngine.Mathf.Lerp(a:  val_20, b:  null, t:  null);
                val_28 = (aWrap + 8 + ((0 + 0)) << 2) + 20;
            }
            else
            {
                    if(val_21 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_27 = mem[aWrap + 8];
                val_27 = aWrap + 8;
                val_29 = mem[aWrap + 12];
                val_29 = aWrap + 12;
            }
            
                var val_15 = val_27 + (val_5 << 2);
                var val_23 = (aWrap + 8 + ((0 + 0)) << 2) + 20;
                if(val_29 <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_27 = mem[aWrap + 8];
                val_27 = aWrap + 8;
                val_29 = mem[aWrap + 12];
                val_29 = aWrap + 12;
            }
            
                var val_16 = val_27 + (val_7 << 2);
                if(val_29 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_27 = mem[aWrap + 8];
                val_27 = aWrap + 8;
                val_29 = mem[aWrap + 12];
                val_29 = aWrap + 12;
            }
            
                val_23 = 1f - val_23;
                val_26 = val_27 + (val_5 << 2);
                val_25 = mem[(aWrap + 8 + ((0 + 0)) << 2) + 24];
                val_25 = (aWrap + 8 + ((0 + 0)) << 2) + 24;
                if(val_29 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_27 = mem[aWrap + 8];
                val_27 = aWrap + 8;
            }
            
                float val_17 = val_23 + ((aWrap + 8 + (((aWrap + 12 - 1) + ((aWrap + 12 - 1)) << 1)) << 2) + 20);
                var val_18 = val_27 + (val_5 << 2);
            }
            
            this = val_19;
            mem[1152921510157359444] = (aWrap + 8 + ((0 + 0)) << 2) + 20;
            mem[1152921510157359448] = val_25;
            return new Ferr.PathDMPoint() {distance = 7015592f, percent = val_27, index = val_26};
        }
    
    }

}
