using UnityEngine;
public sealed class SaveGameManager.StringDataCallback : MulticastDelegate
{
    // Methods
    public SaveGameManager.StringDataCallback(object object, IntPtr method)
    {
        mem[1152921510076774112] = object;
        mem[1152921510076774116] = method;
        mem[1152921510076774104] = method;
    }
    public virtual void Invoke(string data)
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
                if(R8 == 0)
        {
                return;
        }
        
            val_11 = 1152921510076894304;
        }
        else
        {
                val_10 = 1;
        }
        
        var val_15 = 0;
        goto label_45;
        label_44:
        val_12 = R6;
        if(val_12 == 0)
        {
            goto label_4;
        }
        
        if(R6 == 0)
        {
            goto label_5;
        }
        
        var val_9 = 0;
        val_9 = val_9 + 1;
        val_13 = data;
        goto label_43;
        label_4:
        val_12 = mem[R6 + 40];
        val_12 = R6 + 40;
        if(R6 == 0)
        {
            goto label_10;
        }
        
        float val_1 = R6.yAdvance;
        val_14 = 0;
        val_14 = val_14 + 1;
        val_15 = data;
        goto label_43;
        label_5:
        var val_10 = R6 + 40;
        val_10 = 1152921504621649920 + (val_10 << 3);
        goto label_43;
        label_10:
        string val_2 = 1152921504621649920 + (val_12 << 3);
        goto label_43;
        label_37:
        if(data == null)
        {
            goto label_17;
        }
        
        float val_3 = R6.yAdvance;
        if((R6 + 40 + 178) == 0)
        {
            goto label_18;
        }
        
        val_14 = 0;
        label_20:
        if((R6 + 40 + 88 + 0) == R6)
        {
            goto label_19;
        }
        
        val_14 = val_14 + 1;
        if(((uint)val_14 & 65535) < (R6 + 40 + 178))
        {
            goto label_20;
        }
        
        label_18:
        val_16 = val_12;
        goto label_43;
        label_38:
        var val_11 = (val_14 + 1) + 40;
        val_11 = val_12 + (val_11 << 3);
        goto label_43;
        label_17:
        var val_12 = val_12;
        val_12 = val_12 + ((R6 + 40) << 3);
        goto label_43;
        label_19:
        var val_8 = (R6 + 40 + 88) + 0;
        var val_13 = (R6 + 40 + 88 + 0) + 4;
        val_13 = val_13 + (R6 + 40);
        val_13 = val_12 + (val_13 << 3);
        val_16 = val_13 + 188;
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
        
        var val_14 = 0;
        do
        {
            if((R7 + 88 + 0) == (R6 + 12))
        {
            goto label_43;
        }
        
            val_14 = val_14 + 1;
        }
        while(((uint)val_14 & 65535) < (R7 + 178));
        
        goto label_43;
        label_32:
        if((R6 + 40) != 0)
        {
            goto label_44;
        }
        
        label_33:
        label_43:
        val_15 = val_15 + 1;
        if(val_15 != val_10)
        {
            goto label_45;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(string data, System.AsyncCallback callback, object object)
    {
    
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
