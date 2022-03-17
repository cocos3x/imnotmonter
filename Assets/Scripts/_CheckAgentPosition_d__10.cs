using UnityEngine;
private sealed class EnemyWander.<CheckAgentPosition>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemyWander <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EnemyWander.<CheckAgentPosition>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        if((this.<>1__state) > 1)
        {
                return (bool)0;
        }
        
        this.<>1__state = 0;
        float val_1 = this.<>4__this._navMeshAgent.remainingDistance;
        if(((this.<>4__this._navMeshAgent) <= 0) && ((this.<>4__this._hasReachedDestination) != true))
        {
                this.<>4__this._hasReachedDestination = true;
            float val_2 = UnityEngine.Time.time;
            float val_3 = this.<>4__this._startingTime;
            val_3 = 0 - val_3;
            if((this.<>4__this._hasReachedDestination) <= false)
        {
                this.<>4__this.GoToWaypoint();
        }
        else
        {
                UnityEngine.Debug.Log(message:  -1610604349);
        }
        
        }
        
        this.<>2__current = 0;
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
