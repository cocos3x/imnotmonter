using UnityEngine;

namespace FerrPoly2Tri
{
    public class PointOnEdgeException : NotImplementedException
    {
        // Fields
        public readonly FerrPoly2Tri.TriangulationPoint A;
        public readonly FerrPoly2Tri.TriangulationPoint B;
        public readonly FerrPoly2Tri.TriangulationPoint C;
        
        // Methods
        public PointOnEdgeException(string message, FerrPoly2Tri.TriangulationPoint a, FerrPoly2Tri.TriangulationPoint b, FerrPoly2Tri.TriangulationPoint c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
    
    }

}
