using UnityEngine;

namespace ClipperLibFerr
{
    public class ClipperOffset
    {
        // Fields
        private System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> m_destPolys;
        private System.Collections.Generic.List<ClipperLibFerr.IntPoint> m_srcPoly;
        private System.Collections.Generic.List<ClipperLibFerr.IntPoint> m_destPoly;
        private System.Collections.Generic.List<ClipperLibFerr.DoublePoint> m_normals;
        private double m_delta;
        private double m_sinA;
        private double m_sin;
        private double m_cos;
        private double m_miterLim;
        private double m_StepsPerRad;
        private ClipperLibFerr.IntPoint m_lowest;
        private ClipperLibFerr.PolyNode m_polyNodes;
        private double <ArcTolerance>k__BackingField;
        private double <MiterLimit>k__BackingField;
        private const double two_pi = 6.28318530717959;
        private const double def_arc_tolerance = 0.25;
        
        // Properties
        public double ArcTolerance { get; set; }
        public double MiterLimit { get; set; }
        
        // Methods
        public double get_ArcTolerance()
        {
            return (double)D0;
        }
        public void set_ArcTolerance(double value)
        {
            this.<ArcTolerance>k__BackingField = ;
            mem[1152921510287934644] = R3;
        }
        public double get_MiterLimit()
        {
            return (double)D0;
        }
        public void set_MiterLimit(double value)
        {
            this.<MiterLimit>k__BackingField = ;
            mem[1152921510288158652] = R3;
        }
        public ClipperOffset(double miterLimit = 2, double arcTolerance = 0.25)
        {
            double val_1;
            536877849 = new System.Collections.Generic.List<ClipperLibFerr.DoublePoint>();
            this.m_normals = 536877849;
            ClipperLibFerr.PolyNode val_3 = 536891939;
            val_3 = new ClipperLibFerr.PolyNode();
            this.m_polyNodes = val_3;
            this.m_lowest = 0;
            mem[1152921510288270620] = 0;
            this.<ArcTolerance>k__BackingField = val_1;
            this.<MiterLimit>k__BackingField = R2;
        }
        public void Clear()
        {
            this.m_polyNodes.m_Childs.Clear();
            this.m_lowest = 0;
            mem[1152921510288390812] = 0;
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
        public void AddPath(System.Collections.Generic.List<ClipperLibFerr.IntPoint> path, ClipperLibFerr.JoinType joinType, ClipperLibFerr.EndType endType)
        {
            ClipperLibFerr.ClipperOffset val_14;
            ClipperLibFerr.EndType val_15;
            ClipperLibFerr.JoinType val_16;
            ClipperLibFerr.EndType val_17;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_18;
            var val_19;
            var val_20;
            var val_21;
            long val_22;
            var val_23;
            var val_25;
            val_14 = this;
            val_15 = endType;
            val_16 = joinType;
            val_18 = path - 1;
            if(val_18 < 0)
            {
                    return;
            }
            
            ClipperLibFerr.PolyNode val_1 = 536891939;
            val_1 = new ClipperLibFerr.PolyNode();
            if(val_1 != 0)
            {
                    mem[536891959] = val_16;
            }
            else
            {
                    mem[20] = val_16;
            }
            
            mem[536891963] = val_15;
            if((val_15 > 1) || (val_18 < 1))
            {
                goto label_9;
            }
            
            var val_2 = 8 | (path << 4);
            val_19 = 0;
            label_10:
            val_20 = mem[path + 12];
            val_20 = path + 12;
            if(val_20 == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_20 = mem[path + 12];
                val_20 = path + 12;
            }
            
            val_21 = mem[path + 8];
            val_21 = path + 8;
            var val_3 = val_21 + 16;
            if(val_20 <= val_18)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_21 = mem[path + 8];
                val_21 = path + 8;
            }
            
            if((ClipperLibFerr.IntPoint.op_Equality(a:  new ClipperLibFerr.IntPoint() {X = mem[(path + 8 + 16) + (0)], Y = mem[(path + 8 + 16) + (8)]}, b:  new ClipperLibFerr.IntPoint() {X = path + 8 + (8 | (path) << 4) + -8, Y = path + 8 + (8 | (path) << 4)})) == false)
            {
                goto label_9;
            }
            
            val_18 = val_18 - 1;
            val_2 = val_2 - 16;
            if(val_18 >= 1)
            {
                goto label_10;
            }
            
            label_9:
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_5 = val_18 + 1;
            mem[536891951].Capacity = val_5;
            if((path + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = mem[path + 8 + 24];
            val_15 = path + 8 + 24;
            mem[536891951].Add(item:  new ClipperLibFerr.IntPoint() {X = val_5, Y = path + 8 + 20});
            if(val_18 < 1)
            {
                goto label_15;
            }
            
            val_15 = path;
            var val_23 = 40;
            goto label_37;
            label_35:
            if((path + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_14 = val_1;
            if((mem[536891951] + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_13 = mem[536891951] + 8;
            val_13 = val_13 + 0;
            var val_15 = (mem[536891951] + 8 + 0) + 24;
            val_14 = (path + 8 + 40 + 4) ^ val_14;
            val_15 = (path + 8 + 40) ^ val_15;
            if((mem[536891951] + 12) != 0)
            {
                goto label_25;
            }
            
            if((path + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_16 = path + 8;
            val_16 = val_16 + val_23;
            if((mem[536891951] + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_17 = mem[536891951] + 8;
            val_17 = val_17 + 0;
            var val_18 = (mem[536891951] + 8 + 0) + 16;
            val_18 = ((path + 8 + 40) + -8) - val_18;
            if((mem[536891951] + 12) < 0)
            {
                goto label_24;
            }
            
            goto label_25;
            label_37:
            if((mem[536891951] + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_19 = mem[536891951] + 8;
            val_19 = val_19 + 0;
            var val_6 = val_19 + 16;
            if((path + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((ClipperLibFerr.IntPoint.op_Inequality(a:  new ClipperLibFerr.IntPoint() {X = mem[((mem[536891951] + 8 + 0) + 16) + (0)], Y = mem[((mem[536891951] + 8 + 0) + 16) + (8)]}, b:  new ClipperLibFerr.IntPoint() {X = path + 8 + 40 + -8, Y = path + 8 + 40})) == false)
            {
                goto label_29;
            }
            
            if((path + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = path + 8 + 40 + -4;
            if(mem[536891951] == 0)
            {
                    val_22 = val_22;
            }
            
            mem[536891951].Add(item:  new ClipperLibFerr.IntPoint() {X = mem[((mem[536891951] + 8 + 0) + 16) + (4)], Y = val_22});
            if((path + 12) <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((mem[536891951] + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            var val_21 = mem[536891951] + 8;
            val_21 = val_21 + 0;
            var val_22 = (mem[536891951] + 8 + 0) + 24;
            val_22 = val_22 - (path + 8 + 40);
            if((mem[536891951] + 12) >= 0)
            {
                goto label_35;
            }
            
            label_24:
            val_23 = val_20;
            val_16 = val_23;
            goto label_36;
            label_29:
            val_16 = 0f;
            label_25:
            val_23 = val_20;
            label_36:
            val_19 = 1 + 1;
            val_23 = val_23 + 16;
            if(val_19 <= val_18)
            {
                goto label_37;
            }
            
            goto label_38;
            label_15:
            val_16 = 0;
            val_23 = 0;
            label_38:
            val_17 = val_15;
            val_14 = val_16;
            if(val_17 == 0)
            {
                    if(val_23 < 2)
            {
                    return;
            }
            
            }
            
            mem[1152921510288643496].AddChild(Child:  536891939);
            if(val_17 != 0)
            {
                    return;
            }
            
            val_16 = 1.08692E-19f;
            if(val_17 <= 1)
            {
                goto label_44;
            }
            
            if(mem[1152921510288643480] <= this.m_lowest)
            {
                    var val_24 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_24 = val_24 + (this.m_lowest << 2);
            if(((0 + (this.m_lowest) << 2) + 16 + 12 + 12) <= mem[1152921510288643488])
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_25 = (0 + (this.m_lowest) << 2) + 16 + 12 + 8;
            val_25 = val_25 + (mem[1152921510288643488] << 4);
            val_19 = mem[((0 + (this.m_lowest) << 2) + 16 + 12 + 8 + (mem[1152921510288643488]) << 4) + 24];
            val_19 = ((0 + (this.m_lowest) << 2) + 16 + 12 + 8 + (mem[1152921510288643488]) << 4) + 24;
            var val_29 = ((0 + (this.m_lowest) << 2) + 16 + 12 + 8 + (mem[1152921510288643488]) << 4) + 20;
            val_16 = val_14;
            if((mem[536891951] + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_26 = mem[536891951] + 8;
            val_26 = val_26 + 0;
            var val_27 = (mem[536891951] + 8 + 0) + 24;
            val_27 = val_19 - val_27;
            if((mem[536891951] + 12) >= val_14)
            {
                goto label_52;
            }
            
            label_60:
            val_17 = 0;
            int val_8 = this.m_polyNodes.ChildCount;
            val_25 = 0;
            goto label_54;
            label_44:
            val_17 = val_14;
            val_25 = 0;
            label_54:
            ClipperLibFerr.IntPoint val_12 = new ClipperLibFerr.IntPoint(X:  0, Y:  (this.m_polyNodes.ChildCount - 1) >> 31);
            return;
            label_52:
            if((mem[536891951] + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_28 = mem[536891951] + 8;
            val_28 = val_28 + 0;
            var val_30 = (mem[536891951] + 8 + 0) + 24;
            val_29 = val_29 ^ (((0 + (this.m_lowest) << 2) + 16 + 12 + 8 + (mem[1152921510288643488]) << 4) + 28);
            val_30 = val_30 ^ val_19;
            if((mem[536891951] + 12) != val_14)
            {
                    return;
            }
            
            if((mem[536891951] + 12) <= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_31 = mem[536891951] + 8;
            val_31 = val_31 + 0;
            var val_32 = (mem[536891951] + 8 + 0) + 16;
            val_32 = val_32 - (((0 + (this.m_lowest) << 2) + 16 + 12 + 8 + (mem[1152921510288643488]) << 4) + 16);
            if((mem[536891951] + 12) < val_14)
            {
                goto label_60;
            }
        
        }
        public void AddPaths(System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> paths, ClipperLibFerr.JoinType joinType, ClipperLibFerr.EndType endType)
        {
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_3:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            this.AddPath(path:  val_3, joinType:  joinType, endType:  endType);
            goto label_3;
            label_2:
            Dispose();
        }
        private void FixOrientations()
        {
            ClipperLibFerr.IntPoint val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = this.m_lowest;
            if(true < 0)
            {
                goto label_1;
            }
            
            if(this.m_polyNodes == 0)
            {
                    val_6 = val_6;
            }
            
            if(true <= val_6)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_6 << 2);
            val_7 = 0;
            bool val_1 = ClipperLibFerr.Clipper.Orientation(poly:  (0 + (this.m_lowest) << 2) + 16 + 12);
            if(val_1 == false)
            {
                goto label_6;
            }
            
            label_1:
            val_7 = 0;
            val_8 = 22737188;
            goto label_7;
            label_16:
            if(val_1 <= val_7)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            if(((0 + 0) + 16 + 24) == 1)
            {
                    if((ClipperLibFerr.Clipper.Orientation(poly:  (0 + 0) + 16 + 12)) != true)
            {
                    (0 + 0) + 16 + 12.Reverse();
            }
            
            }
            
            val_7 = 1;
            label_7:
            if(val_7 < this.m_polyNodes.ChildCount)
            {
                goto label_16;
            }
            
            return;
            label_6:
            val_8 = 22737188;
            goto label_18;
            label_29:
            if(val_1 <= val_7)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + 0;
            val_9 = mem[(0 + 0) + 16];
            val_9 = (0 + 0) + 16;
            if(((0 + 0) + 16 + 24) == 1)
            {
                goto label_23;
            }
            
            if(((0 + 0) + 16 + 24) != 0)
            {
                goto label_26;
            }
            
            val_9 = val_9 + 12;
            goto label_25;
            label_23:
            if((ClipperLibFerr.Clipper.Orientation(poly:  (0 + 0) + 16 + 12)) == false)
            {
                goto label_26;
            }
            
            label_25:
            (0 + 0) + 16 + 12.Reverse();
            label_26:
            val_7 = 1;
            label_18:
            if(val_7 < this.m_polyNodes.ChildCount)
            {
                goto label_29;
            }
        
        }
        internal static ClipperLibFerr.DoublePoint GetUnitNormal(ClipperLibFerr.IntPoint pt1, ClipperLibFerr.IntPoint pt2)
        {
            var val_2;
            bool val_8;
            float val_9;
            long val_3 = val_2 - pt2.X;
            pt1.Y = (pt2.Y - pt1.Y) | val_3;
            long val_5 = pt2.Y | pt1.Y;
            val_8 = mem[536890482];
            if((val_8 & true) == 0)
            {
                    val_8 = mem[536890411];
            }
            
            long val_6 = val_3 * val_3;
            if(val_8 >= _TYPE_MAX_)
            {
                    val_9 = val_8;
            }
            
            double val_8 = 1;
            val_9 = val_8 / val_9;
            val_8 = val_9 * val_3;
            pt1.X = new ClipperLibFerr.DoublePoint(x:  null, y:  null);
            return new ClipperLibFerr.DoublePoint();
        }
        private void DoOffset(double delta)
        {
            var val_29;
            536877661 = new System.Collections.Generic.List<Page>();
            this.m_destPolys = 536877661;
            mem[1152921510289255272] = R2;
            val_29 = 0;
            this.m_destPolys.Capacity = this.m_polyNodes.ChildCount;
            goto label_5;
            label_13:
            if(this.m_destPolys <= val_29)
            {
                    var val_27 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_27 = val_27 + 0;
            if(((0 + 0) + 16 + 24) == 0)
            {
                    this.m_destPolys.Add(item:  (0 + 0) + 16 + 12);
            }
            
            val_29 = 1;
            label_5:
            if(val_29 < this.m_polyNodes.ChildCount)
            {
                goto label_13;
            }
            
            goto label_14;
        }
        public void Execute(ref System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> solution, double delta)
        {
            var val_5;
            long val_6;
            long val_7;
            var val_8;
            var val_9;
            var val_12;
            var val_24;
            System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> val_25;
            System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> val_26;
            System.Collections.Generic.List<System.Collections.Generic.List<ClipperLibFerr.IntPoint>> val_27;
            val_24 = 1152921510289464704;
            val_25 = solution;
            val_25.Clear();
            this.FixOrientations();
            this.DoOffset(delta:  delta);
            ClipperLibFerr.Clipper val_1 = 536884863;
            val_1 = new ClipperLibFerr.Clipper(InitOptions:  0);
            val_26 = this.m_destPolys;
            bool val_2 = val_1.AddPaths(ppg:  val_26, polyType:  0, closed:  true);
            if(val_1 > 0)
            {
                    bool val_3 = val_1.Execute(clipType:  1, solution:  solution, subjFillType:  2, clipFillType:  2);
                return;
            }
            
            ClipperLibFerr.IntRect val_4 = ClipperLibFerr.ClipperBase.GetBounds(paths:  1387606344);
            var val_24 = val_12;
            val_26 = 536878005;
            val_26 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>(capacity:  4);
            val_24 = val_24 + 10;
            var val_14 = val_9 - 10;
             = new ClipperLibFerr.IntPoint(X:  0, Y:  1);
            val_26.Add(item:  new ClipperLibFerr.IntPoint() {X = val_15.Y, Y = val_15.X});
            var val_16 = val_8 + 10;
            ClipperLibFerr.IntPoint val_17 = new ClipperLibFerr.IntPoint(X:  val_7, Y:  1152921510289420616);
            val_26.Add(item:  new ClipperLibFerr.IntPoint() {X = val_17.Y, Y = val_17.X});
            var val_18 = val_5 - 10;
            ClipperLibFerr.IntPoint val_19 = new ClipperLibFerr.IntPoint(X:  val_6, Y:  1152921510289420616);
            val_24 = 22737180;
            val_26.Add(item:  new ClipperLibFerr.IntPoint() {X = val_19.Y, Y = val_19.X});
            ClipperLibFerr.IntPoint val_20 = new ClipperLibFerr.IntPoint(X:  0, Y:  1);
            val_25 = -1073714129;
            val_26.Add(item:  new ClipperLibFerr.IntPoint() {X = val_20.Y, Y = val_20.X});
            if(val_1 != 0)
            {
                    bool val_21 = val_1.AddPath(pg:  536878005, polyType:  0, Closed:  true);
                mem[536884940] = 1;
                val_27 = solution;
            }
            else
            {
                    bool val_22 = val_1.AddPath(pg:  536878005, polyType:  0, Closed:  true);
                mem[536884940] = 1;
                val_27 = solution;
            }
            
            bool val_23 = val_1.Execute(clipType:  1, solution:  val_27, subjFillType:  3, clipFillType:  3);
            if((mem[solution + 12]) < 1)
            {
                    return;
            }
            
            solution.RemoveAt(index:  0);
        }
        public void Execute(ref ClipperLibFerr.PolyTree solution, double delta)
        {
            var val_5;
            long val_7;
            var val_8;
            var val_9;
            var val_12;
            System.Collections.Generic.List<ClipperLibFerr.IntPoint> val_30;
            var val_31;
            var val_32;
            ClipperLibFerr.PolyTree val_33;
            val_30 = this;
            val_31 = R2;
            val_32 = 1152921510289601120;
            solution.Clear();
            this.FixOrientations();
            this.DoOffset(delta:  delta);
            ClipperLibFerr.Clipper val_1 = 536884863;
            val_1 = new ClipperLibFerr.Clipper(InitOptions:  0);
            bool val_2 = val_1.AddPaths(ppg:  this.m_destPolys, polyType:  0, closed:  true);
            if(val_1 > 0)
            {
                    bool val_3 = val_1.Execute(clipType:  1, polytree:  solution, subjFillType:  2, clipFillType:  2);
                return;
            }
            
            ClipperLibFerr.IntRect val_4 = ClipperLibFerr.ClipperBase.GetBounds(paths:  1387742760);
            val_30 = 536878005;
            val_30 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>(capacity:  4);
            long val_14 = val_12 + 10;
            var val_15 = val_9 - 10;
             = new ClipperLibFerr.IntPoint(X:  0, Y:  1);
            val_32 = 22737180;
            val_30.Add(item:  new ClipperLibFerr.IntPoint() {X = val_16.Y, Y = val_16.X});
            var val_17 = val_8 + 10;
            ClipperLibFerr.IntPoint val_18 = new ClipperLibFerr.IntPoint(X:  val_7, Y:  val_14);
            val_30.Add(item:  new ClipperLibFerr.IntPoint() {X = val_18.Y, Y = val_18.X});
            var val_19 = val_5 - 10;
            ClipperLibFerr.IntPoint val_20 = new ClipperLibFerr.IntPoint(X:  0, Y:  val_14);
            val_30.Add(item:  new ClipperLibFerr.IntPoint() {X = val_20.Y, Y = val_20.X});
            ClipperLibFerr.IntPoint val_21 = new ClipperLibFerr.IntPoint(X:  0, Y:  1);
            val_31 = -1073714129;
            val_30.Add(item:  new ClipperLibFerr.IntPoint() {X = val_21.Y, Y = val_21.X});
            if(val_1 != 0)
            {
                    bool val_22 = val_1.AddPath(pg:  536878005, polyType:  0, Closed:  true);
                mem[536884940] = 1;
                val_33 = solution;
            }
            else
            {
                    bool val_23 = val_1.AddPath(pg:  536878005, polyType:  0, Closed:  true);
                mem[536884940] = 1;
                val_33 = solution;
            }
            
            bool val_24 = val_1.Execute(clipType:  1, polytree:  val_33, subjFillType:  3, clipFillType:  3);
            if(solution.ChildCount == 1)
            {
                    if((mem[solution + 28] + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((mem[solution + 28] + 8 + 16.ChildCount) >= 1)
            {
                    if((mem[solution + 28] + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_32 = mem[mem[solution + 28] + 8 + 16];
                val_32 = mem[solution + 28] + 8 + 16;
                mem[solution + 28].Capacity = val_32.ChildCount;
                if((mem[solution + 28] + 8 + 16 + 28 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                mem[solution + 28].set_Item(index:  0, value:  mem[solution + 28] + 8 + 16 + 28 + 8 + 16);
                if((mem[solution + 28] + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_30 = mem[mem[solution + 28] + 8 + 16];
                val_30 = mem[solution + 28] + 8 + 16;
                mem2[0] = solution;
                if(val_32.ChildCount < 2)
            {
                    return;
            }
            
                do
            {
                if((mem[solution + 28] + 8 + 16 + 28 + 12) <= (5 - 4))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_30 = mem[mem[solution + 28] + 8 + 16 + 28 + 8 + 20];
                val_30 = mem[solution + 28] + 8 + 16 + 28 + 8 + 20;
                solution.AddChild(Child:  val_30);
                val_31 = 5 + 1;
            }
            while((5 - 3) < val_32.ChildCount);
            
                return;
            }
            
            }
            
            solution.Clear();
        }
        private void OffsetPoint(int j, ref int k, ClipperLibFerr.JoinType jointype)
        {
            var val_5;
            float val_6;
            long val_7;
            double val_8;
            double val_9;
            long val_10;
            var val_11;
            double val_12;
            int val_13;
            val_5 = jointype;
            val_6 = 1152921510289852240;
            val_7 = j;
            if(true <= k)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (k << 4);
            double val_8 = (0 + (k) << 4) + 16;
            if(val_5 <= val_7)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_7 << 4);
            if(val_6 <= val_7)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (val_7 << 4);
            val_8 = mem[(0 + (j) << 4) + 16];
            val_8 = (0 + (j) << 4) + 16;
            if(val_7 <= k)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 * ((0 + (j) << 4) + 24);
            val_9 = val_9 + (k << 4);
            this.m_sinA = val_8;
            val_9 = 1;
            double val_10 = System.Math.Abs(val_8 * this.m_delta);
            if(mem[536890411] >= 0)
            {
                goto label_11;
            }
            
            if(536890295 <= k)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (k << 4);
            if(val_11 <= val_7)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (val_7 << 4);
            if(val_12 <= val_7)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + (val_7 << 4);
            val_8 = mem[(0 + (j) << 4) + 24];
            val_8 = (0 + (j) << 4) + 24;
            if(val_13 <= k)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + (k << 4);
            var val_15 = (0 + (k) << 4) + 24;
            val_15 = val_8 * val_15;
            if(val_13 <= k)
            {
                goto label_20;
            }
            
            if(this.m_destPoly <= val_7)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + (val_7 << 4);
            if(val_16 <= k)
            {
                    var val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + (k << 4);
            var val_18 = (0 + (j) << 4) + 16;
            if(val_16 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_18 = val_18 + (-0.5);
            val_10 = (0 + (j) << 4) + 20;
            if(((0 + (j) << 4) + 20) <= val_7)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + (val_7 << 4);
            val_7 = mem[(0 + (j) << 4) + 28];
            val_7 = (0 + (j) << 4) + 28;
            if(val_19 <= k)
            {
                    var val_20 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = this.m_delta;
            val_20 = val_20 + (k << 4);
            var val_21 = (0 + (j) << 4) + 24;
            if(val_19 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_21 = val_21 + (-0.5);
            ClipperLibFerr.IntPoint val_2 = new ClipperLibFerr.IntPoint(X:  val_7, Y:  val_10);
            val_5 = -1073714129;
            this.m_destPoly.Add(item:  new ClipperLibFerr.IntPoint() {X = val_2.Y, Y = val_2.X});
            return;
            label_11:
            if(mem[536890411] <= 0)
            {
                goto label_31;
            }
            
            val_11 = 16368;
            val_11 = 1072693248;
            goto label_32;
            label_20:
            val_12 = this.m_sinA;
            goto label_34;
            label_31:
            val_9 = -1;
            if(mem[536890411] >= 0)
            {
                goto label_34;
            }
            
            val_11 = 49136;
            val_11 = 3220176896;
            label_32:
            val_12 = -1;
            this.m_sinA = -1;
            label_34:
            val_12 = val_12 * this.m_delta;
            if(mem[536890411] >= 0)
            {
                goto label_35;
            }
            
            if(this.m_destPoly <= val_7)
            {
                    var val_22 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = val_22 + (val_7 << 4);
            if(val_22 <= k)
            {
                    var val_23 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_23 = val_23 + (k << 4);
            var val_24 = (0 + (j) << 4) + 16;
            if(val_22 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_24 = val_24 + (-0.5);
            if(((0 + (j) << 4) + 20) <= val_7)
            {
                    var val_25 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_25 = val_25 + (val_7 << 4);
            if(val_25 <= k)
            {
                    var val_26 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_26 = val_26 + (k << 4);
            var val_27 = (0 + (j) << 4) + 24;
            if(val_25 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_27 = val_27 + (-0.5);
            ClipperLibFerr.IntPoint val_3 = new ClipperLibFerr.IntPoint(X:  (0 + (j) << 4) + 20, Y:  (0 + (j) << 4) + 20);
            this.m_destPoly.Add(item:  new ClipperLibFerr.IntPoint() {X = val_3.Y, Y = val_3.X});
            if(this.m_destPoly <= val_7)
            {
                    var val_28 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_28 = val_28 + (val_7 << 4);
            this.m_destPoly.Add(item:  new ClipperLibFerr.IntPoint() {X = val_3.Y, Y = (0 + (j) << 4) + 20});
            if(this.m_destPoly <= val_7)
            {
                    var val_29 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_29 = val_29 + (val_7 << 4);
            if(val_29 <= val_7)
            {
                    var val_30 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_30 = val_30 + (val_7 << 4);
            var val_31 = (0 + (j) << 4) + 16;
            if(val_29 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_31 = val_31 + (-0.5);
            if(this.m_destPoly <= val_7)
            {
                    var val_32 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = this.m_normals;
            val_32 = val_32 + (val_7 << 4);
            if(val_32 <= val_7)
            {
                    var val_33 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = this.m_delta;
            val_33 = val_33 + (val_7 << 4);
            var val_34 = (0 + (j) << 4) + 24;
            if(val_32 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_34 = val_34 + (-0.5);
            ClipperLibFerr.IntPoint val_4 = new ClipperLibFerr.IntPoint(X:  this.m_destPoly, Y:  this.m_destPoly);
            val_5 = -1073714129;
            this.m_destPoly.Add(item:  new ClipperLibFerr.IntPoint() {X = val_4.Y, Y = val_4.X});
            val_6 = val_6;
            goto label_71;
            label_35:
            if(val_5 == 0)
            {
                goto label_58;
            }
            
            if(val_5 == 1)
            {
                goto label_59;
            }
            
            if(val_5 != 2)
            {
                goto label_71;
            }
            
            if(0 <= val_7)
            {
                    var val_35 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_35 = val_35 + (val_7 << 4);
            if(val_35 <= k)
            {
                    var val_36 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_36 = val_36 + (k << 4);
            if(val_36 <= val_7)
            {
                    var val_37 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_37 = val_37 + (val_7 << 4);
            val_8 = mem[(0 + (j) << 4) + 24];
            val_8 = (0 + (j) << 4) + 24;
            if(val_37 <= k)
            {
                    var val_38 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = k;
            val_38 = val_38 + (k << 4);
            float val_39 = (0 + (k) << 4) + 24;
            val_39 = val_8 * val_39;
            val_39 = val_39 + 1;
            if(val_37 < k)
            {
                goto label_69;
            }
            
            this.DoMiter(j:  val_7, k:  val_13, r:  null);
            goto label_71;
            label_58:
            val_13 = k;
            label_69:
            this.DoSquare(j:  val_7, k:  val_13);
            goto label_71;
            label_59:
            this.DoRound(j:  val_7, k:  k);
            label_71:
            k = val_7;
        }
        internal void DoSquare(int j, int k)
        {
            var val_4;
            if(true <= k)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (k << 4);
            if(val_4 <= j)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (j << 4);
            if(val_5 <= k)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (k << 4);
            if(val_6 <= j)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = j + (j << 4);
            if((mem[536890482] & true) == 0)
            {
                    val_4 = mem[536890411];
            }
            
            double val_1 = ((0 + (k) << 4) + 24) * ((j + (j) << 4) + 24);
            double val_7 = 0.25;
            val_7 = val_4 * val_7;
            if(this.m_destPoly <= j)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (j << 4);
            if(val_8 <= k)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (k << 4);
            if(val_4 <= k)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (k << 4);
            var val_11 = (0 + (j) << 4) + 16;
            if(val_4 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_11 = val_11 + (-0.5);
            if(((0 + (j) << 4) + 20) <= j)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (j << 4);
            if(val_12 <= k)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + (k << 4);
            if(val_13 <= k)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + (k << 4);
            var val_15 = (0 + (j) << 4) + 24;
            if(val_13 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_15 = val_15 + (-0.5);
            ClipperLibFerr.IntPoint val_2 = new ClipperLibFerr.IntPoint(X:  (0 + (j) << 4) + 28, Y:  (0 + (j) << 4) + 20);
            this.m_destPoly.Add(item:  new ClipperLibFerr.IntPoint() {X = val_2.Y, Y = val_2.X});
            if(this.m_destPoly <= j)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + (j << 4);
            if(val_16 <= j)
            {
                    var val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + (j << 4);
            if(val_17 <= j)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + (j << 4);
            var val_19 = (0 + (j) << 4) + 16;
            if(val_17 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_19 = val_19 + (-0.5);
            if(((0 + (j) << 4) + 20) <= j)
            {
                    var val_20 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_20 = val_20 + (j << 4);
            if(val_20 <= j)
            {
                    var val_21 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_21 = val_21 + (j << 4);
            if(val_21 <= j)
            {
                    var val_22 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_22 = val_22 + (j << 4);
            var val_23 = (0 + (j) << 4) + 24;
            if(val_21 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_23 = val_23 + (-0.5);
            ClipperLibFerr.IntPoint val_3 = new ClipperLibFerr.IntPoint(X:  this.m_normals, Y:  (0 + (j) << 4) + 20);
            this.m_destPoly.Add(item:  new ClipperLibFerr.IntPoint() {X = val_3.Y, Y = val_3.X});
        }
        internal void DoMiter(int j, int k, double r)
        {
            var val_1;
            double val_8 = this.m_delta;
            if(this.m_destPoly <= j)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (j << 4);
            if(val_6 <= k)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (k << 4);
            val_8 = val_8 / val_1;
            if(val_7 <= j)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + (j << 4);
            double val_2 = ((0 + (k) << 4) + 16) + ((0 + (j) << 4) + 16);
            if(val_7 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            -0.5 = ((0 + (j) << 4) + 16) + (-0.5);
            if(((0 + (j) << 4) + 20) <= j)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (j << 4);
            if(val_10 <= k)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (k << 4);
            if(val_11 <= j)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (j << 4);
            double val_3 = ((0 + (k) << 4) + 24) + ((0 + (j) << 4) + 24);
            if(val_11 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            double val_4 = ((0 + (j) << 4) + 24) + (-0.5);
            ClipperLibFerr.IntPoint val_5 = new ClipperLibFerr.IntPoint(X:  (0 + (j) << 4) + 28, Y:  (0 + (j) << 4) + 20);
            this.m_destPoly.Add(item:  new ClipperLibFerr.IntPoint() {X = val_5.Y, Y = val_5.X});
        }
        internal void DoRound(int j, int k)
        {
            int val_6;
            var val_7;
            if(true <= k)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (k << 4);
            if(val_6 <= j)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (j << 4);
            if(val_7 <= k)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (k << 4);
            if(val_8 <= j)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = j + (j << 4);
            if((mem[536890482] & true) == 0)
            {
                    val_6 = mem[536890411];
            }
            
            double val_1 = ((0 + (k) << 4) + 24) * ((j + (j) << 4) + 24);
            double val_9 = this.m_StepsPerRad;
            val_9 = val_9 * val_6;
            if(val_6 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_9 = val_9 + (-0.5);
            int val_2 = System.Math.Max(val1:  val_6, val2:  1);
            if(val_2 <= k)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (k << 4);
            var val_14 = (0 + (k) << 4) + 16;
            if(val_10 <= k)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (k << 4);
            val_7 = 0;
            goto label_15;
            label_21:
            if(val_11 <= k)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (k << 4);
            if(val_11 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            -0.5 = ((0 + (k) << 4) + 16) + (-0.5);
            if(1388710784 <= k)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + (k << 4);
            if(1388710784 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            -0.5 = ((0 + (k) << 4) + 24) + (-0.5);
            ClipperLibFerr.IntPoint val_3 = new ClipperLibFerr.IntPoint(X:  1152921510290525056, Y:  1152921510290525056);
            SL.Add(item:  new ClipperLibFerr.IntPoint() {X = val_3.Y, Y = val_3.X});
            val_7 = 1;
            double val_4 = val_14 * this.m_sin;
            val_14 = val_14 * this.m_cos;
            label_15:
            if(val_7 < val_2)
            {
                goto label_21;
            }
            
            if(SL <= j)
            {
                    var val_15 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_15 = val_15 + (j << 4);
            if(val_15 <= j)
            {
                    var val_16 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_16 = val_16 + (j << 4);
            var val_17 = (0 + (j) << 4) + 16;
            if(val_15 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_17 = val_17 + (-0.5);
            if(1 <= j)
            {
                    var val_18 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_18 = val_18 + (j << 4);
            if(val_18 <= j)
            {
                    var val_19 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = val_19 + (j << 4);
            var val_20 = (0 + (j) << 4) + 24;
            if(val_18 >= 0)
            {
                    -0.5 = 0.5;
            }
            
            val_20 = val_20 + (-0.5);
            ClipperLibFerr.IntPoint val_5 = new ClipperLibFerr.IntPoint(X:  (0 + (j) << 4) + 28, Y:  1);
            this.m_destPoly.Add(item:  new ClipperLibFerr.IntPoint() {X = val_5.Y, Y = val_5.X});
        }
    
    }

}
