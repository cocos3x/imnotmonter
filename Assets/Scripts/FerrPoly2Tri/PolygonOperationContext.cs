using UnityEngine;

namespace FerrPoly2Tri
{
    public class PolygonOperationContext
    {
        // Fields
        public FerrPoly2Tri.PolygonUtil.PolyOperation mOperations;
        public FerrPoly2Tri.Point2DList mOriginalPolygon1;
        public FerrPoly2Tri.Point2DList mOriginalPolygon2;
        public FerrPoly2Tri.Point2DList mPoly1;
        public FerrPoly2Tri.Point2DList mPoly2;
        public System.Collections.Generic.List<FerrPoly2Tri.EdgeIntersectInfo> mIntersections;
        public int mStartingIndex;
        public FerrPoly2Tri.PolygonUtil.PolyUnionError mError;
        public System.Collections.Generic.List<int> mPoly1VectorAngles;
        public System.Collections.Generic.List<int> mPoly2VectorAngles;
        public System.Collections.Generic.Dictionary<uint, FerrPoly2Tri.Point2DList> mOutput;
        
        // Properties
        public FerrPoly2Tri.Point2DList Union { get; }
        public FerrPoly2Tri.Point2DList Intersect { get; }
        public FerrPoly2Tri.Point2DList Subtract { get; }
        
