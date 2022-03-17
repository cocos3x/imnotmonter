using UnityEngine;
public static class DOTweenModuleUtils.Physics
{
    // Methods
    public static void SetOrientationOnPath(DG.Tweening.Plugins.Options.PathOptions options, DG.Tweening.Tween t, UnityEngine.Quaternion newRot, UnityEngine.Transform trans)
    {
        object val_1;
        if(options.isRigidbody == false)
        {
            goto label_1;
        }
        
        val_1 = t.target;
        if(val_1 == 0)
        {
            goto label_3;
        }
        
        goto label_8;
        label_1:
        val_1 = trans;
        val_1.rotation = new UnityEngine.Quaternion() {x = newRot.x, y = newRot.y, z = newRot.z, w = newRot.w};
        return;
        label_3:
        label_8:
        val_1 = 0;
        val_1.rotation = new UnityEngine.Quaternion() {x = newRot.x, y = newRot.y, z = newRot.z, w = newRot.w};
    }
    public static bool HasRigidbody2D(UnityEngine.Component target)
    {
        UnityEngine.Transform val_1 = target.GetComponent<UnityEngine.Transform>();
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Inequality(x:  target, y:  0);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Inequality(x:  target, y:  0);
        }
        
        return UnityEngine.Object.op_Inequality(x:  target, y:  0);
    }
    public static bool HasRigidbody(UnityEngine.Component target)
    {
        UnityEngine.Transform val_1 = target.GetComponent<UnityEngine.Transform>();
        if((mem[536891408] & true) != 0)
        {
                return UnityEngine.Object.op_Inequality(x:  target, y:  0);
        }
        
        if(mem[536891337] != 0)
        {
                return UnityEngine.Object.op_Inequality(x:  target, y:  0);
        }
        
        return UnityEngine.Object.op_Inequality(x:  target, y:  0);
    }
    public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode)
    {
        if(tweenRigidbody == false)
        {
            goto label_5;
        }
        
        UnityEngine.Transform val_2 = target.GetComponent<UnityEngine.Transform>();
        if(target == 0)
        {
            goto label_5;
        }
        
        if(isLocal == false)
        {
            goto label_6;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_4 = DG.Tweening.DOTweenModulePhysics.DOLocalPath(target:  target, path:  path, duration:  duration, pathMode:  pathMode);
        return;
        label_5:
        UnityEngine.Transform val_5 = target.transform;
        if(isLocal != false)
        {
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_6 = DG.Tweening.ShortcutExtensions.DOLocalPath(target:  target, path:  path, duration:  duration, pathMode:  pathMode);
            return;
        }
        
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_7 = DG.Tweening.ShortcutExtensions.DOPath(target:  target, path:  path, duration:  duration, pathMode:  pathMode);
        return;
        label_6:
        DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_8 = DG.Tweening.DOTweenModulePhysics.DOPath(target:  target, path:  path, duration:  duration, pathMode:  pathMode);
    }

}
