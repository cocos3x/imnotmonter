using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class Pool : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject thing;
        private System.Collections.Generic.List<UnityEngine.GameObject> things;
        
        // Properties
        public UnityEngine.GameObject nextThing { get; set; }
        
        // Methods
        public UnityEngine.GameObject get_nextThing()
        {
            if(true <= 0)
            {
                    DropdownItem val_1 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this.thing);
                UnityEngine.Transform val_2 = this.thing.transform;
                UnityEngine.Transform val_3 = this.transform;
                this.thing.parent = 1097880880;
                this.thing.SetActive(value:  false);
                this.things.Add(item:  this.thing);
                SynchronizationContextBehavoir val_4 = this.thing.AddComponent<SynchronizationContextBehavoir>();
                mem2[0] = this;
            }
            
            if((this.thing + 12) == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.things.RemoveAt(index:  0);
            2621443.SetActive(value:  true);
        }
        public void set_nextThing(UnityEngine.GameObject value)
        {
            value.SetActive(value:  false);
            this.things.Add(item:  value);
        }
        public Pool()
        {
            536877883 = new System.Collections.Generic.List<Page>();
            this.things = 536877883;
        }
    
    }

}
