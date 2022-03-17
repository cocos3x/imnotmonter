using UnityEngine;
private sealed class PlayerInputBot.<RandomInputSpeed>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.Platformer.PlayerInputBot <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerInputBot.<RandomInputSpeed>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) > 1)
        {
                return (bool)0;
        }
        
        this.<>1__state = 0;
        this.<>4__this._fakeInputHorizontalAxis = 3212836864;
        UnityEngine.WaitForSeconds val_3 = 536896849;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null), maxInclusive:  null));
        this.<>2__current = val_3;
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
