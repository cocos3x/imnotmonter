using UnityEngine;

namespace FerrPoly2Tri
{
    public class AdvancingFrontNode
    {
        // Fields
        public FerrPoly2Tri.AdvancingFrontNode Next;
        public FerrPoly2Tri.AdvancingFrontNode Prev;
        public double Value;
        public FerrPoly2Tri.TriangulationPoint Point;
        public FerrPoly2Tri.DelaunayTriangle Triangle;
        
        // Properties
        public bool HasNext { get; }
        public bool HasPrev { get; }
        
        // Methods
        public AdvancingFrontNode(FerrPoly2Tri.TriangulationPoint point)
        {
            this.Point = point;
            this.Value = point;
        }
        public bool get_HasNext()
        {
            if(this.Next != 0)
            {
                    this.Next = 1;
            }
            
            return true;
        }
        public bool get_HasPrev()
        {
            if(this.Prev != 0)
            {
                    this.Prev = 1;
            }
            
            return true;
        }
    
    }

}
