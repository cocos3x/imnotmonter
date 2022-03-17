using UnityEngine;

namespace Vectrosity
{
    public class CapInfo
    {
        // Fields
        public Vectrosity.EndCap capType;
        public UnityEngine.Texture texture;
        public float ratio1;
        public float ratio2;
        public float offset1;
        public float offset2;
        public float scale1;
        public float scale2;
        public float[] uvHeights;
        
        // Methods
        public CapInfo(Vectrosity.EndCap capType, UnityEngine.Texture texture, float ratio1, float ratio2, float offset1, float offset2, float scale1, float scale2, float[] uvHeights)
        {
            System.Single[] val_2;
            float val_3;
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            val_1 = new System.Object();
            this.capType = capType;
            this.texture = val_1;
            this.uvHeights = val_2;
            mem[1152921509264390816] = uvHeights;
            mem[1152921509264390820] = val_3;
            mem[1152921509264390824] = val_4;
            mem[1152921509264390828] = val_5;
            mem[1152921509264390832] = val_6;
            mem[1152921509264390836] = val_7;
        }
    
    }

}
