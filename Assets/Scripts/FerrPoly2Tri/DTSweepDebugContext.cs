using UnityEngine;

namespace FerrPoly2Tri
{
    public class DTSweepDebugContext : TriangulationDebugContext
    {
        // Fields
        private FerrPoly2Tri.DelaunayTriangle _primaryTriangle;
        private FerrPoly2Tri.DelaunayTriangle _secondaryTriangle;
        private FerrPoly2Tri.TriangulationPoint _activePoint;
        private FerrPoly2Tri.AdvancingFrontNode _activeNode;
        private FerrPoly2Tri.DTSweepConstraint _activeConstraint;
        
        // Properties
        public FerrPoly2Tri.DelaunayTriangle PrimaryTriangle { get; set; }
        public FerrPoly2Tri.DelaunayTriangle SecondaryTriangle { get; set; }
        public FerrPoly2Tri.TriangulationPoint ActivePoint { get; set; }
        public FerrPoly2Tri.AdvancingFrontNode ActiveNode { get; set; }
        public FerrPoly2Tri.DTSweepConstraint ActiveConstraint { get; set; }
        public bool IsDebugContext { get; }
        
        // Methods
        public FerrPoly2Tri.DelaunayTriangle get_PrimaryTriangle()
        {
        
        }
        public void set_PrimaryTriangle(FerrPoly2Tri.DelaunayTriangle value)
        {
            this._primaryTriangle = value;
            this._primaryTriangle.Update(message:  -1610598461);
        }
        public FerrPoly2Tri.DelaunayTriangle get_SecondaryTriangle()
        {
        
        }
        public void set_SecondaryTriangle(FerrPoly2Tri.DelaunayTriangle value)
        {
            this._secondaryTriangle = value;
            this._secondaryTriangle.Update(message:  -1610598459);
        }
        public FerrPoly2Tri.TriangulationPoint get_ActivePoint()
        {
        
        }
        public void set_ActivePoint(FerrPoly2Tri.TriangulationPoint value)
        {
            this._activePoint = value;
            this._activePoint.Update(message:  -1610598467);
        }
        public FerrPoly2Tri.AdvancingFrontNode get_ActiveNode()
        {
        
        }
        public void set_ActiveNode(FerrPoly2Tri.AdvancingFrontNode value)
        {
            this._activeNode = value;
            this._activeNode.Update(message:  -1610598469);
        }
        public FerrPoly2Tri.DTSweepConstraint get_ActiveConstraint()
        {
        
        }
        public void set_ActiveConstraint(FerrPoly2Tri.DTSweepConstraint value)
        {
            this._activeConstraint = value;
            this._activeConstraint.Update(message:  -1610598471);
        }
        public DTSweepDebugContext(FerrPoly2Tri.DTSweepContext tcx)
        {
        
        }
        public bool get_IsDebugContext()
        {
            return true;
        }
        public override void Clear()
        {
            this.PrimaryTriangle = 0;
            this.SecondaryTriangle = 0;
            this.ActivePoint = 0;
            this.ActiveNode = 0;
            this.ActiveConstraint = 0;
        }
    
    }

}
