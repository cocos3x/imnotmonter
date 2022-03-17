using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DLimitDistance : BasePC2D, IPositionDeltaChanger
    {
        // Fields
        public static string ExtensionName;
        public bool UseTargetsPosition;
        public bool LimitTopCameraDistance;
        public float MaxTopTargetDistance;
        public bool LimitBottomCameraDistance;
        public float MaxBottomTargetDistance;
        public bool LimitLeftCameraDistance;
        public float MaxLeftTargetDistance;
        public bool LimitRightCameraDistance;
        public float MaxRightTargetDistance;
        private int _pdcOrder;
        
        // Properties
        public int PDCOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            this.AddPositionDeltaChanger(changer:  1015983696);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1016095696)) == false)
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
            float val_16;
            float val_17;
            float val_18;
            float val_63;
            float val_64;
            float val_65;
            var val_66;
            var val_67;
            float val_68;
            float val_69;
            float val_70;
            var val_71;
            var val_72;
            float val_73;
            var val_74;
            var val_75;
            var val_76;
            float val_77;
            float val_78;
            var val_80;
            float val_81;
            val_63 = originalDelta.z;
            val_64 = val_1;
            val_65 = val_2;
            if(originalDelta.x.enabled == false)
            {
                goto label_1;
            }
            
            float val_4 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_63, y = val_65, z = val_64});
            float val_5 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_63, y = val_65, z = val_64});
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = originalDelta.x.ProCamera2D;
            if((originalDelta.x + 41) == 0)
            {
                goto label_5;
            }
            
            val_66 = 22732340;
            float val_7 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = originalDelta.x + 92, y = originalDelta.x + 96, z = originalDelta.x + 100});
            val_67 = mem[originalDelta.x + 20];
            val_67 = originalDelta.x + 20;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_8 = originalDelta.x.ProCamera2D;
            val_68 = mem[originalDelta.x + 92];
            val_68 = originalDelta.x + 92;
            val_69 = mem[originalDelta.x + 96];
            val_69 = originalDelta.x + 96;
            val_70 = mem[originalDelta.x + 100];
            val_70 = originalDelta.x + 100;
            goto label_8;
            label_1:
            mem[1152921509918021976] = val_64;
            return new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z};
            label_5:
            val_66 = 22732340;
            float val_9 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = originalDelta.x + 104, y = originalDelta.x + 108, z = originalDelta.x + 112});
            val_67 = mem[originalDelta.x + 20];
            val_67 = originalDelta.x + 20;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_10 = originalDelta.x.ProCamera2D;
            val_68 = mem[originalDelta.x + 104];
            val_68 = originalDelta.x + 104;
            val_69 = mem[originalDelta.x + 108];
            val_69 = originalDelta.x + 108;
            val_70 = mem[originalDelta.x + 112];
            val_70 = originalDelta.x + 112;
            label_8:
            val_71 = originalDelta.x + 20;
            float val_11 = val_67.Invoke(arg:  new UnityEngine.Vector3() {x = val_68, y = val_69, z = val_70});
            if((originalDelta.x + 42) == 0)
            {
                goto label_13;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_12 = originalDelta.x.ProCamera2D;
            float val_13 = (originalDelta.x + 76) * 0.5f;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_14 = originalDelta.x.ProCamera2D;
            val_13 = (originalDelta.x + 44) * val_13;
            val_72 = 0;
            UnityEngine.Vector3 val_15 = LocalPosition;
            val_73 = originalDelta.x + 16;
            float val_19 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
            var val_58 = originalDelta.x + 20;
            val_58 = val_71 + val_58;
            val_58 = val_13 + val_58;
            if((originalDelta.x + 20) <= 0)
            {
                goto label_20;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_20 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_21 = LocalPosition;
            float val_22 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
            var val_59 = originalDelta.x + 20;
            val_72 = 1;
            val_59 = val_13 + val_59;
            val_71 = val_67 - val_59;
            goto label_20;
            label_13:
            val_72 = 0;
            val_73 = originalDelta.x + 16;
            label_20:
            if((originalDelta.x + 48) != 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_23 = originalDelta.x.ProCamera2D;
                float val_24 = (originalDelta.x + 76) * 0.5f;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_25 = originalDelta.x.ProCamera2D;
                val_24 = (originalDelta.x + 52) * val_24;
                UnityEngine.Vector3 val_26 = LocalPosition;
                float val_27 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
                var val_60 = originalDelta.x + 20;
                val_60 = val_71 + val_60;
                val_60 = val_60 - val_24;
                if((originalDelta.x + 20) < 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_28 = originalDelta.x.ProCamera2D;
                UnityEngine.Vector3 val_29 = LocalPosition;
                float val_30 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
                var val_61 = originalDelta.x + 20;
                val_72 = 1;
                val_61 = val_61 - val_24;
                val_71 = val_67 - val_61;
            }
            
            }
            
            val_74 = val_73;
            if((originalDelta.x + 56) == 0)
            {
                goto label_28;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_31 = originalDelta.x.ProCamera2D;
            float val_32 = (originalDelta.x + 72) * 0.5f;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_33 = originalDelta.x.ProCamera2D;
            val_32 = (originalDelta.x + 60) * val_32;
            val_75 = 0;
            UnityEngine.Vector3 val_34 = LocalPosition;
            val_76 = 22732340;
            float val_35 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
            var val_62 = originalDelta.x + 16;
            val_62 = val_74 + val_62;
            val_62 = val_62 - val_32;
            if((originalDelta.x + 16) >= 0)
            {
                goto label_35;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_36 = originalDelta.x.ProCamera2D;
            UnityEngine.Vector3 val_37 = LocalPosition;
            float val_38 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
            var val_63 = originalDelta.x + 16;
            val_75 = 1;
            val_63 = val_63 - val_32;
            val_74 = (originalDelta.x + 16) - val_63;
            goto label_35;
            label_28:
            val_75 = 0;
            val_76 = 22732340;
            label_35:
            if((originalDelta.x + 64) != 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_39 = originalDelta.x.ProCamera2D;
                float val_40 = (originalDelta.x + 72) * 0.5f;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_41 = originalDelta.x.ProCamera2D;
                val_40 = (originalDelta.x + 68) * val_40;
                UnityEngine.Vector3 val_42 = LocalPosition;
                float val_43 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
                var val_64 = originalDelta.x + 16;
                val_64 = val_74 + val_64;
                val_64 = val_40 + val_64;
                if((originalDelta.x + 16) > 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_44 = originalDelta.x.ProCamera2D;
                UnityEngine.Vector3 val_45 = LocalPosition;
                float val_46 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18});
                var val_65 = originalDelta.x + 16;
                val_75 = 1;
                val_65 = val_40 + val_65;
                val_74 = (originalDelta.x + 16) - val_65;
            }
            
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_47 = originalDelta.x.ProCamera2D;
            val_64 = this;
            val_65 = val_1;
            if(val_75 != 0)
            {
                    UnityEngine.Vector2 val_48 = CameraTargetPositionSmoothed;
                val_77 = val_2;
                float val_49 = originalDelta.x + 16.Invoke(arg:  new UnityEngine.Vector3() {x = val_63, y = val_77, z = val_65});
                val_78 = (val_74 + val_16) - (originalDelta.x + 16);
            }
            else
            {
                    UnityEngine.Vector2 val_51 = CameraTargetPositionSmoothed;
                val_78 = val_16;
                val_77 = val_2;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_52 = originalDelta.x.ProCamera2D;
            if(val_72 != 0)
            {
                    UnityEngine.Vector2 val_53 = CameraTargetPositionSmoothed;
                float val_54 = originalDelta.x + 20.Invoke(arg:  new UnityEngine.Vector3() {x = val_63, y = val_77, z = val_65});
                val_80 = val_71 + val_17;
                val_81 = val_80 - (originalDelta.x + 20);
            }
            else
            {
                    UnityEngine.Vector2 val_55 = CameraTargetPositionSmoothed;
                val_81 = val_17;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_56 = originalDelta.x.ProCamera2D;
            val_63 = originalDelta.x;
            val_63.CameraTargetPositionSmoothed = new UnityEngine.Vector2() {x = val_78, y = val_81};
            UnityEngine.Vector3 val_57 = Invoke(arg1:  val_55.x, arg2:  val_55.y);
            mem[1152921509918021976] = val_18;
            this = val_16;
            return new UnityEngine.Vector3() {x = val_57.x, y = val_57.y, z = val_57.z};
        }
        public int get_PDCOrder()
        {
            return (int)this._pdcOrder;
        }
        public void set_PDCOrder(int value)
        {
            this._pdcOrder = value;
        }
        public ProCamera2DLimitDistance()
        {
            this.MaxTopTargetDistance = 0.8f;
            this.UseTargetsPosition = true;
            this.LimitTopCameraDistance = true;
            this.LimitBottomCameraDistance = true;
            this.MaxBottomTargetDistance = 0.8f;
            this.LimitLeftCameraDistance = true;
            this.MaxLeftTargetDistance = 0.8f;
            this.LimitRightCameraDistance = true;
            this.MaxRightTargetDistance = 0.8f;
            this._pdcOrder = 2000;
        }
        private static ProCamera2DLimitDistance()
        {
            mem2[0] = -1610606661;
        }
    
    }

}
