using UnityEngine;

namespace WrappingRopeLibrary.Model
{
    [Serializable]
    public struct Node
    {
        // Fields
        public UnityEngine.Vector3 _vertex;
        public UnityEngine.Vector2 _uv;
        public int _normalCount;
        public UnityEngine.Vector3[] Normals;
        private int <VertexIndex>k__BackingField;
        private int <UvLeamVertexIndex>k__BackingField;
        public UnityEngine.Vector3 _averageNormal;
        
        // Properties
        public UnityEngine.Vector3 Vertex { get; set; }
        public UnityEngine.Vector2 Uv { get; set; }
        public int VertexIndex { get; set; }
        public int UvLeamVertexIndex { get; set; }
        
        // Methods
        public UnityEngine.Vector3 get_Vertex()
        {
            mem[1152921509796184664] = R1 + 8;
            this = R1;
            return new UnityEngine.Vector3();
        }
        public void set_Vertex(UnityEngine.Vector3 value)
        {
        
        }
        public UnityEngine.Vector2 get_Uv()
        {
            this = R1 + 12;
            mem[1152921509796408660] = R1 + 16;
            return new UnityEngine.Vector2();
        }
        public void set_Uv(UnityEngine.Vector2 value)
        {
            this._uv = value;
            mem[1152921509796520672] = value.y;
        }
        public int get_VertexIndex()
        {
            return (int)this.<VertexIndex>k__BackingField;
        }
        public void set_VertexIndex(int value)
        {
            this.<VertexIndex>k__BackingField = value;
        }
        public int get_UvLeamVertexIndex()
        {
            return (int)this.<UvLeamVertexIndex>k__BackingField;
        }
        public void set_UvLeamVertexIndex(int value)
        {
            this.<UvLeamVertexIndex>k__BackingField = value;
        }
        public Node(int normalsCount)
        {
            this = 536882597;
        }
        public void AddNormal(UnityEngine.Vector3 normal)
        {
            this.Normals[(this._normalCount + (this._normalCount << 1)) << 2] = normal;
            this.Normals[(this._normalCount + (this._normalCount << 1)) << 2] = normal.y;
            this.Normals[(this._normalCount + (this._normalCount << 1)) << 2] = normal.z;
            int val_2 = this._normalCount;
            val_2 = val_2 + 1;
            this._normalCount = val_2;
        }
        public UnityEngine.Vector3 GetAverageNormal()
        {
            float val_2;
            float val_3;
            float val_4;
            float val_9;
            var val_10;
            val_9 = mem[R1 + 36];
            val_9 = R1 + 36;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_9, y = mem[R1 + 36 + (4)], z = mem[R1 + 36 + (8)]}, rhs:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_2})) != false)
            {
                    if((R1 + 20) >= 2)
            {
                    var val_9 = 1;
                do
            {
                val_10 = mem[R1 + 24];
                val_10 = R1 + 24;
                var val_6 = val_10 + 0;
                float val_10 = R1 + 24 + 16;
                float val_11 = 0f;
                val_9 = 0 + 12;
                val_9 = val_9 + 1;
                float val_12 = R1 + 24 + 24;
                val_10 = ((R1 + 24 + 0) + 28) + val_10;
                val_11 = ((R1 + 24 + 0) + 32) + val_11;
                val_12 = ((R1 + 24 + 0) + 36) + val_12;
            }
            while(val_9 < (R1 + 20));
            
            }
            
                UnityEngine.Vector3 val_7 = normalized;
                var val_8 = R1 + 36;
            }
            
            mem[1152921509797378392] = R1 + 36 + 8;
            this = R1 + 36;
            return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        public void ResetNormals()
        {
            this._normalCount = 0;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        }
    
    }

}
