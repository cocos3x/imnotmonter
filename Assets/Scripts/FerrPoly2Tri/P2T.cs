using UnityEngine;

namespace FerrPoly2Tri
{
    public static class P2T
    {
        // Fields
        private static FerrPoly2Tri.TriangulationAlgorithm _defaultAlgorithm;
        
        // Methods
        public static void Triangulate(FerrPoly2Tri.PolygonSet ps)
        {
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            val_5 = 0;
            val_6 = 0;
            val_5 = val_5 + 1;
            val_6 = (uint)val_5 & 65535;
            val_7 = ps._polygons;
            label_20:
            var val_6 = 0;
            val_5 = 0;
            val_6 = val_6 + 1;
            val_5 = (uint)val_6 & 65535;
            val_8 = ps._polygons;
            if(ps._polygons == 0)
            {
                goto label_12;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_9 = ps._polygons;
            FerrPoly2Tri.P2T.Triangulate(p:  ps._polygons);
            goto label_20;
            label_12:
            if(ps._polygons != 0)
            {
                    val_5 = 0;
                val_5 = val_5 + 1;
                val_10 = ps._polygons;
            }
            
            if(1 == 0)
            {
                    return;
            }
            
            var val_5 = 1 - 1;
        }
        public static void Triangulate(FerrPoly2Tri.Polygon p)
        {
            if(((mem[536891616] & true) == 0) && (mem[536891545] == 0))
            {
                    536891429 = 536891429;
            }
            
            FerrPoly2Tri.P2T.Triangulate(algorithm:  mem[536891521], t:  p);
        }
        public static void Triangulate(FerrPoly2Tri.ConstrainedPointSet cps)
        {
            if(((mem[536891616] & true) == 0) && (mem[536891545] == 0))
            {
                    536891429 = 536891429;
            }
            
            FerrPoly2Tri.P2T.Triangulate(algorithm:  mem[536891521], t:  cps);
        }
        public static void Triangulate(FerrPoly2Tri.PointSet ps)
        {
            if(((mem[536891616] & true) == 0) && (mem[536891545] == 0))
            {
                    536891429 = 536891429;
            }
            
            FerrPoly2Tri.P2T.Triangulate(algorithm:  mem[536891521], t:  ps);
        }
        public static FerrPoly2Tri.TriangulationContext CreateContext(FerrPoly2Tri.TriangulationAlgorithm algorithm)
        {
            536885655 = new FerrPoly2Tri.DTSweepContext();
        }
        public static void Triangulate(FerrPoly2Tri.TriangulationAlgorithm algorithm, FerrPoly2Tri.ITriangulatable t)
        {
            FerrPoly2Tri.TriangulationContext val_1 = FerrPoly2Tri.P2T.CreateContext(algorithm:  536891429);
            FerrPoly2Tri.P2T.Triangulate(tcx:  536891429);
        }
        public static void Triangulate(FerrPoly2Tri.TriangulationContext tcx)
        {
            FerrPoly2Tri.DTSweepContext val_1 = 0;
            FerrPoly2Tri.DTSweep.Triangulate(tcx:  null);
        }
        public static void Warmup()
        {
        
        }
        private static P2T()
        {
        
        }
    
    }

}
