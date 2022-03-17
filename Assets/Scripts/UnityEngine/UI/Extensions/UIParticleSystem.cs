using UnityEngine;

namespace UnityEngine.UI.Extensions
{
    public class UIParticleSystem : MaskableGraphic
    {
        // Fields
        public bool fixedTime;
        public bool use3dRotation;
        private UnityEngine.Transform _transform;
        private UnityEngine.ParticleSystem pSystem;
        private UnityEngine.ParticleSystem.Particle[] particles;
        private UnityEngine.UIVertex[] _quad;
        private UnityEngine.Vector4 imageUV;
        private UnityEngine.ParticleSystem.TextureSheetAnimationModule textureSheetAnimation;
        private int textureSheetAnimationFrames;
        private UnityEngine.Vector2 textureSheetAnimationFrameSize;
        private UnityEngine.ParticleSystemRenderer pRenderer;
        private bool isInitialised;
        private UnityEngine.Material currentMaterial;
        private UnityEngine.Texture currentTexture;
        private UnityEngine.ParticleSystem.MainModule mainModule;
        
        // Properties
        public override UnityEngine.Texture mainTexture { get; }
        
        // Methods
        public override UnityEngine.Texture get_mainTexture()
        {
        
        }
        protected bool Initialize()
        {
            var val_26;
            var val_27;
            UnityEngine.ParticleSystem val_33;
            var val_34;
            Particle[] val_35;
            if(this._transform == 0)
            {
                    UnityEngine.Transform val_2 = this._transform.transform;
                this._transform = this;
            }
            
            if(this.pSystem == 0)
            {
                    UnityEngine.Transform val_4 = this.pSystem.GetComponent<UnityEngine.Transform>();
                this.pSystem = this;
                val_33 = this.pSystem;
                val_34 = 0;
                if(val_33 == 0)
            {
                    return (bool)val_34;
            }
            
                ParticleSystem.MainModule val_6 = val_33.main;
                this.mainModule = val_6;
                ParticleSystem.MainModule val_7 = val_33.main;
                if(val_7.m_ParticleSystem.maxParticles >= 14001)
            {
                    this.mainModule.maxParticles = 14000;
            }
            
                UnityEngine.Transform val_9 = val_33.GetComponent<UnityEngine.Transform>();
                this.pRenderer = this.pSystem;
                if(1102523312 != 0)
            {
                    this.enabled = false;
            }
            
                UnityEngine.Material val_11 = this.material;
                if(1102523312 == 0)
            {
                    UnityEngine.Shader val_13 = UnityEngine.Shader.Find(name:  -1610603223);
                if((UnityEngine.Object.op_Implicit(exists:  -1610603223)) != false)
            {
                    536890261 = new UnityEngine.Material(shader:  -1610603223);
                this.material = 536890261;
            }
            
            }
            
                val_33 = this;
                this.material = 536890261;
                mem[1152921510004337768] = this;
                if(((UnityEngine.Object.op_Implicit(exists:  1102523312)) != false) && ((this.HasProperty(name:  -1610602093)) != false))
            {
                    UnityEngine.Texture val_18 = this.mainTexture;
                val_33 = this;
                this.currentTexture = mem[1152921510004337768];
                if(1102523312 == 0)
            {
                    UnityEngine.Texture2D val_20 = UnityEngine.Texture2D.whiteTexture;
                mem[1152921510004337772] = 0;
            }
            
            }
            
                this.material = this.currentMaterial;
                this.mainModule.scalingMode = 0;
                val_35 = this;
                this.particles = 0;
            }
            else
            {
                    val_35 = this.particles;
            }
            
            if(mem[this.particles] == 0)
            {
                    ParticleSystem.MainModule val_21 = this.main;
                int val_22 = val_21.m_ParticleSystem.maxParticles;
                mem2[0] = 536882683;
            }
            
            UnityEngine.Vector4 val_23 = new UnityEngine.Vector4(x:  null, y:  null, z:  null, w:  null);
            ParticleSystem.TextureSheetAnimationModule val_24 = this.pSystem.textureSheetAnimation;
            this.textureSheetAnimation = val_24;
            mem[1152921510004337748] = 0;
            UnityEngine.Vector2 val_25 = UnityEngine.Vector2.zero;
            mem[1152921510004337752] = val_26;
            mem[1152921510004337756] = val_27;
            val_34 = 1;
            if(this.textureSheetAnimation.enabled == false)
            {
                    return (bool)val_34;
            }
            
            int val_30 = this.textureSheetAnimation.numTilesY;
            val_30 = val_30 * this.textureSheetAnimation.numTilesX;
            this.textureSheetAnimationFrames = val_30;
            val_33 = this.textureSheetAnimation.numTilesX;
            float val_33 = (float)val_33;
            float val_34 = 1f;
            val_33 = val_34 / val_33;
            val_34 = val_34 / (float)this.textureSheetAnimation.numTilesY;
            this.textureSheetAnimationFrameSize = val_33;
            mem[1152921510004337756] = val_34;
            return (bool)val_34;
        }
        protected override void Awake()
        {
            this.Awake();
            if(this.Initialize() == true)
            {
                    return;
            }
            
            R4.enabled = false;
        }
        protected override void OnPopulateMesh(UnityEngine.UI.VertexHelper vh)
        {
            float val_10;
            float val_18;
            float val_19;
            UnityEngine.UI.Extensions.UIParticleSystem val_98;
            var val_100;
            var val_101;
            ParticleSystem.TextureSheetAnimationModule val_103;
            var val_104;
            float val_105;
            float val_106;
            var val_107;
            float val_108;
            var val_109;
            var val_111;
            var val_112;
            var val_113;
            val_98 = this;
            vh.Clear();
            UnityEngine.GameObject val_1 = this.gameObject;
            if(this.activeInHierarchy == false)
            {
                goto label_9;
            }
            
            if(this.isInitialised != true)
            {
                    ParticleSystem.MainModule val_3 = this.pSystem.main;
                if(val_3.m_ParticleSystem.playOnAwake != true)
            {
                    this.pSystem.Stop(withChildren:  false, stopBehavior:  0);
                this.isInitialised = true;
            }
            
            }
            
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            int val_8 = this.pSystem.GetParticles(particles:  this.particles);
            if(val_8 < 1)
            {
                goto label_9;
            }
            
            val_100 = 0;
            goto label_10;
            label_25:
            MinMaxCurve val_9 = frameOverTime;
            mem2[0] = val_10;
            float val_11 = val_9.m_ConstantMax.constant;
            if(val_8 <= 1)
            {
                goto label_11;
            }
            
            MinMaxCurve val_12 = frameOverTime;
            mem2[0] = val_10;
            float val_13 = val_12.m_ConstantMax.constant;
            float val_14 = remainingLifetime;
            float val_15 = startLifetime;
            uint val_92 = 1102849704;
            val_92 = 1102849704 / val_92;
            val_101 = val_12.m_ConstantMax - val_92;
            goto label_13;
            label_11:
            uint val_93 = 1102849840;
            val_93 = val_93 / 1102862000;
            val_101 = 1f - val_93;
            goto label_13;
            label_10:
            if(this.particles == null)
            {
                    val_100 = val_100;
                val_98 = val_98;
            }
            
            UnityEngine.ParticleSystemSimulationSpace val_16 = this.mainModule.simulationSpace;
            if(this.mainModule != 0)
            {
                    UnityEngine.Vector3 val_17 = position;
                UnityEngine.Vector3 val_21 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = mem[1152921510004676400], y = val_18, z = val_19});
                val_103 = this.textureSheetAnimation;
                val_98 = val_98;
            }
            else
            {
                    UnityEngine.Vector3 val_22 = position;
                val_103 = this.textureSheetAnimation;
            }
            
