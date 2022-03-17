using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleUI
    {
        // Methods
        public static DG.Tweening.Tweener DOFade(UnityEngine.CanvasGroup target, float endValue, float duration)
        {
            536898465 = new DOTweenModuleUI.<>c__DisplayClass0_0();
            mem[536898473] = target;
            536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536898465, method:  new IntPtr(1610690943));
            536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536898465, method:  new IntPtr(1610690945));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873981, target:  mem[536898473]);
        }
        public static DG.Tweening.Tweener DOColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration)
        {
            536898487 = new DOTweenModuleUI.<>c__DisplayClass1_0();
            mem[536898495] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898487, method:  new IntPtr(1610690949));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898487, method:  new IntPtr(1610690951));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873965, setter:  536874007, endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898495]);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.UI.Graphic target, float endValue, float duration)
        {
            536898509 = new DOTweenModuleUI.<>c__DisplayClass2_0();
            mem[536898517] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898509, method:  new IntPtr(1610690955));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898509, method:  new IntPtr(1610690957));
            DG.Tweening.Tweener val_4 = DG.Tweening.DOTween.ToAlpha(getter:  536873965, setter:  536874007, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898517]);
        }
        public static DG.Tweening.Tweener DOColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
        {
            536898531 = new DOTweenModuleUI.<>c__DisplayClass3_0();
            mem[536898539] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898531, method:  new IntPtr(1610690961));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898531, method:  new IntPtr(1610690963));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873965, setter:  536874007, endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898539]);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.UI.Image target, float endValue, float duration)
        {
            536898533 = new DOTweenModuleUI.<>c__DisplayClass4_0();
            mem[536898541] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898533, method:  new IntPtr(1610690967));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898533, method:  new IntPtr(1610690969));
            DG.Tweening.Tweener val_4 = DG.Tweening.DOTween.ToAlpha(getter:  536873965, setter:  536874007, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898541]);
        }
        public static DG.Tweening.Tweener DOFillAmount(UnityEngine.UI.Image target, float endValue, float duration)
        {
            float val_5;
            DOTweenModuleUI.<>c__DisplayClass5_0 val_1 = 536898535;
            val_1 = new DOTweenModuleUI.<>c__DisplayClass5_0();
            mem[536898543] = target;
            val_5 = 1f;
            if(val_1 <= 0)
            {
                    if(val_1 < 0)
            {
                    val_5 = 0f;
            }
            
            }
            
            536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536898535, method:  new IntPtr(1610690973));
            536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536898535, method:  new IntPtr(1610690975));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873981, target:  mem[536898543]);
        }
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.UI.Image target, UnityEngine.Gradient gradient, float duration)
        {
            UnityEngine.Gradient val_8;
            var val_9;
            UnityEngine.Gradient val_10;
            var val_11;
            float val_12;
            var val_13;
            var val_14;
            float val_15;
            val_8 = gradient;
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            UnityEngine.GradientColorKey[] val_2 = val_8.colorKeys;
            UnityEngine.Gradient val_9 = val_8;
            if(val_8 < 1)
            {
                    return;
            }
            
            val_10 = val_9;
            val_11 = 0;
            UnityEngine.Gradient val_3 = val_8 - 1;
            val_9 = val_10 + 16;
            goto label_6;
            label_16:
            val_10 = val_9;
            val_11 = 1;
            val_9 = val_9 + 20;
            val_9 = mem[gradient + 12];
            val_9 = gradient + 12;
            label_6:
            val_12 = mem[((gradient + 16) + 20) + 8];
            val_12 = ((gradient + 16) + 20) + 8;
            val_13 = mem[((gradient + 16) + 20) + 16];
            val_13 = ((gradient + 16) + 20) + 16;
            if((val_11 != 0) || (val_11 > 0))
            {
                goto label_9;
            }
            
            if(target != 0)
            {
                goto label_11;
            }
            
            goto label_11;
            label_9:
            if(val_3 == val_11)
            {
                    val_14 = 0;
                float val_4 = DG.Tweening.TweenExtensions.Duration(t:  0, includeLoops:  false);
                val_12 = val_12;
                val_15 = R2 - 0;
            }
            else
            {
                    if(val_11 != 0)
            {
                    if((gradient + 12) <= (val_11 - 1))
            {
                    val_12 = val_12;
            }
            
                val_13 = val_13 - (((gradient + 16) + 20) + -4);
            }
            
                val_15 = val_13 * R2;
                val_14 = 0;
            }
            
            DG.Tweening.Tweener val_6 = DG.Tweening.DOTweenModuleUI.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = mem[((gradient + 16) + 20) + (0)], g = mem[((gradient + 16) + 20) + (4)], b = val_12, a = ((gradient + 16) + 20) + 12}, duration:  val_15);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  target, ease:  1);
            DG.Tweening.Sequence val_8 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  target);
            label_11:
            if(val_3 != val_11)
            {
                goto label_16;
            }
        
        }
        public static DG.Tweening.Tweener DOFlexibleSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898537 = new DOTweenModuleUI.<>c__DisplayClass7_0();
            mem[536898545] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898537, method:  new IntPtr(1610690979));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898537, method:  new IntPtr(1610690981));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898545]);
        }
        public static DG.Tweening.Tweener DOMinSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898539 = new DOTweenModuleUI.<>c__DisplayClass8_0();
            mem[536898547] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898539, method:  new IntPtr(1610690985));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898539, method:  new IntPtr(1610690987));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898547]);
        }
        public static DG.Tweening.Tweener DOPreferredSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898541 = new DOTweenModuleUI.<>c__DisplayClass9_0();
            mem[536898549] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898541, method:  new IntPtr(1610690991));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898541, method:  new IntPtr(1610690993));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898549]);
        }
        public static DG.Tweening.Tweener DOColor(UnityEngine.UI.Outline target, UnityEngine.Color endValue, float duration)
        {
            536898467 = new DOTweenModuleUI.<>c__DisplayClass10_0();
            mem[536898475] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898467, method:  new IntPtr(1610690997));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898467, method:  new IntPtr(1610690999));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873965, setter:  536874007, endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898475]);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.UI.Outline target, float endValue, float duration)
        {
            536898469 = new DOTweenModuleUI.<>c__DisplayClass11_0();
            mem[536898477] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898469, method:  new IntPtr(1610691003));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898469, method:  new IntPtr(1610691005));
            DG.Tweening.Tweener val_4 = DG.Tweening.DOTween.ToAlpha(getter:  536873965, setter:  536874007, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898477]);
        }
        public static DG.Tweening.Tweener DOScale(UnityEngine.UI.Outline target, UnityEngine.Vector2 endValue, float duration)
        {
            536898471 = new DOTweenModuleUI.<>c__DisplayClass12_0();
            mem[536898479] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898471, method:  new IntPtr(1610691009));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898471, method:  new IntPtr(1610691011));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898479]);
        }
        public static DG.Tweening.Tweener DOAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898473 = new DOTweenModuleUI.<>c__DisplayClass13_0();
            mem[536898481] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898473, method:  new IntPtr(1610691015));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898473, method:  new IntPtr(1610691017));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898481]);
        }
        public static DG.Tweening.Tweener DOAnchorPosX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            536898475 = new DOTweenModuleUI.<>c__DisplayClass14_0();
            mem[536898483] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898475, method:  new IntPtr(1610691021));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898475, method:  new IntPtr(1610691023));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = snapping, y = 0f}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  2, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898483]);
        }
        public static DG.Tweening.Tweener DOAnchorPosY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            536898477 = new DOTweenModuleUI.<>c__DisplayClass15_0();
            mem[536898485] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898477, method:  new IntPtr(1610691027));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898477, method:  new IntPtr(1610691029));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = 0f, y = snapping}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  4, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898485]);
        }
        public static DG.Tweening.Tweener DOAnchorPos3D(UnityEngine.RectTransform target, UnityEngine.Vector3 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898479 = new DOTweenModuleUI.<>c__DisplayClass16_0();
            mem[536898487] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898479, method:  new IntPtr(1610691033));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898479, method:  new IntPtr(1610691035));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = endValue.x, y = endValue.y, z = endValue.z}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898487]);
        }
        public static DG.Tweening.Tweener DOAnchorPos3DX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            536898481 = new DOTweenModuleUI.<>c__DisplayClass17_0();
            mem[536898489] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898481, method:  new IntPtr(1610691039));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898481, method:  new IntPtr(1610691041));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = snapping, y = 0f, z = 0f}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, axisConstraint:  2, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898489]);
        }
        public static DG.Tweening.Tweener DOAnchorPos3DY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            536898483 = new DOTweenModuleUI.<>c__DisplayClass18_0();
            mem[536898491] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898483, method:  new IntPtr(1610691045));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898483, method:  new IntPtr(1610691047));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = 0f, y = snapping, z = 0f}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, axisConstraint:  4, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898491]);
        }
        public static DG.Tweening.Tweener DOAnchorPos3DZ(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            536898485 = new DOTweenModuleUI.<>c__DisplayClass19_0();
            mem[536898493] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898485, method:  new IntPtr(1610691051));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898485, method:  new IntPtr(1610691053));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873991, setter:  536874035, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = snapping}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, axisConstraint:  8, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898493]);
        }
        public static DG.Tweening.Tweener DOAnchorMax(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898489 = new DOTweenModuleUI.<>c__DisplayClass20_0();
            mem[536898497] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898489, method:  new IntPtr(1610691057));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898489, method:  new IntPtr(1610691059));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898497]);
        }
        public static DG.Tweening.Tweener DOAnchorMin(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898491 = new DOTweenModuleUI.<>c__DisplayClass21_0();
            mem[536898499] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898491, method:  new IntPtr(1610691063));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898491, method:  new IntPtr(1610691065));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898499]);
        }
        public static DG.Tweening.Tweener DOPivot(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration)
        {
            536898493 = new DOTweenModuleUI.<>c__DisplayClass22_0();
            mem[536898501] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898493, method:  new IntPtr(1610691069));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898493, method:  new IntPtr(1610691071));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898501]);
        }
        public static DG.Tweening.Tweener DOPivotX(UnityEngine.RectTransform target, float endValue, float duration)
        {
            536898495 = new DOTweenModuleUI.<>c__DisplayClass23_0();
            mem[536898503] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898495, method:  new IntPtr(1610691075));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898495, method:  new IntPtr(1610691077));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = R1, y = 0f}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  2, snapping:  false);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898503]);
        }
        public static DG.Tweening.Tweener DOPivotY(UnityEngine.RectTransform target, float endValue, float duration)
        {
            536898497 = new DOTweenModuleUI.<>c__DisplayClass24_0();
            mem[536898505] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898497, method:  new IntPtr(1610691081));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898497, method:  new IntPtr(1610691083));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = 0f, y = R1}, duration:  endValue);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  4, snapping:  false);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898505]);
        }
        public static DG.Tweening.Tweener DOSizeDelta(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898499 = new DOTweenModuleUI.<>c__DisplayClass25_0();
            mem[536898507] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898499, method:  new IntPtr(1610691087));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898499, method:  new IntPtr(1610691089));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898507]);
        }
        public static DG.Tweening.Tweener DOPunchAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 punch, float duration, int vibrato = 10, float elasticity = 1, bool snapping = False)
        {
            bool val_1;
            536898501 = new DOTweenModuleUI.<>c__DisplayClass26_0();
            mem[536898509] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898501, method:  new IntPtr(1610691093));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898501, method:  new IntPtr(1610691095));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> val_6 = DG.Tweening.DOTween.Punch(getter:  536873991, setter:  536874035, direction:  new UnityEngine.Vector3() {x = punch.x, y = punch.y, z = 0f}, duration:  duration, vibrato:  vibrato, elasticity:  elasticity);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898509]);
            return DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, snapping:  val_1);
        }
        public static DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, float strength = 100, int vibrato = 10, float randomness = 90, bool snapping = False, bool fadeOut = True)
        {
            bool val_1;
            536898503 = new DOTweenModuleUI.<>c__DisplayClass27_0();
            mem[536898511] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898503, method:  new IntPtr(1610691099));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898503, method:  new IntPtr(1610691101));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> val_7 = DG.Tweening.DOTween.Shake(getter:  536873991, setter:  536874035, duration:  duration, strength:  strength, vibrato:  vibrato, randomness:  randomness, ignoreZAxis:  snapping, fadeOut:  fadeOut);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898511]);
            object val_9 = DG.Tweening.Core.Extensions.SetSpecialStartupMode<System.Object>(t:  536873991, mode:  2);
            return DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, snapping:  val_1);
        }
        public static DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, UnityEngine.Vector2 strength, int vibrato = 10, float randomness = 90, bool snapping = False, bool fadeOut = True)
        {
            bool val_1;
            536898505 = new DOTweenModuleUI.<>c__DisplayClass28_0();
            mem[536898513] = target;
            536873991 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  536898505, method:  new IntPtr(1610691105));
            536874035 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  536898505, method:  new IntPtr(1610691107));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions> val_6 = DG.Tweening.DOTween.Shake(getter:  536873991, setter:  536874035, duration:  duration, strength:  new UnityEngine.Vector3() {x = strength.x, y = strength.y, z = vibrato}, vibrato:  0, randomness:  randomness, fadeOut:  snapping);
            DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873991, target:  mem[536898513]);
            object val_8 = DG.Tweening.Core.Extensions.SetSpecialStartupMode<System.Object>(t:  536873991, mode:  2);
            return DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873991, snapping:  val_1);
        }
        public static DG.Tweening.Sequence DOJumpAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = False)
        {
            float val_2;
            bool val_7;
            object val_25;
            DOTweenModuleUI.<>c__DisplayClass29_0 val_1 = 536898507;
            val_1 = new DOTweenModuleUI.<>c__DisplayClass29_0();
            if(val_1 != 0)
            {
                    val_25 = val_1;
                mem[536898515] = target;
            }
            else
            {
                    val_25 = 8;
                mem[8] = target;
            }
            
            mem[536898535] = endValue.x;
            if(snapping <= true)
            {
                    snapping = 1;
            }
            
            mem[536898539] = endValue.y;
            if(val_1 != 0)
            {
                    mem[536898527] = 3212836864;
                mem[536898519] = 0;
            }
            else
            {
                    mem[12] = 0;
                mem[20] = 3212836864;
            }
            
            mem[536898523] = 0;
            DG.Tweening.Sequence val_3 = DG.Tweening.DOTween.Sequence();
            mem[536898531] = 0;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898507, method:  new IntPtr(1610691111));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898507, method:  new IntPtr(1610691113));
            float val_25 = 2f;
            val_25 = val_2 / val_25;
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_6 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = 0f, y = numJumps}, duration:  val_25);
            DG.Tweening.Tweener val_8 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  4, snapping:  val_7);
            DG.Tweening.Tweener val_9 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  536873989, ease:  6);
            DG.Tweening.Tweener val_10 = DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tweener>(t:  536873989);
            DG.Tweening.Tweener val_11 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  536873989, loops:  2, loopType:  1);
            536895905 = new DG.Tweening.TweenCallback(object:  536898507, method:  new IntPtr(1610691115));
            DG.Tweening.Tweener val_13 = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  536873989, action:  536895905);
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898507, method:  new IntPtr(1610691117));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898507, method:  new IntPtr(1610691119));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_16 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = mem[536898535], y = 0f}, duration:  val_25);
            DG.Tweening.Tweener val_17 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, axisConstraint:  2, snapping:  val_7);
            DG.Tweening.Tweener val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  536873989, ease:  1);
            DG.Tweening.Sequence val_19 = DG.Tweening.TweenSettingsExtensions.Append(s:  0, t:  536873989);
            DG.Tweening.Sequence val_20 = DG.Tweening.TweenSettingsExtensions.Join(s:  0, t:  536873989);
            DG.Tweening.Tweener val_21 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  0, target:  val_25);
            DG.Tweening.Tweener val_22 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  0, ease:  mem[536885657] + 56);
            536895905 = new DG.Tweening.TweenCallback(object:  536898507, method:  new IntPtr(1610691121));
            DG.Tweening.Tweener val_24 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tweener>(t:  0, action:  536895905);
        }
        public static DG.Tweening.Tweener DONormalizedPos(UnityEngine.UI.ScrollRect target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            bool val_1;
            536898511 = new DOTweenModuleUI.<>c__DisplayClass30_0();
            mem[536898519] = target;
            536873989 = new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  536898511, method:  new IntPtr(1610691125));
            536874033 = new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  536898511, method:  new IntPtr(1610691127));
            DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873989, setter:  536874033, endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873989, snapping:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873989, target:  mem[536898519]);
        }
        public static DG.Tweening.Tweener DOHorizontalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping = False)
        {
            536898513 = new DOTweenModuleUI.<>c__DisplayClass31_0();
            mem[536898521] = target;
            536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536898513, method:  new IntPtr(1610691131));
            536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536898513, method:  new IntPtr(1610691133));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  endValue, duration:  duration);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873981, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873981, target:  mem[536898521]);
        }
        public static DG.Tweening.Tweener DOVerticalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping = False)
        {
            536898515 = new DOTweenModuleUI.<>c__DisplayClass32_0();
            mem[536898523] = target;
            536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536898515, method:  new IntPtr(1610691137));
            536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536898515, method:  new IntPtr(1610691139));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  endValue, duration:  duration);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873981, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873981, target:  mem[536898523]);
        }
        public static DG.Tweening.Tweener DOValue(UnityEngine.UI.Slider target, float endValue, float duration, bool snapping = False)
        {
            536898517 = new DOTweenModuleUI.<>c__DisplayClass33_0();
            mem[536898525] = target;
            536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536898517, method:  new IntPtr(1610691143));
            536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536898517, method:  new IntPtr(1610691145));
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_4 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  endValue, duration:  duration);
            DG.Tweening.Tweener val_5 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873981, snapping:  R3);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873981, target:  mem[536898525]);
        }
        public static DG.Tweening.Tweener DOColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration)
        {
            536898519 = new DOTweenModuleUI.<>c__DisplayClass34_0();
            mem[536898527] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898519, method:  new IntPtr(1610691149));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898519, method:  new IntPtr(1610691151));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873965, setter:  536874007, endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898527]);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.UI.Text target, float endValue, float duration)
        {
            536898521 = new DOTweenModuleUI.<>c__DisplayClass35_0();
            mem[536898529] = target;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898521, method:  new IntPtr(1610691155));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898521, method:  new IntPtr(1610691157));
            DG.Tweening.Tweener val_4 = DG.Tweening.DOTween.ToAlpha(getter:  536873965, setter:  536874007, endValue:  endValue, duration:  duration);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[536898529]);
        }
        public static DG.Tweening.Tweener DOText(UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled = True, DG.Tweening.ScrambleMode scrambleMode = 0, string scrambleChars)
        {
            string val_1;
            536898523 = new DOTweenModuleUI.<>c__DisplayClass36_0();
            mem[536898531] = target;
            536873983 = new DG.Tweening.Core.DOGetter<System.String>(object:  536898523, method:  new IntPtr(1610691161));
            536874027 = new DG.Tweening.Core.DOSetter<System.String>(object:  536898523, method:  new IntPtr(1610691163));
            DG.Tweening.Core.TweenerCore<System.String, System.String, DG.Tweening.Plugins.Options.StringOptions> val_5 = DG.Tweening.DOTween.To(getter:  536873983, setter:  536874027, endValue:  endValue, duration:  duration);
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetOptions(t:  536873983, richTextEnabled:  scrambleMode, scrambleMode:  scrambleChars, scrambleChars:  val_1);
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873983, target:  mem[536898531]);
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            var val_14;
            DOTweenModuleUI.<>c__DisplayClass37_0 val_1 = 536898525;
            val_1 = new DOTweenModuleUI.<>c__DisplayClass37_0();
            if(val_1 != 0)
            {
                    val_14 = val_1;
                mem[536898549] = target;
            }
            else
            {
                    val_14 = 24;
                mem[24] = target;
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = 5.169123E+12f, g = endValue.r, b = endValue.g, a = endValue.b}, b:  new UnityEngine.Color() {r = endValue.a});
            UnityEngine.Color val_7 = new UnityEngine.Color(r:  val_2.r, g:  val_2.g, b:  val_2.b, a:  val_2.a);
            var val_8 = val_1 + 8;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898525, method:  new IntPtr(1610691167));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898525, method:  new IntPtr(1610691169));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_12 = DG.Tweening.DOTween.To(getter:  536873965, setter:  536874007, endValue:  new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_6}, duration:  val_2.r);
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_13 = DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  536873965);
            DG.Tweening.Tweener val_14 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[24]);
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            var val_14;
            DOTweenModuleUI.<>c__DisplayClass38_0 val_1 = 536898527;
            val_1 = new DOTweenModuleUI.<>c__DisplayClass38_0();
            if(val_1 != 0)
            {
                    val_14 = val_1;
                mem[536898551] = target;
            }
            else
            {
                    val_14 = 24;
                mem[24] = target;
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = 5.232138E+12f, g = endValue.r, b = endValue.g, a = endValue.b}, b:  new UnityEngine.Color() {r = endValue.a});
            UnityEngine.Color val_7 = new UnityEngine.Color(r:  val_2.r, g:  val_2.g, b:  val_2.b, a:  val_2.a);
            var val_8 = val_1 + 8;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898527, method:  new IntPtr(1610691173));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898527, method:  new IntPtr(1610691175));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_12 = DG.Tweening.DOTween.To(getter:  536873965, setter:  536874007, endValue:  new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_6}, duration:  val_2.r);
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_13 = DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  536873965);
            DG.Tweening.Tweener val_14 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[24]);
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            var val_14;
            DOTweenModuleUI.<>c__DisplayClass39_0 val_1 = 536898529;
            val_1 = new DOTweenModuleUI.<>c__DisplayClass39_0();
            if(val_1 != 0)
            {
                    val_14 = val_1;
                mem[536898553] = target;
            }
            else
            {
                    val_14 = 24;
                mem[24] = target;
            }
            
            UnityEngine.Color val_2 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = 5.295154E+12f, g = endValue.r, b = endValue.g, a = endValue.b}, b:  new UnityEngine.Color() {r = endValue.a});
            UnityEngine.Color val_7 = new UnityEngine.Color(r:  val_2.r, g:  val_2.g, b:  val_2.b, a:  val_2.a);
            var val_8 = val_1 + 8;
            536873965 = new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  536898529, method:  new IntPtr(1610691179));
            536874007 = new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  536898529, method:  new IntPtr(1610691181));
            DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions> val_12 = DG.Tweening.DOTween.To(getter:  536873965, setter:  536874007, endValue:  new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = val_6}, duration:  val_2.r);
            DG.Tweening.Core.TweenerCore<T1, T2, TPlugOptions> val_13 = DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  536873965);
            DG.Tweening.Tweener val_14 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  536873965, target:  mem[24]);
        }
    
    }

}
