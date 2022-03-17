using UnityEngine;
private sealed class EnemyAttack.<Fire>d__14 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemyAttack <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EnemyAttack.<Fire>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_6;
        float val_8;
        float val_9;
        float val_10;
        if((this.<>1__state) >= 2)
        {
                return (bool)0;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this._hasTarget) == false)
        {
                return (bool)0;
        }
        
        UnityEngine.GameObject val_1 = this.<>4__this.BulletPool.nextThing;
        UnityEngine.Transform val_2 = this.<>4__this.BulletPool.transform;
        UnityEngine.Vector3 val_3 = position;
        this.<>4__this.BulletPool.position = new UnityEngine.Vector3() {x = R7, y = R8, z = SB};
        UnityEngine.Transform val_4 = this.<>4__this.BulletPool.transform;
        UnityEngine.Quaternion val_5 = rotation;
        float val_11 = UnityEngine.Random.Range(minInclusive:  val_5.x, maxInclusive:  val_5.y);
        float val_15 = -90f;
        val_15 = ((this.<>4__this.FireAngleRandomness) ^ 2147483648) + val_15;
        UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 5.805433f, y = 0f, z = val_15});
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 5.805433f, y = val_6, z = val_8, w = val_9}, rhs:  new UnityEngine.Quaternion() {x = val_10});
        this.<>4__this.BulletPool.rotation = new UnityEngine.Quaternion() {x = val_6, y = val_8, z = val_9, w = val_10};
        UnityEngine.WaitForSeconds val_14 = 536896849;
        val_14 = new UnityEngine.WaitForSeconds(seconds:  val_13.x);
        this.<>2__current = val_14;
        0 = 1;
        this.<>1__state = 0;
        return (bool)0;
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
