using UnityEngine;

namespace B83.ExpressionParser
{
    public class MultiParameterList : IValue
    {
        // Fields
        private B83.ExpressionParser.IValue[] m_Values;
        
        // Properties
        public B83.ExpressionParser.IValue[] Parameters { get; }
        public double Value { get; }
        
        // Methods
        public B83.ExpressionParser.IValue[] get_Parameters()
        {
        
        }
        public double get_Value()
        {
            var val_3;
            object val_4;
            System.Func<System.Object, System.Double> val_5;
            val_3 = 536900081;
            if(((mem[536900268] & true) == 0) && (mem[536900197] == 0))
            {
                    val_3 = 536900081;
            }
            
            val_4 = mem[536900173];
            val_5 = mem[mem[536900173] + 4];
            val_5 = mem[536900173] + 4;
            if(val_5 == 0)
            {
                    if(((mem[536900268] & true) == 0) && (mem[536900197] == 0))
            {
                    val_4 = mem[536900173];
            }
            
                val_5 = 536875443;
                val_5 = new System.Func<System.Object, System.Double>(object:  val_4, method:  new IntPtr(1610687623));
                mem2[0] = val_5;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<System.Object, System.Double>(source:  this.m_Values, selector:  536875443);
            return System.Linq.Enumerable.FirstOrDefault<System.Double>(source:  this.m_Values);
        }
        public MultiParameterList(B83.ExpressionParser.IValue[] aValues)
        {
            this.m_Values = aValues;
        }
        public override string ToString()
        {
            var val_4;
            object val_5;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_6;
            val_4 = 536900081;
            if(((mem[536900268] & true) == 0) && (mem[536900197] == 0))
            {
                    val_4 = 536900081;
            }
            
            val_5 = mem[536900173];
            val_6 = mem[mem[536900173] + 8];
            val_6 = mem[536900173] + 8;
            if(val_6 == 0)
            {
                    if(((mem[536900268] & true) == 0) && (mem[536900197] == 0))
            {
                    val_5 = mem[536900173];
            }
            
                val_6 = 536875447;
                val_6 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_5, method:  new IntPtr(1610687625));
                mem2[0] = val_6;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription>(source:  this.m_Values, selector:  536875447);
            TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Type>(source:  this.m_Values);
            return System.String.Join(separator:  -1610611907, value:  this.m_Values);
        }
    
    }

}
