using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class ProCamera2DParallax : BasePC2D, IPostMover
    {
        // Fields
        public static string ExtensionName;
        public System.Collections.Generic.List<Com.LuisPedroFonseca.ProCamera2D.ProCamera2DParallaxLayer> ParallaxLayers;
        public bool ParallaxHorizontal;
        public bool ParallaxVertical;
        public bool ParallaxZoom;
        public UnityEngine.Vector3 RootPosition;
        public int FrontDepthStart;
        public int BackDepthStart;
        public bool UseIndependentAxisSpeeds;
        public bool AutomaticallyConfigureCameraClearFlags;
        private float _initialOrtographicSize;
        private float[] _initialSpeeds;
        private UnityEngine.Coroutine _animateCoroutine;
        private int _pmOrder;
        
        // Properties
        public int PMOrder { get; set; }
        
        // Methods
        protected override void Awake()
        {
            var val_16;
            var val_17;
            this.Awake();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            val_17 = this;
            if(1022744528 == 0)
            {
                    return;
            }
            
            bool val_3 = UnityEngine.Application.isPlaying;
            if(val_3 == true)
            {
                    val_3 = this;
                this.CalculateParallaxObjectsOffset();
            }
            
            List.Enumerator<T> val_4 = GetEnumerator();
            label_11:
            if(MoveNext() == false)
            {
                goto label_5;
            }
            
            if((val_6 + 8) == 0)
            {
                goto label_11;
            }
            
            UnityEngine.Transform val_8 = val_6 + 8.transform;
            mem2[0] = val_6 + 8;
            goto label_11;
            label_5:
            Dispose();
            val_16 = this;
            this._initialSpeeds = 536882357;
            val_17 = 4;
            goto label_13;
            label_20:
            if(1152921509924558880 <= )
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            this._initialSpeeds[0] = static_value_0028000F;
            val_17 = 5;
            label_13:
            if((val_17 - 4) < mem[536882369])
            {
                goto label_20;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_10 = this.ProCamera2D;
            if(1022744528 != 0)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_12 = this.ProCamera2D;
                float val_13 = this.orthographicSize;
                this._initialOrtographicSize = this;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_14 = this.ProCamera2D;
                if(this.orthographic != true)
            {
                    this.enabled = false;
            }
            
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_16 = this.ProCamera2D;
            this.AddPostMover(mover:  1022744528);
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_1 = this.ProCamera2D;
            if((UnityEngine.Object.op_Implicit(exists:  1022905680)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_3 = R4.ProCamera2D;
            R4.RemovePostMover(mover:  R4);
        }
        public void PostMove(float deltaTime)
        {
            if(this.enabled == false)
            {
                    return;
            }
            
            R4.Move();
        }
        public int get_PMOrder()
        {
            return (int)this._pmOrder;
        }
        public void set_PMOrder(int value)
        {
            this._pmOrder = value;
        }
        public void CalculateParallaxObjectsOffset()
        {
            var val_3;
            LayoutCache val_6;
            float val_13;
            float val_14;
            float val_15;
            var val_25;
            float val_26;
            float val_27;
            var val_28;
            var val_30;
            T[] val_1 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
            536874237 = new System.Collections.Generic.Dictionary<System.Int32, LayoutCache>();
            label_19:
            val_3 = 0;
            List.Enumerator<T> val_4 = GetEnumerator();
            label_16:
            if(MoveNext() == false)
            {
                goto label_12;
            }
            
            int val_8 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_6 + 24});
            val_8 = val_8 | 0;
            if((UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_6 + 24})) != val_8)
            {
                goto label_16;
            }
            
            536874237.set_Item(key:  0, value:  val_6);
            goto label_16;
            label_12:
            val_25 = 1;
            Dispose();
            if(val_25 != 0)
            {
                    if((1152921509925155888 + ((val_25 - 1)) << 2) == 106)
            {
                    val_25 = val_25 - 1;
            }
            
            }
            
            var val_10 = 0 + 1;
            if(0 < 31)
            {
                goto label_19;
            }
            
            val_28 = -1073688247;
            val_30 = 0;
            val_3 = 3221279065;
            goto label_20;
            label_42:
            UnityEngine.Transform val_11 = mem[3221279065].transform;
            UnityEngine.Vector3 val_12 = position;
            float val_28 = val_13;
            float val_29 = val_14;
            val_28 = val_28 - (8.407791E-45f);
            float val_30 = val_15;
            val_29 = val_29 - (7.286752E-44f);
            val_30 = val_30 - (7.286752E-44f);
            float val_16 = 2621443.Invoke(arg:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30});
            UnityEngine.GameObject val_17 = mem[3221279065].gameObject;
            Spine.Timeline val_19 = 536874237.Item[mem[3221279065].layer];
            if(0 == 0)
            {
                    16 = 12;
            }
            
            var val_31 = 536874237 + 12;
            float val_21 = 1.Invoke(arg:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30});
            UnityEngine.GameObject val_22 = mem[3221279065].gameObject;
            Spine.Timeline val_24 = 536874237.Item[mem[3221279065].layer];
            if(0 == 0)
            {
                    536874257 = 536874237 + 12;
            }
            
            var val_32 = 536874257;
            UnityEngine.Transform val_25 = mem[3221279065].transform;
            val_31 = 2621443 * val_31;
            val_32 = 1 * val_32;
            UnityEngine.Vector3 val_27 = Invoke(arg1:  mem[1152921509925167976].Invoke(arg:  new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30}), arg2:  val_12.y, arg3:  val_29);
            float val_33 = val_13;
            float val_34 = val_14;
            float val_35 = val_15;
            val_33 = val_33 + mem[1152921509925168004];
            val_34 = val_34 + mem[1152921509925168008];
            val_35 = val_35 + mem[1152921509925168012];
            val_27 = val_33;
            val_26 = val_34;
            mem[3221279065].position = new UnityEngine.Vector3() {x = val_27, y = val_26, z = val_35};
            val_28 = -1073688247;
            val_30 = 1;
            label_20:
            if(val_30 < mem[3221279061])
            {
                goto label_42;
            }
        
        }
        private void Move()
        {
            float val_2;
            float val_3;
            UnityEngine.Vector3 val_4;
            float val_8;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            UnityEngine.Vector3 val_1 = position;
            float val_20 = val_2;
            val_18 = 4;
            float val_21 = val_3;
            val_20 = val_20 - S10;
            UnityEngine.Vector3 val_22 = val_4;
            val_21 = val_21 - S8;
            val_22 = val_22 - this.RootPosition;
            goto label_2;
            label_43:
            if(val_22 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_19 = -1810889493;
            bool val_5 = UnityEngine.Object.op_Inequality(x:  -1810889493, y:  0);
            if(val_5 != false)
            {
                    if(val_5 <= R7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_6 = this.ProCamera2D;
                UnityEngine.Rect val_7 = rect;
                static_value_0028000B.rect = new UnityEngine.Rect() {m_XMin = val_4, m_YMin = val_3, m_Width = val_2, m_Height = val_8};
                float val_9 = val_2.Invoke(arg:  new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_20});
                val_20 = val_2;
                if(this.ParallaxHorizontal != false)
            {
                    if(val_2 <= (???))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(this.UseIndependentAxisSpeeds == false)
            {
                    16 = 12;
            }
            
                val_20 = val_20 * (2621443 + 12);
            }
            
                float val_11 = this.UseIndependentAxisSpeeds.Invoke(arg:  new UnityEngine.Vector3() {x = val_22, y = val_21, z = val_20});
                val_21 = this.UseIndependentAxisSpeeds;
                if(this.ParallaxVertical != false)
            {
                    if(this.UseIndependentAxisSpeeds <= (???))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(this.UseIndependentAxisSpeeds == false)
            {
                    20 = 12;
            }
            
                var val_12 = 2621443 + 12;
                val_21 = val_21 * val_12;
            }
            
                if(val_12 <= (???))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                UnityEngine.Vector3 val_13 = position;
                val_17 = ;
                UnityEngine.Vector3 val_15 = Invoke(arg1:  static_value_0028000B.Invoke(arg:  new UnityEngine.Vector3() {x = R4, y = R5, z = SB}), arg2:  val_13.y, arg3:  val_13.z);
                float val_23 = val_4;
                float val_24 = val_3;
                float val_25 = val_2;
                val_23 = this.RootPosition + val_23;
                val_24 = S22 + val_24;
                val_25 = S24 + val_25;
                -1810889493.position = new UnityEngine.Vector3() {x = val_23, y = val_24, z = val_25};
                val_19 = ???;
                if(this.ParallaxZoom != false)
            {
                    if(this.ParallaxZoom <= val_19)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_19 = static_value_0028000B;
                Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_16 = this.ProCamera2D;
                float val_17 = this.orthographicSize;
                if(this <= (???))
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_19.orthographicSize = 1023498448 - this._initialOrtographicSize;
            }
            
            }
            
            val_18 = val_18 + 1;
            label_2:
            if((val_18 - 4) < val_19)
            {
                goto label_43;
            }
        
        }
        public void ToggleParallax(bool value, float duration = 2, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType = 0)
        {
            if(this._initialSpeeds != null)
            {
                    if(this._animateCoroutine != 0)
            {
                    this.StopCoroutine(routine:  this._animateCoroutine);
            }
            
                System.Collections.IEnumerator val_1 = this.Animate(value:  value, duration:  duration, easeType:  easeType);
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  1023688272);
                this._animateCoroutine = this;
            }
            
            var val_3 = FP - 24;
        }
        private System.Collections.IEnumerator Animate(bool value, float duration, Com.LuisPedroFonseca.ProCamera2D.EaseType easeType)
        {
            Com.LuisPedroFonseca.ProCamera2D.EaseType val_2 = easeType;
            ProCamera2DParallax.<Animate>d__23 val_1 = 536900601;
            val_1 = new ProCamera2DParallax.<Animate>d__23(<>1__state:  0);
            if(val_1 != 0)
            {
                    val_2 = val_1;
                mem[536900617] = this;
                mem[536900621] = val_2;
                mem[536900625] = value;
            }
            else
            {
                    mem[16] = this;
                mem[24] = value;
                mem[20] = val_2;
            }
            
            mem[536900629] = R3;
        }
        public ProCamera2DParallax()
        {
            536878181 = new System.Collections.Generic.List<Page>();
            this.ParallaxLayers = 536878181;
            this.ParallaxZoom = true;
            this.ParallaxHorizontal = true;
            this.ParallaxVertical = true;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.BackDepthStart = 0;
            this.AutomaticallyConfigureCameraClearFlags = true;
            this._pmOrder = 1000;
        }
        private static ProCamera2DParallax()
        {
            mem2[0] = -1610605457;
        }
    
    }

}
