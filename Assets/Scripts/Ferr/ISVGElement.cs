using UnityEngine;

namespace Ferr
{
    public interface ISVGElement
    {
        // Properties
        public abstract UnityEngine.Vector2 Start { get; }
        public abstract UnityEngine.Vector2 End { get; }
        public abstract UnityEngine.Rect Bounds { get; }
        public abstract bool Closed { get; }
        
        // Methods
        public abstract UnityEngine.Vector2 get_Start(); // 0
        public abstract UnityEngine.Vector2 get_End(); // 0
        public abstract UnityEngine.Rect get_Bounds(); // 0
        public abstract bool get_Closed(); // 0
        public abstract Ferr.ISVGElement Reverse(); // 0
        public abstract System.Collections.Generic.List<UnityEngine.Vector2> GetPoints(int aResolution); // 0
        public abstract string ToSVGElement(); // 0
    
    }

}
