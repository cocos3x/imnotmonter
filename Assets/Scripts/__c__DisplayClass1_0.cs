using UnityEngine;
private sealed class DOTweenProShortcuts.<>c__DisplayClass1_0
{
    // Fields
    public UnityEngine.Transform target;
    
    // Methods
    public DOTweenProShortcuts.<>c__DisplayClass1_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOSpiral>b__0()
    {
        DOTweenProShortcuts.<>c__DisplayClass1_0 val_2;
        UnityEngine.Transform val_3;
        UnityEngine.Vector3 val_1 = localPosition;
        this.target = val_3;
        this = val_2;
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    internal void <DOSpiral>b__1(UnityEngine.Vector3 x)
    {
        this.target.localPosition = new UnityEngine.Vector3() {x = x.x, y = x.y, z = x.z};
    }

}
