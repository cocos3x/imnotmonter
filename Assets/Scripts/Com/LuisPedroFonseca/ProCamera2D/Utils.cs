using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public static class Utils
    {
        // Methods
        public static float EaseFromTo(float start, float end, float value, Com.LuisPedroFonseca.ProCamera2D.EaseType type = 0)
        {
            float val_3;
            float val_4;
            float val_1 = UnityEngine.Mathf.Clamp01(value:  start);
            val_3 = R2;
            if(R3 == 2)
            {
                goto label_0;
            }
            
            if(R3 == 1)
            {
                goto label_1;
            }
            
            if(R3 != 0)
            {
                    return UnityEngine.Mathf.Lerp(a:  val_3 = val_3, b:  end, t:  val_4 = 3.141593f);
            }
            
            val_3 = val_3 * val_3;
            val_4 = 3f - (val_3 + val_3);
            val_3 = val_3 * val_4;
            return UnityEngine.Mathf.Lerp(a:  val_3, b:  end, t:  val_4);
            label_0:
            val_3 = val_3 * 3.141593f;
            val_3 = val_3 * 0.5f;
            val_4 = val_3;
            val_3 = 1f - val_4;
            return UnityEngine.Mathf.Lerp(a:  val_3, b:  end, t:  val_4);
            label_1:
            val_3 = val_3 * val_4;
            val_3 = val_3 * 0.5f;
            return UnityEngine.Mathf.Lerp(a:  val_3, b:  end, t:  val_4);
        }
        public static float SmoothApproach(float pastPosition, float pastTargetPosition, float targetPosition, float speed, float deltaTime)
        {
            var val_1;
            var val_6 = val_1;
            val_6 = R3 * val_6;
            float val_2 = R2 - R1;
            val_2 = val_2 / val_6;
            uint val_7 = 0;
            float val_4 = R2 - val_2;
            val_7 = val_7 - R1;
            float val_5 = val_7 + val_2;
            return (float)val_6 ^ 2147483648;
        }
        public static float Remap(float value, float from1, float to1, float from2, float to2)
        {
            float val_1;
            float val_4 = R1;
            var val_3 = R2;
            val_3 = val_3 - val_4;
            val_4 = 0 - val_4;
            val_4 = val_4 / val_3;
            float val_2 = val_1 - R3;
            return UnityEngine.Mathf.Clamp(value:  val_4, min:  from1, max:  val_1);
        }
        public static void DrawArrowForGizmo(UnityEngine.Vector3 pos, UnityEngine.Vector3 direction, float arrowHeadLength = 0.25, float arrowHeadAngle = 20)
        {
            float val_2;
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, direction:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z});
            UnityEngine.Color val_1 = UnityEngine.Gizmos.color;
            Com.LuisPedroFonseca.ProCamera2D.Utils.DrawArrowEnd(gizmos:  true, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, direction:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, color:  new UnityEngine.Color() {r = ???}, arrowHeadLength:  val_2, arrowHeadAngle:  val_1.g);
        }
        public static void DrawArrowForGizmo(UnityEngine.Vector3 pos, UnityEngine.Vector3 direction, UnityEngine.Color color, float arrowHeadLength = 0.25, float arrowHeadAngle = 20)
        {
            float val_1;
            UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, direction:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z});
            Com.LuisPedroFonseca.ProCamera2D.Utils.DrawArrowEnd(gizmos:  true, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, direction:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, arrowHeadLength:  val_1, arrowHeadAngle:  arrowHeadAngle);
        }
        public static void DrawArrowForDebug(UnityEngine.Vector3 pos, UnityEngine.Vector3 direction, float arrowHeadLength = 0.25, float arrowHeadAngle = 20)
        {
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, dir:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z});
            UnityEngine.Color val_3 = UnityEngine.Gizmos.color;
            Com.LuisPedroFonseca.ProCamera2D.Utils.DrawArrowEnd(gizmos:  false, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, direction:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = direction.z}, color:  new UnityEngine.Color(), arrowHeadLength:  val_3.r, arrowHeadAngle:  val_3.g);
        }
        public static void DrawArrowForDebug(UnityEngine.Vector3 pos, UnityEngine.Vector3 direction, UnityEngine.Color color, float arrowHeadLength = 0.25, float arrowHeadAngle = 20)
        {
            float val_3;
            float val_4;
            val_3 = color.a;
            val_4 = direction.z;
            if(((mem[536885944] & true) == 0) && (mem[536885873] == 0))
            {
                    val_4 = direction.z;
                val_3 = color.a;
            }
            
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, dir:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = val_4}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = val_3});
            Com.LuisPedroFonseca.ProCamera2D.Utils.DrawArrowEnd(gizmos:  false, pos:  new UnityEngine.Vector3() {x = pos.x, y = pos.y, z = pos.z}, direction:  new UnityEngine.Vector3() {x = direction.x, y = direction.y, z = val_4}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = val_3}, arrowHeadLength:  arrowHeadLength, arrowHeadAngle:  arrowHeadAngle);
        }
        private static void DrawArrowEnd(bool gizmos, UnityEngine.Vector3 pos, UnityEngine.Vector3 direction, UnityEngine.Color color, float arrowHeadLength = 0.25, float arrowHeadAngle = 20)
        {
            float val_2;
            float val_3;
            float val_4;
            float val_6;
            var val_7;
            float val_9;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            val_33 = pos.y;
            val_34 = pos.x;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32}, rhs:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_2})) == true)
            {
                    return;
            }
            
            val_3 = pos.z;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 0.00524788f, y = val_30, z = val_31});
            val_4 = val_6;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  val_8.x, y:  val_8.y, z:  val_8.z);
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 0.00524788f, y = val_3, z = val_4, w = val_2}, rhs:  new UnityEngine.Quaternion() {x = val_9, y = val_3, z = val_4});
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.back;
            UnityEngine.Vector3 val_13 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 0.00524788f, y = val_3, z = val_4, w = val_2}, point:  new UnityEngine.Vector3() {x = val_9, y = val_3, z = val_4});
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 0.00524788f, y = val_30, z = direction.y});
            UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Euler(x:  val_14.x, y:  val_14.y, z:  val_14.z);
            UnityEngine.Quaternion val_17 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 0.00524788f, y = val_3, z = val_4, w = val_2}, rhs:  new UnityEngine.Quaternion() {x = val_9, y = val_3, z = val_4});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.back;
            UnityEngine.Vector3 val_19 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 0.00524788f, y = val_3, z = val_4, w = R7}, point:  new UnityEngine.Vector3() {x = val_9, y = val_3, z = val_4});
            UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 0.00524788f, y = direction.x, z = direction.y});
            UnityEngine.Quaternion val_21 = UnityEngine.Quaternion.Euler(x:  val_20.x, y:  val_20.y, z:  val_20.z);
            UnityEngine.Quaternion val_22 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 0.00524788f, y = val_3, z = val_4, w = R7}, rhs:  new UnityEngine.Quaternion() {x = val_9, y = val_3, z = val_4});
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.back;
            UnityEngine.Vector3 val_24 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 0.00524788f, y = val_3, z = val_4, w = R6}, point:  new UnityEngine.Vector3() {x = ???, y = val_3, z = val_4});
            val_4 = val_3;
            UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 0.00524788f, y = direction.x, z = direction.y});
            UnityEngine.Quaternion val_26 = UnityEngine.Quaternion.Euler(x:  val_25.x, y:  val_25.y, z:  val_25.z);
            UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 0.00524788f, y = val_3, z = val_4, w = R6}, rhs:  new UnityEngine.Quaternion() {x = ???, y = val_3, z = val_4});
            UnityEngine.Vector3 val_28 = UnityEngine.Vector3.back;
            UnityEngine.Vector3 val_29 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 0.00524788f, y = val_3, z = val_4, w = R6}, point:  new UnityEngine.Vector3() {x = ???, y = val_3, z = val_4});
            if(val_33 != 0f)
            {
                    val_30 = 0;
                UnityEngine.Gizmos.color = new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a};
                float val_30 = direction.x;
                val_30 = val_4 ^ 2147483648 + val_30;
                float val_31 = val_3;
                val_31 = val_31 * val_7;
                float val_32 = direction.y;
                val_32 = val_33 + val_32;
                float val_33 = direction.z;
                val_33 = val_3 + val_33;
                float val_34 = val_2;
                val_34 = val_34 * val_7;
                val_33 = val_33;
                float val_35 = val_4;
                val_35 = val_35 * val_7;
                UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_30, y = val_32, z = val_33}, direction:  new UnityEngine.Vector3() {x = val_31, y = val_35, z = val_34});
                float val_36 = val_3;
                val_36 = val_36 * val_7;
                float val_37 = val_2;
                val_37 = val_37 * val_7;
                float val_38 = val_4;
                val_38 = val_38 * val_7;
                UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_30, y = val_32, z = val_33}, direction:  new UnityEngine.Vector3() {x = val_36, y = val_38, z = val_37});
                float val_39 = val_4;
                val_39 = val_39 * val_7;
                float val_40 = val_2;
                val_40 = val_40 * val_7;
                float val_41 = val_4;
                val_41 = val_41 * val_7;
                UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_30, y = val_32, z = val_33}, direction:  new UnityEngine.Vector3() {x = val_39, y = val_41, z = val_40});
                float val_42 = val_34;
                float val_43 = val_31;
                val_42 = val_42 * val_7;
                val_43 = val_43 * val_7;
                float val_44 = SL;
                val_44 = val_44 * val_7;
                UnityEngine.Gizmos.DrawRay(from:  new UnityEngine.Vector3() {x = val_30, y = val_32, z = val_33}, direction:  new UnityEngine.Vector3() {x = val_42, y = val_43, z = val_44});
                return;
            }
            
            float val_45 = val_4;
            val_45 = val_45 * val_7;
            float val_46 = direction.x;
            val_46 = val_34 + val_46;
            float val_47 = val_3;
            val_47 = val_47 * val_7;
            float val_48 = val_2;
            val_48 = val_48 * val_7;
            float val_49 = direction.y;
            val_49 = val_31 + val_49;
            float val_50 = direction.z;
            val_50 = val_3 + val_50;
            val_33 = val_50;
            val_32 = color.a;
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_46, y = val_49, z = val_33}, dir:  new UnityEngine.Vector3() {x = val_47, y = val_45, z = val_48}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = val_32});
            val_31 = color.g;
            float val_51 = val_2;
            val_30 = color.b;
            val_51 = val_51 * val_7;
            float val_52 = val_4;
            val_52 = val_52 * val_7;
            float val_53 = val_3;
            val_53 = val_53 * val_7;
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_46, y = val_49, z = val_33}, dir:  new UnityEngine.Vector3() {x = val_53, y = val_52, z = val_51}, color:  new UnityEngine.Color() {r = color.r, g = val_31, b = val_30, a = val_32});
            val_34 = 0;
            float val_54 = val_2;
            val_54 = val_54 * val_7;
            float val_55 = val_4;
            val_55 = val_55 * val_7;
            float val_56 = val_4;
            val_56 = val_56 * val_7;
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_46, y = val_49, z = val_33}, dir:  new UnityEngine.Vector3() {x = val_56, y = val_55, z = val_54}, color:  new UnityEngine.Color() {r = color.r, g = val_31, b = val_30, a = val_32});
            float val_57 = val_31;
            val_57 = val_57 * val_7;
            float val_58 = ???;
            val_58 = val_58 * val_7;
            float val_59 = val_34;
            val_59 = val_59 * val_7;
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = val_46, y = val_49, z = val_33}, dir:  new UnityEngine.Vector3() {x = val_59, y = val_57, z = val_58}, color:  new UnityEngine.Color() {r = color.r, g = val_31, b = val_30, a = val_32});
        }
        public static bool AreNearlyEqual(float a, float b, float tolerance = 0.02)
        {
            var val_1 = R1;
            val_1 = 0 - val_1;
            float val_2 = System.Math.Abs(val_1);
            if(<0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static UnityEngine.Vector2 GetScreenSizeInWorldCoords(UnityEngine.Camera gameCamera, float distance = 10)
        {
            var val_8;
            var val_9;
            var val_12;
            float val_28;
            float val_29;
            var val_30;
            float val_31;
            float val_33;
            float val_34;
            if(R1.orthographic == false)
            {
                goto label_1;
            }
            
            float val_2 = R1.orthographicSize;
            if(R1 <= 0)
            {
                goto label_3;
            }
            
            if(R1 == 0)
            {
                goto label_4;
            }
            
            float val_3 = R1.nearClipPlane;
            val_28 = R1;
            goto label_5;
            label_1:
            float val_4 = R1.fieldOfView;
            float val_28 = 0.5f;
            val_28 = R1 * val_28;
            val_28 = val_28 * 0.01745329f;
            val_29 = (System.Math.Abs(R2) + System.Math.Abs(R2)) * val_28;
            float val_6 = R1.aspect;
            val_30 = R1;
            val_31 = val_29 * val_30;
            goto label_8;
            label_3:
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            return new UnityEngine.Vector2() {x = val_9 - val_9.magnitude, y = val_18.y};
            label_4:
            float val_10 = 0.nearClipPlane;
            val_28 = 0;
            label_5:
            UnityEngine.Vector3 val_11 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = R1, y = 0f, z = 0f});
            if(R1 != 0)
            {
                    float val_13 = R1.nearClipPlane;
                val_33 = R1;
            }
            else
            {
                    float val_14 = 0.nearClipPlane;
                val_33 = 0;
            }
            
            UnityEngine.Vector3 val_15 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = R1, y = 1f, z = 0f});
            if(R1 != 0)
            {
                    float val_16 = R1.nearClipPlane;
                val_34 = R1;
            }
            else
            {
                    float val_17 = 0.nearClipPlane;
                val_34 = 0;
            }
            
            UnityEngine.Vector3 val_18 = ViewportToWorldPoint(position:  new UnityEngine.Vector3() {x = R1, y = 1f, z = 1f});
            float val_19 = val_8 - val_8;
            float val_21 = val_12 - val_12;
            float val_22 = val_9 - val_9.magnitude;
            float val_24 = val_8 - val_8;
            float val_25 = val_12 - val_12;
            val_31 = 1001353608;
            val_29 = 1001353608;
            label_8:
            mem2[0] = val_31;
            mem2[0] = val_29;
            return new UnityEngine.Vector2() {x = val_9 - val_9.magnitude, y = val_18.y};
        }
        public static UnityEngine.Vector3 GetVectorsSum(System.Collections.Generic.IList<UnityEngine.Vector3> input)
        {
            float val_2;
            float val_3;
            var val_4;
            var val_7;
            float val_8;
            float val_9;
            float val_10;
            float val_11;
            float val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_7 = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_10 = val_2;
            val_11 = val_3;
            val_12 = val_4;
            goto label_1;
            label_12:
            var val_7 = R1;
            if((R1 + 178) == 0)
            {
                goto label_3;
            }
            
            val_13 = 0;
            label_5:
            if((R1 + 88 + 0) == 536877085)
            {
                goto label_4;
            }
            
            val_13 = val_13 + 1;
            if(((uint)val_13 & 65535) < (R1 + 178))
            {
                goto label_5;
            }
            
            label_3:
            val_14 = R1;
            goto label_6;
            label_4:
            var val_5 = (R1 + 88) + 0;
            val_7 = val_7 + (((R1 + 88 + 0) + 4) << 3);
            val_14 = val_7 + 188;
            label_6:
            val_8 = val_2;
            val_7 = 1;
            val_9 = val_3;
            val_10 = val_10 + val_8;
            val_11 = val_11 + val_9;
            val_12 = val_12 + val_4;
            label_1:
            var val_8 = R1;
            if((R1 + 178) == 0)
            {
                goto label_8;
            }
            
            val_13 = 0;
            label_10:
            val_15 = mem[R1 + 88 + 0];
            val_15 = R1 + 88 + 0;
            if(val_15 == 536875927)
            {
                goto label_9;
            }
            
            val_13 = val_13 + 1;
            val_15 = (uint)val_13 & 65535;
            if(val_15 < (R1 + 178))
            {
                goto label_10;
            }
            
            label_8:
            val_16 = R1;
            goto label_11;
            label_9:
            var val_6 = (R1 + 88) + 0;
            val_8 = val_8 + (((R1 + 88 + 0) + 4) << 3);
            val_16 = val_8 + 188;
            label_11:
            if(val_7 < R1)
            {
                goto label_12;
            }
            
            mem2[0] = val_10;
            mem2[0] = val_11;
            mem2[0] = val_12;
            return new UnityEngine.Vector3() {x = val_8, y = val_1.y, z = val_9};
        }
        public static float AlignToGrid(float input, float gridSize)
        {
            var val_2;
            var val_5;
            float val_6;
            var val_7;
            var val_8;
            var val_9;
            float val_10;
            var val_11;
            var val_12;
            float val_1 = 0 / R1;
            if()
            {
                goto label_0;
            }
            
            if()
            {
                goto label_1;
            }
            
            val_5 = val_2;
            val_6 = -1f;
            goto label_2;
            label_0:
            if()
            {
                goto label_3;
            }
            
            val_5 = val_2;
            val_6 = 1f;
            label_2:
            float val_3 = S20 + val_6;
            if((R1 & 1) != 0)
            {
                    val_7 = S20;
            }
            
            goto label_4;
            label_1:
            float val_5 = -0.5f;
            val_5 = val_1 + val_5;
            val_8 = val_5;
            goto label_5;
            label_3:
            float val_6 = 0.5f;
            val_6 = val_1 + val_6;
            val_8 = val_6;
            label_5:
            val_7 = val_8;
            label_4:
            val_6 = val_7 * R1;
            val_7 = val_6 / R1;
            if()
            {
                goto label_6;
            }
            
            if()
            {
                goto label_7;
            }
            
            val_9 = val_2;
            val_10 = -1f;
            goto label_8;
            label_6:
            if()
            {
                goto label_9;
            }
            
            val_9 = val_2;
            val_10 = 1f;
            label_8:
            float val_4 = S20 + val_10;
            if((R1 & 1) != 0)
            {
                    val_11 = S20;
            }
            
            goto label_10;
            label_7:
            float val_7 = -0.5f;
            val_7 = val_7 + val_7;
            val_12 = val_7;
            goto label_11;
            label_9:
            float val_8 = 0.5f;
            val_8 = val_7 + val_8;
            val_12 = val_8;
            label_11:
            val_11 = val_12;
            label_10:
            val_8 = val_11 * R1;
            return (float)val_8;
        }
        public static bool IsInsideRectangle(float x, float y, float width, float height, float pointX, float pointY)
        {
            float val_5 = 0.5f;
            var val_4 = R2;
            val_4 = val_4 * val_5;
            float val_2 = 0 - val_4;
            if()
            {
                    return false;
            }
            
            val_4 = val_4 + 0;
            if()
            {
                    return false;
            }
            
            var val_6 = R3;
            val_5 = val_6 * val_5;
            val_6 = R1 - val_5;
            if()
            {
                    return false;
            }
            
            val_5 = val_5 + R1;
            if()
            {
                    1 = 0;
            }
            
            return (bool)1;
        }
        public static bool IsInsideCircle(float x, float y, float radius, float pointX, float pointY)
        {
            var val_1;
            var val_2 = val_1;
            val_2 = val_2 - R1;
            uint val_3 = 0;
            val_3 = R3 - val_3;
            val_2 = val_2 * val_2;
            var val_4 = R2;
            val_4 = val_4 * val_4;
            if(<0)
            {
                    0 = 1;
            }
            
            return true;
        }
    
    }

}
