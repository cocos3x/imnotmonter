using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DTriggerBoundaries : BaseTrigger, IPositionOverrider
    {
        // Fields
        public static string TriggerName;
        public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries NumericBoundaries;
        public bool AreBoundariesRelative;
        public bool UseTopBoundary;
        public float TopBoundary;
        public bool UseBottomBoundary;
        public float BottomBoundary;
        public bool UseLeftBoundary;
        public float LeftBoundary;
        public bool UseRightBoundary;
        public float RightBoundary;
        public float TransitionDuration;
        public Com.LuisPedroFonseca.ProCamera2D.EaseType TransitionEaseType;
        public bool ChangeZoom;
        public float TargetZoom;
        public float ZoomSmoothness;
        public bool _setAsStartingBoundaries;
        private float _initialCamSize;
        private Com.LuisPedroFonseca.ProCamera2D.BoundariesAnimator _boundsAnim;
        private float _targetTopBoundary;
        private float _targetBottomBoundary;
        private float _targetLeftBoundary;
        private float _targetRightBoundary;
        private bool _transitioning;
        private UnityEngine.Vector3 _newPos;
        private int _poOrder;
        
        // Properties
        public bool IsCurrentTrigger { get; }
        public bool SetAsStartingBoundaries { get; set; }
        public int POOrder { get; set; }
        
        // Methods
        public bool get_IsCurrentTrigger()
        {
            this = R1 - this;
            this = this >> 5;
            return (bool)this;
        }
        public void set_SetAsStartingBoundaries(bool value)
        {
            var val_3;
            var val_4;
            if((value == false) || (this._setAsStartingBoundaries == true))
            {
                goto label_2;
            }
            
            val_3 = 0;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073763079)});
            UnityEngine.Object[] val_2 = UnityEngine.Object.FindObjectsOfType(type:  1073763079);
            var val_3 = 1073763079 + 16;
            goto label_7;
            label_17:
            val_4 = mem[(1073763079 + 16) + 0];
            val_4 = (1073763079 + 16) + 0;
            if(val_4 == 0)
            {
                goto label_9;
            }
            
            if(((1073763079 + 16) + 0 + 180) < mem[536892347])
            {
                goto label_10;
            }
            
            var val_4 = (1073763079 + 16) + 0 + 100;
            val_4 = val_4 + (mem[536892347] << 2);
            if((((1073763079 + 16) + 0 + 100 + (mem[536892347]) << 2) + -4) == 536892167)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            if(((1073763079 + 16) + 0 + 180) < mem[536892347])
            {
                goto label_14;
            }
            
            var val_5 = (1073763079 + 16) + 0 + 100;
            val_5 = val_5 + (mem[536892347] << 2);
            if((((1073763079 + 16) + 0 + 100 + (mem[536892347]) << 2) + -4) == 536892167)
            {
                goto label_13;
            }
            
            goto label_14;
            label_9:
            label_14:
            val_4 = 0;
            label_13:
            val_3 = 1;
            label_7:
            if(val_3 < mem[1073763091])
            {
                goto label_17;
            }
            
            label_2:
            this._setAsStartingBoundaries = value;
        }
        public bool get_SetAsStartingBoundaries()
        {
            return (bool)this._setAsStartingBoundaries;
        }
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.AddPositionOverrider(overrider:  1056722832);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1056834832)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePositionOverrider(overrider:  R4);
        }
        private void Start()
        {
            System.Action val_16;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries val_17;
            var val_18;
            var val_19;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            val_16 = 22713552;
            if(1056963216 == 0)
            {
                    return;
            }
            
            if(this.NumericBoundaries == 0)
            {
                    CutTheRope.Script.RopeCutter val_4 = UnityEngine.Object.FindObjectOfType<CutTheRope.Script.RopeCutter>();
                val_17 = -1073688267;
                if((-1073688267) == 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.ProCamera2D;
                UnityEngine.GameObject val_7 = this.gameObject;
                SynchronizationContextBehavoir val_8 = this.AddComponent<SynchronizationContextBehavoir>();
                val_17 = this;
            }
            
                this.NumericBoundaries = val_17;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_9 = val_17.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.BoundariesAnimator val_10 = 536884277;
            val_10 = new Com.LuisPedroFonseca.ProCamera2D.BoundariesAnimator(proCamera2D:  1056963216, numericBoundaries:  this.NumericBoundaries);
            this._boundsAnim = val_10;
            536882991 = new System.Action(object:  1056963216, method:  new IntPtr(1610685315));
            System.Delegate val_12 = System.Delegate.Combine(a:  this._boundsAnim.OnTransitionStarted, b:  536882991);
            val_18 = this._boundsAnim.OnTransitionStarted;
            if(val_18 != 0)
            {
                    if(null == 536882991)
            {
                goto label_15;
            }
            
            }
            
            val_18 = 0;
            label_15:
            mem2[0] = val_18;
            val_16 = 536882991;
            val_16 = new System.Action(object:  1056963216, method:  new IntPtr(1610685317));
            System.Delegate val_14 = System.Delegate.Combine(a:  mem[this._boundsAnim] + 12, b:  536882991);
            val_19 = mem[this._boundsAnim] + 12;
            if(val_19 != 0)
            {
                    if(val_19 == 536882991)
            {
                goto label_19;
            }
            
            }
            
            val_19 = 0;
            label_19:
            mem2[0] = val_19;
            this.GetTargetBoundaries();
            if(this._setAsStartingBoundaries == true)
            {
                    this._setAsStartingBoundaries = this;
                this.SetBoundaries();
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_15 = this.ProCamera2D;
            float val_16 = 0.5f;
            val_16 = S2 * val_16;
            this._initialCamSize = val_16;
        }
        public UnityEngine.Vector3 OverridePosition(float deltaTime, UnityEngine.Vector3 originalPosition)
        {
            var val_2;
            var val_3;
            bool val_1 = originalPosition.x.enabled;
            if(val_1 == true)
            {
                    val_1 = mem[originalPosition.x + 180];
                val_1 = originalPosition.x + 180;
            }
            
            if(val_1 == 0)
            {
                    this = originalPosition.z;
                mem[1152921509958905876] = val_3;
                mem[1152921509958905880] = val_2;
                return new UnityEngine.Vector3() {x = deltaTime};
            }
            
            mem[1152921509958905880] = originalPosition.x + 192;
            this = originalPosition.x + 184;
            return new UnityEngine.Vector3() {x = deltaTime};
        }
        public int get_POOrder()
        {
            return (int)this._poOrder;
        }
        public void set_POOrder(int value)
        {
            this._poOrder = value;
        }
        protected override void EnteredTrigger()
        {
            this.EnteredTrigger();
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this.NumericBoundaries.CurrentBoundariesTrigger, y:  0);
            if(val_1 != false)
            {
                    System.Collections.IEnumerator val_2 = val_1.TurnOffPreviousTrigger(trigger:  this.NumericBoundaries.CurrentBoundariesTrigger);
                UnityEngine.Coroutine val_3 = this.NumericBoundaries.StartCoroutine(routine:  val_1);
            }
            
            bool val_4 = UnityEngine.Object.op_Inequality(x:  this.NumericBoundaries.CurrentBoundariesTrigger, y:  0);
            if(val_4 != false)
            {
                    if(0 != val_4)
            {
                goto label_12;
            }
            
            }
            
            if(this.NumericBoundaries.CurrentBoundariesTrigger != 0)
            {
                    return;
            }
            
            label_12:
            this.NumericBoundaries.CurrentBoundariesTrigger = this;
            System.Collections.IEnumerator val_6 = this.Transition();
            UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  1057472656);
        }
        private System.Collections.IEnumerator TurnOffPreviousTrigger(Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerBoundaries trigger)
        {
            536900631 = new ProCamera2DTriggerBoundaries.<TurnOffPreviousTrigger>d__39(<>1__state:  0);
            mem[536900647] = trigger;
        }
        public void SetBoundaries()
        {
            if(this.NumericBoundaries == 0)
            {
                    return;
            }
            
            this.NumericBoundaries.CurrentBoundariesTrigger = this;
            this.NumericBoundaries.UseLeftBoundary = this.UseLeftBoundary;
            if(this.UseLeftBoundary != false)
            {
                    if(this.NumericBoundaries != 0)
            {
                    this.NumericBoundaries.TargetLeftBoundary = this._targetLeftBoundary;
            }
            else
            {
                    mem[84] = this._targetLeftBoundary;
            }
            
                this.NumericBoundaries.LeftBoundary = this._targetLeftBoundary;
            }
            
            this.NumericBoundaries.UseRightBoundary = this.UseRightBoundary;
            if(this.UseRightBoundary != false)
            {
                    if(this.NumericBoundaries != 0)
            {
                    this.NumericBoundaries.TargetRightBoundary = this._targetRightBoundary;
            }
            else
            {
                    mem[96] = this._targetRightBoundary;
            }
            
                this.NumericBoundaries.RightBoundary = this._targetRightBoundary;
            }
            
            this.NumericBoundaries.UseTopBoundary = this.UseTopBoundary;
            if(this.UseTopBoundary != false)
            {
                    if(this.NumericBoundaries != 0)
            {
                    this.NumericBoundaries.TargetTopBoundary = this._targetTopBoundary;
            }
            else
            {
                    mem[60] = this._targetTopBoundary;
            }
            
                this.NumericBoundaries.TopBoundary = this._targetTopBoundary;
            }
            
            this.NumericBoundaries.UseBottomBoundary = this.UseBottomBoundary;
            if(this.UseBottomBoundary == false)
            {
                    return;
            }
            
            if(this.NumericBoundaries != 0)
            {
                    this.NumericBoundaries.TargetBottomBoundary = this._targetBottomBoundary;
            }
            else
            {
                    mem[72] = this._targetBottomBoundary;
            }
            
            this.NumericBoundaries.BottomBoundary = this._targetBottomBoundary;
        }
        private void GetTargetBoundaries()
        {
            float val_3;
            if(this.AreBoundariesRelative == false)
            {
                    return;
            }
            
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.Vector3 val_2 = position;
            float val_4 = R8.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = val_3});
            float val_14 = R8;
            val_14 = val_14 + this.TopBoundary;
            this._targetTopBoundary = val_14;
            UnityEngine.Transform val_5 = this.transform;
            UnityEngine.Vector3 val_6 = position;
            float val_7 = R8.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = val_3});
            float val_15 = R8;
            val_15 = val_15 + this.BottomBoundary;
            this._targetBottomBoundary = val_15;
            UnityEngine.Transform val_8 = this.transform;
            UnityEngine.Vector3 val_9 = position;
            float val_10 = R8.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = val_3});
            float val_16 = R8;
            val_16 = val_16 + this.LeftBoundary;
            this._targetLeftBoundary = val_16;
            UnityEngine.Transform val_11 = this.transform;
            UnityEngine.Vector3 val_12 = position;
            float val_13 = R8.Invoke(arg:  new UnityEngine.Vector3() {x = R6, y = R7, z = val_3});
            float val_17 = R8;
            val_17 = val_17 + this.RightBoundary;
            this._targetRightBoundary = val_17;
        }
        private System.Collections.IEnumerator Transition()
        {
            536900629 = new ProCamera2DTriggerBoundaries.<Transition>d__42(<>1__state:  0);
            mem[536900645] = this;
        }
        private System.Collections.IEnumerator MoveCameraToTarget()
        {
            536900627 = new ProCamera2DTriggerBoundaries.<MoveCameraToTarget>d__43(<>1__state:  0);
            mem[536900643] = this;
        }
        private void LimitToNumericBoundaries(ref float horizontalPos, ref float verticalPos)
        {
            var val_9;
            var val_10;
            float val_11;
            var val_12;
            float val_13;
            val_9 = 1152921509960183280;
            if(this.NumericBoundaries.UseLeftBoundary == false)
            {
                goto label_4;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.NumericBoundaries.ProCamera2D;
            val_10 = this;
            if(this.NumericBoundaries >= 0)
            {
                goto label_4;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.NumericBoundaries.ProCamera2D;
            val_10 = this;
            val_11 = 0.5f;
            goto label_7;
            label_4:
            if(this.NumericBoundaries.UseRightBoundary == false)
            {
                goto label_12;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.NumericBoundaries.ProCamera2D;
            val_10 = this;
            if(this.NumericBoundaries <= 0)
            {
                goto label_12;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.NumericBoundaries.ProCamera2D;
            val_10 = this;
            val_11 = -0.5f;
            label_7:
            horizontalPos = this.NumericBoundaries.RightBoundary;
            label_12:
            if(this.NumericBoundaries.UseBottomBoundary == false)
            {
                goto label_19;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.NumericBoundaries.ProCamera2D;
            val_9 = this;
            if(this.NumericBoundaries >= 0)
            {
                goto label_19;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.NumericBoundaries.ProCamera2D;
            val_12 = this;
            val_13 = 0.5f;
            goto label_22;
            label_19:
            if(this.NumericBoundaries.UseTopBoundary == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.NumericBoundaries.ProCamera2D;
            val_9 = this;
            if(this.NumericBoundaries <= 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = this.NumericBoundaries.ProCamera2D;
            val_12 = this;
            val_13 = -0.5f;
            label_22:
            verticalPos = this.NumericBoundaries.TopBoundary;
        }
        public ProCamera2DTriggerBoundaries()
        {
            this.TopBoundary = 10f;
            this.AreBoundariesRelative = true;
            this.UseTopBoundary = true;
            this.UseBottomBoundary = true;
            this.BottomBoundary = -10f;
            this.UseLeftBoundary = true;
            this.LeftBoundary = -10f;
            this.UseRightBoundary = true;
            this.RightBoundary = 10f;
            this.TransitionDuration = 1f;
            this.TargetZoom = 1.5f;
            this.ZoomSmoothness = 1f;
            this._poOrder = 1000;
        }
        private static ProCamera2DTriggerBoundaries()
        {
            mem2[0] = -1610609899;
        }
        private void <Start>b__32_0()
        {
            if(this.NumericBoundaries.OnBoundariesTransitionStarted == 0)
            {
                    return;
            }
            
            this.NumericBoundaries.OnBoundariesTransitionStarted.Invoke();
        }
        private void <Start>b__32_1()
        {
            if(this.NumericBoundaries.OnBoundariesTransitionFinished == 0)
            {
                    return;
            }
            
            this.NumericBoundaries.OnBoundariesTransitionFinished.Invoke();
        }
    
    }

}
