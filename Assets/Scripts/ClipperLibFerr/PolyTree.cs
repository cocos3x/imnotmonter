using UnityEngine;

namespace ClipperLibFerr
{
    public class PolyTree : PolyNode
    {
        // Fields
        internal System.Collections.Generic.List<ClipperLibFerr.PolyNode> m_AllPolys;
        
        // Properties
        public int Total { get; }
        
        // Methods
        public void Clear()
        {
            var val_1;
            System.Collections.Generic.List<ClipperLibFerr.PolyNode> val_2;
            val_1 = 0;
            goto label_1;
            label_4:
            val_2 = this.m_AllPolys;
            if(val_2 == 0)
            {
                    val_2 = 0;
            }
            
            if(val_1 >= (R6 + 12))
            {
                goto label_3;
            }
            
            label_5:
            val_2.set_Item(index:  0, value:  0);
            val_1 = 1;
            label_1:
            val_2 = this.m_AllPolys;
            if(val_2 == 0)
            {
                goto label_4;
            }
            
            if(val_1 < val_2)
            {
                goto label_5;
            }
            
            label_3:
            val_2.Clear();
            this.Clear();
        }
        public ClipperLibFerr.PolyNode GetFirst()
        {
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        public int get_Total()
        {
            var val_1;
            if(this.m_AllPolys < 1)
            {
                    return (int)val_1;
            }
            
            if((R6 + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((R6 + 8) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if((R6 + 8 + 16) != 2621443)
            {
                    val_1 = this.m_AllPolys - 1;
            }
            
            return (int)val_1;
        }
        public PolyTree()
        {
            536878167 = new System.Collections.Generic.List<Page>();
            this.m_AllPolys = 536878167;
        }
    
    }

}
