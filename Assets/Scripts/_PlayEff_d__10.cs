using UnityEngine;
private sealed class RandomPosVFXUI.<PlayEff>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public RandomPosVFXUI <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public RandomPosVFXUI.<PlayEff>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_9;
        UnityEngine.RectTransform val_10;
        var val_12;
        float val_13;
        object val_14;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_9 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_4;
        }
        
        val_10 = this.<>4__this.rectTransform;
        float val_1 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
        val_12 = this.<>4__this.posLimmitTop;
        goto label_5;
        label_1:
        this.<>1__state = 0;
        val_9 = 0;
        UnityEngine.Coroutine val_2 = this.<>4__this.StartCoroutine(methodName:  -1610605349);
        return (bool)val_9;
        label_2:
        this.<>1__state = 0;
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610602639, volume:  null);
        val_9 = 1;
        this.<>4__this.particle.Play(withChildren:  true);
        UnityEngine.WaitForSeconds val_4 = 536896849;
        val_14 = val_4;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_14;
        this.<>1__state = 2;
        return (bool)val_9;
        label_4:
        val_10 = 0;
        val_12 = 52;
        val_13 = 4.085283E-38f;
        label_5:
        val_14 = 22965384;
        val_10.anchoredPosition = new UnityEngine.Vector2() {x = 7.286752E-44f, y = 4.085283E-38f};
        UnityEngine.WaitForSeconds val_8 = 536896849;
        val_8 = new UnityEngine.WaitForSeconds(seconds:  UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null), maxInclusive:  null), maxInclusive:  null));
        this.<>2__current = val_8;
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
