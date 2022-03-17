using UnityEngine;
private sealed class LoadLevelRopeManager.<DelayLoadScene>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LoadLevelRopeManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadLevelRopeManager.<DelayLoadScene>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_7;
        UnityEngine.GameObject val_8;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610680075));
            UnityEngine.WaitUntil val_2 = 536896879;
            val_2 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_2;
            this.<>1__state = 1;
            return true;
        }
        
        this.<>1__state = 0;
        val_8 = 0;
        System.Type val_3 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073758215)});
        UnityEngine.Object val_4 = UnityEngine.Resources.Load(path:  this.<>4__this.linkLevel, systemTypeInstance:  1073758215);
        UnityEngine.Transform val_5 = this.<>4__this.transform;
        UnityEngine.Object val_6 = UnityEngine.Object.Instantiate(original:  this.<>4__this.linkLevel, parent:  this.<>4__this);
        if((this.<>4__this.linkLevel) != null)
        {
                if(null != 536887303)
        {
                this.<>4__this.linkLevel = 0;
        }
        
            val_8 = this.<>4__this.linkLevel;
        }
        
        this.<>4__this.ObjLevel = val_8;
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
