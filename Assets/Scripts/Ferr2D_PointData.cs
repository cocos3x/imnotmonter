using UnityEngine;
[Serializable]
public struct Ferr2D_PointData : ILerpable<Ferr2D_PointData>
{
    // Fields
    public int directionOverride;
    public System.Collections.Generic.List<int> cutOverrides;
    public float scale;
    
    // Methods
    public Ferr2D_PointData(float aScale = 1, int aDirectionOverride = 100)
    {
        this = R2;
        536877987 = new System.Collections.Generic.List<System.Int32>();
        this.cutOverrides = 536877987;
        this.scale = aDirectionOverride;
    }
    public Ferr2D_PointData Lerp(Ferr2D_PointData aWith, float aLerp)
    {
        var val_1;
        float val_5 = 3.141593f;
        val_5 = val_1 * val_5;
        float val_6 = -1f;
        val_6 = val_5 + val_6;
        val_6 = val_6 * (-0.5f);
         = new Ferr2D_PointData(aScale:  UnityEngine.Mathf.Lerp(a:  val_6, b:  null, t:  val_5), aDirectionOverride:  aWith.directionOverride + 8);
        this.scale = val_4.scale;
        this = val_4.directionOverride;
        return new Ferr2D_PointData() {directionOverride = val_4.scale, cutOverrides = aWith.directionOverride + 4, scale = aWith.directionOverride};
    }
    private float EaseInOut(float aTime)
    {
        float val_1 = 3.141593f;
        val_1 = R1 * val_1;
        float val_2 = -1f;
        val_2 = val_1 + val_2;
        val_2 = val_2 * (-0.5f);
        return (float)val_2;
    }

}
