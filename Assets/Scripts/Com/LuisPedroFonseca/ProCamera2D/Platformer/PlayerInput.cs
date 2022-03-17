using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.Platformer
{
    public class PlayerInput : MonoBehaviour
    {
        // Fields
        public UnityEngine.Transform Body;
        public float gravity;
        public float runSpeed;
        public float acceleration;
        public float jumpHeight;
        public int jumpsAllowed;
        private float currentSpeed;
        private UnityEngine.Vector3 amountToMove;
        private int totalJumps;
        private UnityEngine.CharacterController _characterController;
        
        // Methods
        private void Start()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this._characterController = this;
        }
        private void Update()
        {
            var val_11;
            var val_16;
            float val_19;
            float val_24;
            UnityEngine.Vector3 val_25;
            UnityEngine.CollisionFlags val_1 = this._characterController.collisionFlags;
            if(this._characterController != 1)
            {
                    this.currentSpeed = 0f;
            }
            
            UnityEngine.CollisionFlags val_2 = this._characterController.collisionFlags;
            if(this._characterController == 4)
            {
                    float val_3 = UnityEngine.Time.deltaTime;
                mem[1152921510001245404] = ;
            }
            else
            {
                    this.totalJumps = 0;
                mem[1152921510001245404] = 3212836864;
            }
            
            if((UnityEngine.Input.GetKeyDown(key:  119)) != true)
            {
                    if((UnityEngine.Input.GetKeyDown(key:  32)) != true)
            {
                    if((UnityEngine.Input.GetKeyDown(key:  273)) == false)
            {
                goto label_7;
            }
            
            }
            
            }
            
            if(this.totalJumps < this.jumpsAllowed)
            {
                    this.jumpsAllowed = this.jumpHeight;
                this.totalJumps = this.totalJumps + 1;
                this.totalJumps = this.totalJumps;
                mem[1152921510001245404] = this.jumpsAllowed;
            }
            
            label_7:
            float val_7 = UnityEngine.Input.GetAxis(axisName:  -1610607721);
            uint val_24 = 2684359575;
            val_24 = val_24 * this.runSpeed;
            float val_8 = this.IncrementTowards(n:  val_24, target:  null, a:  this.runSpeed);
            this.currentSpeed = -1.08485E-19f;
            UnityEngine.Transform val_9 = this._characterController.transform;
            UnityEngine.Vector3 val_10 = position;
            if(this != 0)
            {
                    UnityEngine.Transform val_12 = this.transform;
                UnityEngine.Vector3 val_13 = position;
                val_24 = -val_11;
                mem[1152921510001245408] = val_24;
            }
            
            this.amountToMove = this.currentSpeed;
            if(this != 0)
            {
                    float val_14 = UnityEngine.Mathf.Sign(f:  val_24);
                UnityEngine.Vector3 val_15 = localScale;
                float val_25 = System.Math.Abs(val_16);
                UnityEngine.Vector3 val_17 = localScale;
                this.Body.localScale = new UnityEngine.Vector3() {x = this.currentSpeed * val_25, y = val_19, z = 0f};
                val_25 = this.amountToMove;
            }
            
            float val_20 = UnityEngine.Time.deltaTime;
            uint val_26 = 0;
            val_26 = val_25 * val_26;
            UnityEngine.CollisionFlags val_23 = this._characterController.Move(motion:  new UnityEngine.Vector3() {y = val_25 * val_26, z = S20 * val_26});
        }
        private float IncrementTowards(float n, float target, float a)
        {
            if()
            {
                    return (float)n;
            }
            
            float val_2 = UnityEngine.Mathf.Sign(f:  R2 - R1);
            float val_3 = UnityEngine.Time.deltaTime;
            uint val_6 = 0;
            val_6 = val_6 * R3;
            float val_4 = R2 - R1;
            float val_5 = UnityEngine.Mathf.Sign(f:  val_4);
            if()
            {
                    R2 = R1;
            }
            
            return val_4;
        }
        public PlayerInput()
        {
            this.jumpsAllowed = 2;
        }
    
    }

}
