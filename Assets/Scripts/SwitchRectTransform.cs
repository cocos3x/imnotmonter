using UnityEngine;
public static class SwitchRectTransform
{
    // Methods
    public static UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to)
    {
        float val_4;
        float val_10;
        UnityEngine.Rect val_1 = rect;
        float val_2 = width;
        UnityEngine.Vector2 val_3 = pivot;
        UnityEngine.Rect val_5 = rect;
        float val_6 = xMin;
        UnityEngine.Rect val_7 = rect;
        float val_8 = height;
        UnityEngine.Vector2 val_9 = pivot;
        UnityEngine.Rect val_11 = rect;
        float val_12 = yMin;
        UnityEngine.Vector3 val_13 = position;
        UnityEngine.Vector2 val_15 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  583077856, worldPoint:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_10});
        float val_28 = val_4;
        float val_29 = val_10;
        val_28 = 583077872 + val_28;
        val_29 = 583077872 + val_29;
        bool val_16 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  R2, screenPoint:  new UnityEngine.Vector2() {x = val_28, y = val_29}, cam:  0, localPoint: out  new UnityEngine.Vector2() {x = 5.23297E-18f, y = 0f});
        UnityEngine.Rect val_17 = rect;
        float val_18 = width;
        UnityEngine.Vector2 val_19 = pivot;
        UnityEngine.Rect val_20 = rect;
        float val_21 = xMin;
        UnityEngine.Rect val_22 = rect;
        float val_23 = height;
        UnityEngine.Vector2 val_24 = pivot;
        UnityEngine.Rect val_25 = rect;
        float val_26 = yMin;
        UnityEngine.Vector2 val_27 = anchoredPosition;
        float val_30 = val_4;
        float val_31 = val_10;
        val_30 = val_30 + 0;
        val_31 = val_31 + 0;
        val_30 = val_30 - 583077872;
        val_31 = val_31 - 583077872;
        mem2[0] = val_30;
        mem2[0] = val_31;
        return new UnityEngine.Vector2() {x = val_30, y = val_27.y};
    }

}
