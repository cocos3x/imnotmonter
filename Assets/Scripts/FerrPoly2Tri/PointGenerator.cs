using UnityEngine;

namespace FerrPoly2Tri
{
    public class PointGenerator
    {
        // Fields
        private static readonly System.Random RNG;
        
        // Methods
        public static System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> UniformDistribution(int n, double scale)
        {
            FerrPoly2Tri.TriangulationPoint val_5;
            var val_6;
            var val_7;
            int val_6 = n;
            val_5 = R3;
            val_6 = R2;
            536878451 = new System.Collections.Generic.List<Page>();
            if(val_6 < 1)
            {
                    return;
            }
            
            do
            {
                val_7 = 536891897;
                if(((mem[536892084] & true) == 0) && (mem[536892013] == 0))
            {
                    val_7 = 536891897;
            }
            
                double val_2 = 0.5 - mem[536891989];
                var val_5 = mem[536891989];
                val_2 = val_2 * val_6;
                val_5 = 0.5 - val_5;
                val_6 = 23000704;
                double val_3 = val_5 * val_6;
                val_5 = 536895819;
                val_5 = new FerrPoly2Tri.TriangulationPoint(x:  scale, y:  null, aId:  mem[536891989] + 248);
                536878451.Add(item:  536895819);
                val_6 = val_6 - 1;
            }
            while(536878451 != 0);
        
        }
        public static System.Collections.Generic.List<FerrPoly2Tri.TriangulationPoint> UniformGrid(int n, double scale)
        {
            var val_8;
            var val_9;
            int val_10;
            val_8 = n;
            val_9 = R2;
            536878451 = new System.Collections.Generic.List<Page>();
            val_10 = val_8 + 1;
            if(val_10 < 1)
            {
                    return;
            }
            
            val_9 = 0;
            double val_2 = val_9 / D16;
            val_8 = 22739436;
            double val_3 = val_9 * 0.5;
            do
            {
                do
            {
                536895819 = new FerrPoly2Tri.TriangulationPoint(x:  scale, y:  null, aId:  -1073712051);
                536878451.Add(item:  536895819);
                double val_5 = D13 + 1;
                val_10 = val_10 - 1;
            }
            while(536878451 != 0);
            
                double val_6 = D10 + 1;
                val_10 = val_10;
            }
            while(1 != val_10);
        
        }
        public PointGenerator()
        {
        
        }
        private static PointGenerator()
        {
            System.Random val_1 = 536892443;
            val_1 = new System.Random();
            mem2[0] = val_1;
        }
    
    }

}
