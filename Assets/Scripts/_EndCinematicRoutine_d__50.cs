using UnityEngine;
private sealed class ProCamera2DCinematics.<EndCinematicRoutine>d__50 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCinematics <>4__this;
    private float <initialPosH>5__2;
    private float <initialPosV>5__3;
    private float <currentCameraSize>5__4;
    private float <t>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DCinematics.<EndCinematicRoutine>d__50(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_23;
        float val_24;
        float val_26;
        var val_27;
        float val_29;
        Com.LuisPedroFonseca.ProCamera2D.EaseType val_30;
        float val_31;
        float val_32;
        val_23 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_23;
        }
        
        this.<>1__state = 0;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  this.<>4__this._letterbox, y:  0);
        if((val_1 != false) && (val_1 > false))
        {
                this.<>4__this._letterbox.TweenTo(targetAmount:  this.<>4__this.LetterboxAmount, duration:  null);
        }
        
        val_24 = 4.01997E-38f;
        float val_2 = this.<>4__this._letterbox.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this._newPos, y = this.<>4__this._letterbox, z = R8});
        this.<initialPosH>5__2 = this.<>4__this._letterbox;
        float val_3 = this.<>4__this._letterbox.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this.<>4__this._newPos + (0)], y = mem[this.<>4__this._newPos + (4)], z = mem[this.<>4__this._newPos + (8)]});
        this.<initialPosV>5__3 = this.<>4__this._letterbox;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.<>4__this.ProCamera2D;
        float val_23 = 0.5f;
        val_26 = this;
        this.<t>5__5 = 0f;
        val_23 = (this.<>4__this.LetterboxAmount) * val_23;
        mem[1152921509906898988] = val_23;
        goto label_16;
        label_1:
        val_26 = this.<t>5__5;
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_13;
        }
        
        if((this.<>4__this) <= 0)
        {
            goto label_16;
        }
        
        this.<>4__this._isPlaying = false;
        goto label_15;
        label_13:
        if((this.<>4__this) <= 0)
        {
            goto label_16;
        }
        
        this.<>4__this._isPlaying = false;
        label_15:
        if((this.<>4__this._numericBoundaries) != 0)
        {
                if((this.<>4__this._numericBoundariesPreviousState) == true)
        {
                this.<>4__this._numericBoundariesPreviousState = 1;
        }
        
            this.<>4__this._numericBoundaries.enabled = true;
        }
        
        if((this.<>4__this.OnCinematicFinished) != 0)
        {
                this.<>4__this.OnCinematicFinished.Invoke();
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.<>4__this.ProCamera2D;
        val_23 = 0;
        if((this.<>4__this) != 0)
        {
                return (bool)val_23;
        }
        
        val_23 = 0;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.<>4__this.ProCamera2D;
        this.<>4__this.Reset(centerOnTargets:  true, resetSize:  true, resetExtensions:  true);
        return (bool)val_23;
        label_16:
        if((this.<>4__this._paused) != true)
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = this.<>4__this.ProCamera2D;
            float val_24 = this.<>4__this.EndDuration;
            val_24 = (this.<>4__this._startCinematicRoutine) / val_24;
            val_24 = (this.<t>5__5) + val_24;
            this.<t>5__5 = val_24;
            float val_9 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this.<>4__this._originalPos + (0)], y = mem[this.<>4__this._originalPos + (4)], z = mem[this.<>4__this._originalPos + (8)]});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_11 = this.<>4__this.ProCamera2D;
            val_27 = 22732340;
            if((this.<>4__this) == 0)
        {
                val_27 = 22732340;
        }
        
            if((this.<>4__this) >= 1)
        {
                float val_12 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this._originalPos, y = mem[this.<>4__this._originalPos + (0)], z = mem[this.<>4__this._originalPos + (8)]}), end:  null, value:  this.<>4__this._startCinematicRoutine, type:  this.<initialPosH>5__2);
            val_29 = this.<initialPosH>5__2;
            val_30 = this.<initialPosV>5__3;
        }
        else
        {
                if((this.<>4__this) == 0)
        {
                val_27 = 22732340;
        }
        
            float val_14 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this.<>4__this._startPos + (0)], y = mem[this.<>4__this._startPos + (4)], z = mem[this.<>4__this._startPos + (8)]}), end:  null, value:  this.<>4__this._startCinematicRoutine, type:  this.<initialPosH>5__2);
            if((mem[this.<>4__this._startPos + (0)]) == 0)
        {
                val_31 = this.<t>5__5;
        }
        
            val_29 = this.<initialPosH>5__2;
            val_30 = this.<initialPosV>5__3;
        }
        
            val_32 = val_30;
            if((this.<>4__this._numericBoundariesPreviousState) != false)
        {
                this.<>4__this.LimitToNumericBoundaries(horizontalPos: ref  float val_17 = 0.007085921f, verticalPos: ref  float val_18 = 0.007085919f);
            val_32 = val_32;
            val_29 = this.<initialPosH>5__2;
        }
        
            UnityEngine.Vector3 val_19 = Invoke(arg1:  Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  mem[this.<>4__this._startPos + (0)].Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this._startPos, y = val_31, z = mem[this.<>4__this._startPos + (8)]}), end:  null, value:  this.<>4__this._startCinematicRoutine, type:  val_30), arg2:  null, arg3:  this.<>4__this._startCinematicRoutine);
            float val_20 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_19.x, end:  val_19.y, value:  val_19.z, type:  this.<currentCameraSize>5__4);
            this.<>4__this._newSize = this.<currentCameraSize>5__4;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_21 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_22 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_23 = 1;
        this.<>1__state = val_23;
        return (bool)val_23;
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
