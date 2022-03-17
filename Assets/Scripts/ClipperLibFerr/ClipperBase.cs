using UnityEngine;

namespace ClipperLibFerr
{
    public class ClipperBase
    {
        // Fields
        internal const double horizontal = -3.4E+38;
        internal const int Skip = -2;
        internal const int Unassigned = -1;
        internal const double tolerance = 1E-20;
        public const long loRange = 1073741823;
        public const long hiRange = 4611686018427387903;
        internal ClipperLibFerr.LocalMinima m_MinimaList;
        internal ClipperLibFerr.LocalMinima m_CurrentLM;
        internal System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.TEdge>> m_edges;
        internal ClipperLibFerr.Scanbeam m_Scanbeam;
        internal System.Collections.Generic.List<ClipperLibFerr.OutRec> m_PolyOuts;
        internal ClipperLibFerr.TEdge m_ActiveEdges;
        internal bool m_UseFullRange;
        internal bool m_HasOpenPaths;
        private bool <PreserveCollinear>k__BackingField;
        
        // Properties
        public bool PreserveCollinear { get; set; }
        
        // Methods
        internal static bool near_zero(double val)
        {
            if(<0)
            {
                    0 = 1;
            }
            
            if()
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool get_PreserveCollinear()
        {
            return (bool)this.<PreserveCollinear>k__BackingField;
        }
        public void set_PreserveCollinear(bool value)
        {
            this.<PreserveCollinear>k__BackingField = value;
        }
        public void Swap(ref long val1, ref long val2)
        {
            val1 = val2;
        }
        internal static bool IsHorizontal(ClipperLibFerr.TEdge e)
        {
            e = e | R1;
            e = e >> 5;
            return (bool)e;
        }
        internal bool PointIsVertex(ClipperLibFerr.IntPoint pt, ClipperLibFerr.OutPt pp)
        {
            var val_1;
            long val_2;
            var val_5;
            var val_6;
            val_5 = val_1;
            label_2:
            var val_3 = val_5 + 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[(val_1 + 16) + (0)]>>0&0x0, Y = mem[(val_1 + 16) + (8)]>>0&0x0}, b:  new ClipperLibFerr.IntPoint() {X = R2, Y = val_2})) == true)
            {
                goto label_1;
            }
            
            val_5 = mem[val_1 + 32];
            val_5 = val_1 + 32;
            if(val_5 != val_1)
            {
                goto label_2;
            }
            
            val_6 = 0;
            return (bool)val_6;
            label_1:
            val_6 = 1;
            return (bool)val_6;
        }
        internal bool PointOnLineSegment(ClipperLibFerr.IntPoint pt, ClipperLibFerr.IntPoint linePt1, ClipperLibFerr.IntPoint linePt2, bool UseFullRange)
        {
            var val_3;
            var val_6;
            long val_15;
            ulong val_17;
            long val_32;
            long val_33;
            var val_34;
            var val_35;
            val_32 = linePt1.Y;
            long val_2 = linePt1.X ^ linePt2.X;
            val_33 = val_3;
            val_2 = pt.Y ^ linePt1.Y | val_2;
            long val_5 = val_33 ^ val_32;
            val_5 = R2 ^ linePt1.X | val_5;
            val_2 = val_5 | val_2;
            val_5 = val_2 >> 5;
            if(val_6 != 0)
            {
                    val_35 = 1;
                if(val_5 != 0)
            {
                    return (bool)val_35;
            }
            
                long val_8 = pt.Y ^ val_34;
                if(val_5 == 0)
            {
                    linePt1.Y = UseFullRange;
                R2 ^ linePt2.X = val_33 ^ linePt2.Y;
                linePt1.Y = linePt1.X ^ linePt1.Y;
            }
            
                if(val_5 == 0)
            {
                    return (bool)val_35;
            }
            
                long val_31 = linePt2.X;
                val_35 = 0;
                val_31 = R2 - val_31;
                if(val_5 < 0)
            {
                    0 = 1;
            }
            
                long val_9 = linePt1.X - R2;
                if(val_5 >= 0)
            {
                    0 = 1;
            }
            
                if(1 == 1)
            {
                    return (bool)val_35;
            }
            
                long val_10 = val_33 - linePt2.Y;
                val_35 = 0;
                if(1 < 1)
            {
                    0 = 1;
            }
            
                long val_11 = val_32 - val_33;
                if(1 >= 1)
            {
                    0 = 1;
            }
            
                if(1 == 1)
            {
                    return (bool)val_35;
            }
            
                long val_12 = linePt2.Y - val_32;
                ClipperLibFerr.Int128 val_14 = ClipperLibFerr.Int128.Int128Mul(lhs:  1152921510268964792, rhs:  R2 - linePt1.X);
                long val_19 = val_33 - val_32;
                ClipperLibFerr.Int128 val_21 = ClipperLibFerr.Int128.Int128Mul(lhs:  1152921510268964792, rhs:  linePt2.X - linePt1.X);
                bool val_22 = ClipperLibFerr.Int128.op_Equality(val1:  new ClipperLibFerr.Int128() {hi = val_15, lo = val_17}, val2:  new ClipperLibFerr.Int128());
                return (bool)val_35;
            }
            
            val_35 = 1;
            if(val_5 != 0)
            {
                    return (bool)val_35;
            }
            
            if(val_5 == 0)
            {
                    pt.Y ^ val_34 = UseFullRange;
                R2 ^ linePt2.X = val_33 ^ linePt2.Y;
                pt.Y ^ val_34 = linePt1.X ^ pt.Y ^ val_34;
            }
            
            if(val_5 == 0)
            {
                    return (bool)val_35;
            }
            
            long val_32 = linePt2.X;
            val_35 = 0;
            val_32 = R2 - val_32;
            if(val_5 < 0)
            {
                    0 = 1;
            }
            
            long val_25 = linePt1.X - R2;
            if(val_5 >= 0)
            {
                    0 = 1;
            }
            
            if(1 == 1)
            {
                    return (bool)val_35;
            }
            
            long val_26 = val_33 - linePt2.Y;
            val_35 = 0;
            if(1 < 1)
            {
                    0 = 1;
            }
            
            long val_27 = val_32 - val_33;
            if(1 >= 1)
            {
                    0 = 1;
            }
            
            if(1 == 1)
            {
                    return (bool)val_35;
            }
            
            long val_33 = linePt2.X;
            val_33 = val_33 - linePt1.X;
            long val_28 = val_33 - val_32;
            val_33 = linePt2.X;
            long val_29 = R2 - linePt1.X;
            val_34 = linePt2.Y - val_32;
            val_33 = val_32 ^ val_33;
            val_33 = linePt1.Y ^ pt.Y | val_33;
            val_35 = val_33 >> 5;
            return (bool)val_35;
        }
        internal bool PointOnPolygon(ClipperLibFerr.IntPoint pt, ClipperLibFerr.OutPt pp, bool UseFullRange)
        {
            bool val_5;
            float val_6;
            long val_7;
            float val_8;
            long val_9;
            var val_10;
            val_5 = UseFullRange;
            label_4:
            if(val_5 != false)
            {
                    val_6 = mem[UseFullRange + 16];
                val_6 = UseFullRange + 16;
                val_7 = mem[UseFullRange + 20];
                val_7 = UseFullRange + 20;
                val_8 = mem[UseFullRange + 24];
                val_8 = UseFullRange + 24;
                val_9 = mem[UseFullRange + 28];
                val_9 = UseFullRange + 28;
            }
            else
            {
                    val_9 = 52;
                val_8 = 0f;
                val_7 = 1;
                val_6 = 3.673424E-39f;
            }
            
            var val_1 = (UseFullRange + 32) + 16;
            if((mem[(UseFullRange + 32 + 16) + (0)].PointOnLineSegment(pt:  new ClipperLibFerr.IntPoint() {X = mem[(UseFullRange + 32 + 16) + (4)]>>0&0x0, Y = pt.Y}, linePt1:  new ClipperLibFerr.IntPoint() {X = pp, Y = val_7}, linePt2:  new ClipperLibFerr.IntPoint() {X = val_9, Y = mem[(UseFullRange + 32 + 16) + (4)]}, UseFullRange:  mem[(UseFullRange + 32 + 16) + (12)])) == true)
            {
                goto label_3;
            }
            
            val_5 = mem[UseFullRange + 32];
            val_5 = UseFullRange + 32;
            if(val_5 != UseFullRange)
            {
                goto label_4;
            }
            
            val_10 = 0;
            return (bool)val_10;
            label_3:
            val_10 = 1;
            return (bool)val_10;
        }
        internal static bool SlopesEqual(ClipperLibFerr.TEdge e1, ClipperLibFerr.TEdge e2, bool UseFullRange)
        {
            long val_2;
            ulong val_4;
            var val_5;
            var val_9;
            ClipperLibFerr.IntPoint val_10;
            var val_11;
            ulong val_12;
            var val_13;
            ClipperLibFerr.IntPoint val_9 = e2.Delta;
            val_10 = e1.Delta;
            if(UseFullRange != false)
            {
                    val_11 = 0;
                ClipperLibFerr.Int128 val_1 = ClipperLibFerr.Int128.Int128Mul(lhs:  1152921510269205176, rhs:  R8);
                val_12 = val_4;
                val_9 = val_5;
                ClipperLibFerr.Int128 val_6 = ClipperLibFerr.Int128.Int128Mul(lhs:  1152921510269205176, rhs:  e1.Delta.X);
                bool val_7 = ClipperLibFerr.Int128.op_Equality(val1:  new ClipperLibFerr.Int128() {hi = val_2, lo = val_12}, val2:  new ClipperLibFerr.Int128());
                return (bool)val_13;
            }
            
            val_9 = val_9 ^ e2;
            val_9 = val_10 ^ R7 | val_9;
            val_13 = val_9 >> 5;
            return (bool)val_13;
        }
        internal static bool SlopesEqual(ClipperLibFerr.IntPoint pt1, ClipperLibFerr.IntPoint pt2, ClipperLibFerr.IntPoint pt3, bool UseFullRange)
        {
            ulong val_4;
            long val_6;
            long val_12;
            long val_13;
            long val_14;
            var val_15;
            long val_13 = pt1.X;
            long val_14 = pt3.X;
            val_12 = pt2.Y;
            val_13 = pt2.X;
            if(UseFullRange != false)
            {
                    long val_1 = val_13 - val_14;
                pt1.Y = pt1.Y - pt2.Y;
                ClipperLibFerr.Int128 val_2 = ClipperLibFerr.Int128.Int128Mul(lhs:  1152921510269325368, rhs:  pt1.Y);
                long val_12 = pt3.Y;
                val_12 = pt2.Y - val_12;
                val_14 = val_6;
                val_12 = 0;
                ClipperLibFerr.Int128 val_8 = ClipperLibFerr.Int128.Int128Mul(lhs:  1152921510269325368, rhs:  val_13 - val_13);
                bool val_9 = ClipperLibFerr.Int128.op_Equality(val1:  new ClipperLibFerr.Int128() {hi = val_14, lo = val_4}, val2:  new ClipperLibFerr.Int128());
                return (bool)val_15;
            }
            
            long val_10 = pt2.Y - pt3.Y;
            val_13 = val_13 - val_13;
            pt1.Y = pt1.Y - pt2.Y;
            val_14 = val_13 - val_14;
            val_10 = val_14 ^ val_10;
            val_10 = val_13 ^ R3 | val_10;
            val_15 = val_10 >> 5;
            return (bool)val_15;
        }
        internal static bool SlopesEqual(ClipperLibFerr.IntPoint pt1, ClipperLibFerr.IntPoint pt2, ClipperLibFerr.IntPoint pt3, ClipperLibFerr.IntPoint pt4, bool UseFullRange)
        {
            long val_7;
            long val_8;
            var val_9;
            var val_11;
            var val_12;
            long val_9 = pt1.X;
            val_7 = pt4.X;
            long val_7 = pt3.X;
            val_8 = pt2.Y;
            if(UseFullRange != false)
            {
                    val_7 = val_7 - val_7;
                pt1.Y = pt1.Y - pt2.Y;
                ClipperLibFerr.Int128 val_1 = ClipperLibFerr.Int128.Int128Mul(lhs:  1152921510269437368, rhs:  pt1.Y);
                long val_8 = pt4.Y;
                val_8 = pt3.Y - val_8;
                val_11 = 0;
                ClipperLibFerr.Int128 val_3 = ClipperLibFerr.Int128.Int128Mul(lhs:  1152921510269437368, rhs:  val_9 - pt2.X);
                bool val_4 = ClipperLibFerr.Int128.op_Equality(val1:  new ClipperLibFerr.Int128() {hi = R6, lo = R8}, val2:  new ClipperLibFerr.Int128());
                return (bool)val_12;
            }
            
            val_9 = pt3.Y - pt4.Y;
            val_9 = val_9 - pt2.X;
            long val_5 = pt1.Y - pt2.Y;
            val_7 = val_7 - val_7;
            val_5 = val_5 ^ R1;
            val_5 = R3 ^ pt1.Y | val_5;
            val_12 = val_5 >> 5;
            return (bool)val_12;
        }
        internal ClipperBase()
        {
            536877667 = new System.Collections.Generic.List<Page>();
            this.m_edges = 536877667;
            this.m_MinimaList = 0;
            this.m_CurrentLM = 0;
            mem[1152921510269561456] = 0;
        }
        public virtual void Clear()
        {
            var val_1;
            var val_2;
            this.DisposeLocalMinimaList();
            val_1 = 0;
            goto label_1;
            label_11:
            val_2 = 0;
            goto label_2;
            label_9:
            R6.set_Item(index:  0, value:  0);
            val_2 = 1;
            label_2:
            if(R6 <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            if(val_1 <= val_1)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            if(val_2 < ((0 + 0) + 16 + 12))
            {
                goto label_9;
            }
            
            (0 + 0) + 16.Clear();
            val_1 = 1;
            label_1:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_11;
            }
            
            this.m_edges.Clear();
            this.m_UseFullRange = false;
            this.m_HasOpenPaths = false;
        }
        private void DisposeLocalMinimaList()
        {
            if(this.m_MinimaList != 0)
            {
                    do
            {
                this.m_MinimaList = 0;
                this.m_MinimaList = this.m_MinimaList.Next;
            }
            while(this.m_MinimaList != 0);
            
            }
            
            this.m_CurrentLM = 0;
        }
        private void RangeTest(ClipperLibFerr.IntPoint Pt, ref bool useFullRange)
        {
            var val_11;
            if(LR != 0)
            {
                    var val_1 = 0 - R0;
                var val_2 = 0 - R2;
            }
            else
            {
                    var val_3 = 0 - R2;
                val_11 = 3221225472;
                var val_4 = 0 - R0;
                val_4 = val_11 - val_4;
                if(LR >= 0)
            {
                    val_3 = val_11 - val_3;
                if(LR >= 0)
            {
                    var val_5 = 3221225472 - R2;
                if(LR >= 0)
            {
                    var val_6 = 3221225472 - R0;
                if(LR >= 0)
            {
                    return;
            }
            
            }
            
            }
            
            }
            
                mem2[0] = 1;
            }
            
            if(R4 <= (-1073741823))
            {
                    if(Pt.Y <= 3221225473)
            {
                goto label_6;
            }
            
            }
            
            label_7:
            22709868 = new ClipperLibFerr.ClipperException(description:  22783984);
            label_6:
            if( >= 1073741824)
            {
                goto label_7;
            }
        
        }
        private void InitEdge(ClipperLibFerr.TEdge e, ClipperLibFerr.TEdge eNext, ClipperLibFerr.TEdge ePrev, ClipperLibFerr.IntPoint pt)
        {
            ClipperLibFerr.TEdge val_1 = eNext;
            if(e != 0)
            {
                    e.Next = val_1;
                val_1 = e;
                e.Prev = ePrev;
                mem2[0] = pt.X;
                mem2[0] = pt.X;
                mem2[0] = pt.Y;
                mem2[0] = pt.Y;
            }
            else
            {
                    mem[104] = val_1;
                mem[108] = ePrev;
                mem[28] = pt.X;
                mem[24] = pt.X;
                mem[36] = pt.Y;
                mem[32] = pt.Y;
            }
            
            e.OutIdx = 0;
        }
        private void InitEdge2(ClipperLibFerr.TEdge e, ClipperLibFerr.PolyType polyType)
        {
            var val_1;
            if(e != 0)
            {
                
            }
            else
            {
                    val_1 = 22965384;
            }
            
            val_1 = val_1 - e.Next;
            if(e.Next < 0)
            {
                    e.Top = e.Curr;
                mem2[0] = polyType;
                mem2[0] = e;
                mem2[0] = 32;
                if(e.Next != 0)
            {
                goto label_5;
            }
            
            }
            else
            {
                    e.Bot = e.Curr;
                mem2[0] = polyType;
                mem2[0] = e;
                mem2[0] = 32;
            }
            
            label_5:
            e.Top.SetDx(e:  e);
            e.PolyTyp = polyType;
        }
        private ClipperLibFerr.TEdge FindNextLocMin(ClipperLibFerr.TEdge E)
        {
            ClipperLibFerr.IntPoint val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            ClipperLibFerr.TEdge val_9;
            ClipperLibFerr.TEdge val_10;
            ClipperLibFerr.TEdge val_11;
            do
            {
                label_20:
                if(E != 0)
            {
                    val_4 = E.Bot;
            }
            else
            {
                    val_7 = 1;
                val_6 = 2621443;
                val_5 = 0;
                val_4 = 0;
            }
            
            }
            while((ClipperLibFerr.IntPoint.op_Inequality(a:  new ClipperLibFerr.IntPoint() {Y = 2621443}, b:  new ClipperLibFerr.IntPoint() {X = mem[E.Prev.Bot + (0)], Y = mem[E.Prev.Bot + (8)]})) == true);
            
            bool val_2 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[E.Curr + (0)]>>0&0x0, Y = mem[E.Curr + (8)]>>0&0x0}, b:  new ClipperLibFerr.IntPoint() {X = mem[E.Curr + (16)], Y = val_4});
            if(val_2 == false)
            {
                goto label_4;
            }
            
            goto label_20;
            label_4:
            if(val_2 != false)
            {
                    if(E.Prev != 0)
            {
                    return;
            }
            
            }
            
            val_10 = E;
            goto label_9;
            label_12:
            val_10 = E.Prev;
            label_9:
            if(E.Prev.Prev == 0)
            {
                goto label_12;
            }
            
            val_11 = val_10;
            goto label_13;
            label_17:
            val_11 = E.Prev.Next;
            label_13:
            if(val_11 == 0)
            {
                goto label_14;
            }
            
            if(val_11 == 0)
            {
                goto label_17;
            }
            
            goto label_16;
            label_14:
            if(val_11 == 0)
            {
                goto label_17;
            }
            
            val_8 = 6;
            val_7 = 1835037;
            goto label_18;
            label_16:
            label_18:
            var val_3 = (mem[E.Curr + (16)]) ^ (mem[E.Curr + (4)]);
            val_2 = val_7 ^ val_2;
            if(E.Prev.Next.Prev != 0)
            {
                    val_9 = E.Prev.Prev;
                ClipperLibFerr.IntPoint val_4 = E.Prev.Next.Bot;
                val_4 = E.Prev.Prev.Bot - val_4;
                if(val_9 >= 0)
            {
                    val_10 = val_11;
            }
            
            }
        
        }
        private ClipperLibFerr.TEdge ProcessBound(ClipperLibFerr.TEdge E, bool LeftBoundIsForward)
        {
            var val_5;
            var val_6;
            ClipperLibFerr.TEdge val_7;
            var val_8;
            bool val_9;
            var val_10;
            float val_11;
            ClipperLibFerr.TEdge val_13;
            var val_14;
            float val_15;
            ClipperLibFerr.TEdge val_16;
            val_5 = this;
            val_6 = LeftBoundIsForward;
            int val_5 = E.OutIdx;
            if(val_5 != 2)
            {
                goto label_2;
            }
            
            if(val_6 == false)
            {
                goto label_3;
            }
            
            val_7 = E;
            goto label_4;
            label_8:
            val_7 = E.Next;
            label_4:
            if(val_7 != 0)
            {
                
            }
            else
            {
                    val_5 = 6;
                val_8 = 1835037;
            }
            
            E = val_5 ^ E;
            val_5 = val_8 ^ val_5;
            if(E.Next.Next == 0)
            {
                goto label_8;
            }
            
            val_9 = val_6;
            if(val_7 == E)
            {
                goto label_27;
            }
            
            label_12:
            if(val_7 != 0)
            {
                goto label_24;
            }
            
            if(E.Next.Prev != E)
            {
                goto label_12;
            }
            
            goto label_27;
            label_2:
            if(val_5 != 2)
            {
                goto label_40;
            }
            
            if(val_6 == true)
            {
                    104 = 108;
            }
            
            if(E.Prev == 0)
            {
                goto label_15;
            }
            
            goto label_16;
            label_3:
            val_7 = E;
            goto label_17;
            label_21:
            val_7 = E.Prev;
            label_17:
            if(val_7 != 0)
            {
                
            }
            else
            {
                    val_11 = 8.407791E-45f;
                val_10 = 1835037;
            }
            
            E = val_11 ^ E;
            val_5 = val_10 ^ val_5;
            if(E.Prev.Prev == 0)
            {
                goto label_21;
            }
            
            val_9 = val_6;
            if(val_7 == E)
            {
                goto label_27;
            }
            
            label_25:
            if(val_7 != 0)
            {
                goto label_24;
            }
            
            if(E.Prev.Next != E)
            {
                goto label_25;
            }
            
            goto label_27;
            label_24:
            if(val_7 == E)
            {
                goto label_27;
            }
            
            if(val_9 == true)
            {
                    108 = 104;
            }
            
            536889811 = new ClipperLibFerr.LocalMinima();
            mem[536889835] = 0;
            mem[536889819] = mem[536889835];
            mem[536889827] = 0;
            mem[536889831] = E.Next;
            E.Next.WindDelta = 0;
            this.InsertLocalMinima(newLm:  536889811);
            goto label_33;
            label_27:
            if(val_9 == false)
            {
                    val_5 = E.Prev;
            }
            
            if(val_9 == true)
            {
                    val_5 = E.Next;
            }
            
            goto label_35;
            label_15:
            label_16:
            ClipperLibFerr.IntPoint val_2 = E.Prev.Bot ^ E.Bot;
            E = E ^ (E + 8 + 4);
            if(E.Prev != 0)
            {
                goto label_36;
            }
            
            val_6 = val_6;
            if(E.Prev == 0)
            {
                goto label_40;
            }
            
            bool val_3 = val_6 ^ (E + 8 + 4);
            ClipperLibFerr.IntPoint val_4 = E.Prev.Top ^ E.Bot;
            if(E.Prev != 0)
            {
                goto label_38;
            }
            
            goto label_40;
            label_36:
            val_6 = val_6;
            if(E.Prev == 0)
            {
                goto label_40;
            }
            
            label_38:
            E.Top = E.Bot;
            mem2[0] = E.Top;
            label_40:
            val_13 = E;
            if(val_6 == true)
            {
                goto label_41;
            }
            
            goto label_42;
            label_48:
            int val_6 = E.Next.OutIdx;
            if(val_6 == 2)
            {
                goto label_44;
            }
            
            val_13 = E.Next;
            label_41:
            if(val_13 != 0)
            {
                
            }
            else
            {
                    val_15 = 8.407791E-45f;
                val_14 = 1835037;
            }
            
            E = val_15 ^ E;
            val_6 = val_14 ^ val_6;
            if(E.Next.Next == 0)
            {
                goto label_48;
            }
            
            label_44:
            if((E.Next.Next == 0) && (E.Next.Next.OutIdx != 2))
            {
                    do
            {
                val_16 = E.Next.Prev;
                if(E.Next.Prev == 0)
            {
                    val_16 = E.Next.Prev;
            }
            
            }
            while(E.Next.Prev == 0);
            
                ClipperLibFerr.IntPoint val_7 = E.Next.Next.Top;
                val_7 = val_7 - E.Next.Prev.Top;
                if(E.Next.Next < 0)
            {
                    val_13 = E.Next.Prev;
            }
            
            }
        
        }
        public bool AddPath(System.Collections.Generic.List<ClipperLibFerr.IntPoint> pg, ClipperLibFerr.PolyType polyType, bool Closed)
        {
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_51;
            var val_52;
            bool val_53;
            ClipperLibFerr.TEdge val_54;
            var val_55;
            var val_56;
            long val_57;
            long val_58;
            var val_59;
            var val_60;
            ClipperLibFerr.ClipperBase val_61;
            float val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            ClipperLibFerr.TEdge val_70;
            ClipperLibFerr.TEdge val_71;
            var val_72;
            var val_73;
            ClipperLibFerr.TEdge val_74;
            long val_75;
            float val_76;
            var val_77;
            var val_78;
            var val_79;
            long val_80;
            float val_81;
            var val_82;
            var val_83;
            var val_84;
            long val_85;
            long val_86;
            long val_87;
            ClipperLibFerr.ClipperException val_88;
            var val_89;
            var val_90;
            long val_91;
            var val_92;
            var val_93;
            var val_94;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            ClipperLibFerr.ClipperBase val_99;
            var val_100;
            var val_101;
            float val_102;
            var val_103;
            val_51 = pg;
            bool val_50 = Closed;
            val_50 = val_50 ^ 1;
            if(polyType == 1)
            {
                    if(val_50 == true)
            {
                goto label_2;
            }
            
            }
            
            val_53 = val_50;
            val_54 = val_50 - 1;
            if(val_54 < true)
            {
                    0 = 1;
            }
            
            if(val_54 != true)
            {
                goto label_4;
            }
            
            val_55 = 8 | (val_50 << 4);
            goto label_5;
            label_10:
            bool val_1 = val_54 - 1;
            if(val_1 < true)
            {
                goto label_6;
            }
            
            val_55 = val_55 - 16;
            val_54 = val_1;
            val_52 = mem[pg + 12];
            val_52 = pg + 12;
            label_5:
            if(val_52 > val_54)
            {
                    val_56 = mem[pg + 8];
                val_56 = pg + 8;
                val_57 = mem[pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16)];
                val_57 = pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16);
                val_58 = pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16) + -8;
                val_59 = pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16) + -4;
                val_60 = mem[pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16) + 4];
                val_60 = pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16) + 4;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_56 = mem[pg + 8];
                val_56 = pg + 8;
                val_53 = val_56;
                val_57 = mem[pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16)];
                val_57 = pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16);
                val_58 = pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16) + -8;
                val_59 = pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16) + -4;
                val_60 = mem[pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16) + 4];
                val_60 = pg + 8 + ((8 | ((Closed ^ 1)) << 4) - 16) + 4;
                if((pg + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_56 = mem[pg + 8];
                val_56 = pg + 8;
            }
            
            }
            
            var val_2 = val_56 + 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = val_58, Y = val_57}, b:  new ClipperLibFerr.IntPoint() {X = mem[(pg + 8 + 16) + (0)], Y = mem[(pg + 8 + 16) + (8)]})) == true)
            {
                goto label_10;
            }
            
            goto label_11;
            label_6:
            val_54 = val_54 - 1;
            label_11:
            val_51 = val_51;
            label_4:
            label_15:
            val_61 = val_54;
            val_62 = 16 + (val_54 << 4);
            if(val_54 < true)
            {
                goto label_12;
            }
            
            val_63 = mem[pg + 12];
            val_63 = pg + 12;
            if(val_63 <= val_61)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_63 = mem[pg + 12];
                val_63 = pg + 12;
            }
            
            val_64 = mem[pg + 8];
            val_64 = pg + 8;
            val_54 = val_61 - 1;
            if(val_63 <= val_54)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_64 = mem[pg + 8];
                val_64 = pg + 8;
            }
            
            Closed = (val_64 + val_62) - 16;
            val_51 = val_51;
            var val_7 = val_62 - 16;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4), Y = mem[pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4) + (8)]}, b:  new ClipperLibFerr.IntPoint() {X = mem[((pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4)) - 16) + (0)], Y = mem[((pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4)) - 16) + (8)]})) == true)
            {
                goto label_15;
            }
            
            label_12:
            if(Closed == false)
            {
                goto label_16;
            }
            
            val_65 = 0;
            if(val_61 > true)
            {
                goto label_17;
            }
            
            return (bool)val_65;
            label_16:
            if(val_61 < true)
            {
                goto label_79;
            }
            
            label_17:
            536878353 = new System.Collections.Generic.List<SingleRange>(capacity:  val_61 + 1);
            var val_51 = 0;
            do
            {
                536894763 = new ClipperLibFerr.TEdge();
                536878353.Add(item:  536894763);
                val_51 = val_51 + 1;
            }
            while(val_51 <= val_61);
            
            if(mem[536878365] <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((pg + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_52 = pg + 8;
            val_52 = val_52 + 32;
            var val_12 = (mem[536878361] + 20) + 24;
            if((pg + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.RangeTest(Pt:  new ClipperLibFerr.IntPoint() {X = pg + 8 + 24, Y = pg + 8 + 20}, useFullRange: ref  pg + 8 + 28);
            if((pg + 12) <= val_61)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            RangeTest(Pt:  new ClipperLibFerr.IntPoint() {X = pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4) + 8, Y = pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4) + 4}, useFullRange: ref  pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4) + 12);
            val_66 = mem[536878365];
            if(val_66 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_66 = mem[536878365];
            }
            
            val_67 = mem[536878361];
            if(val_66 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_67 = mem[536878361];
                val_66 = mem[536878365];
            }
            
            if(val_66 <= val_61)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_67 = mem[536878361];
            }
            
            val_67 = val_67 + (val_61 << 2);
            if((pg + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_15 = (pg + 8) + 16;
            pg + 8 + 28.InitEdge(e:  mem[536878361] + 16, eNext:  mem[536878361] + 20, ePrev:  (mem[536878361] + ((((Closed ^ 1) - 1) - 1)) << 2) + 16, pt:  new ClipperLibFerr.IntPoint() {X = mem[(pg + 8 + 16) + (0)], Y = mem[(pg + 8 + 16) + (8)]});
            val_68 = mem[536878365];
            if(val_68 > val_61)
            {
                    val_69 = mem[536878361];
                var val_16 = val_69 + (val_61 << 2);
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_69 = mem[536878361];
                val_68 = mem[536878365];
                var val_17 = val_69 + (val_61 << 2);
                if(val_68 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_69 = mem[536878361];
                val_68 = mem[536878365];
            }
            
            }
            
            bool val_18 = val_61 - 1;
            if(val_68 <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_69 = mem[536878361];
            }
            
            val_69 = val_69 + (val_61 << 2);
            if((pg + 12) <= val_61)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_70 = mem[536878361] + 16;
            val_71 = (mem[536878361] + ((((Closed ^ 1) - 1) - 1)) << 2) + 16;
            pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4) + 12.InitEdge(e:  val_71, eNext:  val_70, ePrev:  (mem[536878361] + ((((Closed ^ 1) - 1) - 1)) << 2) + 12, pt:  new ClipperLibFerr.IntPoint() {X = pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4), Y = mem[pg + 8 + (16 + ((((Closed ^ 1) - 1) - 1)) << 4) + (8)]});
            if(val_18 >= true)
            {
                    do
            {
                bool val_19 = val_61 - 1;
                if((pg + 12) <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                RangeTest(Pt:  new ClipperLibFerr.IntPoint() {X = pg + 8 + ((16 + ((((Closed ^ 1) - 1) - 1)) << 4) - 8), Y = (mem[536878361] + ((((Closed ^ 1) - 1) - 1)) << 2) + 12}, useFullRange: ref  pg + 8 + ((16 + ((((Closed ^ 1) - 1) - 1)) << 4) - 8) + 4);
                val_72 = mem[536878365];
                if(val_72 <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_72 = mem[536878365];
            }
            
                val_73 = mem[536878361];
                bool val_21 = val_19 + 1;
                var val_22 = val_73 + (val_61 << 2);
                if(val_72 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_73 = mem[536878361];
                val_72 = mem[536878365];
            }
            
                var val_23 = val_73 + (val_61 << 2);
                val_21 = val_21 - 2;
                if(val_72 <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_73 = mem[536878361];
            }
            
                var val_24 = val_73 + (val_61 << 2);
                val_21 = val_21 + 1;
                if((pg + 12) <= val_21)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_70 = (mem[536878361] + ((((Closed ^ 1) - 1) - 1)) << 2) + 16;
                val_71 = (mem[536878361] + ((((Closed ^ 1) - 1) - 1)) << 2) + 12;
                pg + 8 + ((16 + ((((Closed ^ 1) - 1) - 1)) << 4) - 8) + 4.InitEdge(e:  val_71, eNext:  val_70, ePrev:  (mem[536878361] + ((((Closed ^ 1) - 1) - 1)) << 2) + 8, pt:  new ClipperLibFerr.IntPoint() {X = pg + 8 + ((16 + ((((Closed ^ 1) - 1) - 1)) << 4) - 8) + -8, Y = pg + 8 + ((16 + ((((Closed ^ 1) - 1) - 1)) << 4) - 8)});
                var val_26 = (val_62 - 8) - 16;
            }
            while((val_21 - 1) > false);
            
            }
            
            if(mem[536878365] == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_74 = mem[mem[536878361] + 16];
            val_74 = mem[536878361] + 16;
            val_75 = val_74;
            goto label_47;
            label_69:
            if(val_74 == val_75)
            {
                    val_75 = val_71;
            }
            
            val_71 = val_74;
            ClipperLibFerr.TEdge val_27 = mem[536878361].RemoveEdge(e:  val_71);
            val_74 = mem[536878361];
            goto label_47;
            label_63:
            val_71 = val_74;
            if(val_74 == val_75)
            {
                    val_75 = mem[mem[536878361] + 104];
                val_75 = mem[536878361] + 104;
            }
            
            ClipperLibFerr.TEdge val_28 = mem[536878361].RemoveEdge(e:  val_71);
            val_74 = mem[mem[536878361] + 108];
            val_74 = mem[536878361] + 108;
            label_47:
            label_67:
            if(val_74 != 0)
            {
                    val_51 = val_74;
                val_76 = mem[mem[536878361] + 108 + 24];
                val_76 = mem[536878361] + 108 + 24;
                val_77 = mem[mem[536878361] + 108 + 24 + 4];
                val_77 = mem[536878361] + 108 + 24 + 4;
                val_62 = mem[mem[536878361] + 108 + 24 + 8];
                val_62 = mem[536878361] + 108 + 24 + 8;
                val_78 = mem[mem[536878361] + 108 + 24 + 12];
                val_78 = mem[536878361] + 108 + 24 + 12;
            }
            else
            {
                    val_71 = 32;
                val_78 = 83886592;
                val_51 = 24;
                val_62 = 4.085283E-38f;
                val_77 = 52;
                val_76 = 0f;
            }
            
            val_79 = mem[mem[536878361] + 108 + 104];
            val_79 = mem[536878361] + 108 + 104;
            var val_29 = val_79 + 24;
            val_80 = val_78;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {Y = 22965384}, b:  new ClipperLibFerr.IntPoint() {X = mem[(mem[536878361] + 108 + 104 + 24) + (0)], Y = mem[(mem[536878361] + 108 + 104 + 24) + (8)]})) == false)
            {
                goto label_52;
            }
            
            val_81 = val_75;
            var val_31 = (mem[536878361] + 108 + 104) - val_81;
            val_61 = 1152921510270809616;
            val_82 = val_81;
            val_31 = val_31 >> 5;
            if(val_31 != val_50)
            {
                goto label_53;
            }
            
            goto label_54;
            label_52:
            val_61 = 1152921510270809616;
            val_82 = mem[536878361] + 108 + 104;
            val_81 = val_75;
            label_53:
            val_83 = mem[mem[536878361] + 108 + 108];
            val_83 = mem[536878361] + 108 + 108;
            if(val_83 == val_82)
            {
                goto label_70;
            }
            
            if(val_74 == 0)
            {
                goto label_59;
            }
            
            if(val_83 == 0)
            {
                    val_84 = mem[mem[536878361] + 108 + 104];
                val_84 = mem[536878361] + 108 + 104;
            }
            
            val_85 = mem[mem[536878361] + 108 + 108 + 24];
            val_85 = mem[536878361] + 108 + 108 + 24;
            val_86 = mem[mem[536878361] + 108 + 108 + 32];
            val_86 = mem[536878361] + 108 + 108 + 32;
            val_62 = 4.085283E-38f;
            if(val_84 == 0)
            {
                    val_87 = val_86;
                val_86 = val_87;
                val_85 = val_85;
            }
            
            var val_32 = val_84 + 24;
            val_80 = mem[536878361] + 108 + 108 + 36;
            bool val_33 = ClipperLibFerr.ClipperBase.SlopesEqual(pt1:  new ClipperLibFerr.IntPoint() {X = val_85, Y = val_86}, pt2:  new ClipperLibFerr.IntPoint() {X = val_51, Y = val_62}, pt3:  new ClipperLibFerr.IntPoint() {X = mem[(mem[536878361] + 108 + 104 + 24) + (0)], Y = mem[(mem[536878361] + 108 + 104 + 24) + (8)]}, UseFullRange:  this.m_UseFullRange);
            val_61 = 1152921510270809616;
            val_81 = val_75;
            if(val_33 == false)
            {
                goto label_59;
            }
            
            if(val_33 == false)
            {
                goto label_63;
            }
            
            val_80 = mem[mem[536878361] + 108 + 108 + 28];
            val_80 = mem[536878361] + 108 + 108 + 28;
            val_89 = mem[mem[536878361] + 108 + 108 + 32];
            val_89 = mem[536878361] + 108 + 108 + 32;
            val_62 = mem[mem[536878361] + 108 + 104];
            val_62 = mem[536878361] + 108 + 104;
            if(val_62 == 0)
            {
                    val_89 = val_89;
                val_90 = val_90;
                val_91 = val_91;
                val_80 = val_80;
            }
            
            val_51 = mem[mem[536878361] + 108 + 104 + 24];
            val_51 = mem[536878361] + 108 + 104 + 24;
            val_88 = mem[mem[536878361] + 108 + 104 + 32];
            val_88 = mem[536878361] + 108 + 104 + 32;
            val_79 = mem[mem[536878361] + 108 + 104 + 36];
            val_79 = mem[536878361] + 108 + 104 + 36;
            val_61 = 1152921510270809616;
            val_81 = val_75;
            if((this.Pt2IsBetweenPt1AndPt3(pt1:  new ClipperLibFerr.IntPoint() {X = mem[536878361] + 108 + 108 + 36, Y = val_80}, pt2:  new ClipperLibFerr.IntPoint() {X = mem[536878361] + 108 + 108 + 36, Y = val_81}, pt3:  new ClipperLibFerr.IntPoint() {X = val_91, Y = mem[536878361] + 108 + 104 + 28})) == false)
            {
                goto label_63;
            }
            
            label_59:
            val_74 = mem[mem[536878361] + 108 + 104];
            val_74 = mem[536878361] + 108 + 104;
            if(val_74 == val_74)
            {
                goto label_64;
            }
            
            if((val_74 != 0) || ((mem[536878361] + 108 + 104 + 104) != val_81))
            {
                goto label_67;
            }
            
            goto label_68;
            label_54:
            if(val_74 != (mem[536878361] + 108 + 104))
            {
                goto label_69;
            }
            
            goto label_70;
            label_64:
            val_74 = val_74;
            label_70:
            val_92 = val_74;
            if(val_92 == 0)
            {
                goto label_71;
            }
            
            if(val_74 == 0)
            {
                goto label_72;
            }
            
            val_93 = mem[mem[536878361] + 108 + 108];
            val_93 = mem[536878361] + 108 + 108;
            goto label_73;
            label_71:
            if(val_74 == 0)
            {
                goto label_96;
            }
            
            label_68:
            if(val_74 == (mem[536878361] + 108 + 104))
            {
                goto label_79;
            }
            
            mem[1152921510270809649] = 1;
            mem2[0] = 1;
            goto label_78;
            label_72:
            val_93 = 5;
            label_73:
            if(val_93 == (mem[536878361] + 108 + 104))
            {
                goto label_79;
            }
            
            label_78:
            do
            {
                ClipperLibFerr.TEdge val_53 = val_81;
                this.m_UseFullRange.InitEdge2(e:  val_53, polyType:  mem[536878361] + 108 + 108 + 24);
                val_94 = 0;
                if((1 & 1) == 0)
            {
                    var val_54 = val_81 + 32;
                val_53 = val_79 ^ val_53;
                val_54 = (mem[536878361] + 104 + 104 + 32) ^ val_54;
                val_54 = val_54 | val_53;
                val_94 = val_54 >> 5;
            }
            
                val_51 = val_94;
            }
            while((mem[536878361] + 104 + 104) != val_81);
            
            if(val_94 == 0)
            {
                goto label_85;
            }
            
            val_65 = 0;
            if(val_74 != 0)
            {
                    return (bool)val_65;
            }
            
            mem2[0] = 1;
            ClipperLibFerr.LocalMinima val_36 = 536889811;
            val_62 = val_36;
            val_36 = new ClipperLibFerr.LocalMinima();
            mem[536889835] = 0;
            if(val_62 == 0)
            {
                goto label_90;
            }
            
            mem[536889819] = mem[536878361] + 104 + 16;
            mem[536889827] = 0;
            val_95 = val_62;
            val_96 = val_81;
            mem[536889831] = val_81;
            goto label_91;
            label_79:
            val_65 = 0;
            return (bool)val_65;
            label_85:
            val_92 = mem[536878361] + 104 + 104;
            val_92.Add(item:  mem[536878361] + 108 + 108 + 36);
            val_88 = mem[mem[536878361] + 104 + 108];
            val_88 = mem[536878361] + 104 + 108;
            val_97 = val_88;
            if(val_88 != 0)
            {
                goto label_95;
            }
            
            val_98 = mem[mem[536878361] + 104 + 108];
            val_98 = mem[536878361] + 104 + 108;
            if(val_98 == 0)
            {
                goto label_96;
            }
            
            label_95:
            var val_37 = val_88 + 8;
            val_51 = mem[mem[536878361] + 104 + 108 + 40];
            val_51 = mem[536878361] + 104 + 108 + 40;
            val_59 = mem[mem[536878361] + 104 + 108 + 52];
            val_59 = mem[536878361] + 104 + 108 + 52;
            bool val_38 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[(mem[536878361] + 104 + 108 + 8) + (0)]>>0&0x0, Y = mem[(mem[536878361] + 104 + 108 + 8) + (8)]>>0&0x0}, b:  new ClipperLibFerr.IntPoint() {X = val_51, Y = mem[536878361] + 104 + 108 + 48});
            if(val_38 == true)
            {
                    val_54 = mem[mem[536878361] + 104 + 104];
                val_54 = mem[536878361] + 104 + 104;
            }
            
            ClipperLibFerr.TEdge val_39 = val_38.FindNextLocMin(E:  val_54);
            if(val_38 == false)
            {
                goto label_122;
            }
            
            label_121:
            ClipperLibFerr.LocalMinima val_40 = 536889811;
            val_62 = val_40;
            val_40 = new ClipperLibFerr.LocalMinima();
            if(false == 0)
            {
                    false = val_38;
            }
            
            mem[536889835] = 0;
            val_99 = 1152921510270809616;
            if(val_38 != false)
            {
                    mem[536889819] = val_38 + 16;
            }
            else
            {
                    mem[536889819] = 4297588739;
            }
            
            if((val_38 + 108) < 0)
            {
                    val_100 = val_62;
                mem[536889827] = val_38 + 108;
                mem[536889831] = val_38;
                val_61 = 0;
            }
            else
            {
                    val_100 = val_62;
                mem[536889827] = val_38;
                mem[536889831] = val_38 + 108;
                val_61 = 1;
            }
            
            mem2[0] = 0;
            val_59 = val_62;
            mem2[0] = 1;
            if(val_74 != 0)
            {
                    if((val_38 + 104) != mem[536889831])
            {
                    val_74 = 1;
            }
            
                if((val_38 + 104) == mem[536889831])
            {
                    val_74 = 0;
            }
            
                mem2[0] = val_74;
                val_99 = 1152921510270809616;
            }
            else
            {
                    mem2[0] = 0;
            }
            
            mem2[0] = 0 - (val_38 + 88);
            ClipperLibFerr.TEdge val_42 = this.m_UseFullRange.ProcessBound(E:  mem[536889827], LeftBoundIsForward:  true);
            val_101 = val_99;
            if(val_99 == 2)
            {
                    ClipperLibFerr.TEdge val_43 = this.m_UseFullRange.ProcessBound(E:  1368995344, LeftBoundIsForward:  true);
                val_101 = val_99;
            }
            
            bool val_44 = val_61 ^ 1;
            ClipperLibFerr.TEdge val_45 = this.m_UseFullRange.ProcessBound(E:  mem[536889831], LeftBoundIsForward:  val_44);
            if(val_99 == 2)
            {
                    ClipperLibFerr.TEdge val_46 = this.m_UseFullRange.ProcessBound(E:  1368995344, LeftBoundIsForward:  val_44);
            }
            
            if((val_38 + 100) != 2)
            {
                goto label_117;
            }
            
            val_51 = 0;
            mem[536889827] = val_51;
            goto label_118;
            label_117:
            val_51 = 0;
            if((val_38 + 108 + 100) != 2)
            {
                goto label_120;
            }
            
            mem[536889831] = val_51;
            label_118:
            label_120:
            this.m_UseFullRange.InsertLocalMinima(newLm:  536889811);
            if(val_61 != 0)
            {
                    val_54 = val_101;
            }
            
            ClipperLibFerr.TEdge val_47 = this.m_UseFullRange.FindNextLocMin(E:  1368995344);
            if(1152921510270809616 == true)
            {
                goto label_121;
            }
            
            goto label_122;
            label_90:
            mem[12] = val_79;
            mem[8] = mem[536878361] + 104 + 16;
            mem[16] = 0;
            val_95 = 20;
            val_96 = val_81;
            mem[20] = val_81;
            label_91:
            mem2[0] = 1;
            val_51 = 8;
            mem2[0] = 0;
            goto label_126;
            label_131:
            val_96 = mem[mem[536878361] + 104 + 104];
            val_96 = mem[536878361] + 104 + 104;
            var val_48 = val_81 + 112;
            mem2[0] = val_96;
            val_102 = mem[mem[536878361] + 104 + 104];
            val_102 = mem[536878361] + 104 + 104;
            label_126:
            if(val_102 != 0)
            {
                    val_103 = val_102;
                val_61 = mem[mem[536878361] + 104 + 104 + 8];
                val_61 = mem[536878361] + 104 + 104 + 8;
            }
            else
            {
                    val_103 = val_102;
                val_102 = mem[12];
                val_61 = mem[8];
            }
            
            var val_55 = mem[536878361] + 104 + 104 + 108 + 40;
            val_96 = val_102 ^ val_96;
            val_54 = val_103;
            val_55 = val_61 ^ val_55;
            if((mem[536878361] + 104 + 104 + 108) != 0)
            {
                    val_55 = mem[mem[536878361] + 104 + 104 + 8];
                val_55 = mem[536878361] + 104 + 104 + 8;
                mem[536878361] + 108 + 108 + 24 = mem[mem[536878361] + 104 + 104 + 40];
                mem[536878361] + 108 + 108 + 24 = mem[536878361] + 104 + 104 + 40;
                mem2[0] = val_55;
                mem2[0] = mem[536878361] + 108 + 108 + 24;
            }
            
            val_59 = mem[mem[536878361] + 104 + 104 + 104];
            val_59 = mem[536878361] + 104 + 104 + 104;
            if((mem[536878361] + 104 + 104 + 104 + 100) != 2)
            {
                goto label_131;
            }
            
            this.m_UseFullRange.InsertLocalMinima(newLm:  536889811);
            this.m_UseFullRange.Add(item:  mem[536878361] + 108 + 108 + 36);
            label_122:
            val_65 = 1;
            return (bool)val_65;
            label_2:
            val_88 = 22709868;
            val_88 = new ClipperLibFerr.ClipperException(description:  22781716);
            val_92 = val_88;
            label_96:
        }
        public bool AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> ppg, ClipperLibFerr.PolyType polyType, bool closed)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            val_3 = 0;
            goto label_1;
            label_4:
            if(true <= val_2)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            bool val_1 = this.AddPath(pg:  (0 + 0) + 16, polyType:  polyType, Closed:  closed);
            val_3 = val_3 | val_1;
            val_2 = 1;
            label_1:
            if(val_2 < val_1)
            {
                goto label_4;
            }
            
            val_1 = val_3;
            return (bool)val_1;
        }
        internal bool Pt2IsBetweenPt1AndPt3(ClipperLibFerr.IntPoint pt1, ClipperLibFerr.IntPoint pt2, ClipperLibFerr.IntPoint pt3)
        {
            long val_1;
            var val_9;
            var val_10;
            val_9 = 0;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = R2, Y = val_1}, b:  new ClipperLibFerr.IntPoint() {X = pt3.X, Y = pt3.Y})) == true)
            {
                    return (bool)val_9;
            }
            
            val_9 = 0;
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = R2, Y = val_1}, b:  new ClipperLibFerr.IntPoint() {X = pt2.X, Y = pt2.Y})) == true)
            {
                    return (bool)val_9;
            }
            
            val_9 = 0;
            bool val_5 = ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = pt3.X, Y = pt3.Y}, b:  new ClipperLibFerr.IntPoint() {X = pt2.X, Y = pt2.Y});
            if(val_5 == true)
            {
                    return (bool)val_9;
            }
            
            long val_6 = R2 ^ pt3.X;
            long val_10 = pt2.Y;
            long val_7 = pt1.Y ^ pt3.Y;
            if(val_5 != true)
            {
                    long val_9 = pt3.Y;
                val_9 = val_10 - val_9;
                if(val_5 < false)
            {
                    val_10 = 1;
            }
            
                val_10 = val_1 - val_10;
            }
            else
            {
                    long val_8 = pt2.X - pt3.X;
                long val_11 = pt2.X;
                if(val_5 < false)
            {
                    val_10 = 1;
            }
            
                val_11 = R2 - val_11;
                if(val_5 >= false)
            {
                    0 = 1;
            }
            
                val_9 = 1 ^ 1;
                return (bool)val_9;
            }
        
        }
        private ClipperLibFerr.TEdge RemoveEdge(ClipperLibFerr.TEdge e)
        {
            ClipperLibFerr.TEdge val_1;
            ClipperLibFerr.TEdge val_2;
            if(e != 0)
            {
                    val_1 = e;
                val_2 = e.Prev;
            }
            else
            {
                    val_1 = 108;
                val_2 = 5;
            }
            
            mem[109] = e.Next;
            e.Next.Prev = val_1;
            mem[108] = 0;
        }
        private void SetDx(ClipperLibFerr.TEdge e)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            double val_7;
            if(e == 0)
            {
                goto label_0;
            }
            
            float val_1 = Q9 - Q8;
            val_2 = D17;
            val_3 = D17;
            if(e == 0)
            {
                goto label_3;
            }
            
            val_4 = D16;
            val_5 = D16;
            goto label_2;
            label_0:
            mem[56] = 2097204;
            mem[60] = 2097204;
            val_3 = 64;
            mem[64] = -786406;
            mem[68] = -786406;
            val_6 = -786406;
            if(val_6 == 0)
            {
                goto label_3;
            }
            
            val_4 = mem[60];
            val_5 = mem[56];
            val_2 = mem[68];
            val_3 = mem[64];
            label_2:
            val_6 = val_5;
            val_7 = 2097204 / 4294180890;
            goto label_4;
            label_3:
            val_7 = 1.65408152838933E-314;
            label_4:
            e.Dx = val_7;
        }
        private void InsertLocalMinima(ClipperLibFerr.LocalMinima newLm)
        {
            var val_1;
            ClipperLibFerr.LocalMinima val_2;
            var val_3;
            val_1 = this;
            val_2 = this.m_MinimaList;
            if(val_2 == 0)
            {
                goto label_0;
            }
            
            if(newLm != 0)
            {
                goto label_1;
            }
            
            val_2 = val_2;
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            label_1:
            val_3 = newLm;
            long val_1 = this.m_MinimaList.Y;
            val_1 = newLm.Y - val_1;
            if(val_2 >= 0)
            {
                goto label_3;
            }
            
            label_6:
            val_1 = val_2;
            if(this.m_MinimaList.Next == 0)
            {
                goto label_5;
            }
            
            long val_2 = this.m_MinimaList.Next.Y;
            val_2 = (mem[newLm + 8 + (0)]) - val_2;
            if(this.m_MinimaList.Next < 0)
            {
                goto label_6;
            }
            
            label_5:
            newLm.Next = this.m_MinimaList.Next;
            this.m_MinimaList.Next = newLm;
            goto label_7;
            label_3:
            newLm.Next = val_2;
            label_0:
            this.m_MinimaList = newLm;
            label_7:
            label_2:
        }
        internal bool PopLocalMinima(long Y, out ClipperLibFerr.LocalMinima current)
        {
            var val_2;
            mem2[0] = this.m_CurrentLM;
            val_2 = 0;
            if(this.m_CurrentLM == 0)
            {
                    return (bool)val_2;
            }
            
            long val_2 = this.m_CurrentLM.Y;
            val_2 = val_2 ^ R2;
            if(this.m_CurrentLM != 0)
            {
                    return (bool)val_2;
            }
            
            this.m_CurrentLM = this.m_CurrentLM.Next;
            val_2 = 1;
            return (bool)val_2;
        }
        private void ReverseHorizontal(ClipperLibFerr.TEdge e)
        {
            e.Top = e.Bot;
            e.Bot = e.Top;
        }
        internal virtual void Reset()
        {
            this.m_CurrentLM = this.m_MinimaList;
            if(this.m_CurrentLM != 0)
            {
                    this.m_Scanbeam = 0;
                if(this.m_MinimaList != 0)
            {
                    do
            {
                this.InsertScanbeam(Y:  0);
                if(this.m_MinimaList.LeftBound != 0)
            {
                    this.m_MinimaList.LeftBound.OutIdx = 0;
            }
            
                if(this.m_MinimaList.RightBound != 0)
            {
                    this.m_MinimaList.RightBound.OutIdx = 0;
            }
            
            }
            while(this.m_MinimaList.Next != 0);
            
            }
            
                this.m_ActiveEdges = 0;
            }
            
            var val_1 = FP - 16;
        }
        public static ClipperLibFerr.IntRect GetBounds(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> paths)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            float val_13;
            var val_14;
            var val_15;
            float val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            val_4 = R1;
            val_5 = 22974457;
            val_6 = mem[R1 + 12];
            val_6 = R1 + 12;
            val_7 = 0;
            if(val_6 < 1)
            {
                goto label_8;
            }
            
            val_8 = val_6;
            goto label_3;
            label_7:
            if(1 >= val_6)
            {
                goto label_4;
            }
            
            val_8 = mem[R1 + 12];
            val_8 = R1 + 12;
            val_7 = 1;
            label_3:
            if(val_8 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = R1 + 8;
            val_4 = val_4 + 4;
            val_5 = mem[(R1 + 8 + 4) + 16];
            val_5 = (R1 + 8 + 4) + 16;
            if(((R1 + 8 + 4) + 16 + 12) == 0)
            {
                goto label_7;
            }
            
            goto label_8;
            label_4:
            val_7 = 1;
            label_8:
            if(val_7 == val_6)
            {
                    paths = new ClipperLibFerr.IntRect(l:  1, t:  0, r:  0, b:  0);
                return new ClipperLibFerr.IntRect() {left = paths};
            }
            
            if((R1 + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_5 = R1 + 8;
            val_5 = val_5 + 4;
            val_9 = mem[(R1 + 8 + 4) + 16];
            val_9 = (R1 + 8 + 4) + 16;
            if(((R1 + 8 + 4) + 16 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = mem[(R1 + 8 + 4) + 16 + 8 + 16];
            val_10 = (R1 + 8 + 4) + 16 + 8 + 16;
            if((R1 + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_6 = R1 + 8;
            val_6 = val_6 + 4;
            if(((R1 + 8 + 4) + 16 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_7 >= val_6)
            {
                goto label_16;
            }
            
            val_11 = (R1 + 8 + 4) + 16 + 8 + 24;
            label_48:
            val_12 = 0;
            goto label_17;
            label_47:
            if((R1 + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_7 = R1 + 8;
            val_7 = val_7 + 4;
            if(((R1 + 8 + 4) + 16 + 12) <= val_12)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((R1 + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = R1 + 8;
            val_8 = val_8 + 4;
            var val_2 = ((R1 + 8 + 4) + 16 + 8 + 16) - val_10;
            if(((R1 + 8 + 4) + 16) >= 0)
            {
                goto label_23;
            }
            
            val_13 = val_12;
            if(((R1 + 8 + 4) + 16 + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = 16;
            val_10 = mem[(R1 + 8 + 4) + 16 + 8 + val_14];
            val_10 = (R1 + 8 + 4) + 16 + 8 + val_14;
            goto label_27;
            label_23:
            val_13 = val_12;
            if(((R1 + 8 + 4) + 16 + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = 16;
            var val_9 = (R1 + 8 + 4) + 16 + 8 + val_14;
            val_9 = val_10 - val_9;
            if(((R1 + 8 + 4) + 16 + 12) >= val_13)
            {
                goto label_27;
            }
            
            val_4 = val_4;
            if((R1 + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_10 = R1 + 8;
            val_15 = (R1 + 8 + 4) + 16 + 8 + 28;
            val_10 = val_10 + 4;
            if(((R1 + 8 + 4) + 16 + 12) > val_13)
            {
                goto label_31;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            goto label_31;
            label_27:
            val_4 = val_4;
            val_15 = (R1 + 8 + 4) + 16 + 8 + 28;
            label_31:
            if((R1 + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_11 = R1 + 8;
            val_11 = val_11 + 4;
            if(((R1 + 8 + 4) + 16 + 12) <= val_13)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_12 = (R1 + 8 + 4) + 16 + 8;
            val_12 = val_12 + val_14;
            val_16 = val_7;
            if((R1 + 12) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = R1 + 8;
            val_13 = val_13 + 4;
            val_17 = val_11;
            var val_3 = (((R1 + 8 + 4) + 16 + 8 + val_14) + 8) - val_17;
            if(((R1 + 8 + 4) + 16) < 0)
            {
                    val_18 = val_12;
                if(((R1 + 8 + 4) + 16 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_14 = (R1 + 8 + 4) + 16 + 8;
                val_19 = 16;
                val_14 = val_14 + val_19;
                val_11 = mem[((R1 + 8 + 4) + 16 + 8 + val_19) + 8];
                val_11 = ((R1 + 8 + 4) + 16 + 8 + val_19) + 8;
            }
            else
            {
                    val_18 = val_12;
                val_11 = val_17;
                if(((R1 + 8 + 4) + 16 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_15 = (R1 + 8 + 4) + 16 + 8;
                val_19 = 16;
                val_17 = (R1 + 8 + 4) + 16 + 8 + 24;
                val_15 = val_15 + val_19;
                var val_16 = ((R1 + 8 + 4) + 16 + 8 + val_19) + 8;
                val_16 = val_17 - val_16;
                if(((R1 + 8 + 4) + 16 + 12) < val_18)
            {
                    if((R1 + 12) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_17 = R1 + 8;
                val_17 = val_17 + 4;
                if(((R1 + 8 + 4) + 16 + 12) <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_18 = (R1 + 8 + 4) + 16 + 8;
                val_18 = val_18 + val_19;
            }
            
            }
            
            val_19 = val_19 + 16;
            val_12 = val_18 + 1;
            label_17:
            if((R1 + 12) <= val_16)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = R1 + 8;
            val_19 = val_19 + 4;
            val_9 = mem[(R1 + 8 + 4) + 16];
            val_9 = (R1 + 8 + 4) + 16;
            if(val_12 < ((R1 + 8 + 4) + 16 + 12))
            {
                goto label_47;
            }
            
            val_6 = val_6;
            val_20 = val_16 + 1;
            if(val_20 != val_6)
            {
                goto label_48;
            }
            
            goto label_49;
            label_16:
            val_11 = (R1 + 8 + 4) + 16 + 8 + 24;
            label_49:
            mem2[0] = val_10;
            mem2[0] = val_15;
            mem2[0] = val_10;
            mem2[0] = (R1 + 8 + 4) + 16 + 8 + val_14 + 4;
            mem2[0] = (R1 + 8 + 4) + 16 + 8 + 24;
            mem2[0] = (R1 + 8 + 4) + 16 + 8 + 28;
            return new ClipperLibFerr.IntRect() {left = paths};
        }
        internal void InsertScanbeam(long Y)
        {
            ClipperLibFerr.Scanbeam val_5;
            var val_6;
            val_5 = this;
            if(this.m_Scanbeam == 0)
            {
                goto label_1;
            }
            
            long val_1 = this.m_Scanbeam.Y - R2;
            if(this.m_Scanbeam < 0)
            {
                goto label_2;
            }
            
            label_4:
            if(this.m_Scanbeam.Next == 0)
            {
                goto label_3;
            }
            
            long val_5 = this.m_Scanbeam.Next.Y;
            val_5 = val_5 - R2;
            if(this.m_Scanbeam.Next >= 0)
            {
                goto label_4;
            }
            
            label_3:
            long val_6 = this.m_Scanbeam.Y;
            val_6 = val_6 ^ R2;
            var val_2 = R3 ^ R3;
            if(this.m_Scanbeam.Next == 0)
            {
                    return;
            }
            
            val_5 = this.m_Scanbeam.Next;
            label_2:
            ClipperLibFerr.Scanbeam val_3 = 536893307;
            val_3 = new ClipperLibFerr.Scanbeam();
            if(val_3 == 0)
            {
                goto label_6;
            }
            
            mem[536893315] = R2;
            val_6 = mem[this.m_Scanbeam.Next];
            goto label_7;
            label_1:
            ClipperLibFerr.Scanbeam val_4 = 536893307;
            val_4 = new ClipperLibFerr.Scanbeam();
            this.m_Scanbeam = val_4;
            mem[536893323] = 0;
            mem[536893315] = R2;
            return;
            label_6:
            mem[12] = R3;
            mem[8] = R2;
            val_6 = mem[this.m_Scanbeam.Next];
            label_7:
            mem[536893323] = val_6;
            mem2[0] = val_3;
        }
        internal bool PopScanbeam(out long Y)
        {
            if(this.m_Scanbeam != 0)
            {
                    this.m_Scanbeam = this.m_Scanbeam.Next;
                return true;
            }
            
            Y = 0;
            mem[1152921510272282276] = 0;
            return false;
        }
        internal bool LocalMinimaPending()
        {
            if(this.m_CurrentLM != 0)
            {
                    this.m_CurrentLM = 1;
            }
            
            return true;
        }
        internal ClipperLibFerr.OutRec CreateOutRec()
        {
            var val_2;
            ClipperLibFerr.OutRec val_1 = 536891417;
            val_1 = new ClipperLibFerr.OutRec();
            if(val_1 != 0)
            {
                    val_2 = val_1;
                mem[536891429] = 0;
                mem[536891425] = 0;
                mem[536891433] = 0;
                mem[536891437] = 0;
                mem[536891441] = 0;
            }
            else
            {
                    val_2 = 8;
                mem[8] = 0;
                mem[12] = 0;
                mem[536891430] = 0;
                mem[16] = 0;
                mem[20] = 0;
                mem[24] = 0;
            }
            
            mem[536891445] = 0;
            System.Collections.Generic.List<ClipperLibFerr.OutRec> val_2 = this.m_PolyOuts;
            val_2.Add(item:  536891417);
            val_2 = val_2 - 1;
            mem[8] = val_2;
        }
        internal void DisposeOutRec(int index)
        {
            if(true <= index)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 2);
            mem2[0] = 0;
            this.m_PolyOuts.set_Item(index:  index, value:  0);
        }
        internal void UpdateEdgeIntoAEL(ref ClipperLibFerr.TEdge e)
        {
            ClipperLibFerr.TEdge val_2;
            ClipperLibFerr.TEdge val_3;
            int val_4;
            ClipperLibFerr.TEdge val_5;
            ClipperLibFerr.TEdge val_6;
            ClipperLibFerr.TEdge val_7;
            ClipperLibFerr.TEdge val_8;
            ClipperLibFerr.IntPoint val_9;
            var val_10;
            var val_11;
            var val_12;
            if(e.NextInLML == 0)
            {
                goto label_1;
            }
            
            val_2 = e;
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            val_3 = mem[e + 120];
            val_3 = e.PrevInAEL;
            goto label_3;
            label_2:
            val_3 = mem[e + 120];
            val_3 = e.PrevInAEL;
            val_2 = e;
            if(val_2 == 0)
            {
                goto label_4;
            }
            
            label_3:
            label_31:
            label_32:
            val_4 = mem[e + 100];
            val_4 = e.OutIdx;
            OutIdx = val_4;
            if(val_3 != 0)
            {
                    NextInAEL = e.NextInLML;
            }
            else
            {
                    this.m_ActiveEdges = e.NextInLML;
            }
            
            if(e.NextInAEL != 0)
            {
                    PrevInAEL = e.NextInLML;
            }
            
            val_5 = e;
            if(e != 0)
            {
                goto label_11;
            }
            
            val_5 = e;
            if(val_5 == 0)
            {
                goto label_21;
            }
            
            label_11:
            val_4 = mem[e + 84];
            val_4 = e.Side;
            Side = val_4;
            val_6 = e;
            if(e != 0)
            {
                goto label_14;
            }
            
            val_6 = e;
            if(val_6 == 0)
            {
                goto label_21;
            }
            
            label_14:
            val_4 = mem[e + 88];
            val_4 = e.WindDelta;
            WindDelta = val_4;
            val_7 = e;
            if(e != 0)
            {
                goto label_17;
            }
            
            val_7 = e;
            if(val_7 == 0)
            {
                goto label_21;
            }
            
            label_17:
            val_4 = mem[e + 92];
            val_4 = e.WindCnt;
            WindCnt = val_4;
            val_8 = e;
            if(e != 0)
            {
                goto label_20;
            }
            
            val_8 = e;
            if(val_8 == 0)
            {
                goto label_21;
            }
            
            label_20:
            WindCnt2 = e.WindCnt2;
            e = e.NextInLML;
            if(e != 0)
            {
                    val_9 = mem[e.NextInLML + 8];
                val_9 = e.NextInLML.Bot;
                val_10 = mem[e.NextInLML + 12];
                val_11 = mem[e.NextInLML + 16];
                val_12 = mem[e.NextInLML + 20];
            }
            else
            {
                    val_12 = 1;
                val_10 = 0;
                val_11 = 2621443;
                val_9 = 0f;
            }
            
            Curr = val_9;
            mem2[0] = val_10;
            mem2[0] = val_11;
            mem2[0] = val_12;
            PrevInAEL = val_3;
            NextInAEL = e.NextInAEL;
            if(e == 0)
            {
                    return;
            }
            
            this.InsertScanbeam(Y:  e.NextInAEL);
            return;
            label_4:
            if(e != 0)
            {
                goto label_31;
            }
            
            if(e != 0)
            {
                goto label_32;
            }
            
            label_21:
            label_1:
            22709868 = new ClipperLibFerr.ClipperException(description:  22796516);
        }
        internal void SwapPositionsInAEL(ClipperLibFerr.TEdge edge1, ClipperLibFerr.TEdge edge2)
        {
            ClipperLibFerr.ClipperBase val_1;
            var val_2;
            ClipperLibFerr.TEdge val_3;
            ClipperLibFerr.TEdge val_4;
            var val_5;
            var val_6;
            var val_7;
            float val_8;
            ClipperLibFerr.TEdge val_9;
            val_1 = this;
            if(edge1 != 0)
            {
                    val_2 = edge1;
                val_3 = edge1.NextInAEL;
            }
            else
            {
                    val_2 = 116;
                val_3 = 1;
                val_4 = edge2;
            }
            
            if(val_3 == edge1.PrevInAEL)
            {
                    return;
            }
            
            if(val_4 != 0)
            {
                    val_5 = val_4;
                val_6 = mem[edge2 + 116];
                val_6 = edge2 + 116;
            }
            else
            {
                    val_5 = 116;
                val_6 = 1;
                val_4 = edge2;
            }
            
            val_7 = mem[edge2 + 120];
            val_7 = edge2 + 120;
            if(val_6 == val_7)
            {
                    return;
            }
            
            if(val_2 == val_4)
            {
                goto label_6;
            }
            
            if(val_5 == edge1)
            {
                goto label_7;
            }
            
            mem[116] = val_5;
            if(mem[116] != 0)
            {
                    mem[121] = edge1;
            }
            
            val_8 = edge2 + 120;
            mem2[0] = val_8;
            val_1 = val_1;
            if((edge1 + 120) != 0)
            {
                    mem2[0] = edge1;
            }
            
            mem[116] = val_2;
            if(mem[116] != 0)
            {
                    mem[121] = edge2;
            }
            
            mem2[0] = edge1 + 120;
            if(val_8 == 0)
            {
                goto label_15;
            }
            
            mem2[0] = edge2;
            goto label_12;
            label_6:
            val_8 = edge2 + 120;
            if(val_5 != 0)
            {
                    mem[121] = edge1;
                val_4 = edge2;
            }
            
            if((edge1 + 120) != 0)
            {
                    mem2[0] = val_4;
                val_4 = edge2;
            }
            
            mem2[0] = edge1 + 120;
            mem[116] = edge1;
            edge1.PrevInAEL = val_4;
            mem[116] = val_5;
            val_1 = val_1;
            goto label_15;
            label_7:
            if(val_2 != 0)
            {
                    mem[121] = val_4;
                val_9 = mem[edge2 + 120];
                val_9 = edge2 + 120;
            }
            
            val_1 = val_1;
            if(val_9 != 0)
            {
                    mem2[0] = edge1;
            }
            
            edge1.PrevInAEL = val_9;
            mem[116] = edge2;
            val_8 = edge2 + 120;
            mem2[0] = edge1;
            mem[116] = val_2;
            label_12:
            label_15:
            if((edge1 + 120) == 0)
            {
                goto label_18;
            }
            
            if(val_8 == 0)
            {
                goto label_19;
            }
            
            return;
            label_18:
            mem[1152921510272887884] = edge1;
            goto label_20;
            label_19:
            mem[1152921510272887884] = edge2;
            label_20:
        }
        internal void DeleteFromAEL(ClipperLibFerr.TEdge e)
        {
            var val_1;
            ClipperLibFerr.TEdge val_2;
            if(e != 0)
            {
                    val_1 = e;
                val_2 = e.PrevInAEL;
            }
            else
            {
                    val_1 = 120;
                val_2 = 22016016;
            }
            
            if((e == 0) && (this.m_ActiveEdges != e))
            {
                    return;
            }
            
            if(val_2 != 0)
            {
                    mem[22016132] = e.NextInAEL;
            }
            else
            {
                    this.m_ActiveEdges = e.NextInAEL;
                val_2 = 0;
            }
            
            if(e.NextInAEL != 0)
            {
                    e.NextInAEL.PrevInAEL = val_2;
            }
            
            mem2[0] = 0;
            mem[120] = 0;
        }
    
    }

}
