using UnityEngine;

namespace FerrPoly2Tri
{
    public class MathUtil
    {
        // Fields
        public static double EPSILON;
        
        // Methods
        public static bool AreValuesEqual(double val1, double val2)
        {
            if(((mem[536890484] & true) == 0) && (mem[536890413] == 0))
            {
                    536890297 = 536890297;
            }
            
            var val_2 = mem[536890389];
            double val_1 = R2 - val_2;
            val_2 = val_2 + R2;
            if(mem[536890413] <= 0)
            {
                    0 = 1;
            }
            
            if(mem[536890413] >= 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool AreValuesEqual(double val1, double val2, double tolerance)
        {
            var val_1;
            var val_3 = val_1;
            double val_2 = R2 - val_3;
            val_3 = R2 + val_3;
            if()
            {
                    0 = 1;
            }
            
            if()
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool IsValueBetween(double val, double min, double max, double tolerance)
        {
            var val_1;
            var val_2;
            var val_4 = val_2;
            double val_3 = 0 + val_4;
            if()
            {
                    R2 = val_1;
            }
            
            if()
            {
                    return false;
            }
            
            val_4 = 0 - val_4;
            if()
            {
                    val_1 = R2;
            }
            
            if()
            {
                    1 = 0;
            }
            
            return (bool)1;
        }
        public static double RoundWithPrecision(double f, double precision)
        {
            var val_4;
            bool val_5;
            val_4 = 0;
            val_5 = mem[536890482];
            if((val_5 & true) == 0)
            {
                    val_5 = mem[536890411];
            }
            
            double val_2 = val_5 * val_4;
            val_4 = val_5 / val_5;
            return (double)System.Math.Pow(x:  f, y:  precision);
        }
        public static double Clamp(double a, double low, double high)
        {
            return (double)System.Math.Max(val1:  System.Math.Min(val1:  a, val2:  low), val2:  low);
        }
        public static void Swap<T>(ref T a, ref T b)
        {
            a = b;
            b = a;
        }
        public static uint Jenkins32Hash(byte[] data, uint nInitialValue)
        {
            var val_2;
            var val_3;
            val_2 = nInitialValue;
            val_3 = 0;
            goto label_0;
            label_3:
            val_3 = 1;
            uint val_1 = val_2 + 1152921504940361920;
            val_1 = val_1 + (val_1 << 10);
            val_2 = val_1 + (val_1 >> 6);
            label_0:
            if(val_3 < val_1)
            {
                goto label_3;
            }
            
            val_1 = val_2 + (val_2 << 3);
            return 0;
        }
        public MathUtil()
        {
        
        }
        private static MathUtil()
        {
            mem2[0] = 2167269905;
            mem2[0] = 1030854553;
        }
    
    }

}
