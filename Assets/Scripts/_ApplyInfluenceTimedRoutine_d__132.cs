using UnityEngine;
private sealed class ProCamera2D.<ApplyInfluenceTimedRoutine>d__132 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float duration;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2D <>4__this;
    public UnityEngine.Vector2 influence;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2D.<ApplyInfluenceTimedRoutine>d__132(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) >= 2)
        {
                return (bool)0;
        }
        
        this.<>1__state = 0;
        if((this.<>1__state) <= 2)
        {
                return (bool)0;
        }
        
        float val_2 = this.<>4__this.<DeltaTime>k__BackingField;
        val_2 = this.duration - val_2;
        this.duration = val_2;
        if((this.<>4__this) != 0)
        {
                this.<>4__this.ApplyInfluence(influence:  new UnityEngine.Vector2() {x = this.influence, y = R6});
        }
        else
        {
                0.ApplyInfluence(influence:  new UnityEngine.Vector2() {x = this.influence, y = R6});
        }
        
        UnityEngine.YieldInstruction val_1 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        0 = 1;
        this.<>1__state = 0;
        return (bool)0;
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
