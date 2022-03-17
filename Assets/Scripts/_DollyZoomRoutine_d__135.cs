using UnityEngine;
private sealed class ProCamera2D.<DollyZoomRoutine>d__135 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2D <>4__this;
    public float duration;
    public float finalFOV;
    public Com.LuisPedroFonseca.ProCamera2D.EaseType easeType;
    private float <startFOV>5__2;
    private float <newFOV>5__3;
    private float <t>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2D.<DollyZoomRoutine>d__135(int <>1__state)
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
        int val_14;
        float val_15;
        float val_16;
        float val_17;
        val_14 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_14;
        }
        
        this.<>1__state = 0;
        val_15 = 0f;
        float val_1 = this.<>4__this.GameCamera.fieldOfView;
        this.<startFOV>5__2 = this.<>4__this.GameCamera;
        this.<newFOV>5__3 = this.<>4__this.GameCamera;
        val_16 = 0f;
        this.<t>5__4 = val_15;
        goto label_9;
        label_1:
        this.<>1__state = 0;
        if((this.<>1__state) <= 1)
        {
            goto label_6;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_7;
        }
        
        this.<>4__this._dollyZoomRoutine = 0;
        goto label_8;
        label_6:
        val_15 = 0;
        if((this.<>4__this) == 0)
        {
                val_15 = 1;
        }
        
        label_9:
        float val_14 = this.duration;
        val_14 = (this.<>4__this.<DeltaTime>k__BackingField) / val_14;
        val_14 = (this.<t>5__4) + val_14;
        this.<t>5__4 = val_14;
        this.<newFOV>5__3 = this.<startFOV>5__2;
        if(val_15 != 0)
        {
                val_17 = this.<newFOV>5__3;
        }
        else
        {
                val_17 = this.<startFOV>5__2;
        }
        
        this.<>4__this.GameCamera.fieldOfView = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_14, end:  null, value:  this.<>4__this.<DeltaTime>k__BackingField, type:  this.<startFOV>5__2);
        UnityEngine.Vector3 val_3 = localPosition;
        float val_7 = this.<>4__this.Vector3H.Invoke(arg:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
        UnityEngine.Vector3 val_8 = localPosition;
        float val_10 = this.<>4__this.GetCameraDistanceForFOV(fov:  this.<>4__this.Vector3V.Invoke(arg:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6}), cameraHeight:  val_8.y);
        UnityEngine.Vector3 val_12 = Invoke(arg1:  (this.<>4__this) * (this.<>4__this._originalCameraDepthSign), arg2:  val_8.y, arg3:  val_8.z);
        this.<>4__this._transform.localPosition = new UnityEngine.Vector3() {x = R5, y = R6, z = R7};
        UnityEngine.YieldInstruction val_13 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_14 = 1;
        this.<>1__state = val_14;
        return (bool)val_14;
        label_7:
        mem[220] = 0;
        label_8:
        if((this.<>4__this.OnDollyZoomFinished) != 0)
        {
                this.<>4__this.OnDollyZoomFinished.Invoke(obj:  1f);
        }
        
        if((this.<>4__this.OnUpdateScreenSizeFinished) == 0)
        {
                return (bool)val_14;
        }
        
        float val_15 = 0.5f;
        val_15 = S2 * val_15;
        this.<>4__this.OnUpdateScreenSizeFinished.Invoke(obj:  val_15);
        return (bool)val_14;
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
