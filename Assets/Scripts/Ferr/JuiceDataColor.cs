using UnityEngine;

namespace Ferr
{
    [Serializable]
    public class JuiceDataColor
    {
        // Fields
        public UnityEngine.Material renderer;
        public UnityEngine.Color start;
        public UnityEngine.Color end;
        public float duration;
        public float startTime;
        public UnityEngine.AnimationCurve curve;
        public System.Action callback;
        
        // Methods
        public bool Update()
        {
            float val_6;
            float val_7;
            float val_8;
            float val_9;
            if(this.renderer == 0)
            {
                    return true;
            }
            
            float val_2 = UnityEngine.Time.time;
            float val_10 = this.startTime;
            float val_11 = this.duration;
            val_10 = 0 - val_10;
            val_11 = val_10 / val_11;
            UnityEngine.Color val_5 = UnityEngine.Color.Lerp(a:  new UnityEngine.Color() {r = 455572.8f, g = this.start, b = this.start, a = this.start}, b:  new UnityEngine.Color() {r = ???, g = mem[this.end + (0)], b = mem[this.end + (4)], a = mem[this.end + (8)]}, t:  this.curve.Evaluate(time:  UnityEngine.Mathf.Min(a:  val_11, b:  null)));
            this.renderer.color = new UnityEngine.Color() {r = val_6, g = val_7, b = val_8, a = val_9};
            if(this.renderer >= 0)
            {
                    1 = 1;
            }
            
            return true;
        }
        public void Cancel()
        {
            this.startTime = -10000f;
            bool val_1 = this.Update();
        }
        public JuiceDataColor()
        {
        
        }
    
    }

}
