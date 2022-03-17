using UnityEngine;
private sealed class EnemyAttack.<LookAtTarget>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemyAttack <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EnemyAttack.<LookAtTarget>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        float val_4;
        float val_6;
        float val_13;
        int val_17;
        Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemyAttack val_18;
        val_17 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_17;
        }
        
        val_18 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>4__this._hasTarget) == false)
        {
                return (bool)val_17;
        }
        
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.Vector3 val_5 = position;
        UnityEngine.Vector3 val_7 = position;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.up;
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.LookRotation(forward:  new UnityEngine.Vector3() {x = 5.109875f, y = val_2 - val_2, z = val_4 - val_4}, upwards:  new UnityEngine.Vector3() {x = val_6 - val_6});
        UnityEngine.Quaternion val_14 = rotation;
        float val_15 = UnityEngine.Time.deltaTime;
        uint val_17 = 0;
        val_17 = (this.<>4__this.RotationSpeed) * val_17;
        UnityEngine.Quaternion val_16 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = 5.109875f, y = val_2, z = R7, w = R8}, b:  new UnityEngine.Quaternion() {x = ???, y = val_2, z = val_4, w = val_6}, t:  val_17);
        val_18 = 0;
        this.<>4__this._transform.rotation = new UnityEngine.Quaternion() {x = val_2, y = val_4, z = val_6, w = val_13};
        this.<>2__current = val_18;
        val_17 = 1;
        this.<>1__state = val_17;
        return (bool)val_17;
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
