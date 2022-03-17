using UnityEngine;

namespace Ferr
{
    public static class ColorUtil
    {
        // Fields
        private static float sqrt3;
        
        // Methods
        public static UnityEngine.Color HSL(float aHue, float aSaturation, float aLuminance)
        {
            float val_8;
            var val_9;
            float val_10;
            float val_8 = 360f;
            val_8 = R1 * val_8;
            var val_10 = val_8 / 60f;
            float val_9 = System.Math.Abs((R3 + R3) + (-1f));
            val_10 = val_10 + (-1f);
            val_9 = 1f - val_9;
            float val_11 = System.Math.Abs(val_10);
            float val_12 = R2;
            val_12 = val_9 * val_12;
            val_11 = val_12 * (1f - val_11);
            val_8 = 0f;
            if(>=0)
            {
                goto label_0;
            }
            
            val_9 = val_11;
            label_9:
            val_10 = val_12;
            goto label_5;
            label_0:
            if(>=0)
            {
                goto label_2;
            }
            
            val_9 = val_12;
            label_8:
            val_10 = val_11;
            goto label_5;
            label_2:
            val_10 = 0f;
            if(>=0)
            {
                goto label_4;
            }
            
            val_8 = val_11;
            val_9 = val_12;
            goto label_5;
            label_4:
            if(>=0)
            {
                goto label_6;
            }
            
            val_8 = val_12;
            val_9 = val_11;
            label_5:
            float val_5 = R3 + val_10;
            float val_6 = R3 + val_9;
            val_8 = R3 + val_8;
            0 = new UnityEngine.Color(r:  val_5, g:  aSaturation, b:  val_8, a:  null);
            return new UnityEngine.Color() {r = val_5, g = aSaturation, b = val_8};
            label_6:
            if(>=0)
            {
                goto label_9;
            }
            
            goto label_8;
        }
        public static UnityEngine.Vector3 ToHSV(float aR, float aG, float aB)
        {
            var val_7;
            float val_8;
            float val_4 = UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Min(a:  UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Max(a:  aR, b:  aG), b:  aG), b:  aG), b:  aG);
            val_7 = 536885023;
            if(((mem[536885210] & true) == 0) && (mem[536885139] == 0))
            {
                    val_7 = 536885023;
            }
            
            float val_5 = R1 + R1;
            float val_6 = R2 - R3;
            val_5 = val_5 - R2;
            val_6 = val_6 * mem[536885115];
            val_5 = val_5 - R3;
            if(mem[536885139] == 0)
            {
                    val_8 = 0f;
            }
            else
            {
                    var val_7 = R1;
                val_7 = val_7 / R1;
                val_8 = 1f - val_7;
            }
            
