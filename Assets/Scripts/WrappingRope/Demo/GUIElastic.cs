using UnityEngine;

namespace WrappingRope.Demo
{
    public class GUIElastic : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject Rope;
        private UnityEngine.GameObject _rope;
        private WrappingRopeLibrary.Scripts.Rope _ropeEntity;
        
        // Methods
        private void Start()
        {
            UnityEngine.GameObject val_4;
            this._rope = this.Rope;
            val_4 = this._rope;
            if(val_4 == 0)
            {
                    return;
            }
            
            Weight val_2 = mem[this._rope].GetComponent<Weight>();
            this._ropeEntity = mem[this._rope];
        }
        private void Update()
        {
        
        }
        private void OnGUI()
        {
            this.TestControls();
        }
        private void TestControls()
        {
            WrappingRopeLibrary.Scripts.Rope val_12;
            var val_13;
            float val_14;
            float val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_XMin});
            UnityEngine.GUIStyle val_2 = UnityEngine.GUIStyle.op_Implicit(str:  -1610601557);
            val_12 = -1073695541;
            val_13 = mem[mem[3221271779] + 186];
            val_13 = mem[3221271779] + 186;
            if(val_13 == 1)
            {
                    val_13 = mem[mem[3221271779] + 186];
                val_13 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.BeginHorizontal(style:  -1610601557, options:  mem[3221271779] + 92);
            if(this._ropeEntity == 0)
            {
                goto label_11;
            }
            
            val_12 = this._ropeEntity;
            UnityEngine.GUILayoutOption val_4 = UnityEngine.GUILayout.Width(width:  null);
            mem[536881965] = 1120403456;
            mem2[0] = S16;
            float val_6 = (UnityEngine.GUILayout.HorizontalScrollbar(value:  null, size:  null, leftValue:  null, rightValue:  null, options:  S16)) * 100f;
            if(this._ropeEntity >= 0)
            {
                goto label_18;
            }
            
            if(this._ropeEntity != 0)
            {
                goto label_19;
            }
            
            val_14 = val_1.m_XMin;
            val_15 = -1f;
            goto label_20;
            label_18:
            if(this._ropeEntity != 0)
            {
                goto label_21;
            }
            
            val_14 = val_1.m_XMin;
            val_15 = 1f;
            label_20:
            float val_7 = S20 + val_15;
            if((1017370378 & 1) != 0)
            {
                    val_16 = S20;
            }
            
            goto label_22;
            label_19:
            float val_12 = -0.5f;
            val_12 = val_6 + val_12;
            val_17 = val_12;
            goto label_23;
            label_21:
            float val_13 = 0.5f;
            val_13 = val_6 + val_13;
            val_17 = val_13;
            label_23:
            val_16 = val_17;
            label_22:
            val_13 = val_16 / 100f;
            string val_8 = System.String.Format(format:  -1610608571, arg0:  536893745);
            val_18 = mem[mem[3221271779] + 186];
            val_18 = mem[3221271779] + 186;
            if(val_18 == 1)
            {
                    val_18 = mem[mem[3221271779] + 186];
                val_18 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.Label(text:  -1610608571, options:  mem[3221271779] + 92);
            label_11:
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUIStyle val_9 = UnityEngine.GUIStyle.op_Implicit(str:  -1610601557);
            val_19 = mem[mem[3221271779] + 186];
            val_19 = mem[3221271779] + 186;
            if(val_19 == 1)
            {
                    val_19 = mem[mem[3221271779] + 186];
                val_19 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.BeginHorizontal(style:  -1610601557, options:  mem[3221271779] + 92);
            val_20 = mem[mem[3221271779] + 186];
            val_20 = mem[3221271779] + 186;
            if(val_20 == 1)
            {
                    val_20 = mem[mem[3221271779] + 186];
                val_20 = mem[3221271779] + 186;
            }
            
            bool val_10 = UnityEngine.GUILayout.Button(text:  -1610609027, options:  mem[3221271779] + 92);
            if(val_10 != false)
            {
                    float val_11 = UnityEngine.Random.value;
                if(val_10 < 0)
            {
                    3 = 2;
            }
            
                this.NewObject(primitive:  3);
            }
            
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.EndArea();
        }
        private void NewObject(UnityEngine.PrimitiveType primitive)
        {
            var val_19;
            var val_20;
            var val_21;
            float val_22;
            var val_23;
            var val_24;
            val_19 = primitive;
            val_20 = 0;
            float val_1 = UnityEngine.Random.value;
            float val_2 = UnityEngine.Random.value;
            float val_3 = UnityEngine.Random.value;
            float val_4 = UnityEngine.Random.value;
            val_21 = 0;
            float val_5 = UnityEngine.Random.value;
            val_22 = 0;
            if(val_19 == 2)
            {
                goto label_1;
            }
            
            if(val_19 != 3)
            {
                goto label_8;
            }
            
            UnityEngine.GameObject val_6 = UnityEngine.GameObject.CreatePrimitive(type:  3);
            val_20 = 3;
            val_23 = 0;
            UnityEngine.Transform val_7 = val_20.transform;
            val_24 = 1050253722;
            val_20.localScale = new UnityEngine.Vector3() {x = 0.1f, y = 0.3f, z = 2f};
            Weight val_8 = val_20.GetComponent<Weight>();
            val_19 = val_20;
            val_21 = val_21;
            UnityEngine.Object.Destroy(obj:  3);
            val_22 = val_22;
            goto label_8;
            label_1:
            UnityEngine.GameObject val_9 = UnityEngine.GameObject.CreatePrimitive(type:  2);
            val_20 = 2;
            val_23 = 0;
            UnityEngine.Transform val_10 = val_20.transform;
            val_20.localScale = new UnityEngine.Vector3() {x = 0.1f, y = 0.3f, z = 0.1f};
            val_24 = 0;
            UnityEngine.Transform val_11 = val_20.transform;
            val_20.Rotate(eulers:  new UnityEngine.Vector3() {x = 90f, y = 0f, z = 0f});
            Weight val_12 = val_20.GetComponent<Weight>();
            val_19 = val_20;
            UnityEngine.Object.Destroy(obj:  2);
            label_8:
            if(2 == 0)
            {
                    return;
            }
            
            uint val_19 = 0;
            val_19 = val_19 + val_19;
            UnityEngine.Transform val_15 = val_20.transform;
            val_20.position = new UnityEngine.Vector3() {x = val_19 + 3f, y = 3f, z = -1.4f};
            if(val_20 != 0)
            {
                    SynchronizationContextBehavoir val_16 = val_20.AddComponent<SynchronizationContextBehavoir>();
            }
            else
            {
                    SynchronizationContextBehavoir val_17 = 0.AddComponent<SynchronizationContextBehavoir>();
            }
            
            SynchronizationContextBehavoir val_18 = val_20.AddComponent<SynchronizationContextBehavoir>();
            val_20.convex = true;
        }
        public GUIElastic()
        {
        
        }
    
    }

}
