using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONNode
    {
        // Properties
        public virtual com.adjust.sdk.JSONNode Item { get; set; }
        public virtual com.adjust.sdk.JSONNode Item { get; set; }
        public virtual string Value { get; set; }
        public virtual int Count { get; }
        public virtual System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        public System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> DeepChilds { get; }
        public virtual int AsInt { get; set; }
        public virtual float AsFloat { get; set; }
        public virtual double AsDouble { get; set; }
        public virtual bool AsBool { get; set; }
        public virtual com.adjust.sdk.JSONArray AsArray { get; }
        public virtual com.adjust.sdk.JSONClass AsObject { get; }
        
        // Methods
        public virtual void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
        
        }
        public virtual void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode get_Item(string aKey)
        {
        
        }
        public virtual void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
        
        }
        public virtual string get_Value()
        {
        
        }
        public virtual void set_Value(string value)
        {
        
        }
        public virtual int get_Count()
        {
            return 0;
        }
        public virtual void Add(com.adjust.sdk.JSONNode aItem)
        {
            goto typeof(com.adjust.sdk.JSONNode).__il2cppRuntimeField_DC;
        }
        public virtual com.adjust.sdk.JSONNode Remove(string aKey)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode Remove(int aIndex)
        {
        
        }
        public virtual com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
        
        }
        public virtual System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            536899465 = new JSONNode.<get_Childs>d__17(<>1__state:  1);
        }
        public System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_DeepChilds()
        {
            536899467 = new JSONNode.<get_DeepChilds>d__19(<>1__state:  1);
            mem[536899487] = this;
        }
        public override string ToString()
        {
        
        }
        public virtual string ToString(string aPrefix)
        {
        
        }
        public virtual int get_AsInt()
        {
            bool val_2 = System.Int32.TryParse(s:  1436922512, result: out  int val_1 = 1436910500);
            if(val_2 == true)
            {
                    val_2 = 0;
            }
            
            return (int)val_2;
        }
        public virtual void set_AsInt(int value)
        {
            string val_1 = value.ToString();
        }
        public virtual float get_AsFloat()
        {
            if((System.Single.TryParse(s:  1437146512, result: out  float val_1 = 2.321786E+13f)) == true)
            {
                    0f = 0;
            }
            
            return (float)0f;
        }
        public virtual void set_AsFloat(float value)
        {
            string val_1 = ???.ToString();
        }
        public virtual double get_AsDouble()
        {
            bool val_2 = System.Double.TryParse(s:  1437370512, result: out  double val_1 = 7.10149449679118E-315);
            return (double)D0;
        }
        public virtual void set_AsDouble(double value)
        {
            string val_1 = ToString();
        }
        public virtual bool get_AsBool()
        {
            var val_4;
            if((System.Boolean.TryParse(value:  1437594512, result: out  bool val_1 = true)) != false)
            {
                    if(0 != 0)
            {
                    val_4 = 1;
            }
            
                return (bool)val_4;
            }
            
            val_4 = (System.String.IsNullOrEmpty(value:  1437594512)) ^ 1;
            return (bool)val_4;
        }
        public virtual void set_AsBool(bool value)
        {
            if(value == true)
            {
                    22801204 = 22807012;
            }
            
            if(this == 0)
            {
                
            }
        
        }
        public virtual com.adjust.sdk.JSONArray get_AsArray()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(((com.adjust.sdk.JSONNode.__il2cppRuntimeField_typeHierarchy + (mem[536889491]) << 2) + -4) != 536889311)
            {
                    this = 0;
            }
        
        }
        public virtual com.adjust.sdk.JSONClass get_AsObject()
        {
            if(this == 0)
            {
                    return;
            }
            
            if(((com.adjust.sdk.JSONNode.__il2cppRuntimeField_typeHierarchy + (mem[536889499]) << 2) + -4) != 536889319)
            {
                    this = 0;
            }
        
        }
        public static com.adjust.sdk.JSONNode op_Implicit(string s)
        {
            536889323 = new System.Object();
            mem[536889331] = s;
        }
        public static string op_Implicit(com.adjust.sdk.JSONNode d)
        {
            if((com.adjust.sdk.JSONNode.op_Equality(a:  d, b:  0)) != false)
            {
                    return;
            }
            
            if(d == 0)
            {
                
            }
        
        }
        public static bool op_Equality(com.adjust.sdk.JSONNode a, object b)
        {
            if(b == 0)
            {
                goto label_1;
            }
            
            label_4:
            com.adjust.sdk.JSONNode val_1 = a - b;
            val_1 = val_1 >> 5;
            return (bool)val_1;
            label_1:
            if(a == 0)
            {
                goto label_4;
            }
            
            return true;
        }
        public static bool op_Inequality(com.adjust.sdk.JSONNode a, object b)
        {
            bool val_1 = com.adjust.sdk.JSONNode.op_Equality(a:  a, b:  b);
            val_1 = val_1 ^ 1;
            return (bool)val_1;
        }
        public override bool Equals(object obj)
        {
            this = this - obj;
            this = this >> 5;
            return (bool)this;
        }
        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
        internal static string Escape(string aText)
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 0;
            val_7 = -1610612735;
            goto label_1;
            label_13:
            char val_1 = aText.Chars[0];
            char val_2 = val_1 - 8;
            if(val_2 > '')
            {
                goto label_2;
            }
            
            var val_3 = 18208168 + (18208168 + ((val_1 - 8)) << 2);
            if(val_2 == '')
            {
                    18208168 = 17945608;
                18208168 = 18208168 & (aText >> 17945608);
                18208168 = 18208168 & ((((18208168 & ((int)aText) >> 18208168)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((18208168 & ((int)aText) >> 18208168)) << as. 
                
            
            
            
            
            
               
            ));
                18208168 = 18208168 & (18208168 >> 32);
                18208168 = 18208168 & (((22797836) << (32-as. 
                
            
            
            
            
            
               
            )) | ((22797836) << as. 
                
            
            
            
            
            
               
            ));
                18208168 = 18208168 & (((((((18208168 & ((int)aText) >> 18208168) & (((18208168 & ((int)aText) >> 18208168)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((18208168 & ((int)aText) >> 18208168)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((18208168 ) << (32-((((18208168 & ((int)aText) >> 18208168) & (((18208168 & ((int)aText) >> 18208168)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((18208168 & ((int)aText) >> 18208168)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((18208168 )) | ((((((18208168 & ((int)aText) >> 18208168) & (((18208168 & ((int)aText) >> 18208168)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((18208168 & ((int)aText) >> 18208168)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((18208168 ) << ((((18208168 & ((int)aText) >> 18208168) & (((18208168 & ((int)aText) >> 18208168)) << (32-as. 
                
            
            
            
            
            
               
            )) | (((18208168 & ((int)aText) >> 18208168)) << as. 
                
            
            
            
            
            
               
            )) & ((int)((18208168 ));
            }
            
            val_8 = 22797820;
            goto label_8;
            label_2:
            if(val_1 == '"')
            {
                goto label_4;
            }
            
            if(val_1 != '\')
            {
                goto label_5;
            }
            
            val_8 = 22797808;
            goto label_8;
            label_5:
            string val_4 = val_1.ToString();
            val_9 = ;
            goto label_11;
            label_4:
            val_8 = 22797804;
            label_8:
            label_11:
            string val_5 = -1610612735(-1610612735) + -1610602263(-1610602263);
            val_6 = 1;
            val_7 = val_7;
            label_1:
            if(val_6 < aText.m_stringLength)
            {
                goto label_13;
            }
        
        }
        public static com.adjust.sdk.JSONNode Parse(string aJSON)
        {
            var val_37;
            System.Collections.Generic.Stack<DG.Tweening.Tween> val_38;
            var val_39;
            float val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            val_37 = 0;
            val_38 = 536879619;
            val_38 = new System.Collections.Generic.Stack<DG.Tweening.Tween>();
            val_39 = 0;
            val_40 = 4.032453E-38f;
            val_41 = -1610612735;
            val_42 = val_41;
            goto label_1;
            label_78:
            char val_2 = aJSON.Chars[0];
            if(val_2 > ',')
            {
                goto label_2;
            }
            
            if(val_2 > ' ')
            {
                goto label_3;
            }
            
            if(val_2 > '')
            {
                goto label_4;
            }
            
            if(val_2 == '	')
            {
                goto label_5;
            }
            
            if(val_2 == '
            ')
            {
                goto label_76;
            }
            
            goto label_42;
            label_2:
            if(val_2 > ']')
            {
                goto label_8;
            }
            
            if(val_2 > '[')
            {
                goto label_9;
            }
            
            if(val_2 == (':'))
            {
                goto label_10;
            }
            
            if(val_2 != '[')
            {
                goto label_42;
            }
            
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            com.adjust.sdk.JSONArray val_3 = 536889311;
            val_43 = val_3;
            val_3 = new com.adjust.sdk.JSONArray();
            goto label_13;
            label_3:
            if(val_2 == '"')
            {
                goto label_14;
            }
            
            if(val_2 != ',')
            {
                goto label_42;
            }
            
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            if((System.String.op_Inequality(a:  -1610612735, b:  -1610612735)) == false)
            {
                goto label_23;
            }
            
            if((0 == 0) || (mem[1179403827] < mem[536889491]))
            {
                goto label_19;
            }
            
            var val_37 = mem[1179403747];
            val_37 = val_37 + (mem[536889491] << 2);
            if(((mem[1179403747] + (mem[536889491]) << 2) + -4) == 536889311)
            {
                goto label_20;
            }
            
            label_19:
            if((System.String.op_Inequality(a:  -1610612735, b:  -1610612735)) == false)
            {
                goto label_23;
            }
            
            com.adjust.sdk.JSONNode val_6 = com.adjust.sdk.JSONNode.op_Implicit(s:  -1610612735);
            val_40 = val_40;
            val_38 = 1.085328E-19f;
            goto label_23;
            label_8:
            if(val_2 == '}')
            {
                goto label_24;
            }
            
            if(val_2 != '{')
            {
                goto label_42;
            }
            
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            com.adjust.sdk.JSONClass val_7 = 536889319;
            val_43 = val_7;
            val_7 = new com.adjust.sdk.JSONClass();
            label_13:
            val_38.Push(item:  536889319);
            if((com.adjust.sdk.JSONNode.op_Equality(a:  0, b:  0)) == true)
            {
                goto label_36;
            }
            
            string val_9 = val_41.Trim();
            if((0 == 0) || (mem[1179403827] < mem[536889491]))
            {
                goto label_31;
            }
            
            var val_38 = mem[1179403747];
            val_38 = val_38 + (mem[536889491] << 2);
            if(((mem[1179403747] + (mem[536889491]) << 2) + -4) == 536889311)
            {
                goto label_32;
            }
            
            label_31:
            if((System.String.op_Inequality(a:  -1610612735, b:  -1610612735)) == false)
            {
                goto label_36;
            }
            
            object val_11 = val_38.Peek();
            if(0 != 0)
            {
                goto label_36;
            }
            
            goto label_36;
            label_4:
            if(val_2 == '')
            {
                goto label_76;
            }
            
            if(val_2 != ' ')
            {
                goto label_42;
            }
            
            label_5:
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            val_37 = 0;
            goto label_76;
            label_9:
            if(val_2 == '\')
            {
                goto label_41;
            }
            
            if(val_2 != ']')
            {
                goto label_42;
            }
            
            label_24:
            if(val_37 != 1)
            {
                goto label_43;
            }
            
            if(mem[536879631] == 0)
            {
                goto label_79;
            }
            
            DG.Tweening.Tween val_12 = val_38.Pop();
            if((System.String.op_Inequality(a:  -1610612735, b:  -1610612735)) == false)
            {
                goto label_53;
            }
            
            string val_14 = val_41.Trim();
            if((0 == 0) || (mem[1179403827] < mem[536889491]))
            {
                goto label_49;
            }
            
            var val_39 = mem[1179403747];
            val_39 = val_39 + (mem[536889491] << 2);
            if(((mem[1179403747] + (mem[536889491]) << 2) + -4) == 536889311)
            {
                goto label_50;
            }
            
            label_49:
            if((System.String.op_Inequality(a:  -1610612735, b:  -1610612735)) == false)
            {
                goto label_53;
            }
            
            com.adjust.sdk.JSONNode val_16 = com.adjust.sdk.JSONNode.op_Implicit(s:  -1610612735);
            val_40 = val_40;
            val_38 = 1.085328E-19f;
            goto label_53;
            label_42:
            string val_18 = aJSON.Chars[0].ToString();
            string val_19 = -1610612735(-1610612735) + 1438884106;
            label_63:
            val_42 = val_42;
            goto label_76;
            label_14:
            val_37 = 1;
            goto label_76;
            label_10:
            if((val_37 & 1) != 0)
            {
                goto label_63;
            }
            
            label_43:
            string val_21 = aJSON.Chars[0].ToString();
            string val_22 = -1610612735(-1610612735) + 1438884106;
            val_42 = val_42;
            val_37 = 1;
            goto label_76;
            label_41:
            if((val_37 & 1) != 0)
            {
                goto label_58;
            }
            
            char val_23 = aJSON.Chars[1];
            if(val_23 > 'f')
            {
                goto label_59;
            }
            
            if(val_23 == 'b')
            {
                goto label_60;
            }
            
            if(val_23 != 'f')
            {
                goto label_65;
            }
            
            val_44 = 22777180;
            goto label_74;
            label_58:
            val_37 = 0;
            goto label_64;
            label_59:
            val_23 = val_23 - 110;
            if(val_23 > '')
            {
                goto label_65;
            }
            
            var val_24 = 18199760 + (18199760 + ((val_23 - 110)) << 2);
            if(val_23 == '')
            {
                    18199760 + ((val_23 - 110)) << 2 = (18199760 + ((val_23 - 110)) << 2) & ((18199760 + ((val_23 - 110)) << 2) >> 32);
                18199760 + ((val_23 - 110)) << 2 = (18199760 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                18199760 + ((val_23 - 110)) << 2 = (18199760 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                18199760 + ((val_23 - 110)) << 2 = (18199760 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                18199760 + ((val_23 - 110)) << 2 = (18199760 + ((val_23 - 110)) << 2) & ((IP) << 2);
                18199760 + ((val_23 - 110)) << 2 = (18199760 + ((val_23 - 110)) << 2) & ((IP) >> 32);
                18199760 + ((val_23 - 110)) << 2 = (18199760 + ((val_23 - 110)) << 2) & ((18199760 + ((val_23 - 110)) << 2) << 2);
                18199760 + ((val_23 - 110)) << 2 = (18199760 + ((val_23 - 110)) << 2) & ((IP) >> 18199760);
            }
            
            val_44 = 22776980;
            goto label_74;
            label_65:
            string val_25 = val_23.ToString();
            val_45;
            goto label_67;
            label_60:
            val_44 = 22776956;
            goto label_74;
            label_32:
            object val_26 = val_38.Peek();
            label_36:
            val_41 = -1610612735;
            object val_27 = val_38.Peek();
            goto label_71;
            label_50:
            com.adjust.sdk.JSONNode val_28 = com.adjust.sdk.JSONNode.op_Implicit(s:  -1610612735);
            label_53:
            val_37 = 0;
            val_41 = -1610612735;
            if(mem[536879631] < 1)
            {
                goto label_73;
            }
            
            object val_29 = val_38.Peek();
            goto label_73;
            label_74:
            label_67:
            string val_30 = -1610612735(-1610612735) + -1610612583(-1610612583);
            val_42 = val_42;
            val_37 = 1;
            label_64:
            val_46 = val_40;
            val_40 = 4.032453E-38f;
            goto label_76;
            label_20:
            com.adjust.sdk.JSONNode val_35 = com.adjust.sdk.JSONNode.op_Implicit(s:  -1610612735);
            label_23:
            val_41 = -1610612735;
            label_71:
            val_37 = 0;
            label_73:
            val_42 = val_41;
            label_76:
            val_39 = val_39 + 1;
            label_1:
            if(val_39 < aJSON.m_stringLength)
            {
                goto label_78;
            }
            
            if((val_37 & 1) != 0)
            {
                    aJSON.m_stringLength = val_38;
                return;
            }
            
            label_79:
            22710780 = new System.Exception(message:  22788696);
            goto label_79;
        }
        public virtual void Serialize(System.IO.BinaryWriter aWriter)
        {
        
        }
        public void SaveToStream(System.IO.Stream aData)
        {
            536884139 = new System.IO.BinaryWriter(output:  aData);
            goto typeof(com.adjust.sdk.JSONNode).__il2cppRuntimeField_19C;
        }
        public void SaveToCompressedStream(System.IO.Stream aData)
        {
            22710780 = new System.Exception(message:  22783076);
        }
        public void SaveToCompressedFile(string aFileName)
        {
            22710780 = new System.Exception(message:  22783076);
        }
        public string SaveToCompressedBase64()
        {
            22710780 = new System.Exception(message:  22783076);
        }
        public static com.adjust.sdk.JSONNode Deserialize(System.IO.BinaryReader aReader)
        {
            var val_11;
            var val_12;
            System.IO.BinaryReader val_11 = aReader;
            val_11 = val_11 - 1;
            if(val_11 <= 6)
            {
                    var val_1 = 18217264 + (18217264 + ((aReader - 1)) << 2);
                if(val_11 == 6)
            {
                    18217264 + ((aReader - 1)) << 2 = (18217264 + ((aReader - 1)) << 2) & ((IP) << 18217264 + ((aReader - 1)) << 2);
                18217264 + ((aReader - 1)) << 2 = (18217264 + ((aReader - 1)) << 2) & (((aReader) << (32-18217264)) | ((aReader) << 18217264));
                18217264 + ((aReader - 1)) << 2 = (18217264 + ((aReader - 1)) << 2) & (((IP) << (32-1)) | ((IP) << 1));
                18217264 + ((aReader - 1)) << 2 = (18217264 + ((aReader - 1)) << 2) & 22999744;
                18217264 + ((aReader - 1)) << 2 = (18217264 + ((aReader - 1)) << 2) * (18217264 + ((aReader - 1)) << 2);
                18217264 + ((aReader - 1)) << 2 = (18217264 + ((aReader - 1)) << 2) & (aReader << 4);
                18217264 + ((aReader - 1)) << 2 = (18217264 + ((aReader - 1)) << 2) & (((int)IP) >> 4);
            }
            
                val_11 = aReader;
                com.adjust.sdk.JSONArray val_2 = 536889311;
                val_12 = val_2;
                val_2 = new com.adjust.sdk.JSONArray();
                if(val_11 < 1)
            {
                    return;
            }
            
                do
            {
                val_11 = val_11 - 1;
            }
            while(val_12 != 0);
            
                return;
            }
            
            string val_9 = 22785440 + 22712600;
            22710780 = new System.Exception(message:  22785440);
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedFile(string aFileName)
        {
            22710780 = new System.Exception(message:  22783076);
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedStream(System.IO.Stream aData)
        {
            22710780 = new System.Exception(message:  22783076);
        }
        public static com.adjust.sdk.JSONNode LoadFromCompressedBase64(string aBase64)
        {
            22710780 = new System.Exception(message:  22783076);
        }
        public static com.adjust.sdk.JSONNode LoadFromStream(System.IO.Stream aData)
        {
            System.IO.Stream val_4;
            var val_5;
            val_4 = aData;
            System.IO.BinaryReader val_1 = 536884129;
            val_1 = new System.IO.BinaryReader(input:  val_4);
            com.adjust.sdk.JSONNode val_2 = com.adjust.sdk.JSONNode.Deserialize(aReader:  536884129);
            if(val_1 == 0)
            {
                goto label_1;
            }
            
            var val_5 = mem[536884129];
            if((mem[536884129] + 178) == 0)
            {
                goto label_2;
            }
            
            val_4 = 0;
            label_4:
            if((mem[536884129] + 88 + 0) == 536888187)
            {
                goto label_3;
            }
            
            val_4 = val_4 + 1;
            if(((uint)val_4 & 65535) < (mem[536884129] + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_5 = val_1;
            goto label_5;
            label_3:
            var val_3 = (mem[536884129] + 88) + 0;
            val_5 = val_5 + (((mem[536884129] + 88 + 0) + 4) << 3);
            val_5 = val_5 + 188;
            label_5:
            label_1:
            if(1 == 0)
            {
                    return;
            }
            
            var val_4 = 1 - 1;
        }
        public static com.adjust.sdk.JSONNode LoadFromBase64(string aBase64)
        {
            System.Byte[] val_1 = System.Convert.FromBase64String(s:  aBase64);
            System.IO.MemoryStream val_2 = 536890411;
            val_2 = new System.IO.MemoryStream(buffer:  aBase64);
            if(val_2 != 0)
            {
                    return com.adjust.sdk.JSONNode.LoadFromStream(aData:  536890411);
            }
            
            return com.adjust.sdk.JSONNode.LoadFromStream(aData:  536890411);
        }
        public JSONNode()
        {
        
        }
    
    }

}
