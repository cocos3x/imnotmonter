using UnityEngine;

namespace FerrPoly2Tri
{
    public class PolygonUtil
    {
        // Methods
        public static FerrPoly2Tri.Point2DList.WindingOrderType CalculateWindingOrder(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> l)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_8 = 0;
            val_9 = 22705828;
            goto label_1;
            label_36:
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_10 = l;
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_11 = l;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_12 = l;
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_13 = l;
            val_9 = 22705828;
            val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = l;
            val_16 = 1;
            val_8 = val_16;
            label_1:
            val_14 = 0;
            val_16 = 0;
            val_14 = val_14 + 1;
            val_16 = (uint)val_14 & 65535;
            val_17 = l;
            if(val_8 < l)
            {
                goto label_36;
            }
            
            double val_11 = 0.5;
            val_11 = D8 * val_11;
            if(val_8 < 0)
            {
                    return;
            }
            
            if(val_8 <= l)
            {
                    1 = 2;
            }
        
        }
        public static bool PolygonsAreSame2D(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly1, System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly2)
        {
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_10;
            FerrPoly2Tri.Point2D val_11;
            var val_13;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_22;
            var val_23;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_24;
            var val_25;
            val_10 = poly1;
            val_11 = poly2;
            val_13 = 0;
            val_14 = 0;
            val_13 = val_13 + 1;
            val_14 = (uint)val_13 & 65535;
            val_15 = val_10;
            val_13 = 0;
            val_14 = 0;
            val_13 = val_13 + 1;
            val_14 = (uint)val_13 & 65535;
            val_16 = val_11;
            val_17 = 0;
            if(val_10 != val_11)
            {
                    return (bool)val_17;
            }
            
            FerrPoly2Tri.Point2D val_3 = 536891877;
            val_17 = 0;
            val_13 = val_3;
            val_3 = new FerrPoly2Tri.Point2D(x:  null, y:  null);
            if(val_10 < 1)
            {
                    return (bool)val_17;
            }
            
            val_18 = 0;
            label_27:
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_19 = val_10;
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_14 = (uint)val_11 & 65535;
            val_20 = val_11;
            if(val_13 != 0)
            {
                    val_13.Subtract(p:  val_11);
            }
            else
            {
                    val_13.Subtract(p:  val_11);
            }
            
            double val_6 = val_13.MagnitudeSquared();
            if(val_13 < 0)
            {
                goto label_26;
            }
            
            val_18 = val_18 + 1;
            if(val_18 < val_10)
            {
                goto label_27;
            }
            
            val_17 = 0;
            return (bool)val_17;
            label_26:
            val_17 = 1;
            if(val_10 < 2)
            {
                    return (bool)val_17;
            }
            
            label_48:
            val_10 = 1;
            label_46:
            if((0 & 1) == 0)
            {
                    if((-1) <= 1)
            {
                    val_21 = val_10 - 1;
            }
            
            }
            else
            {
                    val_21 = val_18 + 1;
            }
            
            var val_13 = val_10;
            if((poly1 + 178) == 0)
            {
                goto label_33;
            }
            
            var val_12 = 0;
            label_35:
            if((poly1 + 88 + 0) == 536877047)
            {
                goto label_34;
            }
            
            val_12 = val_12 + 1;
            if(((uint)val_12 & 65535) < (poly1 + 178))
            {
                goto label_35;
            }
            
            label_33:
            val_22 = val_10;
            val_23 = val_22;
            goto label_36;
            label_34:
            var val_7 = (poly1 + 88) + 0;
            val_22 = val_10;
            val_13 = val_13 + (((poly1 + 88 + 0) + 4) << 3);
            val_23 = val_13 + 188;
            label_36:
            val_14 = val_10;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = (uint)val_14 & 65535;
            val_24 = val_11;
            val_25 = val_24;
            if(val_13 != 0)
            {
                    val_13.Subtract(p:  null);
            }
            else
            {
                    val_13.Subtract(p:  null);
            }
            
            double val_9 = val_13.MagnitudeSquared();
            val_11 = val_11;
            if(val_13 >= 0)
            {
                goto label_45;
            }
            
            val_10 = val_10 + 1;
            if(val_10 < val_10)
            {
                goto label_46;
            }
            
            goto label_47;
            label_45:
            val_17 = 0;
            if((0 & 1) != 0)
            {
                goto label_48;
            }
            
            return (bool)val_17;
            label_47:
            val_17 = 1;
            return (bool)val_17;
        }
        public static bool PointInPolygon2D(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> polygon, FerrPoly2Tri.Point2D p)
        {
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_9;
            FerrPoly2Tri.Point2D val_10;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_9 = polygon;
            val_10 = p;
            if(val_9 != 0)
            {
                    val_11 = 0;
                val_12 = 0;
                val_11 = val_11 + 1;
                val_12 = (uint)val_11 & 65535;
                val_13 = val_9;
                if(val_9 >= 3)
            {
                    var val_9 = 0;
                val_9 = val_9 + 1;
                val_14 = val_9;
                val_15 = val_9 - 1;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_16 = val_9;
                val_12 = val_9;
                val_11 = typeof(System.Collections.Generic.IList<T>).__il2cppRuntimeField_F8;
                if(val_9 >= 1)
            {
                    if(val_9 >= 1)
            {
                    0 = 1;
            }
            
                do
            {
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_17 = val_9;
                val_11 = val_9;
                if(val_10 >= 0)
            {
                    0 = 1;
            }
            
                if((1 ^ 1 & 1) == 0)
            {
                    val_10 = val_10;
                var val_12 = val_11;
                float val_13 = val_11;
                val_12 = val_9 - val_12;
                val_13 = val_13 - val_10;
                val_12 = (val_11 - val_10) * val_12;
                float val_8 = val_13 * (val_9 - val_11);
                if(val_9 < 0)
            {
                    0 = 1;
            }
            
                if(val_9 >= 0)
            {
                    0 = 1;
            }
            
            }
            
                val_15 = 1;
                val_9 = val_9;
                val_12 = 0 + 1;
            }
            while(val_12 != val_9);
            
            }
            
            }
            
            }
            
            var val_14 = 0;
            val_14 = val_14 & 1;
            return (bool)val_14;
        }
        public static bool PolygonsIntersect2D(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly1, FerrPoly2Tri.Rect2D boundRect1, System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly2, FerrPoly2Tri.Rect2D boundRect2)
        {
            var val_16;
            var val_17;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            bool val_23;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_24;
            var val_25;
            var val_26;
            var val_27;
            FerrPoly2Tri.Point2D val_28;
            var val_29;
            FerrPoly2Tri.Point2D val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            val_16 = boundRect1;
            if(poly1 == 0)
            {
                    return false;
            }
            
            val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = poly1;
            val_19 = val_18;
            if(val_16 == 0)
            {
                    return false;
            }
            
            if( < 3)
            {
                    return false;
            }
            
            var val_20 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_8;
            }
            
            var val_19 = 0;
            label_10:
            if((mem[1179403735] + 0) == 536875901)
            {
                goto label_9;
            }
            
            val_19 = val_19 + 1;
            if(((uint)val_19 & 65535) < mem[1179403825])
            {
                goto label_10;
            }
            
            label_8:
            val_20 = 0;
            val_21 = val_20;
            goto label_11;
            label_9:
            var val_2 = mem[1179403735] + 0;
            val_20 = 0;
            val_20 = val_20 + (((mem[1179403735] + 0) + 4) << 3);
            val_21 = val_20 + 188;
            label_11:
            if(boundRect2 == 0)
            {
                    return false;
            }
            
            if(val_20 < 3)
            {
                    return false;
            }
            
            if((val_16.Intersects(r:  boundRect2)) == false)
            {
                    return false;
            }
            
            double val_4 = val_16.Width;
            val_22 = 536890297;
            val_23 = mem[536890484];
            if((val_23 & true) == 0)
            {
                    val_23 = mem[536890413];
                if(val_23 == 0)
            {
                    val_22 = 536890297;
            }
            
            }
            
            double val_21 = 1.85674631709461E-314;
            var val_22 = 0;
            val_21 = val_16 * val_21;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_23 = poly1;
            if((poly1 + 178) == 0)
            {
                goto label_19;
            }
            
            label_21:
            if((poly1 + 88 + 0) == 536875901)
            {
                goto label_20;
            }
            
            val_22 = val_22 + 1;
            if(((uint)val_22 & 65535) < (poly1 + 178))
            {
                goto label_21;
            }
            
