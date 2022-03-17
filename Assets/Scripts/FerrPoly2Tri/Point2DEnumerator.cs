using UnityEngine;

namespace FerrPoly2Tri
{
    public class Point2DEnumerator : IEnumerator<FerrPoly2Tri.Point2D>, IEnumerator, IDisposable
    {
        // Fields
        protected System.Collections.Generic.IList<FerrPoly2Tri.Point2D> mPoints;
        protected int position;
        
        // Properties
        private object System.Collections.IEnumerator.Current { get; }
        public FerrPoly2Tri.Point2D Current { get; }
        
        // Methods
        public Point2DEnumerator(System.Collections.Generic.IList<FerrPoly2Tri.Point2D> points)
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
        public FerrPoly2Tri.Point2D get_Current()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            if(this.position < 0)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_5 = this.mPoints;
            if(this.position >= this.mPoints)
            {
                    return;
            }
            
            val_3 = 0;
            val_4 = 0;
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            val_6 = this.mPoints;
            goto mem[(1152921504681820160 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)];
        }
    
    }

}
