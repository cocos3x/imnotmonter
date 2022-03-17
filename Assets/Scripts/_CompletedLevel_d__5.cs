using UnityEngine;
private sealed class ReachedPeople.<CompletedLevel>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ReachedPeople.<CompletedLevel>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_5 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
        this.<>1__state = 0;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        mem[3221266371] = 0;
        UnityEngine.WaitForSecondsRealtime val_2 = 536896855;
        val_2 = new UnityEngine.WaitForSecondsRealtime(time:  null);
        this.<>2__current = val_2;
        val_5 = 1;
        this.<>1__state = val_5;
        return (bool)val_5;
        label_1:
        this.<>1__state = 0;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_5 = 0;
        -1073701029.LevelCompleted();
        return (bool)val_5;
        label_2:
        this.<>1__state = 0;
        UnityEngine.WaitForSecondsRealtime val_4 = 536896855;
        val_4 = new UnityEngine.WaitForSecondsRealtime(time:  null);
        this.<>2__current = val_4;
        val_5 = 1;
        this.<>1__state = 2;
        return (bool)val_5;
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
