using UnityEngine;
private sealed class HomeMenu.<SetSkin>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public HomeMenu <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HomeMenu.<SetSkin>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_15 = 0;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_15;
        }
        
        this.<>1__state = 0;
        536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610681729));
        UnityEngine.WaitUntil val_2 = 536896879;
        val_2 = new UnityEngine.WaitUntil(predicate:  536875159);
        this.<>2__current = val_2;
        val_15 = 1;
        this.<>1__state = val_15;
        return (bool)val_15;
        label_1:
        this.<>1__state = 0;
        Spine.Skeleton val_3 = this.<>4__this.huggy.Skeleton;
        object val_4 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_6 = -1073708883.SkinHuggySelectedID.ToString();
        this.<>4__this.huggy.SetSkin(skinName:  811161620);
        Spine.Skeleton val_7 = this.<>4__this.huggy.Skeleton;
        val_15 = 0;
        this.<>4__this.huggy.SetSlotsToSetupPose();
        this.<>4__this.huggy.LateUpdate();
        return (bool)val_15;
        label_2:
        this.<>1__state = 0;
        Spine.Skeleton val_8 = this.<>4__this.character.Skeleton;
        object val_9 = AFramework.ManualSingletonMono<System.Object>.I;
        string val_11 = -1073708883.SkinSelectedID.ToString();
        this.<>4__this.character.SetSkin(skinName:  811161620);
        Spine.Skeleton val_12 = this.<>4__this.character.Skeleton;
        this.<>4__this.character.SetSlotsToSetupPose();
        this.<>4__this.character.LateUpdate();
        536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610681731));
        UnityEngine.WaitUntil val_14 = 536896879;
        val_14 = new UnityEngine.WaitUntil(predicate:  536875159);
        this.<>2__current = val_14;
        val_15 = 1;
        this.<>1__state = 2;
        return (bool)val_15;
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
