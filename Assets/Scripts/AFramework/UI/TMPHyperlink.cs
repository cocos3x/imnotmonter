using UnityEngine;

namespace AFramework.UI
{
    public class TMPHyperlink : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
    {
        // Methods
        public void OnPointerClick(UnityEngine.EventSystems.PointerEventData eventData)
        {
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            UnityEngine.Camera val_6 = UnityEngine.Camera.main;
            int val_7 = TMPro.TMP_TextUtilities.FindIntersectingLink(text:  1185192240, position:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5}, camera:  0);
            if(val_7 == 1)
            {
                    return;
            }
            
            UnityEngine.Transform val_8 = this.GetComponent<UnityEngine.Transform>();
            int val_9 = (val_7 << 3) - val_7;
            val_9 = this + (val_9 << 2);
            AFramework.UI.TMPHyperlink val_10 = val_9 + 16;
            string val_11 = GetLinkID();
            UnityEngine.Application.OpenURL(url:  1185180176);
        }
        public TMPHyperlink()
        {
        
        }
    
    }

}