        // Methods
        public FerrPoly2Tri.Point2DList get_Union()
        {
            if((this.mOutput.TryGetValue(key:  1, value: out  FerrPoly2Tri.Point2DList val_1 = 1316595036)) == true)
            {
                    return;
            }
            
            536891885 = new FerrPoly2Tri.Point2DList();
            this.mOutput.Add(key:  1, value:  536891885);
        }
        public FerrPoly2Tri.Point2DList get_Intersect()
        {
            if((this.mOutput.TryGetValue(key:  2, value: out  FerrPoly2Tri.Point2DList val_1 = 1316723420)) == true)
            {
                    return;
            }
            
            536891885 = new FerrPoly2Tri.Point2DList();
            this.mOutput.Add(key:  2, value:  536891885);
        }
        public FerrPoly2Tri.Point2DList get_Subtract()
        {
            if((this.mOutput.TryGetValue(key:  4, value: out  FerrPoly2Tri.Point2DList val_1 = 1316851804)) == true)
            {
                    return;
            }
            
            536891885 = new FerrPoly2Tri.Point2DList();
            this.mOutput.Add(key:  4, value:  536891885);
        }
        public PolygonOperationContext()
        {
            536874497 = new System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationPoint>();
            this.mOutput = 536874497;
        }
        public void Clear()
        {
            this.mOperations = 0;
            this.mOriginalPolygon1 = 0;
            this.mOriginalPolygon2 = 0;
            this.mPoly1 = 0;
            this.mPoly2 = 0;
            this.mIntersections = 0;
            this.mStartingIndex = 0;
            this.mError = 0;
            this.mPoly1VectorAngles = 0;
            this.mPoly2VectorAngles = 0;
            536874497 = new System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationPoint>();
            mem[1152921510218910336] = 536874497;
        }
        public bool Init(FerrPoly2Tri.PolygonUtil.PolyOperation operations, FerrPoly2Tri.Point2DList polygon1, FerrPoly2Tri.Point2DList polygon2)
        {
            FerrPoly2Tri.PolygonOperationContext val_24;
            var val_25;
            var val_26;
            var val_27;
            System.Collections.Generic.List<FerrPoly2Tri.EdgeIntersectInfo> val_28;
            var val_29;
            var val_30;
            var val_31;
            val_24 = this;
            this.Clear();
            this.mOperations = operations;
            this.mOriginalPolygon1 = polygon1;
            this.mOriginalPolygon2 = polygon2;
            val_25 = 22713972;
            FerrPoly2Tri.Point2DList val_1 = 536891885;
            val_1 = new FerrPoly2Tri.Point2DList(l:  polygon1);
            mem[1152921510219042788] = val_1;
            val_26 = 1;
            mem[1152921510219042788].WindingOrder = 1;
            FerrPoly2Tri.Point2DList val_2 = 536891885;
            val_2 = new FerrPoly2Tri.Point2DList(l:  polygon2);
            val_27 = val_24;
            this.mPoly2 = val_2;
            this.mPoly2.WindingOrder = 1;
            val_28 = this.mIntersections;
            if((this.VerticesIntersect(polygon1:  this.mPoly1, polygon2:  this.mPoly2, intersections: out  val_28)) == false)
            {
                goto label_3;
            }
            
            if((mem[this.mIntersections.SyncRoot + 12]) >= 1)
            {
                    do
            {
                if(1 < (mem[this.mIntersections.SyncRoot + 12]))
            {
                    var val_25 = 0;
                do
            {
                if((mem[this.mIntersections.SyncRoot + 12]) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_24 = mem[this.mIntersections.SyncRoot + 8];
                val_24 = val_24 + 0;
                val_25 = val_25 + 1;
                if((mem[this.mIntersections.SyncRoot + 12]) <= val_25)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_26 = mem[this.mIntersections.SyncRoot + 8];
                val_26 = val_26 + 0;
                if(((mem[this.mIntersections.SyncRoot + 8] + 0) + 16 + 8 + 8.Equals(p:  (mem[this.mIntersections.SyncRoot + 8] + 0) + 20 + 8 + 8)) != false)
            {
                    if((mem[this.mIntersections.SyncRoot + 12]) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_27 = mem[this.mIntersections.SyncRoot + 8];
                val_27 = val_27 + 0;
                if((mem[this.mIntersections.SyncRoot + 12]) <= val_25)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_28 = mem[this.mIntersections.SyncRoot + 8];
                val_28 = val_28 + 0;
                if(((mem[this.mIntersections.SyncRoot + 8] + 0) + 16 + 8 + 12.Equals(p:  (mem[this.mIntersections.SyncRoot + 8] + 0) + 20 + 8 + 12)) != false)
            {
                    if((mem[this.mIntersections.SyncRoot + 12]) <= val_25)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_29 = mem[this.mIntersections.SyncRoot + 8];
                val_29 = val_29 + 0;
                if((mem[this.mIntersections.SyncRoot + 12]) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_30 = mem[this.mIntersections.SyncRoot + 8];
                val_30 = val_30 + 0;
                mem2[0] = (mem[this.mIntersections.SyncRoot + 8] + 0) + 16 + 16;
            }
            
            }
            
                if((mem[this.mIntersections.SyncRoot + 12]) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_31 = mem[this.mIntersections.SyncRoot + 8];
                val_31 = val_31 + 0;
                if((mem[this.mIntersections.SyncRoot + 12]) <= val_25)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_32 = mem[this.mIntersections.SyncRoot + 8];
                val_32 = val_32 + 0;
                if(((mem[this.mIntersections.SyncRoot + 8] + 0) + 16 + 12 + 8.Equals(p:  (mem[this.mIntersections.SyncRoot + 8] + 0) + 20 + 12 + 8)) != false)
            {
                    if((mem[this.mIntersections.SyncRoot + 12]) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_33 = mem[this.mIntersections.SyncRoot + 8];
                val_33 = val_33 + 0;
                if((mem[this.mIntersections.SyncRoot + 12]) <= val_25)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_34 = mem[this.mIntersections.SyncRoot + 8];
                val_34 = val_34 + 0;
                if(((mem[this.mIntersections.SyncRoot + 8] + 0) + 16 + 12 + 12.Equals(p:  (mem[this.mIntersections.SyncRoot + 8] + 0) + 20 + 12 + 12)) != false)
            {
                    if((mem[this.mIntersections.SyncRoot + 12]) <= val_25)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_35 = mem[this.mIntersections.SyncRoot + 8];
                val_35 = val_35 + 0;
                if((mem[this.mIntersections.SyncRoot + 12]) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_36 = mem[this.mIntersections.SyncRoot + 8];
                val_36 = val_36 + 0;
                mem2[0] = (mem[this.mIntersections.SyncRoot + 8] + 0) + 16 + 16;
            }
            
            }
            
            }
            while(((mem[this.mIntersections.SyncRoot + 12]) - 1) != val_25);
            
            }
            
            }
            while(1 != (mem[this.mIntersections.SyncRoot + 12]));
            
            }
            
            List.Enumerator<T> val_10 = GetEnumerator();
            val_24 = val_24;
            label_76:
            if(MoveNext() == false)
            {
                goto label_64;
            }
            
            if((mem[1152921510219042788].Contains(p:  val_12 + 16)) != true)
            {
                    FerrPoly2Tri.Point2D val_37 = val_12 + 8 + 8;
                val_37 = (mem[1152921510219042788].IndexOf(p:  val_37)) + 1;
            }
            
            if((mem[536891885].Contains(p:  val_12 + 16)) == true)
            {
                goto label_76;
            }
            
            FerrPoly2Tri.Point2D val_38 = val_12 + 12 + 8;
            val_38 = (mem[536891885].IndexOf(p:  val_38)) + 1;
            goto label_76;
            label_64:
            Dispose();
            System.Collections.Generic.List<System.Int32> val_17 = 536877987;
            val_17 = new System.Collections.Generic.List<System.Int32>();
            mem[1152921510219042808] = val_17;
            val_29 = 0;
            goto label_77;
            label_80:
            mem[1152921510219042808].Add(item:  0);
            val_29 = 1;
            label_77:
            if(val_29 < mem[536891885].Count)
            {
                goto label_80;
            }
            
            System.Collections.Generic.List<System.Int32> val_19 = 536877987;
            val_19 = new System.Collections.Generic.List<System.Int32>();
            mem[1152921510219042812] = val_19;
            val_30 = 0;
            goto label_81;
            label_84:
            mem[1152921510219042812].Add(item:  0);
            val_30 = 1;
            label_81:
            if(val_30 < mem[1152921510219042788].Count)
            {
                goto label_84;
            }
            
            val_27 = 0;
            val_25 = 22737168;
            label_89:
            FerrPoly2Tri.Point2D val_21 = mem[1152921510219042788].Item[0];
            bool val_22 = this.PointInPolygonAngle(point:  536891885, polygon:  536891885);
            val_28 = mem[1152921510219042812];
            val_28.set_Item(index:  0, value:  val_22);
            if(val_22 == true)
            {
                goto label_87;
            }
            
            if((mem[1152921510219042788].NextIndex(index:  0)) != 0)
            {
                goto label_89;
            }
            
            val_27 = mem[1152921510219042800];
            goto label_90;
            label_87:
            mem[1152921510219042800] = val_27;
            label_90:
            val_31 = 1;
            if(val_27 != 1)
            {
                    return (bool)val_31;
            }
            
            val_26 = 2;
            label_3:
            val_31 = 0;
            mem[1152921510219042804] = val_26;
            return (bool)val_31;
        }
        private bool VerticesIntersect(FerrPoly2Tri.Point2DList polygon1, FerrPoly2Tri.Point2DList polygon2, out System.Collections.Generic.List<FerrPoly2Tri.EdgeIntersectInfo> intersections)
        {
            FerrPoly2Tri.Point2DList val_21;
            bool val_22;
            var val_23;
            var val_24;
            int val_25;
            var val_26;
            var val_27;
            int val_28;
            val_21 = polygon1;
            536877855 = new System.Collections.Generic.List<Page>();
            mem2[0] = 536877855;
            val_22 = mem[536890482];
            if((val_22 & true) == 0)
            {
                    val_22 = mem[536890411];
            }
            
            val_23 = 0;
            val_24 = 22713964;
            goto label_5;
            label_16:
            if(val_21 != 0)
            {
                    FerrPoly2Tri.Point2D val_3 = val_21.Item[0];
                val_25 = val_21.NextIndex(index:  0);
            }
            else
            {
                    FerrPoly2Tri.Point2D val_5 = 0.Item[0];
                val_25 = 0.NextIndex(index:  0);
            }
            
            val_26 = 0;
            FerrPoly2Tri.Point2D val_7 = val_21.Item[val_25];
            goto label_8;
            label_14:
            FerrPoly2Tri.Point2D val_8 = 536891877;
            val_8 = new FerrPoly2Tri.Point2D();
            if(polygon2 != 0)
            {
                    FerrPoly2Tri.Point2D val_9 = polygon2.Item[0];
                val_27 = polygon2;
                val_28 = polygon2.NextIndex(index:  0);
            }
            else
            {
                    FerrPoly2Tri.Point2D val_11 = 0.Item[0];
                val_27 = 0;
                val_28 = 0.NextIndex(index:  0);
            }
            
            FerrPoly2Tri.Point2D val_13 = polygon2.Item[val_28];
            if((FerrPoly2Tri.TriangulationUtil.LinesIntersect2D(ptStart0:  0, ptEnd0:  val_21, ptStart1:  0, ptEnd1:  polygon2, pIntersectionPt: ref  val_8, epsilon:  System.Math.Min(val1:  null, val2:  null))) != false)
            {
                    536886195 = new FerrPoly2Tri.Edge(edgeStart:  0, edgeEnd:  val_21);
                536886195 = new FerrPoly2Tri.Edge(edgeStart:  0, edgeEnd:  polygon2);
                536886207 = new FerrPoly2Tri.EdgeIntersectInfo(edgeOne:  536886195, edgeTwo:  536886195, intersectionPoint:  536891877);
                intersections.Add(item:  536886207);
                val_24 = 22713964;
            }
            
            val_26 = 1;
            label_8:
            if(val_26 < polygon2.Count)
            {
                goto label_14;
            }
            
            val_21 = val_21;
            val_23 = 1;
            label_5:
            if(val_23 < val_21.Count)
            {
                goto label_16;
            }
            
            if((intersections + 12) > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool PointInPolygonAngle(FerrPoly2Tri.Point2D point, FerrPoly2Tri.Point2DList polygon)
        {
            var val_10;
            var val_11;
            int val_12;
            val_11 = 0;
            goto label_1;
            label_6:
            FerrPoly2Tri.Point2D val_1 = polygon.Item[0];
            FerrPoly2Tri.Point2D val_2 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  polygon, rhs:  point);
            if(polygon != 0)
            {
                    val_12 = polygon.NextIndex(index:  0);
            }
            else
            {
                    val_12 = 0.NextIndex(index:  0);
            }
            
            FerrPoly2Tri.Point2D val_5 = polygon.Item[val_12];
            FerrPoly2Tri.Point2D val_6 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  polygon, rhs:  point);
            double val_7 = polygon.VectorAngle(p1:  polygon, p2:  polygon);
            val_11 = 1;
            val_10 = D8 + polygon;
            label_1:
            if(val_11 < polygon.Count)
            {
                goto label_6;
            }
            
            double val_9 = System.Math.Abs(val_10);
            if(mem[536890411] >= 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public double VectorAngle(FerrPoly2Tri.Point2D p1, FerrPoly2Tri.Point2D p2)
        {
            FerrPoly2Tri.Point2D val_1 = p2;
            val_1 = val_1 - p1;
            if(p2 > 0)
            {
                    do
            {
                val_1 = val_1 + (6.98487350263574E-315);
            }
            while(p2 > 0);
            
            }
            
            if(p2 >= 0)
            {
                    return (double)D0;
            }
            
            do
            {
                val_1 = val_1 + (6.98487350263574E-315);
            }
            while(p2 < 0);
            
            return (double)D0;
        }
    
    }

}
