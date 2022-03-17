using UnityEngine;

namespace B83.ExpressionParser
{
    public class Number : IValue
    {
        // Fields
        private double m_Value;
        
        // Properties
        public double Value { get; set; }
        
        // Methods
        public double get_Value()
        {
            return (double)D0;
        }
        public void set_Value(double value)
        {
            this.m_Value = ;
            mem[1152921510100146076] = R3;
        }
        public Number(double aValue)
        {
            this.m_Value = R2;
            mem[1152921510100258076] = R3;
        }
        public override string ToString()
        {
            string val_1 = this.m_Value.ToString();
            if(this.m_Value == 0)
            {
                    this.m_Value = -1610612735;
            }
        
        }
    
    }

}
