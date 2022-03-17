using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DShake : BasePC2D
    {
        // Fields
        public static string ExtensionName;
        private static Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake _instance;
        public System.Action OnShakeCompleted;
        public System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.ShakePreset> ShakePresets;
        public System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.ConstantShakePreset> ConstantShakePresets;
        public Com.LuisPedroFonseca.ProCamera2D.ConstantShakePreset StartConstantShakePreset;
        public Com.LuisPedroFonseca.ProCamera2D.ConstantShakePreset CurrentConstantShakePreset;
        private UnityEngine.Transform _shakeParent;
        private System.Collections.Generic.List<UnityEngine.Coroutine> _applyInfluencesCoroutines;
        private System.Collections.Generic.List<UnityEngine.Coroutine> _shakeTimedCoroutines;
        private UnityEngine.Coroutine _shakeCoroutine;
        private UnityEngine.Vector3 _shakeVelocity;
        private System.Collections.Generic.List<UnityEngine.Vector3> _shakePositions;
        private UnityEngine.Quaternion _rotationTarget;
        private UnityEngine.Quaternion _originalRotation;
        private float _rotationTime;
        private float _rotationVelocity;
        private System.Collections.Generic.List<UnityEngine.Vector3> _influences;
        private UnityEngine.Vector3 _influencesSum;
        private UnityEngine.Vector3[] _constantShakePositions;
        private UnityEngine.Vector3 _constantShakePosition;
        private bool _isConstantShaking;
        
        // Properties
        public static Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake Instance { get; }
        public static bool Exists { get; }
        
        // Methods
        public static Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake get_Instance()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            val_6 = 536892153;
            if(((mem[536892340] & true) == 0) && (mem[536892269] == 0))
            {
                    val_6 = 536892153;
            }
            
            if((System.Object.Equals(objA:  mem[536892245] + 4, objB:  0)) == false)
            {
                goto label_3;
            }
            
            System.Type val_2 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073763065)});
            val_7 = 0;
            UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  1073763065);
            val_8 = 536892153;
            if(((mem[536892340] & true) == 0) && (mem[536892269] == 0))
            {
                    val_8 = 536892153;
            }
            
            if((1073763065 != 0) && ((mem[1073763065] + 180) >= mem[536892333]))
            {
                    var val_6 = mem[1073763065] + 100;
                val_6 = val_6 + (mem[536892333] << 2);
                if(((mem[1073763065] + 100 + (mem[536892333]) << 2) + -4) != val_8)
            {
                    1073763065 = 0;
            }
            
                val_7 = 1073763065;
            }
            
            mem2[0] = val_7;
            if((System.Object.Equals(objA:  mem[536892245] + 4, objB:  0)) == true)
            {
                goto label_12;
            }
            
            label_3:
            val_9 = 536892153;
            if((mem[536892340] & true) != 0)
            {
                    return;
            }
            
            if(mem[536892269] != 0)
            {
                    return;
            }
            
            val_9 = 536892153;
            return;
            label_12:
            22716300 = new UnityEngine.UnityException(message:  22791880);
        }
        public static bool get_Exists()
        {
            if(((mem[536892340] & true) == 0) && (mem[536892269] == 0))
            {
                    536892153 = 536892153;
            }
            
            if((mem[536891408] & true) != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  mem[536892245] + 4, y:  0);
            }
            
            if(mem[536891337] != 0)
            {
                    return UnityEngine.Object.op_Inequality(x:  mem[536892245] + 4, y:  0);
            }
            
            return UnityEngine.Object.op_Inequality(x:  mem[536892245] + 4, y:  0);
        }
        protected override void Awake()
        {
            float val_11;
            float val_12;
            float val_13;
            var val_21;
            UnityEngine.Transform val_22;
            this.Awake();
            val_21 = 536892153;
            if(((mem[536892340] & true) == 0) && (mem[536892269] == 0))
            {
                    val_21 = 536892153;
            }
            
            mem2[0] = this;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            UnityEngine.Transform val_2 = this.transform;
            UnityEngine.Transform val_3 = this.parent;
            if(1042854672 != 0)
            {
                    536887303 = new UnityEngine.GameObject(name:  -1610605225);
                UnityEngine.Transform val_6 = 536887303.transform;
                this._shakeParent = 536887303;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.ProCamera2D;
                UnityEngine.Transform val_8 = this.transform;
                UnityEngine.Transform val_9 = this.parent;
                this._shakeParent.parent = 1042854672;
                val_22 = this._shakeParent;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
                val_22.localPosition = new UnityEngine.Vector3() {x = val_11, y = val_12, z = val_13};
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_14 = this.ProCamera2D;
                UnityEngine.Transform val_15 = this.transform;
                this.parent = 536887303;
            }
            else
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_16 = this.ProCamera2D;
                UnityEngine.Transform val_17 = this.transform;
                536887303 = new UnityEngine.GameObject(name:  -1610605225);
                UnityEngine.Transform val_19 = 536887303.transform;
                val_22 = 536887303;
                this.parent = 536887303;
                this._shakeParent = val_22;
            }
            
            UnityEngine.Quaternion val_20 = localRotation;
        }
        private void Start()
        {
            if(this.StartConstantShakePreset == 0)
            {
                    return;
            }
            
            R4.ConstantShake(preset:  R4 + 56);
        }
        private void Update()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if(R0 < 1)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = Com.LuisPedroFonseca.ProCamera2D.Utils.GetVectorsSum(input:  1043091212);
            this._influences.Clear();
            this._shakeParent.localPosition = new UnityEngine.Vector3() {x = this._influencesSum, y = R7, z = 0.1684496f};
        }
        public void Shake(float duration, UnityEngine.Vector2 strength, int vibrato = 10, float randomness = 0.1, float initialAngle = -1, UnityEngine.Vector3 rotation, float smoothness = 0.1, bool ignoreTimeScale = False)
        {
            float val_7;
            float val_8;
            float val_11;
            float val_13;
            float val_15;
            float val_16;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            float val_37;
            var val_38;
            float val_39;
            val_32 = strength.x;
            if(this.enabled == false)
            {
                    return;
            }
            
            if((rotation.x + 1) <= (2.802597E-45f))
            {
                    val_33 = 2;
            }
            
            val_34 = 536882357;
            if(val_33 >= 1)
            {
                    float val_38 = 0f;
                var val_39 = val_32;
                do
            {
                float val_37 = 0.5f;
                val_37 = val_37 * val_39;
                val_38 = val_38 + val_37;
            }
            while(1 < val_33);
            
                if(val_33 >= 1)
            {
                    val_39 = val_39 / val_38;
                var val_40 = 0;
                do
            {
                val_35 = mem[536882369];
                if(val_35 <= val_40)
            {
                    val_35 = mem[536882369];
            }
            
                val_38 = val_39 * (val_34 + 16);
                val_40 = val_40 + 1;
            }
            while(val_40 < val_33);
            
            }
            
            }
            
            float val_4 = strength.y.magnitude;
            val_32;
            float val_41 = 2f;
            if(val_40 == val_33)
            {
                    float val_5 = UnityEngine.Random.Range(minInclusive:  -1f, maxInclusive:  randomness);
                val_36 = 0;
            }
            
            val_37 = 536882585;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            val_38 = val_33 - 1;
            var val_9 = val_37 + (val_38 << 3);
            mem2[0] = val_7;
            val_39 = val_11;
            if(mem[536882297] <= val_38)
            {
                    val_39 = val_11;
            }
            
            var val_12 = 536882285 + (val_38 << 4);
            val_12 = val_12 + 16;
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0.1701829f, y = ignoreTimeScale, z = val_39});
            if(val_33 >= 2)
            {
                    uint val_44 = 1043219584;
                val_41 = val_44 / val_41;
                var val_45 = 0;
                do
            {
                if(val_45 != 0)
            {
                    int val_17 = UnityEngine.Random.Range(minInclusive:  89, maxExclusive:  90);
                val_36 = val_36 + (-180f);
            }
            
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.up;
                float val_42 = (float)UnityEngine.Random.Range(minInclusive:  89, maxExclusive:  90);
                val_42 = val_42 * rotation.y;
                UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.AngleAxis(angle:  val_42, axis:  new UnityEngine.Vector3() {x = 0.1701829f, y = val_42, z = val_7});
                float val_21 = val_36 * 0.01745329f;
                float val_43 = val_21;
                val_43 = val_44 * val_43;
                UnityEngine.Vector3 val_23 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = 0.1701829f, y = val_7, z = val_8, w = val_15}, point:  new UnityEngine.Vector3() {x = val_16, y = val_44 * val_21, z = val_43});
                UnityEngine.Vector2 val_24 = UnityEngine.Vector2.ClampMagnitude(vector:  new UnityEngine.Vector2() {x = 0.1701829f, y = val_7}, maxLength:  val_23.x);
                UnityEngine.Vector2 val_25 = UnityEngine.Vector2.ClampMagnitude(vector:  new UnityEngine.Vector2() {x = 0.1701829f, y = val_7}, maxLength:  val_24.x);
                val_37 = 1.085711E-19f;
                val_44 = val_44 - val_41;
                var val_26 = val_37 + 0;
                mem2[0] = val_7;
                UnityEngine.Vector2 val_27 = UnityEngine.Vector2.ClampMagnitude(vector:  new UnityEngine.Vector2() {x = 0.1701829f, y = strength.y}, maxLength:  val_25.x);
                val_38;
                float val_28 = 0f / (float)val_38;
                if(val_45 == 1)
            {
                    UnityEngine.Quaternion val_29 = UnityEngine.Quaternion.identity;
                UnityEngine.Quaternion val_30 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = 0.1701829f, y = val_7, z = val_8, w = val_15}, b:  new UnityEngine.Quaternion() {x = val_16}, t:  val_29.x);
            }
            else
            {
                    UnityEngine.Quaternion val_31 = UnityEngine.Quaternion.identity;
                UnityEngine.Quaternion val_32 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = 0.1701829f, y = val_7, z = val_8, w = val_15}, b:  new UnityEngine.Quaternion() {x = val_16}, t:  val_31.x);
                UnityEngine.Quaternion val_33 = UnityEngine.Quaternion.Inverse(rotation:  new UnityEngine.Quaternion() {x = 0.1701829f});
            }
            
                val_33 = 0;
                UnityEngine.Quaternion val_34 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 0.1701829f, y = val_7, z = val_8, w = val_15}, rhs:  new UnityEngine.Quaternion() {x = val_16, y = mem[1152921509945046016], z = mem[1152921509945046020], w = mem[1152921509945046024]});
                val_34 = val_34;
                val_45 = val_45 + 1;
            }
            while(val_45 < val_38);
            
            }
            
            UnityEngine.Coroutine val_36 = this.ApplyShakesTimed(shakes:  536882585, rotations:  536882285, durations:  536882357, smoothness:  val_34.x, ignoreTimeScale:  val_13);
            mem[1152921509945045972].Add(item:  1043231632);
        }
        public void Shake(int presetIndex)
        {
            System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.ShakePreset> val_3;
            float val_4;
            bool val_3 = true;
            val_3 = this.ShakePresets;
            val_3 = val_3 - 1;
            if(val_3 < presetIndex)
            {
                    string val_1 = presetIndex.ToString();
                string val_2 = -1610609109(-1610609109) + 1043372548;
                UnityEngine.Debug.LogWarning(message:  -1610609109);
                return;
            }
            
            if(val_3 <= presetIndex)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (presetIndex << 2);
            if(val_4 <= presetIndex)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + (presetIndex << 2);
            if(((0 + (presetIndex) << 2) + 16 + 16) <= presetIndex)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + (presetIndex << 2);
            if(((0 + (presetIndex) << 2) + 16 + 28) <= presetIndex)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + (presetIndex << 2);
            if(val_7 <= presetIndex)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + (presetIndex << 2);
            if(((0 + (presetIndex) << 2) + 16 + 40) != 0)
            {
                    val_4 = -1f;
            }
            else
            {
                    if(((0 + (presetIndex) << 2) + 16 + 40) <= presetIndex)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_9 = val_9 + (presetIndex << 2);
                val_4 = mem[(0 + (presetIndex) << 2) + 16 + 44];
                val_4 = (0 + (presetIndex) << 2) + 16 + 44;
            }
            
            if(val_9 <= presetIndex)
            {
                    var val_10 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_10 = val_10 + (presetIndex << 2);
            if(val_10 <= presetIndex)
            {
                    var val_11 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_11 = val_11 + (presetIndex << 2);
            val_3 = mem[(0 + (presetIndex) << 2) + 16];
            val_3 = (0 + (presetIndex) << 2) + 16;
            if(val_11 <= presetIndex)
            {
                    var val_12 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_12 = val_12 + (presetIndex << 2);
            this.Shake(duration:  null, strength:  new UnityEngine.Vector2() {x = (0 + (presetIndex) << 2) + 16 + 24, y = (0 + (presetIndex) << 2) + 16 + 12}, vibrato:  (0 + (presetIndex) << 2) + 16 + 16, randomness:  null, initialAngle:  null, rotation:  new UnityEngine.Vector3() {x = (0 + (presetIndex) << 2) + 16 + 28, y = (0 + (presetIndex) << 2) + 16 + 32, z = val_4}, smoothness:  null, ignoreTimeScale:  (0 + (presetIndex) << 2) + 16 + 48);
        }
        public void Shake(string presetName)
        {
            var val_4 = 0;
            goto label_1;
            label_7:
            if(true <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            string val_1 = (0 + 0) + 16.name;
            bool val_2 = System.String.op_Equality(a:  (0 + 0) + 16, b:  presetName);
            if(val_2 == true)
            {
                goto label_5;
            }
            
            val_4 = 1;
            label_1:
            if(val_4 < val_2)
            {
                goto label_7;
            }
            
            string val_3 = -1610609107(-1610609107) + presetName;
            UnityEngine.Debug.LogWarning(message:  -1610609107);
            return;
            label_5:
            this.Shake(presetIndex:  0);
        }
        public void Shake(Com.LuisPedroFonseca.ProCamera2D.ShakePreset preset)
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DShake val_1;
            float val_2;
            float val_3;
            int val_4;
            UnityEngine.Vector3 val_5;
            val_1 = this;
            if(preset != 0)
            {
                    val_2 = preset.Duration;
                val_3 = preset.Randomness;
                val_4 = preset.Vibrato;
                val_5 = preset.Strength;
            }
            else
            {
                    val_2 = 0f;
                val_4 = 7.286752E-44f;
                val_3 = 4.085283E-38f;
                val_5 = preset.Strength;
            }
            
            if(preset.UseRandomInitialAngle == true)
            {
                    preset.InitialAngle = -1f;
            }
            
            if(val_1 == 0)
            {
                    val_5 = val_5;
                val_4 = val_4;
                val_1 = val_1;
            }
            
            if(preset.IgnoreTimeScale == true)
            {
                    preset.IgnoreTimeScale = 1;
            }
            
            this.Shake(duration:  null, strength:  new UnityEngine.Vector2() {x = 0f, y = val_5}, vibrato:  R4, randomness:  null, initialAngle:  null, rotation:  new UnityEngine.Vector3() {x = val_4, y = val_3, z = preset.InitialAngle}, smoothness:  null, ignoreTimeScale:  preset.Rotation);
        }
        public void StopShaking()
        {
            var val_2;
            var val_3;
            System.Collections.Generic.List<UnityEngine.Coroutine> val_4;
            val_2 = 0;
            goto label_1;
            label_5:
            if(true <= val_2)
            {
                    var val_2 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_2 = val_2 + 0;
            this.StopCoroutine(routine:  (0 + 0) + 16);
            val_2 = 1;
            label_1:
            if(val_2 < this)
            {
                goto label_5;
            }
            
            val_3 = 0;
            goto label_6;
            label_10:
            if(this <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            this.StopCoroutine(routine:  (0 + 0) + 16);
            val_3 = 1;
            label_6:
            val_4 = this._shakeTimedCoroutines;
            if(val_3 < this)
            {
                goto label_10;
            }
            
            if(this._shakeCoroutine != 0)
            {
                    val_4 = 0;
                this.StopCoroutine(routine:  this._shakeCoroutine);
                this._shakeCoroutine = val_4;
            }
            
            this._shakePositions.Clear();
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.ShakeCompleted();
        }
        public void ConstantShake(Com.LuisPedroFonseca.ProCamera2D.ConstantShakePreset preset)
        {
            var val_6;
            var val_7;
            if(this.CurrentConstantShakePreset != 0)
            {
                    this.StopConstantShaking(duration:  null);
            }
            
            this.CurrentConstantShakePreset = preset;
            this._isConstantShaking = true;
            this._constantShakePositions = 536882597;
            val_6 = 0;
            val_7 = 0;
            goto label_6;
            label_18:
            if(1043992488 <= val_7)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + val_6;
            if(val_6 <= val_7)
            {
                    var val_7 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + val_6;
            if(val_7 <= val_7)
            {
                    var val_8 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = val_8 + val_6;
            if(val_8 <= val_7)
            {
                    var val_9 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_9 = val_9 + val_6;
            if(val_9 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            System.Collections.IEnumerator val_2 = this.CalculateConstantShakePosition(index:  0, frequencyMin:  4.085283E-38f, frequencyMax:  null, amplitudeX:  null, amplitudeY:  null, amplitudeZ:  null);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1043992336);
            val_6 = 20;
            val_7 = 1;
            label_6:
            if(val_7 < this)
            {
                goto label_18;
            }
            
            System.Collections.IEnumerator val_4 = this.ConstantShakeRoutine(intensity:  4.085283E-38f);
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  1043992336);
        }
        public void ConstantShake(string presetName)
        {
            goto label_1;
            label_7:
            if(true <= 22981920)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            string val_1 = 2621443.name;
            bool val_2 = System.String.op_Equality(a:  2621443, b:  presetName);
            if(val_2 == true)
            {
                goto label_5;
            }
            
            4 = 5;
            label_1:
            if((4 - 4) < val_2)
            {
                goto label_7;
            }
            
            string val_4 = -1610609123(-1610609123) + presetName + -1610611771(-1610611771);
            UnityEngine.Debug.LogWarning(message:  -1610609123);
            return;
            label_5:
            if(val_2 <= 22981920)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this.ConstantShake(preset:  2621443);
        }
        public void ConstantShake(int presetIndex)
        {
            bool val_3 = true;
            val_3 = val_3 - 1;
            if(val_3 < presetIndex)
            {
                    string val_1 = presetIndex.ToString();
                string val_2 = -1610609125(-1610609125) + 1044282132 + -1610611771(-1610611771);
                UnityEngine.Debug.LogWarning(message:  -1610609125);
                return;
            }
            
            if(val_3 <= presetIndex)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + (presetIndex << 2);
            this.ConstantShake(preset:  (0 + (presetIndex) << 2) + 16);
        }
        public void StopConstantShaking(float duration = 0.3)
        {
            this.CurrentConstantShakePreset = 0;
            mem[1152921509946236984] = 0;
            System.Collections.IEnumerator val_1 = this.StopConstantShakeRoutine(duration:  duration);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1044422544);
        }
        public UnityEngine.Coroutine ApplyShakesTimed(UnityEngine.Vector2[] shakes, UnityEngine.Vector3[] rotations, float[] durations, float smoothness = 0.1, bool ignoreTimeScale = False)
        {
            float val_3;
            UnityEngine.Vector3[] val_6;
            UnityEngine.Vector2[] val_7;
            var val_8;
            var val_9;
            val_6 = rotations;
            val_7 = shakes;
            val_8 = 0;
            if(this.enabled == false)
            {
                    return;
            }
            
            val_9 = 536882285;
            if(536882285 >= 1)
            {
                    var val_6 = 0;
                do
            {
                UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0.1913679f, y = mem[rotations[0x10] + (0)], z = mem[rotations[0x10] + (4)]});
                UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.op_Multiply(lhs:  new UnityEngine.Quaternion() {x = 0.1913679f}, rhs:  new UnityEngine.Quaternion() {x = val_3, y = mem[1152921509946467712]});
                val_9 = val_9;
                val_6 = val_6;
                val_6 = val_6 + 1;
            }
            while(val_6 < (rotations + 12));
            
            }
            
            UnityEngine.Coroutine val_5 = this.ApplyShakesTimed(shakes:  val_7, rotations:  536882285, durations:  durations, smoothness:  val_4.x, ignoreTimeScale:  true);
            val_8 = this;
        }
        public void ApplyInfluenceIgnoringBoundaries(UnityEngine.Vector2 influence)
        {
            System.Collections.Generic.List<UnityEngine.Vector3> val_5;
            var val_6;
            val_5 = this;
            val_6 = 22981924;
            float val_1 = UnityEngine.Time.deltaTime;
            if((System.Single.IsNaN(f:  0.0001f)) == true)
            {
                    return;
            }
            
            if((System.Single.IsNaN(f:  0.0001f)) == true)
            {
                    return;
            }
            
            val_5 = this._influences;
            UnityEngine.Vector3 val_4 = Invoke(arg1:  0.0001f, arg2:  null);
            val_5.Add(item:  new UnityEngine.Vector3() {x = R4, y = R5, z = R7});
        }
        private UnityEngine.Coroutine ApplyShakesTimed(UnityEngine.Vector2[] shakes, UnityEngine.Quaternion[] rotations, float[] durations, float smoothness = 0.1, bool ignoreTimeScale = False)
        {
            bool val_1;
            System.Collections.IEnumerator val_2 = this.ApplyShakesTimedRoutine(shakes:  shakes, rotations:  rotations, durations:  durations, ignoreTimeScale:  val_1);
            UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  1045110800);
            if(this._shakeCoroutine != 0)
            {
                    return;
            }
            
            System.Collections.IEnumerator val_4 = this.ShakeRoutine(smoothness:  ignoreTimeScale, ignoreTimeScale:  ignoreTimeScale);
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  1045110800);
            this._shakeCoroutine = this;
        }
        private System.Collections.IEnumerator ShakeRoutine(float smoothness, bool ignoreTimeScale = False)
        {
            ProCamera2DShake.<ShakeRoutine>d__41 val_1 = 536900621;
            val_1 = new ProCamera2DShake.<ShakeRoutine>d__41(<>1__state:  0);
            if(val_1 != 0)
            {
                    22981925 = val_1;
                mem[536900637] = this;
                mem[536900645] = ignoreTimeScale;
            }
            else
            {
                    mem[16] = this;
                mem[24] = ignoreTimeScale;
            }
            
            mem[536900641] = R2;
        }
        private void ShakeCompleted()
        {
            this._shakeParent.localPosition = new UnityEngine.Vector3() {x = mem[this._influencesSum + (0)], y = mem[this._influencesSum + (4)], z = mem[this._influencesSum + (8)]};
            this._shakeParent.localRotation = new UnityEngine.Quaternion() {x = this._originalRotation, y = mem[this._influencesSum + (4)], z = mem[this._influencesSum + (8)], w = mem[this._influencesSum + (0)]};
            this._shakeCoroutine = 0;
            if(this.OnShakeCompleted == 0)
            {
                    return;
            }
            
            this.OnShakeCompleted.Invoke();
        }
        private System.Collections.IEnumerator ApplyShakesTimedRoutine(System.Collections.Generic.IList<UnityEngine.Vector2> shakes, System.Collections.Generic.IList<UnityEngine.Quaternion> rotations, float[] durations, bool ignoreTimeScale = False)
        {
            ProCamera2DShake.<ApplyShakesTimedRoutine>d__43 val_1 = 536900615;
            val_1 = new ProCamera2DShake.<ApplyShakesTimedRoutine>d__43(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536900631] = this;
                mem[536900639] = shakes;
                mem[536900643] = rotations;
                mem[536900635] = durations;
            }
            else
            {
                    mem[16] = this;
                mem[24] = shakes;
                mem[28] = rotations;
                mem[20] = durations;
            }
            
            mem[536900647] = ignoreTimeScale;
        }
        private System.Collections.IEnumerator ApplyShakeTimedRoutine(UnityEngine.Vector2 shake, UnityEngine.Quaternion rotation, float duration, bool ignoreTimeScale = False)
        {
            var val_2;
            float val_3;
            float val_4;
            val_3 = rotation.w;
            val_4 = rotation.z;
            ProCamera2DShake.<ApplyShakeTimedRoutine>d__44 val_1 = 536900613;
            val_1 = new ProCamera2DShake.<ApplyShakeTimedRoutine>d__44(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536900629] = this;
                mem[536900641] = shake.x;
                mem[536900645] = shake.y;
                val_3 = val_3;
                val_4 = rotation.z;
            }
            else
            {
                    mem[16] = this;
                mem[28] = shake.x;
                mem[32] = shake.y;
            }
            
            mem[536900649] = rotation.x;
            mem[536900653] = rotation.y;
            mem[536900657] = val_4;
            mem[536900661] = val_3;
            if(val_1 != 0)
            {
                    mem[536900637] = ignoreTimeScale;
            }
            else
            {
                    mem[24] = ignoreTimeScale;
            }
            
            mem[536900633] = val_2;
        }
        private System.Collections.IEnumerator StopConstantShakeRoutine(float duration)
        {
            ProCamera2DShake.<StopConstantShakeRoutine>d__45 val_1 = 536900623;
            val_1 = new ProCamera2DShake.<StopConstantShakeRoutine>d__45(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536900639] = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            mem[536900643] = R1;
        }
        private System.Collections.IEnumerator CalculateConstantShakePosition(int index, float frequencyMin, float frequencyMax, float amplitudeX, float amplitudeY, float amplitudeZ)
        {
            float val_1;
            float val_2;
            float val_3;
            float val_5 = R3;
            ProCamera2DShake.<CalculateConstantShakePosition>d__46 val_4 = 536900617;
            val_4 = new ProCamera2DShake.<CalculateConstantShakePosition>d__46(<>1__state:  0);
            if(val_4 != 0)
            {
                    val_5 = val_4;
                mem[536900657] = this;
                mem[536900653] = index;
                mem[536900633] = R2;
                mem[536900637] = val_5;
                mem[536900641] = val_3;
                mem[536900645] = val_2;
            }
            else
            {
                    mem[40] = this;
                mem[36] = index;
                mem[16] = R2;
                mem[20] = val_5;
                mem[24] = val_3;
                mem[28] = val_2;
            }
            
            mem[536900649] = val_1;
        }
        private System.Collections.IEnumerator ConstantShakeRoutine(float intensity)
        {
            ProCamera2DShake.<ConstantShakeRoutine>d__47 val_1 = 536900619;
            val_1 = new ProCamera2DShake.<ConstantShakeRoutine>d__47(<>1__state:  0);
            if(val_1 != 0)
            {
                    mem[536900635] = this;
            }
            else
            {
                    mem[16] = this;
            }
            
            mem[536900639] = R1;
        }
        public ProCamera2DShake()
        {
            536878283 = new System.Collections.Generic.List<Page>();
            this.ShakePresets = 536878283;
            536877819 = new System.Collections.Generic.List<Page>();
            this.ConstantShakePresets = 536877819;
            System.Collections.Generic.List<Page> val_3 = 536877835;
            val_3 = new System.Collections.Generic.List<Page>();
            this._applyInfluencesCoroutines = val_3;
            System.Collections.Generic.List<Page> val_4 = 536877835;
            val_4 = new System.Collections.Generic.List<Page>();
            this._shakeTimedCoroutines = val_4;
            System.Collections.Generic.List<UnityEngine.Vector3> val_5 = 536878517;
            val_5 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this._shakePositions = val_5;
            System.Collections.Generic.List<UnityEngine.Vector3> val_6 = 536878517;
            val_6 = new System.Collections.Generic.List<UnityEngine.Vector3>();
            this._influences = val_6;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
        }
        private static ProCamera2DShake()
        {
            mem2[0] = -1610604615;
        }
    
    }

}
