using UnityEngine;

namespace FerrPoly2Tri
{
    public class DTSweepPointComparator : IComparer<FerrPoly2Tri.TriangulationPoint>
    {
        // Methods
        public int Compare(FerrPoly2Tri.TriangulationPoint p1, FerrPoly2Tri.TriangulationPoint p2)
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = 0;
            if(p2 < 0)
            {
                    return 1;
            }
            
            val_2 = p1;
            val_3 = typeof(FerrPoly2Tri.TriangulationPoint).__il2cppRuntimeField_F8;
            val_1 = 1;
            if(p2 > 0)
            {
                    return 1;
            }
            
            val_2 = p1;
            val_3 = typeof(FerrPoly2Tri.TriangulationPoint).__il2cppRuntimeField_E8;
            val_1 = 0;
            if(p2 < 0)
            {
                    return 1;
            }
            
            val_2 = typeof(FerrPoly2Tri.TriangulationPoint).__il2cppRuntimeField_E8;
            if(p2 > 0)
            {
                    val_1 = 1;
            }
            
            return 1;
        }
        public DTSweepPointComparator()
        {
        
        }
    
    }

}
