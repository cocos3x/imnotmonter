using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONData : JSONNode
    {
        // Fields
        private string m_Data;
        
        // Properties
        public override string Value { get; set; }
        
        // Methods
        public override string get_Value()
        {
        
        }
        public override void set_Value(string value)
        {
            this.m_Data = value;
        }
        public JSONData(string aData)
        {
            string val_1 = aData;
            val_1 = new System.Object();
            this.m_Data = val_1;
        }
        public JSONData(float aData)
        {
            this = new System.Object();
            this.AsFloat = aData;
        }
        public JSONData(double aData)
        {
            object val_1 = this;
            val_1 = new System.Object();
            val_1.AsDouble = aData;
        }
        public JSONData(bool aData)
        {
            this = new System.Object();
            this.AsBool = aData;
        }
        public JSONData(int aData)
        {
            this = new System.Object();
            this.AsInt = aData;
        }
        public override string ToString()
        {
            string val_1 = com.adjust.sdk.JSONNode.Escape(aText:  this.m_Data);
            return -1610612241(-1610612241) + this.m_Data + -1610612241(-1610612241);
        }
        public override string ToString(string aPrefix)
        {
            string val_1 = com.adjust.sdk.JSONNode.Escape(aText:  this.m_Data);
            return -1610612241(-1610612241) + this.m_Data + -1610612241(-1610612241);
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_13;
            var val_14;
            object val_15;
            var val_16;
            val_13 = this;
            val_14 = aWriter;
            val_15 = 536889323;
            val_15 = new System.Object();
            mem[536889331] = -1610612735;
            int val_2 = val_13.AsInt;
            if((System.String.op_Equality(a:  -1610612735, b:  this.m_Data)) == false)
            {
                goto label_3;
            }
            
            val_16 = val_13.AsInt;
            if(val_14 != 0)
            {
                goto typeof(System.IO.BinaryWriter).__il2cppRuntimeField_15C;
            }
            
            goto typeof(System.IO.BinaryWriter).__il2cppRuntimeField_15C;
            label_3:
            float val_5 = val_13.AsFloat;
            if((System.String.op_Equality(a:  -1610612735, b:  this.m_Data)) != false)
            {
                    float val_7 = val_13.AsFloat;
                val_16 = val_13;
            }
            else
            {
                    if((System.String.op_Equality(a:  R6 + 8, b:  R5 + 8)) != false)
            {
                    var val_9 = FP - 24;
                return;
            }
            
                if((System.String.op_Equality(a:  R6 + 8, b:  R5 + 8)) != false)
            {
                
            }
            
            }
        
        }
    
    }

}
