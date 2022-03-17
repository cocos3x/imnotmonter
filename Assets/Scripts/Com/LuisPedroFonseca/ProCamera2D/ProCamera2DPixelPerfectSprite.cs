using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DPixelPerfectSprite : BasePC2D, IPostMover
    {
        // Fields
        public bool IsAMovingObject;
        public bool IsAChildSprite;
        public UnityEngine.Vector2 LocalPosition;
        public int SpriteScale;
        private UnityEngine.Sprite _sprite;
        private Com.LuisPedroFonseca.ProCamera2D.ProCamera2DPixelPerfect _pixelPerfectPlugin;
        private UnityEngine.Vector3 _initialScale;
        private int _prevSpriteScale;
        private int _pmOrder;
        
        // Properties
        public int PMOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(1052439696 == 0)
            {
                    this.enabled = false;
                return;
            }
            
            this.GetPixelPerfectPlugin();
            this.GetSprite();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            this.AddPostMover(mover:  1052439696);
        }
        private void Start()
        {
            this.SetAsPixelPerfect();
        }
        public void PostMove(float deltaTime)
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            R4.Step();
        }
        public int get_PMOrder()
        {
            return (int)this._pmOrder;
        }
        public void set_PMOrder(int value)
        {
            this._pmOrder = value;
        }
        private void Step()
        {
            if(this._pixelPerfectPlugin == 0)
            {
                    return;
            }
            
            if((R4 + 60.enabled) == false)
            {
                    return;
            }
            
            if((R4 + 41) != 0)
            {
                    R4 + 41 = R4;
                R4 + 41.SetAsPixelPerfect();
            }
            
            mem2[0] = R4 + 52;
        }
        private void GetPixelPerfectPlugin()
        {
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
            this._pixelPerfectPlugin = this;
        }
        private void GetSprite()
        {
            UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
            if(1053231888 == 0)
            {
                    return;
            }
            
            UnityEngine.Sprite val_3 = R5.sprite;
            mem2[0] = R5;
        }
        public void SetAsPixelPerfect()
        {
            float val_7;
            float val_8;
            float val_9;
            var val_27;
            var val_28;
            var val_29;
            float val_30;
            float val_31;
            float val_32;
            if(this.IsAChildSprite != false)
            {
                    float val_2 = Com.LuisPedroFonseca.ProCamera2D.Utils.AlignToGrid(input:  Com.LuisPedroFonseca.ProCamera2D.Utils.AlignToGrid(input:  null, gridSize:  null), gridSize:  null);
                UnityEngine.Vector3 val_3 = localPosition;
                UnityEngine.Vector3 val_5 = Invoke(arg1:  R5.Invoke(arg:  new UnityEngine.Vector3() {x = R7, y = R8, z = SB}), arg2:  val_3.y, arg3:  val_3.z);
                ???.localPosition = new UnityEngine.Vector3() {x = R4, y = R5, z = R6};
            }
            
            UnityEngine.Vector3 val_6 = position;
            float val_11 = Com.LuisPedroFonseca.ProCamera2D.Utils.AlignToGrid(input:  ???.Invoke(arg:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9}), gridSize:  val_6.y);
            UnityEngine.Vector3 val_12 = position;
            float val_14 = Com.LuisPedroFonseca.ProCamera2D.Utils.AlignToGrid(input:  ???.Invoke(arg:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9}), gridSize:  val_12.y);
            UnityEngine.Vector3 val_15 = position;
            UnityEngine.Vector3 val_17 = Invoke(arg1:  val_8.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = SB}), arg2:  val_15.y, arg3:  val_15.z);
            R8.position = new UnityEngine.Vector3() {x = R4, y = R5, z = R6};
            if(this.SpriteScale == 0)
            {
                goto label_18;
            }
            
            float val_27 = -1f;
            val_27 = val_27 / (float)this.SpriteScale;
            if(this.SpriteScale < 0)
            {
                    (float)this.SpriteScale = val_27;
            }
            
            float val_18 = this._sprite.pixelsPerUnit;
            float val_28 = 1f;
            val_28 = val_28 / this._pixelPerfectPlugin.PixelsPerUnit;
            (float)this.SpriteScale = (float)this.SpriteScale * this._sprite;
            UnityEngine.Vector3 val_19 = localScale;
            float val_20 = UnityEngine.Mathf.Sign(f:  val_19.x);
            (float)this.SpriteScale = (float)this.SpriteScale * val_28;
            UnityEngine.Vector3 val_21 = localScale;
            float val_22 = UnityEngine.Mathf.Sign(f:  val_21.x);
            val_27 = 0;
            UnityEngine.Vector3 val_23 = localScale;
            val_28 = val_9;
            val_29 = (float)this.SpriteScale * val_7;
            val_30 = val_29;
            val_31 = (float)this.SpriteScale * val_8;
            val_32 = val_28;
            goto label_25;
            label_18:
            if(this._prevSpriteScale == 0)
            {
                goto label_26;
            }
            
            val_30 = mem[this._initialScale + (0)];
            val_31 = mem[this._initialScale + (4)];
            val_32 = mem[this._initialScale + (8)];
            label_25:
            R5.localScale = new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32};
            return;
            label_26:
            UnityEngine.Vector3 val_26 = localScale;
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(1053505040 == 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePostMover(mover:  R4);
        }
        public ProCamera2DPixelPerfectSprite()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.one;
            this._pmOrder = 2000;
        }
    
    }

}
