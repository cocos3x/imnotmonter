using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DPanAndZoom : BasePC2D, IPreMover
    {
        // Fields
        public static string ExtensionName;
        public System.Action OnPanStarted;
        public System.Action OnPanFinished;
        public bool AutomaticInputDetection;
        public bool UseMouseInput;
        public bool UseTouchInput;
        public bool DisableOverUGUI;
        public bool AllowZoom;
        public float MouseZoomSpeed;
        public float PinchZoomSpeed;
        public float ZoomSmoothness;
        public float MaxZoomInAmount;
        public float MaxZoomOutAmount;
        public bool ZoomToInputCenter;
        public bool IsZooming;
        private float _zoomAmount;
        private float _initialCamSize;
        private bool _zoomStarted;
        private float _origFollowSmoothnessX;
        private float _origFollowSmoothnessY;
        private float _prevZoomAmount;
        private float _zoomVelocity;
        private UnityEngine.Vector3 _zoomPoint;
        private float _touchZoomTime;
        public bool AllowPan;
        public bool UsePanByDrag;
        public float StopSpeedOnDragStart;
        public UnityEngine.Rect DraggableAreaRect;
        public UnityEngine.Vector2 DragPanSpeedMultiplier;
        public bool UsePanByMoveToEdges;
        public UnityEngine.Vector2 EdgesPanSpeed;
        public float TopPanEdge;
        public float BottomPanEdge;
        public float LeftPanEdge;
        public float RightPanEdge;
        public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DPanAndZoom.MouseButton PanMouseButton;
        public bool ResetPrevPanPoint;
        public bool IsPanning;
        private UnityEngine.Vector2 _panDelta;
        private UnityEngine.Transform _panTarget;
        private UnityEngine.Vector3 _prevMousePosition;
        private UnityEngine.Vector3 _prevTouchPosition;
        private int _prevTouchId;
        private bool _onMaxZoom;
        private bool _onMinZoom;
        private UnityEngine.EventSystems.EventSystem _eventSystem;
        private bool _skip;
        private int _prmOrder;
        
        // Properties
        public int PrMOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            if(this.AutomaticInputDetection != false)
            {
                    bool val_1 = UnityEngine.Input.touchSupported;
                val_1 = val_1 ^ 1;
                this.UseMouseInput = val_1;
                this.UseTouchInput = UnityEngine.Input.touchSupported;
            }
            
            this.UpdateCurrentFollowSmoothness();
            UnityEngine.EventSystems.EventSystem val_3 = UnityEngine.EventSystems.EventSystem.current;
            this._eventSystem = 0;
            536887303 = new UnityEngine.GameObject(name:  -1610605515);
            UnityEngine.Transform val_5 = 536887303.transform;
            this._panTarget = 536887303;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.ProCamera2D;
            this.AddPreMover(mover:  1019600464);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1019712464)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePreMover(mover:  R4);
        }
        private System.Collections.IEnumerator Start()
        {
            536900593 = new ProCamera2DPanAndZoom.<Start>d__50(<>1__state:  0);
            mem[536900609] = this;
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            float val_4 = 0.5f;
            val_4 = this.MaxZoomOutAmount * val_4;
            this._initialCamSize = val_4;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            Com.LuisPedroFonseca.ProCamera2D.CameraTarget val_3 = this.AddCameraTarget(targetTransform:  this._panTarget, targetInfluenceH:  val_4, targetInfluenceV:  null, duration:  this.MaxZoomOutAmount, targetOffset:  new UnityEngine.Vector2() {x = 1f, y = 1f});
            this.CenterPanTargetOnCamera(interpolant:  val_4);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            this.ResetPrevPanPoint = true;
            this._onMaxZoom = false;
            this._onMinZoom = false;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.RemoveCameraTarget(targetTransform:  this._panTarget, duration:  null);
        }
        public void PreMove(float deltaTime)
        {
            var val_16;
            var val_17;
            bool val_18;
            var val_19;
            var val_20;
            var val_21;
            val_16 = this;
            val_17 = R1;
            if(this.UseTouchInput == false)
            {
                goto label_12;
            }
            
            if(this.DisableOverUGUI == false)
            {
                goto label_2;
            }
            
            val_18 = false;
            bool val_1 = UnityEngine.Object.op_Implicit(exists:  this._eventSystem);
            this._skip = val_1;
            if(val_1 == false)
            {
                goto label_12;
            }
            
            this._skip = val_18;
            if(UnityEngine.Input.touchCount < 1)
            {
                goto label_6;
            }
            
            label_9:
            UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  1020172864);
            if(val_3.m_TimeDelta != 0f)
            {
                goto label_8;
            }
            
            val_18 = val_3.m_PositionDelta.y + 1;
            if(val_18 < 0)
            {
                goto label_9;
            }
            
            label_6:
            if((val_3.m_PositionDelta.x + 244) != 0)
            {
                goto label_10;
            }
            
            goto label_12;
            label_2:
            this._skip = false;
            goto label_12;
            label_8:
            mem2[0] = 1;
            label_10:
            float val_4 = val_3.m_Radius + 16;
            mem2[0] = val_3.m_TapCount;
            float val_5 = val_3.m_Radius + 88;
            float val_6 = val_3.m_Radius + 16;
            float val_7 = val_3.m_Radius + 16;
            mem2[0] = val_3.m_Radius + 16;
            float val_8 = val_3.m_Radius + 16;
            val_20 = mem[val_3.m_PositionDelta.x + 24];
            val_20 = val_3.m_PositionDelta.x + 24;
            float val_9 = val_3.m_Radius + 16;
            val_21 = 0;
            val_18 = mem[val_3.m_Radius + 16];
            val_18 = val_3.m_Radius + 16;
            val_19 = mem[val_3.m_Radius + 20];
            val_19 = val_3.m_Radius + 20;
            mem2[0] = -1073723003;
            var val_14 = val_20;
            val_14 = val_14 & (~2147483648);
            mem2[0] = val_3.m_Radius + 8;
            mem2[0] = val_3.m_Radius + 20;
            val_17 = mem[val_3.m_Radius + 12];
            val_17 = val_3.m_Radius + 12;
            mem2[0] = val_14;
            mem2[0] = val_21;
            mem2[0] = val_21;
            mem2[0] = val_21;
            label_12:
            if((val_3.m_PositionDelta.x + 53) == 0)
            {
                goto label_24;
            }
            
            if(((val_3.m_PositionDelta.x + 55) == 0) || ((val_3.m_PositionDelta.x + 240) == 0))
            {
                goto label_19;
            }
            
            mem2[0] = val_3.m_PositionDelta.x + 240;
            if((val_3.m_PositionDelta.x + 240) == 0)
            {
                goto label_24;
            }
            
            float val_10 = val_3.m_Radius + 16;
            mem2[0] = val_17;
            mem2[0] = val_3.m_Radius + 16;
            float val_11 = val_3.m_Radius + 16;
            val_20 = mem[val_3.m_PositionDelta.x + 24];
            val_20 = val_3.m_PositionDelta.x + 24;
            float val_12 = val_3.m_Radius + 16;
            val_21 = 0;
            val_18 = mem[val_3.m_Radius + 16];
            val_18 = val_3.m_Radius + 16;
            val_19 = mem[val_3.m_Radius + 20];
            val_19 = val_3.m_Radius + 20;
            mem2[0] = -1073723003;
            var val_15 = val_20;
            val_15 = val_15 & (~2147483648);
            mem2[0] = val_3.m_Radius + 8;
            mem2[0] = val_3.m_Radius + 20;
            val_17 = mem[val_3.m_Radius + 12];
            val_17 = val_3.m_Radius + 12;
            mem2[0] = val_15;
            mem2[0] = val_21;
            mem2[0] = val_21;
            mem2[0] = val_21;
            goto label_24;
            label_19:
            mem2[0] = 0;
            label_24:
            mem2[0] = 0;
            if((val_3.m_PositionDelta.x + 193) != 0)
            {
                    val_3.m_PositionDelta.x + 193 = mem[val_3.m_PositionDelta.x + 48];
                val_3.m_PositionDelta.x + 193 = val_3.m_PositionDelta.x + 48;
            }
            
            mem2[0] = 0;
            if(val_3.m_PositionDelta.x != 0f)
            {
                    val_3.m_PositionDelta.x = mem[val_3.m_PositionDelta.x + 128];
                val_3.m_PositionDelta.x = val_3.m_PositionDelta.x + 128;
            }
            
            if(val_3.m_PositionDelta.x != 0)
            {
                goto label_26;
            }
            
            label_29:
            if(val_3.m_PositionDelta.x != 0f)
            {
                    val_3.m_PositionDelta.x = mem[val_3.m_PositionDelta.x + 56];
                val_3.m_PositionDelta.x = val_3.m_PositionDelta.x + 56;
            }
            
            if(val_3.m_PositionDelta.x != 0)
            {
                goto label_27;
            }
            
            label_31:
            float val_13 = val_3.m_Pressure - 28;
            return;
            label_26:
            if((val_3.m_PositionDelta.x + 244) != 0)
            {
                goto label_29;
            }
            
            goto label_29;
            label_27:
            if((val_3.m_PositionDelta.x + 244) != 0)
            {
                goto label_31;
            }
            
            goto label_31;
        }
        public int get_PrMOrder()
        {
            return (int)this._prmOrder;
        }
        public void set_PrMOrder(int value)
        {
            this._prmOrder = value;
        }
        private void Pan(float deltaTime)
        {
            UnityEngine.Vector2 val_2;
            var val_3;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            float val_99;
            var val_100;
            val_95 = this;
            val_96 = R1;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            val_97 = val_95;
            this._panDelta = val_2;
            mem[1152921509922343704] = val_3;
            if(this.UseTouchInput == false)
            {
                goto label_10;
            }
            
            float val_4 = UnityEngine.Time.time;
            float val_92 = this._touchZoomTime;
            val_92 = 0 - val_92;
            if(this.UseTouchInput >= 0)
            {
                goto label_2;
            }
            
            if(UnityEngine.Input.touchCount < 1)
            {
                goto label_113;
            }
            
            UnityEngine.Touch val_6 = UnityEngine.Input.GetTouch(index:  1020516960);
            float val_7 = val_6.m_Pressure - 152;
            float val_8 = val_6.m_Radius + 32;
            float val_9 = val_6.m_Radius + 32;
            mem2[0] = val_6.m_Radius + 32;
            float val_10 = val_6.m_Radius + 32;
            val_97 = mem[val_6.m_Radius + 36];
            val_97 = val_6.m_Radius + 36;
            val_98 = mem[val_6.m_Phase + 24];
            val_98 = val_6.m_Phase + 24;
            float val_11 = val_6.m_Radius + 32;
            val_96 = mem[val_6.m_Radius + 32];
            val_96 = val_6.m_Radius + 32;
            val_99 = mem[val_6.m_Radius + 36];
            val_99 = val_6.m_Radius + 36;
            mem2[0] = -1073723003;
            var val_93 = val_98;
            val_93 = val_93 & (~2147483648);
            mem2[0] = val_6.m_Radius + 28;
            mem2[0] = val_97;
            mem2[0] = val_93;
            goto label_113;
            label_2:
            if(this.AllowZoom == false)
            {
                goto label_7;
            }
            
            if(UnityEngine.Input.touchCount == 1)
            {
                goto label_8;
            }
            
            if(this.AllowZoom == true)
            {
                goto label_10;
            }
            
            label_7:
            if(UnityEngine.Input.touchCount < 1)
            {
                goto label_10;
            }
            
            label_8:
            int val_15 = UnityEngine.Input.touchCount - 1;
            UnityEngine.Touch val_16 = UnityEngine.Input.GetTouch(index:  1020516960);
            if((val_16.m_Radius + 120) != 0f)
            {
                
            }
            else
            {
                    mem2[0] = val_16.m_PositionDelta.y;
                val_98 = val_16.m_Phase;
                mem2[0] = val_16.m_Radius + 120;
                float val_19 = val_16.m_Radius + 32;
                mem2[0] = val_16.m_Radius + 32;
                float val_20 = val_16.m_Radius + 32;
                mem2[0] = val_16.m_Radius + 36;
                mem2[0] = val_16.m_Phase;
                float val_21 = val_16.m_Radius + 32;
                val_99 = mem[val_16.m_Radius + 32];
                val_99 = val_16.m_Radius + 32;
                mem2[0] = -1073723003;
                var val_94 = val_16.m_Phase + 24;
                val_95 = mem[val_16.m_Radius + 28];
                val_95 = val_16.m_Radius + 28;
                val_94 = val_94 & (~2147483648);
                mem2[0] = val_16.m_Radius + 24;
                mem2[0] = val_16.m_Radius + 20;
                mem2[0] = val_94;
                val_96 = mem[val_16.m_Radius + 12];
                val_96 = val_16.m_Radius + 12;
            }
            
            if(((val_16.m_Radius + 120) != (val_16.m_Phase + 232)) || ((val_16.m_Radius + 120) != (1.401298E-45f)))
            {
                goto label_113;
            }
            
            float val_24 = val_16.m_Radius + 120;
            float val_25 = val_16.m_Radius + 32;
            mem2[0] = val_96;
            mem2[0] = val_16.m_Radius + 32;
            float val_26 = val_16.m_Radius + 32;
            mem2[0] = val_16.m_Radius + 36;
            val_98 = val_95;
            float val_27 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            float val_95 = val_16.m_Radius + 28 + 24;
            float val_28 = val_16.m_Radius + 32;
            float val_29 = val_16.m_Radius + 120;
            float val_30 = val_16.m_Radius + 32;
            float val_31 = val_16.m_Radius + 120;
            val_95 = val_98;
            val_95 = val_95 & (~2147483648);
            mem2[0] = 0;
            if((val_16.m_Radius + 104) != 0f)
            {
                    float val_33 = (val_16.m_Radius + 32) / ((float)val_16.m_Radius + 28 + 192);
                float val_34 = (val_16.m_Radius + 36) / ((float)val_16.m_Radius + 28 + 192);
                if(val_95 != 0)
            {
                    if((val_16.m_Radius + 28 + 192) == 0)
            {
                    mem2[0] = val_16.m_Radius + 28 + 224;
            }
            
                mem2[0] = 0;
                float val_35 = val_16.m_Radius + 32;
                mem2[0] = val_16.m_Radius + 28 + 228;
                if((val_16.m_Radius + 28 + 192) != 0)
            {
                    float val_36 = val_16.m_Radius + 32;
                mem2[0] = 0;
            }
            
                mem2[0] = 0;
                float val_37 = val_16.m_Radius + 32;
                mem2[0] = val_95;
                var val_96 = val_16.m_Radius + 32;
                var val_97 = val_16.m_Radius + 36;
                var val_98 = val_16.m_Radius + 40;
                val_96 = (val_16.m_Radius + 32) - val_96;
                val_97 = (val_16.m_Radius + 36) - val_97;
                val_98 = (val_16.m_Radius + 40) - val_98;
                val_99 = val_97;
                mem2[0] = -1073723003;
                mem2[0] = -1073723003;
                val_95 = val_98;
                mem2[0] = val_16.m_Radius + 28 + 16;
                mem2[0] = val_16.m_Radius + 28 + 20;
            }
            
            }
            
            mem2[0] = val_16.m_Radius + 24;
            val_96 = mem[val_16.m_Radius + 12];
            val_96 = val_16.m_Radius + 12;
            mem2[0] = val_16.m_Radius + 28;
            mem2[0] = val_95;
            label_10:
            if((val_16.m_Radius + 28 + 53) == 0)
            {
                goto label_37;
            }
            
            float val_38 = val_16.m_Radius + 32;
            mem2[0] = val_16.m_Radius + 28 + 156;
            mem2[0] = val_16.m_Radius + 28 + 152;
            mem2[0] = val_96;
            mem2[0] = val_16.m_Radius + 32;
            float val_39 = val_16.m_Radius + 32;
            mem2[0] = val_16.m_Radius + 36;
            float val_40 = val_16.m_Radius + 32;
            float val_41 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            val_99 = (val_16.m_Radius + 28 + 24) & (~2147483648);
            val_95 = val_95;
            if(((val_16.m_Radius + 28 + 129) == 0) || ((val_16.m_Radius + 28 + 188) == 0))
            {
                goto label_43;
            }
            
            float val_42 = val_16.m_Radius + 32;
            val_98 = mem[val_16.m_Radius + 24];
            val_98 = val_16.m_Radius + 24;
            float val_43 = val_16.m_Radius + 32;
            val_96 = 0;
            mem2[0] = val_96;
            if((val_16.m_Radius + 104) == 0f)
            {
                goto label_59;
            }
            
            float val_45 = (val_16.m_Radius + 32) / ((float)val_16.m_Radius + 28 + 192);
            float val_46 = (val_16.m_Radius + 36) / ((float)val_16.m_Radius + 28 + 192);
            if(val_95 == 0)
            {
                goto label_59;
            }
            
            mem2[0] = 0;
            float val_47 = val_16.m_Radius + 32;
            mem2[0] = val_16.m_Radius + 28 + 216;
            if((val_16.m_Radius + 28 + 192) == 0)
            {
                goto label_54;
            }
            
            val_98 = mem[val_16.m_Radius + 24];
            val_98 = val_16.m_Radius + 24;
            float val_48 = val_16.m_Radius + 32;
            mem2[0] = val_99;
            mem2[0] = 0;
            mem2[0] = 0;
            goto label_57;
            label_43:
            val_98 = mem[val_16.m_Radius + 24];
            val_98 = val_16.m_Radius + 24;
            if(((val_16.m_Radius + 28 + 160) == 0) || ((val_16.m_Radius + 28 + 188) != 0))
            {
                goto label_59;
            }
            
            val_99 = 0;
            float val_49 = val_16.m_Radius + 32;
            var val_99 = val_16.m_Radius + 32;
            val_96 = 0;
            float val_50 = val_16.m_Radius + 32;
            val_99 = val_99 / 0f;
            if((val_16.m_Radius + 28 + 188) >= 0)
            {
                goto label_60;
            }
            
            float val_100 = -0.5f;
            mem2[0] = val_99;
            mem2[0] = val_99;
            val_100 = (val_16.m_Radius + 28 + 180) * val_100;
            goto label_61;
            label_60:
            if((val_16.m_Radius + 28 + 188) <= 0)
            {
                goto label_62;
            }
            
            var val_101 = val_16.m_Radius + 28 + 184;
            val_101 = val_101 * 0.5f;
            mem2[0] = 1056964608;
            mem2[0] = 0;
            label_61:
            label_62:
            if((val_16.m_Radius + 28 + 188) >= 0)
            {
                goto label_63;
            }
            
            float val_102 = -0.5f;
            mem2[0] = 0;
            mem2[0] = 0;
            val_102 = (val_16.m_Radius + 28 + 176) * val_102;
            goto label_64;
            label_63:
            if((val_16.m_Radius + 28 + 188) <= 0)
            {
                goto label_65;
            }
            
            var val_103 = val_16.m_Radius + 28 + 172;
            val_103 = val_103 * 0.5f;
            mem2[0] = 1056964608;
            mem2[0] = 0;
            label_64:
            label_65:
            float val_53 = val_16.m_Radius + 32;
            mem2[0] = val_99 * (val_16.m_Radius + 12);
            mem2[0] = ((val_16.m_Radius + 36) / 0f) * (val_16.m_Radius + 12);
            var val_104 = val_16.m_Radius + 36;
            var val_105 = val_16.m_Radius + 32;
            val_104 = (val_16.m_Type + 4) - val_104;
            val_105 = val_16.m_Type - val_105;
            val_104 = val_104 * val_104;
            if((val_16.m_Radius + 28 + 188) >= 0)
            {
                    val_16.m_Radius + 20 = mem[val_16.m_Radius + 28 + 164];
                val_16.m_Radius + 20 = val_16.m_Radius + 28 + 164;
                val_16.m_Radius + 16 = mem[val_16.m_Radius + 28 + 168];
                val_16.m_Radius + 16 = val_16.m_Radius + 28 + 168;
            }
            
            goto label_66;
            label_54:
            val_98 = mem[val_16.m_Radius + 24];
            val_98 = val_16.m_Radius + 24;
            label_57:
            mem2[0] = 0;
            float val_55 = val_16.m_Radius + 32;
            mem2[0] = val_99;
            var val_106 = val_16.m_Radius + 32;
            var val_107 = val_16.m_Radius + 36;
            var val_108 = val_16.m_Radius + 40;
            val_106 = (val_16.m_Radius + 32) - val_106;
            val_107 = (val_16.m_Radius + 36) - val_107;
            val_108 = (val_16.m_Radius + 40) - val_108;
            val_99 = val_106;
            val_96 = val_107;
            mem2[0] = -1073723003;
            mem2[0] = -1073723003;
            mem2[0] = val_16.m_Radius + 28 + 16;
            mem2[0] = val_16.m_Radius + 28 + 20;
            label_59:
            label_66:
            mem2[0] = val_98;
            mem2[0] = val_16.m_Radius + 28;
            mem2[0] = val_99;
            label_37:
            float val_56 = val_16.m_Radius + 32;
            var val_109 = val_16.m_Radius + 36;
            var val_110 = val_16.m_Radius + 32;
            val_109 = (val_16.m_Type + 4) - val_109;
            val_110 = val_16.m_Type - val_110;
            val_109 = val_109 * val_109;
            if((val_16.m_Radius + 28 + 20) >= 0)
            {
                    float val_57 = (val_16.m_Radius + 28 + 196) * (val_16.m_Radius + 20);
                float val_58 = (val_16.m_Radius + 28 + 200) * (val_16.m_Radius + 16);
                mem2[0] = -1073722879;
                float val_59 = val_16.m_Radius + 32;
                float val_60 = val_16.m_Radius + 32;
                mem2[0] = 0;
                mem2[0] = 1;
            }
            
            if((val_16.m_Radius + 28 + 188) == 0)
            {
                goto label_77;
            }
            
            float val_61 = val_16.m_Radius + 32;
            val_98 = 22732340;
            mem2[0] = -1073723003;
            float val_62 = val_16.m_Radius + 32;
            float val_63 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            if((val_16.m_Radius + 28 + 16) < 0)
            {
                goto label_82;
            }
            
            label_77:
            if((val_16.m_Radius + 28 + 189) == 0)
            {
                goto label_89;
            }
            
            float val_64 = val_16.m_Radius + 32;
            float val_65 = val_16.m_Radius + 32;
            val_98 = 22732340;
            mem2[0] = -1073723003;
            float val_66 = val_16.m_Radius + 32;
            float val_67 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            if((val_16.m_Radius + 28 + 16) <= 0)
            {
                goto label_89;
            }
            
            label_82:
            mem2[0] = val_16.m_Radius + 28 + 32;
            mem2[0] = val_16.m_Radius + 28 + 204;
            float val_68 = val_16.m_Radius + 32;
            float val_69 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            mem2[0] = val_16.m_Radius + 28 + 16;
            mem2[0] = val_95;
            float val_70 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            mem2[0] = val_95;
            float val_71 = val_16.m_Radius + 32;
            float val_72 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            mem2[0] = val_16.m_Radius + 28 + 24;
            mem2[0] = -1073722831;
            float val_73 = val_16.m_Radius + 32;
            float val_74 = val_16.m_Radius + 32;
            val_99 = mem[val_16.m_Radius + 24];
            val_99 = val_16.m_Radius + 24;
            val_95 = mem[val_16.m_Radius + 28];
            val_95 = val_16.m_Radius + 28;
            mem2[0] = 0;
            label_89:
            if((val_16.m_Radius + 28 + 191) == 0)
            {
                goto label_101;
            }
            
            float val_75 = val_16.m_Radius + 32;
            float val_76 = val_16.m_Radius + 32;
            val_98 = 22732340;
            mem2[0] = -1073723003;
            val_100 = mem[val_16.m_Radius + 28 + 20];
            val_100 = val_16.m_Radius + 28 + 20;
            float val_77 = val_16.m_Radius + 32;
            float val_78 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            if(val_100 < 0)
            {
                goto label_106;
            }
            
            label_101:
            if((val_16.m_Radius + 28 + 190) == 0)
            {
                goto label_113;
            }
            
            float val_79 = val_16.m_Radius + 32;
            float val_80 = val_16.m_Radius + 32;
            val_98 = 22732340;
            mem2[0] = -1073723003;
            val_100 = mem[val_16.m_Radius + 28 + 20];
            val_100 = val_16.m_Radius + 28 + 20;
            float val_81 = val_16.m_Radius + 32;
            float val_82 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            if(val_100 <= 0)
            {
                goto label_113;
            }
            
            label_106:
            val_97 = mem[val_16.m_Radius + 28 + 204];
            val_97 = val_16.m_Radius + 28 + 204;
            mem2[0] = val_16.m_Radius + 28 + 32;
            float val_83 = val_16.m_Radius + 32;
            float val_84 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            mem2[0] = val_16.m_Radius + 28 + 16;
            float val_85 = val_16.m_Radius + 32;
            float val_86 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            val_99 = val_16.m_Radius + 28 + 20;
            float val_87 = val_16.m_Radius + 32;
            float val_88 = val_16.m_Radius + 32;
            mem2[0] = -1073723003;
            mem2[0] = val_16.m_Radius + 28 + 24;
            mem2[0] = -1073722831;
            float val_89 = val_16.m_Radius + 32;
            float val_90 = val_16.m_Radius + 32;
            mem2[0] = 0;
            label_113:
            float val_91 = val_16.m_Pressure - 80;
            val_91 = val_91 + 4;
        }
        private void Zoom(float deltaTime)
        {
            float val_27;
            float val_29;
            float val_32;
            var val_55;
            float val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            float val_62;
            float val_63;
            val_55 = this;
            val_56 = 0f;
            if(this.UseTouchInput != false)
            {
                    if(UnityEngine.Input.touchCount == 2)
            {
                    UnityEngine.Touch val_2 = UnityEngine.Input.GetTouch(index:  1020641240);
                float val_3 = val_2.m_Pressure - 168;
                float val_4 = val_2.m_Radius + 24;
                float val_5 = val_2.m_Radius + 120;
                float val_6 = val_2.m_Radius + 24;
                float val_7 = val_2.m_Radius + 24;
                float val_8 = val_2.m_Radius + 24;
                float val_9 = val_2.m_Radius + 24;
                float val_10 = val_2.m_Radius + 24;
                float val_11 = val_2.m_Radius + 24;
                float val_13 = (val_2.m_Radius + 24) / 0f;
                float val_52 = 0f;
                float val_15 = (val_2.m_Radius + 28) / 0f;
                val_52 = (val_2.m_Radius + 28) / val_52;
                val_13 = (val_2.m_Radius + 24) - val_13;
                val_58 = (val_2.m_Radius + 24) - ((val_2.m_Radius + 24) / 0f);
                val_15 = (val_2.m_Radius + 28) - val_15;
                val_52 = (val_2.m_Radius + 28) - val_52;
                val_13 = val_13 - val_58;
                val_52 = val_15 - val_52;
                mem2[0] = val_13;
                mem2[0] = val_52;
                float val_16 = val_2.m_Radius + 24;
                float val_17 = val_2.m_Radius + 24;
                float val_53 = val_2.m_Radius + 24;
                float val_54 = val_2.m_Radius + 28;
                val_53 = (val_2.m_Radius + 24) - val_53;
                val_54 = (val_2.m_Radius + 28) - val_54;
                mem2[0] = val_53;
                mem2[0] = val_54;
                float val_18 = val_2.m_Radius + 24;
                float val_19 = val_2.m_Radius + 24;
                float val_20 = (val_2.m_Radius + 24) - (val_2.m_Radius + 24);
                float val_21 = (val_2.m_Radius + 28) - (val_2.m_Radius + 28);
                float val_22 = val_2.m_Radius + 24;
                float val_23 = val_2.m_Radius + 24;
                mem2[0] = -1073723003;
                var val_55 = val_2.m_Type + 24;
                mem2[0] = val_2.m_Radius + 24;
                val_55 = val_55 & (~2147483648);
                mem2[0] = val_2.m_Radius + 28;
                mem2[0] = val_55;
                if((val_2.m_Type + 92) == 0)
            {
                    mem2[0] = 1;
                float val_24 = val_2.m_Radius + 24;
                var val_56 = val_2.m_Type + 132;
                var val_57 = val_2.m_Type + 136;
                val_56 = (val_2.m_Radius + 24) - val_56;
                val_57 = (val_2.m_Radius + 28) - val_57;
                val_58 = (val_2.m_Radius + 32) - (val_2.m_Type + 140);
                mem2[0] = 0;
            }
            
                val_56 = (val_2.m_Radius + 112) - (val_2.m_Radius + 112);
                mem2[0] = 0;
                val_57 = val_2.m_Radius + 96;
            }
            else
            {
                    if(this._zoomStarted != false)
            {
                    float val_58 = System.Math.Abs(this._zoomAmount);
                if(this._zoomStarted < 0)
            {
                    this.RestoreFollowSmoothness();
                this._zoomStarted = false;
            }
            
            }
            
            }
            
            }
            
            if(this.UseMouseInput != false)
            {
                    float val_25 = UnityEngine.Input.GetAxis(axisName:  -1610606235);
                val_59 = -1610606235;
                UnityEngine.Vector3 val_26 = UnityEngine.Input.mousePosition;
                UnityEngine.Vector3 val_28 = UnityEngine.Input.mousePosition;
                val_60 = val_29;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_30 = this.ProCamera2D;
                UnityEngine.Vector3 val_31 = LocalPosition;
                val_56 = 2684361061;
                var val_59 = R6;
                float val_33 = val_59.Invoke(arg:  new UnityEngine.Vector3() {x = val_27, y = val_29, z = val_32});
                this._zoomPoint = val_27;
                val_59 = val_59 & (~2147483648);
                mem[1152921509922467908] = val_60;
                mem[1152921509922467912] = val_59;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_34 = this.ProCamera2D;
            UnityEngine.Rect val_35 = pixelRect;
            if((Contains(point:  new UnityEngine.Vector3() {x = mem[this._zoomPoint + (0)], y = mem[this._zoomPoint + (4)], z = mem[this._zoomPoint + (8)]})) == false)
            {
                    return;
            }
            
            if(this.UseTouchInput != false)
            {
                    val_62 = this.PinchZoomSpeed * 10f;
            }
            else
            {
                    val_62 = this.MouseZoomSpeed;
            }
            
            val_62 = val_56 * val_62;
            if(this._onMaxZoom != false)
            {
                    if(this._onMaxZoom < 0)
            {
                goto label_21;
            }
            
            }
            
            if((this._onMaxZoom > false) && (this._onMinZoom != false))
            {
                    label_21:
                this._zoomAmount = 0f;
                this._prevZoomAmount = 0f;
                this._zoomVelocity = 0f;
                return;
            }
            
            float val_37 = this._prevZoomAmount;
            val_62 = val_62 * (???);
            float val_38 = UnityEngine.Mathf.SmoothDamp(current:  val_62, target:  val_35.m_YMin, currentVelocity: ref  val_37, smoothTime:  ???, maxSpeed:  val_35.m_Height, deltaTime:  null);
            this._zoomAmount = val_37;
            if(this.UseMouseInput == false)
            {
                goto label_26;
            }
            
            float val_60 = System.Math.Abs(val_37);
            if(this.UseMouseInput <= false)
            {
                goto label_25;
            }
            
            if(this._zoomStarted != true)
            {
                    this._zoomStarted = true;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_39 = this.ProCamera2D;
                UnityEngine.Vector3 val_40 = LocalPosition;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_41 = val_55.ProCamera2D;
                float val_61 = this.StopSpeedOnDragStart;
                UnityEngine.Rect val_62 = this.DraggableAreaRect;
                val_61 = val_27 - val_61;
                val_62 = val_29 - val_62;
                this._panTarget.position = new UnityEngine.Vector3() {x = val_61, y = val_62, z = val_32 - S4};
                this.UpdateCurrentFollowSmoothness();
                this.RemoveFollowSmoothness();
            }
            
            label_26:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_43 = this.ProCamera2D;
            float val_64 = this._zoomAmount;
            float val_63 = this.MaxZoomOutAmount;
            this._onMaxZoom = false;
            this._onMinZoom = false;
            if(val_55 >= 0)
            {
                goto label_31;
            }
            
            val_63 = val_64 - (this._initialCamSize / this.MaxZoomInAmount);
            this._onMaxZoom = true;
            goto label_32;
            label_31:
            val_63 = this._initialCamSize * val_63;
            if(val_55 <= 0)
            {
                goto label_33;
            }
            
            val_63 = val_64 - val_63;
            this._onMinZoom = true;
            label_32:
            val_64 = val_64 - val_63;
            this._zoomAmount = val_64;
            label_33:
            this._prevZoomAmount = val_64;
            if(this.ZoomToInputCenter != false)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_45 = val_55.ProCamera2D;
                UnityEngine.Vector3 val_46 = position;
                UnityEngine.Vector3 val_48 = position;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_49 = this.ProCamera2D;
                val_64 = val_64 / (this.MaxZoomOutAmount * 0.5f);
                UnityEngine.Vector3 val_50 = ScreenToWorldPoint(position:  new UnityEngine.Vector3() {x = this.ResetPrevPanPoint, y = this._zoomPoint, z = val_61});
                var val_65 = val_29;
                var val_66 = val_32;
                val_63 = val_27 - val_27;
                val_65 = val_29 - val_65;
                val_66 = val_32 - val_66;
                this._panTarget.position = new UnityEngine.Vector3() {x = val_27, y = val_29, z = val_32};
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_51 = this.ProCamera2D;
            this.Zoom(zoomAmount:  val_63, duration:  val_50.y, easeType:  this._zoomAmount);
            this.IsZooming = true;
            return;
            label_25:
            if(this._zoomStarted == true)
            {
                    this._zoomStarted = val_55;
                this.RestoreFollowSmoothness();
            }
            
            this._prevZoomAmount = 0f;
            this._zoomStarted = 0f;
        }
        public void UpdateCurrentFollowSmoothness()
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this._origFollowSmoothnessX = this;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            this._origFollowSmoothnessY = this;
        }
        public void CenterPanTargetOnCamera(float interpolant = 1)
        {
            float val_3;
            float val_4;
            float val_5;
            float val_23 = this;
            if(this._panTarget == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_2 = position;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = val_23.ProCamera2D;
            UnityEngine.Vector3 val_7 = LocalPosition;
            float val_8 = SL.Invoke(arg:  new UnityEngine.Vector3() {x = val_3, y = val_4, z = val_5});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_9 = val_23.ProCamera2D;
            float val_10 = this.GetOffsetX();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_11 = val_23.ProCamera2D;
            UnityEngine.Vector3 val_12 = LocalPosition;
            float val_13 = this.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = SB, z = SL});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_14 = val_23.ProCamera2D;
            float val_15 = this.GetOffsetY();
            float val_17 = 1020898000 - 1020898000;
            UnityEngine.Vector3 val_18 = Invoke(arg1:  SL - 1020898000, arg2:  val_12.y);
            float val_19 = UnityEngine.Mathf.Clamp01(value:  val_18.x);
            float val_20 = val_5 - val_5;
            float val_21 = val_4 - val_4;
            float val_22 = val_3 - val_3;
            val_23 = val_3;
            this._panTarget.position = new UnityEngine.Vector3() {x = val_23, y = val_4, z = val_5};
        }
        private void CancelZoom()
        {
            this._zoomAmount = 0f;
            this._prevZoomAmount = 0f;
            this._zoomVelocity = 0f;
        }
        private void RestoreFollowSmoothness()
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            mem[1152921509922944496] = this._origFollowSmoothnessX;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            mem[1152921509922944504] = this._origFollowSmoothnessY;
        }
        private void RemoveFollowSmoothness()
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            mem[1152921509923056496] = 0;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            mem[1152921509923056504] = 0;
        }
        private bool InsideDraggableArea(UnityEngine.Vector2 normalizedInput)
        {
            var val_15;
            var val_16;
            var val_17;
            val_15 = normalizedInput.x;
            float val_1 = this.DraggableAreaRect.x;
            if()
            {
                    float val_2 = this.DraggableAreaRect.y;
                if()
            {
                    float val_3 = this.DraggableAreaRect.width;
                if()
            {
                    float val_4 = this.DraggableAreaRect.height;
                val_16 = 1;
                if()
            {
                    return (bool)val_16;
            }
            
            }
            
            }
            
            }
            
            float val_5 = this.DraggableAreaRect.x;
            val_17 = this.DraggableAreaRect;
            float val_6 = this.DraggableAreaRect.width;
            UnityEngine.Rect val_15 = this.DraggableAreaRect;
            val_15 = 1f - val_15;
            if(<0)
            {
                    float val_7 = this.DraggableAreaRect.x;
                val_15 = this.DraggableAreaRect;
                float val_8 = this.DraggableAreaRect.width;
                val_17 = this.DraggableAreaRect;
                float val_9 = this.DraggableAreaRect.width;
                UnityEngine.Rect val_16 = this.DraggableAreaRect;
                var val_17 = val_15;
                val_16 = 1f - val_16;
                val_17 = val_17 + val_17;
                if()
            {
                    float val_10 = this.DraggableAreaRect.y;
                val_15 = this.DraggableAreaRect;
                float val_11 = this.DraggableAreaRect.height;
                UnityEngine.Rect val_18 = this.DraggableAreaRect;
                val_18 = 1f - val_18;
                if(<0)
            {
                    float val_12 = this.DraggableAreaRect.y;
                float val_13 = this.DraggableAreaRect.height;
                val_15 = this.DraggableAreaRect;
                float val_14 = this.DraggableAreaRect.height;
                UnityEngine.Rect val_19 = this.DraggableAreaRect;
                UnityEngine.Rect val_20 = this.DraggableAreaRect;
                val_19 = 1f - val_19;
                val_20 = val_20 + val_15;
                if()
            {
                    val_16 = 0;
            }
            
                return (bool)val_16;
            }
            
            }
            
            }
            
            val_16 = 0;
            return (bool)val_16;
        }
        public ProCamera2DPanAndZoom()
        {
            this.AutomaticInputDetection = true;
            this.DisableOverUGUI = true;
            this.AllowZoom = true;
            this.MaxZoomOutAmount = 2f;
            this.ZoomToInputCenter = true;
            this.AllowPan = true;
            this.UsePanByDrag = true;
            this.StopSpeedOnDragStart = 0.95f;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            this.DragPanSpeedMultiplier = 1065353216;
            mem[1152921509923280620] = 1065353216;
            this.EdgesPanSpeed = 2f;
            mem[1152921509923280632] = 2f;
        }
        private static ProCamera2DPanAndZoom()
        {
            mem2[0] = -1610605463;
        }
    
    }

}
