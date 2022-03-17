using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DZoomToFitTargets : BasePC2D, ISizeOverrider
    {
        // Fields
        public static string ExtensionName;
        public float ZoomOutBorder;
        public float ZoomInBorder;
        public float ZoomInSmoothness;
        public float ZoomOutSmoothness;
        public float MaxZoomInAmount;
        public float MaxZoomOutAmount;
        public bool DisableWhenOneTarget;
        public bool CompensateForCameraPosition;
        private float _zoomVelocity;
        private float _previousCamSize;
        private float _targetCamSize;
        private float _targetCamSizeSmoothed;
        private float _minCameraSize;
        private float _maxCameraSize;
        private int _soOrder;
        
        // Properties
        public int SOOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(1049798160 == 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            float val_5 = 0.5f;
            val_5 = (R4 + 68) * val_5;
            mem2[0] = val_5;
            mem2[0] = val_5;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = R4.ProCamera2D;
            R4.AddSizeOverrider(overrider:  R4);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1049910160)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemoveSizeOverrider(overrider:  R4);
        }
        public float OverrideSize(float deltaTime, float originalSize)
        {
            var val_10;
            float val_11;
            val_10 = R2;
            val_11 = 22981968;
            if(this.enabled == false)
            {
                    return (float)UnityEngine.Mathf.SmoothDamp(current:  this._targetCamSize, target:  originalSize, currentVelocity: ref  float val_8 = this._targetCamSizeSmoothed, smoothTime:  this._targetCamSizeSmoothed, maxSpeed:  null, deltaTime:  null);
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            float val_10 = this._previousCamSize;
            val_10 = val_10 * 0.5f;
            this._targetCamSizeSmoothed = val_10;
            if(this.DisableWhenOneTarget == false)
            {
                goto label_3;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            if(this <= 1)
            {
                goto label_6;
            }
            
            label_3:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.ProCamera2D;
            if(this == 0)
            {
                    val_11 = 0f;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.ProCamera2D;
                float val_11 = this._previousCamSize;
                this._zoomVelocity = val_11;
                val_11 = val_11 * 0.5f;
                this._targetCamSize = val_11;
                this._targetCamSizeSmoothed = val_11;
            }
            
            this.UpdateTargetCamSize();
            goto label_10;
            label_6:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.ProCamera2D;
            bool val_12 = this.DisableWhenOneTarget;
            val_12 = val_12 * 0.5f;
            this._targetCamSize = val_12;
            label_10:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.ProCamera2D;
            this._previousCamSize = this._previousCamSize;
            if(this < 0)
            {
                    56 = 52;
            }
            
            val_10 = val_8;
            this._targetCamSizeSmoothed = val_8;
            return (float)UnityEngine.Mathf.SmoothDamp(current:  this._targetCamSize, target:  originalSize, currentVelocity: ref  val_8, smoothTime:  this._targetCamSizeSmoothed, maxSpeed:  null, deltaTime:  null);
        }
        public int get_SOOrder()
        {
            return (int)this._soOrder;
        }
        public void set_SOOrder(int value)
        {
            this._soOrder = value;
        }
        public override void OnReset()
        {
            this._zoomVelocity = 0f;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            float val_2 = 0.5f;
            val_2 = this.DisableWhenOneTarget * val_2;
            this._previousCamSize = val_2;
            this._targetCamSize = val_2;
            this._targetCamSizeSmoothed = val_2;
        }
        private void UpdateTargetCamSize()
        {
            goto label_1;
        }
        public ProCamera2DZoomToFitTargets()
        {
            this.MaxZoomInAmount = 2f;
            this.MaxZoomOutAmount = 4f;
            this.DisableWhenOneTarget = true;
        }
        private static ProCamera2DZoomToFitTargets()
        {
            mem2[0] = -1610602401;
        }
    
    }

}
