using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.Platformer
{
    public class PlayerInputBot : MonoBehaviour
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
        private bool _fakeInputJump;
        private float _fakeInputHorizontalAxis;
        private UnityEngine.CharacterController _characterController;
        
        // Methods
        private void Start()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this._characterController = this;
            System.Collections.IEnumerator val_2 = this.RandomInputJump();
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1101184816);
            System.Collections.IEnumerator val_4 = this.RandomInputSpeed();
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  1101184816);
        }
        private System.Collections.IEnumerator RandomInputJump()
        {
            536900351 = new PlayerInputBot.<RandomInputJump>d__13(<>1__state:  0);
            mem[536900367] = this;
        }
        private System.Collections.IEnumerator RandomInputSpeed()
        {
            536900353 = new PlayerInputBot.<RandomInputSpeed>d__14(<>1__state:  0);
            mem[536900369] = this;
        }
        private void Update()
        {
            var val_7;
            bool val_15;
            float val_16;
            UnityEngine.Vector3 val_17;
            UnityEngine.CollisionFlags val_1 = this._characterController.collisionFlags;
            if(this._characterController != 1)
            {
                    this.currentSpeed = 0f;
            }
            
            UnityEngine.CollisionFlags val_2 = this._characterController.collisionFlags;
            if(this._characterController == 4)
            {
                    float val_3 = UnityEngine.Time.deltaTime;
                mem[1152921510003351516] = ;
            }
            else
            {
                    this.totalJumps = 0;
                mem[1152921510003351516] = 3212836864;
            }
            
            val_15 = this._fakeInputJump;
            if(val_15 != false)
            {
                    if(this.totalJumps < this.jumpsAllowed)
            {
                    this.jumpsAllowed = this.jumpHeight;
                this.totalJumps = this.totalJumps + 1;
                this.totalJumps = this.totalJumps;
                mem[1152921510003351516] = this.jumpsAllowed;
            }
            
            }
            
            float val_15 = this.runSpeed;
            val_15 = this._fakeInputHorizontalAxis * val_15;
            float val_4 = this.totalJumps.IncrementTowards(n:  val_15, target:  null, a:  this._fakeInputHorizontalAxis);
            this.currentSpeed = this.totalJumps;
            UnityEngine.Transform val_5 = this._characterController.transform;
            UnityEngine.Vector3 val_6 = position;
            if(this != 0)
            {
                    UnityEngine.Transform val_8 = this.transform;
                UnityEngine.Vector3 val_9 = position;
                val_16 = -val_7;
                mem[1152921510003351520] = val_16;
            }
            
            this.amountToMove = this.currentSpeed;
            if(this != 0)
            {
                    float val_10 = UnityEngine.Mathf.Sign(f:  val_16);
                this.Body.localScale = new UnityEngine.Vector3() {x = this.currentSpeed, y = 1f, z = 0f};
                val_17 = this.amountToMove;
            }
            
            float val_11 = UnityEngine.Time.deltaTime;
            uint val_16 = 0;
            val_16 = val_17 * val_16;
            UnityEngine.CollisionFlags val_14 = this._characterController.Move(motion:  new UnityEngine.Vector3() {y = S18 * val_16, z = S20 * val_16});
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
        public PlayerInputBot()
        {
            this.jumpsAllowed = 2;
        }
    
    }

}
