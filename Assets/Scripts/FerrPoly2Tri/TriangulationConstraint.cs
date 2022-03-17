using UnityEngine;

namespace FerrPoly2Tri
{
    public class TriangulationConstraint : Edge
    {
        // Fields
        private uint mContraintCode;
        
        // Properties
        public FerrPoly2Tri.TriangulationPoint P { get; set; }
        public FerrPoly2Tri.TriangulationPoint Q { get; set; }
        public uint ConstraintCode { get; }
        
        // Methods
        public FerrPoly2Tri.TriangulationPoint get_P()
        {
            if(R1 == 0)
            {
                    return;
            }
            
            if((R1 + 180) < mem[536895999])
            {
                    return;
            }
            
            var val_1 = R1 + 100;
            val_1 = val_1 + (mem[536895999] << 2);
        }
        public void set_P(FerrPoly2Tri.TriangulationPoint value)
        {
            if(R2 == value)
            {
                    return;
            }
            
            mem2[0] = value;
            R4.CalculateContraintCode();
        }
        public FerrPoly2Tri.TriangulationPoint get_Q()
        {
            if(R1 == 0)
            {
                    return;
            }
            
            if((R1 + 180) < mem[536895999])
            {
                    return;
            }
            
            var val_1 = R1 + 100;
            val_1 = val_1 + (mem[536895999] << 2);
        }
        public void set_Q(FerrPoly2Tri.TriangulationPoint value)
        {
            if(R2 == value)
            {
                    return;
            }
            
            mem2[0] = value;
            R4.CalculateContraintCode();
        }
        public uint get_ConstraintCode()
        {
            return (uint)this.mContraintCode;
        }
        public TriangulationConstraint(FerrPoly2Tri.TriangulationPoint p1, FerrPoly2Tri.TriangulationPoint p2)
        {
            var val_1;
            var val_2;
            mem[1152921510228912920] = p1;
            mem[1152921510228912924] = p2;
            if(p2 > 0)
            {
                goto label_2;
            }
            
            val_1 = p1;
            val_2 = typeof(FerrPoly2Tri.TriangulationPoint).__il2cppRuntimeField_F8;
            if(p2 != 0)
            {
                goto label_5;
            }
            
            val_1 = p1;
            val_2 = typeof(FerrPoly2Tri.TriangulationPoint).__il2cppRuntimeField_E8;
            if(p2 <= 0)
            {
                goto label_4;
            }
            
            label_2:
            mem[1152921510228912924] = p1;
            mem[1152921510228912920] = p2;
            goto label_5;
            label_4:
            label_5:
            this.CalculateContraintCode();
        }
        public override string ToString()
        {
            mem[536882417] = -1610602313;
            FerrPoly2Tri.TriangulationPoint val_1 = this.P;
            mem[536882421] = this;
            mem[536882425] = -1610611889;
            FerrPoly2Tri.TriangulationPoint val_2 = this.Q;
            mem[536882429] = this;
            mem[536882433] = -1610612485;
            string val_3 = this.mContraintCode.ToString();
            mem[536882437] = this.mContraintCode;
            mem[536882441] = -1610596927;
            return +536882401;
        }
        public void CalculateContraintCode()
        {
            FerrPoly2Tri.TriangulationPoint val_1 = this.P;
            FerrPoly2Tri.TriangulationPoint val_2 = this.Q;
            this.mContraintCode = FerrPoly2Tri.TriangulationConstraint.CalculateContraintCode(p:  1327330832, q:  1327330832);
        }
        public static uint CalculateContraintCode(FerrPoly2Tri.TriangulationPoint p, FerrPoly2Tri.TriangulationPoint q)
        {
            if(p != 0)
            {
                    System.Byte[] val_1 = System.BitConverter.GetBytes(value:  p.mVertexCode);
                System.Byte[] val_3 = System.BitConverter.GetBytes(value:  q.mVertexCode);
                return FerrPoly2Tri.MathUtil.Jenkins32Hash(data:  q.mVertexCode, nInitialValue:  FerrPoly2Tri.MathUtil.Jenkins32Hash(data:  p.mVertexCode, nInitialValue:  0));
            }
            
            22709200 = new System.ArgumentNullException();
        }
    
    }

}
