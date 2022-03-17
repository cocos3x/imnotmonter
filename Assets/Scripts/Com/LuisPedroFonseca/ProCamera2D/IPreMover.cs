using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public interface IPreMover
    {
        // Properties
        public abstract int PrMOrder { get; set; }
        
        // Methods
        public abstract void PreMove(float deltaTime); // 0
        public abstract int get_PrMOrder(); // 0
        public abstract void set_PrMOrder(int value); // 0
    
    }

}
