using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    internal struct IntPoint : IEquatable<Com.LuisPedroFonseca.ProCamera2D.IntPoint>
    {
        // Fields
        public static Com.LuisPedroFonseca.ProCamera2D.IntPoint MaxValue;
        public int X;
        public int Y;
        
        // Methods
        public IntPoint(int x, int y)
        {
        
        }
        public bool IsEqual(Com.LuisPedroFonseca.ProCamera2D.IntPoint other)
        {
            if(other.X == new Com.LuisPedroFonseca.ProCamera2D.IntPoint())
            {
                    0 = this.Y;
                0 = other.Y - 0;
            }
            
            if(other.X == new Com.LuisPedroFonseca.ProCamera2D.IntPoint())
            {
                    0 = 0 >> 5;
            }
            
            return (bool)0;
        }
        public override string ToString()
        {
            var val_4;
            string val_1 = this.ToString();
            string val_2 = this.Y.ToString();
            string val_3 = -1610602475(-1610602475) + 1031250768 + -1610612497(-1610612497) + this.Y;
            val_4 = mem[mem[3221271783] + 186];
            val_4 = mem[3221271783] + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[mem[3221271783] + 186];
                val_4 = mem[3221271783] + 186;
            }
            
            if((mem[3221271783] + 186) != 1)
            {
                    return System.String.Format(format:  -1610602475, args:  mem[3221271783] + 92);
            }
            
            return System.String.Format(format:  -1610602475, args:  mem[3221271783] + 92);
        }
        public bool Equals(Com.LuisPedroFonseca.ProCamera2D.IntPoint other)
        {
            if(other.X == new Com.LuisPedroFonseca.ProCamera2D.IntPoint())
            {
                    0 = this.Y;
                0 = other.Y - 0;
            }
            
            if(other.X == new Com.LuisPedroFonseca.ProCamera2D.IntPoint())
            {
                    0 = 0 >> 5;
            }
            
            return (bool)0;
        }
        public override int GetHashCode()
        {
            int val_1 = this.Y;
            val_1 = (-3458764393706151936) ^ val_1;
            return (int)val_1;
        }
        private static IntPoint()
        {
            mem2[0] = 2147483648;
            mem2[0] = 2147483648;
        }
    
    }

}
