using UnityEngine;

namespace Vectrosity
{
    public class BrightnessControl : MonoBehaviour
    {
        // Fields
        private Vectrosity.RefInt m_objectNumber;
        private Vectrosity.VectorLine m_vectorLine;
        private bool m_useLine;
        private bool m_destroyed;
        
        // Properties
        public Vectrosity.RefInt objectNumber { get; }
        
        // Methods
        public Vectrosity.RefInt get_objectNumber()
        {
        
        }
        public void Setup(Vectrosity.VectorLine line, bool m_useLine)
        {
            float val_4;
            object val_1 = 536892611;
            val_1 = new System.Object();
            mem[536892619] = 0;
            this.m_objectNumber = val_1;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Color val_3 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 124, g = 202, b = 144, a = 21});
            Vectrosity.VectorManager.CheckDistanceSetup(thisTransform:  361822608, line:  line, color:  new UnityEngine.Color() {r = val_4, g = R4}, objectNum:  this.m_objectNumber);
            Vectrosity.VectorManager.SetDistanceColor(i:  0);
            if(m_useLine == false)
            {
                    return;
            }
            
            mem[1152921509263636896] = line;
            mem[1152921509263636900] = 1;
        }
        public void SetUseLine(bool useLine)
        {
            this.m_useLine = useLine;
        }
        private void OnBecameVisible()
        {
            Vectrosity.VectorManager.SetOldDistance(objectNumber:  this.m_objectNumber.i, val:  0);
            Vectrosity.VectorManager.SetDistanceColor(i:  this.m_objectNumber.i);
            if(this.m_useLine == false)
            {
                    return;
            }
            
            this.m_vectorLine.active = true;
        }
        public void OnBecameInvisible()
        {
            if(this.m_useLine == false)
            {
                    return;
            }
            
            this.m_vectorLine.active = false;
        }
        private void OnDestroy()
        {
            if(this.m_destroyed == true)
            {
                    return;
            }
            
            mem2[0] = 1;
            Vectrosity.VectorManager.DistanceRemove(objectNumber:  R4 + 12 + 8);
            if((R4 + 20) == 0)
            {
                    return;
            }
            
            Vectrosity.VectorLine.Destroy(line: ref  R4 + 16);
        }
        public BrightnessControl()
        {
        
        }
    
    }

}
