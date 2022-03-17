using UnityEngine;

namespace Ferr
{
    public interface IProceduralMesh
    {
        // Properties
        public abstract UnityEngine.Mesh MeshData { get; }
        public abstract UnityEngine.MeshFilter MeshFilter { get; }
        
        // Methods
        public abstract UnityEngine.Mesh get_MeshData(); // 0
        public abstract UnityEngine.MeshFilter get_MeshFilter(); // 0
        public abstract void Build(bool aFullBuild); // 0
    
    }

}
