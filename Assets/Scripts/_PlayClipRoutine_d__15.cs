using UnityEngine;
private sealed class UIPanel.<PlayClipRoutine>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UIPanel <>4__this;
    public string clip;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public UIPanel.<PlayClipRoutine>d__15(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_17;
        var val_18;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_17 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_17;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.isPlaying = true;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_6;
        }
        
        goto label_6;
        label_3:
        0.isPlaying = true;
        label_4:
        bool val_1 = this.<>4__this.anim.Play(animation:  this.clip);
        UnityEngine.AnimationState val_2 = this.<>4__this.anim.Item[this.clip];
        this.<>4__this.anim.time = null;
        label_6:
        UnityEngine.AnimationState val_3 = this.<>4__this.anim.Item[this.clip];
        float val_4 = this.<>4__this.anim.time;
        UnityEngine.AnimationState val_5 = this.<>4__this.anim.Item[this.clip];
        val_18 = this.<>4__this.anim;
        val_17 = 0;
        float val_6 = val_18.length;
        if((this.<>4__this.anim) >= 0)
        {
                this.<>4__this.isPlaying = false;
            if((System.String.op_Equality(a:  this.clip, b:  this.<>4__this.hide)) == false)
        {
                return (bool)val_17;
        }
        
            val_17 = 0;
            UnityEngine.GameObject val_8 = this.<>4__this.gameObject;
            this.<>4__this.SetActive(value:  false);
            return (bool)val_17;
        }
        
        UnityEngine.AnimationState val_9 = this.<>4__this.anim.Item[this.clip];
        this.<>4__this.anim.enabled = true;
        UnityEngine.AnimationState val_10 = this.<>4__this.anim.Item[this.clip];
        float val_11 = this.<>4__this.anim.time;
        float val_12 = UnityEngine.Time.unscaledDeltaTime;
        float val_14 = UnityEngine.Mathf.Min(a:  UnityEngine.Time.maximumDeltaTime, b:  null);
        this.<>4__this.anim.time = (this.<>4__this.anim) + 0;
        this.<>4__this.anim.Sample();
        val_18 = 0;
        UnityEngine.AnimationState val_16 = this.<>4__this.anim.Item[this.clip];
        this.<>4__this.anim.enabled = false;
        this.<>2__current = 536888987;
        val_17 = 1;
        this.<>1__state = val_17;
        return (bool)val_17;
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
