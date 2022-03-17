using UnityEngine;

namespace Ferr
{
    public interface ILerpable<T>
    {
        // Methods
        public abstract T Lerp(T aWith, float aLerp); // 0
    
    }

}
