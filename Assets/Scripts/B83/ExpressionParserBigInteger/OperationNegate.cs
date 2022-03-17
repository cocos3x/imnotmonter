using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class OperationNegate : IValue
    {
        // Fields
        private B83.ExpressionParserBigInteger.IValue m_Value;
        
        // Properties
        public AFramework.BigInteger Value { get; }
        
        // Methods
        public AFramework.BigInteger get_Value()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.m_Value;
            if((mem[536884224] & true) != 0)
            {
                    return AFramework.BigInteger.op_UnaryNegation(a:  this.m_Value);
            }
            
            if(mem[536884153] != 0)
            {
                    return AFramework.BigInteger.op_UnaryNegation(a:  this.m_Value);
            }
            
            return AFramework.BigInteger.op_UnaryNegation(a:  this.m_Value);
        }
        public OperationNegate(B83.ExpressionParserBigInteger.IValue aValue)
        {
            this.m_Value = aValue;
        }
    
    }

}
