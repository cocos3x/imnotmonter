using UnityEngine;

namespace WrappingRope.Demo
{
    public class GUIPanel : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject Rope;
        private UnityEngine.GameObject _rope;
        private WrappingRopeLibrary.Scripts.Rope _ropeEntity;
        private bool _isRope;
        
        // Methods
        private void Start()
        {
        
        }
        private void OnGUI()
        {
            this.TestControls();
        }
        private void TestControls()
        {
            var val_21;
            var val_22;
            WrappingRopeLibrary.Scripts.Rope val_23;
            bool val_24;
            var val_25;
            float val_26;
            float val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_XMin});
            val_21 = -1073695541;
            if(this._isRope == false)
            {
                    22784860 = 22787572;
            }
            
            val_22 = mem[mem[3221271779] + 186];
            val_22 = mem[3221271779] + 186;
            if(val_22 == 1)
            {
                    val_22 = mem[mem[3221271779] + 186];
                val_22 = mem[3221271779] + 186;
            }
            
            val_23 = mem[mem[3221271779]];
            val_23 = mem[3221271779];
            val_24 = this._isRope;
            if((UnityEngine.GUILayout.Button(text:  -1610607385, options:  mem[3221271779] + 92)) != false)
            {
                    if(val_24 != false)
            {
                    val_23 = 0;
                UnityEngine.Object.Destroy(obj:  this._rope);
                this._ropeEntity = val_23;
            }
            else
            {
                    DropdownItem val_3 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this.Rope);
                this._rope = this.Rope;
                Weight val_4 = this._rope.GetComponent<Weight>();
                this._ropeEntity = this._rope;
            }
            
                val_24 = this._isRope ^ 1;
                this._isRope = val_24;
            }
            
            if(((val_24 & true) != 0) || (this._ropeEntity == 0))
            {
                goto label_18;
            }
            
            UnityEngine.GUIStyle val_6 = UnityEngine.GUIStyle.op_Implicit(str:  -1610601557);
            val_25 = mem[mem[3221271779] + 186];
            val_25 = mem[3221271779] + 186;
            if(val_25 == 1)
            {
                    val_25 = mem[mem[3221271779] + 186];
                val_25 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.BeginHorizontal(style:  -1610601557, options:  mem[3221271779] + 92);
            UnityEngine.GUILayoutOption val_7 = UnityEngine.GUILayout.Width(width:  null);
            mem[536881965] = 1120403456;
            float val_8 = UnityEngine.GUILayout.HorizontalScrollbar(value:  null, size:  null, leftValue:  null, rightValue:  null, options:  S16);
            this._ropeEntity.Width = val_8;
            float val_9 = val_8 * 100f;
            if(this._ropeEntity >= 0)
            {
                goto label_33;
            }
            
            if(this._ropeEntity != 0)
            {
                goto label_34;
            }
            
            val_26 = val_1.m_XMin;
            val_27 = -1f;
            goto label_35;
            label_33:
            if(this._ropeEntity != 0)
            {
                goto label_36;
            }
            
            val_26 = val_1.m_XMin;
            val_27 = 1f;
            label_35:
            float val_10 = S20 + val_27;
            if((S16 & 1) != 0)
            {
                    val_28 = S20;
            }
            
            goto label_37;
            label_34:
            float val_20 = -0.5f;
            val_20 = val_9 + val_20;
            val_29 = val_20;
            goto label_38;
            label_36:
            float val_21 = 0.5f;
            val_21 = val_9 + val_21;
            val_29 = val_21;
            label_38:
            val_28 = val_29;
            label_37:
            val_21 = val_28 / 100f;
            string val_11 = System.String.Format(format:  -1610604853, arg0:  536893745);
            val_30 = mem[mem[3221271779] + 186];
            val_30 = mem[3221271779] + 186;
            if(val_30 == 1)
            {
                    val_30 = mem[mem[3221271779] + 186];
                val_30 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.Label(text:  -1610604853, options:  mem[3221271779] + 92);
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUIStyle val_12 = UnityEngine.GUIStyle.op_Implicit(str:  -1610601557);
            val_31 = mem[mem[3221271779] + 186];
            val_31 = mem[3221271779] + 186;
            if(val_31 == 1)
            {
                    val_31 = mem[mem[3221271779] + 186];
                val_31 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.BeginHorizontal(style:  -1610601557, options:  mem[3221271779] + 92);
            val_32 = mem[mem[3221271779] + 186];
            val_32 = mem[3221271779] + 186;
            if(val_32 == 1)
            {
                    val_32 = mem[mem[3221271779] + 186];
                val_32 = mem[3221271779] + 186;
            }
            
            if((UnityEngine.GUILayout.RepeatButton(text:  -1610608977, options:  mem[3221271779] + 92)) != false)
            {
                    this._ropeEntity.CutRope(length:  val_21, dir:  1045220557);
            }
            
            val_33 = mem[mem[3221271779] + 186];
            val_33 = mem[3221271779] + 186;
            if(val_33 == 1)
            {
                    val_33 = mem[mem[3221271779] + 186];
                val_33 = mem[3221271779] + 186;
            }
            
            if((UnityEngine.GUILayout.RepeatButton(text:  -1610608979, options:  mem[3221271779] + 92)) != false)
            {
                    this._ropeEntity.CutRope(length:  val_21, dir:  1045220557);
            }
            
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUIStyle val_15 = UnityEngine.GUIStyle.op_Implicit(str:  -1610601557);
            val_21 = -1073695541;
            val_34 = mem[mem[3221271779] + 186];
            val_34 = mem[3221271779] + 186;
            if(val_34 == 1)
            {
                    val_34 = mem[mem[3221271779] + 186];
                val_34 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.BeginVertical(style:  -1610601557, options:  mem[3221271779] + 92);
            val_35 = mem[mem[3221271779] + 186];
            val_35 = mem[3221271779] + 186;
            if(val_35 == 1)
            {
                    val_35 = mem[mem[3221271779] + 186];
                val_35 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.Label(text:  -1610604711, options:  mem[3221271779] + 92);
            val_36 = mem[mem[3221271779] + 186];
            val_36 = mem[3221271779] + 186;
            if(val_36 == 1)
            {
                    val_36 = mem[mem[3221271779] + 186];
                val_36 = mem[3221271779] + 186;
            }
            
            if((UnityEngine.GUILayout.Button(text:  -1610606001, options:  mem[3221271779] + 92)) != false)
            {
                    mem2[0] = 0;
            }
            
            val_37 = mem[mem[3221271779] + 186];
            val_37 = mem[3221271779] + 186;
            if(val_37 == 1)
            {
                    val_37 = mem[mem[3221271779] + 186];
                val_37 = mem[3221271779] + 186;
            }
            
            if((UnityEngine.GUILayout.Button(text:  -1610604311, options:  mem[3221271779] + 92)) != false)
            {
                    mem2[0] = 1;
            }
            
            val_38 = mem[mem[3221271779] + 186];
            val_38 = mem[3221271779] + 186;
            if(val_38 == 1)
            {
                    val_38 = mem[mem[3221271779] + 186];
                val_38 = mem[3221271779] + 186;
            }
            
            if((UnityEngine.GUILayout.Button(text:  -1610603453, options:  mem[3221271779] + 92)) != false)
            {
                    mem2[0] = 3;
            }
            
            val_23 = -1073695541;
            val_39 = mem[mem[3221271779] + 186];
            val_39 = mem[3221271779] + 186;
            if(val_39 == 1)
            {
                    val_39 = mem[mem[3221271779] + 186];
                val_39 = mem[3221271779] + 186;
            }
            
            if((UnityEngine.GUILayout.Button(text:  -1610603455, options:  mem[3221271779] + 92)) != false)
            {
                    mem2[0] = 2;
            }
            
            UnityEngine.GUILayout.EndVertical();
            label_18:
            UnityEngine.GUILayout.EndArea();
        }
        private void Update()
        {
        
        }
        public GUIPanel()
        {
        
        }
    
    }

}
