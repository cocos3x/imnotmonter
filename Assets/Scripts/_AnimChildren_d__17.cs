using UnityEngine;
private sealed class AnimUIManager.<AnimChildren>d__17 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AnimToolUI.AnimUIManager <>4__this;
    public int i;
    private int <j>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AnimUIManager.<AnimChildren>d__17(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        float val_5;
        float val_6;
        int val_14;
        AnimToolUI.AnimUI[] val_15;
        var val_16;
        float val_17;
        val_14 = 0;
        if((this.<>1__state) > 3)
        {
                return (bool)val_14;
        }
        
        var val_1 = 18503232 + (18503232 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                18503232 + (this.<>1__state) << 2 = (18503232 + (this.<>1__state) << 2) & ((18503232 + (this.<>1__state) << 2) << (18503232 + (this.<>1__state) << 2));
            18503232 + (this.<>1__state) << 2 = (18503232 + (this.<>1__state) << 2) & ((IP) << 4);
            18503232 + (this.<>1__state) << 2 = (18503232 + (this.<>1__state) << 2) & (val_14 >> R2);
            18503232 + (this.<>1__state) << 2 = (18503232 + (this.<>1__state) << 2) & ((18503232 + (this.<>1__state) << 2) >> R2);
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.useAnimChildren) == false)
        {
                return (bool)val_14;
        }
        
        val_15 = this.<>4__this.animObj;
        AnimToolUI.AnimUI val_14 = val_15[this.i];
        if(val_15[this.i] == null)
        {
                return (bool)val_14;
        }
        
        val_16 = 0;
        goto label_9;
        label_21:
        AnimToolUI.AnimUI val_15 = this.<>4__this.animObj[this.i];
        UnityEngine.GameObject val_16 = this.<>4__this.animObj[this.i][0].childrenObj[val_16];
        UnityEngine.Transform val_2 = val_16.transform;
        val_15 = val_16;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        val_17 = val_4;
        val_15.localScale = new UnityEngine.Vector3() {x = val_17, y = val_5, z = val_6};
        val_16 = 1;
        label_9:
        AnimToolUI.AnimUI val_17 = this.<>4__this.animObj[this.i];
        if(val_16 < (this.<>4__this.animObj[this.i]))
        {
            goto label_21;
        }
        
        if((this.<>4__this.useTimeChildren) != false)
        {
                UnityEngine.WaitForSecondsRealtime val_7 = 536896855;
            val_7 = new UnityEngine.WaitForSecondsRealtime(time:  val_3.x);
            this.<>2__current = val_7;
            val_14 = 1;
            this.<>1__state = val_14;
            return (bool)val_14;
        }
        
        mem[1152921510010842312] = this.<>4__this.waitForSecondsRealtimeDelay;
        label_45:
        this.i = 2;
        val_14 = 1;
        return (bool)val_14;
        label_41:
        AnimToolUI.AnimUI val_18 = this.<>4__this.animObj[this.<>4__this.timeDelayOpenChildren];
        UnityEngine.GameObject val_19 = this.<>4__this.animObj[this.<>4__this.timeDelayOpenChildren][0].childrenObj[null];
        UnityEngine.Transform val_8 = val_19.transform;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_10 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_19, endValue:  new UnityEngine.Vector3(), duration:  this.<>4__this.timeScale);
        DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  val_19, ease:  27);
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  val_19, isIndependentUpdate:  true);
        if((this.<>4__this.useTimeChildren) == true)
        {
            goto label_35;
        }
        
        mem2[0] = val_19;
        AnimToolUI.AnimUI val_20 = this.<>4__this.animObj[this.<>4__this.animObj[this.<>4__this.timeDelayOpenChildren][0].childrenObj];
        if(val_19 < (this.<>4__this.animObj[this.<>4__this.animObj[this.<>4__this.timeDelayOpenChildren][0].childrenObj]))
        {
            goto label_41;
        }
        
        return (bool)val_14;
        label_35:
        AnimToolUI.AnimUI val_21 = this.<>4__this.animObj[val_19];
        UnityEngine.WaitForSecondsRealtime val_13 = 536896855;
        val_13 = new UnityEngine.WaitForSecondsRealtime(time:  this.<>4__this.timeScale);
        mem[1152921510010842324] = val_13;
        goto label_45;
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
