using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DTriggerInfluence : BaseTrigger
    {
        // Fields
        public static string TriggerName;
        public UnityEngine.Transform FocusPoint;
        public float InfluenceSmoothness;
        public float ExclusiveInfluencePercentage;
        public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerInfluence.TriggerInfluenceMode Mode;
        private UnityEngine.Vector2 _influence;
        private UnityEngine.Vector2 _velocity;
        private UnityEngine.Vector3 _exclusivePointVelocity;
        private UnityEngine.Vector3 _tempExclusivePoint;
        
        // Methods
        private void Start()
        {
            var val_7;
            UnityEngine.Transform val_8;
            val_7 = 22713552;
            if(this.FocusPoint == 0)
            {
                    UnityEngine.Transform val_2 = this.FocusPoint.transform;
                UnityEngine.Transform val_3 = this.Find(n:  -1610608063);
                this.FocusPoint = this;
            }
            
            val_8 = this.FocusPoint;
            if(1060490704 != 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_5 = this.transform;
            this.FocusPoint = this;
        }
        protected override void EnteredTrigger()
        {
            this.EnteredTrigger();
            System.Collections.IEnumerator val_1 = this.InsideTriggerRoutine();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1060606800);
        }
        protected override void ExitedTrigger()
        {
            this.ExitedTrigger();
            System.Collections.IEnumerator val_1 = this.OutsideTriggerRoutine();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1060718800);
        }
        private System.Collections.IEnumerator InsideTriggerRoutine()
        {
            536900633 = new ProCamera2DTriggerInfluence.<InsideTriggerRoutine>d__13(<>1__state:  0);
            mem[536900649] = this;
        }
        private System.Collections.IEnumerator OutsideTriggerRoutine()
        {
            536900635 = new ProCamera2DTriggerInfluence.<OutsideTriggerRoutine>d__14(<>1__state:  0);
            mem[536900651] = this;
        }
        public ProCamera2DTriggerInfluence()
        {
            this.InfluenceSmoothness = 0.3f;
            this.ExclusiveInfluencePercentage = 0.25f;
        }
        private static ProCamera2DTriggerInfluence()
        {
            mem2[0] = -1610607429;
        }
    
    }

}
