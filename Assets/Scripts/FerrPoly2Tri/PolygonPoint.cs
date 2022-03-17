using UnityEngine;

namespace FerrPoly2Tri
{
    public class PolygonPoint : TriangulationPoint
    {
        // Fields
        private FerrPoly2Tri.PolygonPoint <Next>k__BackingField;
        private FerrPoly2Tri.PolygonPoint <Previous>k__BackingField;
        
        // Properties
        public FerrPoly2Tri.PolygonPoint Next { get; set; }
        public FerrPoly2Tri.PolygonPoint Previous { get; set; }
        
        // Methods
        public PolygonPoint(double x, double y, int aId = -1)
        {
            bool val_3 = mem[536896006];
            if((val_3 & true) != 0)
            {
                    return;
            }
            
            val_3 = mem[536895935];
            if(val_3 != 0)
            {
                    return;
            }
        
        }
        public FerrPoly2Tri.PolygonPoint get_Next()
        {
        
        }
        public void set_Next(FerrPoly2Tri.PolygonPoint value)
        {
            this.<Next>k__BackingField = value;
        }
        public FerrPoly2Tri.PolygonPoint get_Previous()
        {
        
        }
        public void set_Previous(FerrPoly2Tri.PolygonPoint value)
        {
            this.<Previous>k__BackingField = value;
        }
        public static FerrPoly2Tri.Point2D ToBasePoint(FerrPoly2Tri.PolygonPoint p)
        {
        
        }
        public static FerrPoly2Tri.TriangulationPoint ToTriangulationPoint(FerrPoly2Tri.PolygonPoint p)
        {
        
        }
    
    }

}
