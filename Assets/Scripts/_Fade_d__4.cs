using UnityEngine;
private sealed class SceneFader.<Fade>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SceneFader.FadeDirection fadeDirection;
    public SceneFader <>4__this;
    private float <alpha>5__2;
    private float <fadeEndValue>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SceneFader.<Fade>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_3;
        float val_4;
        float val_5;
        float val_6;
        val_3 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_0;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_3;
        }
        
        val_4 = this.<alpha>5__2;
        this.<>1__state = 0;
        if(this.fadeDirection == 1)
        {
                0 = 1f;
            val_5 = 0;
        }
        
        this.<alpha>5__2 = 0;
        this.<fadeEndValue>5__3 = val_5;
        if(this.fadeDirection == 1)
        {
            goto label_3;
        }
        
        val_6 = this.<fadeEndValue>5__3;
        this.<>4__this.fadeOutUIImage.enabled = true;
        goto label_6;
        label_0:
        val_6 = this.<fadeEndValue>5__3;
        val_4 = this.<alpha>5__2;
        this.<>1__state = 0;
        label_6:
        if((this.<>1__state) > 2)
        {
                return (bool)val_3;
        }
        
        this.<>4__this.SetColorImage(alpha: ref  val_4, fadeDirection:  this.fadeDirection);
        this.<>2__current = 0;
        val_3 = 1;
        this.<>1__state = 2;
        return (bool)val_3;
        label_1:
        val_4 = this.<alpha>5__2;
        this.<>1__state = 0;
        val_5 = this.<fadeEndValue>5__3;
        label_3:
        if((this.<>1__state) < 1)
        {
                val_3 = 0;
            this.<>4__this.fadeOutUIImage.enabled = false;
            return (bool)val_3;
        }
        
        this.<>4__this.SetColorImage(alpha: ref  val_4, fadeDirection:  this.fadeDirection);
        this.<>2__current = 0;
        val_3 = 1;
        this.<>1__state = val_3;
        return (bool)val_3;
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
