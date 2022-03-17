using UnityEngine;

namespace FerrPoly2Tri
{
    public class TriangulationPointEnumerator : IEnumerator<FerrPoly2Tri.TriangulationPoint>, IEnumerator, IDisposable
    {
        // Fields
        protected System.Collections.Generic.IList<FerrPoly2Tri.Point2D> mPoints;
        protected int position;
        
        // Properties
        private object System.Collections.IEnumerator.Current { get; }
        public FerrPoly2Tri.TriangulationPoint Current { get; }
        
        // Methods
        public TriangulationPointEnumerator(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> points)
        {
            this.position = 0;
            this.mPoints = points;
        }
        public bool MoveNext()
        {
            var val_3;
            var val_4;
            int val_1 = this.position + 1;
            this.position = val_1;
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this.mPoints;
            if(val_1 < this.mPoints)
            {
                    0 = 1;
            }
            
            return true;
        }
        public void Reset()
        {
            this.position = 0;
        }
        private void System.IDisposable.Dispose()
        {
        
        }
        private object System.Collections.IEnumerator.get_Current()
        {
            return this.Current;
        }
        public FerrPoly2Tri.TriangulationPoint get_Current()
        {
            int val_3;
            var val_4;
            System.Collections.Generic.IList<FerrPoly2Tri.Point2D> val_5;
            var val_6;
            var val_7;
            var val_8;
            val_3 = this;
            val_4 = 0;
            if(this.position < 0)
            {
                    return;
            }
            
            val_5 = this.mPoints;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_7 = val_5;
            if(this.position >= val_5)
            {
                    return;
            }
            
            val_5 = this.mPoints;
            val_3 = this.position;
            val_6 = 0;
            val_6 = val_6 + 1;
            val_8 = val_5;
            if(val_5 == 0)
            {
                    return;
            }
            
            if(((System.Collections.Generic.IList<T>.__il2cppRuntimeField_typeHierarchy + (mem[536895999]) << 2) + -4) != 536895819)
            {
                    val_5 = 0;
            }
            
            val_4 = val_5;
        }
    
    }

}
