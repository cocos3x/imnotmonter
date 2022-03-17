using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DTriggerZoom : BaseTrigger
    {
        // Fields
        public static string TriggerName;
        public bool SetSizeAsMultiplier;
        public float TargetZoom;
        public float ZoomSmoothness;
        public float ExclusiveInfluencePercentage;
        public bool ResetSizeOnExit;
        public float ResetSizeSmoothness;
        private float _startCamSize;
        private float _initialCamSize;
        private float _targetCamSize;
        private float _targetCamSizeSmoothed;
        private float _previousCamSize;
        private float _zoomVelocity;
        private float _initialCamDepth;
        
        // Methods
        private void Start()
        {
            float val_6;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(1063144528 == 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            float val_8 = 0.5f;
            val_8 = S2 * val_8;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.ProCamera2D;
            UnityEngine.Vector3 val_5 = LocalPosition;
            float val_7 = R8.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = val_6});
            this._initialCamDepth = R8;
        }
        protected override void EnteredTrigger()
        {
            float val_8;
            this.EnteredTrigger();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            mem[1152921509965070984] = ???;
            if(this.ResetSizeOnExit != false)
            {
                    this._initialCamSize = this._startCamSize;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
                float val_3 = S0 * 0.5f;
                this._targetCamSize = val_3;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.ProCamera2D;
                val_8 = val_3 * 0.5f;
            }
            else
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.ProCamera2D;
                val_8 = S2 * 0.5f;
                this._initialCamSize = val_8;
                this._targetCamSize = val_8;
            }
            
            this._targetCamSizeSmoothed = val_8;
            System.Collections.IEnumerator val_6 = this.InsideTriggerRoutine();
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  1063256528);
        }
        protected override void ExitedTrigger()
        {
            this.ExitedTrigger();
            if(this.ResetSizeOnExit == false)
            {
                    return;
            }
            
            this._targetCamSize = this._startCamSize;
            System.Collections.IEnumerator val_1 = this.OutsideTriggerRoutine();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1063368528);
        }
        private System.Collections.IEnumerator InsideTriggerRoutine()
        {
            536900643 = new ProCamera2DTriggerZoom.<InsideTriggerRoutine>d__17(<>1__state:  0);
            mem[536900659] = this;
        }
        private System.Collections.IEnumerator OutsideTriggerRoutine()
        {
            536900645 = new ProCamera2DTriggerZoom.<OutsideTriggerRoutine>d__18(<>1__state:  0);
            mem[536900661] = this;
        }
        protected void UpdateScreenSize(float smoothness)
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            float val_2 = this._targetCamSizeSmoothed;
            this._targetCamSizeSmoothed = val_2;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.ProCamera2D;
            this.UpdateScreenSize(newSize:  UnityEngine.Mathf.SmoothDamp(current:  this._startCamSize, target:  null, currentVelocity: ref  val_2, smoothTime:  null, maxSpeed:  null, deltaTime:  null), duration:  null, easeType:  this._targetCamSizeSmoothed);
        }
        public ProCamera2DTriggerZoom()
        {
            this.SetSizeAsMultiplier = true;
            this.ResetSizeSmoothness = 1f;
        }
        private static ProCamera2DTriggerZoom()
        {
            mem2[0] = -1610602399;
        }
    
    }

}
