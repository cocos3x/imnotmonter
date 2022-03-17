using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class SwitchCameraProjection : MonoBehaviour
    {
        // Fields
        public string _cameraMode;
        
        // Methods
        private void Awake()
        {
            this.Switch();
        }
        private void OnGUI()
        {
            bool val_8;
            int val_1 = UnityEngine.Screen.width;
            val_1 = val_1 - 210;
            UnityEngine.Rect val_2 = new UnityEngine.Rect(x:  (float)val_1, y:  null, width:  null, height:  null);
            string val_3 = -1610604249(-1610604249) + this._cameraMode + -1610612333(-1610612333);
            val_8 = mem[536887392];
            if((val_8 & true) == 0)
            {
                    val_8 = mem[536887321];
            }
            
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_2.m_XMin, m_YMin = val_2.m_YMin, m_Width = val_2.m_Width, m_Height = val_2.m_Height}, text:  -1610604249)) == false)
            {
                    return;
            }
            
            UnityEngine.Camera val_5 = UnityEngine.Camera.main;
            UnityEngine.PlayerPrefs.SetInt(key:  -1610598909, value:  0.orthographic ^ 1);
            this.Switch();
        }
        private void Switch()
        {
            UnityEngine.Camera val_1 = UnityEngine.Camera.main;
            int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  -1610598909, defaultValue:  0);
            val_2 = val_2 - 1;
            0.orthographic = val_2 >> 5;
            UnityEngine.Camera val_4 = UnityEngine.Camera.main;
            if(0.orthographic == true)
            {
                    22804516 = 22804636;
            }
            
            this._cameraMode = -1610598847;
        }
        public SwitchCameraProjection()
        {
        
        }
    
    }

}
