using UnityEngine;

namespace FerrPoly2Tri
{
    public class Edge
    {
        // Fields
        protected FerrPoly2Tri.Point2D mP;
        protected FerrPoly2Tri.Point2D mQ;
        
        // Properties
        public FerrPoly2Tri.Point2D EdgeStart { get; set; }
        public FerrPoly2Tri.Point2D EdgeEnd { get; set; }
        
        // Methods
        public FerrPoly2Tri.Point2D get_EdgeStart()
        {
        
        }
        public void set_EdgeStart(FerrPoly2Tri.Point2D value)
        {
            this.mP = value;
        }
        public FerrPoly2Tri.Point2D get_EdgeEnd()
        {
        
        }
        public void set_EdgeEnd(FerrPoly2Tri.Point2D value)
        {
            this.mQ = value;
        }
        public Edge()
        {
            this.mP = 0;
            this.mQ = 0;
        }
        public Edge(FerrPoly2Tri.Point2D edgeStart, FerrPoly2Tri.Point2D edgeEnd)
        {
            val_1 = new System.Object();
            this.mP = edgeStart;
            this.mQ = val_1;
        }
    
    }

}
