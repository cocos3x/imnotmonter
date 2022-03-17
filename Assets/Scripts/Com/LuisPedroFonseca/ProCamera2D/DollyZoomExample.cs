using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D
{
    public class DollyZoomExample : MonoBehaviour
    {
        // Fields
        public float TargetFOV;
        public float Duration;
        public Com.LuisPedroFonseca.ProCamera2D.EaseType EaseType;
        public float ZoomAmount;
        
        // Methods
        private void OnGUI()
        {
            bool val_17;
            string val_18;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            UnityEngine.GUIStyle val_2 = 536887255;
            val_2 = new UnityEngine.GUIStyle();
            val_17 = mem[536887392];
            if((val_17 & true) == 0)
            {
                    val_17 = mem[536887321];
            }
            
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_Height}, text:  -1610604051, style:  val_2);
            UnityEngine.Rect val_3 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            float val_4 = UnityEngine.GUI.HorizontalSlider(position:  new UnityEngine.Rect() {m_XMin = val_3.m_XMin, m_YMin = val_3.m_YMin, m_Width = val_3.m_Width, m_Height = val_3.m_XMin}, value:  this.TargetFOV, leftValue:  null, rightValue:  null);
            this.TargetFOV = val_3.m_XMin;
            UnityEngine.Rect val_5 = new UnityEngine.Rect(x:  val_4, y:  null, width:  null, height:  null);
            UnityEngine.GUIStyle val_6 = 536887255;
            val_6 = new UnityEngine.GUIStyle();
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_5.m_XMin, m_YMin = val_5.m_YMin, m_Width = val_5.m_Width, m_Height = val_5.m_XMin}, text:  -1610608649, style:  val_6);
            UnityEngine.Rect val_7 = new UnityEngine.Rect(x:  val_4, y:  null, width:  null, height:  null);
            float val_8 = UnityEngine.GUI.HorizontalSlider(position:  new UnityEngine.Rect() {m_XMin = val_7.m_XMin, m_YMin = val_7.m_YMin, m_Width = val_7.m_Width, m_Height = val_7.m_XMin}, value:  this.Duration, leftValue:  null, rightValue:  null);
            this.Duration = val_7.m_XMin;
            UnityEngine.Rect val_9 = new UnityEngine.Rect(x:  val_8, y:  null, width:  null, height:  null);
            UnityEngine.GUIStyle val_10 = 536887255;
            val_10 = new UnityEngine.GUIStyle();
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_9.m_XMin, m_YMin = val_9.m_YMin, m_Width = val_9.m_Width, m_Height = val_9.m_XMin}, text:  -1610602403, style:  val_10);
            UnityEngine.Rect val_11 = new UnityEngine.Rect(x:  val_8, y:  null, width:  null, height:  null);
            float val_12 = UnityEngine.GUI.HorizontalSlider(position:  new UnityEngine.Rect() {m_XMin = val_11.m_XMin, m_YMin = val_11.m_YMin, m_Width = val_11.m_Width, m_Height = val_11.m_XMin}, value:  this.ZoomAmount, leftValue:  null, rightValue:  null);
            this.ZoomAmount = val_11.m_XMin;
            UnityEngine.Rect val_13 = new UnityEngine.Rect(x:  val_12, y:  null, width:  null, height:  null);
            val_18 = -1610608683;
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_13.m_XMin, m_YMin = val_13.m_YMin, m_Width = val_13.m_Width, m_Height = val_13.m_XMin}, text:  val_18)) == false)
            {
                    return;
            }
            
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_15 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2D.Instance;
            val_18 = this.EaseType;
            0.DollyZoom(targetFOV:  val_12, duration:  null, easeType:  this.TargetFOV);
            Com.LuisPedroFonseca.ProCamera2D.ProCamera2D val_16 = Com.LuisPedroFonseca.ProCamera2D.ProCamera2D.Instance;
            0.Zoom(zoomAmount:  val_12, duration:  null, easeType:  this.ZoomAmount);
        }
        public DollyZoomExample()
        {
            this.TargetFOV = 30f;
            this.Duration = 2f;
            this.ZoomAmount = -0.2f;
        }
    
    }

}
