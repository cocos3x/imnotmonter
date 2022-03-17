using UnityEngine;
private sealed class VertexShakeA.<AnimateVertexColors>d__11 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public TMPro.Examples.VertexShakeA <>4__this;
    private TMPro.TMP_TextInfo <textInfo>5__2;
    private UnityEngine.Vector3[][] <copyOfVertices>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public VertexShakeA.<AnimateVertexColors>d__11(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_5;
        float val_7;
        float val_8;
        float val_9;
        VertexShakeA.<AnimateVertexColors>d__11 val_57;
        TMPro.Examples.VertexShakeA val_58;
        var val_59;
        VertexShakeA.<AnimateVertexColors>d__11 val_60;
        VertexShakeA.<AnimateVertexColors>d__11 val_61;
        var val_62;
        var val_63;
        TMPro.TMP_TextInfo val_64;
        TMPro.TMP_TextInfo val_65;
        var val_66;
        var val_67;
        float val_68;
        var val_69;
        var val_70;
        float val_71;
        var val_72;
        int val_73;
        var val_74;
        val_57 = this;
        val_58 = this.<>4__this;
        if(((this.<>1__state) - 1) >= 2)
        {
            goto label_1;
        }
        
        this.<>1__state = 0;
        if(val_58 != 0)
        {
            goto label_3;
        }
        
        goto label_3;
        label_1:
        val_59 = 0;
        if((this.<>1__state) != 0)
        {
                return (bool)val_59;
        }
        
        val_60 = val_57;
        this.<>1__state = 0;
        this.<textInfo>5__2 = this.<>4__this.m_TextComponent.m_textInfo;
        val_57 = val_60;
        mem[1152921509868924808] = 536881667;
        this.<>4__this.hasTextChanged = true;
        label_3:
        if((this.<>4__this.hasTextChanged) == false)
        {
            goto label_8;
        }
        
        val_61 = val_57;
        if(true < (this.<>4__this.hasTextChanged))
        {
                this.<copyOfVertices>5__3 = 536881667;
        }
        
        val_62 = 1152921509868924804;
        val_63 = 0;
        val_60 = 24;
        goto label_15;
        label_26:
        mem[536881683] = 536882597;
        val_60 = 64;
        val_63 = 1;
        val_62 = SL;
        label_15:
        val_64 = val_62;
        if(val_63 < (SL + 64 + 12))
        {
            goto label_26;
        }
        
        val_58 = val_58;
        mem2[0] = 0;
        goto label_28;
        label_8:
        val_64 = this.<textInfo>5__2;
        label_28:
        val_65 = val_64;
        if((mem[this.<textInfo>5__2] + 12) == 0)
        {
            goto label_30;
        }
        
        if((mem[this.<textInfo>5__2] + 32) <= 0)
        {
            goto label_32;
        }
        
        val_61 = 1152921509868924808;
        val_58 = val_65;
        do
        {
            val_66 = 22020112;
            val_67 = 1476352;
            float val_57 = 1.21913E-43f;
            float val_2 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
            float val_56 = this.<>4__this + 24;
            val_56 = 3196059648 * val_56;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.Euler(x:  val_56, y:  null, z:  null);
            if(val_66 <= val_67)
        {
                val_68 = 0f + (1.35926E-43f);
            float val_10 = val_68 * 0.5f;
            val_69 = val_66 * 356;
            val_57 = (val_57 + (2.522337E-44f)) * 0.5f;
            float val_11 = ((2.522337E-44f) + 0f) * 0.5f;
            do
        {
            var val_12 = (mem[this.<textInfo>5__2] + 44) + val_69;
            if(((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 368) != 0)
        {
                var val_13 = (mem[this.<textInfo>5__2] + 44) + val_69;
            var val_58 = val_69;
            val_58 = (mem[this.<textInfo>5__2] + 44) + val_58;
            var val_71 = (mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 72;
            var val_14 = ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2);
            val_14 = (mem[this.<textInfo>5__2] + 64) + (val_14 << 3);
            UnityEngine.Vector3[][] val_15 = (this.<copyOfVertices>5__3) + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2);
            var val_16 = val_71 + (val_71 << 1);
            val_16 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24) + (val_16 << 2);
            float val_61 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + (((mem[this.<textInfo>5__2] + 44 + 16;
            float val_60 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + (((mem[this.<textInfo>5__2] + 44 + 20;
            float val_59 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + (((mem[this.<textInfo>5__2] + 44 + 24;
            val_59 = val_59 - val_10;
            val_60 = val_60 - val_57;
            val_61 = val_61 - val_11;
            var val_62 = val_16;
            val_62 = (mem[(this.<copyOfVertices>5__3 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2) + 16]) + (val_62 << 2);
            mem2[0] = val_61;
            mem2[0] = val_60;
            mem2[0] = val_59;
            UnityEngine.Vector3[][] val_17 = (this.<copyOfVertices>5__3) + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2);
            var val_18 = val_71 + 1;
            var val_19 = val_18 + (val_18 << 1);
            val_19 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24) + (val_19 << 2);
            float val_65 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + ((((mem[this.<textInfo>5__2] + 4 + 16;
            float val_64 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + ((((mem[this.<textInfo>5__2] + 4 + 20;
            float val_63 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + ((((mem[this.<textInfo>5__2] + 4 + 24;
            val_63 = val_63 - val_10;
            val_64 = val_64 - val_57;
            val_65 = val_65 - val_11;
            var val_66 = val_19;
            val_66 = (mem[(this.<copyOfVertices>5__3 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2) + 16]) + (val_66 << 2);
            mem2[0] = val_65;
            mem2[0] = val_64;
            mem2[0] = val_63;
            UnityEngine.Vector3[][] val_20 = (this.<copyOfVertices>5__3) + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2);
            var val_21 = val_71 + 2;
            var val_22 = val_21 + (val_21 << 1);
            val_22 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24) + (val_22 << 2);
            float val_69 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + ((((mem[this.<textInfo>5__2] + 4 + 16;
            float val_68 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + ((((mem[this.<textInfo>5__2] + 4 + 20;
            float val_67 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + ((((mem[this.<textInfo>5__2] + 4 + 24;
            val_67 = val_67 - val_10;
            val_68 = val_68 - val_57;
            val_69 = val_69 - val_11;
            var val_70 = val_22;
            val_70 = (mem[(this.<copyOfVertices>5__3 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2) + 16]) + (val_70 << 2);
            mem2[0] = val_69;
            mem2[0] = val_68;
            mem2[0] = val_67;
            UnityEngine.Vector3[][] val_23 = (this.<copyOfVertices>5__3) + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2);
            val_71 = val_71 + 3;
            var val_24 = val_71 + (val_71 << 1);
            val_24 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24) + (val_24 << 2);
            float val_74 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + ((((mem[this.<textInfo>5__2] + 4 + 16;
            float val_73 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + ((((mem[this.<textInfo>5__2] + 4 + 20;
            float val_72 = ((mem[this.<textInfo>5__2] + 64 + (((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2)) << 3) + 24 + ((((mem[this.<textInfo>5__2] + 4 + 24;
            val_72 = val_72 - val_10;
            val_73 = val_73 - val_57;
            val_74 = val_74 - val_11;
            var val_75 = val_24;
            val_75 = (mem[(this.<copyOfVertices>5__3 + ((mem[this.<textInfo>5__2] + 44 + (val_66 * 356)) + 52) << 2) + 16]) + (val_75 << 2);
            mem2[0] = val_74;
            mem2[0] = val_73;
            mem2[0] = val_72;
            if(0 != 0)
        {
                val_70 = mem[this.<>4__this + 20];
            val_70 = this.<>4__this + 20;
            val_71 = mem[this.<>4__this + 20];
            val_71 = this.<>4__this + 20;
        }
        else
        {
                val_71 = mem[this.<>4__this + 20];
            val_71 = this.<>4__this + 20;
            val_70 = val_71;
        }
        
            float val_25 = UnityEngine.Random.Range(minInclusive:  val_71, maxInclusive:  val_3.y);
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.one;
            uint val_78 = 1065269330;
            float val_76 = val_5;
            float val_77 = val_7;
            val_76 = val_78 * val_76;
            val_77 = val_78 * val_77;
            val_78 = val_78 * val_8;
            UnityEngine.Matrix4x4 val_28 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0.0003142348f, y = val_5, z = val_7}, q:  new UnityEngine.Quaternion() {x = val_8, y = val_5, z = val_7, w = val_8}, s:  new UnityEngine.Vector3() {x = val_9, y = val_76, z = val_77});
            float val_29 = val_28.m32 - 168;
            var val_30 = (val_28.m13 + 116) + (val_28.m22 << 2);
            var val_31 = (val_28.m13 + 116) + (val_28.m22 << 2);
            var val_79 = val_28.m13 + 112;
            float val_32 = val_28.m32 - 168;
            val_79 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_79 << 2);
            mem2[0] = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 112) << 2) + 24;
            mem2[0] = 0;
            float val_33 = val_28.m13 + 120;
            float val_34 = val_28.m13 + 120;
            var val_80 = val_28.m13 + 112;
            val_80 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_80 << 2);
            val_80 = val_80 + 16;
            var val_35 = (val_28.m13 + 116) + (val_28.m22 << 2);
            var val_36 = (val_28.m13 + 116) + (val_28.m22 << 2);
            var val_81 = val_28.m13 + 108;
            float val_37 = val_28.m32 - 168;
            val_81 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_81 << 2);
            mem2[0] = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 108) << 2) + 24;
            mem2[0] = 0;
            float val_38 = val_28.m13 + 120;
            float val_39 = val_28.m13 + 120;
            var val_82 = val_28.m13 + 108;
            val_82 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_82 << 2);
            val_82 = val_82 + 16;
            var val_40 = (val_28.m13 + 116) + (val_28.m22 << 2);
            var val_41 = (val_28.m13 + 116) + (val_28.m22 << 2);
            var val_83 = val_28.m13 + 104;
            float val_42 = val_28.m32 - 168;
            val_83 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_83 << 2);
            mem2[0] = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 104) << 2) + 24;
            mem2[0] = 0;
            float val_43 = val_28.m13 + 120;
            float val_44 = val_28.m13 + 120;
            var val_84 = val_28.m13 + 104;
            val_84 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_84 << 2);
            val_84 = val_84 + 16;
            var val_45 = (val_28.m13 + 116) + (val_28.m22 << 2);
            var val_46 = (val_28.m13 + 116) + (val_28.m22 << 2);
            var val_85 = val_28.m13 + 100;
            float val_47 = val_28.m32 - 168;
            val_85 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_85 << 2);
            mem2[0] = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 100) << 2) + 24;
            mem2[0] = 0;
            float val_48 = val_28.m13 + 120;
            float val_49 = val_28.m13 + 120;
            var val_86 = val_28.m13 + 100;
            val_86 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_86 << 2);
            val_86 = val_86 + 16;
            val_61 = mem[val_28.m13 + 116];
            val_61 = val_28.m13 + 116;
            val_58 = mem[val_28.m13 + 64];
            val_58 = val_28.m13 + 64;
            val_67 = mem[val_28.m13 + 60];
            val_67 = val_28.m13 + 60;
            var val_50 = val_61 + (val_28.m22 << 2);
            var val_87 = val_28.m13 + 112;
            val_87 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_87 << 2);
            float val_88 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 112) << 2) + 16;
            float val_89 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 112) << 2) + 20;
            float val_90 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 112) << 2) + 24;
            val_88 = val_11 + val_88;
            val_89 = val_57 + val_89;
            val_90 = val_10 + val_90;
            mem2[0] = val_88;
            mem2[0] = val_89;
            mem2[0] = val_90;
            var val_51 = val_61 + (val_28.m22 << 2);
            var val_91 = val_28.m13 + 108;
            val_91 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_91 << 2);
            float val_92 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 108) << 2) + 16;
            float val_93 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 108) << 2) + 20;
            float val_94 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 108) << 2) + 24;
            val_92 = val_11 + val_92;
            val_93 = val_57 + val_93;
            val_94 = val_10 + val_94;
            mem2[0] = val_92;
            mem2[0] = val_93;
            mem2[0] = val_94;
            var val_52 = val_61 + (val_28.m22 << 2);
            var val_95 = val_28.m13 + 104;
            val_95 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_95 << 2);
            float val_96 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 104) << 2) + 16;
            float val_97 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 104) << 2) + 20;
            float val_98 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 104) << 2) + 24;
            val_96 = val_11 + val_96;
            val_97 = val_57 + val_97;
            val_98 = val_10 + val_98;
            mem2[0] = val_96;
            mem2[0] = val_97;
            mem2[0] = val_98;
            var val_53 = val_61 + (val_28.m22 << 2);
            val_69 = mem[val_28.m13 + 96];
            val_69 = val_28.m13 + 96;
            var val_99 = val_28.m13 + 100;
            val_99 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16) + (val_99 << 2);
            float val_100 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 100) << 2) + 20;
            float val_101 = ((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 100) << 2) + 24;
            val_68 = val_11 + (((val_28.m13 + 116 + (val_28.m22) << 2) + 16 + (val_28.m13 + 100) << 2) + 16);
            val_100 = val_57 + val_100;
            val_101 = val_10 + val_101;
            mem2[0] = val_68;
            mem2[0] = val_100;
            mem2[0] = val_101;
        }
        
            val_28.m02 = val_28.m02 + 1;
            val_65 = val_69 + 356;
        }
        while(val_28.m02 <= val_67);
        
        }
        
            var val_102 = val_28.m13 + 40;
            val_102 = val_102 + 1;
        }
        while(val_102 != (val_28.m13 + 36));
        
        goto label_133;
        label_30:
        UnityEngine.WaitForSeconds val_54 = 536896849;
        val_54 = new UnityEngine.WaitForSeconds(seconds:  null);
        mem[1152921509868924796] = val_54;
        val_72 = val_57;
        val_73 = 1;
        goto label_134;
        label_32:
        val_58 = val_65;
        val_61 = 1152921509868924808;
        label_133:
        val_74 = 0;
        val_60 = 16;
        goto label_135;
        label_149:
        val_64 = val_61;
        mem[this.<textInfo>5__2] + 64 + val_60.vertices = mem[536881679] + 16;
        val_58 = val_65;
        val_60 = 56;
        val_74 = 1;
        val_61 = val_64;
        label_135:
        if(val_74 < (this.<textInfo>5__2 + 64 + 12))
        {
            goto label_149;
        }
        
        UnityEngine.WaitForSeconds val_55 = 536896849;
        val_55 = new UnityEngine.WaitForSeconds(seconds:  null);
        mem[1152921509868924796] = val_55;
        val_72 = val_57;
        val_73 = 2;
        label_134:
        this.<>1__state = val_73;
        val_59 = 1;
        return (bool)val_59;
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
