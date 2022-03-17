using UnityEngine;
private sealed class EnemySight.<Start>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.EnemySight <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EnemySight.<Start>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_2;
        float val_3;
        float val_4;
        int val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_28;
        val_24 = 0;
        if((this.<>1__state) > 1)
        {
                return (bool)val_24;
        }
        
        this.<>1__state = 0;
        UnityEngine.Vector3 val_1 = position;
        UnityEngine.Transform val_5 = this.<>4__this.transform;
        UnityEngine.Vector3 val_6 = position;
        float val_24 = val_2;
        float val_25 = val_3;
        float val_26 = val_4;
        val_24 = val_2 - val_24;
        val_25 = val_3 - val_25;
        val_26 = val_4 - val_26;
        val_25 = val_25;
        val_26 = val_26;
        UnityEngine.Transform val_7 = this.<>4__this.transform;
        val_27 = this.<>4__this;
        UnityEngine.Vector3 val_8 = forward;
        float val_9 = UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26}, to:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
        val_28 = (this.<>4__this.fieldOfViewAngle) * 0.5f;
        if((this.<>4__this) >= 0)
        {
            goto label_13;
        }
        
        UnityEngine.Transform val_10 = this.<>4__this.transform;
        UnityEngine.Vector3 val_11 = position;
        float val_27 = val_2;
        float val_28 = val_3;
        float val_29 = val_4;
        UnityEngine.Transform val_12 = this.<>4__this.transform;
        UnityEngine.Vector3 val_13 = up;
        UnityEngine.Vector3 val_14 = normalized;
        val_27 = val_27 + val_2;
        val_25 = val_3;
        val_28 = val_28 + val_3;
        val_27 = val_4;
        val_29 = val_29 + val_4;
        val_26 = this.<>4__this._hit;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_29}, direction:  new UnityEngine.Vector3() {x = val_2, y = val_25, z = val_27}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = val_26, y = this.<>4__this.ViewDistance, z = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.<>4__this.LayerMask})}, m_Normal = new UnityEngine.Vector3() {x = 0f}, m_UV = new UnityEngine.Vector2() {x = val_24, y = val_25}, m_Collider = val_26}, maxDistance:  val_14.x, layerMask:  0)) == false)
        {
            goto label_13;
        }
        
        UnityEngine.Collider val_17 = val_26.collider;
        UnityEngine.Transform val_18 = val_26.transform;
        val_25 = this.<>4__this.player;
        if(val_26.GetInstanceID() != val_25.GetInstanceID())
        {
            goto label_13;
        }
        
        if((this.<>4__this.playerInSight) == true)
        {
            goto label_19;
        }
        
        this.<>4__this.playerInSight = true;
        if((this.<>4__this.OnPlayerInSight) == 0)
        {
            goto label_19;
        }
        
        UnityEngine.Collider val_21 = val_26.collider;
        val_27 = val_26;
        UnityEngine.Transform val_22 = val_27.transform;
        this.<>4__this.OnPlayerInSight.Invoke(obj:  val_27);
        goto label_19;
        label_13:
        if((this.<>4__this.playerInSight) != false)
        {
                this.<>4__this.playerInSight = false;
            if((this.<>4__this.OnPlayerOutOfSight) != 0)
        {
                this.<>4__this.OnPlayerOutOfSight.Invoke();
        }
        
        }
        
        label_19:
        UnityEngine.WaitForSeconds val_23 = 536896849;
        val_23 = new UnityEngine.WaitForSeconds(seconds:  val_28);
        this.<>2__current = val_23;
        val_24 = 1;
        this.<>1__state = val_24;
        return (bool)val_24;
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
