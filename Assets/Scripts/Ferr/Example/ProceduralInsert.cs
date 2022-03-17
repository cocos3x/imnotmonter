using UnityEngine;

namespace Ferr.Example
{
    public class ProceduralInsert : MonoBehaviour
    {
        // Fields
        private Ferr2DT_PathTerrain _terrain;
        private UnityEngine.Texture2D _handle;
        private bool _showHelpWindow;
        private bool _mouseDown;
        private int _selected;
        private UnityEngine.Vector2 _downPos;
        private UnityEngine.Vector2 _ptStartPos;
        private System.Collections.Generic.List<UnityEngine.Vector2> _original;
        
        // Properties
        public Ferr2DT_PathTerrain Terrain { get; set; }
        
        // Methods
        public Ferr2DT_PathTerrain get_Terrain()
        {
        
        }
        public void set_Terrain(Ferr2DT_PathTerrain value)
        {
            this._terrain = value;
            this.Save();
        }
        private void Start()
        {
            this.Save();
        }
        private void OnGUI()
        {
            var val_6;
            if(this.enabled == false)
            {
                    return;
            }
            
            if(this._showHelpWindow != false)
            {
                    UnityEngine.Rect val_2 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
                536899119 = new GUI.WindowFunction(object:  1276161360, method:  new IntPtr(1610688857));
                val_6 = mem[mem[3221271779] + 186];
                val_6 = mem[3221271779] + 186;
                if(val_6 == 1)
            {
                    val_6 = mem[mem[3221271779] + 186];
                val_6 = mem[3221271779] + 186;
            }
            
                UnityEngine.Rect val_4 = UnityEngine.GUILayout.Window(id:  1276149296, screenRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_2.m_XMin, m_Width = val_2.m_YMin, m_Height = val_2.m_Width}, func:  val_2.m_Height, text:  536899119, options:  -1610604841);
            }
            
