using UnityEngine;

namespace FerrPoly2Tri
{
    public class PolygonGenerator
    {
        // Fields
        private static readonly System.Random RNG;
        private static double PI_2;
        
        // Methods
        public static FerrPoly2Tri.Polygon RandomCircleSweep(double scale, int vertexCount)
        {
            var val_14;
            FerrPoly2Tri.PolygonPoint val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_14 = vertexCount;
            val_15 = R1;
            if(R2 < 1)
            {
                goto label_1;
            }
            
            double val_15 = 25;
            var val_18 = 0;
            val_15 = val_14 * val_15;
            int val_4 = val_14 * 0.5;
            label_24:
            var val_6 = R2 >> 4;
            var val_7 = R2 >> 4;
            label_15:
            val_16 = 536891963;
            var val_16 = mem[536892149];
            val_16 = val_16 & 512;
            if(val_14 == 0)
            {
                goto label_2;
            }
            
            if(23000759 == 0)
            {
                goto label_3;
            }
            
            if((val_16 != 0) && (mem[536892079] == 0))
            {
                    val_17 = 536891963;
            }
            
            val_18 = val_15 / D20;
            val_19 = mem[536892055];
            goto label_11;
            label_2:
            if((val_16 != 0) && (mem[536892079] == 0))
            {
                    val_20 = 536891963;
            }
            
            val_19 = mem[536892055];
            val_18 = val_4;
            goto label_11;
            label_3:
            if((val_16 != 0) && (mem[536892079] == 0))
            {
                    val_21 = 536891963;
            }
            
            val_19 = mem[536892055];
            val_18 = val_14 / 5;
            label_11:
            val_19 = 0.5 - val_19;
            if(mem[536892055] > 0)
            {
                    val_14 * 0.25 = val_4;
            }
            
            if(mem[536892055] < 0)
            {
                    val_14 * 0.25 = val_14 / 10;
            }
            
            if(mem[536892055] > 0)
            {
                goto label_15;
            }
            
            val_22 = 536891963;
            if(((mem[536892150] & true) == 0) && (mem[536892079] == 0))
            {
                    val_22 = 536891963;
            }
            
            double val_8 = (mem[536892055] + 8) * D15;
            val_8 = val_8 / ;
            var val_17 = mem[536892055] + 8;
            val_17 = val_17 * D15;
            val_17 = val_17 / ;
            int val_9 = (val_14 * 0.25) * 536890295;
            val_14 = 23000759;
            int val_10 = (val_14 * 0.25) * R3;
            val_15 = 536891967;
            val_15 = new FerrPoly2Tri.PolygonPoint(x:  scale, y:  null, aId:  R3);
            var val_12 = 536882267 + 0;
            mem2[0] = val_15;
            val_18 = val_18 + 1;
            double val_13 = D15 + 1;
            if(val_18 != R2)
            {
                goto label_24;
            }
            
            label_1:
            536891953 = new FerrPoly2Tri.Polygon(points:  536882267);
        }
        public static FerrPoly2Tri.Polygon RandomCircleSweep2(double scale, int vertexCount)
        {
            var val_11;
            FerrPoly2Tri.PolygonPoint val_12;
            var val_13;
            var val_14;
            val_11 = vertexCount;
            val_12 = R1;
            if(R2 < 1)
            {
                goto label_1;
            }
            
            var val_14 = 0;
            int val_2 = val_11 / 5;
            do
            {
                label_14:
                val_13 = 536891963;
                if(((mem[536892150] & true) == 0) && (mem[536892079] == 0))
            {
                    val_13 = 536891963;
            }
            
                var val_12 = mem[536892055];
                val_12 = 0.5 - val_12;
                if(mem[536892055] > 0)
            {
                    val_11 * 0.25 = val_11 * 0.5;
            }
            
                if(mem[536892055] < 0)
            {
                    val_11 * 0.25 = val_11 / 10;
            }
            
            }
            while(mem[536892055] > 0);
            
            val_14 = 536891963;
            if(((mem[536892150] & true) == 0) && (mem[536892079] == 0))
            {
                    val_14 = 536891963;
            }
            
            double val_5 = (mem[536892055] + 8) * D14;
            val_5 = val_5 / D13;
            var val_13 = mem[536892055] + 8;
            val_13 = val_13 * D14;
            val_13 = val_13 / D13;
            int val_6 = (val_11 * 0.25) * 536890295;
            val_11 = 23000760;
            int val_7 = (val_11 * 0.25) * R3;
            val_12 = 536891967;
            val_12 = new FerrPoly2Tri.PolygonPoint(x:  scale, y:  null, aId:  R3);
            var val_9 = 536882267 + 0;
            mem2[0] = val_12;
            val_14 = val_14 + 1;
            double val_10 = D14 + 1;
            if(val_14 != R2)
            {
                goto label_14;
            }
            
            label_1:
            536891953 = new FerrPoly2Tri.Polygon(points:  536882267);
        }
        public PolygonGenerator()
        {
        
        }
        private static PolygonGenerator()
        {
            System.Random val_1 = 536892443;
            val_1 = new System.Random();
            mem2[0] = val_1;
            mem2[0] = 1413754136;
            mem2[0] = 1075388923;
        }
    
    }

}
