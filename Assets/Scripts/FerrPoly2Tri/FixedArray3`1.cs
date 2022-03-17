using UnityEngine;

namespace FerrPoly2Tri
{
    public struct FixedArray3<T> : IEnumerable<T>, IEnumerable
    {
        // Fields
        public T _0;
        public T _1;
        public T _2;
        
        // Properties
        public T Item { get; set; }
        
        // Methods
        public T get_Item(int index)
        {
            var val_2;
            if(index != 2)
            {
                    if(index != 1)
            {
                    if(index == 0)
            {
                    return;
            }
            
                22712420 = new System.IndexOutOfRangeException();
            }
            
                val_2 = 22712424;
                return;
            }
            
            val_2 = 1152921510238069016;
        }
        public void set_Item(int index, T value)
        {
            if(index == 2)
            {
                goto label_0;
            }
            
            if(index == 1)
            {
                goto label_1;
            }
            
            if(index != 0)
            {
                goto label_2;
            }
            
            this = value;
            label_1:
            mem[1152921510238185108] = value;
            label_0:
            mem[1152921510238185116] = value;
            label_2:
            22712420 = new System.IndexOutOfRangeException();
        }
        public bool Contains(T value)
        {
            int val_3 = 0;
            do
            {
                val_3 = val_3 + 1;
                FerrPoly2Tri.TriangulationPoint val_1 = this.Item[val_3];
                if(this != 0)
            {
                    if((this.Equals(obj:  value)) == true)
            {
                    return true;
            }
            
            }
            
            }
            while(val_3 < 2);
            
            return false;
        }
        public int IndexOf(T value)
        {
            int val_3;
            var val_3 = 0;
            do
            {
                val_3 = val_3 + 1;
                FerrPoly2Tri.TriangulationPoint val_1 = this.Item[val_3];
                if(this != 0)
            {
                    if((this.Equals(obj:  value)) == true)
            {
                    return (int)val_3;
            }
            
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 <= 1);
            
            val_3 = 0;
            return (int)val_3;
        }
        public void Clear()
        {
            mem[1152921510238541592] = 0;
            mem[1152921510238541588] = 0;
            this = 0;
        }
        public void Clear(T value)
        {
            var val_4 = 0;
            do
            {
                FerrPoly2Tri.TriangulationPoint val_1 = this.Item[0];
                if(this != 0)
            {
                    if((this.Equals(obj:  value)) != false)
            {
                    bool val_3 = this.Equals(obj:  0);
            }
            
            }
            
                val_4 = val_4 + 1;
            }
            while(val_4 != 3);
        
        }
        private System.Collections.Generic.IEnumerable<T> Enumerate()
        {
            var val_1;
            var val_2;
            val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
            val_1 = __RuntimeMethodHiddenParam + 12 + 186;
            val_2 = __RuntimeMethodHiddenParam + 12;
            if(val_1 == 1)
            {
                    val_2 = mem[__RuntimeMethodHiddenParam + 12];
                val_2 = __RuntimeMethodHiddenParam + 12;
                val_1 = mem[__RuntimeMethodHiddenParam + 12 + 186];
                val_1 = __RuntimeMethodHiddenParam + 12 + 186;
            }
            
            mem2[0] = ???;
            mem2[0] = ???;
            mem2[0] = this;
        }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            var val_3;
            var val_4;
            val_3 = mem[__RuntimeMethodHiddenParam + 12];
            val_3 = __RuntimeMethodHiddenParam + 12;
            System.Collections.Generic.IEnumerable<T> val_1 = this.Enumerate();
            var val_3 = 0;
            val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = (uint)val_3 & 65535;
            val_4 = this;
            goto (1152921504928571392 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)._2;
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            if((__RuntimeMethodHiddenParam + 12 + 186) != 1)
            {
                    return this.GetEnumerator();
            }
            
            return this.GetEnumerator();
        }
    
    }

}
