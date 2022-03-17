using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DContentFitter : BasePC2D, ISizeOverrider
    {
        // Fields
        public static string ExtensionName;
        private Com.LuisPedroFonseca.ProCamera2D.ContentFitterMode _contentFitterMode;
        private bool _useLetterOrPillarboxing;
        private float _targetHeight;
        private float _targetWidth;
        private float _targetAspectRatio;
        public float VerticalAlignment;
        public float HorizontalAlignment;
        private float _prevTargetHeight;
        private float _prevTargetWidth;
        private float _prevTargetAspectRatio;
        private float _prevAspectRatio;
        private float _prevVerticalAlignment;
        private float _prevHorizontalAlignment;
        private bool _prevUseLetterOrPillarboxing;
        private UnityEngine.Camera _letterPillarboxingCamera;
        private int _soOrder;
        
        // Properties
        public Com.LuisPedroFonseca.ProCamera2D.ContentFitterMode ContentFitterMode { get; set; }
        public bool UseLetterOrPillarboxing { get; set; }
        private static float ScreenAspectRatio { get; }
        public float TargetHeight { get; set; }
        public float TargetWidth { get; set; }
        public float TargetAspectRatio { get; set; }
        public int SOOrder { get; set; }
        
        // Methods
        public void set_ContentFitterMode(Com.LuisPedroFonseca.ProCamera2D.ContentFitterMode value)
        {
            this._contentFitterMode = value;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.ResetProjectionMatrix();
            if(this._contentFitterMode != 0)
            {
                    return;
            }
            
            float val_2 = R4 + 52;
            val_2 = val_2 * (R4 + 60);
            R4.TargetWidth = val_2;
        }
        public Com.LuisPedroFonseca.ProCamera2D.ContentFitterMode get_ContentFitterMode()
        {
        
        }
        public void set_UseLetterOrPillarboxing(bool value)
        {
            this._useLetterOrPillarboxing = value;
            this.ToggleLetterPillarboxing(value:  value);
        }
        public bool get_UseLetterOrPillarboxing()
        {
            return (bool)this._useLetterOrPillarboxing;
        }
        private static float get_ScreenAspectRatio()
        {
            float val_3 = (float)UnityEngine.Screen.width;
            val_3 = val_3 / (float)UnityEngine.Screen.height;
            return (float)val_3;
        }
        public float get_TargetHeight()
        {
            return (float)S0;
        }
        public void set_TargetHeight(float value)
        {
            float val_3;
            this._targetHeight = R1;
            if(this._contentFitterMode != 0)
            {
                    val_3 = (float)UnityEngine.Screen.width / (float)UnityEngine.Screen.height;
            }
            else
            {
                    val_3 = this._targetAspectRatio;
            }
            
            val_3 = val_3 * R1;
            this._targetWidth = val_3;
        }
        public float get_TargetWidth()
        {
            return (float)S0;
        }
        public void set_TargetWidth(float value)
        {
            float val_3;
            this._targetWidth = R1;
            if(this._contentFitterMode != 0)
            {
                    val_3 = (float)UnityEngine.Screen.width / (float)UnityEngine.Screen.height;
            }
            else
            {
                    val_3 = this._targetAspectRatio;
            }
            
            val_3 = R1 / val_3;
            this._targetHeight = val_3;
        }
        public float get_TargetAspectRatio()
        {
            return (float)S0;
        }
        public void set_TargetAspectRatio(float value)
        {
            float val_1 = R1;
            this._targetAspectRatio = ;
            val_1 = this._targetHeight * val_1;
            this._targetWidth = val_1;
        }
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.AddSizeOverrider(overrider:  1011517392);
        }
        private System.Collections.IEnumerator Start()
        {
            536900585 = new ProCamera2DContentFitter.<Start>d__34(<>1__state:  0);
            mem[536900601] = this;
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1011741392)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemoveSizeOverrider(overrider:  R4);
        }
        public float OverrideSize(float deltaTime, float originalSize)
        {
            if(this.enabled == false)
            {
                    return (float)deltaTime;
            }
            
            return this.GetSize(mode:  this._contentFitterMode);
        }
        public int get_SOOrder()
        {
            return (int)this._soOrder;
        }
        public void set_SOOrder(int value)
        {
            this._soOrder = value;
        }
        private float GetSize(Com.LuisPedroFonseca.ProCamera2D.ContentFitterMode mode)
        {
            var val_13;
            float val_14;
            float val_15;
            float val_16;
            float val_17;
            if(mode == 0)
            {
                goto label_0;
            }
            
            if(mode == 1)
            {
                goto label_1;
            }
            
            if(mode != 2)
            {
                goto label_2;
            }
            
            val_13 = this._targetHeight * 0.5f;
            return (float)val_13;
            label_1:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            float val_2 = this.aspect;
            float val_13 = 0.5f;
            val_13 = this._targetWidth * val_13;
            val_13 = val_13 / 1012201680;
            return (float)val_13;
            label_0:
            if(mode != 0)
            {
                goto label_6;
            }
            
            val_14 = this._targetHeight;
            val_15 = this._prevTargetHeight;
            if((mode != 0) || (mode != 0))
            {
                goto label_14;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            float val_4 = this.aspect;
            if(((this != 0) || (this != 0)) || (this != 0))
            {
                goto label_14;
            }
            
            if(this._useLetterOrPillarboxing == true)
            {
                    this._useLetterOrPillarboxing = 1;
            }
            
            if(this._prevUseLetterOrPillarboxing == true)
            {
                    this._prevUseLetterOrPillarboxing = 1;
            }
            
            if(1 != 1)
            {
                goto label_14;
            }
            
            val_16 = this._targetAspectRatio;
            val_17 = this._prevTargetAspectRatio;
            goto label_15;
            label_6:
            val_15 = this._prevTargetHeight;
            val_14 = this._targetHeight;
            label_14:
            System.Collections.IEnumerator val_5 = this.UpdateFixedAspectRatio();
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  1012201680);
            val_17 = this._prevTargetAspectRatio;
            val_16 = this._targetAspectRatio;
            label_15:
            this._prevTargetWidth = this._targetWidth;
            mem2[0] = val_14;
            mem2[0] = val_16;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = this.ProCamera2D;
            float val_8 = this.aspect;
            this._prevUseLetterOrPillarboxing = this._useLetterOrPillarboxing;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_9 = this.ProCamera2D;
            float val_10 = this.aspect;
            float val_14 = 0.5f;
            float val_11 = this._targetWidth * val_14;
            val_14 = this._targetHeight * val_14;
            val_11 = val_11 / 1012201680;
            return UnityEngine.Mathf.Max(a:  val_14, b:  null);
            label_2:
            22709204 = new System.ArgumentOutOfRangeException();
        }
        private System.Collections.IEnumerator UpdateFixedAspectRatio()
        {
            536900587 = new ProCamera2DContentFitter.<UpdateFixedAspectRatio>d__42(<>1__state:  0);
            mem[536900603] = this;
        }
        private static void UpdateCameraAlignment(UnityEngine.Camera cam, bool isPillarbox, float targetAspectRatio, float horizontalAlignment, float verticalAlignment)
        {
            var val_2;
            float val_16;
            float val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            cam.ResetProjectionMatrix();
            if(isPillarbox != false)
            {
                    float val_1 = cam.aspect;
                UnityEngine.Camera val_14 = cam;
                val_14 = R2 / val_14;
                val_16 = 0f;
                val_17 = (-0.5f) * R3;
            }
            else
            {
                    float val_3 = cam.aspect;
                UnityEngine.Camera val_15 = cam;
                val_15 = val_15 / R2;
                val_17 = 0f;
                val_16 = (-0.5f) * val_2;
            }
            
            UnityEngine.Rect val_4 = new UnityEngine.Rect(x:  val_16, y:  horizontalAlignment, width:  val_17, height:  null);
            UnityEngine.Matrix4x4 val_5 = projectionMatrix;
            float val_6 = val_5.m13 + 124;
            val_18 = mem[val_5.m13 + 120];
            val_18 = val_5.m13 + 120;
            mem2[0] = val_5.m13 + 176;
            mem2[0] = val_5.m13 + 172;
            mem2[0] = val_5.m13 + 168;
            mem2[0] = val_5.m13 + 164;
            mem2[0] = val_5.m13 + 144;
            mem2[0] = val_5.m13 + 140;
            mem2[0] = val_5.m13 + 136;
            if(((mem[536892284] & true) == 0) && (mem[536892213] == 0))
            {
                    mem2[0] = mem[(val_5.m13 + 124) + (0)];
                mem2[0] = mem[(val_5.m13 + 124) + (4)];
                val_21 = mem[(val_5.m13 + 124) + (8)];
                val_18 = val_18;
                val_19 = mem[val_5.m13 + 80];
                val_19 = val_5.m13 + 80;
                val_20 = mem[val_5.m13 + 84];
                val_20 = val_5.m13 + 84;
            }
            
            float val_7 = val_5.m32 - 72;
            mem2[0] = val_5.m13 + 180;
            mem2[0] = val_5.m13 + 88;
            mem2[0] = val_5.m13 + 92;
            mem2[0] = val_5.m13 + 100;
            mem2[0] = val_5.m13 + 148;
            mem2[0] = val_5.m13 + 152;
            mem2[0] = val_5.m13 + 156;
            mem2[0] = val_5.m13 + 160;
            mem2[0] = val_5.m13 + 108;
            float val_8 = val_5.m13 + 8;
            mem2[0] = val_5.m13 + 96;
            mem2[0] = val_5.m13 + 104;
            mem2[0] = val_5.m13 + 112;
            float val_9 = val_5.m13 + 120;
            float val_10 = val_5.m13 + 152;
            float val_11 = val_5.m13 + 120;
            mem2[0] = val_5.m13 + 172;
            val_22 = mem[val_5.m13 + 180];
            val_22 = val_5.m13 + 180;
            val_23 = mem[val_5.m13 + 176];
            val_23 = val_5.m13 + 176;
            mem2[0] = mem[(val_5.m13 + 120) + (12)];
            mem2[0] = val_5.m13 + 148;
            mem2[0] = val_5.m13 + 144;
            mem2[0] = val_5.m13 + 140;
            if((val_5.m13 + 116) == 0)
            {
                    mem2[0] = mem[(val_5.m13 + 152) + (4)];
                mem2[0] = mem[(val_5.m13 + 152) + (8)];
                mem2[0] = mem[(val_5.m13 + 120) + (0)];
                mem2[0] = mem[(val_5.m13 + 120) + (4)];
                mem2[0] = mem[(val_5.m13 + 120) + (8)];
                mem2[0] = val_22;
                val_23 = val_23;
                val_22 = mem[val_5.m13 + 72];
                val_22 = val_5.m13 + 72;
                val_24 = mem[val_5.m13 + 76];
                val_24 = val_5.m13 + 76;
                val_25 = mem[val_5.m13 + 92];
                val_25 = val_5.m13 + 92;
            }
            
            mem2[0] = val_23;
            mem2[0] = 0;
            mem2[0] = val_5.m13 + 112;
            float val_12 = val_5.m13 + 16;
            mem2[0] = val_5.m13 + 164;
            mem2[0] = val_5.m13 + 168;
            mem2[0] = val_22;
            mem2[0] = val_5.m13 + 96;
            mem2[0] = val_5.m13 + 100;
            float val_13 = val_5.m32 - 48;
            val_13 = val_13 + 4;
        }
        private static UnityEngine.Matrix4x4 GetScissorRect(UnityEngine.Rect targetScissor, UnityEngine.Matrix4x4 camProjectionMatrix)
        {
            float val_4;
            float val_1 = targetScissor.m_YMin.width;
            float val_2 = targetScissor.m_YMin.height;
            UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
            float val_7 = targetScissor.m_YMin.width;
            float val_8 = targetScissor.m_YMin.height;
            uint val_24 = 1012537868;
            val_24 = 1f / val_24;
            UnityEngine.Matrix4x4 val_12 = UnityEngine.Matrix4x4.TRS(pos:  new UnityEngine.Vector3() {x = 0.01331181f, y = (1f / 1012537868) + (-1f), z = (1f / 1012537868) + (-1f)}, q:  new UnityEngine.Quaternion() {x = 0f}, s:  new UnityEngine.Vector3() {x = val_4, y = 1f / 1012537868, z = val_24});
            mem2[0] = val_12.m32 + -160;
            mem2[0] = val_12.m32 + -156;
            mem2[0] = val_12.m32 + -152;
            mem2[0] = val_12.m32 + -148;
            mem2[0] = val_12.m32 + -144;
            mem2[0] = val_12.m32 + -140;
            mem2[0] = val_12.m32 + -136;
            mem2[0] = val_12.m32 + -132;
            mem2[0] = val_12.m32 + -128;
            mem2[0] = val_12.m32 + -124;
            mem2[0] = val_12.m32 + -120;
            mem2[0] = val_12.m32 + -116;
            mem2[0] = val_12.m32 + -112;
            mem2[0] = val_12.m32 + -108;
            mem2[0] = val_12.m32 + -104;
            mem2[0] = val_12.m32 + -100;
            mem2[0] = val_12.m02;
            float val_13 = val_12.m32 - 160;
            float val_14 = val_12.m32 - 160;
            float val_15 = val_12.m32 - 160;
            float val_16 = val_12.m13 + 16;
            float val_25 = val_12.m02;
            float val_27 = val_12.m02;
            float val_28 = val_12.m02;
            mem2[0] = val_12.m32 + -152;
            mem2[0] = val_12.m32 + -148;
            val_25 = val_25 * (-2f);
            mem2[0] = 0;
            var val_26 = val_12.m13 + 136;
            float val_17 = val_12.m32 - 160;
            val_26 = val_26 * (-2f);
            val_27 = val_25 / val_27;
            val_28 = val_26 / val_28;
            float val_18 = val_12.m32 - 108;
            mem2[0] = val_12.m32 + -160;
            mem2[0] = val_12.m32 + -156;
            mem2[0] = val_12.m32 + -152;
            mem2[0] = val_12.m32 + -136;
            mem2[0] = val_12.m32 + -128;
            mem2[0] = val_12.m13 + 140;
            mem2[0] = val_12.m13 + 144;
            mem2[0] = val_12.m13 + 148;
            mem2[0] = val_12.m13 + 152;
            mem2[0] = val_12.m13 + 156;
            mem2[0] = val_12.m13 + 184;
            mem2[0] = val_12.m13 + 180;
            mem2[0] = val_12.m13 + 176;
            mem2[0] = val_12.m13 + 172;
            mem2[0] = val_12.m13 + 168;
            mem2[0] = val_12.m13 + 164;
            mem2[0] = val_12.m32 + -116;
            float val_19 = val_12.m13 + 40;
            mem2[0] = val_12.m13 + 160;
            float val_20 = val_12.m32 - 160;
            mem2[0] = val_12.m32 + -112;
            mem2[0] = val_12.m32 + -180;
            mem2[0] = val_12.m32 + -168;
            mem2[0] = val_12.m32 + -172;
            mem2[0] = val_12.m32 + -176;
            mem2[0] = val_12.m13 + 124;
            mem2[0] = val_12.m13 + 120;
            mem2[0] = 0;
            mem2[0] = val_12.m32 + -148;
            mem2[0] = val_12.m32 + -144;
            mem2[0] = val_12.m32 + -140;
            mem2[0] = val_12.m32 + -132;
            mem2[0] = val_12.m32 + -124;
            mem2[0] = val_12.m32 + -120;
            float val_21 = val_12.m32 - 124;
            mem2[0] = val_12.m32 + -160;
            mem2[0] = val_12.m32 + -156;
            mem2[0] = val_12.m32 + -152;
            mem2[0] = val_12.m32 + -136;
            mem2[0] = val_12.m32 + -132;
            mem2[0] = val_12.m32 + -128;
            mem2[0] = 0;
            mem2[0] = val_12.m32 + 68;
            mem2[0] = val_12.m32 + 64;
            mem2[0] = val_12.m32 + 60;
            mem2[0] = val_12.m32 + 56;
            mem2[0] = val_12.m32 + 52;
            mem2[0] = val_12.m32 + 48;
            mem2[0] = val_12.m32 + 44;
            mem2[0] = val_12.m32 + 40;
            mem2[0] = val_12.m32 + 36;
            mem2[0] = val_12.m32 + 32;
            mem2[0] = val_12.m32 + 28;
            mem2[0] = val_12.m32 + -100;
            mem2[0] = val_12.m32 + 24;
            mem2[0] = val_12.m32 + -180;
            mem2[0] = val_12.m32 + 20;
            mem2[0] = val_12.m13 + 184;
            mem2[0] = val_12.m32 + 16;
            mem2[0] = val_12.m32 + -104;
            float val_22 = val_12.m13 + 20;
            mem2[0] = val_12.m32 + 72;
            mem2[0] = val_12.m32 + 12;
            mem2[0] = val_12.m32 + -108;
            mem2[0] = val_12.m32 + -112;
            mem2[0] = mem[(val_12.m32 - 124) + (8)];
            mem2[0] = val_12.m32 + -148;
            mem2[0] = val_12.m32 + -144;
            mem2[0] = val_12.m32 + -140;
            float val_23 = val_12.m32 - 72;
            val_23 = val_23 + 4;
            return new UnityEngine.Matrix4x4() {m00 = mem[(val_12.m32 - 160) + (20) + (20) + (0)], m10 = mem[(val_12.m32 - 160) + (20) + (20) + (4)], m20 = mem[(val_12.m32 - 160) + (20) + (20) + (8)], m30 = mem[(val_12.m32 - 160) + (20) + (20) + (12)], m01 = mem[((val_12.m32 - 72) + 4) + (0)], m11 = mem[((val_12.m32 - 72) + 4) + (4)], m21 = mem[((val_12.m32 - 72) + 4) + (8)], m31 = mem[((val_12.m32 - 72) + 4) + (12)], m02 = mem[((val_12.m32 - 72) + 4) + (16)], m12 = mem[((val_12.m32 - 72) + 4) + (20)], m22 = mem[((val_12.m32 - 72) + 4) + (24)], m32 = mem[((val_12.m32 - 72) + 4) + (28)], m03 = mem[(val_12.m32 - 124) + (8)], m13 = ((val_12.m32 - 72) + 4) + (36), m23 = val_12.m32 + 72, m33 = mem[((val_12.m32 - 72) + 4) + (32)]};
        }
        private static void UpdateLetterPillarbox(UnityEngine.Camera cam, bool isPillarbox, float targetAspectRatio, float horizontalAlignment, float verticalAlignment)
        {
            float val_5;
            float val_6;
            float val_5 = (float)UnityEngine.Screen.width;
            val_5 = val_5 / (float)UnityEngine.Screen.height;
            if(isPillarbox != false)
            {
                    val_5 = R2 / val_5;
                val_5 = 1f;
                float val_6 = 0.5f;
                val_5 = val_5 - val_5;
                val_6 = val_5 * val_6;
                val_6 = val_5 - val_5;
            }
            else
            {
                    val_5 = val_5 / R2;
                val_5 = 1f;
                float val_7 = 0.5f;
                val_5 = val_5 - val_5;
                val_7 = val_5 * val_7;
                val_6 = val_5 - val_5;
            }
            
            UnityEngine.Rect val_4 = new UnityEngine.Rect(x:  val_6, y:  horizontalAlignment, width:  val_5, height:  null);
            cam.rect = new UnityEngine.Rect() {m_XMin = val_4.m_XMin, m_YMin = val_4.m_YMin, m_Width = val_4.m_Width, m_Height = val_4.m_Height};
        }
        private void ToggleLetterPillarboxing(bool value)
        {
            var val_15;
            var val_16;
            var val_15 = mem[536891407];
            val_15 = val_15 & 512;
            if(value != false)
            {
                    bool val_1 = UnityEngine.Object.op_Equality(x:  this._letterPillarboxingCamera, y:  0);
                if(val_1 == true)
            {
                    val_1 = this;
                this.CreateLetterPillarboxingCamera();
            }
            
                UnityEngine.GameObject val_2 = this._letterPillarboxingCamera.gameObject;
                this._letterPillarboxingCamera.SetActive(value:  true);
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
                val_15 = UnityEngine.Screen.width;
                float val_16 = (float)val_15;
                val_16 = val_16 / (float)UnityEngine.Screen.height;
                float val_17 = 0.5f;
                val_17 = this._targetHeight * val_17;
                val_16 = (this._targetWidth * val_17) / val_16;
                if(mem[536892213] > 0)
            {
                    val_16 = 1;
            }
            
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2DContentFitter.UpdateLetterPillarbox(cam:  1012794448, isPillarbox:  true, targetAspectRatio:  val_16, horizontalAlignment:  null, verticalAlignment:  val_17);
                return;
            }
            
            if(this._letterPillarboxingCamera != 0)
            {
                    UnityEngine.GameObject val_8 = this._letterPillarboxingCamera.gameObject;
                this._letterPillarboxingCamera.SetActive(value:  false);
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_9 = this.ProCamera2D;
            UnityEngine.Rect val_10 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            this.rect = new UnityEngine.Rect() {m_XMin = val_10.m_XMin, m_YMin = val_10.m_YMin, m_Width = val_10.m_Width, m_Height = val_10.m_Height};
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_11 = this.ProCamera2D;
            val_15 = UnityEngine.Screen.width;
            float val_18 = (float)val_15;
            val_18 = val_18 / (float)UnityEngine.Screen.height;
            float val_19 = 0.5f;
            val_19 = this._targetHeight * val_19;
            val_18 = (this._targetWidth * val_19) / val_18;
            if(mem[536892213] > 0)
            {
                    val_16 = 1;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DContentFitter.UpdateCameraAlignment(cam:  1012794448, isPillarbox:  true, targetAspectRatio:  val_18, horizontalAlignment:  null, verticalAlignment:  val_19);
        }
        private void CreateLetterPillarboxingCamera()
        {
            float val_5;
            System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073755429)});
            mem[536882545] = 1073755429;
            536887303 = new UnityEngine.GameObject(name:  -1610605517, components:  536882529);
            Weight val_3 = 536887303.GetComponent<Weight>();
            this._letterPillarboxingCamera = 536887303;
            this._letterPillarboxingCamera.depth = null;
            this._letterPillarboxingCamera.clearFlags = 2;
            UnityEngine.Color val_4 = UnityEngine.Color.black;
            this._letterPillarboxingCamera.backgroundColor = new UnityEngine.Color() {r = R6, g = R7, b = SL, a = val_5};
            this._letterPillarboxingCamera.cullingMask = 0;
            UnityEngine.Transform val_6 = this._letterPillarboxingCamera.transform;
            this._letterPillarboxingCamera.position = new UnityEngine.Vector3() {x = 10000f, y = 10000f, z = 10000f};
            UnityEngine.GameObject val_7 = this._letterPillarboxingCamera.gameObject;
            this._letterPillarboxingCamera.hideFlags = 1;
        }
        private UnityEngine.Vector3[] DrawGizmoRectangle(float x, float y, float width, float height, UnityEngine.Color fillColor, UnityEngine.Color borderColor)
        {
            var val_7;
            var val_9;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  x, y:  y, width:  width, height:  height);
            float val_2 = val_1.m_XMin.x;
            float val_3 = val_1.m_XMin.width;
            val_1.m_XMin.x = 1013018680;
            float val_4 = val_1.m_XMin.y;
            float val_5 = val_1.m_XMin.height;
            val_1.m_XMin.y = 1013018680;
            UnityEngine.Vector2 val_6 = position;
            UnityEngine.Vector2 val_8 = position;
            UnityEngine.Vector3 val_10 = Invoke(arg1:  val_8.x, arg2:  val_8.y, arg3:  1013018680);
            var val_11 = 536882597 + 16;
            UnityEngine.Vector2 val_12 = position;
            float val_13 = val_1.m_XMin.width;
            UnityEngine.Vector2 val_14 = position;
            UnityEngine.Vector3 val_16 = Invoke(arg1:  val_7 + 1013018680, arg2:  val_14.y, arg3:  val_10.z);
            var val_17 = 536882597 + 28;
            UnityEngine.Vector2 val_18 = position;
            float val_19 = val_1.m_XMin.width;
            UnityEngine.Vector2 val_20 = position;
            float val_21 = val_1.m_XMin.height;
            UnityEngine.Vector3 val_24 = Invoke(arg1:  val_7 + 1013018680, arg2:  val_20.y, arg3:  val_9 + 1013018680);
            var val_25 = 536882597 + 40;
            UnityEngine.Vector2 val_26 = position;
            UnityEngine.Vector2 val_27 = position;
            float val_28 = val_1.m_XMin.height;
            UnityEngine.Vector3 val_30 = Invoke(arg1:  val_9 + 1013018680, arg2:  val_27.y, arg3:  val_24.z);
            var val_31 = 536882597 + 52;
        }
        public ProCamera2DContentFitter()
        {
            this._targetHeight = 5.625f;
            this._targetWidth = 10f;
            this._targetAspectRatio = 1.777778f;
            this._soOrder = 5000;
        }
        private static ProCamera2DContentFitter()
        {
            mem2[0] = -1610609219;
        }
    
    }

}
