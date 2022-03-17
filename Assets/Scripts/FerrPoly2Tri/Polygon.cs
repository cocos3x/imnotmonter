using UnityEngine;

namespace FerrPoly2Tri
{
    public class Polygon : Point2DList, ITriangulatable, IEnumerable<FerrPoly2Tri.TriangulationPoint>, IEnumerable, IList<FerrPoly2Tri.TriangulationPoint>, ICollection<FerrPoly2Tri.TriangulationPoint>
    {
        // Fields
        protected System.Collections.Generic.Dictionary<uint, FerrPoly2Tri.TriangulationPoint> mPointMap;
        protected System.Collections.Generic.List<FerrPoly2Tri.DelaunayTriangle> mTriangles;
        private string <FileName>k__BackingField;
        private bool <DisplayFlipX>k__BackingField;
        private bool <DisplayFlipY>k__BackingField;
        private float <DisplayRotate>k__BackingField;
        private double mPrecision;
        protected System.Collections.Generic.List<FerrPoly2Tri.Polygon> mHoles;
        protected System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> mSteinerPoints;
        protected FerrPoly2Tri.PolygonPoint _last;
        
        // Properties
        public System.Collections.Generic.IList<FerrPoly2Tri.TriangulationPoint> Points { get; }
        public System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> Triangles { get; }
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
        public FerrPoly2Tri.TriangulationPoint Item { get; set; }
        public System.Collections.Generic.IList<FerrPoly2Tri.Polygon> Holes { get; }
        
        // Methods
        public System.Collections.Generic.IList<FerrPoly2Tri.TriangulationPoint> get_Points()
        {
        
        }
        public System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> get_Triangles()
        {
        
        }
        public FerrPoly2Tri.TriangulationMode get_TriangulationMode()
        {
        
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
            mem[1152921510206668172] = R3;
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
            
            23000739 = mem[536895999];
            if(((0 + (index) << 2) + 16 + 180) < 23000739)
            {
                    return;
            }
            
            var val_2 = (0 + (index) << 2) + 16 + 100;
            val_2 = val_2 + (23000739 << 2);
            if((((0 + (index) << 2) + 16 + 100 + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    (0 + (index) << 2) + 16 = 0;
            }
        
        }
        public void set_Item(int index, FerrPoly2Tri.TriangulationPoint value)
        {
            this.set_Item(index:  index, value:  value);
        }
        public System.Collections.Generic.IList<FerrPoly2Tri.Polygon> get_Holes()
        {
        
        }
        public Polygon(System.Collections.Generic.IList<FerrPoly2Tri.PolygonPoint> points)
        {
            var val_4;
            var val_5;
            var val_6;
            536874521 = new System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationPoint>();
            this.mPointMap = 536874521;
            val_4 = 22716056;
            val_5 = 536895819;
            if(((mem[536896006] & true) == 0) && (mem[536895935] == 0))
            {
                    val_5 = 536895819;
            }
            
            this.mPrecision = mem[536895911];
            val_4 = 0;
            val_4 = val_4 + 1;
            val_6 = points;
            if(points > 2)
            {
                    this.AddRange(points:  points, windingOrder:  2);
                return;
            }
            
            22709196 = new System.ArgumentException(message:  22789080, paramName:  22804684);
        }
        public Polygon(System.Collections.Generic.IEnumerable<FerrPoly2Tri.PolygonPoint> points)
        {
            if(points == 0)
            {
                    TSource[] val_1 = System.Linq.Enumerable.ToArray<System.Type>(source:  points);
                points = points;
            }
            
            if(this != 0)
            {
                    return;
            }
        
        }
        public Polygon(FerrPoly2Tri.PolygonPoint[] points)
        {
        
        }
        private System.Collections.Generic.IEnumerator<FerrPoly2Tri.TriangulationPoint> System.Collections.Generic.IEnumerable<FerrPoly2Tri.TriangulationPoint>.GetEnumerator()
        {
            536895827 = new FerrPoly2Tri.TriangulationPointEnumerator(points:  1306304336);
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
        
        }
        public void Add(FerrPoly2Tri.TriangulationPoint p)
        {
        
        }
        public void Add(FerrPoly2Tri.PolygonPoint p)
        {
        
        }
        protected override void Add(FerrPoly2Tri.Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
        {
            System.Collections.Generic.Dictionary<System.UInt32, FerrPoly2Tri.TriangulationPoint> val_2;
            float val_3;
            if(p == 0)
            {
                    return;
            }
            
            if(((FerrPoly2Tri.Point2D.__il2cppRuntimeField_typeHierarchy + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    p = 0;
            }
            
            val_2 = this.mPointMap;
            val_3 = 0f;
            if((val_2.ContainsKey(key:  0)) == true)
            {
                    return;
            }
            
            val_3 = this.mPointMap;
            val_2 = 0f;
            val_3.Add(key:  0, value:  0);
            this.Add(p:  p, idx:  idx, bCalcWindingOrderAndEpsilon:  bCalcWindingOrderAndEpsilon);
            if(((FerrPoly2Tri.Point2D.__il2cppRuntimeField_typeHierarchy + (mem[536892147]) << 2) + -4) != 536891967)
            {
                    p = 0;
            }
        
        }
        public void AddRange(System.Collections.Generic.IList<FerrPoly2Tri.PolygonPoint> points, FerrPoly2Tri.Point2DList.WindingOrderType windingOrder)
        {
            WindingOrderType val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            val_10 = windingOrder;
            val_11 = 23000746;
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
                    mem[1152921510208872544] = val_10;
            }
            
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_13 = points;
            WindingOrderType val_4 = val_10 - 2;
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) != 536875903)
            {
                    val_14 = 1;
            }
            
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) != 536875903)
            {
                    -2 = 1;
            }
            
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) != 536875903)
            {
                    val_10 - val_10 = 1;
            }
            
