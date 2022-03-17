using UnityEngine;

namespace CutTheRope.Script
{
    public class MyRope : MonoBehaviour
    {
        // Fields
        private bool canConnect;
        public float cercleColiderRadius;
        private UnityEngine.GameObject Day;
        public UnityEngine.Rigidbody2D hook;
        private UnityEngine.LineRenderer line;
        public UnityEngine.GameObject linkPrefab;
        public CutTheRope.Script.typeRope mtypeRope;
        public int numberlinks;
        public int segments;
        
        // Methods
        private void CreatePoints()
        {
            int val_3 = this.segments;
            val_3 = val_3 + 1;
            if(val_3 < 1)
            {
                    return;
            }
            
            float val_8 = 20f;
            var val_5 = 0;
            do
            {
                float val_1 = val_8 * 0.01745329f;
                float val_4 = val_1;
                val_4 = val_4 * this.cercleColiderRadius;
                this.line.SetPosition(index:  0, position:  new UnityEngine.Vector3() {x = val_1 * this.cercleColiderRadius, y = val_4, z = 0f});
                int val_6 = this.segments;
                val_5 = val_5 + 1;
                val_6 = val_6 + 1;
                float val_7 = (float)val_6;
                val_7 = 360f / val_7;
                val_8 = val_8 + val_7;
            }
            while(val_5 < val_6);
        
        }
        private void Start()
        {
            536887303 = new UnityEngine.GameObject(name:  -1610608877);
            this.Day = 536887303;
            UnityEngine.Transform val_2 = this.Day.transform;
            UnityEngine.Transform val_3 = this.transform;
            this.Day.parent = 1104103472;
            if(this.mtypeRope != 0)
            {
                    UnityEngine.GameObject val_4 = this.gameObject;
                DropdownItem val_5 = this.GetComponentInChildren<DropdownItem>();
                this.line = this;
                this.SetVertexCount(count:  this.segments + 1);
                this.useWorldSpace = false;
                this.CreatePoints();
                this.GenerateColiderCollect();
                return;
            }
            
            this.GenerateRope();
        }
        private void GenerateColiderCollect()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SynchronizationContextBehavoir val_2 = this.AddComponent<SynchronizationContextBehavoir>();
            if(this != 0)
            {
                    this.radius = null;
            }
            else
            {
                    this.radius = null;
            }
            
            this.isTrigger = true;
        }
        private void GenerateRope()
        {
            float val_7;
            if(this.numberlinks < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            val_7 = 4.014704E-38f;
            do
            {
                UnityEngine.Transform val_1 = this.Day.transform;
                UnityEngine.RectTransform val_2 = UnityEngine.Object.Instantiate<UnityEngine.RectTransform>(original:  this.linkPrefab, parent:  this.Day);
                Weight val_3 = this.linkPrefab.GetComponent<Weight>();
                if(val_7 <= 3)
            {
                    Weight val_4 = this.linkPrefab.GetComponent<Weight>();
                UnityEngine.Object.Destroy(obj:  this.linkPrefab);
                if(val_7 == 0)
            {
                    UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
                this.linkPrefab.connectedAnchor = new UnityEngine.Vector2() {x = R4, y = SL};
                val_7 = 4.014704E-38f;
            }
            
            }
            
                this.linkPrefab.connectedBody = this.hook;
                Weight val_6 = this.linkPrefab.GetComponent<Weight>();
                val_7 = val_7 + 1;
            }
            while(val_7 < this.numberlinks);
        
        }
        private void OnTriggerEnter2D(UnityEngine.Collider2D other)
        {
        
        }
        public MyRope()
        {
            this.cercleColiderRadius = 1f;
            this.canConnect = true;
            this.numberlinks = 7;
            this.segments = 50;
        }
    
    }

}
