using UnityEngine;

namespace FerrPoly2Tri
{
    public interface ITriangulatable
    {
        // Properties
        public abstract System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> Triangles { get; }
        public abstract FerrPoly2Tri.TriangulationMode TriangulationMode { get; }
        public abstract string FileName { get; set; }
        public abstract bool DisplayFlipX { get; set; }
        public abstract bool DisplayFlipY { get; set; }
        public abstract float DisplayRotate { get; set; }
        public abstract double Precision { get; set; }
        public abstract double MinX { get; }
        public abstract double MaxX { get; }
        public abstract double MinY { get; }
        public abstract double MaxY { get; }
        public abstract FerrPoly2Tri.Rect2D Bounds { get; }
        
        // Methods
        public abstract System.Collections.Generic.IList<FerrPoly2Tri.DelaunayTriangle> get_Triangles(); // 0
        public abstract FerrPoly2Tri.TriangulationMode get_TriangulationMode(); // 0
        public abstract string get_FileName(); // 0
        public abstract void set_FileName(string value); // 0
        public abstract bool get_DisplayFlipX(); // 0
        public abstract void set_DisplayFlipX(bool value); // 0
        public abstract bool get_DisplayFlipY(); // 0
        public abstract void set_DisplayFlipY(bool value); // 0
        public abstract float get_DisplayRotate(); // 0
        public abstract void set_DisplayRotate(float value); // 0
        public abstract double get_Precision(); // 0
        public abstract void set_Precision(double value); // 0
        public abstract double get_MinX(); // 0
        public abstract double get_MaxX(); // 0
        public abstract double get_MinY(); // 0
        public abstract double get_MaxY(); // 0
        public abstract FerrPoly2Tri.Rect2D get_Bounds(); // 0
        public abstract void Prepare(FerrPoly2Tri.TriangulationContext tcx); // 0
        public abstract void AddTriangle(FerrPoly2Tri.DelaunayTriangle t); // 0
        public abstract void AddTriangles(System.Collections.Generic.IEnumerable<FerrPoly2Tri.DelaunayTriangle> list); // 0
        public abstract void ClearTriangles(); // 0
    
    }

}
