using UnityEngine;
private sealed class Spring.<Jump>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Spring <>4__this;
    public UnityEngine.Collider2D other;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Spring.<Jump>d__4(int <>1__state)
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
        float val_15;
        int val_22;
        float val_23;
        float val_24;
        float val_25;
        UnityEngine.Collider2D val_26;
        val_22 = 0;
        if((this.<>1__state) != 1)
        {
                if((this.<>1__state) != 0)
        {
                return (bool)val_22;
        }
        
            this.<>1__state = 0;
            UnityEngine.WaitForSeconds val_1 = 536896849;
            val_1 = new UnityEngine.WaitForSeconds(seconds:  null);
            this.<>2__current = val_1;
            val_22 = 1;
            this.<>1__state = val_22;
            return (bool)val_22;
        }
        
        this.<>1__state = 0;
        if((this.other.CompareTag(tag:  -1610607703)) != false)
        {
                UnityEngine.Transform val_3 = this.other.GetComponent<UnityEngine.Transform>();
            this.other.JumpWithSpring();
            val_23 = 4.026442E-38f;
            UnityEngine.Transform val_4 = this.other.GetComponent<UnityEngine.Transform>();
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            val_24 = val_6;
            val_25 = val_7;
        }
        else
        {
                val_26 = this.other;
            if((this.other.CompareTag(tag:  -1610608497)) != false)
        {
                UnityEngine.Transform val_9 = val_26.GetComponent<UnityEngine.Transform>();
            val_26.JumpWithSpring();
        }
        else
        {
                val_22 = 0;
            if((val_26.CompareTag(tag:  -1610605165)) == false)
        {
                return (bool)val_22;
        }
        
        }
        
            val_23 = 4.026442E-38f;
            UnityEngine.Transform val_11 = this.other.GetComponent<UnityEngine.Transform>();
            UnityEngine.Vector2 val_12 = UnityEngine.Vector2.zero;
            val_24 = val_6;
            val_25 = val_7;
        }
        
        this.other.velocity = new UnityEngine.Vector2() {x = val_24, y = val_25};
        UnityEngine.Transform val_13 = this.other.GetComponent<UnityEngine.Transform>();
        UnityEngine.Vector3 val_14 = position;
        UnityEngine.Transform val_16 = this.<>4__this.transform;
        val_26 = 0;
        UnityEngine.Vector3 val_17 = position;
        float val_22 = val_6;
        float val_23 = val_7;
        float val_24 = val_15;
        val_22 = val_6 - val_22;
        val_23 = val_7 - val_23;
        val_24 = val_15 - val_24;
        UnityEngine.Vector3 val_18 = normalized;
        float val_25 = val_6;
        float val_26 = val_7;
        val_25 = val_25 * (this.<>4__this.jumpPower);
        val_26 = val_26 * (this.<>4__this.jumpPower);
        this.other.AddForce(force:  new UnityEngine.Vector2() {x = val_25, y = val_26}, mode:  1);
        Spine.AnimationState val_19 = this.<>4__this.ske.AnimationState;
        Spine.TrackEntry val_20 = this.<>4__this.ske.SetAnimation(trackIndex:  0, animationName:  -1610606789, loop:  false);
        WorldTimeAPI val_21 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_22 = 0;
        -1073701113.Shot(clip:  -1610604411, volume:  val_25);
        return (bool)val_22;
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
