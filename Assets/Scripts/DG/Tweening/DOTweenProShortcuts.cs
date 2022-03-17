using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenProShortcuts
    {
        // Methods
        private static DOTweenProShortcuts()
        {
            536894273 = new DG.Tweening.Plugins.SpiralPlugin();
        }
        public static DG.Tweening.Tweener DOSpiral(UnityEngine.Transform target, float duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode = 0, float speed = 1, float frequency = 10, float depth = 0, bool snapping = False)
        {
            float val_1;
            var val_2;
            float val_3;
            float val_7;
            float val_8;
            float val_9;
            float val_17;
            float val_18;
            var val_21;
            var val_22;
            float val_23;
            536898551 = new DOTweenProShortcuts.<>c__DisplayClass1_0();
            mem[536898559] = target;
            val_23 = 0;
            if((UnityEngine.Mathf.Approximately(a:  duration, b:  speed)) == true)
            {
                    val_3 = 1f;
            }
            
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_23 = val_1;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = mode, y = snapping, z = val_23}, rhs:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_7})) == false)
            {
                goto label_3;
            }
            
            label_2:
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.forward;
            System.Nullable<UnityEngine.Vector3> val_12 = new System.Nullable<UnityEngine.Vector3>(value:  new UnityEngine.Vector3());
            label_3:
            DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions> val_13 = DG.Tweening.Plugins.SpiralPlugin.Get();
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898551, method:  new IntPtr(1610691327));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898551, method:  new IntPtr(1610691329));
            UnityEngine.Vector3 val_16 = Value;
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_19 = DG.Tweening.DOTween.To<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>(plugin:  0, getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = R5}, duration:  val_16.x);
            DG.Tweening.Tweener val_20 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  0, target:  mem[536898559]);
            if(0 != 0)
            {
                    mem[244] = val_21;
                mem[232] = val_17;
                mem[236] = val_18;
                mem[240] = val_3;
            }
            else
            {
                    mem[244] = val_21;
                mem[240] = val_3;
                mem[236] = val_18;
                mem[232] = val_17;
            }
            
            mem[248] = val_22;
        }
        public static DG.Tweening.Tweener DOSpiral(UnityEngine.Rigidbody target, float duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode = 0, float speed = 1, float frequency = 10, float depth = 0, bool snapping = False)
        {
            float val_1;
            var val_2;
            float val_3;
            float val_7;
            float val_8;
            float val_9;
            float val_17;
            float val_18;
            var val_21;
            var val_22;
            float val_23;
            536898553 = new DOTweenProShortcuts.<>c__DisplayClass2_0();
            mem[536898561] = target;
            val_23 = 0;
            if((UnityEngine.Mathf.Approximately(a:  duration, b:  speed)) == true)
            {
                    val_3 = 1f;
            }
            
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            val_23 = val_1;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = mode, y = snapping, z = val_23}, rhs:  new UnityEngine.Vector3() {x = val_8, y = val_9, z = val_7})) == false)
            {
                goto label_3;
            }
            
            label_2:
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.forward;
            System.Nullable<UnityEngine.Vector3> val_12 = new System.Nullable<UnityEngine.Vector3>(value:  new UnityEngine.Vector3());
            label_3:
            DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions> val_13 = DG.Tweening.Plugins.SpiralPlugin.Get();
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898553, method:  new IntPtr(1610691333));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  mem[536898561], method:  new IntPtr(1610650157));
            UnityEngine.Vector3 val_16 = Value;
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_19 = DG.Tweening.DOTween.To<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>(plugin:  0, getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = R6}, duration:  val_16.x);
            DG.Tweening.Tweener val_20 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  0, target:  mem[536898561]);
            if(0 != 0)
            {
                    mem[244] = val_21;
                mem[232] = val_17;
                mem[236] = val_18;
                mem[240] = val_3;
            }
            else
            {
                    mem[244] = val_21;
                mem[240] = val_3;
                mem[236] = val_18;
                mem[232] = val_17;
            }
            
            mem[248] = val_22;
        }
    
    }

}
