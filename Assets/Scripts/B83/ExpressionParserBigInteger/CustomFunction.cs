using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class CustomFunction : IValue
    {
        // Fields
        private B83.ExpressionParserBigInteger.IValue[] m_Params;
        private System.Func<AFramework.BigInteger[], AFramework.BigInteger> m_Delegate;
        
        // Properties
        public AFramework.BigInteger Value { get; }
        
        // Methods
        public AFramework.BigInteger get_Value()
        {
            var val_4;
            object val_5;
            System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>> val_6;
            if(this.m_Params != null)
            {
                    val_4 = 536898391;
                if(((mem[536898578] & true) == 0) && (mem[536898507] == 0))
            {
                    val_4 = 536898391;
            }
            
                val_5 = mem[536898483];
                val_6 = mem[mem[536898483] + 4];
                val_6 = mem[536898483] + 4;
                if(val_6 == 0)
            {
                    if(((mem[536898578] & true) == 0) && (mem[536898507] == 0))
            {
                    val_5 = mem[536898483];
            }
            
                val_6 = 536875451;
                val_6 = new System.Func<System.Type, System.Collections.Generic.IEnumerable<System.Reflection.MethodInfo>>(object:  val_5, method:  new IntPtr(1610687455));
                mem2[0] = val_6;
            }
            
                System.Collections.Generic.IEnumerable<TResult> val_2 = System.Linq.Enumerable.Select<UnityEngine.Purchasing.ProductDefinition, UnityEngine.Purchasing.Default.WinProductDescription>(source:  this.m_Params, selector:  536875451);
                TSource[] val_3 = System.Linq.Enumerable.ToArray<System.Type>(source:  this.m_Params);
                if(this.m_Delegate != 0)
            {
                    return this.m_Delegate.Invoke(arg:  this.m_Params);
            }
            
                return this.m_Delegate.Invoke(arg:  this.m_Params);
            }
            
            if(this.m_Delegate != 0)
            {
                    return this.m_Delegate.Invoke(arg:  null);
            }
            
            return this.m_Delegate.Invoke(arg:  null);
        }
        public CustomFunction(string aName, System.Func<AFramework.BigInteger[], AFramework.BigInteger> aDelegate, B83.ExpressionParserBigInteger.IValue[] aValues)
        {
            this.m_Delegate = aDelegate;
            this.m_Params = aValues;
        }
    
    }

}
