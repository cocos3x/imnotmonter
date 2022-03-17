using UnityEngine;

namespace WrappingRopeLibrary.Model
{
    [Serializable]
    public class MeshConfigurator
    {
        // Fields
        public int BendCrossectionsNumber;
        public int VertexNumber;
        public bool FlipNormals;
        public System.Collections.Generic.List<UnityEngine.Vector3> Profile;
        
        // Methods
        public MeshConfigurator()
        {
            this.VertexNumber = 3;
            536878517 = new System.Collections.Generic.List<UnityEngine.Vector3>(capacity:  3);
            this.Profile = 536878517;
        }
    
    }

}
