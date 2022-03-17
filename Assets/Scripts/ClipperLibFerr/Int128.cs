using UnityEngine;

namespace ClipperLibFerr
{
    internal struct Int128
    {
        // Fields
        private long hi;
        private ulong lo;
        
        // Methods
        public Int128(long _lo)
        {
            this = R3 >> 31;
        }
        public Int128(long _hi, ulong _lo)
        {
            this.lo = ;
            mem[1152921510264543644] = ???;
        }
        public Int128(ClipperLibFerr.Int128 val)
        {
            this.lo = ;
            mem[1152921510264655644] = ???;
        }
        public bool IsNegative()
        {
            return false;
        }
        public static bool op_Equality(ClipperLibFerr.Int128 val1, ClipperLibFerr.Int128 val2)
        {
            ulong val_3 = val1.lo;
            val_3 = val_3;
            if(536888969 == 536888969)
            {
                    return true;
            }
            
            ulong val_3 = val2.lo;
            val_3 = val_3 ^ val_3;
            val_3 = val1.hi ^ val2.hi | val_3;
            ulong val_4 = val2.lo;
            val_4 = R3 ^ val_4;
            val_4 = R1 ^ val2.hi | val_4;
            val_3 = val_3 | val_4;
            val_3 = val_3 >> 5;
            return (bool)val_3;
        }
        public static bool op_Inequality(ClipperLibFerr.Int128 val1, ClipperLibFerr.Int128 val2)
        {
            bool val_1 = ClipperLibFerr.Int128.op_Equality(val1:  new ClipperLibFerr.Int128() {hi = val1.hi, lo = val1.lo}, val2:  new ClipperLibFerr.Int128() {hi = val2.hi, lo = val2.lo});
            val_1 = val_1 ^ 1;
            return (bool)val_1;
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
            
            if(null != 536888969)
            {
                    return (bool)val_4;
            }
            
            var val_2 = val_3;
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            var val_1 = R7 ^ R3;
            if(null != 536888969)
            {
                    return (bool)val_4;
            }
            
            val_1 = val_1 ^ R3;
            val_2 = val_2 ^ this.lo;
            val_2 = val_2 | val_1;
            val_4 = val_2 >> 5;
            return (bool)val_4;
        }
        public override int GetHashCode()
        {
            int val_2 = this.lo.GetHashCode();
            val_2 = val_2 ^ this.GetHashCode();
            return (int)val_2;
        }
        public static bool op_GreaterThan(ClipperLibFerr.Int128 val1, ClipperLibFerr.Int128 val2)
        {
            long val_1 = R1 ^ val2.hi;
            val_1 = val1.hi ^ val2.hi | val_1;
            val1.lo = val2.lo - val1.lo;
            if()
            {
                    0 = 1;
            }
            
            val1.hi = val2.hi - val1.hi;
            if()
            {
                    0 = 1;
            }
            
            return (bool)1;
        }
        public static bool op_LessThan(ClipperLibFerr.Int128 val1, ClipperLibFerr.Int128 val2)
        {
            long val_1 = R1 ^ val2.hi;
            val_1 = val1.hi ^ val2.hi | val_1;
            val1.lo = val1.lo - val2.lo;
            if()
            {
                    0 = 1;
            }
            
            val1.hi = val1.hi - val2.hi;
            if()
            {
                    0 = 1;
            }
            
            return (bool)1;
        }
        public static ClipperLibFerr.Int128 op_Addition(ClipperLibFerr.Int128 lhs, ClipperLibFerr.Int128 rhs)
        {
            val_3 = val_3 + lhs.lo;
            long val_2 = LR + rhs.hi;
            return new ClipperLibFerr.Int128() {hi = lhs.hi, lo = lhs.lo};
        }
        public static ClipperLibFerr.Int128 op_Subtraction(ClipperLibFerr.Int128 lhs, ClipperLibFerr.Int128 rhs)
        {
            var val_1;
            long val_2 = rhs.hi - LR;
            mem2[0] = val_2;
            var val_3 = 0 - LR;
            val_3 = val_2 - val_3;
            mem2[0] = rhs.hi;
            if()
            {
                    0 = 1;
            }
            
            ulong val_4 = 0 - rhs.lo;
            if((LR | val_1) != 0)
            {
                    rhs.hi = rhs.lo;
                rhs.hi = ~rhs.lo;
                val_4 = rhs.lo;
                val_4 = ~rhs.lo;
            }
            
            lhs.lo = val_4 + lhs.lo;
            if(1 == 0)
            {
                    lhs.lo + 1 = lhs.lo;
                val_4 = R3;
            }
            
            mem2[0] = lhs.lo + 1;
            mem2[0] = val_4;
            return new ClipperLibFerr.Int128() {hi = lhs.hi, lo = lhs.lo};
        }
        public static ClipperLibFerr.Int128 op_UnaryNegation(ClipperLibFerr.Int128 val)
        {
            var val_3;
            mem2[0] = 0 - val.lo;
            return new ClipperLibFerr.Int128() {hi = 0 - val_3, lo = val.lo};
        }
        public static double op_Explicit(ClipperLibFerr.Int128 val)
        {
            var val_1;
            var val_2;
            var val_3;
            double val_4;
            if(R1 > 1)
            {
                    val_1 = val.lo;
                val_2 = R3;
                val_3 = R1;
                return (double)D0;
            }
            
            if(R1 != 1)
            {
                    val_1 = ~val.lo;
                val_2 = ~R3;
                val_3 = R1;
                val_3 = ~R1;
                val_4 = -val_1;
                return (double)D0;
            }
            
            val_3 = R1;
            val_4 = val.hi * 0;
            return (double)D0;
        }
        public static ClipperLibFerr.Int128 Int128Mul(long lhs, long rhs)
        {
            var val_1;
            var val_2;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_8 = val_1;
            rhs = rhs + (((int)R3) >> 31);
            rhs = rhs ^ (((int)R3) >> 31);
            var val_3 = R4 ^ (((int)R3) >> 31);
            var val_4 = val_2 + (val_8 >> 31);
            val_4 = val_4 ^ (val_8 >> 31);
            var val_5 = R7 ^ (val_8 >> 31);
            rhs = R6 + rhs;
            val_10 = val_4 + LR;
            if(val_8 ^ R3 > 1)
            {
                    val_11 = rhs;
                val_12 = val_3;
            }
            else
            {
                    long val_7 = 0 - rhs;
                val_8 = val_2 | val_10;
                if(val_8 != 0)
            {
                    val_12 = val_3;
                val_12 = ~val_3;
                val_11 = rhs;
                val_11 = ~rhs;
            }
            
                val_9 = 0 - val_2;
            }
            
            mem2[0] = val_11;
            return new ClipperLibFerr.Int128() {hi = lhs, lo = rhs};
        }
    
    }

}
