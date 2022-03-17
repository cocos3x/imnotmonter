using UnityEngine;

namespace FerrPoly2Tri
{
    public class PolygonSet
    {
        // Fields
        protected System.Collections.Generic.List<FerrPoly2Tri.Polygon> _polygons;
        
        // Properties
        public System.Collections.Generic.IEnumerable<FerrPoly2Tri.Polygon> Polygons { get; }
        
        // Methods
        public PolygonSet()
        {
            536878171 = new System.Collections.Generic.List<Page>();
            this._polygons = 536878171;
        }
        public PolygonSet(FerrPoly2Tri.Polygon poly)
        {
            FerrPoly2Tri.Polygon val_2 = poly;
            536878171 = new System.Collections.Generic.List<Page>();
            this._polygons = 536878171;
            val_2 = new System.Object();
            this._polygons.Add(item:  val_2);
        }
        public void Add(FerrPoly2Tri.Polygon p)
        {
            this._polygons.Add(item:  p);
        }
        public System.Collections.Generic.IEnumerable<FerrPoly2Tri.Polygon> get_Polygons()
        {
        
        }
    
    }

}
