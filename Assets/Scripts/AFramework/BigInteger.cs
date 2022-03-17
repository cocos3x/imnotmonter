using UnityEngine;

namespace AFramework
{
    [Serializable]
    public class BigInteger
    {
        // Fields
        public int e;
        public float m;
        private static string[] sDisplayPostfix;
        private const int PowLimit = 100;
        
        // Methods
        public BigInteger()
        {
            this.e = 0;
            this.m = 0;
        }
        public BigInteger(AFramework.BigInteger other)
        {
            if(other != 0)
            {
                    this.e = other.e;
            }
            else
            {
                    this.e = 0;
            }
            
            this.m = other.m;
        }
        public BigInteger(float _m, int _e)
        {
            this.e = R2;
            this.m = _e;
            this.Normalize();
        }
        public BigInteger(long l)
        {
            if((mem[536890482] & true) == 0)
            {
                    R2 & (~2147483648) = mem[536890411];
            }
            
            this.e = ;
            double val_1 = System.Math.Pow(x:  null, y:  null);
            var val_2 = R2;
            val_2 = val_2 / (R2 & (~2147483648));
            this.m = ;
        }
        public BigInteger(double d)
        {
            int val_2;
            float val_3;
            val_2 = 0;
            val_3 = 0f;
            this.e = val_2;
            this.m = ;
        }
        public BigInteger(string str)
        {
            var val_13;
            int val_14;
            var val_15;
            var val_16;
            var val_17;
            if(str != null)
            {
                    val_13 = str;
                val_14 = str.m_stringLength;
            }
            else
            {
                    val_13 = 8;
                val_14 = 0f;
            }
            
            val_15 = str.IndexOf(value:  '.');
            int val_2 = str.IndexOf(value:  '+');
            if(val_2 < 0)
            {
                goto label_6;
            }
            
            if(str == null)
            {
                goto label_7;
            }
            
            val_16 = 0;
            goto label_8;
            label_6:
            val_17 = val_13 - 1;
            goto label_9;
            label_7:
            val_16 = 0;
            label_8:
            val_14 = val_2 - 1;
            string val_5 = str.Substring(startIndex:  val_2 + 1, length:  val_16 + (~val_2));
            label_9:
            this.e = System.Int32.Parse(s:  str);
            string val_8 = str.Substring(startIndex:  0, length:  System.Math.Min(val1:  val_14, val2:  10));
            float val_9 = System.Single.Parse(s:  str);
            int val_13 = System.Math.Min(val1:  val_13 - 1, val2:  10);
            double val_12 = System.Math.Pow(x:  null, y:  null);
            val_13 = str / val_13;
            this.m = val_13;
        }
        private void Normalize()
        {
            if()
            {
                    this.e = 0;
                return;
            }
            
            float val_2 = this.m;
            val_2 = val_2 & (~2147483648);
            int val_1 = UnityEngine.Mathf.FloorToInt(f:  this.m);
            if(val_1 == 0)
            {
                    return;
            }
            
            val_1 = this.e + val_1;
            this.e = val_1;
            uint val_3 = 1092616192;
            val_3 = this.m / val_3;
            this.m = val_3;
        }
        public static AFramework.BigInteger op_UnaryNegation(AFramework.BigInteger a)
        {
            float val_2;
            if(a != 0)
            {
                    val_2 = a.m;
            }
            else
            {
                    val_2 = 0f;
            }
            
            536884037 = new System.Object();
            mem[536884045] = a.e;
            mem[536884049] = val_2;
            this.Normalize();
        }
        public static AFramework.BigInteger op_Subtraction(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            int val_3;
            var val_4;
            val_3 = a.e;
            int val_3 = b.e;
            val_3 = val_3 - val_3;
            if(val_3 < 31)
            {
                    val_3 = b.e;
                object val_1 = 536884037;
                val_4 = val_1;
                val_1 = new System.Object();
                mem[536884045] = val_3;
                mem[536884049] = b.m;
                this.Normalize();
                return;
            }
            
            AFramework.BigInteger val_2 = 536884037;
            val_4 = val_2;
            val_2 = new AFramework.BigInteger(other:  a);
        }
        public static AFramework.BigInteger op_Addition(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            int val_3;
            var val_4;
            val_3 = a.e;
            int val_3 = b.e;
            val_3 = val_3 - val_3;
            if(val_3 < 31)
            {
                    val_3 = b.e;
                object val_1 = 536884037;
                val_4 = val_1;
                val_1 = new System.Object();
                mem[536884045] = val_3;
                mem[536884049] = b.m;
                this.Normalize();
                return;
            }
            
            AFramework.BigInteger val_2 = 536884037;
            val_4 = val_2;
            val_2 = new AFramework.BigInteger(other:  a);
        }
        public static AFramework.BigInteger op_Multiply(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            int val_4;
            float val_5;
            if(b != 0)
            {
                    val_4 = a.e;
                val_5 = b.m;
            }
            else
            {
                    val_4 = a.e;
                val_5 = 0f;
            }
            
            536884037 = new System.Object();
            mem[536884045] = b.e + val_4;
            mem[536884049] = a.m * val_5;
            this.Normalize();
        }
        public static AFramework.BigInteger op_Division(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            int val_4;
            float val_5;
            if(b != 0)
            {
                    val_4 = a.e;
                val_5 = b.m;
            }
            else
            {
                    val_4 = a.e;
                val_5 = 0f;
            }
            
            536884037 = new System.Object();
            mem[536884045] = val_4 - b.e;
            mem[536884049] = a.m / val_5;
            this.Normalize();
        }
        public static bool op_GreaterThan(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            AFramework.BigInteger val_1 = AFramework.BigInteger.op_Subtraction(a:  a, b:  b);
            if(a > 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool op_LessThan(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            AFramework.BigInteger val_1 = AFramework.BigInteger.op_Subtraction(a:  a, b:  b);
            if(a < 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool op_GreaterThanOrEqual(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            AFramework.BigInteger val_1 = AFramework.BigInteger.op_Subtraction(a:  a, b:  b);
            if(a >= 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool op_LessThanOrEqual(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            AFramework.BigInteger val_1 = AFramework.BigInteger.op_Subtraction(a:  a, b:  b);
            if(a <= 0)
            {
                    0 = 1;
            }
            
            return true;
        }
        public static bool op_Equality(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            AFramework.BigInteger val_1 = AFramework.BigInteger.op_Subtraction(a:  a, b:  b);
            if(a == 0)
            {
                    a = 1;
            }
            
            if(a != 0)
            {
                    a = a.e;
                a = a >> 31;
            }
            
            return (bool)a;
        }
        public static bool op_Inequality(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            bool val_1 = AFramework.BigInteger.op_Equality(a:  a, b:  b);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public static AFramework.BigInteger op_Implicit(int i)
        {
            int val_1 = i >> 31;
            536884037 = new AFramework.BigInteger(l:  0);
        }
        public static AFramework.BigInteger op_Implicit(float f)
        {
            536884037 = new AFramework.BigInteger(d:  null);
        }
        public static AFramework.BigInteger op_Implicit(double d)
        {
            536884037 = new AFramework.BigInteger(d:  d);
        }
        public static AFramework.BigInteger op_Implicit(long i)
        {
            536884037 = new AFramework.BigInteger(l:  0);
        }
        public static AFramework.BigInteger op_Implicit(string str)
        {
            536884037 = new AFramework.BigInteger(str:  str);
        }
        public float ToFloat()
        {
            uint val_1 = 1092616192;
            val_1 = this.m * val_1;
            return (float)val_1;
        }
        public int ToInt()
        {
            uint val_1 = 1092616192;
            val_1 = this.m * val_1;
            return UnityEngine.Mathf.RoundToInt(f:  val_1);
        }
        public string ToDisplayString(bool onlyInt = False)
        {
            var val_11;
            int val_12;
            var val_13;
            var val_14;
            val_11 = onlyInt;
            val_12 = this.e;
            if(val_12 <= 1)
            {
                    return;
            }
            
            if(val_12 <= 2)
            {
                goto label_2;
            }
            
            val_13 = 536884037;
            if(((mem[536884224] & true) == 0) && (mem[536884153] == 0))
            {
                    val_13 = 536884037;
            }
            
            val_11 = mem[mem[536884129]];
            val_11 = mem[536884129];
            var val_10 = mem[536884129] + 12;
            val_10 = val_10 + (val_10 << 1);
            if(val_12 >= val_10)
            {
                goto label_6;
            }
            
            int val_11 = val_12;
            val_12 = 21845;
            val_12 = 1431655766;
            var val_1 = R2 + ((R2) >> 31);
            val_1 = val_1 + (val_1 << 1);
            val_11 = val_11 - val_1;
            uint val_12 = 1092616192;
            val_12 = this.m * val_12;
            if(val_12 >= val_10)
            {
                    100f = 10f;
            }
            
            val_12 = val_12 * 100f;
            float val_13 = val_12;
            val_13 = val_13 / 100f;
            string val_2 = val_13.ToString();
            val_14 = 536884037;
            if(((mem[536884224] & true) == 0) && (mem[536884153] == 0))
            {
                    val_14 = 536884037;
            }
            
            var val_14 = mem[536884129];
            val_11 = val_14 + (val_14 >> 31);
            val_14 = val_14 + (val_11 << 2);
            string val_3 = 1167714536 + (mem[536884129] + ((mem[536884129] + (mem[536884129]) >> 31)) << 2) + 16((mem[536884129] + ((mem[536884129] + (mem[536884129]) >> 31)) << 2) + 16);
            return;
            label_2:
            uint val_15 = 1092616192;
            val_15 = this.m * val_15;
            if((val_12 == 2) || (val_11 == true))
            {
                goto label_14;
            }
            
            if(val_11 >= false)
            {
                    100f = 10f;
            }
            
            val_15 = val_15 * 100f;
            float val_16 = (float)UnityEngine.Mathf.RoundToInt(f:  val_15);
            val_16 = val_16 / 100f;
            string val_5 = val_16.ToString();
            return;
            label_6:
            string val_6 = this.m.ToString(format:  -1610608303);
            string val_7 = val_12.ToString();
            string val_8 = this.m + -1610608645(-1610608645) + 1167726584;
            return;
            label_14:
            string val_9 = (int)val_15.ToString();
        }
        public string ToShortDisplayString()
        {
            int val_9;
            var val_10;
            var val_11;
            var val_12;
            val_9 = this.e;
            if(val_9 <= 1)
            {
                    return;
            }
            
            if(val_9 <= 2)
            {
                goto label_2;
            }
            
            val_10 = 536884037;
            if(((mem[536884224] & true) == 0) && (mem[536884153] == 0))
            {
                    val_10 = 536884037;
            }
            
            val_11 = mem[mem[536884129]];
            val_11 = mem[536884129];
            var val_8 = mem[536884129] + 12;
            val_8 = val_8 + (val_8 << 1);
            if(val_9 >= val_8)
            {
                goto label_6;
            }
            
            int val_9 = val_9;
            val_9 = 21845;
            val_9 = 1431655766;
            var val_1 = R2 + ((R2) >> 31);
            val_1 = val_1 + (val_1 << 1);
            val_9 = val_9 - val_1;
            uint val_10 = 1092616192;
            val_10 = this.m * val_10;
            val_10 = val_10 * 10f;
            float val_11 = val_10;
            val_11 = val_11 / 10f;
            string val_2 = val_11.ToString();
            val_12 = 536884037;
            if(((mem[536884224] & true) == 0) && (mem[536884153] == 0))
            {
                    val_12 = 536884037;
            }
            
            var val_12 = mem[536884129];
            val_11 = val_12 + (val_12 >> 31);
            val_12 = val_12 + (val_11 << 2);
            string val_3 = 1167826536 + (mem[536884129] + ((mem[536884129] + (mem[536884129]) >> 31)) << 2) + 16((mem[536884129] + ((mem[536884129] + (mem[536884129]) >> 31)) << 2) + 16);
            return;
            label_2:
            uint val_13 = 1092616192;
            val_13 = this.m * val_13;
            string val_4 = (int)val_13.ToString();
            return;
            label_6:
            string val_5 = this.m.ToString(format:  -1610608303);
            string val_6 = val_9.ToString();
            string val_7 = this.m + -1610608645(-1610608645) + 1167838584;
        }
        public static AFramework.BigInteger Abs(AFramework.BigInteger a)
        {
            float val_2;
            if(a != 0)
            {
                    val_2 = System.Math.Abs(a.m);
            }
            else
            {
                    val_2 = System.Math.Abs(0f);
            }
            
            536884037 = new System.Object();
            mem[536884049] = 0f;
            mem[536884045] = a.e;
            this.Normalize();
        }
        public static AFramework.BigInteger Pow(AFramework.BigInteger a, int x)
        {
            int val_7;
            var val_8;
            AFramework.BigInteger val_9;
            val_7 = 22999038;
            if(x <= 1)
            {
                goto label_1;
            }
            
            if(x == 0)
            {
                goto label_2;
            }
            
            if(x >= 101)
            {
                goto label_3;
            }
            
            val_7 = a.e;
            object val_1 = 536884037;
            val_8 = val_1;
            val_1 = new System.Object();
            mem[536884049] = a.m;
            mem[536884045] = val_7 * x;
            this.Normalize();
            return;
            label_1:
            AFramework.BigInteger val_3 = AFramework.BigInteger.op_Implicit(i:  1);
            int val_4 = 0 - x;
            return AFramework.BigInteger.op_Division(a:  1, b:  a);
            label_2:
            AFramework.BigInteger val_5 = 536884037;
            val_8 = val_5;
            val_5 = new AFramework.BigInteger(l:  x);
            return;
            label_3:
            val_9 = 1;
            AFramework.BigInteger val_6 = AFramework.BigInteger.op_Implicit(i:  1);
            if(100 != 0)
            {
                    val_9 = a;
            }
            
            if((mem[536884224] & true) != 0)
            {
                    return AFramework.BigInteger.op_Multiply(a:  a, b:  val_9);
            }
            
            if(mem[536884153] != 0)
            {
                    return AFramework.BigInteger.op_Multiply(a:  a, b:  val_9);
            }
            
            return AFramework.BigInteger.op_Multiply(a:  a, b:  val_9);
        }
        public static AFramework.BigInteger Pow(AFramework.BigInteger a, float x)
        {
            AFramework.BigInteger val_1 = AFramework.BigInteger.op_Implicit(i:  1);
            var val_2 = R1 ^ 2147483648;
            return AFramework.BigInteger.op_Division(a:  1, b:  a);
        }
        public static AFramework.BigInteger Pow(AFramework.BigInteger a, AFramework.BigInteger b)
        {
            float val_1 = b.m;
            val_1 = val_1 * 1092616192;
            if((mem[536884224] & true) != 0)
            {
                    return AFramework.BigInteger.Pow(a:  a, x:  1092616192);
            }
            
            if(mem[536884153] != 0)
            {
                    return AFramework.BigInteger.Pow(a:  a, x:  1092616192);
            }
            
            return AFramework.BigInteger.Pow(a:  a, x:  1092616192);
        }
        private static BigInteger()
        {
            mem[536882417] = -1610612735;
            mem[536882421] = -1610606783;
            mem[536882425] = -1610606555;
            mem[536882429] = -1610610009;
            mem[536882433] = -1610604171;
            mem[536882437] = -1610601883;
            mem[536882441] = -1610601625;
            mem[536882445] = -1610601477;
            mem[536882449] = -1610600907;
            mem[536882453] = -1610600683;
            mem[536882457] = -1610600561;
            mem[536882461] = -1610600315;
            mem[536882465] = -1610600213;
            mem[536882469] = -1610600005;
            mem[536882473] = -1610599647;
            mem[536882477] = -1610599555;
            mem[536882481] = -1610599423;
            mem[536882485] = -1610599203;
            mem[536882489] = -1610599081;
            mem[536882493] = -1610598939;
            mem[536882497] = -1610598813;
            mem[536882501] = -1610598743;
            mem[536882505] = -1610598567;
            mem[536882509] = -1610598065;
            mem[536882513] = -1610597657;
            mem[536882517] = -1610597507;
            mem[536882521] = -1610597421;
            mem[536882525] = -1610597341;
            mem[536882529] = -1610597205;
            mem[536882533] = -1610597189;
            mem[536882537] = -1610597139;
            mem2[0] = 536882401;
        }
    
    }

}
