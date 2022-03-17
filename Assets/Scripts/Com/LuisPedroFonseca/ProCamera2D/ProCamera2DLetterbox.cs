using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DLetterbox : MonoBehaviour
    {
        // Fields
        public float Amount;
        public UnityEngine.Color Color;
        private UnityEngine.Material _material;
        private int TopPropertyID;
        private int BottomPropertyID;
        private int ColorPropertyID;
        private float _previousAmount;
        
        // Properties
        private UnityEngine.Material material { get; }
        
        // Methods
        private UnityEngine.Material get_material()
        {
            if(this._material != 0)
            {
                    return;
            }
            
            UnityEngine.Shader val_2 = UnityEngine.Shader.Find(name:  -1610607741);
            UnityEngine.Material val_3 = 536890261;
            val_3 = new UnityEngine.Material(shader:  -1610607741);
            val_3.hideFlags = 61;
            this._material = val_3;
        }
        private void OnEnable()
        {
            this._previousAmount = 3.402823E+38f;
            if(this.TopPropertyID == 0)
            {
                    this.TopPropertyID = UnityEngine.Shader.PropertyToID(name:  -1610602011);
            }
            
            if(this.BottomPropertyID == 0)
            {
                    this.BottomPropertyID = UnityEngine.Shader.PropertyToID(name:  -1610602161);
            }
            
            if(this.ColorPropertyID != 0)
            {
                    return;
            }
            
            mem2[0] = UnityEngine.Shader.PropertyToID(name:  -1610602151);
        }
        private void OnRenderImage(UnityEngine.RenderTexture sourceTexture, UnityEngine.RenderTexture destTexture)
        {
            var val_10;
            float val_11;
            float val_12;
            val_10 = 23000909;
            if((UnityEngine.Mathf.Approximately(a:  null, b:  null)) == true)
            {
                goto label_1;
            }
            
            UnityEngine.Material val_2 = this.material;
            val_10 = this;
            if(1051743120 != 0)
            {
                goto label_4;
            }
            
            label_1:
            UnityEngine.Graphics.Blit(source:  sourceTexture, dest:  destTexture);
            return;
            label_4:
            if(mem[536890411] > 0)
            {
                    float val_5 = UnityEngine.Mathf.Clamp01(value:  System.Math.Abs(this.Amount - this._previousAmount));
                this.Amount = this.Amount;
                UnityEngine.Material val_6 = this.material;
                float val_11 = 1f;
                val_11 = val_11 - this.Amount;
                this.SetFloat(nameID:  this.TopPropertyID, value:  val_11);
                UnityEngine.Material val_7 = this.material;
                this.SetFloat(nameID:  this.BottomPropertyID, value:  val_11);
                UnityEngine.Material val_8 = this.material;
                if(this == 0)
            {
                    val_12 = mem[this.Color + (4)];
                val_11 = mem[this.Color + (0)];
            }
            
                this.SetColor(nameID:  this.ColorPropertyID, value:  new UnityEngine.Color() {r = val_11, g = val_12, b = mem[this.Color + (8)], a = mem[this.Color + (12)]});
            }
            
            UnityEngine.Material val_9 = this.material;
            UnityEngine.Graphics.Blit(source:  sourceTexture, dest:  destTexture, mat:  1051743120);
            this._previousAmount = this.Amount;
        }
        private void OnDisable()
        {
            if((UnityEngine.Object.op_Implicit(exists:  this._material)) == false)
            {
                    return;
            }
            
            UnityEngine.Object.DestroyImmediate(obj:  this._material);
        }
        public void TweenTo(float targetAmount, float duration)
        {
            this.StopAllCoroutines();
            System.Collections.IEnumerator val_1 = this.TweenToRoutine(targetAmount:  targetAmount, duration:  duration);
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1051991696);
        }
        private System.Collections.IEnumerator TweenToRoutine(float targetAmount, float duration)
        {
            float val_2 = R2;
            ProCamera2DLetterbox.<TweenToRoutine>d__13 val_1 = 536900591;
            val_1 = new ProCamera2DLetterbox.<TweenToRoutine>d__13(<>1__state:  0);
            if(val_1 != 0)
            {
                    val_2 = val_1;
                mem[536900607] = this;
                mem[536900615] = R1;
            }
            else
            {
                    mem[16] = this;
                mem[24] = R1;
            }
            
            mem[536900611] = val_2;
        }
        public ProCamera2DLetterbox()
        {
            this._previousAmount = 3.402823E+38f;
        }
    
    }

}
