using UnityEngine;
private sealed class ProCamera2DShake.<ShakeRoutine>d__41 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake <>4__this;
    public bool ignoreTimeScale;
    public float smoothness;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DShake.<ShakeRoutine>d__41(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_9;
        float val_10;
        float val_11;
        float val_26;
        ProCamera2DShake.<ShakeRoutine>d__41 val_32;
        float val_33;
        float val_34;
        UnityEngine.Quaternion val_35;
        float val_37;
        UnityEngine.Transform val_38;
        float val_39;
        float val_40;
        float val_41;
        float val_43;
        val_32 = this;
        val_33 = 0f;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_33;
        }
        
        this.<>1__state = 0;
        if(0 >= 1)
        {
            goto label_9;
        }
        
        val_34 = 0f;
        UnityEngine.Vector3 val_1 = localPosition;
        float val_2 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3(), b:  new UnityEngine.Vector3() {x = this.<>4__this._influencesSum, y = ???, z = val_33});
        if((this.<>4__this._shakeParent) > 0)
        {
            goto label_9;
        }
        
        val_33 = 0;
        UnityEngine.Quaternion val_3 = localRotation;
        val_35 = this.<>4__this._originalRotation;
        float val_4 = UnityEngine.Quaternion.Dot(a:  new UnityEngine.Quaternion(), b:  new UnityEngine.Quaternion() {x = val_35, y = val_34, z = this.<>4__this._shakeParent, w = ???});
        bool val_5 = UnityEngine.Quaternion.IsEqualUsingDot(dot:  val_4);
        if(val_5 == true)
        {
            goto label_8;
        }
        
        float val_7 = UnityEngine.Mathf.Min(a:  val_4, b:  val_3.y);
        var val_30 = R0 & (~2147483648);
        val_30 = val_30 + val_30;
        val_30 = val_30 * 57.29578f;
        if(val_5 > false)
        {
            goto label_9;
        }
        
        label_8:
        this.<>4__this.ShakeCompleted();
        return (bool)val_33;
        label_9:
        UnityEngine.Vector3 val_8 = Com.LuisPedroFonseca.ProCamera2D.Utils.GetVectorsSum(input:  1038147064);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
        float val_13 = val_11 + S26;
        val_37 = val_10 + S24;
        UnityEngine.Vector3 val_14 = val_9 + (this.<>4__this._influencesSum);
        if(this.ignoreTimeScale == false)
        {
            goto label_11;
        }
        
        val_38 = this.<>4__this;
        UnityEngine.Vector3 val_15 = localPosition;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = 0.1097984f, y = R4, z = R5}, target:  new UnityEngine.Vector3() {x = R6, y = val_14, z = val_37}, currentVelocity: ref  new UnityEngine.Vector3() {x = val_13, y = this.<>4__this._shakeVelocity, z = this.smoothness}, smoothTime:  UnityEngine.Time.unscaledDeltaTime, maxSpeed:  val_15.y, deltaTime:  val_15.z);
        goto label_13;
        label_11:
        val_39 = val_9;
        val_40 = val_10;
        val_41 = val_11;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_18 = this.<>4__this.ProCamera2D;
        val_38 = this.<>4__this._shakeParent;
        if((this.<>4__this) <= 0)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_19 = localPosition;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.SmoothDamp(current:  new UnityEngine.Vector3() {x = 0.1097984f}, target:  new UnityEngine.Vector3() {y = val_14, z = val_37}, currentVelocity: ref  new UnityEngine.Vector3() {x = val_13, y = this.<>4__this._shakeVelocity, z = this.smoothness}, smoothTime:  this.smoothness);
        label_13:
        val_39 = val_9;
        val_40 = val_10;
        val_41 = val_11;
        label_15:
        mem[this.<>4__this._shakeParent].localPosition = new UnityEngine.Vector3() {x = val_39, y = val_40, z = val_41};
        this.<>4__this._shakePositions.Clear();
        if(this.ignoreTimeScale == false)
        {
            goto label_19;
        }
        
        float val_21 = UnityEngine.Time.unscaledDeltaTime;
        val_43 = this.<>4__this._rotationTime;
        goto label_20;
        label_19:
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_22 = this.<>4__this.ProCamera2D;
        if((this.<>4__this) <= 0)
        {
            goto label_22;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_23 = this.<>4__this.ProCamera2D;
        val_43 = this.<>4__this._rotationTime;
        label_20:
        float val_24 = UnityEngine.Mathf.SmoothDamp(current:  val_20.x, target:  val_20.y, currentVelocity: ref  val_43, smoothTime:  val_20.z, maxSpeed:  null, deltaTime:  val_14);
        this.<>4__this._rotationTime = val_43;
        label_22:
        UnityEngine.Quaternion val_25 = localRotation;
        UnityEngine.Quaternion val_27 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = 0.1097984f}, b:  new UnityEngine.Quaternion() {x = val_26, y = this.<>4__this._rotationTarget, z = this.<>4__this + 96 + 4, w = this.<>4__this + 96 + 8}, t:  this.<>4__this + 96 + 32);
        val_35 = val_10;
        val_32 = val_26;
        this.<>4__this + 96 + -60.localRotation = new UnityEngine.Quaternion() {x = val_9, y = val_35, z = val_11, w = val_32};
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_28 = this.<>4__this.ProCamera2D;
        UnityEngine.YieldInstruction val_29 = this.<>4__this.GetYield();
        mem[1152921509939973404] = this.<>4__this;
        val_33 = 1;
        this.<>1__state = val_33;
        return (bool)val_33;
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
