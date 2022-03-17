using UnityEngine;

namespace B83.ExpressionParser
{
    public class OperationProduct : IValue
    {
        // Fields
        private B83.ExpressionParser.IValue[] m_Values;
        
        // Properties
        public double Value { get; }
        
        // Methods
        public double get_Value()
        {
            var val_4;
            object val_5;
            System.Func<System.Object, System.Double> val_6;
            object val_7;
            var val_8;
            object val_9;
            System.Func<System.Double, System.Double, System.Double> val_10;
            val_4 = 536900149;
            if(((mem[536900336] & true) == 0) && (mem[536900265] == 0))
            {
                    val_4 = 536900149;
            }
            
            val_5 = mem[536900241];
            val_6 = mem[mem[536900241] + 4];
            val_6 = mem[536900241] + 4;
            if(val_6 == 0)
            {
                    if(((mem[536900336] & true) == 0) && (mem[536900265] == 0))
            {
                    val_5 = mem[536900241];
            }
            
                val_7 = mem[mem[536900241]];
                val_7 = val_5;
                val_6 = 536875443;
                val_6 = new System.Func<System.Object, System.Double>(object:  val_7, method:  new IntPtr(1610687587));
                mem2[0] = val_6;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<System.Object, System.Double>(source:  this.m_Values, selector:  536875443);
            val_8 = 536900149;
            if(((mem[536900336] & true) == 0) && (mem[536900265] == 0))
            {
                    val_8 = 536900149;
            }
            
            val_9 = mem[536900241];
            val_10 = mem[mem[536900241] + 8];
            val_10 = mem[536900241] + 8;
            if(val_10 != 0)
            {
                    return System.Linq.Enumerable.Aggregate<System.Double>(source:  this.m_Values, func:  536875627);
            }
            
            if(((mem[536900336] & true) == 0) && (mem[536900265] == 0))
            {
                    val_9 = mem[536900241];
            }
            
            val_7 = mem[mem[536900241]];
            val_7 = val_9;
            val_10 = 536875627;
            val_10 = new System.Func<System.Double, System.Double, System.Double>(object:  val_7, method:  new IntPtr(1610687589));
            mem2[0] = val_10;
            return System.Linq.Enumerable.Aggregate<System.Double>(source:  this.m_Values, func:  536875627);
        }
        public OperationProduct(B83.ExpressionParser.IValue[] aValues)
        {
            this.m_Values = aValues;
        }
        public override string ToString()
        {
            var val_5;
            object val_6;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_7;
            val_5 = 536900149;
            if(((mem[536900336] & true) == 0) && (mem[536900265] == 0))
            {
                    val_5 = 536900149;
            }
            
            val_6 = mem[536900241];
            val_7 = mem[mem[536900241] + 12];
            val_7 = mem[536900241] + 12;
            if(val_7 == 0)
            {
                    if(((mem[536900336] & true) == 0) && (mem[536900265] == 0))
            {
                    val_6 = mem[536900241];
            }
            
                val_7 = 536875447;
                val_7 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_6, method:  new IntPtr(1610687591));
                mem2[0] = val_7;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription>(source:  this.m_Values, selector:  536875447);
            TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Type>(source:  this.m_Values);
            string val_4 = System.String.Join(separator:  -1610612505, value:  this.m_Values);
            return -1610612031(-1610612031) + -1610612505(-1610612505) + -1610612507(-1610612507);
        }
    
    }

}
