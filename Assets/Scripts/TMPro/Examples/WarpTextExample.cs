using UnityEngine;

namespace TMPro.Examples
{
    public class WarpTextExample : MonoBehaviour
    {
        // Fields
        private TMPro.TMP_Text m_TextComponent;
        public UnityEngine.AnimationCurve VertexCurve;
        public float AngleMultiplier;
        public float SpeedMultiplier;
        public float CurveScale;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            Weight val_2 = this.GetComponent<Weight>();
            this.m_TextComponent = this;
        }
        private void Start()
        {
            System.Collections.IEnumerator val_1 = this.WarpText();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  973200496);
        }
        private UnityEngine.AnimationCurve CopyAnimationCurve(UnityEngine.AnimationCurve curve)
        {
            536883291 = new UnityEngine.AnimationCurve();
            UnityEngine.Keyframe[] val_2 = curve.keys;
            val_1.keys = curve;
        }
        private System.Collections.IEnumerator WarpText()
        {
            536902361 = new WarpTextExample.<WarpText>d__8(<>1__state:  0);
            mem[536902377] = this;
        }
        public WarpTextExample()
        {
            UnityEngine.Keyframe val_1 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_2 = 536882139 + 16;
            mem[536882171] = val_1.m_WeightedMode;
            mem[536882175] = val_1.m_InWeight;
            mem[536882179] = val_1.m_Time;
            UnityEngine.Keyframe val_3 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_4 = 536882139 + 44;
            mem[536882199] = val_3.m_WeightedMode;
            mem[536882203] = val_3.m_Time;
            mem[536882207] = val_3.m_Time;
            UnityEngine.Keyframe val_5 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_6 = 536882139 + 72;
            mem[536882227] = val_5.m_WeightedMode;
            mem[536882231] = val_5.m_Time;
            mem[536882235] = val_5.m_Time;
            UnityEngine.Keyframe val_7 = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_8 = 536882139 + 100;
            mem[536882255] = val_7.m_WeightedMode;
            mem[536882259] = val_7.m_Time;
            mem[536882263] = val_7.m_Time;
             = new UnityEngine.Keyframe(time:  null, value:  null);
            var val_10 = 536882139 + 128;
            mem[536882283] = val_9.m_WeightedMode;
            mem[536882287] = val_9.m_Time;
            mem[536882291] = val_9.m_Time;
            UnityEngine.AnimationCurve val_11 = 536883291;
            val_11 = new UnityEngine.AnimationCurve(keys:  536882139);
            this.VertexCurve = val_11;
            this.AngleMultiplier = 1f;
            this.SpeedMultiplier = 1f;
            this.CurveScale = 1f;
        }
    
    }

}
