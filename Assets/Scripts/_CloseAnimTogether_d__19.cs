using UnityEngine;
private sealed class AnimUIManager.<CloseAnimTogether>d__19 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AnimToolUI.AnimUIManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AnimUIManager.<CloseAnimTogether>d__19(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_8;
        float val_9;
        float val_10;
        AnimToolUI.AnimUIManager val_15;
        int val_16;
        var val_17;
        var val_18;
        float val_20;
        var val_21;
        val_15 = this.<>4__this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_16 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_16;
        }
        
        this.<>1__state = 0;
        val_17 = 1;
        val_18 = 0;
        val_20 = 4.030107E-38f;
        goto label_3;
        label_31:
        if((this.<>4__this.useAnimChildren) == false)
        {
            goto label_9;
        }
        
        AnimToolUI.AnimUI val_15 = this.<>4__this.animObj[val_17];
        if((this.<>4__this.animObj[val_17]) == null)
        {
            goto label_9;
        }
        
        val_21 = 0;
        goto label_10;
        label_21:
        AnimToolUI.AnimUI val_16 = this.<>4__this.animObj[val_17];
        UnityEngine.GameObject val_17 = this.<>4__this.animObj[0x1][0].childrenObj[val_21];
        UnityEngine.Transform val_1 = val_17.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_3 = DG.Tweening.ShortcutExtensions.DOScale(target:  val_17, endValue:  new UnityEngine.Vector3(), duration:  this.<>4__this.timeScale);
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  val_17, ease:  26);
        DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  val_17, isIndependentUpdate:  true);
        val_21 = 1;
        label_10:
        AnimToolUI.AnimUI val_18 = this.<>4__this.animObj[val_17];
        if(val_21 < (this.<>4__this.animObj[val_17]))
        {
            goto label_21;
        }
        
        label_9:
        AnimToolUI.AnimUI val_19 = this.<>4__this.animObj[val_17];
        UnityEngine.Transform val_6 = this.<>4__this.animObj[0x1][0].parentObj.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        AnimToolUI.AnimUI val_20 = this.<>4__this.animObj[val_17];
        val_18 = 0;
        DG.Tweening.Tweener val_11 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.animObj[0x1][0].parentObj, endValue:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_10}, duration:  this.<>4__this.animObj[0x1][0].timeScale);
        val_20 = 4.030107E-38f;
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[0x1][0].parentObj, ease:  26);
        DG.Tweening.Tweener val_13 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[0x1][0].parentObj, isIndependentUpdate:  true);
        val_17 = 2;
        label_3:
        if(val_17 < (this.<>4__this.animObj[0x1][0].parentObj))
        {
            goto label_31;
        }
        
        UnityEngine.WaitForSecondsRealtime val_14 = 536896855;
        val_14 = new UnityEngine.WaitForSecondsRealtime(time:  this.<>4__this.animObj[0x1][0].timeScale);
        val_15 = this;
        mem[1152921510012390844] = val_14;
        val_16 = 1;
        this.<>1__state = val_16;
        return (bool)val_16;
        label_1:
        this.<>1__state = 0;
        AnimToolUI.AnimUI val_21 = this.<>4__this.animObj[0];
        val_16 = 0;
        this.<>4__this.animObj[0].parentObj.SetActive(value:  false);
        if((this.<>4__this.OnClose) == 0)
        {
                return (bool)val_16;
        }
        
        val_16 = 0;
        this.<>4__this.OnClose.Invoke();
        return (bool)val_16;
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
