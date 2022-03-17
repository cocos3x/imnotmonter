using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class BasicBlit : MonoBehaviour
    {
        // Fields
        public UnityEngine.Material CurrentMaterial;
        
        // Methods
        private void OnRenderImage(UnityEngine.RenderTexture src, UnityEngine.RenderTexture dst)
        {
            if(this.CurrentMaterial == 0)
            {
                    return;
            }
            
            UnityEngine.Graphics.Blit(source:  src, dest:  dst, mat:  this.CurrentMaterial);
        }
        public BasicBlit()
        {
        
        }
    
    }

}
