using UnityEngine;
private sealed class AnimUIManager.<CloseAnimPopupSequence>d__21 : IEnumerator<object>, IEnumerator, IDisposable
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
    public AnimUIManager.<CloseAnimPopupSequence>d__21(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_21;
        var val_22;
        int val_23;
        float val_24;
        int val_25;
        int val_26;
        int val_27;
        if((this.<>1__state) > 3)
        {
            goto label_1;
        }
        
        var val_1 = 18509176 + (18509176 + (this.<>1__state) << 2);
        if((this.<>1__state) == 3)
        {
                18509176 + (this.<>1__state) << 2 = (18509176 + (this.<>1__state) << 2) & ((18509176 + (this.<>1__state) << 2) << (18509176 + (this.<>1__state) << 2));
            18509176 + (this.<>1__state) << 2 = (18509176 + (this.<>1__state) << 2) & ((IP) >> (18509176 + (this.<>1__state) << 2 & (18509176 + (this.<>1__state) << 2) << 18509176 + (this.<>1__state) << 2));
            18509176 + (this.<>1__state) << 2 = (18509176 + (this.<>1__state) << 2) & (23000328 >> (18509176 + (this.<>1__state) << 2));
            18509176 + (this.<>1__state) << 2 = (18509176 + (this.<>1__state) << 2) & ((18509176 + (this.<>1__state) << 2) << 7);
        }
        
        val_21 = 1;
        val_22 = this;
        this.<i>5__2 = val_21;
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_3;
        }
        
        goto label_3;
        label_1:
        val_23 = 0;
        return (bool)val_23;
        label_3:
        val_26 = mem[R7 + 40];
        val_26 = R7 + 40;
        if( >= (R7 + 40 + 12))
        {
            goto label_16;
        }
        
        if((R7 + 20) == 0)
        {
            goto label_22;
        }
        
        val_26 = mem[R7 + 40];
        val_26 = R7 + 40;
        var val_12 = val_26 + 8;
        if(((R7 + 40 + 8) + 16 + 28 + 12) == 0)
        {
            goto label_22;
        }
        
        val_24 = 0;
        val_25 = 22768632;
        goto label_23;
        label_34:
        var val_13 = (R7 + 40) + 8;
        var val_14 = ((R7 + 40 + 8) + 16 + 28) + 0;
        UnityEngine.Transform val_15 = ((R7 + 40 + 8) + 16 + 28 + 0) + 16.transform;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
        DG.Tweening.Tweener val_17 = DG.Tweening.ShortcutExtensions.DOScale(target:  ((R7 + 40 + 8) + 16 + 28 + 0) + 16, endValue:  new UnityEngine.Vector3(), duration:  R7 + 24);
        DG.Tweening.Tweener val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  ((R7 + 40 + 8) + 16 + 28 + 0) + 16, ease:  26);
        DG.Tweening.Tweener val_19 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  ((R7 + 40 + 8) + 16 + 28 + 0) + 16, isIndependentUpdate:  true);
        val_24 = 1;
        label_23:
        val_26 = ;
        var val_20 = (R7 + 40) + 8;
        if(val_24 < ((R7 + 40 + 8) + 16 + 28 + 12))
        {
            goto label_34;
        }
        
        this.<>2__current = R7 + 52;
        val_23 = 1;
        this.<>1__state = val_23;
        return (bool)val_23;
        label_22:
        this.<>2__current = R7 + 52;
        val_27 = 2;
        goto label_36;
        label_16:
        this.<>2__current = R7 + 52;
        val_27 = 3;
        label_36:
        this.<>1__state = val_27;
        val_23 = 1;
        return (bool)val_23;
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
