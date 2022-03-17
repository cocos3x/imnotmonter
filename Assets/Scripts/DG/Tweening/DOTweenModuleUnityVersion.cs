using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleUnityVersion
    {
        // Methods
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, float duration)
        {
            var val_11;
            UnityEngine.Gradient val_12;
            var val_14;
            var val_15;
            var val_16;
            UnityEngine.Material val_17;
            float val_18;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            val_11 = 0;
            UnityEngine.GradientColorKey[] val_2 = gradient.colorKeys;
            val_12 = gradient;
            if(gradient < 1)
            {
                    return;
            }
            
            UnityEngine.Gradient val_3 = val_12 + 16;
            val_14 = 0;
            UnityEngine.Gradient val_4 = gradient - 1;
            goto label_6;
            label_16:
            val_14 = 1;
            val_3 = val_3 + 20;
            label_6:
            if((val_14 == 0) && (val_14 <= 0))
            {
                    target.color = new UnityEngine.Color() {r = mem[((gradient + 16) + 20) + (0)], g = mem[((gradient + 16) + 20) + (4)], b = mem[((gradient + 16) + 20) + (8)], a = mem[((gradient + 16) + 20) + (12)]};
            }
            else
            {
                    if(val_4 == val_14)
            {
                    val_16 = val_11;
                float val_5 = DG.Tweening.TweenExtensions.Duration(t:  0, includeLoops:  false);
                val_17 = target;
                val_18 = R2 - 0;
            }
            else
            {
                    if(val_14 != 0)
            {
                    var val_6 = val_14 - 1;
                val_15 = S18 - 1152921504732938240;
            }
            
                val_18 = val_15 * R2;
                val_17 = target;
                val_16 = val_11;
            }
            
                DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOColor(target:  val_17, endValue:  new UnityEngine.Color() {r = mem[((gradient + 16) + 20) + (0)], g = mem[((gradient + 16) + 20) + (4)], b = mem[((gradient + 16) + 20) + (8)], a = mem[((gradient + 16) + 20) + (12)]}, duration:  val_18);
                DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  val_17, ease:  1);
                DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_17);
                val_12 = val_12;
            }
            
            if(val_4 != val_14)
            {
                goto label_16;
            }
        
        }
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, string property, float duration)
        {
            var val_11;
            UnityEngine.Gradient val_12;
            var val_14;
            var val_15;
            float val_16;
            float val_17;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            val_11 = 0;
            UnityEngine.GradientColorKey[] val_2 = gradient.colorKeys;
            val_12 = gradient;
            if(gradient < 1)
            {
                    return;
            }
            
            UnityEngine.Gradient val_3 = val_12 + 16;
            val_14 = 0;
            UnityEngine.Gradient val_4 = gradient - 1;
            goto label_6;
            label_16:
            val_14 = 1;
            val_3 = val_3 + 20;
            label_6:
            if((val_14 == 0) && (val_14 <= 0))
            {
                    target.SetColor(name:  property, value:  new UnityEngine.Color() {r = mem[((gradient + 16) + 20) + (0)], g = mem[((gradient + 16) + 20) + (4)], b = ((gradient + 16) + 20).m_Ptr});
            }
            else
            {
                    if(val_4 == val_14)
            {
                    val_16 = val_11;
                float val_5 = DG.Tweening.TweenExtensions.Duration(t:  0, includeLoops:  false);
                val_17 = R3 - 0;
            }
            else
            {
                    if(val_14 != 0)
            {
                    var val_6 = val_14 - 1;
                val_15 = S18 - 1152921504732938240;
            }
            
                val_17 = val_15 * R3;
                val_16 = val_11;
            }
            
                DG.Tweening.Tweener val_7 = DG.Tweening.ShortcutExtensions.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = mem[((gradient + 16) + 20) + (0)], g = mem[((gradient + 16) + 20) + (4)], b = ((gradient + 16) + 20).m_Ptr, a = ???}, property:  property, duration:  val_17);
                DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  target, ease:  1);
                DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  target);
                val_12 = val_12;
            }
            
            if(val_4 != val_14)
            {
                goto label_16;
            }
        
        }
        public static UnityEngine.CustomYieldInstruction WaitForCompletion(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForCompletion val_1 = 536898397;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForCompletion(tween:  t);
                return;
            }
            
            val_2 = 0;
            if(mem[536885865] < 1)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
        }
        public static UnityEngine.CustomYieldInstruction WaitForRewind(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForRewind val_1 = 536898405;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForRewind(tween:  t);
                return;
            }
            
            val_2 = 0;
            if(mem[536885865] < 1)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
        }
        public static UnityEngine.CustomYieldInstruction WaitForKill(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForKill val_1 = 536898401;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForKill(tween:  t);
                return;
            }
            
            val_2 = 0;
            if(mem[536885865] < 1)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
        }
        public static UnityEngine.CustomYieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForElapsedLoops val_1 = 536898399;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForElapsedLoops(tween:  t, elapsedLoops:  elapsedLoops);
                return;
            }
            
            val_2 = 0;
            if(mem[536885865] < 1)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
        }
        public static UnityEngine.CustomYieldInstruction WaitForPosition(DG.Tweening.Tween t, float position, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForPosition val_1 = 536898403;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForPosition(tween:  t, position:  position);
                return;
            }
            
            val_2 = 0;
            if(mem[536885865] < 1)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
        }
        public static UnityEngine.CustomYieldInstruction WaitForStart(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForStart val_1 = 536898407;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForStart(tween:  t);
                return;
            }
            
            val_2 = 0;
            if(mem[536885865] < 1)
            {
                    return;
            }
            
            DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
        }
        public static DG.Tweening.Tweener DOOffset(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration)
        {
            int val_8;
            object val_9;
            int val_10;
            UnityEngine.Material val_11;
            var val_12;
            val_8 = propertyID;
            DOTweenModuleUnityVersion.<>c__DisplayClass8_0 val_1 = 536898545;
            val_1 = new DOTweenModuleUnityVersion.<>c__DisplayClass8_0();
            if(val_1 != 0)
            {
                    val_9 = val_1;
                mem[536898553] = target;
                val_10 = val_1;
                val_11 = mem[536898553];
                mem[536898557] = val_8;
            }
            else
            {
                    val_9 = 8;
                mem[8] = target;
                val_10 = 12;
                mem[12] = val_8;
                val_11 = mem[8];
                val_8 = mem[12];
            }
            
            val_12 = 0;
            if((val_11.HasProperty(nameID:  val_8)) != false)
            {
                    536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898545, method:  new IntPtr(1610691205));
                536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898545, method:  new IntPtr(1610691207));
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
                DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  val_9);
                val_12 = 536873989;
                return;
            }
            
            if(mem[536885865] < 1)
            {
                    return;
            }
            
            val_12 = 0;
            DG.Tweening.Core.Debugger.LogMissingMaterialProperty(propertyId:  val_10);
        }
        public static DG.Tweening.Tweener DOTiling(UnityEngine.Material target, UnityEngine.Vector2 endValue, int propertyID, float duration)
        {
            int val_8;
            object val_9;
            int val_10;
            UnityEngine.Material val_11;
            var val_12;
            val_8 = propertyID;
            DOTweenModuleUnityVersion.<>c__DisplayClass9_0 val_1 = 536898547;
            val_1 = new DOTweenModuleUnityVersion.<>c__DisplayClass9_0();
            if(val_1 != 0)
            {
                    val_9 = val_1;
                mem[536898555] = target;
                val_10 = val_1;
                val_11 = mem[536898555];
                mem[536898559] = val_8;
            }
            else
            {
                    val_9 = 8;
                mem[8] = target;
                val_10 = 12;
                mem[12] = val_8;
                val_11 = mem[8];
                val_8 = mem[12];
            }
            
            val_12 = 0;
            if((val_11.HasProperty(nameID:  val_8)) != false)
            {
                    536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898547, method:  new IntPtr(1610691211));
                536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898547, method:  new IntPtr(1610691213));
                DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
                DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  val_9);
                val_12 = 536873989;
                return;
            }
            
            if(mem[536885865] < 1)
            {
                    return;
            }
            
            val_12 = 0;
            DG.Tweening.Core.Debugger.LogMissingMaterialProperty(propertyId:  val_10);
        }
    
    }

}
