using UnityEngine;

namespace GameTool
{
    public static class MMMaths
    {
        // Methods
        public static UnityEngine.Vector2 Vector3ToVector2(UnityEngine.Vector3 target)
        {
            return new UnityEngine.Vector2();
        }
        public static UnityEngine.Vector3 Vector2ToVector3(UnityEngine.Vector2 target)
        {
            return new UnityEngine.Vector3();
        }
        public static UnityEngine.Vector3 Vector2ToVector3(UnityEngine.Vector2 target, float newZValue)
        {
            return new UnityEngine.Vector3() {x = newZValue};
        }
        public static UnityEngine.Vector3 RoundVector3(UnityEngine.Vector3 vector)
        {
            var val_1;
            var val_5;
            float val_6;
            float val_7;
            float val_8;
            var val_9;
            float val_10;
            float val_11;
            float val_12;
            var val_13;
            float val_14;
            float val_15;
            float val_16;
            if()
            {
                goto label_0;
            }
            
            if()
            {
                goto label_1;
            }
            
            val_5 = val_1;
            val_6 = -1f;
            goto label_2;
            label_0:
            if()
            {
                goto label_3;
            }
            
            val_5 = val_1;
            val_6 = 1f;
            label_2:
            float val_2 = S18 + val_6;
            if((vector.y & (1.401298E-45f)) != 0)
            {
                    val_7 = S18;
            }
            
            goto label_4;
            label_1:
            float val_5 = -0.5f;
            val_5 = vector.y + val_5;
            val_8 = val_5;
            goto label_5;
            label_3:
            float val_6 = 0.5f;
            val_6 = vector.y + val_6;
            val_8 = val_6;
            label_5:
            val_7 = val_8;
            label_4:
            if()
            {
                goto label_6;
            }
            
            if()
            {
                goto label_7;
            }
            
            val_9 = val_1;
            val_10 = -1f;
            goto label_8;
            label_6:
            if()
            {
                goto label_9;
            }
            
            val_9 = val_1;
            val_10 = 1f;
            label_8:
            float val_3 = S20 + val_10;
            if((vector.y & (1.401298E-45f)) != 0)
            {
                    val_11 = S20;
            }
            
            goto label_10;
            label_7:
            float val_7 = -0.5f;
            val_7 = vector.z + val_7;
            val_12 = val_7;
            goto label_11;
            label_9:
            float val_8 = 0.5f;
            val_8 = vector.z + val_8;
            val_12 = val_8;
            label_11:
            val_11 = val_12;
            label_10:
            if()
            {
                goto label_12;
            }
            
            if()
            {
                goto label_13;
            }
            
            val_13 = val_1;
            val_14 = -1f;
            goto label_14;
            label_12:
            if()
            {
                goto label_15;
            }
            
            val_13 = val_1;
            val_14 = 1f;
            label_14:
            float val_4 = S22 + val_14;
            if((vector.y & (1.401298E-45f)) != 0)
            {
                    val_15 = S22;
            }
            
            goto label_16;
            label_13:
            val_14 = R3 + (-0.5f);
            val_16 = val_14;
            goto label_17;
            label_15:
            val_14 = R3 + 0.5f;
            val_16 = val_14;
            label_17:
            val_15 = val_16;
            label_16:
            mem2[0] = val_7;
            mem2[0] = val_11;
            mem2[0] = val_15;
            return new UnityEngine.Vector3() {x = val_14};
        }
        public static UnityEngine.Vector3 RandomVector3(UnityEngine.Vector3 minimum, UnityEngine.Vector3 maximum)
        {
            mem2[0] = minimum.y;
            mem2[0] = minimum.z;
            mem2[0] = maximum.x;
            return new UnityEngine.Vector3() {x = UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null), maxInclusive:  null), maxInclusive:  null)};
        }
        public static UnityEngine.Vector3 RotatePointAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, float angle)
        {
            var val_1;
            float val_4 = 0.01745329f;
            val_4 = val_1 * val_4;
            float val_5 = point.y;
            float val_6 = val_4;
            val_5 = (val_5 - pivot.y) * val_4;
            mem2[0] = 0;
            val_6 = (point.z - pivot.z) * val_6;
            val_5 = val_5 + pivot.y;
            val_6 = val_6 + pivot.z;
            mem2[0] = val_5;
            mem2[0] = val_6;
            return new UnityEngine.Vector3() {x = val_6, z = val_5};
        }
        public static UnityEngine.Vector3 RotatePointAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Vector3 angle)
        {
            float val_2;
            float val_4;
            float val_5;
            float val_6;
            UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 191.6465f, y = angle.y, z = angle.z});
            float val_8 = point.z;
            float val_7 = pivot.x;
            float val_9 = point.y;
            val_7 = val_7 - angle.x;
            val_8 = val_8 - pivot.z;
            val_9 = val_9 - pivot.y;
            UnityEngine.Vector3 val_3 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 191.6465f}, point:  new UnityEngine.Vector3() {x = val_2, y = val_9, z = val_8});
            float val_10 = val_4;
            float val_11 = val_5;
            float val_12 = val_6;
            val_10 = val_10 + pivot.y;
            val_11 = val_11 + pivot.z;
            val_12 = val_12 + angle.x;
            mem2[0] = val_10;
            mem2[0] = val_11;
            mem2[0] = val_12;
            return new UnityEngine.Vector3() {x = val_10, y = val_3.y, z = val_11};
        }
        public static UnityEngine.Vector3 RotatePointAroundPivot(UnityEngine.Vector3 point, UnityEngine.Vector3 pivot, UnityEngine.Quaternion quaternion)
        {
            float val_1;
            float val_3;
            float val_4;
            float val_5;
            float val_8 = point.y;
            float val_6 = pivot.x;
            float val_7 = point.z;
            val_6 = val_6 - quaternion.x;
            val_7 = val_7 - pivot.z;
            val_8 = val_8 - pivot.y;
            UnityEngine.Vector3 val_2 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 193.3558f, y = quaternion.y, z = quaternion.z, w = quaternion.w}, point:  new UnityEngine.Vector3() {x = val_1, y = val_8, z = val_7});
            float val_9 = val_3;
            float val_10 = val_4;
            float val_11 = val_5;
            val_9 = val_9 + pivot.y;
            val_10 = val_10 + pivot.z;
            val_11 = val_11 + quaternion.x;
            mem2[0] = val_9;
            mem2[0] = val_10;
            mem2[0] = val_11;
            return new UnityEngine.Vector3() {x = val_9, y = val_2.y, z = val_10};
        }
        public static UnityEngine.Vector2 RotateVector2(UnityEngine.Vector2 vector, float angle)
        {
            float val_2 = R3;
            if()
            {
                    mem2[0] = vector.y;
                mem2[0] = R2;
                return new UnityEngine.Vector2() {x = val_2};
            }
            
            val_2 = val_2 * 0.01745329f;
            float val_3 = val_2;
            val_3 = val_3 * R2;
            mem2[0] = val_3 * vector.y;
            mem2[0] = val_3;
            return new UnityEngine.Vector2() {x = vector.y};
        }
        public static float AngleBetween(UnityEngine.Vector2 vectorA, UnityEngine.Vector2 vectorB)
        {
            bool val_8;
            float val_9;
            float val_1 = vectorA.x.sqrMagnitude;
            float val_2 = vectorB.x.sqrMagnitude;
            if(mem[536890411] >= _TYPE_MAX_)
            {
                    float val_8 = 1128580604 * 1128580616;
            }
            
            if(mem[536890411] >= 0)
            {
                    float val_7 = vectorB.y;
                val_7 = vectorA.y * val_7;
                val_8 = val_7 / val_8;
                val_8 = mem[536890482];
                if((val_8 & true) == 0)
            {
                    val_8 = mem[536890411];
            }
            
                val_9 = (UnityEngine.Mathf.Clamp(value:  val_8, min:  null, max:  vectorB.x)) * 57.29578f;
            }
            else
            {
                    val_9 = 0f;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 196.7734f, y = vectorA.x, z = vectorA.y}, rhs:  new UnityEngine.Vector3() {x = 0f, y = vectorB.x, z = vectorB.y});
            float val_9 = 360f;
            val_9 = val_9 - val_9;
            if(mem[536890411] > 0)
            {
                    val_9 = val_9;
            }
            
            return (float)val_9;
        }
        public static float DistanceBetweenPointAndLine(UnityEngine.Vector3 point, UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd)
        {
            var val_2;
            var val_3;
            var val_4;
            UnityEngine.Vector3 val_1 = GameTool.MMMaths.ProjectPointOnLine(point:  new UnityEngine.Vector3() {x = 198.4826f, y = point.x, z = point.y}, lineStart:  new UnityEngine.Vector3() {x = point.z, y = lineStart.x, z = lineStart.y}, lineEnd:  new UnityEngine.Vector3() {x = lineStart.z, y = lineEnd.x, z = lineEnd.y});
            float val_6 = point.z;
            var val_8 = val_2;
            var val_7 = val_3;
            val_6 = val_4 - val_6;
            val_7 = val_7 - point.y;
            val_8 = val_8 - point.x;
            if(mem[536890411] <= _TYPE_MAX_)
            {
                    return (float)val_7 * val_7;
            }
        
        }
        public static UnityEngine.Vector3 ProjectPointOnLine(UnityEngine.Vector3 point, UnityEngine.Vector3 lineStart, UnityEngine.Vector3 lineEnd)
        {
            float val_1;
            float val_8;
            var val_9;
            var val_10;
            float val_11;
            float val_8 = lineEnd.y;
            float val_9 = lineEnd.z;
            val_8 = val_8 - lineStart.y;
            float val_10 = val_1;
            val_9 = val_9 - lineStart.z;
            val_10 = val_10 - lineEnd.x;
            float val_2 = lineStart.x - lineEnd.x;
            float val_4 = point.y - lineStart.y;
            float val_5 = val_8.magnitude;
            val_8 = 1E-06f;
            uint val_12 = 1128804628;
            val_11 = val_10;
            if()
            {
                    var val_11 = val_11;
                val_11 = val_11 / val_12;
                val_8 = val_9 / val_12;
                val_12 = val_10 / val_12;
                val_11 = val_11;
                val_9 = val_8;
                val_10 = val_12;
            }
            
            float val_6 = (point.z - lineStart.z) * val_9;
            float val_7 = UnityEngine.Mathf.Clamp(value:  val_6, min:  null, max:  val_8);
            mem2[0] = lineStart.y;
            mem2[0] = lineStart.z;
            mem2[0] = lineEnd.x;
            return new UnityEngine.Vector3() {x = val_6, z = val_8};
        }
        public static int Sum(int[] thingsToAdd)
        {
            var val_1;
            var val_2;
            val_1 = 0;
            val_2 = 0;
            goto label_0;
            label_3:
            val_1 = 1;
            label_0:
            if(val_1 < null)
            {
                goto label_3;
            }
            
            return (int)val_2;
        }
        public static int RollADice(int numberOfSides)
        {
            return UnityEngine.Random.Range(minInclusive:  1, maxExclusive:  numberOfSides);
        }
        public static bool Chance(int percent)
        {
            if((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  100)) <= percent)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static float Approach(float from, float to, float amount)
        {
            var val_1 = R1;
            var val_1 = R2;
            if(<0)
            {
                    val_1 = 0 + val_1;
                if()
            {
                    val_1 = val_1;
            }
            
                return (float)val_1;
            }
            
            val_1 = 0 - val_1;
            if(<0)
            {
                    return (float)val_1;
            }
            
            val_1 = val_1;
            return (float)val_1;
        }
        public static float Remap(float x, float A, float B, float C, float D)
        {
            var val_1;
            var val_3 = R1;
            var val_2 = R2;
            val_2 = val_2 - val_3;
            val_3 = 0 - val_3;
            val_3 = val_3 / val_2;
            var val_4 = val_1;
            val_4 = val_4 - R3;
            return (float)val_3;
        }
        public static float RoundToClosest(float value, float[] possibleValues)
        {
            var val_4;
            float val_5;
            val_4 = mem[R1 + 12];
            val_4 = R1 + 12;
            if(val_4 != 0)
            {
                    val_5 = mem[R1 + 16];
                val_5 = R1 + 16;
                if(val_4 < 1)
            {
                    return (float)value;
            }
            
                var val_1 = R1 + 16;
                var val_4 = 0;
                do
            {
                if(val_4 <= val_4)
            {
                    val_4 = mem[R1 + 12];
                val_4 = R1 + 12;
            }
            
                val_1 = val_1 + 4;
                val_4 = val_4 + 1;
                float val_5 = System.Math.Abs(val_5 - possibleValues);
                float val_6 = System.Math.Abs(val_1 - possibleValues);
                if(val_4 > val_4)
            {
                    val_5 = val_1;
            }
            
            }
            while(val_4 < val_4);
            
                return (float)value;
            }
            
            val_5 = 0f;
            return (float)value;
        }
    
    }

}
