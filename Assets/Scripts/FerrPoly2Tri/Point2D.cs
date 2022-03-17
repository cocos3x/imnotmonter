using UnityEngine;

namespace FerrPoly2Tri
{
    public class Point2D : IComparable<FerrPoly2Tri.Point2D>
    {
        // Fields
        protected double mX;
        protected double mY;
        
        // Properties
        public virtual double X { get; set; }
        public virtual double Y { get; set; }
        public float Xf { get; }
        public float Yf { get; }
        
        // Methods
        public virtual double get_X()
        {
            return (double)D0;
        }
        public virtual void set_X(double value)
        {
            this.mX = ;
            mem[1152921510242223644] = R3;
        }
        public virtual double get_Y()
        {
            return (double)D0;
        }
        public virtual void set_Y(double value)
        {
            this.mY = ;
            mem[1152921510242447652] = R3;
        }
        public float get_Xf()
        {
            return (float)S0;
        }
        public float get_Yf()
        {
            return (float)S0;
        }
        public Point2D()
        {
        
        }
        public Point2D(double x, double y)
        {
            double val_1;
            this.mX = R2;
            mem[1152921510242895644] = R3;
            this.mY = val_1;
        }
        public Point2D(FerrPoly2Tri.Point2D p)
        {
            this.mX = p;
            this.mY = p;
        }
        public override string ToString()
        {
            mem[536882417] = -1610602391;
            string val_1 = this.mX.ToString();
            mem[536882421] = this.mX;
            mem[536882425] = -1610611911;
            string val_2 = this.mY.ToString();
            mem[536882429] = this.mY;
            mem[536882433] = -1610602237;
            return +536882401;
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
        public bool Equals(FerrPoly2Tri.Point2D p)
        {
            return (bool)this.Equals(p:  p, epsilon:  null);
        }
        public bool Equals(FerrPoly2Tri.Point2D p, double epsilon)
        {
            var val_3;
            float val_4;
            bool val_5;
            bool val_6;
            var val_7;
            val_3 = R3;
            val_4 = R2;
            if(p != 0)
            {
                    val_3 = 22713024;
                val_5 = mem[536890484];
                if((val_5 & true) == 0)
            {
                    val_5 = mem[536890413];
            }
            
                val_4 = 0;
                if((FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  epsilon, val2:  null, tolerance:  null)) != false)
            {
                    val_6 = mem[536890484];
                if((val_6 & true) == 0)
            {
                    val_6 = mem[536890413];
            }
            
                val_4 = 0;
                bool val_2 = FerrPoly2Tri.MathUtil.AreValuesEqual(val1:  epsilon, val2:  null, tolerance:  null);
                return (bool)val_7;
            }
            
            }
            
            val_7 = 0;
            return (bool)val_7;
        }
        public int CompareTo(FerrPoly2Tri.Point2D other)
        {
            var val_1 = 0;
            if(other < 0)
            {
                    return 1;
            }
            
            val_1 = 1;
            if(other > 0)
            {
                    return 1;
            }
            
            val_1 = 0;
            if(other < 0)
            {
                    return 1;
            }
            
            if(other > 0)
            {
                    val_1 = 1;
            }
            
            return 1;
        }
        public virtual void Set(double x, double y)
        {
        
        }
        public virtual void Set(FerrPoly2Tri.Point2D p)
        {
            if(p != 0)
            {
                    return;
            }
        
        }
        public void Add(FerrPoly2Tri.Point2D p)
        {
            double val_1 = p.mX;
            val_1 = 1342254608 + val_1;
            double val_2 = p.mY;
            val_2 = 1342254608 + val_2;
        }
        public void Add(double scalar)
        {
            long val_1 = 1342370704;
            val_1 = val_1 + R2;
            long val_2 = 1342370704;
            val_2 = val_2 + R2;
        }
        public void Subtract(FerrPoly2Tri.Point2D p)
        {
            double val_1 = p.mX;
            val_1 = 1342486800 - val_1;
            double val_2 = p.mY;
            val_2 = 1342486800 - val_2;
        }
        public void Subtract(double scalar)
        {
            long val_1 = 1342602896;
            val_1 = val_1 - R2;
            long val_2 = 1342602896;
            val_2 = val_2 - R2;
        }
        public void Multiply(FerrPoly2Tri.Point2D p)
        {
            double val_1 = p.mX;
            val_1 = 1342718992 * val_1;
            double val_2 = p.mY;
            val_2 = 1342718992 * val_2;
        }
        public void Multiply(double scalar)
        {
            long val_1 = 1342835088;
            val_1 = val_1 * R2;
            long val_2 = 1342835088;
            val_2 = val_2 * R2;
        }
        public void Divide(FerrPoly2Tri.Point2D p)
        {
            double val_1 = p.mX;
            val_1 = 1342951184 / val_1;
            double val_2 = p.mY;
            val_2 = 1342951184 / val_2;
        }
        public void Divide(double scalar)
        {
            long val_1 = 1343067280;
            val_1 = val_1 / R2;
            long val_2 = 1343067280;
            val_2 = val_2 / R2;
        }
        public void Negate()
        {
        
        }
        public double Magnitude()
        {
            bool val_2 = mem[536890482];
            if((val_2 & true) == 0)
            {
                    val_2 = mem[536890411];
            }
            
            double val_1 = this.mY * this.mY;
            if(val_2 <= _TYPE_MAX_)
            {
                    return (double)D0;
            }
        
        }
        public double MagnitudeSquared()
        {
            double val_1 = this.mY;
            val_1 = val_1 * val_1;
            return (double)D0;
        }
        public double MagnitudeReciprocal()
        {
            double val_2 = 1;
            val_2 = val_2 / 1343515280;
            return (double)this.Magnitude();
        }
        public void Normalize()
        {
            double val_2 = 1;
            val_2 = val_2 / 1343627280;
            this.Multiply(scalar:  this.Magnitude());
        }
        public double Dot(FerrPoly2Tri.Point2D p)
        {
            double val_1;
            double val_2;
            if(p != 0)
            {
                    val_1 = this.mY;
                val_2 = p.mX;
            }
            else
            {
                    val_1 = this.mY;
                val_2 = 0;
            }
            
            double val_1 = p.mY;
            val_1 = val_1 * val_1;
            return (double)D0;
        }
        public double Cross(FerrPoly2Tri.Point2D p)
        {
            double val_1 = this.mX * p.mY;
            return (double)D0;
        }
        public void Clamp(FerrPoly2Tri.Point2D low, FerrPoly2Tri.Point2D high)
        {
            bool val_5 = mem[536890482];
            if((val_5 & true) == 0)
            {
                    val_5 = mem[536890411];
            }
            
            double val_4 = System.Math.Max(val1:  System.Math.Min(val1:  System.Math.Max(val1:  System.Math.Min(val1:  null, val2:  null), val2:  null), val2:  null), val2:  null);
        }
        public void Abs()
        {
            double val_1 = System.Math.Abs(this.mX);
            double val_2 = System.Math.Abs(this.mY);
        }
        public void Reciprocal()
        {
            double val_1 = this.mX;
            if()
            {
                    return;
            }
            
            if()
            {
                    return;
            }
            
            val_1 = 1 / val_1;
            double val_2 = this.mY;
            val_2 = 1 / val_2;
        }
        public void Translate(FerrPoly2Tri.Point2D vector)
        {
            this.Add(p:  vector);
        }
        public void Translate(double x, double y)
        {
            var val_1;
            long val_2 = 1344452240;
            val_2 = val_2 + R2;
            var val_3 = val_1;
            val_3 = 1344452240 + val_3;
        }
        public void Scale(FerrPoly2Tri.Point2D vector)
        {
            this.Multiply(p:  vector);
        }
        public void Scale(double scalar)
        {
            this.Multiply(scalar:  scalar);
        }
        public void Scale(double x, double y)
        {
            var val_1;
            long val_2 = 1344796432;
            val_2 = val_2 * R2;
            var val_3 = val_1;
            val_3 = 1344796432 * val_3;
        }
        public void Rotate(double radians)
        {
            double val_1 = R2 * 1344908432;
            double val_2 = R2 * 1344908432;
        }
        public void RotateDegrees(double degrees)
        {
            double val_1 = 6.98487350263574E-315;
            val_1 = R2 * val_1;
            val_1 = val_1 / 0;
            this.Rotate(radians:  degrees);
        }
        public static double Dot(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            double val_1;
            double val_2;
            if(rhs != 0)
            {
                    val_1 = lhs.mY;
                val_2 = rhs.mX;
            }
            else
            {
                    val_1 = lhs.mY;
                val_2 = 0;
            }
            
            double val_1 = rhs.mY;
            val_1 = val_1 * val_1;
            return (double)D0;
        }
        public static double Cross(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            double val_2;
            double val_3;
            if(rhs != 0)
            {
                    val_2 = lhs.mY;
                val_3 = rhs.mY;
            }
            else
            {
                    val_2 = lhs.mY;
                val_3 = 1.29516492883101E-317;
            }
            
            double val_1 = lhs.mX * val_3;
            return (double)D0;
        }
        public static FerrPoly2Tri.Point2D Clamp(FerrPoly2Tri.Point2D a, FerrPoly2Tri.Point2D low, FerrPoly2Tri.Point2D high)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  a);
            this.Clamp(low:  low, high:  high);
        }
        public static FerrPoly2Tri.Point2D Min(FerrPoly2Tri.Point2D a, FerrPoly2Tri.Point2D b)
        {
            bool val_4;
            object val_1 = 536891877;
            val_1 = new System.Object();
            val_4 = mem[536890482];
            if((val_4 & true) == 0)
            {
                    val_4 = mem[536890411];
            }
            
            double val_3 = System.Math.Min(val1:  System.Math.Min(val1:  null, val2:  null), val2:  null);
            if(val_1 != 0)
            {
                    return;
            }
        
        }
        public static FerrPoly2Tri.Point2D Max(FerrPoly2Tri.Point2D a, FerrPoly2Tri.Point2D b)
        {
            bool val_4;
            object val_1 = 536891877;
            val_1 = new System.Object();
            val_4 = mem[536890482];
            if((val_4 & true) == 0)
            {
                    val_4 = mem[536890411];
            }
            
            double val_3 = System.Math.Max(val1:  System.Math.Max(val1:  null, val2:  null), val2:  null);
            if(val_1 != 0)
            {
                    return;
            }
        
        }
        public static FerrPoly2Tri.Point2D Abs(FerrPoly2Tri.Point2D a)
        {
            536891877 = new System.Object();
            mem[536891885] = System.Math.Abs(a.mX);
            mem[536891893] = System.Math.Abs(a.mY);
        }
        public static FerrPoly2Tri.Point2D Reciprocal(FerrPoly2Tri.Point2D a)
        {
            double val_3;
            if(a != 0)
            {
                    val_3 = a.mX;
            }
            else
            {
                    val_3 = 0;
            }
            
            536891877 = new System.Object();
            double val_3 = 1;
            val_3 = val_3 / val_3;
            mem[536891885] = val_3;
            mem[536891893] = val_3 / a.mY;
        }
        public static FerrPoly2Tri.Point2D Perpendicular(FerrPoly2Tri.Point2D lhs, double scalar)
        {
            double val_3;
            if(lhs != 0)
            {
                    val_3 = lhs.mY;
            }
            else
            {
                    val_3 = 1.29516492883101E-317;
            }
            
            536891877 = new System.Object();
            mem[536891885] = val_3 * R2;
            mem[536891893] = ;
        }
        public static FerrPoly2Tri.Point2D Perpendicular(double scalar, FerrPoly2Tri.Point2D rhs)
        {
            double val_3;
            if(R2 != 0)
            {
                    val_3 = mem[R2 + 16];
                val_3 = R2 + 16;
            }
            else
            {
                    val_3 = 1.29516492883101E-317;
            }
            
            536891877 = new System.Object();
            mem[536891885] = ;
            mem[536891893] = (R2 + 8) * rhs;
        }
        public static FerrPoly2Tri.Point2D op_Addition(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  lhs);
            this.Add(p:  rhs);
        }
        public static FerrPoly2Tri.Point2D op_Addition(FerrPoly2Tri.Point2D lhs, double scalar)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  lhs);
            this.Add(scalar:  scalar);
        }
        public static FerrPoly2Tri.Point2D op_Subtraction(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  lhs);
            this.Subtract(p:  rhs);
        }
        public static FerrPoly2Tri.Point2D op_Subtraction(FerrPoly2Tri.Point2D lhs, double scalar)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  lhs);
            this.Subtract(scalar:  scalar);
        }
        public static FerrPoly2Tri.Point2D op_Multiply(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  lhs);
            this.Multiply(p:  rhs);
        }
        public static FerrPoly2Tri.Point2D op_Multiply(FerrPoly2Tri.Point2D lhs, double scalar)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  lhs);
            this.Multiply(scalar:  scalar);
        }
        public static FerrPoly2Tri.Point2D op_Multiply(double scalar, FerrPoly2Tri.Point2D lhs)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  R2);
            this.Multiply(scalar:  scalar);
        }
        public static FerrPoly2Tri.Point2D op_Division(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  lhs);
            this.Divide(p:  rhs);
        }
        public static FerrPoly2Tri.Point2D op_Division(FerrPoly2Tri.Point2D lhs, double scalar)
        {
            536891877 = new FerrPoly2Tri.Point2D(p:  lhs);
            this.Divide(scalar:  scalar);
        }
        public static FerrPoly2Tri.Point2D op_UnaryNegation(FerrPoly2Tri.Point2D p)
        {
            FerrPoly2Tri.Point2D val_1 = 536891877;
            val_1 = new FerrPoly2Tri.Point2D(p:  p);
            if(val_1 != 0)
            {
                    return;
            }
        
        }
        public static bool op_LessThan(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            int val_1 = lhs.CompareTo(other:  rhs);
            val_1 = val_1 + 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public static bool op_GreaterThan(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            int val_1 = lhs.CompareTo(other:  rhs);
            val_1 = val_1 - 1;
            val_1 = val_1 >> 5;
            return (bool)val_1;
        }
        public static bool op_LessThanOrEqual(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            if((lhs.CompareTo(other:  rhs)) < 1)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool op_GreaterThanOrEqual(FerrPoly2Tri.Point2D lhs, FerrPoly2Tri.Point2D rhs)
        {
            var val_2 = ~(lhs.CompareTo(other:  rhs));
            val_2 = val_2 >> 31;
            return (bool)val_2;
        }
    
    }

}
