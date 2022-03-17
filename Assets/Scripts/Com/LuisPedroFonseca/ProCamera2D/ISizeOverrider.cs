using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public interface ISizeOverrider
    {
        // Properties
        public abstract int SOOrder { get; set; }
        
        // Methods
        public abstract float OverrideSize(float deltaTime, float originalSize); // 0
        public abstract int get_SOOrder(); // 0
        public abstract void set_SOOrder(int value); // 0
    
    }

}
