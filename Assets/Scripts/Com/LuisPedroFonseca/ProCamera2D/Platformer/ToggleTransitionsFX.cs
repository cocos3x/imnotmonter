using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.Platformer
{
    public class ToggleTransitionsFX : MonoBehaviour
    {
        // Methods
        private void OnGUI()
        {
            bool val_7;
            bool val_8;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            val_7 = mem[536887392];
            if((val_7 & true) == 0)
            {
                    val_7 = mem[536887321];
            }
            
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height}, text:  -1610603335)) != false)
            {
                    Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTransitionsFX val_3 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTransitionsFX.Instance;
                0.TransitionEnter();
            }
            
            UnityEngine.Rect val_4 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            val_8 = mem[536887392];
            if((val_8 & true) == 0)
            {
                    val_8 = mem[536887321];
            }
            
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_4.m_XMin, m_YMin = val_4.m_YMin, m_Width = val_4.m_Width, m_Height = val_4.m_Height}, text:  -1610603333)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTransitionsFX val_6 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2DTransitionsFX.Instance;
            0.TransitionExit();
        }
        public ToggleTransitionsFX()
        {
        
        }
    
    }

}
