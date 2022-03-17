using UnityEngine;

namespace WrappingRope.Demo
{
    public class Man1Controller : MonoBehaviour
    {
        // Fields
        public float stepSpeed;
        public float rotateSpeed;
        private UnityEngine.CharacterController _controller;
        private UnityEngine.Animator _anim;
        private float g;
        private float jf;
        private float vv;
        private System.Collections.Generic.List<UnityEngine.Vector3> _externalForces;
        
        // Methods
        private void Start()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this._controller = this;
            UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
            this._anim = this;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this._externalForces = 536878517;
        }
        private void Update()
        {
            var val_4;
            var val_5;
            var val_6;
            float val_1 = UnityEngine.Input.GetAxis(axisName:  -1610602649);
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Vector3 val_3 = TransformDirection(direction:  new UnityEngine.Vector3() {x = 6.968119E-06f, y = 0f, z = 0f});
            var val_34 = val_4;
            var val_33 = val_5;
            var val_32 = val_6;
            UnityEngine.Transform val_7 = this.transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.down;
            float val_9 = UnityEngine.Input.GetAxis(axisName:  -1610607721);
            uint val_31 = 2684359575;
            val_31 = val_4 * val_31;
            this.Rotate(eulers:  new UnityEngine.Vector3() {x = val_31 ^ 2147483648, y = (val_5 * val_31) ^ 2147483648, z = (val_6 * val_31) ^ 2147483648}, relativeTo:  0);
            val_32 = val_32 * this.stepSpeed;
            val_33 = val_33 * this.stepSpeed;
            val_34 = val_34 * this.stepSpeed;
            if(this._controller.isGrounded != false)
            {
                    float val_16 = UnityEngine.Time.deltaTime;
                this.vv = 0;
            }
            else
            {
                    float val_17 = UnityEngine.Time.deltaTime;
                this.vv = this.vv;
            }
            
            UnityEngine.Vector3 val_18 = GetSuperpositionOfExternalForces();
            var val_35 = val_4;
            var val_36 = val_5;
            var val_37 = val_6;
            val_35 = val_34 + val_35;
            val_36 = val_33 + val_36;
            val_37 = val_32 + val_37;
            float val_22 = UnityEngine.Time.deltaTime;
            uint val_38 = 0;
            val_38 = (val_35 + 0f) * val_38;
            UnityEngine.CollisionFlags val_25 = this._controller.Move(motion:  new UnityEngine.Vector3() {y = (val_36 + this.vv) * val_38, z = (val_37 + 0f) * val_38});
            if(this._controller.isGrounded != false)
            {
                    bool val_27 = UnityEngine.Input.GetKeyDown(key:  32);
                if(val_27 == true)
            {
                    val_27 = this.jf;
                mem2[0] = val_27;
            }
            
            }
            
            float val_28 = UnityEngine.Time.deltaTime;
            uint val_39 = 0;
            val_39 = val_39 * 0f;
            UnityEngine.CollisionFlags val_30 = this._controller.Move(motion:  new UnityEngine.Vector3() {y = this.vv * val_39});
            this._externalForces.Clear();
        }
        private void FixedUpdate()
        {
            UnityEngine.Animator val_9;
            var val_10;
            float val_12;
            var val_13;
            float val_1 = UnityEngine.Input.GetAxis(axisName:  -1610602649);
            float val_2 = UnityEngine.Time.deltaTime;
            if(this._anim > 0)
            {
                
            }
            else
            {
                
            }
            
            this._anim.SetFloat(name:  -1610607511, value:  0, dampTime:  null, deltaTime:  null);
            float val_3 = UnityEngine.Input.GetAxis(axisName:  -1610607721);
            if(this._anim > 0)
            {
                    val_9 = this._anim;
                val_10 = 0;
                float val_4 = UnityEngine.Time.deltaTime;
                val_12 = 0;
                val_13 = 22792648;
            }
            else
            {
                    float val_5 = UnityEngine.Input.GetAxis(axisName:  -1610607721);
                if(this._anim < 0)
            {
                    val_9 = this._anim;
                val_10 = 0;
                float val_6 = UnityEngine.Time.deltaTime;
                val_12 = 0;
                val_13 = 22792648;
            }
            else
            {
                    float val_7 = UnityEngine.Input.GetAxis(axisName:  -1610607721);
                if(this._anim != 0)
            {
                    return;
            }
            
                val_9 = this._anim;
                val_10 = 0;
                val_12 = 0;
                val_13 = 22792648;
            }
            
            }
            
            val_9.SetFloat(name:  -1610604845, value:  UnityEngine.Time.deltaTime, dampTime:  null, deltaTime:  null);
        }
        private UnityEngine.Vector3 GetSuperpositionOfExternalForces()
        {
            float val_2;
            var val_3;
            var val_4;
            float val_6;
            var val_7;
            float val_9;
            float val_10;
            WrappingRope.Demo.Man1Controller val_11;
            float val_12;
            float val_13;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_11 = val_2;
            val_12 = val_3;
            val_13 = val_4;
            List.Enumerator<T> val_5 = GetEnumerator();
            goto label_2;
            label_3:
            val_9 = val_6;
            val_10 = 0f;
            val_11 = val_11 + val_9;
            val_12 = val_12 + val_10;
            val_13 = val_13 + val_7;
            label_2:
            if(val_2.MoveNext() == true)
            {
                goto label_3;
            }
            
            val_2.Dispose();
            this = val_11;
            mem[1152921509823384244] = val_12;
            mem[1152921509823384248] = val_13;
            return new UnityEngine.Vector3() {x = val_9, y = val_1.y, z = val_10};
        }
        public void AddForce(UnityEngine.Vector3 force)
        {
            this._externalForces.Add(item:  new UnityEngine.Vector3() {x = force.x, y = force.y, z = force.z});
        }
        public Man1Controller()
        {
            this.stepSpeed = 1f;
            this.rotateSpeed = 1f;
            this.g = 10f;
            this.jf = 3f;
        }
    
    }

}
