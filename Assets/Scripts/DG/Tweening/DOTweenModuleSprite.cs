using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleSprite
    {
        // Methods
        public static DG.Tweening.Tweener DOColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration)
        {
            536898459 = new DOTweenModuleSprite.<>c__DisplayClass0_0();
            mem[536898467] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898459, method:  new IntPtr(1610690843));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898459, method:  new IntPtr(1610690845));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873965, setter:  536874007, endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898467]);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.SpriteRenderer target, float endValue, float duration)
        {
            536898461 = new DOTweenModuleSprite.<>c__DisplayClass1_0();
            mem[536898469] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898461, method:  new IntPtr(1610690849));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898461, method:  new IntPtr(1610690851));
            DG.Tweening.Tweener val_4 = DG.Tweening.DOTween.ToAlpha(getter:  536873965, setter:  536874007, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898469]);
        }
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.SpriteRenderer target, UnityEngine.Gradient gradient, float duration)
        {
            var val_11;
            UnityEngine.Gradient val_12;
            var val_14;
            var val_15;
            var val_16;
            UnityEngine.SpriteRenderer val_17;
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
            
                DG.Tweening.Tweener val_7 = DG.Tweening.DOTweenModuleSprite.DOColor(target:  val_17, endValue:  new UnityEngine.Color() {r = mem[((gradient + 16) + 20) + (0)], g = mem[((gradient + 16) + 20) + (4)], b = mem[((gradient + 16) + 20) + (8)], a = mem[((gradient + 16) + 20) + (12)]}, duration:  val_18);
                DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  val_17, ease:  1);
                DG.Tweening.Sequence val_9 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  val_17);
                val_12 = val_12;
            }
            
            if(val_4 != val_14)
            {
                goto label_16;
            }
        
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration)
        {
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            var val_15;
            DOTweenModuleSprite.<>c__DisplayClass3_0 val_1 = 536898463;
            val_1 = new DOTweenModuleSprite.<>c__DisplayClass3_0();
            if(val_1 != 0)
            {
                    val_15 = val_1;
                mem[536898487] = target;
            }
            else
            {
                    val_15 = 24;
                mem[24] = target;
            }
            
            UnityEngine.Color val_2 = color;
            UnityEngine.Color val_3 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = 1.067316E+12f, g = endValue.r, b = endValue.g, a = endValue.b}, b:  new UnityEngine.Color() {r = endValue.a});
            UnityEngine.Color val_8 = new UnityEngine.Color(r:  val_3.r, g:  val_3.g, b:  val_3.b, a:  val_3.a);
            var val_9 = val_1 + 8;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898463, method:  new IntPtr(1610690855));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898463, method:  new IntPtr(1610690857));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_13 = DG.Tweening.DOTween.To(getter:  536873965, setter:  536874007, endValue:  new UnityEngine.Color() {r = val_4, g = val_5, b = val_6, a = val_7}, duration:  val_3.r);
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_14 = DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  536873965);
            DG.Tweening.Tweener val_15 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[24]);
        }
    
    }

}
