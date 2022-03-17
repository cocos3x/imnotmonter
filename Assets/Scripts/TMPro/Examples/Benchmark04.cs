using UnityEngine;

namespace TMPro.Examples
{
    public class Benchmark04 : MonoBehaviour
    {
        // Fields
        public int SpawnType;
        public int MinPointSize;
        public int MaxPointSize;
        public int Steps;
        private UnityEngine.Transform m_Transform;
        
        // Methods
        private void Start()
        {
            float val_14;
            float val_15;
            var val_16;
            var val_24;
            var val_25;
            int val_26;
            int val_27;
            var val_28;
            int val_29;
            UnityEngine.Transform val_1 = this.transform;
            this.m_Transform = this;
            UnityEngine.Camera val_2 = UnityEngine.Camera.main;
            int val_3 = UnityEngine.Screen.height;
            val_3 = val_3 + (val_3 >> 31);
            val_3 = val_3 >> 1;
            float val_25 = val_3;
            val_24 = 0;
            0.orthographicSize = val_3;
            val_25 = UnityEngine.Screen.width;
            val_26 = this.MinPointSize;
            val_27 = this.MaxPointSize;
            if(val_26 > val_27)
            {
                    return;
            }
            
            float val_24 = (float)UnityEngine.Screen.height;
            float val_6 = val_25 + val_25;
            uint val_28 = 0;
            val_24 = (float)val_25 / val_24;
            val_24 = val_24 * val_25;
            val_25 = val_25 * 0.975f;
            do
            {
                if(this.SpawnType == 0)
            {
                    string val_8 = val_26.ToString();
                string val_9 = -1610604013(-1610604013) + 947246948 + -1610612435(-1610612435);
                UnityEngine.GameObject val_10 = 536887303;
                val_28 = val_10;
                val_10 = new UnityEngine.GameObject(name:  -1610604013);
                if(this.SpawnType > 0)
            {
                    return;
            }
            
                UnityEngine.Transform val_11 = val_28.transform;
                UnityEngine.Vector3 val_12 = position;
                float val_13 = val_25 - val_28;
                float val_26 = val_14;
                float val_27 = val_15;
                val_26 = val_26 - (val_24 * 0.975f);
                val_27 = val_27 + 0f;
                val_13 = val_13 + val_16;
                val_28.position = new UnityEngine.Vector3() {x = val_26, y = val_13, z = val_27};
                SynchronizationContextBehavoir val_17 = val_28.AddComponent<SynchronizationContextBehavoir>();
                val_28 = val_28;
                UnityEngine.RectTransform val_18 = val_28.rectTransform;
                val_28.pivot = new UnityEngine.Vector2() {x = 0f, y = 0.5f};
                if(val_28 != 0)
            {
                    val_28.enableWordWrapping = false;
                val_28.extraPadding = true;
                val_28.isOrthographic = true;
                val_29 = val_26;
            }
            else
            {
                    val_28.enableWordWrapping = false;
                val_28.extraPadding = true;
                val_28.isOrthographic = true;
                val_29 = val_26;
            }
            
                val_28.fontSize = (float)val_29;
                string val_19 = val_26.ToString();
                string val_20 = 947246948 + -1610612301(-1610612301);
                UnityEngine.Color32 val_21 = new UnityEngine.Color32(r:  255, g:  255, b:  255, a:  255);
                UnityEngine.Color val_22 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = 80, g = 215, b = 117, a = 56});
                val_26 = val_26;
                val_24 = 0;
                val_27 = this.MaxPointSize;
                val_28 = val_28 + (float)val_26;
            }
            
                val_26 = this.Steps + val_26;
            }
            while(val_26 <= val_27);
        
        }
        public Benchmark04()
        {
            this.MinPointSize = 12;
            this.MaxPointSize = 64;
            this.Steps = 4;
        }
    
    }

}
