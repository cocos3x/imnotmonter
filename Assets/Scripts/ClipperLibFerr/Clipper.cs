using UnityEngine;

namespace ClipperLibFerr
{
    public class Clipper : ClipperBase
    {
        // Fields
        public const int ioReverseSolution = 1;
        public const int ioStrictlySimple = 2;
        public const int ioPreserveCollinear = 4;
        private ClipperLibFerr.ClipType m_ClipType;
        private ClipperLibFerr.Maxima m_Maxima;
        private ClipperLibFerr.TEdge m_SortedEdges;
        private System.Collections.Generic.List<ClipperLibFerr.IntersectNode> m_IntersectList;
        private System.Collections.Generic.IComparer<ClipperLibFerr.IntersectNode> m_IntersectNodeComparer;
        private bool m_ExecuteLocked;
        private ClipperLibFerr.PolyFillType m_ClipFillType;
        private ClipperLibFerr.PolyFillType m_SubjFillType;
        private System.Collections.Generic.List<ClipperLibFerr.Join> m_Joins;
        private System.Collections.Generic.List<ClipperLibFerr.Join> m_GhostJoins;
        private bool m_UsingPolyTree;
        private bool <ReverseSolution>k__BackingField;
        private bool <StrictlySimple>k__BackingField;
        
        // Properties
        public bool ReverseSolution { get; set; }
        public bool StrictlySimple { get; set; }
        
        // Methods
        public Clipper(int InitOptions = 0)
        {
            mem[1152921510273161028] = 0;
            this.m_Maxima = 0;
            mem[1152921510273161036] = 0;
            this.m_SortedEdges = 0;
            536878011 = new System.Collections.Generic.List<Page>();
            mem[1152921510273161056] = 536878011;
            ClipperLibFerr.MyIntersectNodeSort val_2 = 536890885;
            val_2 = new ClipperLibFerr.MyIntersectNodeSort();
            mem[1152921510273161060] = val_2;
            mem[1152921510273161084] = 0;
            mem[1152921510273161064] = 0;
            536878117 = new System.Collections.Generic.List<Page>();
            mem[1152921510273161032] = 536878117;
            System.Collections.Generic.List<Page> val_4 = 536878025;
            val_4 = new System.Collections.Generic.List<Page>();
            mem[1152921510273161076] = val_4;
            System.Collections.Generic.List<Page> val_5 = 536878025;
            val_5 = new System.Collections.Generic.List<Page>();
            mem[1152921510273161080] = val_5;
            mem[1152921510273161086] = (uint)(((int)InitOptions & 255) >> 1) & 1;
            mem[1152921510273161085] = InitOptions & 1;
            mem[1152921510273161042] = (uint)(((int)InitOptions & 255) >> 2) & 1;
        }
        private void InsertMaxima(long X)
        {
            var val_4;
            var val_5;
            ClipperLibFerr.Maxima val_6;
            ClipperLibFerr.Maxima val_7;
            var val_8;
            ClipperLibFerr.Maxima val_9;
            val_4 = R3;
            val_5 = R2;
            ClipperLibFerr.Maxima val_1 = 536890361;
            var val_4 = 0;
            val_6 = val_1;
            val_1 = new ClipperLibFerr.Maxima();
            mem[536890369] = val_5;
            val_7 = this.m_Maxima;
            if(val_7 == 0)
            {
                goto label_2;
            }
            
            long val_2 = this.m_Maxima.X;
            val_2 = val_5 - val_2;
            if(val_7 >= 0)
            {
                goto label_6;
            }
            
            mem[536890377] = val_7;
            mem[536890381] = 0;
            this.m_Maxima = val_6;
            goto label_4;
            label_6:
            val_8 = val_7;
            val_9 = this.m_Maxima.Next;
            if(val_9 == 0)
            {
                goto label_5;
            }
            
            long val_3 = this.m_Maxima.Next.X;
            val_3 = val_5 - val_3;
            if(val_9 >= 0)
            {
                goto label_6;
            }
            
            label_5:
            long val_5 = this.m_Maxima.X;
            val_4 = val_4 ^ val_4;
            val_5 = val_5 ^ val_5;
            if(val_9 != 0)
            {
                goto label_7;
            }
            
            return;
            label_2:
            this.m_Maxima = val_6;
            mem[536890377] = 0;
            mem[536890381] = 0;
            label_7:
            if(R4 != 0)
            {
                    mem2[0] = ???;
            }
            else
            {
                    mem[16] = ???;
            }
            
            mem2[0] = ???;
            val_7 = R5 + 16;
            if((R5 + 16) != 0)
            {
                    mem2[0] = ???;
            }
            
            mem2[0] = ???;
            label_4:
        }
        public bool get_ReverseSolution()
        {
            return (bool)this.<ReverseSolution>k__BackingField;
        }
        public void set_ReverseSolution(bool value)
        {
            this.<ReverseSolution>k__BackingField = value;
        }
        public bool get_StrictlySimple()
        {
            return (bool)this.<StrictlySimple>k__BackingField;
        }
        public void set_StrictlySimple(bool value)
        {
            this.<StrictlySimple>k__BackingField = value;
        }
        public bool Execute(ClipperLibFerr.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> solution, ClipperLibFerr.PolyFillType FillType = 0)
        {
            return (bool)this.Execute(clipType:  clipType, solution:  solution, subjFillType:  FillType, clipFillType:  FillType);
        }
        public bool Execute(ClipperLibFerr.ClipType clipType, ClipperLibFerr.PolyTree polytree, ClipperLibFerr.PolyFillType FillType = 0)
        {
            return (bool)this.Execute(clipType:  clipType, polytree:  polytree, subjFillType:  FillType, clipFillType:  FillType);
        }
        public bool Execute(ClipperLibFerr.ClipType clipType, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> solution, ClipperLibFerr.PolyFillType subjFillType, ClipperLibFerr.PolyFillType clipFillType)
        {
            ClipperLibFerr.ClipType val_3;
            var val_4;
            val_3 = clipType;
            val_4 = 0;
            if(this.m_ExecuteLocked == true)
            {
                    return (bool)val_4;
            }
            
            if(this.m_ExecuteLocked != true)
            {
                    this.m_ExecuteLocked = true;
                solution.Clear();
                this.m_ClipFillType = clipFillType;
                this.m_SubjFillType = subjFillType;
                this.m_ClipType = val_3;
                val_3 = false;
                this.m_UsingPolyTree = val_3;
                bool val_1 = this.ExecuteInternal();
                val_4 = val_1;
                if(val_1 != false)
            {
                    this.BuildResult(polyg:  solution);
            }
            
                this.DisposeAllPolyPts();
                this.m_ExecuteLocked = false;
                return (bool)val_4;
            }
            
            22709868 = new ClipperLibFerr.ClipperException(description:  22785564);
            if(22754952 == 1)
            {
                    this.DisposeAllPolyPts();
                if(536884867 == 0)
            {
                    return (bool)val_4;
            }
            
                return (bool)val_4;
            }
        
        }
        public bool Execute(ClipperLibFerr.ClipType clipType, ClipperLibFerr.PolyTree polytree, ClipperLibFerr.PolyFillType subjFillType, ClipperLibFerr.PolyFillType clipFillType)
        {
            if(this.m_ExecuteLocked == true)
            {
                    return (bool)0;
            }
            
            this.m_ExecuteLocked = true;
            this.m_ClipFillType = clipFillType;
            this.m_SubjFillType = subjFillType;
            this.m_ClipType = clipType;
            this.m_UsingPolyTree = true;
            bool val_1 = this.ExecuteInternal();
            0 = val_1;
            if(val_1 != false)
            {
                    this.BuildResult2(polytree:  polytree);
            }
            
            this.DisposeAllPolyPts();
            this.m_ExecuteLocked = false;
            return (bool)0;
        }
        internal void FixHoleLinkage(ClipperLibFerr.OutRec outRec)
        {
            ClipperLibFerr.OutRec val_1;
            bool val_2;
            val_1 = outRec.FirstLeft;
            if(val_1 == 0)
            {
                    return;
            }
            
            val_2 = outRec.FirstLeft.IsHole;
            if(val_2 == true)
            {
                    val_2 = 1;
            }
            
            if(outRec.IsHole == true)
            {
                    outRec.IsHole = 1;
            }
            
            if(outRec.FirstLeft.Pts == 0)
            {
                goto label_2;
            }
            
            return;
            label_4:
            val_2 = outRec.FirstLeft.IsHole;
            label_2:
            if(R4 != 0)
            {
                    R4 = 1;
            }
            
            if(((int)val_2 & 255) != 0)
            {
                    (int)val_2 & 255 = 1;
            }
            
            if(outRec.FirstLeft.Pts != 0)
            {
                goto label_3;
            }
            
            if(outRec.FirstLeft.FirstLeft != 0)
            {
                goto label_4;
            }
            
            val_1 = 0;
            label_3:
            mem2[0] = val_1;
        }
        private bool ExecuteInternal()
        {
            ClipperLibFerr.OutRec val_9;
            var val_13;
            this.Reset();
            this.m_SortedEdges = 0;
            this.m_Maxima = 0;
            if((this.PopScanbeam(Y: out  long val_1 = 1372751008)) == false)
            {
                goto label_5;
            }
            
            this.InsertLocalMinimaIntoAEL(botY:  1152921510274565280);
            label_6:
            if((this.PopScanbeam(Y: out  long val_3 = 1372751000)) != true)
            {
                    if(this.LocalMinimaPending() == false)
            {
                goto label_3;
            }
            
            }
            
            this.ProcessHorizontals();
            this.m_GhostJoins.Clear();
            if((this.ProcessIntersections(topY:  3221253413)) == false)
            {
                goto label_5;
            }
            
            this.ProcessEdgesAtTopOfScanbeam(topY:  3221253413);
            this.InsertLocalMinimaIntoAEL(botY:  3221253413);
            goto label_6;
            label_5:
            label_31:
            this.m_Joins.Clear();
            this.m_GhostJoins.Clear();
            var val_14 = 1;
            if(val_14 == 0)
            {
                    return false;
            }
            
            val_14 = val_14 - 1;
            return false;
            label_3:
            List.Enumerator<T> val_7 = GetEnumerator();
            label_17:
            if(MoveNext() == false)
            {
                goto label_12;
            }
            
            if(((val_9 + 20) == 0) || ((val_9 + 13) != 0))
            {
                goto label_17;
            }
            
            double val_10 = val_9 + 13.Area(op:  val_9 + 20);
            if((this.<ReverseSolution>k__BackingField) == true)
            {
                    this.<ReverseSolution>k__BackingField = 1;
            }
            
            if((val_9 + 12) != 0)
            {
                    val_9 + 12 = 1;
            }
            
            if((val_9 + 12) <= 0)
            {
                    0 = 1;
            }
            
            if(0 == 1)
            {
                goto label_17;
            }
            
            this.ReversePolyPtLinks(pp:  val_9 + 20);
            goto label_17;
            label_12:
            mem2[0] = 227;
            var val_15 = val_14;
            val_15 = val_15 + 1;
            Dispose();
            var val_16 = val_15;
            if(val_16 != 0)
            {
                    val_16 = val_16 - 1;
            }
            
            this.JoinCommonEdges();
            List.Enumerator<T> val_11 = GetEnumerator();
            label_26:
            if(MoveNext() == false)
            {
                goto label_21;
            }
            
            if((val_9 + 20) == 0)
            {
                goto label_26;
            }
            
            if((val_9 + 13) == 0)
            {
                goto label_24;
            }
            
            val_9 + 13.FixupOutPolyline(outrec:  val_9);
            goto label_26;
            label_24:
            this.FixupOutPolygon(outRec:  val_9);
            goto label_26;
            label_21:
            mem2[0] = 317;
            var val_17 = val_16;
            val_17 = val_17 + 1;
            Dispose();
            if(val_17 != 0)
            {
                    var val_13 = val_17 - 1;
                if((1152921510274565232 + ((((((1 - 1) + 1) - 1) + 1) - 1)) << 2) == 317)
            {
                    val_13 = val_13;
            }
            
            }
            else
            {
                    val_13 = 0;
            }
            
            if((this.<StrictlySimple>k__BackingField) != false)
            {
                    this.DoSimplePolygons();
                val_13 = val_13;
            }
            
            mem2[0] = 358;
            var val_18 = val_13;
            val_18 = val_18 + 1;
            goto label_31;
        }
        private void DisposeAllPolyPts()
        {
            goto label_1;
            label_3:
            this.DisposeOutRec(index:  0);
            0 = 1;
            label_1:
            if(0 < (R6 + 12))
            {
                goto label_3;
            }
            
            this.Clear();
        }
        private void AddJoin(ClipperLibFerr.OutPt Op1, ClipperLibFerr.OutPt Op2, ClipperLibFerr.IntPoint OffPt)
        {
            var val_1;
            var val_2;
            ClipperLibFerr.Join val_3 = 536889363;
            val_3 = new ClipperLibFerr.Join();
            if(val_3 != 0)
            {
                    mem[536889371] = Op1;
                mem[536889375] = Op2;
            }
            else
            {
                    mem[8] = Op1;
                mem[12] = Op2;
            }
            
            mem[536889379] = val_2;
            mem[536889383] = OffPt.Y;
            mem[536889387] = OffPt.Y;
            mem[536889391] = val_1;
            mem[1152921510274821876].Add(item:  536889363);
        }
        private void AddGhostJoin(ClipperLibFerr.OutPt Op, ClipperLibFerr.IntPoint OffPt)
        {
            ClipperLibFerr.Join val_1 = 536889363;
            val_1 = new ClipperLibFerr.Join();
            if(val_1 != 0)
            {
                    mem[536889371] = Op;
            }
            else
            {
                    mem[8] = Op;
            }
            
            mem[536889379] = OffPt.X;
            mem[536889383] = R3;
            mem[536889387] = OffPt.Y;
            mem[536889391] = OffPt.Y;
            this.m_GhostJoins.Add(item:  536889363);
        }
        private void InsertLocalMinimaIntoAEL(long botY)
        {
            ClipperLibFerr.LocalMinima val_16;
            var val_17;
            var val_18;
            long val_19;
            var val_20;
            var val_21;
            var val_22;
            ClipperLibFerr.OutPt val_23;
            var val_24;
            var val_25;
            var val_26;
            label_47:
            val_16 = ???;
            if((this.PopLocalMinima(Y:  botY, current: out  val_16)) == false)
            {
                    return;
            }
            
            val_17 = 0;
            if(0 != 0)
            {
                goto label_2;
            }
            
            val_17 = 0;
            if(val_17 == 0)
            {
                goto label_42;
            }
            
            label_2:
            if(2621443 == 0)
            {
                goto label_4;
            }
            
            this.InsertEdgeIntoAEL(edge:  2621443, startEdge:  0);
            if((1.401298E-45f) == 0)
            {
                goto label_5;
            }
            
            this.InsertEdgeIntoAEL(edge:  1, startEdge:  2621443);
            this.SetWindingCount(edge:  2621443);
            mem[93] = -1608515359;
            mem[97] = 397945315;
            val_18 = 0;
            if((this.IsContributing(edge:  2621443)) != false)
            {
                    val_18 = 2621443;
                ClipperLibFerr.OutPt val_3 = this.AddLocalMinPoly(e1:  2621443, e2:  1, pt:  new ClipperLibFerr.IntPoint() {X = 2686451937});
            }
            
            this.InsertScanbeam(Y:  2621443);
            val_20 = 2621443;
            goto label_10;
            label_4:
            this.InsertEdgeIntoAEL(edge:  1, startEdge:  0);
            this.SetWindingCount(edge:  1);
            if((this.IsContributing(edge:  1)) == false)
            {
                goto label_8;
            }
            
            val_19 = 50331648;
            ClipperLibFerr.OutPt val_5 = this.AddOutPt(e:  1, pt:  new ClipperLibFerr.IntPoint() {Y = 16787456});
            val_20 = 0;
            goto label_10;
            label_5:
            this.SetWindingCount(edge:  2621443);
            val_21 = 2621443;
            if((this.IsContributing(edge:  2621443)) != false)
            {
                    val_22 = static_value_0028000F;
                val_21 = 2621443;
                ClipperLibFerr.OutPt val_7 = this.AddOutPt(e:  2621443, pt:  new ClipperLibFerr.IntPoint() {X = static_value_0028000B, Y = static_value_00280013});
            }
            
            this.InsertScanbeam(Y:  2621443);
            goto label_47;
            label_8:
            val_20 = 0;
            if((1.401298E-45f) == 0)
            {
                goto label_47;
            }
            
            label_10:
            val_23 = 0;
            if((ClipperLibFerr.ClipperBase.IsHorizontal(e:  1)) != false)
            {
                    if(16777232 != 0)
            {
                    this.InsertScanbeam(Y:  0);
            }
            
                val_23 = 1.401298E-45f;
                this.AddEdgeToSEL(edge:  1);
            }
            else
            {
                    this.InsertScanbeam(Y:  0);
            }
            
            if(2621443 == 0)
            {
                goto label_47;
            }
            
            if(0 == 0)
            {
                goto label_22;
            }
            
            val_23 = 0;
            bool val_9 = ClipperLibFerr.ClipperBase.IsHorizontal(e:  1);
            if(((val_9 == false) || (val_9 < true)) || (0 == 0))
            {
                goto label_22;
            }
            
            var val_10 = (1.401298E-45f) + 40;
            val_24 = 0;
            goto label_23;
            label_30:
            if(((1.401298E-45f) + 8) <= val_24)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + 0;
            val_19 = (0 + 0) + 16 + 8 + 20;
            if((this.HorzSegmentsOverlap(seg1a:  0, seg1b:  val_19, seg2a:  (0 + 0) + 16 + 16 + 4, seg2b:  val_16)) != false)
            {
                    val_23 = mem[(0 + 0) + 16 + 8];
                val_23 = (0 + 0) + 16 + 8;
                val_19 = mem[(0 + 0) + 16 + 28];
                val_19 = (0 + 0) + 16 + 28;
                this.AddJoin(Op1:  val_23, Op2:  0, OffPt:  new ClipperLibFerr.IntPoint() {X = val_19, Y = mem[(0 + 0) + 16 + 16 + (4)]});
            }
            
            val_24 = 1;
            label_23:
            if(val_24 < this)
            {
                goto label_30;
            }
            
            label_22:
            val_25 = val_20;
            if((23 < 0) || (22016016 == 0))
            {
                goto label_53;
            }
            
            val_23 = 0;
            val_19 = val_19 ^ val_23;
            if((22016016 != 0) || (1516128 < 0))
            {
                goto label_53;
            }
            
            val_25 = val_20;
            val_19 = 1512968;
            bool val_13 = ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {Y = 1512740}, pt2:  new ClipperLibFerr.IntPoint() {X = 1513412, Y = 1513880}, pt3:  new ClipperLibFerr.IntPoint() {Y = 22965384}, pt4:  new ClipperLibFerr.IntPoint() {X = 2.938809E-39f, Y = 1835037}, UseFullRange:  (0 + 0) + 16 + 8 + 16);
            if(val_13 == true)
            {
                    val_13 = 0;
            }
            
            if(val_13 != 0)
            {
                goto label_36;
            }
            
            label_53:
            if(1 == (1.401298E-45f))
            {
                goto label_47;
            }
            
            if(((-1878962201) < 0) || (mem[268521556] < 0))
            {
                goto label_50;
            }
            
            val_26 = 268521456;
            if(268521456 != 0)
            {
                goto label_41;
            }
            
            val_26 = 268521456;
            if(val_26 == 0)
            {
                goto label_42;
            }
            
