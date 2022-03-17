using UnityEngine;

namespace ClipperLibFerr
{
    public class MyIntersectNodeSort : IComparer<ClipperLibFerr.IntersectNode>
    {
        // Methods
        public int Compare(ClipperLibFerr.IntersectNode node1, ClipperLibFerr.IntersectNode node2)
        {
            this = R6 - this;
            ClipperLibFerr.MyIntersectNodeSort val_1 = 0 - this;
            if(node1 < 0)
            {
                    return 1;
            }
            
            if(node1 != 0)
            {
                    this = 0;
            }
            
            return (int)this;
        }
        public MyIntersectNodeSort()
        {
        
        }
    
    }

}
