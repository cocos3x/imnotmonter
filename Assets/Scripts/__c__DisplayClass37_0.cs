using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass37_0
{
    // Fields
    public UnityEngine.Color to;
    public UnityEngine.UI.Graphic target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass37_0()
    {
    
    }
    internal UnityEngine.Color <DOBlendableColor>b__0()
    {
        var val_1 = R1 + 8;
        return new UnityEngine.Color();
    }
    internal void <DOBlendableColor>b__1(UnityEngine.Color x)
    {
        float val_2;
        float val_3;
        float val_4;
        float val_5;
        UnityEngine.Color val_1 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = 3.397251E+12f, g = x.r, b = x.g, a = x.b}, b:  new UnityEngine.Color() {r = x.a, g = this.to});
        this.to = x;
        mem[1152921510315683356] = x.g;
        mem[1152921510315683360] = x.b;
        mem[1152921510315683364] = x.a;
        UnityEngine.Color val_6 = UnityEngine.Color.op_Addition(a:  new UnityEngine.Color() {r = 3.397251E+12f}, b:  new UnityEngine.Color() {r = val_5, g = val_3, b = val_4, a = val_2});
        if(this.target != 0)
        {
                return;
        }
    
    }

}
