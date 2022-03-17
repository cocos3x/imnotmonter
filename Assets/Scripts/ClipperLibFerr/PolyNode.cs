using UnityEngine;

namespace ClipperLibFerr
{
    public class PolyNode
    {
        // Fields
        internal ClipperLibFerr.PolyNode m_Parent;
        internal System.Collections.Generic.List<ClipperLibFerr.IntPoint> m_polygon;
        internal int m_Index;
        internal ClipperLibFerr.JoinType m_jointype;
        internal ClipperLibFerr.EndType m_endtype;
        internal System.Collections.Generic.List<ClipperLibFerr.PolyNode> m_Childs;
        private bool <IsOpen>k__BackingField;
        
        // Properties
        public int ChildCount { get; }
        public System.Collections.Generic.List<ClipperLibFerr.IntPoint> Contour { get; }
        public System.Collections.Generic.List<ClipperLibFerr.PolyNode> Childs { get; }
        public ClipperLibFerr.PolyNode Parent { get; }
        public bool IsHole { get; }
        public bool IsOpen { get; set; }
        
        // Methods
        private bool IsHoleNode()
        {
            var val_1 = 1;
            do
            {
                val_1 = val_1 ^ 1;
            }
            while(this.m_Parent != 0);
            
            return true;
        }
        public int get_ChildCount()
        {
            if(this.m_Childs != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public System.Collections.Generic.List<ClipperLibFerr.IntPoint> get_Contour()
        {
        
        }
        internal void AddChild(ClipperLibFerr.PolyNode Child)
        {
            System.Collections.Generic.List<ClipperLibFerr.PolyNode> val_1 = this.m_Childs;
            if(val_1 != 0)
            {
                
            }
            else
            {
                    val_1 = this.m_Childs;
                if(val_1 == 0)
            {
                    val_1 = 0;
            }
            
            }
            
            val_1.Add(item:  Child);
            if(Child != 0)
            {
                    Child.m_Parent = this;
            }
            else
            {
                    mem[8] = this;
            }
            
            Child.m_Index = ;
        }
        public ClipperLibFerr.PolyNode GetNext()
        {
            if(true < 1)
            {
                    return this.GetNextSiblingUp();
            }
            
            if(true != 0)
            {
                    return;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        internal ClipperLibFerr.PolyNode GetNextSiblingUp()
        {
            var val_2;
            goto label_3;
            label_6:
            if(this.m_Childs != 0)
            {
                goto label_1;
            }
            
            val_2 = mem[R4 + 8];
            val_2 = R4 + 8;
            if(val_2 == 0)
            {
                goto label_2;
            }
            
            label_1:
            if((R4 + 16) == (R1 - 1))
            {
                goto label_3;
            }
            
            goto label_4;
            label_2:
            val_2 = 0;
            label_3:
            if(0 != 0)
            {
                goto label_6;
            }
            
            return;
            label_4:
            var val_2 = R4 + 16;
            val_2 = val_2 + 1;
            if((R4 + 8 + 28 + 12) <= val_2)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_3 = R4 + 8 + 28 + 8;
            val_3 = val_3 + (val_2 << 2);
        }
        public System.Collections.Generic.List<ClipperLibFerr.PolyNode> get_Childs()
        {
        
        }
        public ClipperLibFerr.PolyNode get_Parent()
        {
        
        }
        public bool get_IsHole()
        {
            var val_1 = 1;
            do
            {
                val_1 = val_1 ^ 1;
            }
            while(this.m_Parent != 0);
            
            return true;
        }
        public bool get_IsOpen()
        {
            return (bool)this.<IsOpen>k__BackingField;
        }
        public void set_IsOpen(bool value)
        {
            this.<IsOpen>k__BackingField = value;
        }
        public PolyNode()
        {
            536878005 = new System.Collections.Generic.List<ClipperLibFerr.IntPoint>();
            this.m_polygon = 536878005;
            536878167 = new System.Collections.Generic.List<Page>();
            this.m_Childs = 536878167;
        }
    
    }

}
