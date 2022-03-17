using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModulePhysics2D
    {
        // Methods
        public static DG.Tweening.Tweener DOMove(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898449 = new DOTweenModulePhysics2D.<>c__DisplayClass0_0();
            mem[536898457] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898449, method:  new IntPtr(1610690805));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  mem[536898457], method:  new IntPtr(1610647477));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898457]);
        }
        public static DG.Tweening.Tweener DOMoveX(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping = False)
        {
            536898451 = new DOTweenModulePhysics2D.<>c__DisplayClass1_0();
            mem[536898459] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898451, method:  new IntPtr(1610690809));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  mem[536898459], method:  new IntPtr(1610647477));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = snapping, y = 0f}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  2, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898459]);
        }
        public static DG.Tweening.Tweener DOMoveY(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping = False)
        {
            536898453 = new DOTweenModulePhysics2D.<>c__DisplayClass2_0();
            mem[536898461] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898453, method:  new IntPtr(1610690813));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  mem[536898461], method:  new IntPtr(1610647477));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = 0f, y = snapping}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  4, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898461]);
        }
        public static DG.Tweening.Tweener DORotate(UnityEngine.Rigidbody2D target, float endValue, float duration)
        {
            536898455 = new DOTweenModulePhysics2D.<>c__DisplayClass3_0();
            mem[536898463] = target;
            536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536898455, method:  new IntPtr(1610690817));
            536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  mem[536898463], method:  new IntPtr(1610647479));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873981, target:  mem[536898463]);
        }
        public static DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = False)
        {
            float val_2;
            bool val_7;
            object val_25;
            DOTweenModulePhysics2D.<>c__DisplayClass4_0 val_1 = 536898457;
            val_1 = new DOTweenModulePhysics2D.<>c__DisplayClass4_0();
            if(val_1 != 0)
            {
                    val_25 = val_1;
                mem[536898465] = target;
            }
            else
            {
                    val_25 = 8;
                mem[8] = target;
            }
            
            mem[536898485] = endValue.x;
            if(snapping <= true)
            {
                    snapping = 1;
            }
            
            mem[536898489] = endValue.y;
            if(val_1 != 0)
            {
                    mem[536898477] = 3212836864;
                mem[536898469] = 0;
            }
            else
            {
                    mem[12] = 0;
                mem[20] = 3212836864;
            }
            
            mem[536898473] = 0;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            mem[536898481] = 0;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898457, method:  new IntPtr(1610690821));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898457, method:  new IntPtr(1610690823));
            float val_26 = 2f;
            val_26 = val_2 / val_26;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = 0f, y = numJumps}, duration:  val_26);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  4, snapping:  val_7);
            DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  536873989, ease:  6);
            DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tweener>(t:  536873989);
            DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  536873989, loops:  2, loopType:  1);
            536895905 = new DG.Tweening.TweenCallback(object:  536898457, method:  new IntPtr(1610690825));
            DG.Tweening.Tweener val_13 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  536873989, action:  536895905);
            mem[536898493] = 536873989;
            var val_14 = val_1 + 36;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898457, method:  new IntPtr(1610690827));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898457, method:  new IntPtr(1610690829));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_17 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = mem[536898485], y = 0f}, duration:  val_26);
            DG.Tweening.Tweener val_18 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  2, snapping:  val_7);
            DG.Tweening.Tweener val_19 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  536873989, ease:  1);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  536873989);
            DG.Tweening.Sequence val_21 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  536873989);
            DG.Tweening.Tweener val_22 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  0, target:  val_25);
            DG.Tweening.Tweener val_23 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  0, ease:  mem[536885657] + 56);
            536895905 = new DG.Tweening.TweenCallback(object:  536898457, method:  new IntPtr(1610690831));
            DG.Tweening.Tweener val_25 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tweener>(t:  536873989, action:  536895905);
        }
    
    }

}