            float val_23 = rotation;
            UnityEngine.Color32 val_24 = GetCurrentColor(system:  this.pSystem);
            float val_25 = GetCurrentSize(system:  this.pSystem);
            UnityEngine.ParticleSystemScalingMode val_26 = this.mainModule.scalingMode;
            val_104 = 22716216;
            if(this.mainModule == 2)
            {
                    UnityEngine.Canvas val_27 = this.canvas;
                float val_28 = this.scaleFactor;
                val_105 = val_19 / 1102862000;
                float val_29 = val_18 / 1102862000;
            }
            else
            {
                    val_105 = val_105;
            }
            
            val_106 = mem[1152921510004676416];
            val_107 = mem[1152921510004676420];
            val_108 = mem[1152921510004676424];
            val_109 = mem[1152921510004676428];
            if(val_103.enabled == false)
            {
                goto label_22;
            }
            
            float val_31 = remainingLifetime;
            float val_32 = startLifetime;
            MinMaxCurve val_33 = frameOverTime;
            UnityEngine.AnimationCurve val_34 = val_18.curveMin;
            if( == 0)
            {
                goto label_23;
            }
            
            MinMaxCurve val_35 = frameOverTime;
            mem2[0] = val_18;
            UnityEngine.AnimationCurve val_36 = val_35.m_ConstantMax.curveMin;
            val_111 = val_35.m_ConstantMax;
            goto label_24;
            label_23:
            MinMaxCurve val_37 = frameOverTime;
            mem2[0] = val_18;
            UnityEngine.AnimationCurve val_38 = val_37.m_ConstantMax.curve;
            if(val_37.m_ConstantMax == 0f)
            {
                goto label_25;
            }
            
