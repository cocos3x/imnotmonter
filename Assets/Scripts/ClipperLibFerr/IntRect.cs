using UnityEngine;

namespace ClipperLibFerr
{
    public struct IntRect
    {
        // Fields
        public long left;
        public long top;
        public long right;
        public long bottom;
        
        // Methods
        public IntRect(long l, long t, long r, long b)
        {
            var val_1;
            mem[1152921510266912036] = b;
            this.bottom = b;
            mem[1152921510266912044] = val_1;
        }
        public IntRect(ClipperLibFerr.IntRect ir)
        {
            var val_1;
            mem[1152921510267024036] = ir.bottom;
            this.bottom = ir.bottom;
            mem[1152921510267024044] = val_1;
        }
    
    }

}
