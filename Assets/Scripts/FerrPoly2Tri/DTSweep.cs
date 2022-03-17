using UnityEngine;

namespace FerrPoly2Tri
{
    public static class DTSweep
    {
        // Fields
        private const double PI_div2 = 1.5707963267949;
        private const double PI_3div4 = 2.35619449019234;
        
        // Methods
        public static void Triangulate(FerrPoly2Tri.DTSweepContext tcx)
        {
            if(tcx != 0)
            {
                    tcx.CreateAdvancingFront();
                FerrPoly2Tri.DTSweep.Sweep(tcx:  tcx);
                FerrPoly2Tri.DTSweep.FixupConstrainedEdges(tcx:  tcx);
            }
            else
            {
                    0.CreateAdvancingFront();
                FerrPoly2Tri.DTSweep.Sweep(tcx:  0);
                FerrPoly2Tri.DTSweep.FixupConstrainedEdges(tcx:  0);
            }
            
            if(0 == 2)
            {
                    FerrPoly2Tri.DTSweep.FinalizationPolygon(tcx:  tcx);
            }
            else
            {
                    FerrPoly2Tri.DTSweep.FinalizationConvexHull(tcx:  tcx);
                tcx.FinalizeTriangulation();
            }
            
            tcx.Done();
        }
        private static void Sweep(FerrPoly2Tri.DTSweepContext tcx)
        {
            FerrPoly2Tri.DTSweepConstraint val_5;
            var val_9 = 1;
            label_18:
            if(val_9 >= 771781743)
            {
                    return;
            }
            
            if(771781743 <= val_9)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = 1731068001;
            val_8 = val_8 + 4;
            FerrPoly2Tri.AdvancingFrontNode val_1 = FerrPoly2Tri.DTSweep.PointEvent(tcx:  tcx, point:  (1731068001 + 4) + 16);
            if((tcx == 0) || (((1731068001 + 4) + 16.HasEdges) == false))
            {
                goto label_16;
            }
            
            List.Enumerator<T> val_3 = GetEnumerator();
            label_14:
            if(MoveNext() == false)
            {
                goto label_10;
            }
            
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_6 = tcx.DTDebugContext;
                tcx.ActiveConstraint = val_5;
            }
            
            FerrPoly2Tri.DTSweep.EdgeEvent(tcx:  tcx, edge:  val_5, node:  tcx);
            goto label_14;
            label_10:
            Dispose();
            if(1 != 0)
            {
                    var val_7 = 1 - 1;
            }
            
            label_16:
            tcx.Update(message:  null);
            val_9 = val_9 + 1;
            goto label_18;
        }
        private static void FixupConstrainedEdges(FerrPoly2Tri.DTSweepContext tcx)
        {
            var val_2;
            List.Enumerator<T> val_1 = GetEnumerator();
            goto label_3;
            label_9:
            var val_18 = 2;
            var val_3 = val_2 + 32;
            FerrPoly2Tri.TriangulationPoint val_4 = val_2 + 8;
            do
            {
                FerrPoly2Tri.TriangulationPoint val_5 = val_4.Item[0];
                int val_6 = val_2.IndexOf(p:  val_4);
                val_6 = val_6 + 2;
                int val_16 = 4294967298;
                val_16 = val_6 - val_16;
                if(val_3.Item[val_16] != true)
            {
                    FerrPoly2Tri.TriangulationPoint val_8 = val_4.Item[0];
                int val_9 = val_2.IndexOf(p:  val_4);
                val_9 = val_9 + 2;
                int val_17 = 4294967298;
                val_17 = val_9 - val_17;
                if((val_2.GetEdge(idx:  val_17, edge: out  FerrPoly2Tri.DTSweepConstraint val_10 = 1286211892)) != false)
            {
                    var val_12 = SB >> 1;
                val_12 = val_12 + (val_12 << 1);
                val_12 = 2 - val_12;
                val_3.set_Item(index:  0 + val_12, value:  true);
            }
            
            }
            
                val_18 = val_18 + 1;
                var val_14 = 0 + 1;
            }
            while(0 <= 1);
            
            label_3:
            if(MoveNext() == true)
            {
                goto label_9;
            }
            
            Dispose();
        }
        private static void FinalizationConvexHull(FerrPoly2Tri.DTSweepContext tcx)
        {
            FerrPoly2Tri.AdvancingFrontNode val_19;
            var val_20;
            FerrPoly2Tri.DelaunayTriangle val_21;
            var val_22;
            FerrPoly2Tri.DelaunayTriangle val_23;
            FerrPoly2Tri.AdvancingFrontNode val_24;
            FerrPoly2Tri.DelaunayTriangle val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            FerrPoly2Tri.AdvancingFront val_31;
            if(tcx.Front.Head.Next != 0)
            {
                    val_19 = tcx.Front.Head.Next.Next;
            }
            else
            {
                    val_19 = 0;
            }
            
            FerrPoly2Tri.DTSweep.TurnAdvancingFrontConvex(tcx:  tcx, b:  tcx.Front.Head.Next, c:  0);
            if(tcx.Front.Tail.Prev != 0)
            {
                    val_20 = tcx.Front.Tail.Prev;
                val_21 = tcx.Front.Tail.Prev.Triangle;
            }
            else
            {
                    val_20 = 28;
                val_21 = 52;
            }
            
            if((val_21.Contains(p:  tcx.Front.Tail.Prev.Next.Point)) != false)
            {
                    if((val_20.Contains(p:  tcx.Front.Tail.Prev.Prev.Point)) != false)
            {
                    FerrPoly2Tri.DelaunayTriangle val_3 = 52.NeighborAcrossFrom(point:  tcx.Front.Tail.Prev.Point);
                FerrPoly2Tri.TriangulationPoint val_4 = 52.OppositePoint(t:  52, p:  tcx.Front.Tail.Prev.Point);
                FerrPoly2Tri.DTSweep.RotateTrianglePair(t:  52, p:  tcx.Front.Tail.Prev.Point, ot:  52, op:  52);
                tcx.MapTriangleToNodes(t:  52);
                tcx.MapTriangleToNodes(t:  52);
            }
            
            }
            
            if(tcx.Front.Head.Next != 0)
            {
                    val_22 = tcx.Front.Head.Next;
                val_23 = tcx.Front.Head.Next.Triangle;
            }
            else
            {
                    val_22 = 28;
                val_23 = 52;
            }
            
            if((val_23.Contains(p:  tcx.Front.Head.Next.Prev.Point)) != false)
            {
                    if((val_22.Contains(p:  tcx.Front.Head.Next.Next.Point)) != false)
            {
                    FerrPoly2Tri.DelaunayTriangle val_7 = 52.NeighborAcrossFrom(point:  tcx.Front.Head.Next.Point);
                FerrPoly2Tri.TriangulationPoint val_8 = 52.OppositePoint(t:  52, p:  tcx.Front.Head.Next.Point);
                FerrPoly2Tri.DTSweep.RotateTrianglePair(t:  52, p:  tcx.Front.Head.Next.Point, ot:  52, op:  52);
                tcx.MapTriangleToNodes(t:  52);
                tcx.MapTriangleToNodes(t:  52);
            }
            
            }
            
            val_24 = tcx.Front.Tail.Prev;
            if(val_24 != 0)
            {
                    val_25 = tcx.Front.Tail.Prev.Triangle;
                val_26 = tcx.Front.Tail.Prev + 28 + -4;
            }
            else
            {
                    val_24 = 28;
                val_25 = 52;
                val_26 = 0;
            }
            
            mem[28] = 0;
            goto label_35;
            label_40:
            val_26 = val_24;
            if(val_25 != 0)
            {
                    FerrPoly2Tri.DelaunayTriangle val_9 = val_25.NeighborCCWFrom(point:  mem[28]);
                val_27 = val_25;
            }
            else
            {
                    FerrPoly2Tri.DelaunayTriangle val_10 = 0.NeighborCCWFrom(point:  mem[28]);
                val_27 = 0;
            }
            
            val_25.Clear();
            val_25 = val_27;
            label_35:
            tcx.RemoveFromList(triangle:  0);
            FerrPoly2Tri.TriangulationPoint val_11 = val_25.PointCCWFrom(point:  mem[28]);
            if(val_25 != tcx.Front.Head.Point)
            {
                goto label_40;
            }
            
            FerrPoly2Tri.TriangulationPoint val_12 = val_25.PointCWFrom(point:  tcx.Front.Head.Point);
            val_28 = val_25;
            if(val_25 != 0)
            {
                    FerrPoly2Tri.DelaunayTriangle val_13 = val_25.NeighborCWFrom(point:  tcx.Front.Head.Point);
                val_29 = val_25;
            }
            else
            {
                    FerrPoly2Tri.DelaunayTriangle val_14 = 0.NeighborCWFrom(point:  tcx.Front.Head.Point);
                val_29 = 0;
            }
            
            val_25.Clear();
            goto label_52;
            label_56:
            tcx.RemoveFromList(triangle:  0);
            if(val_29 != 0)
            {
                    FerrPoly2Tri.TriangulationPoint val_15 = val_29.PointCCWFrom(point:  0);
                val_28 = val_29;
                FerrPoly2Tri.DelaunayTriangle val_16 = val_29.NeighborCCWFrom(point:  0);
                val_30 = val_29;
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_17 = 0.PointCCWFrom(point:  0);
                val_28 = 0;
                FerrPoly2Tri.DelaunayTriangle val_18 = 0.NeighborCCWFrom(point:  0);
                val_30 = 0;
            }
            
            val_29.Clear();
            val_29 = val_30;
            label_52:
            if(val_28 != tcx.Front.Head.Next.Point)
            {
                goto label_56;
            }
            
            val_31 = tcx.Front;
            if(tcx == 0)
            {
                    val_31 = tcx.Front;
            }
            
            tcx.Front.Head = tcx.Front.Head.Next;
            tcx.Front.Head.Prev = 0;
            mem2[0] = tcx.Front.Tail.Prev;
            tcx.Front.Tail.Next = 0;
        }
        private static void TurnAdvancingFrontConvex(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.AdvancingFrontNode b, FerrPoly2Tri.AdvancingFrontNode c)
        {
            FerrPoly2Tri.AdvancingFrontNode val_4;
            FerrPoly2Tri.AdvancingFrontNode val_5;
            FerrPoly2Tri.TriangulationPoint val_6;
            val_4 = c;
            val_5 = b;
            goto label_11;
            label_15:
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_1 = tcx.DTDebugContext;
                tcx.ActiveNode = val_4;
            }
            
