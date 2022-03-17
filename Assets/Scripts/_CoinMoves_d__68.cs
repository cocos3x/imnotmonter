using UnityEngine;
private sealed class WinPopup.<CoinMoves>d__68 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WinPopup <>4__this;
    private WinPopup.<>c__DisplayClass68_0 <>8__1;
    private WinPopup.<>c__DisplayClass68_1 <>8__2;
    private int <i>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WinPopup.<CoinMoves>d__68(int <>1__state)
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
        var val_60;
        WinPopup val_61;
        int val_62;
        float val_63;
        WinPopup.<>c__DisplayClass68_1 val_64;
        WinPopup val_65;
        val_60 = this;
        val_61 = this.<>4__this;
        if((this.<>1__state) != 1)
        {
                val_62 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_62;
        }
        
            this.<>1__state = 0;
            object val_1 = 536902481;
            val_1 = new System.Object();
            this.<>8__1 = val_1;
            this.<>8__1.<>4__this = this.<>4__this;
            mem2[0] = 429496729;
            this.<i>5__2 = 0;
        }
        else
        {
                this.<>1__state = 0;
            WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            UnityEngine.Vector3 val_3 = position;
            UnityEngine.GameObject val_7 = -1073701087.GetItem(key:  -1610609311, position:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
            this.<>8__2.coin = -1073701087;
            val_63 = this.<>8__2;
            UnityEngine.Transform val_8 = this.<>8__2 + 8.transform;
            UnityEngine.Transform val_9 = this.<>4__this + 84.transform;
            this.<>8__2 + 8.parent = this.<>4__this + 84;
            UnityEngine.Transform val_10 = this.<>8__2 + 8.transform;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            float val_62 = 0.8f;
            float val_60 = val_5;
            float val_61 = val_6;
            val_60 = val_60 * val_62;
            val_61 = val_61 * val_62;
            val_62 = val_4 * val_62;
            this.<>8__2 + 8.localScale = new UnityEngine.Vector3() {x = val_62, y = val_60, z = val_61};
            UnityEngine.Transform val_12 = this.<>8__2 + 8.transform;
            UnityEngine.Vector3 val_13 = localPosition;
            UnityEngine.Transform val_14 = this.<>8__2 + 8.transform;
            UnityEngine.Vector3 val_15 = localPosition;
            float val_63 = val_4;
            val_63 = val_63 + 100f;
            float val_16 = UnityEngine.Random.Range(minInclusive:  val_63, maxInclusive:  val_15.y);
            UnityEngine.Transform val_17 = this.<>8__2 + 8.transform;
            UnityEngine.Vector3 val_18 = localPosition;
            UnityEngine.Transform val_19 = this.<>8__2 + 8.transform;
            UnityEngine.Vector3 val_20 = localPosition;
            float val_64 = val_5;
            val_64 = val_64 + (-200f);
            float val_22 = UnityEngine.Random.Range(minInclusive:  val_64, maxInclusive:  val_20.y);
            UnityEngine.Transform val_23 = this.<>8__2 + 8.transform;
            UnityEngine.Vector3 val_24 = localPosition;
            val_61 = val_6;
            val_64 = 0;
            UnityEngine.Transform val_25 = this.<>8__2 + 8.transform;
            DG.Tweening.Tweener val_26 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  this.<>8__2 + 8, endValue:  new UnityEngine.Vector3() {x = val_4, y = val_5 + (-100f), z = val_61}, duration:  val_24.x, snapping:  true);
            DG.Tweening.Tweener val_27 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.<>8__2 + 8, ease:  7);
            536895905 = new DG.Tweening.TweenCallback(object:  this.<>8__2, method:  new IntPtr(1610681451));
            DG.Tweening.Tweener val_29 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.<>8__2 + 8, action:  536895905);
            this.<>8__2 = val_64;
            int val_65 = this.<i>5__2;
            val_65 = val_65 + 1;
            this.<i>5__2 = val_65;
            if(val_65 >= 10)
        {
                object val_30 = AFramework.ManualSingletonMono<System.Object>.I;
            val_62 = 0;
            val_65 = val_61;
            if((-1073708883.RopeTapeBonusReward) >= 1)
        {
                object val_32 = 536902491;
            val_32 = new System.Object();
            mem[536902503] = this.<>8__1;
            WorldTimeAPI val_33 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            UnityEngine.Vector3 val_34 = position;
            UnityEngine.GameObject val_35 = -1073701087.GetItem(key:  -1610604053, position:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
            val_60 = val_32;
            mem[536902499] = -1073701087;
            UnityEngine.Transform val_36 = mem[536902499].transform;
            UnityEngine.Transform val_37 = this.<>4__this + 84.transform;
            mem[536902499].parent = this.<>4__this + 84;
            UnityEngine.Transform val_38 = mem[536902499].transform;
            UnityEngine.Vector3 val_39 = UnityEngine.Vector3.one;
            mem[536902499].localScale = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
            UnityEngine.Transform val_40 = mem[536902499].transform;
            UnityEngine.Vector3 val_41 = localPosition;
            UnityEngine.Transform val_42 = mem[536902499].transform;
            UnityEngine.Vector3 val_43 = localPosition;
            float val_66 = val_4;
            val_66 = val_66 + 100f;
            float val_44 = UnityEngine.Random.Range(minInclusive:  val_66, maxInclusive:  val_43.y);
            val_63 = val_4;
            UnityEngine.Transform val_45 = mem[536902499].transform;
            UnityEngine.Vector3 val_46 = localPosition;
            UnityEngine.Transform val_47 = mem[536902499].transform;
            UnityEngine.Vector3 val_48 = localPosition;
            float val_67 = val_5;
            val_67 = val_67 + (-200f);
            float val_50 = UnityEngine.Random.Range(minInclusive:  val_67, maxInclusive:  val_48.y);
            UnityEngine.Transform val_51 = mem[536902499].transform;
            val_64 = 0;
            UnityEngine.Vector3 val_52 = localPosition;
            val_61 = val_6;
            UnityEngine.Transform val_53 = mem[536902499].transform;
            DG.Tweening.Tweener val_54 = DG.Tweening.ShortcutExtensions.DOLocalMove(target:  -1073701087, endValue:  new UnityEngine.Vector3() {x = val_63, y = val_5 + (-100f), z = val_61}, duration:  val_52.x, snapping:  true);
            DG.Tweening.Tweener val_55 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  -1073701087, ease:  7);
            536895905 = new DG.Tweening.TweenCallback(object:  536902491, method:  new IntPtr(1610681457));
            DG.Tweening.Tweener val_57 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  -1073701087, action:  536895905);
            val_65 = val_61;
        }
        
            val_65.ShowLoseIt();
            return (bool)val_62;
        }
        
        }
        
        object val_58 = 536902487;
        val_58 = new System.Object();
        this.<>8__2 = val_58;
        mem[536902499] = this.<>8__1;
        UnityEngine.WaitForSeconds val_59 = 536896849;
        val_59 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_59;
        val_62 = 1;
        this.<>1__state = val_62;
        return (bool)val_62;
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