            if(points >= 1)
            {
                    do
            {
                val_15 = 0;
                if(1 != 0)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_16 = points;
            }
            
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_17 = points;
                val_14 = points;
                val_10 = 0 + 1;
            }
            while(val_10 != points);
            
            }
            
            double val_8 = this.GetSignedArea();
            if(typeof(FerrPoly2Tri.Polygon).__il2cppRuntimeField_15C <= 2)
            {
                    1 = 2;
            }
            
            mem[1152921510208872544] = 0;
            double val_9 = this.CalculateEpsilon();
            mem[1152921510208872552] = this;
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
            var val_17;
            val_10 = windingOrder;
            val_11 = 23000747;
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
                    mem[1152921510209000928] = val_10;
            }
            
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_13 = points;
            WindingOrderType val_4 = val_10 - 2;
            if((Klass->__il2cppRuntimeField_interfaceOffsets[].interfaceType) != 536875919)
            {
                    val_14 = 1;
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
                val_15 = 0;
                if(1 != 0)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                val_16 = points;
            }
            
                var val_12 = 0;
                val_12 = val_12 + 1;
                val_17 = points;
                val_14 = points;
                val_10 = 0 + 1;
            }
            while(val_10 != points);
            
            }
            
            double val_8 = this.GetSignedArea();
            if(typeof(FerrPoly2Tri.Polygon).__il2cppRuntimeField_15C <= 2)
            {
                    1 = 2;
            }
            
            mem[1152921510209000928] = 0;
            double val_9 = this.CalculateEpsilon();
            mem[1152921510209000936] = this;
        }
        public void Insert(int idx, FerrPoly2Tri.TriangulationPoint p)
        {
        
        }
        public bool Remove(FerrPoly2Tri.TriangulationPoint p)
        {
            return this.Remove(p:  p);
        }
        public void RemovePoint(FerrPoly2Tri.PolygonPoint p)
        {
            var val_4;
            FerrPoly2Tri.PolygonPoint val_5;
            if(p != 0)
            {
                    val_5 = p.<Next>k__BackingField;
            }
            else
            {
                    val_5 = 83886592;
            }
            
            p.<Previous>k__BackingField.<Next>k__BackingField = val_5;
            mem[83886632] = p.<Previous>k__BackingField;
            bool val_1 = mem[83886632].Remove(item:  p);
            p.Clear();
            List.Enumerator<T> val_2 = GetEnumerator();
            label_13:
            if(MoveNext() == false)
            {
                goto label_8;
            }
            
            if(val_4 != 0)
            {
                    if((val_4 + 180) >= mem[536892147])
            {
                    var val_5 = val_4 + 100;
                val_5 = val_5 + (mem[536892147] << 2);
                if(((val_4 + 100 + (mem[536892147]) << 2) + -4) == 536891967)
            {
                goto label_14;
            }
            
            }
            
            }
            
            label_14:
            val_4 + 180.AddPoint(p:  0);
            goto label_13;
            label_8:
            Dispose();
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
        public void AddSteinerPoint(FerrPoly2Tri.TriangulationPoint point)
        {
            if(this.mSteinerPoints == 0)
            {
                    23000751 = 536878451;
                23000751 = new System.Collections.Generic.List<Page>();
                this.mSteinerPoints = 23000751;
            }
            
            0.Add(item:  point);
        }
        public void AddSteinerPoints(System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> points)
        {
            if(this.mSteinerPoints == 0)
            {
                    23000752 = 536878451;
                23000752 = new System.Collections.Generic.List<Page>();
                this.mSteinerPoints = 23000752;
            }
            
            0.AddRange(collection:  points);
        }
        public void ClearSteinerPoints()
        {
            if(this.mSteinerPoints == 0)
            {
                    return;
            }
            
            this.mSteinerPoints.Clear();
        }
        public void AddHole(FerrPoly2Tri.Polygon poly)
        {
            if(this.mHoles == 0)
            {
                    23000754 = 536878171;
                23000754 = new System.Collections.Generic.List<Page>();
                this.mHoles = 23000754;
            }
            
            0.Add(item:  poly);
        }
        public void AddTriangle(FerrPoly2Tri.DelaunayTriangle t)
        {
            this.mTriangles.Add(item:  t);
        }
        public void AddTriangles(System.Collections.Generic.IEnumerable<FerrPoly2Tri.DelaunayTriangle> list)
        {
            this.mTriangles.AddRange(collection:  list);
        }
        public void ClearTriangles()
        {
            if(this.mTriangles == 0)
            {
                    return;
            }
            
            this.mTriangles.Clear();
        }
        public bool IsPointInside(FerrPoly2Tri.TriangulationPoint p)
        {
            return FerrPoly2Tri.PolygonUtil.PointInPolygon2D(polygon:  1308876112, p:  p);
        }
        public void Prepare(FerrPoly2Tri.TriangulationContext tcx)
        {
            System.Collections.Generic.IEnumerable<T> val_11;
            float val_17;
            var val_18;
            FerrPoly2Tri.Polygon val_19;
            System.Collections.Generic.IEnumerable<T> val_20;
            if(this.mTriangles != 0)
            {
                    this.mTriangles.Clear();
                val_17 = 1152921510210826968;
            }
            else
            {
                    val_17 = this;
                536877843 = new System.Collections.Generic.List<SingleRange>(capacity:  mem[23000770]);
                this.mTriangles = 536877843;
            }
            
            val_18 = 1;
            goto label_4;
            label_7:
            FerrPoly2Tri.TriangulationPoint val_2 = this.Item[mem[23000770]];
            FerrPoly2Tri.TriangulationPoint val_3 = this.Item[1];
            val_18 = 2;
            label_4:
            var val_19 = mem[1152921510210826972];
            val_19 = val_19 - 1;
            if((val_18 - 1) < val_19)
            {
                goto label_7;
            }
            
            val_19 = this;
            FerrPoly2Tri.TriangulationPoint val_5 = this.Item[0];
            FerrPoly2Tri.TriangulationPoint val_8 = this.Item[this.Count - 1];
            if(tcx != 0)
            {
                
            }
            
            tcx.Points.AddRange(collection:  1309012688);
            if(mem[1152921510210827024] == 0)
            {
                goto label_11;
            }
            
            List.Enumerator<T> val_9 = GetEnumerator();
            val_17 = 4.018955E-38f;
            label_18:
            if(MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_21 = 1;
            label_16:
            var val_20 = val_11 + 8 + 12;
            int val_12 = val_21 - 1;
            val_20 = val_20 - 1;
            if(val_12 >= val_20)
            {
                goto label_15;
            }
            
            FerrPoly2Tri.TriangulationPoint val_13 = val_11.Item[val_12];
            FerrPoly2Tri.TriangulationPoint val_14 = val_11.Item[1];
            val_21 = val_21 + 1;
            goto label_16;
            label_15:
            FerrPoly2Tri.TriangulationPoint val_15 = val_11.Item[0];
            FerrPoly2Tri.TriangulationPoint val_18 = val_11.Item[val_11.Count - 1];
            tcx.Points.AddRange(collection:  val_11);
            goto label_18;
            label_12:
            Dispose();
            val_19 = this;
            label_11:
            val_20 = mem[1152921510210827028];
            if(val_20 == 0)
            {
                    return;
            }
            
            if(tcx == 0)
            {
                    val_20 = mem[1152921510210827028];
            }
            
            tcx.Points.AddRange(collection:  val_20);
        }
    
    }

}
