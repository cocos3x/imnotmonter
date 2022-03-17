using UnityEngine;
private sealed class ShaderPropAnimator.<AnimateProperties>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.Examples.ShaderPropAnimator <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ShaderPropAnimator.<AnimateProperties>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        UnityEngine.AnimationCurve val_7;
        var val_8;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_6 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
        this.<>1__state = 0;
        float val_1 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
        this.<>4__this.m_frame = 0;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_5;
        }
        
        label_4:
        val_7 = this.<>4__this.GlowCurve;
        goto label_6;
        label_5:
        val_7 = 1;
        label_6:
        val_8 = 536893671;
        if(((mem[536893858] & true) == 0) && (mem[536893787] == 0))
        {
                val_8 = 536893671;
        }
        
        this.<>4__this.m_Material.SetFloat(nameID:  mem[536893763] + 124, value:  val_7.Evaluate(time:  null));
        float val_4 = UnityEngine.Random.Range(minInclusive:  UnityEngine.Time.deltaTime, maxInclusive:  null);
        this.<>4__this.m_frame = this.<>4__this.m_frame;
        UnityEngine.WaitForEndOfFrame val_5 = 536896839;
        val_5 = new UnityEngine.WaitForEndOfFrame();
        this.<>2__current = val_5;
        val_6 = 1;
        this.<>1__state = val_6;
        return (bool)val_6;
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
