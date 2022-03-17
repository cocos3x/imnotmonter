using UnityEngine;

namespace B83.ExpressionParser
{
    public sealed class MultiResultDelegate : MulticastDelegate
    {
        // Methods
        public MultiResultDelegate(object object, IntPtr method)
        {
            mem[1152921510109754016] = object;
            mem[1152921510109754020] = method;
            mem[1152921510109754008] = method;
        }
        public virtual double[] Invoke(double[] aParams)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            if(this != 0)
            {
                    if(R8 == 0)
            {
                    return;
            }
            
                val_14 = 1152921510109906976;
            }
            else
            {
                    val_13 = 1;
            }
            
            var val_18 = 0;
            goto label_45;
            label_44:
            val_15 = R6;
            if(val_15 == 0)
            {
                goto label_4;
            }
            
            if(R6 == 0)
            {
                goto label_5;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_16 = aParams;
            goto label_43;
            label_4:
            val_15 = mem[R6 + 40];
            val_15 = R6 + 40;
            if(R6 == 0)
            {
                goto label_10;
            }
            
            float val_1 = R6.yAdvance;
            val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = aParams;
            goto label_43;
            label_5:
            var val_13 = R6 + 40;
            val_13 = 1152921504993718320 + (val_13 << 3);
            goto label_43;
            label_10:
            System.Double[] val_2 = 1152921504993718320 + (val_15 << 3);
            goto label_43;
            label_37:
            if(aParams == null)
            {
                goto label_17;
            }
            
            float val_3 = R6.yAdvance;
            if((R6 + 40 + 178) == 0)
            {
                goto label_18;
            }
            
            val_17 = 0;
            label_20:
            if((R6 + 40 + 88 + 0) == R6)
            {
                goto label_19;
            }
            
            val_17 = val_17 + 1;
            if(((uint)val_17 & 65535) < (R6 + 40 + 178))
            {
                goto label_20;
            }
            
            label_18:
            val_19 = val_15;
            goto label_43;
            label_38:
            var val_14 = (val_17 + 1) + 40;
            val_14 = val_15 + (val_14 << 3);
            goto label_43;
            label_17:
            var val_15 = val_15;
            val_15 = val_15 + ((R6 + 40) << 3);
            goto label_43;
            label_19:
            var val_11 = (R6 + 40 + 88) + 0;
            var val_16 = (R6 + 40 + 88 + 0) + 4;
            val_16 = val_16 + (R6 + 40);
            val_16 = val_15 + (val_16 << 3);
            val_19 = val_16 + 188;
            goto label_43;
            label_45:
            if(R6 == 0)
            {
                goto label_29;
            }
            
            if((R6 + 42) == 1)
            {
                goto label_33;
            }
            
            goto label_43;
            label_29:
            if((R6 + 42) != 1)
            {
                goto label_32;
            }
            
            if(R7 == 0)
            {
                goto label_33;
            }
            
            if((((R6 + 40) == 65535) || ((R7 + 157) != 1)) || ((R7 + 157) == 0))
            {
                goto label_43;
            }
            
            if(R6 == 0)
            {
                goto label_37;
            }
            
            if(R6 == 0)
            {
                goto label_38;
            }
            
            if((R7 + 178) == 0)
            {
                goto label_43;
            }
            
            var val_17 = 0;
            do
            {
                if((R7 + 88 + 0) == (R6 + 12))
            {
                goto label_43;
            }
            
                val_17 = val_17 + 1;
            }
            while(((uint)val_17 & 65535) < (R7 + 178));
            
            goto label_43;
            label_32:
            if((R6 + 40) != 0)
            {
                goto label_44;
            }
            
            label_33:
            label_43:
            val_18 = val_18 + 1;
            if(val_18 != val_13)
            {
                goto label_45;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(double[] aParams, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual double[] EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
