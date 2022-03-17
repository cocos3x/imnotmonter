using UnityEngine;
private sealed class ProCamera2DTriggerInfluence.<InsideTriggerRoutine>d__13 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence <>4__this;
    private float <previousDistancePercentage>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DTriggerInfluence.<InsideTriggerRoutine>d__13(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_30;
        float val_31;
        float val_32;
        int val_90;
        var val_91;
        var val_92;
        ProCamera2DTriggerInfluence.<InsideTriggerRoutine>d__13 val_93;
        UnityEngine.Vector2 val_95;
        var val_96;
        var val_97;
        var val_98;
        val_90 = 0;
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
                return (bool)val_90;
        }
        
        this.<>1__state = 0;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_2 = this.<>4__this.GetYield();
        this.<>2__current = this.<>4__this;
        val_90 = 1;
        this.<>1__state = val_90;
        return (bool)val_90;
        label_1:
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            goto label_8;
        }
        
        goto label_8;
        label_2:
        this.<previousDistancePercentage>5__2 = 1f;
        this.<>1__state = 0;
        if((this.<>4__this) != 0)
        {
            
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.<>4__this.ProCamera2D;
        UnityEngine.Transform val_4 = this.<>4__this.transform;
        UnityEngine.Vector3 val_5 = position;
        float val_6 = 3.673424E-39f.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R7});
        val_91 = 3.673424E-39f;
        if((this.<>4__this) != 0)
        {
            
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.<>4__this.ProCamera2D;
        UnityEngine.Transform val_8 = this.<>4__this.transform;
        UnityEngine.Vector3 val_9 = position;
        UnityEngine.Vector3 val_11 = Invoke(arg1:  1.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R7, z = R8}), arg2:  val_9.y);
        label_8:
        if((this.<>4__this._tempExclusivePoint) == 0)
        {
                return (bool)val_90;
        }
        
        mem2[0] = this.<>4__this.ExclusiveInfluencePercentage;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_12 = this.<>4__this.ProCamera2D;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_87 = this.<>4__this;
        val_87 = val_87 + 92;
        float val_13 = R4.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = mem[(this.<>4__this + 92) + (4)], z = mem[(this.<>4__this + 92) + (8)]});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_14 = this.<>4__this.ProCamera2D;
        float val_15 = mem[(this.<>4__this + 92) + (4)].Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = this.<>4__this.FocusPoint, z = this.<>4__this.InfluenceSmoothness});
        float val_16 = this.<>4__this.GetDistanceToCenterPercentage(point:  new UnityEngine.Vector2() {x = R4, y = mem[(this.<>4__this + 92) + (4)]});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_17 = this.<>4__this.ProCamera2D;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_88 = this.<>4__this;
        val_88 = val_88 + 92;
        float val_18 = this.<>4__this.InfluenceSmoothness.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = mem[(this.<>4__this + 92) + (4)], z = mem[(this.<>4__this + 92) + (8)]});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_19 = this.<>4__this.ProCamera2D;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_89 = this.<>4__this;
        val_89 = val_89 + 92;
        float val_20 = this.<>4__this.InfluenceSmoothness.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = mem[(this.<>4__this + 92) + (4)], z = mem[(this.<>4__this + 92) + (8)]});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_21 = this.<>4__this.ProCamera2D;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_90 = this.<>4__this;
        val_90 = val_90 + 80;
        float val_22 = this.<>4__this.InfluenceSmoothness.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 80) + (0)], y = mem[(this.<>4__this + 80) + (4)], z = mem[(this.<>4__this + 80) + (8)]});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_23 = this.<>4__this.ProCamera2D;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_91 = this.<>4__this;
        val_91 = val_91 + 92;
        float val_24 = this.<>4__this.InfluenceSmoothness.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = mem[(this.<>4__this + 92) + (4)], z = mem[(this.<>4__this + 92) + (8)]});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_25 = this.<>4__this.ProCamera2D;
        float val_26 = this.<>4__this.InfluenceSmoothness.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = this.<>4__this.FocusPoint, z = this.<>4__this.InfluenceSmoothness});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_27 = this.<>4__this.ProCamera2D;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_92 = this.<>4__this;
        val_92 = val_92 + 80;
        float val_28 = this.<>4__this.InfluenceSmoothness.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 80) + (0)], y = mem[(this.<>4__this + 80) + (4)], z = mem[(this.<>4__this + 80) + (8)]});
        float val_94 = this.<>4__this.InfluenceSmoothness;
        float val_93 = this.<>4__this.InfluenceSmoothness;
        UnityEngine.Vector3 val_29 = position;
        val_93 = val_93 + (this.<>4__this.InfluenceSmoothness);
        float val_95 = this.<>4__this.InfluenceSmoothness;
        val_94 = (this.<>4__this.InfluenceSmoothness) + val_94;
        float val_33 = this.<>4__this.InfluenceSmoothness.Invoke(arg:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32});
        val_95 = val_94 - val_95;
        val_93 = val_93 - (this.<>4__this.InfluenceSmoothness);
        UnityEngine.Vector3 val_34 = position;
        float val_35 = this.<>4__this.InfluenceSmoothness.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
        val_95 = val_95 - (this.<>4__this.InfluenceSmoothness);
        val_93 = val_93 - (this.<>4__this.InfluenceSmoothness);
        if((this.<>4__this.InfluenceSmoothness) != 0f)
        {
            goto label_42;
        }
        
        UnityEngine.Vector3 val_36 = position;
        float val_37 = this.<>4__this.InfluenceSmoothness.Invoke(arg:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32});
        val_91 = this.<>4__this.InfluenceSmoothness;
        UnityEngine.Vector3 val_38 = position;
        UnityEngine.Vector3 val_40 = Invoke(arg1:  val_31.Invoke(arg:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32}), arg2:  val_38.y);
        val_92 = 0;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_41 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector3 val_42 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = 0.6375685f, y = mem[this.<>4__this._tempExclusivePoint + (0)], z = mem[this.<>4__this._tempExclusivePoint + (4)]}, target:  new UnityEngine.Vector3() {x = mem[this.<>4__this._tempExclusivePoint + (8)]}, currentVelocity: ref  new UnityEngine.Vector3() {y = this.<>4__this._exclusivePointVelocity, z = this.<>4__this.InfluenceSmoothness}, smoothTime:  this.<>4__this.InfluenceSmoothness);
        System.Nullable<UnityEngine.Vector3> val_43 = new System.Nullable<UnityEngine.Vector3>(value:  new UnityEngine.Vector3());
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_44 = (this.<>4__this) + 168;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_45 = this.<>4__this.ProCamera2D;
        val_93 = this;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_46 = (this.<>4__this) + 168;
        UnityEngine.Vector3 val_47 = Value;
        float val_96 = 1f;
        val_96 = val_96 - (this.<>4__this);
        this.<>4__this._influence = val_47.z;
        mem2[0] = val_96;
        if((this.<>4__this.Mode) == 1)
        {
            goto label_50;
        }
        
        if((this.<>4__this.Mode) != 2)
        {
            goto label_51;
        }
        
        val_96 = this.<>4__this._influence;
        goto label_52;
        label_42:
        if((this.<>4__this.InfluenceSmoothness) == 0f)
        {
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_48 = this.<>4__this.ProCamera2D;
            UnityEngine.Vector2 val_49 = val_43.HasValue.CameraTargetPositionSmoothed;
            bool val_106 = val_43.HasValue;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_50 = this.<>4__this.ProCamera2D;
            UnityEngine.Vector2 val_51 = val_43.HasValue.CameraTargetPositionSmoothed;
            var val_105 = val_31;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_52 = this.<>4__this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_97 = this.<>4__this;
            val_97 = val_97 + 92;
            float val_53 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = mem[(this.<>4__this + 92) + (4)], z = mem[(this.<>4__this + 92) + (8)]});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_54 = this.<>4__this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_98 = this.<>4__this;
            val_98 = val_98 + 92;
            float val_55 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = mem[(this.<>4__this + 92) + (4)], z = mem[(this.<>4__this + 92) + (8)]});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_56 = this.<>4__this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_99 = this.<>4__this;
            val_99 = val_99 + 80;
            float val_57 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 80) + (0)], y = mem[(this.<>4__this + 80) + (4)], z = mem[(this.<>4__this + 80) + (8)]});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_58 = this.<>4__this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_100 = this.<>4__this;
            val_100 = val_100 + 92;
            float val_59 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = mem[(this.<>4__this + 92) + (4)], z = mem[(this.<>4__this + 92) + (8)]});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_60 = this.<>4__this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_101 = this.<>4__this;
            val_101 = val_101 + 92;
            float val_61 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = mem[(this.<>4__this + 92) + (4)], z = mem[(this.<>4__this + 92) + (8)]});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_62 = this.<>4__this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_102 = this.<>4__this;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_103 = this.<>4__this;
            float val_63 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[(this.<>4__this + 92) + (0)], y = 4.01997E-38f, z = this.<>4__this});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_64 = this.<>4__this.ProCamera2D;
            val_102 = (this.<>4__this) + val_102;
            val_103 = val_103 + (this.<>4__this);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_104 = this.<>4__this;
            val_104 = val_103 - val_104;
            val_102 = val_102 - (this.<>4__this);
            float val_65 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this.<>4__this._velocity + (0)], y = mem[this.<>4__this._velocity + (4)], z = mem[this.<>4__this._velocity + (8)]});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_66 = this.<>4__this.ProCamera2D;
            val_105 = val_105 - val_104;
            val_106 = val_106 - val_102;
            float val_67 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this.<>4__this._velocity + (0)], y = mem[this.<>4__this._velocity + (4)], z = mem[this.<>4__this._velocity + (8)]});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence val_107 = this.<>4__this;
            val_95 = val_106 + (this.<>4__this);
            val_107 = val_105 + val_107;
            this.<>4__this._influence = val_95;
            mem2[0] = val_107;
        }
        
        float val_108 = 1f;
        val_97 = (this.<>4__this) + 116;
        val_108 = (val_108 - (this.<>4__this)) * val_95;
        float val_69 = UnityEngine.Time.deltaTime;
        UnityEngine.Vector2 val_72 = UnityEngine.Vector2.SmoothDamp(current:  new UnityEngine.Vector2() {x = 0.6375685f, y = this.<>4__this._influence}, target:  new UnityEngine.Vector2() {x = this.<>4__this + 112 + 4, y = val_108 ^ 2147483648}, currentVelocity: ref  new UnityEngine.Vector2() {x = val_69, y = (this.<>4__this + 112) + 8}, smoothTime:  val_69, maxSpeed:  val_51.y, deltaTime:  val_95);
        mem2[0] = val_43.HasValue;
        mem2[0] = val_31;
        if((this.<>4__this + 112 + -4) == 1)
        {
            goto label_72;
        }
        
        if((this.<>4__this + 112 + -4) != 2)
        {
            goto label_73;
        }
        
        val_97 = this.<>4__this + 112;
        label_72:
        mem2[0] = 0;
        label_73:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_73 = this.<>4__this.ProCamera2D;
        this.<>4__this.ApplyInfluence(influence:  new UnityEngine.Vector2() {x = mem[this.<>4__this + 112 + (0)], y = mem[this.<>4__this + 112 + (4)]});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_74 = this.<>4__this.ProCamera2D;
        float val_75 = this.<>4__this.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this.ExclusiveInfluencePercentage, y = this.<>4__this.Mode, z = this.<>4__this._influence});
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_76 = this.<>4__this.ProCamera2D;
        UnityEngine.Vector3 val_78 = val_43.HasValue.Invoke(arg1:  this.<>4__this.Mode.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this.ExclusiveInfluencePercentage, y = this.<>4__this.Mode, z = this.<>4__this._influence}), arg2:  val_72.y);
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_79 = this.<>4__this.ProCamera2D;
        float val_80 = this.<>4__this._influence.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this._velocity, y = this.<>4__this.Mode, z = this.<>4__this._exclusivePointVelocity});
        val_91 = this.<>4__this._influence;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_81 = this.<>4__this.ProCamera2D;
        val_93 = this;
        val_98 = 1152921509961098980;
        UnityEngine.Vector3 val_83 = val_43.HasValue.Invoke(arg1:  this.<>4__this.Mode.Invoke(arg:  new UnityEngine.Vector3() {x = this.<>4__this._velocity, y = this.<>4__this._exclusivePointVelocity, z = this.<>4__this._exclusivePointVelocity}), arg2:  val_78.y);
        bool val_109 = val_43.HasValue;
        float val_110 = val_31;
        float val_111 = val_32;
        val_109 = val_43.HasValue + val_109;
        val_110 = val_31 + val_110;
        val_111 = val_32 + val_111;
        this.<>4__this._tempExclusivePoint = val_109;
        mem2[0] = val_110;
        mem2[0] = val_111;
        goto label_85;
        label_50:
        val_96 = (this.<>4__this) + 116;
        label_52:
        mem2[0] = 0;
        label_51:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_84 = this.<>4__this.ProCamera2D;
        this.<>4__this.ApplyInfluence(influence:  new UnityEngine.Vector2() {x = mem[this.<>4__this._influence + (0)], y = mem[this.<>4__this._influence + (4)]});
        val_98 = 1152921509961098980;
        label_85:
        mem[1152921509961098980] = this.<>4__this;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_85 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_86 = this.<>4__this.GetYield();
        mem[1152921509961098972] = this.<>4__this;
        val_90 = 1;
        this.<>1__state = 2;
        return (bool)val_90;
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
