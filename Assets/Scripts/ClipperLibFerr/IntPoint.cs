using UnityEngine;

namespace ClipperLibFerr
{
    public struct IntPoint
    {
        // Fields
        public long X;
        public long Y;
        
        // Methods
        public IntPoint(long X, long Y)
        {
            this.Y = ;
            mem[1152921510266119836] = ???;
        }
        public IntPoint(double x, double y)
        {
            long val_1;
            this.Y = val_1;
            this = R2;
        }
        public IntPoint(ClipperLibFerr.IntPoint pt)
        {
            this.Y = ;
            mem[1152921510266343836] = ???;
        }
        public static bool op_Equality(ClipperLibFerr.IntPoint a, ClipperLibFerr.IntPoint b)
        {
            a.X = a.X ^ b.X;
            long val_2 = R1 ^ b.X;
            a.Y = a.Y ^ b.Y;
            val_2 = val_2 | R3 ^ b.Y;
            a.X = a.X | a.Y;
            a.X = a.X | val_2;
            a.X = a.X >> 5;
            return (bool)a.X;
        }
        public static bool op_Inequality(ClipperLibFerr.IntPoint a, ClipperLibFerr.IntPoint b)
        {
            long val_1 = R1 ^ b.X;
            a.X = a.X ^ b.X;
            a.Y = a.Y ^ b.Y;
            a.X = a.Y | a.X;
            val_1 = R3 ^ b.Y | val_1;
            if()
            {
                    a.X = 1;
            }
            
            return true;
        }
        public override bool Equals(object obj)
        {
            var val_3;
            var val_4;
            val_3 = obj;
            val_4 = 0;
            if(val_3 == 0)
            {
                    return (bool)val_4;
            }
            
            if(null != 536889075)
            {
                    return (bool)val_4;
            }
            
            var val_2 = val_3;
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            var val_1 = R7 ^ R3;
            if(null != 536889075)
            {
                    return (bool)val_4;
            }
            
            val_1 = R3 ^ val_1;
            val_2 = this.Y ^ val_2;
            val_2 = val_2 | val_1;
            val_4 = val_2 >> 5;
            return (bool)val_4;
        }
        public override int GetHashCode()
        {
            return (int)536889075.GetHashCode();
        }
    
    }

}
