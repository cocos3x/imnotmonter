using UnityEngine;
private sealed class ProCamera2DTransitionsFX.<TransitionRoutine>d__48 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTransitionsFX <>4__this;
    public float startValue;
    public UnityEngine.Material material;
    public float endValue;
    public float delay;
    public float duration;
    public Com.LuisPedroFonseca.ProCamera2D.EaseType easeType;
    private float <t>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DTransitionsFX.<TransitionRoutine>d__48(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        UnityEngine.Material val_8;
        System.Action val_9;
        float val_10;
        float val_11;
        int val_12;
        UnityEngine.Material val_13;
        float val_14;
        int val_15;
        UnityEngine.Material val_16;
        System.Action val_17;
        if(((this.<>1__state) - 1) < 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 3)
        {
            goto label_2;
        }
        
        val_7 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        this.<>4__this._blit.enabled = true;
        this.<>4__this._step = this.startValue;
        this.<>4__this._blit.CurrentMaterial = this.material;
        val_8 = this.<>4__this._blit.CurrentMaterial;
        val_8.SetFloat(nameID:  this.<>4__this._material_StepID, value:  null);
        if(val_8 != 0)
        {
            goto label_9;
        }
        
        val_9 = this.<>4__this.OnTransitionEnterStarted;
        goto label_10;
        label_1:
        this.<>1__state = 0;
        goto label_18;
        label_2:
        this.<>1__state = 0;
        if((this.<>1__state) <= 3)
        {
            goto label_12;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_13;
        }
        
        this.<>4__this._step = this.endValue;
        val_11 = this.endValue;
        val_12 = this.<>4__this._material_StepID;
        val_13 = this.material;
        goto label_14;
        label_9:
        if(val_8 != 0)
        {
            goto label_16;
        }
        
        val_9 = this.<>4__this.OnTransitionExitStarted;
        label_10:
        if(val_9 != 0)
        {
                val_9.Invoke();
        }
        
        label_16:
        if((this.<>4__this.OnTransitionStarted) != 0)
        {
                this.<>4__this.OnTransitionStarted.Invoke();
        }
        
        if((this.<>4__this.OnTransitionStarted) <= 0)
        {
            goto label_18;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.<>4__this.ProCamera2D;
        if((this.<>4__this) == 0)
        {
            goto label_20;
        }
        
        UnityEngine.WaitForSecondsRealtime val_3 = 536896855;
        val_3 = new UnityEngine.WaitForSecondsRealtime(time:  this.delay);
        this.<>2__current = val_3;
        val_7 = 1;
        this.<>1__state = val_7;
        return (bool)val_7;
        label_18:
        val_10 = 0f;
        this.<t>5__2 = 0f;
        label_12:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.<>4__this.ProCamera2D;
        float val_7 = this.duration;
        val_7 = (this.<>4__this.TextureSmoothingEnter) / val_7;
        val_7 = val_10 + val_7;
        this.<t>5__2 = val_7;
        val_14 = this.startValue;
        if((this.<>4__this) != 0)
        {
                this.<>4__this._step = val_14;
            val_15 = this.<>4__this._material_StepID;
            val_16 = this.material;
        }
        else
        {
                mem[180] = val_14;
            val_16 = this.material;
            val_15 = 188;
            val_14 = mem[180];
        }
        
        val_8 = 0;
        val_16.SetFloat(nameID:  188, value:  Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_7, end:  null, value:  this.<>4__this.TextureSmoothingEnter, type:  this.startValue));
        this.<>2__current = val_8;
        label_31:
        this.<>1__state = 3;
        val_7 = 1;
        return (bool)val_7;
        label_13:
        mem[180] = this.endValue;
        val_13 = this.material;
        val_12 = 188;
        val_11 = mem[180];
        label_14:
        val_13.SetFloat(nameID:  188, value:  null);
        if(val_13 != 0)
        {
            goto label_28;
        }
        
        val_17 = this.<>4__this.OnTransitionEnterEnded;
        goto label_30;
        label_20:
        UnityEngine.WaitForSeconds val_6 = 536896849;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  this.delay);
        this.<>2__current = val_6;
        goto label_31;
        label_28:
        if(val_13 != 0)
        {
            goto label_34;
        }
        
        val_17 = this.<>4__this.OnTransitionExitEnded;
        label_30:
        if(val_17 != 0)
        {
                val_17.Invoke();
        }
        
        label_34:
        if((this.<>4__this.OnTransitionEnded) != 0)
        {
                this.<>4__this.OnTransitionEnded.Invoke();
        }
        
        if((this.<>4__this.OnTransitionEnded) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>4__this._blit.enabled = false;
        return (bool)val_7;
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
