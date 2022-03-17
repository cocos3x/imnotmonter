using UnityEngine;

namespace Vectrosity
{
    [Serializable]
    public class VectorObject2D : RawImage, IVectorObject
    {
        // Fields
        private bool m_updateVerts;
        private bool m_updateUVs;
        private bool m_updateColors;
        private bool m_updateNormals;
        private bool m_updateTangents;
        private bool m_updateTris;
        private UnityEngine.Mesh m_mesh;
        public Vectrosity.VectorLine vectorLine;
        private static UnityEngine.UI.VertexHelper vertexHelper;
        
        // Methods
        public void SetVectorLine(Vectrosity.VectorLine vectorLine, UnityEngine.Texture tex, UnityEngine.Material mat, bool useCustomMaterial)
        {
            this.vectorLine = vectorLine;
            this.texture = tex;
            this.material = mat;
        }
        public void Destroy()
        {
            UnityEngine.Object.Destroy(obj:  this.m_mesh);
        }
        public void Enable(bool enable)
        {
            if(425152720 == 0)
            {
                    return;
            }
            
            this.enabled = enable;
        }
        public void SetTexture(UnityEngine.Texture tex)
        {
            this.texture = tex;
        }
        public void SetMaterial(UnityEngine.Material mat)
        {
            this.material = mat;
        }
        protected override void UpdateGeometry()
        {
            var val_11;
            var val_12;
            var val_13;
            val_11 = 22713552;
            bool val_1 = UnityEngine.Object.op_Equality(x:  this.m_mesh, y:  0);
            if(val_1 == true)
            {
                    val_1 = this;
                this.SetupMesh();
            }
            
            UnityEngine.RectTransform val_2 = this.rectTransform;
            val_12 = this;
            if(425513296 != 0)
            {
                    UnityEngine.RectTransform val_4 = this.rectTransform;
                val_11 = this;
                UnityEngine.Rect val_5 = rect;
                float val_6 = width;
                if(this >= 0)
            {
                    UnityEngine.RectTransform val_7 = this.rectTransform;
                val_11 = this;
                UnityEngine.Rect val_8 = rect;
                float val_9 = height;
                if(this >= 0)
            {
                    val_13 = 536896705;
                if(((mem[536896892] & true) == 0) && (mem[536896821] == 0))
            {
                    val_13 = 536896705;
            }
            
            }
            
            }
            
            }
            
            UnityEngine.CanvasRenderer val_10 = this.canvasRenderer;
            this.SetMesh(mesh:  this.m_mesh);
        }
        private void SetupMesh()
        {
            UnityEngine.Mesh val_1 = 536890419;
            val_1 = new UnityEngine.Mesh();
            this.m_mesh = val_1;
            this.m_mesh.name = R7 + 84;
            this.m_mesh.hideFlags = 61;
            this.SetMeshBounds();
        }
        private void SetMeshBounds()
        {
            float val_8 = 0f;
            if(this.m_mesh == 0)
            {
                    return;
            }
            
            int val_2 = UnityEngine.Screen.width;
            int val_3 = UnityEngine.Screen.height;
            int val_4 = val_2 + (val_2 >> 31);
            val_3 = val_3 + (val_3 >> 31);
            val_4 = val_4 >> 1;
            val_3 = val_3 >> 1;
            UnityEngine.Bounds val_7 = new UnityEngine.Bounds(center:  new UnityEngine.Vector3() {x = (float)val_4, y = (float)val_3, z = 0f}, size:  new UnityEngine.Vector3() {x = (float)UnityEngine.Screen.width, y = (float)UnityEngine.Screen.height, z = val_8});
            val_8 = val_7.m_Extents.y;
            this.m_mesh.bounds = new UnityEngine.Bounds() {m_Center = new UnityEngine.Vector3() {x = val_7.m_Center.x, y = val_7.m_Center.y, z = val_7.m_Center.z}, m_Extents = new UnityEngine.Vector3() {x = val_7.m_Extents.x, y = val_8, z = val_7.m_Extents.z}};
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            UnityEngine.Vector3[] val_7;
            bool val_8;
            if(this.m_updateVerts != false)
            {
                    val_7 = this.vectorLine.m_lineVertices;
                val_8 = false;
                this.m_mesh.vertices = val_7;
                this.m_updateVerts = val_8;
            }
            
            if(this.m_updateUVs != false)
            {
                    val_7 = this.vectorLine.m_lineUVs;
                val_8 = false;
                if(0 == this.m_mesh.vertexCount)
            {
                    val_7 = this.vectorLine.m_lineUVs;
                this.m_mesh.uv = val_7;
            }
            
                this.m_updateUVs = val_8;
            }
            
            if(this.m_updateColors != false)
            {
                    val_7 = this.vectorLine.m_lineColors;
                val_8 = false;
                if(0 == this.m_mesh.vertexCount)
            {
                    val_7 = this.vectorLine.m_lineColors;
                this.m_mesh.colors32 = val_7;
            }
            
                this.m_updateColors = val_8;
            }
            
            if(this.m_updateTris != false)
            {
                    val_7 = this.vectorLine.m_lineTriangles;
                val_8 = false;
                this.m_mesh.SetTriangles(triangles:  val_7, submesh:  0);
                this.m_updateTris = val_8;
                this.SetMeshBounds();
            }
            
            if(this.m_updateNormals != false)
            {
                    if(this.m_mesh != 0)
            {
                    val_7 = false;
                this.m_mesh.RecalculateNormals();
                this.m_updateNormals = val_7;
            }
            
            }
            
            if(this.m_updateTangents == false)
            {
                    return;
            }
            
            if(this.m_mesh == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3[] val_5 = this.m_mesh.normals;
            val_8 = this.m_mesh;
            UnityEngine.Vector4[] val_6 = this.vectorLine.CalculateTangents(normals:  val_8);
            val_7 = this.vectorLine;
            this.m_mesh.tangents = val_7;
            this.m_updateTangents = false;
        }
        public void SetName(string name)
        {
            if(this.m_mesh == 0)
            {
                    return;
            }
            
            this.m_mesh.name = name;
        }
        public void UpdateVerts()
        {
            this.m_updateVerts = true;
            this.SetVerticesDirty();
        }
        public void UpdateUVs()
        {
            this.m_updateUVs = true;
            this.SetVerticesDirty();
        }
        public void UpdateColors()
        {
            this.m_updateColors = true;
            this.SetVerticesDirty();
        }
        public void UpdateNormals()
        {
            this.m_updateNormals = true;
            this.SetVerticesDirty();
        }
        public void UpdateTangents()
        {
            this.m_updateTangents = true;
            this.SetVerticesDirty();
        }
        public void UpdateTris()
        {
            this.m_updateTris = true;
            this.SetVerticesDirty();
        }
        public void UpdateMeshAttributes()
        {
            if(this.m_mesh != 0)
            {
                    this.m_mesh.Clear();
            }
            
            this.m_updateColors = true;
            this.m_updateVerts = true;
            this.m_updateUVs = true;
            this.m_updateTris = true;
            this.SetVerticesDirty();
            this.SetMeshBounds();
        }
        public void ClearMesh()
        {
            if(this.m_mesh == 0)
            {
                    return;
            }
            
            R4 + 152.Clear();
            goto R4 + 516;
        }
        public int VertexCount()
        {
            if(this.m_mesh != 0)
            {
                    return this.m_mesh.vertexCount;
            }
            
            return this.m_mesh.vertexCount;
        }
        public VectorObject2D()
        {
            this.m_updateColors = true;
            this.m_updateVerts = true;
            this.m_updateUVs = true;
            this.m_updateTris = true;
        }
        private static VectorObject2D()
        {
        
        }
    
    }

}
