using UnityEngine;
private sealed class AudioFade.<FadeOut>d__0 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.AudioSource audioSource;
    public float fadingTime;
    public System.Func<float, float, float, float> Interpolate;
    private float <startVolume>5__2;
    private float <frameCount>5__3;
    private float <framesPassed>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AudioFade.<FadeOut>d__0(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        UnityEngine.AudioSource val_6;
        float val_7;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            val_6 = this.audioSource;
            this.<>1__state = 0;
            val_5 = 0f;
            float val_1 = val_6.volume;
            this.<startVolume>5__2 = val_6;
            float val_2 = UnityEngine.Time.deltaTime;
            this.<framesPassed>5__4 = val_5;
            val_7 = this.fadingTime / 0;
            this.<frameCount>5__3 = val_7;
            if(val_6 <= 0)
        {
                return (bool)val_5;
        }
        
        }
        else
        {
                val_7 = this.<frameCount>5__3;
            this.<>1__state = 0;
        }
        
        if((this.<>1__state) > 1)
        {
                val_5 = 0;
            this.audioSource.volume = val_7;
            return (bool)val_5;
        }
        
        float val_3 = (this.<framesPassed>5__4) / val_7;
        float val_5 = 1f;
        val_5 = (this.<framesPassed>5__4) + val_5;
        this.<framesPassed>5__4 = val_5;
        val_6 = this.Interpolate;
        this.audioSource.volume = this.Interpolate.Invoke(arg1:  val_5, arg2:  null, arg3:  this.<framesPassed>5__4);
        this.<>2__current = 0;
        val_5 = 1;
        this.<>1__state = val_5;
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
