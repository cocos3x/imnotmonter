using UnityEngine;

namespace ClipperLibFerr
{
    internal class OutPt
    {
        // Fields
        internal int Idx;
        internal ClipperLibFerr.IntPoint Pt;
        internal ClipperLibFerr.OutPt Next;
        internal ClipperLibFerr.OutPt Prev;
        
        // Methods
        public OutPt()
        {
        
        }
    
    }

}
