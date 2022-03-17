using UnityEngine;
private sealed class MoreGameButton.<LoadImage>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public string url;
    public MoreGameButton <>4__this;
    public int index;
    private UnityEngine.WWW <request>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MoreGameButton.<LoadImage>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        UnityEngine.WWW val_5;
        if((this.<>1__state) != 1)
        {
                val_4 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_4;
        }
        
            this.<>1__state = 0;
            UnityEngine.WWW val_1 = 536896821;
            val_5 = val_1;
            val_1 = new UnityEngine.WWW(url:  this.url);
            this.<request>5__2 = val_5;
            this.<>2__current = this.<request>5__2;
            val_4 = 1;
            this.<>1__state = val_4;
            return (bool)val_4;
        }
        
        val_5 = this.<request>5__2;
        this.<>1__state = 0;
        val_4 = 0;
        string val_2 = val_5.error;
        if(val_5 != 0)
        {
                return (bool)val_4;
        }
        
        UnityEngine.Texture2D val_3 = this.<request>5__2.texture;
        val_5 = this.<request>5__2;
        this.<>4__this.icons[this.index].texture = val_5;
        val_4 = 0;
        this.<>4__this.icons[this.index].enabled = true;
        return (bool)val_4;
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