            label_41:
            val_23 = mem[268521484];
            val_19 = mem[268521492];
            bool val_14 = ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = mem[268521480], Y = mem[268521488]}, pt2:  new ClipperLibFerr.IntPoint() {X = mem[268521496], Y = mem[268521504]}, pt3:  new ClipperLibFerr.IntPoint() {X = 872415232, Y = 89708}, pt4:  new ClipperLibFerr.IntPoint() {X = 134225920, Y = 100670464}, UseFullRange:  true);
            val_25 = val_20;
            if(val_14 == true)
            {
                    val_14 = 0;
            }
            
            if(val_14 != 0)
            {
                goto label_43;
            }
            
            label_50:
            if(1 == (1.401298E-45f))
            {
                goto label_47;
            }
            
            var val_15 = val_25 + 32;
            val_25 = val_25 + 24;
            do
            {
                this.IntersectEdges(e1:  1, e2:  1, pt:  new ClipperLibFerr.IntPoint() {X = val_19, Y = val_23});
            }
            while(268435456 != (1.401298E-45f));
            
            goto label_47;
            label_43:
            if(mem[268521544] == 0)
            {
                goto label_50;
            }
            
            ClipperLibFerr.OutPt val_16 = this.AddOutPt(e:  268521456, pt:  new ClipperLibFerr.IntPoint() {Y = 16787456});
            this.AddJoin(Op1:  0, Op2:  1373268400, OffPt:  new ClipperLibFerr.IntPoint() {X = 100670464, Y = 268521456});
            goto label_50;
            label_36:
            if(1515588 == 0)
            {
                goto label_53;
            }
            
            ClipperLibFerr.OutPt val_17 = this.AddOutPt(e:  22016016, pt:  new ClipperLibFerr.IntPoint() {Y = 2621443});
            this.AddJoin(Op1:  0, Op2:  1373268400, OffPt:  new ClipperLibFerr.IntPoint() {X = 1835037, Y = 22016016});
            goto label_53;
            label_42:
        }
        private void InsertEdgeIntoAEL(ClipperLibFerr.TEdge edge, ClipperLibFerr.TEdge startEdge)
        {
            var val_3;
            ClipperLibFerr.TEdge val_4;
            ClipperLibFerr.TEdge val_5;
            var val_6;
            val_3 = this;
            val_4 = edge;
            if(edge == 0)
            {
                goto label_0;
            }
            
            val_5 = startEdge;
            if(startEdge != 0)
            {
                goto label_1;
            }
            
            if((this.E2InsertsBeforeE1(e1:  edge, e2:  val_4)) == false)
            {
                goto label_11;
            }
            
            edge.PrevInAEL = 0;
            edge.NextInAEL = val_5;
            startEdge.PrevInAEL = val_4;
            goto label_6;
            label_0:
            if(val_4 != 0)
            {
                    edge.PrevInAEL = 0;
            }
            else
            {
                    mem[120] = 0;
            }
            
            edge.NextInAEL = 0;
            label_6:
            mem[1152921510275215180] = val_4;
            label_15:
            label_11:
            val_5 = mem[R5];
            val_5 = R5;
            label_1:
            if((R5 + 116) == 0)
            {
                goto label_10;
            }
            
            if((mem[1152921510275215180].E2InsertsBeforeE1(e1:  R5 + 116, e2:  R4)) == false)
            {
                goto label_11;
            }
            
            val_6 = mem[R5 + 116];
            val_6 = R5 + 116;
            goto label_12;
            label_10:
            val_6 = 0;
            label_12:
            mem2[0] = val_6;
            if((R5 + 116) != 0)
            {
                    mem2[0] = ???;
            }
            
            mem2[0] = val_5;
            mem2[0] = ???;
            goto label_15;
        }
        private bool E2InsertsBeforeE1(ClipperLibFerr.TEdge e1, ClipperLibFerr.TEdge e2)
        {
            ClipperLibFerr.IntPoint val_6;
            var val_7;
            val_6 = e2;
            val_7 = mem[e2 + 24 + 4];
            val_7 = e2 + 24 + 4;
            ClipperLibFerr.IntPoint val_7 = e1.Curr;
            ClipperLibFerr.IntPoint val_1 = e2.Curr ^ val_7;
            ClipperLibFerr.TEdge val_2 = val_7 ^ e1;
            if(e1 != 0)
            {
                goto label_2;
            }
            
            ClipperLibFerr.IntPoint val_3 = val_7 - (e2 + 24);
            if(e1 >= 0)
            {
                goto label_3;
            }
            
            long val_6 = ClipperLibFerr.Clipper.TopX(edge:  e1, currentY:  e1);
            val_6 = e2.Top - val_6;
            goto label_5;
            label_2:
            val_7 = (e2 + 24) - val_7;
            goto label_5;
            label_3:
            val_6 = e1.Top;
            long val_8 = ClipperLibFerr.Clipper.TopX(edge:  e2, currentY:  e1);
            val_8 = val_8 - val_6;
            if(e1 < 0)
            {
                    label_5:
                0 = 1;
            }
            
            return true;
        }
        private bool IsEvenOddFillType(ClipperLibFerr.TEdge edge)
        {
            if(edge.PolyTyp == 0)
            {
                    60 = 64;
            }
            
            ClipperLibFerr.PolyFillType val_1 = this.m_SubjFillType;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool IsEvenOddAltFillType(ClipperLibFerr.TEdge edge)
        {
            if(edge.PolyTyp == 0)
            {
                    64 = 60;
            }
            
            ClipperLibFerr.PolyFillType val_1 = this.m_ClipFillType;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private bool IsContributing(ClipperLibFerr.TEdge edge)
        {
            var val_3;
            if(edge.PolyTyp == 0)
            {
                    60 = 64;
                64 = 60;
            }
            
            if(this.m_SubjFillType == 2)
            {
                goto label_2;
            }
            
            if(this.m_SubjFillType == 1)
            {
                goto label_3;
            }
            
            if(this.m_SubjFillType != 0)
            {
                goto label_4;
            }
            
            if(edge.WindDelta != 0)
            {
                goto label_10;
            }
            
            label_2:
            val_3 = 0;
            if(edge.WindCnt == 1)
            {
                goto label_10;
            }
            
            return false;
            label_3:
            val_3 = 0;
            if(edge.WindCnt < 0)
            {
                    edge.WindCnt = 0 - edge.WindCnt;
            }
            
            if(edge.WindCnt == 1)
            {
                goto label_10;
            }
            
            return false;
            label_4:
            val_3 = 0;
            if(edge.WindCnt != 1)
            {
                    return false;
            }
            
            label_10:
            val_3 = 1;
            if(this.m_ClipType > 3)
            {
                    return false;
            }
            
            var val_1 = 5983000 + (5983000 + (this.m_ClipType) << 2);
            if(this.m_ClipType == 3)
            {
                    val_3 = val_3 & ((IP) << val_3);
                val_3 = val_3 & (((int)R8) >> 32);
                val_3 = val_3 & (val_3 << val_3);
                val_3 = val_3 & ((R8) >> (((val_3 & (IP) << val_3) & ((int)R8) >> 32) & (((val_3 & (IP) << val_3) & ((int)R8) >> 32)) << ((val_3 & (IP) << val_3) & ((int)R8) >> 32)));
            }
            
            if(edge.PolyTyp == 0)
            {
                goto label_18;
            }
            
            if(this.m_ClipFillType < 2)
            {
                goto label_15;
            }
            
            if(this.m_ClipFillType != 2)
            {
                    return (bool)edge.WindCnt2 >> 31;
            }
            
            goto label_17;
            label_18:
            if(this.m_ClipFillType < 2)
            {
                goto label_19;
            }
            
            if(this.m_ClipFillType != 2)
            {
                goto label_20;
            }
            
            if(edge.WindCnt2 < 1)
            {
                    0 = 1;
            }
            
            return true;
            label_19:
            int val_3 = edge.WindCnt2;
            val_3 = val_3 >> 5;
            return (bool)val_3;
            label_15:
            if(edge.WindCnt2 != 0)
            {
                    edge.WindCnt2 = 1;
            }
            
            return true;
            label_20:
            if(edge.WindCnt2 > 1)
            {
                    label_17:
                0 = 1;
            }
            
            return true;
        }
        private void SetWindingCount(ClipperLibFerr.TEdge edge)
        {
            ClipperLibFerr.TEdge val_4;
            int val_5;
            ClipperLibFerr.TEdge val_6;
            int val_7;
            int val_8;
            var val_9;
            var val_10;
            val_4 = edge.PrevInAEL;
            if(val_4 != 0)
            {
                    do
            {
                if(edge.PrevInAEL.PolyTyp == edge.PolyTyp)
            {
                    if(edge.PrevInAEL.WindDelta != 0)
            {
                goto label_4;
            }
            
            }
            
                val_4 = edge.PrevInAEL.PrevInAEL;
            }
            while(val_4 != 0);
            
            }
            
            if(edge.WindDelta != 0)
            {
                    edge.WindCnt = edge.WindDelta;
            }
            else
            {
                    if(edge.PolyTyp == 0)
            {
                    60 = 64;
            }
            
                if(this.m_SubjFillType == 3)
            {
                    1 = 0;
            }
            
                edge.WindCnt = 1;
            }
            
            val_5 = 0;
            val_6 = 1152921510275955404;
            goto label_8;
            label_4:
            val_7 = edge.WindDelta;
            if(val_7 == 0)
            {
                    if(this.m_ClipType != 1)
            {
                goto label_10;
            }
            
            }
            
            if(edge.PolyTyp == 0)
            {
                    60 = 64;
            }
            
            if(this.m_SubjFillType == 0)
            {
                goto label_11;
            }
            
            if((edge.PrevInAEL.WindDelta * edge.PrevInAEL.WindCnt) <= 1)
            {
                goto label_12;
            }
            
            if(val_7 == 0)
            {
                goto label_13;
            }
            
            if((val_7 * edge.PrevInAEL.WindDelta) > 1)
            {
                    val_8 = edge.PrevInAEL.WindCnt + val_7;
            }
            
            goto label_26;
            label_11:
            if(val_7 == 0)
            {
                    val_9 = 1;
                if(edge.PrevInAEL.PrevInAEL != 0)
            {
                    val_9 = 1;
                do
            {
                if(edge.PrevInAEL.PrevInAEL.PolyTyp == edge.PolyTyp)
            {
                    if(edge.PrevInAEL.PrevInAEL.WindDelta != 0)
            {
                    edge.PrevInAEL.PrevInAEL.WindDelta = 1;
            }
            
                val_9 = val_9 ^ 1;
            }
            
            }
            while(edge.PrevInAEL.PrevInAEL.PrevInAEL != 0);
            
            }
            
                val_7 = 1 & (~val_9);
            }
            
            edge.WindCnt = val_7;
            goto label_21;
            label_10:
            edge.WindCnt = 1;
            goto label_21;
            label_12:
            if(edge.PrevInAEL.WindCnt < 0)
            {
                    edge.PrevInAEL.WindCnt = 0 - edge.PrevInAEL.WindCnt;
            }
            
            if(edge.PrevInAEL.WindCnt >= 2)
            {
                goto label_24;
            }
            
            if(edge.WindDelta == 0)
            {
                    val_8 = 1;
            }
            
            goto label_26;
            label_13:
            if(edge.PrevInAEL.WindCnt < 0)
            {
                    1 = 0;
            }
            
            val_8 = 1 + edge.PrevInAEL.WindCnt;
            goto label_26;
            label_24:
            if((edge.WindDelta * edge.PrevInAEL.WindDelta) > 1)
            {
                    val_8 = edge.PrevInAEL.WindCnt + edge.WindDelta;
            }
            
            label_26:
            edge.WindCnt = val_8;
            label_21:
            val_5 = edge.PrevInAEL.WindCnt2;
            val_6 = edge.PrevInAEL.NextInAEL;
            label_8:
            edge.WindCnt2 = val_5;
            if(edge.PolyTyp == 0)
            {
                    64 = 60;
            }
            
            val_10 = mem[edge.PrevInAEL.NextInAEL];
            if(this.m_ClipFillType == 0)
            {
                goto label_27;
            }
            
            if(val_10 == edge)
            {
                    return;
            }
            
            val_4 = 88;
            goto label_29;
            label_32:
            val_5 = edge.WindCnt2;
            label_29:
            if(val_10 != 0)
            {
                    int val_4 = mem[edge.PrevInAEL.NextInAEL] + 88;
                val_4 = val_4 + val_5;
                edge.WindCnt2 = val_4;
            }
            else
            {
                    int val_5 = 0;
                val_5 = val_5 + val_5;
                edge.WindCnt2 = val_5;
            }
            
            if((mem[edge.PrevInAEL.NextInAEL] + 116) != edge)
            {
                goto label_32;
            }
            
            return;
            label_38:
            int val_6 = mem[edge.PrevInAEL.NextInAEL] + 116 + 88;
            if(val_6 != 0)
            {
                    if(edge != 0)
            {
                    val_4 = edge.WindCnt2;
            }
            else
            {
                    val_4 = edge.WindCnt2;
            }
            
                val_6 = val_6 >> 5;
                edge.WindCnt2 = val_6;
            }
            
            val_10 = mem[mem[edge.PrevInAEL.NextInAEL] + 116 + 116];
            val_10 = mem[edge.PrevInAEL.NextInAEL] + 116 + 116;
            label_27:
            if(val_10 != edge)
            {
                goto label_38;
            }
        
        }
        private void AddEdgeToSEL(ClipperLibFerr.TEdge edge)
        {
            ClipperLibFerr.TEdge val_2;
            ClipperLibFerr.TEdge val_3;
            val_2 = edge;
            val_3 = this.m_SortedEdges;
            if(val_3 == 0)
            {
                goto label_0;
            }
            
            if(val_2 == 0)
            {
                goto label_1;
            }
            
            edge.NextInSEL = val_3;
            goto label_2;
            label_0:
            this.m_SortedEdges = val_2;
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            edge.PrevInSEL = 0;
            goto label_4;
            label_1:
            mem[124] = val_3;
            label_2:
            edge.PrevInSEL = 0;
            PrevInSEL = val_2;
            this.m_SortedEdges = val_2;
            label_3:
            mem[128] = 0;
            label_4:
            mem2[0] = 0;
        }
        internal bool PopEdgeFromSEL(out ClipperLibFerr.TEdge e)
        {
            e = this.m_SortedEdges;
            if(e == 0)
            {
                    return false;
            }
            
            this.m_SortedEdges = this.m_SortedEdges.NextInSEL;
            if(this.m_SortedEdges != 0)
            {
                    PrevInSEL = 0;
            }
            
            NextInSEL = 0;
            PrevInSEL = 0;
            return true;
        }
        private void CopyAELToSEL()
        {
            var val_3;
            this.m_SortedEdges = null;
            goto label_0;
            label_1:
            var val_1 = R4 + 128;
            mem2[0] = R4 + 120;
            var val_2 = R4 + 124;
            mem2[0] = R4 + 116;
            val_3 = mem[R4 + 116];
            val_3 = R4 + 116;
            label_0:
            if(val_3 != 0)
            {
                goto label_1;
            }
        
        }
        private void SwapPositionsInSEL(ClipperLibFerr.TEdge edge1, ClipperLibFerr.TEdge edge2)
        {
            var val_1;
            ClipperLibFerr.TEdge val_2;
            ClipperLibFerr.TEdge val_3;
            var val_4;
            val_1 = edge1;
            if(edge1.NextInSEL == 0)
            {
                    edge1.NextInSEL = edge1.PrevInSEL;
                return;
            }
            
            val_2 = edge2.NextInSEL;
            if(val_2 == 0)
            {
                    edge1.NextInSEL = edge2.PrevInSEL;
            }
            
            if(edge1.NextInSEL == 0)
            {
                    return;
            }
            
            val_3 = mem[edge1 + 124];
            val_3 = edge1 + 124;
            if(val_3 == edge2)
            {
                goto label_4;
            }
            
            if(val_2 == edge1)
            {
                goto label_5;
            }
            
            val_4 = edge1;
            mem2[0] = val_2;
            if((edge1 + 128 + -4) != 0)
            {
                    mem2[0] = edge1;
            }
            
            val_1 = edge2;
            mem2[0] = edge2.PrevInSEL;
            if((edge1 + 128) != 0)
            {
                    mem2[0] = edge1;
            }
            
            mem2[0] = val_3;
            if((edge2 + 124) != 0)
            {
                    mem2[0] = edge2;
            }
            
            mem2[0] = edge1.PrevInSEL;
            if((edge2 + 128) == 0)
            {
                goto label_9;
            }
            
            mem2[0] = edge2;
            goto label_13;
            label_4:
            if(val_2 != 0)
            {
                    edge2.NextInSEL.PrevInSEL = edge1;
            }
            
            val_4 = edge1;
            val_3 = edge1.PrevInSEL;
            if(val_3 != 0)
            {
                    edge1.PrevInSEL.NextInSEL = edge2;
            }
            
            edge2.PrevInSEL = val_3;
            edge2.NextInSEL = edge1;
            edge1.PrevInSEL = edge2;
            edge1.NextInSEL = val_2;
            goto label_13;
            label_5:
            if(val_3 != 0)
            {
                    mem2[0] = edge2;
            }
            
            val_2 = edge2.PrevInSEL;
            if(val_2 != 0)
            {
                    edge2.PrevInSEL.NextInSEL = edge1;
            }
            
            val_4 = edge1;
            edge1.PrevInSEL = val_2;
            edge1.NextInSEL = edge2;
            edge2.PrevInSEL = edge1;
            edge2.NextInSEL = val_3;
            label_13:
            label_9:
            if((edge1 + 128) == 0)
            {
                goto label_16;
            }
            
            if(edge2.PrevInSEL == 0)
            {
                goto label_17;
            }
            
            return;
            label_16:
            mem[1152921510276538428] = edge1;
            goto label_18;
            label_17:
            mem[1152921510276538428] = edge2;
            label_18:
        }
        private void AddLocalMaxPoly(ClipperLibFerr.TEdge e1, ClipperLibFerr.TEdge e2, ClipperLibFerr.IntPoint pt)
        {
            long val_1;
            long val_5;
            long val_6;
            var val_7;
            var val_8;
            int val_9;
            int val_10;
            ClipperLibFerr.TEdge val_11;
            ClipperLibFerr.TEdge val_12;
            val_5 = pt.Y;
            val_6 = val_1;
            ClipperLibFerr.OutPt val_3 = this.AddOutPt(e:  e1, pt:  new ClipperLibFerr.IntPoint() {X = val_6, Y = pt.Y});
            if(e2.WindDelta == 0)
            {
                    ClipperLibFerr.OutPt val_4 = this.AddOutPt(e:  e2, pt:  new ClipperLibFerr.IntPoint() {X = val_6, Y = pt.Y});
            }
            
            if(e1 == 0)
            {
                goto label_2;
            }
            
            val_7 = e2;
            val_8 = e1;
            val_9 = e2.OutIdx;
            val_10 = e1.OutIdx;
            if(val_10 == val_9)
            {
                goto label_3;
            }
            
            goto label_4;
            label_2:
            val_7 = 100;
            val_8 = 100;
            val_5 = 3.818603E-38f;
            val_6 = mem[val_7 + e2];
            val_6 = val_7 + e2;
            if(val_5 != val_6)
            {
                goto label_5;
            }
            
            label_3:
            mem[100] = 0;
            mem2[0] = 0;
            return;
            label_5:
            val_9 = mem[val_7 + e2];
            val_9 = val_7 + e2;
            val_10 = mem[100];
            label_4:
            if(val_10 < val_9)
            {
                    val_11 = e1;
                val_12 = e2;
            }
            else
            {
                    val_11 = e2;
                val_12 = e1;
            }
            
            this.AppendPolygon(e1:  val_11, e2:  val_12);
        }
        private ClipperLibFerr.OutPt AddLocalMinPoly(ClipperLibFerr.TEdge e1, ClipperLibFerr.TEdge e2, ClipperLibFerr.IntPoint pt)
        {
            long val_2;
            long val_8;
            ClipperLibFerr.TEdge val_13;
            ClipperLibFerr.Clipper val_14;
            ClipperLibFerr.TEdge val_15;
            var val_16;
            long val_17;
            var val_18;
            long val_19;
            ClipperLibFerr.Clipper val_20;
            int val_21;
            ClipperLibFerr.TEdge val_22;
            ClipperLibFerr.EdgeSide val_23;
            val_13 = e1;
            val_14 = this;
            val_15 = e2;
            if((ClipperLibFerr.ClipperBase.IsHorizontal(e:  e2)) == false)
            {
                goto label_0;
            }
            
            val_19 = R5;
            ClipperLibFerr.OutPt val_3 = this.AddOutPt(e:  val_13, pt:  new ClipperLibFerr.IntPoint() {X = val_2, Y = val_17});
            val_20 = val_14;
            if(val_13 == 0)
            {
                    val_20 = val_20;
            }
            
            val_21 = e1.OutIdx;
            if(val_15 != 0)
            {
                goto label_2;
            }
            
            mem[100] = val_21;
            e1.Side = 0;
            val_20 = val_20;
            goto label_3;
            label_0:
            if(val_13 == 0)
            {
                    val_19 = val_16;
                val_16 = val_19;
            }
            
            if(val_15 == 0)
            {
                    val_19 = val_16;
            }
            
            if(val_15 <= 0)
            {
                goto label_6;
            }
            
            val_19 = R5;
            ClipperLibFerr.OutPt val_4 = this.AddOutPt(e:  val_13, pt:  new ClipperLibFerr.IntPoint() {X = val_2, Y = val_17});
            val_20 = val_14;
            val_21 = e1.OutIdx;
            label_2:
            e2.OutIdx = val_21;
            e1.Side = 0;
            label_3:
            val_22 = val_13;
            val_23 = 1;
            val_13 = val_15;
            val_18 = val_19;
            val_17 = pt.Y;
            goto label_7;
            label_6:
            ClipperLibFerr.OutPt val_5 = this.AddOutPt(e:  val_15, pt:  new ClipperLibFerr.IntPoint() {X = val_2, Y = val_17});
            val_20 = val_14;
            val_22 = val_15;
            e1.Side = 1;
            val_23 = 0;
            e1.OutIdx = e2.OutIdx;
            label_7:
            e2.Side = val_23;
            if(e2.PrevInAEL != val_13)
            {
                    e2.PrevInAEL = val_22;
            }
            
            if(e2.PrevInAEL == 0)
            {
                    return;
            }
            
            int val_13 = e2.PrevInAEL.OutIdx;
            if(0 != (val_13 >> 31))
            {
                    return;
            }
            
            val_15 = e2.PrevInAEL;
            val_13 = val_13 - val_17;
            if(0 >= (val_13 >> 31))
            {
                    return;
            }
            
            long val_14 = e2 + 48 + 4;
            val_13 = val_13 - val_17;
            if(0 >= (val_13 >> 31))
            {
                    return;
            }
            
            val_14 = ClipperLibFerr.Clipper.TopX(edge:  e2.PrevInAEL, currentY:  val_14);
            val_19 = val_14;
            long val_7 = ClipperLibFerr.Clipper.TopX(edge:  val_22, currentY:  val_14);
            val_20 = val_20;
            val_14 = val_19 ^ val_14;
            val_7 = val_14 ^ val_7;
            if(0 != (val_13 >> 31))
            {
                    return;
            }
            
            if(e2.WindDelta != 0)
            {
                    e2.WindDelta = e2.PrevInAEL.WindDelta;
                goto label_13;
            }
            
            return;
            label_13:
            ClipperLibFerr.IntPoint val_9 = new ClipperLibFerr.IntPoint(X:  val_8, Y:  val_19);
            ClipperLibFerr.IntPoint val_10 = new ClipperLibFerr.IntPoint(X:  0, Y:  val_19);
            if((ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = val_9.X, Y = val_9.X}, pt2:  new ClipperLibFerr.IntPoint() {X = val_10.X, Y = e2.PrevInAEL + 48}, pt3:  new ClipperLibFerr.IntPoint() {X = val_10.X, Y = val_10.X}, pt4:  new ClipperLibFerr.IntPoint() {X = val_10.X, Y = val_10.X}, UseFullRange:  .ctor(X:  val_8, Y:  val_19) + 32)) == false)
            {
                    return;
            }
            
            ClipperLibFerr.OutPt val_12 = val_9.AddOutPt(e:  e2.PrevInAEL, pt:  new ClipperLibFerr.IntPoint() {X = val_2, Y = val_17});
            val_9.AddJoin(Op1:  val_10.Y, Op2:  val_9, OffPt:  new ClipperLibFerr.IntPoint() {X = val_10.X + 4, Y = e2.PrevInAEL});
        }
        private ClipperLibFerr.OutPt AddOutPt(ClipperLibFerr.TEdge e, ClipperLibFerr.IntPoint pt)
        {
            ClipperLibFerr.TEdge val_8;
            long val_9;
            long val_10;
            var val_11;
            val_8 = e;
            val_9 = pt.Y;
            if(e.OutIdx <= 1)
            {
                goto label_2;
            }
            
            if(true <= e.OutIdx)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (e.OutIdx << 2);
            val_10 = mem[(0 + (e.OutIdx) << 2) + 16];
            val_10 = (0 + (e.OutIdx) << 2) + 16;
            val_8 = val_10;
            if(e.Side == 0)
            {
                goto label_6;
            }
            
            var val_1 = ((0 + (e.OutIdx) << 2) + 16 + 20 + 36) + 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = pt.X, Y = val_9}, b:  new ClipperLibFerr.IntPoint() {X = mem[((0 + (e.OutIdx) << 2) + 16 + 20 + 36 + 16) + (0)], Y = mem[((0 + (e.OutIdx) << 2) + 16 + 20 + 36 + 16) + (8)]})) == false)
            {
                goto label_15;
            }
            
            val_11 = mem[(0 + (e.OutIdx) << 2) + 16 + 20 + 36];
            val_11 = (0 + (e.OutIdx) << 2) + 16 + 20 + 36;
            return;
            label_2:
            val_10 = pt.X;
            ClipperLibFerr.OutRec val_3 = this.CreateOutRec();
            val_9 = this;
            mem[1152921510276976797] = 0;
            ClipperLibFerr.OutPt val_4 = 536891413;
            val_11 = val_4;
            val_4 = new ClipperLibFerr.OutPt();
            if(val_9 == 0)
            {
                goto label_12;
            }
            
            mem[1152921510276976804] = val_11;
            goto label_13;
            label_6:
            var val_5 = ((0 + (e.OutIdx) << 2) + 16 + 20) + 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = pt.X, Y = val_9}, b:  new ClipperLibFerr.IntPoint() {X = mem[((0 + (e.OutIdx) << 2) + 16 + 20 + 16) + (0)], Y = mem[((0 + (e.OutIdx) << 2) + 16 + 20 + 16) + (8)]})) != false)
            {
                    val_11 = (0 + (e.OutIdx) << 2) + 16 + 20;
                return;
            }
            
            label_15:
            ClipperLibFerr.OutPt val_7 = 536891413;
            val_11 = val_7;
            val_7 = new ClipperLibFerr.OutPt();
            if(val_11 == 0)
            {
                goto label_17;
            }
            
            mem[536891421] = (0 + (e.OutIdx) << 2) + 16 + 8;
            mem[536891429] = pt.X;
            mem[536891433] = R3;
            mem[536891437] = pt.Y;
            mem[536891441] = pt.Y;
            goto label_18;
            label_12:
            mem[20] = val_11;
            label_13:
            if(val_11 != 0)
            {
                    mem[536891421] = e.WindDelta;
                mem[536891429] = val_10;
                mem[536891433] = R3;
                mem[536891437] = pt.Y;
                mem[536891441] = pt.Y;
                var val_8 = val_11 + 32;
                mem[536891445] = val_11;
            }
            else
            {
                    mem[8] = e.WindDelta;
                mem[20] = R3;
                mem[16] = val_10;
                mem[28] = pt.Y;
                mem[24] = pt.Y;
                mem[32] = 0;
            }
            
            mem[536891449] = val_11;
            if((val_11 + 36) == 0)
            {
                    this.SetHoleState(e:  val_8, outRec:  1375162512);
            }
            
            e.OutIdx = this;
            return;
            label_17:
            mem[8] = (0 + (e.OutIdx) << 2) + 16 + 8;
            mem[20] = R3;
            mem[16] = pt.X;
            mem[28] = pt.Y;
            mem[24] = pt.Y;
            label_18:
            mem[536891445] = (0 + (e.OutIdx) << 2) + 16 + 20;
            val_9 = e.Side;
            mem[536891449] = (0 + (e.OutIdx) << 2) + 16 + 20 + 36;
            mem2[0] = val_11;
            mem2[0] = val_11;
            if(val_9 != 0)
            {
                    return;
            }
            
            mem2[0] = val_11;
        }
        private ClipperLibFerr.OutPt GetLastOutPt(ClipperLibFerr.TEdge e)
        {
            var val_1;
            if(true <= e.OutIdx)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (e.OutIdx << 2);
            val_1 = mem[(0 + (e.OutIdx) << 2) + 16 + 20];
            val_1 = (0 + (e.OutIdx) << 2) + 16 + 20;
            if(e.Side == 0)
            {
                    return;
            }
            
            val_1 = mem[(0 + (e.OutIdx) << 2) + 16 + 20 + 36];
            val_1 = (0 + (e.OutIdx) << 2) + 16 + 20 + 36;
        }
        internal void SwapPoints(ref ClipperLibFerr.IntPoint pt1, ref ClipperLibFerr.IntPoint pt2)
        {
            ClipperLibFerr.IntPoint val_1 = new ClipperLibFerr.IntPoint(pt:  new ClipperLibFerr.IntPoint() {X = mem[1152921510277273564]});
        }
        private bool HorzSegmentsOverlap(long seg1a, long seg1b, long seg2a, long seg2b)
        {
            var val_1;
            long val_9;
            var val_10;
            long val_12;
            long val_13;
            var val_14;
            val_9 = val_1;
            val_13 = seg2a;
            var val_2 = val_9 - R2;
            if()
            {
                    this.Swap(val1: ref  long val_3 = 1375543432, val2: ref  long val_4 = 1375543424);
                val_12 = val_12;
            }
            
            long val_5 = val_10 - val_13;
            if()
            {
                    this.Swap(val1: ref  long val_6 = 1375543416, val2: ref  long val_7 = 1375543408);
            }
            
            val_14 = 0;
            val_10 = seg2a - val_10;
            if()
            {
                    return true;
            }
            
            var val_8 = val_9;
            val_9 = val_12;
            val_8 = val_13 - val_8;
            if()
            {
                    val_14 = 1;
            }
            
            return true;
        }
        private void SetHoleState(ClipperLibFerr.TEdge e, ClipperLibFerr.OutRec outRec)
        {
            ClipperLibFerr.OutRec val_1;
            var val_2;
            var val_3;
            ClipperLibFerr.OutRec val_4;
            val_1 = e;
            if(e.PrevInAEL == 0)
            {
                goto label_8;
            }
            
            label_7:
            if((e.PrevInAEL.OutIdx < 0) || (e.PrevInAEL.WindDelta == 0))
            {
                goto label_4;
            }
            
            val_2 = e.PrevInAEL;
            if(0 == 0)
            {
                goto label_6;
            }
            
            var val_1 = 22013840;
            val_1 = val_1 - e.PrevInAEL.OutIdx;
            if(0 != 0)
            {
                    val_2 = 0;
            }
            
            goto label_6;
            label_4:
            val_2 = 0;
            label_6:
            if(e.PrevInAEL.PrevInAEL != 0)
            {
                goto label_7;
            }
            
            if(val_2 == 0)
            {
                goto label_8;
            }
            
            if(e.PrevInAEL.PrevInAEL <= 22013840)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 88055360;
            val_1 = mem[(0 + 88055360) + 16];
            val_1 = (0 + 88055360) + 16;
            if(outRec == 0)
            {
                goto label_11;
            }
            
            val_3 = outRec;
            outRec.FirstLeft = val_1;
            goto label_12;
            label_8:
            if(outRec == 0)
            {
                goto label_13;
            }
            
            val_4 = 0;
            outRec.FirstLeft = val_4;
            goto label_15;
            label_13:
            val_4 = 0;
            mem[16] = val_4;
            goto label_15;
            label_11:
            val_3 = 16;
            mem[16] = val_1;
            label_12:
            val_4 = ((0 + 88055360) + 16 + 12) ^ 1;
            label_15:
            outRec.IsHole = val_4;
        }
        private double GetDx(ClipperLibFerr.IntPoint pt1, ClipperLibFerr.IntPoint pt2)
        {
            var val_1;
            var val_2;
            var val_6;
            double val_7;
            long val_3 = val_1 ^ pt2.X;
            val_6 = pt2.Y ^ val_2;
            if()
            {
                    val_7 = 1.65408152838933E-314;
                return (double)D0;
            }
            
            long val_5 = pt2.X;
            val_5 = val_5 - R2;
            val_7 = val_5 / (pt2.Y - val_2);
            return (double)D0;
        }
        private bool FirstIsBottomPt(ClipperLibFerr.OutPt btmPt1, ClipperLibFerr.OutPt btmPt2)
        {
            double val_22;
            double val_23;
            do
            {
                bool val_2 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = btmPt1.Prev.Pt, Y = btmPt2}, b:  new ClipperLibFerr.IntPoint() {X = btmPt1.Pt.X, Y = mem[(btmPt1 + 24) + (0)]});
            }
            while(val_2 == true);
            
            ClipperLibFerr.OutPt val_3 = (btmPt1.Prev + 24) ^ 1152921504930168832;
            ClipperLibFerr.OutPt val_4 = (btmPt1.Prev + 24 + 4) ^ btmPt2;
            if(val_2 != true)
            {
                    val_22 = 1.65408152838933E-314;
            }
            else
            {
                    long val_20 = btmPt1.Pt.X;
                val_20 = (btmPt1.Prev + 16) - val_20;
                val_22 = val_20 / ((btmPt1.Prev + 24) - 1152921504930168832);
            }
            
            do
            {
                bool val_6 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = (btmPt1.Prev + 16 - btmPt1.Pt.X) + 32 + 16, Y = (btmPt1.Prev + 16 - btmPt1.Pt.X) + 32 + 24}, b:  new ClipperLibFerr.IntPoint() {X = btmPt1.Pt.X, Y = mem[(btmPt1 + 24) + (0)]});
            }
            while(val_6 == true);
            
            ClipperLibFerr.OutPt val_7 = (mem[(btmPt1.Prev + 16 - btmPt1.Pt.X) + 32 + 24 + (0)]) ^ 1152921504930168832;
            ClipperLibFerr.OutPt val_8 = (mem[(btmPt1.Prev + 16 - btmPt1.Pt.X) + 32 + 24 + (4)]) ^ (btmPt1 + 24);
            if(val_6 != true)
            {
                    val_23 = 1.65408152838933E-314;
            }
            else
            {
                    long val_21 = btmPt1.Pt.X;
                val_21 = ((btmPt1.Prev + 16 - btmPt1.Pt.X) + 32 + 16) - val_21;
                val_23 = val_21 / ((mem[(btmPt1.Prev + 16 - btmPt1.Pt.X) + 32 + 24 + (0)]) - 1152921504930168832);
            }
            
            double val_22 = System.Math.Abs(val_22);
            ClipperLibFerr.OutPt val_10 = btmPt2 + 24;
            double val_23 = System.Math.Abs(val_23);
            do
            {
                bool val_12 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = btmPt2 + 36 + 16, Y = btmPt2 + 36 + 24}, b:  new ClipperLibFerr.IntPoint() {X = mem[(btmPt2 + 16) + (0)], Y = val_10});
            }
            while(val_12 == true);
            
            ClipperLibFerr.OutPt val_13 = (mem[btmPt2 + 36 + 24 + (0)]) ^ val_10;
            var val_14 = (mem[btmPt2 + 36 + 24 + (4)]) ^ (mem[(btmPt2 + 16) + (0)]);
            if(val_12 != true)
            {
                
            }
            else
            {
                    ClipperLibFerr.OutPt val_24 = btmPt2 + 16;
                val_24 = (btmPt2 + 36 + 16) - val_24;
                ClipperLibFerr.OutPt val_16 = val_24 / ((mem[btmPt2 + 36 + 24 + (0)]) - val_10);
            }
            
            do
            {
                bool val_17 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = btmPt2 + 32 + 16, Y = btmPt2 + 32 + 24}, b:  new ClipperLibFerr.IntPoint() {X = mem[(btmPt2 + 16) + (0)], Y = val_10});
            }
            while(val_17 == true);
            
            var val_18 = (mem[btmPt2 + 32 + 24 + (0)]) ^ (mem[(btmPt2 + 24) + (0)]);
            var val_19 = (mem[btmPt2 + 32 + 24 + (4)]) ^ (mem[(btmPt2 + 24) + (4)]);
            if(val_17 != true)
            {
                
            }
        
        }
        private ClipperLibFerr.OutPt GetBottomPt(ClipperLibFerr.OutPt pp)
        {
            ClipperLibFerr.OutPt val_5;
            ClipperLibFerr.OutPt val_6;
            ClipperLibFerr.OutPt val_7;
            ClipperLibFerr.OutPt val_8;
            val_5 = pp;
            val_6 = pp.Next;
            if(val_6 == val_5)
            {
                    return;
            }
            
            label_9:
            val_7 = 0;
            val_8 = 0;
            pp = R2 - pp;
            if(val_6 >= 0)
            {
                goto label_3;
            }
            
            val_5 = val_6;
            goto label_7;
            label_3:
            var val_5 = pp.Next + 24;
            pp = pp ^ R3;
            val_5 = val_5 ^ R2;
            if(val_6 != 0)
            {
                goto label_8;
            }
            
            ClipperLibFerr.IntPoint val_6 = pp.Pt;
            ClipperLibFerr.IntPoint val_1 = val_6 - pp.Next.Pt;
            if(val_6 < 0)
            {
                goto label_8;
            }
            
            val_6 = pp.Next.Pt - val_6;
            val_5 = val_6;
            if(val_6 < 0)
            {
                goto label_7;
            }
            
            if(pp.Next.Next != val_5)
            {
                    if(pp.Next.Prev != val_5)
            {
                    val_7 = val_6;
            }
            
            }
            
            label_8:
            val_8 = val_7;
            val_5 = val_5;
            label_7:
            val_6 = pp.Next.Next;
            if(val_6 != val_5)
            {
                goto label_9;
            }
            
            if(val_8 == val_5)
            {
                    return;
            }
            
            do
            {
                if((this.FirstIsBottomPt(btmPt1:  val_5, btmPt2:  val_8)) == false)
            {
                    val_5 = val_8;
            }
            
                ClipperLibFerr.OutPt val_3 = val_5 + 24;
                do
            {
            
            }
            while((ClipperLibFerr.IntPoint.op_Inequality(a:  new ClipperLibFerr.IntPoint() {X = mem[pp.Next.Next.Pt + (0)]>>0&0x0, Y = mem[pp.Next.Next.Pt + (8)]>>0&0x0}, b:  new ClipperLibFerr.IntPoint() {X = pp.Next.Pt.X})) == true);
            
            }
            while(pp.Next.Next != val_5);
        
        }
        private ClipperLibFerr.OutRec GetLowermostRec(ClipperLibFerr.OutRec outRec1, ClipperLibFerr.OutRec outRec2)
        {
            var val_6;
            var val_7;
            ClipperLibFerr.OutPt val_8;
            var val_9;
            val_6 = outRec1;
            if(outRec1.BottomPt == 0)
            {
                    ClipperLibFerr.OutPt val_1 = this.GetBottomPt(pp:  outRec1.Pts);
                val_7 = this;
                outRec1.BottomPt = this;
            }
            
            val_8 = outRec2.BottomPt;
            if(val_8 == 0)
            {
                    ClipperLibFerr.OutPt val_2 = this.GetBottomPt(pp:  outRec2.Pts);
                val_7 = this;
                outRec2.BottomPt = this;
                var val_6 = outRec2 + 24;
                val_8 = outRec2.BottomPt;
            }
            
            val_9 = outRec1 + 24;
            var val_3 = val_6 - (outRec1 + 24 + 24);
            if(val_8 < 0)
            {
                    return;
            }
            
            val_6 = (outRec1 + 24 + 24) - val_6;
            if(val_8 >= 0)
            {
                goto label_7;
            }
            
            label_11:
            val_6 = outRec2;
            return;
            label_7:
            ClipperLibFerr.IntPoint val_7 = outRec2.BottomPt.Pt;
            ClipperLibFerr.IntPoint val_4 = (outRec1 + 24 + 16) - val_7;
            if(val_8 < 0)
            {
                    return;
            }
            
            val_7 = val_7 - (outRec1 + 24 + 16);
            if((val_8 < 0) || ((outRec1 + 24 + 32) == (outRec1 + 24)))
            {
                goto label_11;
            }
            
            if(outRec2.BottomPt.Next == val_8)
            {
                    return;
            }
            
            if((this.FirstIsBottomPt(btmPt1:  outRec1 + 24, btmPt2:  val_8)) == true)
            {
                    outRec2 = val_6;
            }
        
        }
        private bool OutRec1RightOfOutRec2(ClipperLibFerr.OutRec outRec1, ClipperLibFerr.OutRec outRec2)
        {
            do
            {
                if(outRec1.FirstLeft == outRec2)
            {
                    return true;
            }
            
            }
            while(outRec1.FirstLeft != 0);
            
            return false;
        }
        private ClipperLibFerr.OutRec GetOutRec(int idx)
        {
            int val_1 = idx;
            goto label_1;
            label_7:
            val_1 = mem[idx + 8];
            val_1 = idx + 8;
            label_1:
            if(mem[22970910] <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_1 = mem[22970906];
            val_1 = val_1 + (val_1 << 2);
            if(mem[22970910] <= ((mem[22970906] + (idx + 8) << 2) + 16 + 8))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = mem[22970906];
            val_2 = val_2 + (((mem[22970906] + (idx + 8) << 2) + 16 + 8) << 2);
            if(((mem[22970906] + (idx + 8) << 2) + 16) != ((mem[22970906] + ((mem[22970906] + (idx + 8) << 2) + 16 + 8) << 2) + 16))
            {
                goto label_7;
            }
        
        }
        private void AppendPolygon(ClipperLibFerr.TEdge e1, ClipperLibFerr.TEdge e2)
        {
            float val_3;
            ClipperLibFerr.TEdge val_4;
            var val_5;
            if(mem[22970911] <= e1.OutIdx)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = mem[22970907];
            val_3 = val_3 + (e1.OutIdx << 2);
            if(mem[22970911] <= e2.OutIdx)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = mem[22970907];
            val_4 = val_4 + (e2.OutIdx << 2);
            do
            {
                if(((mem[22970907] + (e1.OutIdx) << 2) + 16 + 16) == ((mem[22970907] + (e2.OutIdx) << 2) + 16))
            {
                goto label_14;
            }
            
            }
            while(((mem[22970907] + (e1.OutIdx) << 2) + 16 + 16) != 0);
            
            label_12:
            if(((mem[22970907] + (e2.OutIdx) << 2) + 16 + 16) == ((mem[22970907] + (e1.OutIdx) << 2) + 16))
            {
                goto label_11;
            }
            
            if(((mem[22970907] + (e2.OutIdx) << 2) + 16 + 16) != 0)
            {
                goto label_12;
            }
            
            ClipperLibFerr.OutRec val_1 = this.GetLowermostRec(outRec1:  (mem[22970907] + (e1.OutIdx) << 2) + 16, outRec2:  (mem[22970907] + (e2.OutIdx) << 2) + 16);
            goto label_14;
            label_11:
            label_14:
            if(e1.Side == 0)
            {
                goto label_21;
            }
            
            if((e2 + 84) != 1)
            {
                goto label_22;
            }
            
            e2 + 84.ReversePolyPtLinks(pp:  (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20);
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20 + 36;
            val_3 = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20;
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16 + 20 + 36;
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16 + 20;
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20;
            goto label_25;
            label_21:
            if((e2 + 84) == 0)
            {
                goto label_26;
            }
            
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16 + 20;
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20 + 36;
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16 + 20 + 36;
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20;
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20;
            goto label_29;
            label_22:
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20;
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16 + 20 + 36;
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20 + 36;
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16 + 20;
            label_29:
            val_4 = e2;
            val_3 = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20;
            goto label_32;
            label_26:
            e2 + 84.ReversePolyPtLinks(pp:  (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20);
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16 + 20;
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20;
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20 + 36;
            val_3 = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20;
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16 + 20 + 36;
            mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 20 + 36;
            label_25:
            val_4 = e2;
            label_32:
            mem2[0] = 0;
            var val_2 = ((mem[22970907] + (e2.OutIdx) << 2) + 16) + 16;
            if(((mem[22970907] + (e1.OutIdx) << 2) + 16) == ((mem[22970907] + (e2.OutIdx) << 2) + 16))
            {
                    if(val_2 != ((mem[22970907] + (e1.OutIdx) << 2) + 16))
            {
                    mem2[0] = val_2;
            }
            
                mem2[0] = (mem[22970907] + (e2.OutIdx) << 2) + 16 + 12;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16;
            mem2[0] = 0;
            mem2[0] = 0;
            val_5 = mem[1152921510278474668];
            goto label_37;
            label_39:
            if((mem[1152921510278474668] + 100) == (e2 + 100))
            {
                goto label_38;
            }
            
            val_5 = mem[mem[1152921510278474668] + 116];
            val_5 = mem[1152921510278474668] + 116;
            label_37:
            if(val_5 != 0)
            {
                goto label_39;
            }
            
            goto label_40;
            label_38:
            mem2[0] = e1 + 100;
            mem2[0] = e1 + 84;
            label_40:
            mem2[0] = (mem[22970907] + (e1.OutIdx) << 2) + 16 + 8;
        }
        private void ReversePolyPtLinks(ClipperLibFerr.OutPt pp)
        {
            ClipperLibFerr.OutPt val_1;
            var val_2;
            var val_3;
            if(pp == 0)
            {
                    return;
            }
            
            do
            {
                if(pp != 0)
            {
                    val_1 = pp.Next;
                val_2 = pp + 32;
                mem2[0] = pp + 32 + 4;
                val_3 = val_1;
            }
            else
            {
                    val_3 = 22965384;
                val_2 = 36;
                val_1 = 83886592;
                mem[32] = val_1;
            }
            
                mem[36] = val_3;
            }
            while(val_3 != pp);
        
        }
        private static void SwapSides(ClipperLibFerr.TEdge edge1, ClipperLibFerr.TEdge edge2)
        {
            ClipperLibFerr.TEdge val_1 = edge2;
            if(val_1 != 0)
            {
                    edge1.Side = edge2.Side;
            }
            else
            {
                    val_1 = 84;
                edge1.Side = 1;
            }
            
            mem[84] = edge1.Side;
        }
        private static void SwapPolyIndexes(ClipperLibFerr.TEdge edge1, ClipperLibFerr.TEdge edge2)
        {
            ClipperLibFerr.TEdge val_1 = edge2;
            if(val_1 != 0)
            {
                    edge1.OutIdx = edge2.OutIdx;
            }
            else
            {
                    val_1 = 100;
                edge1.OutIdx = 22013840;
            }
            
            mem[100] = edge1.OutIdx;
        }
        private void IntersectEdges(ClipperLibFerr.TEdge e1, ClipperLibFerr.TEdge e2, ClipperLibFerr.IntPoint pt)
        {
            long val_2;
            var val_15;
            int val_16;
            int val_17;
            int val_18;
            ClipperLibFerr.PolyFillType val_19;
            ClipperLibFerr.PolyFillType val_20;
            var val_21;
            int val_22;
            ClipperLibFerr.PolyFillType val_23;
            long val_24;
            int val_25;
            int val_26;
            int val_27;
            long val_28;
            ClipperLibFerr.TEdge val_29;
            long val_30;
            long val_31;
            int val_32;
            int val_33;
            val_15 = 22970900;
            val_16 = e1.OutIdx;
            val_17 = e2.WindDelta;
            val_18 = e2.OutIdx;
            if(e1.WindDelta == 0)
            {
                goto label_3;
            }
            
            if(val_17 == 0)
            {
                goto label_4;
            }
            
            if(e1.PolyTyp != e2.PolyTyp)
            {
                goto label_5;
            }
            
            if(e1.PolyTyp == 0)
            {
                    60 = 64;
            }
            
            val_19 = this.m_ClipFillType;
            val_20 = this.m_SubjFillType;
            if(this.m_SubjFillType == 0)
            {
                goto label_6;
            }
            
            if(val_17 != e1.WindCnt)
            {
                    val_17 = val_17 + e1.WindCnt;
            }
            
            e1.WindCnt = val_17;
            if(e2.WindCnt != e1.WindDelta)
            {
                    e1.WindDelta = e2.WindCnt - e1.WindDelta;
            }
            
            if(e2.WindCnt == e1.WindDelta)
            {
                    e1.WindDelta = 0 - e1.WindDelta;
            }
            
            e2.WindCnt = e1.WindDelta;
            goto label_31;
            label_3:
            if(val_17 != 0)
            {
                goto label_8;
            }
            
            return;
            label_4:
            val_17 = 0;
            label_8:
            if(e1.PolyTyp != e2.PolyTyp)
            {
                goto label_10;
            }
            
            if(e1.WindDelta == val_17)
            {
                    return;
            }
            
            if(this.m_ClipType != 1)
            {
                    return;
            }
            
            if(e1.WindDelta == 0)
            {
                goto label_13;
            }
            
            if(val_16 >= 0)
            {
                goto label_26;
            }
            
            return;
            label_10:
            if(e1.WindDelta == 0)
            {
                    if(((mem[536890482] & true) == 0) && (mem[536890411] == 0))
            {
                    val_21 = val_18;
            }
            
                if(e2.WindCnt < 0)
            {
                    val_15 = 0 - e2.WindCnt;
            }
            
                if(val_15 == 1)
            {
                    if((this.m_ClipType != 1) || (e2.WindCnt2 == 0))
            {
                goto label_21;
            }
            
            }
            
            }
            
            if(e2.WindDelta != 0)
            {
                    return;
            }
            
            if(((mem[536890482] & true) == 0) && (mem[536890411] == 0))
            {
                    val_21 = val_21;
            }
            
            if(e1.WindCnt < 0)
            {
                    val_15 = 0 - e1.WindCnt;
            }
            
            if(val_15 != 1)
            {
                    return;
            }
            
            if(this.m_ClipType == 1)
            {
                    if(e1.WindCnt2 != 0)
            {
                    return;
            }
            
            }
            
            label_26:
            ClipperLibFerr.OutPt val_3 = this.AddOutPt(e:  e2, pt:  new ClipperLibFerr.IntPoint() {X = val_2, Y = pt.Y});
            if(val_21 >= 0)
            {
                    this = 0;
                e2.OutIdx = this;
            }
            
            return;
            label_5:
            if(e2.PolyTyp == 0)
            {
                    60 = 64;
            }
            
            val_17 = val_17 + e1.WindCnt2;
            val_19 = this.m_ClipFillType;
            val_20 = this.m_SubjFillType;
            if(this.m_SubjFillType == 0)
            {
                    val_17 = e1.WindCnt2 >> 5;
            }
            
            e1.WindCnt2 = val_17;
            if(e1.PolyTyp == 0)
            {
                    60 = 64;
            }
            
            if(this.m_SubjFillType == 0)
            {
                goto label_29;
            }
            
            val_22 = e2.WindCnt2 - e1.WindDelta;
            goto label_30;
            label_6:
            e1.WindCnt = e2.WindCnt;
            e2.WindCnt = e1.WindCnt;
            goto label_31;
            label_29:
            val_22 = e2.WindCnt2 >> 5;
            label_30:
            e2.WindCnt2 = val_22;
            label_31:
            if(e2.PolyTyp == 0)
            {
                    val_19 = val_20;
            }
            
            if(e1.PolyTyp == 0)
            {
                    val_19 = val_20;
            }
            
            if(e2.PolyTyp == 0)
            {
                    val_20 = val_19;
            }
            
            if(e1.PolyTyp == 0)
            {
                    val_20 = val_19;
            }
            
            val_23 = mem[this.m_ClipFillType];
            val_23 = val_20;
            val_24 = mem[this.m_ClipFillType];
            val_24 = val_20;
            if(val_19 == 3)
            {
                goto label_32;
            }
            
            if(val_19 != 2)
            {
                goto label_33;
            }
            
            val_25 = e1.WindCnt;
            goto label_35;
            label_32:
            val_25 = 0 - e1.WindCnt;
            goto label_35;
            label_33:
            if(((mem[536890482] & true) == 0) && (mem[536890411] == 0))
            {
                    val_23 = val_23;
                val_26 = val_18;
            }
            
            if(e1.WindCnt < 0)
            {
                    val_25 = 0 - e1.WindCnt;
            }
            
            label_35:
            if(val_19 == 3)
            {
                goto label_38;
            }
            
            if(val_19 != 2)
            {
                goto label_39;
            }
            
            val_27 = e2.WindCnt;
            goto label_41;
            label_38:
            val_27 = 0 - e2.WindCnt;
            goto label_41;
            label_39:
            if(((mem[536890482] & true) == 0) && (mem[536890411] == 0))
            {
                    val_23 = val_23;
                val_26 = val_26;
            }
            
            if(e2.WindCnt < 0)
            {
                    val_27 = 0 - e2.WindCnt;
            }
            
            label_41:
            var val_12 = 1;
            var val_11 = val_26 >> 31;
            val_12 = val_12 ^ (val_16 >> 31);
            if(((~(val_26 >> 31)) & val_12) != 0)
            {
                goto label_44;
            }
            
            if((val_27 | val_25) > 1)
            {
                goto label_46;
            }
            
            if(e1.PolyTyp != e2.PolyTyp)
            {
                    e2.PolyTyp = this.m_ClipType;
            }
            
            if(e2.PolyTyp != 3)
            {
                goto label_46;
            }
            
            val_16 = pt.Y;
            val_28 = pt.Y;
            val_24 = val_2;
            ClipperLibFerr.OutPt val_5 = this.AddOutPt(e:  e1, pt:  new ClipperLibFerr.IntPoint() {X = val_24, Y = val_16});
            val_29 = e2;
            val_30 = val_24;
            goto label_47;
            label_44:
            if(val_16 < 0)
            {
                goto label_48;
            }
            
            if(val_27 > 1)
            {
                    return;
            }
            
            val_31 = pt.Y;
            val_29 = e1;
            goto label_50;
            label_46:
            this.AddLocalMaxPoly(e1:  e1, e2:  e2, pt:  new ClipperLibFerr.IntPoint() {X = val_23, Y = pt.Y});
            return;
            label_48:
            if(val_26 < 0)
            {
                goto label_52;
            }
            
            if(val_25 > 1)
            {
                    return;
            }
            
            val_31 = pt.Y;
            val_29 = e2;
            label_50:
            val_30 = val_2;
            label_47:
            ClipperLibFerr.OutPt val_6 = this.AddOutPt(e:  val_29, pt:  new ClipperLibFerr.IntPoint() {X = val_30, Y = val_31});
            ClipperLibFerr.Clipper.SwapSides(edge1:  e1, edge2:  e2);
            ClipperLibFerr.Clipper.SwapPolyIndexes(edge1:  e1, edge2:  e2);
            return;
            label_13:
            if(val_18 < 0)
            {
                    return;
            }
            
            label_21:
            ClipperLibFerr.OutPt val_7 = this.AddOutPt(e:  e1, pt:  new ClipperLibFerr.IntPoint() {X = val_2, Y = pt.Y});
            if(val_16 >= 0)
            {
                    this = 0;
                e1.OutIdx = this;
            }
            
            return;
            label_52:
            if((val_25 | val_27) > 1)
            {
                    return;
            }
            
            if(val_24 == 3)
            {
                goto label_56;
            }
            
            if(val_24 != 2)
            {
                goto label_57;
            }
            
            val_32 = e1.WindCnt2;
            goto label_59;
            label_56:
            val_32 = 0 - e1.WindCnt2;
            goto label_59;
            label_57:
            if(((mem[536890482] & true) == 0) && (mem[536890411] == 0))
            {
                    val_23 = val_23;
            }
            
            if(e1.WindCnt2 < 0)
            {
                    val_32 = 0 - e1.WindCnt2;
            }
            
            label_59:
            if(val_23 == 3)
            {
                goto label_62;
            }
            
            if(val_23 != 2)
            {
                goto label_63;
            }
            
            val_33 = e2.WindCnt2;
            goto label_65;
            label_62:
            val_33 = 0 - e2.WindCnt2;
            goto label_65;
            label_63:
            if(e2.WindCnt2 < 0)
            {
                    val_33 = 0 - e2.WindCnt2;
            }
            
            label_65:
            if(e1.PolyTyp == e2.PolyTyp)
            {
                    if(val_27 != 1)
            {
                    ClipperLibFerr.Clipper.SwapSides(edge1:  e1, edge2:  e2);
                return;
            }
            
                if(this.m_ClipType > 3)
            {
                    return;
            }
            
                var val_9 = 5987104 + (5987104 + (this.m_ClipType) << 2);
                if(this.m_ClipType == 3)
            {
                    e1.PolyTyp = e1.PolyTyp & (e1.PolyTyp << e1.PolyTyp);
                e1.PolyTyp = e1.PolyTyp & (this >> e1.PolyTyp);
                e1.PolyTyp = e1.PolyTyp & (val_25 >> 32);
                e1.PolyTyp = e1.PolyTyp & (val_25 >> e1.PolyTyp);
            }
            
                if(val_32 < 1)
            {
                    return;
            }
            
                if(val_33 < 1)
            {
                    return;
            }
            
            }
            
            ClipperLibFerr.OutPt val_10 = this.AddLocalMinPoly(e1:  e1, e2:  e2, pt:  new ClipperLibFerr.IntPoint() {X = val_23, Y = pt.Y});
        }
        private void DeleteFromSEL(ClipperLibFerr.TEdge e)
        {
            var val_1;
            ClipperLibFerr.TEdge val_2;
            if(e != 0)
            {
                    val_1 = e;
                val_2 = e.PrevInSEL;
            }
            else
            {
                    val_1 = 128;
                val_2 = 22020112;
            }
            
            if((e == 0) && (this.m_SortedEdges != e))
            {
                    return;
            }
            
            if(val_2 != 0)
            {
                
            }
            else
            {
                    this.m_SortedEdges = e.NextInSEL;
                val_2 = 0;
            }
            
            if(e.NextInSEL != 0)
            {
                    e.NextInSEL.PrevInSEL = val_2;
            }
            
            mem2[0] = 0;
            mem[128] = 0;
        }
        private void ProcessHorizontals()
        {
            if((this.PopEdgeFromSEL(e: out  ClipperLibFerr.TEdge val_1 = 1377594780)) == false)
            {
                    return;
            }
            
            do
            {
                this.ProcessHorizontal(horzEdge:  0);
            }
            while((this.PopEdgeFromSEL(e: out  ClipperLibFerr.TEdge val_3 = 1377594780)) == true);
        
        }
        private void GetHorzDirection(ClipperLibFerr.TEdge HorzEdge, out ClipperLibFerr.Direction Dir, out long Left, out long Right)
        {
            var val_2;
            var val_3;
            ClipperLibFerr.Direction val_4;
            val_2 = 1152921510279585360;
            if(HorzEdge == 0)
            {
                goto label_0;
            }
            
            val_3 = HorzEdge + 8;
            ClipperLibFerr.IntPoint val_1 = HorzEdge.Bot - (HorzEdge + 8 + 32);
            if(HorzEdge >= 0)
            {
                goto label_1;
            }
            
            goto label_2;
            label_0:
            val_3 = 40;
            val_2 = val_2;
            if(HorzEdge >= 0)
            {
                goto label_3;
            }
            
            Left = 0;
            label_2:
            val_4 = 1;
            goto label_5;
            label_1:
            Left = HorzEdge + 8 + 32;
            val_4 = 0;
            val_3 = HorzEdge + 8;
            goto label_5;
            label_3:
            Left = 11259033430261812;
            val_4 = 0;
            val_3 = 8;
            label_5:
            Right = 5917499081642475520;
            Dir = val_4;
        }
        private void ProcessHorizontal(ClipperLibFerr.TEdge horzEdge)
        {
            ClipperLibFerr.Clipper val_36;
            long val_37;
            long val_38;
            int val_39;
            ClipperLibFerr.TEdge val_40;
            ClipperLibFerr.TEdge val_41;
            ClipperLibFerr.Maxima val_42;
            var val_43;
            ClipperLibFerr.TEdge val_44;
            ClipperLibFerr.TEdge val_45;
            ClipperLibFerr.TEdge val_46;
            var val_47;
            ClipperLibFerr.TEdge val_48;
            ClipperLibFerr.TEdge val_49;
            long val_50;
            ClipperLibFerr.TEdge val_51;
            ClipperLibFerr.TEdge val_52;
            ClipperLibFerr.TEdge val_53;
            var val_54;
            var val_55;
            ClipperLibFerr.TEdge val_56;
            ClipperLibFerr.TEdge val_57;
            ClipperLibFerr.TEdge val_58;
            long val_59;
            ClipperLibFerr.TEdge val_60;
            val_36 = this;
            val_39 = horzEdge.WindDelta;
            0.GetHorzDirection(HorzEdge:  horzEdge, Dir: out  ClipperLibFerr.Direction val_1 = 1377896168, Left: out  long val_2 = 1377896160, Right: out  0);
            label_3:
            val_40 = mem[horzEdge + 112];
            val_40 = horzEdge + 112;
            if(val_40 == 0)
            {
                goto label_2;
            }
            
            val_41 = mem[horzEdge + 112];
            val_41 = horzEdge + 112;
            if((ClipperLibFerr.ClipperBase.IsHorizontal(e:  val_40)) == true)
            {
                goto label_3;
            }
            
            val_40 = 0;
            if(val_41 != 0)
            {
                goto label_4;
            }
            
            label_2:
            val_41 = horzEdge;
            ClipperLibFerr.TEdge val_5 = this.GetMaximaPair(e:  val_41);
            label_4:
            val_42 = this.m_Maxima;
            val_43 = 0;
            if(val_42 == 0)
            {
                goto label_17;
            }
            
            val_44 = horzEdge;
            ClipperLibFerr.TEdge val_6 = val_44 + 8;
            if(0 != 1)
            {
                goto label_11;
            }
            
            label_9:
            val_44 = mem[this.m_Maxima + 8 + 4];
            val_44 = this.m_Maxima + 8 + 4;
            var val_35 = val_6;
            val_35 = val_35 - this.m_Maxima.X;
            if(horzEdge < 0)
            {
                goto label_8;
            }
            
            val_42 = this.m_Maxima.Next;
            if(val_42 != 0)
            {
                goto label_9;
            }
            
            val_43 = 0;
            goto label_10;
            label_15:
            var val_36 = val_6;
            val_36 = 0 - val_36;
            if(val_44 >= 0)
            {
                goto label_13;
            }
            
            val_42 = this.m_Maxima.Next;
            label_11:
            if(this.m_Maxima.Next.Next != 0)
            {
                goto label_15;
            }
            
            label_13:
            var val_37 = horzEdge + 40;
            val_37 = val_37 - this.m_Maxima.Next.X;
            if(horzEdge < 0)
            {
                    0 = 1;
            }
            
            if(1 != 0)
            {
                    val_43 = val_42;
            }
            
            label_10:
            val_39 = val_39;
            goto label_17;
            label_8:
            val_39 = val_39;
            var val_38 = horzEdge + 40;
            val_38 = (this.m_Maxima + 8) - val_38;
            if(horzEdge < 0)
            {
                    0 = 1;
            }
            
            if(1 != 0)
            {
                    val_43 = val_42;
            }
            
            label_17:
            val_45 = horzEdge;
            goto label_19;
            label_72:
            if((ClipperLibFerr.ClipperBase.IsHorizontal(e:  horzEdge + 112)) == false)
            {
                goto label_21;
            }
            
            this.UpdateEdgeIntoAEL(e: ref  ClipperLibFerr.TEdge val_8 = 1377896172);
            if((horzEdge + 100) >= 0)
            {
                    val_44 = horzEdge;
                ClipperLibFerr.OutPt val_9 = this.AddOutPt(e:  val_44, pt:  new ClipperLibFerr.IntPoint() {X = horzEdge + 8, Y = horzEdge + 16});
            }
            
            val_41 = horzEdge;
            0.GetHorzDirection(HorzEdge:  val_41, Dir: out  ClipperLibFerr.Direction val_10 = 1377896168, Left: out  long val_11 = 1377896160, Right: out  0);
            val_45 = horzEdge;
            label_19:
            if(0 == 1)
            {
                    120 = 116;
            }
            
            val_46 = mem[horzEdge + 116];
            val_46 = horzEdge + 116;
            if(val_46 == 0)
            {
                goto label_70;
            }
            
            label_69:
            if(val_43 == 0)
            {
                goto label_27;
            }
            
            var val_13 = val_46 + 24;
            if(0 != 1)
            {
                goto label_41;
            }
            
            label_34:
            val_37 = mem[(horzEdge + 116 + 24)];
            val_37 = val_13;
            long val_39 = this.m_Maxima.X;
            val_41 = mem[this.m_Maxima + 8 + 4];
            val_41 = this.m_Maxima + 8 + 4;
            val_39 = val_39 - val_37;
            if(0 >= 1)
            {
                goto label_36;
            }
            
            if((val_39 != 0) && ((horzEdge + 100) >= 0))
            {
                    val_44 = horzEdge;
                ClipperLibFerr.IntPoint val_14 = new ClipperLibFerr.IntPoint(X:  val_41, Y:  this.m_Maxima + 8);
                val_37 = val_14.X;
                val_38 = val_14.X;
                val_41 = val_44;
                ClipperLibFerr.OutPt val_15 = this.AddOutPt(e:  val_41, pt:  new ClipperLibFerr.IntPoint() {X = val_37, Y = val_14.Y});
            }
            
            if(this.m_Maxima.Next != 0)
            {
                goto label_34;
            }
            
            goto label_35;
            label_41:
            val_37 = mem[(horzEdge + 116 + 24)];
            val_37 = val_13;
            long val_40 = this.m_Maxima.X;
            val_41 = mem[this.m_Maxima + 8 + 4];
            val_41 = this.m_Maxima + 8 + 4;
            val_40 = val_37 - val_40;
            if(0 >= 1)
            {
                goto label_36;
            }
            
            if((val_39 != 0) && ((horzEdge + 100) >= 0))
            {
                    val_44 = horzEdge;
                ClipperLibFerr.IntPoint val_16 = new ClipperLibFerr.IntPoint(X:  val_41, Y:  this.m_Maxima + 8);
                val_37 = val_16.X;
                val_38 = val_16.X;
                val_41 = val_44;
                ClipperLibFerr.OutPt val_17 = this.AddOutPt(e:  val_41, pt:  new ClipperLibFerr.IntPoint() {X = val_37, Y = val_16.Y});
            }
            
            if(this.m_Maxima.Prev != 0)
            {
                goto label_41;
            }
            
            label_35:
            val_43 = 0;
            label_36:
            val_46 = val_46;
            goto label_42;
            label_27:
            val_43 = 0;
            label_42:
            val_39 = val_46;
            val_42 = mem[horzEdge + 116 + 24];
            val_42 = horzEdge + 116 + 24;
            if(0 != 1)
            {
                goto label_43;
            }
            
            long val_41 = 0;
            val_41 = val_41 - val_42;
            if(0 >= 1)
            {
                goto label_46;
            }
            
            goto label_54;
            label_43:
            if(0 != 0)
            {
                goto label_46;
            }
            
            long val_42 = 0;
            val_42 = val_42 - val_42;
            if(0 < 0)
            {
                goto label_54;
            }
            
            label_46:
            var val_43 = horzEdge + 40;
            val_41 = (horzEdge + 116 + 24 + 4) ^ val_41;
            val_47 = 0;
            val_43 = val_42 ^ val_43;
            val_42 = val_46;
            if((horzEdge == 0) && ((horzEdge + 112) != 0))
            {
                    if((horzEdge + 112) < 0)
            {
                goto label_54;
            }
            
            }
            
            if((val_39 == 0) || ((horzEdge + 100) < 0))
            {
                goto label_57;
            }
            
            ClipperLibFerr.OutPt val_18 = this.AddOutPt(e:  horzEdge, pt:  new ClipperLibFerr.IntPoint() {X = horzEdge + 116 + 24, Y = horzEdge + 116 + 32});
            val_48 = this.m_SortedEdges;
            goto label_58;
            label_63:
            if(this.m_SortedEdges.OutIdx < 0)
            {
                goto label_62;
            }
            
            val_49 = horzEdge;
            if(horzEdge != 0)
            {
                goto label_60;
            }
            
            val_49 = horzEdge;
            if(val_49 == 0)
            {
                goto label_99;
            }
            
            label_60:
            val_44 = this.m_SortedEdges.Top;
            if((this.HorzSegmentsOverlap(seg1a:  this.m_SortedEdges + 40 + -28, seg1b:  horzEdge + 12, seg2a:  horzEdge + 44, seg2b:  this.m_SortedEdges + 40 + -28)) != false)
            {
                    ClipperLibFerr.OutPt val_20 = this.GetLastOutPt(e:  val_48);
                this.AddJoin(Op1:  1377908240, Op2:  1377908240, OffPt:  new ClipperLibFerr.IntPoint() {X = mem[this.m_SortedEdges + 40 + (4)]>>0&0x0, Y = mem[this.m_SortedEdges + 40 + (4)]});
            }
            
            label_62:
            val_48 = this.m_SortedEdges.NextInSEL;
            label_58:
            if(val_48 != 0)
            {
                goto label_63;
            }
            
            val_37 = mem[horzEdge + 8];
            val_37 = horzEdge + 8;
            val_36 = val_36;
            this.AddGhostJoin(Op:  1377908240, OffPt:  new ClipperLibFerr.IntPoint() {X = val_37, Y = horzEdge + 16});
            val_47 = 0;
            label_57:
            if(val_45 == horzEdge)
            {
                    horzEdge = val_40;
            }
            
            if(val_46 == horzEdge)
            {
                goto label_65;
            }
            
            val_39 = val_39;
            if(val_47 == 1)
            {
                    ClipperLibFerr.IntPoint val_21 = new ClipperLibFerr.IntPoint(X:  val_45, Y:  val_44);
                val_44 = val_21.X;
                val_51 = horzEdge;
                val_42 = val_46;
                val_52 = val_42;
            }
            else
            {
                    ClipperLibFerr.IntPoint val_22 = new ClipperLibFerr.IntPoint(X:  val_45, Y:  val_44);
                val_44 = val_22.X;
                val_50 = val_22.X;
                val_52 = horzEdge;
                val_42 = val_46;
                val_51 = val_42;
            }
            
            this.IntersectEdges(e1:  val_51, e2:  val_52, pt:  new ClipperLibFerr.IntPoint() {X = val_50, Y = val_44});
            if(val_47 == 1)
            {
                    120 = 116;
            }
            
            this.SwapPositionsInAEL(edge1:  horzEdge, edge2:  val_42);
            if((horzEdge + 116 + 116) != 0)
            {
                goto label_69;
            }
            
            goto label_70;
            label_54:
            val_39 = val_39;
            label_70:
            if((horzEdge + 112) != 0)
            {
                goto label_72;
            }
            
            label_21:
            if((val_36 != 0) || ((horzEdge + 100) < 0))
            {
                goto label_75;
            }
            
            ClipperLibFerr.OutPt val_23 = this.GetLastOutPt(e:  horzEdge);
            val_42 = this.m_SortedEdges;
            val_39 = val_36;
            goto label_76;
            label_81:
            if(this.m_SortedEdges.OutIdx < 0)
            {
                goto label_80;
            }
            
            val_53 = horzEdge;
            if(horzEdge != 0)
            {
                goto label_78;
            }
            
            val_53 = horzEdge;
            if(val_53 == 0)
            {
                goto label_99;
            }
            
            label_78:
            val_44 = val_42;
            val_36 = val_36;
            if((this.HorzSegmentsOverlap(seg1a:  this.m_SortedEdges.Top, seg1b:  horzEdge + 12, seg2a:  horzEdge + 44, seg2b:  horzEdge + 116 + 24 + 4)) != false)
            {
                    ClipperLibFerr.OutPt val_25 = this.GetLastOutPt(e:  val_42);
                this.AddJoin(Op1:  1377908240, Op2:  1377908240, OffPt:  new ClipperLibFerr.IntPoint() {X = mem[this.m_SortedEdges + 40 + (4)]>>0&0x0, Y = mem[this.m_SortedEdges + 40 + (4)]});
            }
            
            label_80:
            val_42 = this.m_SortedEdges.NextInSEL;
            label_76:
            if(val_42 != 0)
            {
                goto label_81;
            }
            
            this.AddGhostJoin(Op:  1377908240, OffPt:  new ClipperLibFerr.IntPoint() {X = horzEdge + 40, Y = horzEdge + 48});
            label_75:
            if(horzEdge == 0)
            {
                goto label_83;
            }
            
            val_54 = (horzEdge + 100) >> 31;
            if((horzEdge + 112) == 0)
            {
                goto label_84;
            }
            
            label_91:
            if(val_54 == 0)
            {
                goto label_85;
            }
            
            val_39.UpdateEdgeIntoAEL(e: ref  ClipperLibFerr.TEdge val_26 = 1377896172);
            return;
            label_65:
            if((horzEdge + 100) >= 0)
            {
                    ClipperLibFerr.TEdge val_27 = horzEdge + 40;
                this.AddLocalMaxPoly(e1:  horzEdge, e2:  0, pt:  new ClipperLibFerr.IntPoint() {X = mem[(horzEdge + 40) + (12)]>>0&0x0, Y = mem[(horzEdge + 40) + (4)]});
            }
            
            this.DeleteFromAEL(e:  horzEdge);
            label_94:
            this.DeleteFromAEL(e:  0);
            return;
            label_83:
            val_54 = (horzEdge + 100) >> 31;
            if((horzEdge + 112) != 0)
            {
                goto label_91;
            }
            
            label_84:
            if(val_54 != 0)
            {
                goto label_94;
            }
            
            ClipperLibFerr.OutPt val_28 = this.AddOutPt(e:  horzEdge, pt:  new ClipperLibFerr.IntPoint() {X = horzEdge + 40, Y = horzEdge + 48});
            goto label_94;
            label_85:
            val_55 = mem[horzEdge + 44];
            val_55 = horzEdge + 44;
            ClipperLibFerr.OutPt val_29 = this.AddOutPt(e:  horzEdge, pt:  new ClipperLibFerr.IntPoint() {X = horzEdge + 40, Y = horzEdge + 48});
            this.UpdateEdgeIntoAEL(e: ref  ClipperLibFerr.TEdge val_30 = 1377896172);
            if((horzEdge + 88) == 0)
            {
                    return;
            }
            
            val_57 = horzEdge;
            val_58 = val_57;
            if(val_57 != 0)
            {
                goto label_98;
            }
            
            val_58 = horzEdge;
            if(val_58 == 0)
            {
                goto label_99;
            }
            
            label_98:
            if((horzEdge + 120) == 0)
            {
                goto label_108;
            }
            
            var val_44 = horzEdge + 8;
            val_56 = val_57 ^ 1152921510279710444;
            val_44 = (horzEdge + 120 + 24) ^ val_44;
            if(horzEdge != 0)
            {
                goto label_108;
            }
            
            val_57 = horzEdge + 120;
            var val_45 = horzEdge + 16;
            val_56 = (horzEdge + 120 + 32 + 4) ^ val_56;
            val_45 = (horzEdge + 120 + 32) ^ val_45;
            if(((horzEdge != 0) || ((horzEdge + 120 + 88) == 0)) || ((horzEdge + 120 + 100) < 0))
            {
                goto label_108;
            }
            
            var val_46 = horzEdge + 120 + 32;
            val_46 = (horzEdge + 120 + 48) - val_46;
            if((horzEdge + 120 + 100) >= 0)
            {
                goto label_108;
            }
            
            val_55 = 0;
            val_56 = horzEdge + 120;
            if((ClipperLibFerr.ClipperBase.SlopesEqual(e1:  horzEdge, e2:  val_56, UseFullRange:  mem[1152921510279722544])) == false)
            {
                goto label_108;
            }
            
            val_59 = mem[horzEdge + 8];
            val_59 = horzEdge + 8;
            val_60 = horzEdge + 120;
            goto label_110;
            label_108:
            if((horzEdge + 116) == 0)
            {
                    return;
            }
            
            var val_47 = horzEdge + 8;
            ClipperLibFerr.TEdge val_32 = val_57 ^ 1152921510279710444;
            val_47 = (horzEdge + 116 + 24) ^ val_47;
            if(horzEdge != 0)
            {
                    return;
            }
            
            var val_48 = horzEdge + 16;
            val_32 = (horzEdge + 116 + 32 + 4) ^ val_32;
            val_48 = (horzEdge + 116 + 32) ^ val_48;
            if(horzEdge != 0)
            {
                    return;
            }
            
            if((horzEdge + 116 + 88) == 0)
            {
                    return;
            }
            
            if((horzEdge + 116 + 100) < 0)
            {
                    return;
            }
            
            var val_49 = horzEdge + 116 + 32;
            val_49 = (horzEdge + 116 + 48) - val_49;
            if((horzEdge + 116 + 100) >= 0)
            {
                    return;
            }
            
            if((ClipperLibFerr.ClipperBase.SlopesEqual(e1:  horzEdge, e2:  horzEdge + 116, UseFullRange:  mem[1152921510279722544])) == false)
            {
                    return;
            }
            
            val_59 = mem[horzEdge + 8];
            val_59 = horzEdge + 8;
            val_60 = horzEdge + 116;
            label_110:
            ClipperLibFerr.OutPt val_34 = this.AddOutPt(e:  val_60, pt:  new ClipperLibFerr.IntPoint() {X = val_59, Y = horzEdge + 16});
            this.AddJoin(Op1:  1377908240, Op2:  1377908240, OffPt:  new ClipperLibFerr.IntPoint() {X = horzEdge + 52, Y = horzEdge + 44});
            return;
            label_99:
        }
        private ClipperLibFerr.TEdge GetNextInAEL(ClipperLibFerr.TEdge e, ClipperLibFerr.Direction Direction)
        {
            if(Direction == 1)
            {
                    120 = 116;
            }
        
        }
        private bool IsMinima(ClipperLibFerr.TEdge e)
        {
            if(e == 0)
            {
                    return true;
            }
            
            if(e.Prev.NextInLML == e)
            {
                    return true;
            }
            
            ClipperLibFerr.TEdge val_1 = e.Next.NextInLML - e;
            if(e.Next != 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        private bool IsMaxima(ClipperLibFerr.TEdge e, double Y)
        {
            if(e == 0)
            {
                    return (bool)0;
            }
            
            if(e == 0)
            {
                    this = e.NextInLML;
            }
            
            if(e == 0)
            {
                    0 = this >> 5;
            }
            
            return (bool)0;
        }
        private bool IsIntermediate(ClipperLibFerr.TEdge e, double Y)
        {
            var val_1;
            if(e == 0)
            {
                    if(e.NextInLML != 0)
            {
                    val_1 = 1;
            }
            
                return (bool)val_1;
            }
            
            val_1 = 0;
            return (bool)val_1;
        }
        internal ClipperLibFerr.TEdge GetMaximaPair(ClipperLibFerr.TEdge e)
        {
            var val_3;
            ClipperLibFerr.TEdge val_4;
            ClipperLibFerr.TEdge val_5;
            ClipperLibFerr.TEdge val_6;
            val_3 = e + 40;
            val_4 = mem[e + 40 + 12];
            val_4 = e + 40 + 12;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[e.Next.Top + (0)]>>0&0x0, Y = mem[e.Next.Top + (8)]>>0&0x0}, b:  new ClipperLibFerr.IntPoint() {X = e.Top, Y = e + 40 + 8})) == false)
            {
                goto label_2;
            }
            
            val_5 = e.Next;
            if(e.Next.NextInLML == 0)
            {
                goto label_4;
            }
            
            label_2:
            val_6 = 0;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[e.Prev.Top + (0)]>>0&0x0, Y = mem[e.Prev.Top + (8)]>>0&0x0}, b:  new ClipperLibFerr.IntPoint() {X = mem[e + 40 + (0)], Y = mem[e + 40 + 8 + (0)]})) == false)
            {
                    return;
            }
            
            val_4 = e.Prev;
            if(e.Prev.NextInLML == 0)
            {
                    val_6 = e.Prev;
            }
            
            return;
            label_4:
            val_6 = e.Next;
        }
        internal ClipperLibFerr.TEdge GetMaximaPairEx(ClipperLibFerr.TEdge e)
        {
            ClipperLibFerr.TEdge val_1 = this.GetMaximaPair(e:  e);
            if(this == 2)
            {
                    return;
            }
            
            if(this != e)
            {
                    return;
            }
            
            if((ClipperLibFerr.ClipperBase.IsHorizontal(e:  1378801424)) == true)
            {
                    0 = this;
            }
        
        }
        private bool ProcessIntersections(long topY)
        {
            System.Collections.Generic.List<ClipperLibFerr.IntersectNode> val_2;
            var val_3;
            val_2 = R3;
            val_3 = 1;
            if(true == 0)
            {
                    return (bool)val_3;
            }
            
            this.BuildIntersectList(topY:  topY);
            val_2 = this.m_IntersectList;
            if(this == 0)
            {
                    return (bool)val_3;
            }
            
            if(this != 1)
            {
                    val_3 = 0;
                if(this.FixupIntersectionOrder() == false)
            {
                    return (bool)val_3;
            }
            
            }
            
            this.ProcessIntersectList();
            this.m_SortedEdges = 0;
            val_3 = 1;
            return (bool)val_3;
        }
        private void BuildIntersectList(long topY)
        {
            var val_4;
            ClipperLibFerr.TEdge val_8;
            var val_9;
            var val_10;
            var val_11;
            val_8 = mem[1152921510280860204];
            if(val_8 == 0)
            {
                    return;
            }
            
            mem[1152921510280860220] = val_8;
            do
            {
                var val_1 = val_8 + 128;
                mem2[0] = mem[1152921510280860204] + 120;
                var val_2 = val_8 + 124;
                mem2[0] = mem[1152921510280860204] + 116;
                mem2[0] = ClipperLibFerr.Clipper.TopX(edge:  val_8, currentY:  mem[1152921510280860204] + 116);
                val_8 = mem[1152921510280860204] + 116;
            }
            while((mem[1152921510280860204] + 116) != 0);
            
            label_19:
            if(mem[1152921510280860220] == 0)
            {
                goto label_18;
            }
            
            label_17:
            val_8 = mem[1152921510280860220];
            goto label_11;
            label_10:
            val_9 = 0;
            goto label_5;
            label_11:
            if(val_8 == 0)
            {
                goto label_6;
            }
            
            val_10 = mem[mem[1152921510280860204] + 124];
            val_10 = mem[1152921510280860204] + 124;
            if(val_10 == 0)
            {
                goto label_9;
            }
            
            val_11 = mem[mem[1152921510280860204] + 24];
            val_11 = mem[1152921510280860204] + 24;
            goto label_8;
            label_6:
            val_8 = 22020112;
            if(val_8 == 0)
            {
                goto label_9;
            }
            
            val_10 = 22020112;
            val_11 = mem[mem[1152921510280860204] + 24];
            val_11 = mem[1152921510280860204] + 24;
            if(val_10 == 0)
            {
                goto label_10;
            }
            
            label_8:
            val_9 = val_10;
            label_5:
            var val_9 = 1511920;
            val_9 = val_9 - val_11;
            if(val_10 >= 0)
            {
                goto label_11;
            }
            
            val_9.IntersectPoint(edge1:  val_8, edge2:  22020112, ip: out  new ClipperLibFerr.IntPoint() {X = 1152921510280848120});
            var val_10 = val_4;
            val_10 = val_10 - R2;
            if(val_10 < 0)
            {
                    long val_5 = ClipperLibFerr.Clipper.TopX(edge:  val_8, currentY:  val_8);
                ClipperLibFerr.IntPoint val_6 = new ClipperLibFerr.IntPoint(X:  val_8, Y:  val_8);
            }
            
            ClipperLibFerr.IntersectNode val_7 = 536889215;
            val_7 = new ClipperLibFerr.IntersectNode();
            if(val_7 != 0)
            {
                    mem[536889223] = val_8;
            }
            else
            {
                    mem[8] = val_8;
            }
            
            mem[536889227] = val_9;
            var val_8 = val_7 + 16;
            mem[1152921510280860224].Add(item:  536889215);
            this.SwapPositionsInSEL(edge1:  val_8, edge2:  22020112);
            goto label_17;
            label_9:
            if((mem[1152921510280860204] + 128) == 0)
            {
                goto label_18;
            }
            
            mem2[0] = 0;
            if(0 != 255)
            {
                goto label_19;
            }
            
            label_18:
            mem2[0] = 0;
        }
        private bool EdgesAdjacent(ClipperLibFerr.IntersectNode inode)
        {
            ClipperLibFerr.TEdge val_1 = inode.Edge2;
            if(inode.Edge1.NextInSEL == val_1)
            {
                    return true;
            }
            
            if(inode.Edge1 == 0)
            {
                    val_1 = inode.Edge2;
            }
            
            val_1 = inode.Edge1.PrevInSEL - val_1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        private static int IntersectNodeSort(ClipperLibFerr.IntersectNode node1, ClipperLibFerr.IntersectNode node2)
        {
            node1 = node2 - node1;
            return (int)node1;
        }
        private bool FixupIntersectionOrder()
        {
            System.Collections.Generic.IComparer<ClipperLibFerr.IntersectNode> val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_4 = this.m_IntersectNodeComparer;
            this.m_IntersectList.Sort(comparer:  val_4);
            this.CopyAELToSEL();
            val_5 = 1;
            if(SL < 1)
            {
                    return (bool)val_5;
            }
            
            val_4 = 0;
            val_6 = 5;
            var val_1 = 0 - SL;
            label_23:
            if(val_1 <= val_4)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            bool val_2 = val_5.EdgesAdjacent(inode:  (0 + 0) + 16);
            if(val_2 == true)
            {
                goto label_6;
            }
            
            label_10:
            val_7 = 1;
            if(val_7 >= SL)
            {
                goto label_7;
            }
            
            if(val_2 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = val_6 + 1;
            if((this.EdgesAdjacent(inode:  1)) == false)
            {
                goto label_10;
            }
            
            label_7:
            var val_6 = val_1;
            val_6 = val_6 + val_6;
            if(val_6 == 4)
            {
                goto label_11;
            }
            
            if(val_6 <= val_4)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            if(((0 + 0) + 16) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.m_IntersectList.set_Item(index:  0, value:  1);
            this.m_IntersectList.set_Item(index:  1, value:  (0 + 0) + 16);
            val_8 = val_6;
            label_6:
            if(this.m_IntersectList <= val_4)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + 0;
            if(val_8 <= val_4)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + 0;
            val_7 = mem[(0 + 0) + 16];
            val_7 = (0 + 0) + 16;
            this.SwapPositionsInSEL(edge1:  (0 + 0) + 16 + 8, edge2:  (0 + 0) + 16 + 12);
            val_4 = val_4 + 1;
            val_9 = val_8 + 1;
            if(val_4 < SL)
            {
                goto label_23;
            }
            
            val_5 = 1;
            return (bool)val_5;
            label_11:
            val_5 = 0;
            return (bool)val_5;
        }
        private void ProcessIntersectList()
        {
            var val_1;
            System.Collections.Generic.List<ClipperLibFerr.IntersectNode> val_2;
            var val_3;
            float val_4;
            var val_5;
            var val_6;
            var val_7;
            val_1 = 0;
            goto label_1;
            label_9:
            val_2 = this.m_IntersectList;
            if(val_2 == 0)
            {
                    val_2 = 0;
            }
            
            if(val_1 >= (R5 + 12))
            {
                goto label_3;
            }
            
            label_10:
            if(0 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = 0;
            val_2 = val_2 + 0;
            if(((0 + 0) + 16) != 0)
            {
                    val_3 = (0 + 0) + 16;
                val_4 = mem[(0 + 0) + 16 + 8];
                val_4 = (0 + 0) + 16 + 8;
                val_5 = (0 + 0) + 16 + 8;
                val_6 = mem[(0 + 0) + 16 + 8 + 4];
                val_6 = (0 + 0) + 16 + 8 + 4;
            }
            else
            {
                    val_3 = 8;
                val_4 = 0f;
                val_5 = 12;
                val_6 = 0;
            }
            
            var val_1 = ((0 + 0) + 16) + 16;
            this.IntersectEdges(e1:  0, e2:  0, pt:  new ClipperLibFerr.IntPoint() {X = mem[((0 + 0) + 16 + 16) + (12)]>>0&0x0, Y = mem[((0 + 0) + 16 + 16) + (4)]});
            if(((0 + 0) + 16) != 0)
            {
                
            }
            else
            {
                    val_7 = 0;
            }
            
            this.SwapPositionsInAEL(edge1:  0, edge2:  0);
            val_1 = 1;
            label_1:
            val_2 = this.m_IntersectList;
            if(val_2 == 0)
            {
                goto label_9;
            }
            
            if(val_1 < this)
            {
                goto label_10;
            }
            
            label_3:
            val_2.Clear();
        }
        internal static long Round(double value)
        {
            if(>=0)
            {
                    -0.5 = 0.5;
            }
            
            double val_1 = (-0.5) + 0;
            return (long)R1;
        }
        private static long TopX(ClipperLibFerr.TEdge edge, long currentY)
        {
            var val_2;
            ClipperLibFerr.IntPoint val_3;
            var val_4;
            double val_5;
            ClipperLibFerr.IntPoint val_6;
            if(edge == 0)
            {
                goto label_0;
            }
            
            val_2 = currentY ^ R3;
            edge = edge ^ R2;
            if(edge == 0)
            {
                goto label_1;
            }
            
            val_3 = edge.Bot;
            val_5 = edge.Dx;
            goto label_2;
            label_0:
            var val_1 = 6;
            val_1 = val_1 ^ R3;
            val_2 = 1835037 ^ R2;
            val_4 = val_2 | val_1;
            if(val_4 != 0)
            {
                goto label_3;
            }
            
            label_1:
            val_6 = edge.Top;
            return (long)val_6;
            label_3:
            val_4 = 0;
            val_3 = 0;
            var val_2 = 72;
            val_5 = 1.26480805335359E-321;
            label_2:
            val_2 = R2 - val_2;
            var val_3 = val_2;
            val_3 = val_5 * val_3;
            if(val_4 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_3 = val_3 + (-0.5);
            val_6 = val_3 + val_2;
            return (long)val_6;
        }
        private void IntersectPoint(ClipperLibFerr.TEdge edge1, ClipperLibFerr.TEdge edge2, out ClipperLibFerr.IntPoint ip)
        {
            var val_14;
            var val_15;
            var val_18;
            bool val_19;
            var val_20;
            var val_23;
            ClipperLibFerr.IntPoint val_24;
            ClipperLibFerr.IntPoint val_25;
            double val_26;
            var val_27;
            var val_28;
            val_14 = 22970905;
            if(edge2 != 0)
            {
                goto label_3;
            }
            
            mem[1152921510281880888] = edge2;
            long val_1 = ClipperLibFerr.Clipper.TopX(edge:  edge1, currentY:  edge1);
            goto label_4;
            label_3:
            if(edge2 == 0)
            {
                goto label_5;
            }
            
            if(edge2 == 0)
            {
                goto label_6;
            }
            
            if(edge2 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            -0.5 = (((mem[edge2.Bot + (0)]) - edge1.Bot) / (edge1.Dx - edge2.Dx)) + (-0.5);
            val_18 = 1152921510281880880;
            mem[1152921510281880888] = edge1.Bot;
            mem[1152921510281880892] = edge1.Bot;
            val_19 = mem[536890482];
            if((val_19 & true) == 0)
            {
                    val_19 = mem[536890411];
            }
            
            double val_13 = System.Math.Abs(edge1.Dx);
            double val_14 = System.Math.Abs(edge2.Dx);
            if(val_19 >= 0)
            {
                goto label_9;
            }
            
            if(val_19 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_20 = edge1.Bot + (-0.5);
            goto label_10;
            label_5:
            ip.X = edge1.Bot;
            if((ClipperLibFerr.ClipperBase.IsHorizontal(e:  edge2)) == true)
            {
                goto label_11;
            }
            
            val_23 = edge2;
            val_14 = 0;
            val_24 = edge2.Bot;
            val_25 = ip.X;
            val_26 = edge2.Dx;
            goto label_12;
            label_6:
            ip.X = edge2.Bot;
            bool val_6 = ClipperLibFerr.ClipperBase.IsHorizontal(e:  edge1);
            if(val_6 == false)
            {
                goto label_13;
            }
            
            label_11:
            val_18 = 1152921510281880880;
            mem[1152921510281880888] = edge2;
            mem[1152921510281880892] = 0;
            goto label_15;
            label_9:
            if(val_19 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_20 = (mem[edge2.Bot + (0)]) + (-0.5);
            label_10:
            ip.X = val_19;
            goto label_15;
            label_13:
            val_23 = edge2;
            val_14 = 0;
            val_24 = edge1.Bot;
            val_25 = ip.X;
            val_26 = edge1.Dx;
            label_12:
            ClipperLibFerr.IntPoint val_7 = val_24 / val_26;
            var val_15 = val_25;
            val_15 = val_15 / val_26;
            val_7 = val_23 - val_7;
            val_15 = val_7 + val_15;
            if(val_6 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_15 = val_15 + (-0.5);
            mem[1152921510281880888] = 5927340953336685872;
            val_18 = 1152921510281880888;
            label_15:
            var val_8 = val_18 - 1380066608;
            if(val_6 < false)
            {
                goto label_16;
            }
            
            long val_9 = val_18 - val_25;
            if(val_6 >= false)
            {
                goto label_17;
            }
            
            label_16:
            long val_10 = val_25 - 1380066608;
            if(val_6 < false)
            {
                    0 = 1;
            }
            
            if(1 != 0)
            {
                    val_25 = 1380066608;
                val_27 = 1152921510281880880;
            }
            
            mem[1152921510281880888] = val_25;
            mem[1152921510281880892] = val_27;
            if(((mem[536890482] & true) == 0) && (mem[536890411] == 0))
            {
                    val_27 = mem[1152921510281880892];
            }
            
            double val_16 = System.Math.Abs(edge1.Dx);
            double val_17 = System.Math.Abs(edge2.Dx);
            ip.X = ClipperLibFerr.Clipper.TopX(edge:  edge2 = edge1, currentY:  1152921510281880880);
            label_17:
            if(mem[536890411] >= 0)
            {
                    return;
            }
            
            mem[1152921510281880888] = 1152921510281880880;
            mem[1152921510281880892] = val_27;
            if(((mem[536890482] & true) == 0) && (mem[536890411] == 0))
            {
                    val_28 = mem[1152921510281880892];
            }
            
            double val_18 = System.Math.Abs(edge1.Dx);
            double val_19 = System.Math.Abs(edge2.Dx);
            if(mem[536890411] <= 0)
            {
                    536890295 = edge1;
            }
            
            val_15 = 1152921510281880880;
            label_4:
            ip.X = ClipperLibFerr.Clipper.TopX(edge:  536890295 = edge2, currentY:  1152921510281880880);
        }
        private void ProcessEdgesAtTopOfScanbeam(long topY)
        {
            ClipperLibFerr.Clipper val_16;
            long val_17;
            float val_18;
            long val_20;
            ClipperLibFerr.TEdge val_21;
            var val_22;
            var val_23;
            ClipperLibFerr.TEdge val_24;
            long val_25;
            var val_26;
            long val_27;
            ClipperLibFerr.TEdge val_28;
            var val_29;
            ClipperLibFerr.Clipper val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            long val_36;
            ClipperLibFerr.TEdge val_37;
            val_16 = this;
            val_17 = R3;
            val_18 = R2;
            if(R7 == 0)
            {
                goto label_0;
            }
            
            val_20 = val_17;
            goto label_34;
            label_16:
            val_21 = R7;
            ClipperLibFerr.TEdge val_1 = GetMaximaPairEx(e:  val_21);
            if(1380142640 == 0)
            {
                goto label_3;
            }
            
            val_22 = 0;
            if((ClipperLibFerr.ClipperBase.IsHorizontal(e:  1380142640)) == false)
            {
                goto label_3;
            }
            
            val_23 = ???;
            if(val_23 != 0)
            {
                goto label_4;
            }
            
            goto label_65;
            label_3:
            if((this.<StrictlySimple>k__BackingField) != false)
            {
                    this.InsertMaxima(X:  val_21);
            }
            
            val_24 = ???;
            if((???) == 0)
            {
                    val_24 = ???;
            }
            
            this.DoMaxima(e:  val_24);
            if((??? + 120) != 0)
            {
                    ??? = mem[??? + 120 + 116];
                ??? = ??? + 120 + 116;
            }
            
            goto label_9;
            label_32:
            if((??? + 120 + 116 + 100) < 0)
            {
                goto label_30;
            }
            
            val_26 = ???;
            var val_15 = val_26 + 24;
            val_16 = val_16;
            val_24 = (??? + 120) ^ val_24;
            val_15 = (??? + 120 + 116 + 24) ^ val_15;
            if((val_26 != 0) || ((??? + 120 + 116 + 88) == 0))
            {
                goto label_30;
            }
            
            ClipperLibFerr.IntPoint val_3 = new ClipperLibFerr.IntPoint(pt:  new ClipperLibFerr.IntPoint() {X = ??? + 36, Y = ??? + 28});
            ClipperLibFerr.OutPt val_4 = this.AddOutPt(e:  ???, pt:  new ClipperLibFerr.IntPoint() {X = val_3.X, Y = val_3.Y});
            ClipperLibFerr.OutPt val_5 = this.AddOutPt(e:  ???, pt:  new ClipperLibFerr.IntPoint() {X = val_3.X, Y = val_3.Y});
            val_27 = val_3.X;
            this.AddJoin(Op1:  1380154704, Op2:  1380154704, OffPt:  new ClipperLibFerr.IntPoint() {X = val_27, Y = val_3.X});
            goto label_30;
            label_34:
            if(R7 == 0)
            {
                    R7 + 48 = mem[R7 + 112];
                R7 + 48 = R7 + 112;
            }
            
            if((R7 + 48) == 0)
            {
                goto label_16;
            }
            
            label_4:
            if(((R7 + 48) != 0) || ((R7 + 112) == 0))
            {
                goto label_20;
            }
            
            val_20 = 0;
            if((ClipperLibFerr.ClipperBase.IsHorizontal(e:  ??? + 112)) == false)
            {
                goto label_20;
            }
            
            val_16.UpdateEdgeIntoAEL(e: ref  ClipperLibFerr.TEdge val_7 = 1380142652);
            if((??? + 100) >= 0)
            {
                    val_27 = mem[??? + 12];
                val_27 = ??? + 12;
                ClipperLibFerr.OutPt val_8 = this.AddOutPt(e:  ???, pt:  new ClipperLibFerr.IntPoint() {X = ??? + 8, Y = ??? + 16});
            }
            
            this.AddEdgeToSEL(edge:  ???);
            goto label_24;
            label_20:
            val_28 = ???;
            if((???) == 0)
            {
                    val_28 = ???;
            }
            
            val_27 = val_17;
            mem2[0] = ClipperLibFerr.Clipper.TopX(edge:  val_28, currentY:  val_20);
            mem2[0] = val_18;
            mem2[0] = val_17;
            label_24:
            if((this.<StrictlySimple>k__BackingField) == false)
            {
                goto label_30;
            }
            
            val_29 = ???;
            if((???) != 0)
            {
                goto label_28;
            }
            
            val_29 = ???;
            if(val_29 == 0)
            {
                goto label_65;
            }
            
            label_28:
            if((val_29 + 100) < 0)
            {
                goto label_30;
            }
            
            if((??? + 120) != 0)
            {
                    val_29 + 100 = mem[??? + 88];
                val_29 + 100 = ??? + 88;
            }
            
            if((val_29 + 100) != 0)
            {
                goto label_32;
            }
            
            label_30:
            val_25 = mem[??? + 116];
            val_25 = ??? + 116;
            label_9:
            if(val_25 != 0)
            {
                goto label_34;
            }
            
            label_0:
            this.ProcessHorizontals();
            this.m_Maxima = 0;
            if((???) == 0)
            {
                    return;
            }
            
            label_74:
            if(((???) != 0) || ((??? + 112) == 0))
            {
                goto label_68;
            }
            
            if((??? + 100) >= 0)
            {
                    val_30 = val_16;
                val_27 = mem[??? + 44];
                val_27 = ??? + 44;
                val_31 = val_30;
                ClipperLibFerr.OutPt val_10 = this.AddOutPt(e:  ???, pt:  new ClipperLibFerr.IntPoint() {X = ??? + 40, Y = ??? + 48});
            }
            else
            {
                    val_31 = 0;
                val_30 = val_16;
            }
            
            this.UpdateEdgeIntoAEL(e: ref  ClipperLibFerr.TEdge val_11 = 1380142652);
            val_33 = ???;
            if((???) != 0)
            {
                goto label_41;
            }
            
            val_33 = ???;
            if(val_33 == 0)
            {
                goto label_65;
            }
            
            label_41:
            val_17 = mem[??? + 120];
            val_17 = ??? + 120;
            val_26 = mem[val_33 + 116];
            val_26 = val_33 + 116;
            if(val_17 == 0)
            {
                goto label_53;
            }
            
            val_16 = mem[??? + 120 + 24];
            val_16 = ??? + 120 + 24;
            val_25 = mem[??? + 120 + 24 + 4];
            val_25 = ??? + 120 + 24 + 4;
            var val_16 = ??? + 8;
            val_32 = val_25 ^ 1152921510281956924;
            val_16 = val_16 ^ val_16;
            if((???) != 0)
            {
                goto label_53;
            }
            
            val_18 = ???;
            val_16 = mem[??? + 120 + 32];
            val_16 = ??? + 120 + 32;
            val_25 = mem[??? + 120 + 32 + 4];
            val_25 = ??? + 120 + 32 + 4;
            if(val_31 == 0)
            {
                goto label_53;
            }
            
            var val_17 = val_18 + 16;
            val_32 = val_25 ^ val_32;
            val_17 = val_16 ^ val_17;
            if((val_31 != 0) || ((??? + 120 + 100) < 0))
            {
                goto label_53;
            }
            
            val_25 = val_17;
            var val_18 = ??? + 120 + 48;
            val_32 = mem[??? + 120 + 48 + 4];
            val_32 = ??? + 120 + 48 + 4;
            val_18 = val_18 - (??? + 120 + 32);
            if((??? + 120 + 100) >= 0)
            {
                goto label_53;
            }
            
            val_34 = ???;
            if((???) != 0)
            {
                goto label_51;
            }
            
            val_34 = ???;
            if(val_34 == 0)
            {
                goto label_65;
            }
            
            label_51:
            val_16 = mem[val_34 + 40];
            val_16 = val_34 + 40;
            val_18 = mem[val_34 + 48];
            val_18 = val_34 + 48;
            val_25 = mem[??? + 120 + 48];
            val_25 = ??? + 120 + 48;
            val_32 = ??? + 28;
            val_27 = ??? + 36;
            if((ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = ??? + 24, Y = ??? + 32}, pt2:  new ClipperLibFerr.IntPoint() {X = val_16, Y = val_18}, pt3:  new ClipperLibFerr.IntPoint() {X = ??? + 120 + 24, Y = ??? + 120 + 32}, pt4:  new ClipperLibFerr.IntPoint() {X = ??? + 120 + 40, Y = val_25}, UseFullRange:  ??? + 28 + 32)) != false)
            {
                    if((??? + 88) != 0)
            {
                    ??? + 88 = mem[??? + 120 + 88];
                ??? + 88 = ??? + 120 + 88;
                goto label_55;
            }
            
            }
            
            label_53:
            if(val_26 == 0)
            {
                goto label_68;
            }
            
            val_25 = ???;
            val_16 = mem[val_33 + 116 + 24 + 4];
            val_16 = val_33 + 116 + 24 + 4;
            var val_19 = val_25 + 8;
            val_32 = val_16 ^ val_32;
            val_19 = (val_33 + 116 + 24) ^ val_19;
            if(val_25 != 0)
            {
                goto label_68;
            }
            
            val_16 = ???;
            val_17 = mem[val_33 + 116 + 32];
            val_17 = val_33 + 116 + 32;
            val_25 = mem[val_33 + 116 + 32 + 4];
            val_25 = val_33 + 116 + 32 + 4;
            if((??? + 24) == 0)
            {
                goto label_68;
            }
            
            var val_20 = val_16 + 16;
            val_32 = val_25 ^ val_32;
            val_20 = val_17 ^ val_20;
            if(((??? + 24) != 0) || ((val_33 + 116 + 100) < 0))
            {
                goto label_68;
            }
            
            val_25 = val_26;
            var val_21 = val_33 + 116 + 48;
            val_21 = val_21 - (val_33 + 116 + 32);
            if((val_33 + 116 + 100) >= 0)
            {
                goto label_68;
            }
            
            val_35 = ???;
            if((???) != 0)
            {
                goto label_64;
            }
            
            val_35 = ???;
            if(val_35 == 0)
            {
                goto label_65;
            }
            
            label_64:
            val_16 = mem[val_35 + 40];
            val_16 = val_35 + 40;
            val_17 = mem[val_35 + 48];
            val_17 = val_35 + 48;
            val_25 = mem[val_33 + 116 + 48];
            val_25 = val_33 + 116 + 48;
            if((ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = ??? + 24, Y = ??? + 32}, pt2:  new ClipperLibFerr.IntPoint() {X = val_16, Y = val_17}, pt3:  new ClipperLibFerr.IntPoint() {X = mem[val_33 + 116 + 24 + (0)], Y = val_33 + 116 + 32}, pt4:  new ClipperLibFerr.IntPoint() {X = val_33 + 116 + 40, Y = val_25}, UseFullRange:  ??? + 28 + 32)) == false)
            {
                goto label_68;
            }
            
            if((??? + 88) != 0)
            {
                    ??? + 88 = mem[val_33 + 116 + 88];
                ??? + 88 = val_33 + 116 + 88;
            }
            
            if((??? + 88) == 0)
            {
                goto label_68;
            }
            
            val_36 = mem[??? + 8];
            val_36 = ??? + 8;
            val_37 = val_26;
            goto label_70;
            label_55:
            val_36 = mem[??? + 8];
            val_36 = ??? + 8;
            val_37 = val_17;
            label_70:
            val_16 = ??? + 28;
            ClipperLibFerr.OutPt val_14 = val_16.AddOutPt(e:  val_37, pt:  new ClipperLibFerr.IntPoint() {X = val_36, Y = ??? + 16});
            val_16.AddJoin(Op1:  ??? + 24, Op2:  val_16, OffPt:  new ClipperLibFerr.IntPoint() {X = ??? + 52, Y = ??? + 44});
            label_68:
            if((??? + 116) != 0)
            {
                goto label_74;
            }
            
            return;
            label_65:
        }
        private void DoMaxima(ClipperLibFerr.TEdge e)
        {
            var val_8;
            long val_9;
            ClipperLibFerr.TEdge val_1 = this.GetMaximaPairEx(e:  e);
            if(this == 0)
            {
                goto label_1;
            }
            
            if(e.NextInAEL != this)
            {
                    ClipperLibFerr.TEdge val_2 = e + 48;
                do
            {
                this.IntersectEdges(e1:  e, e2:  e.NextInAEL, pt:  new ClipperLibFerr.IntPoint() {Y = e});
                this.SwapPositionsInAEL(edge1:  e, edge2:  e.NextInAEL);
            }
            while(e.NextInAEL != this);
            
            }
            
            if(e.OutIdx == 1)
            {
                goto label_4;
            }
            
            if(e.OutIdx < 0)
            {
                goto label_5;
            }
            
            if(e.OutIdx < 0)
            {
                goto label_6;
            }
            
            this.AddLocalMaxPoly(e1:  e, e2:  1380278992, pt:  new ClipperLibFerr.IntPoint() {X = mem[e.Top + (12)]>>0&0x0, Y = mem[e.Top + (4)]});
            goto label_7;
            label_1:
            if(e.OutIdx >= 0)
            {
                    ClipperLibFerr.OutPt val_3 = this.AddOutPt(e:  e, pt:  new ClipperLibFerr.IntPoint() {X = e.Top, Y = e.OutIdx});
            }
            
            val_8 = e;
            goto label_9;
            label_4:
            val_9 = 1;
            if(e != 1)
            {
                goto label_12;
            }
            
            label_7:
            this.DeleteFromAEL(e:  e);
            goto label_15;
            label_5:
            val_9 = 1;
            goto label_12;
            label_6:
            val_9 = 0;
            label_12:
            if(e.WindDelta != 0)
            {
                goto label_13;
            }
            
            if(val_9 == 0)
            {
                    ClipperLibFerr.OutPt val_4 = this.AddOutPt(e:  e, pt:  new ClipperLibFerr.IntPoint() {X = e.Top, Y = val_9});
                e.OutIdx = 0;
            }
            
            this.DeleteFromAEL(e:  e);
            if(this >= 0)
            {
                    ClipperLibFerr.OutPt val_5 = this.AddOutPt(e:  1380278992, pt:  new ClipperLibFerr.IntPoint() {X = e.Top, Y = this});
                mem[1152921510282093364] = 0;
            }
            
            label_15:
            val_8 = this;
            label_9:
            val_8.DeleteFromAEL(e:  1380278992);
            return;
            label_13:
            22709868 = new ClipperLibFerr.ClipperException(description:  22784968);
        }
        public static void ReversePaths(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> polys)
        {
            var val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_3.Reverse();
            goto label_4;
            label_2:
            Dispose();
        }
        public static bool Orientation(System.Collections.Generic.List<ClipperLibFerr.IntPoint> poly)
        {
            double val_1 = ClipperLibFerr.Clipper.Area(poly:  poly);
            if()
            {
                    0 = 1;
            }
            
            return true;
        }
        private int PointCount(ClipperLibFerr.OutPt pts)
        {
            var val_1;
            if(pts != 0)
            {
                    do
            {
                val_1 = 0 + 1;
            }
            while(pts.Next != pts);
            
                return (int)val_1;
            }
            
            val_1 = 0;
            return (int)val_1;
        }
        private void BuildResult(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> polyg)
        {
            var val_3;
            polyg.Clear();
            polyg.Capacity = mem[22970919];
            var val_4 = 0;
            label_10:
            if(val_4 >= (mem[22970919] + 12))
            {
                    return;
            }
            
            if((mem[22970919] + 12) <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = mem[22970919] + 8;
            val_3 = val_3 + 0;
            if(((mem[22970919] + 8 + 0) + 16 + 20 + 36) != 0)
            {
                goto label_9;
            }
            
            label_18:
            val_4 = val_4 + 1;
            goto label_10;
            label_9:
            int val_5 = 0;
            do
            {
                val_5 = val_5 + 1;
            }
            while(((mem[22970919] + 8 + 0) + 16 + 20 + 36 + 32) != ((mem[22970919] + 8 + 0) + 16 + 20 + 36));
            
            if(val_5 < 2)
            {
                goto label_18;
            }
            
            536878005 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>(capacity:  val_5);
            var val_6 = 0;
            do
            {
                var val_2 = ((mem[22970919] + 8 + 0) + 16 + 20 + 36) + 20;
                val_3 = 536878005;
                if(val_3 == 0)
            {
                    val_3 = 536878005;
            }
            
                val_3.Add(item:  new ClipperLibFerr.IntPoint() {X = 536878005, Y = mem[((mem[22970919] + 8 + 0) + 16 + 20 + 36 + 20) + (0)]});
                val_6 = val_6 + 1;
            }
            while(val_5 != val_6);
            
            polyg.Add(item:  536878005);
            goto label_18;
        }
        private void BuildResult2(ClipperLibFerr.PolyTree polytree)
        {
            ClipperLibFerr.Clipper val_3;
            var val_4;
            ClipperLibFerr.OutRec val_5;
            int val_6;
            ClipperLibFerr.PolyTree val_7;
            var val_8;
            ClipperLibFerr.PolyTree val_9;
            var val_10;
            ClipperLibFerr.PolyNode val_11;
            val_3 = this;
            if(polytree != 0)
            {
                    polytree.Clear();
            }
            else
            {
                    0.Clear();
            }
            
            polytree.m_AllPolys.Capacity = polytree;
            val_4 = 0;
            goto label_5;
            label_27:
            if(polytree.m_AllPolys <= val_4)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            val_5 = mem[(0 + 0) + 16];
            val_5 = (0 + 0) + 16;
            val_6 = 0;
            if(((0 + 0) + 16 + 20) != 0)
            {
                    do
            {
                val_6 = val_6 + 1;
            }
            while(((0 + 0) + 16 + 20 + 32) != ((0 + 0) + 16 + 20));
            
            }
            
            if(val_6 <= 1)
            {
                    if(((0 + 0) + 16 + 13) != 0)
            {
                goto label_22;
            }
            
            }
            
            if(val_6 <= 2)
            {
                    if(((0 + 0) + 16 + 13) == 0)
            {
                goto label_22;
            }
            
            }
            
            (0 + 0) + 16 + 13.FixHoleLinkage(outRec:  val_5);
            ClipperLibFerr.PolyNode val_1 = 536891939;
            val_1 = new ClipperLibFerr.PolyNode();
            val_7 = polytree;
            if(val_7 == 0)
            {
                    val_7 = polytree;
            }
            
            polytree + 36.Add(item:  536891939);
            mem2[0] = val_1;
            mem[536891951].Capacity = val_6;
            val_8 = mem[(0 + 0) + 16 + 20];
            val_8 = (0 + 0) + 16 + 20;
            if(val_6 >= 1)
            {
                    do
            {
                val_8 = mem[(0 + 0) + 16 + 20 + 36];
                val_8 = (0 + 0) + 16 + 20 + 36;
                val_5 = mem[536891951];
                var val_2 = val_8 + 20;
                val_5.Add(item:  new ClipperLibFerr.IntPoint() {X = val_6, Y = mem[((0 + 0) + 16 + 20 + 36 + 20) + (0)]});
                val_6 = val_6 - 1;
            }
            while(val_5 != 0);
            
            }
            
            label_22:
            val_3 = val_3;
            val_4 = val_4 + 1;
            label_5:
            if(val_4 < (mem[1152921510282714728] + 12))
            {
                goto label_27;
            }
            
            val_9 = polytree;
            if(val_9 == 0)
            {
                    val_9 = polytree;
            }
            
            polytree + 28.Capacity = mem[1152921510282714728] + 12;
            val_10 = 0;
            goto label_31;
            label_41:
            if((mem[1152921510282714728] + 12) <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = mem[1152921510282714728] + 8;
            val_4 = val_4 + 0;
            val_5 = mem[(mem[1152921510282714728] + 8 + 0) + 16];
            val_5 = (mem[1152921510282714728] + 8 + 0) + 16;
            val_11 = mem[(mem[1152921510282714728] + 8 + 0) + 16 + 28];
            val_11 = (mem[1152921510282714728] + 8 + 0) + 16 + 28;
            if(val_11 == 0)
            {
                goto label_35;
            }
            
            if(((mem[1152921510282714728] + 8 + 0) + 16 + 13) != 0)
            {
                    mem2[0] = 1;
                val_11 = mem[(mem[1152921510282714728] + 8 + 0) + 16 + 28];
                val_11 = (mem[1152921510282714728] + 8 + 0) + 16 + 28;
            }
            else
            {
                    if(((mem[1152921510282714728] + 8 + 0) + 16 + 16) != 0)
            {
                    (mem[1152921510282714728] + 8 + 0) + 16 + 16 = mem[(mem[1152921510282714728] + 8 + 0) + 16 + 16 + 28];
                (mem[1152921510282714728] + 8 + 0) + 16 + 16 = (mem[1152921510282714728] + 8 + 0) + 16 + 16 + 28;
                goto label_39;
            }
            
            }
            
            label_39:
            polytree.AddChild(Child:  val_11);
            label_35:
            val_10 = 1;
            label_31:
            if(val_10 < (mem[1152921510282714728] + 12))
            {
                goto label_41;
            }
        
        }
        private void FixupOutPolyline(ClipperLibFerr.OutRec outrec)
        {
            ClipperLibFerr.OutPt val_2;
            var val_3;
            var val_4;
            var val_5;
            label_9:
            label_6:
            if(outrec.Pts == outrec.Pts.Prev)
            {
                goto label_2;
            }
            
            if(outrec.Pts.Next != 0)
            {
                
            }
            else
            {
                    val_5 = 52;
                val_4 = 0;
                val_2 = 1;
                val_3 = 2621443;
            }
            
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = 2621443}, b:  new ClipperLibFerr.IntPoint() {X = mem[outrec.Pts.Next.Prev.Pt + (0)], Y = mem[outrec.Pts.Next.Prev.Pt + (8)]})) == false)
            {
                goto label_6;
            }
            
            if(outrec.Pts.Next == outrec.Pts.Prev)
            {
                    outrec.Pts.Prev = val_2;
            }
            
            mem[33] = outrec.Pts.Next.Next;
            outrec.Pts.Next.Next.Prev = val_2;
            goto label_9;
            label_2:
            if(outrec.Pts.Prev != outrec.Pts.Prev.Prev)
            {
                    return;
            }
            
            mem2[0] = 0;
        }
        private void FixupOutPolygon(ClipperLibFerr.OutRec outRec)
        {
            ClipperLibFerr.OutPt val_9;
            var val_10;
            long val_11;
            long val_12;
            long val_13;
            var val_14;
            var val_15;
            long val_16;
            var val_17;
            long val_18;
            ClipperLibFerr.OutPt val_19;
            if(outRec != 0)
            {
                    outRec.BottomPt = 0;
            }
            else
            {
                    mem[24] = 0;
            }
            
            val_9 = outRec.Pts;
            if(mem[1152921510283020658] != true)
            {
                    if(mem[1152921510283020702] == true)
            {
                    mem[1152921510283020702] = 1;
            }
            
            }
            
            val_10 = 0;
            goto label_3;
            label_20:
            val_11 = mem[outRec.Pts + 16 + 8];
            val_11 = outRec.Pts + 16 + 8;
            var val_1 = (outRec + 20) + 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = outRec.Pts.Pt, Y = val_11}, b:  new ClipperLibFerr.IntPoint() {X = mem[(outRec + 20 + 16) + (0)], Y = mem[(outRec + 20 + 16) + (8)]})) == true)
            {
                goto label_14;
            }
            
            var val_9 = SB;
            val_9 = val_9 + 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = outRec.Pts + 16, Y = outRec.Pts + 16 + 8}, b:  new ClipperLibFerr.IntPoint() {X = mem[(SB + 16) + (0)], Y = mem[(SB + 16) + (8)]})) == true)
            {
                goto label_14;
            }
            
            var val_4 = SB + 20;
            val_12 = mem[SB + 16];
            val_12 = SB + 16;
            val_14 = mem[outRec.Pts + 16 + 8 + 4];
            val_14 = outRec.Pts + 16 + 8 + 4;
            if(SL == 0)
            {
                    val_14 = val_14;
                val_12 = val_12;
                val_13 = mem[(SB + 20) + (4)];
            }
            
            val_11 = outRec.Pts + 16 + 8;
            if((ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = val_12, Y = val_13}, pt2:  new ClipperLibFerr.IntPoint() {X = outRec.Pts + 16, Y = val_11}, pt3:  new ClipperLibFerr.IntPoint() {X = SL + 16, Y = SL + 24}, UseFullRange:  mem[1152921510283020656])) == false)
            {
                goto label_10;
            }
            
            if(1 == 0)
            {
                goto label_14;
            }
            
            val_15 = mem[SB + 16];
            val_15 = SB + 16;
            val_16 = mem[SB + 20];
            val_16 = SB + 20;
            val_17 = mem[SB + 24];
            val_17 = SB + 24;
            val_18 = mem[SB + 28];
            val_18 = SB + 28;
            if(SL == 0)
            {
                    val_18 = val_18;
                val_17 = val_17;
                val_16 = val_16;
                val_15 = val_15;
            }
            
            val_11 = mem[SL + 28];
            val_11 = SL + 28;
            if((this.Pt2IsBetweenPt1AndPt3(pt1:  new ClipperLibFerr.IntPoint() {X = outRec.Pts + 16 + 4, Y = val_16}, pt2:  new ClipperLibFerr.IntPoint() {X = val_18, Y = outRec.Pts + 16 + 4}, pt3:  new ClipperLibFerr.IntPoint() {X = outRec.Pts + 16 + 8 + 4, Y = SL + 20})) == false)
            {
                goto label_14;
            }
            
            label_10:
            val_19 = val_9;
            if(val_19 == val_10)
            {
                goto label_15;
            }
            
            if(val_10 == 0)
            {
                    val_10 = val_19;
            }
            
            goto label_16;
            label_14:
            mem2[0] = SL;
            mem2[0] = SB;
            val_10 = 0;
            label_16:
            val_9 = mem[SB];
            val_9 = SB;
            label_3:
            if((SB + 36) != SB)
            {
                goto label_20;
            }
            
            mem2[0] = 0;
            label_23:
            label_15:
            mem2[0] = ???;
            goto label_23;
        }
        private ClipperLibFerr.OutPt DupOutPt(ClipperLibFerr.OutPt outPt, bool InsertAfter)
        {
            int val_2;
            var val_3;
            ClipperLibFerr.OutPt val_1 = 536891413;
            val_1 = new ClipperLibFerr.OutPt();
            if(val_1 != 0)
            {
                    var val_2 = val_1 + 16;
                mem[536891441] = ???;
                val_2 = outPt.Idx;
            }
            else
            {
                    var val_3 = val_1 + 16;
                mem[536891441] = ???;
                val_2 = outPt.Idx;
            }
            
            mem[536891421] = val_2;
            if(InsertAfter != false)
            {
                    mem[536891445] = outPt.Next;
                mem[536891449] = outPt;
                val_3 = mem[outPt + 32];
                val_3 = outPt + 32;
                mem2[0] = val_1;
            }
            else
            {
                    mem[536891449] = outPt.Prev;
                mem[536891445] = outPt;
                val_3 = mem[outPt + 36];
                val_3 = outPt + 36;
                mem2[0] = val_1;
            }
            
            mem2[0] = val_1;
        }
        private bool GetOverlap(long a1, long a2, long b1, long b2, out long Left, out long Right)
        {
            long val_1;
            long val_12;
            long val_13;
            long val_14;
            long val_15;
            var val_16;
            long val_17;
            long val_18;
            long val_20;
            val_12 = b1;
            val_13 = b1;
            var val_2 = R2 - val_1;
            var val_12 = mem[536890481];
            val_12 = val_12 & 512;
            long val_3 = val_13 - val_14;
            if((val_12 != 0) && (mem[536890411] == 0))
            {
                    val_15 = val_13;
            }
            
            val_16 = 0;
            Right = System.Math.Max(val1:  R2, val2:  val_15);
            val_17 = val_1;
            val_18 = b1;
            val_20 = b2;
            long val_9 = System.Math.Min(val1:  null, val2:  null);
            mem2[0] = val_9;
            long val_11 =  - val_9;
            if(mem[536890411] < 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        private bool JoinHorz(ClipperLibFerr.OutPt op1, ClipperLibFerr.OutPt op1b, ClipperLibFerr.OutPt op2, ClipperLibFerr.OutPt op2b, ClipperLibFerr.IntPoint Pt, bool DiscardLeft)
        {
            bool val_2;
            var val_17;
            var val_18;
            ClipperLibFerr.IntPoint val_19;
            ClipperLibFerr.OutPt val_20;
            ClipperLibFerr.IntPoint val_21;
            ClipperLibFerr.OutPt val_22;
            long val_23;
            ClipperLibFerr.IntPoint val_24;
            bool val_25;
            var val_26;
            long val_27;
            var val_28;
            var val_29;
            ClipperLibFerr.OutPt val_30;
            var val_32;
            ClipperLibFerr.OutPt val_33;
            bool val_34;
            ClipperLibFerr.IntPoint val_35;
            var val_36;
            ClipperLibFerr.OutPt val_37;
            ClipperLibFerr.OutPt val_38;
            ClipperLibFerr.OutPt val_39;
            ClipperLibFerr.IntPoint val_40;
            var val_42;
            bool val_43;
            ClipperLibFerr.IntPoint val_44;
            val_17 = op2;
            val_18 = op1;
            val_19 = op1.Pt;
            if(op1b == 0)
            {
                    val_19 = val_19;
            }
            
            val_21 = op1b.Pt;
            val_22 = op2b;
            if(val_17 == 0)
            {
                    val_22 = val_22;
                val_19 = val_19;
            }
            
            val_24 = op2.Pt;
            if(val_22 == 0)
            {
                    val_22 = op2b;
                val_19 = val_19;
                val_24 = val_24;
            }
            
            val_26 = 0;
            ClipperLibFerr.IntPoint val_1 = val_21 - val_19;
            if(val_22 >= 0)
            {
                    0 = 1;
            }
            
            val_24 = op2b.Pt - val_24;
            if(val_22 >= 0)
            {
                    0 = 1;
            }
            
            if(1 == 1)
            {
                    return (bool)val_26;
            }
            
            ClipperLibFerr.IntPoint val_17 = val_21;
            val_17 = val_17 - val_19;
            val_27 = Pt.Y;
            val_28 = val_19;
            if(1 >= 1)
            {
                goto label_5;
            }
            
            goto label_6;
            label_13:
            ClipperLibFerr.IntPoint val_18 = op1.Pt;
            val_18 = op1.Next.Pt - val_18;
            if(op1.Next < 0)
            {
                goto label_10;
            }
            
            val_29 = val_28 ^ DiscardLeft;
            val_18 = val_18 ^ Pt.Y;
            if(op1.Next != 0)
            {
                goto label_10;
            }
            
            val_30 = op1.Next;
            label_5:
            ClipperLibFerr.IntPoint val_19 = op1.Next.Next.Pt;
            val_19 = Pt.X - val_19;
            if(op1.Next.Next >= 0)
            {
                goto label_13;
            }
            
            label_10:
            bool val_3 = val_2 ^ 1;
            if(val_2 != 0)
            {
                    val_19 = op1.Next.Pt;
            }
            
            if(val_2 != 0)
            {
                    val_29 = val_29 ^ val_27;
                val_19 = val_19 ^ Pt.X;
            }
            
            if(val_2 != 0)
            {
                    val_30 = op1.Next.Next;
            }
            
            ClipperLibFerr.OutPt val_4 = val_19.DupOutPt(outPt:  val_30, InsertAfter:  val_3);
            if((ClipperLibFerr.IntPoint.op_Inequality(a:  new ClipperLibFerr.IntPoint() {X = mem[(op1.Next.Pt ^ Pt.X) + 16], Y = (op1.Next.Pt ^ Pt.X) + 16 + 8}, b:  new ClipperLibFerr.IntPoint() {X = Pt.X, Y = Pt.Y})) == false)
            {
                goto label_15;
            }
            
            ClipperLibFerr.OutPt val_6 = Pt.Y.DupOutPt(outPt:  val_19, InsertAfter:  val_3);
            goto label_16;
            label_23:
            ClipperLibFerr.IntPoint val_20 = op1.Next.Next.Next.Pt;
            val_20 = op1.Next.Next.Pt - val_20;
            if(op1.Next.Next.Next < 0)
            {
                goto label_20;
            }
            
            val_32 = val_19 ^ DiscardLeft;
            val_20 = val_20 ^ Pt.Y;
            if(op1.Next.Next.Next != 0)
            {
                goto label_20;
            }
            
            val_33 = op1.Next.Next.Next;
            label_6:
            ClipperLibFerr.IntPoint val_21 = op1.Next.Next.Next.Next.Pt;
            val_21 = val_21 - ((op1.Next.Pt ^ Pt.X) + 16 + 8);
            if(op1.Next.Next.Next.Next >= 0)
            {
                goto label_23;
            }
            
            label_20:
            if(((op1.Next.Pt ^ Pt.X) + 16) == 0)
            {
                    ClipperLibFerr.IntPoint val_22 = op1.Next.Next.Next.Pt;
                val_32 = val_32 ^ val_27;
                val_22 = val_22 ^ ((op1.Next.Pt ^ Pt.X) + 16 + 8);
                if(((op1.Next.Pt ^ Pt.X) + 16) != 0)
            {
                    val_33 = op1.Next.Next.Next.Next;
            }
            
            }
            
            ClipperLibFerr.OutPt val_7 = val_22.DupOutPt(outPt:  val_33, InsertAfter:  (op1.Next.Pt ^ Pt.X) + 16);
            bool val_8 = ClipperLibFerr.IntPoint.op_Inequality(a:  new ClipperLibFerr.IntPoint() {X = mem[(op1.Next.Next.Next.Pt ^ (op1.Next.Pt ^ Pt.X) + 16 + 8) + 16], Y = (op1.Next.Next.Next.Pt ^ (op1.Next.Pt ^ Pt.X) + 16 + 8) + 16 + 8}, b:  new ClipperLibFerr.IntPoint() {X = Pt.X, Y = Pt.Y});
            if(val_8 == false)
            {
                goto label_26;
            }
            
            val_34 = val_2;
            ClipperLibFerr.OutPt val_9 = Pt.X.DupOutPt(outPt:  val_22, InsertAfter:  val_34);
            val_27 = Pt.Y;
            goto label_28;
            label_15:
            label_16:
            val_34 = val_2;
            goto label_28;
            label_26:
            val_34 = val_2;
            val_27 = Pt.Y;
            label_28:
            ClipperLibFerr.IntPoint val_23 = val_24;
            val_23 = Pt.X;
            val_23 = op2b.Pt - val_23;
            val_35 = val_19;
            if(val_8 >= false)
            {
                goto label_29;
            }
            
            goto label_30;
            label_37:
            ClipperLibFerr.IntPoint val_24 = op2.Pt;
            val_24 = op2.Next.Pt - val_24;
            if(op2.Next < 0)
            {
                goto label_34;
            }
            
            val_36 = val_35 ^ DiscardLeft;
            val_24 = val_24 ^ Pt.Y;
            if(op2.Next != 0)
            {
                goto label_34;
            }
            
            val_37 = op2.Next;
            label_29:
            ClipperLibFerr.IntPoint val_25 = op2.Next.Next.Pt;
            val_25 = val_23 - val_25;
            if(op2.Next.Next >= 0)
            {
                goto label_37;
            }
            
            label_34:
            bool val_10 = val_34 ^ 1;
            if(val_34 != 0)
            {
                    val_25 = op2.Next.Pt;
            }
            
            if(val_34 != 0)
            {
                    val_36 = val_36 ^ val_27;
                val_25 = val_25 ^ val_23;
            }
            
            if(val_34 != 0)
            {
                    val_38 = op2.Next.Next;
            }
            
            ClipperLibFerr.OutPt val_11 = val_25.DupOutPt(outPt:  val_38, InsertAfter:  val_10);
            val_39 = val_25;
            val_25 = DiscardLeft;
            val_21 = (op2.Next.Pt ^ Pt.X) + 16;
            bool val_12 = ClipperLibFerr.IntPoint.op_Inequality(a:  new ClipperLibFerr.IntPoint() {X = mem[(op2.Next.Pt ^ Pt.X) + 16], Y = (op2.Next.Pt ^ Pt.X) + 16 + 8}, b:  new ClipperLibFerr.IntPoint() {X = val_23, Y = Pt.Y});
            if(val_12 == false)
            {
                goto label_50;
            }
            
            mem2[0] = val_23;
            mem2[0] = Pt.Y;
            ClipperLibFerr.OutPt val_13 = Pt.Y.DupOutPt(outPt:  val_39, InsertAfter:  val_10);
            val_40 = Pt.Y;
            goto label_40;
            label_47:
            ClipperLibFerr.IntPoint val_26 = op2.Next.Next.Next.Pt;
            val_26 = op2.Next.Next.Pt - val_26;
            if(op2.Next.Next.Next < 0)
            {
                goto label_44;
            }
            
            val_42 = val_39 ^ ((op2.Next.Pt ^ Pt.X) + 16);
            val_26 = val_26 ^ Pt.Y;
            if(op2.Next.Next.Next != 0)
            {
                goto label_44;
            }
            
            val_38 = op2.Next.Next.Next;
            label_30:
            ClipperLibFerr.IntPoint val_27 = op2.Next.Next.Next.Next.Pt;
            val_27 = val_27 - val_23;
            if(op2.Next.Next.Next.Next >= 0)
            {
                goto label_47;
            }
            
            label_44:
            if(val_39 == 0)
            {
                    ClipperLibFerr.IntPoint val_28 = op2.Next.Next.Next.Pt;
                val_42 = val_42 ^ ((op2.Next.Pt ^ Pt.X) + 16 + 8);
                val_28 = val_28 ^ val_23;
                if(val_39 != 0)
            {
                    val_38 = op2.Next.Next.Next.Next;
            }
            
            }
            
            ClipperLibFerr.OutPt val_14 = val_28.DupOutPt(outPt:  val_38, InsertAfter:  val_39);
            val_39 = val_28;
            val_25 = DiscardLeft;
            val_21 = (op2.Next.Next.Next.Pt ^ Pt.X) + 16;
            if((ClipperLibFerr.IntPoint.op_Inequality(a:  new ClipperLibFerr.IntPoint() {X = mem[(op2.Next.Next.Next.Pt ^ Pt.X) + 16], Y = (op2.Next.Next.Next.Pt ^ Pt.X) + 16 + 8}, b:  new ClipperLibFerr.IntPoint() {X = val_23, Y = Pt.Y})) == false)
            {
                goto label_50;
            }
            
            val_43 = val_2;
            mem2[0] = val_23;
            mem2[0] = Pt.Y;
            ClipperLibFerr.OutPt val_16 = Pt.Y.DupOutPt(outPt:  val_39, InsertAfter:  val_43);
            val_40 = Pt.Y;
            goto label_51;
            label_50:
            val_40 = val_39;
            val_39 = val_38;
            label_40:
            val_43 = val_2;
            label_51:
            ClipperLibFerr.IntPoint val_29 = val_19;
            val_20 = val_33;
            val_29 = val_17 - val_29;
            if(val_12 >= false)
            {
                    0 = 1;
            }
            
            val_43 = 1 ^ val_43;
            if(val_43 != 0)
            {
                    mem2[0] = val_39;
                val_44 = val_22;
                op2.Next.Next.Prev = val_20;
                mem2[0] = val_40;
                mem2[0] = val_44;
            }
            else
            {
                    mem2[0] = val_39;
                val_44 = val_22;
                op2.Next.Next.Next = val_20;
                mem2[0] = val_40;
                mem2[0] = val_44;
            }
            
            val_26 = 1;
            return (bool)val_26;
        }
        private bool JoinPoints(ClipperLibFerr.Join j, ClipperLibFerr.OutRec outRec1, ClipperLibFerr.OutRec outRec2)
        {
            var val_28;
            ClipperLibFerr.OutPt val_29;
            ClipperLibFerr.OutPt val_30;
            var val_31;
            float val_32;
            float val_33;
            long val_34;
            var val_35;
            var val_36;
            ClipperLibFerr.OutPt val_37;
            var val_38;
            long val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            long val_48;
            long val_49;
            var val_50;
            long val_51;
            long val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            long val_60;
            var val_61;
            var val_62;
            var val_63;
            if(j != 0)
            {
                    val_28 = j;
                val_29 = j.OutPt1;
                val_30 = mem[j + 8 + 4];
                val_30 = j + 8 + 4;
                val_31 = val_29;
            }
            else
            {
                    val_28 = 8;
                val_31 = 0;
                var val_39 = 12;
                val_30 = 0;
                val_29 = 0;
            }
            
            val_32 = 7.286752E-44f;
            var val_40 = j + 24 + 4;
            val_39 = 0 ^ val_39;
            val_40 = val_32 ^ val_40;
            if(j != 0)
            {
                goto label_4;
            }
            
            val_33 = j;
            val_34 = mem[j + 16 + 4];
            val_34 = j + 16 + 4;
            val_35 = val_32;
            val_36 = val_31;
            val_37 = val_30;
            val_38 = val_36;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = j.OffPt}, b:  new ClipperLibFerr.IntPoint() {})) == false)
            {
                goto label_18;
            }
            
            val_39 = j + 24;
            val_35 = val_34;
            val_40 = val_31;
            val_37 = val_30;
            val_38 = val_40;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = j + 16, Y = val_39}, b:  new ClipperLibFerr.IntPoint() {})) == false)
            {
                goto label_18;
            }
            
            val_41 = 0;
            if(outRec1 != outRec2)
            {
                    return (bool)val_41;
            }
            
            label_13:
            val_42 = 22965384;
            if(val_42 == val_31)
            {
                goto label_11;
            }
            
            var val_3 = val_42 + 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[(val_42 + 16) + (0)]>>0&0x0, Y = mem[(val_42 + 16) + (8)]>>0&0x0}, b:  new ClipperLibFerr.IntPoint() {X = j + 16, Y = j + 24})) == true)
            {
                goto label_13;
            }
            
            goto label_14;
            label_18:
            val_33 = val_38;
            val_34 = val_33;
            var val_41 = 0;
            var val_42 = 52;
            val_41 = mem[83886616] ^ val_41;
            val_42 = val_35 ^ val_42;
            if(83886592 == 0)
            {
                    if(83886592 != val_37)
            {
                goto label_18;
            }
            
            }
            
            label_23:
            val_43 = val_35 ^ val_43;
            if(22965384 != 0)
            {
                goto label_21;
            }
            
            if(val_43 == val_33)
            {
                goto label_58;
            }
            
            if(val_43 != val_37)
            {
                goto label_23;
            }
            
            val_44 = val_37;
            label_21:
            if(val_44 == val_37)
            {
                goto label_58;
            }
            
            label_28:
            val_46 = val_37;
            if(val_37 == 0)
            {
                    val_46 = val_37;
            }
            
            if(83886592 == 0)
            {
                    val_46 = val_37;
            }
            
            val_32 = val_46;
            var val_44 = 0;
            var val_45 = 52;
            val_44 = mem[83886616] ^ val_44;
            val_45 = val_35 ^ val_45;
            if(83886592 != 0)
            {
                goto label_27;
            }
            
            if(83886592 != val_37)
            {
                    val_45 = val_36;
            }
            
            if(83886592 != val_45)
            {
                goto label_28;
            }
            
            label_27:
            label_33:
            if(val_37 == 0)
            {
                    val_46 = val_37;
            }
            
            if((4.085283E-38f) == 0)
            {
                    val_46 = val_37;
            }
            
            val_46 = val_35 ^ val_46;
            if((4.085283E-38f) != 0)
            {
                goto label_31;
            }
            
            val_33 = 0f;
            if(val_47 == val_46)
            {
                goto label_58;
            }
            
            if(val_47 != val_33)
            {
                goto label_33;
            }
            
            val_47 = val_33;
            goto label_34;
            label_4:
            long val_6 = val_31 + 24;
            long val_7 = val_31 + 16;
            do
            {
                val_37 = mem[(val_31 + 32)];
                val_37 = val_31 + 32;
                bool val_8 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = (val_31 + 32) + 16, Y = (val_31 + 32) + 24}, b:  new ClipperLibFerr.IntPoint() {X = val_7, Y = mem[(val_31 + 24) + (0)]});
                if(val_37 != val_37)
            {
                    val_37 = val_37 + 32;
            }
            
            }
            while(val_8 == true);
            
            val_48 = mem[(val_31 + 24)];
            val_48 = val_6;
            var val_9 = val_48 - (mem[(val_31 + 32) + 24 + (0)]);
            if(val_8 >= false)
            {
                    if((ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = val_7, Y = val_48}, pt2:  new ClipperLibFerr.IntPoint() {X = (val_31 + 32) + 16, Y = mem[(val_31 + 32) + 24 + (0)]}, pt3:  new ClipperLibFerr.IntPoint() {X = j + 16}, UseFullRange:  mem[1152921510283730672])) == true)
            {
                goto label_40;
            }
            
            }
            
            do
            {
                val_37 = 83886592;
                val_45 = val_37;
                bool val_11 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[83886608], Y = mem[83886616]}, b:  new ClipperLibFerr.IntPoint() {X = val_7, Y = mem[(val_31 + 24) + (0)]});
            }
            while(val_11 == true);
            
            val_34 = mem[(val_31 + 24)];
            val_34 = val_6;
            val_48 = mem[(val_31 + 24) + 4];
            val_48 = (val_31 + 24) + 4;
            val_33 = mem[83886616];
            val_32 = mem[83886620];
            val_41 = 0;
            var val_12 = val_34 - val_33;
            if(val_11 < false)
            {
                    return (bool)val_41;
            }
            
            val_49 = mem[(val_31 + 16)];
            val_49 = val_7;
            if(j == 0)
            {
                    val_49 = val_49;
            }
            
            val_41 = 0;
            val_45 = mem[83886612];
            if((ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = val_49, Y = val_34}, pt2:  new ClipperLibFerr.IntPoint() {X = mem[83886608], Y = val_33}, pt3:  new ClipperLibFerr.IntPoint() {X = j + 16}, UseFullRange:  mem[1152921510283730672])) == false)
            {
                    return (bool)val_41;
            }
            
            label_40:
            long val_15 = val_37 + 24;
            long val_16 = val_37 + 16;
            do
            {
                val_33 = mem[(val_37 + 32)];
                val_33 = val_37 + 32;
                val_50 = 0;
                bool val_17 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = (val_37 + 32) + 16, Y = (val_37 + 32) + 24}, b:  new ClipperLibFerr.IntPoint() {X = val_16, Y = mem[(val_37 + 24) + (0)]});
                if(val_33 != val_37)
            {
                    val_37 = val_33 + 32;
            }
            
            }
            while(val_17 == true);
            
            val_51 = mem[(val_37 + 24)];
            val_51 = val_15;
            var val_18 = val_51 - (mem[(val_37 + 32) + 24 + (0)]);
            if(val_17 < false)
            {
                goto label_49;
            }
            
            if(j == 0)
            {
                    val_45 = mem[(val_37 + 32) + 24 + (4)];
                val_51 = val_51;
            }
            
            val_34 = mem[j + 20];
            val_34 = j + 20;
            val_50 = (val_37 + 32) + 16 + 4;
            if((ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = val_16, Y = val_51}, pt2:  new ClipperLibFerr.IntPoint() {X = (val_37 + 32) + 16, Y = mem[(val_37 + 32) + 24 + (0)]}, pt3:  new ClipperLibFerr.IntPoint() {X = j + 16}, UseFullRange:  mem[1152921510283730672])) == true)
            {
                goto label_51;
            }
            
            label_49:
            do
            {
                val_33 = 6.018898E-36f;
                val_34 = val_33;
                bool val_20 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[83886608], Y = mem[83886616]}, b:  new ClipperLibFerr.IntPoint() {X = val_16, Y = mem[(val_37 + 24) + (0)]});
            }
            while(val_20 == true);
            
            val_52 = mem[(val_37 + 24)];
            val_52 = val_15;
            val_41 = 0;
            var val_21 = val_52 - R6;
            if(val_20 < false)
            {
                    return (bool)val_41;
            }
            
            if(j == 0)
            {
                    val_52 = val_52;
            }
            
            val_41 = 0;
            val_34 = mem[j + 20];
            val_34 = j + 20;
            if((ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = val_16, Y = val_52}, pt2:  new ClipperLibFerr.IntPoint() {X = mem[83886608]}, pt3:  new ClipperLibFerr.IntPoint() {X = j + 16}, UseFullRange:  mem[1152921510283730672])) == false)
            {
                    return (bool)val_41;
            }
            
            label_51:
            if(val_37 == val_33)
            {
                goto label_58;
            }
            
            if(val_37 != val_37)
            {
                    val_37 = val_37;
            }
            
            if(val_33 == val_37)
            {
                goto label_58;
            }
            
            val_41 = 0;
            if(outRec1 == outRec2)
            {
                    outRec2 = 1;
                outRec1 = 1;
            }
            
            if(outRec2 == outRec1)
            {
                    return (bool)val_41;
            }
            
            if(1 == 0)
            {
                goto label_60;
            }
            
            ClipperLibFerr.OutPt val_23 = this.DupOutPt(outPt:  0, InsertAfter:  false);
            ClipperLibFerr.OutPt val_24 = this.DupOutPt(outPt:  0, InsertAfter:  true);
            mem[36] = val_37;
            mem[32] = val_37;
            mem[33] = 1;
            mem[37] = 1;
            mem[8] = val_37;
            mem[12] = 1;
            return (bool)val_41;
            label_31:
            val_33 = 0f;
            label_34:
            if(val_47 != val_33)
            {
                goto label_65;
            }
            
            label_58:
            val_41 = 0;
            return (bool)val_41;
            label_11:
            val_42 = val_31;
            if(val_31 == 0)
            {
                goto label_72;
            }
            
            label_14:
            label_70:
            val_53 = mem[33];
            if(val_53 == val_37)
            {
                goto label_68;
            }
            
            var val_25 = val_53 + 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[(val_53 + 16) + (0)]>>0&0x0, Y = mem[(val_53 + 16) + (8)]>>0&0x0}, b:  new ClipperLibFerr.IntPoint() {X = j + 16})) == true)
            {
                goto label_70;
            }
            
            goto label_71;
            label_68:
            val_53 = val_37;
            if(val_53 == 0)
            {
                goto label_72;
            }
            
            label_71:
            var val_47 = 0;
            if(val_53 < 0)
            {
                    0 = 1;
            }
            
            val_47 =  - val_47;
            if(val_53 < 0)
            {
                    0 = 1;
            }
            
            if(1 == 1)
            {
                    return (bool)val_41;
            }
            
            if(1 >= 1)
            {
                goto label_74;
            }
            
            ClipperLibFerr.OutPt val_27 = this.DupOutPt(outPt:  0, InsertAfter:  false);
            val_54 = 1179403647;
            ClipperLibFerr.OutPt val_28 = this.DupOutPt(outPt:  0, InsertAfter:  true);
            val_55 = 1179403647;
            mem[36] = val_37;
            mem[32] = val_37;
            mem[1179403679] = val_55;
            mem[1179403683] = val_54;
            goto label_79;
            label_65:
            if(val_33 == 0)
            {
                    val_56 = val_37;
            }
            
            val_57 = 2621443;
            if(65793 == 0)
            {
                    val_57 = val_57;
                val_56 = val_37;
            }
            
            if(val_56 == 0)
            {
                    val_56 = val_37;
            }
            
            val_58 = 2621443;
            bool val_31 = 0.GetOverlap(a1:  2621443, a2:  1, b1:  1952412257, b2:  1, Left: out  1, Right: out  0);
            if(val_31 == false)
            {
                    return (bool)val_41;
            }
            
            long val_48 = 0;
            val_59 = -1895825179;
            val_60 = -1856995104;
            if(val_31 < false)
            {
                goto label_85;
            }
            
            val_58 = 0;
            if(val_31 < false)
            {
                goto label_85;
            }
            
            val_61 = mem[1751331121];
            goto label_86;
            label_74:
            val_62 = val_37;
            ClipperLibFerr.OutPt val_32 = this.DupOutPt(outPt:  0, InsertAfter:  true);
            val_63 = val_37;
            val_54 = 1179403647;
            ClipperLibFerr.OutPt val_33 = this.DupOutPt(outPt:  0, InsertAfter:  false);
            val_55 = 1179403647;
            mem[32] = val_63;
            if(val_63 != 0)
            {
                goto label_89;
            }
            
            goto label_89;
            label_60:
            val_62 = val_37;
            ClipperLibFerr.OutPt val_34 = this.DupOutPt(outPt:  0, InsertAfter:  true);
            val_63 = val_37;
            val_54 = 1;
            ClipperLibFerr.OutPt val_35 = this.DupOutPt(outPt:  0, InsertAfter:  false);
            val_55 = 1;
            mem[32] = val_63;
            label_89:
            mem[36] = val_62;
            mem[37] = val_55;
            mem[33] = val_54;
            label_79:
            mem[8] = val_37;
            mem[12] = val_54;
            return (bool)val_41;
            label_85:
            val_61 = -1895825179;
            var val_36 = val_61 - val_48;
            if((val_31 < false) || (val_31 < false))
            {
                goto label_95;
            }
            
            val_59 = val_61;
            val_60 = val_58;
            if(val_31 < false)
            {
                    0 = 1;
            }
            
            goto label_99;
            label_95:
            val_48 = R7 - val_48;
            if(val_31 < false)
            {
                goto label_98;
            }
            
            long val_49 = 0;
            val_49 = val_49 - R7;
            if(val_31 < false)
            {
                goto label_98;
            }
            
            var val_37 = val_59 - R7;
            if(val_31 < false)
            {
                    0 = 1;
            }
            
            val_59 = R7;
            val_60 = SB;
            goto label_99;
            label_98:
            val_59 = 2621443;
            val_60 = 1;
            label_86:
            val_61 = val_61 - val_59;
            if(val_31 < false)
            {
                    0 = 1;
            }
            
            label_99:
            if(52 != 0)
            {
                    mem[8] = val_33;
            }
            else
            {
                    mem[8] = val_33;
            }
            
            mem[12] = val_37;
            bool val_38 = this.JoinHorz(op1:  0, op1b:  65793, op2:  0, op2b:  val_37, Pt:  new ClipperLibFerr.IntPoint() {X = 1952412257, Y = val_60}, DiscardLeft:  true);
            return (bool)val_41;
            label_72:
        }
        public static int PointInPolygon(ClipperLibFerr.IntPoint pt, System.Collections.Generic.List<ClipperLibFerr.IntPoint> path)
        {
            long val_7;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_8;
            long val_9;
            long val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_7 = pt.X;
            val_8 = path;
            val_9 = R1;
            val_8 = path;
            val_7 = val_7;
            val_9 = ???;
            val_10 = pt.Y;
            val_11 = ???;
            if(val_8 == 0)
            {
                    val_8 = path;
                val_7 = val_7;
                val_9 = ???;
                val_10 = pt.Y;
                val_11 = ???;
            }
            
            val_13 = 0;
            if(R6 < 3)
            {
                    return (int)val_13;
            }
            
            val_14 = 1;
            val_15 = 40;
            label_18:
            if(R6 == val_14)
            {
                    if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_7 = val_7;
                val_9 = ???;
                val_10 = pt.Y;
                val_11 = ???;
            }
            
                var val_8 = 0;
                val_16 = val_8 + 24;
                val_8 = val_8 + 16;
            }
            else
            {
                    if(0 <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_7 = val_7;
                val_9 = ???;
                val_10 = pt.Y;
                val_11 = ???;
            }
            
                val_16 = 0 + val_15;
                var val_1 = val_16 - 8;
            }
            
            long val_2 = val_16 ^ val_10;
            var val_3 = (R1 + 28) ^ val_11;
            if(0 == val_14)
            {
                    var val_9 = mem[((0 + val_15) - 8) + (0)];
                var val_4 = (mem[((0 + val_15) - 8) + (4)]) ^ val_9;
                val_9 = val_9 ^ val_7;
                val_13 = 0;
                if(0 == val_14)
            {
                    return (int)val_13;
            }
            
                var val_10 = R1 + 24;
                var val_11 = R1 + 28;
                val_10 = val_10 ^ val_10;
                val_11 = val_11 ^ val_11;
                val_12 = ???;
                if(0 == val_14)
            {
                    var val_12 = mem[((0 + val_15) - 8) + (0)];
                var val_13 = R1 + 16;
                val_12 = val_7 - val_12;
                if(0 >= val_14)
            {
                    0 = 1;
            }
            
                val_13 = val_13 - val_7;
                if(0 >= val_14)
            {
                    0 = 1;
            }
            
                val_12 = ???;
                if(1 == 1)
            {
                    return (int)val_13;
            }
            
            }
            
            }
            
            long val_5 = val_16 - val_10;
            var val_14 = R1 + 24;
            if(1 < 1)
            {
                    0 = 1;
            }
            
            val_14 = val_14 - val_10;
            if(1 >= 1)
            {
                    0 = 1;
            }
            
            if(1 != 1)
            {
                goto label_11;
            }
            
            var val_15 = R1 + 16;
            val_15 = val_15 - val_7;
            if(1 >= 1)
            {
                goto label_12;
            }
            
            var val_16 = mem[((0 + val_15) - 8) + (0)];
            val_16 = val_7 - val_16;
            if(1 < 1)
            {
                goto label_15;
            }
            
            label_11:
            val_13 = 0;
            goto label_16;
            label_12:
            var val_17 = mem[((0 + val_15) - 8) + (0)];
            val_17 = val_7 - val_17;
            if(1 >= 1)
            {
                goto label_15;
            }
            
            val_13 = 1;
            goto label_16;
            label_15:
            long val_18 = R1 + 16;
            val_18 = val_18 - val_7;
            long val_19 = pt.Y;
            val_19 = val_16 - val_19;
            var val_20 = mem[((0 + val_15) - 8) + (0)];
            val_20 = val_20 - val_7;
            long val_6 = val_18 * val_19;
            val_9 = val_18;
            long val_21 = pt.Y;
            val_12 = R1 + 28;
            val_21 = val_9 - val_21;
            if(1 == 1)
            {
                goto label_17;
            }
            
            if(1 <= 1)
            {
                    0 = 1;
            }
            
            long val_7 = val_9 - val_16;
            val_9 = ???;
            val_12 = ???;
            if(1 < 1)
            {
                    0 = 1;
            }
            
            if(1 != 1)
            {
                    val_13 = 1;
            }
            
            label_16:
            val_14 = val_14 + 1;
            val_15 = val_15 + 16;
            if(val_14 <= val_12)
            {
                goto label_18;
            }
            
            return (int)val_13;
            label_17:
            val_13 = 0;
            return (int)val_13;
        }
        private static int PointInPolygon(ClipperLibFerr.IntPoint pt, ClipperLibFerr.OutPt op)
        {
            ClipperLibFerr.OutPt val_10;
            ClipperLibFerr.IntPoint val_11;
            var val_12;
            long val_13;
            var val_14;
            ClipperLibFerr.OutPt val_15;
            ClipperLibFerr.OutPt val_16;
            var val_17;
            float val_18;
            var val_19;
            ClipperLibFerr.IntPoint val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            val_10 = op;
            if(val_10 != 0)
            {
                    val_11 = op.Pt;
            }
            else
            {
                    val_12 = 1;
                val_11 = 2621443;
                val_13 = pt.Y;
                val_14 = ???;
                val_10 = op;
            }
            
            val_15 = val_10;
            label_17:
            val_16 = op.Next;
            val_17 = 0;
            val_18 = ???;
            val_19 = val_12;
            if(val_16 != 0)
            {
                    val_20 = op.Next.Pt;
            }
            else
            {
                    val_22 = val_19;
                val_21 = 1;
                var val_11 = 16;
                val_15 = op;
                val_20 = 2621443;
                val_13 = pt.Y;
                val_19 = val_22;
                val_14 = ???;
            }
            
            val_11 = val_11 ^ val_14;
            long val_1 = R1 ^ val_13;
            if(val_16 == 0)
            {
                    long val_12 = pt.X;
                long val_13 = pt.X;
                val_12 = val_20 ^ val_12;
                val_13 = val_21 ^ val_13;
                val_23 = 0;
                if(val_16 == 0)
            {
                    return (int)val_23;
            }
            
                val_22 = val_17;
                long val_2 = 16 ^ val_13;
                var val_3 = val_18 ^ val_14;
                val_17 = val_22;
                if(val_16 == 0)
            {
                    long val_14 = pt.X;
                long val_4 = val_14 - val_20;
                if(val_16 >= 0)
            {
                    0 = 1;
            }
            
                val_14 = (3.673424E-39f) - val_14;
                val_16 = val_16;
                val_19 = val_19;
                if(val_16 >= 0)
            {
                    0 = 1;
            }
            
                val_17 = val_22;
                if(1 == 1)
            {
                    return (int)val_23;
            }
            
            }
            
            }
            
            var val_15 = ???;
            val_15 = val_15 - val_13;
            if(1 < 1)
            {
                    0 = 1;
            }
            
            long val_5 = 16 - val_13;
            if(1 >= 1)
            {
                    0 = 1;
            }
            
            if(1 != 1)
            {
                goto label_10;
            }
            
            long val_16 = pt.X;
            val_16 = val_11 - val_16;
            if(1 >= 1)
            {
                goto label_9;
            }
            
            long val_17 = pt.X;
            val_17 = val_17 - val_20;
            if(1 >= 1)
            {
                goto label_10;
            }
            
            long val_18 = pt.X;
            val_18 = val_11 - val_18;
            val_22 = ???;
            long val_19 = pt.Y;
            val_18 = val_11;
            val_19 = val_22 - val_19;
            long val_20 = val_18;
            val_20 = val_20 - val_20;
            long val_6 = val_18 * val_19;
            val_17 = val_21;
            long val_21 = pt.Y;
            val_21 = 16 - val_21;
            if(1 == 1)
            {
                goto label_16;
            }
            
            if(1 <= 1)
            {
                    val_24 = 1;
            }
            
            var val_7 = 16 - val_22;
            goto label_12;
            label_10:
            val_23 = val_17;
            label_15:
            val_25 = val_15;
            goto label_13;
            label_9:
            long val_22 = val_18;
            val_22 = val_22 - val_20;
            if(1 >= 1)
            {
                goto label_14;
            }
            
            var val_8 = 1 - val_17;
            goto label_15;
            label_14:
            long val_23 = val_18;
            val_23 = val_11 - val_23;
            long val_24 = pt.Y;
            val_22 = val_11;
            val_24 = (???) - val_24;
            long val_25 = val_23;
            val_25 = val_20 - val_25;
            long val_9 = val_23 * val_24;
            val_17 = pt.X;
            long val_26 = pt.Y;
            val_26 = 16 - val_26;
            if(1 == 1)
            {
                goto label_16;
            }
            
            if(1 <= 1)
            {
                    val_24 = 1;
            }
            
            var val_10 = 16 - (???);
            label_12:
            if(1 < 1)
            {
                    0 = 1;
            }
            
            val_25 = op;
            if(1 != 1)
            {
                    val_23 = 1;
            }
            
            label_13:
            if(val_16 != val_25)
            {
                goto label_17;
            }
            
            return (int)val_23;
            label_16:
            val_23 = 0;
            return (int)val_23;
        }
        private static bool Poly2ContainsPoly1(ClipperLibFerr.OutPt outPt1, ClipperLibFerr.OutPt outPt2)
        {
            ClipperLibFerr.OutPt val_2;
            var val_3;
            val_2 = outPt1;
            label_2:
            if((ClipperLibFerr.Clipper.PointInPolygon(pt:  new ClipperLibFerr.IntPoint() {X = mem[outPt1.Pt + (0)]>>0&0x0, Y = mem[outPt1.Pt + (8)]>>0&0x0}, op:  outPt2)) >= 0)
            {
                goto label_1;
            }
            
            val_2 = outPt1.Next;
            if(val_2 != outPt1)
            {
                goto label_2;
            }
            
            val_3 = 1;
            return true;
        }
        private void FixupFirstLefts1(ClipperLibFerr.OutRec OldOutRec, ClipperLibFerr.OutRec NewOutRec)
        {
            var val_5;
            var val_6;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_12:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_5 = 0;
            val_6 = mem[val_3 + 16];
            val_6 = val_3 + 16;
            goto label_4;
            label_6:
            val_6 = mem[val_3 + 16 + 16];
            val_6 = val_3 + 16 + 16;
            label_4:
            if(val_6 == 0)
            {
                goto label_5;
            }
            
            if((val_3 + 16 + 16 + 20) == 0)
            {
                goto label_6;
            }
            
            val_5 = val_6;
            label_5:
            if(((val_5 != OldOutRec) || ((val_3 + 20) == 0)) || ((ClipperLibFerr.Clipper.Poly2ContainsPoly1(outPt1:  val_3 + 20, outPt2:  NewOutRec.Pts)) == false))
            {
                goto label_12;
            }
            
            mem2[0] = NewOutRec;
            goto label_12;
            label_2:
            Dispose();
        }
        private void FixupFirstLefts2(ClipperLibFerr.OutRec innerOutRec, ClipperLibFerr.OutRec outerOutRec)
        {
            var val_3;
            ClipperLibFerr.OutPt val_6;
            var val_7;
            ClipperLibFerr.OutRec val_8;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_21:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            if(val_3 == innerOutRec)
            {
                goto label_21;
            }
            
            if(val_3 != outerOutRec)
            {
                    this = mem[val_3 + 20];
                this = val_3 + 20;
            }
            
            if(this == 0)
            {
                goto label_21;
            }
            
            val_7 = 0;
            val_8 = mem[val_3 + 16];
            val_8 = val_3 + 16;
            goto label_7;
            label_9:
            val_8 = mem[val_3 + 16 + 16];
            val_8 = val_3 + 16 + 16;
            label_7:
            if(val_8 == 0)
            {
                goto label_8;
            }
            
            if((val_3 + 16 + 16 + 20) == 0)
            {
                goto label_9;
            }
            
            val_7 = val_8;
            label_8:
            if(val_7 != outerOutRec)
            {
                    val_8 = outerOutRec.FirstLeft;
            }
            
            if(val_7 != val_8)
            {
                goto label_10;
            }
            
            label_16:
            if(val_3 == 0)
            {
                    val_6 = mem[val_3 + 20];
                val_6 = val_3 + 20;
            }
            
            if((ClipperLibFerr.Clipper.Poly2ContainsPoly1(outPt1:  val_6, outPt2:  innerOutRec.Pts)) == false)
            {
                goto label_13;
            }
            
            mem2[0] = innerOutRec;
            goto label_21;
            label_10:
            if(val_7 != innerOutRec)
            {
                goto label_21;
            }
            
            goto label_16;
            label_13:
            if((ClipperLibFerr.Clipper.Poly2ContainsPoly1(outPt1:  val_3 + 20, outPt2:  outerOutRec.Pts)) == false)
            {
                goto label_18;
            }
            
            mem2[0] = outerOutRec;
            goto label_21;
            label_18:
            if((val_3 + 16) != outerOutRec)
            {
                goto label_21;
            }
            
            mem2[0] = outerOutRec.FirstLeft;
            goto label_21;
            label_3:
            Dispose();
        }
        private void FixupFirstLefts3(ClipperLibFerr.OutRec OldOutRec, ClipperLibFerr.OutRec NewOutRec)
        {
            var val_4;
            var val_5;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_10:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_4 = 0;
            val_5 = mem[val_3 + 16];
            val_5 = val_3 + 16;
            goto label_4;
            label_6:
            val_5 = mem[val_3 + 16 + 16];
            val_5 = val_3 + 16 + 16;
            label_4:
            if(val_5 == 0)
            {
                goto label_5;
            }
            
            if((val_3 + 16 + 16 + 20) == 0)
            {
                goto label_6;
            }
            
            val_4 = val_5;
            label_5:
            if((val_4 != OldOutRec) || ((val_3 + 20) == 0))
            {
                goto label_10;
            }
            
            mem2[0] = NewOutRec;
            goto label_10;
            label_2:
            Dispose();
        }
        private static ClipperLibFerr.OutRec ParseFirstLeft(ClipperLibFerr.OutRec FirstLeft)
        {
            goto label_0;
            label_1:
            FirstLeft = FirstLeft.FirstLeft;
            label_0:
            if(FirstLeft == 0)
            {
                    return;
            }
            
            if(FirstLeft.FirstLeft.Pts == 0)
            {
                goto label_1;
            }
        
        }
        private void JoinCommonEdges()
        {
            var val_10;
            var val_11;
            bool val_12;
            ClipperLibFerr.OutPt val_13;
            bool val_14;
            var val_11 = 0;
            label_13:
            if(val_11 >= true)
            {
                    return;
            }
            
            if(true <= val_11)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + 0;
            ClipperLibFerr.OutRec val_1 = this.GetOutRec(idx:  (0 + 0) + 16 + 8 + 8);
            ClipperLibFerr.OutRec val_2 = this.GetOutRec(idx:  (0 + 0) + 16 + 12 + 8);
            label_45:
            val_11 = val_11 + 1;
            goto label_13;
            label_16:
            if(this == this)
            {
                goto label_15;
            }
            
            if(this != 0)
            {
                goto label_16;
            }
            
            label_19:
            if(this == this)
            {
                goto label_18;
            }
            
            if(this != 0)
            {
                goto label_19;
            }
            
            ClipperLibFerr.OutRec val_3 = this.GetLowermostRec(outRec1:  1382992592, outRec2:  1382992592);
            val_10 = this;
            goto label_21;
            label_15:
            val_10 = this;
            goto label_21;
            label_18:
            val_10 = this;
            label_21:
            if((this.JoinPoints(j:  (0 + 0) + 16, outRec1:  1382992592, outRec2:  1382992592)) == false)
            {
                goto label_45;
            }
            
            if(this == this)
            {
                goto label_23;
            }
            
            if(this == 0)
            {
                goto label_24;
            }
            
            val_11 = 0;
            mem[1152921510284806884] = val_11;
            goto label_25;
            label_23:
            if(this == 0)
            {
                goto label_27;
            }
            
            mem[1152921510284806884] = (0 + 0) + 16 + 8;
            goto label_28;
            label_24:
            val_11 = 0;
            mem[1152921510284806884] = val_11;
            label_25:
            mem[1152921510284806888] = val_11;
            mem[1152921510284806872] = mem[1152921510284806888];
            mem[1152921510284806876] = mem[1152921510284806888];
            if(val_10 == this)
            {
                    mem[1152921510284806880] = null;
            }
            
            mem[1152921510284806880] = this;
            if(mem[1152921510284806940] == false)
            {
                goto label_45;
            }
            
            this.FixupFirstLefts3(OldOutRec:  1382992592, NewOutRec:  1382992592);
            goto label_45;
            label_27:
            mem[1152921510284806884] = (0 + 0) + 16 + 8;
            label_28:
            mem[1152921510284806888] = 0;
            ClipperLibFerr.OutRec val_5 = this.CreateOutRec();
            mem[1152921510284806884] = (0 + 0) + 16 + 12;
            mem[1152921510284806884].UpdateOutPtIdxs(outrec:  1382992592);
            ClipperLibFerr.OutPt val_12 = mem[1152921510284806884];
            bool val_6 = ClipperLibFerr.Clipper.Poly2ContainsPoly1(outPt1:  mem[1152921510284806884], outPt2:  val_12);
            if(val_6 == false)
            {
                goto label_36;
            }
            
            mem[1152921510284806880] = this;
            val_12 = val_12 ^ 1;
            mem[1152921510284806876] = val_12;
            val_12 = mem[1152921510284806940];
            if(val_12 != false)
            {
                    val_12 = this;
                this.FixupFirstLefts2(innerOutRec:  1382992592, outerOutRec:  1382992592);
            }
            
            double val_7 = this.Area(op:  mem[1152921510284806884]);
            if(mem[1152921510284806941] == true)
            {
                    mem[1152921510284806941] = 1;
            }
            
            if(mem[1152921510284806876] != 0)
            {
                    mem[1152921510284806876] = 1;
            }
            
            if(mem[1152921510284806876] <= 0)
            {
                    0 = 1;
            }
            
            if(1 != 1)
            {
                goto label_45;
            }
            
            val_13 = mem[1152921510284806884];
            goto label_39;
            label_36:
            mem[1152921510284806876] = this;
            if((ClipperLibFerr.Clipper.Poly2ContainsPoly1(outPt1:  val_6, outPt2:  mem[1152921510284806884])) == false)
            {
                goto label_40;
            }
            
            mem[1152921510284806876] = 1152921510284806865;
            mem[1152921510284806880] = mem[1152921510284806884];
            mem[1152921510284806880] = this;
            val_14 = mem[1152921510284806940];
            if(val_14 != false)
            {
                    val_14 = this;
                this.FixupFirstLefts2(innerOutRec:  1382992592, outerOutRec:  1382992592);
            }
            
            double val_9 = this.Area(op:  1382992592);
            if(mem[1152921510284806941] == true)
            {
                    mem[1152921510284806941] = 1;
            }
            
            if(this != 0)
            {
                    this = 1;
            }
            
            if(this <= 0)
            {
                    0 = 1;
            }
            
            if(1 != 1)
            {
                goto label_45;
            }
            
            val_13 = mem[1152921510284806884];
            label_39:
            this.ReversePolyPtLinks(pp:  val_13);
            goto label_45;
            label_40:
            mem[1152921510284806880] = mem[1152921510284806884];
            if(mem[1152921510284806940] == false)
            {
                goto label_45;
            }
            
            this.FixupFirstLefts1(OldOutRec:  1382992592, NewOutRec:  1382992592);
            goto label_45;
        }
        private void UpdateOutPtIdxs(ClipperLibFerr.OutRec outrec)
        {
            do
            {
                if(outrec.Pts != 0)
            {
                    outrec.Pts.Idx = outrec.Idx;
            }
            else
            {
                    mem[8] = outrec.Idx;
            }
            
            }
            while(outrec.Pts.Prev != outrec.Pts);
        
        }
        private void DoSimplePolygons()
        {
            var val_13;
            var val_14;
            ClipperLibFerr.OutRec val_15;
            var val_16;
            val_13 = 0;
            goto label_6;
            label_28:
            if((mem[1152921510285071848] + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = mem[1152921510285071848] + 8;
            val_13 = val_13 + 0;
            val_13 = 1;
            val_14 = mem[(mem[1152921510285071848] + 8 + 0) + 16 + 20];
            val_14 = (mem[1152921510285071848] + 8 + 0) + 16 + 20;
            if((val_14 == 0) || (((mem[1152921510285071848] + 8 + 0) + 16 + 13) != 0))
            {
                goto label_6;
            }
            
            label_26:
            long val_3 = val_14 + 24;
            ClipperLibFerr.OutPt val_5 = val_14 + 32;
            label_13:
            if(val_5 == ((mem[1152921510285071848] + 8 + 0) + 16 + 20))
            {
                goto label_9;
            }
            
            var val_6 = val_5 + 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = val_14 + 16, Y = val_3}, b:  new ClipperLibFerr.IntPoint() {X = mem[(((mem[1152921510285071848] + 8 + 0) + 16 + 20 + 32) + 16) + (0)], Y = mem[(((mem[1152921510285071848] + 8 + 0) + 16 + 20 + 32) + 16) + (8)]})) == false)
            {
                goto label_25;
            }
            
            if((((mem[1152921510285071848] + 8 + 0) + 16 + 20 + 32) + 32) != val_14)
            {
                    ((mem[1152921510285071848] + 8 + 0) + 16 + 20 + 16) + 4 = val_5;
                val_3 = mem[((mem[1152921510285071848] + 8 + 0) + 16 + 20 + 32) + 36];
                val_3 = ((mem[1152921510285071848] + 8 + 0) + 16 + 20 + 32) + 36;
            }
            
            if(val_3 != val_14)
            {
                goto label_12;
            }
            
            label_25:
            var val_8 = val_5 + 32;
            goto label_13;
            label_12:
            mem2[0] = val_3;
            mem2[0] = val_14;
            mem2[0] = val_14 + 36;
            mem2[0] = val_5;
            mem2[0] = val_14;
            ClipperLibFerr.OutRec val_9 = this.CreateOutRec();
            mem[1152921510285071844] = val_5;
            mem[1152921510285071844].UpdateOutPtIdxs(outrec:  1383257552);
            if((ClipperLibFerr.Clipper.Poly2ContainsPoly1(outPt1:  mem[1152921510285071844], outPt2:  (mem[1152921510285071848] + 8 + 0) + 16 + 20)) == false)
            {
                goto label_18;
            }
            
            var val_14 = (mem[1152921510285071848] + 8 + 0) + 16 + 12;
            mem[1152921510285071840] = (mem[1152921510285071848] + 8 + 0) + 16;
            val_14 = val_14 ^ 1;
            mem[1152921510285071836] = val_14;
            if(mem[1152921510285071900] == false)
            {
                goto label_25;
            }
            
            val_15 = this;
            val_16 = (mem[1152921510285071848] + 8 + 0) + 16;
            goto label_20;
            label_18:
            mem[1152921510285071836] = (mem[1152921510285071848] + 8 + 0) + 16 + 12;
            if((ClipperLibFerr.Clipper.Poly2ContainsPoly1(outPt1:  (mem[1152921510285071848] + 8 + 0) + 16 + 20, outPt2:  mem[1152921510285071844])) == false)
            {
                goto label_21;
            }
            
            mem2[0] = ((mem[1152921510285071848] + 8 + 0) + 16 + 12) ^ 1;
            mem[1152921510285071840] = (mem[1152921510285071848] + 8 + 0) + 16 + 16;
            mem2[0] = this;
            if(mem[1152921510285071900] == false)
            {
                goto label_25;
            }
            
            val_16 = this;
            val_15 = (mem[1152921510285071848] + 8 + 0) + 16;
            label_20:
            this.FixupFirstLefts2(innerOutRec:  val_15, outerOutRec:  1383257552);
            goto label_25;
            label_21:
            mem[1152921510285071840] = ((mem[1152921510285071848] + 8 + 0) + 16) + 16;
            if(mem[1152921510285071900] == false)
            {
                goto label_25;
            }
            
            this.FixupFirstLefts1(OldOutRec:  (mem[1152921510285071848] + 8 + 0) + 16, NewOutRec:  1383257552);
            goto label_25;
            label_9:
            val_14 = mem[((mem[1152921510285071848] + 8 + 0) + 16 + 20 + 32)];
            val_14 = val_5;
            if(val_14 != ((mem[1152921510285071848] + 8 + 0) + 16 + 20))
            {
                goto label_26;
            }
            
            val_13 = val_13;
            label_6:
            if(val_13 < (mem[1152921510285071848] + 12))
            {
                goto label_28;
            }
        
        }
        public static double Area(System.Collections.Generic.List<ClipperLibFerr.IntPoint> poly)
        {
            var val_3;
            var val_4;
            var val_5;
            if(true < 3)
            {
                    return (double)D0;
            }
            
            var val_1 = true - 1;
            val_4 = 0;
            val_5 = 16;
            goto label_3;
            label_8:
            val_4 = val_1 + 1;
            val_5 = 32;
            label_3:
            if(true <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_2 = val_4 + (val_1 << 4);
            if(0 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= val_1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = val_4 + (val_1 << 4);
            if(0 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = val_4 + val_5;
            var val_6 = (((true - 1) + 1) + val_5) + 8;
            double val_5 = ((((true - 1) + 1) + ((true - 1)) << 4) + 16) + (((true - 1) + 1) + val_5);
            val_6 = ((((true - 1) + 1) + ((true - 1)) << 4) + 24) - val_6;
            if(val_1 != val_4)
            {
                goto label_8;
            }
            
            val_3 = D8 * (-0.5);
            return (double)D0;
        }
        internal double Area(ClipperLibFerr.OutRec outRec)
        {
            if(outRec != 0)
            {
                    return this.Area(op:  outRec.Pts);
            }
            
            return this.Area(op:  outRec.Pts);
        }
        internal double Area(ClipperLibFerr.OutPt op)
        {
            ClipperLibFerr.OutPt val_2;
            var val_3;
            if(op == 0)
            {
                    return (double)D0;
            }
            
            label_4:
            val_2 = op.Prev;
            if(op.Prev != 0)
            {
                goto label_2;
            }
            
            val_2 = op.Prev;
            if(val_2 == 0)
            {
                goto label_3;
            }
            
            label_2:
            ClipperLibFerr.IntPoint val_1 = (mem[op.Pt + (0)]) + op.Prev.Pt;
            val_1 = val_1 - (mem[op.Pt + (8)]);
            if(op.Next != op)
            {
                goto label_4;
            }
            
            val_3 = D8 * 0.5;
            return (double)D0;
            label_3:
        }
        public static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> SimplifyPolygon(System.Collections.Generic.List<ClipperLibFerr.IntPoint> poly, ClipperLibFerr.PolyFillType fillType = 0)
        {
            536877661 = new System.Collections.Generic.List<Page>();
            ClipperLibFerr.Clipper val_2 = 536884863;
            val_2 = new ClipperLibFerr.Clipper(InitOptions:  0);
            if(val_2 != 0)
            {
                    mem[536884941] = 1;
                bool val_3 = val_2.AddPath(pg:  poly, polyType:  0, Closed:  true);
            }
            else
            {
                    mem[536884941] = 1;
                bool val_4 = 0.AddPath(pg:  poly, polyType:  0, Closed:  true);
            }
            
            bool val_5 = this.Execute(clipType:  1, solution:  536877661, subjFillType:  fillType, clipFillType:  fillType);
        }
        public static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> SimplifyPolygons(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> polys, ClipperLibFerr.PolyFillType fillType = 0)
        {
            536877661 = new System.Collections.Generic.List<Page>();
            ClipperLibFerr.Clipper val_2 = 536884863;
            val_2 = new ClipperLibFerr.Clipper(InitOptions:  0);
            if(val_2 != 0)
            {
                    mem[536884941] = 1;
                bool val_3 = val_2.AddPaths(ppg:  polys, polyType:  0, closed:  true);
            }
            else
            {
                    mem[536884941] = 1;
                bool val_4 = 0.AddPaths(ppg:  polys, polyType:  0, closed:  true);
            }
            
            bool val_5 = this.Execute(clipType:  1, solution:  536877661, subjFillType:  fillType, clipFillType:  fillType);
        }
        private static double DistanceSqrd(ClipperLibFerr.IntPoint pt1, ClipperLibFerr.IntPoint pt2)
        {
            long val_3 = pt2.X;
            long val_2 = (pt1.Y - pt2.Y) * (pt1.Y - pt2.Y);
            val_3 = pt1.X - val_3;
            return (double)D0;
        }
        private static double DistanceFromLineSqrd(ClipperLibFerr.IntPoint pt, ClipperLibFerr.IntPoint ln1, ClipperLibFerr.IntPoint ln2)
        {
            long val_4 = ln2.Y;
            val_4 = ln1.Y - val_4;
            long val_5 = ln2.X;
            val_5 = val_5 - ln1.X;
            long val_6 = ln1.Y;
            val_6 = val_6 * val_5;
            long val_2 = val_5 * val_5;
            long val_3 = (pt.Y * val_5) - val_6;
            val_3 = val_3 * val_3;
            val_2 = val_3 / val_2;
            return (double)D0;
        }
        private static bool SlopesNearCollinear(ClipperLibFerr.IntPoint pt1, ClipperLibFerr.IntPoint pt2, ClipperLibFerr.IntPoint pt3, double distSqrd)
        {
            var val_15;
            long val_16;
            long val_17;
            long val_18;
            long val_19;
            long val_20;
            var val_21;
            long val_22;
            long val_23;
            val_15 = R1;
            val_15 = val_15;
            val_16 = pt2.X;
            if(((mem[536890482] & true) == 0) && (mem[536890411] == 0))
            {
                    var val_15 = val_15;
                val_15 = val_15;
                val_16 = val_16;
            }
            
            long val_1 = pt1.X - pt2.X;
            val_17 = pt2.X;
            long val_4 = pt1.Y - pt2.Y;
            var val_5 = R7 ^ (val_15 >> 31);
            val_15 = (val_1 + (val_15 >> 31)) ^ (val_15 >> 31);
            val_4 = val_4 + (((int)R7) >> 31);
            val_1 = val_1 ^ (((int)R7) >> 31);
            long val_6 = val_4 ^ (((int)R7) >> 31);
            val_6 = val_6 - val_15;
            if(mem[536890411] >= 0)
            {
                goto label_3;
            }
            
            long val_7 = pt1.X - pt3.X;
            val_18 = pt3.Y;
            val_19 = pt1.Y;
            if(mem[536890411] < 0)
            {
                    val_20 = 1;
            }
            
            long val_8 = val_17 - pt1.X;
            if(mem[536890411] >= 0)
            {
                    val_21 = 1;
            }
            
            if(1 == 1)
            {
                goto label_4;
            }
            
            val_22 = val_19;
            val_23 = val_15;
            val_17 = pt1.X;
            goto label_11;
            label_3:
            val_19 = pt3.Y;
            long val_9 = pt1.Y - val_19;
            if(mem[536890411] < 0)
            {
                    val_20 = 1;
            }
            
            long val_10 = pt2.Y - pt1.Y;
            val_18 = pt3.Y;
            if(mem[536890411] >= 0)
            {
                    val_21 = 1;
            }
            
            val_22 = val_19;
            if(1 == 1)
            {
                goto label_6;
            }
            
            val_17 = pt1.X;
            val_23 = val_15;
            val_22 = pt1.Y;
            goto label_11;
            label_4:
            long val_11 = val_17 - pt3.X;
            if(1 < 1)
            {
                    0 = 1;
            }
            
            long val_12 = pt1.X - val_17;
            if(1 >= 1)
            {
                    0 = 1;
            }
            
            val_20 = pt1.Y;
            if(1 == 1)
            {
                goto label_8;
            }
            
            val_22 = pt2.Y;
            val_23 = val_16;
            goto label_11;
            label_6:
            long val_16 = pt2.Y;
            val_19 = pt1.Y;
            long val_13 = val_16 - val_22;
            if(1 < 1)
            {
                    val_20 = 1;
            }
            
            val_16 = val_19 - val_16;
            if(1 >= 1)
            {
                    0 = 1;
            }
            
            if(1 == 1)
            {
                goto label_10;
            }
            
            val_23 = val_16;
            val_22 = pt2.Y;
            goto label_11;
            label_8:
            val_17 = pt3.X;
            val_23 = pt3.X;
            val_22 = pt3.Y;
            goto label_12;
            label_10:
            val_17 = pt3.X;
            val_23 = pt3.X;
            label_12:
            label_11:
            double val_14 = ClipperLibFerr.Clipper.DistanceFromLineSqrd(pt:  new ClipperLibFerr.IntPoint() {X = val_17, Y = val_22}, ln1:  new ClipperLibFerr.IntPoint() {X = pt1.X, Y = val_19}, ln2:  new ClipperLibFerr.IntPoint() {X = pt1.Y, Y = val_16});
            if(1 < 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        private static bool PointsAreClose(ClipperLibFerr.IntPoint pt1, ClipperLibFerr.IntPoint pt2, double distSqrd)
        {
            long val_4 = pt2.X;
            long val_2 = (pt1.Y - pt2.Y) * (pt1.Y - pt2.Y);
            val_4 = pt1.X - val_4;
            if()
            {
                    0 = 1;
            }
            
            return true;
        }
        private static ClipperLibFerr.OutPt ExcludeOp(ClipperLibFerr.OutPt op)
        {
            ClipperLibFerr.OutPt val_1;
            if(op != 0)
            {
                    val_1 = op.Prev;
            }
            else
            {
                    val_1 = 83886592;
            }
            
            mem[83886624] = op.Next;
            op.Next.Prev = val_1;
            mem[83886600] = 0;
        }
        public static System.Collections.Generic.List<ClipperLibFerr.IntPoint> CleanPolygon(System.Collections.Generic.List<ClipperLibFerr.IntPoint> path, double distance = 1.415)
        {
            var val_11;
            float val_12;
            float val_13;
            var val_14;
            var val_15;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_16;
            var val_17;
            var val_18;
            long val_19;
            long val_20;
            long val_21;
            val_11 = R3;
            val_12 = R2;
            if(SL == 0)
            {
                goto label_2;
            }
            
            float val_20 = val_12;
            val_11 = 536882239;
            if(SL < 1)
            {
                goto label_3;
            }
            
            val_14 = 536882255;
            var val_16 = 0;
            var val_15 = 0;
            do
            {
                ClipperLibFerr.OutPt val_1 = 536891413;
                val_12 = val_1;
                val_1 = new ClipperLibFerr.OutPt();
                var val_2 = val_14 + val_16;
                mem[536882255] = val_12;
                val_15 = val_15 + 1;
                val_16 = val_16 + 4;
            }
            while(SL != val_15);
            
            if(SL >= 1)
            {
                    var val_19 = 16;
                var val_18 = 0;
                do
            {
                if((path + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_17 = path + 8;
                val_17 = val_17 + val_19;
                var val_3 = mem[536882255] + 16;
                val_15 = mem[536882251];
                if(val_15 <= val_18)
            {
                    val_15 = mem[536882251];
            }
            
                var val_4 = val_18 + 1;
                if(val_15 != val_18)
            {
                    val_4 - (???) = val_4;
            }
            
                var val_6 = val_11 + ((val_4 - (???)) << 2);
                mem[536891445] = (val_11 + ((0 + 1)) << 2) + 16;
                val_4 = val_4 - 1;
                val_12 = mem[536882255];
                mem2[0] = val_12;
                val_18 = val_4 + 1;
                mem[536891421] = 0;
                val_19 = val_19 + 16;
            }
            while(val_18 != (???));
            
            }
            
            val_20 = val_20 * val_20;
            goto label_26;
            label_2:
            val_16 = 536878005;
            val_16 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>();
            return;
            label_3:
            val_20 = val_20 * val_20;
            label_26:
            val_13 = 1.086852E-19f;
            goto label_38;
            label_40:
            if(mem[536891445] == path)
            {
                goto label_29;
            }
            
            val_14 = val_13;
            val_12 = mem[536891433];
            var val_21 = mem[536891437];
            val_21 = val_21 - R2;
            val_17 = mem[536891429];
            var val_22 = mem[536891441];
            double val_8 = val_21 * val_21;
            val_22 = val_17 - val_22;
            if(path <= 0)
            {
                goto label_37;
            }
            
            val_12 = mem[mem[536891449] + 20];
            val_12 = mem[536891449] + 20;
            val_18 = mem[536891445];
            var val_23 = mem[536891449] + 24;
            val_11 = mem[(val_11 + ((0 + 1)) << 2) + 16 + 20];
            val_11 = (val_11 + ((0 + 1)) << 2) + 16 + 20;
            val_23 = val_23 - ((val_11 + ((0 + 1)) << 2) + 16 + 24);
            val_17 = mem[536891449] + 16;
            var val_24 = (val_11 + ((0 + 1)) << 2) + 16 + 16;
            double val_9 = val_23 * val_23;
            val_24 = val_17 - val_24;
            if(val_18 <= 0)
            {
                goto label_34;
            }
            
            var val_10 = mem[536891449] + 20;
            val_19 = mem[mem[536891449] + 16];
            val_19 = mem[536891449] + 16;
            var val_25 = mem[536891445];
            if(val_25 == 0)
            {
                    val_18 = mem[(mem[536891449] + 20) + (8)];
                val_21 = R0;
                val_12 = ???;
                val_20 = mem[(mem[536891449] + 20) + (4)];
                val_19 = val_19;
            }
            
            val_25 = val_25 + 20;
            if((ClipperLibFerr.Clipper.SlopesNearCollinear(pt1:  new ClipperLibFerr.IntPoint() {X = val_19, Y = val_20}, pt2:  new ClipperLibFerr.IntPoint() {X = mem[536891429], Y = val_21}, pt3:  new ClipperLibFerr.IntPoint() {X = (val_11 + ((0 + 1)) << 2) + 16 + 16, Y = mem[((val_11 + ((0 + 1)) << 2) + 16 + 20) + (4)]}, distSqrd:  distance)) == true)
            {
                goto label_37;
            }
            
            mem[536891421] = 1;
            val_13 = mem[536891445];
            goto label_38;
            label_34:
            ClipperLibFerr.OutPt val_12 = ClipperLibFerr.Clipper.ExcludeOp(op:  mem[536891445]);
            label_37:
            ClipperLibFerr.OutPt val_13 = ClipperLibFerr.Clipper.ExcludeOp(op:  536891413);
            val_13 = val_13;
            var val_26 = ???;
            val_26 = val_26 + 1;
            label_38:
            if(mem[536891421] == 0)
            {
                goto label_40;
            }
            
            label_29:
            val_16 = 536878005;
            if(val_26 <= 2)
            {
                    val_26 = 0;
            }
            
            val_16 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>(capacity:  0);
            if(val_26 < 1)
            {
                    return;
            }
            
            var val_27 = val_26;
            do
            {
                val_14 = mem[536891429];
                val_12 = mem[536891433];
                val_11 = mem[536891441];
                val_16.Add(item:  new ClipperLibFerr.IntPoint() {Y = val_12});
                val_13 = mem[536891445];
                val_27 = val_27 - 1;
            }
            while(val_16 != 0);
        
        }
        public static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> CleanPolygons(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> polys, double distance = 1.415)
        {
            536877661 = new System.Collections.Generic.List<SingleRange>(capacity:  22970922);
            if(536877661 < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                if(536877661 <= val_4)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_3 = val_3 + 0;
                System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_2 = ClipperLibFerr.Clipper.CleanPolygon(path:  (0 + 0) + 16, distance:  distance);
                536877661.Add(item:  (0 + 0) + 16);
                val_4 = val_4 + 1;
            }
            while(val_4 < 536877661);
        
        }
        internal static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> Minkowski(System.Collections.Generic.List<ClipperLibFerr.IntPoint> pattern, System.Collections.Generic.List<ClipperLibFerr.IntPoint> path, bool IsSum, bool IsClosed)
        {
            var val_4;
            var val_5;
            var val_14;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_24;
            System.Collections.Generic.List<SingleRange> val_25;
            var val_26;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_27;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_28;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_29;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            System.Collections.Generic.List<SingleRange> val_42;
            val_24 = pattern;
            if(val_24 == 0)
            {
                    val_24 = pattern;
            }
            
            val_25 = 536877661;
            val_25 = new System.Collections.Generic.List<SingleRange>(capacity:  path + 12);
            if(IsSum == false)
            {
                goto label_3;
            }
            
            if((path + 12) < 1)
            {
                goto label_26;
            }
            
            goto label_44;
            label_3:
            if((path + 12) < 1)
            {
                goto label_26;
            }
            
            label_25:
            val_27 = 536878005;
            val_27 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>(capacity:  pattern + 12);
            val_28 = pattern;
            if(val_28 == 0)
            {
                    val_28 = pattern;
            }
            
            List.Enumerator<T> val_3 = GetEnumerator();
            goto label_16;
            label_21:
            val_29 = val_4;
            val_30 = val_5;
            val_31 = mem[path + 12];
            val_31 = path + 12;
            val_32 = 0;
            if(val_31 <= val_32)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_31 = mem[path + 12];
                val_31 = path + 12;
                val_32 = 0;
            }
            
            val_33 = mem[path + 8];
            val_33 = path + 8;
            var val_6 = val_33 + 0;
            val_34 = mem[(path + 8 + 0) + 16];
            val_34 = (path + 8 + 0) + 16;
            if(val_31 <= val_32)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_32 = 0;
                val_33 = mem[path + 8];
                val_33 = path + 8;
            }
            
            var val_7 = val_33 + 0;
            var val_26 = (path + 8 + 0) + 24;
            val_26 = val_26 - R4;
            var val_8 = val_34 - val_29;
            ClipperLibFerr.IntPoint val_9 = new ClipperLibFerr.IntPoint(X:  0, Y:  0);
            val_27.Add(item:  new ClipperLibFerr.IntPoint() {X = 1152921510286663168, Y = val_9.X});
            val_25 = val_25;
            label_16:
            if(MoveNext() == true)
            {
                goto label_21;
            }
            
            val_26 = 1;
            Dispose();
            if(val_26 != 0)
            {
                    var val_11 = val_26 - 1;
                if((1152921510286663196 + ((val_26 - 1)) << 2) == 281)
            {
                    val_35 = val_11;
            }
            
            }
            else
            {
                    val_35 = 0;
            }
            
            val_25.Add(item:  536878005);
            if(1 < (path + 12))
            {
                goto label_25;
            }
            
            goto label_26;
            label_44:
            val_29 = 536878005;
            val_29 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>(capacity:  pattern + 12);
            val_37 = pattern;
            if(val_37 == 0)
            {
                    val_37 = pattern;
            }
            
            List.Enumerator<T> val_13 = val_9.X.GetEnumerator();
            goto label_35;
            label_40:
            val_27 = val_14;
            val_34 = val_4;
            val_38 = mem[path + 12];
            val_38 = path + 12;
            val_39 = 0;
            if(val_38 <= val_39)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_38 = mem[path + 12];
                val_38 = path + 12;
                val_39 = 0;
            }
            
            val_40 = mem[path + 8];
            val_40 = path + 8;
            var val_15 = val_40 + 0;
            if(val_38 <= val_39)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_39 = 0;
                val_40 = mem[path + 8];
                val_40 = path + 8;
            }
            
            var val_16 = val_40 + 0;
            var val_27 = (path + 8 + 0) + 24;
            val_27 = val_27 + val_27;
            var val_17 = ((path + 8 + 0) + 16) + val_34;
            ClipperLibFerr.IntPoint val_18 = new ClipperLibFerr.IntPoint(X:  0, Y:  0);
            val_29.Add(item:  new ClipperLibFerr.IntPoint() {X = 1152921510286663168, Y = val_18.X});
            val_25 = val_25;
            label_35:
            if(MoveNext() == true)
            {
                goto label_40;
            }
            
            val_36 = val_11 + 1;
            Dispose();
            if(val_36 != 0)
            {
                    if((1152921510286663196 + ((((val_26 - 1) + 1) - 1)) << 2) == 146)
            {
                    val_41 = val_36 - 1;
            }
            
            }
            else
            {
                    val_41 = 0;
            }
            
            val_25.Add(item:  536878005);
            if(1 < (path + 12))
            {
                goto label_44;
            }
            
            label_26:
            int val_29 = path + 12;
            bool val_21 = val_29 + IsClosed;
            val_42 = 536877661;
            var val_28 = pattern + 12;
            val_28 = val_28 + 1;
            val_29 = val_21 * val_28;
            val_42 = new System.Collections.Generic.List<SingleRange>(capacity:  val_29);
            bool val_23 = val_21 - 1;
            if(val_23 < true)
            {
                    return;
            }
            
            var val_30 = pattern + 12;
            val_30 = 0 - val_30;
            do
            {
                val_34 = 0 + 1;
                if((pattern + 12) >= 1)
            {
                    do
            {
                val_30 = 536878005;
                val_30 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>(capacity:  4);
                if(mem[536877673] <= (path + 12))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_31 = mem[536877669];
                val_31 = val_31 + ((path + 12) << 2);
                if(((mem[536877669] + (path + 12) << 2) + 16 + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_30.Add(item:  new ClipperLibFerr.IntPoint() {Y = 536877661});
                if(mem[536877673] <= (path + 12))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_32 = mem[536877669];
                val_32 = val_32 + ((path + 12) << 2);
                if(((mem[536877669] + (path + 12) << 2) + 16 + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_30.Add(item:  new ClipperLibFerr.IntPoint() {Y = 536877661});
                if(mem[536877673] <= (path + 12))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_33 = mem[536877669];
                val_33 = val_33 + ((path + 12) << 2);
                var val_34 = val_30;
                val_34 = val_34 + 0;
                if(val_34 == 1)
            {
                    1 = val_34 + 1;
            }
            
                if(((mem[536877669] + (path + 12) << 2) + 16 + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_35 = (mem[536877669] + (path + 12) << 2) + 16 + 8;
                val_35 = val_35 + (1 << 4);
                val_30.Add(item:  new ClipperLibFerr.IntPoint() {X = (mem[536877669] + (path + 12) << 2) + 16 + 12, Y = ((mem[536877669] + (path + 12) << 2) + 16 + 8 + ((((0 - pattern + 12) + 0) + 1)) << 4) + 20});
                if(mem[536877673] <= (path + 12))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_36 = mem[536877669];
                val_34 = val_34;
                val_36 = val_36 + ((path + 12) << 2);
                if(((mem[536877669] + (path + 12) << 2) + 16 + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_37 = (mem[536877669] + (path + 12) << 2) + 16 + 8;
                val_37 = val_37 + (1 << 4);
                val_27 = mem[((mem[536877669] + (path + 12) << 2) + 16 + 8 + ((((0 - pattern + 12) + 0) + 1)) << 4) + 20];
                val_27 = ((mem[536877669] + (path + 12) << 2) + 16 + 8 + ((((0 - pattern + 12) + 0) + 1)) << 4) + 20;
                val_30.Add(item:  new ClipperLibFerr.IntPoint() {X = (mem[536877669] + (path + 12) << 2) + 16 + 12, Y = val_27});
                double val_25 = ClipperLibFerr.Clipper.Area(poly:  536878005);
                val_25 = val_25;
                val_42 = val_42;
                if(val_30 < 0)
            {
                    val_30.Reverse();
            }
            
                val_42.Add(item:  536878005);
                var val_38 = val_30;
                val_29 = 24 + 16;
                val_38 = val_38 + 1;
            }
            while(val_42 != 0);
            
            }
            
            }
            while(val_34 != val_23);
        
        }
        public static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> MinkowskiSum(System.Collections.Generic.List<ClipperLibFerr.IntPoint> pattern, System.Collections.Generic.List<ClipperLibFerr.IntPoint> path, bool pathIsClosed)
        {
            System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> val_1 = ClipperLibFerr.Clipper.Minkowski(pattern:  pattern, path:  path, IsSum:  true, IsClosed:  pathIsClosed);
            ClipperLibFerr.Clipper val_2 = 536884863;
            val_2 = new ClipperLibFerr.Clipper(InitOptions:  0);
            if(val_2 != 0)
            {
                    bool val_3 = val_2.AddPaths(ppg:  pattern, polyType:  0, closed:  true);
            }
            else
            {
                    bool val_4 = 0.AddPaths(ppg:  pattern, polyType:  0, closed:  true);
            }
            
            bool val_5 = this.Execute(clipType:  1, solution:  pattern, subjFillType:  1, clipFillType:  1);
        }
        private static System.Collections.Generic.List<ClipperLibFerr.IntPoint> TranslatePath(System.Collections.Generic.List<ClipperLibFerr.IntPoint> path, ClipperLibFerr.IntPoint delta)
        {
            var val_2;
            var val_4;
            var val_5;
            536878005 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>(capacity:  22970925);
            if(536878005 < 1)
            {
                    return;
            }
            
            var val_11 = 16;
            var val_10 = 0;
            do
            {
                if(536878005 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(0 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_9 = val_5;
                val_9 = val_9 + val_4;
                var val_7 = val_2 + (???);
                ClipperLibFerr.IntPoint val_8 = new ClipperLibFerr.IntPoint(X:  1152921510286915904, Y:  delta.Y);
                536878005.Add(item:  new ClipperLibFerr.IntPoint() {X = val_8.Y, Y = val_8.X});
                val_10 = val_10 + 1;
                val_11 = val_11 + 16;
            }
            while(val_10 < 536878005);
        
        }
        public static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> MinkowskiSum(System.Collections.Generic.List<ClipperLibFerr.IntPoint> pattern, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> paths, bool pathIsClosed)
        {
            var val_8;
            536877661 = new System.Collections.Generic.List<Page>();
            536884863 = new ClipperLibFerr.Clipper(InitOptions:  0);
            val_8 = 4;
            goto label_1;
            label_10:
            if(536884863 <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> val_3 = ClipperLibFerr.Clipper.Minkowski(pattern:  pattern, path:  2621443, IsSum:  true, IsClosed:  pathIsClosed);
            if(pathIsClosed != false)
            {
                    if((val_2.AddPaths(ppg:  pattern, polyType:  0, closed:  true)) <= SL)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(0 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_5 = ClipperLibFerr.Clipper.TranslatePath(path:  2621443, delta:  new ClipperLibFerr.IntPoint() {Y = 1});
            }
            
            val_8 = 5;
            label_1:
            if((val_8 - 4) < (val_2.AddPath(pg:  2621443, polyType:  1, Closed:  true)))
            {
                goto label_10;
            }
            
            bool val_8 = this.Execute(clipType:  1, solution:  536877661, subjFillType:  1, clipFillType:  1);
        }
        public static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> MinkowskiDiff(System.Collections.Generic.List<ClipperLibFerr.IntPoint> poly1, System.Collections.Generic.List<ClipperLibFerr.IntPoint> poly2)
        {
            System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> val_1 = ClipperLibFerr.Clipper.Minkowski(pattern:  poly1, path:  poly2, IsSum:  false, IsClosed:  true);
            ClipperLibFerr.Clipper val_2 = 536884863;
            val_2 = new ClipperLibFerr.Clipper(InitOptions:  0);
            if(val_2 != 0)
            {
                    bool val_3 = val_2.AddPaths(ppg:  poly1, polyType:  0, closed:  true);
            }
            else
            {
                    bool val_4 = 0.AddPaths(ppg:  poly1, polyType:  0, closed:  true);
            }
            
            bool val_5 = this.Execute(clipType:  1, solution:  poly1, subjFillType:  1, clipFillType:  1);
        }
        public static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> PolyTreeToPaths(ClipperLibFerr.PolyTree polytree)
        {
            536877661 = new System.Collections.Generic.List<Page>();
            536877661.Capacity = polytree.Total;
            ClipperLibFerr.Clipper.AddPolyNodeToPaths(polynode:  polytree, nt:  0, paths:  536877661);
        }
        internal static void AddPolyNodeToPaths(ClipperLibFerr.PolyNode polynode, ClipperLibFerr.Clipper.NodeType nt, System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> paths)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = polynode;
            val_6 = 22970929;
            if(nt == 1)
            {
                    return;
            }
            
            if(nt == 2)
            {
                    val_7 = (polynode.<IsOpen>k__BackingField) ^ 1;
            }
            else
            {
                    val_7 = 1;
            }
            
            if( > 0)
            {
                    0 = 1;
            }
            
            if((val_7 & 1) == 0)
            {
                    paths.Add(item:  polynode.m_polygon);
            }
            
            val_5;
            List.Enumerator<T> val_1 = GetEnumerator();
            val_6 = 22728708;
            label_12:
            if(MoveNext() == false)
            {
                goto label_10;
            }
            
            goto label_12;
            label_10:
            Dispose();
        }
        public static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> OpenPathsFromPolyTree(ClipperLibFerr.PolyTree polytree)
        {
            var val_4;
            536877661 = new System.Collections.Generic.List<Page>();
            int val_2 = polytree.ChildCount;
            536877661.Capacity = val_2;
            val_4 = 4;
            goto label_3;
            label_14:
            if(mem[22970942] <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((mem[22970938] + 16 + 32) != 0)
            {
                    if((mem[22970938] + 16 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                536877661.Add(item:  mem[22970938] + 16 + 8 + 16 + 12);
            }
            
            val_4 = 5;
            label_3:
            if((val_4 - 4) < polytree.ChildCount)
            {
                goto label_14;
            }
        
        }
        public static System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> ClosedPathsFromPolyTree(ClipperLibFerr.PolyTree polytree)
        {
            536877661 = new System.Collections.Generic.List<Page>();
            536877661.Capacity = polytree.Total;
            ClipperLibFerr.Clipper.AddPolyNodeToPaths(polynode:  polytree, nt:  2, paths:  536877661);
        }
    
    }

}
