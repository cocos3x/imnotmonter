using UnityEngine;
private sealed class BoundariesAnimator.<BottomTransitionRoutine>d__22 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.BoundariesAnimator <>4__this;
    public float duration;
    public bool turnOffBoundaryAfterwards;
    private float <initialBottomBoundary>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BoundariesAnimator.<BottomTransitionRoutine>d__22(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        int val_9;
        System.Func<UnityEngine.Vector3, System.Single> val_10;
        float val_11;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries val_13;
        float val_14;
        val_9 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_9;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        val_10 = this.<>4__this.Vector3V;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>1__state) <= 1)
        {
            goto label_5;
        }
        
        if(this.turnOffBoundaryAfterwards == false)
        {
            goto label_6;
        }
        
        this.<>4__this.NumericBoundaries.UseBottomBoundary = false;
        this.<>4__this.UseBottomBoundary = false;
        goto label_30;
        label_5:
        if((this.<>4__this) != 0)
        {
            goto label_11;
        }
        
        goto label_11;
        label_3:
        val_10 = 256;
        label_4:
        UnityEngine.Vector3 val_1 = LocalPosition;
        float val_3 = val_10.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = SB, z = val_2});
        this.<initialBottomBoundary>5__2 = 256;
        val_13 = this.<>4__this.NumericBoundaries;
        this.<>4__this.NumericBoundaries.TargetBottomBoundary = this.<>4__this.BottomBoundary;
        val_11 = 0f;
        this.<t>5__3 = 0f;
        label_11:
        float val_8 = this.duration;
        val_14 = this.<>4__this.ProCamera2D.<DeltaTime>k__BackingField;
        val_8 = val_14 / val_8;
        val_8 = val_11 + val_8;
        this.<t>5__3 = val_8;
        if((this.<>4__this.UseBottomBoundary) == false)
        {
            goto label_27;
        }
        
        if((this.<>4__this.UseTopBoundary) == false)
        {
            goto label_18;
        }
        
        val_14 = this.<initialBottomBoundary>5__2;
        if((this.<>4__this.UseTopBoundary) < 0)
        {
            goto label_19;
        }
        
        label_18:
        float val_4 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_8, end:  val_1.y, value:  val_14, type:  this.<initialBottomBoundary>5__2);
        this.<>4__this.NumericBoundaries.BottomBoundary = this.<initialBottomBoundary>5__2;
        UnityEngine.Vector3 val_5 = LocalPosition;
        val_10 = val_2;
        float val_6 = this.<>4__this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = SB, z = val_10});
        if(((this.<>4__this.NumericBoundaries) >= 0) || ((this.<>4__this.NumericBoundaries) >= 0))
        {
            goto label_27;
        }
        
        label_19:
        this.<>4__this.NumericBoundaries.BottomBoundary = this.<>4__this.Vector3V;
        label_27:
        UnityEngine.YieldInstruction val_7 = this.<>4__this.ProCamera2D.GetYield();
        this.<>2__current = this.<>4__this.ProCamera2D;
        val_9 = 1;
        this.<>1__state = val_9;
        return (bool)val_9;
        label_6:
        label_30:
        if((this.<>4__this.NumericBoundaries.HasFiredTransitionFinished) == true)
        {
                return (bool)val_9;
        }
        
        if((this.<>4__this.OnTransitionFinished) == 0)
        {
                return (bool)val_9;
        }
        
        this.<>4__this.NumericBoundaries.HasFiredTransitionStarted = false;
        this.<>4__this.NumericBoundaries.HasFiredTransitionFinished = true;
        this.<>4__this.OnTransitionFinished.Invoke();
        return (bool)val_9;
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
