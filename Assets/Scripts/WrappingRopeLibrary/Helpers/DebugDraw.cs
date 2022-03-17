using UnityEngine;

namespace WrappingRopeLibrary.Helpers
{
    public static class DebugDraw
    {
        // Methods
        public static void DrawPlane(UnityEngine.Vector3 position, UnityEngine.Vector3 normal, UnityEngine.Color color, UnityEngine.Color normalColor)
        {
            float val_20;
            float val_21;
            float val_22;
            float val_23;
            float val_24;
            UnityEngine.Vector3 val_1 = 0.normalized;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.forward;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = 0f, y = normal.x, z = normal.y}, rhs:  new UnityEngine.Vector3() {x = 0f, y = normal.x, z = normal.y})) != false)
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.forward;
            }
            else
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = 1.184166E-06f, y = normal.x, z = normal.y}, rhs:  new UnityEngine.Vector3() {x = normal.z, y = 0f, z = normal.x});
            UnityEngine.Vector3 val_7 = normal.y.normalized;
            float val_22 = normal.y;
            float val_21 = normal.x;
            float val_20 = normal.y;
            float val_8 = normal.x.magnitude;
            val_20 = val_20 * 899608484;
            val_21 = val_21 * 899608484;
            val_22 = val_22 * 899608484;
            UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.AngleAxis(angle:  899608484, axis:  new UnityEngine.Vector3() {x = 1.184166E-06f, y = 90f, z = normal.x});
            UnityEngine.Vector3 val_10 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 1.184166E-06f, y = normal.y, z = normal.x, w = normal.y}, point:  new UnityEngine.Vector3() {x = normal.z, y = val_22, z = val_21});
            float val_24 = position.y;
            float val_25 = position.x;
            float val_11 = val_24 - val_21;
            uint val_23 = 0;
            val_20 = val_25 - val_22;
            val_21 = val_23 - val_20;
            float val_16 = val_23 - normal.y;
            float val_17 = val_24 - normal.x;
            val_22 = val_22 + val_25;
            val_23 = val_21 + val_24;
            float val_18 = val_25 - normal.y;
            val_23 = normal.y + val_23;
            val_24 = normal.x + val_24;
            val_25 = normal.y + val_25;
            val_24 = val_20 + val_23;
            if(((mem[536885944] & true) == 0) && (mem[536885873] == 0))
            {
                    val_24 = val_24;
                val_20 = val_20;
                val_21 = val_21;
                val_23 = val_23;
                val_22 = val_22;
            }
            
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, end:  new UnityEngine.Vector3() {x = val_20, y = val_11, z = val_21}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, duration:  val_25);
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_25, y = val_24}, end:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = val_16}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, duration:  val_25);
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, end:  new UnityEngine.Vector3() {x = val_25, y = val_24}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, duration:  val_25);
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_25, y = val_24}, end:  new UnityEngine.Vector3() {x = val_20, y = val_11, z = val_21}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, duration:  val_25);
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_20, y = val_11, z = val_21}, end:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = val_16}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, duration:  val_25);
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = val_16}, end:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.b, a = color.a}, duration:  val_25);
            UnityEngine.Debug.DrawRay(start:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = 0f}, dir:  new UnityEngine.Vector3() {x = normal.x, y = normal.y, z = normal.z}, color:  new UnityEngine.Color() {r = normalColor.r, g = normalColor.g, b = normalColor.b, a = normalColor.a}, duration:  val_25);
        }
        public static void DrawPoly(System.Collections.Generic.List<UnityEngine.Vector3> vertices, UnityEngine.Color color, float duration)
        {
            var val_7;
            var val_8;
            float val_11;
            float val_12;
            var val_13;
            var val_14;
            val_7 = 1;
            val_8 = 0;
            goto label_1;
            label_7:
            var val_2 = R5 - 1;
            if(22969437 >= val_2)
            {
                goto label_2;
            }
            
            label_8:
            if(R7 <= 22969437)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            float val_3 = color.r + val_8;
            val_11 = mem[(color.r + val_8) + 16];
            val_11 = (color.r + val_8) + 16;
            val_12 = mem[(color.r + val_8) + 24];
            val_12 = (color.r + val_8) + 24;
            if(R7 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_12 = val_12;
                val_11 = val_11;
            }
            
            color.r = color.r + val_8;
            if(((mem[536885944] & true) == 0) && (mem[536885873] == 0))
            {
                    val_12 = val_12;
                val_11 = val_11;
            }
            
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = val_11, y = (color.r + val_8) + 20, z = val_12}, end:  new UnityEngine.Vector3() {x = (color.r + val_8) + 28, y = (color.r + val_8) + 32, z = (color.r + val_8) + 36}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.r, a = color.a}, duration:  duration);
            val_7 = 2;
            val_8 = 12;
            label_1:
            if(vertices == 0)
            {
                goto label_7;
            }
            
            val_14 = ((color.r + val_8) + 32) - 1;
            if(1 < val_14)
            {
                goto label_8;
            }
            
            goto label_9;
            label_2:
            val_14 = R7 - 1;
            val_13 = val_2;
            label_9:
            if(val_13 <= val_14)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + ((val_14 + (val_14 << 1)) << 2);
            if(val_5 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = (0 + (((R7 - 1) + ((R7 - 1)) << 1)) << 2) + 16, y = (0 + (((R7 - 1) + ((R7 - 1)) << 1)) << 2) + 20, z = (0 + (((R7 - 1) + ((R7 - 1)) << 1)) << 2) + 24}, end:  new UnityEngine.Vector3() {x = ((R7 - 1) + ((R7 - 1)) << 1) + 16, y = ((R7 - 1) + ((R7 - 1)) << 1) + 20, z = ((R7 - 1) + ((R7 - 1)) << 1) + 24}, color:  new UnityEngine.Color() {r = color.r, g = color.g, b = color.r, a = color.a}, duration:  duration);
        }
    
    }

}
