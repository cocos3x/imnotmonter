using UnityEngine;

namespace FerrPoly2Tri
{
    public class DTSweepContext : TriangulationContext
    {
        // Fields
        private readonly float ALPHA;
        public FerrPoly2Tri.AdvancingFront Front;
        private FerrPoly2Tri.TriangulationPoint <Head>k__BackingField;
        private FerrPoly2Tri.TriangulationPoint <Tail>k__BackingField;
        public FerrPoly2Tri.DTSweepBasin Basin;
        public FerrPoly2Tri.DTSweepEdgeEvent EdgeEvent;
        private FerrPoly2Tri.DTSweepPointComparator _comparator;
        
        // Properties
        public FerrPoly2Tri.TriangulationPoint Head { get; set; }
        public FerrPoly2Tri.TriangulationPoint Tail { get; set; }
        public override FerrPoly2Tri.TriangulationAlgorithm Algorithm { get; }
        public override bool IsDebugEnabled { get; set; }
        
        // Methods
        public FerrPoly2Tri.TriangulationPoint get_Head()
        {
        
        }
        public void set_Head(FerrPoly2Tri.TriangulationPoint value)
        {
            this.<Head>k__BackingField = value;
        }
        public FerrPoly2Tri.TriangulationPoint get_Tail()
        {
        
        }
        public void set_Tail(FerrPoly2Tri.TriangulationPoint value)
        {
            this.<Tail>k__BackingField = value;
        }
        public override FerrPoly2Tri.TriangulationAlgorithm get_Algorithm()
        {
        
        }
        public DTSweepContext()
        {
            this.ALPHA = 0.3f;
            object val_1 = 536885645;
            val_1 = new System.Object();
            this.Basin = val_1;
            object val_2 = 536885659;
            val_2 = new System.Object();
            this.EdgeEvent = val_2;
            object val_3 = 536885663;
            val_3 = new System.Object();
            this._comparator = val_3;
            goto typeof(FerrPoly2Tri.DTSweepContext).__il2cppRuntimeField_F4;
        }
        public override bool get_IsDebugEnabled()
        {
            return (bool)this;
        }
        protected override void set_IsDebugEnabled(bool value)
        {
            if(value != false)
            {
                    22969405 = this;
                if(true == 0)
            {
                    FerrPoly2Tri.TriangulationDebugContext val_1 = 536885657;
                val_1 = new FerrPoly2Tri.TriangulationDebugContext(tcx:  1293924720);
                mem[1152921510195739000] = val_1;
            }
            
            }
            
            mem[1152921510195739024] = value;
        }
        public void RemoveFromList(FerrPoly2Tri.DelaunayTriangle triangle)
        {
            bool val_1 = this.Remove(item:  triangle);
        }
        public void MeshClean(FerrPoly2Tri.DelaunayTriangle triangle)
        {
            this.MeshCleanReq(triangle:  triangle);
        }
        private void MeshCleanReq(FerrPoly2Tri.DelaunayTriangle triangle)
        {
            var val_4;
            if(triangle == 0)
            {
                    return;
            }
            
            if((triangle.<IsInterior>k__BackingField) == true)
            {
                    return;
            }
            
            triangle.<IsInterior>k__BackingField = true;
            if((R6 + 178) == 0)
            {
                goto label_4;
            }
            
            var val_4 = 0;
            label_6:
            if((R6 + 88 + 0) == 536888795)
            {
                goto label_5;
            }
            
            val_4 = val_4 + 1;
            if(((uint)val_4 & 65535) < (R6 + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_4 = R6;
            goto label_7;
            label_5:
            var val_1 = (R6 + 88) + 0;
            var val_5 = (R6 + 88 + 0) + 4;
            val_5 = R6 + (val_5 << 3);
            val_4 = val_5 + 332;
            label_7:
            var val_6 = 0;
            do
            {
                if(triangle.mEdgeIsConstrained._0.Item[0] != true)
            {
                    FerrPoly2Tri.DelaunayTriangle val_3 = triangle.Neighbors.Item[0];
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 != 3);
        
        }
        public override void Clear()
        {
            this.Clear();
            this.Clear();
        }
        public void AddNode(FerrPoly2Tri.AdvancingFrontNode node)
        {
            this.Front.AddNode(node:  node);
        }
        public void RemoveNode(FerrPoly2Tri.AdvancingFrontNode node)
        {
            this.Front.RemoveNode(node:  node);
        }
        public FerrPoly2Tri.AdvancingFrontNode LocateNode(FerrPoly2Tri.TriangulationPoint point)
        {
            if(this.Front != 0)
            {
                    return this.Front.LocateNode(point:  point);
            }
            
            return this.Front.LocateNode(point:  point);
        }
        public void CreateAdvancingFront()
        {
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            FerrPoly2Tri.DelaunayTriangle val_1 = 536885899;
            val_1 = new FerrPoly2Tri.DelaunayTriangle(p1:  mem[1852140925], p2:  this.<Tail>k__BackingField, p3:  this.<Head>k__BackingField);
            this.<Head>k__BackingField.Add(item:  536885899);
            FerrPoly2Tri.TriangulationPoint val_2 = val_1 + 8;
            FerrPoly2Tri.TriangulationPoint val_3 = val_2.Item[1];
            536883105 = new FerrPoly2Tri.AdvancingFrontNode(point:  val_2);
            mem[536883133] = val_1;
            FerrPoly2Tri.TriangulationPoint val_5 = val_2.Item[0];
            FerrPoly2Tri.AdvancingFrontNode val_6 = 536883105;
            val_6 = new FerrPoly2Tri.AdvancingFrontNode(point:  val_2);
            mem[536883133] = val_1;
            FerrPoly2Tri.TriangulationPoint val_7 = val_2.Item[2];
            536883105 = new FerrPoly2Tri.AdvancingFrontNode(point:  val_2);
            FerrPoly2Tri.AdvancingFront val_9 = 536883101;
            val_9 = new FerrPoly2Tri.AdvancingFront(head:  536883105, tail:  536883105);
            this.Front = val_9;
            this.Front.AddNode(node:  536883105);
            mem2[0] = val_6;
            mem[536883113] = mem[536883113];
            mem[536883117] = mem[536883109];
            mem2[0] = val_6;
        }
        public void MapTriangleToNodes(FerrPoly2Tri.DelaunayTriangle t)
        {
            FerrPoly2Tri.TriangulationPoint val_6;
            var val_6 = 0;
            do
            {
                FerrPoly2Tri.DelaunayTriangle val_1 = t.Neighbors.Item[0];
                if(t.Neighbors == 0)
            {
                    if(t != 0)
            {
                    FerrPoly2Tri.TriangulationPoint val_2 = t.Points.Item[0];
                val_6 = t.Points;
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_3 = t.Points.Item[0];
                val_6 = t.Points;
            }
            
                FerrPoly2Tri.TriangulationPoint val_4 = t.PointCWFrom(point:  val_6);
                FerrPoly2Tri.AdvancingFrontNode val_5 = mem[1152921510196841240].LocatePoint(point:  t);
                if(mem[1152921510196841240] != 0)
            {
                    mem2[0] = t;
            }
            
            }
            
                val_6 = val_6 + 1;
            }
            while(val_6 != 3);
        
        }
        public override void PrepareTriangulation(FerrPoly2Tri.ITriangulatable t)
        {
            var val_3;
            this.PrepareTriangulation(t:  t);
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            var val_10 = static_value_015E7C4B + 16;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_14:
            label_13:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            if(val_3 >= 0)
            {
                goto label_13;
            }
            
            goto label_14;
            label_8:
            Dispose();
            double val_5 = (D11 - val_10) * D17;
            FerrPoly2Tri.TriangulationPoint val_8 = 536895819;
            double val_6 = D10 - D9;
            double val_7 = D11 + val_5;
            val_8 = new FerrPoly2Tri.TriangulationPoint(x:  null, y:  null, aId:  -1073728399);
            FerrPoly2Tri.TriangulationPoint val_9 = 536895819;
            val_10 = val_10 - val_5;
            val_9 = new FerrPoly2Tri.TriangulationPoint(x:  null, y:  null, aId:  -1073728399);
            this.<Head>k__BackingField = val_8;
            this.<Tail>k__BackingField = val_9;
            val_9.Sort(comparer:  this._comparator);
        }
        public void FinalizeTriangulation()
        {
            var val_2;
            var val_3;
            var val_3 = R6;
            if((R6 + 178) == 0)
            {
                goto label_2;
            }
            
            var val_2 = 0;
            label_4:
            val_2 = 0;
            if((R6 + 88 + 0) == 536888795)
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            if(val_2 < (R6 + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_3 = R6;
            goto label_5;
            label_3:
            var val_1 = (R6 + 88) + 0;
            val_3 = val_3 + (((R6 + 88 + 0) + 4) << 3);
            val_3 = val_3 + 340;
            label_5:
            R6 + 88 + 0.Clear();
        }
        public override FerrPoly2Tri.TriangulationConstraint NewConstraint(FerrPoly2Tri.TriangulationPoint a, FerrPoly2Tri.TriangulationPoint b)
        {
            536885649 = new FerrPoly2Tri.DTSweepConstraint(p1:  a, p2:  b);
        }
    
    }

}
