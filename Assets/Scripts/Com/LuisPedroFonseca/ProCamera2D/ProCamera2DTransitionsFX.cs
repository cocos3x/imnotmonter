using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DTransitionsFX : BasePC2D
    {
        // Fields
        public static string ExtensionName;
        public System.Action OnTransitionEnterStarted;
        public System.Action OnTransitionEnterEnded;
        public System.Action OnTransitionExitStarted;
        public System.Action OnTransitionExitEnded;
        public System.Action OnTransitionStarted;
        public System.Action OnTransitionEnded;
        private static Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTransitionsFX _instance;
        public Com.LuisPedroFonseca.ProCamera2D.TransitionsFXShaders TransitionShaderEnter;
        public float DurationEnter;
        public float DelayEnter;
        public Com.LuisPedroFonseca.ProCamera2D.EaseType EaseTypeEnter;
        public UnityEngine.Color BackgroundColorEnter;
        public Com.LuisPedroFonseca.ProCamera2D.TransitionFXSide SideEnter;
        public Com.LuisPedroFonseca.ProCamera2D.TransitionFXDirection DirectionEnter;
        public int BlindsEnter;
        public UnityEngine.Texture TextureEnter;
        public float TextureSmoothingEnter;
        public Com.LuisPedroFonseca.ProCamera2D.TransitionsFXShaders TransitionShaderExit;
        public float DurationExit;
        public float DelayExit;
        public Com.LuisPedroFonseca.ProCamera2D.EaseType EaseTypeExit;
        public UnityEngine.Color BackgroundColorExit;
        public Com.LuisPedroFonseca.ProCamera2D.TransitionFXSide SideExit;
        public Com.LuisPedroFonseca.ProCamera2D.TransitionFXDirection DirectionExit;
        public int BlindsExit;
        public UnityEngine.Texture TextureExit;
        public float TextureSmoothingExit;
        public bool StartSceneOnEnterState;
        private UnityEngine.Coroutine _transitionCoroutine;
        private float _step;
        private UnityEngine.Material _transitionEnterMaterial;
        private UnityEngine.Material _transitionExitMaterial;
        private Com.LuisPedroFonseca.ProCamera2D.BasicBlit _blit;
        private int _material_StepID;
        private int _material_BackgroundColorID;
        private string _previousEnterShader;
        private string _previousExitShader;
        
        // Properties
        public static Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTransitionsFX Instance { get; }
        
        // Methods
        public static Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTransitionsFX get_Instance()
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = 536892161;
            if(((mem[536892348] & true) == 0) && (mem[536892277] == 0))
            {
                    val_6 = 536892161;
            }
            
            if((System.Object.Equals(objA:  mem[536892253] + 4, objB:  0)) == false)
            {
                goto label_3;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2D.Instance;
            UnityEngine.Transform val_3 = 0.GetComponent<UnityEngine.Transform>();
            val_7 = 536892161;
            if(((mem[536892348] & true) == 0) && (mem[536892277] == 0))
            {
                    val_7 = 536892161;
            }
            
            mem2[0] = 0;
            if((System.Object.Equals(objA:  mem[536892253] + 4, objB:  0)) == true)
            {
                goto label_9;
            }
            
            label_3:
            val_8 = 536892161;
            if((mem[536892348] & true) != 0)
            {
                    return;
            }
            
            if(mem[536892277] != 0)
            {
                    return;
            }
            
            val_8 = 536892161;
            return;
            label_9:
            22716300 = new UnityEngine.UnityException(message:  22791884);
        }
        protected override void Awake()
        {
            var val_5;
            this.Awake();
            val_5 = 536892161;
            if(((mem[536892348] & true) == 0) && (mem[536892277] == 0))
            {
                    val_5 = 536892161;
            }
            
            mem2[0] = this;
            this._material_StepID = UnityEngine.Shader.PropertyToID(name:  -1610602029);
            this._material_BackgroundColorID = UnityEngine.Shader.PropertyToID(name:  -1610602171);
            UnityEngine.GameObject val_3 = this.gameObject;
            SynchronizationContextBehavoir val_4 = this.AddComponent<SynchronizationContextBehavoir>();
            this._blit = this;
            this.enabled = false;
            this.UpdateTransitionsShaders();
            this.UpdateTransitionsProperties();
            this.UpdateTransitionsColor();
            if(this.StartSceneOnEnterState == false)
            {
                    return;
            }
            
            this._step = 1f;
            this._blit.CurrentMaterial = this._transitionEnterMaterial;
            mem[1152921509950118300].SetFloat(nameID:  this._material_StepID, value:  null);
            this.enabled = true;
        }
        public void TransitionEnter()
        {
            this.Transition(material:  this._transitionEnterMaterial, duration:  null, delay:  null, startValue:  null, endValue:  null, easeType:  mem[this.DurationEnter + (0)]);
        }
        public void TransitionExit()
        {
            this.Transition(material:  this._transitionExitMaterial, duration:  null, delay:  null, startValue:  null, endValue:  null, easeType:  mem[this.DurationExit + (0)]);
        }
        public void UpdateTransitionsShaders()
        {
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            this.TransitionShaderEnter = mem[536895765];
            if((this._previousEnterShader.Equals(value:  536895765)) != true)
            {
                    string val_2 = -1610607739(-1610607739) + 536895765;
                UnityEngine.Shader val_3 = UnityEngine.Shader.Find(name:  -1610607739);
                UnityEngine.Material val_4 = 536890261;
                val_4 = new UnityEngine.Material(shader:  -1610607739);
                this._transitionEnterMaterial = val_4;
                this._previousEnterShader = 536895765;
            }
            
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            this.TransitionShaderExit = mem[536895765];
            if((this._previousExitShader.Equals(value:  536895765)) != false)
            {
                    return;
            }
            
            string val_6 = -1610607739(-1610607739) + 536895765;
            UnityEngine.Shader val_7 = UnityEngine.Shader.Find(name:  -1610607739);
            UnityEngine.Material val_8 = 536890261;
            val_8 = new UnityEngine.Material(shader:  -1610607739);
            this._transitionExitMaterial = val_8;
            this._previousExitShader = 536895765;
        }
        public void UpdateTransitionsProperties()
        {
            UnityEngine.Material val_3;
            int val_4;
            var val_5;
            int val_6;
            UnityEngine.Material val_7;
            var val_8;
            if((this.TransitionShaderEnter - 3) < 2)
            {
                goto label_1;
            }
            
            if(this.TransitionShaderEnter == 2)
            {
                goto label_2;
            }
            
            if(this.TransitionShaderEnter != 5)
            {
                goto label_6;
            }
            
            val_3 = this._transitionEnterMaterial;
            val_3.SetTexture(name:  -1610602009, value:  this.TextureEnter);
            this._transitionEnterMaterial.SetFloat(name:  -1610602043, value:  null);
            goto label_6;
            label_1:
            this._transitionEnterMaterial.SetInt(name:  -1610602137, value:  this.SideEnter);
            val_3 = this._transitionEnterMaterial;
            val_4 = this.BlindsEnter;
            val_5 = 22798004;
            goto label_9;
            label_2:
            val_3 = this._transitionEnterMaterial;
            val_4 = this.DirectionEnter;
            val_5 = 22798056;
            label_9:
            val_3.SetInt(name:  -1610602137, value:  val_4);
            label_6:
            if((this.TransitionShaderExit - 3) < 2)
            {
                goto label_11;
            }
            
            if(this.TransitionShaderExit == 2)
            {
                goto label_12;
            }
            
            if(this.TransitionShaderExit != 5)
            {
                    return;
            }
            
            this._transitionExitMaterial.SetTexture(name:  -1610602009, value:  this.TextureExit);
            this._transitionExitMaterial.SetFloat(name:  -1610602043, value:  null);
            return;
            label_11:
            val_3 = this._transitionExitMaterial;
            val_3.SetInt(name:  -1610602137, value:  this.SideExit);
            val_6 = this.BlindsExit;
            val_7 = this._transitionExitMaterial;
            val_8 = 22798004;
            goto label_18;
            label_12:
            val_6 = this.DirectionExit;
            val_7 = this._transitionExitMaterial;
            val_8 = 22798056;
            label_18:
            val_7.SetInt(name:  -1610602137, value:  val_6);
        }
        public void UpdateTransitionsColor()
        {
            this._transitionEnterMaterial.SetColor(nameID:  this._material_BackgroundColorID, value:  new UnityEngine.Color() {r = this.BackgroundColorEnter, g = SL});
            this._transitionExitMaterial.SetColor(nameID:  this._material_BackgroundColorID, value:  new UnityEngine.Color() {r = this.BackgroundColorExit, g = SB, b = this._transitionEnterMaterial});
        }
        public void Clear()
        {
            this._blit.enabled = false;
        }
        private void Transition(UnityEngine.Material material, float duration, float delay, float startValue, float endValue, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType)
        {
            if(this._transitionEnterMaterial == 0)
            {
                    UnityEngine.Debug.LogWarning(message:  -1610603325);
                return;
            }
            
            if(this._transitionCoroutine != 0)
            {
                    this.StopCoroutine(routine:  this._transitionCoroutine);
            }
            
            System.Collections.IEnumerator val_5 = this.TransitionRoutine(material:  material, duration:  duration, delay:  delay, startValue:  startValue, endValue:  endValue, easeType:  easeType);
            UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  1049317392);
            this._transitionCoroutine = this;
        }
        private System.Collections.IEnumerator TransitionRoutine(UnityEngine.Material material, float duration, float delay, float startValue, float endValue, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType)
        {
            var val_1;
            float val_2;
            float val_3;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTransitionsFX val_5 = this;
            ProCamera2DTransitionsFX.<TransitionRoutine>d__48 val_4 = 536900625;
            val_4 = new ProCamera2DTransitionsFX.<TransitionRoutine>d__48(<>1__state:  0);
            if(val_4 != 0)
            {
                    mem[536900641] = val_5;
                val_5 = val_4;
                mem[536900649] = material;
                mem[536900645] = val_3;
                mem[536900653] = val_2;
                mem[536900657] = R3;
                mem[536900661] = easeType;
            }
            else
            {
                    mem[16] = val_5;
                mem[24] = material;
                mem[36] = easeType;
                mem[32] = R3;
                mem[20] = val_3;
                mem[28] = val_2;
            }
            
            mem[536900665] = val_1;
        }
        public ProCamera2DTransitionsFX()
        {
            this.EaseTypeEnter = 1;
            this.DurationEnter = 0.5f;
            UnityEngine.Color val_1 = UnityEngine.Color.black;
            this.BlindsEnter = 16;
            this.TextureSmoothingEnter = 0.2f;
            this.DurationExit = 0.5f;
            this.EaseTypeExit = 1;
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            this.BlindsExit = 16;
            this.TextureSmoothingExit = 0.2f;
            this.StartSceneOnEnterState = 1;
            this._previousEnterShader = -1610612735;
            this._previousExitShader = -1610612735;
        }
        private static ProCamera2DTransitionsFX()
        {
            mem2[0] = -1610603327;
        }
    
    }

}
