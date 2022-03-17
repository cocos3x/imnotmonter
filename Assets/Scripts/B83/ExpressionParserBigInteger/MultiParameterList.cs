using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class MultiParameterList : IValue
    {
        // Fields
        private B83.ExpressionParserBigInteger.IValue[] m_Values;
        
        // Properties
        public B83.ExpressionParserBigInteger.IValue[] Parameters { get; }
        public AFramework.BigInteger Value { get; }
        
        // Methods
        public B83.ExpressionParserBigInteger.IValue[] get_Parameters()
        {
        
        }
        public AFramework.BigInteger get_Value()
        {
            var val_3;
            object val_4;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_5;
            val_3 = 536900085;
            if(((mem[536900272] & true) == 0) && (mem[536900201] == 0))
            {
                    val_3 = 536900085;
            }
            
            val_4 = mem[536900177];
            val_5 = mem[mem[536900177] + 4];
            val_5 = mem[536900177] + 4;
            if(val_5 == 0)
            {
                    if(((mem[536900272] & true) == 0) && (mem[536900201] == 0))
            {
                    val_4 = mem[536900177];
            }
            
                val_5 = 536875451;
                val_5 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_4, method:  new IntPtr(1610687445));
                mem2[0] = val_5;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription>(source:  this.m_Values, selector:  536875451);
            return System.Linq.Enumerable.FirstOrDefault<System.Object>(source:  this.m_Values);
        }
        public MultiParameterList(B83.ExpressionParserBigInteger.IValue[] aValues)
        {
            this.m_Values = aValues;
        }
    
    }

}
