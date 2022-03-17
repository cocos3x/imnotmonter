using UnityEngine;
private sealed class AudioManager.<CrossFade>d__12 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameTool.AudioManager <>4__this;
    public UnityEngine.AudioClip to;
    private float <delay>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AudioManager.<CrossFade>d__12(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_14;
        float val_15;
        float val_16;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_14 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_14;
        }
        
        val_15 = this;
        this.<delay>5__2 = 0.3f;
        this.<>1__state = 0;
        UnityEngine.AudioClip val_1 = this.<>4__this.music.clip;
        if((this.<>4__this.music) != 0)
        {
            goto label_8;
        }
        
        goto label_12;
        label_1:
        val_16 = this.<delay>5__2;
        this.<>1__state = 0;
        goto label_23;
        label_2:
        val_15 = this.<delay>5__2;
        this.<>1__state = 0;
        label_8:
        if((this.<>1__state) > 1)
        {
            goto label_11;
        }
        
        label_12:
        val_16 = this.<>4__this.music;
        val_16.clip = this.to;
        if(this.to != 0)
        {
            goto label_16;
        }
        
        val_14 = 0;
        this.<>4__this.music.Stop();
        return (bool)val_14;
        label_11:
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        val_16 = 0;
        float val_5 = -1073708883.MusicVolume;
        this.<>4__this.ChangeMusicVolume(value:  val_15 * 3221258413);
        float val_7 = UnityEngine.Time.unscaledDeltaTime;
        uint val_14 = 0;
        val_14 = (this.<delay>5__2) - val_14;
        this.<delay>5__2 = val_14;
        this.<>2__current = 536888987;
        val_14 = 1;
        this.<>1__state = val_14;
        return (bool)val_14;
        label_16:
        val_16 = this;
        this.<delay>5__2 = 0f;
        if((this.<>4__this.music.isPlaying) != true)
        {
                this.<>4__this.music.Play();
        }
        
        label_23:
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        if((this.<>4__this.music) < 0)
        {
            goto label_25;
        }
        
        float val_10 = -1073708883.MusicVolume;
        if((this.<>4__this) == 0)
        {
            goto label_27;
        }
        
        this.<>4__this.ChangeMusicVolume(value:  val_10);
        goto label_28;
        label_25:
        val_16 = 0;
        float val_11 = -1073708883.MusicVolume;
        this.<>4__this.ChangeMusicVolume(value:  (this.<delay>5__2) * 3221258413);
        float val_13 = UnityEngine.Time.unscaledDeltaTime;
        uint val_15 = 0;
        val_15 = (this.<delay>5__2) + val_15;
        this.<delay>5__2 = val_15;
        this.<>2__current = 536888987;
        val_14 = 1;
        this.<>1__state = 2;
        return (bool)val_14;
        label_27:
        0.ChangeMusicVolume(value:  val_10);
        label_28:
        val_14 = 0;
        this.<>4__this.music.loop = true;
        return (bool)val_14;
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
