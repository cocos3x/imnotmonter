using UnityEngine;
private sealed class LineManager.<DisableLine>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float time;
    public bool remove;
    public Vectrosity.LineManager <>4__this;
    public Vectrosity.VectorLine vectorLine;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LineManager.<DisableLine>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        object val_4;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_4 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_4;
            val_3 = 1;
            this.<>1__state = val_3;
            return (bool)val_3;
        }
        
        val_4 = this.<>4__this;
        this.<>1__state = 0;
        val_3 = 0;
        val_4.RemoveLine(vectorLine:  this.vectorLine);
        if(this.remove != true)
        {
                Vectrosity.VectorLine.Destroy(line: ref  Vectrosity.VectorLine val_2 = 362965804);
        }
        
        this.vectorLine = val_3;
        return (bool)val_3;
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
