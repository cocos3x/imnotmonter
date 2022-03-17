using UnityEngine;

namespace FerrPoly2Tri
{
    public class Point2DList : IEnumerable<FerrPoly2Tri.Point2D>, IEnumerable, IList<FerrPoly2Tri.Point2D>, ICollection<FerrPoly2Tri.Point2D>
    {
        // Fields
        public static readonly int kMaxPolygonVertices;
        public static readonly double kLinearSlop;
        public static readonly double kAngularSlop;
        protected System.Collections.Generic.List<FerrPoly2Tri.Point2D> mPoints;
        protected FerrPoly2Tri.Rect2D mBoundingBox;
        protected FerrPoly2Tri.Point2DList.WindingOrderType mWindingOrder;
        protected double mEpsilon;
        
        // Properties
        public FerrPoly2Tri.Rect2D BoundingBox { get; }
        public FerrPoly2Tri.Point2DList.WindingOrderType WindingOrder { get; set; }
        public double Epsilon { get; }
        public FerrPoly2Tri.Point2D Item { get; set; }
        public int Count { get; }
        public virtual bool IsReadOnly { get; }
        
        // Methods
        public FerrPoly2Tri.Rect2D get_BoundingBox()
        {
        
        }
        public FerrPoly2Tri.Point2DList.WindingOrderType get_WindingOrder()
        {
        
        }
        public void set_WindingOrder(FerrPoly2Tri.Point2DList.WindingOrderType value)
        {
            System.Collections.Generic.List<FerrPoly2Tri.Point2D> val_2;
            Point2DList.WindingOrderType val_3;
            val_2 = 23000671;
            val_3 = this.mWindingOrder;
            if(val_3 == 2)
            {
                    double val_1 = this.GetSignedArea();
                if(val_3 <= 2)
            {
                    1 = 2;
            }
            
                if(val_3 < 0)
            {
                    val_3 = 0;
            }
            
                this.mWindingOrder = val_3;
            }
            
            if(val_3 == value)
            {
                    return;
            }
            
            val_2 = this.mPoints;
            val_2.Reverse();
            this.mWindingOrder = value;
        }
        public double get_Epsilon()
        {
            return (double)D0;
        }
        public FerrPoly2Tri.Point2D get_Item(int index)
        {
            if(true <= index)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 2);
        }
        public void set_Item(int index, FerrPoly2Tri.Point2D value)
        {
            this.mPoints.set_Item(index:  index, value:  value);
        }
        public int get_Count()
        {
            if(this.mPoints != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public virtual bool get_IsReadOnly()
        {
            return false;
        }
        public Point2DList()
        {
            var val_3;
            536878157 = new System.Collections.Generic.List<Page>();
            this.mPoints = 536878157;
            FerrPoly2Tri.Rect2D val_2 = 536892565;
            val_2 = new FerrPoly2Tri.Rect2D();
            mem[1152921510251500316] = val_2;
            mem[1152921510251500320] = 2;
            val_3 = 536890297;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_3 = 536890297;
            }
            
            this.mEpsilon = mem[536890389];
        }
        public Point2DList(int capacity)
        {
            var val_3;
            536878157 = new System.Collections.Generic.List<Page>();
            this.mPoints = 536878157;
            FerrPoly2Tri.Rect2D val_2 = 536892565;
            val_2 = new FerrPoly2Tri.Rect2D();
            mem[1152921510251616412] = val_2;
            mem[1152921510251616416] = 2;
            val_3 = 536890297;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_3 = 536890297;
            }
            
            this.mEpsilon = mem[536890389];
            this.mPoints.Capacity = capacity;
        }
        public Point2DList(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> l)
        {
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            536878157 = new System.Collections.Generic.List<Page>();
            val_4 = this;
            this.mPoints = 536878157;
            FerrPoly2Tri.Rect2D val_2 = 536892565;
            val_2 = new FerrPoly2Tri.Rect2D();
            mem[1152921510251736604] = val_2;
            mem[1152921510251736608] = 2;
            val_5 = 22713024;
            val_6 = 536890297;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_6 = 536890297;
            }
            
