using UnityEngine;

namespace FerrPoly2Tri
{
    public class SplitComplexPolygonNode
    {
        // Fields
        private System.Collections.Generic.List<FerrPoly2Tri.SplitComplexPolygonNode> mConnected;
        private FerrPoly2Tri.Point2D mPosition;
        
        // Properties
        public int NumConnected { get; }
        public FerrPoly2Tri.Point2D Position { get; set; }
        public FerrPoly2Tri.SplitComplexPolygonNode Item { get; }
        
        // Methods
        public int get_NumConnected()
        {
            if(this.mConnected != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public FerrPoly2Tri.Point2D get_Position()
        {
        
        }
        public void set_Position(FerrPoly2Tri.Point2D value)
        {
            this.mPosition = value;
        }
        public FerrPoly2Tri.SplitComplexPolygonNode get_Item(int index)
        {
            if(true <= index)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (index << 2);
        }
        public SplitComplexPolygonNode()
        {
            536878327 = new System.Collections.Generic.List<Page>();
            this.mConnected = 536878327;
        }
        public SplitComplexPolygonNode(FerrPoly2Tri.Point2D pos)
        {
            FerrPoly2Tri.Point2D val_2 = pos;
            536878327 = new System.Collections.Generic.List<Page>();
            this.mConnected = 536878327;
            val_2 = new System.Object();
            this.mPosition = val_2;
        }
        public override bool Equals(object obj)
        {
            if(obj == 0)
            {
                    return obj.Equals(obj:  obj);
            }
            
            return obj.Equals(obj:  obj);
        }
        public bool Equals(FerrPoly2Tri.SplitComplexPolygonNode pn)
        {
            if(pn != 0)
            {
                    this = this.mPosition;
            }
            
            if(this == 0)
            {
                    return false;
            }
            
            if(pn.mPosition == 0)
            {
                    return false;
            }
            
            return this.Equals(p:  pn.mPosition);
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public static bool op_Equality(FerrPoly2Tri.SplitComplexPolygonNode lhs, FerrPoly2Tri.SplitComplexPolygonNode rhs)
        {
            var val_1;
            lhs = lhs | rhs;
            val_1 = lhs >> 5;
            if(lhs == 0)
            {
                    return (bool)val_1;
            }
            
            if(rhs != 0)
            {
                    lhs = lhs.mPosition;
                val_1 = 0;
            }
            
            if(lhs == 0)
            {
                    return (bool)val_1;
            }
            
            if(rhs.mPosition == 0)
            {
                    return (bool)val_1;
            }
            
            return lhs.Equals(p:  rhs.mPosition);
        }
        public static bool op_Inequality(FerrPoly2Tri.SplitComplexPolygonNode lhs, FerrPoly2Tri.SplitComplexPolygonNode rhs)
        {
            if(lhs == 0)
            {
                goto label_0;
            }
            
            if(rhs == 0)
            {
                    return true;
            }
            
            if(rhs != 0)
            {
                goto label_1;
            }
            
            return true;
            label_0:
            if(rhs != 0)
            {
                    rhs = 1;
            }
            
            return true;
            label_1:
            bool val_1 = lhs.mPosition.Equals(p:  rhs = rhs.mPosition);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public override string ToString()
        {
            string val_9;
            var val_10;
            System.Text.StringBuilder val_1 = 536894635;
            val_1 = new System.Text.StringBuilder(capacity:  256);
            val_9 = this.mPosition;
            if(val_1 != 0)
            {
                    System.Text.StringBuilder val_2 = val_1.Append(value:  val_9);
            }
            else
            {
                    System.Text.StringBuilder val_3 = val_1.Append(value:  val_9);
            }
            
            val_10 = 0;
            System.Text.StringBuilder val_4 = val_1.Append(value:  -1610612493);
            if(this.NumConnected >= 1)
            {
                    do
            {
                if(val_10 != 0)
            {
                    System.Text.StringBuilder val_6 = val_1.Append(value:  -1610611907);
            }
            
                if(val_1 <= val_10)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = val_9 + 0;
                val_9 = (0 + 0) + 16 + 12;
                System.Text.StringBuilder val_7 = val_1.Append(value:  val_9);
                val_10 = val_10 + 1;
            }
            while(val_10 < this.NumConnected);
            
            }
            
            if(val_1 == 0)
            {
                
            }
        
        }
        private bool IsRighter(double sinA, double cosA, double sinB, double cosB)
        {
            var val_2;
            if(<0)
            {
                    val_2 = 1;
                if()
            {
                    return true;
            }
            
                if()
            {
                    0 = 1;
            }
            
                return true;
            }
            
            if(<0)
            {
                    return false;
            }
            
            if()
            {
                    val_2 = 1;
            }
            
            return true;
        }
        private int remainder(int x, int modulus)
        {
            int val_1 = modulus - modulus;
            do
            {
                val_1 = val_1 + modulus;
            }
            while(val_1 < 0);
            
            return (int)val_1;
        }
        public void AddConnection(FerrPoly2Tri.SplitComplexPolygonNode toMe)
        {
            if((this.mConnected.Contains(item:  toMe)) == true)
            {
                    return;
            }
            
            if((FerrPoly2Tri.SplitComplexPolygonNode.op_Inequality(lhs:  toMe, rhs:  1315655120)) == false)
            {
                    return;
            }
            
            this.mConnected.Add(item:  toMe);
        }
        public void RemoveConnection(FerrPoly2Tri.SplitComplexPolygonNode fromMe)
        {
            bool val_1 = this.mConnected.Remove(item:  fromMe);
        }
        private void RemoveConnectionByIndex(int index)
        {
            if(index < 0)
            {
                    return;
            }
            
            23000095 = this.mConnected;
            if(true <= index)
            {
                    return;
            }
            
            this.mConnected.RemoveAt(index:  index);
        }
        public void ClearConnections()
        {
            this.mConnected.Clear();
        }
        private bool IsConnectedTo(FerrPoly2Tri.SplitComplexPolygonNode me)
        {
            if(this.mConnected != 0)
            {
                    return this.mConnected.Contains(item:  me);
            }
            
            return this.mConnected.Contains(item:  me);
        }
        public FerrPoly2Tri.SplitComplexPolygonNode GetRightestConnection(FerrPoly2Tri.SplitComplexPolygonNode incoming)
        {
            FerrPoly2Tri.Point2D val_18;
            var val_19;
            var val_20;
            var val_21;
            System.Collections.Generic.List<FerrPoly2Tri.SplitComplexPolygonNode> val_22;
            if(this.NumConnected == 0)
            {
                goto label_37;
            }
            
            if(this.NumConnected == 1)
            {
                    return;
            }
            
            FerrPoly2Tri.Point2D val_3 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  this.mPosition, rhs:  incoming.mPosition);
            val_18 = this.mPosition;
            if(this.mPosition != 0)
            {
                    double val_4 = val_18.Magnitude();
            }
            else
            {
                    double val_5 = 0.Magnitude();
            }
            
            val_18.Normalize();
            val_19 = 536890297;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_19 = 536890297;
            }
            
            if(mem[536890413] <= 0)
            {
                goto label_21;
            }
            
            if(this.NumConnected < 1)
            {
                    return;
            }
            
            label_35:
            var val_7 = 4 - 4;
            if(0 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            bool val_8 = FerrPoly2Tri.SplitComplexPolygonNode.op_Equality(lhs:  2621443, rhs:  incoming);
            if(val_8 == true)
            {
                goto label_32;
            }
            
            if(val_8 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            FerrPoly2Tri.Point2D val_9 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  static_value_0028000F, rhs:  this.mPosition);
            double val_10 = static_value_0028000F.MagnitudeSquared();
            static_value_0028000F.Normalize();
            val_20 = 536890297;
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    val_20 = 536890297;
            }
            
            var val_21 = mem[536890389];
            val_21 = val_21 * val_21;
            if(mem[536890413] <= 0)
            {
                goto label_21;
            }
            
            double val_12 = FerrPoly2Tri.Point2D.Dot(lhs:  val_18, rhs:  static_value_0028000F);
            double val_13 = FerrPoly2Tri.Point2D.Cross(lhs:  val_18, rhs:  static_value_0028000F);
            val_21 = 0;
            if(val_21 == 0)
            {
                goto label_22;
            }
            
            if(val_21 == 0)
            {
                    val_21 = 0;
            }
            
            FerrPoly2Tri.Point2D val_14 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  0, rhs:  this.mPosition);
            0.Normalize();
            val_18 = val_18;
            double val_15 = FerrPoly2Tri.Point2D.Dot(lhs:  val_18, rhs:  0);
            double val_16 = FerrPoly2Tri.Point2D.Cross(lhs:  val_18, rhs:  0);
            if(0 >= 0)
            {
                goto label_25;
            }
            
            if(0 <= 0)
            {
                goto label_28;
            }
            
            if(0 <= 0)
            {
                goto label_32;
            }
            
            goto label_28;
            label_22:
            val_22 = this.mConnected;
            val_18 = val_18;
            goto label_30;
            label_25:
            if((0 <= 0) || (0 < 0))
            {
                goto label_32;
            }
            
            label_28:
            val_22 = this.mConnected;
            label_30:
            if(val_18 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            label_32:
            var val_19 = 4 + 1;
            if((4 - 3) < this.NumConnected)
            {
                goto label_35;
            }
            
            return;
            label_21:
            label_37:
            22710780 = new System.Exception(message:  22788976);
            goto label_37;
        }
        public FerrPoly2Tri.SplitComplexPolygonNode GetRightestConnection(FerrPoly2Tri.Point2D incomingDir)
        {
            FerrPoly2Tri.Point2D val_1 = FerrPoly2Tri.Point2D.op_Subtraction(lhs:  this.mPosition, rhs:  incomingDir);
            536894289 = new FerrPoly2Tri.SplitComplexPolygonNode(pos:  this.mPosition);
            return this.GetRightestConnection(incoming:  536894289);
        }
    
    }

}
