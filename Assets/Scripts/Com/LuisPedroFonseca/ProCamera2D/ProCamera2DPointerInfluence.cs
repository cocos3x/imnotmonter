using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DPointerInfluence : BasePC2D, IPreMover
    {
        // Fields
        public static string ExtensionName;
        public float MaxHorizontalInfluence;
        public float MaxVerticalInfluence;
        public float InfluenceSmoothness;
        private UnityEngine.Vector2 _influence;
        private UnityEngine.Vector2 _velocity;
        private int _prmOrder;
        
        // Properties
        public int PrMOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.AddPreMover(mover:  1025885904);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1025997904)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePreMover(mover:  R4);
        }
        public override void OnReset()
        {
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            this._influence = new UnityEngine.Vector2();
            mem[1152921509927924236] = ???;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            this._velocity = new UnityEngine.Vector2();
            mem[1152921509927924244] = ???;
        }
        public void PreMove(float deltaTime)
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            R5.ApplyInfluence(deltaTime:  deltaTime);
        }
        public int get_PrMOrder()
        {
            return (int)this._prmOrder;
        }
        public void set_PrMOrder(int value)
        {
            this._prmOrder = value;
        }
        private void ApplyInfluence(float deltaTime)
        {
            float val_3;
            float val_4;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
            UnityEngine.Vector3 val_6 = ScreenToViewportPoint(position:  new UnityEngine.Vector3() {x = R1, y = val_3, z = val_4});
            float val_8 = Com.LuisPedroFonseca.ProCamera2D.Utils.Remap(value:  Com.LuisPedroFonseca.ProCamera2D.Utils.Remap(value:  val_6.x, from1:  val_6.y, to1:  val_6.z, from2:  null, to2:  null), from1:  val_6.y, to1:  val_6.z, from2:  null, to2:  null);
            float val_11 = this.MaxHorizontalInfluence;
            val_11 = val_3 * val_11;
            float val_12 = val_4;
            val_12 = val_12 * this.MaxVerticalInfluence;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.SmoothDamp(current:  new UnityEngine.Vector2() {x = 0.04293133f, y = this._influence}, target:  new UnityEngine.Vector2() {x = 1f, y = val_11}, currentVelocity: ref  new UnityEngine.Vector2() {x = val_12, y = this._velocity}, smoothTime:  val_12, maxSpeed:  val_6.y, deltaTime:  this.MaxVerticalInfluence);
            this._influence = val_3;
            mem[1152921509928372236] = val_4;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_10 = this.ProCamera2D;
            this.ApplyInfluence(influence:  new UnityEngine.Vector2() {x = this._influence, y = 0.0429762f});
        }
        public ProCamera2DPointerInfluence()
        {
            this.MaxHorizontalInfluence = 3f;
            this.MaxVerticalInfluence = 2f;
            this.InfluenceSmoothness = 0.2f;
            this._prmOrder = 3000;
        }
        private static ProCamera2DPointerInfluence()
        {
            mem2[0] = -1610605319;
        }
    
    }

}
