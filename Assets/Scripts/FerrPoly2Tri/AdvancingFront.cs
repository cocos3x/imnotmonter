using UnityEngine;

namespace FerrPoly2Tri
{
    public class AdvancingFront
    {
        // Fields
        public FerrPoly2Tri.AdvancingFrontNode Head;
        public FerrPoly2Tri.AdvancingFrontNode Tail;
        protected FerrPoly2Tri.AdvancingFrontNode Search;
        
        // Methods
        public AdvancingFront(FerrPoly2Tri.AdvancingFrontNode head, FerrPoly2Tri.AdvancingFrontNode tail)
        {
            val_1 = new System.Object();
            this.Head = head;
            this.Tail = val_1;
            this.Search = head;
        }
        public void AddNode(FerrPoly2Tri.AdvancingFrontNode node)
        {
        
        }
        public void RemoveNode(FerrPoly2Tri.AdvancingFrontNode node)
        {
        
        }
        public override string ToString()
        {
            FerrPoly2Tri.AdvancingFrontNode val_6;
            System.Text.StringBuilder val_1 = 536894635;
            val_1 = new System.Text.StringBuilder();
            val_6 = this.Head;
            if(val_6 != this.Tail)
            {
                    do
            {
                System.Text.StringBuilder val_2 = val_1.Append(value:  null);
                System.Text.StringBuilder val_3 = val_1.Append(value:  -1610611801);
                val_6 = this.Head.Next;
            }
            while(val_6 != this.Tail);
            
            }
            
            if(val_1 != 0)
            {
                    System.Text.StringBuilder val_4 = val_1.Append(value:  null);
            }
            else
            {
                    System.Text.StringBuilder val_5 = val_1.Append(value:  null);
            }
        
        }
        private FerrPoly2Tri.AdvancingFrontNode FindSearchNode(double x)
        {
        
        }
        public FerrPoly2Tri.AdvancingFrontNode LocateNode(FerrPoly2Tri.TriangulationPoint point)
        {
            FerrPoly2Tri.AdvancingFrontNode val_1 = this.LocateNode(x:  null);
        }
        private FerrPoly2Tri.AdvancingFrontNode LocateNode(double x)
        {
            FerrPoly2Tri.AdvancingFrontNode val_1;
            if(this.Search <= 0)
            {
                goto label_6;
            }
            
            label_3:
            val_1 = this.Search.Prev;
            if(val_1 == 0)
            {
                goto label_5;
            }
            
            if(val_1 > 0)
            {
                goto label_3;
            }
            
            this.Search = val_1;
            return;
            label_6:
            if(this.Search.Next == 0)
            {
                goto label_5;
            }
            
            if(this.Search.Next <= 0)
            {
                goto label_6;
            }
            
            this.Search = this.Search.Next.Prev;
            val_1 = this.Search.Next.Prev;
            return;
            label_5:
            val_1 = 0;
        }
        public FerrPoly2Tri.AdvancingFrontNode LocatePoint(FerrPoly2Tri.TriangulationPoint point)
        {
            FerrPoly2Tri.AdvancingFrontNode val_2 = this.Search;
            if(this.Search.Point != 0)
            {
                goto label_3;
            }
            
            if(this.Search.Point == point)
            {
                goto label_17;
            }
            
            if(this.Search.Prev.Point == point)
            {
                goto label_6;
            }
            
            if(this.Search.Next.Point != point)
            {
                goto label_8;
            }
            
            val_2 = this.Search.Next;
            goto label_17;
            label_3:
            if(this.Search.Point >= 0)
            {
                goto label_15;
            }
            
            label_12:
            val_2 = this.Search.Prev;
            if(val_2 == 0)
            {
                goto label_14;
            }
            
            if(this.Search.Prev.Point != point)
            {
                goto label_12;
            }
            
            goto label_17;
            label_15:
            val_2 = this.Search.Next;
            if(val_2 == 0)
            {
                goto label_14;
            }
            
            if(this.Search.Next.Point != point)
            {
                goto label_15;
            }
            
            goto label_17;
            label_14:
            val_2 = 0;
            goto label_17;
            label_6:
            val_2 = this.Search.Prev;
            label_17:
            this.Search = val_2;
            return;
            label_8:
            22710780 = new System.Exception(message:  22785840);
        }
    
    }

}
