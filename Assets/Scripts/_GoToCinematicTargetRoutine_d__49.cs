using UnityEngine;
private sealed class ProCamera2DCinematics.<GoToCinematicTargetRoutine>d__49 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.CinematicTarget cinematicTarget;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCinematics <>4__this;
    public int targetIndex;
    private float <initialPosH>5__2;
    private float <initialPosV>5__3;
    private float <currentCameraSize>5__4;
    private float <t>5__5;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DCinematics.<GoToCinematicTargetRoutine>d__49(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_6;
        float val_7;
        float val_8;
        int val_57;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCinematics val_58;
        UnityEngine.Transform val_59;
        float val_60;
        float val_61;
        object val_62;
        Com.LuisPedroFonseca.ProCamera2D.CinematicTarget val_63;
        float val_64;
        float val_65;
        float val_66;
        float val_67;
        var val_68;
        Com.LuisPedroFonseca.ProCamera2D.CinematicTarget val_69;
        UnityEngine.Transform val_70;
        Com.LuisPedroFonseca.ProCamera2D.CinematicTarget val_71;
        float val_72;
        Com.LuisPedroFonseca.ProCamera2D.CinematicTarget val_73;
        Com.LuisPedroFonseca.ProCamera2D.CinematicTarget val_74;
        Com.LuisPedroFonseca.ProCamera2D.CinematicTarget val_75;
        val_57 = 0;
        val_58 = this.<>4__this;
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
                return (bool)val_57;
        }
        
        this.<>1__state = 0;
        val_59 = this.cinematicTarget.TargetTransform;
        val_57 = 0;
        if(val_59 == 0)
        {
                return (bool)val_57;
        }
        
        if(val_58 == 0)
        {
            goto label_8;
        }
        
        goto label_9;
        label_2:
        val_61 = this.<t>5__5;
        val_62 = val_58;
        this.<>1__state = 0;
        label_43:
        val_58 = val_62;
        if((this.<>1__state) <= 1)
        {
            goto label_10;
        }
        
        if(val_62 != 0)
        {
            goto label_12;
        }
        
        goto label_12;
        label_1:
        val_61 = this.cinematicTarget;
        this.<>1__state = 0;
        goto label_13;
        label_10:
        if((this.<>4__this._paused) == false)
        {
            goto label_15;
        }
        
        label_96:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = val_58.ProCamera2D;
        UnityEngine.YieldInstruction val_3 = val_58.GetYield();
        this.<>2__current = val_58;
        val_57 = 1;
        this.<>1__state = val_57;
        return (bool)val_57;
        label_15:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = val_58.ProCamera2D;
        val_63 = this.cinematicTarget;
        if(this.cinematicTarget == 0)
        {
                val_63 = this.cinematicTarget;
        }
        
        float val_57 = this.cinematicTarget.EaseInDuration;
        val_57 = (this.<>4__this._startCinematicRoutine) / val_57;
        val_57 = val_61 + val_57;
        this.<t>5__5 = val_57;
        UnityEngine.Vector3 val_5 = position;
        float val_9 = val_62.Invoke(arg:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_10 = val_58.ProCamera2D;
        float val_11 = this.<>4__this + 16.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this + 120, y = this.<>4__this + 124, z = this.<>4__this + 128});
        float val_13 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_62 - (this.<>4__this + 16), end:  val_5.y, value:  val_5.z, type:  this.<initialPosH>5__2);
        UnityEngine.Vector3 val_14 = position;
        float val_15 = this.<>4__this + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
        val_62 = this.<>4__this + 20;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_16 = val_58.ProCamera2D;
        float val_17 = this.<>4__this + 20.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this + 120, y = this.<>4__this + 124, z = this.<>4__this + 128});
        if((this.<>4__this + 72) == 0)
        {
            goto label_32;
        }
        
        val_58.LimitToNumericBoundaries(horizontalPos: ref  float val_20 = 0.006671907f, verticalPos: ref  float val_21 = 0.006671906f);
        val_64 = this.<initialPosV>5__3;
        goto label_33;
        label_8:
        val_60 = 3.673424E-39f;
        label_9:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_22 = val_58.ProCamera2D;
        UnityEngine.Vector3 val_23 = LocalPosition;
        float val_24 = val_60.Invoke(arg:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
        this.<initialPosH>5__2 = val_60;
        if(val_58 != 0)
        {
            
        }
        else
        {
                val_65 = 1.401298E-45f;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_25 = val_58.ProCamera2D;
        UnityEngine.Vector3 val_26 = LocalPosition;
        float val_27 = val_65.Invoke(arg:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
        this.<initialPosV>5__3 = val_65;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_28 = val_58.ProCamera2D;
        float val_58 = 0.5f;
        this.<t>5__5 = 0f;
        val_58 = (this.<>4__this.LetterboxAmount) * val_58;
        mem[1152921509906009908] = val_58;
        if(this.cinematicTarget > 0)
        {
            goto label_43;
        }
        
        UnityEngine.Vector3 val_29 = position;
        float val_30 = 3.673424E-39f.Invoke(arg:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
        if(val_58 != 0)
        {
                val_66 = 3.673424E-39f;
        }
        else
        {
                val_66 = 3.673424E-39f;
        }
        
        val_58 = val_58;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_31 = val_58.ProCamera2D;
        float val_32 = val_66.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this._goToCinematicRoutine, y = this.<>4__this._endCinematicRoutine, z = this.<>4__this._skipTarget});
        UnityEngine.Vector3 val_33 = position;
        float val_34 = 1.401298E-45f.Invoke(arg:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
        if(val_58 != 0)
        {
                val_67 = 1.401298E-45f;
        }
        else
        {
                val_67 = 1.401298E-45f;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_35 = val_58.ProCamera2D;
        val_59 = this.<>4__this._endCinematicRoutine;
        uint val_60 = 1;
        uint val_59 = 2621443;
        val_59 = val_59 - 2621443;
        val_60 = val_60 - 1;
        UnityEngine.Vector3 val_37 = Invoke(arg1:  val_67.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this._goToCinematicRoutine, y = val_59, z = this.<>4__this._skipTarget}), arg2:  val_33.y, arg3:  val_33.z);
        float val_61 = this.cinematicTarget.Zoom;
        val_61 = (this.<>4__this._initialCameraSize) / val_61;
        this.<>4__this._newSize = val_61;
        label_12:
        if((this.<>4__this.OnCinematicTargetReached) != 0)
        {
                this.<>4__this.OnCinematicTargetReached.Invoke(arg0:  this.targetIndex);
        }
        
        val_61 = this;
        val_68 = 0;
        val_62 = 0f;
        if((System.String.IsNullOrEmpty(value:  this.cinematicTarget.SendMessageName)) == true)
        {
            goto label_65;
        }
        
        val_69 = this.cinematicTarget;
        if(val_69 == 0)
        {
            goto label_66;
        }
        
        val_70 = this.cinematicTarget.TargetTransform;
        goto label_67;
        label_66:
        val_70 = this.cinematicTarget.TargetTransform;
        val_71 = this.cinematicTarget;
        if(val_71 == 0)
        {
            goto label_68;
        }
        
        label_67:
        label_97:
        val_59 = this.cinematicTarget.SendMessageParam;
        val_70.SendMessage(methodName:  this.cinematicTarget.SendMessageName, value:  val_59, options:  1);
        label_65:
        this.<t>5__5 = val_62;
        label_13:
        if(this.cinematicTarget >= 0)
        {
                val_57 = 0;
            if(this.cinematicTarget > 0)
        {
                return (bool)val_57;
        }
        
        }
        
        if((this.<>4__this._paused) == false)
        {
            goto label_75;
        }
        
        label_92:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_39 = val_58.ProCamera2D;
        UnityEngine.YieldInstruction val_40 = val_58.GetYield();
        this.<>2__current = val_58;
        val_57 = 1;
        this.<>1__state = 2;
        return (bool)val_57;
        label_75:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_41 = val_58.ProCamera2D;
        UnityEngine.Coroutine val_62 = this.<>4__this._startCinematicRoutine;
        val_62 = (this.<t>5__5) + val_62;
        this.<t>5__5 = val_62;
        UnityEngine.Vector3 val_42 = position;
        float val_43 = val_62.Invoke(arg:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_44 = val_58.ProCamera2D;
        val_62 = mem[this.<>4__this + 120];
        val_62 = this.<>4__this + 120;
        float val_45 = this.<>4__this + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_62, y = this.<>4__this + 124, z = this.<>4__this + 128});
        float val_63 = this.<>4__this + 16;
        val_63 = 0 - val_63;
        UnityEngine.Vector3 val_46 = position;
        float val_47 = this.<>4__this + 20.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_48 = val_58.ProCamera2D;
        val_61 = mem[this.<>4__this + 124];
        val_61 = this.<>4__this + 124;
        float val_49 = this.<>4__this + 20.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this + 120, y = val_61, z = this.<>4__this + 128});
        val_72 = (this.<>4__this + 20) - (this.<>4__this + 20);
        if((this.<>4__this + 72) != 0)
        {
                val_58.LimitToNumericBoundaries(horizontalPos: ref  float val_50 = 0.006671904f, verticalPos: ref  float val_51 = 0.006671902f);
            val_72 = val_72;
        }
        
        val_59 = mem[this.<>4__this + 32];
        val_59 = this.<>4__this + 32;
        val_57 = 0;
        UnityEngine.Vector3 val_52 = Invoke(arg1:  this.<>4__this + 20, arg2:  val_46.y, arg3:  val_46.z);
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCinematics val_53 = val_58 + 132;
        if((this.<>4__this + 128) != 0)
        {
                return (bool)val_57;
        }
        
        goto label_92;
        label_32:
        val_64 = this.<initialPosV>5__3;
        label_33:
        val_59 = mem[this.<>4__this + 32];
        val_59 = this.<>4__this + 32;
        val_57 = 0;
        UnityEngine.Vector3 val_54 = Invoke(arg1:  Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_62 - (this.<>4__this + 20), end:  val_14.y, value:  val_14.z, type:  this.<initialPosV>5__3), arg2:  val_14.y, arg3:  val_14.z);
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCinematics val_55 = val_58 + 132;
        val_74 = this.cinematicTarget;
        val_75 = val_74;
        if(val_74 != 0)
        {
            goto label_94;
        }
        
        val_75 = this.cinematicTarget;
        if(val_75 == 0)
        {
            goto label_95;
        }
        
        label_94:
        float val_64 = this.cinematicTarget.Zoom;
        val_64 = (this.<>4__this + 100) / val_64;
        float val_56 = Com.LuisPedroFonseca.ProCamera2D.Utils.EaseFromTo(start:  val_64, end:  val_54.y, value:  val_54.z, type:  this.<currentCameraSize>5__4);
        mem2[0] = this.<currentCameraSize>5__4;
        if((this.<>4__this + 128) == 0)
        {
            goto label_96;
        }
        
        return (bool)val_57;
        label_68:
        val_73 = this.cinematicTarget;
        if(val_73 != 0)
        {
            goto label_97;
        }
        
        label_95:
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
