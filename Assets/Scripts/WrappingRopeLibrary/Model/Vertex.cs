using UnityEngine;

namespace WrappingRopeLibrary.Model
{
    public struct Vertex
    {
        // Fields
        private UnityEngine.Vector3 <Position>k__BackingField;
        private UnityEngine.Vector2 <Uv>k__BackingField;
        private UnityEngine.Vector3 <Normal>k__BackingField;
        private int[] <NodeIndex>k__BackingField;
        
        // Properties
        public UnityEngine.Vector3 Position { get; set; }
        public UnityEngine.Vector2 Uv { get; set; }
        public UnityEngine.Vector3 Normal { get; set; }
        public int[] NodeIndex { get; set; }
        
        // Methods
        public UnityEngine.Vector3 get_Position()
        {
            mem[1152921509798987352] = R1 + 8;
            this = R1;
            return new UnityEngine.Vector3();
        }
        public void set_Position(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector2 get_Uv()
        {
            this = R1 + 12;
            mem[1152921509799211348] = R1 + 16;
            return new UnityEngine.Vector2();
        }
        public void set_Uv(UnityEngine.Vector2 value)
        {
            this.<Uv>k__BackingField = value;
            mem[1152921509799323360] = value.y;
        }
        public UnityEngine.Vector3 get_Normal()
        {
            mem[1152921509799435352] = R1 + 28;
            this = R1 + 20;
            return new UnityEngine.Vector3();
        }
        public void set_Normal(UnityEngine.Vector3 value)
        {
        
        }
        public int[] get_NodeIndex()
        {
        
        }
        public void set_NodeIndex(int[] value)
        {
            this.<NodeIndex>k__BackingField = value;
        }
        public Vertex(UnityEngine.Vector3 position, int[] nodeIndex, UnityEngine.Vector2 uv)
        {
            mem[1152921509800067692] = 0;
            this.<NodeIndex>k__BackingField = nodeIndex;
            this.<Uv>k__BackingField = uv;
            mem[1152921509800067680] = uv.y;
        }
        public Vertex(UnityEngine.Vector3 position, int[] nodeIndex, UnityEngine.Vector2 uv, UnityEngine.Vector3 normal)
        {
            mem[1152921509800253420] = 0;
            this.<NodeIndex>k__BackingField = nodeIndex;
            this.<Uv>k__BackingField = uv;
            mem[1152921509800253408] = uv.y;
            this.<Normal>k__BackingField = normal;
            mem[1152921509800253416] = normal.y;
            mem[1152921509800253420] = normal.z;
        }
    
    }

}
