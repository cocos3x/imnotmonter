using UnityEngine;
private sealed class PeopleToHelp.<ShowEmoti>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float time;
    public PeopleToHelp <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PeopleToHelp.<ShowEmoti>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        UnityEngine.Sprite[] val_8;
        UnityEngine.SpriteRenderer val_9;
        var val_10;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_7 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = 536896849;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_1;
        val_7 = 1;
        this.<>1__state = val_7;
        return (bool)val_7;
        label_1:
        this.<>1__state = 0;
        val_7 = 0;
        this.<>4__this.txt_Box.SetActive(value:  false);
        float val_2 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
        UnityEngine.Coroutine val_3 = this.<>4__this.StartCoroutine(methodName:  -1610604583, value:  536893745);
        return (bool)val_7;
        label_2:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                val_8 = this.<>4__this.listEmoti;
            val_9 = this.<>4__this.iconEmoti;
            val_10 = val_8;
        }
        else
        {
                val_9 = 0;
            val_10 = 1;
            val_8 = 1;
        }
        
        var val_5 = val_10 + ((UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  50331648)) << 2);
        val_9.sprite = (val_10 + (val_4) << 2) + 16;
        val_7 = 1;
        this.<>4__this.txt_Box.SetActive(value:  true);
        UnityEngine.WaitForSeconds val_6 = 536896849;
        val_6 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_6;
        this.<>1__state = 2;
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
