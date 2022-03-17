using UnityEngine;
public static class DOTweenModuleUI.Utils
{
    // Methods
    public static UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to)
    {
        float val_11;
        float val_12;
        UnityEngine.Rect val_1 = rect;
        float val_2 = width;
        UnityEngine.Rect val_3 = rect;
        float val_4 = xMin;
        UnityEngine.Rect val_5 = rect;
        float val_6 = height;
        UnityEngine.Rect val_7 = rect;
        float val_8 = yMin;
        UnityEngine.Vector3 val_9 = position;
        UnityEngine.Vector2 val_10 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  1400530528, worldPoint:  new UnityEngine.Vector3() {x = 0f, y = R4, z = R6});
        float val_23 = val_11;
        float val_24 = val_12;
        val_23 = 1400530544 + val_23;
        val_24 = 1400530544 + val_24;
        bool val_13 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  R2, screenPoint:  new UnityEngine.Vector2() {x = val_23, y = val_24}, cam:  0, localPoint: out  new UnityEngine.Vector2() {x = 1.075461E+12f, y = 0f});
        UnityEngine.Rect val_14 = rect;
        float val_15 = width;
        UnityEngine.Rect val_16 = rect;
        float val_17 = xMin;
        UnityEngine.Rect val_18 = rect;
        float val_19 = height;
        UnityEngine.Rect val_20 = rect;
        float val_21 = yMin;
        UnityEngine.Vector2 val_22 = anchoredPosition;
        float val_25 = val_11;
        float val_26 = val_12;
        val_25 = val_25 + 0;
        val_26 = val_26 + 0;
        val_25 = val_25 - 1400530544;
        val_26 = val_26 - 1400530544;
        mem2[0] = val_25;
        mem2[0] = val_26;
        return new UnityEngine.Vector2() {x = val_25, y = val_22.y};
    }

}
