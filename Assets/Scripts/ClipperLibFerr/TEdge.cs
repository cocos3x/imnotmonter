using UnityEngine;

namespace ClipperLibFerr
{
    internal class TEdge
    {
        // Fields
        internal ClipperLibFerr.IntPoint Bot;
        internal ClipperLibFerr.IntPoint Curr;
        internal ClipperLibFerr.IntPoint Top;
        internal ClipperLibFerr.IntPoint Delta;
        internal double Dx;
        internal ClipperLibFerr.PolyType PolyTyp;
        internal ClipperLibFerr.EdgeSide Side;
        internal int WindDelta;
        internal int WindCnt;
        internal int WindCnt2;
        internal int OutIdx;
        internal ClipperLibFerr.TEdge Next;
        internal ClipperLibFerr.TEdge Prev;
        internal ClipperLibFerr.TEdge NextInLML;
        internal ClipperLibFerr.TEdge NextInAEL;
        internal ClipperLibFerr.TEdge PrevInAEL;
        internal ClipperLibFerr.TEdge NextInSEL;
        internal ClipperLibFerr.TEdge PrevInSEL;
        
        // Methods
        public TEdge()
        {
        
        }
    
    }

}
