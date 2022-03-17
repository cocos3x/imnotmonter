using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class Number : IValue
    {
        // Fields
        private AFramework.BigInteger m_Value;
        
        // Properties
        public AFramework.BigInteger Value { get; set; }
        
        // Methods
        public AFramework.BigInteger get_Value()
        {
        
        }
        public void set_Value(AFramework.BigInteger value)
        {
            this.m_Value = value;
        }
        public Number(AFramework.BigInteger aValue)
        {
            AFramework.BigInteger val_1 = aValue;
            val_1 = new System.Object();
            this.m_Value = val_1;
        }
    
    }

}
