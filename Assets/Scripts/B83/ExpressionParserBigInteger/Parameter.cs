using UnityEngine;

namespace B83.ExpressionParserBigInteger
{
    public class Parameter : Number
    {
        // Fields
        private string <Name>k__BackingField;
        
        // Properties
        public string Name { get; set; }
        
        // Methods
        public string get_Name()
        {
        
        }
        private void set_Name(string value)
        {
            this.<Name>k__BackingField = value;
        }
        public Parameter(string aName)
        {
            string val_2 = aName;
            AFramework.BigInteger val_1 = AFramework.BigInteger.op_Implicit(i:  0);
            val_2 = new System.Object();
            mem[1152921510093149752] = 0;
            this.<Name>k__BackingField = val_2;
        }
    
    }

}
