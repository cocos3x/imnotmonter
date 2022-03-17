using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModulePhysics
    {
        // Methods
        public static DG.Tweening.Tweener DOMove(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898427 = new DOTweenModulePhysics.<>c__DisplayClass0_0();
            mem[536898435] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898427, method:  new IntPtr(1610690739));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  mem[536898435], method:  new IntPtr(1610650157));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = endValue.x, y = endValue.y, z = endValue.z}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898435]);
        }
        public static DG.Tweening.Tweener DOMoveX(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping = False)
        {
            536898431 = new DOTweenModulePhysics.<>c__DisplayClass1_0();
            mem[536898439] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898431, method:  new IntPtr(1610690743));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  mem[536898439], method:  new IntPtr(1610650157));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = snapping, y = 0f, z = 0f}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, axisConstraint:  2, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898439]);
        }
        public static DG.Tweening.Tweener DOMoveY(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping = False)
        {
            536898433 = new DOTweenModulePhysics.<>c__DisplayClass2_0();
            mem[536898441] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898433, method:  new IntPtr(1610690747));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  mem[536898441], method:  new IntPtr(1610650157));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = 0f, y = snapping, z = 0f}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, axisConstraint:  4, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898441]);
        }
        public static DG.Tweening.Tweener DOMoveZ(UnityEngine.Rigidbody target, float endValue, float duration, bool snapping = False)
        {
            536898435 = new DOTweenModulePhysics.<>c__DisplayClass3_0();
            mem[536898443] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898435, method:  new IntPtr(1610690751));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  mem[536898443], method:  new IntPtr(1610650157));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = snapping}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, axisConstraint:  8, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898443]);
        }
        public static DG.Tweening.Tweener DORotate(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float duration, DG.Tweening.RotateMode mode = 0)
        {
            var val_4;
            536898437 = new DOTweenModulePhysics.<>c__DisplayClass4_0();
            mem[536898445] = target;
            536873975 = new DG.Tweening.Core.DOGetter<UnityEngine.Quaternion>(object:  536898437, method:  new IntPtr(1610690755));
            536874017 = new DG.Tweening.Core.DOSetter<UnityEngine.Quaternion>(object:  mem[536898445], method:  new IntPtr(1610650159));
            DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873975, setter:  536874017, endValue:  new UnityEngine.Vector3() {x = endValue.x, y = endValue.y, z = endValue.z}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873975, target:  mem[536898445]);
            mem[536874207] = val_4;
        }
        public static DG.Tweening.Tweener DOLookAt(UnityEngine.Rigidbody target, UnityEngine.Vector3 towards, float duration, DG.Tweening.AxisConstraint axisConstraint = 0, System.Nullable<UnityEngine.Vector3> up)
        {
            var val_2;
            536898439 = new DOTweenModulePhysics.<>c__DisplayClass5_0();
            mem[536898447] = target;
            536873975 = new DG.Tweening.Core.DOGetter<UnityEngine.Quaternion>(object:  536898439, method:  new IntPtr(1610690759));
            536874017 = new DG.Tweening.Core.DOSetter<UnityEngine.Quaternion>(object:  mem[536898447], method:  new IntPtr(1610650159));
            DG.Tweening.Core.TweenerCore<UnityEngine.Quaternion, UnityEngine.Vector3, DG.Tweening.Plugins.Options.QuaternionOptions> val_8 = DG.Tweening.DOTween.To(getter:  536873975, setter:  536874017, endValue:  new UnityEngine.Vector3() {x = towards.x, y = towards.y, z = towards.z}, duration:  duration);
            DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873975, target:  mem[536898447]);
            object val_10 = DG.Tweening.Core.Extensions.SetSpecialStartupMode<System.Object>(t:  536873975, mode:  1);
            if(536873975 != 0)
            {
                    mem[536874211] = up.HasValue;
            }
            else
            {
                    mem[236] = up.HasValue;
            }
            
            if(val_2 != 0)
            {
                    UnityEngine.Vector3 val_11 = Value;
            }
            else
            {
                    UnityEngine.Vector3 val_12 = UnityEngine.Vector3.up;
            }
            
            var val_14 = 536873975 + 240;
        }
        public static DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody target, UnityEngine.Vector3 endValue, float jumpPower, int numJumps, float duration, bool snapping = False)
        {
            float val_2;
            bool val_7;
            object val_31;
            DOTweenModulePhysics.<>c__DisplayClass6_0 val_1 = 536898441;
            val_1 = new DOTweenModulePhysics.<>c__DisplayClass6_0();
            if(val_1 != 0)
            {
                    val_31 = val_1;
                mem[536898449] = target;
            }
            else
            {
                    val_31 = 8;
                mem[8] = target;
            }
            
            mem[536898469] = endValue.x;
            if(snapping <= true)
            {
                    snapping = 1;
            }
            
            mem[536898473] = endValue.y;
            mem[536898477] = endValue.z;
            if(val_1 != 0)
            {
                    mem[536898461] = 3212836864;
                mem[536898453] = 0;
            }
            else
            {
                    mem[12] = 0;
                mem[20] = 3212836864;
            }
            
            mem[536898457] = 0;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            mem[536898465] = 0;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898441, method:  new IntPtr(1610690763));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_31, method:  new IntPtr(1610650157));
            float val_32 = 2f;
            val_32 = val_2 / val_32;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = 0f, y = numJumps, z = 0f}, duration:  val_32);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, axisConstraint:  4, snapping:  val_7);
            DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  536873991, ease:  6);
            DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tweener>(t:  536873991);
            DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  536873991, loops:  2, loopType:  1);
            536895905 = new DG.Tweening.TweenCallback(object:  536898441, method:  new IntPtr(1610690765));
            DG.Tweening.Tweener val_13 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  536873991, action:  536895905);
            mem[536898481] = 536873991;
            var val_14 = val_1 + 40;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898441, method:  new IntPtr(1610690767));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  mem[8], method:  new IntPtr(1610650157));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_17 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = mem[536898469], y = 0f, z = 0f}, duration:  val_32);
            DG.Tweening.Tweener val_18 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, axisConstraint:  2, snapping:  val_7);
            DG.Tweening.Tweener val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  536873991, ease:  1);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  536873991);
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898441, method:  new IntPtr(1610690769));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  mem[8], method:  new IntPtr(1610650157));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_23 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = mem[536898477]}, duration:  val_32);
            DG.Tweening.Tweener val_24 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, axisConstraint:  mem[8], snapping:  val_7);
            DG.Tweening.Tweener val_25 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  536873991, ease:  1);
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  536873991);
            DG.Tweening.Sequence val_27 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  536873991);
            DG.Tweening.Tweener val_28 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  0, target:  mem[8]);
            DG.Tweening.Tweener val_29 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  0, ease:  mem[536885657] + 56);
            536895905 = new DG.Tweening.TweenCallback(object:  536898441, method:  new IntPtr(1610690771));
            DG.Tweening.Tweener val_31 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tweener>(t:  536873991, action:  536895905);
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType = 0, DG.Tweening.PathMode pathMode = 1, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor)
        {
            bool val_5;
            536898443 = new DOTweenModulePhysics.<>c__DisplayClass7_0();
            mem[536898451] = target;
            DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_2 = DG.Tweening.Plugins.PathPlugin.Get();
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898443, method:  new IntPtr(1610690775));
            if(gizmoColor.HasValue <= true)
            {
                    gizmoColor.HasValue = 1;
            }
            
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  mem[536898451], method:  new IntPtr(1610650157));
            536891583 = new DG.Tweening.Plugins.Core.PathCore.Path(type:  pathMode, waypoints:  path, subdivisionsXSegment:  1, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_5});
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_11 = DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  0, getter:  536873991, setter:  536874035, endValue:  536891583, duration:  duration);
            DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  0, target:  mem[536898451]);
            object val_13 = DG.Tweening.TweenSettingsExtensions.SetUpdate<System.Object>(t:  0, updateType:  2);
            if(0 != 0)
            {
                    mem[276] = 1;
            }
            else
            {
                    mem[276] = 1;
            }
            
            mem[208] = resolution;
        }
        public static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, UnityEngine.Vector3[] path, float duration, DG.Tweening.PathType pathType = 0, DG.Tweening.PathMode pathMode = 1, int resolution = 10, System.Nullable<UnityEngine.Color> gizmoColor)
        {
            bool val_6;
            536898445 = new DOTweenModulePhysics.<>c__DisplayClass8_0();
            mem[536898457] = target;
            if(gizmoColor.HasValue <= true)
            {
                    gizmoColor.HasValue = 1;
            }
            
            UnityEngine.Transform val_2 = mem[536898457].transform;
            mem[536898453] = mem[536898457];
            DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_3 = DG.Tweening.Plugins.PathPlugin.Get();
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898445, method:  new IntPtr(1610690779));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898445, method:  new IntPtr(1610690781));
            536891583 = new DG.Tweening.Plugins.Core.PathCore.Path(type:  pathMode, waypoints:  path, subdivisionsXSegment:  1, gizmoColor:  new System.Nullable<UnityEngine.Color>() {HasValue = val_6});
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_12 = DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  0, getter:  536873991, setter:  536874035, endValue:  536891583, duration:  duration);
            DG.Tweening.Tweener val_13 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  0, target:  mem[536898457]);
            object val_14 = DG.Tweening.TweenSettingsExtensions.SetUpdate<System.Object>(t:  0, updateType:  2);
            if(0 != 0)
            {
                    mem[208] = resolution;
                mem[276] = 1;
            }
            else
            {
                    mem[276] = 1;
                mem[208] = resolution;
            }
            
            mem[268] = 1;
        }
        internal static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode = 1)
        {
            536898447 = new DOTweenModulePhysics.<>c__DisplayClass9_0();
            mem[536898455] = target;
            DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_2 = DG.Tweening.Plugins.PathPlugin.Get();
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898447, method:  new IntPtr(1610690785));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  mem[536898455], method:  new IntPtr(1610650157));
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_5 = DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  0, getter:  536873991, setter:  536874035, endValue:  path, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  0, target:  mem[536898455]);
            if(0 != 0)
            {
                    mem[276] = 1;
            }
            else
            {
                    mem[276] = 1;
            }
            
            mem[208] = ???;
        }
        internal static DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> DOLocalPath(UnityEngine.Rigidbody target, DG.Tweening.Plugins.Core.PathCore.Path path, float duration, DG.Tweening.PathMode pathMode = 1)
        {
            UnityEngine.Rigidbody val_8;
            DOTweenModulePhysics.<>c__DisplayClass10_0 val_1 = 536898429;
            val_1 = new DOTweenModulePhysics.<>c__DisplayClass10_0();
            if(val_1 != 0)
            {
                    val_8 = val_1;
                mem[536898441] = target;
            }
            else
            {
                    val_8 = 12;
                mem[12] = target;
            }
            
            UnityEngine.Transform val_2 = val_8.transform;
            mem[536898437] = val_8;
            DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions> val_3 = DG.Tweening.Plugins.PathPlugin.Get();
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898429, method:  new IntPtr(1610690789));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898429, method:  new IntPtr(1610690791));
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_6 = DG.Tweening.DOTween.To<UnityEngine.Vector3, DG.Tweening.Plugins.Core.PathCore.Path, DG.Tweening.Plugins.Options.PathOptions>(plugin:  0, getter:  536873991, setter:  536874035, endValue:  path, duration:  duration);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  0, target:  mem[12]);
            if(0 != 0)
            {
                    mem[208] = R3;
                mem[276] = 1;
            }
            else
            {
                    mem[276] = 1;
                mem[208] = R3;
            }
            
            mem[268] = 1;
        }
    
    }

}