            label_19:
            val_24 = poly1;
            val_25 = val_24;
            goto label_22;
            label_20:
            var val_8 = (poly1 + 88) + 0;
            val_24 = poly1;
            val_23 = val_23 + (((poly1 + 88 + 0) + 4) << 3);
            val_25 = val_23 + 188;
            label_22:
            var val_25 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_23;
            }
            
            var val_24 = 0;
            label_25:
            if((mem[1179403735] + 0) == 536875901)
            {
                goto label_24;
            }
            
            val_24 = val_24 + 1;
            if(((uint)val_24 & 65535) < mem[1179403825])
            {
                goto label_25;
            }
            
            label_23:
            val_26 = 0;
            val_27 = val_26;
            goto label_26;
            label_24:
            var val_9 = mem[1179403735] + 0;
            val_26 = 0;
            val_25 = val_25 + (((mem[1179403735] + 0) + 4) << 3);
            val_27 = val_25 + 188;
            label_26:
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_27 = val_24;
            if(val_27 < 1)
            {
                    return false;
            }
            
            var val_26 = 0;
            label_47:
            val_26 = val_26 + 1;
            val_27 = val_26 - val_27;
            if(val_27 != 1)
            {
                    val_27 = val_26;
            }
            
            label_45:
            if(0 >= val_26)
            {
                goto label_28;
            }
            
            FerrPoly2Tri.Point2D val_10 = 0 + 1;
            if(0 != val_26)
            {
                    val_10 - val_26 = val_10;
            }
            
            if((poly1 + 178) == 0)
            {
                goto label_29;
            }
            
            var val_28 = 0;
            label_31:
            if((poly1 + 88 + 0) == 536877047)
            {
                goto label_30;
            }
            
            val_28 = val_28 + 1;
            if(((uint)val_28 & 65535) < (poly1 + 178))
            {
                goto label_31;
            }
            
            label_29:
            val_28 = val_10;
            val_29 = val_28;
            goto label_32;
            label_30:
            var val_12 = (poly1 + 88) + 0;
            val_28 = val_10;
            val_29 = (poly1 + (((poly1 + 88 + 0) + 4) << 3)) + 188;
            label_32:
            var val_30 = val_28;
            if(((0 + 1) + 178) == 0)
            {
                goto label_33;
            }
            
            var val_29 = 0;
            label_35:
            if(((0 + 1) + 88 + 0) == 536877047)
            {
                goto label_34;
            }
            
            val_29 = val_29 + 1;
            if(((uint)val_29 & 65535) < ((0 + 1) + 178))
            {
                goto label_35;
            }
            
            label_33:
            val_30 = val_10;
            val_31 = val_30;
            goto label_36;
            label_34:
            var val_14 = ((0 + 1) + 88) + 0;
            val_30 = val_10;
            val_30 = val_30 + ((((0 + 1) + 88 + 0) + 4) << 3);
            val_31 = val_30 + 188;
            label_36:
            var val_32 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_37;
            }
            
            var val_31 = 0;
            label_39:
            if((mem[1179403735] + 0) == 536877047)
            {
                goto label_38;
            }
            
            val_31 = val_31 + 1;
            if(((uint)val_31 & 65535) < mem[1179403825])
            {
                goto label_39;
            }
            
            label_37:
            val_32 = 0;
            goto label_40;
            label_38:
            var val_15 = mem[1179403735] + 0;
            val_32 = val_32 + (((mem[1179403735] + 0) + 4) << 3);
            val_32 = val_32 + 188;
            label_40:
            var val_34 = 1179403647;
            if(mem[1179403825] == 0)
            {
                goto label_41;
            }
            
            var val_33 = 0;
            label_43:
            if((mem[1179403735] + 0) == 536877047)
            {
                goto label_42;
            }
            
            val_33 = val_33 + 1;
            if(((uint)val_33 & 65535) < mem[1179403825])
            {
                goto label_43;
            }
            
            label_41:
            val_33 = 0;
            val_34 = val_33;
            goto label_44;
            label_42:
            var val_16 = mem[1179403735] + 0;
            val_33 = 0;
            val_34 = val_34 + (((mem[1179403735] + 0) + 4) << 3);
            val_34 = val_34 + 188;
            label_44:
            if((FerrPoly2Tri.TriangulationUtil.LinesIntersect2D(ptStart0:  val_28, ptEnd0:  val_30, ptStart1:  0, ptEnd1:  0, pIntersectionPt: ref  0, epsilon:  System.Math.Max(val1:  System.Math.Min(val1:  boundRect2.Width, val2:  null), val2:  null))) == false)
            {
                goto label_45;
            }
            
            return false;
            label_28:
            if(val_26 < val_24)
            {
                goto label_47;
            }
            
            return false;
        }
        public bool PolygonContainsPolygon(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly1, FerrPoly2Tri.Rect2D boundRect1, System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly2, FerrPoly2Tri.Rect2D boundRect2)
        {
            return (bool)FerrPoly2Tri.PolygonUtil.PolygonContainsPolygon(poly1:  poly1, boundRect1:  boundRect1, poly2:  poly2, boundRect2:  boundRect2, runIntersectionTest:  true);
        }
        public static bool PolygonContainsPolygon(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly1, FerrPoly2Tri.Rect2D boundRect1, System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly2, FerrPoly2Tri.Rect2D boundRect2, bool runIntersectionTest)
        {
            bool val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            val_8 = runIntersectionTest;
            val_9 = 23000779;
            if(poly1 == 0)
            {
                    return false;
            }
            
            val_9 = 0;
            val_10 = 0;
            val_9 = val_9 + 1;
            val_10 = (uint)val_9 & 65535;
            val_11 = poly1;
            if(poly2 == 0)
            {
                    return false;
            }
            
            if(poly1 < 3)
            {
                    return false;
            }
            
            val_9 = 0;
            val_10 = 0;
            val_9 = val_9 + 1;
            val_10 = (uint)val_9 & 65535;
            val_12 = poly2;
            if(poly2 < 3)
            {
                    return false;
            }
            
            if(val_8 != false)
            {
                    val_10 = 0;
                val_9 = 0;
                val_10 = val_10 + 1;
                val_9 = (uint)val_10 & 65535;
                val_13 = poly1;
                val_8 = poly1;
                val_10 = 0;
                val_9 = 0;
                val_10 = val_10 + 1;
                val_9 = (uint)val_10 & 65535;
                val_14 = poly2;
                if(val_8 == poly2)
            {
                    if((FerrPoly2Tri.PolygonUtil.PolygonsAreSame2D(poly1:  poly1, poly2:  poly2)) == true)
            {
                    return false;
            }
            
            }
            
                if((FerrPoly2Tri.PolygonUtil.PolygonsIntersect2D(poly1:  poly1, boundRect1:  boundRect1, poly2:  poly2, boundRect2:  boundRect2)) == true)
            {
                    return false;
            }
            
            }
            
            val_10 = 0;
            val_9 = 0;
            val_10 = val_10 + 1;
            val_9 = (uint)val_10 & 65535;
            val_15 = poly2;
            return FerrPoly2Tri.PolygonUtil.PointInPolygon2D(polygon:  poly1, p:  poly2);
        }
        public static void ClipPolygonToEdge2D(FerrPoly2Tri.Point2D edgeBegin, FerrPoly2Tri.Point2D edgeEnd, System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly, out System.Collections.Generic.List<FerrPoly2Tri.Point2D> outPoly)
        {
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_16;
            FerrPoly2Tri.Point2D val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_44;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_45;
            var val_46;
            var val_47;
            var val_48;
            FerrPoly2Tri.Point2D val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            FerrPoly2Tri.Point2D val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            val_39 = poly;
            outPoly = 0;
            if(edgeBegin == 0)
            {
                    return;
            }
            
            if(val_39 == 0)
            {
                    return;
            }
            
            val_40 = 0;
            val_40 = val_40 + 1;
            val_41 = val_39;
            if(val_39 < 3)
            {
                    return;
            }
            
            536878157 = new System.Collections.Generic.List<Page>();
            outPoly = 536878157;
            val_40 = 0;
            val_40 = val_40 + 1;
            val_42 = val_39;
            FerrPoly2Tri.Point2D val_38 = edgeEnd;
            val_38 = val_38 - edgeBegin;
            FerrPoly2Tri.Point2D val_39 = edgeEnd;
            val_39 = val_39 - edgeBegin;
            var val_40 = 0;
            536891877 = new FerrPoly2Tri.Point2D(x:  null, y:  null);
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_5 = val_39 - 1;
            val_40 = val_40 + 1;
            val_43 = val_39;
            val_44 = val_5;
            FerrPoly2Tri.Orientation val_7 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  edgeBegin, pb:  edgeEnd, pc:  val_39);
            536891877 = new FerrPoly2Tri.Point2D(x:  null, y:  null);
            FerrPoly2Tri.Point2D val_9 = 536891877 >> 5;
            val_45 = 0;
            goto label_16;
            label_97:
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_46 = val_39;
            val_44 = val_5;
            FerrPoly2Tri.Orientation val_11 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  edgeBegin, pb:  edgeEnd, pc:  val_39);
            FerrPoly2Tri.Point2D val_12 = edgeEnd >> 5;
            if(edgeBegin != 0)
            {
                    0 = val_12;
            }
            
            if(edgeBegin == 0)
            {
                goto label_21;
            }
            
            if((val_9 & 1) != 0)
            {
                goto label_22;
            }
            
            var val_42 = 0;
            val_42 = val_42 + 1;
            val_47 = val_39;
            goto label_26;
            label_21:
            FerrPoly2Tri.Point2D val_13 = val_9 & 1;
            if(edgeBegin == 0)
            {
                    0 = val_12;
            }
            
            if(edgeBegin == 0)
            {
                goto label_27;
            }
            
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_48 = val_39;
            goto label_31;
            label_22:
            val_49 = val_12;
            goto label_91;
            label_27:
            var val_44 = 0;
            val_44 = val_44 + 1;
            val_50 = val_39;
            goto label_36;
            label_26:
            var val_45 = 0;
            val_45 = val_45 + 1;
            val_51 = val_39;
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_52 = val_39;
            var val_47 = 0;
            val_47 = val_47 + 1;
            val_53 = val_39;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_19 = val_39 - val_39;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_20 = val_39 - val_39;
            536891877 = new FerrPoly2Tri.Point2D(x:  null, y:  null);
            val_44 = val_5;
            var val_48 = 0;
            val_48 = val_48 + 1;
            val_54 = val_39;
            if((FerrPoly2Tri.TriangulationUtil.RaysIntersect2D(ptRayOrigin0:  val_39, ptRayVector0:  536891877, ptRayOrigin1:  edgeBegin, ptRayVector1:  536891877, ptIntersection: ref  536891877)) != false)
            {
                    val_55 = 0;
                outPoly.Add(item:  536891877);
            }
            else
            {
                    val_55 = 0;
            }
            
            val_49 = val_55;
            goto label_91;
            label_31:
            val_44 = val_5;
            outPoly.Add(item:  val_39);
            val_49 = val_12;
            goto label_91;
            label_36:
            var val_49 = 0;
            val_49 = val_49 + 1;
            val_56 = val_39;
            var val_50 = 0;
            val_50 = val_50 + 1;
            val_57 = val_39;
            val_58 = val_39;
            var val_51 = 0;
            val_51 = val_51 + 1;
            val_59 = val_39;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_30 = val_39 - ;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_31 = val_39 - val_39;
            536891877 = new FerrPoly2Tri.Point2D(x:  null, y:  null);
            val_44 = val_5;
            var val_52 = 0;
            val_52 = val_52 + 1;
            val_60 = val_39;
            if((FerrPoly2Tri.TriangulationUtil.RaysIntersect2D(ptRayOrigin0:  val_39, ptRayVector0:  536891877, ptRayOrigin1:  536891877, ptRayVector1:  536891877, ptIntersection: ref  536891877)) == false)
            {
                goto label_85;
            }
            
            outPoly.Add(item:  536891877);
            var val_53 = 0;
            val_53 = val_53 + 1;
            val_61 = val_39;
            goto label_90;
            label_85:
            val_49 = 0;
            goto label_91;
            label_90:
            val_44 = val_5;
            outPoly.Add(item:  val_39);
            val_49 = 0;
            label_91:
            val_45 = val_44 + 1;
            if(val_49 != 0)
            {
                    val_49 = 1;
            }
            
            label_16:
            val_16 = val_44;
            var val_54 = 0;
            val_54 = val_54 + 1;
            val_62 = val_39;
            if(val_45 < val_39)
            {
                goto label_97;
            }
        
        }
        public static void ClipPolygonToPolygon(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> poly, System.Collections.Generic.IList<FerrPoly2Tri.Point2D> clipPoly, out System.Collections.Generic.List<FerrPoly2Tri.Point2D> outPoly)
        {
            System.Collections.Generic.IEnumerable<T> val_9;
            float val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_9 = poly;
            outPoly = 0;
            if(val_9 == 0)
            {
                    return;
            }
            
            val_10 = 4.01254E-38f;
            var val_10 = 0;
            val_11 = 0;
            val_10 = val_10 + 1;
            val_11 = (uint)val_10 & 65535;
            val_12 = val_9;
            if(clipPoly == 0)
            {
                    return;
            }
            
            if(val_9 < 3)
            {
                    return;
            }
            
            var val_11 = 0;
            val_11 = 0;
            val_11 = val_11 + 1;
            val_11 = (uint)val_11 & 65535;
            val_13 = clipPoly;
            if(clipPoly < 3)
            {
                    return;
            }
            
            536878157 = new System.Collections.Generic.List<Point>(collection:  val_9);
            outPoly = 536878157;
            val_11 = 0;
            val_9 = 0;
            val_11 = val_11 + 1;
            val_9 = (uint)val_11 & 65535;
            val_14 = clipPoly;
            if(clipPoly < 1)
            {
                    return;
            }
            
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_5 = clipPoly - 1;
            do
            {
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_15 = clipPoly;
                var val_13 = 0;
                val_13 = val_13 + 1;
                val_9 = (uint)val_13 & 65535;
                val_16 = clipPoly;
                FerrPoly2Tri.PolygonUtil.ClipPolygonToEdge2D(edgeBegin:  clipPoly, edgeEnd:  clipPoly, poly:  536878157, outPoly: out  System.Collections.Generic.List<FerrPoly2Tri.Point2D> val_8 = 1311415176);
                outPoly.Clear();
                outPoly.AddRange(collection:  0);
                var val_9 = 0 + 1;
                val_11 = 0;
                val_10 = val_9;
            }
            while(val_9 != clipPoly);
        
        }
        public static FerrPoly2Tri.PolygonUtil.PolyUnionError PolygonUnion(FerrPoly2Tri.Point2DList polygon1, FerrPoly2Tri.Point2DList polygon2, out FerrPoly2Tri.Point2DList union)
        {
            FerrPoly2Tri.PolygonOperationContext val_1 = 536891965;
            val_1 = new FerrPoly2Tri.PolygonOperationContext();
            if(val_1 != 0)
            {
                    bool val_2 = val_1.Init(operations:  1, polygon1:  polygon1, polygon2:  polygon2);
                FerrPoly2Tri.PolygonUtil.PolygonUnionInternal(ctx:  536891965);
            }
            else
            {
                    bool val_3 = val_1.Init(operations:  1, polygon1:  polygon1, polygon2:  polygon2);
                FerrPoly2Tri.PolygonUtil.PolygonUnionInternal(ctx:  536891965);
            }
            
            FerrPoly2Tri.Point2DList val_4 = val_1.Union;
            union = val_1;
            if(val_1 != 0)
            {
                    return;
            }
        
        }
        protected static void PolygonUnionInternal(FerrPoly2Tri.PolygonOperationContext ctx)
        {
            var val_22;
            var val_23;
            FerrPoly2Tri.Point2DList val_24;
            FerrPoly2Tri.Point2D val_25;
            int val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            System.Collections.Generic.List<System.Int32> val_31;
            var val_32;
            FerrPoly2Tri.PolygonOperationContext val_33;
            var val_34;
            if(ctx != 0)
            {
                    FerrPoly2Tri.Point2DList val_1 = ctx.Union;
                val_23 = ctx;
            }
            else
            {
                    FerrPoly2Tri.Point2DList val_2 = 0.Union;
                val_23 = 0;
            }
            
            if(ctx.mStartingIndex == 1)
            {
                goto label_3;
            }
            
            label_73:
            val_24 = ctx.mPoly1;
            val_25 = mem[ctx + 20 + 4];
            val_25 = ctx + 20 + 4;
            FerrPoly2Tri.Point2D val_3 = val_24.Item[ctx.mStartingIndex];
            val_23.Clear();
            label_44:
            FerrPoly2Tri.Point2D val_4 = val_24.Item[ctx.mStartingIndex];
            List.Enumerator<T> val_5 = GetEnumerator();
            label_25:
            if(MoveNext() == false)
            {
                goto label_9;
            }
            
            FerrPoly2Tri.Point2D val_8 = val_24.Item[ctx.mStartingIndex];
            if((val_24.Equals(p:  val_7 + 16, epsilon:  null)) == false)
            {
                goto label_25;
            }
            
            val_26 = val_25.IndexOf(p:  val_7 + 16);
            int val_11 = val_25.NextIndex(index:  val_26);
            FerrPoly2Tri.Point2D val_12 = val_25.Item[val_11];
            if((ctx + 20 + 20 + 12) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_23 = ctx + 20 + 20 + 8;
            val_23 = val_23 + (val_11 << 2);
            val_27 = mem[(ctx + 20 + 20 + 8 + (val_11) << 2) + 16];
            val_27 = (ctx + 20 + 20 + 8 + (val_11) << 2) + 16;
            if(val_27 == 1)
            {
                goto label_20;
            }
            
            if((ctx + 20 + 20 + 12) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_24 = ctx + 20 + 20 + 8;
                val_24 = val_24 + (val_11 << 2);
                val_27 = mem[(ctx + 20 + 20 + 8 + (val_11) << 2) + 16];
                val_27 = (ctx + 20 + 20 + 8 + (val_11) << 2) + 16;
            }
            
            val_22 = ;
            if(val_27 == 1)
            {
                goto label_25;
            }
            
            goto label_23;
            label_20:
            bool val_13 = ctx.PointInPolygonAngle(point:  val_25, polygon:  val_24);
            ctx + 20 + 20.set_Item(index:  val_11, value:  val_13);
            val_22 = ;
            if(val_13 == true)
            {
                goto label_25;
            }
            
            label_23:
            val_28 = ctx + 20;
            val_29 = 0;
            if(val_24 == val_28)
            {
                goto label_27;
            }
            
            val_30 = val_28;
            val_25 = mem[ctx + 20 + 4];
            val_25 = ctx + 20 + 4;
            val_31 = ctx + 20 + 20;
            goto label_28;
            label_9:
            val_26 = ctx.mStartingIndex;
            val_28 = ctx + 20;
            val_29 = 0;
            goto label_29;
            label_27:
            val_25 = val_24;
            val_30 = ctx + 20 + 4;
            if(0 <= 1)
            {
                    0 = val_26;
            }
            
            val_31 = ctx.mPoly2VectorAngles;
            label_28:
            val_24 = mem[ctx + 20 + 4];
            val_24 = val_30;
            label_29:
            Dispose();
            if(1 != 0)
            {
                    if((1152921510213510572 + ((1 - 1)) << 2) == 385)
            {
                    val_32 = 1 - 1;
            }
            
            }
            else
            {
                    val_32 = 0;
            }
            
            int val_15 = val_24.NextIndex(index:  val_26);
            val_33 = ctx;
            val_34 = val_23;
            if(val_24 == val_28)
            {
                goto label_34;
            }
            
            if((0 < 0) || (val_15 != 0))
            {
                goto label_36;
            }
            
            goto label_45;
            label_34:
            if(val_15 == 0)
            {
                goto label_45;
            }
            
            label_36:
            FerrPoly2Tri.Point2D val_16 = val_24.Item[val_15];
            if(val_24 == val_24)
            {
                goto label_45;
            }
            
            val_26 = val_34.Count;
            int val_19 = ctx + 20 + 4.Count;
            val_33 = ctx;
            val_19 = val_19 + val_28.Count;
            val_34 = val_23;
            if(val_26 <= val_19)
            {
                goto label_44;
            }
            
            label_45:
            val_23 = mem[ctx + 20 + 4];
            val_23 = ctx + 20 + 4;
            int val_22 = val_23.Count;
            val_22 = val_22 + (ctx + 20.Count);
            if(val_34.Count > val_22)
            {
                    val_22 = 3;
                mem2[0] = val_22;
            }
            
            return;
            label_3:
            if(ctx.mError == 3)
            {
                    return;
            }
            
            if(ctx.mError != 2)
            {
                goto label_73;
            }
            
            if(val_23 != 0)
            {
                    return;
            }
        
        }
        public static FerrPoly2Tri.PolygonUtil.PolyUnionError PolygonIntersect(FerrPoly2Tri.Point2DList polygon1, FerrPoly2Tri.Point2DList polygon2, out FerrPoly2Tri.Point2DList intersectOut)
        {
            FerrPoly2Tri.PolygonOperationContext val_1 = 536891965;
            val_1 = new FerrPoly2Tri.PolygonOperationContext();
            if(val_1 != 0)
            {
                    bool val_2 = val_1.Init(operations:  2, polygon1:  polygon1, polygon2:  polygon2);
                FerrPoly2Tri.PolygonUtil.PolygonIntersectInternal(ctx:  536891965);
            }
            else
            {
                    bool val_3 = val_1.Init(operations:  2, polygon1:  polygon1, polygon2:  polygon2);
                FerrPoly2Tri.PolygonUtil.PolygonIntersectInternal(ctx:  536891965);
            }
            
            FerrPoly2Tri.Point2DList val_4 = val_1.Intersect;
            intersectOut = val_1;
            if(val_1 != 0)
            {
                    return;
            }
        
        }
        protected static void PolygonIntersectInternal(FerrPoly2Tri.PolygonOperationContext ctx)
        {
            FerrPoly2Tri.PolygonOperationContext val_25;
            var val_27;
            FerrPoly2Tri.Point2DList val_28;
            FerrPoly2Tri.Point2D val_29;
            int val_30;
            int val_31;
            var val_32;
            var val_33;
            var val_34;
            System.Collections.Generic.List<System.Int32> val_35;
            var val_36;
            int val_37;
            val_25 = ctx;
            if(val_25 != 0)
            {
                    FerrPoly2Tri.Point2DList val_1 = val_25.Intersect;
                val_27 = val_25;
            }
            else
            {
                    FerrPoly2Tri.Point2DList val_2 = 0.Intersect;
                val_27 = 0;
            }
            
            if(ctx.mStartingIndex == 1)
            {
                goto label_3;
            }
            
            label_79:
            val_28 = ctx.mPoly1;
            val_29 = mem[ctx + 20 + 4];
            val_29 = ctx + 20 + 4;
            if((ctx + 20 + 8 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_30 = val_28.IndexOf(p:  ctx + 20 + 8 + 8 + 16 + 16);
            if((ctx + 20) == 0)
            {
                    val_30 = val_30;
            }
            
            FerrPoly2Tri.Point2D val_4 = ctx + 20.Item[val_30];
            val_27.Clear();
            label_50:
            FerrPoly2Tri.Point2D val_5 = val_28.Item[val_30];
            if((val_27.Contains(p:  val_28)) == true)
            {
                goto label_51;
            }
            
            FerrPoly2Tri.Point2D val_7 = val_28.Item[val_30];
            List.Enumerator<T> val_8 = GetEnumerator();
            label_32:
            if(MoveNext() == false)
            {
                goto label_16;
            }
            
            FerrPoly2Tri.Point2D val_11 = val_28.Item[val_30];
            if((val_28.Equals(p:  val_10 + 16, epsilon:  null)) == false)
            {
                goto label_32;
            }
            
            val_31 = val_29.IndexOf(p:  val_10 + 16);
            int val_14 = val_29.NextIndex(index:  val_31);
            FerrPoly2Tri.Point2D val_15 = val_29.Item[val_14];
            if((ctx + 20 + 20 + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_26 = ctx + 20 + 20 + 8;
            val_26 = val_26 + (val_14 << 2);
            val_32 = mem[(ctx + 20 + 20 + 8 + (val_14) << 2) + 16];
            val_32 = (ctx + 20 + 20 + 8 + (val_14) << 2) + 16;
            if(val_32 == 1)
            {
                goto label_27;
            }
            
            if((ctx + 20 + 20 + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_27 = ctx + 20 + 20 + 8;
                val_27 = val_27 + (val_14 << 2);
                val_32 = mem[(ctx + 20 + 20 + 8 + (val_14) << 2) + 16];
                val_32 = (ctx + 20 + 20 + 8 + (val_14) << 2) + 16;
            }
            
            if(val_32 != 1)
            {
                goto label_32;
            }
            
            goto label_30;
            label_27:
            bool val_16 = val_25.PointInPolygonAngle(point:  val_29, polygon:  val_28);
            ctx + 20 + 20.set_Item(index:  val_14, value:  val_16);
            if(val_16 == false)
            {
                goto label_32;
            }
            
            label_30:
            val_33 = ctx + 20;
            if(val_28 == val_33)
            {
                goto label_34;
            }
            
            val_34 = val_33;
            val_29 = mem[ctx + 20 + 4];
            val_29 = ctx + 20 + 4;
            val_35 = ctx + 20 + 20;
            goto label_35;
            label_16:
            val_31 = val_30;
            val_33 = ctx + 20;
            goto label_36;
            label_34:
            val_29 = val_28;
            val_34 = ctx + 20 + 4;
            if(0 <= 1)
            {
                    0 = val_31;
            }
            
            val_35 = ctx.mPoly2VectorAngles;
            label_35:
            val_28 = mem[ctx + 20 + 4];
            val_28 = val_34;
            label_36:
            Dispose();
            if(1 != 0)
            {
                    if((1152921510213799972 + ((1 - 1)) << 2) == 426)
            {
                    val_36 = 1 - 1;
            }
            
            }
            else
            {
                    val_36 = 0;
            }
            
            int val_18 = val_28.NextIndex(index:  val_31);
            val_25 = val_25;
            val_27 = val_27;
            if(val_28 == val_33)
            {
                goto label_41;
            }
            
            if(0 < 0)
            {
                goto label_42;
            }
            
            val_37 = 0;
            goto label_43;
            label_41:
            val_37 = val_30;
            label_43:
            if(val_18 == val_37)
            {
                goto label_51;
            }
            
            label_42:
            FerrPoly2Tri.Point2D val_19 = val_28.Item[val_18];
            if(val_28 == (ctx + 20))
            {
                goto label_51;
            }
            
            int val_22 = ctx + 20 + 4.Count;
            val_22 = val_22 + (ctx + 20.Count);
            if(val_27.Count <= val_22)
            {
                goto label_50;
            }
            
            label_51:
            int val_25 = ctx + 20 + 4.Count;
            val_25 = val_25 + (ctx + 20.Count);
            if(val_27.Count > val_25)
            {
                    val_25 = 3;
                ctx.mError = val_25;
            }
            
            return;
            label_3:
            if(ctx.mError == 3)
            {
                    return;
            }
            
            if(ctx.mError != 2)
            {
                goto label_79;
            }
            
            if(val_27 != 0)
            {
                    return;
            }
        
        }
        public static FerrPoly2Tri.PolygonUtil.PolyUnionError PolygonSubtract(FerrPoly2Tri.Point2DList polygon1, FerrPoly2Tri.Point2DList polygon2, out FerrPoly2Tri.Point2DList subtract)
        {
            FerrPoly2Tri.PolygonOperationContext val_1 = 536891965;
            val_1 = new FerrPoly2Tri.PolygonOperationContext();
            if(val_1 != 0)
            {
                    bool val_2 = val_1.Init(operations:  4, polygon1:  polygon1, polygon2:  polygon2);
                FerrPoly2Tri.PolygonUtil.PolygonSubtractInternal(ctx:  536891965);
            }
            else
            {
                    bool val_3 = val_1.Init(operations:  4, polygon1:  polygon1, polygon2:  polygon2);
                FerrPoly2Tri.PolygonUtil.PolygonSubtractInternal(ctx:  536891965);
            }
            
            FerrPoly2Tri.Point2DList val_4 = val_1.Subtract;
            subtract = val_1;
            if(val_1 != 0)
            {
                    return;
            }
        
        }
        public static void PolygonSubtractInternal(FerrPoly2Tri.PolygonOperationContext ctx)
        {
            FerrPoly2Tri.PolygonOperationContext val_26;
            var val_27;
            int val_28;
            FerrPoly2Tri.Point2DList val_29;
            var val_30;
            FerrPoly2Tri.Point2D val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_40;
            val_26 = ctx;
            if(val_26 != 0)
            {
                    FerrPoly2Tri.Point2DList val_1 = val_26.Subtract;
                val_27 = val_26;
            }
            else
            {
                    FerrPoly2Tri.Point2DList val_2 = 0.Subtract;
                val_27 = 0;
            }
            
            val_28 = ctx.mStartingIndex;
            if(val_28 == 1)
            {
                    PolygonUtil.PolyUnionError val_26 = ctx.mError;
                val_26 = val_26 - 1;
                if(val_26 < 3)
            {
                    return;
            }
            
            }
            
            val_29 = ctx.mPoly1;
            val_30 = mem[ctx + 20 + 20];
            val_30 = ctx + 20 + 20;
            val_31 = mem[ctx + 20 + 4];
            val_31 = ctx + 20 + 4;
            FerrPoly2Tri.Point2D val_3 = val_29.Item[val_28];
            val_27.Clear();
            label_55:
            FerrPoly2Tri.Point2D val_4 = val_29.Item[ctx.mStartingIndex];
            List.Enumerator<T> val_5 = GetEnumerator();
            label_38:
            if(MoveNext() == false)
            {
                goto label_10;
            }
            
            FerrPoly2Tri.Point2D val_8 = val_29.Item[ctx.mStartingIndex];
            if((val_29.Equals(p:  val_7 + 16, epsilon:  null)) == false)
            {
                goto label_38;
            }
            
            val_28 = val_31.IndexOf(p:  val_7 + 16);
            if((1 & 1) != 0)
            {
                goto label_17;
            }
            
            int val_11 = val_31.PreviousIndex(index:  val_28);
            FerrPoly2Tri.Point2D val_12 = val_31.Item[val_11];
            if((ctx + 20 + 20 + 12) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_27 = ctx + 20 + 20 + 8;
            val_27 = val_27 + (val_11 << 2);
            val_32 = mem[(ctx + 20 + 20 + 8 + (val_11) << 2) + 16];
            val_32 = (ctx + 20 + 20 + 8 + (val_11) << 2) + 16;
            if(val_32 == 1)
            {
                goto label_22;
            }
            
            if((ctx + 20 + 20 + 12) <= val_11)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_28 = ctx + 20 + 20 + 8;
                val_28 = val_28 + (val_11 << 2);
                val_32 = mem[(ctx + 20 + 20 + 8 + (val_11) << 2) + 16];
                val_32 = (ctx + 20 + 20 + 8 + (val_11) << 2) + 16;
            }
            
            if(val_32 != 1)
            {
                goto label_38;
            }
            
            goto label_36;
            label_17:
            int val_13 = val_31.NextIndex(index:  val_28);
            FerrPoly2Tri.Point2D val_14 = val_31.Item[val_13];
            if((ctx + 20 + 20 + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_29 = ctx + 20 + 20 + 8;
            val_29 = val_29 + (val_13 << 2);
            val_33 = mem[(ctx + 20 + 20 + 8 + (val_13) << 2) + 16];
            val_33 = (ctx + 20 + 20 + 8 + (val_13) << 2) + 16;
            if(val_33 == 1)
            {
                goto label_30;
            }
            
            if((ctx + 20 + 20 + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_30 = ctx + 20 + 20 + 8;
                val_30 = val_30 + (val_13 << 2);
                val_33 = mem[(ctx + 20 + 20 + 8 + (val_13) << 2) + 16];
                val_33 = (ctx + 20 + 20 + 8 + (val_13) << 2) + 16;
            }
            
            if(val_33 == 1)
            {
                goto label_38;
            }
            
            goto label_33;
            label_22:
            bool val_15 = val_26.PointInPolygonAngle(point:  val_31, polygon:  val_29);
            val_30.set_Item(index:  val_11, value:  val_15);
            if(val_15 == false)
            {
                goto label_38;
            }
            
            goto label_36;
            label_30:
            bool val_16 = val_26.PointInPolygonAngle(point:  val_31, polygon:  val_29);
            val_30.set_Item(index:  val_13, value:  val_16);
            if(val_16 == true)
            {
                goto label_38;
            }
            
            label_33:
            val_34 = ctx + 20 + 4;
            if(val_29 != (ctx + 20))
            {
                    ctx.mPoly2VectorAngles = ctx + 20 + 20;
                val_35 = ctx + 20;
                val_36 = mem[ctx + 20 + 4];
                val_36 = val_34;
            }
            
            val_30 = mem[ctx + 20 + 20];
            val_30 = ctx.mPoly2VectorAngles;
            val_37 = 1;
            goto label_40;
            label_10:
            val_28 = ctx.mStartingIndex;
            val_34 = ctx + 20 + 4;
            goto label_41;
            label_36:
            val_34 = ctx + 20 + 4;
            if(val_29 != (ctx + 20))
            {
                    ctx.mPoly2VectorAngles = ctx + 20 + 20;
                val_35 = ctx + 20;
                val_36 = mem[ctx + 20 + 4];
                val_36 = val_34;
            }
            
            val_30 = mem[ctx + 20 + 20];
            val_30 = ctx.mPoly2VectorAngles;
            val_37 = 0;
            label_40:
            val_31 = val_36;
            val_29 = val_35;
            label_41:
            Dispose();
            if(1 == 0)
            {
                goto label_43;
            }
            
            val_38 = 1 - 1;
            if((1152921510214081192 + ((1 - 1)) << 2) != 517)
            {
                goto label_44;
            }
            
            goto label_45;
            label_43:
            val_38 = 0;
            label_45:
            label_44:
            if((val_37 & 1) == 0)
            {
                    int val_17 = val_29.NextIndex(index:  val_28);
            }
            
            val_40 = val_27;
            FerrPoly2Tri.Point2D val_19 = val_29.Item[val_29.PreviousIndex(index:  val_28)];
            if(val_29 == val_29)
            {
                goto label_56;
            }
            
            val_28 = val_40.Count;
            int val_22 = val_34.Count;
            val_22 = val_22 + (ctx + 20.Count);
            val_40 = val_27;
            if(val_28 <= val_22)
            {
                goto label_55;
            }
            
            label_56:
            val_26 = mem[ctx + 20 + 4];
            val_26 = val_34;
            int val_25 = val_26.Count;
            val_25 = val_25 + (ctx + 20.Count);
            if(val_40.Count > val_25)
            {
                    val_25 = 3;
                mem2[0] = val_25;
            }
        
        }
        public static FerrPoly2Tri.PolygonUtil.PolyUnionError PolygonOperation(FerrPoly2Tri.PolygonUtil.PolyOperation operations, FerrPoly2Tri.Point2DList polygon1, FerrPoly2Tri.Point2DList polygon2, out System.Collections.Generic.Dictionary<uint, FerrPoly2Tri.Point2DList> results)
        {
            FerrPoly2Tri.PolygonOperationContext val_1 = 536891965;
            val_1 = new FerrPoly2Tri.PolygonOperationContext();
            if(val_1 != 0)
            {
                    bool val_2 = val_1.Init(operations:  operations, polygon1:  polygon1, polygon2:  polygon2);
            }
            else
            {
                    bool val_3 = val_1.Init(operations:  operations, polygon1:  polygon1, polygon2:  polygon2);
            }
            
            results = mem[536892013];
            return FerrPoly2Tri.PolygonUtil.PolygonOperation(ctx:  536891965);
        }
        public static FerrPoly2Tri.PolygonUtil.PolyUnionError PolygonOperation(FerrPoly2Tri.PolygonOperationContext ctx)
        {
            PolygonUtil.PolyOperation val_1 = ctx.mOperations;
            if((val_1 & 1) == 0)
            {
                    FerrPoly2Tri.PolygonUtil.PolygonUnionInternal(ctx:  ctx);
                val_1 = ctx.mOperations;
            }
            
            if((val_1 & 2) != 0)
            {
                    return;
            }
            
            FerrPoly2Tri.PolygonUtil.PolygonIntersectInternal(ctx:  ctx);
            val_1 = ctx.mOperations;
        }
        public static System.Collections.Generic.List<FerrPoly2Tri.Point2DList> SplitComplexPolygon(FerrPoly2Tri.Point2DList verts, double epsilon)
        {
            FerrPoly2Tri.Point2DList val_53;
            System.Collections.Generic.List<Page> val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            float val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            FerrPoly2Tri.Point2D val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            FerrPoly2Tri.SplitComplexPolygonNode val_72;
            var val_73;
            FerrPoly2Tri.SplitComplexPolygonNode val_74;
            var val_75;
            var val_76;
            int val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_83;
            val_53 = verts;
            float val_71 = ???;
            int val_1 = val_53.Count;
            val_54 = 536878327;
            val_54 = new System.Collections.Generic.List<Page>();
            val_55 = 0;
            goto label_2;
            label_9:
            FerrPoly2Tri.Point2D val_3 = val_53.Item[0];
            FerrPoly2Tri.Point2D val_4 = val_53.Item[0];
            val_56 = typeof(FerrPoly2Tri.Point2DList).__il2cppRuntimeField_E8;
            536891877 = new FerrPoly2Tri.Point2D(x:  epsilon, y:  null);
            536894289 = new FerrPoly2Tri.SplitComplexPolygonNode(pos:  536891877);
            val_54 = val_54;
            val_54.Add(item:  536894289);
            val_53 = val_53;
            val_55 = 1;
            label_2:
            if(val_55 < val_53.Count)
            {
                goto label_9;
            }
            
            var val_8 = val_54 + 12;
            val_57 = val_54 + 8;
            val_58 = 4;
            val_59 = 4.01482E-38f;
            goto label_10;
            label_19:
            FerrPoly2Tri.Point2DList val_9 = val_53 - 1;
            FerrPoly2Tri.Point2DList val_10 = val_53 + 1;
            if(val_10 == 1)
            {
                    val_9 = 536878326;
            }
            
            if(val_10 != 1)
            {
                    val_53 - 536878326 = val_10;
            }
            
            val_9 = val_9 + 1;
            val_60 = mem[(val_54 + 12)];
            val_60 = val_8;
            if(val_60 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_60 = mem[(val_54 + 12)];
                val_60 = val_8;
            }
            
            val_61 = mem[(val_54 + 8)];
            val_61 = val_57;
            if(val_60 <= (val_53 - 536878326))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_52 = val_57;
                val_61 = mem[(val_54 + 8)];
                val_61 = val_52;
            }
            
            val_52 = val_61 + ((val_53 - 536878326) << 2);
            (val_54 + 8) + 16.AddConnection(toMe:  ((val_54 + 8) + ((verts + 1)) << 2) + 16);
            val_62 = mem[(val_54 + 12)];
            val_62 = val_8;
            if(val_62 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_62 = mem[(val_54 + 12)];
                val_62 = val_8;
            }
            
            val_63 = mem[(val_54 + 8)];
            val_63 = val_57;
            if(val_62 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_53 = val_57;
                val_63 = mem[(val_54 + 8)];
                val_63 = val_53;
            }
            
            val_53 = val_63 + 2147513304;
            (val_54 + 8) + 16.AddConnection(toMe:  ((val_54 + 8) + 2147513304) + 16);
            val_57 = val_57;
            val_58 = 5;
            label_10:
            if((val_58 - 4) < val_53.Count)
            {
                goto label_19;
            }
            
            val_64 = val_54;
            val_65 = val_8;
            label_89:
            if(val_65 < 1)
            {
                goto label_21;
            }
            
            var val_65 = 0;
            label_60:
            val_66 = 0;
            goto label_22;
            label_59:
            if(val_65 < 1)
            {
                goto label_23;
            }
            
            var val_63 = 0;
            label_55:
            if(val_63 == val_65)
            {
                goto label_33;
            }
            
            val_67 = mem[(val_54 + 12)];
            val_67 = val_8;
            if(val_67 <= val_63)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_67 = mem[(val_54 + 12)];
                val_67 = val_8;
            }
            
            val_68 = mem[(val_54 + 8)];
            val_68 = val_57;
            var val_14 = val_68 + 0;
            if(val_67 <= val_65)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_68 = mem[(val_54 + 8)];
                val_68 = val_57;
            }
            
            var val_15 = val_68 + 0;
            FerrPoly2Tri.SplitComplexPolygonNode val_16 = ((val_54 + 8) + 0) + 16.Item[0];
            if((FerrPoly2Tri.SplitComplexPolygonNode.op_Equality(lhs:  ((val_54 + 8) + 0) + 16, rhs:  ((val_54 + 8) + 0) + 16)) == true)
            {
                goto label_33;
            }
            
            val_69 = 0;
            goto label_30;
            label_53:
            val_69 = 1;
            label_30:
            if(val_8 <= val_63)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_54 = val_57;
            val_54 = val_54 + 0;
            if(val_69 >= (((val_54 + 8) + 0) + 16.NumConnected))
            {
                goto label_33;
            }
            
            if(val_8 <= val_63)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_55 = val_57;
            val_55 = val_55 + 0;
            FerrPoly2Tri.SplitComplexPolygonNode val_19 = ((val_54 + 8) + 0) + 16.Item[1];
            if(val_8 <= val_65)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_56 = val_57;
            val_56 = val_56 + 0;
            FerrPoly2Tri.SplitComplexPolygonNode val_20 = ((val_54 + 8) + 0) + 16.Item[0];
            if((FerrPoly2Tri.SplitComplexPolygonNode.op_Equality(lhs:  ((val_54 + 8) + 0) + 16, rhs:  ((val_54 + 8) + 0) + 16)) == true)
            {
                goto label_53;
            }
            
            if(val_8 <= val_63)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_57 = val_57;
            val_57 = val_57 + 0;
            FerrPoly2Tri.SplitComplexPolygonNode val_22 = ((val_54 + 8) + 0) + 16.Item[1];
            if(val_8 <= val_65)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_58 = val_57;
            val_58 = val_58 + 0;
            if((FerrPoly2Tri.SplitComplexPolygonNode.op_Equality(lhs:  ((val_54 + 8) + 0) + 16, rhs:  ((val_54 + 8) + 0) + 16)) == true)
            {
                goto label_53;
            }
            
            FerrPoly2Tri.Point2D val_24 = 536891877;
            val_24 = new FerrPoly2Tri.Point2D();
            if(val_8 <= val_65)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_59 = val_57;
            val_59 = val_59 + 0;
            if(val_8 <= val_65)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_60 = val_57;
            val_60 = val_60 + 0;
            FerrPoly2Tri.SplitComplexPolygonNode val_25 = ((val_54 + 8) + 0) + 16.Item[536891877];
            if(val_8 <= val_63)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_61 = val_57;
            val_61 = val_61 + 0;
            if(val_8 <= val_63)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_62 = val_57;
            val_62 = val_62 + 0;
            FerrPoly2Tri.SplitComplexPolygonNode val_26 = ((val_54 + 8) + 0) + 16.Item[1];
            if((FerrPoly2Tri.TriangulationUtil.LinesIntersect2D(ptStart0:  ((val_54 + 8) + 0) + 16 + 12, ptEnd0:  ((val_54 + 8) + 0) + 16 + 12, ptStart1:  ((val_54 + 8) + 0) + 16 + 12, ptEnd1:  ((val_54 + 8) + 0) + 16 + 12, firstIsSegment:  true, secondIsSegment:  true, coincidentEndPointCollisions:  true, pIntersectionPt: ref  val_24, epsilon:  epsilon)) == false)
            {
                goto label_53;
            }
            
            goto label_54;
            label_33:
            val_63 = val_63 + 1;
            if(val_63 < val_65)
            {
                goto label_55;
            }
            
            label_23:
            val_66 = val_24 + 1;
            label_22:
            if(val_8 <= val_65)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_64 = val_57;
            val_64 = val_64 + 0;
            if(val_66 < (((val_54 + 8) + 0) + 16.NumConnected))
            {
                goto label_59;
            }
            
            val_65 = val_65 + 1;
            if(val_65 < val_65)
            {
                goto label_60;
            }
            
            val_64 = val_65;
            val_70 = 1;
            val_65 = val_8;
            goto label_61;
            label_54:
            536894289 = new FerrPoly2Tri.SplitComplexPolygonNode(pos:  val_66);
            int val_31 = val_65.IndexOf(item:  536894289);
            if(val_31 < 0)
            {
                goto label_63;
            }
            
            val_71 = mem[(val_54 + 12)];
            val_71 = val_8;
            if(val_31 >= val_71)
            {
                goto label_63;
            }
            
            if(val_71 <= val_31)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_71 = mem[(val_54 + 12)];
                val_71 = val_8;
            }
            
            var val_66 = val_57;
            val_66 = val_66 + (val_31 << 2);
            goto label_65;
            label_63:
            val_65.Add(item:  ((val_54 + 8) + (val_31) << 2) + 16);
            val_71 = mem[(val_54 + 12) + 12];
            val_71 = (val_54 + 12) + 12;
            label_65:
            if(val_71 <= val_65)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_71 = mem[(val_54 + 12)];
                val_71 = val_8;
            }
            
            var val_67 = val_57;
            val_67 = val_67 + 0;
            val_72 = ((val_54 + 8) + 0) + 16;
            if(val_71 <= val_65)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_68 = val_57;
                val_68 = val_68 + 0;
                val_72 = mem[((val_54 + 8) + 0) + 16];
                val_72 = ((val_54 + 8) + 0) + 16;
            }
            
            FerrPoly2Tri.SplitComplexPolygonNode val_32 = val_72.Item[val_66];
            val_73 = mem[(val_54 + 12)];
            val_73 = val_8;
            if(val_73 <= val_63)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_73 = mem[(val_54 + 12)];
                val_73 = val_8;
            }
            
            var val_69 = val_57;
            val_69 = val_69 + 0;
            val_74 = ((val_54 + 8) + 0) + 16;
            if(val_73 <= val_63)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_70 = val_57;
                val_70 = val_70 + 0;
                val_74 = mem[((val_54 + 8) + 0) + 16];
                val_74 = ((val_54 + 8) + 0) + 16;
            }
            
            FerrPoly2Tri.SplitComplexPolygonNode val_33 = val_74.Item[1];
            val_72.RemoveConnection(fromMe:  ((val_54 + 8) + 0) + 16);
            ((val_54 + 8) + 0) + 16.RemoveConnection(fromMe:  val_72);
            val_74.RemoveConnection(fromMe:  ((val_54 + 8) + 0) + 16);
            ((val_54 + 8) + 0) + 16.RemoveConnection(fromMe:  val_74);
            if((((val_54 + 8) + (val_31) << 2) + 16 + 12.Equals(p:  ((val_54 + 8) + 0) + 16 + 12, epsilon:  epsilon)) != true)
            {
                    ((val_54 + 8) + (val_31) << 2) + 16.AddConnection(toMe:  ((val_54 + 8) + 0) + 16);
                ((val_54 + 8) + 0) + 16.AddConnection(toMe:  ((val_54 + 8) + (val_31) << 2) + 16);
            }
            
            if((((val_54 + 8) + (val_31) << 2) + 16 + 12.Equals(p:  ((val_54 + 8) + 0) + 16 + 12, epsilon:  epsilon)) != true)
            {
                    ((val_54 + 8) + (val_31) << 2) + 16.AddConnection(toMe:  ((val_54 + 8) + 0) + 16);
                ((val_54 + 8) + 0) + 16.AddConnection(toMe:  ((val_54 + 8) + (val_31) << 2) + 16);
            }
            
            val_64 = val_71;
            val_65 = val_8;
            if((((val_54 + 8) + (val_31) << 2) + 16 + 12.Equals(p:  ((val_54 + 8) + 0) + 16 + 12, epsilon:  epsilon)) != true)
            {
                    ((val_54 + 8) + (val_31) << 2) + 16.AddConnection(toMe:  val_72);
                val_72.AddConnection(toMe:  ((val_54 + 8) + (val_31) << 2) + 16);
            }
            
            val_70 = 0;
            val_56 = ???;
            if((((val_54 + 8) + (val_31) << 2) + 16 + 12.Equals(p:  ((val_54 + 8) + 0) + 16 + 12, epsilon:  epsilon)) != true)
            {
                    val_70 = 0;
                ((val_54 + 8) + (val_31) << 2) + 16.AddConnection(toMe:  val_74);
                val_74.AddConnection(toMe:  ((val_54 + 8) + (val_31) << 2) + 16);
            }
            
            val_57 = val_57;
            label_61:
            if(val_70 == 0)
            {
                goto label_89;
            }
            
            label_21:
            val_71 = val_71 * val_71;
            label_120:
            val_75 = 0;
            if(val_71 < 1)
            {
                goto label_152;
            }
            
            val_76 = 0;
            label_119:
            if(val_65 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_72 = val_57;
            val_72 = val_72 + 0;
            val_77 = 0 + 1;
            if((((val_54 + 8) + 0) + 16.NumConnected) != 0)
            {
                goto label_94;
            }
            
            goto label_95;
            label_118:
            if(val_65 <= val_77)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_73 = val_57;
            val_73 = val_73 + (val_77 << 2);
            if((((val_54 + 8) + ((0 + 1)) << 2) + 16.NumConnected) == 0)
            {
                goto label_105;
            }
            
            if(val_65 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_74 = val_57;
            val_74 = val_74 + 0;
            if(val_65 <= val_77)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_75 = val_57;
            val_75 = val_75 + (val_77 << 2);
            FerrPoly2Tri.Point2D val_40 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  ((val_54 + 8) + 0) + 16 + 12, rhs:  ((val_54 + 8) + ((0 + 1)) << 2) + 16 + 12);
            val_57 = val_57;
            if((((val_54 + 8) + 0) + 16 + 12) > 0)
            {
                goto label_105;
            }
            
            var val_77 = val_71;
            if(val_77 <= 3)
            {
                goto label_106;
            }
            
            val_78 = mem[(val_54 + 12)];
            val_78 = val_65;
            if(val_78 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_78 = mem[(val_54 + 12)];
                val_78 = val_65;
            }
            
            val_79 = mem[(val_54 + 8)];
            val_79 = val_57;
            var val_42 = val_79 + 0;
            if(val_78 <= val_77)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_76 = val_57;
                val_79 = mem[(val_54 + 8)];
                val_79 = val_76;
            }
            
            val_76 = val_79 + (val_77 << 2);
            val_77 = val_77 - 1;
            val_80 = 0;
            val_81 = ((val_54 + 8) + ((0 + 1)) << 2) + 16.NumConnected;
            goto label_110;
            label_116:
            FerrPoly2Tri.SplitComplexPolygonNode val_44 = ((val_54 + 8) + ((0 + 1)) << 2) + 16.Item[0];
            if((FerrPoly2Tri.SplitComplexPolygonNode.op_Inequality(lhs:  ((val_54 + 8) + ((0 + 1)) << 2) + 16, rhs:  ((val_54 + 8) + 0) + 16)) != false)
            {
                    ((val_54 + 8) + 0) + 16.AddConnection(toMe:  ((val_54 + 8) + ((0 + 1)) << 2) + 16);
                ((val_54 + 8) + ((0 + 1)) << 2) + 16.AddConnection(toMe:  ((val_54 + 8) + 0) + 16);
            }
            
            ((val_54 + 8) + ((0 + 1)) << 2) + 16.RemoveConnection(fromMe:  ((val_54 + 8) + ((0 + 1)) << 2) + 16);
            val_80 = 1;
            label_110:
            if(val_80 < val_81)
            {
                goto label_116;
            }
            
            ((val_54 + 8) + ((0 + 1)) << 2) + 16.ClearConnections();
            val_64 = val_71;
            val_64.RemoveAt(index:  val_77);
            val_57 = val_57;
            val_76 = 1;
            val_65 = val_8;
            var val_78 = val_71;
            val_78 = val_78 - 1;
            label_105:
            val_77 = val_77 + 1;
            label_94:
            if(val_77 < val_78)
            {
                goto label_118;
            }
            
            label_95:
            if(val_77 < val_78)
            {
                goto label_119;
            }
            
            val_59 = 4.01482E-38f;
            if(val_76 != 1)
            {
                goto label_120;
            }
            
            if(val_78 < 1)
            {
                goto label_121;
            }
            
            val_83 = 0;
            val_75 = 0;
            label_151:
            if(val_65 <= val_83)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_79 = val_57;
            val_79 = val_79 + 0;
            if((((val_54 + 8) + 0) + 16 + 12) >= 0)
            {
                goto label_126;
            }
            
            if(val_65 <= val_83)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_80 = val_57;
            val_80 = val_80 + 0;
            if((((val_54 + 8) + 0) + 16.NumConnected) >= 2)
            {
                goto label_129;
            }
            
            label_126:
            if(val_65 <= val_83)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_81 = val_57;
            val_81 = val_81 + 0;
            if((((val_54 + 8) + 0) + 16 + 12) != 0)
            {
                goto label_144;
            }
            
            if(val_65 <= val_83)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_82 = val_57;
            val_82 = val_82 + 0;
            if((((val_54 + 8) + 0) + 16 + 12) <= 0)
            {
                goto label_144;
            }
            
            if(val_65 <= val_83)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_83 = val_57;
            val_83 = val_83 + 0;
            if((((val_54 + 8) + 0) + 16.NumConnected) < 2)
            {
                goto label_144;
            }
            
            if(val_65 <= val_83)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_84 = val_57;
            val_84 = val_84 + 0;
            val_75 = val_83;
            goto label_144;
            label_129:
            if(val_65 <= val_83)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_85 = val_57;
            val_85 = val_85 + 0;
            if(val_65 <= val_83)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_86 = val_57;
            val_86 = val_86 + 0;
            val_75 = val_83;
            label_144:
            val_83 = val_83 + 1;
            if(val_78 != val_83)
            {
                goto label_151;
            }
            
            goto label_152;
            label_121:
            val_75 = 0;
            label_152:
            val_59 = new FerrPoly2Tri.Point2D(x:  ((val_54 + 8) + 0) + 16 + 12.MagnitudeSquared(), y:  null);
            536878157 = new System.Collections.Generic.List<Page>();
            if(val_65 <= val_75)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_87 = val_57;
            val_87 = val_87 + 0;
            FerrPoly2Tri.SplitComplexPolygonNode val_50 = ((val_54 + 8) + 0) + 16.GetRightestConnection(incomingDir:  536891877);
            if((FerrPoly2Tri.SplitComplexPolygonNode.op_Equality(lhs:  ((val_54 + 8) + 0) + 16, rhs:  0)) != false)
            {
                
            }
        
        }
        private static System.Collections.Generic.List<FerrPoly2Tri.Point2DList> SplitComplexPolygonCleanup(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> orig)
        {
            float val_9;
            var val_10;
            int val_11;
            var val_12;
            float val_13;
            var val_14;
            var val_15;
            536878161 = new System.Collections.Generic.List<Page>();
            FerrPoly2Tri.Point2DList val_2 = 536891885;
            val_9 = val_2;
            val_2 = new FerrPoly2Tri.Point2DList(l:  orig);
            if(536878161 != 0)
            {
                    536878161.Add(item:  536891885);
            }
            else
            {
                    536878161.Add(item:  536891885);
            }
            
            val_10 = mem[536878173];
            if(val_10 < 1)
            {
                    return;
            }
            
            var val_16 = 0;
            goto label_4;
            label_28:
            val_10 = mem[536878173];
            label_4:
            if(val_10 <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = mem[536878169];
            val_10 = val_10 + 0;
            int val_3 = (mem[536878169] + 0) + 16.Count;
            if(val_3 < 1)
            {
                goto label_7;
            }
            
            val_11 = val_3;
            label_24:
            val_12 = 1;
            if(val_12 >= val_11)
            {
                goto label_8;
            }
            
            label_23:
            if(mem[536878173] <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_11 = mem[536878169];
            val_11 = val_11 + 0;
            FerrPoly2Tri.Point2D val_4 = (mem[536878169] + 0) + 16.Item[0];
            if(mem[536878173] <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = mem[536878169];
            val_12 = val_12 + 0;
            FerrPoly2Tri.Point2D val_5 = (mem[536878169] + 0) + 16.Item[1];
            if(((mem[536878169] + 0) + 16.Equals(p:  (mem[536878169] + 0) + 16, epsilon:  null)) == false)
            {
                goto label_16;
            }
            
            536891885 = new FerrPoly2Tri.Point2DList();
            val_13 = val_12;
            goto label_17;
            label_21:
            FerrPoly2Tri.Point2D val_8 = (mem[536878169] + 0) + 16.Item[1];
            val_13 = 2;
            label_17:
            if(mem[536878173] <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = mem[536878169];
            val_13 = val_13 + 0;
            if(val_13 <= val_12)
            {
                goto label_21;
            }
            
            val_14 = val_12;
            536878161.Add(item:  536891885);
            var val_14 = val_10;
            val_11 = val_11 - (val_12 - 0);
            val_9 = 1.086913E-19f;
            val_14 = val_14 + 1;
            goto label_22;
            label_16:
            val_11 = val_11;
            label_22:
            val_15 = val_12 + 1;
            if(val_15 < val_11)
            {
                goto label_23;
            }
            
            label_8:
            if(1 < val_11)
            {
                goto label_24;
            }
            
            label_7:
            if(mem[536878173] <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_15 = mem[536878169];
            val_15 = val_15 + 0;
            (mem[536878169] + 0) + 16.Simplify();
            val_16 = val_16 + 1;
            if(val_16 < val_14)
            {
                goto label_28;
            }
        
        }
        public PolygonUtil()
        {
        
        }
    
    }

}
