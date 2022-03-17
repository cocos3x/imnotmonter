using UnityEngine;

namespace FerrPoly2Tri
{
    public class ConstrainedPointSet : PointSet
    {
        // Fields
        protected System.Collections.Generic.Dictionary<uint, FerrPoly2Tri.TriangulationConstraint> mConstraintMap;
        protected System.Collections.Generic.List<FerrPoly2Tri.Contour> mHoles;
        
        // Properties
        public override FerrPoly2Tri.TriangulationMode TriangulationMode { get; }
        
        // Methods
        public override FerrPoly2Tri.TriangulationMode get_TriangulationMode()
        {
        
        }
        public ConstrainedPointSet(System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> bounds)
        {
            536874517 = new System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationPoint>();
            this.mConstraintMap = 536874517;
            536877823 = new System.Collections.Generic.List<Page>();
            this.mHoles = 536877823;
            this.AddBoundaryConstraints();
        }
        public ConstrainedPointSet(System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> bounds, System.Collections.Generic.List<FerrPoly2Tri.TriangulationConstraint> constraints)
        {
            536874517 = new System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationPoint>();
            this.mConstraintMap = 536874517;
            536877823 = new System.Collections.Generic.List<Page>();
            this.mHoles = 536877823;
            this.AddBoundaryConstraints();
            bool val_3 = this.AddConstraints(constraints:  constraints);
        }
        public ConstrainedPointSet(System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> bounds, int[] indices)
        {
            var val_6;
            536874517 = new System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationPoint>();
            this.mConstraintMap = 536874517;
            536877823 = new System.Collections.Generic.List<Page>();
            this.mHoles = 536877823;
            val_6 = 0;
            this.AddBoundaryConstraints();
            var val_7 = -1073712059;
            536878449 = new System.Collections.Generic.List<Page>();
            goto label_1;
            label_7:
            if(536878449 <= val_6)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = val_7 + 0;
            if(0 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            536895803 = new FerrPoly2Tri.TriangulationConstraint(p1:  (-1073712059 + 0) + 16, p2:  (-1073712059 + 0) + 20);
            536878449.Add(item:  536895803);
            val_6 = 1 + 1;
            label_1:
            if(val_6 < 536878449)
            {
                goto label_7;
            }
            
            bool val_6 = this.AddConstraints(constraints:  536878449);
        }
        protected void AddBoundaryConstraints()
        {
            var val_37;
            var val_38;
            double val_1 = this.MinX;
            if((this.TryGetPoint(x:  this.MinY, y:  null, p: out  FerrPoly2Tri.TriangulationPoint val_3 = 0)) != true)
            {
                    double val_5 = this.MinX;
                val_37 = 0;
                536895819 = new FerrPoly2Tri.TriangulationPoint(x:  this.MinY, y:  null, aId:  0);
            }
            
            double val_8 = this.MaxX;
            if((this.TryGetPoint(x:  this.MinY, y:  null, p: out  FerrPoly2Tri.TriangulationPoint val_10 = 0)) != true)
            {
                    double val_12 = this.MaxX;
                val_37 = 0;
                536895819 = new FerrPoly2Tri.TriangulationPoint(x:  this.MinY, y:  null, aId:  0);
            }
            
            val_38 = 0;
            double val_15 = this.MaxX;
            if((this.TryGetPoint(x:  this.MaxY, y:  null, p: out  FerrPoly2Tri.TriangulationPoint val_17 = 0)) != true)
            {
                    double val_19 = this.MaxX;
                val_37 = 0;
                536895819 = new FerrPoly2Tri.TriangulationPoint(x:  this.MaxY, y:  null, aId:  0);
            }
            
            double val_22 = this.MinX;
            if((this.TryGetPoint(x:  this.MaxY, y:  null, p: out  FerrPoly2Tri.TriangulationPoint val_24 = 0)) != true)
            {
                    val_38 = 0;
                double val_26 = this.MinX;
                val_37 = 0;
                536895819 = new FerrPoly2Tri.TriangulationPoint(x:  this.MaxY, y:  null, aId:  0);
            }
            
            536895803 = new FerrPoly2Tri.TriangulationConstraint(p1:  536895819, p2:  536895819);
            bool val_30 = this.AddConstraint(tc:  536895803);
            536895803 = new FerrPoly2Tri.TriangulationConstraint(p1:  536895819, p2:  536895819);
            bool val_32 = this.AddConstraint(tc:  536895803);
            536895803 = new FerrPoly2Tri.TriangulationConstraint(p1:  536895819, p2:  536895819);
            bool val_34 = this.AddConstraint(tc:  536895803);
            536895803 = new FerrPoly2Tri.TriangulationConstraint(p1:  536895819, p2:  536895819);
            bool val_36 = this.AddConstraint(tc:  536895803);
        }
        public override void Add(FerrPoly2Tri.Point2D p)
        {
            bool val_2;
            var val_3;
            val_2 = 22974506;
            val_3 = 0;
            if(p != 0)
            {
                    val_2 = mem[536895999];
                val_3 = 0;
                if(((FerrPoly2Tri.Point2D.__il2cppRuntimeField_typeHierarchy + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    p = 0;
            }
            
                val_3 = p;
            }
            
            bool val_1 = this.Add(p:  0, idx:  0, constrainToBounds:  true);
        }
        public override void Add(FerrPoly2Tri.TriangulationPoint p)
        {
            bool val_1 = this.Add(p:  p, idx:  0, constrainToBounds:  true);
        }
        public override bool AddRange(System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> points)
        {
            FerrPoly2Tri.TriangulationPoint val_2;
            var val_6;
            List.Enumerator<T> val_1 = GetEnumerator();
            val_6 = 1;
            goto label_2;
            label_3:
            val_6 = val_6 & (this.Add(p:  val_2, idx:  0, constrainToBounds:  true));
            label_2:
            if(MoveNext() == true)
            {
                goto label_3;
            }
            
            Dispose();
            return (bool)val_6;
        }
        public bool AddHole(System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> points, string name)
        {
            var val_30;
            var val_31;
            var val_32;
            System.Collections.Generic.List<Page> val_33;
            int val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            val_30 = 22974508;
            val_31 = 0;
            if(points == 0)
            {
                    return (bool)val_31 & 1;
            }
            
            val_33 = 536877823;
            val_33 = new System.Collections.Generic.List<Page>();
            536885317 = new FerrPoly2Tri.Contour(parent:  1318797648, points:  points, windingOrder:  2);
            val_33.Add(item:  536885317);
            if(val_33 <= 1)
            {
                    var val_3 = val_33 + 8;
                var val_4 = val_33 + 12;
            }
            else
            {
                    if(mem[536877835] == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_35 = 0;
                int val_5 = mem[536877831] + 16.Count;
                if(val_5 >= 1)
            {
                    do
            {
                if(mem[536877835] == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                FerrPoly2Tri.TriangulationPoint val_6 = mem[536877831] + 16.Item[0];
                bool val_7 = this.ConstrainPointToBounds(p:  mem[536877831] + 16);
                val_35 = val_35 + 1;
            }
            while(val_5 != val_35);
            
            }
            
            }
            
            val_30 = 0;
            val_34 = 0;
            goto label_55;
            label_57:
            if(0 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_36 = mem[536877831];
            val_36 = val_36 + 0;
            (mem[536877831] + 0) + 16.RemoveDuplicateNeighborPoints();
            if(mem[536877835] <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_37 = mem[536877831];
            val_37 = val_37 + 0;
            (mem[536877831] + 0) + 16.WindingOrder = 1;
            label_50:
            if(mem[536877835] <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_38 = mem[536877831];
            val_38 = val_38 + 0;
            label_40:
            var val_39 = (mem[536877831] + 0) + 16;
            Point2DList.PolygonError val_8 = val_39.CheckPolygon();
            if(val_39 == 0)
            {
                goto label_20;
            }
            
            if(val_39 != 0)
            {
                goto label_25;
            }
            
            var val_10 = val_39 & 1073741880;
            val_39 = val_39 & 4;
            if(val_39 != 0)
            {
                    val_39 & 1 = 1;
            }
            
            label_24:
            if(val_39 != 0)
            {
                goto label_22;
            }
            
            if((val_39 & 64) != 0)
            {
                goto label_23;
            }
            
            if(1 == 0)
            {
                goto label_24;
            }
            
            goto label_25;
            label_22:
            val_35 = mem[536877835];
            if(val_35 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_35 = mem[536877835];
            }
            
            val_36 = mem[536877831];
            var val_12 = val_36 + 0;
            if(val_35 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_36 = mem[536877831];
            }
            
            var val_13 = val_36 + 0;
            System.Collections.Generic.List<FerrPoly2Tri.Point2DList> val_14 = FerrPoly2Tri.PolygonUtil.SplitComplexPolygon(verts:  (mem[536877831] + 0) + 16, epsilon:  null);
            val_33.RemoveAt(index:  0);
            List.Enumerator<T> val_15 = GetEnumerator();
            label_34:
            if(MoveNext() == false)
            {
                goto label_31;
            }
            
            536885317 = new FerrPoly2Tri.Contour(parent:  1318797648);
            val_33.Add(item:  536885317);
            goto label_34;
            label_31:
            Dispose();
            if(1 != 0)
            {
                    if((1152921510220599844 + ((1 - 1)) << 2) == 271)
            {
                    val_37 = 1 - 1;
            }
            
            }
            else
            {
                    val_37 = 0;
            }
            
            if(mem[536877835] <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_40 = mem[536877831];
            val_40 = val_40 + 0;
            if(((mem[536877831] + 0) + 16) != 0)
            {
                goto label_40;
            }
            
            goto label_40;
            label_23:
            if(mem[536877835] <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_41 = mem[536877831];
            val_41 = val_41 + 0;
            (mem[536877831] + 0) + 16.Simplify(bias:  null);
            goto label_50;
            label_25:
            if(mem[536877835] <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_42 = mem[536877831];
            val_42 = val_42 + 0;
            if(((mem[536877831] + 0) + 16.Count) != 2)
            {
                goto label_54;
            }
            
            label_20:
            val_34 = 0 + 1;
            goto label_55;
            label_54:
            val_33.RemoveAt(index:  val_34);
            val_34 = val_34;
            label_55:
            if(val_34 < mem[536877835])
            {
                goto label_57;
            }
            
            val_32 = 0;
            val_31 = 1;
            if(mem[536877835] < 1)
            {
                    return (bool)val_31 & 1;
            }
            
            val_30 = 22726612;
            goto label_79;
            label_63:
            val_38 = val_32;
            val_31 = 0;
            goto label_60;
            label_79:
            if(mem[536877835] <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_43 = mem[536877831];
            val_43 = val_43 + 0;
            int val_20 = (mem[536877831] + 0) + 16.Count;
            if(val_20 <= 1)
            {
                goto label_63;
            }
            
            if(mem[536877835] <= val_32)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_44 = mem[536877831];
            val_44 = val_44 + 0;
            if(val_20 != 2)
            {
                goto label_65;
            }
            
            FerrPoly2Tri.TriangulationPoint val_21 = (mem[536877831] + 0) + 16.Item[0];
            if(mem[536877835] <= val_32)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_45 = mem[536877831];
            val_45 = val_45 + 0;
            FerrPoly2Tri.TriangulationPoint val_22 = (mem[536877831] + 0) + 16.Item[1];
            val_33 = this.mConstraintMap;
            if((val_33.TryGetValue(key:  FerrPoly2Tri.TriangulationConstraint.CalculateContraintCode(p:  (mem[536877831] + 0) + 16, q:  (mem[536877831] + 0) + 16), value: out  FerrPoly2Tri.TriangulationConstraint val_24 = 1318785580)) == true)
            {
                goto label_75;
            }
            
            if(mem[536877835] <= val_32)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_46 = mem[536877831];
            val_46 = val_46 + 0;
            FerrPoly2Tri.TriangulationPoint val_26 = (mem[536877831] + 0) + 16.Item[0];
            val_33 = (mem[536877831] + 0) + 16;
            if(mem[536877835] <= val_32)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_47 = mem[536877831];
            val_47 = val_47 + 0;
            FerrPoly2Tri.TriangulationPoint val_27 = (mem[536877831] + 0) + 16.Item[1];
            536895803 = new FerrPoly2Tri.TriangulationConstraint(p1:  val_33, p2:  (mem[536877831] + 0) + 16);
            bool val_29 = this.AddConstraint(tc:  536895803);
            val_30 = val_30;
            val_32 = 0;
            goto label_75;
            label_65:
            FerrPoly2Tri.Contour val_30 = 536885317;
            val_33 = val_30;
            val_30 = new FerrPoly2Tri.Contour(parent:  1318797648, points:  (mem[536877831] + 0) + 16, windingOrder:  2);
            val_33.WindingOrder = 1;
            string val_31 = val_32.ToString();
            string val_32 = name + -1610610741(-1610610741) + 1318785596;
            mem[536885357] = name;
            this.mHoles.Add(item:  536885317);
            label_75:
            val_38 = val_32;
            label_60:
            if((val_38 + 1) < mem[536877835])
            {
                goto label_79;
            }
            
            return (bool)val_31 & 1;
        }
        public bool AddConstraints(System.Collections.Generic.List<FerrPoly2Tri.TriangulationConstraint> constraints)
        {
            FerrPoly2Tri.TriangulationPoint val_2;
            System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationConstraint> val_12;
            bool val_13;
            val_12 = constraints;
            val_13 = 0;
            if((val_12 == 0) || (true < 1))
            {
                    return val_13;
            }
            
            List.Enumerator<T> val_1 = GetEnumerator();
            goto label_11;
            label_12:
            FerrPoly2Tri.TriangulationPoint val_3 = val_2.P;
            if((this.ConstrainPointToBounds(p:  val_2)) == true)
            {
                goto label_5;
            }
            
            FerrPoly2Tri.TriangulationPoint val_5 = val_2.Q;
            if((this.ConstrainPointToBounds(p:  val_2)) == false)
            {
                goto label_7;
            }
            
            label_5:
            val_2.CalculateContraintCode();
            label_7:
            val_12 = this.mConstraintMap;
            if((val_12.TryGetValue(key:  val_2 + 16, value: out  FerrPoly2Tri.TriangulationConstraint val_7 = 1318922164)) != true)
            {
                    bool val_12 = true;
                val_12 = val_12 & (this.AddConstraint(tc:  val_2));
            }
            
            label_11:
            if(MoveNext() == true)
            {
                goto label_12;
            }
            
            Dispose();
            val_13 = val_12;
            return val_13;
        }
        public bool AddConstraint(FerrPoly2Tri.TriangulationConstraint tc)
        {
            var val_14;
            System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationConstraint> val_15;
            val_14 = 0;
            if(tc == 0)
            {
                    return (bool)val_14;
            }
            
            val_14 = 0;
            FerrPoly2Tri.TriangulationPoint val_1 = tc.P;
            if(tc == 0)
            {
                    return (bool)val_14;
            }
            
            val_14 = 0;
            FerrPoly2Tri.TriangulationPoint val_2 = tc.Q;
            if(tc == 0)
            {
                    return (bool)val_14;
            }
            
            val_15 = this.mConstraintMap;
            val_14 = 1;
            if((val_15.ContainsKey(key:  tc.mContraintCode)) == true)
            {
                    return (bool)val_14;
            }
            
            FerrPoly2Tri.TriangulationPoint val_4 = tc.P;
            FerrPoly2Tri.TriangulationPoint val_5 = tc.P;
            if((this.TryGetPoint(x:  null, y:  null, p: out  FerrPoly2Tri.TriangulationPoint val_6 = typeof(FerrPoly2Tri.TriangulationConstraint).__il2cppRuntimeField_F8)) != false)
            {
                    tc.P = 0;
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_8 = tc.P;
            }
            
            FerrPoly2Tri.TriangulationPoint val_9 = tc.Q;
            FerrPoly2Tri.TriangulationPoint val_10 = tc.Q;
            if((this.TryGetPoint(x:  null, y:  null, p: out  FerrPoly2Tri.TriangulationPoint val_11 = typeof(FerrPoly2Tri.TriangulationConstraint).__il2cppRuntimeField_F8)) != false)
            {
                    tc.Q = 0;
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_13 = tc.Q;
            }
            
            val_15 = tc.mContraintCode;
            this.mConstraintMap.Add(key:  val_15, value:  tc);
            return (bool)val_14;
        }
        public bool TryGetConstraint(uint constraintCode, out FerrPoly2Tri.TriangulationConstraint tc)
        {
            if(this.mConstraintMap != 0)
            {
                    return this.mConstraintMap.TryGetValue(key:  constraintCode, value: out  FerrPoly2Tri.TriangulationConstraint val_1 = 1319231104);
            }
            
            return this.mConstraintMap.TryGetValue(key:  constraintCode, value: out  val_1);
        }
        public int GetNumConstraints()
        {
            if(this.mConstraintMap != 0)
            {
                    return this.mConstraintMap.Count;
            }
            
            return this.mConstraintMap.Count;
        }
        public System.Collections.Generic.Dictionary.Enumerator<uint, FerrPoly2Tri.TriangulationConstraint> GetConstraintEnumerator()
        {
            FerrPoly2Tri.ConstrainedPointSet val_2;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            this = val_2;
            return (Dictionary.Enumerator<System.UInt32, FerrPoly2Tri.TriangulationConstraint>)val_1.getEnumeratorRetType;
        }
        public int GetNumHoles()
        {
            var val_2;
            var val_5;
            List.Enumerator<T> val_1 = GetEnumerator();
            val_5 = 0;
            goto label_2;
            label_4:
            val_5 = (val_2.GetNumHoles(parentIsHole:  false)) + val_5;
            label_2:
            if(MoveNext() == true)
            {
                goto label_4;
            }
            
            Dispose();
            return (int)val_5;
        }
        public FerrPoly2Tri.Contour GetHole(int idx)
        {
            var val_1 = 0;
            if(idx < 0)
            {
                    return;
            }
            
            if(true <= idx)
            {
                    return;
            }
            
            if(true <= idx)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (idx << 2);
            val_1 = mem[(0 + (idx) << 2) + 16];
            val_1 = (0 + (idx) << 2) + 16;
        }
        public int GetActualHoles(out System.Collections.Generic.List<FerrPoly2Tri.Contour> holes)
        {
            var val_4;
            536877823 = new System.Collections.Generic.List<Page>();
            holes = 536877823;
            List.Enumerator<T> val_2 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_4.GetActualHoles(parentIsHole:  false, holes: ref  System.Collections.Generic.List<FerrPoly2Tri.Contour> val_5 = 1319840096);
            goto label_4;
            label_2:
            Dispose();
            if(holes != 0)
            {
                    return (int)mem[536877835];
            }
            
            return (int)mem[536877835];
        }
        protected void InitializeHoles()
        {
            var val_3;
            FerrPoly2Tri.Contour.InitializeHoles(holes:  this.mHoles, parent:  1319936400, cps:  1319936400);
            List.Enumerator<T> val_1 = GetEnumerator();
            label_4:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            val_3.InitializeHoles(cps:  1319936400);
            goto label_4;
            label_2:
            Dispose();
        }
        public override bool Initialize()
        {
            this.InitializeHoles();
            return this.Initialize();
        }
        public override void Prepare(FerrPoly2Tri.TriangulationContext tcx)
        {
            System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationConstraint> val_7;
            var val_8;
            val_7 = 22974518;
            if(this == 0)
            {
                    return;
            }
            
            this.Prepare(tcx:  tcx);
            val_7 = this.mConstraintMap;
            Dictionary.Enumerator<TKey, TValue> val_1 = 0.GetEnumerator();
            if(0.MoveNext() == false)
            {
                    return;
            }
            
            do
            {
                if(0 != 0)
            {
                    FerrPoly2Tri.TriangulationPoint val_3 = 0.P;
                val_8 = 0;
            }
            else
            {
                    FerrPoly2Tri.TriangulationPoint val_4 = 0.P;
                val_8 = 0;
            }
            
                FerrPoly2Tri.TriangulationPoint val_5 = 0.Q;
                val_7 = 0;
            }
            while(0.MoveNext() == true);
        
        }
        public override void AddTriangle(FerrPoly2Tri.DelaunayTriangle t)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this;
            goto mem[(1152921504927772672 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
    
    }

}
