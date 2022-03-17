using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public abstract class BaseTrigger : BasePC2D
    {
        // Fields
        public System.Action OnEnteredTrigger;
        public System.Action OnExitedTrigger;
        public float UpdateInterval;
        public Com.LuisPedroFonseca.ProCamera2D.TriggerShape TriggerShape;
        public bool UseTargetsMidPoint;
        public UnityEngine.Transform TriggerTarget;
        protected float _exclusiveInfluencePercentage;
        private UnityEngine.Coroutine _testTriggerRoutine;
        protected bool _insideTrigger;
        protected UnityEngine.Vector2 _vectorFromPointToCenter;
        protected int _instanceID;
        private bool _triggerEnabled;
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(977603952 == 0)
            {
                    return;
            }
            
            this._instanceID = this.GetInstanceID();
            float val_4 = UnityEngine.Random.Range(minInclusive:  null, maxInclusive:  null);
            uint val_5 = 3164854026;
            val_5 = this.UpdateInterval + val_5;
            this.UpdateInterval = val_5;
            this.Toggle(value:  true);
        }
        protected override void OnEnable()
        {
            this.Enable();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(977715952 == 0)
            {
                    return;
            }
            
            if((R4 + 92) == 0)
            {
                    return;
            }
            
            R4.Toggle(value:  true);
        }
        protected override void OnDisable()
        {
            this.Disable();
            this._testTriggerRoutine = 0;
        }
        public void Toggle(bool value)
        {
            bool val_3;
            if(value == false)
            {
                goto label_0;
            }
            
            val_3 = 1;
            if(this._testTriggerRoutine != 0)
            {
                goto label_4;
            }
            
            System.Collections.IEnumerator val_1 = this.TestTriggerRoutine();
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  977944048);
            this._testTriggerRoutine = this;
            goto label_4;
            label_0:
            if(this._testTriggerRoutine != 0)
            {
                    this.StopCoroutine(routine:  this._testTriggerRoutine);
                this._testTriggerRoutine = 0;
            }
            
            val_3 = false;
            label_4:
            this._triggerEnabled = val_3;
        }
        public void TestTrigger()
        {
            float val_4;
            float val_5;
            float val_6;
            bool val_30;
            float val_31;
            float val_32;
            Com.LuisPedroFonseca.ProCamera2D.TriggerShape val_33;
            float val_34;
            var val_35;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            val_30 = this._triggerEnabled;
            if(this.UseTargetsMidPoint != true)
            {
                    val_32 = R5;
                if(this.TriggerTarget != 0)
            {
                    UnityEngine.Vector3 val_3 = position;
                val_30 = val_4;
                val_31 = val_5;
                val_32 = val_6;
            }
            
            }
            
            val_33 = this.TriggerShape;
            if(val_33 != 1)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_7 = position;
            val_34 = 4.01997E-38f;
            float val_8 = val_32.Invoke(arg:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
            UnityEngine.Vector3 val_9 = position;
            float val_10 = val_32.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7});
            UnityEngine.Vector3 val_11 = localScale;
            float val_12 = R6.Invoke(arg:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
            UnityEngine.Vector3 val_13 = localScale;
            float val_14 = val_5.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6});
            val_35 = val_5;
            val_30 = val_30;
            val_31 = val_31;
            val_32 = val_32;
            float val_15 = R4.Invoke(arg:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32});
            if((Com.LuisPedroFonseca.ProCamera2D.Utils.IsInsideRectangle(x:  R4.Invoke(arg:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32}), y:  val_13.y, width:  val_13.z, height:  null, pointX:  null, pointY:  null)) == true)
            {
                goto label_18;
            }
            
            val_33 = this.TriggerShape;
            label_7:
            if(val_33 != 0)
            {
                goto label_30;
            }
            
            UnityEngine.Vector3 val_18 = position;
            val_34 = 4.01997E-38f;
            float val_19 = val_32.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7});
            UnityEngine.Vector3 val_20 = position;
            float val_21 = val_32.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R6, z = R7});
            UnityEngine.Vector3 val_22 = localScale;
            float val_23 = R6.Invoke(arg:  new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6});
            UnityEngine.Vector3 val_24 = localScale;
            float val_25 = val_5.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R8});
            val_31 = val_31;
            val_30 = val_32;
            float val_26 = R4.Invoke(arg:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_30});
            val_35 = R4;
            float val_27 = R4.Invoke(arg:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_30});
            float val_30 = 0.25f;
            float val_28 = R6 + val_5;
            val_30 = val_28 * val_30;
            if((Com.LuisPedroFonseca.ProCamera2D.Utils.IsInsideCircle(x:  val_30, y:  val_24.y, radius:  val_28, pointX:  null, pointY:  null)) == false)
            {
                goto label_30;
            }
            
            label_18:
            if(this._insideTrigger == true)
            {
                    return;
            }
            
            return;
            label_30:
            if(this._insideTrigger == false)
            {
                    return;
            }
        
        }
        protected virtual void EnteredTrigger()
        {
            this._insideTrigger = true;
            if(this.OnEnteredTrigger == 0)
            {
                    return;
            }
            
            this.OnEnteredTrigger.Invoke();
        }
        protected virtual void ExitedTrigger()
        {
            this._insideTrigger = false;
            if(this.OnExitedTrigger == 0)
            {
                    return;
            }
            
            this.OnExitedTrigger.Invoke();
        }
        private System.Collections.IEnumerator TestTriggerRoutine()
        {
            536898083 = new BaseTrigger.<TestTriggerRoutine>d__19(<>1__state:  0);
            mem[536898099] = this;
        }
        protected float GetDistanceToCenterPercentage(UnityEngine.Vector2 point)
        {
            float val_2;
            float val_3;
            float val_4;
            float val_24;
            var val_25;
            float val_28;
            float val_29;
            UnityEngine.Vector3 val_1 = position;
            float val_5 = R7.Invoke(arg:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            UnityEngine.Vector3 val_6 = position;
            float val_7 = R7.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6});
            float val_23 = point.x;
            float val_24 = point.y;
            val_23 = val_23 - R7;
            val_24 = val_24 - R7;
            this._vectorFromPointToCenter = val_23;
            mem[1152921509880375748] = val_24;
            if(this.TriggerShape == 1)
            {
                    float val_8 = R7.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this._vectorFromPointToCenter + (0)], y = mem[this._vectorFromPointToCenter + (4)], z = 0f});
                UnityEngine.Vector3 val_9 = localScale;
                float val_10 = R7.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = SB});
                float val_11 = R5.Invoke(arg:  new UnityEngine.Vector3() {x = mem[this._vectorFromPointToCenter + (0)], y = mem[this._vectorFromPointToCenter + (4)], z = 0f});
                val_24 = 22732340;
                val_25 = 0;
                UnityEngine.Vector3 val_12 = localScale;
                float val_13 = mem[this._vectorFromPointToCenter + (4)].Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R7});
                float val_26 = 0.5f;
                var val_25 = mem[this._vectorFromPointToCenter + (4)];
                val_25 = val_25 * val_26;
                val_26 = R7 * val_26;
                val_28 = R5 / val_25;
                val_26 = R7 / val_26;
                float val_14 = val_28 & (~2147483648);
                float val_15 = val_26 & (~2147483648);
                float val_16 = UnityEngine.Mathf.Max(a:  val_26, b:  val_12.y);
                return (float)Com.LuisPedroFonseca.ProCamera2D.Utils.Remap(value:  val_29 = this._vectorFromPointToCenter / val_27, from1:  val_20.y, to1:  val_28 = 0.25f, from2:  null, to2:  R7);
            }
            
            float val_17 = this._vectorFromPointToCenter.magnitude;
            UnityEngine.Vector3 val_18 = localScale;
            val_24 = 4.01997E-38f;
            float val_19 = this._vectorFromPointToCenter.Invoke(arg:  new UnityEngine.Vector3() {x = val_2, y = val_3, z = val_4});
            val_25 = 0;
            UnityEngine.Vector3 val_20 = localScale;
            float val_21 = this._vectorFromPointToCenter.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R7});
            UnityEngine.Vector2 val_27 = this._vectorFromPointToCenter;
            val_27 = this._vectorFromPointToCenter + val_27;
            val_27 = val_27 * val_28;
            return (float)Com.LuisPedroFonseca.ProCamera2D.Utils.Remap(value:  val_29, from1:  val_20.y, to1:  val_28, from2:  null, to2:  R7);
        }
        protected BaseTrigger()
        {
            this.UseTargetsMidPoint = true;
            this.UpdateInterval = 0.1f;
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
