using UnityEngine;
private sealed class Water2D_Spawner.<UpdateQuietParticleProperties>d__100 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Water2D.Water2D_Spawner <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Water2D_Spawner.<UpdateQuietParticleProperties>d__100(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Water2D_Spawner.<UpdateQuietParticleProperties>d__100 val_12;
        int val_13;
        var val_14;
        UnityEngine.Vector2 val_15;
        float val_16;
        float val_17;
        var val_18;
        float val_21;
        val_12 = this;
        val_13 = 0;
        if((this.<>1__state) > 1)
        {
                return (bool)val_13;
        }
        
        this.<>1__state = 0;
        val_14 = 0;
        val_15 = this.<>4__this.SpeedLimiterY;
        goto label_2;
        label_33:
        UnityEngine.GameObject val_12 = this.<>4__this.WaterDropsObjects[val_14];
        Weight val_1 = val_12.GetComponent<Weight>();
        if((System.String.op_Equality(a:  this.<>4__this.Water2DType, b:  -1610605017)) == false)
        {
            goto label_6;
        }
        
        this.<>4__this.SetRefractingWaterparams(intensity:  null, mag:  null, speed:  null);
        if((this.<>4__this) != 0)
        {
            goto label_11;
        }
        
        UnityEngine.GameObject val_3 = val_12.gameObject;
        Weight val_4 = val_12.GetComponent<Weight>();
        if(val_12 == 0)
        {
                val_16 = mem[this.<>4__this.FillColor + (0)];
        }
        
        val_12.color = new UnityEngine.Color() {r = val_16, g = mem[this.<>4__this.FillColor + (4)], b = mem[this.<>4__this.FillColor + (8)], a = val_12};
        val_15 = val_15;
        goto label_11;
        label_6:
        if((System.String.op_Equality(a:  this.<>4__this.Water2DType, b:  -1610603379)) == false)
        {
            goto label_12;
        }
        
        val_17 = this.<>4__this.AlphaCutOff;
        this.<>4__this.SetToonWaterparams(fill:  new UnityEngine.Color() {r = mem[this.<>4__this.FillColor + (0)], g = mem[this.<>4__this.FillColor + (4)], b = mem[this.<>4__this.FillColor + (8)], a = mem[this.<>4__this.FillColor + (12)]}, stroke:  new UnityEngine.Color() {r = this.<>4__this.StrokeColor, g = val_12, b = val_12, a = ???}, alphaCutoff:  val_17, alphaStroke:  null);
        goto label_14;
        label_12:
        val_18 = 0;
        if((System.String.op_Equality(a:  this.<>4__this.Water2DType, b:  -1610604997)) == false)
        {
            goto label_14;
        }
        
        if((this.<>4__this.SpeedLimiterX) == 0)
        {
                UnityEngine.GameObject val_7 = val_12.gameObject;
            Weight val_8 = val_12.GetComponent<Weight>();
            if(val_12 == 0)
        {
                val_18 = val_18;
        }
        
            val_12.color = new UnityEngine.Color() {r = this.<>4__this.FillColor, g = 0f, b = val_15, a = val_12};
            val_15 = val_15;
        }
        
        val_17 = this.<>4__this.AlphaCutOff;
        this.<>4__this.SetRegularWaterparams(fill:  new UnityEngine.Color() {r = mem[this.<>4__this.FillColor + (0)], g = mem[this.<>4__this.FillColor + (4)], b = mem[this.<>4__this.FillColor + (8)], a = mem[this.<>4__this.FillColor + (12)]}, fresnel:  new UnityEngine.Color() {r = this.<>4__this.StrokeColor, g = val_12, b = val_12, a = ???}, alphaCutoff:  val_17, multiplier:  null);
        label_11:
        val_12 = 0;
        goto label_20;
        label_14:
        val_12 = 0;
        if(val_12 == 0)
        {
                val_12 = 1;
        }
        
        label_20:
        mem2[0] = mem[this.<>4__this.SpeedLimiterX + (0)];
        mem2[0] = mem[this.<>4__this.SpeedLimiterX + (4)];
        if(val_12 != 0)
        {
                mem[44] = this.<>4__this.SpeedLimiterY.x;
            mem[48] = this.<>4__this.SpeedLimiterY.y;
        }
        else
        {
                mem2[0] = this.<>4__this.SpeedLimiterY.x;
            mem2[0] = this.<>4__this.SpeedLimiterY.y;
        }
        
        UnityEngine.Transform val_9 = val_12.GetComponent<UnityEngine.Transform>();
        if(val_12 != 0)
        {
                val_12.sharedMaterial = this.<>4__this.PhysicMat;
            val_12.drag = val_17;
            val_12.angularDrag = val_17;
            val_21 = this.<>4__this.GravityScale;
        }
        else
        {
                val_12.sharedMaterial = this.<>4__this.PhysicMat;
            val_12.drag = val_17;
            val_12.angularDrag = val_17;
            val_21 = this.<>4__this.GravityScale;
        }
        
        val_12.gravityScale = val_17;
        if((this.<>4__this.FreezeRotation) != false)
        {
                val_12.constraints = 4;
        }
        
        UnityEngine.Transform val_10 = val_12.GetComponent<UnityEngine.Transform>();
        val_12.sharedMaterial = this.<>4__this.PhysicMat;
        UnityEngine.Transform val_11 = val_12.GetComponent<UnityEngine.Transform>();
        val_12.radius = val_17;
        val_14 = 1;
        label_2:
        if(val_14 < val_12)
        {
            goto label_33;
        }
        
        mem[1152921509833273468] = 0;
        val_13 = 1;
        this.<>1__state = val_13;
        return (bool)val_13;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
