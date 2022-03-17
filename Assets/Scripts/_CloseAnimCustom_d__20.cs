using UnityEngine;
private sealed class AnimUIManager.<CloseAnimCustom>d__20 : IEnumerator<object>, IEnumerator, IDisposable
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
    public AnimUIManager.<CloseAnimCustom>d__20(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_24;
        var val_25;
        int val_26;
        float val_27;
        int val_28;
        int val_29;
        int val_30;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_1 = 18507648 + (18507648 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                18507648 + (this.<>1__state) << 2 = (18507648 + (this.<>1__state) << 2) & ((18507648 + (this.<>1__state) << 2) << (18507648 + (this.<>1__state) << 2));
            18507648 + (this.<>1__state) << 2 = (18507648 + (this.<>1__state) << 2) & ((IP) >> (18507648 + (this.<>1__state) << 2 & (18507648 + (this.<>1__state) << 2) << 18507648 + (this.<>1__state) << 2));
            18507648 + (this.<>1__state) << 2 = (18507648 + (this.<>1__state) << 2) & (23000327 >> (18507648 + (this.<>1__state) << 2));
            18507648 + (this.<>1__state) << 2 = (18507648 + (this.<>1__state) << 2) & 235060714;
        }
        
        val_24 = 1;
        val_25 = this;
        this.<i>5__2 = val_24;
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_3;
        }
        
        goto label_3;
        label_1:
        val_26 = 0;
        return (bool)val_26;
        label_3:
        if( >= (R7 + 40 + 12))
        {
            goto label_16;
        }
        
        if((R7 + 20) == 0)
        {
            goto label_22;
        }
        
        var val_12 = (R7 + 40) + 8;
        if(((R7 + 40 + 8) + 16 + 28 + 12) == 0)
        {
            goto label_22;
        }
        
        val_27 = 0;
        val_28 = 22768632;
        goto label_23;
        label_34:
        var val_13 = (R7 + 40) + 8;
        var val_14 = ((R7 + 40 + 8) + 16 + 28) + 0;
        UnityEngine.Transform val_15 = ((R7 + 40 + 8) + 16 + 28 + 0) + 16.transform;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  ((R7 + 40 + 8) + 16 + 28 + 0) + 16, endValue:  new UnityEngine.Vector3(), duration:  R7 + 24);
        DG.Tweening.Tweener val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  ((R7 + 40 + 8) + 16 + 28 + 0) + 16, ease:  26);
        DG.Tweening.Tweener val_19 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  ((R7 + 40 + 8) + 16 + 28 + 0) + 16, isIndependentUpdate:  true);
        val_27 = 1;
        label_23:
        val_29 = ;
        var val_20 = (R7 + 40) + 8;
        if(val_27 < ((R7 + 40 + 8) + 16 + 28 + 12))
        {
            goto label_34;
        }
        
        this.<>2__current = R7 + 52;
        val_26 = 1;
        this.<>1__state = val_26;
        return (bool)val_26;
        label_22:
        var val_21 = (R7 + 40) + ((this.<i>5__2) << 2);
        UnityEngine.WaitForSecondsRealtime val_22 = 536896855;
        val_29 = val_22;
        val_22 = new UnityEngine.WaitForSecondsRealtime(time:  null);
        this.<>2__current = val_29;
        val_30 = 2;
        goto label_39;
        label_16:
        UnityEngine.WaitForSecondsRealtime val_23 = 536896855;
        val_29 = val_23;
        val_23 = new UnityEngine.WaitForSecondsRealtime(time:  (R7 + 40 + 4) + 16 + 20);
        this.<>2__current = val_29;
        val_30 = 3;
        label_39:
        this.<>1__state = val_30;
        val_26 = 1;
        return (bool)val_26;
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
