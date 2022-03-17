using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DNumericBoundaries : BasePC2D, IPositionDeltaChanger, ISizeOverrider
    {
        // Fields
        public static string ExtensionName;
        public System.Action OnBoundariesTransitionStarted;
        public System.Action OnBoundariesTransitionFinished;
        public bool UseNumericBoundaries;
        public bool UseTopBoundary;
        public float TopBoundary;
        public float TargetTopBoundary;
        public bool UseBottomBoundary;
        public float BottomBoundary;
        public float TargetBottomBoundary;
        public bool UseLeftBoundary;
        public float LeftBoundary;
        public float TargetLeftBoundary;
        public bool UseRightBoundary;
        public float RightBoundary;
        public float TargetRightBoundary;
        public bool IsCameraPositionHorizontallyBounded;
        public bool IsCameraPositionVerticallyBounded;
        public UnityEngine.Coroutine TopBoundaryAnimRoutine;
        public UnityEngine.Coroutine BottomBoundaryAnimRoutine;
        public UnityEngine.Coroutine LeftBoundaryAnimRoutine;
        public UnityEngine.Coroutine RightBoundaryAnimRoutine;
        public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTriggerBoundaries CurrentBoundariesTrigger;
        public UnityEngine.Coroutine MoveCameraToTargetRoutine;
        public bool HasFiredTransitionStarted;
        public bool HasFiredTransitionFinished;
        public bool UseSoftBoundaries;
        public float Softness;
        public float SoftAreaSize;
        private float _smoothnessVelX;
        private float _smoothnessVelY;
        private int _pdcOrder;
        private int _soOrder;
        
        // Properties
        public Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings Settings { get; set; }
        public int PDCOrder { get; set; }
        public int SOOrder { get; set; }
        
        // Methods
        public Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings get_Settings()
        {
            mem[1152921509919365976] = R1 + 64;
            this = R1 + 52;
            mem[1152921509919365970] = 0;
            mem[1152921509919365972] = R1 + 56;
            mem[1152921509919365979] = 0;
            mem[1152921509919365977] = 0;
            mem[1152921509919365980] = R1 + 68;
            mem[1152921509919365984] = R1 + 76;
            mem[1152921509919365987] = 0;
            mem[1152921509919365985] = 0;
            mem[1152921509919365988] = R1 + 80;
            mem[1152921509919365992] = R1 + 88;
            mem[1152921509919365995] = 0;
            mem[1152921509919365993] = 0;
            mem[1152921509919365996] = R1 + 92;
            return new Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings() {UseNumericBoundaries = true, UseTopBoundary = true, TopBoundary = 0f, UseBottomBoundary = R1 + 80, BottomBoundary = R1 + 76, UseLeftBoundary = false, UseRightBoundary = false};
        }
        public void set_Settings(Com.LuisPedroFonseca.ProCamera2D.NumericBoundariesSettings value)
        {
            this.TopBoundary = value.TopBoundary;
            if()
            {
                    value.UseNumericBoundaries & 65280 = 1;
            }
            
            if(((int)value.UseNumericBoundaries & 255) != 0)
            {
                    (int)value.UseNumericBoundaries & 255 = 1;
            }
            
            this.BottomBoundary = value.BottomBoundary;
            this.LeftBoundary = value.LeftBoundary;
            this.RightBoundary = value.RightBoundary;
            this.UseTopBoundary = true;
            this.UseNumericBoundaries = true;
            if(((int)value.UseBottomBoundary & 255) != 0)
            {
                    (int)value.UseBottomBoundary & 255 = 1;
            }
            
            if(value.UseLeftBoundary == true)
            {
                    value.UseLeftBoundary = 1;
            }
            
            if(value.UseRightBoundary == true)
            {
                    value.UseRightBoundary = 1;
            }
            
            this.UseBottomBoundary = true;
            this.UseLeftBoundary = true;
            this.UseRightBoundary = true;
        }
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.AddPositionDeltaChanger(changer:  1017775696);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            this.AddSizeOverrider(overrider:  1017775696);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(1017887696 == 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePositionDeltaChanger(changer:  R4);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = R4.ProCamera2D;
            R4.RemoveSizeOverrider(overrider:  R4);
        }
        public UnityEngine.Vector3 AdjustDelta(float deltaTime, UnityEngine.Vector3 originalDelta)
        {
            float val_1;
            float val_2;
            float val_10;
            float val_11;
            float val_12;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DNumericBoundaries val_113;
            float val_114;
            float val_116;
            float val_117;
            var val_118;
            float val_119;
            var val_120;
            float val_121;
            var val_122;
            var val_123;
            float val_124;
            val_113 = originalDelta.z;
            val_114 = val_2;
            bool val_3 = originalDelta.x.enabled;
            if(val_3 == true)
            {
                    val_3 = mem[originalDelta.x + 52];
                val_3 = originalDelta.x + 52;
            }
            
            if(val_3 == 0)
            {
                    this = val_113;
                mem[1152921509919813972] = val_114;
                mem[1152921509919813976] = val_1;
                return new UnityEngine.Vector3() {x = val_104.x, y = val_104.y, z = val_104.z};
            }
            
            mem2[0] = 0;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = originalDelta.x.ProCamera2D;
            mem2[0] = 0;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = originalDelta.x.ProCamera2D;
            mem2[0] = 0;
            mem2[0] = 0;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = originalDelta.x.ProCamera2D;
            mem2[0] = 0;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_7 = originalDelta.x.ProCamera2D;
            mem2[0] = 0;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_9 = LocalPosition;
            float val_13 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_10, y = val_11, z = val_12});
            float val_14 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_113, y = val_2, z = val_1});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_15 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_16 = LocalPosition;
            float val_17 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6});
            val_116 = val_113;
            val_117 = val_1;
            float val_18 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_116, y = val_2, z = val_117});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_19 = originalDelta.x.ProCamera2D;
            var val_105 = originalDelta.x + 72;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_20 = originalDelta.x.ProCamera2D;
            val_118 = originalDelta.x;
            float val_109 = 0.5f;
            val_119 = 0f;
            if((originalDelta.x + 130) == 0)
            {
                goto label_15;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_21 = originalDelta.x.ProCamera2D;
            val_118 = originalDelta.x;
            val_120 = (originalDelta.x + 136) * (originalDelta.x + 72);
            val_121 = 4.01997E-38f;
            if((originalDelta.x + 130) == 0)
            {
                goto label_19;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_22 = originalDelta.x.ProCamera2D;
            val_118 = originalDelta.x;
            val_119 = (originalDelta.x + 136) * (originalDelta.x + 76);
            goto label_19;
            label_15:
            val_120 = 0;
            val_121 = 4.01997E-38f;
            label_19:
            val_122 = (originalDelta.x + 16) + (originalDelta.x + 16);
            val_105 = val_105 * val_109;
            if((originalDelta.x + 76) == 0)
            {
                goto label_21;
            }
            
            float val_23 = val_122 - val_105;
            float val_24 = val_120 + (originalDelta.x + 80);
            if((originalDelta.x + 76) >= 0)
            {
                goto label_21;
            }
            
            if((originalDelta.x + 130) == 0)
            {
                goto label_22;
            }
            
            float val_25 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_116, y = val_2, z = val_117});
            if((originalDelta.x + 16) <= 0)
            {
                goto label_24;
            }
            
            float val_26 = val_105 + (originalDelta.x + 80);
            float val_27 = UnityEngine.Mathf.Max(a:  val_26, b:  val_16.y);
            val_122 = val_26;
            goto label_26;
            label_22:
            val_122 = val_105 + (originalDelta.x + 80);
            goto label_26;
            label_24:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_28 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_29 = LocalPosition;
            float val_30 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = SB});
            float val_31 = val_105 + (originalDelta.x + 80);
            float val_32 = UnityEngine.Mathf.Max(a:  val_31, b:  val_29.y);
            float val_106 = originalDelta.x + 80;
            val_106 = val_105 + val_106;
            float val_33 = UnityEngine.Mathf.Max(a:  val_106, b:  val_29.y);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_34 = originalDelta.x.ProCamera2D;
            float val_35 = originalDelta.x + 140;
            UnityEngine.Vector3 val_36 = LocalPosition;
            val_121 = 22732340;
            float val_37 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
            float val_38 = val_105 + (originalDelta.x + 80);
            val_38 = val_38 - (originalDelta.x + 16);
            float val_39 = val_31;
            val_38 = val_120 + val_38;
            val_38 = val_38 / val_120;
            val_38 = (originalDelta.x + 132) * val_38;
            float val_40 = UnityEngine.Mathf.SmoothDamp(current:  val_38, target:  val_36.y, currentVelocity: ref  val_39, smoothTime:  originalDelta.x + 132);
            val_122 = val_39;
            val_116 = val_113;
            label_26:
            mem2[0] = 1;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_41 = originalDelta.x.ProCamera2D;
            val_118 = originalDelta.x;
            mem2[0] = 1;
            val_117 = val_1;
            label_21:
            if((originalDelta.x + 88) == 0)
            {
                goto label_33;
            }
            
            float val_42 = val_105 + val_122;
            float val_43 = (originalDelta.x + 92) - val_120;
            if((originalDelta.x + 88) <= 0)
            {
                goto label_33;
            }
            
            if((originalDelta.x + 130) == 0)
            {
                goto label_34;
            }
            
            float val_44 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_116, y = val_2, z = val_117});
            if((originalDelta.x + 16) >= 0)
            {
                goto label_36;
            }
            
            float val_45 = (originalDelta.x + 92) - val_105;
            float val_46 = UnityEngine.Mathf.Min(a:  val_45, b:  val_36.y);
            val_122 = val_45;
            goto label_38;
            label_34:
            val_122 = (originalDelta.x + 92) - val_105;
            goto label_38;
            label_36:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_47 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_48 = LocalPosition;
            float val_49 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6});
            float val_50 = (originalDelta.x + 92) - val_105;
            float val_51 = UnityEngine.Mathf.Min(a:  val_50, b:  val_48.y);
            float val_107 = originalDelta.x + 92;
            val_107 = val_107 - val_105;
            float val_52 = UnityEngine.Mathf.Min(a:  val_107, b:  val_48.y);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_53 = originalDelta.x.ProCamera2D;
            float val_54 = originalDelta.x + 140;
            UnityEngine.Vector3 val_55 = LocalPosition;
            val_121 = 4.01997E-38f;
            float val_56 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R8});
            float val_108 = originalDelta.x + 92;
            val_108 = val_108 - val_105;
            float val_57 = val_50;
            val_108 = (originalDelta.x + 16) - val_108;
            val_108 = val_120 + val_108;
            val_108 = val_108 / val_120;
            val_108 = (originalDelta.x + 132) * val_108;
            float val_58 = UnityEngine.Mathf.SmoothDamp(current:  val_108, target:  val_55.y, currentVelocity: ref  val_57, smoothTime:  originalDelta.x + 132);
            val_122 = val_57;
            val_116 = val_113;
            val_117 = val_1;
            label_38:
            val_118 = 1;
            mem2[0] = val_118;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_59 = originalDelta.x.ProCamera2D;
            mem2[0] = val_118;
            label_33:
            val_123 = (originalDelta.x + 20) + (originalDelta.x + 20);
            val_109 = (originalDelta.x + 76) * val_109;
            if((originalDelta.x + 64) == 0)
            {
                goto label_45;
            }
            
            float val_60 = val_123 - val_109;
            float val_61 = val_119 + (originalDelta.x + 68);
            if((originalDelta.x + 64) >= 0)
            {
                goto label_45;
            }
            
            if((originalDelta.x + 130) == 0)
            {
                goto label_46;
            }
            
            float val_62 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_116, y = val_2, z = val_117});
            if((originalDelta.x + 20) <= 0)
            {
                goto label_48;
            }
            
            float val_63 = val_109 + (originalDelta.x + 68);
            float val_64 = UnityEngine.Mathf.Max(a:  val_63, b:  val_55.y);
            val_123 = val_63;
            goto label_50;
            label_46:
            val_123 = val_109 + (originalDelta.x + 68);
            goto label_50;
            label_48:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_65 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_66 = LocalPosition;
            float val_67 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6});
            float val_68 = val_109 + (originalDelta.x + 68);
            float val_69 = UnityEngine.Mathf.Max(a:  val_68, b:  val_66.y);
            float val_110 = originalDelta.x + 68;
            val_110 = val_109 + val_110;
            float val_70 = UnityEngine.Mathf.Max(a:  val_110, b:  val_66.y);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_71 = originalDelta.x.ProCamera2D;
            float val_72 = originalDelta.x + 144;
            UnityEngine.Vector3 val_73 = LocalPosition;
            val_121 = 4.01997E-38f;
            float val_74 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R8});
            float val_75 = val_109 + (originalDelta.x + 68);
            val_75 = val_119 + val_75;
            val_75 = val_75 - (originalDelta.x + 20);
            float val_76 = val_68;
            val_75 = val_75 / val_120;
            val_75 = (originalDelta.x + 132) * val_75;
            float val_77 = UnityEngine.Mathf.SmoothDamp(current:  val_75, target:  val_73.y, currentVelocity: ref  val_76, smoothTime:  originalDelta.x + 132);
            val_123 = val_76;
            val_116 = val_113;
            val_117 = val_1;
            label_50:
            val_118 = 1;
            mem2[0] = val_118;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_78 = originalDelta.x.ProCamera2D;
            mem2[0] = val_118;
            label_45:
            if((originalDelta.x + 53) == 0)
            {
                goto label_57;
            }
            
            float val_79 = val_109 + val_123;
            float val_80 = (originalDelta.x + 56) - val_119;
            if((originalDelta.x + 53) <= 0)
            {
                goto label_57;
            }
            
            if((originalDelta.x + 130) == 0)
            {
                goto label_58;
            }
            
            float val_81 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_116, y = val_2, z = val_117});
            if((originalDelta.x + 20) >= 0)
            {
                goto label_60;
            }
            
            float val_82 = (originalDelta.x + 56) - val_109;
            val_124 = val_82;
            float val_83 = UnityEngine.Mathf.Min(a:  val_82, b:  val_73.y);
            goto label_61;
            label_58:
            val_123 = (originalDelta.x + 56) - val_109;
            goto label_62;
            label_60:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_84 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_85 = LocalPosition;
            float val_86 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R7});
            float val_87 = (originalDelta.x + 56) - val_109;
            float val_88 = UnityEngine.Mathf.Min(a:  val_87, b:  val_85.y);
            float val_111 = originalDelta.x + 56;
            val_111 = val_111 - val_109;
            float val_89 = UnityEngine.Mathf.Min(a:  val_111, b:  val_85.y);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_90 = originalDelta.x.ProCamera2D;
            float val_91 = originalDelta.x + 144;
            UnityEngine.Vector3 val_92 = LocalPosition;
            val_121 = 4.01997E-38f;
            float val_93 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R8});
            float val_112 = originalDelta.x + 56;
            val_112 = val_112 - val_109;
            val_124 = val_87;
            val_112 = (originalDelta.x + 20) - val_112;
            val_112 = val_119 + val_112;
            val_112 = val_112 / val_120;
            val_112 = (originalDelta.x + 132) * val_112;
            float val_94 = UnityEngine.Mathf.SmoothDamp(current:  val_112, target:  val_92.y, currentVelocity: ref  val_124, smoothTime:  originalDelta.x + 132);
            label_61:
            val_123 = val_124;
            label_62:
            val_118 = 1;
            mem2[0] = val_118;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_95 = originalDelta.x.ProCamera2D;
            mem2[0] = val_118;
            label_57:
            val_113 = mem[originalDelta.x + 28];
            val_113 = originalDelta.x + 28;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_96 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_97 = LocalPosition;
            float val_98 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = R6});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_99 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_100 = LocalPosition;
            val_114 = val_11;
            float val_101 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_10, y = val_114, z = val_12});
            float val_103 = val_123 - (originalDelta.x + 20);
            UnityEngine.Vector3 val_104 = Invoke(arg1:  val_122 - (originalDelta.x + 16), arg2:  val_100.y);
            mem[1152921509919813976] = val_12;
            this = val_10;
            return new UnityEngine.Vector3() {x = val_104.x, y = val_104.y, z = val_104.z};
        }
        public int get_PDCOrder()
        {
            return (int)this._pdcOrder;
        }
        public void set_PDCOrder(int value)
        {
            this._pdcOrder = value;
        }
        public float OverrideSize(float deltaTime, float originalSize)
        {
            bool val_1 = this.enabled;
            if(val_1 == true)
            {
                    val_1 = this.UseNumericBoundaries;
                goto label_0;
            }
            
            return (float)deltaTime;
            label_0:
            if(this.UseRightBoundary == true)
            {
                    this.UseRightBoundary = this.UseLeftBoundary;
                goto label_1;
            }
            
            label_9:
            if(this.UseTopBoundary == false)
            {
                    return (float)deltaTime;
            }
            
            float val_9 = 0.5f;
            float val_3 = R2 + R2;
            val_9 = (this.TopBoundary - this.BottomBoundary) * val_9;
            if(this.UseBottomBoundary == true)
            {
                    R2 = val_9;
            }
            
            if(this.UseBottomBoundary > false)
            {
                    R2 = R2;
            }
            
            return (float)deltaTime;
            label_1:
            float val_10 = this.LeftBoundary;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_4 = this.ProCamera2D;
            val_10 = this.RightBoundary - val_10;
            float val_5 = this.aspect;
            uint val_11 = 1018335696;
            val_11 = val_11 * R2;
            val_11 = val_11 + val_11;
            if(this <= 0)
            {
                goto label_9;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.ProCamera2D;
            float val_7 = this.aspect;
            uint val_12 = 1018335696;
            val_12 = val_10 / val_12;
            float val_8 = val_12 * 0.5f;
            goto label_9;
        }
        public int get_SOOrder()
        {
            return (int)this._soOrder;
        }
        public void set_SOOrder(int value)
        {
            this._soOrder = value;
        }
        public ProCamera2DNumericBoundaries()
        {
            this.TopBoundary = 10f;
            this.UseNumericBoundaries = true;
            this.UseBottomBoundary = true;
            this.BottomBoundary = -10f;
            this.LeftBoundary = -10f;
            this.RightBoundary = 10f;
            this.UseSoftBoundaries = true;
            this.Softness = 0.5f;
            this.SoftAreaSize = 0.1f;
            this._pdcOrder = 4000;
            this._soOrder = 2000;
        }
        private static ProCamera2DNumericBoundaries()
        {
            mem2[0] = -1610605913;
        }
    
    }

}