            MinMaxCurve val_39 = frameOverTime;
            mem2[0] = val_18;
            UnityEngine.AnimationCurve val_40 = val_39.m_ConstantMax.curve;
            val_111 = val_39.m_ConstantMax;
            label_24:
            float val_41 = remainingLifetime;
            float val_42 = startLifetime;
            float val_43 = 1102849704 / 1102849704;
            val_43 = 1f - val_43;
            float val_44 = val_111.Evaluate(time:  val_43);
            val_101 = val_111;
            label_13:
            val_112 = 0;
            val_104 = 22716216;
            float val_94 = (float)val_103.cycleCount;
            val_94 = val_101 * val_94;
            float val_46 = UnityEngine.Mathf.Repeat(t:  val_94, length:  val_22.y);
            UnityEngine.ParticleSystemAnimationType val_47 = val_103.animation;
            if(val_103 == 1)
            {
                goto label_27;
            }
            
            if(val_103 != 0)
            {
                goto label_29;
            }
            
            float val_95 = (float)mem[1152921510004676436];
            val_95 = val_94 * val_95;
            val_112 = UnityEngine.Mathf.FloorToInt(f:  val_95);
            goto label_29;
            label_27:
            float val_96 = (float)val_103.numTilesX;
            val_96 = val_94 * val_96;
            int val_50 = UnityEngine.Mathf.FloorToInt(f:  val_96);
            int val_51 = val_103.rowIndex;
            int val_52 = val_103.numTilesX;
            label_29:
            int val_53 = val_103.numTilesX;
            int val_54 = val_103.numTilesX;
            int val_55 = UnityEngine.Mathf.FloorToInt(f:  val_53);
            val_106 = mem[1152921510004676440] * (float)val_53;
            val_108 = val_106 + mem[1152921510004676440];
            val_109 = mem[1152921510004676444] + 1f;
            label_22:
            if(((mem[536896324] & true) == 0) && (mem[536896253] == 0))
            {
                    val_113 = 536896137;
            }
            
