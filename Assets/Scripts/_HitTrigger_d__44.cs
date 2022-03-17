using UnityEngine;
private sealed class SpriteBasedLaser.<HitTrigger>d__44 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TwoDLaserPack.SpriteBasedLaser <>4__this;
    public UnityEngine.RaycastHit2D hit;
    public float triggerInterval;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpriteBasedLaser.<HitTrigger>d__44(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        bool val_2;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        val_2 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_2;
        }
        
        this.<>1__state = 0;
        if((this.<>4__this) == 0)
        {
            goto label_3;
        }
        
        this.<>4__this.waitingForTriggerTime = true;
        goto label_4;
        label_1:
        this.<>1__state = 0;
        val_2 = false;
        this.<>4__this.waitingForTriggerTime = val_2;
        return (bool)val_2;
        label_3:
        mem[132] = 1;
        label_4:
        if((this.<>4__this.OnLaserHitTriggered) != 0)
        {
                this.<>4__this.OnLaserHitTriggered.Invoke(hitInfo:  new UnityEngine.RaycastHit2D() {m_Centroid = new UnityEngine.Vector2() {x = mem[this.hit + (0)], y = mem[this.hit + (4)]}, m_Point = new UnityEngine.Vector2() {x = mem[this.hit + (8)], y = mem[this.hit + (12)]}, m_Normal = new UnityEngine.Vector2(), m_Fraction = ???, m_Collider = ???});
        }
        
        UnityEngine.WaitForSeconds val_1 = 536896849;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_1;
        val_2 = 1;
        this.<>1__state = val_2;
        return (bool)val_2;
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
