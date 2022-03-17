using UnityEngine;

namespace Vectrosity
{
    internal interface IVectorObject
    {
        // Methods
        public abstract void SetName(string name); // 0
        public abstract void UpdateVerts(); // 0
        public abstract void UpdateUVs(); // 0
        public abstract void UpdateColors(); // 0
        public abstract void UpdateTris(); // 0
        public abstract void UpdateNormals(); // 0
        public abstract void UpdateTangents(); // 0
        public abstract void UpdateMeshAttributes(); // 0
        public abstract void ClearMesh(); // 0
        public abstract void SetMaterial(UnityEngine.Material material); // 0
        public abstract void SetTexture(UnityEngine.Texture texture); // 0
        public abstract void Enable(bool enable); // 0
        public abstract void SetVectorLine(Vectrosity.VectorLine vectorLine, UnityEngine.Texture texture, UnityEngine.Material material, bool useCustomMaterial); // 0
        public abstract void Destroy(); // 0
        public abstract int VertexCount(); // 0
    
    }

}
