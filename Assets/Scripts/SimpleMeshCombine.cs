using UnityEngine;
public class SimpleMeshCombine : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject[] combinedGameOjects;
    public UnityEngine.GameObject combined;
    public string meshName;
    public bool _canGenerateLightmapUV;
    public int vCount;
    public bool generateLightmapUV;
    public UnityEngine.GameObject copyTarget;
    public bool destroyOldColliders;
    public bool keepStructure;
    
    // Methods
    public void EnableRenderers(bool e)
    {
        var val_4;
        UnityEngine.GameObject val_5;
        val_4 = 4;
        goto label_1;
        label_15:
        val_5 = this.combinedGameOjects[0];
        if(val_5 == 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_5 = this.combinedGameOjects[0];
        Weight val_2 = val_5.GetComponent<Weight>();
        if(val_5 != 0)
        {
                val_5.enabled = e;
        }
        
        val_4 = 5;
        label_1:
        val_5 = this.combinedGameOjects;
        if((val_4 - 4) < val_5)
        {
            goto label_15;
        }
    
    }
    public UnityEngine.MeshFilter[] FindEnabledMeshes()
    {
        var val_11;
        var val_12;
        UnityEngine.Object val_13;
        val_11 = 0;
        UnityEngine.Transform val_1 = this.transform;
        T[] val_2 = this.GetComponentsInChildren<UnityEngine.TrailRenderer>();
        val_12 = 0;
        goto label_2;
        label_12:
        UnityEngine.Transform val_3 = mem[this.combined + 0].GetComponent<UnityEngine.Transform>();
        val_13 = mem[this.combined + 0];
        if(val_13 != 0)
        {
                UnityEngine.Transform val_5 = mem[this.combined + 0].GetComponent<UnityEngine.Transform>();
            val_13 = mem[this.combined + 0];
            val_12 = val_12 + val_13.enabled;
        }
        
        val_11 = 1;
        label_2:
        if(val_11 < this.combinedGameOjects)
        {
            goto label_12;
        }
        
        if(this.combinedGameOjects < 1)
        {
                return;
        }
        
        var val_12 = 0;
        do
        {
            UnityEngine.Transform val_7 = mem[this.combined + 0].GetComponent<UnityEngine.Transform>();
            val_13 = mem[this.combined + 0];
            if(val_13 != 0)
        {
                UnityEngine.Transform val_9 = mem[this.combined + 0].GetComponent<UnityEngine.Transform>();
            val_13 = mem[this.combined + 0];
            if(val_13.enabled != false)
        {
                val_13 = mem[this.combined + 0];
            var val_11 = 536882183 + 0;
            mem2[0] = val_13;
            val_12 = val_12 + 1;
        }
        
        }
        
            val_12 = 0 + 1;
        }
        while(val_12 < this.combinedGameOjects);
    
    }
    public void CombineMeshes()
    {
        var val_14;
        var val_18;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        UnityEngine.GameObject val_1 = 536887303;
        val_35 = val_1;
        val_1 = new UnityEngine.GameObject();
        string val_2 = this.name;
        string val_3 = -1610602147(-1610602147) + 861148816 + -1610602237(-1610602237);
        if(val_35 != 0)
        {
                val_35.name = -1610602147;
        }
        else
        {
                0.name = -1610602147;
        }
        
        UnityEngine.GameObject val_4 = val_35.gameObject;
        SynchronizationContextBehavoir val_5 = val_35.AddComponent<SynchronizationContextBehavoir>();
        if(val_35 == 0)
        {
                val_35 = val_35;
        }
        
        UnityEngine.GameObject val_6 = val_35.gameObject;
        SynchronizationContextBehavoir val_7 = val_35.AddComponent<SynchronizationContextBehavoir>();
        UnityEngine.MeshFilter[] val_8 = this.FindEnabledMeshes();
        val_36 = this;
        System.Collections.ArrayList val_9 = 536883505;
        val_37 = val_9;
        val_9 = new System.Collections.ArrayList();
        536883505 = new System.Collections.ArrayList();
        mem[1152921509762963100] = 536881957;
        val_38 = 0;
        goto label_7;
        label_74:
        T[] val_11 = mem[1152921509762963104].GetComponentsInChildren<UnityEngine.TrailRenderer>();
        UnityEngine.GameObject val_12 = this.combined.gameObject;
        var val_13 = mem[536881957] + 0;
        mem2[0] = this.combined;
        val_39 = 0;
        val_40 = mem[1152921509762963104];
        goto label_16;
        label_67:
        val_41 = 4;
        val_42 = val_14;
        goto label_17;
        label_47:
        UnityEngine.Material[] val_15 = val_41.sharedMaterials;
        if(val_38 >= 2621443)
        {
            goto label_23;
        }
        
        UnityEngine.Mesh val_16 = val_42.sharedMesh;
        if(val_38 >= val_42.subMeshCount)
        {
            goto label_23;
        }
        
        UnityEngine.Material[] val_19 = val_18.sharedMaterials;
        if((mem[536881957].Contains(l:  536883505, n:  val_18 + (mem[536881957]) << 2)) == 1)
        {
                UnityEngine.Material[] val_21 = val_18.sharedMaterials;
            if(val_37 != 0)
        {
            
        }
        
            val_43 = 536883504;
        }
        
        536883505 = new System.Collections.ArrayList();
        UnityEngine.Transform val_23 = val_18.transform;
        UnityEngine.Matrix4x4 val_24 = localToWorldMatrix;
        float val_25 = val_24.m13 + 160;
        mem2[0] = val_24.m13 + 136;
        float val_26 = val_24.m13 + 184;
        mem2[0] = val_24.m13 + 140;
        mem2[0] = val_24.m13 + 144;
        mem2[0] = val_24.m13 + 148;
        mem2[0] = val_24.m13 + 180;
        float val_27 = val_24.m13 + 36;
        mem2[0] = 0;
        float val_28 = val_24.m13 + 12;
        mem2[0] = val_24.m13 + 156;
        float val_29 = val_24.m32 - 136;
        mem2[0] = val_24.m13 + 176;
        float val_30 = val_24.m13 + 136;
        if((val_24.m13 + 100) == 0)
        {
            goto label_37;
        }
        
        val_44 = 536883505;
        if((val_24.m13 + 100 + 180) < mem[536883685])
        {
            goto label_38;
        }
        
        var val_35 = val_24.m13 + 100 + 100;
        val_35 = val_35 + (mem[536883685] << 2);
        if(((val_24.m13 + 100 + 100 + (mem[536883685]) << 2) + -4) == val_44)
        {
            goto label_39;
        }
        
        label_38:
        val_44 = 536883505;
        label_39:
        val_45 = 0;
        val_37 = mem[val_24.m13 + 96];
        val_37 = val_24.m13 + 96;
        if((val_24.m13 + 100 + 180) < mem[536883685])
        {
            goto label_41;
        }
        
        var val_36 = val_24.m13 + 100 + 100;
        val_36 = val_36 + (mem[536883685] << 2);
        if(((val_24.m13 + 100 + 100 + (mem[536883685]) << 2) + -4) != val_44)
        {
                val_24.m13 + 100 = 0;
        }
        
        val_45 = val_24.m13 + 100;
        goto label_41;
        label_37:
        val_45 = 0;
        val_37 = mem[val_24.m13 + 96];
        val_37 = val_24.m13 + 96;
        label_41:
        val_42 = mem[val_24.m13 + 124];
        val_42 = val_24.m13 + 124;
        label_23:
        val_41 = (val_24.m13 + 132) + 1;
        label_17:
        mem2[0] = val_41;
        if((val_41 - 4) >= val_42)
        {
            goto label_44;
        }
        
        if((val_24.m13 + 128) == 0)
        {
            goto label_47;
        }
        
        val_46 = 0;
        if(val_42 != 0)
        {
                val_24.m13 + 72 = val_42;
        }
        
        if(val_42 != 0)
        {
                val_46 = val_24.m13 + 72;
        }
        
        mem2[0] = val_24.m13 + 72;
        val_37 = val_37;
        label_44:
        val_47 = mem[val_24.m13 + 76];
        val_47 = val_24.m13 + 76;
        val_40 = mem[val_24.m13 + 80];
        val_40 = val_24.m13 + 80;
        val_39 = (val_24.m13 + 84) + 1;
        label_16:
        if(val_39 >= (val_24.m13 + 80 + 12))
        {
            goto label_54;
        }
        
        var val_32 = val_40 + (val_39 << 2);
        mem2[0] = (val_24.m13 + 80 + ((val_24.m13 + 84 + 1)) << 2) + 16;
        val_48 = mem[val_24.m13 + 92];
        val_48 = val_24.m13 + 92;
        if(val_48 == 0)
        {
                val_48 = mem[val_24.m13 + 92];
            val_48 = val_24.m13 + 92;
        }
        
        mem2[0] = (val_24.m13 + 80 + ((val_24.m13 + 84 + 1)) << 2) + 16;
        if((val_24.m13 + 88) == 0)
        {
            goto label_67;
        }
        
        val_49 = 0;
        if((val_24.m13 + 124) != 0)
        {
                val_24.m13 + 64 = val_24.m13 + 124;
        }
        
        if((val_24.m13 + 124) != 0)
        {
                val_49 = val_24.m13 + 64;
        }
        
        mem2[0] = val_24.m13 + 64;
        val_47 = mem[val_24.m13 + 76];
        val_47 = val_24.m13 + 76;
        label_54:
        val_36 = mem[val_24.m13 + 92];
        val_36 = val_24.m13 + 92;
        val_38 = val_47 + 1;
        label_7:
        if(val_36 == 0)
        {
                val_36 = mem[val_24.m13 + 92];
            val_36 = val_24.m13 + 92;
        }
        
        if(val_38 < (val_24.m13 + 92 + 12))
        {
            goto label_74;
        }
        
        val_50 = 536881835;
        mem2[0] = 536882179;
        if(val_37 < 1)
        {
            goto label_77;
        }
        
        var val_41 = 536881851;
        var val_42 = 0;
        var val_40 = 0;
        mem2[0] = 536882179 + 16;
        mem2[0] = val_50;
        label_97:
        if((val_24.m13 + 100) == 0)
        {
            goto label_81;
        }
        
        val_51 = 536883505;
        if((val_24.m13 + 100 + 180) < mem[536883685])
        {
            goto label_82;
        }
        
        var val_37 = val_24.m13 + 100 + 100;
        val_37 = val_37 + (mem[536883685] << 2);
        if(((val_24.m13 + 100 + 100 + (mem[536883685]) << 2) + -4) == val_51)
        {
            goto label_83;
        }
        
        label_82:
        val_51 = 536883505;
        label_83:
        val_52 = 0;
        val_37 = mem[val_24.m13 + 96];
        val_37 = val_24.m13 + 96;
        if((val_24.m13 + 100 + 180) < mem[536883685])
        {
            goto label_85;
        }
        
        var val_38 = val_24.m13 + 100 + 100;
        val_38 = val_38 + (mem[536883685] << 2);
        if(((val_24.m13 + 100 + 100 + (mem[536883685]) << 2) + -4) != val_51)
        {
                val_24.m13 + 100 = 0;
        }
        
        val_52 = val_24.m13 + 100;
        goto label_85;
        label_81:
        val_52 = 0;
        label_85:
        var val_39 = val_24.m13 + 132;
        mem2[0] = 536890419;
        val_39 = val_39 + val_42;
        mem2[0] = 0;
        val_50 = mem[val_24.m13 + 124];
        val_50 = val_24.m13 + 124;
        val_40 = val_40 + 1;
        val_41 = val_41 + 104;
        val_42 = val_42 + 4;
        if(val_40 < val_37)
        {
            goto label_97;
        }
        
        label_77:
        val_53 = mem[val_24.m13 + 60];
        val_53 = val_24.m13 + 60;
        if(val_53 == 0)
        {
                val_53 = mem[val_24.m13 + 60];
            val_53 = val_24.m13 + 60;
        }
        
        if(val_53 == 0)
        {
                val_53 = mem[val_24.m13 + 60];
            val_53 = val_24.m13 + 60;
        }
        
        mem2[0] = 0;
        var val_34 = (val_24.m13 + 128) + 16;
        goto label_103;
    }
    public int Contains(System.Collections.ArrayList l, UnityEngine.Material n)
    {
        var val_2;
        var val_3;
        var val_4;
        val_2 = 0;
        goto label_1;
        label_8:
        val_3 = l;
        val_4 = 0;
        if(val_3 != 0)
        {
                if(((System.Collections.ArrayList.__il2cppRuntimeField_typeHierarchy + (mem[536890441]) << 2) + -4) != 536890261)
        {
                val_3 = 0;
        }
        
            val_4 = val_3;
        }
        
        if(0 == n)
        {
                return 0;
        }
        
        val_2 = 1;
        label_1:
        if(val_2 < l)
        {
            goto label_8;
        }
        
        return 0;
    }
    public SimpleMeshCombine()
    {
        this.meshName = -1610609273;
        this.keepStructure = true;
    }

}
