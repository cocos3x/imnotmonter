using UnityEngine;
private sealed class RopeManager.<HideAllRope>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RopeManager <>4__this;
    public int _index;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RopeManager.<HideAllRope>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        var val_4;
        if((this.<>1__state) != 1)
        {
                val_3 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_1;
            this.<>1__state = 1;
            return true;
        }
        
        this.<>1__state = 0;
        val_4 = 0;
        goto label_4;
        label_11:
        RopeNode[].__il2cppRuntimeField_byval_arg.enabled = false;
        UnityEngine.GameObject val_2 = 1152921506739462608.gameObject;
        1152921506739462608.SetActive(value:  false);
        val_4 = 1;
        label_4:
        if(val_4 < 1152921506739462608)
        {
            goto label_11;
        }
        
        val_3 = 0;
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
