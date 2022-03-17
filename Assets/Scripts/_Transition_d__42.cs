using UnityEngine;
private sealed class ProCamera2DTriggerBoundaries.<Transition>d__42 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerBoundaries <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DTriggerBoundaries.<Transition>d__42(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        var val_4;
        bool val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries val_22;
        UnityEngine.Coroutine val_23;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_17 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_17;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this.UseTopBoundary) == false)
        {
                this.<>4__this.UseTopBoundary = this.<>4__this.UseBottomBoundary;
            goto label_4;
        }
        
        label_51:
        UnityEngine.Transform val_1 = this.<>4__this.transform;
        UnityEngine.Vector3 val_2 = position;
        val_18 = this.<>4__this.TopBoundary;
        if((this.<>4__this.AreBoundariesRelative) == false)
        {
            goto label_6;
        }
        
        val_18 = val_3 + val_18;
        val_19 = val_3 + (this.<>4__this.BottomBoundary);
        val_20 = val_4 + (this.<>4__this.LeftBoundary);
        val_21 = val_4 + (this.<>4__this.RightBoundary);
        goto label_7;
        label_1:
        this.<>1__state = 0;
        val_17 = 0;
        this.<>4__this._boundsAnim.Transition();
        return (bool)val_17;
        label_6:
        val_19 = this.<>4__this.BottomBoundary;
        val_20 = this.<>4__this.LeftBoundary;
        val_21 = this.<>4__this.RightBoundary;
        label_7:
        if((this.<>4__this.UseTopBoundary) == false)
        {
            goto label_11;
        }
        
        float val_14 = this.<>4__this.NumericBoundaries.TopBoundary;
        val_14 = val_14 - val_18;
        float val_15 = System.Math.Abs(val_14);
        if(((this.<>4__this.NumericBoundaries) > 0) || ((this.<>4__this.NumericBoundaries.UseTopBoundary) == false))
        {
            goto label_28;
        }
        
        label_11:
        if((this.<>4__this.UseBottomBoundary) == false)
        {
            goto label_16;
        }
        
        float val_16 = this.<>4__this.NumericBoundaries.BottomBoundary;
        val_16 = val_16 - val_19;
        float val_17 = System.Math.Abs(val_16);
        if(((this.<>4__this.NumericBoundaries) > 0) || ((this.<>4__this.NumericBoundaries.UseBottomBoundary) == false))
        {
            goto label_28;
        }
        
        label_16:
        if((this.<>4__this.UseLeftBoundary) == false)
        {
            goto label_21;
        }
        
        float val_18 = this.<>4__this.NumericBoundaries.LeftBoundary;
        val_18 = val_18 - val_20;
        float val_19 = System.Math.Abs(val_18);
        if(((this.<>4__this.NumericBoundaries) > 0) || ((this.<>4__this.NumericBoundaries.UseLeftBoundary) == false))
        {
            goto label_28;
        }
        
        label_21:
        val_17 = 0;
        if((this.<>4__this.UseRightBoundary) == false)
        {
                return (bool)val_17;
        }
        
        float val_20 = this.<>4__this.NumericBoundaries.RightBoundary;
        val_20 = val_20 - val_21;
        float val_21 = System.Math.Abs(val_20);
        if((this.<>4__this.NumericBoundaries) <= 0)
        {
                val_22 = this.<>4__this.NumericBoundaries;
            if((this.<>4__this.NumericBoundaries.UseRightBoundary) == true)
        {
                return (bool)val_17;
        }
        
        }
        
        label_28:
        this.<>4__this.GetTargetBoundaries();
        this.<>4__this._boundsAnim.UseTopBoundary = this.<>4__this.UseTopBoundary;
        this.<>4__this._boundsAnim.TopBoundary = this.<>4__this._targetTopBoundary;
        this.<>4__this._boundsAnim.UseBottomBoundary = this.<>4__this.UseBottomBoundary;
        this.<>4__this._boundsAnim.BottomBoundary = this.<>4__this._targetBottomBoundary;
        this.<>4__this._boundsAnim.UseLeftBoundary = this.<>4__this.UseLeftBoundary;
        this.<>4__this._boundsAnim.LeftBoundary = this.<>4__this._targetLeftBoundary;
        this.<>4__this._boundsAnim.UseRightBoundary = this.<>4__this.UseRightBoundary;
        this.<>4__this._boundsAnim.RightBoundary = this.<>4__this._targetRightBoundary;
        this.<>4__this._boundsAnim.TransitionDuration = this.<>4__this.TransitionDuration;
        val_22 = this.<>4__this._boundsAnim;
        this.<>4__this._boundsAnim.TransitionEaseType = this.<>4__this.TransitionEaseType;
        if((this.<>4__this.ChangeZoom) != false)
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.<>4__this.ProCamera2D;
            float val_6 = (this.<>4__this._initialCamSize) / (this.<>4__this.TargetZoom);
            float val_22 = 0.5f;
            val_22 = S4 * val_22;
            if((this.<>4__this) != 0)
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.<>4__this.ProCamera2D;
            val_22 = this.<>4__this.TransitionEaseType;
            float val_8 = (this.<>4__this._initialCamSize) / (this.<>4__this.TargetZoom);
            this.<>4__this.UpdateScreenSize(newSize:  val_8, duration:  val_2.y, easeType:  val_8);
        }
        
        }
        
        if((this.<>4__this._boundsAnim.GetAnimsCount()) < 2)
        {
            goto label_46;
        }
        
        if((this.<>4__this.NumericBoundaries.MoveCameraToTargetRoutine) == 0)
        {
            goto label_48;
        }
        
        if((this.<>4__this.NumericBoundaries) == 0)
        {
            goto label_49;
        }
        
        val_22 = this.<>4__this.NumericBoundaries.MoveCameraToTargetRoutine;
        goto label_50;
        label_4:
        if((this.<>4__this.UseLeftBoundary) == false)
        {
                this.<>4__this.UseLeftBoundary = this.<>4__this.UseRightBoundary;
        }
        
        if((this.<>4__this.UseLeftBoundary) == true)
        {
            goto label_51;
        }
        
        this.<>4__this.NumericBoundaries.UseTopBoundary = false;
        this.<>4__this.NumericBoundaries.UseBottomBoundary = false;
        val_17 = false;
        this.<>4__this.NumericBoundaries.UseLeftBoundary = val_17;
        this.<>4__this.NumericBoundaries.UseRightBoundary = val_17;
        return (bool)val_17;
        label_49:
        val_22 = this.<>4__this.NumericBoundaries.MoveCameraToTargetRoutine;
        label_50:
        this.<>4__this.NumericBoundaries.StopCoroutine(routine:  val_22);
        label_48:
        System.Collections.IEnumerator val_10 = this.<>4__this.MoveCameraToTarget();
        if((this.<>4__this.NumericBoundaries) != 0)
        {
                UnityEngine.Coroutine val_11 = this.<>4__this.NumericBoundaries.StartCoroutine(routine:  this.<>4__this);
            val_23 = this.<>4__this.NumericBoundaries;
        }
        else
        {
                UnityEngine.Coroutine val_12 = this.<>4__this.NumericBoundaries.StartCoroutine(routine:  this.<>4__this);
            val_23 = this.<>4__this.NumericBoundaries;
        }
        
        this.<>4__this.NumericBoundaries.MoveCameraToTargetRoutine = val_23;
        label_46:
        UnityEngine.WaitForEndOfFrame val_13 = 536896839;
        val_13 = new UnityEngine.WaitForEndOfFrame();
        this.<>2__current = val_13;
        val_17 = 1;
        this.<>1__state = val_17;
        return (bool)val_17;
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
