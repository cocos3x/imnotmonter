using UnityEngine;
private sealed class DOTweenModuleUI.<>c__DisplayClass19_0
{
    // Fields
    public UnityEngine.RectTransform target;
    
    // Methods
    public DOTweenModuleUI.<>c__DisplayClass19_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOAnchorPos3DZ>b__0()
    {
        DOTweenModuleUI.<>c__DisplayClass19_0 val_2;
        UnityEngine.RectTransform val_3;
        UnityEngine.Vector3 val_1 = anchoredPosition3D;
        this.target = val_3;
        this = val_2;
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    internal void <DOAnchorPos3DZ>b__1(UnityEngine.Vector3 x)
    {
        this.target.anchoredPosition3D = new UnityEngine.Vector3() {x = x.x, y = x.y, z = x.z};
    }

}
