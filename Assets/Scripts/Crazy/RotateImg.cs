using UnityEngine;

namespace Crazy
{
    public class RotateImg : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 axis;
        private float speed;
        private UnityEngine.UI.Image img;
        
        // Methods
        private void Start()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.img = this;
        }
        private void Update()
        {
            UnityEngine.RectTransform val_1 = this.img.rectTransform;
            float val_5 = UnityEngine.Time.deltaTime;
            uint val_8 = 0;
            val_8 = (this.axis * this.speed) * val_8;
            this.img.Rotate(eulers:  new UnityEngine.Vector3() {y = (S2 * this.speed) * val_8, z = (S4 * this.speed) * val_8});
        }
        public RotateImg()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.forward;
        }
    
    }

}
