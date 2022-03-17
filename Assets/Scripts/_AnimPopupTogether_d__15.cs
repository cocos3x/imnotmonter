using UnityEngine;
private sealed class AnimUIManager.<AnimPopupTogether>d__15 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AnimToolUI.AnimUIManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AnimUIManager.<AnimPopupTogether>d__15(int <>1__state)
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
        int val_18;
        float val_19;
        var val_20;
        AnimToolUI.AnimUI[] val_21;
        AnimUIManager.<AnimPopupTogether>d__15 val_23;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_18 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_18;
        }
        
        this.<>1__state = 0;
        val_20 = 0;
        goto label_3;
        label_12:
        val_21 = this.<>4__this.animObj;
        if(val_21 != null)
        {
            
        }
        else
        {
                val_21 = 0;
        }
        
        label_13:
        var val_1 = val_21 + 0;
        UnityEngine.Transform val_2 = (val_21 + 0) + 16 + 8.transform;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
        (val_21 + 0) + 16 + 8.localScale = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
        val_20 = 1;
        label_3:
        val_21 = this.<>4__this.animObj;
        if(val_21 == null)
        {
            goto label_12;
        }
        
        if(val_20 < ((val_21 + 0) + 16 + 8))
        {
            goto label_13;
        }
        
        AnimToolUI.AnimUI val_20 = val_21[0];
        val_23 = this;
        UnityEngine.Transform val_7 = this.<>4__this.animObj[0].parentObj.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_9 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.animObj[0].parentObj, endValue:  new UnityEngine.Vector3(), duration:  this.<>4__this.timeScale);
        DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[0].parentObj, ease:  27);
        val_18 = 1;
        DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[0].parentObj, isIndependentUpdate:  true);
        mem[1152921510008167100] = this.<>4__this.waitForSecondsRealtimeDelay;
        this.<>1__state = val_18;
        return (bool)val_18;
        label_1:
        val_23 = 5;
        this.<>1__state = 0;
        val_19 = 4.030107E-38f;
        val_20 = 22768632;
        goto label_18;
        label_25:
        AnimToolUI.AnimUI val_21 = this.<>4__this.animObj[1];
        UnityEngine.Transform val_12 = this.<>4__this.animObj[1].parentObj.transform;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_14 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.animObj[1].parentObj, endValue:  new UnityEngine.Vector3(), duration:  this.<>4__this.timeScale);
        DG.Tweening.Tweener val_15 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[1].parentObj, ease:  27);
        DG.Tweening.Tweener val_16 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[1].parentObj, isIndependentUpdate:  true);
        System.Collections.IEnumerator val_17 = this.<>4__this.AnimChildren(i:  R6);
        UnityEngine.Coroutine val_18 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        val_23 = 6;
        label_18:
        if((val_23 - 4) < (this.<>4__this))
        {
            goto label_25;
        }
        
        val_18 = 0;
        return (bool)val_18;
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
