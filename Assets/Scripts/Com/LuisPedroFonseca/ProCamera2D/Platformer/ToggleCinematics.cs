using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.Platformer
{
    public class ToggleCinematics : MonoBehaviour
    {
        // Fields
        public Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCinematics Cinematics;
        
        // Methods
        private void OnGUI()
        {
            float val_6;
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DCinematics val_7;
            bool val_8;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            val_6 = val_1.m_YMin;
            if(this.Cinematics._isPlaying == false)
            {
                    22793628 = 22793560;
            }
            
            string val_2 = -1610604389(-1610604389) + -1610612465(-1610612465);
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_6, m_Width = val_1.m_Width, m_Height = val_1.m_Height}, text:  -1610604389)) == false)
            {
                goto label_7;
            }
            
            val_7 = this.Cinematics;
            if(val_7 == 0)
            {
                goto label_5;
            }
            
            if(this.Cinematics._isPlaying == false)
            {
                goto label_6;
            }
            
            label_9:
            val_7.Stop();
            goto label_7;
            label_5:
            val_7 = this.Cinematics;
            if(val_7 == 0)
            {
                    val_7 = 0;
            }
            
            if(this.Cinematics._isPlaying == true)
            {
                goto label_9;
            }
            
            label_6:
            val_7.Play();
            label_7:
            if(this.Cinematics._isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.Rect val_4 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            val_8 = mem[536887392];
            if((val_8 & true) == 0)
            {
                    val_8 = mem[536887321];
            }
            
            val_6 = -1610610499;
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_4.m_XMin, m_YMin = val_4.m_YMin, m_Width = val_4.m_Width, m_Height = val_4.m_Height}, text:  val_6)) == false)
            {
                    return;
            }
            
            this.Cinematics.GoToNextTarget();
        }
        public ToggleCinematics()
        {
        
        }
    
    }

}