            if(val_4 != 0)
            {
                    val_6 = c.Point;
            }
            else
            {
                    val_6 = c.Point;
            }
            
            FerrPoly2Tri.Orientation val_2 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  b.Point, pb:  val_6, pc:  c.Next.Point);
            if(b.Point == 1)
            {
                goto label_7;
            }
            
            if(val_5 == b)
            {
                goto label_10;
            }
            
            FerrPoly2Tri.Orientation val_3 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  b.Prev.Point, pb:  b.Point, pc:  c.Point);
            if(b.Prev.Point != 1)
            {
                goto label_10;
            }
            
            FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  val_5);
            val_5 = b.Prev;
            goto label_11;
            label_10:
            val_5 = val_4;
            goto label_12;
            label_7:
            FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  val_4);
            label_12:
            val_4 = c.Next;
            label_11:
            if(val_4 != tcx.Front.Tail)
            {
                goto label_15;
            }
        
        }
        private static void FinalizationPolygon(FerrPoly2Tri.DTSweepContext tcx)
        {
            label_9:
            FerrPoly2Tri.TriangulationPoint val_4 = tcx.Front.Head.Next.Point;
            int val_1 = tcx.Front.Head.Next.Triangle.IndexOf(p:  val_4);
            val_1 = val_1 + 1;
            val_4 = val_4 + (val_4 >> 31);
            val_4 = val_4 + (val_4 << 1);
            val_4 = val_1 - val_4;
            if(tcx.Front.Head.Next.Triangle.mEdgeIsConstrained.Item[val_4] == true)
            {
                goto label_8;
            }
            
            FerrPoly2Tri.DelaunayTriangle val_3 = tcx.Front.Head.Next.Triangle.NeighborCCWFrom(point:  tcx.Front.Head.Next.Point);
            if(tcx.Front.Head.Next.Triangle != 0)
            {
                goto label_9;
            }
            
            label_8:
            tcx.MeshCleanReq(triangle:  tcx.Front.Head.Next.Triangle);
        }
        private static void FinalizationConstraints(FerrPoly2Tri.DTSweepContext tcx)
        {
            label_7:
            FerrPoly2Tri.TriangulationPoint val_4 = tcx.Front.Head.Point;
            int val_1 = tcx.Front.Head.Triangle.IndexOf(p:  val_4);
            val_1 = val_1 + 1;
            val_4 = val_4 + (val_4 >> 31);
            val_4 = val_4 + (val_4 << 1);
            val_4 = val_1 - val_4;
            if(tcx.Front.Head.Triangle.mEdgeIsConstrained.Item[val_4] == true)
            {
                goto label_6;
            }
            
            FerrPoly2Tri.DelaunayTriangle val_3 = tcx.Front.Head.Triangle.NeighborCCWFrom(point:  tcx.Front.Head.Point);
            if(tcx.Front.Head.Triangle != 0)
            {
                goto label_7;
            }
            
            label_6:
            tcx.MeshCleanReq(triangle:  tcx.Front.Head.Triangle);
        }
        private static FerrPoly2Tri.AdvancingFrontNode PointEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.TriangulationPoint point)
        {
            FerrPoly2Tri.TriangulationPoint val_4;
            FerrPoly2Tri.AdvancingFront val_5;
            FerrPoly2Tri.AdvancingFrontNode val_6;
            var val_7;
            val_4 = point;
            val_5 = tcx.Front;
            val_6 = 0;
            FerrPoly2Tri.AdvancingFrontNode val_1 = val_5.LocateNode(point:  val_4);
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_2 = tcx.DTDebugContext;
                tcx.ActiveNode = val_5;
            }
            
            if(val_5 == 0)
            {
                    return;
            }
            
            FerrPoly2Tri.AdvancingFrontNode val_3 = FerrPoly2Tri.DTSweep.NewFrontTriangle(tcx:  tcx, point:  val_4, node:  val_5);
            val_6 = tcx;
            val_5 = typeof(FerrPoly2Tri.TriangulationPoint).__il2cppRuntimeField_E8;
            val_7 = 536890297;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_7 = 536890297;
            }
            
            var val_4 = mem[536890389];
            val_4 = val_4 + val_4;
            if(mem[536890413] <= 0)
            {
                    FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  val_5);
            }
            
            tcx.Front.AddNode(node:  val_6);
            FerrPoly2Tri.DTSweep.FillAdvancingFront(tcx:  tcx, n:  val_6);
        }
        private static FerrPoly2Tri.AdvancingFrontNode NewFrontTriangle(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.TriangulationPoint point, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.TriangulationPoint val_5;
            if(node != 0)
            {
                    val_5 = node.Point;
            }
            else
            {
                    val_5 = 0;
            }
            
            536885899 = new FerrPoly2Tri.DelaunayTriangle(p1:  point, p2:  0, p3:  node.Next.Point);
            val_1.MarkNeighbor(t:  node.Triangle);
            node.Triangle.Add(item:  536885899);
            FerrPoly2Tri.AdvancingFrontNode val_2 = 536883105;
            val_2 = new FerrPoly2Tri.AdvancingFrontNode(point:  point);
            if(val_2 != 0)
            {
                    mem[536883113] = node + 8;
            }
            else
            {
                    mem[8] = node + 8;
            }
            
            mem[536883117] = node;
            node.Next.Prev = val_2;
            mem2[0] = val_2;
            tcx.Front.AddNode(node:  536883105);
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_3 = tcx.DTDebugContext;
                tcx.ActiveNode = 536883105;
            }
            
            if((FerrPoly2Tri.DTSweep.Legalize(tcx:  tcx, t:  536885899)) == true)
            {
                    return;
            }
            
            tcx.MapTriangleToNodes(t:  536885899);
        }
        private static void EdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.TriangulationPoint val_10;
            FerrPoly2Tri.DelaunayTriangle val_11;
            FerrPoly2Tri.TriangulationPoint val_12;
            tcx.EdgeEvent.ConstrainedEdge = edge;
            FerrPoly2Tri.TriangulationPoint val_1 = edge.P;
            val_10 = edge;
            FerrPoly2Tri.TriangulationPoint val_2 = edge.Q;
            if(tcx.EdgeEvent > 0)
            {
                    0 = 1;
            }
            
            tcx.EdgeEvent.Right = true;
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_3 = tcx.DTDebugContext;
                tcx.PrimaryTriangle = node + 28;
            }
            
            val_11 = mem[node + 28];
            val_11 = node + 28;
            FerrPoly2Tri.TriangulationPoint val_4 = edge.P;
            val_12 = edge;
            FerrPoly2Tri.TriangulationPoint val_5 = edge.Q;
            if((FerrPoly2Tri.DTSweep.IsEdgeSideOfTriangle(triangle:  val_11, ep:  val_12, eq:  edge)) == true)
            {
                    return;
            }
            
            FerrPoly2Tri.DTSweep.FillEdgeEvent(tcx:  tcx, edge:  edge, node:  node);
            FerrPoly2Tri.TriangulationPoint val_7 = edge.P;
            val_10 = edge;
            FerrPoly2Tri.TriangulationPoint val_8 = edge.Q;
            val_11 = mem[node + 28];
            val_11 = node + 28;
            val_12 = edge;
            FerrPoly2Tri.TriangulationPoint val_9 = edge.Q;
            FerrPoly2Tri.DTSweep.EdgeEvent(tcx:  tcx, ep:  val_10, eq:  val_12, triangle:  val_11, point:  edge);
        }
        private static void FillEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            if(tcx.EdgeEvent.Right != false)
            {
                    FerrPoly2Tri.DTSweep.FillRightAboveEdgeEvent(tcx:  tcx, edge:  edge, node:  node);
                return;
            }
            
            FerrPoly2Tri.DTSweep.FillLeftAboveEdgeEvent(tcx:  tcx, edge:  edge, node:  node);
        }
        private static void FillRightConcaveEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.TriangulationPoint val_6;
            FerrPoly2Tri.Point2D val_7;
            FerrPoly2Tri.AdvancingFrontNode val_8;
            label_12:
            if(node != 0)
            {
                    FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  node.Next);
            }
            else
            {
                    FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  node.Next);
            }
            
            val_6 = node.Next.Point;
            FerrPoly2Tri.TriangulationPoint val_1 = edge.P;
            if(val_6 == edge)
            {
                    return;
            }
            
            FerrPoly2Tri.TriangulationPoint val_2 = edge.Q;
            val_7 = edge;
            val_6 = node.Next.Point;
            FerrPoly2Tri.TriangulationPoint val_3 = edge.P;
            FerrPoly2Tri.Orientation val_4 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_7, pb:  val_6, pc:  edge);
            if(val_7 != 1)
            {
                    return;
            }
            
            val_7 = node.Point;
            val_8 = node.Next;
            if(node.Next != 0)
            {
                goto label_9;
            }
            
            val_8 = node.Next;
            if(val_8 == 0)
            {
                goto label_10;
            }
            
            label_9:
            val_6 = node.Next.Point;
            FerrPoly2Tri.Orientation val_5 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_7, pb:  val_6, pc:  node.Next.Next.Point);
            if(val_7 == 1)
            {
                goto label_12;
            }
            
            return;
            label_10:
        }
        private static void FillRightConvexEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.AdvancingFrontNode val_5;
            FerrPoly2Tri.AdvancingFrontNode val_6;
            val_5 = node;
            goto label_0;
            label_13:
            FerrPoly2Tri.TriangulationPoint val_1 = edge.Q;
            FerrPoly2Tri.TriangulationPoint val_2 = edge.P;
            FerrPoly2Tri.Orientation val_3 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  edge, pb:  node.Next.Next.Point, pc:  edge);
            if(edge != 1)
            {
                    return;
            }
            
            val_5 = node.Next;
            label_0:
            val_6 = node.Next.Next;
            if(node.Next.Next != 0)
            {
                goto label_7;
            }
            
            val_6 = node.Next.Next;
            if(val_6 == 0)
            {
                goto label_8;
            }
            
            label_7:
            FerrPoly2Tri.Orientation val_4 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  node.Next.Next.Point, pb:  node.Next.Next.Next.Point, pc:  node.Next.Next.Next.Next.Point);
            if(node.Next.Next.Point != 1)
            {
                goto label_13;
            }
            
            FerrPoly2Tri.DTSweep.FillRightConcaveEdgeEvent(tcx:  tcx, edge:  edge, node:  node.Next.Next);
            return;
            label_8:
        }
        private static void FillRightBelowEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.AdvancingFrontNode val_4;
            goto label_0;
            label_12:
            val_4 = node.Next;
            if(node.Next != 0)
            {
                goto label_1;
            }
            
            val_4 = node.Next;
            if(val_4 == 0)
            {
                goto label_2;
            }
            
            label_1:
            FerrPoly2Tri.Orientation val_1 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  node.Point, pb:  node.Next.Point, pc:  node.Next.Next.Point);
            if(node.Point == 1)
            {
                goto label_4;
            }
            
            FerrPoly2Tri.DTSweep.FillRightConvexEdgeEvent(tcx:  tcx, edge:  edge, node:  node);
            label_0:
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_2 = tcx.DTDebugContext;
                tcx.ActiveNode = node;
            }
            
            FerrPoly2Tri.TriangulationPoint val_3 = edge.P;
            if(edge < 0)
            {
                goto label_12;
            }
            
            return;
            label_4:
            FerrPoly2Tri.DTSweep.FillRightConcaveEdgeEvent(tcx:  tcx, edge:  edge, node:  node);
            return;
            label_2:
        }
        private static void FillRightAboveEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.AdvancingFrontNode val_6 = node;
            goto label_0;
            label_12:
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_1 = tcx.DTDebugContext;
                tcx.ActiveNode = val_6;
            }
            
            FerrPoly2Tri.TriangulationPoint val_2 = edge.Q;
            FerrPoly2Tri.TriangulationPoint val_3 = edge.P;
            FerrPoly2Tri.Orientation val_4 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  edge, pb:  node.Next.Point, pc:  edge);
            if(edge != 1)
            {
                    val_6 = node.Next;
            }
            
            label_0:
            FerrPoly2Tri.TriangulationPoint val_5 = edge.P;
            if(edge < 0)
            {
                goto label_12;
            }
        
        }
        private static void FillLeftConvexEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.AdvancingFrontNode val_5;
            FerrPoly2Tri.AdvancingFrontNode val_6;
            val_5 = node;
            goto label_0;
            label_13:
            FerrPoly2Tri.TriangulationPoint val_1 = edge.Q;
            FerrPoly2Tri.TriangulationPoint val_2 = edge.P;
            FerrPoly2Tri.Orientation val_3 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  edge, pb:  node.Prev.Prev.Point, pc:  edge);
            if(edge != 0)
            {
                    return;
            }
            
            val_5 = node.Prev;
            label_0:
            val_6 = node.Prev.Prev;
            if(node.Prev.Prev != 0)
            {
                goto label_7;
            }
            
            val_6 = node.Prev.Prev;
            if(val_6 == 0)
            {
                goto label_8;
            }
            
            label_7:
            FerrPoly2Tri.Orientation val_4 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  node.Prev.Prev.Point, pb:  node.Prev.Prev.Prev.Point, pc:  node.Prev.Prev.Prev.Prev.Point);
            if(node.Prev.Prev.Point != 0)
            {
                goto label_13;
            }
            
            FerrPoly2Tri.DTSweep.FillLeftConcaveEdgeEvent(tcx:  tcx, edge:  edge, node:  node.Prev.Prev);
            return;
            label_8:
        }
        private static void FillLeftConcaveEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.TriangulationPoint val_6;
            FerrPoly2Tri.Point2D val_7;
            FerrPoly2Tri.AdvancingFrontNode val_8;
            label_12:
            if(node != 0)
            {
                    FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  node.Prev);
            }
            else
            {
                    FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  node.Prev);
            }
            
            val_6 = node.Prev.Point;
            FerrPoly2Tri.TriangulationPoint val_1 = edge.P;
            if(val_6 == edge)
            {
                    return;
            }
            
            FerrPoly2Tri.TriangulationPoint val_2 = edge.Q;
            val_7 = edge;
            val_6 = node.Prev.Point;
            FerrPoly2Tri.TriangulationPoint val_3 = edge.P;
            FerrPoly2Tri.Orientation val_4 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_7, pb:  val_6, pc:  edge);
            if(val_7 != 0)
            {
                    return;
            }
            
            val_7 = node.Point;
            val_8 = node.Prev;
            if(node.Prev != 0)
            {
                goto label_9;
            }
            
            val_8 = node.Prev;
            if(val_8 == 0)
            {
                goto label_10;
            }
            
            label_9:
            val_6 = node.Prev.Point;
            FerrPoly2Tri.Orientation val_5 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_7, pb:  val_6, pc:  node.Prev.Prev.Point);
            if(val_7 == 0)
            {
                goto label_12;
            }
            
            return;
            label_10:
        }
        private static void FillLeftBelowEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.AdvancingFrontNode val_4;
            goto label_0;
            label_12:
            val_4 = node.Prev;
            if(node.Prev != 0)
            {
                goto label_1;
            }
            
            val_4 = node.Prev;
            if(val_4 == 0)
            {
                goto label_2;
            }
            
            label_1:
            FerrPoly2Tri.Orientation val_1 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  node.Point, pb:  node.Prev.Point, pc:  node.Prev.Prev.Point);
            if(node.Point == 0)
            {
                goto label_4;
            }
            
            FerrPoly2Tri.DTSweep.FillLeftConvexEdgeEvent(tcx:  tcx, edge:  edge, node:  node);
            label_0:
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_2 = tcx.DTDebugContext;
                tcx.ActiveNode = node;
            }
            
            FerrPoly2Tri.TriangulationPoint val_3 = edge.P;
            if(edge > 0)
            {
                goto label_12;
            }
            
            return;
            label_4:
            FerrPoly2Tri.DTSweep.FillLeftConcaveEdgeEvent(tcx:  tcx, edge:  edge, node:  node);
            return;
            label_2:
        }
        private static void FillLeftAboveEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DTSweepConstraint edge, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.AdvancingFrontNode val_6 = node;
            goto label_0;
            label_12:
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_1 = tcx.DTDebugContext;
                tcx.ActiveNode = val_6;
            }
            
            FerrPoly2Tri.TriangulationPoint val_2 = edge.Q;
            FerrPoly2Tri.TriangulationPoint val_3 = edge.P;
            FerrPoly2Tri.Orientation val_4 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  edge, pb:  node.Prev.Point, pc:  edge);
            if(edge != 0)
            {
                    val_6 = node.Prev;
            }
            
            label_0:
            FerrPoly2Tri.TriangulationPoint val_5 = edge.P;
            if(edge > 0)
            {
                goto label_12;
            }
        
        }
        private static bool IsEdgeSideOfTriangle(FerrPoly2Tri.DelaunayTriangle triangle, FerrPoly2Tri.TriangulationPoint ep, FerrPoly2Tri.TriangulationPoint eq)
        {
            int val_3;
            var val_4;
            val_3 = 22969398;
            int val_1 = triangle.EdgeIndex(p1:  ep, p2:  eq);
            if(val_1 == 1)
            {
                goto label_2;
            }
            
            val_3 = val_1;
            if(triangle == 0)
            {
                goto label_3;
            }
            
            triangle.mEdgeIsConstrained.set_Item(index:  val_3, value:  true);
            goto label_4;
            label_2:
            val_4 = 0;
            return (bool)val_4;
            label_3:
            32.set_Item(index:  val_3, value:  true);
            label_4:
            FerrPoly2Tri.DelaunayTriangle val_2 = triangle.Neighbors.Item[val_3];
            val_4 = 1;
            return (bool)val_4;
        }
        private static void EdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.TriangulationPoint ep, FerrPoly2Tri.TriangulationPoint eq, FerrPoly2Tri.DelaunayTriangle triangle, FerrPoly2Tri.TriangulationPoint point)
        {
            FerrPoly2Tri.TriangulationPoint val_15;
            FerrPoly2Tri.Point2D val_16;
            FerrPoly2Tri.Point2D val_17;
            FerrPoly2Tri.Point2D val_18;
            FerrPoly2Tri.Point2D val_19;
            FerrPoly2Tri.Point2D val_20;
            val_15 = point;
            val_16 = triangle;
            val_17 = eq;
            val_18 = ep;
            goto label_8;
            label_12:
            FerrPoly2Tri.TriangulationPoint val_1 = val_16.PointCCWFrom(point:  val_15);
            val_19 = val_16;
            FerrPoly2Tri.Orientation val_2 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_17, pb:  val_19, pc:  val_18);
            if(val_17 == 2)
            {
                goto label_3;
            }
            
            FerrPoly2Tri.TriangulationPoint val_3 = val_16.PointCWFrom(point:  val_15);
            val_20 = val_16;
            FerrPoly2Tri.Orientation val_4 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_17, pb:  val_20, pc:  val_18);
            if(val_17 == 2)
            {
                goto label_4;
            }
            
            if(val_17 != val_17)
            {
                goto label_5;
            }
            
            if(val_17 != 0)
            {
                    FerrPoly2Tri.DelaunayTriangle val_5 = val_16.NeighborCWFrom(point:  val_15);
                val_16 = val_16;
            }
            else
            {
                    FerrPoly2Tri.DelaunayTriangle val_6 = val_16.NeighborCCWFrom(point:  val_15);
                val_16 = val_16;
            }
            
            label_8:
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_7 = tcx.DTDebugContext;
                tcx.PrimaryTriangle = val_16;
            }
            
            if((FerrPoly2Tri.DTSweep.IsEdgeSideOfTriangle(triangle:  val_16, ep:  val_18, eq:  val_17)) == false)
            {
                goto label_12;
            }
            
            goto label_13;
            label_4:
            label_3:
            if(((val_16.Contains(p:  val_17)) == false) || ((val_16.Contains(p:  val_20)) == false))
            {
                goto label_17;
            }
            
            val_16.MarkConstrainedEdge(p:  val_17, q:  val_20);
            tcx.EdgeEvent.ConstrainedEdge.Q = val_20;
            FerrPoly2Tri.DelaunayTriangle val_11 = val_16.NeighborAcrossFrom(point:  val_15);
            goto typeof(FerrPoly2Tri.DTSweepContext).__il2cppRuntimeField_FC;
            label_5:
            FerrPoly2Tri.DTSweep.FlipEdgeEvent(tcx:  R5, ep:  R8, eq:  SL, t:  R7, p:  ???);
            label_13:
            var val_12 = FP - 28;
            return;
            label_17:
            22713988 = new FerrPoly2Tri.PointOnEdgeException(message:  22785160, a:  val_18, b:  val_17, c:  val_20);
        }
        private static void FlipEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.TriangulationPoint ep, FerrPoly2Tri.TriangulationPoint eq, FerrPoly2Tri.DelaunayTriangle t, FerrPoly2Tri.TriangulationPoint p)
        {
            FerrPoly2Tri.TriangulationPoint val_19;
            FerrPoly2Tri.DelaunayTriangle val_20;
            FerrPoly2Tri.TriangulationPoint val_21;
            FerrPoly2Tri.DelaunayTriangle val_22;
            FerrPoly2Tri.TriangulationPoint val_23;
            val_19 = p;
            FerrPoly2Tri.DelaunayTriangle val_1 = t.NeighborAcrossFrom(point:  val_19);
            val_20 = t;
            if(t == 0)
            {
                goto label_1;
            }
            
            FerrPoly2Tri.TriangulationPoint val_2 = val_20.OppositePoint(t:  t, p:  val_19);
            if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_3 = tcx.DTDebugContext;
                tcx.PrimaryTriangle = t;
                FerrPoly2Tri.DTSweepDebugContext val_4 = tcx.DTDebugContext;
                tcx.SecondaryTriangle = val_20;
                val_19 = p;
            }
            
            if(t != 0)
            {
                    FerrPoly2Tri.TriangulationPoint val_5 = t.PointCCWFrom(point:  val_19);
                val_21 = t;
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_6 = 0.PointCCWFrom(point:  val_19);
                val_21 = 0;
            }
            
            FerrPoly2Tri.TriangulationPoint val_7 = t.PointCWFrom(point:  val_19);
            val_22 = 0;
            if((FerrPoly2Tri.TriangulationUtil.InScanArea(pa:  val_19, pb:  0, pc:  t, pd:  val_20)) == false)
            {
                goto label_8;
            }
            
            val_22 = val_20;
            FerrPoly2Tri.DTSweep.RotateTrianglePair(t:  t, p:  val_19, ot:  val_20, op:  val_20);
            tcx.MapTriangleToNodes(t:  t);
            tcx.MapTriangleToNodes(t:  val_22);
            val_20 = eq;
            val_23 = ep;
            if(val_20 == val_23)
            {
                goto label_9;
            }
            
            FerrPoly2Tri.Orientation val_9 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_20, pb:  val_20, pc:  val_23);
            val_21 = p;
            FerrPoly2Tri.DelaunayTriangle val_10 = FerrPoly2Tri.DTSweep.NextFlipTriangle(tcx:  tcx, o:  val_20, t:  t, ot:  val_22, p:  p, op:  val_20);
            return;
            label_8:
            val_23 = ep;
            if((FerrPoly2Tri.DTSweep.NextFlipPoint(ep:  val_23, eq:  eq, ot:  val_20, op:  val_20, newP: out  0)) == false)
            {
                    return;
            }
            
            FerrPoly2Tri.DTSweep.FlipScanEdgeEvent(tcx:  tcx, ep:  val_23, eq:  eq, flipTriangle:  t, t:  val_20, p:  val_22);
            FerrPoly2Tri.DTSweep.EdgeEvent(tcx:  tcx, ep:  val_23, eq:  eq, triangle:  t, point:  p);
            return;
            label_9:
            val_20 = mem[tcx + 56 + 8];
            val_20 = tcx + 56 + 8;
            FerrPoly2Tri.TriangulationPoint val_13 = val_20.Q;
            if(val_20 != p)
            {
                    return;
            }
            
            val_20 = mem[tcx + 56 + 8];
            val_20 = tcx + 56 + 8;
            FerrPoly2Tri.TriangulationPoint val_14 = val_20.P;
            if(val_20 != val_23)
            {
                    return;
            }
            
            t.MarkConstrainedEdge(p:  val_23, q:  p);
            val_22.MarkConstrainedEdge(p:  val_23, q:  p);
            bool val_15 = FerrPoly2Tri.DTSweep.Legalize(tcx:  tcx, t:  t);
            bool val_16 = FerrPoly2Tri.DTSweep.Legalize(tcx:  tcx, t:  val_22);
            return;
            label_1:
            FerrPoly2Tri.TriangulationPoint val_17 = val_20.OppositePoint(t:  t, p:  val_19);
            22712548 = new System.InvalidOperationException(message:  22797608);
        }
        private static bool NextFlipPoint(FerrPoly2Tri.TriangulationPoint ep, FerrPoly2Tri.TriangulationPoint eq, FerrPoly2Tri.DelaunayTriangle ot, FerrPoly2Tri.TriangulationPoint op, out FerrPoly2Tri.TriangulationPoint newP)
        {
            FerrPoly2Tri.TriangulationPoint val_5;
            FerrPoly2Tri.DelaunayTriangle val_6;
            val_5 = 0;
            newP = val_5;
            FerrPoly2Tri.Orientation val_1 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  eq, pb:  op, pc:  ep);
            if(eq == 2)
            {
                    return (bool)val_5;
            }
            
            if(eq == 1)
            {
                goto label_1;
            }
            
            if(eq != 0)
            {
                goto label_2;
            }
            
            val_6 = ot;
            FerrPoly2Tri.TriangulationPoint val_2 = val_6.PointCCWFrom(point:  op);
            goto label_4;
            label_1:
            val_6 = ot;
            FerrPoly2Tri.TriangulationPoint val_3 = val_6.PointCWFrom(point:  op);
            label_4:
            newP = val_6;
            val_5 = 1;
            return (bool)val_5;
            label_2:
            22713472 = new System.NotImplementedException(message:  22791224);
        }
        private static FerrPoly2Tri.DelaunayTriangle NextFlipTriangle(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.Orientation o, FerrPoly2Tri.DelaunayTriangle t, FerrPoly2Tri.DelaunayTriangle ot, FerrPoly2Tri.TriangulationPoint p, FerrPoly2Tri.TriangulationPoint op)
        {
            FerrPoly2Tri.DelaunayTriangle val_7;
            int val_8;
            FerrPoly2Tri.FixedBitArray3 val_9;
            val_7 = t;
            if(o != 1)
            {
                goto label_0;
            }
            
            if(ot == 0)
            {
                goto label_1;
            }
            
            val_8 = ot.EdgeIndex(p1:  p, p2:  op);
            goto label_2;
            label_0:
            if(val_7 == 0)
            {
                goto label_3;
            }
            
            val_8 = val_7.EdgeIndex(p1:  p, p2:  op);
            goto label_4;
            label_1:
            val_8 = 0.EdgeIndex(p1:  p, p2:  op);
            label_2:
            val_9 = ot.EdgeIsDelaunay;
            val_9.set_Item(index:  val_8, value:  true);
            bool val_4 = FerrPoly2Tri.DTSweep.Legalize(tcx:  tcx, t:  ot);
            val_9.Clear();
            return;
            label_3:
            val_8 = 0.EdgeIndex(p1:  p, p2:  op);
            label_4:
            val_9 = t.EdgeIsDelaunay;
            val_9.set_Item(index:  val_8, value:  true);
            bool val_6 = FerrPoly2Tri.DTSweep.Legalize(tcx:  tcx, t:  val_7);
            val_9.Clear();
            val_7 = ot;
        }
        private static void FlipScanEdgeEvent(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.TriangulationPoint ep, FerrPoly2Tri.TriangulationPoint eq, FerrPoly2Tri.DelaunayTriangle flipTriangle, FerrPoly2Tri.DelaunayTriangle t, FerrPoly2Tri.TriangulationPoint p)
        {
            var val_13;
            FerrPoly2Tri.DelaunayTriangle val_1 = t.NeighborAcrossFrom(point:  p);
            if(t != 0)
            {
                    FerrPoly2Tri.TriangulationPoint val_2 = t.OppositePoint(t:  t, p:  p);
                if(tcx != 0)
            {
                    FerrPoly2Tri.DTSweepDebugContext val_3 = tcx.DTDebugContext;
                tcx.PrimaryTriangle = t;
                FerrPoly2Tri.DTSweepDebugContext val_4 = tcx.DTDebugContext;
                tcx.SecondaryTriangle = t;
            }
            
                if(flipTriangle != 0)
            {
                    FerrPoly2Tri.TriangulationPoint val_5 = flipTriangle.PointCCWFrom(point:  eq);
                val_13 = flipTriangle;
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_6 = 0.PointCCWFrom(point:  eq);
                val_13 = 0;
            }
            
                FerrPoly2Tri.TriangulationPoint val_7 = flipTriangle.PointCWFrom(point:  eq);
                if((FerrPoly2Tri.TriangulationUtil.InScanArea(pa:  eq, pb:  0, pc:  flipTriangle, pd:  t)) != false)
            {
                    FerrPoly2Tri.DTSweep.FlipEdgeEvent(tcx:  tcx, ep:  eq, eq:  t, t:  t, p:  t);
                return;
            }
            
                if((FerrPoly2Tri.DTSweep.NextFlipPoint(ep:  ep, eq:  eq, ot:  t, op:  t, newP: out  0)) == false)
            {
                    return;
            }
            
                return;
            }
            
            FerrPoly2Tri.TriangulationPoint val_11 = t.OppositePoint(t:  t, p:  p);
            22710780 = new System.Exception(message:  22797608);
        }
        private static void FillAdvancingFront(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.AdvancingFrontNode n)
        {
            var val_9;
            FerrPoly2Tri.AdvancingFrontNode val_10;
            FerrPoly2Tri.AdvancingFrontNode val_11;
            val_9 = n.Next;
            goto label_1;
            label_6:
            double val_1 = FerrPoly2Tri.DTSweep.HoleAngle(node:  R6);
            if((n > 0) || (n < 0))
            {
                goto label_3;
            }
            
            FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  R6);
            val_9 = R6 + 8;
            label_1:
            if(val_9.HasNext == true)
            {
                goto label_6;
            }
            
            label_3:
            val_10 = n;
            if(n != 0)
            {
                goto label_11;
            }
            
            val_10 = n;
            goto label_11;
            label_13:
            double val_3 = FerrPoly2Tri.DTSweep.HoleAngle(node:  val_10);
            if((n > 0) || (n < 0))
            {
                goto label_10;
            }
            
            FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  val_10);
            label_11:
            val_11 = n.Prev;
            if(val_11.HasPrev == true)
            {
                goto label_13;
            }
            
            label_10:
            if(n.HasNext == false)
            {
                    return;
            }
            
            val_11 = mem[n.Next];
            bool val_6 = val_11.HasNext;
            if(val_6 == false)
            {
                    return;
            }
            
            double val_7 = FerrPoly2Tri.DTSweep.BasinAngle(node:  n);
            if(val_6 >= 0)
            {
                    return;
            }
            
            FerrPoly2Tri.DTSweep.FillBasin(tcx:  tcx, node:  n);
        }
        private static void FillBasin(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.TriangulationPoint val_4;
            FerrPoly2Tri.AdvancingFrontNode val_5;
            FerrPoly2Tri.AdvancingFrontNode val_6;
            FerrPoly2Tri.AdvancingFrontNode val_7;
            FerrPoly2Tri.DTSweepBasin val_8;
            FerrPoly2Tri.DTSweepBasin val_9;
            if(node != 0)
            {
                    val_4 = node.Point;
            }
            else
            {
                    val_4 = 0;
            }
            
            val_5 = node.Next;
            if(node.Next != 0)
            {
                goto label_2;
            }
            
            val_5 = node.Next;
            if(val_5 == 0)
            {
                goto label_43;
            }
            
            label_2:
            FerrPoly2Tri.Orientation val_1 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  0, pb:  node.Next.Point, pc:  node.Next.Next.Point);
            val_6 = val_4;
            if(val_6 != 1)
            {
                    node = node.Next;
            }
            
            tcx.Basin.leftNode = node;
            if(tcx.Basin != 0)
            {
                    val_7 = tcx.Basin.leftNode;
            }
            else
            {
                    val_7 = tcx.Basin.leftNode;
            }
            
            tcx.Basin.bottomNode = val_7;
            goto label_9;
            label_22:
            val_7 = typeof(FerrPoly2Tri.TriangulationPoint).__il2cppRuntimeField_F8;
            val_6 = tcx.Basin.bottomNode.Next;
            if(tcx.Basin.bottomNode.Next.Point < 0)
            {
                goto label_17;
            }
            
            val_7 = tcx.Basin.bottomNode;
            mem2[0] = tcx.Basin.bottomNode.Next;
            label_9:
            if(tcx.Basin.bottomNode.HasNext == true)
            {
                goto label_22;
            }
            
            label_17:
            val_8 = tcx.Basin;
            if(tcx.Basin != 0)
            {
                goto label_23;
            }
            
            val_8 = tcx.Basin;
            if(val_8 == 0)
            {
                goto label_43;
            }
            
            label_23:
            if(tcx.Basin.bottomNode == tcx.Basin.leftNode)
            {
                    return;
            }
            
            if(tcx.Basin != 0)
            {
                    val_7 = tcx.Basin.bottomNode;
            }
            else
            {
                    val_7 = tcx.Basin.bottomNode;
            }
            
            tcx.Basin.rightNode = val_7;
            goto label_28;
            label_41:
            val_7 = typeof(FerrPoly2Tri.TriangulationPoint).__il2cppRuntimeField_F8;
            val_6 = tcx.Basin.rightNode.Next;
            if(tcx.Basin.rightNode.Next.Point >= 0)
            {
                goto label_36;
            }
            
            val_7 = tcx.Basin.rightNode;
            mem2[0] = tcx.Basin.rightNode.Next;
            label_28:
            if(tcx.Basin.rightNode.HasNext == true)
            {
                goto label_41;
            }
            
            label_36:
            val_9 = tcx.Basin;
            if(tcx.Basin != 0)
            {
                goto label_42;
            }
            
            val_9 = tcx.Basin;
            if(val_9 == 0)
            {
                goto label_43;
            }
            
            label_42:
            if(tcx.Basin.rightNode == tcx.Basin.bottomNode)
            {
                    return;
            }
            
            FerrPoly2Tri.TriangulationPoint val_4 = tcx.Basin.leftNode.Point;
            val_4 = tcx.Basin.rightNode.Point - val_4;
            tcx.Basin.width = val_4;
            if(tcx.Basin.rightNode.Point > 0)
            {
                    0 = 1;
            }
            
            tcx.Basin.leftHighest = true;
            FerrPoly2Tri.DTSweep.FillBasinReq(tcx:  tcx, node:  tcx.Basin.bottomNode);
            return;
            label_43:
        }
        private static void FillBasinReq(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.AdvancingFrontNode node)
        {
            var val_4;
            FerrPoly2Tri.DTSweepBasin val_5;
            FerrPoly2Tri.Point2D val_6;
            var val_7;
            var val_8;
            goto label_0;
            label_25:
            FerrPoly2Tri.DTSweep.Fill(tcx:  tcx, node:  node);
            val_4 = node;
            if(node.Prev == tcx.Basin.leftNode)
            {
                    val_5 = tcx.Basin;
                if(node.Next == tcx.Basin.rightNode)
            {
                    return;
            }
            
            }
            
            if((node + 12) == tcx.Basin.leftNode)
            {
                goto label_8;
            }
            
            val_6 = node;
            if(node.Next == tcx.Basin.rightNode)
            {
                goto label_10;
            }
            
            val_5 = node + 12 + 24 + 248;
            if((node + 8 + 24) >= 0)
            {
                    val_4 = node + 8;
            }
            
            goto label_19;
            label_8:
            val_4 = node;
            val_6 = mem[node + 8 + 16];
            val_6 = node + 8 + 16;
            val_7 = node.Next;
            if(node.Next != 0)
            {
                goto label_16;
            }
            
            val_7 = mem[node + 8];
            val_7 = node + 8;
            if(val_7 == 0)
            {
                goto label_22;
            }
            
            label_16:
            val_5 = node.Next.Point;
            FerrPoly2Tri.Orientation val_1 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_6, pb:  val_5, pc:  node + 8 + 8 + 24);
            if(val_6 != 0)
            {
                goto label_19;
            }
            
            return;
            label_10:
            val_6 = node.Point;
            val_8 = node.Prev;
            if(node.Prev != 0)
            {
                goto label_21;
            }
            
            val_8 = mem[node + 12];
            val_8 = node + 12;
            if(val_8 == 0)
            {
                goto label_22;
            }
            
            label_21:
            val_5 = node.Prev.Point;
            FerrPoly2Tri.Orientation val_2 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_6, pb:  val_5, pc:  node + 12 + 12 + 24);
            if(val_6 == 1)
            {
                    return;
            }
            
            label_19:
            label_0:
            if((FerrPoly2Tri.DTSweep.IsShallow(tcx:  tcx, node:  node + 12)) == false)
            {
                goto label_25;
            }
            
            return;
            label_22:
        }
        private static bool IsShallow(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.DTSweepBasin val_1;
            FerrPoly2Tri.AdvancingFrontNode val_2;
            val_1 = tcx.Basin;
            if(val_1 == 0)
            {
                goto label_1;
            }
            
            if(tcx.Basin.leftHighest == false)
            {
                goto label_2;
            }
            
            label_5:
            val_2 = tcx.Basin.leftNode;
            goto label_3;
            label_1:
            if(tcx.Basin == 0)
            {
                goto label_4;
            }
            
            val_1 = tcx.Basin;
            if(tcx.Basin.leftHighest == true)
            {
                goto label_5;
            }
            
            label_2:
            val_2 = tcx.Basin.rightNode;
            label_3:
            FerrPoly2Tri.TriangulationPoint val_1 = tcx.Basin.rightNode.Point;
            val_1 = val_1 - node.Point;
            if(tcx.Basin > 0)
            {
                    0 = 1;
            }
            
            return true;
            label_4:
        }
        private static double HoleAngle(FerrPoly2Tri.AdvancingFrontNode node)
        {
            bool val_2;
            FerrPoly2Tri.TriangulationPoint val_2 = node.Next.Point;
            FerrPoly2Tri.TriangulationPoint val_3 = node.Next.Point;
            FerrPoly2Tri.TriangulationPoint val_4 = node.Point;
            FerrPoly2Tri.TriangulationPoint val_5 = node.Point;
            val_2 = val_2 - val_4;
            val_3 = val_3 - val_5;
            val_4 = node.Prev.Point - val_4;
            FerrPoly2Tri.TriangulationPoint val_6 = node.Prev.Point;
            val_5 = val_6 - val_5;
            val_2 = mem[536890482];
            if((val_2 & true) == 0)
            {
                    val_2 = mem[536890411];
            }
            
            val_6 = val_2 * val_5;
            FerrPoly2Tri.TriangulationPoint val_1 = val_3 * val_5;
        }
        private static double BasinAngle(FerrPoly2Tri.AdvancingFrontNode node)
        {
            bool val_2;
            FerrPoly2Tri.TriangulationPoint val_2 = node.Point;
            val_2 = val_2 - node.Next.Next.Point;
            val_2 = mem[536890482];
            if((val_2 & true) == 0)
            {
                    val_2 = mem[536890411];
            }
            
            FerrPoly2Tri.TriangulationPoint val_1 = node.Point - node.Next.Next.Point;
        }
        private static void Fill(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.AdvancingFrontNode node)
        {
            FerrPoly2Tri.DelaunayTriangle val_3;
            FerrPoly2Tri.DelaunayTriangle val_1 = 536885899;
            val_1 = new FerrPoly2Tri.DelaunayTriangle(p1:  node.Prev.Point, p2:  node.Point, p3:  node.Next.Point);
            if(val_1 != 0)
            {
                    val_1.MarkNeighbor(t:  node.Prev.Triangle);
                val_3 = node.Triangle;
            }
            else
            {
                    val_1.MarkNeighbor(t:  node.Prev.Triangle);
                val_3 = node.Triangle;
            }
            
            val_1.MarkNeighbor(t:  val_3);
            val_3.Add(item:  536885899);
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
            tcx.Front.RemoveNode(node:  node);
            if((FerrPoly2Tri.DTSweep.Legalize(tcx:  tcx, t:  536885899)) != false)
            {
                    return;
            }
            
            tcx.MapTriangleToNodes(t:  536885899);
        }
        private static bool Legalize(FerrPoly2Tri.DTSweepContext tcx, FerrPoly2Tri.DelaunayTriangle t)
        {
            int val_15;
            label_13:
            if(t.EdgeIsDelaunay.Item[0] == true)
            {
                goto label_9;
            }
            
            FerrPoly2Tri.TriangulationPoint val_2 = t.Neighbors.Item[0];
            if(t.Neighbors == 0)
            {
                goto label_9;
            }
            
            FerrPoly2Tri.TriangulationPoint val_3 = t.Points.Item[0];
            FerrPoly2Tri.TriangulationPoint val_4 = t.Neighbors.OppositePoint(t:  t, p:  t.Points);
            int val_5 = t.Neighbors.IndexOf(p:  t.Neighbors);
            val_15 = t.Neighbors;
            if((t.Neighbors + 32.Item[val_5]) == true)
            {
                goto label_6;
            }
            
            FerrPoly2Tri.FixedArray3<FerrPoly2Tri.DelaunayTriangle> val_7 = t.Neighbors + 35;
            if(val_7.Item[val_5] == false)
            {
                goto label_7;
            }
            
            label_6:
            t.mEdgeIsConstrained.set_Item(index:  t.IndexOf(p:  t.Points), value:  t.Neighbors + 32.Item[val_5]);
            goto label_9;
            label_7:
            val_15 = val_5;
            if(t != 0)
            {
                    FerrPoly2Tri.TriangulationPoint val_11 = t.PointCCWFrom(point:  t.Points);
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_12 = 0.PointCCWFrom(point:  t.Points);
            }
            
            FerrPoly2Tri.TriangulationPoint val_13 = t.PointCWFrom(point:  t.Points);
            if((FerrPoly2Tri.TriangulationUtil.SmartIncircle(pa:  t.Points, pb:  0, pc:  t, pd:  t.Neighbors)) == true)
            {
                goto label_12;
            }
            
            label_9:
            var val_15 = 0 + 1;
            if(0 < 2)
            {
                goto label_13;
            }
            
            return false;
            label_12:
            t.EdgeIsDelaunay.set_Item(index:  0, value:  true);
            val_7.set_Item(index:  val_15, value:  true);
            FerrPoly2Tri.DTSweep.RotateTrianglePair(t:  t, p:  t.Points, ot:  t.Neighbors, op:  t.Neighbors);
            if(tcx == 0)
            {
                    tcx.MapTriangleToNodes(t:  t);
            }
            
            if(tcx == 0)
            {
                    tcx.MapTriangleToNodes(t:  t.Neighbors);
            }
            
            t.EdgeIsDelaunay.set_Item(index:  0, value:  false);
            val_7.set_Item(index:  val_15, value:  false);
            return false;
        }
        private static void RotateTrianglePair(FerrPoly2Tri.DelaunayTriangle t, FerrPoly2Tri.TriangulationPoint p, FerrPoly2Tri.DelaunayTriangle ot, FerrPoly2Tri.TriangulationPoint op)
        {
            if(t != 0)
            {
                    FerrPoly2Tri.DelaunayTriangle val_1 = t.NeighborCCWFrom(point:  p);
            }
            else
            {
                    FerrPoly2Tri.DelaunayTriangle val_2 = 0.NeighborCCWFrom(point:  p);
            }
            
            FerrPoly2Tri.DelaunayTriangle val_3 = t.NeighborCWFrom(point:  p);
            if(ot != 0)
            {
                    FerrPoly2Tri.DelaunayTriangle val_4 = ot.NeighborCCWFrom(point:  op);
            }
            else
            {
                    FerrPoly2Tri.DelaunayTriangle val_5 = 0.NeighborCCWFrom(point:  op);
            }
            
            FerrPoly2Tri.DelaunayTriangle val_6 = ot.NeighborCWFrom(point:  op);
            FerrPoly2Tri.TriangulationPoint val_33 = p;
            int val_7 = t.IndexOf(p:  val_33);
            val_7 = val_7 + 2;
            val_33 = val_33 + (val_33 >> 31);
            val_33 = val_33 + (val_33 << 1);
            val_33 = val_7 - val_33;
            FerrPoly2Tri.TriangulationPoint val_34 = p;
            int val_9 = t.IndexOf(p:  val_34);
            val_9 = val_9 + 1;
            val_34 = val_34 + (val_34 >> 31);
            val_34 = val_34 + (val_34 << 1);
            val_34 = val_9 - val_34;
            FerrPoly2Tri.TriangulationPoint val_35 = op;
            int val_11 = ot.IndexOf(p:  val_35);
            val_11 = val_11 + 2;
            val_35 = val_35 + (val_35 >> 31);
            val_35 = val_35 + (val_35 << 1);
            val_35 = val_11 - val_35;
            FerrPoly2Tri.TriangulationPoint val_36 = op;
            int val_13 = ot.IndexOf(p:  val_36);
            val_13 = val_13 + 1;
            val_36 = val_36 + (val_36 >> 31);
            val_36 = val_36 + (val_36 << 1);
            val_36 = val_13 - val_36;
            bool val_14 = ot + 32.Item[val_36];
            FerrPoly2Tri.TriangulationPoint val_37 = p;
            int val_15 = t.IndexOf(p:  val_37);
            val_15 = val_15 + 2;
            val_37 = val_37 + (val_37 >> 31);
            val_37 = val_37 + (val_37 << 1);
            val_37 = val_15 - val_37;
            FerrPoly2Tri.TriangulationPoint val_38 = p;
            int val_17 = t.IndexOf(p:  val_38);
            val_17 = val_17 + 1;
            val_38 = val_38 + (val_38 >> 31);
            val_38 = val_38 + (val_38 << 1);
            val_38 = val_17 - val_38;
            FerrPoly2Tri.TriangulationPoint val_39 = op;
            int val_19 = ot.IndexOf(p:  val_39);
            val_19 = val_19 + 2;
            val_39 = val_39 + (val_39 >> 31);
            val_39 = val_39 + (val_39 << 1);
            val_39 = val_19 - val_39;
            FerrPoly2Tri.TriangulationPoint val_40 = op;
            int val_21 = ot.IndexOf(p:  val_40);
            val_21 = val_21 + 1;
            val_40 = val_40 + (val_40 >> 31);
            val_40 = val_40 + (val_40 << 1);
            val_40 = val_21 - val_40;
            bool val_22 = ot.EdgeIsDelaunay.Item[val_40];
            t.Legalize(oPoint:  p, nPoint:  op);
            if(ot != 0)
            {
                    ot.Legalize(oPoint:  op, nPoint:  p);
            }
            else
            {
                    0.Legalize(oPoint:  op, nPoint:  p);
            }
            
            FerrPoly2Tri.TriangulationPoint val_41 = p;
            int val_23 = ot.IndexOf(p:  val_41);
            val_23 = val_23 + 2;
            val_41 = val_41 + (val_41 >> 31);
            val_41 = val_41 + (val_41 << 1);
            val_41 = val_23 - val_41;
            ot.EdgeIsDelaunay.set_Item(index:  val_41, value:  t.EdgeIsDelaunay.Item[val_37]);
            FerrPoly2Tri.TriangulationPoint val_42 = p;
            int val_24 = t.IndexOf(p:  val_42);
            val_24 = val_24 + 1;
            val_42 = val_42 + (val_42 >> 31);
            val_42 = val_42 + (val_42 << 1);
            val_42 = val_24 - val_42;
            t.EdgeIsDelaunay.set_Item(index:  val_42, value:  t.EdgeIsDelaunay.Item[val_38]);
            FerrPoly2Tri.TriangulationPoint val_43 = op;
            int val_25 = t.IndexOf(p:  val_43);
            val_25 = val_25 + 2;
            val_43 = val_43 + (val_43 >> 31);
            val_43 = val_43 + (val_43 << 1);
            val_43 = val_25 - val_43;
            t.EdgeIsDelaunay.set_Item(index:  val_43, value:  ot.EdgeIsDelaunay.Item[val_39]);
            if(ot != 0)
            {
                    FerrPoly2Tri.TriangulationPoint val_44 = op;
                int val_26 = ot.IndexOf(p:  val_44);
                val_26 = val_26 + 1;
                val_44 = val_44 + (val_44 >> 31);
                val_44 = val_44 + (val_44 << 1);
                val_44 = val_26 - val_44;
                ot.EdgeIsDelaunay.set_Item(index:  val_44, value:  val_22);
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_45 = op;
                int val_27 = 0.IndexOf(p:  val_45);
                val_27 = val_27 + 1;
                val_45 = val_45 + (val_45 >> 31);
                val_45 = val_45 + (val_45 << 1);
                val_45 = val_27 - val_45;
                ot.EdgeIsDelaunay.set_Item(index:  val_45, value:  val_22);
            }
            
            FerrPoly2Tri.TriangulationPoint val_46 = p;
            int val_28 = ot.IndexOf(p:  val_46);
            val_28 = val_28 + 2;
            val_46 = val_46 + (val_46 >> 31);
            val_46 = val_46 + (val_46 << 1);
            val_46 = val_28 - val_46;
            ot + 32.set_Item(index:  val_46, value:  t.mEdgeIsConstrained.Item[val_33]);
            FerrPoly2Tri.TriangulationPoint val_47 = p;
            int val_29 = t.IndexOf(p:  val_47);
            val_29 = val_29 + 1;
            val_47 = val_47 + (val_47 >> 31);
            val_47 = val_47 + (val_47 << 1);
            val_47 = val_29 - val_47;
            t + 32.set_Item(index:  val_47, value:  t + 32.Item[val_34]);
            FerrPoly2Tri.TriangulationPoint val_48 = op;
            int val_30 = t.IndexOf(p:  val_48);
            val_30 = val_30 + 2;
            val_48 = val_48 + (val_48 >> 31);
            val_48 = val_48 + (val_48 << 1);
            val_48 = val_30 - val_48;
            t + 32.set_Item(index:  val_48, value:  ot.mEdgeIsConstrained.Item[val_35]);
            if(ot != 0)
            {
                    FerrPoly2Tri.TriangulationPoint val_49 = op;
                int val_31 = ot.IndexOf(p:  val_49);
                val_31 = val_31 + 1;
                val_49 = val_49 + (val_49 >> 31);
                val_49 = val_49 + (val_49 << 1);
                val_49 = val_31 - val_49;
                ot + 32.set_Item(index:  val_49, value:  val_14);
                t.Neighbors.Clear();
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_50 = op;
                int val_32 = 0.IndexOf(p:  val_50);
                val_32 = val_32 + 1;
                val_50 = val_50 + (val_50 >> 31);
                val_50 = val_50 + (val_50 << 1);
                val_50 = val_32 - val_50;
                ot + 32.set_Item(index:  val_50, value:  val_14);
                t.Neighbors.Clear();
            }
            
            ot.Neighbors.Clear();
            if(0 != 0)
            {
                    ot.MarkNeighbor(t:  0);
            }
            
            if(t != 0)
            {
                    ot = t;
                ot.MarkNeighbor(t:  t);
            }
            
            if(0 != 0)
            {
                    ot = t;
                t = 0;
                ot.MarkNeighbor(t:  0);
            }
            
            if(ot != 0)
            {
                    ot.MarkNeighbor(t:  ot);
            }
            
            t.MarkNeighbor(t:  ot);
        }
    
    }

}
