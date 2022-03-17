using UnityEngine;

namespace AFramework.UI
{
    public class HoldToScaleButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerExitHandler, IPointerUpHandler, IPointerEnterHandler
    {
        // Fields
        private UnityEngine.Vector3 ScaleValue;
        private UnityEngine.Vector3 mBaseScale;
        private bool mOnHold;
        private UnityEngine.UI.Button mButton;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = localScale;
            UnityEngine.Transform val_3 = this.GetComponent<UnityEngine.Transform>();
            this.mButton = this;
        }
        private void OnDisable()
        {
            this.mOnHold = false;
            UnityEngine.Transform val_1 = this.transform;
            this.localScale = new UnityEngine.Vector3() {x = mem[this.mBaseScale + (0)], y = mem[this.mBaseScale + (4)], z = mem[this.mBaseScale + (8)]};
        }
        private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.mOnHold = this;
            if(this == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = this.transform;
            this.localScale = new UnityEngine.Vector3() {x = this.ScaleValue, y = R7, z = 18040.84f};
        }
        private void UnityEngine.EventSystems.IPointerExitHandler.OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_2 = this;
            if(this.mOnHold == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = this.transform;
            this.localScale = new UnityEngine.Vector3() {x = mem[this.mBaseScale + (0)], y = mem[this.mBaseScale + (4)], z = mem[this.mBaseScale + (8)]};
        }
        private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.mOnHold = false;
            UnityEngine.Transform val_1 = this.transform;
            this.localScale = new UnityEngine.Vector3() {x = mem[this.mBaseScale + (0)], y = mem[this.mBaseScale + (4)], z = mem[this.mBaseScale + (8)]};
        }
        private void UnityEngine.EventSystems.IPointerEnterHandler.OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            var val_2 = this;
            if(this.mOnHold == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = this.transform;
            this.localScale = new UnityEngine.Vector3() {x = mem[this.ScaleValue + (0)], y = mem[this.ScaleValue + (4)], z = mem[this.ScaleValue + (8)]};
        }
        public HoldToScaleButton()
        {
            this.ScaleValue = 1067030938;
            mem[1152921510085937088] = 1067030938;
            mem[1152921510085937092] = 1067030938;
        }
    
    }

}
