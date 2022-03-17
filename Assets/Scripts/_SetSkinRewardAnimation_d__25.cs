using UnityEngine;
private sealed class LotterySlotController.<SetSkinRewardAnimation>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LotterySlotController <>4__this;
    public int skinId;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LotterySlotController.<SetSkinRewardAnimation>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610681115));
            UnityEngine.WaitUntil val_2 = 536896879;
            val_2 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_2;
            val_5 = 1;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
                string val_3 = this.skinId.ToString();
            MixSkinManager.SetSkinSkeletonGraphic(ske:  this.<>4__this.characterSkeleton, nameSkin:  this.skinId);
        }
        else
        {
                string val_4 = this.skinId.ToString();
            MixSkinManager.SetSkinSkeletonGraphic(ske:  22965384, nameSkin:  this.skinId);
        }
        
        val_5 = 0;
        this.<>4__this.SetStartAnimation();
        return (bool)val_5;
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
