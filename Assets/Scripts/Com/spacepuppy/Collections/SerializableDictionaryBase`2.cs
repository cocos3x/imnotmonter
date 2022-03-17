using UnityEngine;

namespace com.spacepuppy.Collections
{
    [Serializable]
    public class SerializableDictionaryBase<TKey, TValue> : DrawableDictionary, IDictionary<TKey, TValue>, ICollection<System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable<System.Collections.Generic.KeyValuePair<TKey, TValue>>, IEnumerable, ISerializationCallbackReceiver
    {
        // Fields
        private System.Collections.Generic.Dictionary<TKey, TValue> _dict;
        private TKey[] _keys;
        private TValue[] _values;
        
        // Properties
        public int Count { get; }
        public System.Collections.Generic.ICollection<TKey> Keys { get; }
        public System.Collections.Generic.ICollection<TValue> Values { get; }
        public TValue Item { get; set; }
        private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
        
        // Methods
        public int get_Count()
        {
            if(this == 0)
            {
                    this = 0;
                return (int)this;
            }
            
            goto __RuntimeMethodHiddenParam + 12 + 96;
        }
        public void Add(TKey key, TValue value)
        {
            if(this == 0)
            {
                    mem[1152921510332385816] = __RuntimeMethodHiddenParam + 12 + 96 + 4;
                if(mem[1152921510332385816] == 0)
            {
                
            }
            
            }
        
        }
        public bool ContainsKey(TKey key)
        {
            if(this == 0)
            {
                    this = 0;
                return (bool)this;
            }
            
            goto __RuntimeMethodHiddenParam + 12 + 96 + 16;
        }
        public System.Collections.Generic.ICollection<TKey> get_Keys()
        {
            if(this == 0)
            {
                    mem[1152921510332626200] = __RuntimeMethodHiddenParam + 12 + 96 + 4;
                if(mem[1152921510332626200] == 0)
            {
                
            }
            
            }
        
        }
        public bool Remove(TKey key)
        {
            if(this == 0)
            {
                    this = 0;
                return (bool)this;
            }
            
            goto __RuntimeMethodHiddenParam + 12 + 96 + 24;
        }
        public bool TryGetValue(TKey key, out TValue value)
        {
            if(this != 0)
            {
                
            }
            else
            {
                    value = 0;
                return false;
            }
        
        }
        public System.Collections.Generic.ICollection<TValue> get_Values()
        {
            if(this == 0)
            {
                    mem[1152921510332986648] = __RuntimeMethodHiddenParam + 12 + 96 + 4;
                if(mem[1152921510332986648] == 0)
            {
                
            }
            
            }
        
        }
        public TValue get_Item(TKey key)
        {
            if(this != 0)
            {
                
            }
            else
            {
                    22712676 = new System.Collections.Generic.KeyNotFoundException();
            }
        
        }
        public void set_Item(TKey key, TValue value)
        {
            if(this == 0)
            {
                    mem[1152921510333227032] = __RuntimeMethodHiddenParam + 12 + 96 + 4;
                if(mem[1152921510333227032] == 0)
            {
                
            }
            
            }
        
        }
        public void Clear()
        {
            if(this == 0)
            {
                    return;
            }
            
            goto __RuntimeMethodHiddenParam + 12 + 96 + 44;
        }
        private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = this;
            if(R7 == 0)
            {
                    mem[1152921510333459224] = R3 + 12 + 96 + 4;
                val_3 = mem[1152921510333459224];
                if(val_3 == 0)
            {
                goto label_8;
            }
            
            }
            
            label_8:
            var val_3 = val_3;
            if((R3 + 12 + 96 + 4 + 178) == 0)
            {
                goto label_4;
            }
            
            var val_2 = 0;
            label_6:
            val_2 = mem[R3 + 12 + 96 + 4 + 88 + 0];
            val_2 = R3 + 12 + 96 + 4 + 88 + 0;
            if(val_2 == (R3 + 12 + 96 + 48))
            {
                goto label_5;
            }
            
            val_2 = val_2 + 1;
            if(((uint)val_2 & 65535) < (R3 + 12 + 96 + 4 + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_4 = val_3;
            goto ((R3 + 12 + 96 + 4 + ((R3 + 12 + 96 + 4 + 88 + 0) + 4) << 3) + 204);
            label_5:
            var val_1 = (R3 + 12 + 96 + 4 + 88) + 0;
            val_3 = val_3 + (((R3 + 12 + 96 + 4 + 88 + 0) + 4) << 3);
            val_4 = val_3 + 204;
            goto ((R3 + 12 + 96 + 4 + ((R3 + 12 + 96 + 4 + 88 + 0) + 4) << 3) + 204);
        }
        private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
        {
            var val_2;
            if(R6 == 0)
            {
                    return false;
            }
            
            var val_3 = R6;
            if((R6 + 178) == 0)
            {
                goto label_2;
            }
            
            var val_2 = 0;
            label_4:
            if((R6 + 88 + 0) == (R3 + 12 + 96 + 48))
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(((uint)val_2 & 65535) < (R6 + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_2 = R6;
            goto ((R6 + ((R6 + 88 + 0) + 4) << 3) + 220);
            label_3:
            var val_1 = (R6 + 88) + 0;
            val_3 = val_3 + (((R6 + 88 + 0) + 4) << 3);
            val_2 = val_3 + 220;
            goto ((R6 + ((R6 + 88 + 0) + 4) << 3) + 220);
        }
        private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(System.Collections.Generic.KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            var val_2;
            if(R6 == 0)
            {
                    return;
            }
            
            var val_3 = R6;
            if((R6 + 178) == 0)
            {
                goto label_2;
            }
            
            var val_2 = 0;
            label_4:
            if((R6 + 88 + 0) == (__RuntimeMethodHiddenParam + 12 + 96 + 48))
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(((uint)val_2 & 65535) < (R6 + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_2 = R6;
            goto ((R6 + ((R6 + 88 + 0) + 4) << 3) + 228);
            label_3:
            var val_1 = (R6 + 88) + 0;
            val_3 = val_3 + (((R6 + 88 + 0) + 4) << 3);
            val_2 = val_3 + 228;
            goto ((R6 + ((R6 + 88 + 0) + 4) << 3) + 228);
        }
        private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(System.Collections.Generic.KeyValuePair<TKey, TValue> item)
        {
            var val_2;
            if(R6 == 0)
            {
                    return false;
            }
            
            var val_3 = R6;
            if((R6 + 178) == 0)
            {
                goto label_2;
            }
            
            var val_2 = 0;
            label_4:
            if((R6 + 88 + 0) == (R3 + 12 + 96 + 48))
            {
                goto label_3;
            }
            
            val_2 = val_2 + 1;
            if(((uint)val_2 & 65535) < (R6 + 178))
            {
                goto label_4;
            }
            
            label_2:
            val_2 = R6;
            goto ((R6 + ((R6 + 88 + 0) + 4) << 3) + 236);
            label_3:
            var val_1 = (R6 + 88) + 0;
            val_3 = val_3 + (((R6 + 88 + 0) + 4) << 3);
            val_2 = val_3 + 236;
            goto ((R6 + ((R6 + 88 + 0) + 4) << 3) + 236);
        }
        private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly()
        {
            return false;
        }
        public System.Collections.Generic.Dictionary.Enumerator<TKey, TValue> GetEnumerator()
        {
            com.spacepuppy.Collections.SerializableDictionaryBase<TKey, TValue> val_1;
            com.spacepuppy.Collections.SerializableDictionaryBase<TKey, TValue> val_2;
            if((__RuntimeMethodHiddenParam + 8) != 0)
            {
                    val_2 = ;
                this = val_1;
                return (Dictionary.Enumerator<TKey, TValue>)val_2;
            }
            
            val_2 = 0;
            mem[1152921510334092960] = val_2;
            this = val_2;
            return (Dictionary.Enumerator<TKey, TValue>)val_2;
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            float val_1;
            var val_3;
            if(__RuntimeMethodHiddenParam != 0)
            {
                    val_1 = val_1;
                return;
            }
            
            var val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 56;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 178) == 0)
            {
                goto label_4;
            }
            
            var val_3 = 0;
            label_6:
            if((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88 + 0) == (__RuntimeMethodHiddenParam + 12 + 96 + 60))
            {
                goto label_5;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < (__RuntimeMethodHiddenParam + 12 + 96 + 56 + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 56;
            goto ((__RuntimeMethodHiddenParam + 12 + 96 + 56 + ((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88 + 0) + 4) << 3) + 188);
            label_5:
            var val_2 = (__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88) + 0;
            val_4 = val_4 + (((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88 + 0) + 4) << 3);
            val_3 = val_4 + 188;
            goto ((__RuntimeMethodHiddenParam + 12 + 96 + 56 + ((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88 + 0) + 4) << 3) + 188);
        }
        private System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator()
        {
            float val_1;
            var val_3;
            if(__RuntimeMethodHiddenParam != 0)
            {
                    val_1 = val_1;
                return;
            }
            
            var val_4 = __RuntimeMethodHiddenParam + 12 + 96 + 56;
            if((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 178) == 0)
            {
                goto label_4;
            }
            
            var val_3 = 0;
            label_6:
            if((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88 + 0) == (__RuntimeMethodHiddenParam + 12 + 96 + 60))
            {
                goto label_5;
            }
            
            val_3 = val_3 + 1;
            if(((uint)val_3 & 65535) < (__RuntimeMethodHiddenParam + 12 + 96 + 56 + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_3 = __RuntimeMethodHiddenParam + 12 + 96 + 56;
            goto ((__RuntimeMethodHiddenParam + 12 + 96 + 56 + ((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88 + 0) + 4) << 3) + 188);
            label_5:
            var val_2 = (__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88) + 0;
            val_4 = val_4 + (((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88 + 0) + 4) << 3);
            val_3 = val_4 + 188;
            goto ((__RuntimeMethodHiddenParam + 12 + 96 + 56 + ((__RuntimeMethodHiddenParam + 12 + 96 + 56 + 88 + 0) + 4) << 3) + 188);
        }
        private void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize()
        {
            var val_1;
            var val_2;
            var val_3;
            if(R6 != 0)
            {
                    1152921510334428960 = 1152921510334428960;
            }
            
            if(1152921510334428960 == 0)
            {
                goto label_0;
            }
            
            if(mem[1152921510334428952] != 0)
            {
                
            }
            else
            {
                    mem[1152921510334428952] = __RuntimeMethodHiddenParam + 12 + 96 + 4;
            }
            
            val_2 = 4;
            goto label_4;
            label_15:
            val_1 = mem[1152921510334428952];
            if((__RuntimeMethodHiddenParam + 12 + 96 + 4) < (R5 + 12))
            {
                    val_3 = __RuntimeMethodHiddenParam;
            }
            else
            {
                    val_3 = __RuntimeMethodHiddenParam;
            }
            
            val_2 = 5;
            label_4:
            if((val_2 - 4) < (__RuntimeMethodHiddenParam + 12 + 96 + 40 + 12))
            {
                goto label_15;
            }
            
            label_0:
            mem[1152921510334428956] = 0;
            mem[1152921510334428960] = 0;
        }
        private void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize()
        {
            float val_1;
            var val_3;
            var val_5;
            var val_6;
            val_5 = __RuntimeMethodHiddenParam;
            if((20 != 0) && (20 != 0))
            {
                    mem[1152921510334540956] = __RuntimeMethodHiddenParam + 12 + 96 + 72;
                mem[1152921510334540960] = __RuntimeMethodHiddenParam + 12 + 96 + 76;
                if(val_1.MoveNext() == false)
            {
                    return;
            }
            
                var val_6 = 0;
                var val_5 = 16;
                do
            {
                mem2[0] = val_3;
                val_6 = 0;
                mem2[0] = val_6;
                val_5 = val_5 + 4;
                val_6 = val_6 + 1;
            }
            while(val_1.MoveNext() == true);
            
                return;
            }
            
            mem[1152921510334540956] = 0;
            mem[1152921510334540960] = 0;
        }
        public SerializableDictionaryBase<TKey, TValue>()
        {
            if(this != 0)
            {
                    return;
            }
        
        }
    
    }

}
