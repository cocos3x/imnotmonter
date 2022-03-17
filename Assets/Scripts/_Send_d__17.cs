using UnityEngine;
private sealed class WebMessager.<Send>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Ferr.WebMessager <>4__this;
    public string aTo;
    public UnityEngine.WWWForm aForm;
    public System.Action<UnityEngine.WWW> aCallback;
    public System.Action<UnityEngine.WWW> aOnError;
    private UnityEngine.WWW <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WebMessager.<Send>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) != 1)
        {
                val_6 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            this.<>4__this.BeginMessage();
            UnityEngine.WWW val_1 = 536896821;
            val_1 = new UnityEngine.WWW(url:  this.aTo, form:  this.aForm);
            this.<www>5__2 = val_1;
            this.<>2__current = this.<www>5__2;
            val_6 = 1;
            this.<>1__state = val_6;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        string val_2 = this.<www>5__2.error;
        bool val_3 = System.String.IsNullOrEmpty(value:  this.<www>5__2);
        if(val_3 == true)
        {
                val_3 = this.aCallback;
        }
        
        if(val_3 != 0)
        {
            goto label_6;
        }
        
        string val_4 = this.<www>5__2.error;
        if(((System.String.IsNullOrEmpty(value:  this.<www>5__2)) == true) || (this.aOnError == 0))
        {
            goto label_9;
        }
        
        label_6:
        this.aOnError.Invoke(obj:  this.<www>5__2);
        label_9:
        val_6 = 0;
        this.<>4__this.FinishMessage();
        return (bool)val_6;
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
