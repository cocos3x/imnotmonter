using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class DoorKey : MonoBehaviour
    {
        // Fields
        public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.Door Door;
        public string PickupTag;
        public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCinematics Cinematics;
        
        // Methods
        private void OnTriggerEnter(UnityEngine.Collider other)
        {
            UnityEngine.Transform val_1 = other.transform;
            if((other.CompareTag(tag:  this.PickupTag)) == false)
            {
                    return;
            }
            
            if(this.Door._isOpen == true)
            {
                    return;
            }
            
            R4 + 12.OpenDoor(openDelay:  null);
            if((R4 + 20) != 0)
            {
                    R4 + 20.Play();
            }
            
            UnityEngine.GameObject val_4 = R4.gameObject;
            UnityEngine.Object.Destroy(obj:  R4);
        }
        public DoorKey()
        {
            this.PickupTag = -1610605337;
        }
    
    }

}
