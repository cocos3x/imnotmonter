using UnityEngine;

namespace FerrPoly2Tri
{
    public class TriangulationUtil
    {
        // Methods
        public static bool SmartIncircle(FerrPoly2Tri.Point2D pa, FerrPoly2Tri.Point2D pb, FerrPoly2Tri.Point2D pc, FerrPoly2Tri.Point2D pd)
        {
            var val_7;
            var val_8;
            FerrPoly2Tri.Point2D val_7 = pa;
            val_7 = pd;
            FerrPoly2Tri.Point2D val_8 = pa;
            val_7 = val_7 - val_7;
            val_8 = val_8 - pd;
            val_8 = 0;
            FerrPoly2Tri.Point2D val_2 = pb - pd;
            FerrPoly2Tri.Point2D val_3 = val_7 * val_2;
            if(pb <= 0)
            {
                    return true;
            }
            
            FerrPoly2Tri.Point2D val_9 = pc;
            val_7 = val_9 - val_7;
            FerrPoly2Tri.Point2D val_10 = pc;
            val_9 = val_8 * val_7;
            val_10 = val_10 - pd;
            if(pc <= 0)
            {
                    return true;
            }
            
            FerrPoly2Tri.Point2D val_5 = (pb - val_7) * val_10;
            FerrPoly2Tri.Point2D val_6 = val_8 * val_8;
            val_10 = val_10 * val_10;
            val_9 = (val_2 * val_2) * val_9;
            if(pc > 0)
            {
                    val_8 = 1;
            }
            
            return true;
        }
        public static bool InScanArea(FerrPoly2Tri.Point2D pa, FerrPoly2Tri.Point2D pb, FerrPoly2Tri.Point2D pc, FerrPoly2Tri.Point2D pd)
        {
            var val_3;
            FerrPoly2Tri.Point2D val_3 = pa;
            FerrPoly2Tri.Point2D val_4 = pa;
            val_3 = val_3 - pd;
            val_4 = val_4 - pd;
            FerrPoly2Tri.Point2D val_1 = pb - pd;
            FerrPoly2Tri.Point2D val_5 = pb;
            val_5 = val_5 - pd;
            val_5 = val_3 * val_5;
            if(pb > 0)
            {
                    FerrPoly2Tri.Point2D val_2 = pc - pd;
                FerrPoly2Tri.Point2D val_6 = pc;
                val_2 = val_4 * val_2;
                val_6 = val_6 - pd;
                if(pc > 0)
            {
                    val_3 = 1;
            }
            
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public static FerrPoly2Tri.Orientation Orient2d(FerrPoly2Tri.Point2D pa, FerrPoly2Tri.Point2D pb, FerrPoly2Tri.Point2D pc)
        {
            var val_2;
            var val_3;
            FerrPoly2Tri.Point2D val_2 = pa;
            FerrPoly2Tri.Point2D val_3 = pb;
            val_2 = val_2 - pc;
            val_3 = val_3 - pc;
            FerrPoly2Tri.Point2D val_4 = pc;
            val_2 = val_2 * val_3;
            val_2 = 536890297;
            FerrPoly2Tri.Point2D val_1 = pa - pc;
            val_4 = pb - val_4;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_2 = 536890297;
            }
            
            val_3 = mem[mem[536890389]];
            val_3 = mem[536890389];
            if(mem[536890413] > 0)
            {
                    if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_3 = mem[mem[536890389]];
                val_3 = mem[536890389];
            }
            
                if(mem[536890413] < 0)
            {
                    return;
            }
            
            }
            
            if(mem[536890413] > 0)
            {
                    0 = 1;
            }
        
        }
        public static bool PointInBoundingBox(double xmin, double xmax, double ymin, double ymax, FerrPoly2Tri.Point2D p)
        {
            var val_1;
            if(val_1 <= 0)
            {
                    return true;
            }
            
            if(val_1 >= 0)
            {
                    return true;
            }
            
            if(val_1 <= 0)
            {
                    return true;
            }
            
            if(val_1 < 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool PointOnLineSegment2D(FerrPoly2Tri.Point2D lineStart, FerrPoly2Tri.Point2D lineEnd, FerrPoly2Tri.Point2D p, double epsilon)
        {
            return (bool)FerrPoly2Tri.TriangulationUtil.PointOnLineSegment2D(x1:  epsilon, y1:  null, x2:  null, y2:  null, x:  null, y:  null, epsilon:  null);
        }
        public static bool PointOnLineSegment2D(double x1, double y1, double x2, double y2, double x, double y, double epsilon)
        {
            float val_3;
            var val_5;
            float val_6;
            var val_12;
            float val_13;
            bool val_14;
            var val_15;
            bool val_16;
            bool val_17;
            bool val_18;
            val_12 = 0;
            val_13 = val_3;
            val_14 = mem[536890484];
            if((val_14 & true) == 0)
            {
                    val_14 = mem[536890413];
            }
            
            val_15 = 0;
            if((FerrPoly2Tri.MathUtil.IsValueBetween(val:  x1, min:  y1, max:  x2, tolerance:  y2)) == false)
            {
                    return (bool)val_15;
            }
            
            val_16 = mem[536890484];
            if((val_16 & true) == 0)
            {
                    val_16 = mem[536890413];
            }
            
            val_15 = 0;
            if((FerrPoly2Tri.MathUtil.IsValueBetween(val:  x1, min:  y1, max:  x2, tolerance:  y2)) == false)
            {
                    return (bool)val_15;
            }
            
            val_17 = mem[536890484];
            if((val_17 & true) == 0)
            {
                    val_17 = mem[536890413];
            }
            
            val_13 = val_13 - 0;
            val_12 = 0;
            val_15 = 1;
            if((FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  x1, val2:  y1, tolerance:  x2)) != false)
            {
                    return (bool)val_15;
            }
            
            val_18 = mem[536890484];
            val_13 = (val_6 - R2) / val_13;
            if((val_18 & true) == 0)
            {
                    val_18 = mem[536890413];
            }
            
            double val_10 = val_5 - R2;
            bool val_11 = FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  x1, val2:  y1, tolerance:  x2);
            return (bool)val_15;
        }
        public static bool RectsIntersect(FerrPoly2Tri.Rect2D r1, FerrPoly2Tri.Rect2D r2)
        {
            if(r2 <= 0)
            {
                    return true;
            }
            
            if(r2 >= 0)
            {
                    return true;
            }
            
            if(r2 <= 0)
            {
                    return true;
            }
            
            if(r2 < 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool LinesIntersect2D(FerrPoly2Tri.Point2D ptStart0, FerrPoly2Tri.Point2D ptEnd0, FerrPoly2Tri.Point2D ptStart1, FerrPoly2Tri.Point2D ptEnd1, bool firstIsSegment, bool secondIsSegment, bool coincidentEndPointCollisions, ref FerrPoly2Tri.Point2D pIntersectionPt, double epsilon)
        {
            FerrPoly2Tri.Point2D val_13;
            FerrPoly2Tri.Point2D val_14;
            float val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            double val_20;
            var val_21;
            var val_22;
            bool val_23;
            bool val_24;
            val_13 = ptEnd1;
            val_14 = ptStart1;
            val_15 = typeof(FerrPoly2Tri.Point2D).__il2cppRuntimeField_E8;
            val_16 = typeof(FerrPoly2Tri.Point2D).__il2cppRuntimeField_F8;
            FerrPoly2Tri.Point2D val_12 = ptEnd0;
            val_17 = val_14;
            val_18 = val_14 - val_13;
            val_19 = ptEnd0;
            val_12 = val_12 - ptStart0;
            val_20 = val_13;
            FerrPoly2Tri.Point2D val_13 = ptStart0;
            val_12 = val_12 * val_18;
            FerrPoly2Tri.Point2D val_2 = val_17 - val_20;
            val_13 = val_19 - val_13;
            double val_14 = System.Math.Abs(val_12);
            val_21 = 0;
            if(mem[536890411] < 0)
            {
                    return (bool)val_21;
            }
            
            val_17 = val_14 - val_13;
            val_18 = val_14 - ptStart0;
            val_19 = val_13;
            val_14 = val_14;
            val_15 = typeof(FerrPoly2Tri.Point2D).__il2cppRuntimeField_E8;
            val_20 = 1;
            val_16 = ptStart0 + 232;
            val_13 = ptEnd0 + 248;
            double val_4 = val_20 / val_12;
            FerrPoly2Tri.Point2D val_5 = val_14 - val_19;
            FerrPoly2Tri.Point2D val_6 = val_14 - ptStart0;
            val_22 = val_4 * (val_18 * val_17);
            if(firstIsSegment != false)
            {
                    if((firstIsSegment < false) || (firstIsSegment > false))
            {
                goto label_11;
            }
            
            }
            
            val_21 = 0;
            FerrPoly2Tri.Point2D val_15 = ptEnd0;
            val_15 = val_15 - ptStart0;
            var val_16 = val_14;
            val_16 = val_16 - ptStart0;
            val_15 = val_15 * val_16;
            FerrPoly2Tri.Point2D val_7 = val_14 - ptStart0;
            FerrPoly2Tri.Point2D val_8 = ptEnd0 - ptStart0;
            val_18 = val_4 * val_15;
            if(secondIsSegment != false)
            {
                    if(secondIsSegment < false)
            {
                    return (bool)val_21;
            }
            
                if(secondIsSegment > false)
            {
                    return (bool)val_21;
            }
            
            }
            
            if(coincidentEndPointCollisions == false)
            {
                goto label_15;
            }
            
            label_24:
            val_15 = pIntersectionPt;
            val_21 = 1;
            val_13 = pIntersectionPt;
            if(val_13 == 0)
            {
                    return (bool)val_21;
            }
            
            val_14 = ptEnd0;
            FerrPoly2Tri.Point2D val_17 = ptStart0;
            val_17 = val_14 - val_17;
            val_13 = pIntersectionPt;
            val_16 = ptStart0;
            val_20 = val_14;
            val_18 = ptStart0;
            FerrPoly2Tri.Point2D val_9 = val_20 - val_18;
            return (bool)val_21;
            label_15:
            val_23 = mem[536890484];
            if((val_23 & true) == 0)
            {
                    val_23 = mem[536890413];
            }
            
            val_21 = 0;
            if((FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  epsilon, val2:  null, tolerance:  null)) == true)
            {
                    return (bool)val_21;
            }
            
            val_24 = mem[536890484];
            if((val_24 & true) == 0)
            {
                    val_24 = mem[536890413];
            }
            
            val_21 = 0;
            if((FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  epsilon, val2:  null, tolerance:  null)) == false)
            {
                goto label_24;
            }
            
            return (bool)val_21;
            label_11:
            val_21 = 0;
            return (bool)val_21;
        }
        public static bool LinesIntersect2D(FerrPoly2Tri.Point2D ptStart0, FerrPoly2Tri.Point2D ptEnd0, FerrPoly2Tri.Point2D ptStart1, FerrPoly2Tri.Point2D ptEnd1, ref FerrPoly2Tri.Point2D pIntersectionPt, double epsilon)
        {
            return (bool)FerrPoly2Tri.TriangulationUtil.LinesIntersect2D(ptStart0:  ptStart0, ptEnd0:  ptEnd0, ptStart1:  ptStart1, ptEnd1:  ptEnd1, firstIsSegment:  true, secondIsSegment:  true, coincidentEndPointCollisions:  false, pIntersectionPt: ref  FerrPoly2Tri.Point2D val_2 = pIntersectionPt, epsilon:  epsilon);
        }
        public static double LI2DDotProduct(FerrPoly2Tri.Point2D v0, FerrPoly2Tri.Point2D v1)
        {
            FerrPoly2Tri.Point2D val_1 = v1;
            val_1 = v0 * val_1;
            return (double)D0;
        }
        public static bool RaysIntersect2D(FerrPoly2Tri.Point2D ptRayOrigin0, FerrPoly2Tri.Point2D ptRayVector0, FerrPoly2Tri.Point2D ptRayOrigin1, FerrPoly2Tri.Point2D ptRayVector1, ref FerrPoly2Tri.Point2D ptIntersection)
        {
            var val_9;
            var val_10;
            if(ptIntersection != 0)
            {
                    FerrPoly2Tri.Point2D val_1 = ptRayOrigin1 - ptRayOrigin0;
                FerrPoly2Tri.Point2D val_2 = ptRayOrigin1 - ptRayOrigin0;
                536891877 = new FerrPoly2Tri.Point2D(x:  null, y:  null);
                val_9 = typeof(FerrPoly2Tri.Point2D).__il2cppRuntimeField_E8;
                val_10 = 0;
                536891877 = new FerrPoly2Tri.Point2D(x:  null, y:  null);
                double val_5 = FerrPoly2Tri.TriangulationUtil.LI2DDotProduct(v0:  ptRayVector0, v1:  536891877);
                FerrPoly2Tri.Point2D val_10 = ptRayVector0;
                double val_9 = System.Math.Abs(val_10);
                if(mem[536890411] < 0)
            {
                    return (bool)val_10;
            }
            
                double val_6 = FerrPoly2Tri.TriangulationUtil.LI2DDotProduct(v0:  536891877, v1:  536891877);
                val_9 = typeof(FerrPoly2Tri.Point2D).__il2cppRuntimeField_E8;
                val_10 = 536891877 / val_10;
                val_10 = 1;
                return (bool)val_10;
            }
            
            val_9 = 22713020;
            double val_11 = System.Math.Abs(ptRayVector1 - ptRayVector0);
            if(mem[536890411] > 0)
            {
                    double val_12 = System.Math.Abs(ptRayVector1 - ptRayVector0);
                if(mem[536890411] <= 0)
            {
                    val_10 = 0;
            }
            
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public TriangulationUtil()
        {
        
        }
    
    }

}
