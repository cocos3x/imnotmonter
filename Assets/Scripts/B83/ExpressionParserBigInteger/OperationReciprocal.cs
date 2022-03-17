using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class OperationReciprocal : IValue
    {
        // Fields
        private B83.ExpressionParserBigInteger.IValue m_Value;
        
        // Properties
        public AFramework.BigInteger Value { get; }
        
        // Methods
        public AFramework.BigInteger get_Value()
        {
            bool val_3;
            var val_4;
            var val_5;
            val_3 = mem[536884224];
            if((val_3 & true) == 0)
            {
                    val_3 = mem[536884153];
            }
            
            AFramework.BigInteger val_1 = AFramework.BigInteger.op_Implicit(d:  null);
            var val_3 = 0;
            val_4 = 0;
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            val_5 = this.m_Value;
            return AFramework.BigInteger.op_Division(a:  val_3, b:  this.m_Value);
        }
        public OperationReciprocal(B83.ExpressionParserBigInteger.IValue aValue)
        {
            this.m_Value = aValue;
        }
    
    }

}
