using UnityEngine;

namespace WrappingRopeLibrary.Events
{
    public sealed class ObjectWrapEventHandler : MulticastDelegate
    {
        // Methods
        public ObjectWrapEventHandler(object object, IntPtr method)
        {
            mem[1152921509803244512] = object;
            mem[1152921509803244516] = method;
            mem[1152921509803244504] = method;
        }
        public virtual void Invoke(WrappingRopeLibrary.Scripts.RopeBase sender, WrappingRopeLibrary.Events.ObjectWrapEventArgs args)
        {
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            if(this != 0)
            {
                    if(sender == 0)
            {
                    return;
            }
            
                val_10 = 1152921509803368800;
            }
            
            var val_18 = 0;
            goto label_45;
            label_44:
            val_11 = R7;
            if(val_11 == 0)
            {
                goto label_4;
            }
            
            if(R7 == 0)
            {
                goto label_5;
            }
            
            val_12 = args;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_13 = sender;
            goto label_43;
            label_4:
            val_11 = mem[R7 + 40];
            val_11 = R7 + 40;
            if(R7 == 0)
            {
                goto label_10;
            }
            
            float val_1 = R7.yAdvance;
            val_14 = 0;
            val_14 = val_14 + 1;
            val_15 = sender;
            goto label_14;
            label_5:
            var val_10 = R7 + 40;
            val_10 = 1152921504901255168 + (val_10 << 3);
            goto label_43;
            label_10:
            WrappingRopeLibrary.Scripts.RopeBase val_2 = 1152921504901255168 + (val_11 << 3);
            goto label_43;
            label_37:
            val_12 = mem[R7 + 40];
            val_12 = R7 + 40;
            if((sender.Equals(other:  args)) == false)
            {
                goto label_17;
            }
            
            float val_4 = R7.yAdvance;
            var val_16 = val_11;
            if((R7 + 40 + 178) == 0)
            {
                goto label_18;
            }
            
            var val_11 = 0;
            label_20:
            if((R7 + 40 + 88 + 0) == R7)
            {
                goto label_19;
            }
            
            val_11 = val_11 + 1;
            if(((uint)val_11 & 65535) < (R7 + 40 + 178))
            {
                goto label_20;
            }
            
            label_18:
            val_16 = val_11;
            goto label_43;
            label_38:
            var val_12 = (0 + 1) + 40;
            val_12 = val_11 + (val_12 << 3);
            goto label_43;
            label_17:
            var val_13 = val_11;
            val_13 = val_13 + (val_12 << 3);
            goto label_43;
            label_14:
            WrappingRopeLibrary.Scripts.RopeBase val_14 = sender;
            goto label_43;
            label_40:
            val_14 = val_14 + (args << 3);
            goto label_43;
            label_19:
            var val_8 = (R7 + 40 + 88) + 0;
            var val_15 = (R7 + 40 + 88 + 0) + 4;
            val_15 = val_15 + val_12;
            val_16 = val_16 + (val_15 << 3);
            val_16 = val_16 + 188;
            goto label_43;
            label_45:
            if(R7 == 0)
            {
                goto label_29;
            }
            
            if((R7 + 42) == 2)
            {
                goto label_33;
            }
            
            goto label_43;
            label_29:
            if((R7 + 42) != 2)
            {
                goto label_32;
            }
            
            if(R6 == 0)
            {
                goto label_33;
            }
            
            if((((R7 + 40) == 65535) || ((R6 + 157) != 1)) || ((R6 + 157) == 0))
            {
                goto label_43;
            }
            
            if(R7 == 0)
            {
                goto label_37;
            }
            
            if(R7 == 0)
            {
                goto label_38;
            }
            
            if((R6 + 178) == 0)
            {
                goto label_43;
            }
            
            var val_17 = 0;
            label_41:
            if((R6 + 88 + 0) == (R7 + 12))
            {
                goto label_40;
            }
            
            val_17 = val_17 + 1;
            if(((uint)val_17 & 65535) < (R6 + 178))
            {
                goto label_41;
            }
            
            goto label_43;
            label_32:
            if((R7 + 40) != 0)
            {
                goto label_44;
            }
            
            label_33:
            label_43:
            val_18 = val_18 + 1;
            if(val_18 != 1)
            {
                goto label_45;
            }
        
        }
        public virtual System.IAsyncResult BeginInvoke(WrappingRopeLibrary.Scripts.RopeBase sender, WrappingRopeLibrary.Events.ObjectWrapEventArgs args, System.AsyncCallback callback, object object)
        {
        
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