            var val_56 = mem[536896229] + 20;
            var val_57 = mem[this._quad] + 16;
            mem2[0] = val_24.r;
            mem[1] = val_24.g;
            mem[2] = val_24.b;
            mem[3] = val_24.a;
            UnityEngine.Vector4 val_58 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = 23.51913f, y = val_106});
            var val_59 = mem[this._quad] + 60;
            var val_60 = mem[536896229] + 20;
            var val_61 = mem[this._quad] + 124;
            mem2[0] = val_24.r;
            mem[1] = val_24.g;
            mem[2] = val_24.b;
            mem[3] = val_24.a;
            UnityEngine.Vector4 val_62 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = 23.51913f, y = val_106});
            var val_63 = mem[this._quad] + 168;
            var val_64 = mem[536896229] + 20;
            var val_65 = mem[this._quad] + 232;
            mem2[0] = val_24.r;
            mem[1] = val_24.g;
            mem[2] = val_24.b;
            mem[3] = val_24.a;
            UnityEngine.Vector4 val_66 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = 23.51913f, y = val_108});
            var val_67 = mem[this._quad] + 276;
            var val_68 = mem[536896229] + 20;
            var val_69 = mem[this._quad] + 340;
            uint val_99 = 1102849704;
            mem2[0] = val_24.r;
            mem[1] = val_24.g;
            mem[2] = val_24.b;
            mem[3] = val_24.a;
            float val_70 = val_99 * (-0.01745329f);
            uint val_101 = 1102849704;
            UnityEngine.Vector4 val_71 = UnityEngine.Vector4.op_Implicit(v:  new UnityEngine.Vector2() {x = 23.51913f, y = val_108});
            float val_72 = val_101 * 0.5f;
            var val_73 = mem[this._quad] + 384;
            if((mem[this._quad] + 12) != 3)
            {
                goto label_56;
            }
            
            float val_97 = val_105;
            float val_98 = val_29;
            float val_74 = val_97 - val_72;
            float val_75 = val_98 - val_72;
            mem2[0] = val_75;
            mem2[0] = val_74;
            mem2[0] = 0;
            val_97 = val_72 + val_97;
            mem2[0] = val_75;
            mem2[0] = val_97;
            mem2[0] = 0;
            val_98 = val_72 + val_98;
            mem2[0] = val_98;
            mem2[0] = val_97;
            mem2[0] = 0;
            mem2[0] = val_98;
            mem2[0] = val_74;
            label_78:
            mem2[0] = 0;
            goto label_65;
            label_56:
            if(mem[1152921510004676397] == false)
            {
                goto label_66;
            }
            
            UnityEngine.ParticleSystemSimulationSpace val_76 = this.mainModule.simulationSpace;
            if(this.mainModule == 0)
            {
                goto label_67;
            }
            
            UnityEngine.Vector3 val_77 = position;
            UnityEngine.Vector3 val_78 = InverseTransformPoint(position:  new UnityEngine.Vector3() {x = mem[1152921510004676400], y = R5, z = R6});
            goto label_69;
            label_66:
            val_99 = val_70 + 1.570796f;
            var val_100 = val_99;
            float val_79 = val_72 * val_70;
            float val_80 = val_72 * val_70;
            val_100 = val_72 * val_100;
            val_101 = val_72 * val_99;
            float val_81 = val_105 - val_80;
            float val_82 = val_29 - val_79;
            mem2[0] = val_82 - val_100;
            mem2[0] = val_81 - val_101;
            mem2[0] = 0;
            mem2[0] = val_82 + val_100;
            mem2[0] = val_81 + val_101;
            mem2[0] = 0;
            val_80 = val_105 + val_80;
            float val_87 = val_79 + val_29;
            mem2[0] = val_87 + val_100;
            mem2[0] = val_80 + val_101;
            mem2[0] = 0;
            mem2[0] = val_87 - val_100;
            mem2[0] = val_80 - val_101;
            goto label_78;
        }
        private void Update()
        {
            UnityEngine.Object val_14;
            UnityEngine.Texture val_15;
            if(this.fixedTime == true)
            {
                    return;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            val_14 = 0;
            this.pSystem.Simulate(t:  UnityEngine.Time.unscaledDeltaTime, withChildren:  false, restart:  false, fixedTimeStep:  false);
            this.SetAllDirty();
            if(this.currentMaterial == 0)
            {
                goto label_6;
            }
            
            val_15 = this.currentTexture;
            UnityEngine.Texture val_4 = this.currentMaterial.mainTexture;
            val_14 = this.currentMaterial;
            if(val_15 != val_14)
            {
                goto label_10;
            }
            
            label_6:
            UnityEngine.Material val_6 = this.material;
            val_15 = this;
            if(1103088688 == 0)
            {
                    return;
            }
            
            val_15 = this.currentMaterial;
            if(val_15 == 0)
            {
                    return;
            }
            
            UnityEngine.Material val_9 = this.material;
            UnityEngine.Shader val_10 = val_14.shader;
            val_15 = this;
            UnityEngine.Shader val_11 = this.currentMaterial.shader;
            val_14 = this.currentMaterial;
            if(1103088688 == val_14)
            {
                    return;
            }
            
            label_10:
            this.pSystem = 0;
            bool val_13 = this.Initialize();
        }
        private void LateUpdate()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                goto label_1;
            }
            
            if(this.fixedTime == false)
            {
                goto label_22;
            }
            
            this.pSystem.Simulate(t:  UnityEngine.Time.unscaledDeltaTime, withChildren:  false, restart:  false, fixedTimeStep:  false);
            this.SetAllDirty();
            if(this.currentMaterial == 0)
            {
                goto label_6;
            }
            
            UnityEngine.Texture val_4 = this.currentMaterial.mainTexture;
            if(this.currentTexture != this.currentMaterial)
            {
                goto label_10;
            }
            
            label_6:
            UnityEngine.Material val_6 = this.material;
            if((1103253936 == 0) || (this.currentMaterial == 0))
            {
                goto label_22;
            }
            
            UnityEngine.Material val_9 = this.material;
            UnityEngine.Shader val_10 = this.currentMaterial.shader;
            UnityEngine.Shader val_11 = this.currentMaterial.shader;
            if(1103253936 == this.currentMaterial)
            {
                goto label_22;
            }
            
            label_10:
            this.pSystem = 0;
            bool val_13 = this.Initialize();
            goto label_22;
            label_1:
            this.SetAllDirty();
            label_22:
            UnityEngine.Material val_14 = this.material;
            if(1103253936 == this.currentMaterial)
            {
                    return;
            }
            
            this.pSystem = 0;
            bool val_16 = this.Initialize();
        }
        protected override void OnDestroy()
        {
            this.currentMaterial = 0;
            this.currentTexture = 0;
        }
        public void StartParticleEmission()
        {
            this.pSystem.Play();
        }
        public void StopParticleEmission()
        {
            this.pSystem.Stop(withChildren:  false, stopBehavior:  0);
        }
        public void PauseParticleEmission()
        {
            this.pSystem.Stop(withChildren:  false, stopBehavior:  1);
        }
        public UIParticleSystem()
        {
            this.fixedTime = true;
            this._quad = 536882545;
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
        }
    
    }

}
