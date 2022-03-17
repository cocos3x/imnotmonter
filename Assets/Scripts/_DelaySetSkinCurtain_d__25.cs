using UnityEngine;
private sealed class DecoHomeBG.<DelaySetSkinCurtain>d__25 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public DecoHomeBG <>4__this;
    public string nameSkin;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DecoHomeBG.<DelaySetSkinCurtain>d__25(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        if((this.<>1__state) != 1)
        {
                val_8 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_8;
        }
        
            this.<>1__state = 0;
            536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610681585));
            UnityEngine.WaitUntil val_2 = 536896879;
            val_2 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_2;
            val_8 = 1;
            this.<>1__state = val_8;
            return (bool)val_8;
        }
        
        this.<>1__state = 0;
        Spine.Skeleton val_3 = this.<>4__this.skeleton_curtain.Skeleton;
        this.<>4__this.skeleton_curtain.SetSkin(skinName:  this.nameSkin);
        Spine.Skeleton val_4 = this.<>4__this.skeleton_curtain.Skeleton;
        this.<>4__this.skeleton_curtain.SetSlotsToSetupPose();
        Spine.AnimationState val_5 = this.<>4__this.skeleton_curtain.AnimationState;
        val_8 = 0;
        Spine.Skeleton val_6 = this.<>4__this.skeleton_curtain.Skeleton;
        bool val_7 = this.<>4__this.skeleton_curtain.Apply(skeleton:  this.<>4__this.skeleton_curtain);
        return (bool)val_8;
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
