using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DForwardFocus : BasePC2D, IPreMover
    {
        // Fields
        public static string ExtensionName;
        private const float EPSILON = 0.001;
        public bool Progressive;
        public float SpeedMultiplier;
        public float TransitionSmoothness;
        public bool MaintainInfluenceOnStop;
        public UnityEngine.Vector2 MovementThreshold;
        public float LeftFocus;
        public float RightFocus;
        public float TopFocus;
        public float BottomFocus;
        private float _hVel;
        private float _hVelSmooth;
        private float _vVel;
        private float _vVelSmooth;
        private float _targetHVel;
        private float _targetVVel;
        private bool _isFirstHorizontalCameraMovement;
        private bool _isFirstVerticalCameraMovement;
        private bool __enabled;
        private int _prmOrder;
        
        // Properties
        public int PrMOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            System.Collections.IEnumerator val_1 = this.Enable();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1014063312);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            this.AddPreMover(mover:  1014063312);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1014175312)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePreMover(mover:  R4);
        }
        public void PreMove(float deltaTime)
        {
            if(this.__enabled == false)
            {
                    return;
            }
            
            if(this.enabled == false)
            {
                    return;
            }
            
            R5.ApplyInfluence(deltaTime:  deltaTime);
        }
        public int get_PrMOrder()
        {
            return (int)this._prmOrder;
        }
        public void set_PrMOrder(int value)
        {
            this._prmOrder = value;
        }
        public override void OnReset()
        {
            System.Collections.IEnumerator val_1 = this.Enable();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1014623312);
        }
        private System.Collections.IEnumerator Enable()
        {
            536900589 = new ProCamera2DForwardFocus.<Enable>d__28(<>1__state:  0);
            mem[536900605] = this;
        }
        private void ApplyInfluence(float deltaTime)
        {
            float val_48;
            float val_49;
            float val_50;
            float val_51;
            var val_52;
            float val_54;
            float val_55;
            bool val_56;
            bool val_57;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            float val_2 = R6.Invoke(arg:  new UnityEngine.Vector3() {x = this._vVelSmooth, y = this._targetHVel, z = this._targetVVel});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            float val_4 = R6.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this._hVel + (0)], y = mem[this._hVel + (4)], z = mem[this._hVel + (8)]});
            var val_45 = R6;
            val_48 = 0f;
            val_45 = R6 - val_45;
            float val_46 = System.Math.Abs(val_45);
            if(R6 < 0)
            {
                    val_45 / R1 = 0;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.ProCamera2D;
            float val_7 = mem[this._hVel + (4)].Invoke(arg:  new UnityEngine.Vector3() {x = mem[this._vVelSmooth + (0)], y = mem[this._vVelSmooth + (4)], z = mem[this._vVelSmooth + (8)]});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = this.ProCamera2D;
            float val_9 = mem[this._hVel + (4)].Invoke(arg:  new UnityEngine.Vector3() {x = mem[this._hVel + (0)], y = mem[this._hVel + (4)], z = mem[this._hVel + (8)]});
            var val_47 = mem[this._hVel + (4)];
            val_47 = (mem[this._hVel + (4)]) - val_47;
            if((mem[this._hVel + (4)]) < 0)
            {
                    val_47 / R1 = 0;
            }
            
            if(this.Progressive == false)
            {
                goto label_9;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_11 = this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_12 = this.ProCamera2D;
            float val_49 = this.TopFocus;
            float val_13 = this.LeftFocus * this.TopFocus;
            val_49 = this.RightFocus * val_49;
            var val_50 = val_13;
            val_50 = val_50 ^ 2147483648;
            float val_15 = UnityEngine.Mathf.Clamp(value:  val_13, min:  null, max:  val_49);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_16 = this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_17 = this.ProCamera2D;
            float val_51 = this.BottomFocus;
            float val_18 = this.BottomFocus * this.BottomFocus;
            val_50 = (val_47 / R1) * this.SpeedMultiplier;
            val_51 = this.TopFocus * val_51;
            val_51 = (val_45 / R1) * this.SpeedMultiplier;
            var val_52 = val_18;
            val_52 = val_52 ^ 2147483648;
            val_52 = val_50;
            if(this.MaintainInfluenceOnStop == false)
            {
                goto label_45;
            }
            
            float val_20 = UnityEngine.Mathf.Sign(f:  UnityEngine.Mathf.Clamp(value:  val_18, min:  null, max:  val_51));
            if(this.MaintainInfluenceOnStop == true)
            {
                goto label_15;
            }
            
            val_54 = this._hVel;
            if(this.MaintainInfluenceOnStop < 0)
            {
                goto label_18;
            }
            
            label_15:
            float val_21 = UnityEngine.Mathf.Sign(f:  val_54);
            if(this.MaintainInfluenceOnStop == true)
            {
                goto label_17;
            }
            
            float val_53 = System.Math.Abs(val_51);
            val_50 = 0.001f;
            val_55 = this._hVel;
            if(this.MaintainInfluenceOnStop < 0)
            {
                goto label_18;
            }
            
            if(this.MaintainInfluenceOnStop > false)
            {
                    val_51 = val_55;
            }
            
            goto label_39;
            label_9:
            if(this.MaintainInfluenceOnStop == false)
            {
                goto label_20;
            }
            
            if((this.MaintainInfluenceOnStop < 0) || (this._isFirstHorizontalCameraMovement == true))
            {
                goto label_22;
            }
            
            val_56 = true;
            this._isFirstHorizontalCameraMovement = val_56;
            goto label_23;
            label_20:
            val_51 = 0;
            if(this.MaintainInfluenceOnStop >= 0)
            {
                    if(this.MaintainInfluenceOnStop < 0)
            {
                    System.Math.Abs(val_45 / R1) = this.LeftFocus;
                val_51 = -(System.Math.Abs(val_45 / R1));
            }
            
                if(this.MaintainInfluenceOnStop >= 0)
            {
                    val_51 = this.RightFocus;
            }
            
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_22 = this.ProCamera2D;
                val_51 = val_51 * this.TopFocus;
            }
            
            if(this < 0)
            {
                goto label_47;
            }
            
            if(this < 0)
            {
                    System.Math.Abs(val_47 / R1) = this.BottomFocus;
                val_47 / R1 = -(System.Math.Abs(val_47 / R1));
            }
            
            if(this >= 0)
            {
                    val_47 / R1 = this.TopFocus;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_23 = this.ProCamera2D;
            val_48 = (val_47 / R1) * this.BottomFocus;
            goto label_47;
            label_22:
            float val_25 = UnityEngine.Mathf.Sign(f:  UnityEngine.Mathf.Sign(f:  System.Math.Abs(val_47)));
            val_49 = this._targetHVel;
            if(this.MaintainInfluenceOnStop == true)
            {
                    val_56 = 1;
            }
            
            label_23:
            if((this.MaintainInfluenceOnStop >= 0) && (1 != 0))
            {
                    if(1 < 0)
            {
                    val_49 = this.LeftFocus;
                System.Math.Abs(val_45 / R1) = -val_49;
            }
            
                if(1 >= 0)
            {
                    System.Math.Abs(val_45 / R1) = this.RightFocus;
            }
            
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_26 = this.ProCamera2D;
                val_49 = this.TopFocus;
                val_51 = (System.Math.Abs(val_45 / R1)) * val_49;
                this._targetHVel = val_51;
            }
            else
            {
                    val_51 = this._targetHVel;
            }
            
            float val_57 = System.Math.Abs(val_47 / R1);
            if((this.MaintainInfluenceOnStop >= 0) && (this._isFirstVerticalCameraMovement != true))
            {
                    val_57 = true;
                this._isFirstVerticalCameraMovement = val_57;
            }
            else
            {
                    float val_28 = UnityEngine.Mathf.Sign(f:  UnityEngine.Mathf.Sign(f:  val_49));
                if(this.MaintainInfluenceOnStop == true)
            {
                    val_57 = 1;
            }
            
            }
            
            if(this.MaintainInfluenceOnStop >= 0)
            {
                    0 = 1;
            }
            
            if((1 & 1) != 0)
            {
                goto label_36;
            }
            
            if(1 < 0)
            {
                    this._targetVVel = this.BottomFocus;
                val_47 / R1 = -this._targetVVel;
            }
            
            if(1 >= 0)
            {
                    val_47 / R1 = this.TopFocus;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_29 = this.ProCamera2D;
            val_48 = (val_47 / R1) * this.BottomFocus;
            this._targetVVel = val_48;
            goto label_47;
            label_17:
            float val_58 = System.Math.Abs(val_51);
            if(this.MaintainInfluenceOnStop >= 0)
            {
                goto label_39;
            }
            
            val_55 = this._hVel;
            label_18:
            val_51 = val_55;
            label_39:
            float val_30 = UnityEngine.Mathf.Sign(f:  val_55);
            if(this.MaintainInfluenceOnStop == true)
            {
                goto label_40;
            }
            
            val_48 = this._vVel;
            if(this.MaintainInfluenceOnStop < 0)
            {
                goto label_47;
            }
            
            label_40:
            float val_31 = UnityEngine.Mathf.Sign(f:  val_50);
            float val_59 = System.Math.Abs(val_52);
            if(this.MaintainInfluenceOnStop == true)
            {
                goto label_42;
            }
            
            val_48 = this._vVel;
            if(this.MaintainInfluenceOnStop < 0)
            {
                goto label_47;
            }
            
            if(this.MaintainInfluenceOnStop <= false)
            {
                    val_48 = val_52;
            }
            
            goto label_47;
            label_42:
            if(this.MaintainInfluenceOnStop >= 0)
            {
                goto label_45;
            }
            
            val_48 = this._vVel;
            goto label_47;
            label_45:
            val_48 = val_52;
            goto label_47;
            label_36:
            val_48 = this._targetVVel;
            label_47:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_32 = this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_33 = this.ProCamera2D;
            float val_60 = this.TopFocus;
            float val_34 = this.LeftFocus * this.TopFocus;
            val_60 = this.RightFocus * val_60;
            var val_61 = val_34;
            val_61 = val_61 ^ 2147483648;
            float val_35 = UnityEngine.Mathf.Clamp(value:  val_34, min:  null, max:  val_60);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_36 = this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_37 = this.ProCamera2D;
            float val_62 = this.BottomFocus;
            float val_38 = this.BottomFocus * this.BottomFocus;
            val_62 = this.TopFocus * val_62;
            var val_63 = val_38;
            val_63 = val_63 ^ 2147483648;
            float val_40 = this._hVel;
            this._hVel = val_40;
            float val_42 = this._vVel;
            float val_43 = UnityEngine.Mathf.SmoothDamp(current:  UnityEngine.Mathf.SmoothDamp(current:  UnityEngine.Mathf.Clamp(value:  val_38, min:  null, max:  val_62), target:  null, currentVelocity: ref  val_40, smoothTime:  val_62, maxSpeed:  null, deltaTime:  null), target:  null, currentVelocity: ref  val_42, smoothTime:  val_62, maxSpeed:  null, deltaTime:  null);
            this._vVel = val_42;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_44 = this.ProCamera2D;
            this.ApplyInfluence(influence:  new UnityEngine.Vector2() {x = this._hVel, y = this._vVel});
        }
        public ProCamera2DForwardFocus()
        {
            this.Progressive = true;
            this.SpeedMultiplier = 1f;
            this.TransitionSmoothness = 0.5f;
            this.MaintainInfluenceOnStop = true;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this.MovementThreshold = new UnityEngine.Vector2();
            mem[1152921509916773644] = ???;
            this._prmOrder = 2000;
        }
        private static ProCamera2DForwardFocus()
        {
            mem2[0] = -1610608021;
        }
    
    }

}
