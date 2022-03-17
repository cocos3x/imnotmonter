using UnityEngine;
private sealed class WinPopup.<SetSkinChest>d__87 : IEnumerator<object>, IEnumerator, IDisposable
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
    public WinPopup.<SetSkinChest>d__87(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_7;
        if((this.<>1__state) != 1)
        {
                val_7 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_7;
        }
        
            this.<>1__state = 0;
            GameTool.EventDispatcherExtension.PostEvent(sender:  this.<>4__this, eventID:  10);
            UnityEngine.GameObject val_1 = this.<>4__this.skeletonSkin.gameObject;
            val_7 = 1;
            this.<>4__this.skeletonSkin.SetActive(value:  true);
            536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610681433));
            UnityEngine.WaitUntil val_3 = 536896879;
            val_3 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_3;
            this.<>1__state = val_7;
            return (bool)val_7;
        }
        
        this.<>1__state = 0;
        Spine.Skeleton val_4 = this.<>4__this.skeletonSkin.Skeleton;
        string val_5 = this.id.ToString();
        this.<>4__this.skeletonSkin.SetSkin(skinName:  this.id);
        Spine.Skeleton val_6 = this.<>4__this.skeletonSkin.Skeleton;
        val_7 = 0;
        this.<>4__this.skeletonSkin.SetSlotsToSetupPose();
        return (bool)val_7;
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
