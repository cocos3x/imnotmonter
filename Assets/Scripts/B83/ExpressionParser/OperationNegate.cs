using UnityEngine;

namespace B83.ExpressionParser
{
    public class OperationNegate : IValue
    {
        // Fields
        private B83.ExpressionParser.IValue m_Value;
        
        // Properties
        public double Value { get; }
        
        // Methods
        public double get_Value()
        {
            var val_1;
            var val_1 = 0;
            val_1 = val_1 + 1;
            val_1 = this.m_Value;
            return (double)D0;
        }
        public OperationNegate(B83.ExpressionParser.IValue aValue)
        {
            this.m_Value = aValue;
        }
        public override string ToString()
        {
            var val_1;
            if(this.m_Value != 0)
            {
                    val_1 = this.m_Value;
                return -1610612029(-1610612029) + null + -1610612507(-1610612507);
            }
            
            val_1 = 0;
            return -1610612029(-1610612029) + null + -1610612507(-1610612507);
        }
    
    }

}
