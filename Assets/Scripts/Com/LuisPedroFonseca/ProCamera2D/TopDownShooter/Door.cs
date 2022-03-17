using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class Door : MonoBehaviour
    {
        // Fields
        private bool _isOpen;
        public Com.LuisPedroFonseca.ProCamera2D.TopDownShooter.DoorDirection DoorDirection;
        public float MovementRange;
        public float AnimDuration;
        public float OpenDelay;
        public float CloseDelay;
        private UnityEngine.Vector3 _origPos;
        private UnityEngine.Coroutine _moveCoroutine;
        
        // Properties
        public bool IsOpen { get; }
        
        // Methods
        public bool get_IsOpen()
        {
            return (bool)this._isOpen;
        }
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = position;
        }
        public void OpenDoor(float openDelay = -1)
        {
            float val_3;
            UnityEngine.Vector3 val_6;
            this._isOpen = true;
            if(this.DoorDirection > 3)
            {
                    return;
            }
            
            var val_1 = 4437680 + (4437680 + (this.DoorDirection) << 2);
            if(this.DoorDirection == 3)
            {
                    this = 1083400624;
                this = 1083400624;
                this = this & (((R4) << (32-as. 
                
            
            
            
            
            
               
            )) | ((R4) << as. 
                
            
            
            
            
            
               
            ));
                this = IP * this;
            }
            
            float val_3 = (IP * (this & ((R4) << (32-as. 
                
            
            
            
            
            
               
            )) | ((R4) << as. 
                
            
            
            
            
            
               
            ))).MovementRange;
            val_3 = (IP * (this & ((R4) << (32-as. 
                
            
            
            
            
            
               
            )) | ((R4) << as. 
                
            
            
            
            
            
               
            ))).AnimDuration;
            val_3 = ((IP * (this & ((R4) << (32-as. 
                
            
            
            
            
            
               
            )) | ((R4) << as. 
                
            
            
            
            
            
               
            )))._origPos) - val_3;
            val_6 = val_3;
            this.Move(newPos:  new UnityEngine.Vector3() {}, duration:  R1 = this.OpenDelay, delay:  null);
        }
        public void CloseDoor()
        {
            this._isOpen = false;
            this.Move(newPos:  new UnityEngine.Vector3() {x = mem[this._origPos + (0)], y = mem[this._origPos + (4)], z = mem[this._origPos + (8)]}, duration:  this.AnimDuration, delay:  null);
        }
        private void Move(UnityEngine.Vector3 newPos, float duration, float delay)
        {
            if(this._moveCoroutine != 0)
            {
                    this.StopCoroutine(routine:  this._moveCoroutine);
            }
            
            System.Collections.IEnumerator val_3 = this.MoveRoutine(newPos:  new UnityEngine.Vector3() {x = newPos.x, y = newPos.y, z = newPos.z}, duration:  duration, delay:  delay);
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  1083632816);
            this._moveCoroutine = this;
        }
        private System.Collections.IEnumerator MoveRoutine(UnityEngine.Vector3 newPos, float duration, float delay)
        {
            float val_2;
            float val_3;
            Door.<MoveRoutine>d__14 val_1 = 536898667;
            val_1 = new Door.<MoveRoutine>d__14(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536898687] = this;
            }
            else
            {
                    mem[20] = this;
            }
            
            mem[536898695] = newPos.x;
            mem[536898699] = newPos.y;
            mem[536898703] = newPos.z;
            if(val_1 != 0)
            {
                    mem[536898691] = val_3;
            }
            else
            {
                    mem[24] = val_3;
            }
            
            mem[536898683] = val_2;
        }
        public Door()
        {
            this.MovementRange = 5f;
            this.AnimDuration = 1f;
        }
    
    }

}
