using UnityEngine;
private sealed class DOTweenModulePhysics.<>c__DisplayClass6_0
{
    // Fields
    public UnityEngine.Rigidbody target;
    public float startPosY;
    public bool offsetYSet;
    public float offsetY;
    public DG.Tweening.Sequence s;
    public UnityEngine.Vector3 endValue;
    public DG.Tweening.Tween yTween;
    
    // Methods
    public DOTweenModulePhysics.<>c__DisplayClass6_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOJump>b__0()
    {
        DOTweenModulePhysics.<>c__DisplayClass6_0 val_2;
        UnityEngine.Rigidbody val_3;
        UnityEngine.Vector3 val_1 = position;
        this.target = val_3;
        this = val_2;
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    internal void <DOJump>b__1()
    {
        float val_2;
        UnityEngine.Vector3 val_1 = position;
        this.startPosY = val_2;
    }
    internal UnityEngine.Vector3 <DOJump>b__2()
    {
        DOTweenModulePhysics.<>c__DisplayClass6_0 val_2;
        UnityEngine.Rigidbody val_3;
        UnityEngine.Vector3 val_1 = position;
        this.target = val_3;
        this = val_2;
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    internal UnityEngine.Vector3 <DOJump>b__3()
    {
        DOTweenModulePhysics.<>c__DisplayClass6_0 val_2;
        UnityEngine.Rigidbody val_3;
        UnityEngine.Vector3 val_1 = position;
        this.target = val_3;
        this = val_2;
        return new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    internal void <DOJump>b__4()
    {
        float val_2;
        float val_3;
        var val_4;
        if(this.offsetYSet != true)
        {
                this.offsetYSet = true;
            this.offsetY = S0 - this.startPosY;
        }
        
        UnityEngine.Vector3 val_1 = position;
        float val_6 = DG.Tweening.DOVirtual.EasedValue(from:  DG.Tweening.TweenExtensions.ElapsedPercentage(t:  this.yTween, includeLoops:  true), to:  val_1.y, lifetimePercentage:  val_1.z, easeType:  0);
        uint val_7 = 0;
        val_7 = val_4 + val_7;
        this.target.MovePosition(position:  new UnityEngine.Vector3() {x = val_3, z = val_2});
    }

}
