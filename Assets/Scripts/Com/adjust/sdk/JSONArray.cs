using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONArray : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.List<com.adjust.sdk.JSONNode> m_List;
        
        // Properties
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        
        // Methods
        public override com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            System.Collections.Generic.List<com.adjust.sdk.JSONNode> val_2;
            var val_3;
            val_2 = 22999678;
            if(aIndex >= 0)
            {
                    val_2 = this.m_List;
                if(true > aIndex)
            {
                    if(true <= aIndex)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_2 = val_2 + (aIndex << 2);
                val_3 = mem[(0 + (aIndex) << 2) + 16];
                val_3 = (0 + (aIndex) << 2) + 16;
                return;
            }
            
            }
            
            com.adjust.sdk.JSONLazyCreator val_1 = 536889325;
            val_3 = val_1;
            val_1 = new com.adjust.sdk.JSONLazyCreator(aNode:  1442312080);
        }
        public override void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
            if(aIndex >= 0)
            {
                    22999679 = this.m_List;
                if(true > aIndex)
            {
                    this.m_List.set_Item(index:  aIndex, value:  value);
                return;
            }
            
            }
            
            this.m_List.Add(item:  value);
        }
        public override com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            536889325 = new com.adjust.sdk.JSONLazyCreator(aNode:  1442581136);
        }
        public override void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
            this.m_List.Add(item:  value);
        }
        public override int get_Count()
        {
            if(this.m_List != 0)
            {
                    return (int)true;
            }
            
            return (int)true;
        }
        public override void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
            this.m_List.Add(item:  aItem);
        }
        public override com.adjust.sdk.JSONNode Remove(int aIndex)
        {
            var val_1 = 0;
            if(aIndex < 0)
            {
                    return;
            }
            
            if(true <= aIndex)
            {
                    return;
            }
            
            if(true <= aIndex)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + (aIndex << 2);
            val_1 = mem[(0 + (aIndex) << 2) + 16];
            val_1 = (0 + (aIndex) << 2) + 16;
            this.m_List.RemoveAt(index:  aIndex);
        }
        public override com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
            bool val_1 = this.m_List.Remove(item:  aNode);
        }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            536899457 = new JSONArray.<get_Childs>d__13(<>1__state:  1);
            mem[536899477] = this;
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            536899455 = new JSONArray.<GetEnumerator>d__14(<>1__state:  0);
            mem[536899471] = this;
        }
        public override string ToString()
        {
            string val_3;
            var val_7;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            if(mem[2684364915] < 3)
            {
                    val_7 = -1610602389;
            }
            else
            {
                    string val_4 = -1610602389(-1610602389) + -1610611907(-1610611907);
                val_7 = -1610602389;
            }
            
            string val_5 = -1610602389(-1610602389) + val_3;
            goto label_7;
            label_2:
            Dispose();
            string val_6 = -1610602389(-1610602389) + -1610612423(-1610612423);
        }
        public override string ToString(string aPrefix)
        {
            string val_3;
            var val_9;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_7:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            if(mem[2684364915] < 4)
            {
                    val_9 = -1610602389;
            }
            else
            {
                    string val_4 = -1610602389(-1610602389) + -1610611907(-1610611907);
                val_9 = -1610602389;
            }
            
            string val_5 = -1610602389(-1610602389) + -1610612685(-1610612685) + aPrefix + -1610612539(-1610612539);
            string val_6 = aPrefix + -1610612539(-1610612539);
            string val_7 = -1610602389(-1610602389) + val_3;
            goto label_7;
            label_2:
            Dispose();
            string val_8 = -1610602389(-1610602389) + -1610612685(-1610612685) + aPrefix + -1610602237(-1610602237);
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_1 = 0;
            goto label_3;
            label_8:
            if(aWriter <= val_1)
            {
                    var val_1 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_1 = val_1 + 0;
            val_1 = 1;
            label_3:
            if(val_1 < ((0 + 0) + 16))
            {
                goto label_8;
            }
        
        }
        public JSONArray()
        {
            536878021 = new System.Collections.Generic.List<Page>();
            this.m_List = 536878021;
            this = new System.Object();
        }
    
    }

}
