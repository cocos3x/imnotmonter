using UnityEngine;

namespace Water2D
{
    public class MetaballCameraEffect : MonoBehaviour
    {
        // Fields
        public UnityEngine.Material cutOutMaterial;
        public UnityEngine.Camera bgCamera;
        private UnityEngine.RenderTexture bgTargetTexture;
        private UnityEngine.RenderTexture buffer;
        
        // Methods
        public void Restart()
        {
            this.OnEnable();
        }
        private void OnEnable()
        {
            if(UnityEngine.Screen.width < 1)
            {
                    return;
            }
            
            if(UnityEngine.Screen.height < 1)
            {
                    return;
            }
            
            UnityEngine.RenderTexture val_5 = 536892813;
            val_5 = new UnityEngine.RenderTexture(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, depth:  16);
            this.bgTargetTexture = val_5;
            this.bgCamera.targetTexture = 536892813;
        }
        protected void OnDisable()
        {
        
        }
        protected void Start()
        {
            UnityEngine.Shader val_1 = this.cutOutMaterial.shader;
            if(this.cutOutMaterial.isSupported == true)
            {
                    return;
            }
            
            R4.enabled = false;
        }
        private void OnRenderImage(UnityEngine.RenderTexture source, UnityEngine.RenderTexture destination)
        {
            UnityEngine.RenderTexture val_5 = source;
            val_5 = val_5 + ((val_5 >> 31) >> 30);
            UnityEngine.RenderTexture val_2 = val_5 >> 2;
            UnityEngine.RenderTexture val_6 = source;
            UnityEngine.RenderTexture val_3 = val_6 >> 31;
            val_6 = val_6 + (val_3 >> 30);
            val_3 = val_6 >> 2;
            UnityEngine.RenderTexture val_4 = UnityEngine.RenderTexture.GetTemporary(width:  val_2, height:  val_3, depthBuffer:  0);
            this.buffer = val_2;
            UnityEngine.Graphics.Blit(source:  this.bgTargetTexture, dest:  destination);
            UnityEngine.Graphics.Blit(source:  source, dest:  destination, mat:  this.cutOutMaterial);
            UnityEngine.RenderTexture.ReleaseTemporary(temp:  this.buffer);
        }
        public MetaballCameraEffect()
        {
        
        }
    
    }

}
