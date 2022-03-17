using UnityEngine;
private sealed class VertexZoom.<AnimateVertexColors>d__10 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.Examples.VertexZoom <>4__this;
    private TMPro.Examples.VertexZoom.<>c__DisplayClass10_0 <>8__1;
    private TMPro.TMP_TextInfo <textInfo>5__2;
    private TMPro.TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;
    private System.Collections.Generic.List<int> <scaleSortingOrder>5__4;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VertexZoom.<AnimateVertexColors>d__10(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_33;
        float val_34;
        float val_35;
        VertexZoom.<AnimateVertexColors>d__10 val_76;
        TMPro.Examples.VertexZoom val_77;
        var val_78;
        var val_79;
        VertexZoom.<>c__DisplayClass10_0 val_80;
        var val_81;
        var val_82;
        UnityEngine.Vector3[] val_83;
        TMPro.TMP_MeshInfo val_84;
        var val_86;
        var val_87;
        var val_88;
        var val_89;
        var val_90;
        var val_91;
        var val_92;
        var val_93;
        var val_94;
        var val_95;
        var val_96;
        var val_97;
        var val_98;
        int val_99;
        val_76 = this;
        val_77 = this.<>4__this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if(val_77 != 0)
        {
            goto label_3;
        }
        
        goto label_3;
        label_1:
        val_78 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_78;
        }
        
        this.<>1__state = 0;
        object val_2 = 536902339;
        val_2 = new System.Object();
        this.<>8__1 = val_2;
        this.<textInfo>5__2 = this.<>4__this + 24 + 668;
        TMPro.TMP_MeshInfo[] val_3 = this.<textInfo>5__2.CopyMeshInfoVertexData();
        this.<cachedMeshInfoVertexData>5__3 = this.<textInfo>5__2;
        val_80 = this.<>8__1;
        536878291 = new System.Collections.Generic.List<System.Single>();
        mem[536902347] = 536878291;
        536877987 = new System.Collections.Generic.List<System.Int32>();
        this.<scaleSortingOrder>5__4 = 536877987;
        val_77 = val_77;
        mem2[0] = 1;
        label_3:
        if((this.<>4__this + 28) != 0)
        {
                TMPro.TMP_MeshInfo[] val_6 = this.<textInfo>5__2.CopyMeshInfoVertexData();
            this.<cachedMeshInfoVertexData>5__3 = this.<textInfo>5__2;
            mem2[0] = 0;
        }
        
        if((this.<textInfo>5__2.characterCount) == 0)
        {
            goto label_13;
        }
        
        this.<>8__1.modifiedCharScale.Clear();
        this.<scaleSortingOrder>5__4.Clear();
        if((this.<textInfo>5__2.characterCount) >= 1)
        {
                val_81 = 0;
            val_82 = 0;
            do
        {
            if((this.<textInfo>5__2.characterInfo[val_81]) != 0)
        {
                TMPro.TMP_CharacterInfo val_72 = this.<textInfo>5__2.characterInfo[val_81];
            TMPro.TMP_CharacterInfo val_73 = this.<textInfo>5__2.characterInfo[val_81];
            TMPro.TMP_CharacterInfo val_7 = val_72 + (val_72 << 2);
            TMPro.TMP_MeshInfo val_74 = this.<cachedMeshInfoVertexData>5__3[val_7 << 3];
            val_83 = mem[this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + 12];
            val_83 = this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0].normals;
            if(val_83 <= val_73)
        {
                val_83 = mem[this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + 12];
            val_83 = this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0].normals;
        }
        
            TMPro.TMP_CharacterInfo val_8 = val_73 + (val_73 << 1);
            val_81 = val_74 + (val_8 << 2);
            UnityEngine.Vector2[] val_75 = (this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.uvs0;
            TMPro.TMP_CharacterInfo val_9 = val_72 + (val_72 << 1);
            TMPro.TMP_MeshInfo val_10 = val_74 + (val_9 << 2);
            UnityEngine.Vector4[] val_76 = (this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.tangents;
            val_75 = val_75 + ((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.uvs0);
            val_76 = ((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.tangents) + val_76;
            val_84 = this.<textInfo>5__2.meshInfo[val_7 << 3];
            if((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0].normals) <= val_73)
        {
                val_84 = val_84;
        }
        
            UnityEngine.Vector2[] val_11 = val_75 * 0.5f;
            float val_78 = mem[(this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.tangents];
            UnityEngine.Vector4[] val_12 = val_76 * 0.5f;
            float val_77 = mem[(this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.uvs0];
            if(val_84 == 0)
        {
                val_84 = val_84;
        }
        
            val_77 = val_77 - val_11;
            val_78 = val_78 - val_12;
            if((this.<textInfo>5__2.meshInfo[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + 12) <= val_73)
        {
                val_84 = val_84;
        }
        
            TMPro.TMP_CharacterInfo val_79 = val_8;
            val_79 = val_84 + (val_79 << 2);
            mem2[0] = mem[(this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.uvs2];
            TMPro.TMP_CharacterInfo val_13 = val_73 + 1;
            mem2[0] = val_78;
            mem2[0] = val_77;
            if((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0].normals) <= val_13)
        {
                val_84 = val_84;
        }
        
            TMPro.TMP_CharacterInfo val_14 = val_13 + (val_13 << 1);
            TMPro.TMP_MeshInfo val_15 = val_74 + (val_14 << 2);
            if((this.<textInfo>5__2.meshInfo[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + 12) <= val_13)
        {
                val_84 = val_84;
        }
        
            TMPro.TMP_MeshInfo val_18 = val_84 + (val_14 << 2);
            mem2[0] = (this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + (((this.<textInfo>5__2.characterInfo[0x0][0] + 1) + ((t.uvs2;
            mem2[0] = ((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + (((this.<textInfo>5__2.characterInfo[0x0][0] + 1) + ((t.tangents) - val_12;
            mem2[0] = ((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + (((this.<textInfo>5__2.characterInfo[0x0][0] + 1) + ((t.uvs0) - val_11;
            if((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0].normals) <= val_72)
        {
                val_84 = val_84;
        }
        
            if((this.<textInfo>5__2.meshInfo[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + 12) <= val_72)
        {
                val_84 = val_84;
        }
        
            TMPro.TMP_CharacterInfo val_80 = val_9;
            val_80 = val_84 + (val_80 << 2);
            TMPro.TMP_CharacterInfo val_21 = val_73 + 3;
            mem2[0] = mem[(this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.uvs2];
            mem2[0] = (mem[(this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.tangents]) - val_12;
            mem2[0] = (mem[(this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<te.uvs0]) - val_11;
            if((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0].normals) <= val_21)
        {
                val_84 = val_84;
        }
        
            TMPro.TMP_CharacterInfo val_22 = val_21 + (val_21 << 1);
            TMPro.TMP_MeshInfo val_23 = val_74 + (val_22 << 2);
            if((this.<textInfo>5__2.meshInfo[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + 12) <= val_21)
        {
                val_84 = val_84;
        }
        
            TMPro.TMP_MeshInfo val_26 = val_84 + (val_22 << 2);
            mem2[0] = (this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + (((this.<textInfo>5__2.characterInfo[0x0][0] + 3) + ((t.uvs2;
            mem2[0] = ((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + (((this.<textInfo>5__2.characterInfo[0x0][0] + 3) + ((t.tangents) - val_12;
            mem2[0] = ((this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + (((this.<textInfo>5__2.characterInfo[0x0][0] + 3) + ((t.uvs0) - val_11;
            mem[536902347].Add(item:  UnityEngine.Random.Range(minInclusive:  (this.<cachedMeshInfoVertexData>5__3[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + (((this.<textInfo>5__2.characterInfo[0x0][0] + 3) + ((t.tangents, maxInclusive:  null));
            var val_28 = ((this.<textInfo>5__2.meshInfo[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo> + 24) - 4;
            var val_29 = ((this.<textInfo>5__2.meshInfo[((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo>5__2.characterInfo[0x0][0]) << 2)) << 3][0] + ((this.<textInfo>5__2.characterInfo[0x0][0] + (this.<textInfo> + 24) - 8;
            this.<scaleSortingOrder>5__4.Add(item:  mem[536878303] - 1);
            UnityEngine.Quaternion val_31 = UnityEngine.Quaternion.identity;
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.one;
            float val_81 = val_33;
            float val_82 = val_34;
            float val_83 = val_35;
            val_81 = 1065353216 * val_81;
            val_82 = 1065353216 * val_82;
            val_83 = 1065353216 * val_83;
            UnityEngine.Matrix4x4 val_36 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0.0004226705f, y = 0f, z = 0f}, q:  new UnityEngine.Quaternion() {x = 0f}, s:  new UnityEngine.Vector3() {y = val_81, z = val_82});
            val_86 = mem[val_36.m13 + 124];
            val_86 = val_36.m13 + 124;
            mem2[0] = val_36.m02;
            mem2[0] = 0;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 120))
        {
                val_86 = mem[val_36.m13 + 124];
            val_86 = val_36.m13 + 124;
        }
        
            mem2[0] = val_36.m13 + 128;
            val_87 = (val_36.m13 + 80) - 8;
            mem2[0] = val_36.m13 + 132;
            mem2[0] = val_36.m13 + 136;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 112))
        {
                val_87 = val_87;
        }
        
            float val_38 = val_36.m13 + 128;
            mem2[0] = val_36.m13 + 80;
            mem2[0] = 0;
            float val_39 = val_36.m32 - 152;
            val_88 = val_36.m13 + 80;
            val_89 = val_86;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 112))
        {
                val_89 = mem[val_36.m13 + 124];
            val_89 = val_36.m13 + 124;
            val_88 = val_88;
        }
        
            mem2[0] = val_36.m13 + 128;
            mem2[0] = val_36.m13 + 132;
            val_90 = (val_36.m13 + 76) - 4;
            mem2[0] = val_36.m13 + 136;
            mem2[0] = val_87;
            mem2[0] = (val_36.m13 + 80) - 4;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 108))
        {
                val_90 = val_90;
        }
        
            float val_41 = val_36.m32 - 152;
            mem2[0] = val_36.m13 + 76;
            mem2[0] = 0;
            float val_42 = val_36.m13 + 128;
            val_91 = mem[val_36.m13 + 128];
            val_91 = val_36.m13 + 128;
            val_92 = val_89;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 108))
        {
                val_92 = mem[val_36.m13 + 124];
            val_92 = val_36.m13 + 124;
            val_91 = val_91;
        }
        
            mem2[0] = val_91;
            mem2[0] = val_36.m13 + 132;
            mem2[0] = val_36.m13 + 136;
            val_93 = (val_36.m13 + 72) - 8;
            mem2[0] = (val_36.m13 + 76) - 8;
            mem2[0] = val_90;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 100))
        {
                val_93 = val_93;
        }
        
            float val_44 = val_36.m32 - 152;
            mem2[0] = val_36.m13 + 72;
            mem2[0] = 0;
            float val_45 = val_36.m13 + 128;
            val_94 = val_36.m13 + 72;
            val_95 = val_92;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 100))
        {
                val_95 = mem[val_36.m13 + 124];
            val_95 = val_36.m13 + 124;
            val_94 = val_94;
        }
        
            mem2[0] = val_36.m13 + 128;
            mem2[0] = val_36.m13 + 132;
            mem2[0] = val_36.m13 + 136;
            mem2[0] = val_93;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 120))
        {
                val_95 = mem[val_36.m13 + 124];
            val_95 = val_36.m13 + 124;
        }
        
            float val_84 = val_36.m13 + 88;
            float val_85 = val_36.m13 + 92;
            float val_86 = val_36.m13 + 84;
            val_84 = val_12 + val_84;
            val_85 = val_11 + val_85;
            val_86 = val_86 + 0f;
            mem2[0] = val_84;
            mem2[0] = val_85;
            mem2[0] = val_86;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 112))
        {
                val_95 = mem[val_36.m13 + 124];
            val_95 = val_36.m13 + 124;
        }
        
            float val_87 = val_36.m13 + 52;
            float val_88 = val_36.m13 + 48;
            float val_89 = val_36.m13 + 80;
            val_87 = val_11 + val_87;
            val_88 = val_12 + val_88;
            val_89 = val_89 + 0f;
            mem2[0] = val_88;
            mem2[0] = val_87;
            mem2[0] = val_89;
            if((val_36.m13 + 124 + 12) <= (val_36.m13 + 108))
        {
                val_95 = mem[val_36.m13 + 124];
            val_95 = val_36.m13 + 124;
        }
        
            float val_90 = val_36.m13 + 36;
            float val_91 = val_36.m13 + 76;
            float val_92 = val_36.m13 + 44;
            val_90 = val_12 + val_90;
            val_91 = val_91 + 0f;
            val_92 = val_11 + val_92;
            mem2[0] = val_90;
            mem2[0] = val_92;
            mem2[0] = val_91;
            float val_93 = (val_36.m13 + 72) - 4;
            float val_94 = val_36.m13 + 40;
            float val_95 = val_36.m13 + 72;
            val_93 = val_11 + val_93;
            val_94 = val_12 + val_94;
            val_95 = val_95 + 0f;
            mem2[0] = val_94;
            mem2[0] = val_93;
            mem2[0] = val_95;
            var val_96 = val_36.m13 + 116;
            val_96 = (val_36.m13 + 96 + 28) + (val_96 << 3);
            var val_97 = val_36.m13 + 116;
            val_97 = (val_36.m13 + 96 + 24 + 64) + (val_97 << 3);
            var val_46 = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36) + ((val_36.m13 + 120) << 3);
            var val_47 = ((val_36.m13 + 96 + 24 + 64 + (val_36.m13 + 116) << 3) + 36) + ((val_36.m13 + 120) << 3);
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36 + (val_36.m13 + 120) << 3) + 16;
            var val_48 = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36) + ((val_36.m13 + 112) << 3);
            var val_49 = ((val_36.m13 + 96 + 24 + 64 + (val_36.m13 + 116) << 3) + 36) + ((val_36.m13 + 112) << 3);
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36 + (val_36.m13 + 112) << 3) + 16;
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36 + (val_36.m13 + 112) << 3) + 20;
            var val_50 = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36) + ((val_36.m13 + 108) << 3);
            var val_51 = ((val_36.m13 + 96 + 24 + 64 + (val_36.m13 + 116) << 3) + 36) + ((val_36.m13 + 108) << 3);
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36 + (val_36.m13 + 108) << 3) + 16;
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36 + (val_36.m13 + 108) << 3) + 20;
            var val_52 = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36) + ((val_36.m13 + 100) << 3);
            var val_53 = ((val_36.m13 + 96 + 24 + 64 + (val_36.m13 + 116) << 3) + 36) + ((val_36.m13 + 100) << 3);
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36 + (val_36.m13 + 100) << 3) + 16;
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 36 + (val_36.m13 + 100) << 3) + 20;
            val_82 = mem[val_36.m13 + 56];
            val_82 = val_36.m13 + 56;
            var val_98 = val_36.m13 + 116;
            val_98 = (val_36.m13 + 96 + 28) + (val_98 << 3);
            var val_99 = val_36.m13 + 116;
            val_76 = val_36.m13 + 96;
            val_99 = (val_36.m13 + 96 + 24 + 64) + (val_99 << 3);
            var val_54 = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 44) + ((val_36.m13 + 120) << 2);
            var val_55 = ((val_36.m13 + 96 + 24 + 64 + (val_36.m13 + 116) << 3) + 44) + ((val_36.m13 + 120) << 2);
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 44 + (val_36.m13 + 120) << 2) + 16;
            var val_56 = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 44) + ((val_36.m13 + 112) << 2);
            var val_57 = ((val_36.m13 + 96 + 24 + 64 + (val_36.m13 + 116) << 3) + 44) + ((val_36.m13 + 112) << 2);
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 44 + (val_36.m13 + 112) << 2) + 16;
            var val_58 = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 44) + ((val_36.m13 + 108) << 2);
            var val_59 = ((val_36.m13 + 96 + 24 + 64 + (val_36.m13 + 116) << 3) + 44) + ((val_36.m13 + 108) << 2);
            val_79 = mem[val_36.m13 + 100];
            val_79 = val_36.m13 + 100;
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 44 + (val_36.m13 + 108) << 2) + 16;
            var val_60 = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 44) + (val_79 << 2);
            val_81 = mem[val_36.m13 + 60];
            val_81 = val_36.m13 + 60;
            var val_61 = ((val_36.m13 + 96 + 24 + 64 + (val_36.m13 + 116) << 3) + 44) + (val_79 << 2);
            mem2[0] = ((val_36.m13 + 96 + 28 + (val_36.m13 + 116) << 3) + 44 + (val_36.m13 + 100) << 2) + 16;
        }
        
            val_82 = val_82 + 1;
            val_80 = val_81 + 356;
        }
        while((val_36.m13 + 32) != val_82);
        
        }
        
        val_96 = 0;
        val_97 = 0;
        goto label_93;
        label_129:
        val_98 = mem[val_36.m13 + 96 + 20 + 12];
        val_98 = val_36.m13 + 96 + 20 + 12;
        if(val_98 == 0)
        {
                val_98 = 536873785;
            mem2[0] = val_98;
        }
        
        var val_62 = (val_36.m13 + 96 + 24 + 64) + val_96;
        val_62 = val_62 + 16;
        var val_63 = (val_36.m13 + 96 + 24 + 64) + val_96;
        var val_64 = (val_36.m13 + 96 + 24 + 64) + val_96;
        var val_65 = (val_36.m13 + 96 + 24 + 64) + val_96;
        var val_66 = (val_36.m13 + 96 + 24 + 64) + val_96;
        var val_67 = (val_36.m13 + 96 + 24 + 64) + val_96;
        var val_68 = (val_36.m13 + 96 + 24 + 64) + val_96;
        val_80 = mem[val_36.m13 + 68 + 24];
        val_80 = val_36.m13 + 68 + 24;
        var val_69 = (val_36.m13 + 96 + 24 + 64) + val_96;
        val_96 = val_96 + 40;
        val_97 = val_97 + 1;
        label_93:
        if(val_97 < (val_36.m13 + 96 + 24 + 64 + 12))
        {
            goto label_129;
        }
        
        mem2[0] = 536896849;
        val_99 = 2;
        goto label_130;
        label_13:
        UnityEngine.WaitForSeconds val_70 = 536896849;
        val_70 = new UnityEngine.WaitForSeconds(seconds:  null);
        this.<>2__current = val_70;
        val_99 = 1;
        label_130:
        this.<>1__state = val_99;
        val_78 = 1;
        return (bool)val_78;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
    
    }
    private void System.Collections.IEnumerator.Reset()
    {
        22713476 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
    
    }

}
