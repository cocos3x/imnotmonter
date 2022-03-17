using UnityEngine;

namespace FerrPoly2Tri
{
    public class DelaunayTriangle
    {
        // Fields
        public FerrPoly2Tri.FixedArray3<FerrPoly2Tri.TriangulationPoint> Points;
        public FerrPoly2Tri.FixedArray3<FerrPoly2Tri.DelaunayTriangle> Neighbors;
        private FerrPoly2Tri.FixedBitArray3 mEdgeIsConstrained;
        public FerrPoly2Tri.FixedBitArray3 EdgeIsDelaunay;
        private bool <IsInterior>k__BackingField;
        
        // Properties
        public FerrPoly2Tri.FixedBitArray3 EdgeIsConstrained { get; }
        public bool IsInterior { get; set; }
        
        // Methods
        public FerrPoly2Tri.FixedBitArray3 get_EdgeIsConstrained()
        {
            FerrPoly2Tri.FixedBitArray3 val_1 = this.mEdgeIsConstrained;
            val_1 = val_1 | ((R1) << 16);
            return new FerrPoly2Tri.FixedBitArray3() {_0 = val_1, _1 = val_1, _2 = val_1};
        }
        public bool get_IsInterior()
        {
            return (bool)this.<IsInterior>k__BackingField;
        }
        public void set_IsInterior(bool value)
        {
            this.<IsInterior>k__BackingField = value;
        }
        public DelaunayTriangle(FerrPoly2Tri.TriangulationPoint p1, FerrPoly2Tri.TriangulationPoint p2, FerrPoly2Tri.TriangulationPoint p3)
        {
            FerrPoly2Tri.TriangulationPoint val_1 = p3;
            val_1 = new System.Object();
            this.Points.set_Item(index:  0, value:  p1);
            this.Points.set_Item(index:  1, value:  p2);
            this.Points.set_Item(index:  2, value:  val_1);
        }
        public int IndexOf(FerrPoly2Tri.TriangulationPoint p)
        {
            int val_1 = this.Points.IndexOf(value:  p);
            if(val_1 != 1)
            {
                    return val_1;
            }
            
            22710780 = new System.Exception(message:  22782932);
        }
        public int IndexCWFrom(FerrPoly2Tri.TriangulationPoint p)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 2;
            val_1 = val_1 - 4294967298;
            return (int)val_1;
        }
        public int IndexCCWFrom(FerrPoly2Tri.TriangulationPoint p)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 1;
            val_1 = val_1 - 4294967298;
            return (int)val_1;
        }
        public bool Contains(FerrPoly2Tri.TriangulationPoint p)
        {
            return this.Points.Contains(value:  p);
        }
        private void MarkNeighbor(FerrPoly2Tri.TriangulationPoint p1, FerrPoly2Tri.TriangulationPoint p2, FerrPoly2Tri.DelaunayTriangle t)
        {
            int val_1 = this.EdgeIndex(p1:  p1, p2:  p2);
            if(val_1 != 1)
            {
                    this.Neighbors.set_Item(index:  val_1, value:  t);
                return;
            }
            
            22710780 = new System.Exception(message:  22785488);
        }
        public void MarkNeighbor(FerrPoly2Tri.DelaunayTriangle t)
        {
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            FerrPoly2Tri.TriangulationPoint val_16;
            FerrPoly2Tri.TriangulationPoint val_17;
            var val_18;
            FerrPoly2Tri.TriangulationPoint val_1 = this.Points.Item[0];
            bool val_2 = t.Contains(p:  this.Points);
            FerrPoly2Tri.TriangulationPoint val_3 = this.Points.Item[1];
            bool val_4 = t.Contains(p:  this.Points);
            FerrPoly2Tri.TriangulationPoint val_5 = this.Points.Item[2];
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.TriangulationPoint> val_12 = this.Points;
            bool val_6 = t.Contains(p:  val_12);
            val_12 = val_4 & val_6;
            if(val_12 != true)
            {
                goto label_4;
            }
            
            this.Neighbors.set_Item(index:  0, value:  t);
            val_12 = -1073723595;
            val_13 = this.Points;
            val_14 = 1;
            goto label_5;
            label_4:
            val_6 = val_2 & val_6;
            if(val_6 != true)
            {
                goto label_6;
            }
            
            this.Neighbors.set_Item(index:  1, value:  t);
            val_12 = -1073723595;
            val_13 = this.Points;
            val_14 = 0;
            label_5:
            FerrPoly2Tri.TriangulationPoint val_7 = val_13.Item[0];
            val_15 = -1073723595;
            val_16 = val_13;
            val_17 = this.Points;
            val_18 = 2;
            goto label_7;
            label_6:
            if((val_2 & val_4) != true)
            {
                goto label_8;
            }
            
            this.Neighbors.set_Item(index:  2, value:  t);
            FerrPoly2Tri.TriangulationPoint val_9 = this.Points.Item[0];
            val_16 = this.Points;
            val_15 = -1073723595;
            val_17 = this.Points;
            val_18 = 1;
            label_7:
            FerrPoly2Tri.TriangulationPoint val_10 = val_17.Item[1];
            t.MarkNeighbor(p1:  val_16, p2:  val_17, t:  1279802576);
            return;
            label_8:
            22710780 = new System.Exception(message:  22785856);
        }
        public void ClearNeighbors()
        {
            this.Neighbors.set_Item(index:  2, value:  0);
            this.Neighbors.set_Item(index:  1, value:  0);
            this.Neighbors.set_Item(index:  0, value:  0);
        }
        public void ClearNeighbor(FerrPoly2Tri.DelaunayTriangle triangle)
        {
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.DelaunayTriangle> val_5;
            var val_6;
            var val_7;
            var val_8;
            val_5 = this.Neighbors;
            val_6 = 22731972;
            FerrPoly2Tri.DelaunayTriangle val_1 = val_5.Item[0];
            if(val_5 == triangle)
            {
                goto label_1;
            }
            
            FerrPoly2Tri.DelaunayTriangle val_2 = val_5.Item[1];
            if(val_5 == triangle)
            {
                goto label_2;
            }
            
            FerrPoly2Tri.DelaunayTriangle val_3 = val_5.Item[2];
            if(val_5 != triangle)
            {
                    return;
            }
            
            val_7 = 2;
            val_8 = 22731976;
            goto label_4;
            label_1:
            val_7 = 0;
            val_8 = 22731976;
            goto label_4;
            label_2:
            val_7 = 1;
            val_8 = 22731976;
            label_4:
            val_5.set_Item(index:  1, value:  0);
        }
        public void Clear()
        {
            var val_2 = 0;
            do
            {
                FerrPoly2Tri.DelaunayTriangle val_1 = this.Neighbors.Item[0];
                if(this.Neighbors != 0)
            {
                    val_2 = this;
                this.Neighbors.ClearNeighbor(triangle:  1280150864);
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 != 3);
            
            this.ClearNeighbors();
            this.Points.set_Item(index:  2, value:  0);
            this.Points.set_Item(index:  1, value:  0);
            this.Points.set_Item(index:  0, value:  0);
        }
        public FerrPoly2Tri.TriangulationPoint OppositePoint(FerrPoly2Tri.DelaunayTriangle t, FerrPoly2Tri.TriangulationPoint p)
        {
            FerrPoly2Tri.TriangulationPoint val_1 = t.PointCWFrom(point:  p);
            return this.PointCWFrom(point:  t);
        }
        public FerrPoly2Tri.DelaunayTriangle NeighborCWFrom(FerrPoly2Tri.TriangulationPoint point)
        {
            int val_1 = this.Points.IndexOf(value:  point);
            val_1 = val_1 + 1;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            return this.Neighbors.Item[val_2];
        }
        public FerrPoly2Tri.DelaunayTriangle NeighborCCWFrom(FerrPoly2Tri.TriangulationPoint point)
        {
            int val_1 = this.Points.IndexOf(value:  point);
            val_1 = val_1 + 2;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            return this.Neighbors.Item[val_2];
        }
        public FerrPoly2Tri.DelaunayTriangle NeighborAcrossFrom(FerrPoly2Tri.TriangulationPoint point)
        {
            return this.Neighbors.Item[this.Points.IndexOf(value:  point)];
        }
        public FerrPoly2Tri.TriangulationPoint PointCCWFrom(FerrPoly2Tri.TriangulationPoint point)
        {
            int val_1 = this.IndexOf(p:  point);
            val_1 = val_1 + 1;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            return this.Points.Item[val_2];
        }
        public FerrPoly2Tri.TriangulationPoint PointCWFrom(FerrPoly2Tri.TriangulationPoint point)
        {
            int val_1 = this.IndexOf(p:  point);
            val_1 = val_1 + 2;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            return this.Points.Item[val_2];
        }
        private void RotateCW()
        {
            FerrPoly2Tri.TriangulationPoint val_1 = this.Points.Item[2];
            FerrPoly2Tri.TriangulationPoint val_2 = this.Points.Item[1];
            this.Points.set_Item(index:  2, value:  this.Points);
            FerrPoly2Tri.TriangulationPoint val_3 = this.Points.Item[0];
            this.Points.set_Item(index:  1, value:  this.Points);
            this.Points.set_Item(index:  0, value:  this.Points);
        }
        public void Legalize(FerrPoly2Tri.TriangulationPoint oPoint, FerrPoly2Tri.TriangulationPoint nPoint)
        {
            this.RotateCW();
            int val_1 = this.IndexOf(p:  oPoint);
            val_1 = val_1 + 1;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            this.Points.set_Item(index:  val_2, value:  nPoint);
        }
        public override string ToString()
        {
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.TriangulationPoint> val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_4 = 0;
            FerrPoly2Tri.TriangulationPoint val_1 = this.Points.Item[0];
            if(this.Points != 0)
            {
                    val_4 = this.Points;
            }
            
            mem[536882417] = val_4;
            mem[536882421] = -1610611911;
            FerrPoly2Tri.TriangulationPoint val_2 = this.Points.Item[1];
            val_5 = 0;
            if(this.Points == 0)
            {
                goto label_9;
            }
            
            val_6 = this.Points;
            if(this.Points == 0)
            {
                goto label_12;
            }
            
            val_5 = val_6;
            goto label_12;
            label_9:
            val_6 = 0;
            label_12:
            mem[536882425] = val_5;
            mem[536882429] = -1610611911;
            FerrPoly2Tri.TriangulationPoint val_3 = this.Points.Item[2];
            val_7 = 0;
            if(this.Points == 0)
            {
                goto label_17;
            }
            
            val_8 = this.Points;
            if(this.Points == 0)
            {
                goto label_20;
            }
            
            val_7 = val_8;
            goto label_20;
            label_17:
            val_8 = 0;
            label_20:
            mem[536882433] = val_7;
            return +536882401;
        }
        public void MarkNeighborEdges()
        {
            var val_7;
            var val_8 = 0;
            var val_9 = 2;
            val_7 = 22731972;
            do
            {
                if(this.mEdgeIsConstrained._0.Item[0] != false)
            {
                    FerrPoly2Tri.DelaunayTriangle val_2 = this.Neighbors.Item[0];
                if(this.Neighbors != 0)
            {
                    FerrPoly2Tri.DelaunayTriangle val_3 = this.Neighbors.Item[0];
                FerrPoly2Tri.TriangulationPoint val_5 = this.Points.Item[val_8 - 2];
                FerrPoly2Tri.TriangulationPoint val_7 = this.Points.Item[val_8 + 2];
                this.Neighbors.MarkConstrainedEdge(p:  this.Points, q:  this.Points);
                val_7 = 22731972;
            }
            
            }
            
                val_8 = val_8 + 1;
                val_9 = val_9 + 1;
            }
            while(val_8 != 3);
        
        }
        public void MarkEdge(FerrPoly2Tri.DelaunayTriangle triangle)
        {
            var val_7 = 2;
            do
            {
                int val_2 = 0 + 1;
                if(this.mEdgeIsConstrained._0.Item[0] != false)
            {
                    FerrPoly2Tri.TriangulationPoint val_4 = this.Points.Item[0 - 2];
                FerrPoly2Tri.TriangulationPoint val_6 = this.Points.Item[0 + 2];
                triangle.MarkConstrainedEdge(p:  this.Points, q:  this.Points);
            }
            
                val_7 = val_7 + 1;
            }
            while(val_2 != 3);
        
        }
        public void MarkEdge(System.Collections.Generic.List<FerrPoly2Tri.DelaunayTriangle> tList)
        {
            var val_2;
            List.Enumerator<T> val_1 = GetEnumerator();
            goto label_2;
            label_6:
            FerrPoly2Tri.TriangulationPoint val_3 = val_2 + 8;
            do
            {
                tList = 0 + 1;
                if((val_2 + 32.Item[0]) != false)
            {
                    FerrPoly2Tri.TriangulationPoint val_7 = val_3.Item[0 - 2];
                int val_9 = R3 >> 1;
                val_9 = val_9 + (val_9 << 1);
                val_9 = ((int)(0 + 2) & 255) - val_9;
                FerrPoly2Tri.TriangulationPoint val_10 = val_3.Item[val_9];
                this.MarkConstrainedEdge(p:  val_3, q:  val_3);
            }
            
            }
            while((tList - 1) <= 1);
            
            label_2:
            if(MoveNext() == true)
            {
                goto label_6;
            }
            
            Dispose();
        }
        public void MarkConstrainedEdge(int index)
        {
            this.mEdgeIsConstrained.set_Item(index:  index, value:  true);
        }
        public void MarkConstrainedEdge(FerrPoly2Tri.DTSweepConstraint edge)
        {
            var val_4;
            var val_5;
            if(edge != 0)
            {
                    val_4 = edge;
                FerrPoly2Tri.TriangulationPoint val_1 = edge.P;
                val_5 = edge;
            }
            else
            {
                    val_4 = 0;
                FerrPoly2Tri.TriangulationPoint val_2 = 0.P;
                val_5 = 0;
            }
            
            FerrPoly2Tri.TriangulationPoint val_3 = val_4.Q;
            this.MarkConstrainedEdge(p:  0, q:  0);
        }
        public void MarkConstrainedEdge(FerrPoly2Tri.TriangulationPoint p, FerrPoly2Tri.TriangulationPoint q)
        {
            int val_1 = this.EdgeIndex(p1:  p, p2:  q);
            if(val_1 == 1)
            {
                    return;
            }
            
            this.mEdgeIsConstrained.set_Item(index:  val_1, value:  true);
        }
        public double Area()
        {
            bool val_6;
            FerrPoly2Tri.TriangulationPoint val_1 = this.Points.Item[0];
            FerrPoly2Tri.TriangulationPoint val_2 = this.Points.Item[1];
            FerrPoly2Tri.TriangulationPoint val_3 = this.Points.Item[2];
            FerrPoly2Tri.TriangulationPoint val_4 = this.Points.Item[1];
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.TriangulationPoint> val_6 = this.Points;
            val_6 = val_6 - this.Points;
            val_6 = mem[536890482];
            if((val_6 & true) == 0)
            {
                    val_6 = mem[536890411];
            }
            
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.TriangulationPoint> val_5 = this.Points - this.Points;
            val_5 = val_5 * val_6;
            val_5 = val_5 * 0.5;
            double val_7 = System.Math.Abs(val_5);
            return (double)D0;
        }
        public FerrPoly2Tri.TriangulationPoint Centroid()
        {
            FerrPoly2Tri.TriangulationPoint val_1 = this.Points.Item[0];
            FerrPoly2Tri.TriangulationPoint val_2 = this.Points.Item[1];
            FerrPoly2Tri.TriangulationPoint val_3 = this.Points.Item[2];
            FerrPoly2Tri.TriangulationPoint val_4 = this.Points.Item[0];
            FerrPoly2Tri.TriangulationPoint val_5 = this.Points.Item[1];
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.TriangulationPoint> val_11 = this.Points;
            FerrPoly2Tri.TriangulationPoint val_6 = this.Points.Item[2];
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.TriangulationPoint> val_7 = this.Points + this.Points;
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.TriangulationPoint> val_8 = this.Points + this.Points;
            val_7 = val_7 + val_11;
            val_8 = val_8 + this.Points;
            val_11 = val_7 / 3;
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.TriangulationPoint> val_9 = val_8 / 3;
            536895819 = new FerrPoly2Tri.TriangulationPoint(x:  null, y:  null, aId:  0);
        }
        public int EdgeIndex(FerrPoly2Tri.TriangulationPoint p1, FerrPoly2Tri.TriangulationPoint p2)
        {
            var val_7;
            var val_8;
            val_7 = 22731992;
            int val_1 = this.Points.IndexOf(value:  p1);
            int val_2 = this.Points.IndexOf(value:  p2);
            int val_3 = val_1 - 1;
            int val_4 = val_2 - 1;
            int val_5 = val_2 - 2;
            val_3 = val_3 >> 5;
            val_4 = val_4 >> 5;
            val_4 = val_3 | val_4;
            if(static_value_015E7C87 == true)
            {
                    val_3 = val_1;
            }
            
            val_3 = val_3 - 2;
            val_5 = val_5 >> 5;
            val_3 = val_3 >> 5;
            val_5 = val_5 | val_3;
            if(val_4 == 1)
            {
                    val_8 = 0;
                if(val_5 != 0)
            {
                    return (int)val_8;
            }
            
            }
            
            val_2 = val_2 >> 5;
            val_7 = 0 | val_2;
            val_8 = 1;
            if((val_7 & val_5) == 0)
            {
                    return (int)val_8;
            }
            
            if(val_4 != 0)
            {
                    0 = 2;
            }
            
            return (int)0;
        }
        public bool GetConstrainedEdgeCCW(FerrPoly2Tri.TriangulationPoint p)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 2;
            int val_3 = 4294967298;
            val_3 = val_1 - val_3;
            return (bool)this.mEdgeIsConstrained.Item[val_3];
        }
        public bool GetConstrainedEdgeCW(FerrPoly2Tri.TriangulationPoint p)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 1;
            int val_3 = 4294967298;
            val_3 = val_1 - val_3;
            return (bool)this.mEdgeIsConstrained.Item[val_3];
        }
        public bool GetConstrainedEdgeAcross(FerrPoly2Tri.TriangulationPoint p)
        {
            return (bool)this.mEdgeIsConstrained.Item[this.IndexOf(p:  p)];
        }
        protected void SetConstrainedEdge(int idx, bool ce)
        {
            this.mEdgeIsConstrained.set_Item(index:  idx, value:  ce);
        }
        public void SetConstrainedEdgeCCW(FerrPoly2Tri.TriangulationPoint p, bool ce)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 2;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            this.mEdgeIsConstrained.set_Item(index:  val_2, value:  ce);
        }
        public void SetConstrainedEdgeCW(FerrPoly2Tri.TriangulationPoint p, bool ce)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 1;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            this.mEdgeIsConstrained.set_Item(index:  val_2, value:  ce);
        }
        public void SetConstrainedEdgeAcross(FerrPoly2Tri.TriangulationPoint p, bool ce)
        {
            this.mEdgeIsConstrained.set_Item(index:  this.IndexOf(p:  p), value:  ce);
        }
        public bool GetDelaunayEdgeCCW(FerrPoly2Tri.TriangulationPoint p)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 2;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            return this.EdgeIsDelaunay.Item[val_2];
        }
        public bool GetDelaunayEdgeCW(FerrPoly2Tri.TriangulationPoint p)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 1;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            return this.EdgeIsDelaunay.Item[val_2];
        }
        public bool GetDelaunayEdgeAcross(FerrPoly2Tri.TriangulationPoint p)
        {
            return this.EdgeIsDelaunay.Item[this.IndexOf(p:  p)];
        }
        public void SetDelaunayEdgeCCW(FerrPoly2Tri.TriangulationPoint p, bool ce)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 2;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            this.EdgeIsDelaunay.set_Item(index:  val_2, value:  ce);
        }
        public void SetDelaunayEdgeCW(FerrPoly2Tri.TriangulationPoint p, bool ce)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 1;
            int val_2 = 4294967298;
            val_2 = val_1 - val_2;
            this.EdgeIsDelaunay.set_Item(index:  val_2, value:  ce);
        }
        public void SetDelaunayEdgeAcross(FerrPoly2Tri.TriangulationPoint p, bool ce)
        {
            this.EdgeIsDelaunay.set_Item(index:  this.IndexOf(p:  p), value:  ce);
        }
        public bool GetEdge(int idx, out FerrPoly2Tri.DTSweepConstraint edge)
        {
            FerrPoly2Tri.TriangulationPoint val_8;
            FerrPoly2Tri.DTSweepConstraint val_9;
            val_8 = idx;
            val_9 = 0;
            edge = val_9;
            if(val_8 > 2)
            {
                    return (bool)val_9;
            }
            
            int val_8 = 0;
            val_8 = (val_8 + 1) - val_8;
            FerrPoly2Tri.TriangulationPoint val_2 = this.Points.Item[val_8];
            val_8 = val_8 + (val_8 >> 31);
            val_8 = val_8 + (val_8 << 1);
            val_8 = (val_8 + 2) - val_8;
            FerrPoly2Tri.TriangulationPoint val_4 = this.Points.Item[val_8];
            val_8 = this.Points;
            val_9 = 1;
            if((this.Points.GetEdge(p:  val_8, edge: out  FerrPoly2Tri.DTSweepConstraint val_5 = 1284000256)) != false)
            {
                    return (bool)val_9;
            }
            
            if(val_8 != 0)
            {
                    return val_8.GetEdge(p:  this.Points, edge: out  FerrPoly2Tri.DTSweepConstraint val_7 = 1284000256);
            }
            
            return val_8.GetEdge(p:  this.Points, edge: out  val_7);
        }
        public bool GetEdgeCCW(FerrPoly2Tri.TriangulationPoint p, out FerrPoly2Tri.DTSweepConstraint edge)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 2;
            int val_3 = 4294967298;
            val_3 = val_1 - val_3;
            return this.GetEdge(idx:  val_3, edge: out  FerrPoly2Tri.DTSweepConstraint val_2 = 1284128480);
        }
        public bool GetEdgeCW(FerrPoly2Tri.TriangulationPoint p, out FerrPoly2Tri.DTSweepConstraint edge)
        {
            int val_1 = this.IndexOf(p:  p);
            val_1 = val_1 + 1;
            int val_3 = 4294967298;
            val_3 = val_1 - val_3;
            return this.GetEdge(idx:  val_3, edge: out  FerrPoly2Tri.DTSweepConstraint val_2 = 1284256704);
        }
        public bool GetEdgeAcross(FerrPoly2Tri.TriangulationPoint p, out FerrPoly2Tri.DTSweepConstraint edge)
        {
            return this.GetEdge(idx:  this.IndexOf(p:  p), edge: out  FerrPoly2Tri.DTSweepConstraint val_2 = 1284384928);
        }
    
    }

}
