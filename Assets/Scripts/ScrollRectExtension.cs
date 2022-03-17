using UnityEngine;
public static class ScrollRectExtension
{
    // Methods
    private static float CalculateHorizontalNormalizedPos(UnityEngine.UI.ScrollRect scrollRect, UnityEngine.RectTransform target)
    {
        var val_8;
        if(target != 0)
        {
                UnityEngine.Transform val_2 = scrollRect.GetComponent<UnityEngine.Transform>();
            UnityEngine.Rect val_3 = rect;
            float val_4 = width;
            float val_10 = 0.5f;
            uint val_12 = 578826240;
            val_10 = val_12 * val_10;
            UnityEngine.Rect val_5 = rect;
            float val_6 = width;
            uint val_11 = 578826240;
            val_11 = val_11 - val_10;
            val_12 = val_11 - val_10;
            UnityEngine.Vector2 val_7 = anchoredPosition;
            var val_13 = val_8;
            val_13 = val_13 - val_10;
            val_13 = val_13 / val_12;
            return (float)val_13;
        }
        
        22710780 = new System.Exception(message:  22794244);
    }
    public static DG.Tweening.Tweener ScrollHorizontalTo(UnityEngine.UI.ScrollRect scrollRect, UnityEngine.RectTransform target, float duration, bool scrollOutRange = False)
    {
        UnityEngine.UI.ScrollRect val_7;
        var val_9;
        ScrollRectExtension.<>c__DisplayClass1_0 val_1 = 536900943;
        val_1 = new ScrollRectExtension.<>c__DisplayClass1_0();
        if(val_1 != 0)
        {
                val_7 = val_1;
            mem[536900951] = scrollRect;
        }
        else
        {
                val_7 = 8;
            mem[8] = scrollRect;
        }
        
        val_9 = val_7;
        if(R3 == 0)
        {
                val_9 = val_9;
        }
        
        536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536900943, method:  new IntPtr(1610678007));
        536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536900943, method:  new IntPtr(1610678009));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_6 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  UnityEngine.Mathf.Clamp(value:  ScrollRectExtension.CalculateHorizontalNormalizedPos(scrollRect:  val_7, target:  target), min:  null, max:  null), duration:  null);
    }
    private static float CalculateVerticalNormalizedPos(UnityEngine.UI.ScrollRect scrollRect, UnityEngine.RectTransform target)
    {
        var val_8;
        if(target != 0)
        {
                UnityEngine.Transform val_2 = scrollRect.GetComponent<UnityEngine.Transform>();
            UnityEngine.Rect val_3 = rect;
            float val_4 = height;
            float val_10 = 0.5f;
            uint val_12 = 579091200;
            val_10 = val_12 * val_10;
            UnityEngine.Rect val_5 = rect;
            float val_6 = height;
            uint val_11 = 579091200;
            val_11 = val_11 - val_10;
            val_12 = val_10 - val_11;
            UnityEngine.Vector2 val_7 = anchoredPosition;
            var val_13 = val_8;
            val_13 = val_10 + val_13;
            val_13 = val_13 / val_12;
            val_13 = 1f - val_13;
            return (float)val_13;
        }
        
        22710780 = new System.Exception(message:  22794244);
    }
    public static DG.Tweening.Tweener ScrollVerticalTo(UnityEngine.UI.ScrollRect scrollRect, UnityEngine.RectTransform target, float duration, bool scrollOutRange = False)
    {
        UnityEngine.UI.ScrollRect val_7;
        var val_9;
        ScrollRectExtension.<>c__DisplayClass3_0 val_1 = 536900945;
        val_1 = new ScrollRectExtension.<>c__DisplayClass3_0();
        if(val_1 != 0)
        {
                val_7 = val_1;
            mem[536900953] = scrollRect;
        }
        else
        {
                val_7 = 8;
            mem[8] = scrollRect;
        }
        
        val_9 = val_7;
        if(R3 == 0)
        {
                val_9 = val_9;
        }
        
        536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536900945, method:  new IntPtr(1610678013));
        536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536900945, method:  new IntPtr(1610678015));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_6 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  UnityEngine.Mathf.Clamp(value:  ScrollRectExtension.CalculateVerticalNormalizedPos(scrollRect:  val_7, target:  target), min:  null, max:  null), duration:  null);
    }
    private static float CalculateVerticalNormalizedPos(UnityEngine.UI.ScrollRect scrollRect, float anchedPositionY)
    {
        UnityEngine.Transform val_1 = scrollRect.GetComponent<UnityEngine.Transform>();
        UnityEngine.Rect val_2 = rect;
        float val_3 = height;
        float val_7 = 0.5f;
        val_7 = 579352064 * val_7;
        UnityEngine.Rect val_4 = rect;
        float val_5 = height;
        uint val_8 = 579352064;
        val_8 = val_8 - val_7;
        val_8 = val_7 - val_8;
        val_8 = (val_7 + R1) / val_8;
        val_8 = 1f - val_8;
        return (float)val_8;
    }
    public static DG.Tweening.Tweener ScrollVerticalTo(UnityEngine.UI.ScrollRect scrollRect, float anchoredPositionY, float duration, bool scrollOutRange = False)
    {
        UnityEngine.UI.ScrollRect val_7;
        var val_9;
        ScrollRectExtension.<>c__DisplayClass5_0 val_1 = 536900947;
        val_1 = new ScrollRectExtension.<>c__DisplayClass5_0();
        if(val_1 != 0)
        {
                val_7 = val_1;
            mem[536900955] = scrollRect;
        }
        else
        {
                val_7 = 8;
            mem[8] = scrollRect;
        }
        
        val_9 = val_7;
        if(R3 == 0)
        {
                val_9 = val_9;
        }
        
        536873981 = new DG.Tweening.Core.DOGetter<System.Single>(object:  536900947, method:  new IntPtr(1610678019));
        536874023 = new DG.Tweening.Core.DOSetter<System.Single>(object:  536900947, method:  new IntPtr(1610678021));
        DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_6 = DG.Tweening.DOTween.To(getter:  536873981, setter:  536874023, endValue:  UnityEngine.Mathf.Clamp(value:  ScrollRectExtension.CalculateVerticalNormalizedPos(scrollRect:  val_7, anchedPositionY:  anchoredPositionY), min:  duration, max:  null), duration:  duration);
    }

}
