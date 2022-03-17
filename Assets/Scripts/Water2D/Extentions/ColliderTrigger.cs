using UnityEngine;

namespace Water2D.Extentions
{
    public class ColliderTrigger : MonoBehaviour
    {
        // Fields
        public Water2D.ColliderFiller colliderFiller;
        public System.Collections.Generic.List<string> tags;
        public bool check;
        public UnityEngine.Events.UnityEvent onTrue;
        public UnityEngine.Events.UnityEvent onFalse;
        private System.Collections.Generic.List<UnityEngine.Transform> inArea;
        
        // Methods
        private void Start()
        {
            if(this.inArea == 0)
            {
                    536878437 = new System.Collections.Generic.List<Page>();
                this.inArea = 536878437;
            }
            
            if(this.onFalse == 0)
            {
                    return;
            }
            
            this.onFalse.Invoke();
        }
        private void Apply(bool active)
        {
            if(active == true)
            {
                    this = this.onTrue;
            }
            
            if(this == 0)
            {
                    return;
            }
            
            this.Invoke();
        }
        private bool CheckFilled()
        {
            var val_3;
            if(this.inArea != 0)
            {
                goto label_1;
            }
            
            536878437 = new System.Collections.Generic.List<Page>();
            this.inArea = 536878437;
            if(this.inArea == 0)
            {
                goto label_2;
            }
            
            label_1:
            val_3 = 0;
            if(this.colliderFiller == 0)
            {
                    return (bool)val_3;
            }
            
            if(mem[536878449] >= 0)
            {
                    val_3 = 1;
            }
            
            return (bool)val_3;
            label_2:
            val_3 = 0;
            return (bool)val_3;
        }
        private void OnTriggerEnter2D(UnityEngine.Collider2D collision)
        {
            System.Collections.Generic.List<System.String> val_8;
            string val_9;
            val_8 = 22974495;
            if(this.check == false)
            {
                    return;
            }
            
            val_8 = this.tags;
            string val_1 = collision.tag;
            val_9 = collision;
            if((val_8.Contains(item:  val_9)) == false)
            {
                    return;
            }
            
            val_9 = this.inArea;
            if(val_9 == 0)
            {
                    536878437 = new System.Collections.Generic.List<Page>();
                this.inArea = 536878437;
                val_9 = this.inArea;
            }
            
            UnityEngine.Transform val_4 = collision.transform;
            val_8 = collision;
            if((val_9.Contains(item:  val_8)) != false)
            {
                    return;
            }
            
            UnityEngine.Transform val_6 = collision.transform;
            this.inArea.Add(item:  collision);
            this.Apply(active:  this.CheckFilled());
        }
        private void OnTriggerExit2D(UnityEngine.Collider2D collision)
        {
            System.Collections.Generic.List<System.String> val_9;
            string val_10;
            val_9 = 22974496;
            if(this.check == false)
            {
                    return;
            }
            
            val_9 = this.tags;
            string val_1 = collision.tag;
            val_10 = collision;
            if((val_9.Contains(item:  val_10)) == false)
            {
                    return;
            }
            
            val_10 = this.inArea;
            if(val_10 == 0)
            {
                    536878437 = new System.Collections.Generic.List<Page>();
                this.inArea = 536878437;
                val_10 = this.inArea;
            }
            
            UnityEngine.Transform val_4 = collision.transform;
            val_9 = collision;
            if((val_10.Contains(item:  val_9)) == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_6 = collision.transform;
            bool val_7 = this.inArea.Remove(item:  collision);
            this.Apply(active:  this.CheckFilled());
        }
        public ColliderTrigger()
        {
            536878341 = new System.Collections.Generic.List<Page>();
            536878341.Add(item:  -1610606363);
            this.tags = 536878341;
        }
    
    }

}
