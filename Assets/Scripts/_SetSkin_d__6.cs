using UnityEngine;
private sealed class EffDeath.<SetSkin>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public EffDeath <>4__this;
    public bool botHasSkin;
    public int id;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public EffDeath.<SetSkin>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        var val_6;
        string val_7;
        string val_8;
        Spine.Unity.SkeletonAnimation val_9;
        Spine.Unity.SkeletonAnimation val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        if((this.<>1__state) != 1)
        {
                val_5 = 0;
            if((this.<>1__state) != 0)
        {
                return (bool)val_5;
        }
        
            this.<>1__state = 0;
            536875159 = new System.Func<System.Boolean>(object:  this.<>4__this, method:  new IntPtr(1610679329));
            UnityEngine.WaitUntil val_2 = 536896879;
            val_2 = new UnityEngine.WaitUntil(predicate:  536875159);
            this.<>2__current = val_2;
            val_5 = 1;
            this.<>1__state = val_5;
            return (bool)val_5;
        }
        
        this.<>1__state = 0;
        if(this.botHasSkin != false)
        {
                val_6 = 536884779;
            if(((mem[536884966] & true) == 0) && (mem[536884895] == 0))
        {
                val_6 = 536884779;
        }
        
            val_5 = 0;
            val_7 = mem[mem[536884871] + 20];
            val_7 = mem[536884871] + 20;
            string val_3 = this.id.ToString();
            string val_4 = val_7 + this.id;
            val_8 = val_7;
            val_9 = this.<>4__this.skeleton;
        }
        else
        {
                val_7 = this.id;
            if(val_7 > 6)
        {
                val_10 = this.<>4__this.skeleton;
            val_11 = 536884779;
            if(((mem[536884966] & true) == 0) && (mem[536884895] == 0))
        {
                val_11 = 536884779;
        }
        
            val_8 = mem[mem[536884871] + 16];
            val_8 = mem[536884871] + 16;
        }
        else
        {
                val_10 = this.<>4__this.skeleton;
            val_12 = 536884779;
            var val_5 = mem[536884965];
            val_5 = val_5 & 512;
            if(val_7 == 3)
        {
                if((val_5 != 0) && (mem[536884895] == 0))
        {
                val_13 = 536884779;
        }
        
            val_8 = mem[mem[536884871] + 24];
            val_8 = mem[536884871] + 24;
        }
        else
        {
                if((val_5 != 0) && (mem[536884895] == 0))
        {
                val_14 = 536884779;
        }
        
            val_8 = mem[mem[536884871] + 12];
            val_8 = mem[536884871] + 12;
        }
        
        }
        
            val_5 = 0;
            val_9 = val_10;
        }
        
        MixSkinManager.SetSkinSkeleton(ske:  val_9, nameSkin:  val_8);
        return (bool)val_5;
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
