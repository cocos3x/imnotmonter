using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class PlayerInput : MonoBehaviour
    {
        // Fields
        public float RunSpeed;
        public float Acceleration;
        private float _currentSpeedH;
        private float _currentSpeedV;
        private UnityEngine.Vector3 _amountToMove;
        private int _totalJumps;
        private UnityEngine.CharacterController _characterController;
        private bool _movementAllowed;
        
        // Methods
        private void Start()
        {
            var val_5;
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this._characterController = this;
            T[] val_2 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
            val_5 = 0;
            goto label_3;
            label_11:
            536896275 = new UnityEngine.Events.UnityAction(object:  1097180208, method:  new IntPtr(1610685983));
            mem[3221279063] + 44.AddListener(call:  536896275);
            536896275 = new UnityEngine.Events.UnityAction(object:  1097180208, method:  new IntPtr(1610685985));
            mem[3221279063] + 52.AddListener(call:  536896275);
            val_5 = 1;
            label_3:
            if(val_5 < mem[3221279059])
            {
                goto label_11;
            }
        
        }
        private void Update()
        {
            if(this._movementAllowed == false)
            {
                    return;
            }
            
            float val_1 = UnityEngine.Input.GetAxis(axisName:  -1610607721);
            uint val_9 = 2684359575;
            val_9 = val_9 * this.RunSpeed;
            float val_2 = this.IncrementTowards(n:  val_9, target:  null, a:  this.RunSpeed);
            this._currentSpeedH = -1.08485E-19f;
            float val_3 = UnityEngine.Input.GetAxis(axisName:  -1610602649);
            uint val_10 = 2684364647;
            val_10 = val_10 * this.RunSpeed;
            float val_4 = this.IncrementTowards(n:  val_10, target:  null, a:  this.RunSpeed);
            mem[1152921509999110612] = -1610602649;
            this._currentSpeedV = -1.085506E-19f;
            this._amountToMove = this._currentSpeedH;
            float val_5 = UnityEngine.Time.deltaTime;
            uint val_11 = 0;
            val_11 = val_11 * this._currentSpeedH;
            UnityEngine.CollisionFlags val_8 = this._characterController.Move(motion:  new UnityEngine.Vector3() {y = S16 * val_11, z = 2684364647 * val_11});
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
            this.RunSpeed = 12f;
            this.Acceleration = 30f;
            this._movementAllowed = true;
        }
        private void <Start>b__8_0()
        {
            this._movementAllowed = false;
            this._currentSpeedH = false;
            this._currentSpeedV = false;
        }
        private void <Start>b__8_1()
        {
            this._movementAllowed = true;
        }
    
    }

}
