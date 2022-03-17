using UnityEngine;
private sealed class BossRopeRescueController.<ShowTextHit>d__21 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BossRopeRescueController <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BossRopeRescueController.<ShowTextHit>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        BossRopeRescueController val_6;
        int val_7;
        val_6 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            UnityEngine.GameObject val_1 = this.<>4__this.skeletonTextHit.gameObject;
            this.<>4__this.skeletonTextHit.SetActive(value:  true);
            val_6 = 0;
            Spine.AnimationState val_2 = this.<>4__this.skeletonTextHit.AnimationState;
            Spine.TrackEntry val_3 = this.<>4__this.skeletonTextHit.SetAnimation(trackIndex:  0, animationName:  -1610600187, loop:  false);
            UnityEngine.WaitForSeconds val_4 = 536896849;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_4;
            val_7 = 1;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        val_7 = 0;
        UnityEngine.GameObject val_5 = this.<>4__this.skeletonTextHit.gameObject;
        this.<>4__this.skeletonTextHit.SetActive(value:  false);
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
