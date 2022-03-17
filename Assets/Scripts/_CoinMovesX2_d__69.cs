using UnityEngine;
private sealed class WinPopup.<CoinMovesX2>d__69 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WinPopup <>4__this;
    private WinPopup.<>c__DisplayClass69_0 <>8__1;
    private WinPopup.<>c__DisplayClass69_1 <>8__2;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WinPopup.<CoinMovesX2>d__69(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_9;
        float val_10;
        float val_11;
        WinPopup val_34;
        int val_35;
        int val_36;
        int val_37;
        val_34 = this.<>4__this;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        val_35 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_35;
        }
        
        this.<>1__state = 0;
        object val_1 = 536902493;
        val_1 = new System.Object();
        this.<>8__1 = val_1;
        this.<>8__1.<>4__this = this.<>4__this;
        if(val_34 == 0)
        {
            goto label_5;
        }
        
        val_36 = this.<>4__this.coinWin;
        goto label_6;
        label_1:
        this.<>1__state = 0;
        val_35 = 0;
        val_34.NextLevelButtonClick();
        return (bool)val_35;
        label_2:
        this.<>1__state = 0;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        UnityEngine.Vector3 val_3 = position;
        UnityEngine.GameObject val_4 = -1073701087.GetItem(key:  -1610609311, position:  new UnityEngine.Vector3() {x = R4, y = R5, z = ???});
        this.<>8__2.coin = -1073701087;
        val_37 = this.<>8__2;
        UnityEngine.Transform val_5 = this.<>8__2 + 8.transform;
        UnityEngine.Transform val_6 = this.<>4__this.coinHolder.transform;
        this.<>8__2 + 8.parent = this.<>4__this.coinHolder;
        UnityEngine.Transform val_7 = this.<>8__2 + 8.transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        float val_36 = 0.8f;
        float val_34 = val_9;
        float val_35 = val_10;
        val_34 = val_34 * val_36;
        val_35 = val_35 * val_36;
        val_36 = val_11 * val_36;
        this.<>8__2 + 8.localScale = new UnityEngine.Vector3() {x = val_36, y = val_34, z = val_35};
        UnityEngine.Transform val_12 = this.<>8__2 + 8.transform;
        UnityEngine.Vector3 val_13 = localPosition;
        UnityEngine.Transform val_14 = this.<>8__2 + 8.transform;
        UnityEngine.Vector3 val_15 = localPosition;
        float val_37 = 100f;
        val_37 = val_11 + val_37;
        float val_16 = UnityEngine.Random.Range(minInclusive:  val_37, maxInclusive:  val_15.y);
        UnityEngine.Transform val_17 = this.<>8__2 + 8.transform;
        UnityEngine.Vector3 val_18 = localPosition;
        UnityEngine.Transform val_19 = this.<>8__2 + 8.transform;
        UnityEngine.Vector3 val_20 = localPosition;
        float val_38 = -100f;
        float val_39 = -200f;
        val_38 = val_9 + val_38;
        val_39 = val_9 + val_39;
        float val_21 = UnityEngine.Random.Range(minInclusive:  val_38, maxInclusive:  val_20.y);
        UnityEngine.Transform val_22 = this.<>8__2 + 8.transform;
        UnityEngine.Vector3 val_23 = localPosition;
        val_36 = 0;
        UnityEngine.Transform val_24 = this.<>8__2 + 8.transform;
        DG.Tweening.Tweener val_25 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.<>8__2 + 8, endValue:  new UnityEngine.Vector3() {x = val_11, y = val_38, z = val_10}, duration:  val_23.x, snapping:  true);
        DG.Tweening.Tweener val_26 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.<>8__2 + 8, ease:  7);
        val_34 = 536895905;
        val_34 = new DG.Tweening.TweenCallback(object:  this.<>8__2, method:  new IntPtr(1610681477));
        DG.Tweening.Tweener val_28 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.<>8__2 + 8, action:  536895905);
        this.<>8__2 = val_36;
        int val_40 = this.<i>5__2;
        val_40 = val_40 + 1;
        this.<i>5__2 = val_40;
        if(val_40 < 10)
        {
            goto label_37;
        }
        
        UnityEngine.WaitForSeconds val_29 = 536896849;
        val_29 = new UnityEngine.WaitForSeconds(seconds:  val_23.x);
        this.<>2__current = val_29;
        val_35 = 1;
        this.<>1__state = 2;
        return (bool)val_35;
        label_5:
        val_36 = 22013840;
        label_6:
        val_37 = 0;
        int val_30 = val_34.ValueCoinGet();
        val_30 = val_30 * val_36;
        val_30 = (val_30 >> 2) + (val_30 >> 31);
        mem2[0] = val_30;
        this.<i>5__2 = val_37;
        label_37:
        object val_32 = 536902499;
        val_32 = new System.Object();
        this.<>8__2 = val_32;
        mem[536902511] = this.<>8__1;
        UnityEngine.WaitForSeconds val_33 = 536896849;
        val_33 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_33;
        val_35 = 1;
        this.<>1__state = val_35;
        return (bool)val_35;
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