            bool val_5 = UnityEngine.Object.op_Inequality(x:  this._terrain, y:  0);
            if(val_5 == true)
            {
                    val_5 = this;
                this.DoHandleEditor();
            }
        
        }
        private void DoHandleEditor()
        {
            Ferr2DT_PathTerrain val_23;
            Ferr2DPath val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            val_23 = this._terrain;
            if(val_23 != 0)
            {
                    val_24 = this._terrain.pathData;
            }
            else
            {
                    val_24 = this._terrain.pathData;
                val_23 = this._terrain;
                if(val_23 == 0)
            {
                    val_23 = 0;
            }
            
            }
            
            UnityEngine.Transform val_1 = val_23.transform;
            UnityEngine.Matrix4x4 val_2 = localToWorldMatrix;
            float val_3 = val_2.m13 + 136;
            float val_4 = val_2.m32 - 120;
            mem2[0] = val_2.m13 + 136;
            float val_5 = val_2.m32 - 108;
            mem2[0] = val_2.m13 + 140;
            mem2[0] = val_2.m32 + -160;
            mem2[0] = val_2.m32 + -156;
            mem2[0] = val_2.m32 + -128;
            mem2[0] = mem[(val_2.m32 - 120) + (0)];
            float val_6 = val_2.m13 + 44;
            mem2[0] = mem[(val_2.m32 - 120) + (4)];
            mem2[0] = mem[(val_2.m32 - 120) + (8)];
            val_25 = mem[val_2.m13 + 84];
            val_25 = val_2.m13 + 84;
            mem2[0] = val_2.m32 + -132;
            val_26 = val_2.m13 + 136;
            mem2[0] = val_2.m13 + 108;
            mem2[0] = val_2.m32 + -144;
            mem2[0] = val_2.m32 + -140;
            mem2[0] = val_2.m32 + -136;
            mem2[0] = val_2.m32 + -124;
            mem2[0] = val_2.m13 + 136;
            mem2[0] = val_2.m13 + 140;
            val_27 = 0;
            val_28 = mem[val_2.m13 + 92];
            val_28 = val_2.m13 + 92;
            if(0 == 0)
            {
                goto label_7;
            }
            
            val_27 = 0;
            mem2[0] = 0;
            if(0 != 1)
            {
                goto label_10;
            }
            
            val_27 = 1;
            mem2[0] = 0;
            mem2[0] = 0;
            goto label_10;
            label_7:
            mem2[0] = 1;
            mem2[0] = 1;
            mem2[0] = val_2.m13 + 68;
            mem2[0] = val_2.m13 + 64;
            label_10:
            val_29 = 0;
            val_30 = 0;
            mem2[0] = val_27;
            mem2[0] = val_25 + 28;
            mem2[0] = val_25 + 36;
            goto label_11;
            label_29:
            mem2[0] = val_30;
            if((val_30 == (val_2.m13 + 84 + 24)) && (0 == 0))
            {
                    var val_21 = val_2.m13 + 76;
                var val_22 = val_2.m13 + 76 + 4;
                val_21 = (val_2.m13 + 68) - val_21;
                val_22 = (val_2.m13 + 64) - val_22;
                val_21 = val_21 + (val_2.m13 + 72);
                val_22 = val_22 + (val_2.m13 + 72 + 4);
                mem2[0] = val_29;
            }
            
            float val_9 = val_2.m32 - 160;
            val_31 = 0;
            mem2[0] = val_31;
            mem2[0] = val_31;
            float val_10 = val_2.m13 + 136;
            var val_23 = val_2.m13 + 140;
            val_23 = 0f - val_23;
            if((val_2.m13 + 88) != 0)
            {
                    mem2[0] = val_31;
                val_31 = 0;
                if((val_2.m13 + 84 + 16) < 0)
            {
                    mem2[0] = val_2.m13 + 116;
                float val_11 = val_2.m13 + 136;
                val_31 = 0;
                mem2[0] = val_2.m13 + 136;
                mem2[0] = val_2.m13 + 140;
            }
            
            }
            
            float val_12 = val_2.m13 + 136;
            mem2[0] = val_2.m13 + 136;
            mem2[0] = val_2.m13 + 140;
            mem2[0] = val_31;
            mem2[0] = val_31;
            mem2[0] = val_31;
            mem2[0] = val_2.m13 + 136;
            float val_24 = val_2.m13 + 100;
            float val_13 = val_2.m13 + 136;
            val_24 = val_24 / 300f;
            mem2[0] = val_31;
            mem2[0] = val_2.m13 + 148;
            float val_14 = val_2.m13 + 120;
            mem2[0] = val_24;
            float val_15 = val_2.m13 + 120;
            mem2[0] = 0;
            val_25 = mem[val_2.m13 + 84];
            val_25 = val_2.m13 + 84;
            val_28 = mem[val_2.m13 + 92];
            val_28 = val_2.m13 + 92;
            var val_16 = (val_2.m13 + 84 + 16) + ((val_2.m13 + 84 + 16) >> 31);
            var val_17 = (val_2.m13 + 84 + 16) + ((val_2.m13 + 84 + 16) >> 31);
            float val_18 = val_2.m13 + 120;
            val_16 = val_16 >> 1;
            val_17 = val_17 >> 1;
            float val_25 = (float)val_16;
            float val_26 = (float)val_17;
            val_25 = (val_2.m13 + 112) - val_25;
            val_26 = val_23 - val_26;
            mem2[0] = 0;
            mem2[0] = (float)val_2.m13 + 84 + 16;
            float val_19 = val_2.m13 + 120;
            mem2[0] = val_2.m13 + 84 + 16;
            val_29 = 0;
            mem2[0] = 0;
            val_26 = val_2.m13 + 136;
            val_27 = mem[val_2.m13 + 80];
            val_27 = val_2.m13 + 80;
            val_30 = (val_2.m13 + 116) + 1;
            label_11:
            if(val_30 < val_28)
            {
                goto label_29;
            }
            
            if(val_27 != 0)
            {
                    if(((val_2.m13 + 84 + 24) == 1) && (0 == 0))
            {
                    mem2[0] = 0;
            }
            
                mem2[0] = 0;
            }
            
            if((((val_2.m13 + 88) != 0) && (0 == 1)) && ((val_2.m13 + 84 + 24) != 1))
            {
                    mem2[0] = 0;
            }
            
            float val_20 = val_2.m32 - 88;
            val_20 = val_20 + 4;
        }
        private UnityEngine.Vector2 GetMouseLocal(UnityEngine.Matrix4x4 aLocalToWorld)
        {
            float val_4;
            float val_5;
            float val_15;
            float val_27;
            var val_31;
            var val_32;
            float val_33;
            var val_34;
            UnityEngine.Event val_2 = UnityEngine.Event.current;
            UnityEngine.Vector2 val_3 = mousePosition;
            UnityEngine.Vector3 val_6 = MultiplyVector(vector:  new UnityEngine.Vector3() {x = 3.89212E+07f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_9 = MultiplyPoint(point:  new UnityEngine.Vector3() {x = 3.89212E+07f, y = val_4, z = val_5});
            UnityEngine.Plane val_10 = new UnityEngine.Plane(inNormal:  new UnityEngine.Vector3() {x = R4, y = R5, z = R8}, inPoint:  new UnityEngine.Vector3());
            UnityEngine.Camera val_11 = UnityEngine.Camera.main;
            float val_24 = (float)UnityEngine.Screen.height;
            val_24 = val_24 - val_5;
            val_27 = 0f;
            UnityEngine.Ray val_13 = ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = val_4, z = val_24});
            UnityEngine.Vector2 val_14 = UnityEngine.Vector2.zero;
            val_31 = val_4;
            val_32 = val_5;
            val_33 = val_4;
            val_34 = 0;
            if((val_10.m_Normal.x.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f}, m_Direction = new UnityEngine.Vector3() {x = val_15, y = val_33, z = 0f}}, enter: out  val_27)) != false)
            {
                    UnityEngine.Vector3 val_18 = GetPoint(distance:  val_14.x);
                UnityEngine.Transform val_19 = aLocalToWorld.m00 + 12.transform;
                UnityEngine.Matrix4x4 val_20 = worldToLocalMatrix;
                float val_21 = val_20.m13 + 96;
                mem2[0] = 0;
                mem2[0] = 0;
                float val_22 = val_20.m13 + 32;
                val_31 = mem[val_20.m13 + 32];
                val_31 = val_20.m13 + 32;
                val_32 = mem[val_20.m13 + 36];
                val_32 = val_20.m13 + 36;
            }
            
            float val_23 = val_20.m32 - 40;
            val_23 = val_23 + 4;
            return new UnityEngine.Vector2() {x = val_18.x, y = val_18.y};
        }
        private void Save()
        {
            var val_4 = this;
            if(this._terrain != 0)
            {
                    System.Collections.Generic.List<UnityEngine.Vector2> val_2 = this._terrain.pathData.GetPathRawCopy();
                this._original = this._terrain.pathData;
            }
            
            R4 + 44.Clear();
        }
        private void Reset()
        {
            var val_3;
            if(this._terrain == 0)
            {
                    return;
            }
            
            this._terrain.ClearPoints();
            val_3 = 0;
            goto label_5;
            label_10:
            if(this._terrain <= val_3)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = 1;
            label_5:
            if(val_3 < (this._terrain.AddPoint(aPt:  new UnityEngine.Vector2() {x = 3.673424E-39f, y = 1.401298E-45f}, aAtIndex:  0, aType:  4)))
            {
                goto label_10;
            }
            
            this._terrain.Build(aFullBuild:  false);
        }
        public ProceduralInsert()
        {
            this._selected = 0;
            this._showHelpWindow = true;
            536878507 = new System.Collections.Generic.List<UnityEngine.Vector2>();
            this._original = 536878507;
        }
        private void <OnGUI>b__12_0(int id)
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            var val_8;
            val_3 = mem[mem[3221271779] + 186];
            val_3 = mem[3221271779] + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[mem[3221271779] + 186];
                val_3 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.Label(text:  -1610596811, options:  mem[3221271779] + 92);
            val_4 = mem[mem[3221271779] + 186];
            val_4 = mem[3221271779] + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[mem[3221271779] + 186];
                val_4 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.Label(text:  -1610596807, options:  mem[3221271779] + 92);
            val_5 = -1073695541;
            val_6 = mem[mem[3221271779] + 186];
            val_6 = mem[3221271779] + 186;
            if(val_6 == 1)
            {
                    val_6 = mem[mem[3221271779] + 186];
                val_6 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.Label(text:  -1610596809, options:  mem[3221271779] + 92);
            if(this._terrain == 0)
            {
                    val_5 = -1073695541;
                val_7 = mem[mem[3221271779] + 186];
                val_7 = mem[3221271779] + 186;
                if(val_7 == 1)
            {
                    val_7 = mem[mem[3221271779] + 186];
                val_7 = mem[3221271779] + 186;
            }
            
                UnityEngine.GUILayout.Label(text:  -1610610503, options:  mem[3221271779] + 92);
            }
            
            val_8 = mem[mem[3221271779] + 186];
            val_8 = mem[3221271779] + 186;
            if(val_8 == 1)
            {
                    val_8 = mem[mem[3221271779] + 186];
                val_8 = mem[3221271779] + 186;
            }
            
            if((UnityEngine.GUILayout.Button(text:  -1610604923, options:  mem[3221271779] + 92)) == false)
            {
                    return;
            }
            
            this.Reset();
        }
    
    }

}
