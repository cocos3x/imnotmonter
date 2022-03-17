using UnityEngine;

namespace TMPro.Examples
{
    public class Benchmark03 : MonoBehaviour
    {
        // Fields
        public int NumberOfSamples;
        public TMPro.Examples.Benchmark03.BenchmarkType Benchmark;
        public UnityEngine.Font SourceFont;
        
        // Methods
        private void Awake()
        {
        
        }
        private void Start()
        {
            float val_16;
            float val_19;
            float val_20;
            float val_21;
            TMPro.Examples.Benchmark03 val_22;
            TMPro.AtlasPopulationMode val_23;
            var val_24;
            UnityEngine.Font val_25;
            var val_26;
            var val_29;
            var val_30;
            float val_31;
            float val_32;
            val_22 = this;
            if(this.Benchmark > 3)
            {
                goto label_1;
            }
            
            var val_1 = 17837252 + (17837252 + (this.Benchmark) << 2);
            if(this.Benchmark == 3)
            {
                    17837252 + (this.Benchmark) << 2 = (17837252 + (this.Benchmark) << 2) & ((17837252 + (this.Benchmark) << 2) << (17837252 + (this.Benchmark) << 2));
                17837252 + (this.Benchmark) << 2 = (17837252 + (this.Benchmark) << 2) & ((((17837252 + (this.Benchmark) << 2 & (17837252 + (this.Benchmark) << 2) << 17837252 + (this.Benchmark) << 2)) << (32-(17837252 + (this.Benchmark) << 2 & (17837252 + (this.Benchmark) << 2) << 17837252 + (this.Benchmark) << 2))) | (((17837252 + (this.Benchmark) << 2 & (17837252 + (this.Benchmark) << 2) << 17837252 + (this.Benchmark) << 2)) << (17837252 + (this.Benchmark) << 2 & (17837252 + (this.Benchmark) << 2) << 17837252 + (this.Benchmark) << 2)));
                17837252 + (this.Benchmark) << 2 = (17837252 + (this.Benchmark) << 2) & (((IP) << (32-1)) | ((IP) << 1));
                17837252 + (this.Benchmark) << 2 = IP * 17837252;
            }
            
            val_23 = 1;
            val_24 = 9;
            val_25 = this.SourceFont;
            val_26 = 4165;
            goto label_4;
            label_1:
            val_25 = 0;
            goto label_5;
            label_4:
            TMPro.TMP_FontAsset val_5 = TMPro.TMP_FontAsset.CreateFontAsset(font:  null, samplingPointSize:  90, atlasPadding:  9, renderMode:  4117, atlasWidth:  256, atlasHeight:  256, atlasPopulationMode:  null, enableMultiAtlasSupport:  true);
            label_5:
            if(this.NumberOfSamples < 1)
            {
                    return;
            }
            
            var val_22 = 0;
            label_39:
            if(this.Benchmark < 4)
            {
                goto label_18;
            }
            
            if(this.Benchmark != 4)
            {
                goto label_36;
            }
            
            UnityEngine.GameObject val_6 = 536887303;
            val_6 = new UnityEngine.GameObject();
            UnityEngine.Transform val_7 = val_6.transform;
            val_6.position = new UnityEngine.Vector3() {x = 0f, y = 1.2f, z = 0f};
            SynchronizationContextBehavoir val_8 = val_6.AddComponent<SynchronizationContextBehavoir>();
            val_29 = val_6;
            UnityEngine.Transform val_9 = val_29.GetComponent<UnityEngine.Transform>();
            UnityEngine.Material val_10 = this.SourceFont.material;
            val_29.sharedMaterial = this.SourceFont;
            if(val_29 == 0)
            {
                goto label_26;
            }
            
            val_29.font = this.SourceFont;
            val_29.anchor = 4;
            goto label_27;
            label_18:
            UnityEngine.GameObject val_11 = 536887303;
            val_11 = new UnityEngine.GameObject();
            UnityEngine.Transform val_12 = val_11.transform;
            val_11.position = new UnityEngine.Vector3() {x = 0f, y = 1.2f, z = 0f};
            SynchronizationContextBehavoir val_13 = val_11.AddComponent<SynchronizationContextBehavoir>();
            val_29 = val_11;
            if(val_11 != 0)
            {
                    val_29.font = ;
                val_29.fontSize = null;
                val_30 = val_29;
            }
            else
            {
                    val_30 = 0;
                0.font = ;
                0.fontSize = null;
            }
            
            val_30.alignment = 514;
            UnityEngine.Color32 val_14 = new UnityEngine.Color32(r:  255, g:  255, b:  0, a:  255);
            UnityEngine.Color val_15 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 88, g = 236, b = 113, a = 56});
            val_22 = val_22;
            if(this.Benchmark != 3)
            {
                goto label_36;
            }
            
            val_30.fontSize = val_15.r;
            goto label_36;
            label_26:
            val_29.font = this.SourceFont;
            val_29.anchor = 4;
            label_27:
            val_29.fontSize = 130;
            UnityEngine.Color32 val_17 = new UnityEngine.Color32(r:  255, g:  255, b:  0, a:  255);
            UnityEngine.Color val_18 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 88, g = 236, b = 113, a = 56});
            val_32 = val_20;
            val_31 = val_21;
            if(val_29 != 0)
            {
                    val_29.color = new UnityEngine.Color() {r = val_16, g = val_19, b = val_32, a = val_31};
            }
            else
            {
                    val_29.color = new UnityEngine.Color() {r = val_16, g = val_19, b = val_32, a = val_31};
            }
            
            val_29.text = -1610610483;
            label_36:
            val_22 = val_22 + 1;
            if(val_22 < this.NumberOfSamples)
            {
                goto label_39;
            }
        
        }
        public Benchmark03()
        {
            this.NumberOfSamples = 100;
        }
    
    }

}
