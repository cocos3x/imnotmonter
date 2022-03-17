using UnityEngine;

namespace WrappingRopeLibrary.Events
{
    public sealed class Mouse : MulticastDelegate
    {
        // Methods
        public Mouse(object object, IntPtr method)
        {
            mem[1152921509802263904] = object;
            mem[1152921509802263908] = method;
            mem[1152921509802263896] = method;
        }
        public virtual void Invoke(UnityEngine.Vector2 position)
        {
            float val_3;
            var val_6;
            var val_7;
            float val_8;
            var val_9;
            if(this != 0)
            {
                    if(R8 == 0)
            {
                    return;
            }
            
                val_7 = 1152921509802380000;
            }
            else
            {
                    val_6 = 1;
            }
            
            var val_11 = 0;
            goto label_28;
            label_21:
            if(900553660 == 0)
            {
                goto label_4;
            }
            
            float val_1 = R7.yAdvance;
            val_8 = position.x;
            if((R6 + 178) == 0)
            {
                goto label_5;
            }
            
            var val_5 = 0;
            label_7:
            if((R6 + 88 + 0) == R7)
            {
                goto label_6;
            }
            
            val_5 = val_5 + 1;
            if(((uint)val_5 & 65535) < (R6 + 178))
            {
                goto label_7;
            }
            
            label_5:
            val_9 = R6;
            val_8 = val_8;
            goto label_27;
            label_22:
            var val_6 = (0 + 1) + 40;
            val_6 = R6 + (val_6 << 3);
            goto label_27;
            label_4:
            var val_7 = R6;
            val_7 = val_7 + ((R7 + 40) << 3);
            goto label_27;
            label_24:
            var val_2 = (R7 + 40) + 2909558400;
            var val_8 = (R7 + 40 + 2909558400) + 4;
            val_8 = val_8 + position.y;
            val_8 = IP + (val_8 << 3);
            val_8 = val_8 + 188;
            goto label_27;
            label_6:
            var val_4 = (R6 + 88) + 0;
            var val_9 = (R6 + 88 + 0) + 4;
            val_9 = val_9 + (R7 + 40);
            val_9 = R6 + (val_9 << 3);
            val_9 = val_9 + 188;
            goto label_27;
            label_28:
            if(R7 == 0)
            {
                goto label_14;
            }
            
            if((R7 + 42) != 1)
            {
                goto label_27;
            }
            
            goto label_27;
            label_14:
            if(R6 == 0)
            {
                goto label_17;
            }
            
            if((((R7 + 40) == 65535) || ((R6 + 157) != 1)) || ((R6 + 157) == 0))
            {
                goto label_27;
            }
            
            if(R7 == 0)
            {
                goto label_21;
            }
            
            if(R7 == 0)
            {
                goto label_22;
            }
            
            val_3 = position.y;
            if((R6 + 178) == 0)
            {
                goto label_27;
            }
            
            var val_10 = 0;
            label_25:
            if((R6 + 88 + 0) == (R7 + 12))
            {
                goto label_24;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (R6 + 178))
            {
                goto label_25;
            }
            
            goto label_27;
            label_17:
            label_27:
            val_11 = val_11 + 1;
            if(val_11 != val_6)
            {
                goto label_28;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(UnityEngine.Vector2 position, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
