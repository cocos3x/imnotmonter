using UnityEngine;

namespace B83.ExpressionParser
{
    public interface IValue
    {
        // Properties
        public abstract double Value { get; }
        
        // Methods
        public abstract double get_Value(); // 0
    
    }

}
