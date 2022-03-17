using UnityEngine;

namespace Vectrosity
{
    public class VisibilityControlStatic : MonoBehaviour
    {
        // Fields
        private Vectrosity.RefInt m_objectNumber;
        private Vectrosity.VectorLine m_vectorLine;
        private bool m_destroyed;
        private bool m_dontDestroyLine;
        private UnityEngine.Matrix4x4 m_originalMatrix;
        
        // Properties
        public Vectrosity.RefInt objectNumber { get; }
        
        // Methods
        public Vectrosity.RefInt get_objectNumber()
        {
        
        }
        public void Setup(Vectrosity.VectorLine line, bool makeBounds)
        {
            var val_13;
            var val_14;
            if(makeBounds != false)
            {
                    UnityEngine.GameObject val_1 = this.gameObject;
                Vectrosity.VectorManager.SetupBoundsMesh(go:  435247184, line:  line);
            }
            
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Matrix4x4 val_3 = localToWorldMatrix;
            float val_4 = val_3.m11 + 32;
            float val_5 = val_3.m31 + 24;
            float val_6 = val_3.m11 + 16;
            float val_7 = val_3.m31 + 40;
            float val_8 = val_3.m31 + 56;
            float val_9 = val_3.m31 + 72;
            mem2[0] = val_3.m31;
            mem2[0] = val_3.m02;
            float val_10 = val_3.m13 + 20;
            val_13 = 0;
            val_14 = 0;
            goto label_6;
            label_9:
            var val_13 = mem[536878525];
            val_13 = val_13 + val_13;
            val_13 = 12;
            val_14 = 1;
            label_6:
            if(val_14 < mem[536878529])
            {
                goto label_9;
            }
            
            mem2[0] = val_3.m13 + 12;
            var val_11 = (val_3.m13 + 16 + 16) - 4;
            float val_12 = val_3.m32 - 28;
        }
        private System.Collections.IEnumerator WaitCheck()
        {
            536902355 = new System.Object();
            mem[536902363] = 0;
            mem[536902371] = this;
        }
        private void OnBecameVisible()
        {
            this.m_vectorLine.active = true;
            Vectrosity.VectorManager.DrawArrayLine(i:  this.m_objectNumber.i);
        }
        private void OnBecameInvisible()
        {
            this.m_vectorLine.active = false;
        }
        private void OnDestroy()
        {
            if(this.m_destroyed != false)
            {
                    return;
            }
            
            this.m_destroyed = true;
            Vectrosity.VectorManager.VisibilityStaticRemove(objectNumber:  this.m_objectNumber.i);
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
        public UnityEngine.Matrix4x4 GetMatrix()
        {
            var val_1 = R1 + 24;
            return new UnityEngine.Matrix4x4() {m00 = 2.607294E-23f, m10 = (R1 + 24) + (20) + (20), m20 = mem[(R1 + 24) + (20) + (20) + (0)], m30 = mem[(R1 + 24) + (20) + (20) + (4)], m03 = mem[(R1 + 24) + (20) + (20) + (16)], m13 = 2.605394E-23f, m23 = mem[(R1 + 24) + (20) + (20) + (20)]};
        }
        public VisibilityControlStatic()
        {
        
        }
    
    }

}
