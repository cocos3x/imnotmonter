using UnityEngine;

namespace Vectrosity
{
    public class VisibilityControl : MonoBehaviour
    {
        // Fields
        private Vectrosity.RefInt m_objectNumber;
        private Vectrosity.VectorLine m_vectorLine;
        private bool m_destroyed;
        private bool m_dontDestroyLine;
        
        // Properties
        public Vectrosity.RefInt objectNumber { get; }
        
        // Methods
        public Vectrosity.RefInt get_objectNumber()
        {
        
        }
        public void Setup(Vectrosity.VectorLine line, bool makeBounds)
        {
            if(makeBounds != false)
            {
                    UnityEngine.GameObject val_1 = this.gameObject;
                Vectrosity.VectorManager.SetupBoundsMesh(go:  433029072, line:  line);
            }
            
            UnityEngine.Transform val_2 = this.transform;
            Vectrosity.VectorManager.VisibilitySetup(thisTransform:  433029072, line:  line, objectNum: out  this.m_objectNumber);
            this.m_vectorLine = line;
            Vectrosity.VectorManager.DrawArrayLine2(i:  this.m_objectNumber.i);
            System.Collections.IEnumerator val_4 = this.VisibilityTest();
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  433029072);
        }
        private System.Collections.IEnumerator VisibilityTest()
        {
            536902353 = new System.Object();
            mem[536902361] = 0;
            mem[536902369] = this;
        }
        private System.Collections.IEnumerator OnBecameVisible()
        {
            536902351 = new System.Object();
            mem[536902359] = 0;
            mem[536902367] = this;
        }
        private System.Collections.IEnumerator OnBecameInvisible()
        {
            536902349 = new System.Object();
            mem[536902357] = 0;
            mem[536902365] = this;
        }
        private void OnDestroy()
        {
            if(this.m_destroyed != false)
            {
                    return;
            }
            
            this.m_destroyed = true;
            Vectrosity.VectorManager.VisibilityRemove(objectNumber:  this.m_objectNumber.i);
            if(this.m_dontDestroyLine == true)
            {
                    return;
            }
            
            Vectrosity.VectorLine.Destroy(line: ref  R4 + 16);
        }
        public void DontDestroyLine()
        {
            this.m_dontDestroyLine = true;
        }
        public VisibilityControl()
        {
        
        }
    
    }

}
