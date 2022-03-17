using UnityEngine;

namespace Ferr
{
    public class CameraShake : MonoBehaviour
    {
        // Fields
        private static Ferr.CameraShake instance;
        private UnityEngine.Vector3 magnitude;
        private float duration;
        private float start;
        private UnityEngine.Vector3 offset;
        private UnityEngine.AnimationCurve curve;
        
        // Properties
        private static Ferr.CameraShake Instance { get; }
        
        // Methods
        private static Ferr.CameraShake get_Instance()
        {
            var val_3;
            var val_4;
            val_3 = 536884545;
            if(((mem[536884732] & true) == 0) && (mem[536884661] == 0))
            {
                    val_3 = 536884545;
            }
            
            if(mem[536884637] == 0)
            {
                    Ferr.CameraShake val_2 = Ferr.CameraShake.Create();
                mem2[0] = 536884545;
            }
            
            val_4 = 536884545;
            if((mem[536884732] & true) != 0)
            {
                    return;
            }
            
            if(mem[536884661] != 0)
            {
                    return;
            }
            
            val_4 = 536884545;
        }
        private CameraShake()
        {
        
        }
        private static Ferr.CameraShake Create()
        {
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            UnityEngine.GameObject val_2 = 0.gameObject;
            if(0 != 0)
            {
                    return 0.AddComponent<SynchronizationContextBehavoir>();
            }
            
            return 0.AddComponent<SynchronizationContextBehavoir>();
        }
        private void LateUpdate()
        {
            float val_5;
            float val_6;
            float val_7;
            float val_21;
            float val_22;
            float val_23;
            float val_1 = UnityEngine.Time.time;
            float val_21 = this.start;
            val_21 = 0 - val_21;
            float val_2 = val_21 / this.duration;
            UnityEngine.Transform val_3 = this.transform;
            if(this > 0)
            {
                    UnityEngine.Vector3 val_4 = position;
                float val_22 = val_5;
                float val_23 = val_6;
                val_22 = val_22 - this.offset;
                float val_24 = val_7;
                val_23 = val_23 - S8;
                val_24 = val_24 - S10;
                val_21 = val_22;
                val_22 = val_23;
                val_23 = val_24;
                this.position = new UnityEngine.Vector3() {x = val_21, y = val_22, z = val_23};
                UnityEngine.Vector2 val_8 = UnityEngine.Vector2.zero;
                this.enabled = false;
                return;
            }
            
            UnityEngine.Vector3 val_9 = position;
            float val_25 = val_5;
            float val_26 = val_6;
            val_25 = val_25 - this.offset;
            float val_27 = val_7;
            val_26 = val_26 - S8;
            val_27 = val_27 - S10;
            this.position = new UnityEngine.Vector3() {x = val_25, y = val_26, z = val_27};
            float val_16 = this.curve.Evaluate(time:  UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  UnityEngine.Random.Range(minInclusive:  val_25, maxInclusive:  val_9.y), maxInclusive:  val_9.y), maxInclusive:  val_9.y));
            UnityEngine.AnimationCurve val_28 = this.curve;
            val_28 = this.magnitude ^ 2147483648 * val_28;
            this.offset = this.magnitude ^ 2147483648 * val_28;
            mem[1152921510116249108] = this.magnitude ^ 2147483648 * val_28;
            mem[1152921510116249112] = val_28;
            UnityEngine.Transform val_19 = this.transform;
            val_23 = 0;
            UnityEngine.Vector3 val_20 = position;
            float val_29 = val_5;
            float val_30 = val_6;
            val_29 = val_29 + this.offset;
            float val_31 = val_7;
            val_30 = val_30 + S8;
            val_31 = val_31 + S10;
            val_22 = val_29;
            val_21 = val_30;
            this.position = new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_31};
        }
        public static void Shake(UnityEngine.Vector3 aMagnitude, float aDuration)
        {
            var val_8;
            var val_9;
            var val_10;
            float val_12;
            float val_13;
            float val_14;
            Ferr.CameraShake val_1 = Ferr.CameraShake.Instance;
            mem[536884557] = aMagnitude.x;
            mem[536884561] = aMagnitude.y;
            mem[536884565] = aMagnitude.z;
            Ferr.CameraShake val_2 = Ferr.CameraShake.Instance;
            mem[536884569] = R3;
            Ferr.CameraShake val_3 = Ferr.CameraShake.Instance;
            float val_4 = UnityEngine.Time.time;
            mem[536884573] = 0;
            Ferr.CameraShake val_5 = Ferr.CameraShake.Instance;
            UnityEngine.Transform val_6 = 0.transform;
            UnityEngine.Vector3 val_7 = position;
            Ferr.CameraShake val_11 = Ferr.CameraShake.Instance;
            float val_24 = val_12;
            float val_25 = val_13;
            float val_26 = val_14;
            val_24 = val_8 - val_24;
            val_25 = val_9 - val_25;
            val_26 = val_10 - val_26;
            0.position = new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26};
            Ferr.CameraShake val_15 = Ferr.CameraShake.Instance;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.zero;
            Ferr.CameraShake val_17 = Ferr.CameraShake.Instance;
            free_mem[].enabled = true;
            Ferr.CameraShake val_18 = Ferr.CameraShake.Instance;
            UnityEngine.Keyframe val_19 = new UnityEngine.Keyframe(time:  val_16.x, value:  val_16.y);
            var val_20 = 536882139 + 16;
            mem[536882171] = val_19.m_WeightedMode;
            mem[536882175] = val_19.m_InWeight;
            mem[536882179] = val_19.m_Time;
            UnityEngine.Keyframe val_21 = new UnityEngine.Keyframe(time:  val_16.x, value:  val_16.y);
            var val_22 = 536882139 + 44;
            mem[536882199] = val_21.m_WeightedMode;
            mem[536882203] = val_21.m_Time;
            mem[536882207] = val_21.m_Time;
            UnityEngine.AnimationCurve val_23 = 536883291;
            val_23 = new UnityEngine.AnimationCurve(keys:  536882139);
            mem[76] = val_23;
        }
        private static CameraShake()
        {
        
        }
    
    }

}
