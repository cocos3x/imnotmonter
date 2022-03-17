using UnityEngine;

namespace FerrPoly2Tri
{
    public abstract class TriangulationDebugContext
    {
        // Fields
        protected FerrPoly2Tri.TriangulationContext _tcx;
        
        // Methods
        public TriangulationDebugContext(FerrPoly2Tri.TriangulationContext tcx)
        {
            FerrPoly2Tri.TriangulationContext val_1 = tcx;
            val_1 = new System.Object();
            this._tcx = val_1;
        }
        public abstract void Clear(); // 0
    
    }

}
