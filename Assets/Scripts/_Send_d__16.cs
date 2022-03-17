using UnityEngine;
private sealed class WebMessager.<Send>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Ferr.WebMessager <>4__this;
    public string aTo;
    public System.Action<UnityEngine.Texture> aCallback;
    public System.Action<UnityEngine.WWW> aOnError;
    private UnityEngine.WWW <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WebMessager.<Send>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        var val_8;
        UnityEngine.WWW val_9;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            this.<>4__this.BeginMessage();
            UnityEngine.WWW val_1 = 536896821;
            val_1 = new UnityEngine.WWW(url:  this.aTo);
            this.<www>5__2 = val_1;
            this.<>2__current = this.<www>5__2;
            val_7 = 1;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        string val_2 = this.<www>5__2.error;
        if((System.String.IsNullOrEmpty(value:  this.<www>5__2)) == true)
        {
                this.<www>5__2 = this.aCallback;
        }
        
        if((this.<www>5__2) != 0)
        {
            goto label_6;
        }
        
        string val_4 = this.<www>5__2.error;
        if(((System.String.IsNullOrEmpty(value:  this.<www>5__2)) == true) || (this.aOnError == 0))
        {
            goto label_9;
        }
        
        val_8 = -1073740515;
        val_9 = this.<www>5__2;
        goto label_10;
        label_6:
        UnityEngine.Texture2D val_6 = this.<www>5__2.texture;
        val_9 = this.<www>5__2;
        val_8 = -1073740579;
        label_10:
        this.<www>5__2.Invoke(obj:  val_9);
        label_9:
        val_7 = 0;
        this.<>4__this.FinishMessage();
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
