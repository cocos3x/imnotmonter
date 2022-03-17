using UnityEngine;
private sealed class HuggyPinPullController.<WaitForUntie>d__20 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public HuggyPinPullController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HuggyPinPullController.<WaitForUntie>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_15;
        var val_16;
        var val_17;
        if((this.<>1__state) != 1)
        {
                val_15 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_15;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_1;
            val_15 = 1;
            this.<>1__state = val_15;
            return (bool)val_15;
        }
        
        this.<>1__state = 0;
        UnityEngine.Transform val_2 = this.<>4__this.transform;
        UnityEngine.Transform val_3 = this.<>4__this.parent;
        UnityEngine.Transform val_4 = this.<>4__this.GetComponent<UnityEngine.Transform>();
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this)) != false)
        {
                UnityEngine.Transform val_6 = this.<>4__this.GetComponent<UnityEngine.Transform>();
            this.<>4__this.Untie();
        }
        
        if((this.<>4__this) != 0)
        {
                UnityEngine.Transform val_7 = this.<>4__this.transform;
            val_16 = this.<>4__this;
        }
        else
        {
                UnityEngine.Transform val_8 = this.<>4__this.transform;
            val_16 = this.<>4__this;
        }
        
        UnityEngine.Transform val_9 = this.<>4__this.transform;
        UnityEngine.Transform val_10 = this.<>4__this.parent;
        UnityEngine.Transform val_11 = this.<>4__this.parent;
        val_16.parent = this.<>4__this;
        this.<>4__this.myRigidbody.bodyType = 0;
        this.<>4__this.isUntied = true;
        val_17 = 536887951;
        if(((mem[536888138] & true) == 0) && (mem[536888067] == 0))
        {
                val_17 = 536887951;
        }
        
        val_15 = 0;
        536882991 = new System.Action(object:  this.<>4__this, method:  new IntPtr(1610678811));
        this.<>4__this.animationController.SetAnimation(name:  mem[536888043] + 36, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return (bool)val_15;
        }
        
        WorldTimeAPI val_14 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_15 = 0;
        -1073701113.Shot(clip:  -1610605269, volume:  null);
        return (bool)val_15;
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
