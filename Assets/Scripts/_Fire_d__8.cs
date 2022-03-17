using UnityEngine;
private sealed class PlayerFire.<Fire>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.PlayerFire <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PlayerFire.<Fire>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_8;
        var val_11;
        var val_14;
        int val_17;
        Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.PlayerFire val_18;
        val_17 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_17;
        }
        
        val_18 = this.<>4__this;
        this.<>1__state = 0;
        val_17 = 0;
        if((UnityEngine.Input.GetKey(key:  32)) != true)
        {
                if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
                return (bool)val_17;
        }
        
        }
        
        UnityEngine.GameObject val_3 = this.<>4__this.BulletPool.nextThing;
        UnityEngine.Transform val_4 = this.<>4__this.BulletPool.transform;
        UnityEngine.Vector3 val_5 = position;
        this.<>4__this.BulletPool.position = new UnityEngine.Vector3() {x = R4, y = R5, z = SL};
        UnityEngine.Transform val_6 = this.<>4__this.BulletPool.transform;
        UnityEngine.Quaternion val_7 = rotation;
        this.<>4__this.BulletPool.rotation = new UnityEngine.Quaternion() {x = val_8, y = R4, z = R6, w = ???};
        val_18 = val_18;
        UnityEngine.Quaternion val_9 = rotation;
        UnityEngine.Vector3 val_10 = eulerAngles;
        float val_17 = -90f;
        val_17 = val_11 + val_17;
        val_17 = val_17 * 0.01745329f;
        float val_19 = this.<>4__this.FireShakeForce;
        float val_18 = val_17;
        Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_12 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake.Instance;
        val_18 = val_18 * val_19;
        val_19 = val_17 * val_19;
        mem[536882601] = val_19;
        mem[536882605] = val_18;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
        mem[536882613] = val_8;
        mem[536882617] = val_11;
        mem[536882621] = val_14;
        mem[536882373] = this.<>4__this.FireShakeDuration;
        UnityEngine.Coroutine val_15 = 0.ApplyShakesTimed(shakes:  536882585, rotations:  536882597, durations:  536882357, smoothness:  val_13.x, ignoreTimeScale:  true);
        UnityEngine.WaitForSeconds val_16 = 536896849;
        val_16 = new UnityEngine.WaitForSeconds(seconds:  val_13.x);
        mem[1152921509996523836] = val_16;
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
