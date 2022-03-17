using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DCameraWindow : BasePC2D, IPositionDeltaChanger
    {
        // Fields
        public static string ExtensionName;
        public UnityEngine.Rect CameraWindowRect;
        private UnityEngine.Rect _cameraWindowRectInWorldCoords;
        public bool IsRelativeSizeAndPosition;
        private int _pdcOrder;
        
        // Properties
        public int PDCOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.AddPositionDeltaChanger(changer:  1001937936);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1002049936)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePositionDeltaChanger(changer:  R4);
        }
        public UnityEngine.Vector3 AdjustDelta(float deltaTime, UnityEngine.Vector3 originalDelta)
        {
            var val_11;
            var val_12;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCameraWindow val_38;
            var val_39;
            float val_40;
            float val_41;
            float val_42;
            var val_44;
            float val_45;
            var val_46;
            var val_47;
            float val_48;
            float val_49;
            var val_50;
            float val_51;
            float val_52;
            var val_53;
            var val_54;
            float val_55;
            val_40 = originalDelta.z;
            if(originalDelta.x.enabled == false)
            {
                goto label_1;
            }
            
            val_41 = mem[originalDelta.x + 48];
            val_41 = originalDelta.x + 48;
            val_42 = mem[originalDelta.x + 52];
            val_42 = originalDelta.x + 52;
            val_40 = mem[originalDelta.x + 56];
            val_40 = originalDelta.x + 56;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_2 = originalDelta.x.ProCamera2D;
            UnityEngine.Rect val_3 = GetRectAroundTransf(rectNormalized:  new UnityEngine.Rect() {m_XMin = originalDelta.x, m_YMin = originalDelta.x + 44, m_Width = val_41, m_Height = val_42}, rectSize:  new UnityEngine.Vector2() {x = val_40, y = originalDelta.x + 72}, transf:  originalDelta.x + 76, isRelative:  originalDelta.x + 36);
            float val_4 = originalDelta.x + 60;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_5 = originalDelta.x.ProCamera2D;
            float val_6 = val_4.x;
            float val_7 = val_4.width;
            float val_8 = val_4 + val_4;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_9 = originalDelta.x.ProCamera2D;
            val_44 = mem[originalDelta.x + 56];
            val_44 = originalDelta.x + 56;
            if(originalDelta.x >= 0f)
            {
                goto label_5;
            }
            
            float val_10 = val_4.x;
            if(originalDelta.x <= 0f)
            {
                goto label_6;
            }
            
            val_45 = 0f;
            goto label_7;
            label_1:
            this = val_40;
            mem[1152921509903976212] = val_12;
            mem[1152921509903976216] = val_11;
            return new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
            label_5:
            val_40 = mem[originalDelta.x + 16];
            val_40 = originalDelta.x + 16;
            UnityEngine.Vector3 val_13 = localPosition;
            float val_14 = val_40.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R7, z = R8});
            val_46 = val_40;
            val_47 = val_4;
            float val_15 = val_47.width;
            val_48 = 0.5f;
            goto label_11;
            label_6:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_16 = originalDelta.x.ProCamera2D;
            val_40 = mem[originalDelta.x + 16];
            val_40 = originalDelta.x + 16;
            val_44 = mem[originalDelta.x + 56];
            val_44 = originalDelta.x + 56;
            UnityEngine.Vector3 val_17 = localPosition;
            float val_18 = val_40.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R7, z = R8});
            val_46 = val_40;
            val_47 = val_4;
            float val_19 = val_47.width;
            val_48 = -0.5f;
            label_11:
            float val_20 = originalDelta.x + 44.x;
            if((originalDelta.x + 76) != 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_21 = originalDelta.x.ProCamera2D;
                val_49 = mem[originalDelta.x + 72];
                val_49 = originalDelta.x + 72;
            }
            else
            {
                    val_49 = 1f;
            }
            
            val_45 = val_44 - val_46;
            label_7:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_22 = originalDelta.x.ProCamera2D;
            float val_23 = val_4.y;
            float val_24 = val_4.height;
            float val_25 = val_4 + val_4;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_26 = originalDelta.x.ProCamera2D;
            val_50 = mem[originalDelta.x + 60];
            val_50 = originalDelta.x + 60;
            if(originalDelta.x >= 0f)
            {
                goto label_20;
            }
            
            float val_27 = val_4.y;
            val_51 = val_4;
            if(originalDelta.x <= 0f)
            {
                goto label_21;
            }
            
            val_52 = 0f;
            goto label_22;
            label_20:
            val_40 = mem[originalDelta.x + 20];
            val_40 = originalDelta.x + 20;
            UnityEngine.Vector3 val_28 = localPosition;
            float val_29 = val_40.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R7, z = R8});
            val_53 = val_40;
            val_54 = val_4;
            float val_30 = val_54.height;
            val_55 = 0.5f;
            goto label_25;
            label_21:
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_31 = originalDelta.x.ProCamera2D;
            val_40 = mem[originalDelta.x + 20];
            val_40 = originalDelta.x + 20;
            val_50 = mem[originalDelta.x + 60];
            val_50 = originalDelta.x + 60;
            UnityEngine.Vector3 val_32 = localPosition;
            float val_33 = val_40.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R7, z = R8});
            val_53 = val_40;
            val_54 = val_4;
            float val_34 = val_54.height;
            val_55 = -0.5f;
            label_25:
            float val_35 = originalDelta.x + 44.y;
            if((originalDelta.x + 76) != 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_36 = originalDelta.x.ProCamera2D;
                val_51 = mem[originalDelta.x + 76];
                val_51 = originalDelta.x + 76;
            }
            else
            {
                    val_51 = 1f;
            }
            
            val_52 = val_50 - val_53;
            label_22:
            UnityEngine.Vector3 val_37 = Invoke(arg1:  val_51, arg2:  val_32.y);
            mem[1152921509903976216] = val_39;
            this = val_38;
            return new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z};
        }
        public int get_PDCOrder()
        {
            return (int)this._pdcOrder;
        }
        public void set_PDCOrder(int value)
        {
            this._pdcOrder = value;
        }
        private UnityEngine.Rect GetRectAroundTransf(UnityEngine.Rect rectNormalized, UnityEngine.Vector2 rectSize, UnityEngine.Transform transf, bool isRelative)
        {
            var val_1;
            float val_5;
            float val_6;
            float val_8;
            UnityEngine.Transform val_15;
            float val_16;
            val_15 = transf;
            val_16 = rectSize.y;
            float val_2 = rectNormalized.m_YMin.width;
            float val_3 = rectNormalized.m_YMin.height;
            if(val_1 == 0)
            {
                    UnityEngine.Vector2 val_4 = UnityEngine.Vector2.one;
                val_16 = val_5;
                val_15 = val_6;
            }
            
            uint val_15 = 1002489976;
            UnityEngine.Vector3 val_7 = localPosition;
            uint val_16 = 1002489976;
            val_15 = val_15 * val_16;
            float val_9 = rectNormalized.m_XMin + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_5, y = val_6, z = val_8});
            if(val_1 != 0)
            {
                    1f = rectSize.y;
            }
            
            float val_10 = rectNormalized.m_YMin.x;
            val_16 = val_16 * val_15;
            UnityEngine.Vector3 val_11 = localPosition;
            float val_12 = rectNormalized.m_XMin + 20.Invoke(arg:  new UnityEngine.Vector3() {x = R5, y = R6, z = R7});
            if(val_1 != 0)
            {
                    1f = transf;
            }
            
            float val_13 = rectNormalized.m_YMin.y;
            this = new UnityEngine.Rect(x:  1002489976, y:  val_11.y, width:  val_11.z, height:  null);
            return new UnityEngine.Rect() {m_XMin = 1002489976, m_YMin = val_11.y, m_Width = val_11.z};
        }
        public ProCamera2DCameraWindow()
        {
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            this.IsRelativeSizeAndPosition = true;
        }
        private static ProCamera2DCameraWindow()
        {
            mem2[0] = -1610609697;
        }
    
    }

}
