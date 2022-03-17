using UnityEngine;

namespace Ferr
{
    public class RestoreMesh : MonoBehaviour
    {
        // Fields
        private UnityEngine.Mesh _originalMesh;
        
        // Properties
        public UnityEngine.Mesh OriginalMesh { get; set; }
        
        // Methods
        public UnityEngine.Mesh get_OriginalMesh()
        {
        
        }
        public void set_OriginalMesh(UnityEngine.Mesh value)
        {
            this._originalMesh = value;
        }
        public void Restore(bool aMaintainColors = True)
        {
            bool val_5;
            bool val_6;
            bool val_7;
            bool val_8;
            bool val_39;
            UnityEngine.Mesh val_42;
            Ferr.RecolorTree val_43;
            val_42 = this;
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            val_43 = 0;
            if(1233759760 == 0)
            {
                    UnityEngine.GameObject val_3 = this.gameObject;
                UnityEngine.Debug.LogError(message:  -1610606055, context:  1233759760);
                return;
            }
            
            if(aMaintainColors != false)
            {
                    UnityEngine.Mesh val_4 = this.sharedMesh;
                val_43 = 536892547;
                val_43 = new Ferr.RecolorTree(aMesh:  1233759760, aTransform:  new System.Nullable<UnityEngine.Matrix4x4>() {HasValue = val_5}, aX:  val_6, aY:  val_7, aZ:  val_8);
            }
            
            val_42 = this._originalMesh;
            this.sharedMesh = val_42;
            if(aMaintainColors == false)
            {
                    return;
            }
            
            Ferr.ProceduralMeshUtil.EnsureProceduralMesh(aFilter:  1233759760, aCreateRestoreComponent:  true);
            UnityEngine.Mesh val_23 = this.sharedMesh;
            val_43.Recolor(aMesh: ref  UnityEngine.Mesh val_41 = 1233747716, aTransform:  new System.Nullable<UnityEngine.Matrix4x4>() {HasValue = val_39});
        }
        public RestoreMesh()
        {
        
        }
    
    }

}
