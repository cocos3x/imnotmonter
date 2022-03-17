using UnityEngine;

namespace Vectrosity
{
    public class VectorObject3D : MonoBehaviour, IVectorObject
    {
        // Fields
        private bool m_updateVerts;
        private bool m_updateUVs;
        private bool m_updateColors;
        private bool m_updateNormals;
        private bool m_updateTangents;
        private bool m_updateTris;
        private UnityEngine.Mesh m_mesh;
        private Vectrosity.VectorLine m_vectorLine;
        private UnityEngine.Material m_material;
        private bool m_useCustomMaterial;
        
        // Methods
        public void SetVectorLine(Vectrosity.VectorLine vectorLine, UnityEngine.Texture tex, UnityEngine.Material mat, bool useCustomMaterial)
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            SynchronizationContextBehavoir val_2 = this.AddComponent<SynchronizationContextBehavoir>();
            UnityEngine.GameObject val_3 = this.gameObject;
            SynchronizationContextBehavoir val_4 = this.AddComponent<SynchronizationContextBehavoir>();
            this.m_vectorLine = vectorLine;
            this.m_material = mat;
            this.m_material.mainTexture = tex;
            UnityEngine.Transform val_5 = this.GetComponent<UnityEngine.Transform>();
            this.sharedMaterial = this.m_material;
            this.m_useCustomMaterial = useCustomMaterial;
            this.SetupMesh();
        }
        public void Destroy()
        {
            UnityEngine.Object.Destroy(obj:  this.m_mesh);
            if(this.m_useCustomMaterial == true)
            {
                    return;
            }
            
            UnityEngine.Object.Destroy(obj:  R4 + 28);
        }
        public void Enable(bool enable)
        {
            if(428176464 == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
            this.enabled = enable;
        }
        public void SetTexture(UnityEngine.Texture tex)
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            UnityEngine.Material val_2 = this.sharedMaterial;
            this.mainTexture = tex;
        }
        public void SetMaterial(UnityEngine.Material mat)
        {
            this.m_material = mat;
            this.m_useCustomMaterial = true;
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            this.sharedMaterial = mat;
            if(mat == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_3 = this.GetComponent<UnityEngine.Transform>();
            UnityEngine.Material val_4 = this.sharedMaterial;
            this.mainTexture = this.m_vectorLine.m_texture;
        }
        private void SetupMesh()
        {
            UnityEngine.Mesh val_1 = 536890419;
            val_1 = new UnityEngine.Mesh();
            this.m_mesh = val_1;
            this.m_mesh.name = R7 + 84;
            this.m_mesh.hideFlags = 61;
            UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
            this.mesh = this.m_mesh;
        }
        private void LateUpdate()
        {
            UnityEngine.Vector2[] val_5;
            bool val_6;
            if(this.m_updateVerts == true)
            {
                    this.m_updateVerts = this;
                this.SetVerts();
            }
            
            if(this.m_updateUVs != false)
            {
                    val_5 = this.m_vectorLine.m_lineUVs;
                val_6 = false;
                if(0 == this.m_mesh.vertexCount)
            {
                    val_5 = this.m_vectorLine.m_lineUVs;
                this.m_mesh.uv = val_5;
            }
            
                this.m_updateUVs = val_6;
            }
            
            if(this.m_updateColors != false)
            {
                    val_5 = this.m_vectorLine.m_lineColors;
                val_6 = false;
                if(0 == this.m_mesh.vertexCount)
            {
                    val_5 = this.m_vectorLine.m_lineColors;
                this.m_mesh.colors32 = val_5;
            }
            
                this.m_updateColors = val_6;
            }
            
            if(this.m_updateTris != false)
            {
                    val_5 = this.m_vectorLine.m_lineTriangles;
                val_6 = false;
                this.m_mesh.SetTriangles(triangles:  val_5, submesh:  0);
                this.m_updateTris = val_6;
            }
            
            if(this.m_updateNormals != false)
            {
                    val_5 = false;
                this.m_mesh.RecalculateNormals();
                this.m_updateNormals = val_5;
            }
            
            if(this.m_updateTangents == false)
            {
                    return;
            }
            
            UnityEngine.Vector3[] val_3 = this.m_mesh.normals;
            val_6 = this.m_mesh;
            UnityEngine.Vector4[] val_4 = this.m_vectorLine.CalculateTangents(normals:  val_6);
            val_5 = this.m_vectorLine;
            this.m_mesh.tangents = val_5;
            this.m_updateTangents = false;
        }
        private void SetVerts()
        {
            this.m_mesh.vertices = this.m_vectorLine.m_lineVertices;
            this.m_updateVerts = false;
            this.m_mesh.RecalculateBounds();
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
        }
        public void UpdateUVs()
        {
            this.m_updateUVs = true;
        }
        public void UpdateColors()
        {
            this.m_updateColors = true;
        }
        public void UpdateNormals()
        {
            this.m_updateNormals = true;
        }
        public void UpdateTangents()
        {
            this.m_updateTangents = true;
        }
        public void UpdateTris()
        {
            this.m_updateTris = true;
        }
        public void UpdateMeshAttributes()
        {
            this.m_mesh.Clear();
            this.m_updateColors = true;
            this.m_updateVerts = true;
            this.m_updateUVs = true;
            this.m_updateTris = true;
        }
        public void ClearMesh()
        {
            if(this.m_mesh == 0)
            {
                    return;
            }
            
            R4 + 20.Clear();
        }
        public int VertexCount()
        {
            if(this.m_mesh != 0)
            {
                    return this.m_mesh.vertexCount;
            }
            
            return this.m_mesh.vertexCount;
        }
        public VectorObject3D()
        {
            this.m_updateColors = true;
            this.m_updateVerts = true;
            this.m_updateUVs = true;
            this.m_updateTris = true;
        }
    
    }

}
