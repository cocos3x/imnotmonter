using UnityEngine;
private sealed class BuyIAP.<LoadPriceRoutine>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public BuyIAP <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BuyIAP.<LoadPriceRoutine>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_13;
        BuyIAP val_14;
        object val_15;
        UnityEngine.UI.Text val_16;
        var val_17;
        val_13 = 0;
        if((this.<>1__state) >= 2)
        {
                return (bool)val_13;
        }
        
        val_14 = this.<>4__this;
        this.<>1__state = 0;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_15 = 0;
        if((-1073701017.IsInitialized()) == false)
        {
            goto label_3;
        }
        
        if((this.<>4__this.itemType) == 2)
        {
            goto label_5;
        }
        
        if((this.<>4__this.itemType) == 1)
        {
            goto label_6;
        }
        
        val_13 = 0;
        if((this.<>4__this.itemType) != 0)
        {
                return (bool)val_13;
        }
        
        val_13 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this.priceText)) == false)
        {
                return (bool)val_13;
        }
        
        val_16 = this.<>4__this.priceText;
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_17 = -1073701017;
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_15 = mem[3221266291];
        goto label_18;
        label_3:
        this.<>2__current = val_15;
        val_13 = 1;
        this.<>1__state = val_13;
        return (bool)val_13;
        label_5:
        val_13 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this.priceText)) == false)
        {
                return (bool)val_13;
        }
        
        val_16 = this.<>4__this.priceText;
        WorldTimeAPI val_7 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_17 = -1073701017;
        WorldTimeAPI val_8 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_15 = mem[3221266299];
        goto label_18;
        label_6:
        val_13 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.<>4__this.priceText)) == false)
        {
                return (bool)val_13;
        }
        
        val_16 = this.<>4__this.priceText;
        WorldTimeAPI val_10 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_17 = -1073701017;
        WorldTimeAPI val_11 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_15 = mem[3221266295];
        label_18:
        val_13 = 0;
        string val_12 = val_17.GetProducePriceFromStore(id:  val_15);
        val_14 = val_17;
        return (bool)val_13;
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
