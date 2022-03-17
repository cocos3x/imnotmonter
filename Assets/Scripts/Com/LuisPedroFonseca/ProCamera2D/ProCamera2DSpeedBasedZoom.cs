using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DSpeedBasedZoom : BasePC2D, ISizeDeltaChanger
    {
        // Fields
        public static string ExtensionName;
        public float CamVelocityForZoomOut;
        public float CamVelocityForZoomIn;
        public float ZoomInSmoothness;
        public float ZoomOutSmoothness;
        public float MaxZoomInAmount;
        public float MaxZoomOutAmount;
        private float _zoomVelocity;
        private float _initialCamSize;
        private float _previousCamSize;
        private UnityEngine.Vector3 _previousCameraPosition;
        public float CurrentVelocity;
        private int _sdcOrder;
        
        // Properties
        public int SDCOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            float val_6;
            float val_7;
            float val_8;
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(1046451984 == 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            float val_15 = 0.5f;
            val_15 = this._previousCamSize * val_15;
            this._initialCamSize = val_15;
            this._previousCamSize = val_15;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.ProCamera2D;
            UnityEngine.Vector3 val_5 = LocalPosition;
            float val_9 = SB.Invoke(arg:  new UnityEngine.Vector3() {x = val_6, y = val_7, z = val_8});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_10 = this.ProCamera2D;
            UnityEngine.Vector3 val_11 = LocalPosition;
            UnityEngine.Vector3 val_13 = Invoke(arg1:  SL.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}), arg2:  val_11.y);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_14 = this.ProCamera2D;
            this.AddSizeDeltaChanger(changer:  1046451984);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1046563984)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemoveSizeDeltaChanger(changer:  R4);
        }
        public float AdjustSize(float deltaTime, float originalDelta)
        {
            float val_10;
            float val_11;
            float val_12;
            float val_29;
            var val_30;
            var val_31;
            float val_32;
            var val_33;
            val_29 = R1;
            val_30 = 22981935;
            val_31 = R2;
            if(this.enabled == false)
            {
                    return -0.5f;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            if(this == 0)
            {
                    this = 0f;
                this._zoomVelocity = this;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            UnityEngine.Vector3 val_4 = LocalPosition;
            float val_5 = SL.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.ProCamera2D;
            UnityEngine.Vector3 val_7 = LocalPosition;
            UnityEngine.Vector3 val_9 = Invoke(arg1:  R5.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = R8}), arg2:  val_7.y);
            float val_29 = val_10;
            float val_30 = val_11;
            float val_31 = val_12;
            val_29 = this._previousCameraPosition - val_29;
            val_30 = S24 - val_30;
            val_31 = S22 - val_31;
            float val_13 = val_29.magnitude;
            uint val_32 = 1046663928;
            val_32 = val_32 / val_29;
            this.CurrentVelocity = val_32;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_14 = this.ProCamera2D;
            UnityEngine.Vector3 val_15 = LocalPosition;
            float val_16 = SB.Invoke(arg:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_17 = this.ProCamera2D;
            UnityEngine.Vector3 val_18 = LocalPosition;
            val_29 = SL;
            UnityEngine.Vector3 val_20 = Invoke(arg1:  SL.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}), arg2:  val_18.y);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_21 = this.ProCamera2D;
            float val_22 = this._previousCamSize * 0.5f;
            float val_34 = this.CamVelocityForZoomIn;
            float val_33 = this.CurrentVelocity;
            if(this > 0)
            {
                    val_32 = this.CamVelocityForZoomOut;
                val_33 = val_33 - val_34;
                val_34 = val_32 - val_34;
                val_34 = val_33 / val_34;
                float val_23 = UnityEngine.Mathf.Clamp01(value:  val_34);
                float val_35 = 1f;
                val_35 = this.MaxZoomOutAmount + val_35;
                val_35 = val_35 + (-1f);
                val_35 = this._initialCamSize * val_35;
                val_35 = val_34 * val_35;
                if(this > 0)
            {
                    val_33 = val_35;
            }
            
            }
            else
            {
                    val_34 = val_33 / val_34;
                val_34 = 1f - val_34;
                float val_24 = Com.LuisPedroFonseca.ProCamera2D.Utils.Remap(value:  val_34, from1:  val_20.y, to1:  1f, from2:  null, to2:  val_31);
                float val_36 = this.MaxZoomInAmount;
                val_32 = val_34;
                val_33 = val_22;
                val_36 = val_32 * val_36;
                val_36 = this._initialCamSize / val_36;
                if(this < 0)
            {
                    val_33 = val_36;
            }
            
            }
            
            val_36 = val_22 - val_33;
            if(this > 0)
            {
                    float val_25 = val_22;
                if(this < 0)
            {
                    56 = 52;
            }
            
                float val_26 = UnityEngine.Mathf.SmoothDamp(current:  System.Math.Abs(val_36), target:  val_20.y, currentVelocity: ref  val_25, smoothTime:  0.0001f, maxSpeed:  null, deltaTime:  val_32);
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_27 = this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_28 = this.ProCamera2D;
            val_31 = val_25 + val_31;
            this._previousCamSize = this._previousCamSize;
            return -0.5f;
        }
        public int get_SDCOrder()
        {
            return (int)this._sdcOrder;
        }
        public void set_SDCOrder(int value)
        {
            this._sdcOrder = value;
        }
        public override void OnReset()
        {
            float val_3;
            float val_4;
            float val_5;
            this._previousCamSize = this._initialCamSize;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            UnityEngine.Vector3 val_2 = LocalPosition;
            float val_6 = SB.Invoke(arg:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.ProCamera2D;
            UnityEngine.Vector3 val_8 = LocalPosition;
            UnityEngine.Vector3 val_10 = Invoke(arg1:  SL.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7}), arg2:  val_8.y);
            this._zoomVelocity = 0f;
        }
        public ProCamera2DSpeedBasedZoom()
        {
            this.MaxZoomInAmount = 2f;
            this.MaxZoomOutAmount = 2f;
            this._sdcOrder = 1000;
        }
        private static ProCamera2DSpeedBasedZoom()
        {
            mem2[0] = -1610604427;
        }
    
    }

}
