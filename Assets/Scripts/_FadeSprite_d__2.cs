using UnityEngine;
private sealed class MMFade.<FadeSprite>d__2 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public UnityEngine.SpriteRenderer target;
    public UnityEngine.Color color;
    public float duration;
    private float <alpha>5__2;
    private float <t>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MMFade.<FadeSprite>d__2(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        int val_14;
        UnityEngine.SpriteRenderer val_15;
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        if((this.<>1__state) != 1)
        {
                val_14 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_14;
        }
        
            this.<>1__state = 0;
            val_15 = this.target;
            val_14 = 0;
            if(val_15 == 0)
        {
                return (bool)val_14;
        }
        
            UnityEngine.Material val_2 = this.target.material;
            UnityEngine.Color val_3 = color;
            this.<alpha>5__2 = val_4;
            this.<t>5__3 = 0f;
        }
        else
        {
                val_17 = 1f;
            this.<>1__state = 0;
            if((this.<>1__state) >= 0)
        {
                val_14 = 0;
            UnityEngine.Color val_6 = new UnityEngine.Color(r:  UnityEngine.Mathf.SmoothStep(from:  this.<t>5__3, to:  null, t:  val_17), g:  null, b:  val_17, a:  null);
            val_15 = this.target;
            if(val_15 == 0)
        {
                return (bool)val_14;
        }
        
            val_14 = 0;
            UnityEngine.Material val_8 = this.target.material;
            val_20 = val_6.r;
            val_18 = val_6.g;
            val_19 = val_6.b;
            val_15 = val_6.a;
            this.target.color = new UnityEngine.Color() {r = val_20, g = val_18, b = val_19, a = val_15};
            return (bool)val_14;
        }
        
        }
        
        val_15 = this.target;
        val_14 = 0;
        if(val_15 == 0)
        {
                return (bool)val_14;
        }
        
        UnityEngine.Color val_11 = new UnityEngine.Color(r:  UnityEngine.Mathf.SmoothStep(from:  val_3.r, to:  val_3.g, t:  val_3.b), g:  val_3.g, b:  val_3.b, a:  val_3.a);
        val_20 = 0;
        UnityEngine.Material val_12 = this.target.material;
        val_18 = val_11.g;
        val_19 = val_11.b;
        this.target.color = new UnityEngine.Color() {r = val_11.r, g = val_18, b = val_19, a = val_11.a};
        float val_13 = UnityEngine.Time.deltaTime;
        val_15 = this;
        uint val_14 = 0;
        this.<>2__current = val_20;
        val_14 = val_14 / this.duration;
        val_14 = (this.<t>5__3) + val_14;
        this.<t>5__3 = val_14;
        val_14 = 1;
        this.<>1__state = val_14;
        return (bool)val_14;
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