            mem2[0] = val_5;
            mem[4] = val_8;
            mem[8] = R1;
            return new UnityEngine.Vector3() {x = val_5, y = aG, z = val_8};
        }
        public static UnityEngine.Color HSV(float aHue, float aSaturation, float aValue)
        {
            float val_4;
            var val_5;
            float val_6;
            float val_4 = 360f;
            val_4 = R1 * val_4;
            float val_5 = -1f;
            val_5 = (val_4 / 60f) + val_5;
            float val_7 = R2;
            float val_6 = System.Math.Abs(val_5);
            float val_8 = R3;
            val_7 = val_7 * val_8;
            val_6 = 1f - val_6;
            float val_2 = val_7 * val_6;
            val_4 = 0f;
            if(>=0)
            {
                goto label_0;
            }
            
            val_5 = val_2;
            label_9:
            val_6 = val_7;
            goto label_5;
            label_0:
            if(>=0)
            {
                goto label_2;
            }
            
            val_5 = val_7;
            label_8:
            val_6 = val_2;
            goto label_5;
            label_2:
            val_6 = 0f;
            if(>=0)
            {
                goto label_4;
            }
            
            val_4 = val_2;
            val_5 = val_7;
            goto label_5;
            label_4:
            if(>=0)
            {
                goto label_6;
            }
            
            val_4 = val_7;
            val_5 = val_2;
            label_5:
            val_8 = val_8 - val_7;
            val_7 = val_8 + val_6;
            val_2 = val_8 + val_5;
            val_8 = val_8 + val_4;
            0 = new UnityEngine.Color(r:  val_8, g:  aSaturation, b:  val_7);
            return new UnityEngine.Color() {r = val_8, g = aSaturation, b = val_7};
            label_6:
            if(>=0)
            {
                goto label_9;
            }
            
            goto label_8;
        }
        public static UnityEngine.Color HCL(float aHue, float aChroma, float aLuma)
        {
            float val_4;
            float val_5;
            float val_6;
            float val_4 = 360f;
            val_4 = R1 * val_4;
            float val_5 = -1f;
            val_4 = 0f;
            val_5 = (val_4 / 60f) + val_5;
            val_5 = R2;
            float val_6 = System.Math.Abs(val_5);
            val_6 = 1f - val_6;
            float val_2 = val_6 * val_5;
            float val_8 = R3;
            if(>=0)
            {
                goto label_0;
            }
            
            val_6 = val_2;
            goto label_7;
            label_0:
            if(>=0)
            {
                goto label_2;
            }
            
            val_6 = val_5;
            val_5 = val_2;
            goto label_7;
            label_2:
            if(>=0)
            {
                goto label_4;
            }
            
            val_6 = val_5;
            val_4 = val_2;
            goto label_5;
            label_4:
            if(>=0)
            {
                goto label_6;
            }
            
            val_4 = val_5;
            val_6 = val_2;
            label_5:
            val_5 = 0;
            goto label_7;
            label_6:
            val_6 = 0f;
            if(>=0)
            {
                    5f = val_2;
            }
            
            if(<0)
            {
                    val_4 = val_5;
                val_5 = val_2;
            }
            
            label_7:
            float val_7 = 0.3f;
            val_7 = val_5 * val_7;
            val_8 = val_8 - val_7;
            val_5 = val_5 + val_8;
            val_7 = val_6 + val_8;
            val_8 = val_4 + val_8;
            0 = new UnityEngine.Color(r:  val_8, g:  aChroma, b:  val_5);
            return new UnityEngine.Color() {r = val_8, g = aChroma, b = val_5};
        }
        public static UnityEngine.Color GetColorBand(UnityEngine.Color[] aColorBand, float aValue)
        {
            var val_16;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            if(R1 == 0)
            {
                    return new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
            }
            
            var val_11 = R1 + 12;
            val_11 = val_11 - 1;
            float val_12 = (float)val_11;
            val_12 = R2 * val_12;
            float val_3 = UnityEngine.Mathf.Min(a:  val_12, b:  val_1.g);
            int val_13 = R1 + 12;
            val_13 = val_13 - 1;
            int val_5 = UnityEngine.Mathf.Min(a:  val_13, b:  UnityEngine.Mathf.Max(a:  0, b:  (int)val_12));
            val_16 = mem[R1 + 12];
            val_16 = R1 + 12;
            if(val_16 <= val_5)
            {
                    val_16 = mem[R1 + 12];
                val_16 = R1 + 12;
            }
            
            var val_7 = (R1 + (val_5 << 4)) + 16;
            if(val_16 <= ((int)val_12 + 1f))
            {
                    val_16 = mem[R1 + 12];
                val_16 = R1 + 12;
            }
            
            var val_9 = (R1 + (((int)val_12 + 1f) << 4)) + 16;
            float val_14 = (float)val_16;
            val_14 = 1f / val_14;
            val_14 = R2 / val_14;
            UnityEngine.Color val_10 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = 246699.1f, g = mem[((R1 + (val_5) << 4) + 16) + (0)], b = mem[((R1 + (val_5) << 4) + 16) + (4)], a = mem[((R1 + (val_5) << 4) + 16) + (8)]}, b:  new UnityEngine.Color() {r = mem[((R1 + (val_5) << 4) + 16) + (12)], g = mem[((R1 + ((int)(((R2 * (float)(R1 + 12)) + 1f))) << 4) + 16) + (0)], b = mem[((R1 + ((int)(((R2 * (float)(R1 + 12)) + 1f))) << 4) + 16) + (4)], a = mem[((R1 + ((int)(((R2 * (float)(R1 + 12)) + 1f))) << 4) + 16) + (8)]}, t:  val_14);
            return new UnityEngine.Color() {r = val_10.r, g = val_10.g, b = val_10.b, a = val_10.a};
        }
        public static UnityEngine.Color FromHex(string aHex)
        {
            float val_27;
            float val_28;
            if((R1 + 8) == 8)
            {
                    string val_2 = R1.Chars[0].ToString();
                string val_4 = R1.Chars[1].ToString();
                string val_5 = 1215512682 + 1215512682;
                string val_8 = R1.Chars[2].ToString();
                string val_10 = R1.Chars[3].ToString();
                string val_11 = 1215512682 + 1215512682;
                string val_14 = R1.Chars[4].ToString();
                string val_16 = R1.Chars[5].ToString();
                string val_17 = 1215512682 + 1215512682;
                string val_20 = R1.Chars[6].ToString();
                string val_22 = R1.Chars[7].ToString();
                string val_23 = 1215512682 + 1215512682;
                float val_28 = 255f;
                float val_27 = (float)System.Convert.ToInt32(value:  1215512682);
                val_27 = ((float)System.Convert.ToInt32(value:  1215512682)) / val_28;
                val_28 = ((float)System.Convert.ToInt32(value:  1215512682)) / val_28;
                val_27 = val_27 / val_28;
                val_28 = ((float)System.Convert.ToInt32(value:  1215512682)) / val_28;
                aHex = new UnityEngine.Color(r:  val_27, g:  null, b:  val_28, a:  null);
                return new UnityEngine.Color() {r = val_26.r, g = val_26.g, b = val_26.b, a = val_26.a};
            }
            
            UnityEngine.Color val_26 = UnityEngine.Color.red;
            return new UnityEngine.Color() {r = val_26.r, g = val_26.g, b = val_26.b, a = val_26.a};
        }
        public static string ToHex(UnityEngine.Color aColor)
        {
            float val_2 = aColor.r;
            val_2 = val_2 * 255f;
            mem[536882227] = 536888987;
            float val_3 = aColor.g;
            val_3 = val_3 * 255f;
            mem[536882231] = 536888987;
            float val_4 = aColor.b;
            val_4 = val_4 * 255f;
            mem[536882235] = 536888987;
            float val_5 = aColor.a;
            val_5 = val_5 * 255f;
            mem[536882239] = 536888987;
            string val_1 = System.String.Format(format:  -1610597087, args:  536882211);
        }
        private static ColorUtil()
        {
            mem2[0] = 1071494103;
        }
    
    }

}
