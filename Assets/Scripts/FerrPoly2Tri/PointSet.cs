using UnityEngine;

namespace FerrPoly2Tri
{
    public class PointSet : Point2DList, ITriangulatable, IEnumerable<FerrPoly2Tri.TriangulationPoint>, IEnumerable, IList<FerrPoly2Tri.TriangulationPoint>, ICollection<FerrPoly2Tri.TriangulationPoint>
    {
        // Fields
        protected System.Collections.Generic.Dictionary<uint, FerrPoly2Tri.TriangulationPoint> mPointMap;
        private System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> <Triangles>k__BackingField;
        private string <FileName>k__BackingField;
        private bool <DisplayFlipX>k__BackingField;
        private bool <DisplayFlipY>k__BackingField;
        private float <DisplayRotate>k__BackingField;
        protected double mPrecision;
        
        // Properties
        public System.Collections.Generic.IList<FerrPoly2Tri.TriangulationPoint> Points { get; set; }
        public System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> Triangles { get; set; }
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
        public virtual FerrPoly2Tri.TriangulationMode TriangulationMode { get; }
        public FerrPoly2Tri.TriangulationPoint Item { get; set; }
        
        // Methods
        public System.Collections.Generic.IList<FerrPoly2Tri.TriangulationPoint> get_Points()
        {
        
        }
        private void set_Points(System.Collections.Generic.IList<FerrPoly2Tri.TriangulationPoint> value)
        {
        
        }
        public System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> get_Triangles()
        {
        
        }
        private void set_Triangles(System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> value)
        {
            this.<Triangles>k__BackingField = value;
        }
        public string get_FileName()
        {
        
        }
        public void set_FileName(string value)
        {
            this.<FileName>k__BackingField = value;
        }
        public bool get_DisplayFlipX()
        {
            return (bool)this.<DisplayFlipX>k__BackingField;
        }
        public void set_DisplayFlipX(bool value)
        {
            this.<DisplayFlipX>k__BackingField = value;
        }
        public bool get_DisplayFlipY()
        {
            return (bool)this.<DisplayFlipY>k__BackingField;
        }
        public void set_DisplayFlipY(bool value)
        {
            this.<DisplayFlipY>k__BackingField = value;
        }
        public float get_DisplayRotate()
        {
            return (float)S0;
        }
        public void set_DisplayRotate(float value)
        {
            this.<DisplayRotate>k__BackingField = ;
        }
        public double get_Precision()
        {
            return (double)D0;
        }
        public void set_Precision(double value)
        {
            this.mPrecision = ;
            mem[1152921510223728460] = R3;
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
        public virtual FerrPoly2Tri.TriangulationMode get_TriangulationMode()
        {
        
        }
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
            
            23000707 = mem[536895999];
            if(((0 + (index) << 2) + 16 + 180) < 23000707)
            {
                    return;
            }
            
            var val_2 = (0 + (index) << 2) + 16 + 100;
            val_2 = val_2 + (23000707 << 2);
            if((((0 + (index) << 2) + 16 + 100 + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    (0 + (index) << 2) + 16 = 0;
            }
        
        }
        public void set_Item(int index, FerrPoly2Tri.TriangulationPoint value)
        {
            this.set_Item(index:  index, value:  value);
        }
        public PointSet(System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> bounds)
        {
            FerrPoly2Tri.TriangulationPoint val_4;
            var val_7;
            bool val_8;
            536874521 = new System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationPoint>();
            this.mPointMap = 536874521;
            val_7 = 536895819;
            if(((mem[536896006] & true) == 0) && (mem[536895935] == 0))
            {
                    val_7 = 536895819;
            }
            
            this.mPrecision = mem[536895911];
            List.Enumerator<T> val_2 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_6;
            }
            
            bool val_5 = this.Add(p:  val_4, idx:  0, constrainToBounds:  false);
            R7.AddPoint(p:  val_4);
            goto label_8;
            label_6:
            Dispose();
            val_8 = mem[536892072];
            if((val_8 & true) == 0)
            {
                    val_8 = mem[536892001];
            }
            
            double val_6 = this.CalculateEpsilon();
            mem[1152921510224748712] = this;
            mem[1152921510224748704] = 2;
        }
        private System.Collections.Generic.IEnumerator<FerrPoly2Tri.TriangulationPoint> System.Collections.Generic.IEnumerable<FerrPoly2Tri.TriangulationPoint>.GetEnumerator()
        {
            536895827 = new FerrPoly2Tri.TriangulationPointEnumerator(points:  1323050512);
        }
        public int IndexOf(FerrPoly2Tri.TriangulationPoint p)
        {
            if(this != 0)
            {
                    return this.IndexOf(item:  p);
            }
            
            return this.IndexOf(item:  p);
        }
        public override void Add(FerrPoly2Tri.Point2D p)
        {
            var val_2;
            var val_3;
            val_2 = 23000712;
            val_3 = 0;
            if(p != 0)
            {
                    if(((FerrPoly2Tri.Point2D.__il2cppRuntimeField_typeHierarchy + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    p = 0;
            }
            
                val_3 = p;
            }
            
            bool val_1 = this.Add(p:  0, idx:  0, constrainToBounds:  false);
        }
        public virtual void Add(FerrPoly2Tri.TriangulationPoint p)
        {
            bool val_1 = this.Add(p:  p, idx:  0, constrainToBounds:  false);
        }
        protected override void Add(FerrPoly2Tri.Point2D p, int idx, bool constrainToBounds)
        {
            var val_2;
            var val_3;
            val_2 = p;
            val_3 = 0;
            if(val_2 != 0)
            {
                    if(((FerrPoly2Tri.Point2D.__il2cppRuntimeField_typeHierarchy + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    val_2 = 0;
            }
            
                val_3 = val_2;
            }
            
            bool val_1 = this.Add(p:  0, idx:  idx, constrainToBounds:  constrainToBounds);
        }
        protected bool Add(FerrPoly2Tri.TriangulationPoint p, int idx, bool constrainToBounds)
        {
            var val_3;
            var val_4;
            val_3 = this;
            if(p == 0)
            {
                goto label_1;
            }
            
            if(constrainToBounds != false)
            {
                    bool val_1 = this.ConstrainPointToBounds(p:  p);
            }
            
            val_4 = 1;
            if((this.mPointMap.ContainsKey(key:  p.mVertexCode)) == true)
            {
                    return (bool)val_4;
            }
            
            this.mPointMap.Add(key:  p.mVertexCode, value:  p);
            if(idx <= 1)
            {
                goto label_7;
            }
            
            this.Insert(index:  idx, item:  p);
            return (bool)val_4;
            label_1:
            val_4 = 0;
            return (bool)val_4;
            label_7:
            this.Add(item:  p);
            return (bool)val_4;
        }
        public override void AddRange(System.Collections.Generic.IEnumerator<FerrPoly2Tri.Point2D> iter, FerrPoly2Tri.Point2DList.WindingOrderType windingOrder)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_3 = 23000715;
            if(iter == 0)
            {
                    return;
            }
            
            val_4 = 0;
            val_3 = 0;
            val_4 = val_4 + 1;
            val_3 = (uint)val_4 & 65535;
            val_5 = iter;
            goto label_6;
            label_15:
            val_3 = 0;
            val_4 = 0;
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            val_6 = iter;
            label_6:
            val_3 = 0;
            val_4 = 0;
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            val_7 = iter;
            if(iter != 0)
            {
                goto label_15;
            }
        
        }
        public virtual bool AddRange(System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> points)
        {
            FerrPoly2Tri.TriangulationPoint val_2;
            var val_6;
            List.Enumerator<T> val_1 = GetEnumerator();
            val_6 = 1;
            goto label_2;
            label_3:
            val_6 = val_6 & (this.Add(p:  val_2, idx:  0, constrainToBounds:  false));
            label_2:
            if(MoveNext() == true)
            {
                goto label_3;
            }
            
            Dispose();
            return (bool)val_6;
        }
        public bool TryGetPoint(double x, double y, out FerrPoly2Tri.TriangulationPoint p)
        {
            FerrPoly2Tri.TriangulationPoint val_1;
            return this.mPointMap.TryGetValue(key:  FerrPoly2Tri.TriangulationPoint.CreateVertexCode(x:  x, y:  y, precision:  null), value: out  val_1);
        }
        public void Insert(int idx, FerrPoly2Tri.TriangulationPoint item)
        {
            this.Insert(index:  idx, item:  item);
        }
        public override bool Remove(FerrPoly2Tri.Point2D p)
        {
            if(this != 0)
            {
                    return this.Remove(item:  p);
            }
            
            return this.Remove(item:  p);
        }
        public bool Remove(FerrPoly2Tri.TriangulationPoint p)
        {
            if(this != 0)
            {
                    return this.Remove(item:  p);
            }
            
            return this.Remove(item:  p);
        }
        public override void RemoveAt(int idx)
        {
            if(idx < 0)
            {
                    return;
            }
            
            if(this.Count <= idx)
            {
                    return;
            }
            
            this.RemoveAt(index:  idx);
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
        protected bool ConstrainPointToBounds(FerrPoly2Tri.Point2D p)
        {
            bool val_5;
            var val_6;
            val_5 = mem[536890482];
            if((val_5 & true) == 0)
            {
                    val_5 = mem[536890411];
            }
            
            double val_4 = System.Math.Min(val1:  System.Math.Max(val1:  System.Math.Min(val1:  System.Math.Max(val1:  null, val2:  null), val2:  null), val2:  null), val2:  null);
            if(typeof(FerrPoly2Tri.Point2D).__il2cppRuntimeField_FC != 0)
            {
                    val_6 = 1;
            }
            
            return (bool);
        }
        protected bool ConstrainPointToBounds(FerrPoly2Tri.TriangulationPoint p)
        {
            bool val_5;
            var val_6;
            val_5 = mem[536890482];
            if((val_5 & true) == 0)
            {
                    val_5 = mem[536890411];
            }
            
            double val_4 = System.Math.Min(val1:  System.Math.Max(val1:  System.Math.Min(val1:  System.Math.Max(val1:  null, val2:  null), val2:  null), val2:  null), val2:  null);
            if(typeof(FerrPoly2Tri.TriangulationPoint).__il2cppRuntimeField_FC != 0)
            {
                    val_6 = 1;
            }
            
            return (bool);
        }
        public virtual void AddTriangle(FerrPoly2Tri.DelaunayTriangle t)
        {
            var val_2;
            var val_3;
            var val_2 = 0;
            val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = (uint)val_2 & 65535;
            val_3 = this.<Triangles>k__BackingField;
            goto mem[(1152921504681820160 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public void AddTriangles(System.Collections.Generic.IEnumerable<FerrPoly2Tri.DelaunayTriangle> list)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_5 = 23000727;
            val_6 = 0;
            val_5 = 0;
            val_6 = val_6 + 1;
            val_5 = (uint)val_6 & 65535;
            val_7 = list;
            label_17:
            val_6 = 0;
            val_5 = 0;
            val_6 = val_6 + 1;
            val_5 = (uint)val_6 & 65535;
            val_8 = list;
            if(list == 0)
            {
                goto label_11;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_9 = list;
            goto label_17;
            label_11:
            if(list != 0)
            {
                    val_6 = 0;
                val_6 = val_6 + 1;
                val_10 = list;
            }
            
            if(1 == 0)
            {
                    return;
            }
            
            var val_5 = 1 - 1;
        }
        public void ClearTriangles()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.<Triangles>k__BackingField;
            goto mem[(1152921504681820160 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
        public virtual bool Initialize()
        {
            return true;
        }
        public virtual void Prepare(FerrPoly2Tri.TriangulationContext tcx)
        {
            var val_3;
            System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> val_4;
            var val_5;
            var val_6;
            val_3 = this;
            val_4 = this.<Triangles>k__BackingField;
            if(val_4 != 0)
            {
                    val_3 = 0;
                val_3 = val_3 + 1;
                val_5 = val_4;
            }
            else
            {
                    var val_3 = 0;
                val_3 = val_3 + 1;
                val_6 = this;
                val_4 = this;
                536877843 = new System.Collections.Generic.List<SingleRange>(capacity:  1325668624);
                this.<Triangles>k__BackingField = 536877843;
            }
            
            tcx.Points.AddRange(collection:  1325668624);
        }
    
    }

}
