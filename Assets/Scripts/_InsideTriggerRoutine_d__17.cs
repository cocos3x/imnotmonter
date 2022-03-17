using UnityEngine;
private sealed class ProCamera2DTriggerZoom.<InsideTriggerRoutine>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerZoom <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DTriggerZoom.<InsideTriggerRoutine>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_7;
        float val_8;
        float val_9;
        int val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        float val_31;
        val_24 = 0;
        if((this.<>1__state) == 0)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 1)
        {
                return (bool)val_24;
        }
        
        this.<>1__state = 0;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
        float val_23 = System.Math.Abs(this.<>4__this._targetCamSize);
        if((this.<>4__this) > 0)
        {
                if((this.<>4__this.ResetSizeOnExit) == false)
        {
                112 = 100;
        }
        
            this.<>4__this.UpdateScreenSize(smoothness:  val_23);
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.<>4__this.ProCamera2D;
        val_25 = this.<>4__this;
        if((this.<>4__this) != 0)
        {
            goto label_11;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.<>4__this.ProCamera2D;
        val_25 = this.<>4__this;
        this.<>4__this._zoomVelocity = 0f;
        val_23 = val_23 * 0.5f;
        this.<>4__this._targetCamSize = val_23;
        this.<>4__this._targetCamSizeSmoothed = val_23;
        goto label_11;
        label_1:
        this.<>1__state = 0;
        label_11:
        if(0 == 0)
        {
                return (bool)val_24;
        }
        
        val_24 = 0;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.<>4__this.ProCamera2D;
        val_25 = this.<>4__this;
        if(22999198 != (this.<>4__this))
        {
                return (bool)val_24;
        }
        
        mem2[0] = this.<>4__this.ExclusiveInfluencePercentage;
        if((this.<>4__this) != 0)
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.<>4__this.ProCamera2D;
            val_27 = this.<>4__this.TargetZoom;
            val_28 = this.<>4__this.ZoomSmoothness;
        }
        else
        {
                UnityEngine.Vector3 val_6 = position;
            val_26 = val_7;
            val_27 = val_8;
            val_28 = val_9;
        }
        
        float val_10 = static_value_015EF09E.Invoke(arg:  new UnityEngine.Vector3() {x = val_26, y = val_27, z = val_28});
        if(22999198 != 0)
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_11 = this.<>4__this.ProCamera2D;
            val_25 = this.<>4__this.TargetZoom;
            val_30 = this.<>4__this.ZoomSmoothness;
        }
        else
        {
                UnityEngine.Vector3 val_12 = position;
            val_29 = val_7;
            val_25 = val_8;
            val_30 = val_9;
        }
        
        float val_13 = val_26.Invoke(arg:  new UnityEngine.Vector3() {x = val_29, y = val_25, z = val_30});
        float val_14 = this.<>4__this.GetDistanceToCenterPercentage(point:  new UnityEngine.Vector2() {x = 4.094759E-38f, y = val_26});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerZoom val_26 = this.<>4__this;
        if((this.<>4__this.SetSizeAsMultiplier) != false)
        {
                val_31 = (this.<>4__this._startCamSize) / (this.<>4__this.TargetZoom);
        }
        else
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_15 = this.<>4__this.ProCamera2D;
            if((this.<>4__this.orthographic) != false)
        {
                val_31 = this.<>4__this.TargetZoom;
        }
        else
        {
                float val_24 = 0.5f;
            val_24 = (this.<>4__this.TargetZoom) * val_24;
            val_24 = val_24 * 0.01745329f;
            val_31 = (System.Math.Abs(this.<>4__this._initialCamDepth)) * val_24;
        }
        
        }
        
        float val_17 = 1f - val_26;
        val_26 = val_26 * (this.<>4__this._initialCamSize);
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_18 = this.<>4__this.ProCamera2D;
        if((this.<>4__this) <= 0)
        {
            goto label_32;
        }
        
        float val_27 = this.<>4__this._targetCamSize;
        if((this.<>4__this) > 0)
        {
            goto label_36;
        }
        
        label_32:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_19 = this.<>4__this.ProCamera2D;
        val_27 = val_27 * 0.5f;
        if((this.<>4__this) < 0)
        {
                if((this.<>4__this) < 0)
        {
            goto label_36;
        }
        
        }
        
        if((this.<>4__this.ResetSizeOnExit) == false)
        {
            goto label_37;
        }
        
        label_36:
        mem2[0] = val_26;
        label_37:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_20 = this.<>4__this.ProCamera2D;
        this.<>4__this._previousCamSize = this.<>4__this;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_21 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_22 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_24 = 1;
        this.<>1__state = val_24;
        return (bool)val_24;
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
