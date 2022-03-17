using UnityEngine;

namespace Ferr
{
    public interface IBlendPaintable
    {
        // Methods
        public abstract void OnPainterSelected(Ferr.IBlendPaintType aPainter); // 0
        public abstract void OnPainterUnselected(Ferr.IBlendPaintType aPainter); // 0
    
    }

}
