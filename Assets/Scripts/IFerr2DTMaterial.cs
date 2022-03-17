using UnityEngine;
public interface IFerr2DTMaterial
{
    // Properties
    public abstract string name { get; }
    public abstract UnityEngine.Material fillMaterial { get; set; }
    public abstract UnityEngine.Material edgeMaterial { get; set; }
    public abstract int descriptorCount { get; }
    
    // Methods
    public abstract string get_name(); // 0
    public abstract UnityEngine.Material get_fillMaterial(); // 0
    public abstract void set_fillMaterial(UnityEngine.Material value); // 0
    public abstract UnityEngine.Material get_edgeMaterial(); // 0
    public abstract void set_edgeMaterial(UnityEngine.Material value); // 0
    public abstract int get_descriptorCount(); // 0
    public abstract Ferr2DT_SegmentDescription GetDescriptor(Ferr2DT_TerrainDirection aDirection); // 0
    public abstract bool Has(Ferr2DT_TerrainDirection aDirection); // 0
    public abstract void Set(Ferr2DT_TerrainDirection aDirection, bool aActive); // 0
    public abstract UnityEngine.Rect GetBody(Ferr2DT_TerrainDirection aDirection, int aBodyID); // 0
    public abstract void Add(); // 0
    public abstract void Remove(Ferr2DT_TerrainDirection aDirection); // 0
    public abstract UnityEngine.Rect ToUV(UnityEngine.Rect aNativeRect); // 0
    public abstract UnityEngine.Rect ToScreen(UnityEngine.Rect aNativeRect); // 0
    public abstract UnityEngine.Rect ToNative(UnityEngine.Rect aPixelRect); // 0
    public abstract UnityEngine.Rect ToPixels(UnityEngine.Rect aNativeRect); // 0

}
