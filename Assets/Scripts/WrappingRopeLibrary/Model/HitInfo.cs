using UnityEngine;

namespace WrappingRopeLibrary.Model
{
    public class HitInfo
    {
        // Fields
        private int <TriangleIndex>k__BackingField;
        private UnityEngine.Vector3 <Normal>k__BackingField;
        private UnityEngine.Vector3 <Point>k__BackingField;
        private UnityEngine.Rigidbody <Rigidbody>k__BackingField;
        private UnityEngine.GameObject <GameObject>k__BackingField;
        
        // Properties
        public int TriangleIndex { get; set; }
        public UnityEngine.Vector3 Normal { get; set; }
        public UnityEngine.Vector3 Point { get; set; }
        public UnityEngine.Rigidbody Rigidbody { get; set; }
        public UnityEngine.GameObject GameObject { get; set; }
        
        // Methods
        public int get_TriangleIndex()
        {
            return (int)this.<TriangleIndex>k__BackingField;
        }
        public void set_TriangleIndex(int value)
        {
            this.<TriangleIndex>k__BackingField = value;
        }
        public UnityEngine.Vector3 get_Normal()
        {
            this.<TriangleIndex>k__BackingField = R1 + 20;
            this = R1 + 12;
            return new UnityEngine.Vector3();
        }
        public void set_Normal(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_Point()
        {
            this.<TriangleIndex>k__BackingField = R1 + 32;
            this = R1 + 24;
            return new UnityEngine.Vector3();
        }
        public void set_Point(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Rigidbody get_Rigidbody()
        {
        
        }
        public void set_Rigidbody(UnityEngine.Rigidbody value)
        {
            this.<Rigidbody>k__BackingField = value;
        }
        public UnityEngine.GameObject get_GameObject()
        {
        
        }
        public void set_GameObject(UnityEngine.GameObject value)
        {
            this.<GameObject>k__BackingField = value;
        }
        public HitInfo()
        {
        
        }
        public HitInfo(UnityEngine.RaycastHit raycastHit)
        {
            this.<TriangleIndex>k__BackingField = raycastHit.m_Point.x.triangleIndex;
            UnityEngine.Vector3 val_2 = normal;
            UnityEngine.Vector3 val_3 = point;
            UnityEngine.Rigidbody val_4 = raycastHit.m_Point.x.rigidbody;
            this.<Rigidbody>k__BackingField = ;
            UnityEngine.Collider val_5 = raycastHit.m_Point.x.collider;
            UnityEngine.GameObject val_6 = raycastHit.m_Point.x.gameObject;
            this.<GameObject>k__BackingField = ;
        }
    
    }

}
