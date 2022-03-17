using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DPixelPerfect : BasePC2D, IPositionOverrider
    {
        // Fields
        public static string ExtensionName;
        public float PixelsPerUnit;
        public Com.LuisPedroFonseca.ProCamera2D.AutoScaleMode ViewportAutoScale;
        public UnityEngine.Vector2 TargetViewportSizeInPixels;
        private int _zoom;
        public bool SnapMovementToGrid;
        public bool SnapCameraToGrid;
        public bool DrawGrid;
        public UnityEngine.Color GridColor;
        public float GridDensity;
        private float <ViewportScale>k__BackingField;
        private float _pixelStep;
        private UnityEngine.Transform _parent;
        private int _poOrder;
        
        // Properties
        public int Zoom { get; set; }
        public float ViewportScale { get; set; }
        public float PixelStep { get; }
        public int POOrder { get; set; }
        
        // Methods
        public int get_Zoom()
        {
            return (int)this._zoom;
        }
        public void set_Zoom(int value)
        {
            this._zoom = value;
            this.ResizeCameraToPixelPerfect();
        }
        public float get_ViewportScale()
        {
            return (float)S0;
        }
        private void set_ViewportScale(float value)
        {
            this.<ViewportScale>k__BackingField = ;
        }
        public float get_PixelStep()
        {
            return (float)S0;
        }
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(this.orthographic != false)
            {
                    this.ResizeCameraToPixelPerfect();
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
                this.AddPositionOverrider(overrider:  1024749520);
                return;
            }
            
            this.enabled = false;
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1024861520)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePositionOverrider(overrider:  R4);
        }
        public UnityEngine.Vector3 OverridePosition(float deltaTime, UnityEngine.Vector3 originalPosition)
        {
            float val_1;
            float val_2;
            float val_7;
            float val_8;
            float val_9;
            float val_27;
            float val_28;
            var val_29;
            var val_30;
            var val_31;
            float val_33;
            float val_34;
            var val_35;
            var val_36;
            val_27 = originalPosition.z;
            val_28 = val_1;
            val_29 = val_2;
            if(originalPosition.x.enabled != false)
            {
                    val_30 = mem[originalPosition.x + 92];
                val_30 = originalPosition.x + 92;
                if(((originalPosition.x + 64) != 0) && ((originalPosition.x + 65) == 0))
            {
                    var val_27 = originalPosition.x + 44;
                float val_26 = (float)originalPosition.x + 60;
                val_26 = (originalPosition.x + 88) + val_26;
                val_31 = val_26 + (-1f);
                val_27 = val_27 * val_31;
                val_30 = 1f / val_27;
            }
            
                UnityEngine.Transform val_4 = originalPosition.x + 36.parent;
                mem2[0] = originalPosition.x + 36;
                if((originalPosition.x + 96) != 0)
            {
                    UnityEngine.Vector3 val_6 = position;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
                val_28 = val_1;
                val_33 = val_2;
                if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9}, rhs:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9})) != false)
            {
                    UnityEngine.Vector3 val_12 = position;
                float val_14 = Com.LuisPedroFonseca.ProCamera2D.Utils.AlignToGrid(input:  originalPosition.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9}), gridSize:  val_12.y);
                UnityEngine.Vector3 val_15 = position;
                float val_17 = Com.LuisPedroFonseca.ProCamera2D.Utils.AlignToGrid(input:  originalPosition.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9}), gridSize:  val_15.y);
                UnityEngine.Vector3 val_18 = position;
                UnityEngine.Vector3 val_20 = Invoke(arg1:  originalPosition.x + 24.Invoke(arg:  new UnityEngine.Vector3() {x = val_7, y = val_8, z = val_9}), arg2:  val_18.y, arg3:  val_18.z);
                originalPosition.x + 96.position = new UnityEngine.Vector3() {x = R5, y = R7, z = R8};
                val_28 = val_1;
                val_34 = val_27;
                val_33 = val_2;
            }
            
            }
            
                val_35 = val_30;
                float val_22 = Com.LuisPedroFonseca.ProCamera2D.Utils.AlignToGrid(input:  originalPosition.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_34, y = val_33, z = val_28}), gridSize:  val_20.y);
                val_36 = originalPosition.x + 20;
                UnityEngine.Vector3 val_25 = Invoke(arg1:  Com.LuisPedroFonseca.ProCamera2D.Utils.AlignToGrid(input:  originalPosition.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_34, y = val_33, z = val_28}), gridSize:  val_20.y), arg2:  val_20.y, arg3:  val_20.z);
                mem[1152921509926787800] = val_9;
                this = val_7;
                return new UnityEngine.Vector3() {x = deltaTime};
            }
            
            this = val_27;
            mem[1152921509926787796] = val_29;
            mem[1152921509926787800] = val_28;
            return new UnityEngine.Vector3() {x = deltaTime};
        }
        public int get_POOrder()
        {
            return (int)this._poOrder;
        }
        public void set_POOrder(int value)
        {
            this._poOrder = value;
        }
        public void ResizeCameraToPixelPerfect()
        {
            float val_6;
            float val_1 = this.CalculateViewportScale();
            val_6 = this.PixelsPerUnit;
            this.<ViewportScale>k__BackingField = this;
            if(this.SnapMovementToGrid != true)
            {
                    uint val_6 = 1025309520;
                val_6 = val_6 + (float)this._zoom;
                val_6 = val_6 + (-1f);
                val_6 = val_6 * val_6;
            }
            
            float val_9 = 1f;
            val_6 = val_9 / val_6;
            this._pixelStep = val_6;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = this.ProCamera2D;
            float val_7 = this.PixelsPerUnit;
            val_7 = val_9 / val_7;
            float val_8 = (float)this._zoom;
            val_8 = (this.<ViewportScale>k__BackingField) + val_8;
            val_8 = val_8 + (-1f);
            val_7 = ((float)this.pixelHeight * 0.5f) * val_7;
            val_9 = val_7 / val_8;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = this.ProCamera2D;
            this.UpdateScreenSize(newSize:  val_7, duration:  null, easeType:  val_9);
        }
        public float CalculateViewportScale()
        {
            var val_5;
            var val_7;
            var val_8;
            float val_9;
            if(this.ViewportAutoScale == 0)
            {
                    return 1f;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            float val_7 = (float)this.pixelWidth;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = this.ProCamera2D;
            val_7 = val_7 / this.TargetViewportSizeInPixels;
            float val_8 = (float)this.pixelHeight;
            val_8 = val_8 / S2;
            if(this > 0)
            {
                    val_7 = val_8;
            }
            
            if(this.ViewportAutoScale == 3)
            {
                goto label_5;
            }
            
            if(this.ViewportAutoScale == 2)
            {
                goto label_6;
            }
            
            if(this.ViewportAutoScale != 1)
            {
                    return 1f;
            }
            
            val_7 = val_7;
            return 1f;
            label_5:
            if(this.ViewportAutoScale >= 3)
            {
                goto label_10;
            }
            
            if(this.ViewportAutoScale != 3)
            {
                goto label_11;
            }
            
            val_8 = val_5;
            val_9 = -1f;
            goto label_12;
            label_6:
            val_7 = val_7;
            return 1f;
            label_10:
            if(this.ViewportAutoScale != 3)
            {
                goto label_14;
            }
            
            val_8 = val_5;
            val_9 = 1f;
            label_12:
            if((0 & 1) != 0)
            {
                    this.TargetViewportSizeInPixels + val_9 = this.TargetViewportSizeInPixels;
            }
            
            return 1f;
            label_11:
            float val_9 = -0.5f;
            val_9 = val_7 + val_9;
            return 1f;
            label_14:
            float val_10 = 0.5f;
            val_10 = val_7 + val_10;
            return 1f;
        }
        private float CalculatePixelStep(float viewportScale)
        {
            float val_1 = this.PixelsPerUnit;
            if(this.SnapMovementToGrid != true)
            {
                    var val_1 = R1;
                val_1 = (float)this._zoom + val_1;
                val_1 = val_1 + (-1f);
                val_1 = val_1 * val_1;
            }
            
            val_1 = 1f / val_1;
            return (float)val_1;
        }
        public ProCamera2DPixelPerfect()
        {
            this.PixelsPerUnit = 32f;
            this.SnapCameraToGrid = true;
            UnityEngine.Color val_1 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
            this._pixelStep = -1f;
            this._poOrder = 2000;
        }
        private static ProCamera2DPixelPerfect()
        {
            mem2[0] = -1610605359;
        }
    
    }

}
