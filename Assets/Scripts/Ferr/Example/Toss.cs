using UnityEngine;

namespace Ferr.Example
{
    public class Toss : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector3 start;
        private UnityEngine.Animator animator;
        public UnityEngine.GameObject visual;
        public bool swipeToJump;
        private UnityEngine.Rigidbody2D body;
        
        // Methods
        private void Start()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.body = this;
            this.body.gravityScale = null;
            Weight val_2 = this.visual.GetComponent<Weight>();
            this.animator = this.visual;
        }
        private void Update()
        {
            float val_4;
            float val_5;
            float val_6;
            float val_9;
            float val_24;
            float val_32;
            float val_33;
            var val_34;
            float val_35;
            float val_36;
            float val_37;
            float val_38;
            float val_1 = this.body.gravityScale;
            if(this.body > 0)
            {
                    UnityEngine.Transform val_2 = this.visual.transform;
                val_32 = this.visual;
                UnityEngine.Vector3 val_3 = UnityEngine.Vector3.right;
                UnityEngine.Vector2 val_7 = velocity;
                UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = 4.208435E+07f, y = val_4, z = val_5}, toDirection:  new UnityEngine.Vector3() {x = val_6, y = val_4, z = val_5});
                val_32.rotation = new UnityEngine.Quaternion() {x = R4, y = R5, z = R7, w = val_9};
                UnityEngine.Transform val_10 = this.visual.transform;
                val_33 = this.visual;
                val_34 = 0;
                UnityEngine.Vector3 val_11 = eulerAngles;
                float val_31 = -90f;
                val_31 = val_6 + val_31;
                val_35 = val_4;
                val_33.eulerAngles = new UnityEngine.Vector3() {x = val_35, y = val_5, z = val_31};
            }
            
            if((UnityEngine.Input.GetButtonDown(buttonName:  -1610608129)) != false)
            {
                    UnityEngine.Vector3 val_13 = UnityEngine.Input.mousePosition;
                return;
            }
            
            if((UnityEngine.Input.GetButtonUp(buttonName:  -1610608129)) == false)
            {
                    return;
            }
            
            UnityEngine.Camera val_15 = UnityEngine.Camera.main;
            UnityEngine.Vector3 val_16 = UnityEngine.Input.mousePosition;
            UnityEngine.Ray val_17 = ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_5});
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.forward;
            UnityEngine.Transform val_19 = this.transform;
            val_32 = R6 ^ 2147483648;
            val_34 = 0;
            UnityEngine.Vector3 val_22 = position;
            UnityEngine.Plane val_23 = new UnityEngine.Plane(inNormal:  new UnityEngine.Vector3() {x = R4 ^ 2147483648, y = R5 ^ 2147483648, z = val_32}, d:  val_6);
            bool val_26 = Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_17.m_Direction.y}, m_Direction = new UnityEngine.Vector3() {y = val_35, z = val_24}}, enter: out  0f);
            if(this.swipeToJump != false)
            {
                    UnityEngine.Vector3 val_27 = UnityEngine.Input.mousePosition;
                val_36 = val_23.m_Normal.x - this.start;
                val_37 = 2.1f;
                val_38 = val_23.m_Normal.y - S6;
            }
            else
            {
                    UnityEngine.Vector3 val_28 = val_23.m_Normal.x.GetPoint(distance:  val_6);
                UnityEngine.Transform val_29 = this.body.transform;
                UnityEngine.Vector3 val_30 = val_23.m_Normal.x.position;
                val_36 = val_23.m_Normal.x - val_23.m_Normal.x;
                val_37 = 100f;
                val_38 = val_23.m_Normal.y - val_23.m_Normal.y;
            }
            
            val_38 = val_38 * val_37;
            val_36 = val_36 * val_37;
            val_33 = val_36;
            this.body.AddForce(force:  new UnityEngine.Vector2() {x = val_33, y = val_38});
            this.animator.SetTrigger(name:  -1610606789);
            this.body.gravityScale = val_36;
        }
        private void OnCollisionEnter2D(UnityEngine.Collision2D collision)
        {
            float val_2;
            float val_3;
            this.animator.SetTrigger(name:  -1610606723);
            this.body.gravityScale = null;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.body.velocity = new UnityEngine.Vector2() {x = val_2, y = val_3};
            this.body.Sleep();
            UnityEngine.Transform val_4 = this.visual.transform;
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.right;
            UnityEngine.ContactPoint2D[] val_6 = collision.contacts;
            UnityEngine.Vector2 val_7 = normal;
            float val_8 = Ferr.PathUtil.ClockwiseAngle(v1:  new UnityEngine.Vector2() {x = val_2, y = val_3}, v2:  new UnityEngine.Vector2());
            float val_9 = 360f;
            val_9 = val_9 - val_2;
            val_9 = val_9 + 270f;
            this.visual.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_9};
        }
        public Toss()
        {
        
        }
    
    }

}
