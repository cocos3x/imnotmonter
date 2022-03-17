using UnityEngine;
private sealed class AnimUIManager.<AnimPopupSequence>d__14 : IEnumerator<object>, IEnumerator, IDisposable
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
    public AnimUIManager.<AnimPopupSequence>d__14(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        AnimUIManager.<AnimPopupSequence>d__14 val_11;
        int val_12;
        var val_13;
        int val_14;
        val_11 = this;
        val_12 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_12;
        }
        
        this.<>1__state = 0;
        val_13 = 0;
        goto label_3;
        label_11:
        AnimToolUI.AnimUI val_10 = this.<>4__this.animObj[val_13];
        UnityEngine.Transform val_1 = this.<>4__this.animObj[0x0][0].parentObj.transform;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.<>4__this.animObj[0x0][0].parentObj.localScale = new UnityEngine.Vector3() {x = R4, y = R7, z = R8};
        val_13 = 1;
        label_3:
        if(val_13 < (this.<>4__this.animObj[0x0][0].parentObj))
        {
            goto label_11;
        }
        
        val_11 = val_11;
        val_14 = 0;
        val_12 = 0;
        goto label_12;
        label_1:
        this.<>1__state = 0;
        AnimToolUI.AnimUI val_11 = this.<>4__this.animObj[this.<i>5__2];
        UnityEngine.Transform val_3 = this.<>4__this.animObj[this.<i>5__2][0].parentObj.transform;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        DG.Tweening.Tweener val_5 = DG.Tweening.ShortcutExtensions.DOScale(target:  this.<>4__this.animObj[this.<i>5__2][0].parentObj, endValue:  new UnityEngine.Vector3(), duration:  this.<>4__this.timeScale);
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[this.<i>5__2][0].parentObj, ease:  27);
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetUpdate<DG.Tweening.Tweener>(t:  this.<>4__this.animObj[this.<i>5__2][0].parentObj, isIndependentUpdate:  true);
        System.Collections.IEnumerator val_8 = this.<>4__this.AnimChildren(i:  this.<i>5__2);
        UnityEngine.Coroutine val_9 = this.<>4__this.StartCoroutine(routine:  this.<>4__this);
        val_14 = (this.<i>5__2) + 1;
        label_12:
        this.<i>5__2 = val_14;
        if(val_14 >= (this.<i>5__2))
        {
                return (bool)val_12;
        }
        
        this.<>2__current = this.<>4__this.waitForSecondsRealtimeDelay;
        val_12 = 1;
        this.<>1__state = val_12;
        return (bool)val_12;
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
