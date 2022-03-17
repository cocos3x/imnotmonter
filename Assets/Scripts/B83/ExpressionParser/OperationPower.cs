using UnityEngine;

namespace B83.ExpressionParser
{
    public class OperationPower : IValue
    {
        // Fields
        private B83.ExpressionParser.IValue m_Value;
        private B83.ExpressionParser.IValue m_Power;
        
        // Properties
        public double Value { get; }
        
        // Methods
        public double get_Value()
        {
            var val_4;
            var val_5;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = this.m_Value;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = this.m_Power;
            return (double)System.Math.Pow(x:  null, y:  null);
        }
        public OperationPower(B83.ExpressionParser.IValue aValue, B83.ExpressionParser.IValue aPower)
        {
            this.m_Value = aValue;
            this.m_Power = aPower;
        }
        public override string ToString()
        {
            var val_1;
            var val_2;
            var val_3;
            var val_4;
            mem[536882417] = -1610612031;
            val_1 = 0;
            if(this.m_Value == 0)
            {
                goto label_5;
            }
            
            val_2 = this.m_Value;
            if(this.m_Value == 0)
            {
                goto label_8;
            }
            
            val_1 = val_2;
            goto label_8;
            label_5:
            val_2 = 0;
            label_8:
            mem[536882421] = val_1;
            mem[536882425] = -1610602189;
            val_3 = 0;
            if(this.m_Power == 0)
            {
                goto label_13;
            }
            
            val_4 = this.m_Power;
            if(this.m_Power == 0)
            {
                goto label_16;
            }
            
            val_3 = val_4;
            goto label_16;
            label_13:
            val_4 = 0;
            label_16:
            mem[536882429] = val_3;
            mem[536882433] = -1610612507;
            return +536882401;
        }
    
    }

}
