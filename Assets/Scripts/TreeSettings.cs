using UnityEngine;
public class RecolorTree.TreeSettings
{
    // Fields
    private int[] axes;
    
    // Methods
    public RecolorTree.TreeSettings(bool aUseX, bool aUseY, bool aUseZ)
    {
        var val_3 = -1073714347;
        536877987 = new System.Collections.Generic.List<System.Int32>(capacity:  3);
        if(aUseX != false)
        {
                val_3 = -1073714345;
            536877987.Add(item:  0);
        }
        
        if(aUseY != false)
        {
                val_3 = -1073714345;
            536877987.Add(item:  1);
        }
        
        if(aUseZ != false)
        {
                val_3 = -1073714345;
            536877987.Add(item:  2);
        }
        
        T[] val_2 = 536877987.ToArray();
        this.axes = 536877987;
    }
    public int GetAxis(int aDepth)
    {
        System.Int32[] val_2;
        var val_3;
        val_2 = this.axes;
        if(val_2 != null)
        {
                val_3 = aDepth;
        }
        else
        {
                val_2 = this.axes;
            val_3 = aDepth;
            if(val_2 == null)
        {
                val_2 = 0;
        }
        
        }
        
        var val_1 = val_2 + (val_3 << 2);
        return (int)(val_2 + (aDepth) << 2) + 16;
    }
    public float AxisDist(int aAxis, UnityEngine.Vector3 a, UnityEngine.Vector3 b)
    {
        float val_1;
        var val_2;
        var val_3;
        if(aAxis == 2)
        {
            goto label_0;
        }
        
        if(aAxis == 1)
        {
            goto label_1;
        }
        
        if(aAxis != 0)
        {
                this = 0;
            return (float)S0;
        }
        
        val_1 = b.x;
        val_2 = a.x;
        goto label_2;
        label_0:
        val_3 = b.z;
        val_2 = a.z;
        goto label_3;
        label_1:
        val_1 = b.y;
        val_2 = a.y;
        label_2:
        val_3 = val_1;
        label_3:
        val_3 = val_2 - val_3;
        var val_1 = val_3;
        val_1 = val_1 & (~2147483648);
        return (float)val_3;
    }

}
