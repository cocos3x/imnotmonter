using UnityEngine;
private sealed class CharacterPinPullBase.<DelaySoundCollectCoin>d__32 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharacterPinPullBase.<DelaySoundCollectCoin>d__32(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) > 3)
        {
                return (bool);
        }
        
        var val_1 = 17658496 + (17658496 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                17658496 + (this.<>1__state) << 2 = (17658496 + (this.<>1__state) << 2) & ((17658496 + (this.<>1__state) << 2) << (17658496 + (this.<>1__state) << 2));
            17658496 + (this.<>1__state) << 2 = (17658496 + (this.<>1__state) << 2) & (this >> (17658496 + (this.<>1__state) << 2));
            17658496 + (this.<>1__state) << 2 = (17658496 + (this.<>1__state) << 2) & (((R8) << (32-1)) | ((R8) << 1));
            17658496 + (this.<>1__state) << 2 = (17658496 + (this.<>1__state) << 2) & ((R8) << 3);
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_2 = 536896849;
        val_2 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_2;
        0 = 1;
        this.<>1__state = 0;
        return (bool);
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
