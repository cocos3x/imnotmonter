using UnityEngine;

namespace FerrPoly2Tri
{
    public class Contour : Point2DList, ITriangulatable, IEnumerable<FerrPoly2Tri.TriangulationPoint>, IEnumerable, IList<FerrPoly2Tri.TriangulationPoint>, ICollection<FerrPoly2Tri.TriangulationPoint>
    {
        // Fields
        private System.Collections.Generic.List<FerrPoly2Tri.Contour> mHoles;
        private FerrPoly2Tri.ITriangulatable mParent;
        private string mName;
        
        // Properties
        public FerrPoly2Tri.TriangulationPoint Item { get; set; }
        public string Name { get; set; }
        public System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> Triangles { get; set; }
        public FerrPoly2Tri.TriangulationMode TriangulationMode { get; }
        public string FileName { get; set; }
        public bool DisplayFlipX { get; set; }
        public bool DisplayFlipY { get; set; }
        public float DisplayRotate { get; set; }
        public double Precision { get; set; }
        public double MinX { get; }
        public double MaxX { get; }
        public double MinY { get; }
        public double MaxY { get; }
        public FerrPoly2Tri.Rect2D Bounds { get; }
        
        // Methods
        public FerrPoly2Tri.TriangulationPoint get_Item(int index)
        {
            if(true <= index)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 2);
            if(((0 + (index) << 2) + 16) == 0)
            {
                    return;
            }
            
            22974523 = mem[536895999];
            if(((0 + (index) << 2) + 16 + 180) < 22974523)
            {
                    return;
            }
            
