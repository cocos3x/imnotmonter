using UnityEngine;
private sealed class PlayerHealth.<HitAnim>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.PlayerHealth <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerHealth.<HitAnim>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        int val_7;
        var val_8;
        var val_9;
        float val_10;
        var val_11;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_7 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_1 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
        0.Shake(presetName:  -1610605333);
        val_8 = 0;
        goto label_6;
        label_13:
        UnityEngine.Renderer val_7 = this.<>4__this._renderers[val_8];
        UnityEngine.Material val_2 = val_7.material;
        val_9 = val_7;
        UnityEngine.Color val_3 = UnityEngine.Color.white;
        val_10 = val_4;
        val_9.color = new UnityEngine.Color() {r = val_10, g = R4, b = R5, a = ???};
        val_8 = 1;
        label_6:
        if(val_8 < val_9)
        {
            goto label_13;
        }
        
        UnityEngine.WaitForSeconds val_5 = 536896849;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  val_3.r);
        mem[1152921509997840444] = val_5;
        val_7 = 1;
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        val_11 = 0;
        this.<>1__state = 0;
        goto label_15;
        label_22:
        UnityEngine.Renderer val_8 = this.<>4__this._renderers[val_11];
        UnityEngine.Material val_6 = val_8.material;
        val_8.color = new UnityEngine.Color() {r = mem[this.<>4__this._originalColor + (0)], g = mem[this.<>4__this._originalColor + (4)], b = mem[this.<>4__this._originalColor + (8)], a = mem[this.<>4__this._originalColor + (12)]};
        val_11 = 1;
        label_15:
        if(val_11 < val_8)
        {
            goto label_22;
        }
        
        val_7 = 0;
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
