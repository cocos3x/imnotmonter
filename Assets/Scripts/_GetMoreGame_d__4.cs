using UnityEngine;
private sealed class MoreGameButton.<GetMoreGame>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public MoreGameButton <>4__this;
    private UnityEngine.WWW <request>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MoreGameButton.<GetMoreGame>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_11;
        UnityEngine.WWW val_12;
        var val_13;
        var val_14;
        var val_15;
        if((this.<>1__state) != 1)
        {
                val_11 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_11;
        }
        
            this.<>1__state = 0;
            UnityEngine.WWW val_1 = 536896821;
            val_1 = new UnityEngine.WWW(url:  -1610600095);
            this.<request>5__2 = val_1;
            this.<>2__current = this.<request>5__2;
            val_11 = 1;
            this.<>1__state = val_11;
            return (bool)val_11;
        }
        
        val_12 = this.<request>5__2;
        this.<>1__state = 0;
        val_11 = 0;
        string val_2 = val_12.error;
        if(val_12 != 0)
        {
                return (bool)val_11;
        }
        
        string val_3 = this.<request>5__2.text;
        LoadGameDictionary val_4 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  this.<request>5__2);
        this.<>4__this.UpdateData(index:  0, info:  this.<request>5__2._uwr);
        if(22999118 != 0)
        {
                val_12 = 22999118;
            val_13 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  static_value_015EF05A);
        }
        else
        {
                val_12 = 22999118;
            val_13 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  static_value_015EF05A);
        }
        
        var val_7 = 22999118 + (val_13 << 2);
        this.<>4__this.UpdateData(index:  1, info:  (22999118 + (val_6) << 2) + 16);
        if(((22999118 + (val_6) << 2) + 16) != 0)
        {
                val_14 = (22999118 + (val_6) << 2) + 16;
            val_15 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  (22999118 + (val_6) << 2) + 16 + 12);
        }
        else
        {
                val_14 = (22999118 + (val_6) << 2) + 16;
            val_15 = UnityEngine.Random.Range(minInclusive:  0, maxExclusive:  (22999118 + (val_6) << 2) + 16 + 12);
        }
        
        var val_10 = ((22999118 + (val_6) << 2) + 16) + (val_15 << 2);
        val_11 = 0;
        this.<>4__this.UpdateData(index:  2, info:  ((22999118 + (val_6) << 2) + 16 + (val_9) << 2) + 16);
        return (bool)val_11;
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
