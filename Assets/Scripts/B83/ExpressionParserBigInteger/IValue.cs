using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public interface IValue
    {
        // Properties
        public abstract AFramework.BigInteger Value { get; }
        
        // Methods
        public abstract AFramework.BigInteger get_Value(); // 0
    
    }

}
