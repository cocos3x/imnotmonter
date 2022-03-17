using UnityEngine;
private sealed class WinPopup.<SetSkinReward>d__71 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public WinPopup <>4__this;
    public int id;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WinPopup.<SetSkinReward>d__71(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) != 1)
        {
                val_6 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_6;
        }
        
            this.<>1__state = 0;
            536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610681421));
            UnityEngine.WaitUntil val_2 = 536896879;
            val_2 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_2;
            val_6 = 1;
            this.<>1__state = val_6;
            return (bool)val_6;
        }
        
        this.<>1__state = 0;
        Spine.Skeleton val_3 = this.<>4__this.skeletonSkinReward.Skeleton;
        string val_4 = this.id.ToString();
        this.<>4__this.skeletonSkinReward.SetSkin(skinName:  this.id);
        Spine.Skeleton val_5 = this.<>4__this.skeletonSkinReward.Skeleton;
        val_6 = 0;
        this.<>4__this.skeletonSkinReward.SetSlotsToSetupPose();
        return (bool)val_6;
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
