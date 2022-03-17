using UnityEngine;
private sealed class ProCamera2DRooms.<TransitionRoutine>d__58 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DRooms <>4__this;
    public float transitionDuration;
    public float targetSize;
    public Com.LuisPedroFonseca.ProCamera2D.EaseType transitionEaseType;
    public Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings numericBoundariesSettings;
    private float <initialSize>5__2;
    private float <initialCamPosH>5__3;
    private float <initialCamPosV>5__4;
    private float <t>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DRooms.<TransitionRoutine>d__58(int <>1__state)
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
        int val_28;
        float val_30;
        float val_31;
        float val_32;
        var val_33;
        bool val_34;
        var val_37;
        float val_38;
        var val_39;
        bool val_40;
        float val_41;
        bool val_42;
        var val_43;
        val_28 = 0;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
                return (bool)val_28;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this._transitioning = true;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        if((this.<>1__state) <= 1)
        {
            goto label_5;
        }
        
        if((this.<>4__this) == 0)
        {
            goto label_6;
        }
        
        this.<>4__this._transitioning = false;
        goto label_7;
        label_5:
        val_30 = this.<t>5__5;
        goto label_8;
        label_3:
        mem[136] = 1;
        label_4:
        this.<>4__this._numericBoundaries.UseNumericBoundaries = false;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
        float val_28 = 0.5f;
        val_28 = (this.<>4__this.RestoreDuration) * val_28;
        this.<initialSize>5__2 = val_28;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector3 val_3 = LocalPosition;
        float val_7 = static_value_015EF092.Invoke(arg:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
        this.<initialCamPosH>5__3 = 4.094756E-38f;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector3 val_9 = LocalPosition;
        float val_10 = static_value_015EF092.Invoke(arg:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
        val_30 = this;
        this.<t>5__5 = 0f;
        mem[1152921509935684760] = 4.094756E-38f;
        label_8:
        if((4.094756E-38f) >= 0)
        {
            goto label_15;
        }
        
        val_32 = 1.1f;
        goto label_16;
        label_15:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_11 = this.<>4__this.ProCamera2D;
        val_32 = this.<t>5__5;
        if((this.<>4__this) <= 0)
        {
            goto label_19;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_12 = this.<>4__this.ProCamera2D;
        val_31 = val_9.z / this.transitionDuration;
        val_32 = val_32 + val_31;
        label_16:
        this.<t>5__5 = val_32;
        label_19:
        float val_13 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_31, end:  val_9.y, value:  val_9.z, type:  this.<initialSize>5__2);
        if((this.<>4__this) != 0)
        {
                this.<>4__this._newSize = this.<initialSize>5__2;
        }
        else
        {
                mem[152] = this.<initialSize>5__2;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_14 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector2 val_15 = CameraTargetPositionSmoothed;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_16 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector2 val_17 = CameraTargetPositionSmoothed;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_18 = this.<>4__this.ProCamera2D;
        float val_19 = this.<>4__this.aspect;
        if((this.<>4__this) == 0)
        {
                val_34 = IP;
            val_33 = 4.094756E-38f;
            val_37 = ???;
            val_38 = ???;
        }
        
        float val_20 = this.targetSize * (this.<>4__this);
        this.<>4__this.LimitToNumericBoundaries(horizontalPos: ref  float val_21 = 0.07784495f, verticalPos: ref  float val_22 = 0.07784492f, halfCameraWidth:  val_20, halfCameraHeight:  val_17.y, numericBoundaries:  new Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings() {UseNumericBoundaries = val_20, UseTopBoundary = val_20, TopBoundary = this.targetSize, UseBottomBoundary = this.numericBoundariesSettings, BottomBoundary = 4.094756E-38f, UseLeftBoundary = val_34, LeftBoundary = 4.01997E-38f, UseRightBoundary = val_6, RightBoundary = val_38});
        val_39 = this.<initialCamPosV>5__4;
        UnityEngine.Vector3 val_25 = Invoke(arg1:  Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_20, end:  val_17.y, value:  val_9.z, type:  this.<initialCamPosH>5__3), end:  val_17.y, value:  val_9.z, type:  this.<initialCamPosV>5__4), arg2:  val_17.y, arg3:  val_9.z);
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_26 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_27 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_28 = 1;
        this.<>1__state = val_28;
        return (bool)val_28;
        label_6:
        mem[136] = 0;
        label_7:
        if((this.<>4__this._numericBoundaries) == 0)
        {
                val_43 = 136;
            val_41 = mem[this.numericBoundariesSettings + (4)];
            val_42 = mem[this.numericBoundariesSettings + (8)];
            val_40 = mem[this.numericBoundariesSettings + (0)];
        }
        
        val_28 = 0;
        this.<>4__this._numericBoundaries.Settings = new Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings() {UseNumericBoundaries = val_40, UseTopBoundary = val_40, TopBoundary = val_41, UseBottomBoundary = val_42, BottomBoundary = mem[this.numericBoundariesSettings + (12)], UseLeftBoundary = false, UseRightBoundary = false, RightBoundary = 1.905766E-43f};
        this.<>4__this._transitionRoutine = val_28;
        if((this.<>4__this + 156 + -64) != 0)
        {
                this.<>4__this + 156 + -64.Invoke(arg0:  this.<>4__this._currentRoomIndex, arg1:  this.<>4__this._previousRoomIndex);
        }
        
        this.<>4__this._previousRoomIndex = this.<>4__this._currentRoomIndex;
        return (bool)val_28;
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
