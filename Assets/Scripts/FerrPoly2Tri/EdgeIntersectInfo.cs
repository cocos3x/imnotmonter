using UnityEngine;

namespace FerrPoly2Tri
{
    public class EdgeIntersectInfo
    {
        // Fields
        private FerrPoly2Tri.Edge <EdgeOne>k__BackingField;
        private FerrPoly2Tri.Edge <EdgeTwo>k__BackingField;
        private FerrPoly2Tri.Point2D <IntersectionPoint>k__BackingField;
        
        // Properties
        public FerrPoly2Tri.Edge EdgeOne { get; set; }
        public FerrPoly2Tri.Edge EdgeTwo { get; set; }
        public FerrPoly2Tri.Point2D IntersectionPoint { get; set; }
        
        // Methods
        public EdgeIntersectInfo(FerrPoly2Tri.Edge edgeOne, FerrPoly2Tri.Edge edgeTwo, FerrPoly2Tri.Point2D intersectionPoint)
        {
            val_1 = new System.Object();
            this.<EdgeOne>k__BackingField = edgeOne;
            this.<EdgeTwo>k__BackingField = val_1;
            this.<IntersectionPoint>k__BackingField = intersectionPoint;
        }
        public FerrPoly2Tri.Edge get_EdgeOne()
        {
        
        }
        private void set_EdgeOne(FerrPoly2Tri.Edge value)
        {
            this.<EdgeOne>k__BackingField = value;
        }
        public FerrPoly2Tri.Edge get_EdgeTwo()
        {
        
        }
        private void set_EdgeTwo(FerrPoly2Tri.Edge value)
        {
            this.<EdgeTwo>k__BackingField = value;
        }
        public FerrPoly2Tri.Point2D get_IntersectionPoint()
        {
        
        }
        private void set_IntersectionPoint(FerrPoly2Tri.Point2D value)
        {
            this.<IntersectionPoint>k__BackingField = value;
        }
    
    }

}
