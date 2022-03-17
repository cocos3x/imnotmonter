using UnityEngine;

namespace WrappingRopeLibrary.Model
{
    public class Edge
    {
        // Fields
        private UnityEngine.Vector3 <Vertex1>k__BackingField;
        private UnityEngine.Vector3 <Vertex2>k__BackingField;
        private int <TriangleIndex>k__BackingField;
        
        // Properties
        public UnityEngine.Vector3 Vertex1 { get; set; }
        public UnityEngine.Vector3 Vertex2 { get; set; }
        public int TriangleIndex { get; set; }
        
        // Methods
        public UnityEngine.Vector3 get_Vertex1()
        {
            this.<Vertex1>k__BackingField = R1 + 16;
            this = R1 + 8;
            return new UnityEngine.Vector3();
        }
        public void set_Vertex1(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector3 get_Vertex2()
        {
            this.<Vertex1>k__BackingField = R1 + 28;
            this = R1 + 20;
            return new UnityEngine.Vector3();
        }
        public void set_Vertex2(UnityEngine.Vector3 value)
        {
        
        }
        public int get_TriangleIndex()
        {
            return (int)this.<TriangleIndex>k__BackingField;
        }
        public void set_TriangleIndex(int value)
        {
            this.<TriangleIndex>k__BackingField = value;
        }
        public Edge()
        {
        
        }
    
    }

}
