using UnityEngine;
private sealed class PlayerInputBot.<RandomInputJump>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.Platformer.PlayerInputBot <>4__this;
    private UnityEngine.WaitForEndOfFrame <waitForEndOfFrame>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerInputBot.<RandomInputJump>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Com.LuisPedroFonseca.ProCamera2D.Platformer.PlayerInputBot val_7;
        var val_8;
        if((this.<>1__state) > 3)
        {
                return false;
        }
        
        val_7 = this.<>4__this;
        var val_1 = 17909892 + (17909892 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                17909892 + (this.<>1__state) << 2 = (17909892 + (this.<>1__state) << 2) & ((17909892 + (this.<>1__state) << 2) << (17909892 + (this.<>1__state) << 2));
            17909892 + (this.<>1__state) << 2 = (17909892 + (this.<>1__state) << 2) & ((17909892 + (this.<>1__state) << 2) >> (17909892 + (this.<>1__state) << 2));
            17909892 + (this.<>1__state) << 2 = (17909892 + (this.<>1__state) << 2) & (((((17909892 + (this.<>1__state) << 2 & (17909892 + (this.<>1__state) << 2) << 17909892 + (this.<>1__state) << 2) & ((int)(17909892 + (this.<>1__state) << 2 & (17909892 + (this.<>1__state) << 2) << 1790) << (32-((17909892 + (this.<>1__state) << 2 & (17909892 + (this.<>1__state) << 2) << 17909892 + (this.<>1__state) << 2) & ((int)(17909892 + (this.<>1__state) << 2 & (17909892 + (this.<>1__state) << 2) << 1790)) | ((((17909892 + (this.<>1__state) << 2 & (17909892 + (this.<>1__state) << 2) << 17909892 + (this.<>1__state) << 2) & ((int)(17909892 + (this.<>1__state) << 2 & (17909892 + (this.<>1__state) << 2) << 1790) << ((17909892 + (this.<>1__state) << 2 & (17909892 + (this.<>1__state) << 2) << 17909892 + (this.<>1__state) << 2) & ((int)(17909892 + (this.<>1__state) << 2 & (17909892 + (this.<>1__state) << 2) << 1790));
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForEndOfFrame val_2 = 536896839;
        val_2 = new UnityEngine.WaitForEndOfFrame();
        this.<waitForEndOfFrame>5__2 = val_2;
        val_8 = 1;
        var val_6 = R4 + 12;
        mem[536896905] = val_8;
        mem2[0] = R4 + 20;
        mem2[0] = val_8;
        return true;
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
