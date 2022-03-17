using UnityEngine;
private sealed class PeopleToHelp.<OnDelay>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public int i;
    public PeopleToHelp <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PeopleToHelp.<OnDelay>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_2 = 536896849;
            float val_1 = (float)this.i * 0.05f;
            val_2 = new UnityEngine.WaitForSeconds(seconds:  (float)this.i);
            this.<>2__current = val_2;
            val_5 = 1;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        this.<>1__state = 0;
        UnityEngine.GameObject val_3 = this.<>4__this.gameObject;
        this.<>4__this.layer = UnityEngine.LayerMask.NameToLayer(layerName:  -1610609369);
        val_5 = 0;
        this.<>4__this.myFollow.enabled = true;
        return (bool)val_5;
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
