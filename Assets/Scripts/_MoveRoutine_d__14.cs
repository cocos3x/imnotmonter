using UnityEngine;
private sealed class Door.<MoveRoutine>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.Door <>4__this;
    public float duration;
    public UnityEngine.Vector3 newPos;
    private UnityEngine.Vector3 <origPos>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Door.<MoveRoutine>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_10;
        Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.Door val_11;
        float val_12;
        val_10 = 0;
        val_11 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_10;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = 536896849;
        val_11 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_11;
        val_10 = 1;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_1:
        this.<>1__state = 0;
        if((this.<>1__state) <= 2)
        {
            goto label_5;
        }
        
        return (bool)val_10;
        label_2:
        this.<>1__state = 0;
        UnityEngine.Transform val_2 = val_11.transform;
        UnityEngine.Vector3 val_3 = position;
        val_12 = 0f;
        label_5:
        float val_4 = UnityEngine.Time.deltaTime;
        float val_9 = this.duration;
        val_9 = 0 / val_9;
        val_9 = val_12 + val_9;
        this.<t>5__3 = val_9;
        UnityEngine.Transform val_5 = val_11.transform;
        val_10 = 1;
        float val_8 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_9, end:  val_3.y, value:  0, type:  this.<origPos>5__2), end:  val_3.y, value:  0, type:  this.<origPos>5__2), end:  val_3.y, value:  0, type:  this.<origPos>5__2);
        val_11 = 0;
        val_11.position = new UnityEngine.Vector3() {x = this.<origPos>5__2, y = this.<origPos>5__2, z = this.<origPos>5__2};
        this.<>2__current = val_11;
        this.<>1__state = 2;
        return (bool)val_10;
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
