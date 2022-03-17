using UnityEngine;
public sealed class SpriteBasedLaser.LaserHitTriggerHandler : MulticastDelegate
{
    // Methods
    public SpriteBasedLaser.LaserHitTriggerHandler(object object, IntPtr method)
    {
        mem[1152921510385178528] = object;
        mem[1152921510385178532] = method;
        mem[1152921510385178520] = method;
    }
    public virtual void Invoke(UnityEngine.RaycastHit2D hitInfo)
    {
        float val_3;
        float val_4;
        float val_7;
        float val_8;
        var val_9;
        float val_10;
        float val_11;
        var val_12;
        val_7 = hitInfo.m_Normal.y;
        val_8 = hitInfo.m_Distance;
        if(this != 0)
        {
                if(hitInfo.m_Centroid.x == 0f)
        {
                return;
        }
        
            val_9 = 1152921510385294624;
        }
        
        var val_12 = 0;
        goto label_29;
        label_22:
        if(1 == 0)
        {
            goto label_5;
        }
        
        float val_1 = val_7.yAdvance;
        val_11 = hitInfo.m_Centroid.x;
        val_10 = hitInfo.m_Centroid.y;
        if((SB + 178) == 0)
        {
            goto label_6;
        }
        
        var val_6 = 0;
        label_8:
        val_8 = mem[SB + 88 + 0];
        val_8 = SB + 88 + 0;
        if(val_8 == val_7)
        {
            goto label_7;
        }
        
        val_6 = val_6 + 1;
        if(((uint)val_6 & 65535) < (SB + 178))
        {
            goto label_8;
        }
        
        label_6:
        val_12 = SB;
        val_11 = val_11;
        goto label_13;
        label_23:
        var val_7 = (0 + 1) + 40;
        val_7 = SB + (val_7 << 3);
        val_7 = val_11;
        goto label_13;
        label_5:
        var val_8 = SB;
        val_8 = val_8 + ((hitInfo.m_Normal.y + 40) << 3);
        val_10 = val_7;
        val_8 = hitInfo.m_Normal.x;
        goto label_13;
        label_25:
        var val_2 = 1152921510385282472 + (hitInfo.m_Collider << 3);
        val_8 = (SB + (hitInfo.m_Normal.y + 40) << 3) + 192;
        var val_9 = (1152921510385282472 + (hitInfo.m_Collider) << 3) + 4;
        val_9 = val_9 + hitInfo.m_Centroid.y;
        val_9 = ((SB + (hitInfo.m_Normal.y + 40) << 3) + 188) + (val_9 << 3);
        val_9 = val_9 + 188;
        goto label_13;
        label_7:
        var val_5 = (SB + 88) + 0;
        var val_10 = (SB + 88 + 0) + 4;
        val_10 = val_10 + (hitInfo.m_Normal.y + 40);
        val_10 = SB + (val_10 << 3);
        val_12 = val_10 + 188;
        goto label_13;
        label_29:
        if(val_7 == 0f)
        {
            goto label_15;
        }
        
        if((hitInfo.m_Normal.y + 42) != 1)
        {
            goto label_16;
        }
        
        goto label_17;
        label_15:
        if(SB == 0)
        {
            goto label_13;
        }
        
        if((((hitInfo.m_Normal.y + 40) == 65535) || ((SB + 157) != 1)) || (mem[1152921510385294620] == 0))
        {
            goto label_21;
        }
        
        if(val_7 == 0f)
        {
            goto label_22;
        }
        
        if(val_7 == 0f)
        {
            goto label_23;
        }
        
        val_4 = hitInfo.m_Normal.x;
        val_3 = hitInfo.m_Point.y;
        if((SB + 178) == 0)
        {
            goto label_13;
        }
        
        var val_11 = 0;
        label_26:
        if((SB + 88 + 0) == (hitInfo.m_Normal.y + 12))
        {
            goto label_25;
        }
        
        val_11 = val_11 + 1;
        if(((uint)val_11 & 65535) < (SB + 178))
        {
            goto label_26;
        }
        
        goto label_13;
        label_21:
        val_8 = hitInfo.m_Normal.x;
        goto label_28;
        label_16:
        label_28:
        label_17:
        label_13:
        val_12 = val_12 + 1;
        if(val_12 != 1)
        {
            goto label_29;
        }
    
    }
    public virtual System.IAsyncResult BeginInvoke(UnityEngine.RaycastHit2D hitInfo, System.AsyncCallback callback, object object)
    {
    
    }
    public virtual void EndInvoke(System.IAsyncResult result)
    {
    
    }

}
