using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONClass : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, com.adjust.sdk.JSONNode> m_Dict;
        
        // Properties
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        
        // Methods
        public override com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    if(this.m_Dict != 0)
            {
                    return this.m_Dict.Item[aKey];
            }
            
                return this.m_Dict.Item[aKey];
            }
            
            536889325 = new com.adjust.sdk.JSONLazyCreator(aNode:  1446195088, aKey:  aKey);
        }
        public override void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    this.m_Dict.set_Item(key:  aKey, value:  value);
                return;
            }
            
            this.m_Dict.Add(key:  aKey, value:  value);
        }
        public override com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            var val_3;
            if(aIndex < 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= aIndex)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  1446460304, index:  this.m_Dict);
            0 = val_3;
        }
        public override void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
            string val_3;
            string val_4;
            System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode> val_5;
            val_4 = aIndex;
            val_5 = 22999695;
            if(val_4 < 0)
            {
                    return;
            }
            
            val_5 = this.m_Dict;
            if(val_5.Count <= val_4)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  1446596880, index:  this.m_Dict);
            val_4 = val_3;
            this.m_Dict.set_Item(key:  val_4, value:  value);
        }
        public override int get_Count()
        {
            if(this.m_Dict != 0)
            {
                    return this.m_Dict.Count;
            }
            
            return this.m_Dict.Count;
        }
        public override void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
            System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode> val_5;
            string val_6;
            var val_7;
            val_5 = this.m_Dict;
            if((System.String.IsNullOrEmpty(value:  aKey)) != false)
            {
                    System.Guid val_2 = System.Guid.NewGuid();
                string val_3 = ToString();
                val_6 = ;
                val_7 = -1073733951;
            }
            else
            {
                    val_5 = val_5.ContainsKey(key:  aKey);
                if(val_5 != false)
            {
                    this.m_Dict.set_Item(key:  aKey, value:  aItem);
                return;
            }
            
                val_6 = aKey;
                val_7 = -1073733951;
            }
            
            this.m_Dict.Add(key:  val_6, value:  aItem);
        }
        public override com.adjust.sdk.JSONNode Remove(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) == false)
            {
                    return;
            }
            
            com.adjust.sdk.JSONNode val_2 = this.m_Dict.Item[aKey];
            0 = this.m_Dict;
            bool val_3 = this.m_Dict.Remove(key:  aKey);
        }
        public override com.adjust.sdk.JSONNode Remove(int aIndex)
        {
            var val_4 = 0;
            if(aIndex < 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= aIndex)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  1447147280, index:  this.m_Dict);
            bool val_3 = this.m_Dict.Remove(key:  R5);
        }
        public override com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
            string val_5;
            536899459 = new JSONClass.<>c__DisplayClass12_0();
            mem[536899467] = aNode;
            536875331 = new System.Func<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>, System.Boolean>(object:  536899459, method:  new IntPtr(1610691621));
            System.Collections.Generic.IEnumerable<TSource> val_3 = System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  this.m_Dict, predicate:  536875331);
            System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  1447283848);
            bool val_6 = this.m_Dict.Remove(key:  val_5);
        }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            536899463 = new JSONClass.<get_Childs>d__14(<>1__state:  1);
            mem[536899483] = this;
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            536899461 = new JSONClass.<GetEnumerator>d__15(<>1__state:  0);
            mem[536899477] = this;
        }
        public override string ToString()
        {
            var val_4;
            var val_9;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_23:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(mem[2684370167] < 3)
            {
                    val_9 = -1610597137;
            }
            else
            {
                    string val_5 = -1610597137(-1610597137) + -1610611907(-1610611907);
                val_9 = -1610597137;
            }
            
            mem[536882417] = val_9;
            mem[536882421] = -1610612241;
            string val_6 = com.adjust.sdk.JSONNode.Escape(aText:  null);
            mem[536882425] = 0;
            mem[536882429] = -1610612189;
            mem[536882433] = val_4;
            string val_7 = +536882401;
            goto label_23;
            label_2:
            0.Dispose();
            string val_8 = -1610597137(-1610597137) + -1610596933(-1610596933);
        }
        public override string ToString(string aPrefix)
        {
            var val_10;
            Dictionary.Enumerator<TKey, TValue> val_1 = GetEnumerator();
            label_23:
            if(0.MoveNext() == false)
            {
                goto label_2;
            }
            
            if(mem[2684370169] < 4)
            {
                    val_10 = -1610597135;
            }
            else
            {
                    string val_4 = -1610597135(-1610597135) + -1610611907(-1610611907);
                val_10 = -1610597135;
            }
            
            string val_5 = -1610597135(-1610597135) + -1610612685(-1610612685) + aPrefix + -1610612539(-1610612539);
            mem[536882417] = val_10;
            mem[536882421] = -1610612241;
            string val_6 = com.adjust.sdk.JSONNode.Escape(aText:  null);
            mem[536882425] = 0;
            mem[536882429] = -1610612239;
            string val_7 = aPrefix + -1610612539(-1610612539);
            mem[536882433] = SL;
            string val_8 = +536882401;
            goto label_23;
            label_2:
            0.Dispose();
            string val_9 = -1610597135(-1610597135) + -1610612685(-1610612685) + aPrefix + -1610596933(-1610596933);
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            string val_5;
            int val_1 = this.m_Dict.Count;
            Dictionary.KeyCollection<TKey, TValue> val_2 = this.m_Dict.Keys;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            com.adjust.sdk.JSONNode val_6 = this.m_Dict.Item[val_5];
            if(this.m_Dict != 0)
            {
                goto label_8;
            }
            
            goto label_8;
            label_5:
            Dispose();
        }
        public JSONClass()
        {
            536874367 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
            this.m_Dict = 536874367;
            this = new System.Object();
        }
    
    }

}
