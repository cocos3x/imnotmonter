using UnityEngine;
private sealed class AnimUIManager.<AnimPopupCustom>d__16 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AnimToolUI.AnimUIManager <>4__this;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AnimUIManager.<AnimPopupCustom>d__16(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        float val_4;
        float val_5;
        AnimUIManager.<AnimPopupCustom>d__16 val_15;
        int val_16;
        float val_17;
        float val_18;
        AnimUIManager.<AnimPopupCustom>d__16 val_19;
        int val_20;
        var val_21;
        int val_22;
        val_15 = this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_16 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_16;
        }
        
        this.<>1__state = 0;
        val_17 = 0;
        goto label_4;
        label_12:
        AnimToolUI.AnimUI val_15 = this.<>4__this.animObj[val_17];
        UnityEngine.Transform val_1 = this.<>4__this.animObj[0x0][0].parentObj.transform;
        val_15 = this.<>4__this.animObj[0x0][0].parentObj;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        val_15.localScale = new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5};
        val_17 = 1;
        label_4:
        if(val_17 < val_15)
        {
            goto label_12;
        }
        
        val_19 = val_15;
        val_20 = 0;
        val_21 = val_19;
        mem[1152921510009367492] = val_20;
        goto label_13;
        label_1:
        this.<>1__state = 0;
        val_16 = 0;
        GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  18);
        return (bool)val_16;
        label_2:
        this.<>1__state = 0;
        val_21 = val_15;
        AnimToolUI.AnimUI val_16 = this.<>4__this.animObj[this.<i>5__2];
        UnityEngine.Transform val_6 = this.<>4__this.animObj[this.<i>5__2][0].parentObj.transform;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        val_17 = val_5;
        AnimToolUI.AnimUI val_17 = this.<>4__this.animObj[mem[1152921510009367492]];
        val_18 = this.<>4__this.animObj[0x0][0].timeScale;
        DG.Tweening.Tweener val_8 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.animObj[this.<i>5__2][0].parentObj, endValue:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_17}, duration:  val_18);
        val_15 = this.<>4__this.animObj;
        val_19 = val_15;
        AnimToolUI.AnimUI val_18 = val_15[mem[1152921510009367492]];
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[this.<i>5__2][0].parentObj, ease:  this.<>4__this.animObj[0x0][0].easeAnim);
        DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[this.<i>5__2][0].parentObj, isIndependentUpdate:  true);
        System.Collections.IEnumerator val_11 = this.<>4__this.AnimChildren(i:  0);
        UnityEngine.Coroutine val_12 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        val_20 = 1;
        this.<i>5__2 = val_20;
        label_13:
        if(val_20 < mem[1152921510009367492])
        {
                val_22 = this.<i>5__2;
            if(val_22 == 0)
        {
                AnimToolUI.AnimUI val_19 = this.<>4__this.animObj[0];
            this.<>4__this.animObj[0].parentObj.SetActive(value:  true);
            val_22 = this.<i>5__2;
        }
        
            AnimToolUI.AnimUI val_20 = this.<>4__this.animObj[val_22];
            UnityEngine.WaitForSecondsRealtime val_13 = 536896855;
            val_13 = new UnityEngine.WaitForSecondsRealtime(time:  val_18);
            mem[1152921510009367484] = val_13;
            val_16 = 1;
            this.<>1__state = val_16;
            return (bool)val_16;
        }
        
        UnityEngine.WaitForSecondsRealtime val_14 = 536896855;
        val_14 = new UnityEngine.WaitForSecondsRealtime(time:  val_18);
        mem[1152921510009367484] = val_14;
        val_16 = 1;
        this.<>1__state = 2;
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
