using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public interface IPositionOverrider
    {
        // Properties
        public abstract int POOrder { get; set; }
        
        // Methods
        public abstract UnityEngine.Vector3 OverridePosition(float deltaTime, UnityEngine.Vector3 originalPosition); // 0
        public abstract int get_POOrder(); // 0
        public abstract void set_POOrder(int value); // 0
    
    }

}
