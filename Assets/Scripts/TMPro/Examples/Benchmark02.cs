using UnityEngine;

namespace TMPro.Examples
{
    public class Benchmark02 : MonoBehaviour
    {
        // Fields
        public int SpawnType;
        public int NumberOfNPC;
        public bool IsTextObjectScaleStatic;
        private TMPro.Examples.TextMeshProFloatingText floatingText_Script;
        
        // Methods
        private void Start()
        {
            float val_27;
            float val_28;
            float val_29;
            float val_30;
            TMPro.Examples.Benchmark02 val_41;
            var val_42;
            var val_43;
            float val_44;
            var val_45;
            var val_46;
            var val_47;
            val_41 = this;
            if(this.NumberOfNPC < 1)
            {
                    return;
            }
            
            val_42 = 0;
            val_43 = 0;
            val_44 = 4.01406E-38f;
            label_49:
            if(this.SpawnType == 2)
            {
                goto label_2;
            }
            
            if(this.SpawnType == 1)
            {
                goto label_3;
            }
            
            if(this.SpawnType != 0)
            {
                goto label_46;
            }
            
            UnityEngine.GameObject val_1 = 536887303;
            val_1 = new UnityEngine.GameObject();
            UnityEngine.Transform val_2 = val_1.transform;
            float val_4 = UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null), maxInclusive:  null);
            val_1.position = new UnityEngine.Vector3() {x = -95f, y = 0.25f, z = -95f};
            SynchronizationContextBehavoir val_5 = val_1.AddComponent<SynchronizationContextBehavoir>();
            val_45 = val_1;
            UnityEngine.RectTransform val_6 = val_45.rectTransform;
            val_45.pivot = new UnityEngine.Vector2() {x = 0.5f, y = 0f};
            if(val_45 == 0)
            {
                goto label_11;
            }
            
            val_45.alignment = 1026;
            val_45.fontSize = val_4;
            goto label_12;
            label_3:
            UnityEngine.GameObject val_7 = 536887303;
            val_46 = val_7;
            val_7 = new UnityEngine.GameObject();
            UnityEngine.Transform val_8 = val_46.transform;
            float val_10 = UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null), maxInclusive:  null);
            val_46.position = new UnityEngine.Vector3() {x = -95f, y = 0.25f, z = -95f};
            SynchronizationContextBehavoir val_11 = val_46.AddComponent<SynchronizationContextBehavoir>();
            val_45 = val_46;
            TMPro.TMP_SpriteAsset val_12 = UnityEngine.Resources.Load<TMPro.TMP_SpriteAsset>(path:  -1610608035);
            if(val_45 == 0)
            {
                goto label_16;
            }
            
            val_45.font = -1610608035;
            UnityEngine.Transform val_13 = val_45.GetComponent<UnityEngine.Transform>();
            val_47 = val_45;
            goto label_17;
            label_2:
            UnityEngine.GameObject val_14 = 536887303;
            val_46 = val_14;
            val_14 = new UnityEngine.GameObject();
            SynchronizationContextBehavoir val_15 = val_46.AddComponent<SynchronizationContextBehavoir>();
            UnityEngine.Camera val_16 = UnityEngine.Camera.main;
            val_46.worldCamera = 0;
            UnityEngine.Transform val_17 = val_46.transform;
            val_46.localScale = new UnityEngine.Vector3() {x = 0.1f, y = 0.1f, z = 0.1f};
            UnityEngine.Transform val_18 = val_46.transform;
            float val_20 = UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null), maxInclusive:  null);
            val_46.position = new UnityEngine.Vector3() {x = -95f, y = 5f, z = -95f};
            UnityEngine.GameObject val_21 = 536887303;
            val_21 = new UnityEngine.GameObject();
            SynchronizationContextBehavoir val_22 = val_21.AddComponent<SynchronizationContextBehavoir>();
            val_45 = val_21;
            UnityEngine.RectTransform val_23 = val_45.rectTransform;
            UnityEngine.Transform val_24 = val_46.transform;
            val_45.SetParent(parent:  536887303, worldPositionStays:  false);
            UnityEngine.Color32 val_25 = new UnityEngine.Color32(r:  255, g:  255, b:  0, a:  255);
            UnityEngine.Color val_26 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 216, g = 75, b = 108, a = 56});
            if(val_45 == 0)
            {
                goto label_29;
            }
            
            val_45.alignment = 1026;
            val_45.fontSize = val_26.r;
            goto label_30;
            label_16:
            val_45.font = -1610608035;
            UnityEngine.Transform val_31 = 0.GetComponent<UnityEngine.Transform>();
            val_47 = 0;
            label_17:
            UnityEngine.Font val_32 = val_45.font;
            UnityEngine.Material val_33 = val_45.material;
            val_47.sharedMaterial = 536887303;
            if(val_45 != 0)
            {
                    val_45.anchor = 7;
            }
            else
            {
                    val_45.anchor = 7;
            }
            
            val_45.fontSize = 96;
            UnityEngine.Color32 val_34 = new UnityEngine.Color32(r:  255, g:  255, b:  0, a:  255);
            UnityEngine.Color val_35 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 216, g = 75, b = 108, a = 56});
            if(val_45 != 0)
            {
                    val_45.color = new UnityEngine.Color() {r = val_27, g = val_28, b = val_29, a = val_30};
            }
            else
            {
                    val_45.color = new UnityEngine.Color() {r = val_27, g = val_28, b = val_29, a = val_30};
            }
            
            val_45.text = -1610612247;
            val_44 = 4.01406E-38f;
            val_43 = val_43;
            val_41 = val_41;
            SynchronizationContextBehavoir val_36 = val_46.AddComponent<SynchronizationContextBehavoir>();
            mem2[0] = val_46;
            val_42 = 0;
            mem2[0] = 1;
            goto label_46;
            label_11:
            val_45.alignment = 1026;
            val_45.fontSize = val_4;
            label_12:
            val_45.enableKerning = false;
            UnityEngine.Color32 val_37 = new UnityEngine.Color32(r:  255, g:  255, b:  0, a:  255);
            UnityEngine.Color val_38 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 216, g = 75, b = 108, a = 56});
            val_46 = val_27;
            val_41 = val_41;
            val_42 = 0;
            if(mem[1152921509848447748] == true)
            {
                    mem[1152921509848447748] = 1;
            }
            
            val_45.isTextObjectScaleStatic = true;
            val_44 = 4.01406E-38f;
            SynchronizationContextBehavoir val_39 = val_1.AddComponent<SynchronizationContextBehavoir>();
            mem2[0] = val_1;
            mem2[0] = val_42;
            IsTextObjectScaleStatic = mem[1152921509848447748];
            val_43 = val_43;
            goto label_46;
            label_29:
            val_45.alignment = 1026;
            val_45.fontSize = val_26.r;
            label_30:
            val_41 = val_41;
            val_42 = 0;
            val_44 = 4.01406E-38f;
            val_43 = val_43;
            SynchronizationContextBehavoir val_40 = val_46.AddComponent<SynchronizationContextBehavoir>();
            mem2[0] = val_46;
            mem2[0] = val_42;
            label_46:
            val_43 = val_43 + 1;
            if(val_43 < this.NumberOfNPC)
            {
                goto label_49;
            }
        
        }
        public Benchmark02()
        {
            this.NumberOfNPC = 12;
        }
    
    }

}
