using UnityEngine;

namespace Vectrosity
{
    public class VisibilityControlAlways : MonoBehaviour
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
        public void Setup(Vectrosity.VectorLine line)
        {
            UnityEngine.Transform val_1 = this.transform;
            Vectrosity.VectorManager.VisibilitySetup(thisTransform:  433949648, line:  line, objectNum: out  this.m_objectNumber);
            Vectrosity.VectorManager.DrawArrayLine2(i:  mem[this.m_objectNumber] + 8);
            this.m_vectorLine = line;
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
        public VisibilityControlAlways()
        {
        
        }
    
    }

}
