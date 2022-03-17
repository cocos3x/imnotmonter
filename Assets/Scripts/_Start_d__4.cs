using UnityEngine;
private sealed class TeleType.<Start>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.Examples.TeleType <>4__this;
    private int <totalVisibleCharacters>5__2;
    private int <counter>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TeleType.<Start>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        int val_8;
        var val_11;
        var val_12;
        if((this.<>1__state) > 4)
        {
                return false;
        }
        
        var val_1 = 6761004 + (6761004 + (this.<>1__state) << 2);
        if((this.<>1__state) == 4)
        {
                6761004 + (this.<>1__state) << 2 = (6761004 + (this.<>1__state) << 2) & (this << (6761004 + (this.<>1__state) << 2));
            6761004 + (this.<>1__state) << 2 = this * (6761004 + (this.<>1__state) << 2);
            6761004 + (this.<>1__state) << 2 = (6761004 + (this.<>1__state) << 2) & ((IP) >> 1);
            6761004 + (this.<>1__state) << 2 = (6761004 + (this.<>1__state) << 2) & 478650104;
        }
        
        this.<>1__state = 0;
        val_7 = this;
        this.<totalVisibleCharacters>5__2 = this.<>4__this.m_textMeshPro.m_textInfo.characterCount;
        val_8 = 0;
        mem[1152921509859114504] = val_8;
        val_11 = mem[R6 + 20];
        val_11 = R6 + 20;
        val_11.maxVisibleCharacters = ;
        if( < (R4 + 20))
        {
                var val_8 = R4 + 24;
            val_8 = val_8 + 1;
            mem2[0] = val_8;
            UnityEngine.WaitForSeconds val_2 = 536896849;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
            var val_3 = R4 + 12;
            mem2[0] = val_2;
            val_12 = 4;
        }
        else
        {
                UnityEngine.WaitForSeconds val_4 = 536896849;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
            mem2[0] = val_4;
            val_12 = 1;
        }
        
        mem2[0] = ;
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
