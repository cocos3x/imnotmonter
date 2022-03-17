using UnityEngine;
private sealed class EnemyFSM.<HitAnim>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemyFSM <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EnemyFSM.<HitAnim>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        float val_3;
        float val_4;
        float val_5;
        int val_7;
        UnityEngine.Color val_8;
        float val_9;
        float val_10;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            val_8 = 0;
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            val_9 = val_3;
            val_10 = val_4;
            this.<>4__this.Colorize(color:  new UnityEngine.Color() {r = val_2, g = val_9, b = val_10, a = val_5});
            UnityEngine.WaitForSeconds val_6 = 536896849;
            val_6 = new UnityEngine.WaitForSeconds(seconds:  val_1.r);
            this.<>2__current = val_6;
            val_7 = 1;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        val_8 = this.<>4__this._currentColor;
        val_7 = 0;
        this.<>4__this.Colorize(color:  new UnityEngine.Color() {r = val_8, g = R7, b = R8, a = this});
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
