using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class OperationPower : IValue
    {
        // Fields
        private B83.ExpressionParserBigInteger.IValue m_Value;
        private B83.ExpressionParserBigInteger.IValue m_Power;
        
        // Properties
        public AFramework.BigInteger Value { get; }
        
        // Methods
        public AFramework.BigInteger get_Value()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            val_3 = 0;
            val_4 = 0;
            val_3 = val_3 + 1;
            val_4 = (uint)val_3 & 65535;
            val_5 = this.m_Value;
            val_4 = 0;
            val_3 = 0;
            val_4 = val_4 + 1;
            val_3 = (uint)val_4 & 65535;
            val_6 = this.m_Power;
            if((mem[536884224] & true) != 0)
            {
                    return AFramework.BigInteger.Pow(a:  this.m_Value, b:  this.m_Power);
            }
            
            if(mem[536884153] != 0)
            {
                    return AFramework.BigInteger.Pow(a:  this.m_Value, b:  this.m_Power);
            }
            
            return AFramework.BigInteger.Pow(a:  this.m_Value, b:  this.m_Power);
        }
        public OperationPower(B83.ExpressionParserBigInteger.IValue aValue, B83.ExpressionParserBigInteger.IValue aPower)
        {
            this.m_Value = aValue;
            this.m_Power = aPower;
        }
    
    }

}
