using UnityEngine;
private sealed class EnemyAnimController.<FadeOpacity>d__26 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public EnemyAnimController <>4__this;
    public float value;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EnemyAnimController.<FadeOpacity>d__26(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        Spine.Unity.SkeletonAnimation val_6;
        float val_7;
        val_4 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_4;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.characterSkeleton) == 0)
        {
                return (bool)val_4;
        }
        
        val_6 = this.<>4__this.characterSkeleton;
        if((this.<>4__this.characterSkeleton) != 0)
        {
            goto label_5;
        }
        
        val_6 = this.<>4__this.characterSkeleton;
        if(val_6 == 0)
        {
            goto label_6;
        }
        
        label_5:
        float val_1 = UnityEngine.Time.deltaTime;
        uint val_4 = 0;
        val_4 = val_4 + val_4;
        float val_2 = UnityEngine.Mathf.Lerp(a:  val_4, b:  null, t:  null);
        mem2[0] = this.<>4__this.characterSkeleton;
        float val_5 = System.Math.Abs(S2 - this.value);
        if((this.<>4__this.characterSkeleton) <= 0)
        {
                if((this.<>4__this.characterSkeleton) != 0)
        {
                val_7 = this.value;
        }
        else
        {
                val_7 = this.value;
        }
        
            mem2[0] = val_7;
        }
        
        this.<>2__current = 0;
        val_4 = 1;
        this.<>1__state = val_4;
        return (bool)val_4;
        label_6:
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
