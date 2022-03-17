using UnityEngine;

namespace Ferr
{
    public class ProceduralMeshUtil
    {
        // Fields
        public const string cProcMeshPrefix = "FerrProcMesh_";
        
        // Methods
        public static void EnsureProceduralMesh(UnityEngine.MeshFilter aFilter, bool aCreateRestoreComponent = True)
        {
            var val_16;
            UnityEngine.Object val_17;
            DropdownItem val_18;
            var val_19;
            val_16 = 22981977;
            if((Ferr.ProceduralMeshUtil.IsProceduralMesh(aFilter:  aFilter)) == false)
            {
                goto label_1;
            }
            
            if((Ferr.ProceduralMeshUtil.IsCorrectName(aFilter:  aFilter)) == false)
            {
                goto label_2;
            }
            
            return;
            label_1:
            if(aCreateRestoreComponent != false)
            {
                    UnityEngine.Transform val_3 = aFilter.GetComponent<UnityEngine.Transform>();
                val_17 = aFilter;
                if(val_17 == 0)
            {
                    UnityEngine.GameObject val_5 = aFilter.gameObject;
                SynchronizationContextBehavoir val_6 = aFilter.AddComponent<SynchronizationContextBehavoir>();
                val_17 = aFilter;
            }
            
                UnityEngine.Mesh val_7 = aFilter.sharedMesh;
                mem2[0] = aFilter;
            }
            
            UnityEngine.Mesh val_8 = aFilter.sharedMesh;
            val_16 = 22713552;
            if(aFilter == 0)
            {
                    536890419 = new UnityEngine.Mesh();
                aFilter.sharedMesh = 536890419;
            }
            
            UnityEngine.Mesh val_11 = aFilter.sharedMesh;
            val_18 = aFilter;
            val_19 = 536891221;
            goto label_18;
            label_2:
            UnityEngine.Mesh val_12 = aFilter.sharedMesh;
            val_18 = aFilter;
            val_19 = 536891221;
            label_18:
            DropdownItem val_13 = UnityEngine.Object.Instantiate<DropdownItem>(original:  val_18);
            if(aFilter != 0)
            {
                    aFilter.sharedMesh = val_18;
            }
            else
            {
                    0.sharedMesh = val_18;
            }
            
            UnityEngine.Mesh val_14 = aFilter.sharedMesh;
            string val_15 = Ferr.ProceduralMeshUtil.MakeInstName(aFilter:  aFilter);
            aFilter.name = aFilter;
        }
        public static bool IsProceduralMesh(UnityEngine.MeshFilter aFilter)
        {
            if(aFilter == 0)
            {
                    return false;
            }
            
            UnityEngine.Mesh val_2 = aFilter.sharedMesh;
            if(aFilter == 0)
            {
                    return false;
            }
            
            UnityEngine.Mesh val_4 = aFilter.sharedMesh;
            string val_5 = aFilter.name;
            if(aFilter != 0)
            {
                    return aFilter.StartsWith(value:  -1610608193);
            }
            
            return aFilter.StartsWith(value:  -1610608193);
        }
        public static string MakeInstName(UnityEngine.MeshFilter aFilter)
        {
            UnityEngine.GameObject val_1 = aFilter.gameObject;
            string val_2 = aFilter.name;
            int val_3 = aFilter.GetInstanceID();
            string val_4 = System.String.Format(format:  -1610596967, arg0:  -1610608193, arg1:  aFilter, arg2:  536888987);
        }
        public static bool IsCorrectName(UnityEngine.MeshFilter aFilter)
        {
            if(aFilter == 0)
            {
                    return false;
            }
            
            UnityEngine.Mesh val_2 = aFilter.sharedMesh;
            if(aFilter == 0)
            {
                    return false;
            }
            
            UnityEngine.Mesh val_4 = aFilter.sharedMesh;
            string val_5 = aFilter.name;
            string val_6 = Ferr.ProceduralMeshUtil.MakeInstName(aFilter:  aFilter);
            return System.String.op_Equality(a:  aFilter, b:  aFilter);
        }
        public ProceduralMeshUtil()
        {
        
        }
    
    }

}
