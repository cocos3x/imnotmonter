using UnityEngine;
private sealed class HuggyMove.<>c__DisplayClass9_1
{
    // Fields
    public float speed;
    public HuggyMove.<>c__DisplayClass9_0 CS$<>8__locals1;
    
    // Methods
    public HuggyMove.<>c__DisplayClass9_1()
    {
    
    }
    internal void <MovePeople>b__1()
    {
        var val_10;
        var val_11;
        string val_12;
        var val_13;
        this.CS$<>8__locals1.<>4__this.setAnimation.SetPosPlayerSwing(isSwing:  true);
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073701113.Shot(clip:  -1610606251, volume:  null);
        UnityEngine.Transform val_2 = this.CS$<>8__locals1.<>4__this.transform;
        if((this.CS$<>8__locals1.<>4__this) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.CS$<>8__locals1.<>4__this.position = new UnityEngine.Vector3() {x = 3.673424E-39f, y = 1.401298E-45f, z = 0f};
        val_10 = 536887951;
        var val_10 = mem[536888137];
        val_10 = val_10 & 512;
        if((this.CS$<>8__locals1.<>4__this.typeRope) != 0)
        {
                if((val_10 != 0) && (mem[536888067] == 0))
        {
                val_11 = 536887951;
        }
        
            val_12 = mem[536888043] + 16;
        }
        else
        {
                if((val_10 != 0) && (mem[536888067] == 0))
        {
                val_13 = 536887951;
        }
        
            val_12 = mem[536888043] + 4;
        }
        
        this.CS$<>8__locals1.<>4__this.setAnimation.SetAnimation(name:  val_12, loop:  true, _callBack:  0);
        UnityEngine.Transform val_3 = this.CS$<>8__locals1.<>4__this.transform;
        T[] val_4 = this.CS$<>8__locals1.waypoints.ToArray();
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_5 = DG.Tweening.ShortcutExtensions.DOPath(target:  this.CS$<>8__locals1.<>4__this, path:  this.CS$<>8__locals1.waypoints, duration:  null, pathType:  this.speed, pathMode:  0, resolution:  1, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  this.CS$<>8__locals1.<>4__this, ease:  1);
        536895905 = new DG.Tweening.TweenCallback(object:  this.CS$<>8__locals1.<>4__this, method:  new IntPtr(1610680247));
        DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  this.CS$<>8__locals1.<>4__this, action:  536895905);
        DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetSpeedBased<DG.Tweening.Tweener>(t:  this.CS$<>8__locals1.<>4__this);
    }

}
