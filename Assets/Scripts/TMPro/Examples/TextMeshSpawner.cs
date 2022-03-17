using UnityEngine;

namespace TMPro.Examples
{
    public class TextMeshSpawner : MonoBehaviour
    {
        // Fields
        public int SpawnType;
        public int NumberOfNPC;
        public UnityEngine.Font TheFont;
        private TMPro.Examples.TextMeshProFloatingText floatingText_Script;
        
        // Methods
        private void Awake()
        {
        
        }
        private void Start()
        {
            float val_11;
            float val_12;
            float val_13;
            float val_14;
            TMPro.Examples.TextMeshSpawner val_19;
            var val_20;
            float val_21;
            var val_22;
            var val_23;
            val_19 = this;
            if(this.NumberOfNPC < 1)
            {
                    return;
            }
            
            label_23:
            UnityEngine.GameObject val_1 = 536887303;
            val_1 = new UnityEngine.GameObject();
            UnityEngine.Transform val_2 = val_1.transform;
            float val_4 = UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null), maxInclusive:  null);
            if(this.SpawnType == 0)
            {
                goto label_3;
            }
            
            val_1.position = new UnityEngine.Vector3() {x = -95f, y = 0.5f, z = -95f};
            SynchronizationContextBehavoir val_5 = val_1.AddComponent<SynchronizationContextBehavoir>();
            UnityEngine.Transform val_6 = val_1.GetComponent<UnityEngine.Transform>();
            UnityEngine.Material val_7 = mem[1152921509864856324].material;
            val_1.sharedMaterial = mem[1152921509864856324];
            if(val_1 == 0)
            {
                goto label_9;
            }
            
            val_1.font = mem[1152921509864856324];
            val_1.anchor = 7;
            goto label_10;
            label_3:
            val_1.position = new UnityEngine.Vector3() {x = -95f, y = 0.5f, z = -95f};
            SynchronizationContextBehavoir val_8 = val_1.AddComponent<SynchronizationContextBehavoir>();
            if(val_1 == 0)
            {
                goto label_13;
            }
            
            val_1.fontSize = val_4;
            goto label_14;
            label_9:
            val_1.font = mem[1152921509864856324];
            val_1.anchor = 7;
            label_10:
            val_1.fontSize = 96;
            val_20 = 0;
            UnityEngine.Color32 val_9 = new UnityEngine.Color32(r:  255, g:  255, b:  0, a:  255);
            UnityEngine.Color val_10 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 216, g = 171, b = 102, a = 57});
            val_21 = val_11;
            if(val_1 != 0)
            {
                    val_1.color = new UnityEngine.Color() {r = val_21, g = val_12, b = val_13, a = val_14};
            }
            else
            {
                    val_1.color = new UnityEngine.Color() {r = val_21, g = val_12, b = val_13, a = val_14};
            }
            
            val_22 = 0;
            val_19 = val_19;
            val_1.text = -1610612247;
            SynchronizationContextBehavoir val_15 = val_1.AddComponent<SynchronizationContextBehavoir>();
            mem2[0] = val_1;
            val_23 = 0;
            mem2[0] = 1;
            goto label_19;
            label_13:
            0.fontSize = val_4;
            label_14:
            UnityEngine.Color32 val_16 = new UnityEngine.Color32(r:  255, g:  255, b:  0, a:  255);
            UnityEngine.Color val_17 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 216, g = 171, b = 102, a = 57});
            val_20 = val_11;
            val_21 = val_12;
            SynchronizationContextBehavoir val_18 = val_1.AddComponent<SynchronizationContextBehavoir>();
            mem2[0] = val_1;
            val_23 = 0;
            val_19 = val_19;
            val_22 = 0;
            mem2[0] = val_23;
            label_19:
            val_22 = val_22 + 1;
            if(val_22 < this.NumberOfNPC)
            {
                goto label_23;
            }
        
        }
        public TextMeshSpawner()
        {
            this.NumberOfNPC = 12;
        }
    
    }

}
