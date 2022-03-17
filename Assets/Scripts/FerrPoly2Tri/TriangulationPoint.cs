using UnityEngine;

namespace FerrPoly2Tri
{
    public class TriangulationPoint : Point2D
    {
        // Fields
        public static readonly double kVertexCodeDefaultPrecision;
        protected uint mVertexCode;
        protected int id;
        private System.Collections.Generic.List<FerrPoly2Tri.DTSweepConstraint> <Edges>k__BackingField;
        
        // Properties
        public override double X { get; set; }
        public override double Y { get; set; }
        public uint VertexCode { get; }
        public int Id { get; }
        public System.Collections.Generic.List<FerrPoly2Tri.DTSweepConstraint> Edges { get; set; }
        public bool HasEdges { get; }
        
        // Methods
        public override double get_X()
        {
            return (double)D0;
        }
        public override void set_X(double value)
        {
            var val_2;
            var val_3;
            val_2 = 22969874;
            mem[1152921510231499800] = R2;
            val_2 = 22716056;
            val_3 = 536895819;
            if(((mem[536896006] & true) == 0) && (mem[536895935] == 0))
            {
                    val_3 = 536895819;
            }
            
            this.mVertexCode = FerrPoly2Tri.TriangulationPoint.CreateVertexCode(x:  value, y:  null, precision:  null);
        }
        public override double get_Y()
        {
            return (double)D0;
        }
        public override void set_Y(double value)
        {
            var val_2;
            var val_3;
            bool val_4;
            val_2 = 22969875;
            mem[1152921510231723808] = R2;
            val_2 = 22716056;
            val_3 = 536895819;
            val_4 = mem[536896006];
            if((val_4 & true) == 0)
            {
                    val_4 = mem[536895935];
                if(val_4 == 0)
            {
                    val_3 = 536895819;
            }
            
            }
            
            this.mVertexCode = FerrPoly2Tri.TriangulationPoint.CreateVertexCode(x:  value, y:  null, precision:  null);
        }
        public uint get_VertexCode()
        {
            return (uint)this.mVertexCode;
        }
        public int get_Id()
        {
            return (int)this.id;
        }
        public System.Collections.Generic.List<FerrPoly2Tri.DTSweepConstraint> get_Edges()
        {
        
        }
        private void set_Edges(System.Collections.Generic.List<FerrPoly2Tri.DTSweepConstraint> value)
        {
            this.<Edges>k__BackingField = value;
        }
        public bool get_HasEdges()
        {
            if((this.<Edges>k__BackingField) != 0)
            {
                    this.<Edges>k__BackingField = 1;
            }
            
            return true;
        }
        public TriangulationPoint(double x, double y, int aId = -1)
        {
            var val_3;
            bool val_4;
            val_3 = 536895819;
            val_4 = mem[536896006];
            if((val_4 & true) != 0)
            {
                    return;
            }
            
            val_4 = mem[536895935];
            if(val_4 != 0)
            {
                    return;
            }
            
            val_3 = 536895819;
        }
        public TriangulationPoint(double x, double y, double precision, int aId = -1)
        {
            this.id = 0;
            this.mVertexCode = FerrPoly2Tri.TriangulationPoint.CreateVertexCode(x:  x, y:  y, precision:  precision);
        }
        public override string ToString()
        {
            mem[536882417] = -1610612181;
            string val_1 = this.id.ToString();
            mem[536882421] = this.id;
            mem[536882425] = -1610610741;
            string val_2 = this.ToString();
            mem[536882429] = this;
            mem[536882433] = -1610610707;
            string val_3 = this.mVertexCode.ToString();
            mem[536882437] = this.mVertexCode;
            mem[536882441] = -1610596933;
            return +536882401;
        }
        public override int GetHashCode()
        {
            return (int)this.mVertexCode;
        }
        public override bool Equals(object obj)
        {
            if(obj == 0)
            {
                    return this.Equals(obj:  obj);
            }
            
            var val_1 = 536895819;
            return this.Equals(obj:  obj);
        }
        public override void Set(double x, double y)
        {
            float val_1;
            var val_3;
            var val_4;
            val_3 = 22969880;
            mem[1152921510232988568] = R2;
            mem[1152921510232988576] = val_1;
            val_3 = 22716056;
            val_4 = 536895819;
            if(((mem[536896006] & true) == 0) && (mem[536895935] == 0))
            {
                    val_4 = 536895819;
            }
            
            this.mVertexCode = FerrPoly2Tri.TriangulationPoint.CreateVertexCode(x:  x, y:  y, precision:  null);
        }
        public static uint CreateVertexCode(double x, double y, double precision)
        {
            double val_3 = FerrPoly2Tri.MathUtil.RoundWithPrecision(f:  FerrPoly2Tri.MathUtil.RoundWithPrecision(f:  x, precision:  y), precision:  y);
            System.Byte[] val_4 = System.BitConverter.GetBytes(value:  null);
            System.Byte[] val_6 = System.BitConverter.GetBytes(value:  null);
            return FerrPoly2Tri.MathUtil.Jenkins32Hash(data:  S16, nInitialValue:  FerrPoly2Tri.MathUtil.Jenkins32Hash(data:  S0, nInitialValue:  0));
        }
        public void AddEdge(FerrPoly2Tri.DTSweepConstraint e)
        {
            if((this.<Edges>k__BackingField) == 0)
            {
                    22969882 = 536877839;
                22969882 = new System.Collections.Generic.List<Page>();
                this.<Edges>k__BackingField = 22969882;
            }
            
            0.Add(item:  e);
        }
        public bool HasEdge(FerrPoly2Tri.TriangulationPoint p)
        {
            return (bool)this.GetEdge(p:  p, edge: out  FerrPoly2Tri.DTSweepConstraint val_1 = 1331518756);
        }
        public bool GetEdge(FerrPoly2Tri.TriangulationPoint p, out FerrPoly2Tri.DTSweepConstraint edge)
        {
            FerrPoly2Tri.DTSweepConstraint val_4;
            var val_13;
            var val_14;
            edge = 0;
            if(p == 0)
            {
                    return false;
            }
            
            if((this.<Edges>k__BackingField) < 1)
            {
                    return false;
            }
            
            if((p.Equals(p:  1331663168)) == true)
            {
                    return false;
            }
            
            List.Enumerator<T> val_2 = GetEnumerator();
            label_17:
            bool val_3 = MoveNext();
            if(val_3 == false)
            {
                goto label_5;
            }
            
            FerrPoly2Tri.TriangulationPoint val_5 = val_4.P;
            if((val_4.Equals(p:  1331663168)) == false)
            {
                goto label_8;
            }
            
            FerrPoly2Tri.TriangulationPoint val_7 = val_4.Q;
            if((val_4.Equals(p:  p)) == true)
            {
                goto label_11;
            }
            
            label_8:
            FerrPoly2Tri.TriangulationPoint val_9 = val_4.P;
            if((val_4.Equals(p:  p)) == false)
            {
                goto label_17;
            }
            
            FerrPoly2Tri.TriangulationPoint val_11 = val_4.Q;
            if((val_4.Equals(p:  1331663168)) == false)
            {
                goto label_17;
            }
            
            label_11:
            edge = val_4;
            val_13 = 1;
            val_14 = 3;
            goto label_18;
            label_5:
            val_13 = 0;
            val_14 = 1;
            label_18:
            Dispose();
            var val_13 = val_14 + 1;
            val_13 = (val_13 & 3) - val_13;
            if(val_3 == true)
            {
                    val_13 = 1;
            }
            
            var val_15 = 1 & val_13;
            return false;
        }
        public static FerrPoly2Tri.Point2D ToPoint2D(FerrPoly2Tri.TriangulationPoint p)
        {
        
        }
        private static TriangulationPoint()
        {
            mem2[0] = 0;
            mem2[0] = 1074266112;
        }
    
    }

}
