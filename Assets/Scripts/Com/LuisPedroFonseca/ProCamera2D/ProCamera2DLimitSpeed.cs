using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DLimitSpeed : BasePC2D, IPositionDeltaChanger
    {
        // Fields
        public static string ExtensionName;
        public bool LimitHorizontalSpeed;
        public float MaxHorizontalSpeed;
        public bool LimitVerticalSpeed;
        public float MaxVerticalSpeed;
        private int _pdcOrder;
        
        // Properties
        public int PDCOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.AddPositionDeltaChanger(changer:  1016767696);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1016879696)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePositionDeltaChanger(changer:  R4);
        }
        public UnityEngine.Vector3 AdjustDelta(float deltaTime, UnityEngine.Vector3 originalDelta)
        {
            float val_1;
            float val_2;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DLimitSpeed val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_18;
            val_15 = originalDelta.y;
            if(originalDelta.x.enabled != false)
            {
                    float val_15 = 1f;
                val_15 = val_15 / val_15;
                float val_4 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = originalDelta.z, y = val_2, z = val_1});
                val_15 = mem[originalDelta.x + 20];
                val_15 = originalDelta.x + 20;
                val_16 = val_15 * (originalDelta.x + 16);
                if((originalDelta.x + 41) != 0)
            {
                    var val_6 = (originalDelta.x + 44) ^ 2147483648;
                val_16 = val_16;
            }
            
                val_18 = val_15 * val_15;
                if((originalDelta.x + 48) != 0)
            {
                    var val_8 = (originalDelta.x + 52) ^ 2147483648;
                float val_9 = UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.Clamp(value:  val_15.Invoke(arg:  new UnityEngine.Vector3() {x = originalDelta.z, y = val_2, z = val_1}), min:  null, max:  null), min:  null, max:  null);
                val_18 = val_18;
            }
            
                float val_11 = val_18 * val_15;
                UnityEngine.Vector3 val_12 = Invoke(arg1:  val_16 * val_15, arg2:  null);
                mem[1152921509918805976] = val_14;
                this = val_13;
                return new UnityEngine.Vector3() {x = deltaTime};
            }
            
            mem[1152921509918805976] = val_1;
            return new UnityEngine.Vector3() {x = deltaTime};
        }
        public int get_PDCOrder()
        {
            return (int)this._pdcOrder;
        }
        public void set_PDCOrder(int value)
        {
            this._pdcOrder = value;
        }
        public ProCamera2DLimitSpeed()
        {
            this.MaxHorizontalSpeed = 2f;
            this.LimitHorizontalSpeed = true;
            this.LimitVerticalSpeed = true;
            this.MaxVerticalSpeed = 2f;
            this._pdcOrder = 1000;
        }
        private static ProCamera2DLimitSpeed()
        {
            mem2[0] = -1610606659;
        }
    
    }

}
