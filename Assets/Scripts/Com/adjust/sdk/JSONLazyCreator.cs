using UnityEngine;

namespace com.adjust.sdk
{
    internal class JSONLazyCreator : JSONNode
    {
        // Fields
        private com.adjust.sdk.JSONNode m_Node;
        private string m_Key;
        
        // Properties
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override int AsInt { get; set; }
        public override float AsFloat { get; set; }
        public override double AsDouble { get; set; }
        public override bool AsBool { get; set; }
        public override com.adjust.sdk.JSONArray AsArray { get; }
        public override com.adjust.sdk.JSONClass AsObject { get; }
        
        // Methods
        public JSONLazyCreator(com.adjust.sdk.JSONNode aNode)
        {
            com.adjust.sdk.JSONNode val_1 = aNode;
            val_1 = new System.Object();
            this.m_Node = val_1;
            this.m_Key = 0;
        }
        public JSONLazyCreator(com.adjust.sdk.JSONNode aNode, string aKey)
        {
            val_1 = new System.Object();
            this.m_Node = aNode;
            this.m_Key = val_1;
        }
        private void Set(com.adjust.sdk.JSONNode aVal)
        {
            if(this.m_Key != null)
            {
                    if(this.m_Node != 0)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            this.m_Node = 0;
        }
        public override com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            536889325 = new com.adjust.sdk.JSONLazyCreator(aNode:  1449728400);
        }
        public override void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
            536889311 = new com.adjust.sdk.JSONArray();
            this.Set(aVal:  536889311);
        }
        public override com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            536889325 = new com.adjust.sdk.JSONLazyCreator(aNode:  1449964688, aKey:  aKey);
        }
        public override void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
            536889319 = new com.adjust.sdk.JSONClass();
            this.Set(aVal:  536889319);
        }
        public override void Add(com.adjust.sdk.JSONNode aItem)
        {
            536889311 = new com.adjust.sdk.JSONArray();
            this.Set(aVal:  536889311);
        }
        public override void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
            536889319 = new com.adjust.sdk.JSONClass();
            this.Set(aVal:  536889319);
        }
        public static bool op_Equality(com.adjust.sdk.JSONLazyCreator a, object b)
        {
            a = a - b;
            b = b >> 5;
            a = a >> 5;
            a = b | a;
            return (bool)a;
        }
        public static bool op_Inequality(com.adjust.sdk.JSONLazyCreator a, object b)
        {
            a = a - b;
            if()
            {
                    a = 1;
            }
            
            if(b != 0)
            {
                    b = 1;
            }
            
            return true;
        }
        public override bool Equals(object obj)
        {
            this = this - obj;
            obj = obj >> 5;
            this = this >> 5;
            this = obj | this;
            return (bool)this;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        public override string ToString()
        {
        
        }
        public override string ToString(string aPrefix)
        {
        
        }
        public override int get_AsInt()
        {
            536889323 = new System.Object();
            this.Set(aVal:  536889323);
            return 0;
        }
        public override void set_AsInt(int value)
        {
            536889323 = new System.Object();
            this.Set(aVal:  536889323);
        }
        public override float get_AsFloat()
        {
            536889323 = new System.Object();
            this.Set(aVal:  536889323);
            return (float)S0;
        }
        public override void set_AsFloat(float value)
        {
            536889323 = new System.Object();
            this.Set(aVal:  536889323);
        }
        public override double get_AsDouble()
        {
            536889323 = new System.Object();
            this.Set(aVal:  536889323);
            return (double)D0;
        }
        public override void set_AsDouble(double value)
        {
            536889323 = new System.Object();
            this.Set(aVal:  536889323);
        }
        public override bool get_AsBool()
        {
            536889323 = new System.Object();
            this.Set(aVal:  536889323);
            return false;
        }
        public override void set_AsBool(bool value)
        {
            536889323 = new System.Object();
            this.Set(aVal:  536889323);
        }
        public override com.adjust.sdk.JSONArray get_AsArray()
        {
            536889311 = new com.adjust.sdk.JSONArray();
            this.Set(aVal:  536889311);
        }
        public override com.adjust.sdk.JSONClass get_AsObject()
        {
            536889319 = new com.adjust.sdk.JSONClass();
            this.Set(aVal:  536889319);
        }
    
    }

}
