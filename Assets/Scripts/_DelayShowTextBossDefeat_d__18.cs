using UnityEngine;
private sealed class GameMenu.<DelayShowTextBossDefeat>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float time;
    public GameMenu <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameMenu.<DelayShowTextBossDefeat>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        object val_6;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_6 = val_1;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_6;
            val_5 = 1;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        val_6 = this.<>4__this;
        this.<>1__state = 0;
        val_5 = 0;
        UnityEngine.GameObject val_2 = this.<>4__this.bossTextSkeleton.gameObject;
        this.<>4__this.bossTextSkeleton.SetActive(value:  true);
        MixSkinManager.SetAnimation(ske:  this.<>4__this.bossTextSkeleton, name:  -1610601567, loop:  false, timeScale:  null, _callBack:  1065353216);
        if((SingletonMonoBehaviour<TransitionFX>.Exists()) == false)
        {
                return (bool)val_5;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_5 = 0;
        -1073701113.Shot(clip:  -1610609915, volume:  null);
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