            var val_2 = (0 + (index) << 2) + 16 + 100;
            val_2 = val_2 + (22974523 << 2);
            if((((0 + (index) << 2) + 16 + 100 + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    (0 + (index) << 2) + 16 = 0;
            }
        
        }
        public void set_Item(int index, FerrPoly2Tri.TriangulationPoint value)
        {
            this.set_Item(index:  index, value:  value);
        }
        public string get_Name()
        {
        
        }
        public void set_Name(string value)
        {
            this.mName = value;
        }
        public System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> get_Triangles()
        {
            22713472 = new System.NotImplementedException(message:  22791728);
        }
        private void set_Triangles(System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> value)
        {
        
        }
        public FerrPoly2Tri.TriangulationMode get_TriangulationMode()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.mParent;
            goto mem[(1152921504927133696 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public string get_FileName()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.mParent;
            goto mem[(1152921504927133696 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void set_FileName(string value)
        {
        
        }
        public bool get_DisplayFlipX()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.mParent;
            goto mem[(1152921504927133696 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void set_DisplayFlipX(bool value)
        {
        
        }
        public bool get_DisplayFlipY()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.mParent;
            goto mem[(1152921504927133696 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void set_DisplayFlipY(bool value)
        {
        
        }
        public float get_DisplayRotate()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.mParent;
            goto mem[(1152921504927133696 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void set_DisplayRotate(float value)
        {
        
        }
        public double get_Precision()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.mParent;
            goto mem[(1152921504927133696 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void set_Precision(double value)
        {
        
        }
        public double get_MinX()
        {
            if(R4 != 0)
            {
                    return (double)D0;
            }
            
            return (double)D0;
        }
        public double get_MaxX()
        {
            if(R4 != 0)
            {
                    return (double)D0;
            }
            
            return (double)D0;
        }
        public double get_MinY()
        {
            if(R4 != 0)
            {
                    return (double)D0;
            }
            
            return (double)D0;
        }
        public double get_MaxY()
        {
            if(R4 != 0)
            {
                    return (double)D0;
            }
            
            return (double)D0;
        }
        public FerrPoly2Tri.Rect2D get_Bounds()
        {
        
        }
        public Contour(FerrPoly2Tri.ITriangulatable parent)
        {
            536877823 = new System.Collections.Generic.List<Page>();
            this.mHoles = 536877823;
            mem[1152921510201927576] = -1610612735;
            this.mParent = parent;
        }
        public Contour(FerrPoly2Tri.ITriangulatable parent, System.Collections.Generic.IList<FerrPoly2Tri.TriangulationPoint> points, FerrPoly2Tri.Point2DList.WindingOrderType windingOrder)
        {
            536877823 = new System.Collections.Generic.List<Page>();
            this.mHoles = 536877823;
            mem[1152921510202055960] = -1610612735;
            this.mParent = parent;
            this.AddRange(points:  points, windingOrder:  windingOrder);
        }
        public override string ToString()
        {
            string val_1 = this.ToString();
            return this.mName + -1610612487(-1610612487) + 1300370032;
        }
        private System.Collections.Generic.IEnumerator<FerrPoly2Tri.TriangulationPoint> System.Collections.Generic.IEnumerable<FerrPoly2Tri.TriangulationPoint>.GetEnumerator()
        {
            536895827 = new FerrPoly2Tri.TriangulationPointEnumerator(points:  1300486128);
        }
        public int IndexOf(FerrPoly2Tri.TriangulationPoint p)
        {
            if(this != 0)
            {
                    return this.IndexOf(item:  p);
            }
            
            return this.IndexOf(item:  p);
        }
        public void Add(FerrPoly2Tri.TriangulationPoint p)
        {
        
        }
        protected override void Add(FerrPoly2Tri.Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
        {
            int val_4;
            FerrPoly2Tri.TriangulationPoint val_5;
            val_4 = idx;
            val_5 = p;
            if(val_5 != 0)
            {
                
            }
            else
            {
                    val_5 = 536895819;
                val_5 = new FerrPoly2Tri.TriangulationPoint(x:  null, y:  null, aId:  0);
                val_4 = val_4;
            }
            
            if(val_4 > 1)
            {
                    val_5.Insert(index:  val_4, item:  536895819);
            }
            else
            {
                    val_5.Add(item:  536895819);
            }
            
            val_5.AddPoint(p:  536895819);
            if(bCalcWindingOrderAndEpsilon == false)
            {
                    return;
            }
            
            if(val_5 == 2)
            {
                    WindingOrderType val_2 = this.CalculateWindingOrder();
                mem[1152921510202656896] = this;
            }
            
            double val_3 = this.CalculateEpsilon();
            mem[1152921510202656904] = this;
        }
        public override void AddRange(System.Collections.Generic.IEnumerator<FerrPoly2Tri.Point2D> iter, FerrPoly2Tri.Point2DList.WindingOrderType windingOrder)
        {
            WindingOrderType val_13;
            var val_15;
            var val_16;
            FerrPoly2Tri.Contour val_17;
            float val_18;
            var val_19;
            var val_20;
            var val_21;
            FerrPoly2Tri.TriangulationPoint val_22;
            var val_23;
            var val_24;
            var val_25;
            FerrPoly2Tri.Contour val_15 = this;
            val_13 = windingOrder;
            if(iter == 0)
            {
                    return;
            }
            
            if(true == 2)
            {
                    int val_1 = val_15.Count;
                if(val_1 == 0)
            {
                    mem[1152921510202781184] = val_13;
                val_1 = val_13;
            }
            
            }
            
            val_15 = val_1 - 2;
            if(val_1 != 0)
            {
                    val_15 = 1;
            }
            
            if(val_1 != 0)
            {
                    val_13 - 2 = 1;
            }
            
            if(val_1 != 0)
            {
                    val_1 - val_13 = 1;
            }
            
            val_15 = 0;
            val_15 = val_15 + 1;
            val_16 = iter;
            val_17 = val_15;
            val_18 = 4.01422E-38f;
            goto label_8;
            label_41:
            val_15 = 0;
            val_15 = val_15 + 1;
            val_19 = iter;
            val_20 = 0;
            if(iter != 0)
            {
                    if(((System.Collections.Generic.IEnumerator<T>.__il2cppRuntimeField_typeHierarchy + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    iter = 0;
            }
            
                val_20 = iter;
            }
            
            val_15 = 0;
            val_15 = val_15 + 1;
            val_21 = iter;
            if(val_20 == 0)
            {
                goto label_19;
            }
            
            val_22 = 0;
            if(iter == 0)
            {
                goto label_22;
            }
            
            if(((System.Collections.Generic.IEnumerator<T>.__il2cppRuntimeField_typeHierarchy + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    iter = 0;
            }
            
            val_22 = iter;
            goto label_22;
            label_19:
            val_15 = typeof(System.Collections.Generic.IEnumerator<T>).__il2cppRuntimeField_E8;
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_23 = iter;
            val_22 = 536895819;
            val_22 = new FerrPoly2Tri.TriangulationPoint(x:  null, y:  null, aId:  typeof(System.Collections.Generic.IEnumerator<T>).__il2cppRuntimeField_F8);
            val_17 = val_15;
            val_18 = 4.01422E-38f;
            label_22:
            if((1 & (1 & 1)) != 0)
            {
                    mem[1152921510202781176].Insert(index:  R7 + 12, item:  536895819);
            }
            else
            {
                    mem[1152921510202781176].Add(item:  536895819);
            }
            
            val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = (uint)val_15 & 65535;
            val_24 = iter;
            mem[1152921510202781180].AddPoint(p:  iter);
            label_8:
            val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = (uint)val_15 & 65535;
            val_25 = iter;
            if(iter != 0)
            {
                goto label_41;
            }
            
            if(val_13 == 2)
            {
                    val_13 = mem[1152921510202781184];
            }
            
            if(val_13 == 2)
            {
                    WindingOrderType val_13 = this.CalculateWindingOrder();
                mem[1152921510202781184] = val_17;
            }
            
            double val_14 = this.CalculateEpsilon();
            mem[1152921510202781192] = this;
        }
        public void AddRange(System.Collections.Generic.IList<FerrPoly2Tri.TriangulationPoint> points, FerrPoly2Tri.Point2DList.WindingOrderType windingOrder)
        {
            WindingOrderType val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            val_10 = windingOrder;
            val_11 = 22974538;
            if(points == 0)
            {
                    return;
            }
            
            val_11 = 0;
            val_11 = val_11 + 1;
            val_12 = points;
            if(points < 1)
            {
                    return;
            }
            
            if(points == 2)
            {
                    if(this.Count == 0)
            {
                    mem[1152921510202909568] = val_10;
            }
            
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_13 = points;
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) != 536875919)
            {
                    val_10 - 2 = 1;
            }
            
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) != 536875919)
            {
                    -2 = 1;
            }
            
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) != 536875919)
            {
                    val_10 - val_10 = 1;
            }
            
            if(points >= 1)
            {
                    do
            {
                val_14 = 0;
                if(1 != 0)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_15 = points;
            }
            
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_16 = points;
                val_10 = 0 + 1;
            }
            while(val_10 != points);
            
            }
            
            WindingOrderType val_8 = this.CalculateWindingOrder();
            mem[1152921510202909568] = this;
            double val_9 = this.CalculateEpsilon();
            mem[1152921510202909576] = this;
        }
        public void Insert(int idx, FerrPoly2Tri.TriangulationPoint p)
        {
        
        }
        public bool Remove(FerrPoly2Tri.TriangulationPoint p)
        {
            goto typeof(FerrPoly2Tri.Contour).__il2cppRuntimeField_17C;
        }
        public bool Contains(FerrPoly2Tri.TriangulationPoint p)
        {
            if(this != 0)
            {
                    return this.Contains(item:  p);
            }
            
            return this.Contains(item:  p);
        }
        public void CopyTo(FerrPoly2Tri.TriangulationPoint[] array, int arrayIndex)
        {
            var val_6;
            FerrPoly2Tri.TriangulationPoint val_7;
            int val_3 = System.Math.Min(val1:  this.Count, val2:  536890295 - arrayIndex);
            if(val_3 < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            label_14:
            if((val_1 + 12) <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_4 = val_1 + 8;
            val_4 = val_4 + 0;
            if(((val_1 + 8 + 0) + 16) == 0)
            {
                goto label_7;
            }
            
            if(((val_1 + 8 + 0) + 16 + 180) >= mem[536895999])
            {
                    var val_5 = (val_1 + 8 + 0) + 16 + 100;
                val_5 = val_5 + (mem[536895999] << 2);
            }
            
            val_6 = arrayIndex + val_7;
            if(((val_1 + 8 + 0) + 16 + 180) < mem[536895999])
            {
                goto label_11;
            }
            
            var val_6 = (val_1 + 8 + 0) + 16 + 100;
            val_6 = val_6 + (mem[536895999] << 2);
            if((((val_1 + 8 + 0) + 16 + 100 + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    val_7 = 0;
            }
            
            goto label_12;
            label_7:
            val_6 = val_7 + arrayIndex;
            label_11:
            val_7 = 0;
            label_12:
            array[val_6] = val_7;
            val_7 = val_7 + 1;
            if(val_3 != val_7)
            {
                goto label_14;
            }
        
        }
        protected void AddHole(FerrPoly2Tri.Contour c)
        {
            c.mParent = this;
            this.mHoles.Add(item:  c);
        }
        public int GetNumHoles(bool parentIsHole)
        {
            var val_3;
            System.Collections.Generic.List<FerrPoly2Tri.Contour> val_5;
            var val_6;
            val_5 = this.mHoles;
            List.Enumerator<T> val_2 = GetEnumerator();
            val_6 = parentIsHole ^ 1;
            goto label_2;
            label_5:
            val_5 = val_3;
            val_6 = val_5 + val_6;
            label_2:
            if(MoveNext() == true)
            {
                goto label_5;
            }
            
            Dispose();
            return (int)val_6;
        }
        public int GetNumHoles()
        {
            if(this.mHoles != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
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
        public void GetActualHoles(bool parentIsHole, ref System.Collections.Generic.List<FerrPoly2Tri.Contour> holes)
        {
            var val_3;
            bool val_4 = parentIsHole;
            if(val_4 != false)
            {
                    holes.Add(item:  1302267040);
            }
            
            List.Enumerator<T> val_1 = GetEnumerator();
            val_4 = val_4 ^ 1;
            label_7:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            if(val_3 != 0)
            {
                goto label_7;
            }
            
            goto label_7;
            label_4:
            Dispose();
        }
        public System.Collections.Generic.List.Enumerator<FerrPoly2Tri.Contour> GetHoleEnumerator()
        {
            List.Enumerator<T> val_1 = GetEnumerator();
            return (List.Enumerator<FerrPoly2Tri.Contour>)val_1.current;
        }
        public void InitializeHoles(FerrPoly2Tri.ConstrainedPointSet cps)
        {
            var val_3;
            FerrPoly2Tri.Contour.InitializeHoles(holes:  this.mHoles, parent:  1302511440, cps:  cps);
            List.Enumerator<T> val_1 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            if(val_3 != 0)
            {
                goto label_5;
            }
            
            goto label_5;
            label_2:
            Dispose();
        }
        public static void InitializeHoles(System.Collections.Generic.List<FerrPoly2Tri.Contour> holes, FerrPoly2Tri.ITriangulatable parent, FerrPoly2Tri.ConstrainedPointSet cps)
        {
            System.Collections.Generic.List<FerrPoly2Tri.Contour> val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            val_28 = holes;
            val_29 = mem[holes + 12];
            val_29 = holes + 12;
            if(val_29 < 1)
            {
                goto label_115;
            }
            
            int val_27 = 0;
            label_11:
            val_27 = val_27 + 1;
            int val_28 = val_27;
            goto label_3;
            label_10:
            val_30 = mem[holes + 12];
            val_30 = holes + 12;
            if(val_30 <= val_27)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_30 = mem[holes + 12];
                val_30 = holes + 12;
            }
            
            val_31 = mem[holes + 8];
            val_31 = holes + 8;
            var val_1 = val_31 + 0;
            if(val_30 <= val_28)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_31 = mem[holes + 8];
                val_31 = holes + 8;
            }
            
            var val_2 = val_31 + (val_28 << 2);
            if((FerrPoly2Tri.PolygonUtil.PolygonsAreSame2D(poly1:  (holes + 8 + 0) + 16, poly2:  (holes + 8 + ((0 + 1)) << 2) + 16)) == false)
            {
                goto label_7;
            }
            
            holes.RemoveAt(index:  val_28);
            val_29 = val_29 - 1;
            if(val_28 < val_29)
            {
                goto label_10;
            }
            
            goto label_9;
            label_7:
            val_28 = val_28 + 1;
            label_3:
            if(val_28 < val_29)
            {
                goto label_10;
            }
            
            label_9:
            if(val_27 < val_29)
            {
                goto label_11;
            }
            
            val_28 = holes;
            if(val_29 < 1)
            {
                goto label_115;
            }
            
            System.Collections.Generic.List<FerrPoly2Tri.Contour> val_4 = val_28 + 8;
            label_116:
            var val_41 = 1;
            label_114:
            if(val_41 >= val_29)
            {
                goto label_13;
            }
            
            val_32 = mem[holes + 12];
            val_32 = holes + 12;
            if(val_32 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_32 = mem[holes + 12];
                val_32 = holes + 12;
            }
            
            var val_29 = val_4;
            val_29 = val_29 + 0;
            val_33 = ((holes + 8) + 0) + 16;
            if(val_32 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_30 = val_4;
                val_30 = val_30 + 0;
                val_33 = mem[((holes + 8) + 0) + 16];
                val_33 = ((holes + 8) + 0) + 16;
            }
            
            val_34 = mem[holes + 12];
            val_34 = holes + 12;
            if(val_34 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_34 = mem[holes + 12];
                val_34 = holes + 12;
            }
            
            var val_31 = val_4;
            val_31 = val_31 + 4;
            val_35 = ((holes + 8) + 4) + 16;
            if(val_34 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_32 = val_4;
                val_32 = val_32 + 4;
                val_35 = mem[((holes + 8) + 4) + 16];
                val_35 = ((holes + 8) + 4) + 16;
            }
            
            val_36 = mem[holes + 12];
            val_36 = holes + 12;
            if((FerrPoly2Tri.PolygonUtil.PolygonContainsPolygon(poly1:  ((holes + 8) + 0) + 16, boundRect1:  ((holes + 8) + 0) + 16 + 12, poly2:  ((holes + 8) + 4) + 16, boundRect2:  ((holes + 8) + 4) + 16 + 12, runIntersectionTest:  false)) == false)
            {
                goto label_21;
            }
            
            if(val_36 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_37 = mem[holes + 12];
                val_37 = holes + 12;
            }
            
            val_38 = mem[(holes + 8)];
            val_38 = val_4;
            System.Collections.Generic.List<FerrPoly2Tri.Contour> val_6 = val_38 + 0;
            if(val_37 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_38 = mem[(holes + 8)];
                val_38 = val_4;
            }
            
            val_38 = val_38 + 4;
            ((holes + 8) + 0) + 16.AddHole(c:  ((holes + 8) + 4) + 16);
            holes.RemoveAt(index:  1);
            val_29 = val_29 - 1;
            goto label_114;
            label_21:
            if(val_36 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_39 = mem[holes + 12];
                val_39 = holes + 12;
            }
            
            var val_33 = val_4;
            val_33 = val_33 + 4;
            val_40 = ((holes + 8) + 4) + 16;
            if(val_39 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_34 = val_4;
                val_34 = val_34 + 4;
                val_40 = mem[((holes + 8) + 4) + 16];
                val_40 = ((holes + 8) + 4) + 16;
            }
            
            val_41 = mem[holes + 12];
            val_41 = holes + 12;
            if(val_41 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_41 = mem[holes + 12];
                val_41 = holes + 12;
            }
            
            var val_35 = val_4;
            val_35 = val_35 + 0;
            val_42 = ((holes + 8) + 0) + 16;
            if(val_41 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_36 = val_4;
                val_36 = val_36 + 0;
                val_42 = mem[((holes + 8) + 0) + 16];
                val_42 = ((holes + 8) + 0) + 16;
            }
            
            val_43 = mem[holes + 12];
            val_43 = holes + 12;
            if((FerrPoly2Tri.PolygonUtil.PolygonContainsPolygon(poly1:  ((holes + 8) + 4) + 16, boundRect1:  ((holes + 8) + 4) + 16 + 12, poly2:  ((holes + 8) + 0) + 16, boundRect2:  ((holes + 8) + 0) + 16 + 12, runIntersectionTest:  false)) == true)
            {
                goto label_32;
            }
            
            if(val_43 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_44 = mem[holes + 12];
                val_44 = holes + 12;
            }
            
            var val_37 = val_4;
            val_37 = val_37 + 0;
            val_45 = ((holes + 8) + 0) + 16;
            if(val_44 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_38 = val_4;
                val_38 = val_38 + 0;
                val_45 = mem[((holes + 8) + 0) + 16];
                val_45 = ((holes + 8) + 0) + 16;
            }
            
            val_46 = mem[holes + 12];
            val_46 = holes + 12;
            if(val_46 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_46 = mem[holes + 12];
                val_46 = holes + 12;
            }
            
            var val_39 = val_4;
            val_39 = val_39 + 4;
            val_47 = ((holes + 8) + 4) + 16;
            if(val_46 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                var val_40 = val_4;
                val_40 = val_40 + 4;
                val_47 = mem[((holes + 8) + 4) + 16];
                val_47 = ((holes + 8) + 4) + 16;
            }
            
            if((FerrPoly2Tri.PolygonUtil.PolygonsIntersect2D(poly1:  ((holes + 8) + 0) + 16, boundRect1:  ((holes + 8) + 0) + 16 + 12, poly2:  ((holes + 8) + 4) + 16, boundRect2:  ((holes + 8) + 4) + 16 + 12)) == false)
            {
                goto label_39;
            }
            
            FerrPoly2Tri.PolygonOperationContext val_9 = 536891965;
            val_9 = new FerrPoly2Tri.PolygonOperationContext();
            val_48 = mem[holes + 12];
            val_48 = holes + 12;
            if(val_48 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_48 = mem[holes + 12];
                val_48 = holes + 12;
            }
            
            val_49 = mem[(holes + 8)];
            val_49 = val_4;
            System.Collections.Generic.List<FerrPoly2Tri.Contour> val_10 = val_49 + 0;
            if(val_48 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_49 = mem[(holes + 8)];
                val_49 = val_4;
            }
            
            System.Collections.Generic.List<FerrPoly2Tri.Contour> val_11 = val_49 + 4;
            if((val_9.Init(operations:  3, polygon1:  ((holes + 8) + 0) + 16, polygon2:  ((holes + 8) + 4) + 16)) == false)
            {
                goto label_43;
            }
            
            PolygonUtil.PolyUnionError val_13 = FerrPoly2Tri.PolygonUtil.PolygonOperation(ctx:  536891965);
            if(val_9 != 0)
            {
                goto label_44;
            }
            
            if(val_9 == 0)
            {
                goto label_45;
            }
            
            FerrPoly2Tri.Point2DList val_14 = val_9.Union;
            val_50 = val_9;
            goto label_46;
            label_39:
            val_41 = val_41 + 1;
            goto label_114;
            label_45:
            FerrPoly2Tri.Point2DList val_15 = val_9.Union;
            val_50 = val_9;
            label_46:
            FerrPoly2Tri.Point2DList val_16 = val_9.Intersect;
            536885317 = new FerrPoly2Tri.Contour(parent:  parent);
            mem[536882417] = -1610612033;
            if((holes + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_42 = val_4;
            val_42 = val_42 + 0;
            mem[536882421] = ((holes + 8) + 0) + 16 + 40;
            mem[536882425] = -1610612431;
            if((holes + 12) <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_43 = val_4;
            val_43 = val_43 + 4;
            mem[536882429] = ((holes + 8) + 4) + 16 + 40;
            mem[536882433] = -1610611957;
            string val_18 = +536882401;
            mem[536885357] = 536882401;
            val_17.WindingOrder = 1;
            if((holes + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_44 = val_4;
            val_44 = val_44 + 0;
            int val_19 = ((holes + 8) + 0) + 16.GetNumHoles();
            val_51 = mem[holes + 12];
            val_51 = holes + 12;
            if(val_19 >= 1)
            {
                    var val_46 = 0;
                do
            {
                if(val_51 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_45 = val_4;
                val_45 = val_45 + 0;
                FerrPoly2Tri.Contour val_20 = ((holes + 8) + 0) + 16.GetHole(idx:  0);
                this.AddHole(c:  ((holes + 8) + 0) + 16);
                val_46 = val_46 + 1;
                val_51 = mem[holes + 12];
                val_51 = holes + 12;
            }
            while(val_19 != val_46);
            
            }
            
            if(val_51 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_47 = val_4;
            val_47 = val_47 + 4;
            int val_21 = ((holes + 8) + 4) + 16.GetNumHoles();
            if(val_21 >= 1)
            {
                    var val_49 = 0;
                do
            {
                if((holes + 12) <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_48 = val_4;
                val_48 = val_48 + 4;
                FerrPoly2Tri.Contour val_22 = ((holes + 8) + 4) + 16.GetHole(idx:  0);
                this.AddHole(c:  ((holes + 8) + 4) + 16);
                val_49 = val_49 + 1;
            }
            while(val_21 != val_49);
            
            }
            
            536885317 = new FerrPoly2Tri.Contour(parent:  536885317);
            mem[536882417] = -1610612033;
            if((holes + 12) <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_50 = val_4;
            val_50 = val_50 + 0;
            mem[536882421] = ((holes + 8) + 0) + 16 + 40;
            mem[536882425] = -1610612453;
            if((holes + 12) <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_51 = val_4;
            val_51 = val_51 + 4;
            mem[536882429] = ((holes + 8) + 4) + 16 + 40;
            mem[536882433] = -1610611957;
            string val_24 = +536882401;
            mem[536885357] = 536882401;
            val_23.WindingOrder = 1;
            this.AddHole(c:  536885317);
            holes.set_Item(index:  0, value:  536885317);
            holes.RemoveAt(index:  1);
            val_29 = val_29 - 1;
            goto label_114;
            label_32:
            val_52 = 0;
            if(val_43 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_53 = mem[holes + 12];
                val_53 = holes + 12;
            }
            
            val_54 = mem[(holes + 8)];
            val_54 = val_4;
            System.Collections.Generic.List<FerrPoly2Tri.Contour> val_25 = val_54 + 4;
            val_55 = mem[((holes + 8) + 4) + 16];
            val_55 = ((holes + 8) + 4) + 16;
            if(val_53 <= val_52)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_54 = mem[(holes + 8)];
                val_54 = val_4;
            }
            
            val_56 = val_54 + 0;
            goto label_108;
            label_43:
            val_52 = 0;
            if(mem[536892001] != 2)
            {
                goto label_110;
            }
            
            val_57 = mem[holes + 12];
            val_57 = holes + 12;
            if(val_57 <= val_41)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_57 = mem[holes + 12];
                val_57 = holes + 12;
            }
            
            val_58 = mem[(holes + 8)];
            val_58 = val_4;
            System.Collections.Generic.List<FerrPoly2Tri.Contour> val_26 = val_58 + 4;
            val_55 = mem[((holes + 8) + 4) + 16];
            val_55 = ((holes + 8) + 4) + 16;
            if(val_57 <= val_52)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_58 = mem[(holes + 8)];
                val_58 = val_4;
            }
            
            val_56 = val_58 + 0;
            label_108:
            val_55.AddHole(c:  ((holes + 8) + 0) + 16);
            val_28 = holes;
            val_28.RemoveAt(index:  0);
            val_29 = val_29 - 1;
            if(val_52 < val_29)
            {
                goto label_114;
            }
            
            goto label_115;
            label_13:
            if(val_41 < val_29)
            {
                goto label_116;
            }
            
            label_115:
            if((holes + 12) >= 1)
            {
                
            }
        
        }
        public void Prepare(FerrPoly2Tri.TriangulationContext tcx)
        {
            22713472 = new System.NotImplementedException(message:  22791724);
        }
        public void AddTriangle(FerrPoly2Tri.DelaunayTriangle t)
        {
            22713472 = new System.NotImplementedException(message:  22791712);
        }
        public void AddTriangles(System.Collections.Generic.IEnumerable<FerrPoly2Tri.DelaunayTriangle> list)
        {
            22713472 = new System.NotImplementedException(message:  22791716);
        }
        public void ClearTriangles()
        {
            22713472 = new System.NotImplementedException(message:  22791720);
        }
        public FerrPoly2Tri.Point2D FindPointInContour()
        {
            var val_7;
            var val_8;
            var val_10;
            var val_12;
            val_7 = 0;
            if(this.Count < 3)
            {
                    return;
            }
            
            FerrPoly2Tri.Point2D val_2 = this.GetCentroid();
            val_7 = this;
            if((this.IsPointInsideContour(p:  1303244880)) == true)
            {
                    return;
            }
            
            System.Random val_4 = 536892443;
            val_4 = new System.Random();
            label_11:
            val_8 = val_4;
            if(val_4 == 0)
            {
                goto label_4;
            }
            
            val_10 = 536892459;
            goto label_5;
            label_4:
            val_10 = 16;
            if(val_4 == 0)
            {
                goto label_10;
            }
            
            label_5:
            double val_5 = val_10 - mem[536892451];
            val_8 = val_4;
            if(val_4 == 0)
            {
                goto label_8;
            }
            
            val_12 = 536892475;
            goto label_9;
            label_8:
            val_12 = 32;
            if(val_4 == 0)
            {
                goto label_10;
            }
            
            label_9:
            val_12 = val_12 - mem[536892467];
            if((this.IsPointInsideContour(p:  1303244880)) == false)
            {
                goto label_11;
            }
            
            return;
            label_10:
        }
        public bool IsPointInsideContour(FerrPoly2Tri.Point2D p)
        {
            var val_4;
            var val_5;
            var val_6;
            val_5 = 0;
            if((FerrPoly2Tri.PolygonUtil.PointInPolygon2D(polygon:  1303365072, p:  p)) == false)
            {
                    return (bool)val_5;
            }
            
            List.Enumerator<T> val_2 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            if(val_4 == 0)
            {
                goto label_6;
            }
            
            val_6 = 7;
            goto label_7;
            label_3:
            val_6 = 3;
            label_7:
            Dispose();
            var val_5 = val_6 + 1;
            val_5 = (val_5 & 7) - val_5;
            val_5 = val_5 >> 5;
            return (bool)val_5;
        }
    
    }

}
