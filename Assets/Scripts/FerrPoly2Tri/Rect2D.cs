using UnityEngine;

namespace FerrPoly2Tri
{
    public class Rect2D
    {
        // Fields
        private double mMinX;
        private double mMaxX;
        private double mMinY;
        private double mMaxY;
        
        // Properties
        public double MinX { get; set; }
        public double MaxX { get; set; }
        public double MinY { get; set; }
        public double MaxY { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }
        public double Top { get; set; }
        public double Bottom { get; set; }
        public double Width { get; }
        public double Height { get; }
        public bool Empty { get; }
        
        // Methods
        public double get_MinX()
        {
            return (double)D0;
        }
        public void set_MinX(double value)
        {
            this.mMinX = ;
            mem[1152921510256777500] = R3;
        }
        public double get_MaxX()
        {
            return (double)D0;
        }
        public void set_MaxX(double value)
        {
            this.mMaxX = ;
            mem[1152921510257001508] = R3;
        }
        public double get_MinY()
        {
            return (double)D0;
        }
        public void set_MinY(double value)
        {
            this.mMinY = ;
            mem[1152921510257225516] = R3;
        }
        public double get_MaxY()
        {
            return (double)D0;
        }
        public void set_MaxY(double value)
        {
            this.mMaxY = ;
            mem[1152921510257449524] = R3;
        }
        public double get_Left()
        {
            return (double)D0;
        }
        public void set_Left(double value)
        {
            this.mMinX = ;
            mem[1152921510257673500] = R3;
        }
        public double get_Right()
        {
            return (double)D0;
        }
        public void set_Right(double value)
        {
            this.mMaxX = ;
            mem[1152921510257897508] = R3;
        }
        public double get_Top()
        {
            return (double)D0;
        }
        public void set_Top(double value)
        {
            this.mMaxY = ;
            mem[1152921510258121524] = R3;
        }
        public double get_Bottom()
        {
            return (double)D0;
        }
        public void set_Bottom(double value)
        {
            this.mMinY = ;
            mem[1152921510258345516] = R3;
        }
        public double get_Width()
        {
            double val_1 = this.mMinX;
            val_1 = this.mMaxX - val_1;
            return (double)D0;
        }
        public double get_Height()
        {
            double val_1 = this.mMinY;
            val_1 = this.mMaxY - val_1;
            return (double)D0;
        }
        public bool get_Empty()
        {
            if()
            {
                    this = 1;
                return (bool)this;
            }
            
            if()
            {
                    0 = 1;
            }
            
            return true;
        }
        public Rect2D()
        {
            this.mMinX = 0;
            this.mMinY = 0;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if(obj == 0)
            {
                    return obj.Equals(obj:  obj);
            }
            
            return obj.Equals(obj:  obj);
        }
        public bool Equals(FerrPoly2Tri.Rect2D r)
        {
            if(((mem[536890484] & true) != 0) || (mem[536890413] != 0))
            {
                    return (bool)this.Equals(r:  r, epsilon:  null);
            }
            
            536890297 = 536890297;
            return (bool)this.Equals(r:  r, epsilon:  null);
        }
        public bool Equals(FerrPoly2Tri.Rect2D r, double epsilon)
        {
            bool val_5;
            var val_6;
            bool val_7;
            bool val_8;
            bool val_9;
            var val_10;
            val_5 = mem[536890484];
            if((val_5 & true) == 0)
            {
                    val_5 = mem[536890413];
            }
            
            val_6 = 0;
            if((FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  epsilon, val2:  null, tolerance:  null)) != false)
            {
                    val_7 = mem[536890484];
                if((val_7 & true) == 0)
            {
                    val_7 = mem[536890413];
            }
            
                val_6 = 0;
                if((FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  epsilon, val2:  null)) != false)
            {
                    val_8 = mem[536890484];
                if((val_8 & true) == 0)
            {
                    val_8 = mem[536890413];
            }
            
                val_6 = 0;
                if((FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  epsilon, val2:  null, tolerance:  null)) != false)
            {
                    val_9 = mem[536890484];
                if((val_9 & true) == 0)
            {
                    val_9 = mem[536890413];
            }
            
                val_6 = 0;
                bool val_4 = FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  epsilon, val2:  null, tolerance:  null);
                return (bool)val_10;
            }
            
            }
            
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public void Clear()
        {
            this.mMinX = 0;
            this.mMinY = 0;
        }
        public void Set(double xmin, double xmax, double ymin, double ymax)
        {
            double val_1;
            double val_2;
            double val_3;
            this.mMinX = ;
            mem[1152921510259490076] = R3;
            this.mMaxX = val_3;
            this.mMinY = val_1;
            this.mMaxY = val_2;
            this.Normalize();
        }
        public void Set(FerrPoly2Tri.Rect2D b)
        {
            if(b != 0)
            {
                    this.mMinX = b.mMinX;
                this.mMaxX = b.mMaxX;
                this.mMinY = b.mMinY;
            }
            else
            {
                    this.mMinX = 0;
                this.mMaxX = 1.29516492883101E-317;
                this.mMinY = 0;
            }
            
            this.mMaxY = b.mMaxY;
        }
        public void SetSize(double w, double h)
        {
            var val_1;
            double val_2 = this.mMinX;
            double val_3 = this.mMinY;
            val_2 = val_2 + R2;
            val_3 = val_3 + val_1;
            this.mMaxX = val_2;
            this.mMaxY = val_3;
        }
        public bool Contains(double x, double y)
        {
            var val_2 = 0;
            if(>=0)
            {
                    return true;
            }
            
            if(>=0)
            {
                    return true;
            }
            
            if()
            {
                    return (bool)val_2;
            }
            
            if()
            {
                    val_2 = 1;
            }
            
            return true;
        }
        public bool Contains(FerrPoly2Tri.Point2D p)
        {
            if(p >= 0)
            {
                    return true;
            }
            
            if(p >= 0)
            {
                    return true;
            }
            
            if(p <= 0)
            {
                    return true;
            }
            
            if(p > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool Contains(FerrPoly2Tri.Rect2D r)
        {
            if(r >= 0)
            {
                    return true;
            }
            
            if(r <= 0)
            {
                    return true;
            }
            
            if(r >= 0)
            {
                    return true;
            }
            
            if(r > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool ContainsInclusive(double x, double y)
        {
            var val_2 = 0;
            if()
            {
                    return true;
            }
            
            if()
            {
                    return true;
            }
            
            if()
            {
                    return (bool)val_2;
            }
            
            if()
            {
                    val_2 = 1;
            }
            
            return true;
        }
        public bool ContainsInclusive(double x, double y, double epsilon)
        {
            var val_1;
            var val_3;
            var val_5;
            var val_6 = val_1;
            var val_5 = R2;
            double val_2 = val_5 + val_6;
            val_5 = 0;
            if()
            {
                    return true;
            }
            
            double val_4 = val_3 + val_6;
            if()
            {
                    return true;
            }
            
            val_5 = val_5 - val_6;
            if()
            {
                    return (bool)val_5;
            }
            
            val_6 = val_3 - val_6;
            if()
            {
                    val_5 = 1;
            }
            
            return true;
        }
        public bool ContainsInclusive(FerrPoly2Tri.Point2D p)
        {
            if(p > 0)
            {
                    return true;
            }
            
            if(p > 0)
            {
                    return true;
            }
            
            if(p < 0)
            {
                    return true;
            }
            
            if(p >= 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool ContainsInclusive(FerrPoly2Tri.Point2D p, double epsilon)
        {
            var val_4;
            FerrPoly2Tri.Point2D val_1 = p + R2;
            val_4 = 0;
            if(p < 0)
            {
                    return true;
            }
            
            FerrPoly2Tri.Point2D val_4 = p;
            FerrPoly2Tri.Point2D val_2 = val_4 + R2;
            if(p < 0)
            {
                    return true;
            }
            
            FerrPoly2Tri.Point2D val_3 = p - R2;
            if(p > 0)
            {
                    return true;
            }
            
            val_4 = val_4 - R2;
            if(p <= 0)
            {
                    val_4 = 1;
            }
            
            return true;
        }
        public bool ContainsInclusive(FerrPoly2Tri.Rect2D r)
        {
            if(r > 0)
            {
                    return true;
            }
            
            if(r < 0)
            {
                    return true;
            }
            
            if(r > 0)
            {
                    return true;
            }
            
            if(r >= 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public bool ContainsInclusive(FerrPoly2Tri.Rect2D r, double epsilon)
        {
            var val_2;
            double val_1 = this.mMinX - R2;
            val_2 = 0;
            if(r > 0)
            {
                    return true;
            }
            
            double val_2 = this.mMaxX;
            val_2 = val_2 + R2;
            if(r < 0)
            {
                    return true;
            }
            
            double val_3 = this.mMaxY;
            val_3 = val_3 - R2;
            if(r > 0)
            {
                    return true;
            }
            
            double val_4 = this.mMinY;
            val_4 = val_4 + R2;
            if(r >= 0)
            {
                    val_2 = 1;
            }
            
            return true;
        }
        public bool Intersects(FerrPoly2Tri.Rect2D r)
        {
            if(r <= 0)
            {
                    return true;
            }
            
            if(r >= 0)
            {
                    return true;
            }
            
            if(r >= 0)
            {
                    return true;
            }
            
            if(r > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public FerrPoly2Tri.Point2D GetCenter()
        {
            double val_1 = D16 + D17;
            val_1 = val_1 * 0.5;
            double val_3 = (D18 + D19) * 0.5;
            536891877 = new FerrPoly2Tri.Point2D(x:  null, y:  null);
        }
        public bool IsNormalized()
        {
            if()
            {
                    return false;
            }
            
            if()
            {
                    0 = 1;
            }
            
            return true;
        }
        public void Normalize()
        {
            FerrPoly2Tri.MathUtil.Swap<System.Double>(a: ref  this.mMinX, b: ref  this.mMaxX);
            if(mem[536890413] >= 0)
            {
                    return;
            }
            
            FerrPoly2Tri.MathUtil.Swap<System.Double>(a: ref  this.mMinY, b: ref  this.mMaxY);
        }
        public void AddPoint(FerrPoly2Tri.Point2D p)
        {
            bool val_5 = mem[536890482];
            if((val_5 & true) == 0)
            {
                    val_5 = mem[536890411];
            }
            
            this.mMinX = val_5;
            this.mMaxX = typeof(FerrPoly2Tri.Point2D).__il2cppRuntimeField_E8;
            this.mMinY = typeof(FerrPoly2Tri.Point2D).__il2cppRuntimeField_F8;
            double val_4 = System.Math.Max(val1:  System.Math.Min(val1:  System.Math.Max(val1:  System.Math.Min(val1:  null, val2:  null), val2:  null), val2:  null), val2:  null);
            this.mMaxY = typeof(FerrPoly2Tri.Point2D).__il2cppRuntimeField_F8;
        }
        public void Inflate(double w, double h)
        {
            var val_1;
            double val_2 = D16 - R2;
            double val_3 = D17 + R2;
            double val_4 = D18 - val_1;
            double val_5 = D19 + val_1;
        }
        public void Inflate(double left, double top, double right, double bottom)
        {
            double val_1;
            var val_2;
            var val_3;
            double val_7 = val_1;
            double val_4 = D17 - R2;
            val_7 = D20 + val_7;
            double val_5 = D18 + val_2;
            double val_6 = D19 - val_3;
            this.mMaxY = val_7;
        }
        public void Offset(double w, double h)
        {
            var val_1;
            double val_2 = D16 + R2;
            double val_3 = D17 + R2;
            double val_4 = D18 + val_1;
            double val_5 = D19 + val_1;
        }
        public void SetPosition(double x, double y)
        {
            double val_3;
            double val_1 = D17 - D16;
            double val_2 = D18 - D19;
            val_1 = val_1 + R2;
            val_2 = val_2 + val_3;
            this.mMinX = R2;
            this.mMaxX = val_1;
            this.mMinY = val_3;
            this.mMaxY = val_2;
        }
        public bool Intersection(FerrPoly2Tri.Rect2D r1, FerrPoly2Tri.Rect2D r2)
        {
            var val_2 = 0;
            if((FerrPoly2Tri.TriangulationUtil.RectsIntersect(r1:  r1, r2:  r2)) == false)
            {
                    return (bool)val_2;
            }
            
            if(r2 > 0)
            {
                    r2.mMinX = r1.mMinX;
            }
            
            this.mMinX = r2.mMinX;
            if(this < 0)
            {
                    r2.mMaxY = r1.mMaxY;
            }
            
            this.mMaxY = r2.mMaxY;
            if(this < 0)
            {
                    r2.mMaxX = r1.mMaxX;
            }
            
            this.mMaxX = r2.mMaxX;
            if(this > 0)
            {
                    r2.mMinY = r1.mMinY;
            }
            
            val_2 = 1;
            this.mMinY = r2.mMinY;
            return (bool)val_2;
        }
        public void Union(FerrPoly2Tri.Rect2D r1, FerrPoly2Tri.Rect2D r2)
        {
            double val_1;
            double val_2;
            double val_3;
            if(r2 != 0)
            {
                    val_1 = r2.mMaxX;
            }
            else
            {
                    val_1 = 16;
            }
            
            if(r2 != 0)
            {
                    if(r2 != 0)
            {
                goto label_3;
            }
            
            }
            
            label_8:
            this.Set(b:  r1);
            return;
            label_3:
            if(r1 != 0)
            {
                    val_2 = r1.mMaxX;
            }
            else
            {
                    val_2 = 16;
            }
            
            if(r1 == 0)
            {
                goto label_8;
            }
            
            if(r1 != 0)
            {
                goto label_7;
            }
            
            goto label_8;
            label_7:
            if(r1 < 0)
            {
                    r2.mMinX = r1.mMinX;
            }
            
            if(this != 0)
            {
                    this.mMinX = r2.mMinX;
                if(this > 0)
            {
                    r2.mMaxY = r1.mMaxY;
            }
            
                this.mMaxY = r2.mMaxY;
                if(this > 0)
            {
                    1.29516492883101E-317 = 2621443;
            }
            
                this.mMaxX = 1.29516492883101E-317;
                if(this < 0)
            {
                    val_3 = r1.mMinY;
            }
            
            }
            else
            {
                    this.mMinX = r2.mMinX;
                if(this > 0)
            {
                    r2.mMaxY = r1.mMaxY;
            }
            
                this.mMaxY = r2.mMaxY;
                if(this > 0)
            {
                    1.29516492883101E-317 = 2621443;
            }
            
                this.mMaxX = 1.29516492883101E-317;
                if(this < 0)
            {
                    val_3 = r1.mMinY;
            }
            
            }
            
            this.mMinY = val_3;
        }
    
    }

}
