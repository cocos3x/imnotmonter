using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DCinematics : BasePC2D, IPositionOverrider, ISizeOverrider
    {
        // Fields
        public static string ExtensionName;
        public UnityEngine.Events.UnityEvent OnCinematicStarted;
        public Com.LuisPedroFonseca.ProCamera2D.CinematicEvent OnCinematicTargetReached;
        public UnityEngine.Events.UnityEvent OnCinematicFinished;
        private bool _isPlaying;
        public System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.CinematicTarget> CinematicTargets;
        public float EndDuration;
        public Com.LuisPedroFonseca.ProCamera2D.EaseType EndEaseType;
        public bool UseNumericBoundaries;
        public bool UseLetterbox;
        public float LetterboxAmount;
        public float LetterboxAnimDuration;
        public UnityEngine.Color LetterboxColor;
        private float _initialCameraSize;
        private Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries _numericBoundaries;
        private bool _numericBoundariesPreviousState;
        private Com.LuisPedroFonseca.ProCamera2D.ProCamera2DLetterbox _letterbox;
        private UnityEngine.Coroutine _startCinematicRoutine;
        private UnityEngine.Coroutine _goToCinematicRoutine;
        private UnityEngine.Coroutine _endCinematicRoutine;
        private bool _skipTarget;
        private UnityEngine.Vector3 _newPos;
        private UnityEngine.Vector3 _originalPos;
        private UnityEngine.Vector3 _startPos;
        private float _newSize;
        private bool _paused;
        private int _poOrder;
        private int _soOrder;
        
        // Properties
        public bool IsPlaying { get; }
        public int POOrder { get; set; }
        public int SOOrder { get; set; }
        
        // Methods
        public bool get_IsPlaying()
        {
            return (bool)this._isPlaying;
        }
        protected override void Awake()
        {
            this.Awake();
            if(this.UseLetterbox == true)
            {
                    this.UseLetterbox = this;
                this.SetupLetterbox();
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.AddPositionOverrider(overrider:  1006054416);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            this.AddSizeOverrider(overrider:  1006054416);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(1006166416 == 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePositionOverrider(overrider:  R4);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = R4.ProCamera2D;
            R4.RemoveSizeOverrider(overrider:  R4);
        }
        public UnityEngine.Vector3 OverridePosition(float deltaTime, UnityEngine.Vector3 originalPosition)
        {
            var val_2;
            var val_3;
            if(originalPosition.x.enabled != false)
            {
                    mem2[0] = originalPosition.z;
                mem2[0] = val_3;
                mem2[0] = val_2;
                if((originalPosition.x + 56) != 0)
            {
                    mem[1152921509908092696] = originalPosition.x + 140;
                this = originalPosition.x + 132;
                return new UnityEngine.Vector3() {x = deltaTime};
            }
            
            }
            
            this = originalPosition.z;
            mem[1152921509908092692] = val_3;
            mem[1152921509908092696] = val_2;
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
        public float OverrideSize(float deltaTime, float originalSize)
        {
            bool val_1 = this.enabled;
            if(val_1 == true)
            {
                    val_1 = this._isPlaying;
                R2 = this._newSize;
            }
            
            return R2;
        }
        public int get_SOOrder()
        {
            return (int)this._soOrder;
        }
        public void set_SOOrder(int value)
        {
            this._soOrder = value;
        }
        public void Play()
        {
            UnityEngine.Object val_11;
            if(this._isPlaying == true)
            {
                    return;
            }
            
            mem2[0] = 0;
            if((R4 + 60 + 12) == 0)
            {
                goto label_2;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = R4.ProCamera2D;
            float val_11 = 0.5f;
            val_11 = (R4 + 76) * val_11;
            mem2[0] = val_11;
            if((R4 + 104) == 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
                UnityEngine.UI.Toggle val_4 = R4.GetComponentInChildren<UnityEngine.UI.Toggle>();
                mem2[0] = R4;
            }
            
            if((R4 + 104) == 0)
            {
                    CutTheRope.Script.RopeCutter val_6 = UnityEngine.Object.FindObjectOfType<CutTheRope.Script.RopeCutter>();
                mem2[0] = -1073688267;
            }
            
            val_11 = mem[R4 + 104];
            val_11 = R4 + 104;
            if(val_11 != 0)
            {
                goto label_15;
            }
            
            mem2[0] = 0;
            goto label_16;
            label_2:
            UnityEngine.Debug.LogWarning(message:  -1610606071);
            return;
            label_15:
            mem2[0] = R4 + 104.enabled;
            R4 + 104.enabled = false;
            label_16:
            mem2[0] = 1;
            if((R4 + 124) != 0)
            {
                    val_11 = 0;
                R4.StopCoroutine(routine:  R4 + 124);
                mem2[0] = val_11;
            }
            
            if((R4 + 116) != 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_9 = R4.StartCinematicRoutine();
            UnityEngine.Coroutine val_10 = R4.StartCoroutine(routine:  R4);
            mem2[0] = R4;
        }
        public void Stop()
        {
            UnityEngine.Coroutine val_4;
            if(this._isPlaying == false)
            {
                    return;
            }
            
            if(this._startCinematicRoutine != 0)
            {
                    val_4 = 0;
                this.StopCoroutine(routine:  this._startCinematicRoutine);
                this._startCinematicRoutine = val_4;
            }
            
            if(this._goToCinematicRoutine != 0)
            {
                    val_4 = 0;
                this.StopCoroutine(routine:  this._goToCinematicRoutine);
                this._goToCinematicRoutine = val_4;
            }
            
            if(this._endCinematicRoutine != 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_1 = R4.EndCinematicRoutine();
            UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  R4);
            mem2[0] = R4;
        }
        public void Toggle()
        {
            if(this._isPlaying != false)
            {
                    this.Stop();
                return;
            }
            
            this.Play();
        }
        public void GoToNextTarget()
        {
            this._skipTarget = true;
        }
        public void Pause()
        {
            this._paused = true;
        }
        public void Unpause()
        {
            this._paused = false;
        }
        public void AddCinematicTarget(UnityEngine.Transform targetTransform, float easeInDuration = 1, float holdDuration = 1, float zoom = 1, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType = 1, string sendMessageName = "", string sendMessageParam = "", int index = -1)
        {
            int val_1;
            var val_2;
            var val_3;
            Com.LuisPedroFonseca.ProCamera2D.CinematicTarget val_4 = 536884795;
            val_4 = new Com.LuisPedroFonseca.ProCamera2D.CinematicTarget();
            if(val_4 != 0)
            {
                    mem[536884803] = targetTransform;
                mem[536884823] = val_3;
                mem[536884807] = easeType;
                mem[536884811] = sendMessageName;
                mem[536884815] = sendMessageParam;
                mem[536884819] = index;
            }
            else
            {
                    mem[8] = targetTransform;
                mem[12] = easeType;
                mem[16] = sendMessageName;
                mem[20] = sendMessageParam;
                mem[24] = index;
                mem[28] = val_3;
            }
            
            mem[536884827] = val_2;
            if(val_1 != 1)
            {
                    if((mem[1152921509909477708] + 12) >= val_1)
            {
                goto label_5;
            }
            
            }
            
            mem[1152921509909477708].Add(item:  536884795);
            return;
            label_5:
            mem[1152921509909477708].Insert(index:  val_1, item:  536884795);
        }
        public void RemoveCinematicTarget(UnityEngine.Transform targetTransform)
        {
            goto label_1;
            label_11:
            if(true <= 23000883)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            int val_2 = targetTransform.GetInstanceID();
            if(static_value_0028000B.GetInstanceID() == val_2)
            {
                    if(val_2 <= 23000883)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < (this.CinematicTargets.Remove(item:  2621443)))
            {
                goto label_11;
            }
        
        }
        private System.Collections.IEnumerator StartCinematicRoutine()
        {
            536900583 = new ProCamera2DCinematics.<StartCinematicRoutine>d__48(<>1__state:  0);
            mem[536900599] = this;
        }
        private System.Collections.IEnumerator GoToCinematicTargetRoutine(Com.LuisPedroFonseca.ProCamera2D.CinematicTarget cinematicTarget, int targetIndex)
        {
            ProCamera2DCinematics.<GoToCinematicTargetRoutine>d__49 val_1 = 536900581;
            val_1 = new ProCamera2DCinematics.<GoToCinematicTargetRoutine>d__49(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536900601] = this;
                mem[536900597] = cinematicTarget;
            }
            else
            {
                    mem[20] = this;
                mem[16] = cinematicTarget;
            }
            
            mem[536900605] = targetIndex;
        }
        private System.Collections.IEnumerator EndCinematicRoutine()
        {
            536900579 = new ProCamera2DCinematics.<EndCinematicRoutine>d__50(<>1__state:  0);
            mem[536900595] = this;
        }
        private void SetupLetterbox()
        {
            var val_13;
            object val_14;
            System.Func<ResolutionInfor, System.Single> val_15;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            UnityEngine.GameObject val_2 = this.gameObject;
            DropdownItem val_3 = this.GetComponentInChildren<DropdownItem>();
            if(1008280720 == 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.ProCamera2D;
                UnityEngine.GameObject val_6 = this.gameObject;
                T[] val_7 = this.GetComponentsInChildren<Spine.Unity.SkeletonUtilityBone>();
                val_13 = 536900575;
                if(((mem[536900762] & true) == 0) && (mem[536900691] == 0))
            {
                    val_13 = 536900575;
            }
            
                val_14 = mem[536900667];
                val_15 = mem[mem[536900667] + 4];
                val_15 = mem[536900667] + 4;
                if(val_15 == 0)
            {
                    if(((mem[536900762] & true) == 0) && (mem[536900691] == 0))
            {
                    val_14 = mem[536900667];
            }
            
                val_15 = 536875375;
                val_15 = new System.Func<ResolutionInfor, System.Single>(object:  val_14, method:  new IntPtr(1610684543));
                mem2[0] = val_15;
            }
            
                System.Linq.IOrderedEnumerable<TSource> val_9 = System.Linq.Enumerable.OrderByDescending<System.Object, System.Single>(source:  1008280720, keySelector:  536875375);
                TSource[] val_10 = System.Linq.Enumerable.ToArray<System.Type>(source:  1008280720);
                UnityEngine.GameObject val_11 = this.gameObject;
                SynchronizationContextBehavoir val_12 = this.AddComponent<SynchronizationContextBehavoir>();
            }
            
            this._letterbox = this;
        }
        private void LimitToNumericBoundaries(ref float horizontalPos, ref float verticalPos)
        {
            var val_9;
            var val_10;
            float val_11;
            var val_12;
            float val_13;
            val_9 = 1152921509910296176;
            if(this._numericBoundaries.UseLeftBoundary == false)
            {
                goto label_4;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this._numericBoundaries.ProCamera2D;
            val_10 = this;
            if(this._numericBoundaries >= 0)
            {
                goto label_4;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this._numericBoundaries.ProCamera2D;
            val_10 = this;
            val_11 = 0.5f;
            goto label_7;
            label_4:
            if(this._numericBoundaries.UseRightBoundary == false)
            {
                goto label_12;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this._numericBoundaries.ProCamera2D;
            val_10 = this;
            if(this._numericBoundaries <= 0)
            {
                goto label_12;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this._numericBoundaries.ProCamera2D;
            val_10 = this;
            val_11 = -0.5f;
            label_7:
            horizontalPos = this._numericBoundaries.RightBoundary;
            label_12:
            if(this._numericBoundaries.UseBottomBoundary == false)
            {
                goto label_19;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this._numericBoundaries.ProCamera2D;
            val_9 = this;
            if(this._numericBoundaries >= 0)
            {
                goto label_19;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this._numericBoundaries.ProCamera2D;
            val_12 = this;
            val_13 = 0.5f;
            goto label_22;
            label_19:
            if(this._numericBoundaries.UseTopBoundary == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this._numericBoundaries.ProCamera2D;
            val_9 = this;
            if(this._numericBoundaries <= 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = this._numericBoundaries.ProCamera2D;
            val_12 = this;
            val_13 = -0.5f;
            label_22:
            verticalPos = this._numericBoundaries.TopBoundary;
        }
        public ProCamera2DCinematics()
        {
            536877793 = new System.Collections.Generic.List<Page>();
            this.CinematicTargets = 536877793;
            this.EndDuration = 1f;
            this.EndEaseType = 1;
            this.UseLetterbox = 1;
            this.LetterboxAmount = 0.1f;
            this.LetterboxAnimDuration = 1f;
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            this._soOrder = 3000;
        }
        private static ProCamera2DCinematics()
        {
            mem2[0] = -1610609343;
        }
    
    }

}
