using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public abstract class BasePC2D : MonoBehaviour
    {
        // Fields
        private Com.LuisPedroFonseca.ProCamera2D.ProCamera2D _pc2D;
        protected System.Func<UnityEngine.Vector3, float> Vector3H;
        protected System.Func<UnityEngine.Vector3, float> Vector3V;
        protected System.Func<UnityEngine.Vector3, float> Vector3D;
        protected System.Func<float, float, UnityEngine.Vector3> VectorHV;
        protected System.Func<float, float, float, UnityEngine.Vector3> VectorHVD;
        protected UnityEngine.Transform _transform;
        private bool _enabled;
        
        // Properties
        public Com.LuisPedroFonseca.ProCamera2D.ProCamera2D ProCamera2D { get; set; }
        
        // Methods
        public Com.LuisPedroFonseca.ProCamera2D.ProCamera2D get_ProCamera2D()
        {
            var val_11;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_12;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_13;
            val_11 = 22713552;
            val_12 = this._pc2D;
            if(val_12 != 0)
            {
                    return;
            }
            
            val_12 = 22755388;
            UnityEngine.Transform val_2 = this.GetComponent<UnityEngine.Transform>();
            this._pc2D = this;
            if(this._pc2D == 0)
            {
                    UnityEngine.Camera val_4 = UnityEngine.Camera.main;
                if(0 != 0)
            {
                    UnityEngine.Camera val_6 = UnityEngine.Camera.main;
                UnityEngine.Transform val_7 = 0.GetComponent<UnityEngine.Transform>();
                this._pc2D = 0;
            }
            
            }
            
            if(0 != 0)
            {
                    return;
            }
            
            val_13 = 0;
            System.Type val_9 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = new IntPtr(1073762995)});
            val_12 = 1073762995;
            UnityEngine.Object val_10 = UnityEngine.Object.FindObjectOfType(type:  1073762995);
            if(val_12 != 0)
            {
                    val_11 = mem[mem[1073762995] + 180];
                val_11 = mem[1073762995] + 180;
                if(val_11 >= mem[536892263])
            {
                    var val_11 = mem[1073762995] + 100;
                val_11 = val_11 + (mem[536892263] << 2);
                if(((mem[1073762995] + 100 + (mem[536892263]) << 2) + -4) != 536892083)
            {
                    val_12 = 0;
            }
            
                val_13 = val_12;
            }
            
            }
            
            this._pc2D = val_13;
        }
        public void set_ProCamera2D(Com.LuisPedroFonseca.ProCamera2D.ProCamera2D value)
        {
            this._pc2D = value;
        }
        protected virtual void Awake()
        {
            UnityEngine.Transform val_1 = this.transform;
            this._transform = this;
            bool val_2 = this.enabled;
            if(val_2 == true)
            {
                    val_2 = this;
                this.Enable();
            }
            
            this.ResetAxisFunctions();
        }
        protected virtual void OnEnable()
        {
            this.Enable();
        }
        protected virtual void OnDisable()
        {
            this.Disable();
        }
        protected virtual void OnDestroy()
        {
            this.Disable();
        }
        public virtual void OnReset()
        {
        
        }
        private void Enable()
        {
            var val_4;
            if(this._enabled == true)
            {
                    return;
            }
            
            if(this._pc2D == 0)
            {
                    return;
            }
            
            this._enabled = true;
            536882991 = new System.Action(object:  976381552, method:  typeof(Com.LuisPedroFonseca.ProCamera2D.BasePC2D).__il2cppRuntimeField_100);
            System.Delegate val_3 = System.Delegate.Combine(a:  this._pc2D.OnReset, b:  536882991);
            if(this._pc2D.OnReset == 0)
            {
                goto label_6;
            }
            
            val_4 = this._pc2D.OnReset;
            if(null == 536882991)
            {
                goto label_7;
            }
            
            label_6:
            val_4 = 0;
            label_7:
            mem2[0] = val_4;
        }
        private void Disable()
        {
            var val_4;
            bool val_1 = UnityEngine.Object.op_Inequality(x:  this._pc2D, y:  0);
            if(val_1 == true)
            {
                    val_1 = this._enabled;
                goto label_3;
            }
            
            return;
            label_3:
            this._enabled = false;
            536882991 = new System.Action(object:  976518128, method:  typeof(Com.LuisPedroFonseca.ProCamera2D.BasePC2D).__il2cppRuntimeField_100);
            System.Delegate val_3 = System.Delegate.Remove(source:  this._pc2D.OnReset, value:  536882991);
            if(this._pc2D.OnReset == 0)
            {
                goto label_5;
            }
            
            val_4 = this._pc2D.OnReset;
            if(null == 536882991)
            {
                goto label_6;
            }
            
            label_5:
            val_4 = 0;
            label_6:
            mem2[0] = val_4;
        }
        private void ResetAxisFunctions()
        {
            var val_18;
            var val_19;
            object val_20;
            System.Func<UnityEngine.Vector3, System.Single> val_21;
            object val_22;
            var val_23;
            object val_24;
            System.Func<UnityEngine.Vector3, System.Single> val_25;
            var val_26;
            object val_27;
            System.Func<UnityEngine.Vector3, System.Single> val_28;
            var val_29;
            object val_30;
            System.Func<System.Single, System.Single, UnityEngine.Vector3> val_31;
            var val_32;
            object val_33;
            System.Func<System.Single, System.Single, System.Single, UnityEngine.Vector3> val_34;
            var val_35;
            object val_36;
            var val_37;
            object val_38;
            System.Func<UnityEngine.Vector3, System.Single> val_39;
            var val_40;
            object val_41;
            System.Func<UnityEngine.Vector3, System.Single> val_42;
            var val_43;
            object val_44;
            System.Func<System.Single, System.Single, UnityEngine.Vector3> val_45;
            var val_46;
            object val_47;
            var val_48;
            object val_49;
            var val_50;
            object val_51;
            System.Func<UnityEngine.Vector3, System.Single> val_52;
            var val_53;
            object val_54;
            System.Func<UnityEngine.Vector3, System.Single> val_55;
            var val_56;
            object val_57;
            System.Func<System.Single, System.Single, UnityEngine.Vector3> val_58;
            var val_59;
            object val_60;
            if(this.Vector3H != 0)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if(976654704 == 0)
            {
                    return;
            }
            
            if(this._pc2D.Axis == 2)
            {
                goto label_6;
            }
            
            if(this._pc2D.Axis == 1)
            {
                goto label_7;
            }
            
            if(this._pc2D.Axis != 0)
            {
                    return;
            }
            
            val_18 = 22717236;
            val_19 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_19 = 536898079;
            }
            
            val_20 = mem[536898171];
            val_21 = mem[mem[536898171] + 4];
            val_21 = mem[536898171] + 4;
            if(val_21 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_20 = mem[536898171];
            }
            
                val_22 = mem[mem[536898171]];
                val_22 = val_20;
                val_21 = 536875575;
                val_21 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_22, method:  new IntPtr(1610684025));
                mem2[0] = val_21;
            }
            
            this.Vector3H = val_21;
            val_23 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_23 = 536898079;
            }
            
            val_24 = mem[536898171];
            val_25 = mem[mem[536898171] + 8];
            val_25 = mem[536898171] + 8;
            if(val_25 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_24 = mem[536898171];
            }
            
                val_21 = mem[mem[536898171]];
                val_21 = val_24;
                val_25 = 536875575;
                val_25 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610684027));
                mem2[0] = val_25;
            }
            
            this.Vector3V = val_25;
            val_26 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_26 = 536898079;
            }
            
            val_27 = mem[536898171];
            val_28 = mem[mem[536898171] + 12];
            val_28 = mem[536898171] + 12;
            if(val_28 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_27 = mem[536898171];
            }
            
                val_21 = mem[mem[536898171]];
                val_21 = val_27;
                val_28 = 536875575;
                val_28 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610684029));
                mem2[0] = val_28;
            }
            
            this.Vector3D = val_28;
            val_29 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_29 = 536898079;
            }
            
            val_30 = mem[536898171];
            val_31 = mem[mem[536898171] + 16];
            val_31 = mem[536898171] + 16;
            if(val_31 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_30 = mem[536898171];
            }
            
                val_21 = mem[mem[536898171]];
                val_21 = val_30;
                val_31 = 536875643;
                val_31 = new System.Func<System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610684031));
                mem2[0] = val_31;
            }
            
            this.VectorHV = val_31;
            val_32 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_32 = 536898079;
            }
            
            val_33 = mem[536898171];
            val_34 = mem[mem[536898171] + 20];
            val_34 = mem[536898171] + 20;
            if(val_34 != 0)
            {
                goto label_83;
            }
            
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_33 = mem[536898171];
            }
            
            val_21 = mem[mem[536898171]];
            val_21 = val_33;
            val_34 = 536875681;
            val_34 = new System.Func<System.Single, System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610684033));
            mem2[0] = val_34;
            goto label_60;
            label_6:
            val_18 = 22717236;
            val_35 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_35 = 536898079;
            }
            
            val_36 = mem[536898171];
            val_21 = mem[mem[536898171] + 44];
            val_21 = mem[536898171] + 44;
            if(val_21 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_36 = mem[536898171];
            }
            
                val_22 = mem[mem[536898171]];
                val_22 = val_36;
                val_21 = 536875575;
                val_21 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_22, method:  new IntPtr(1610684045));
                mem2[0] = val_21;
            }
            
            this.Vector3H = val_21;
            val_37 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_37 = 536898079;
            }
            
            val_38 = mem[536898171];
            val_39 = mem[mem[536898171] + 48];
            val_39 = mem[536898171] + 48;
            if(val_39 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_38 = mem[536898171];
            }
            
                val_21 = mem[mem[536898171]];
                val_21 = val_38;
                val_39 = 536875575;
                val_39 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610684047));
                mem2[0] = val_39;
            }
            
            this.Vector3V = val_39;
            val_40 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_40 = 536898079;
            }
            
            val_41 = mem[536898171];
            val_42 = mem[mem[536898171] + 52];
            val_42 = mem[536898171] + 52;
            if(val_42 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_41 = mem[536898171];
            }
            
                val_21 = mem[mem[536898171]];
                val_21 = val_41;
                val_42 = 536875575;
                val_42 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610684049));
                mem2[0] = val_42;
            }
            
            this.Vector3D = val_42;
            val_43 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_43 = 536898079;
            }
            
            val_44 = mem[536898171];
            val_45 = mem[mem[536898171] + 56];
            val_45 = mem[536898171] + 56;
            if(val_45 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_44 = mem[536898171];
            }
            
                val_21 = mem[mem[536898171]];
                val_21 = val_44;
                val_45 = 536875643;
                val_45 = new System.Func<System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610684051));
                mem2[0] = val_45;
            }
            
            this.VectorHV = val_45;
            val_46 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_46 = 536898079;
            }
            
            val_47 = mem[536898171];
            val_34 = mem[mem[536898171] + 60];
            val_34 = mem[536898171] + 60;
            if(val_34 != 0)
            {
                goto label_83;
            }
            
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_47 = mem[536898171];
            }
            
            val_21 = mem[mem[536898171]];
            val_21 = val_47;
            val_34 = 536875681;
            val_34 = new System.Func<System.Single, System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610684053));
            mem2[0] = val_34;
            goto label_60;
            label_7:
            val_18 = 22717236;
            val_48 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_48 = 536898079;
            }
            
            val_49 = mem[536898171];
            val_21 = mem[mem[536898171] + 24];
            val_21 = mem[536898171] + 24;
            if(val_21 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_49 = mem[536898171];
            }
            
                val_22 = mem[mem[536898171]];
                val_22 = val_49;
                val_21 = 536875575;
                val_21 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_22, method:  new IntPtr(1610684035));
                mem2[0] = val_21;
            }
            
            this.Vector3H = val_21;
            val_50 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_50 = 536898079;
            }
            
            val_51 = mem[536898171];
            val_52 = mem[mem[536898171] + 28];
            val_52 = mem[536898171] + 28;
            if(val_52 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_51 = mem[536898171];
            }
            
                val_21 = mem[mem[536898171]];
                val_21 = val_51;
                val_52 = 536875575;
                val_52 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610684037));
                mem2[0] = val_52;
            }
            
            this.Vector3V = val_52;
            val_53 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_53 = 536898079;
            }
            
            val_54 = mem[536898171];
            val_55 = mem[mem[536898171] + 32];
            val_55 = mem[536898171] + 32;
            if(val_55 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_54 = mem[536898171];
            }
            
                val_21 = mem[mem[536898171]];
                val_21 = val_54;
                val_55 = 536875575;
                val_55 = new System.Func<UnityEngine.Vector3, System.Single>(object:  val_21, method:  new IntPtr(1610684039));
                mem2[0] = val_55;
            }
            
            this.Vector3D = val_55;
            val_56 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_56 = 536898079;
            }
            
            val_57 = mem[536898171];
            val_58 = mem[mem[536898171] + 36];
            val_58 = mem[536898171] + 36;
            if(val_58 == 0)
            {
                    if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_57 = mem[536898171];
            }
            
                val_21 = mem[mem[536898171]];
                val_21 = val_57;
                val_58 = 536875643;
                val_58 = new System.Func<System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610684041));
                mem2[0] = val_58;
            }
            
            this.VectorHV = val_58;
            val_59 = 536898079;
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_59 = 536898079;
            }
            
            val_60 = mem[536898171];
            val_34 = mem[mem[536898171] + 40];
            val_34 = mem[536898171] + 40;
            if(val_34 != 0)
            {
                goto label_83;
            }
            
            if(((mem[536898266] & true) == 0) && (mem[536898195] == 0))
            {
                    val_60 = mem[536898171];
            }
            
            val_21 = mem[mem[536898171]];
            val_21 = val_60;
            val_34 = 536875681;
            val_34 = new System.Func<System.Single, System.Single, System.Single, UnityEngine.Vector3>(object:  val_21, method:  new IntPtr(1610684043));
            mem2[0] = val_34;
            label_60:
            label_83:
            this.VectorHVD = val_34;
        }
        protected BasePC2D()
        {
        
        }
    
    }

}
