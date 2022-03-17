using UnityEngine;

namespace FerrPoly2Tri
{
    public struct FixedBitArray3 : IEnumerable<bool>, IEnumerable
    {
        // Fields
        public bool _0;
        public bool _1;
        public bool _2;
        
        // Properties
        public bool Item { get; set; }
        
        // Methods
        public bool get_Item(int index)
        {
            bool val_2;
            if(index != 2)
            {
                    if(index != 1)
            {
                    if(index == 0)
            {
                    return val_2;
            }
            
                22712420 = new System.IndexOutOfRangeException();
            }
            
                val_2 = 22712421;
                return val_2;
            }
            
            val_2 = this._2;
            return val_2;
        }
        public void set_Item(int index, bool value)
        {
            if(index == 2)
            {
                    this._2 = value;
                return;
            }
            
            if(index == 1)
            {
                    this._1 = value;
                return;
            }
            
            if(index == 0)
            {
                    this = value;
                return;
            }
            
            22712420 = new System.IndexOutOfRangeException();
        }
        public bool Contains(bool value)
        {
            do
            {
                bool val_1 = this.Item[1];
                val_1 = val_1 ^ value;
                if(val_1 != true)
            {
                    return true;
            }
            
            }
            while(1 < 2);
            
            return false;
        }
        public int IndexOf(bool value)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            do
            {
                val_3 = 1;
                bool val_1 = this.Item[1];
                val_1 = val_1 ^ value;
                if(val_1 != true)
            {
                    return (int)val_3;
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 <= 1);
            
            val_3 = 0;
            return (int)val_3;
        }
        public void Clear()
        {
            this._2 = false;
            this = false;
        }
        public void Clear(bool value)
        {
            var val_2 = 0;
            do
            {
                if(this.Item[0] == value)
            {
                    this.set_Item(index:  0, value:  false);
            }
            
                val_2 = val_2 + 1;
            }
            while(val_2 != 3);
        
        }
        private System.Collections.Generic.IEnumerable<bool> Enumerate()
        {
            536899039 = new FixedBitArray3.<Enumerate>d__10(<>1__state:  1);
            bool val_3 = this._2;
            FerrPoly2Tri.FixedBitArray3 val_2 = 1152921504928677888 | (val_3 << 16);
            val_3 = val_2 >> 16;
            mem[536899062] = val_2;
            mem[536899064] = val_3;
        }
        public System.Collections.Generic.IEnumerator<bool> GetEnumerator()
        {
            var val_2;
            System.Collections.Generic.IEnumerable<System.Boolean> val_1 = this.Enumerate();
            var val_2 = 0;
            val_2 = val_2 + 1;
            val_2 = this;
            goto (1152921504928677888 + (Klass->__il2cppRuntimeField_interfaceOffsets[].offset) << 3)._0;
        }
        private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    
    }

}
