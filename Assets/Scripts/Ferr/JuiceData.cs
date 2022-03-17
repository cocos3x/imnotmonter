using UnityEngine;

namespace Ferr
{
    [Serializable]
    public class JuiceData
    {
        // Fields
        public Ferr.JuiceType type;
        public UnityEngine.Transform transform;
        public float start;
        public float end;
        public float duration;
        public float startTime;
        public bool relative;
        public UnityEngine.AnimationCurve curve;
        public System.Action callback;
        
        // Methods
        public bool Update()
        {
            float val_12;
            float val_13;
            float val_14;
            var val_24;
            var val_25;
            var val_26;
            Ferr.JuiceType val_27;
            float val_28;
            float val_29;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            float val_34;
            float val_35;
            float val_36;
            float val_37;
            val_24 = 1;
            if(this.transform == 0)
            {
                    return true;
            }
            
            float val_2 = UnityEngine.Time.time;
            float val_24 = this.startTime;
            float val_25 = this.duration;
            val_24 = 0 - val_24;
            val_25 = val_24 / val_25;
            float val_4 = this.curve.Evaluate(time:  UnityEngine.Mathf.Min(a:  val_25, b:  null));
            float val_26 = this.start;
            val_26 = this.end - val_26;
            if(this.relative == false)
            {
                goto label_5;
            }
            
            float val_5 = UnityEngine.Time.time;
            float val_6 = UnityEngine.Time.deltaTime;
            uint val_27 = 0;
            val_27 = 0 - val_27;
            val_27 = val_27 - this.startTime;
            val_27 = val_27 / this.duration;
            val_26 = 0;
            float val_9 = this.curve.Evaluate(time:  UnityEngine.Mathf.Max(a:  UnityEngine.Mathf.Min(a:  val_27, b:  null), b:  null));
            float val_28 = this.start;
            val_27 = this.type;
            val_28 = this.end - val_28;
            val_25 = this.start - this.start;
            if(this.relative == false)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            goto label_8;
            label_5:
            val_27 = this.type;
            label_7:
            val_26 = 0;
            UnityEngine.Vector3 val_11 = localPosition;
            label_8:
            if(this.relative != false)
            {
                    UnityEngine.Vector3 val_15 = UnityEngine.Vector3.zero;
            }
            else
            {
                    val_26 = 0;
                UnityEngine.Vector3 val_16 = localScale;
            }
            
            if(this.relative != false)
            {
                    UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
            }
            else
            {
                    UnityEngine.Vector3 val_18 = eulerAngles;
            }
            
            if(val_27 != 4)
            {
                    val_13 = this.start;
            }
            
            if(val_27 != 2)
            {
                    val_12 = this.start;
            }
            
            if(val_27 != 1)
            {
                    val_14 = this.start;
            }
            
            if(val_27 != 32)
            {
                    val_28 = this.start;
            }
            
            if(val_27 != 16)
            {
                    val_12 = this.start;
            }
            
            if(val_27 != 8)
            {
                    val_29 = this.start;
            }
            
            if(val_27 != 8)
            {
                    val_27 & 448 = 1;
            }
            
            Ferr.JuiceType val_20 = val_27 & 7;
            if(val_27 != 8)
            {
                    val_30 = 1;
            }
            
            if((val_27 & 56) == 0)
            {
                    val_27 = val_12;
                if(this.relative != false)
            {
                    UnityEngine.Vector3 val_21 = localPosition;
                var val_30 = val_27;
                var val_29 = val_28;
                var val_31 = val_14;
                val_29 = val_13 + val_29;
                val_30 = val_12 + val_30;
                val_31 = val_31 + val_29;
                val_28 = val_29;
                val_29 = val_30;
                val_27 = val_31;
                val_31 = val_27;
                val_32 = val_29;
            }
            else
            {
                    val_31 = val_29;
                val_32 = val_27;
            }
            
                this.transform.localPosition = new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_28};
            }
            
            if(1 != 0)
            {
                    if(this.relative != false)
            {
                    val_28 = 0;
                UnityEngine.Vector3 val_22 = localScale;
                var val_33 = val_12;
                var val_32 = val_13;
                var val_34 = val_14;
                val_32 = val_13 + val_32;
                val_33 = val_12 + val_33;
                val_34 = val_34 + val_14;
                val_30 = val_32;
                val_29 = val_33;
                val_27 = val_34;
                val_33 = val_27;
                val_34 = val_29;
            }
            else
            {
                    val_27 = val_12;
                val_30 = val_13;
                val_33 = val_14;
                val_34 = val_27;
            }
            
                this.transform.localScale = new UnityEngine.Vector3() {x = val_33, y = val_34, z = val_30};
            }
            
            if(1 != 0)
            {
                    if(this.relative != false)
            {
                    val_30 = 0;
                UnityEngine.Vector3 val_23 = localEulerAngles;
                var val_36 = this.start;
                var val_35 = this.start;
                var val_37 = val_14;
                val_35 = val_13 + val_35;
                val_36 = val_12 + val_36;
                val_37 = val_37 + this.start;
                val_27 = val_36;
                val_29 = val_37;
                val_35 = val_29;
                val_36 = val_27;
                val_37 = val_35;
            }
            else
            {
                    val_27 = this.start;
                val_29 = this.start;
                val_35 = this.start;
                val_36 = val_27;
                val_37 = val_29;
            }
            
                this.transform.localEulerAngles = new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37};
            }
            
            if(this.transform >= 0)
            {
                    val_24 = 1;
            }
            
            return true;
        }
        public void Cancel()
        {
            this.startTime = -10000f;
            bool val_1 = this.Update();
        }
        public JuiceData()
        {
        
        }
    
    }

}
