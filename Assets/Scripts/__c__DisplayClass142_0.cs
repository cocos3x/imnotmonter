using UnityEngine;
private sealed class Ferr2DT_PathTerrain.<>c__DisplayClass142_0
{
    // Fields
    public System.Collections.Generic.List<Ferr2DT_TerrainDirection> dirs;
    public Ferr2DT_PathTerrain <>4__this;
    public System.Collections.Generic.List<System.Collections.Generic.List<int>> segments;
    
    // Methods
    public Ferr2DT_PathTerrain.<>c__DisplayClass142_0()
    {
    
    }
    internal int <LegacyAddEdge>b__0(int x, int y)
    {
        float val_12;
        System.Collections.Generic.List<UnityEngine.Vector2> val_13;
        Ferr2DT_PathTerrain val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_12 = 22998718;
        if(0 <= x)
        {
                var val_12 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + (x << 2);
        if(((0 + (x) << 2) + 16) == 100)
        {
                Ferr2D_Path val_1 = this.<>4__this.Path;
            val_12 = this.<>4__this.fillZ;
            if((this.<>4__this) <= x)
        {
                var val_13 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_13 = val_13 + (x << 2);
            Ferr2DT_FillMode val_14 = this.<>4__this.fill;
            val_14 = val_14 - 3;
            val_13 = val_12;
            Ferr2DT_TerrainDirection val_3 = Ferr2D_Path.GetDirection(aPath:  val_13, aSegment:  (0 + (x) << 2) + 16, i:  0, aInvert:  val_14 >> 5, aClosed:  false, aOverrides:  0);
        }
        else
        {
                if(((0 + (x) << 2) + 16) <= x)
        {
                var val_15 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_15 = val_15 + (x << 2);
            val_13 = mem[(0 + (x) << 2) + 16];
            val_13 = (0 + (x) << 2) + 16;
        }
        
        if(val_13 <= y)
        {
                var val_16 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_16 = val_16 + (y << 2);
        if(((0 + (y) << 2) + 16) == 100)
        {
                val_14 = this;
            Ferr2D_Path val_4 = this.<>4__this.Path;
            if((this.<>4__this) <= y)
        {
                var val_17 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_12 = this.<>4__this;
            val_17 = val_17 + (y << 2);
            Ferr2DT_FillMode val_18 = this.<>4__this.fill;
            val_18 = val_18 - 3;
            Ferr2DT_TerrainDirection val_6 = Ferr2D_Path.GetDirection(aPath:  this.<>4__this.fillZ, aSegment:  (0 + (y) << 2) + 16, i:  0, aInvert:  val_18 >> 5, aClosed:  false, aOverrides:  0);
            val_15 = this.<>4__this.fillZ;
        }
        else
        {
                if(((0 + (y) << 2) + 16) <= y)
        {
                var val_19 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_14 = this.<>4__this;
            val_19 = val_19 + (y << 2);
            val_15 = mem[(0 + (y) << 2) + 16];
            val_15 = (0 + (y) << 2) + 16;
        }
        
        IFerr2DTMaterial val_7 = mem[this.<>4__this].TerrainMaterial;
        val_16 = mem[this.<>4__this];
        var val_20 = val_16;
        if((mem[this.<>4__this] + 178) == 0)
        {
            goto label_25;
        }
        
        val_12 = 0;
        label_27:
        if((mem[this.<>4__this] + 88 + 0) == 536888251)
        {
            goto label_26;
        }
        
        val_12 = val_12 + 1;
        if(((uint)val_12 & 65535) < (mem[this.<>4__this] + 178))
        {
            goto label_27;
        }
        
        label_25:
        val_17 = val_16;
        goto label_28;
        label_26:
        var val_8 = (mem[this.<>4__this] + 88) + 0;
        val_20 = val_20 + (((mem[this.<>4__this] + 88 + 0) + 4) << 3);
        val_17 = val_20 + 236;
        label_28:
        IFerr2DTMaterial val_9 = mem[this.<>4__this].TerrainMaterial;
        var val_21 = mem[this.<>4__this];
        if((mem[this.<>4__this] + 178) == 0)
        {
            goto label_32;
        }
        
        val_12 = 0;
        label_34:
        val_16 = 0;
        if((mem[this.<>4__this] + 88 + 0) == 536888251)
        {
            goto label_33;
        }
        
        val_12 = val_12 + 1;
        val_16 = (uint)val_12 & 65535;
        if(val_16 < (mem[this.<>4__this] + 178))
        {
            goto label_34;
        }
        
        label_32:
        val_18 = mem[this.<>4__this];
        return (int)mem[this.<>4__this] + 12.CompareTo(value:  null);
        label_33:
        var val_10 = (mem[this.<>4__this] + 88) + 0;
        val_21 = val_21 + (((mem[this.<>4__this] + 88 + 0) + 4) << 3);
        val_18 = val_21 + 236;
        return (int)mem[this.<>4__this] + 12.CompareTo(value:  null);
    }

}
