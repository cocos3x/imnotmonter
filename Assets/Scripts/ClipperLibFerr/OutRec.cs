using UnityEngine;

namespace ClipperLibFerr
{
    internal class OutRec
    {
        // Fields
        internal int Idx;
        internal bool IsHole;
        internal bool IsOpen;
        internal ClipperLibFerr.OutRec FirstLeft;
        internal ClipperLibFerr.OutPt Pts;
        internal ClipperLibFerr.OutPt BottomPt;
        internal ClipperLibFerr.PolyNode PolyNode;
        
        // Methods
        public OutRec()
        {
        
        }
    
    }

}