            this.mEpsilon = mem[536890389];
            val_4 = 0;
            val_5 = 0;
            val_4 = val_4 + 1;
            val_5 = (uint)val_4 & 65535;
            val_7 = l;
            goto typeof(FerrPoly2Tri.Point2DList).__il2cppRuntimeField_16C;
        }
        public Point2DList(FerrPoly2Tri.Point2DList l)
        {
            var val_6;
            FerrPoly2Tri.Point2DList val_3 = l;
            536878157 = new System.Collections.Generic.List<Page>();
            this.mPoints = 536878157;
            FerrPoly2Tri.Rect2D val_2 = 536892565;
            val_2 = new FerrPoly2Tri.Rect2D();
            mem[1152921510251864988] = val_2;
            mem[1152921510251864992] = 2;
            val_6 = 536890297;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_6 = 536890297;
            }
            
            this.mEpsilon = mem[536890389];
            val_3 = new System.Object();
            int val_4 = val_3.Count;
            if(val_4 >= 1)
            {
                    var val_6 = 0;
                do
            {
                FerrPoly2Tri.Point2D val_5 = val_3.Item[0];
                this.mPoints.Add(item:  val_3);
                val_6 = val_6 + 1;
            }
            while(val_4 != val_6);
            
            }
            
            mem[1152921510251864988].Set(b:  l.mBoundingBox);
            mem[1152921510251865000] = l.mEpsilon;
            mem[1152921510251864992] = l.mWindingOrder;
        }
        public override string ToString()
        {
            var val_8;
            System.Text.StringBuilder val_1 = 536894635;
            val_8 = 0;
            val_1 = new System.Text.StringBuilder();
            if(this.Count >= 1)
            {
                    do
            {
                FerrPoly2Tri.Point2D val_3 = this.Item[0];
                System.Text.StringBuilder val_4 = val_1.Append(value:  1350174992);
                int val_5 = this.Count;
                val_5 = val_5 - 1;
                if(val_8 < val_5)
            {
                    System.Text.StringBuilder val_6 = val_1.Append(value:  -1610612561);
            }
            
                val_8 = val_8 + 1;
            }
            while(val_8 < this.Count);
            
            }
            
            if(val_1 == 0)
            {
                
            }
        
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            List.Enumerator<T> val_1 = GetEnumerator();
        }
        private System.Collections.Generic.IEnumerator<FerrPoly2Tri.Point2D> System.Collections.Generic.IEnumerable<FerrPoly2Tri.Point2D>.GetEnumerator()
        {
            mem[536891895] = 0;
            536891883 = new System.Object();
            mem[536891891] = this.mPoints;
        }
        public void Clear()
        {
            var val_1;
            this.mPoints.Clear();
            this.mBoundingBox.Clear();
            val_1 = 536890297;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_1 = 536890297;
            }
            
            this.mWindingOrder = 2;
            this.mEpsilon = mem[536890389];
        }
        public int IndexOf(FerrPoly2Tri.Point2D p)
        {
            if(this.mPoints != 0)
            {
                    return this.mPoints.IndexOf(item:  p);
            }
            
            return this.mPoints.IndexOf(item:  p);
        }
        public virtual void Add(FerrPoly2Tri.Point2D p)
        {
        
        }
        protected virtual void Add(FerrPoly2Tri.Point2D p, int idx, bool bCalcWindingOrderAndEpsilon)
        {
            if(idx > 1)
            {
                    this.mPoints.Insert(index:  idx, item:  p);
            }
            else
            {
                    this.mPoints.Add(item:  p);
            }
            
            this.mBoundingBox.AddPoint(p:  p);
            if(bCalcWindingOrderAndEpsilon == false)
            {
                    return;
            }
            
            if(this.mWindingOrder == 2)
            {
                    double val_1 = this.GetSignedArea();
                if(this.mWindingOrder <= 2)
            {
                    1 = 2;
            }
            
                this.mWindingOrder = 0;
            }
            
            double val_2 = this.CalculateEpsilon();
            this.mEpsilon = this;
        }
        public virtual void AddRange(FerrPoly2Tri.Point2DList l)
        {
            List.Enumerator<T> val_1 = GetEnumerator();
        }
        public virtual void AddRange(System.Collections.Generic.IEnumerator<FerrPoly2Tri.Point2D> iter, FerrPoly2Tri.Point2DList.WindingOrderType windingOrder)
        {
            Point2DList.WindingOrderType val_11;
            Point2DList.WindingOrderType val_12;
            FerrPoly2Tri.Point2D val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            val_11 = windingOrder;
            if(iter == 0)
            {
                    return;
            }
            
            val_12 = this.mWindingOrder;
            if(val_12 == 2)
            {
                    int val_1 = this.Count;
                if(val_1 == 0)
            {
                    this.mWindingOrder = val_11;
                val_1 = val_11;
            }
            
                if(val_1 != 0)
            {
                    val_12 = this.mWindingOrder;
            }
            
            }
            
            if(val_1 != 0)
            {
                    val_12 - 2 = 1;
            }
            
            WindingOrderType val_3 = val_11 - 2;
            if(val_1 != 0)
            {
                    val_14 = 1;
            }
            
            if(val_1 != 0)
            {
                    val_12 - val_11 = 1;
            }
            
            val_15 = 1 & 1;
            val_14 = 0;
            val_14 = val_14 + 1;
            val_16 = iter;
            goto label_8;
            label_25:
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_17 = iter;
            if((1 & val_15) != 0)
            {
                    this.mPoints.Insert(index:  windingOrder, item:  iter);
            }
            else
            {
                    this.mPoints.Add(item:  iter);
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_15 = (uint)val_13 & 65535;
            val_18 = iter;
            val_14 = iter;
            this.mBoundingBox.AddPoint(p:  val_14);
            label_8:
            val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = (uint)val_14 & 65535;
            val_19 = iter;
            if(iter != 0)
            {
                goto label_25;
            }
            
            if(val_11 == 2)
            {
                    val_11 = this.mWindingOrder;
            }
            
            if(val_11 == 2)
            {
                    double val_10 = this.GetSignedArea();
                if(val_11 <= 2)
            {
                    1 = 2;
            }
            
                this.mWindingOrder = 0;
            }
            
            double val_11 = this.CalculateEpsilon();
            this.mEpsilon = this;
        }
        public virtual void Insert(int idx, FerrPoly2Tri.Point2D item)
        {
        
        }
        public virtual bool Remove(FerrPoly2Tri.Point2D p)
        {
            if((this.mPoints.Remove(item:  p)) == false)
            {
                    return (bool)0;
            }
            
            this.CalculateBounds();
            double val_2 = this.CalculateEpsilon();
            this.mEpsilon = this;
            0 = 1;
            return (bool)0;
        }
        public virtual void RemoveAt(int idx)
        {
            if(idx < 0)
            {
                    return;
            }
            
            if(this.Count <= idx)
            {
                    return;
            }
            
            23000688 = this.mPoints;
            23000688.RemoveAt(index:  idx);
            this.CalculateBounds();
            double val_2 = this.CalculateEpsilon();
            this.mEpsilon = this;
        }
        public virtual void RemoveRange(int idxStart, int count)
        {
            if(idxStart < 0)
            {
                    return;
            }
            
            if(count == 0)
            {
                    return;
            }
            
            if(this.Count <= idxStart)
            {
                    return;
            }
            
            23000689 = this.mPoints;
            23000689.RemoveRange(index:  idxStart, count:  count);
            this.CalculateBounds();
            double val_2 = this.CalculateEpsilon();
            this.mEpsilon = this;
        }
        public bool Contains(FerrPoly2Tri.Point2D p)
        {
            if(this.mPoints != 0)
            {
                    return this.mPoints.Contains(item:  p);
            }
            
            return this.mPoints.Contains(item:  p);
        }
        public void CopyTo(FerrPoly2Tri.Point2D[] array, int arrayIndex)
        {
            var val_5 = 0;
            int val_3 = System.Math.Min(val1:  this.Count, val2:  536890295 - arrayIndex);
            if(val_3 < 1)
            {
                    return;
            }
            
            do
            {
                if((mem[1152921510253831704] + 12) <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                var val_5 = mem[1152921510253831704] + 8;
                val_5 = val_5 + 0;
                int val_4 = arrayIndex + val_5;
                var val_6 = array[arrayIndex][16];
                var val_7 = array[arrayIndex][16];
                mem2[0] = (mem[1152921510253831704] + 8 + 0) + 16;
                val_5 = val_5 + 1;
            }
            while(val_3 != val_5);
        
        }
        public void CalculateBounds()
        {
            FerrPoly2Tri.Point2D val_3;
            this.mBoundingBox.Clear();
            List.Enumerator<T> val_1 = GetEnumerator();
            label_5:
            if(MoveNext() == false)
            {
                goto label_3;
            }
            
            this.mBoundingBox.AddPoint(p:  val_3);
            goto label_5;
            label_3:
            Dispose();
        }
        public double CalculateEpsilon()
        {
            var val_5;
            bool val_6;
            double val_1 = this.mBoundingBox.Width;
            val_5 = 536890297;
            val_6 = mem[536890484];
            if((val_6 & true) == 0)
            {
                    val_6 = mem[536890413];
                if(val_6 == 0)
            {
                    val_5 = 536890297;
            }
            
            }
            
            double val_5 = 1.85674631709461E-314;
            val_5 = this.mBoundingBox * val_5;
            return (double)System.Math.Max(val1:  System.Math.Min(val1:  this.mBoundingBox.Height, val2:  null), val2:  null);
        }
        public FerrPoly2Tri.Point2DList.WindingOrderType CalculateWindingOrder()
        {
            double val_1 = this.GetSignedArea();
            if(<0)
            {
                    this = 0;
                return;
            }
            
            if()
            {
                    1 = 2;
            }
        
        }
        public int NextIndex(int index)
        {
            int val_1 = this.Count;
            val_1 = val_1 - 1;
            val_1 = val_1 - index;
            if()
            {
                    val_1 = index + 1;
            }
            
            return val_1;
        }
        public int PreviousIndex(int index)
        {
            if(index == 0)
            {
                    int val_1 = this.Count;
            }
            
            val_1 = val_1 - 1;
            return (int)val_1;
        }
        public double GetSignedArea()
        {
            var val_8;
            if(this.Count < 1)
            {
                    return (double)D0;
            }
            
            do
            {
                int val_2 = this.Count;
                FerrPoly2Tri.Point2D val_3 = this.Item[0];
                FerrPoly2Tri.Point2D val_5 = this.Item[val_2];
                FerrPoly2Tri.Point2D val_6 = this.Item[0];
                FerrPoly2Tri.Point2D val_7 = this.Item[val_2];
            }
            while((0 + 1) < this.Count);
            
            val_8 = D8 * 0.5;
            return (double)D0;
        }
        public double GetArea()
        {
            if(this.Count < 1)
            {
                    return (double)D0;
            }
            
            do
            {
                int val_2 = this.Count;
                FerrPoly2Tri.Point2D val_3 = this.Item[0];
                FerrPoly2Tri.Point2D val_5 = this.Item[val_2];
                FerrPoly2Tri.Point2D val_6 = this.Item[0];
                FerrPoly2Tri.Point2D val_7 = this.Item[val_2];
            }
            while((0 + 1) < this.Count);
            
            double val_9 = 0.5;
            val_9 = D8 * val_9;
            return (double)D0;
        }
        public FerrPoly2Tri.Point2D GetCentroid()
        {
            var val_18;
            int val_19;
            var val_20;
            object val_1 = 536891877;
            val_18 = val_1;
            val_19 = 0;
            val_1 = new System.Object();
            536891877 = new System.Object();
            if(this.Count >= 1)
            {
                    do
            {
                FerrPoly2Tri.Point2D val_4 = this.Item[0];
                int val_5 = this.Count;
                val_19 = val_19 + 1;
                FerrPoly2Tri.Point2D val_6 = this.Item[0];
                FerrPoly2Tri.Point2D val_7 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  1352991248, rhs:  536891877);
                FerrPoly2Tri.Point2D val_8 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  1352991248, rhs:  536891877);
                double val_9 = FerrPoly2Tri.Point2D.Cross(lhs:  1352991248, rhs:  1352991248);
                long val_17 = 1352991248;
                double val_10 = val_17 * 0.5;
                FerrPoly2Tri.Point2D val_11 = FerrPoly2Tri.Point2D.op_Addition(lhs:  536891877, rhs:  1352991248);
                FerrPoly2Tri.Point2D val_12 = FerrPoly2Tri.Point2D.op_Addition(lhs:  536891877, rhs:  1352991248);
                val_17 = val_10 * (7.07331930157069E-315);
                FerrPoly2Tri.Point2D val_13 = FerrPoly2Tri.Point2D.op_Multiply(scalar:  val_9, lhs:  1352991248);
                FerrPoly2Tri.Point2D val_14 = FerrPoly2Tri.Point2D.op_Addition(lhs:  536891877, rhs:  1352991248);
                val_18 = val_18;
                val_20 = D8 + val_10;
            }
            while(val_19 < this.Count);
            
            }
            
            double val_18 = 1;
            val_18 = val_18 / val_20;
            FerrPoly2Tri.Point2D val_16 = FerrPoly2Tri.Point2D.op_Multiply(lhs:  536891877, scalar:  val_9);
        }
        public void Translate(FerrPoly2Tri.Point2D vector)
        {
            if(this.Count < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                FerrPoly2Tri.Point2D val_2 = this.Item[0];
                FerrPoly2Tri.Point2D val_3 = FerrPoly2Tri.Point2D.op_Addition(lhs:  1353107344, rhs:  vector);
                this.set_Item(index:  0, value:  1353107344);
                val_5 = val_5 + 1;
            }
            while(val_5 < this.Count);
        
        }
        public void Scale(FerrPoly2Tri.Point2D value)
        {
            if(this.Count < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                FerrPoly2Tri.Point2D val_2 = this.Item[0];
                FerrPoly2Tri.Point2D val_3 = FerrPoly2Tri.Point2D.op_Multiply(lhs:  1353227536, rhs:  value);
                this.set_Item(index:  0, value:  1353227536);
                val_5 = val_5 + 1;
            }
            while(val_5 < this.Count);
        
        }
        public void Rotate(double radians)
        {
            var val_3;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_6:
            if(MoveNext() == false)
            {
                goto label_4;
            }
            
            double val_4 = R2 * val_3;
            var val_5 = val_3;
            val_5 = R2 * val_5;
            goto label_6;
            label_4:
            Dispose();
        }
        public bool IsDegenerate()
        {
            var val_11;
            FerrPoly2Tri.Point2D val_12;
            FerrPoly2Tri.Point2D val_13;
            val_11 = 0;
            if(this.Count < 3)
            {
                    return (bool)val_11;
            }
            
            if(this.Count < 3)
            {
                    return (bool)val_11;
            }
            
            int val_3 = this.Count;
            if(val_3 < 1)
            {
                    return (bool)val_11;
            }
            
            val_11 = 1;
            do
            {
                if(val_3 == 1)
            {
                    0 = this;
                int val_4 = this.Count;
            }
            
                val_12 = val_4 - 1;
                if(val_4 <= val_12)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_12 = val_12 + (val_12 << 2);
                if(val_12 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13 = 2621443;
                if(((0 + ((val_4 - 1)) << 2) + 16.Equals(p:  2621443, epsilon:  null)) == true)
            {
                    return (bool)val_11;
            }
            
                if(val_12 == 0)
            {
                    val_12 = this;
                int val_6 = this.Count;
            }
            
                int val_7 = val_6 - 1;
                if(val_6 <= val_7)
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_13 = val_13 + (val_7 << 2);
                val_13 = mem[(0 + ((val_6 - 1)) << 2) + 16];
                val_13 = (0 + ((val_6 - 1)) << 2) + 16;
                if(val_13 <= val_12)
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_14 = val_14 + (val_12 << 2);
                val_12 = mem[(0 + ((val_4 - 1)) << 2) + 16];
                val_12 = (0 + ((val_4 - 1)) << 2) + 16;
                if(val_14 <= 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                FerrPoly2Tri.Orientation val_8 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  val_13, pb:  val_12, pc:  2621443);
                if(val_13 == 2)
            {
                    return (bool)val_11;
            }
            
                var val_10 = 4 + 1;
            }
            while((4 - 3) < this.Count);
            
            val_11 = 0;
            return (bool)val_11;
        }
        public bool IsConvex()
        {
            var val_16;
            var val_17;
            if(this.Count >= 1)
            {
                    do
            {
                val_16 = 0;
                if(0 == 0)
            {
                    val_16 = this.Count;
            }
            
                int val_3 = this.Count;
                val_3 = val_3 - 1;
                int val_5 = 0 + 1;
                if(0 != 0)
            {
                    0 - val_3 = val_5;
            }
            
                FerrPoly2Tri.Point2D val_6 = this.Item[0];
                int val_7 = val_16 - 1;
                FerrPoly2Tri.Point2D val_8 = this.Item[val_7];
                FerrPoly2Tri.Point2D val_9 = this.Item[0];
                FerrPoly2Tri.Point2D val_10 = this.Item[val_7];
                FerrPoly2Tri.Point2D val_11 = this.Item[0 - val_3];
                FerrPoly2Tri.Point2D val_12 = this.Item[0];
                long val_18 = 1353616784;
                long val_17 = 1353616784;
                FerrPoly2Tri.Point2D val_13 = this.Item[0 - val_3];
                val_17 = val_17 - 1353616784;
                val_18 = val_18 - 1353616784;
                FerrPoly2Tri.Point2D val_14 = this.Item[0];
                long val_19 = 1353616784;
                val_19 = 1353616784 - val_19;
                val_19 = (1353616784 - 1353616784) * val_19;
                if(this >= 0)
            {
                    0 = 1;
            }
            
                if(0 != 0)
            {
                    val_17 = 0;
                if(0 >= 0)
            {
                    0 = 1;
            }
            
                if(1 != 1)
            {
                    return (bool)val_17;
            }
            
            }
            
            }
            while(val_5 < this.Count);
            
            }
            
            val_17 = 1;
            return (bool)val_17;
        }
        public bool IsSimple()
        {
            var val_9;
            var val_10;
            int val_1 = this.Count;
            if(val_1 < 1)
            {
                goto label_1;
            }
            
            label_13:
            int val_2 = this.Count;
            val_2 = val_2 - 1;
            var val_4 = 0 + 1;
            if(val_1 != 1)
            {
                    val_2 - 0 = val_4;
            }
            
            label_11:
            int val_5 = this.Count;
            int val_6 = this.Count;
            var val_7 = 5 - 4;
            if(val_7 >= val_5)
            {
                goto label_2;
            }
            
            val_6 = val_6 - 1;
            var val_8 = val_7 + 1;
            if(val_7 != val_5)
            {
                    val_6 - val_7 = val_8;
            }
            
            if(val_6 <= 0)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + 0;
            if(((0 + 0) + 16) <= (val_2 - 0))
            {
                    var val_13 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + ((val_2 - 0) << 2);
            val_7 = val_8 - 1;
            if(val_13 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(0 <= (val_6 - val_7))
            {
                    var val_14 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + ((val_6 - val_7) << 2);
            val_9 = 0;
            val_10 = 5 + 1;
            if((FerrPoly2Tri.TriangulationUtil.LinesIntersect2D(ptStart0:  (0 + 0) + 16, ptEnd0:  (0 + ((0 + 1)) << 2) + 16, ptStart1:  1, ptEnd1:  (0 + (((5 - 4) + 1)) << 2) + 16, pIntersectionPt: ref  0, epsilon:  null)) == false)
            {
                goto label_11;
            }
            
            return (bool)val_9;
            label_2:
            val_10 = 5 + 1;
            if(val_4 < val_6)
            {
                goto label_13;
            }
            
            label_1:
            val_9 = 1;
            return (bool)val_9;
        }
        public FerrPoly2Tri.Point2DList.PolygonError CheckPolygon()
        {
            FerrPoly2Tri.Point2DList val_31;
            var val_32;
            var val_33;
            bool val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            val_31 = this;
            val_32 = 1;
            if(this.Count < 3)
            {
                    return;
            }
            
            val_33 = 536891885;
            val_34 = mem[536892072];
            if((val_34 & true) == 0)
            {
                    val_34 = mem[536892001];
                if(val_34 == 0)
            {
                    val_33 = 536891885;
            }
            
            }
            
            if(this.Count > mem[536891977])
            {
                    return;
            }
            
            bool val_3 = this.IsDegenerate();
            if(val_3 == true)
            {
                    val_3 = 64;
            }
            
            if(this.IsSimple() == false)
            {
                    64 = 68;
            }
            
            val_35 = 536890297;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_35 = 536890297;
            }
            
            if(mem[536890413] < 0)
            {
                    val_32 = 64 | 8;
            }
            
            if(val_32 != 4)
            {
                    return;
            }
            
            val_36 = 0;
            if(this.mWindingOrder == 0)
            {
                    val_36 = 1;
                this.WindingOrder = 1;
            }
            
            int val_6 = this.Count;
            val_37 = 536882263;
            FerrPoly2Tri.Point2DList val_8 = 536891885;
            val_38 = val_8;
            val_8 = new FerrPoly2Tri.Point2DList(capacity:  this.Count);
            if(this.Count >= 1)
            {
                    do
            {
                FerrPoly2Tri.Point2D val_10 = this.Item[0];
                FerrPoly2Tri.Point2D val_11 = this.Item[0];
                536891877 = new System.Object();
                mem[536891893] = val_31;
                mem[536891897] = typeof(FerrPoly2Tri.Point2DList).__il2cppRuntimeField_F8;
                mem[536891885] = 1353877648;
                mem[536891889] = 2.524355E-29f;
                int val_13 = this.Count;
                val_13 = val_13 - 1;
                int val_14 = 0 + 1;
                if(val_38 != 0)
            {
                    val_13 - 0 = val_14;
            }
            
                FerrPoly2Tri.Point2D val_16 = this.Item[val_13 - 0];
                int val_17 = val_14 - 1;
                FerrPoly2Tri.Point2D val_18 = this.Item[val_17];
                FerrPoly2Tri.Point2D val_19 = this.Item[val_13 - 0];
                FerrPoly2Tri.Point2D val_20 = this.Item[val_17];
                object val_21 = 536891877;
                val_21 = new System.Object();
                long val_36 = 1353877648;
                val_36 = 1353877648 - val_36;
                mem[536891885] = 1353877648 - 1353877648;
                mem[536891893] = val_36;
                FerrPoly2Tri.Point2D val_23 = FerrPoly2Tri.Point2D.Perpendicular(lhs:  536891877, scalar:  this.GetArea());
                val_37 = val_37;
                val_39 = val_21;
                val_38 = val_38;
                var val_24 = 536882279 + 0;
                mem[536882279] = val_39;
                val_40 = val_17;
                if(mem[536882275] <= val_40)
            {
                    val_40 = 0;
            }
            
                long val_37 = 536891877;
                val_37 = 1 / val_37;
                mem[536882279].Multiply(scalar:  mem[536882279].Magnitude());
                val_41 = 0 + 4;
            }
            while((val_17 + 1) < this.Count);
            
            }
            
            if(this.Count < 1)
            {
                goto label_24;
            }
            
            var val_29 = val_37 + 16;
            val_41 = val_31;
            var val_39 = 0;
            val_38 = 536882263;
            label_35:
            if(val_39 == 0)
            {
                    val_39 = val_41;
                int val_30 = this.Count;
            }
            
            int val_31 = val_30 - 1;
            val_42 = mem[536882275];
            if(val_42 <= val_31)
            {
                    val_42 = mem[536882275];
            }
            
            var val_32 = val_37 + (val_31 << 2);
            double val_34 = FerrPoly2Tri.MathUtil.Clamp(a:  FerrPoly2Tri.Point2D.Cross(lhs:  (val_37 + ((val_30 - 1)) << 2) + 16, rhs:  (val_37 + 16) + 0), low:  null, high:  null);
            val_39 = (val_37 + 16) + 0;
            val_43 = 536891885;
            float val_38 = System.Math.Abs(S0);
            if(((mem[536892072] & true) == 0) && (mem[536892001] == 0))
            {
                    val_43 = 536891885;
            }
            
            if(mem[536892001] >= 0)
            {
                goto label_34;
            }
            
            val_39 = val_39 + 1;
            if(val_39 < this.Count)
            {
                goto label_35;
            }
            
            val_31 = val_41;
            label_24:
            val_32 = val_32;
            goto label_36;
            label_34:
            val_31 = val_41;
            val_32 = val_32 | 16;
            label_36:
            if(val_36 == 0)
            {
                    return;
            }
            
            this.WindingOrder = 0;
        }
        public static string GetErrorString(FerrPoly2Tri.Point2DList.PolygonError error)
        {
            var val_10;
            System.Object[] val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            System.Object[] val_20;
            var val_21;
            var val_22;
            System.Text.StringBuilder val_1 = 536894635;
            val_1 = new System.Text.StringBuilder(capacity:  256);
            if(error == 0)
            {
                goto label_1;
            }
            
            if((error & 1) == 0)
            {
                    val_10 = 536891885;
                if(((mem[536892072] & true) == 0) && (mem[536892001] == 0))
            {
                    val_10 = 536891885;
            }
            
                val_11 = 536888987;
                System.Text.StringBuilder val_2 = val_1.AppendFormat(format:  -1610605949, arg0:  536888987);
            }
            
            if((error & 2) == 0)
            {
                    val_12 = -1073695537;
                val_13 = mem[mem[3221271783] + 186];
                val_13 = mem[3221271783] + 186;
                if(val_13 == 1)
            {
                    val_13 = mem[mem[3221271783] + 186];
                val_13 = mem[3221271783] + 186;
            }
            
                val_11 = mem[mem[3221271783] + 92];
                val_11 = mem[3221271783] + 92;
                System.Text.StringBuilder val_3 = val_1.AppendFormat(format:  -1610605951, args:  val_11);
            }
            
            if((error & 4) == 0)
            {
                    val_12 = -1073695537;
                val_14 = mem[mem[3221271783] + 186];
                val_14 = mem[3221271783] + 186;
                if(val_14 == 1)
            {
                    val_14 = mem[mem[3221271783] + 186];
                val_14 = mem[3221271783] + 186;
            }
            
                val_11 = mem[mem[3221271783] + 92];
                val_11 = mem[3221271783] + 92;
                System.Text.StringBuilder val_4 = val_1.AppendFormat(format:  -1610605947, args:  val_11);
            }
            
            if((error & 8) == 0)
            {
                    val_12 = -1073695537;
                val_15 = mem[mem[3221271783] + 186];
                val_15 = mem[3221271783] + 186;
                if(val_15 == 1)
            {
                    val_15 = mem[mem[3221271783] + 186];
                val_15 = mem[3221271783] + 186;
            }
            
                val_11 = mem[mem[3221271783] + 92];
                val_11 = mem[3221271783] + 92;
                System.Text.StringBuilder val_5 = val_1.AppendFormat(format:  -1610610159, args:  val_11);
            }
            
            if((error & 16) == 0)
            {
                    val_12 = -1073695537;
                val_16 = mem[mem[3221271783] + 186];
                val_16 = mem[3221271783] + 186;
                if(val_16 == 1)
            {
                    val_16 = mem[mem[3221271783] + 186];
                val_16 = mem[3221271783] + 186;
            }
            
                val_11 = mem[mem[3221271783] + 92];
                val_11 = mem[3221271783] + 92;
                System.Text.StringBuilder val_6 = val_1.AppendFormat(format:  -1610604561, args:  val_11);
            }
            
            if((error & 32) == 0)
            {
                    val_12 = -1073695537;
                val_17 = mem[mem[3221271783] + 186];
                val_17 = mem[3221271783] + 186;
                if(val_17 == 1)
            {
                    val_17 = mem[mem[3221271783] + 186];
                val_17 = mem[3221271783] + 186;
            }
            
                val_11 = mem[mem[3221271783] + 92];
                val_11 = mem[3221271783] + 92;
                System.Text.StringBuilder val_7 = val_1.AppendFormat(format:  -1610603381, args:  val_11);
            }
            
            if((error & 64) == 0)
            {
                    val_12 = -1073695537;
                val_18 = mem[mem[3221271783] + 186];
                val_18 = mem[3221271783] + 186;
                if(val_18 == 1)
            {
                    val_18 = mem[mem[3221271783] + 186];
                val_18 = mem[3221271783] + 186;
            }
            
                val_11 = mem[mem[3221271783] + 92];
                val_11 = mem[3221271783] + 92;
                System.Text.StringBuilder val_8 = val_1.AppendFormat(format:  -1610608803, args:  val_11);
            }
            
            if((error & 1073741824) != 0)
            {
                goto label_54;
            }
            
            val_11 = -1073695537;
            val_19 = mem[mem[3221271783] + 186];
            val_19 = mem[3221271783] + 186;
            if(val_19 == 1)
            {
                    val_19 = mem[mem[3221271783] + 186];
                val_19 = mem[3221271783] + 186;
            }
            
            val_20 = mem[mem[3221271783] + 92];
            val_20 = mem[3221271783] + 92;
            val_21 = 22796420;
            goto label_62;
            label_1:
            val_11 = -1073695537;
            val_22 = mem[mem[3221271783] + 186];
            val_22 = mem[3221271783] + 186;
            if(val_22 == 1)
            {
                    val_22 = mem[mem[3221271783] + 186];
                val_22 = mem[3221271783] + 186;
            }
            
            val_20 = mem[mem[3221271783] + 92];
            val_20 = mem[3221271783] + 92;
            val_21 = 22790208;
            label_62:
            System.Text.StringBuilder val_9 = val_1.AppendFormat(format:  -1610606065, args:  val_20);
            label_54:
            if(val_1 != 0)
            {
                    return;
            }
        
        }
        public void RemoveDuplicateNeighborPoints()
        {
            var val_6;
            int val_7;
            int val_1 = this.Count;
            if(val_1 < 2)
            {
                    return;
            }
            
            val_1 = val_1 - 1;
            val_6 = 0;
            label_14:
            val_7 = val_1;
            label_12:
            if(val_1 <= val_7)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (val_7 << 2);
            if(val_6 <= val_6)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            bool val_2 = (0 + ((val_1 - 1)) << 2) + 16.Equals(p:  (0 + 0) + 16, epsilon:  null);
            if(val_2 == false)
            {
                goto label_7;
            }
            
            this.mPoints.RemoveAt(index:  System.Math.Max(val1:  val_7, val2:  0));
            int val_4 = val_1 - 1;
            if(val_7 >= val_4)
            {
                    val_7 = val_1 - 2;
            }
            
            if(val_4 < 2)
            {
                    return;
            }
            
            if(val_6 < val_4)
            {
                goto label_12;
            }
            
            return;
            label_7:
            int val_5 = this.Count;
            val_5 = val_5 - 1;
            val_6 = val_6 + 1;
            val_5 = val_5 - val_7;
            if(val_2 == true)
            {
                    val_5 = val_7 + 1;
            }
            
            if(val_6 < val_1)
            {
                goto label_14;
            }
        
        }
        public void Simplify()
        {
            this.Simplify(bias:  null);
        }
        public void Simplify(double bias)
        {
            var val_13;
            var val_14;
            int val_15;
            if(this.Count < 3)
            {
                    return;
            }
            
            var val_15 = R2;
            int val_2 = this.Count;
            val_15 = val_15 * val_15;
            val_13 = 0;
            label_8:
            label_6:
            if(val_2 < 3)
            {
                    return;
            }
            
            val_13 = val_13;
            if(val_13 >= val_2)
            {
                    return;
            }
            
            val_14 = val_13;
            if(val_13 == 0)
            {
                    val_14 = this.Count;
            }
            
            FerrPoly2Tri.Point2D val_6 = this.Item[val_14 - 1];
            FerrPoly2Tri.Point2D val_7 = this.Item[0];
            int val_9 = val_13 + 1;
            FerrPoly2Tri.Point2D val_11 = this.Item[val_13 - (this.Count - 1)];
            FerrPoly2Tri.Point2D val_12 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  1354370704, rhs:  1354370704);
            Point2DList.WindingOrderType val_16 = this.mWindingOrder;
            val_16 = val_16 * val_16;
            if(this <= 0)
            {
                goto label_5;
            }
            
            FerrPoly2Tri.Orientation val_13 = FerrPoly2Tri.TriangulationUtil.Orient2d(pa:  1354370704, pb:  1354370704, pc:  1354370704);
            val_15 = val_2;
            if(this != 2)
            {
                goto label_6;
            }
            
            var val_14 = val_9 - 1;
            goto label_7;
            label_5:
            val_15 = val_2;
            label_7:
            val_15 = val_15 - 1;
            goto label_8;
        }
        public void MergeParallelEdges(double tolerance)
        {
            FerrPoly2Tri.Point2DList val_38;
            int val_39;
            var val_40;
            var val_41;
            int val_42;
            var val_43;
            bool val_44;
            int val_45;
            float val_46;
            var val_47;
            var val_48;
            val_38 = this;
            val_39 = R3;
            val_40 = R2;
            if(this.Count < 4)
            {
                    return;
            }
            
            int val_2 = this.Count;
            val_41 = 536881727;
            int val_3 = this.Count;
            val_42 = val_3;
            if(this.Count >= 1)
            {
                    do
            {
                val_43 = 0;
                if(0 == 0)
            {
                    val_43 = this.Count;
            }
            
                int val_6 = this.Count;
                val_6 = val_6 - 1;
                int val_7 = 0 - val_6;
                int val_8 = 0 + 1;
                if(0 != 0)
            {
                    val_39 = val_8;
            }
            
                FerrPoly2Tri.Point2D val_9 = this.Item[0];
                int val_10 = val_43 - 1;
                FerrPoly2Tri.Point2D val_11 = this.Item[val_10];
                FerrPoly2Tri.Point2D val_12 = this.Item[0];
                FerrPoly2Tri.Point2D val_13 = this.Item[val_10];
                FerrPoly2Tri.Point2D val_14 = this.Item[val_39];
                FerrPoly2Tri.Point2D val_15 = this.Item[0];
                FerrPoly2Tri.Point2D val_16 = this.Item[val_39];
                long val_38 = 1354490896;
                long val_39 = 1354490896;
                FerrPoly2Tri.Point2D val_17 = this.Item[0];
                val_38 = val_38 - 1354490896;
                val_39 = val_39 - 1354490896;
                val_40 = 22713020;
                val_44 = mem[536890482];
                if((val_44 & true) == 0)
            {
                    val_44 = mem[536890411];
            }
            
                double val_18 = val_38 * val_38;
                val_38 = val_38;
                val_41 = val_41;
                double val_20 = 1354490896 - 1354490896;
                double val_21 = val_20 * val_20;
                val_45 = val_3;
                if(val_44 > 0)
            {
                    0 = 1;
            }
            
                if(val_44 > 0)
            {
                    0 = 1;
            }
            
                if((1 == 1) && (val_45 >= 4))
            {
                    mem[536881743] = 1;
                val_45 = val_3 - 1;
            }
            
                double val_22 = val_20 / val_44;
                double val_25 = (1354490896 - 1354490896) / val_44;
                val_38 = (val_38 / val_44) * val_22;
                val_39 = (val_39 / val_44) * val_22;
                double val_40 = System.Math.Abs(val_39);
                if(mem[536890411] >= 0)
            {
                    0 = 1;
            }
            
                if(mem[536890411] <= 0)
            {
                    0 = 1;
            }
            
                if(val_45 < 4)
            {
                    0 = 1;
            }
            
                if(1 != 0)
            {
                    mem[536881743] = 0;
            }
            else
            {
                    mem[536881743] = 1;
                int val_41 = val_45;
                val_41 = val_41 - 1;
            }
            
                val_46 = val_8;
            }
            while(val_46 < this.Count);
            
                val_42 = val_41;
            }
            
            int val_27 = this.Count;
            if(val_42 == 0)
            {
                    return;
            }
            
            val_46 = 0;
            FerrPoly2Tri.Point2DList val_28 = 536891885;
            val_47 = val_38;
            val_40 = val_28;
            val_28 = new FerrPoly2Tri.Point2DList(l:  1354490896);
            this.Clear();
            val_38 = val_41 + 16;
            val_48 = 0;
            goto label_29;
            label_41:
            val_39 = val_41;
            if(mem[536881739] <= val_48)
            {
                    val_47 = 0;
            }
            
            if(((val_41 + 16) + val_48) != 0)
            {
                goto label_34;
            }
            
            if(0 != val_42)
            {
                goto label_33;
            }
            
            goto label_34;
            label_33:
            if(0 >= val_42)
            {
                goto label_35;
            }
            
            FerrPoly2Tri.Point2D val_29 = this.Item[0];
            mem[1152921510256305176].Add(item:  536891885);
            FerrPoly2Tri.Point2D val_30 = this.Item[0];
            val_39 = val_40;
            val_47 = val_39;
            mem[1152921510256305180].AddPoint(p:  536891885);
            val_46 = 1;
            label_34:
            val_48 = 1;
            label_29:
            int val_31 = this.Count;
            if(val_48 < val_31)
            {
                goto label_41;
            }
            
            double val_32 = this.GetSignedArea();
            if(val_48 <= val_31)
            {
                    1 = 2;
            }
            
            mem[1152921510256305184] = 0;
            double val_33 = this.CalculateEpsilon();
            mem[1152921510256305192] = this;
            return;
            label_35:
            string val_34 = val_46.ToString();
            string val_35 = val_41.ToString();
            string val_36 = +22708560;
            22710780 = new System.Exception(message:  22708560);
        }
        public void ProjectToAxis(FerrPoly2Tri.Point2D axis, out double min, out double max)
        {
            var val_7 = 0;
            FerrPoly2Tri.Point2D val_1 = this.Item[0];
            double val_2 = FerrPoly2Tri.Point2D.Dot(lhs:  axis, rhs:  1354615056);
            min = axis;
            max = axis;
            int val_3 = this.Count;
            if(val_3 < 1)
            {
                    return;
            }
            
            do
            {
                FerrPoly2Tri.Point2D val_4 = this.Item[0];
                double val_5 = FerrPoly2Tri.Point2D.Dot(lhs:  1354615056, rhs:  axis);
                if(val_3 < 0)
            {
                    min = 1354615056;
                mem[1152921510256465428] = 2.524355E-29f;
            }
            else
            {
                    if(val_3 > 1)
            {
                    max = 1354615056;
                mem[1152921510256469460] = 2.524355E-29f;
            }
            
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 < this.Count);
        
        }
        private static Point2DList()
        {
            mem2[0] = 100000;
            mem2[0] = 4572414629676717179;
            mem2[0] = 1856099127;
            mem2[0] = 1064106280;
        }
    
    }

}
