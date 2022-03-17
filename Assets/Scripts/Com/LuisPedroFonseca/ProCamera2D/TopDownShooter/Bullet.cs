using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class Bullet : MonoBehaviour
    {
        // Fields
        public float BulletDuration;
        public float BulletSpeed;
        public float SkinWidth;
        public UnityEngine.LayerMask CollisionMask;
        public float BulletDamage;
        private UnityEngine.Transform _transform;
        private UnityEngine.RaycastHit _raycastHit;
        private UnityEngine.Vector2 _collisionPoint;
        private float _startTime;
        private bool _exploding;
        private UnityEngine.Vector3 _lastPos;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            this._transform = this;
        }
        private void OnEnable()
        {
            this._exploding = false;
            float val_1 = UnityEngine.Time.time;
            this._startTime = 0f;
        }
        private void Update()
        {
            float val_3;
            float val_4;
            float val_5;
            UnityEngine.Transform val_21;
            float val_22;
            float val_23;
            float val_24;
            if(this._exploding == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_1 = position;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
            float val_6 = val_3 * this.BulletSpeed;
            float val_7 = val_4 * this.BulletSpeed;
            float val_9 = UnityEngine.Time.deltaTime;
            uint val_21 = 0;
            val_21 = val_6 * val_21;
            this._transform.Translate(translation:  new UnityEngine.Vector3() {y = val_7 * val_21, z = (val_5 * this.BulletSpeed) * val_21});
            UnityEngine.Vector3 val_12 = position;
            float val_22 = val_3;
            float val_23 = val_4;
            val_22 = val_22 - this._lastPos;
            float val_24 = val_5;
            val_23 = val_23 - val_6;
            val_21 = this._transform;
            val_24 = val_24 - val_7;
            val_22 = val_22;
            val_23 = val_23;
            val_24 = val_24;
            UnityEngine.Vector3 val_13 = position;
            float val_25 = val_3;
            float val_26 = val_4;
            float val_27 = val_5;
            val_25 = this._lastPos - val_25;
            val_26 = val_6 - val_26;
            val_27 = val_7 - val_27;
            float val_14 = val_25.magnitude;
            float val_16 = 1081987224 + this.SkinWidth;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = this._lastPos, y = this._lastPos, z = SL}, direction:  new UnityEngine.Vector3() {x = val_22, y = val_23, z = val_24}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this._raycastHit, y = val_16, z = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.CollisionMask})}, m_Normal = new UnityEngine.Vector3() {x = 0f, z = this._lastPos}, m_FaceID = this._lastPos, m_UV = new UnityEngine.Vector2(), m_Collider = val_25}, maxDistance:  val_16, layerMask:  val_26)) != false)
            {
                    val_23 = 0;
                UnityEngine.Vector3 val_18 = point;
                val_22 = this._transform;
                this._collisionPoint = val_3;
                mem[1152921509983813636] = val_4;
                UnityEngine.Vector3 val_19 = normal;
                val_22.up = new UnityEngine.Vector3() {x = R5, y = R7, z = R8};
                this.Collide();
            }
            
            float val_20 = UnityEngine.Time.time;
            float val_28 = this._startTime;
            val_28 = 0 - val_28;
            if(val_22 > 0)
            {
                    0 = this;
                this.Disable();
            }
        
        }
        private void Collide()
        {
            this._exploding = true;
            this._transform.position = new UnityEngine.Vector3() {x = this._collisionPoint, y = R7, z = 0f};
            UnityEngine.Collider val_1 = this._raycastHit.collider;
            this._raycastHit.SendMessageUpwards(methodName:  -1610607727, value:  536893745, options:  1);
            this.Disable();
        }
        private void Disable()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            this.SetActive(value:  false);
        }
        public Bullet()
        {
            this.BulletDuration = 1f;
            this.BulletSpeed = 50f;
            this.SkinWidth = 0.1f;
            this.BulletDamage = 10f;
        }
    
    }

}
