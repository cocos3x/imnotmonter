using UnityEngine;
private sealed class ProCamera2DTriggerBoundaries.<MoveCameraToTarget>d__43 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerBoundaries <>4__this;
    private float <initialCamPosH>5__2;
    private float <initialCamPosV>5__3;
    private float <t>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DTriggerBoundaries.<MoveCameraToTarget>d__43(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_3;
        float val_4;
        float val_5;
        UnityEngine.Coroutine val_26;
        var val_27;
        float val_28;
        float val_29;
        float val_30;
        var val_31;
        float val_32;
        val_26 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_26;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>1__state) > 1)
        {
                val_26 = 0;
            this.<>4__this.NumericBoundaries.MoveCameraToTargetRoutine = val_26;
            this.<>4__this._transitioning = val_26;
            return (bool)val_26;
        }
        
        val_29 = this.<t>5__4;
        val_30 = 0;
        if((this.<>4__this) != 0)
        {
            goto label_10;
        }
        
        val_30 = 1;
        goto label_10;
        label_3:
        val_27 = 2621443;
        label_4:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector3 val_2 = LocalPosition;
        float val_6 = val_27.Invoke(arg:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
        this.<initialCamPosH>5__2 = 3.673424E-39f;
        if((this.<>4__this) != 0)
        {
            
        }
        else
        {
                val_31 = 1;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector3 val_8 = LocalPosition;
        this.<initialCamPosV>5__3 = 1.401298E-45f;
        if((this.<>4__this) != 0)
        {
                val_32 = 1;
        }
        else
        {
                val_32 = this.<initialCamPosV>5__3;
        }
        
        val_30 = 0f;
        UnityEngine.Vector3 val_10 = Invoke(arg1:  val_31.Invoke(arg:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5}), arg2:  val_8.y, arg3:  val_8.z);
        val_29 = this;
        val_28 = 0f;
        this.<>4__this._transitioning = true;
        this.<t>5__4 = val_30;
        label_10:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_11 = this.<>4__this.ProCamera2D;
        float val_26 = this.<>4__this.TransitionDuration;
        val_26 = (this.<>4__this.UseLeftBoundary) / val_26;
        val_26 = val_28 + val_26;
        this.<t>5__4 = val_26;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_12 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector2 val_13 = CameraTargetPositionSmoothed;
        float val_14 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_13.x, end:  val_13.y, value:  val_10.z, type:  this.<initialCamPosH>5__2);
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_15 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector2 val_16 = CameraTargetPositionSmoothed;
        if(val_30 != 0)
        {
                float val_17 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_16.x, end:  val_16.y, value:  val_10.z, type:  this.<initialCamPosV>5__3);
            0.LimitToNumericBoundaries(horizontalPos: ref  float val_18 = 0.4674836f, verticalPos: ref  float val_19 = 0.4674835f);
        }
        else
        {
                this.<>4__this.LimitToNumericBoundaries(horizontalPos: ref  float val_21 = 0.4674836f, verticalPos: ref  float val_22 = 0.4674835f);
        }
        
        UnityEngine.Vector3 val_23 = Invoke(arg1:  Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_16.x, end:  val_16.y, value:  val_10.z, type:  this.<initialCamPosV>5__3), arg2:  val_16.y, arg3:  val_10.z);
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_24 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_25 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_26 = 1;
        this.<>1__state = val_26;
        return (bool)val_26;
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
