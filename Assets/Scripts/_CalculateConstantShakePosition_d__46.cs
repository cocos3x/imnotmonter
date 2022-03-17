using UnityEngine;
private sealed class ProCamera2DShake.<CalculateConstantShakePosition>d__46 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float frequencyMin;
    public float frequencyMax;
    public float amplitudeX;
    public float amplitudeY;
    public float amplitudeZ;
    public int index;
    public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ProCamera2DShake.<CalculateConstantShakePosition>d__46(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Vector3 val_3;
        UnityEngine.Vector3 val_4;
        float val_5;
        int val_11;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_12;
        float val_13;
        UnityEngine.Vector3[] val_15;
        val_11 = 0;
        if((this.<>1__state) >= 3)
        {
                return (bool)val_11;
        }
        
        val_12 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>4__this._isConstantShaking) == false)
        {
                return (bool)val_11;
        }
        
        float val_1 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
        val_13 = this.frequencyMin;
        UnityEngine.Vector3 val_2 = UnityEngine.Random.insideUnitSphere;
        val_15 = this.<>4__this._constantShakePositions;
        var val_13 = val_3;
        var val_12 = val_4;
        float val_11 = val_5;
        if(this.index < 1041224188)
        {
                val_11 = val_11 * this.amplitudeZ;
            val_12 = val_12 * this.amplitudeY;
            val_13 = val_13 * this.amplitudeX;
            UnityEngine.Vector3 val_6 = Invoke(arg1:  val_2.x, arg2:  val_2.y, arg3:  val_2.z);
            val_15 = val_3;
            this.<>4__this._constantShakePositions[(this.index + (this.index << 1)) << 2] = val_15;
            this.<>4__this._constantShakePositions[(this.index + (this.index << 1)) << 2] = val_4;
            this.<>4__this._constantShakePositions[(this.index + (this.index << 1)) << 2] = val_5;
            val_13 = val_13;
        }
        
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = val_12.ProCamera2D;
        if(val_12 != 0)
        {
                UnityEngine.WaitForSecondsRealtime val_9 = 536896855;
            val_12 = val_9;
            val_9 = new UnityEngine.WaitForSecondsRealtime(time:  val_6.x);
            this.<>2__current = val_12;
            val_11 = 1;
            this.<>1__state = val_11;
            return (bool)val_11;
        }
        
        UnityEngine.WaitForSeconds val_10 = 536896849;
        val_12 = val_10;
        val_10 = new UnityEngine.WaitForSeconds(seconds:  val_6.x);
        this.<>2__current = val_12;
        val_11 = 1;
        this.<>1__state = 2;
        return (bool)val_11;
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
