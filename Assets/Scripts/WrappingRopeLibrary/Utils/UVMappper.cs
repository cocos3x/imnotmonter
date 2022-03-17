using UnityEngine;

namespace WrappingRopeLibrary.Utils
{
    internal class UVMappper
    {
        // Methods
        internal static UnityEngine.Vector2 GetUv(WrappingRopeLibrary.Enums.UVLocation uvLocation, float cross, float extend)
        {
            float val_2 = R2;
            if(R1 < 2)
            {
                goto label_1;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            if((R1 & (~1)) != 2)
            {
                goto label_1;
            }
            
            mem2[0] = val_2;
            val_2 = R3;
            goto label_2;
            label_1:
            mem2[0] = R3;
            label_2:
            mem2[0] = val_2;
            return new UnityEngine.Vector2() {x = val_2, y = extend};
        }
        public UVMappper()
        {
        
        }
    
    }

}
