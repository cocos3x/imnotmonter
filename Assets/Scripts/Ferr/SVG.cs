using UnityEngine;

namespace Ferr
{
    public static class SVG
    {
        // Fields
        public const float Scale = 100;
        
        // Methods
        public static string CreateFile(System.Collections.Generic.List<Ferr.ISVGElement> aPaths, bool aSort, UnityEngine.Vector2 aPadding)
        {
            System.Collections.Generic.List<Ferr.ISVGElement> val_10;
            var val_11;
            float val_12;
            var val_13;
            val_10 = aPaths;
            if(aSort != false)
            {
                    System.Collections.Generic.List<Ferr.ISVGElement> val_1 = Ferr.SVG.Sort(aElements:  val_10);
                val_10 = val_10;
            }
            
            UnityEngine.Rect val_2 = Ferr.SVG.GetBounds(aPaths:  1264671160, aPadding:  new UnityEngine.Vector2() {x = val_10, y = aPadding.x});
            val_11 = 0;
            val_12 = -1.084202E-19f;
            goto label_2;
            label_10:
            if(22776880 <= val_11)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + 0;
            var val_12 = (0 + 0) + 16;
            if(((0 + 0) + 16 + 178) == 0)
            {
                goto label_5;
            }
            
            var val_11 = 0;
            label_7:
            if(((0 + 0) + 16 + 88 + 0) == 536888667)
            {
                goto label_6;
            }
            
            val_11 = val_11 + 1;
            if(((uint)val_11 & 65535) < ((0 + 0) + 16 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_13 = (0 + 0) + 16;
            goto label_8;
            label_6:
            var val_3 = ((0 + 0) + 16 + 88) + 0;
            val_12 = val_12 + ((((0 + 0) + 16 + 88 + 0) + 4) << 3);
            val_13 = val_12 + 236;
            label_8:
            string val_4 = -1610612735(-1610612735) + -1610612695(-1610612695) + (0 + 0) + 16((0 + 0) + 16) + -1610612685(-1610612685);
            val_11 = 1;
            val_12 = val_12;
            label_2:
            if(val_11 < val_12)
            {
                goto label_10;
            }
            
            float val_5 = xMin;
            uint val_13 = 1264671160;
            val_13 = val_13 * 100f;
            mem[536882227] = 536893745;
            float val_6 = yMax;
            float val_14 = -100f;
            val_14 = 1264671160 * val_14;
            mem[536882231] = 536893745;
            float val_7 = width;
            uint val_15 = 1264671160;
            val_15 = val_15 * 100f;
            mem[536882235] = 536893745;
            float val_8 = height;
            uint val_16 = 1264671160;
            val_16 = val_16 * 100f;
            mem[536882239] = 536893745;
            mem[536882243] = val_12;
            string val_9 = System.String.Format(format:  -1610610529, args:  536882211);
        }
        public static System.Collections.Generic.List<Ferr.ISVGElement> Sort(System.Collections.Generic.List<Ferr.ISVGElement> aElements)
        {
            float val_3;
            float val_4;
            System.Collections.Generic.List<Point> val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_14 = 536877957;
            if(22975248 == 0)
            {
                goto label_2;
            }
            
            val_14 = new System.Collections.Generic.List<Point>(collection:  aElements);
            val_15 = 0;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            goto label_3;
            label_40:
            val_16 = 0;
            val_17 = val_15;
            goto label_4;
            label_21:
            if(1264791352 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_15 = mem[536877965];
            val_15 = val_15 + 0;
            var val_17 = (mem[536877965] + 0) + 16;
            if(((mem[536877965] + 0) + 16 + 178) == 0)
            {
                goto label_7;
            }
            
            var val_16 = 0;
            label_9:
            if(((mem[536877965] + 0) + 16 + 88 + 0) == 536888667)
            {
                goto label_8;
            }
            
            val_16 = val_16 + 1;
            if(((uint)val_16 & 65535) < ((mem[536877965] + 0) + 16 + 178))
            {
                goto label_9;
            }
            
            label_7:
            val_18 = (mem[536877965] + 0) + 16;
            goto label_10;
            label_8:
            var val_5 = ((mem[536877965] + 0) + 16 + 88) + 0;
            val_17 = val_17 + ((((mem[536877965] + 0) + 16 + 88 + 0) + 4) << 3);
            val_18 = val_17 + 188;
            label_10:
            float val_18 = val_3;
            float val_19 = val_4;
            val_18 = val_3 - val_18;
            val_19 = val_4 - val_19;
            float val_6 = val_18.sqrMagnitude;
            if(((mem[536877965] + 0) + 16 + 88 + 0) < 0)
            {
                    2139095039 = 1264791360;
            }
            
            if(((mem[536877965] + 0) + 16 + 88 + 0) >= 0)
            {
                    0 = 1;
            }
            
            if(mem[536877969] <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_20 = mem[536877965];
            val_20 = val_20 + 0;
            var val_22 = (mem[536877965] + 0) + 16;
            if(((mem[536877965] + 0) + 16 + 178) == 0)
            {
                goto label_14;
            }
            
            var val_21 = 0;
            label_16:
            if(((mem[536877965] + 0) + 16 + 88 + 0) == 536888667)
            {
                goto label_15;
            }
            
            val_21 = val_21 + 1;
            if(((uint)val_21 & 65535) < ((mem[536877965] + 0) + 16 + 178))
            {
                goto label_16;
            }
            
            label_14:
            val_19 = (mem[536877965] + 0) + 16;
            goto label_17;
            label_15:
            var val_8 = ((mem[536877965] + 0) + 16 + 88) + 0;
            val_22 = val_22 + ((((mem[536877965] + 0) + 16 + 88 + 0) + 4) << 3);
            val_19 = val_22 + 196;
            label_17:
            float val_23 = val_3;
            float val_24 = val_4;
            val_23 = val_3 - val_23;
            val_24 = val_4 - val_24;
            float val_9 = val_23.sqrMagnitude;
            if(((mem[536877965] + 0) + 16 + 88 + 0) < 0)
            {
                    1264791360 = 1264791360;
                val_17 = val_15;
            }
            
            if(((mem[536877965] + 0) + 16 + 88 + 0) < 0)
            {
                    val_17 = val_15;
            }
            
            if(((mem[536877965] + 0) + 16 + 88 + 0) < 0)
            {
                    0 = 1;
            }
            
            val_16 = (val_16 & 1) | 1;
            val_14 = val_14;
            label_4:
            if(val_14 == 0)
            {
                goto label_18;
            }
            
            val_20 = mem[536877969];
            if(1 < val_20)
            {
                goto label_21;
            }
            
            goto label_20;
            label_18:
            val_20 = mem[536877969];
            if(1 < mem[536877969])
            {
                goto label_21;
            }
            
            label_20:
            if(val_20 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_20 = mem[536877969];
            }
            
            val_21 = mem[536877965];
            var val_10 = val_21 + 0;
            if(val_20 <= val_17)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_21 = mem[536877965];
            }
            
            var val_11 = val_21 + 0;
            val_14.set_Item(index:  0, value:  (mem[536877965] + 0) + 16);
            val_14.set_Item(index:  0, value:  (mem[536877965] + 0) + 16);
            if((val_16 & 1) != 0)
            {
                goto label_24;
            }
            
            if(mem[536877969] <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_25 = mem[536877965];
            val_25 = val_25 + 0;
            var val_26 = (mem[536877965] + 0) + 16;
            if(((mem[536877965] + 0) + 16 + 178) == 0)
            {
                goto label_27;
            }
            
            val_16 = 0;
            label_29:
            val_17 = 0;
            if(((mem[536877965] + 0) + 16 + 88 + 0) == 536888667)
            {
                goto label_28;
            }
            
            val_16 = val_16 + 1;
            val_17 = (uint)val_16 & 65535;
            if(val_17 < ((mem[536877965] + 0) + 16 + 178))
            {
                goto label_29;
            }
            
            label_27:
            val_22 = (mem[536877965] + 0) + 16;
            goto label_30;
            label_28:
            var val_12 = ((mem[536877965] + 0) + 16 + 88) + 0;
            val_26 = val_26 + ((((mem[536877965] + 0) + 16 + 88 + 0) + 4) << 3);
            val_22 = val_26 + 220;
            label_30:
            val_14.set_Item(index:  0, value:  (mem[536877965] + 0) + 16);
            label_24:
            if(mem[536877969] <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_27 = mem[536877965];
            val_27 = val_27 + 0;
            var val_28 = (mem[536877965] + 0) + 16;
            if(((mem[536877965] + 0) + 16 + 178) == 0)
            {
                goto label_35;
            }
            
            val_16 = 0;
            label_37:
            val_17 = 0;
            if(((mem[536877965] + 0) + 16 + 88 + 0) == 536888667)
            {
                goto label_36;
            }
            
            val_16 = val_16 + 1;
            val_17 = (uint)val_16 & 65535;
            if(val_17 < ((mem[536877965] + 0) + 16 + 178))
            {
                goto label_37;
            }
            
            label_35:
            val_23 = (mem[536877965] + 0) + 16;
            goto label_38;
            label_36:
            var val_13 = ((mem[536877965] + 0) + 16 + 88) + 0;
            val_28 = val_28 + ((((mem[536877965] + 0) + 16 + 88 + 0) + 4) << 3);
            val_23 = val_28 + 196;
            label_38:
            val_15 = val_15 + 1;
            label_3:
            if(val_15 < mem[536877969])
            {
                goto label_40;
            }
            
            return;
            label_2:
            val_14 = new System.Collections.Generic.List<Page>();
        }
        public static UnityEngine.Rect GetBounds(System.Collections.Generic.List<Ferr.ISVGElement> aPaths, UnityEngine.Vector2 aPadding)
        {
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_25;
            if((aPadding.x + 12) == 0)
            {
                    return new UnityEngine.Rect() {m_XMin = val_27};
            }
            
            var val_20 = aPadding.x + 8 + 16;
            if((aPadding.x + 8 + 16 + 178) == 0)
            {
                goto label_4;
            }
            
            var val_19 = 0;
            label_6:
            val_20 = mem[aPadding.x + 8 + 16 + 88 + 0];
            val_20 = aPadding.x + 8 + 16 + 88 + 0;
            if(val_20 == 536888667)
            {
                goto label_5;
            }
            
            val_19 = val_19 + 1;
            val_20 = (uint)val_19 & 65535;
            if(val_20 < (aPadding.x + 8 + 16 + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_21 = aPadding.x + 8 + 16;
            goto label_7;
            label_5:
            var val_1 = (aPadding.x + 8 + 16 + 88) + 0;
            val_20 = val_20 + (((aPadding.x + 8 + 16 + 88 + 0) + 4) << 3);
            val_21 = val_20 + 204;
            label_7:
            val_22 = 1;
            goto label_9;
            label_21:
            if( <= val_22)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_21 = aPadding.x + 8;
            val_21 = val_21 + 4;
            var val_23 = (aPadding.x + 8 + 4) + 16;
            if(((aPadding.x + 8 + 4) + 16 + 178) == 0)
            {
                goto label_12;
            }
            
            var val_22 = 0;
            label_14:
            val_20 = 0;
            val_23 = mem[(aPadding.x + 8 + 4) + 16 + 88 + 0];
            val_23 = (aPadding.x + 8 + 4) + 16 + 88 + 0;
            if(val_23 == 536888667)
            {
                goto label_13;
            }
            
            val_22 = val_22 + 1;
            val_20 = (uint)val_22 & 65535;
            if(val_20 < ((aPadding.x + 8 + 4) + 16 + 178))
            {
                goto label_14;
            }
            
            label_12:
            val_25 = (aPadding.x + 8 + 4) + 16;
            goto label_15;
            label_13:
            var val_2 = ((aPadding.x + 8 + 4) + 16 + 88) + 0;
            val_23 = val_23 + ((((aPadding.x + 8 + 4) + 16 + 88 + 0) + 4) << 3);
            val_25 = val_23 + 204;
            label_15:
            float val_3 = xMin;
            float val_4 = xMin;
            if(val_23 < 0)
            {
                    xMin = xMin;
            }
            
            float val_6 = xMax;
            float val_7 = xMax;
            if(val_23 > 536888667)
            {
                    xMax = xMax;
            }
            
            float val_9 = yMin;
            float val_10 = yMin;
            if(val_23 < 0)
            {
                    yMin = yMin;
            }
            
            float val_12 = yMax;
            float val_13 = yMax;
            if(val_23 > 536888667)
            {
                    yMax = yMax;
            }
            
            val_22 = 2;
            label_9:
            if(val_22 < (aPadding.x + 12))
            {
                goto label_21;
            }
            
            float val_15 = xMin;
            uint val_24 = 1264911544;
            val_24 = val_24 - aPadding.y;
            xMin = val_24;
            float val_16 = xMax;
            uint val_25 = 1264911544;
            val_25 = val_25 + aPadding.y;
            xMax = val_25;
            float val_17 = yMin;
            uint val_26 = 1264911544;
            val_26 = val_26 - (???);
            yMin = val_26;
            float val_18 = yMax;
            uint val_27 = 1264911544;
            val_27 = val_27 + (???);
            yMax = val_27;
            return new UnityEngine.Rect() {m_XMin = val_27};
        }
        public static void GizmoDraw(System.Collections.Generic.List<Ferr.ISVGElement> aElements, int aResolution)
        {
            System.Collections.Generic.List<UnityEngine.Vector2> val_3;
            var val_4;
            var val_5;
            if(aElements == 0)
            {
                    return;
            }
            
            if(true < 1)
            {
                    return;
            }
            
            var val_9 = 0;
            label_15:
            if(true <= val_9)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            val_3 = mem[(0 + 0) + 16];
            val_3 = (0 + 0) + 16;
            var val_5 = val_3;
            if(((0 + 0) + 16 + 178) == 0)
            {
                goto label_5;
            }
            
            var val_4 = 0;
            label_7:
            if(((0 + 0) + 16 + 88 + 0) == 536888667)
            {
                goto label_6;
            }
            
            val_4 = val_4 + 1;
            if(((uint)val_4 & 65535) < ((0 + 0) + 16 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_4 = val_3;
            goto label_8;
            label_6:
            var val_1 = ((0 + 0) + 16 + 88) + 0;
            val_5 = val_5 + ((((0 + 0) + 16 + 88 + 0) + 4) << 3);
            val_4 = val_5 + 228;
            label_8:
            if(val_3 <= val_9)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            var val_8 = (0 + 0) + 16;
            if(((0 + 0) + 16 + 178) == 0)
            {
                goto label_11;
            }
            
            var val_7 = 0;
            label_13:
            val_3 = mem[(0 + 0) + 16 + 88 + 0];
            val_3 = (0 + 0) + 16 + 88 + 0;
            if(val_3 == 536888667)
            {
                goto label_12;
            }
            
            val_7 = val_7 + 1;
            if(((uint)val_7 & 65535) < ((0 + 0) + 16 + 178))
            {
                goto label_13;
            }
            
            label_11:
            val_5 = (0 + 0) + 16;
            goto label_14;
            label_12:
            var val_2 = ((0 + 0) + 16 + 88) + 0;
            val_8 = val_8 + ((((0 + 0) + 16 + 88 + 0) + 4) << 3);
            val_5 = val_8 + 212;
            label_14:
            Ferr.PathUtil.GizmoDraw(aPath:  val_3, aVertSize:  null, aClosed:  false, aDrawLine:  (0 + 0) + 16, aArrowSize:  null);
            val_9 = val_9 + 1;
            if(val_9 < val_3)
            {
                goto label_15;
            }
        
        }
        public static Ferr.ISVGElement CreateRect(UnityEngine.Rect r)
        {
            536893227 = new Ferr.SVGLine(aClosed:  true);
            float val_2 = r.m_XMin.xMin;
            float val_3 = r.m_XMin.yMin;
            val_1.Add(aPt:  new UnityEngine.Vector2() {x = 1.524526E+07f, y = 1.524526E+07f});
            float val_4 = r.m_XMin.xMax;
            float val_5 = r.m_XMin.yMin;
            val_1.Add(aPt:  new UnityEngine.Vector2() {x = 1.524526E+07f, y = 1.524526E+07f});
            float val_6 = r.m_XMin.xMax;
            float val_7 = r.m_XMin.yMax;
            val_1.Add(aPt:  new UnityEngine.Vector2() {x = 1.524526E+07f, y = 1.524526E+07f});
            float val_8 = r.m_XMin.xMin;
            float val_9 = r.m_XMin.yMax;
            val_1.Add(aPt:  new UnityEngine.Vector2() {x = 1.524526E+07f, y = 1.524526E+07f});
        }
        public static Ferr.ISVGElement CreateCircle(UnityEngine.Vector2 aAt, float aRadius)
        {
            536893229 = new Ferr.SVGPath(aClosed:  true);
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.left;
            float val_8 = 1.2f;
            val_8 = (R2 * R2) * val_8;
            float val_6 = val_8 ^ 2147483648;
            val_2.Add(aPt:  new UnityEngine.Vector2() {x = aAt.x, y = aAt.y}, aType:  0, aControlPointPrev:  new UnityEngine.Vector2() {x = 0f, y = val_6}, aControlPointNext:  new UnityEngine.Vector2() {x = 0f, y = val_8});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.right;
            val_2.Add(aPt:  new UnityEngine.Vector2() {x = aAt.x, y = aAt.y}, aType:  0, aControlPointPrev:  new UnityEngine.Vector2() {x = 0f, y = val_8}, aControlPointNext:  new UnityEngine.Vector2() {x = 0f, y = val_6});
        }
    
    }

}
