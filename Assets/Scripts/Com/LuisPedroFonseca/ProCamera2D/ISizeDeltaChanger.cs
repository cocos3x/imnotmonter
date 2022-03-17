using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public interface ISizeDeltaChanger
    {
        // Properties
        public abstract int SDCOrder { get; set; }
        
        // Methods
        public abstract float AdjustSize(float deltaTime, float originalDelta); // 0
        public abstract int get_SDCOrder(); // 0
        public abstract void set_SDCOrder(int value); // 0
    
    }

}
