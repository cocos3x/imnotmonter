using UnityEngine;

namespace AFramework.UI
{
    public class HoldToTriggerButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
    {
        // Fields
        private float RateTime;
        private UnityEngine.UI.Button mButton;
        private bool mOnHold;
        private float mHoldingTime;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.mButton = this;
        }
        private void Update()
        {
            if(this.mOnHold == false)
            {
                    return;
            }
            
            if(this.mOnHold == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Time.deltaTime;
            uint val_2 = 0;
            val_2 = this.mHoldingTime + val_2;
            this.mHoldingTime = val_2;
            if(this.mOnHold < false)
            {
                    return;
            }
            
            val_2 = val_2 - this.RateTime;
            this.mHoldingTime = val_2;
            this.mButton.m_OnClick.Invoke();
        }
        private void UnityEngine.EventSystems.IPointerDownHandler.OnPointerDown(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.mHoldingTime = 0f;
            this.mOnHold = 0f;
        }
        private void UnityEngine.EventSystems.IPointerUpHandler.OnPointerUp(UnityEngine.EventSystems.PointerEventData eventData)
        {
            this.mOnHold = false;
        }
        public HoldToTriggerButton()
        {
            this.RateTime = 0.15f;
        }
    
    }

}
