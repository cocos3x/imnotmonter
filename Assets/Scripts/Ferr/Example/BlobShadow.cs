using UnityEngine;

namespace Ferr.Example
{
    public class BlobShadow : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject shadowedObject;
        public UnityEngine.Vector3 offset;
        public float maxDistance;
        public float scaleTo;
        public bool fadeOut;
        private UnityEngine.Renderer renderCom;
        private UnityEngine.Collider2D col2D;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.renderCom = this;
        }
        private void Start()
        {
            DropdownItem val_1 = this.shadowedObject.GetComponentInChildren<DropdownItem>();
            this.col2D = this.shadowedObject;
        }
        private void LateUpdate()
        {
            float val_3;
            float val_4;
            var val_14;
            float val_15;
            UnityEngine.Object val_16;
            UnityEngine.Collider2D val_17;
            var val_18;
            float val_19;
            var val_20;
            UnityEngine.Transform val_1 = this.shadowedObject.transform;
            val_14 = 0;
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.RaycastHit2D[] val_5 = UnityEngine.Physics2D.RaycastAll(origin:  new UnityEngine.Vector2() {x = val_3, y = val_4}, direction:  new UnityEngine.Vector2() {x = 0f, y = -1f}, distance:  val_2.x);
            val_15 = val_3;
            val_16 = val_15 + 16;
            val_18 = 0;
            val_19 = this.maxDistance;
            goto label_5;
            label_14:
            UnityEngine.Vector2 val_6 = point;
            float val_13 = val_3;
            float val_14 = val_4;
            val_13 = val_3 - val_13;
            val_14 = val_4 - val_14;
            float val_7 = val_13.magnitude;
            uint val_15 = 1271810328;
            val_15 = val_15 / this.maxDistance;
            UnityEngine.Collider2D val_8 = val_16.collider;
            val_17 = this.col2D;
            if((mem[536891337] <= 0) && (val_16 != val_17))
            {
                    val_19 = val_15;
                val_18 = 1;
            }
            
            val_16 = val_16 + 36;
            val_14 = 1;
            label_5:
            if(val_14 < (val_3 + 12))
            {
                goto label_14;
            }
            
            if((val_18 & 1) == 0)
            {
                    val_14 = 0;
                UnityEngine.Transform val_10 = val_17.transform;
                UnityEngine.Vector2 val_11 = point;
                float val_16 = val_3;
                float val_17 = val_4;
                val_16 = val_16 + this.offset;
                float val_18 = 0f;
                val_17 = val_17 + S8;
                val_18 = S10 + val_18;
                val_15 = val_16;
                val_16 = val_17;
                val_17 = val_18;
                this.position = new UnityEngine.Vector3() {x = val_15, y = val_16, z = val_17};
                UnityEngine.Vector2 val_12 = normal;
                this.FitGround(aNormal:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = 0f});
                this.Modifiers(aPercent:  val_12.x);
                val_20 = 1;
            }
            else
            {
                    val_20 = 0;
            }
            
            this.renderCom.enabled = false;
        }
        private void Modifiers(float aPercent)
        {
            float val_3;
            float val_4;
            float val_5;
            if(this.fadeOut != false)
            {
                    UnityEngine.Material val_1 = this.renderCom.material;
                UnityEngine.Color val_2 = color;
                UnityEngine.Material val_6 = this.renderCom.material;
                this.renderCom.color = new UnityEngine.Color() {r = val_3, g = val_4, b = val_5, a = 1f};
            }
            
            float val_7 = UnityEngine.Mathf.Lerp(a:  val_2.r, b:  val_2.g, t:  val_2.b);
            UnityEngine.Transform val_8 = this.transform;
            this.localScale = new UnityEngine.Vector3() {x = 1f, y = 1f, z = 1f};
        }
        private void FitGround(UnityEngine.Vector3 aNormal)
        {
            float val_4;
            float val_5;
            float val_6;
            float val_7;
            float val_14;
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.right;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.FromToRotation(fromDirection:  new UnityEngine.Vector3() {x = 2.755186E+07f}, toDirection:  new UnityEngine.Vector3() {y = aNormal.x, z = aNormal.y});
            this.rotation = new UnityEngine.Quaternion() {x = val_4, y = val_5, z = val_6, w = val_7};
            UnityEngine.Transform val_8 = this.transform;
            UnityEngine.Vector3 val_9 = eulerAngles;
            UnityEngine.Transform val_10 = this.transform;
            UnityEngine.Transform val_11 = this.transform;
            if(this != 0)
            {
                    UnityEngine.Vector3 val_12 = eulerAngles;
                val_14 = -270f;
            }
            else
            {
                    UnityEngine.Vector3 val_13 = eulerAngles;
                val_14 = -90f;
            }
            
            val_14 = val_6 + val_14;
            this.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = val_14};
        }
        public BlobShadow()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.fadeOut = true;
        }
    
    }

}
