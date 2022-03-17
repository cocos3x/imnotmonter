using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class OperationProduct : IValue
    {
        // Fields
        private B83.ExpressionParserBigInteger.IValue[] m_Values;
        
        // Properties
        public AFramework.BigInteger Value { get; }
        
        // Methods
        public AFramework.BigInteger get_Value()
        {
            var val_4;
            object val_5;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_6;
            object val_7;
            var val_8;
            object val_9;
            System.Func<System.String, System.String, System.String> val_10;
            val_4 = 536900153;
            if(((mem[536900340] & true) == 0) && (mem[536900269] == 0))
            {
                    val_4 = 536900153;
            }
            
            val_5 = mem[536900245];
            val_6 = mem[mem[536900245] + 4];
            val_6 = mem[536900245] + 4;
            if(val_6 == 0)
            {
                    if(((mem[536900340] & true) == 0) && (mem[536900269] == 0))
            {
                    val_5 = mem[536900245];
            }
            
                val_7 = mem[mem[536900245]];
                val_7 = val_5;
                val_6 = 536875451;
                val_6 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_7, method:  new IntPtr(1610687419));
                mem2[0] = val_6;
            }
            
            System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription>(source:  this.m_Values, selector:  536875451);
            val_8 = 536900153;
            if(((mem[536900340] & true) == 0) && (mem[536900269] == 0))
            {
                    val_8 = 536900153;
            }
            
            val_9 = mem[536900245];
            val_10 = mem[mem[536900245] + 8];
            val_10 = mem[536900245] + 8;
            if(val_10 != 0)
            {
                    return System.Linq.Enumerable.Aggregate<System.String>(source:  this.m_Values, func:  536875619);
            }
            
            if(((mem[536900340] & true) == 0) && (mem[536900269] == 0))
            {
                    val_9 = mem[536900245];
            }
            
            val_7 = mem[mem[536900245]];
            val_7 = val_9;
            val_10 = 536875619;
            val_10 = new System.Func<System.String, System.String, System.String>(object:  val_7, method:  new IntPtr(1610687421));
            mem2[0] = val_10;
            return System.Linq.Enumerable.Aggregate<System.String>(source:  this.m_Values, func:  536875619);
        }
        public OperationProduct(B83.ExpressionParserBigInteger.IValue[] aValues)
        {
            this.m_Values = aValues;
        }
    
    }

}
