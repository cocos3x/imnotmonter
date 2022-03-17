using UnityEngine;
private sealed class EnemyAttack.<FollowTarget>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemyAttack <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EnemyAttack.<FollowTarget>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        float val_3;
        float val_5;
        int val_9;
        Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemyAttack val_10;
        val_9 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_9;
        }
        
        val_10 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>4__this._hasTarget) == false)
        {
                return (bool)val_9;
        }
        
        UnityEngine.Vector2 val_1 = UnityEngine.Random.insideUnitCircle;
        UnityEngine.Vector3 val_4 = position;
        UnityEngine.Vector3 val_6 = position;
        UnityEngine.Vector3 val_7 = position;
        float val_9 = val_2;
        float val_10 = val_3;
        float val_11 = val_5;
        val_9 = val_2 - val_9;
        val_10 = val_3 - val_10;
        val_11 = val_5 - val_11;
        UnityEngine.Vector3 val_8 = normalized;
        float val_12 = 0f;
        float val_14 = val_3;
        float val_13 = val_2;
        val_12 = val_3 + val_12;
        val_13 = val_2 + val_13;
        val_14 = val_5 + val_14;
        val_10 = val_12;
        this.<>4__this._navMeshAgent.destination = new UnityEngine.Vector3() {x = val_13, y = val_10, z = val_14};
        this.<>2__current = 0;
        val_9 = 1;
        this.<>1__state = val_9;
        return (bool)val_9;
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
