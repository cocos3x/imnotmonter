using UnityEngine;
public class FPSDisplay : MonoBehaviour
{
    // Fields
    private float deltaTime;
    
    // Methods
    private void Update()
    {
        float val_1 = UnityEngine.Time.deltaTime;
        float val_2 = this.deltaTime;
        val_2 = 0 - val_2;
        this.deltaTime = this.deltaTime;
    }
    private void OnGUI()
    {
        bool val_12;
        int val_1 = UnityEngine.Screen.width;
        UnityEngine.GUIStyle val_3 = 536887255;
        val_3 = new UnityEngine.GUIStyle();
        int val_4 = UnityEngine.Screen.height << 1;
        int val_6 = (val_4 >> 5) + (val_4 >> 31);
        UnityEngine.Rect val_7 = new UnityEngine.Rect(x:  (float)val_6, y:  null, width:  null, height:  null);
        if(val_3 != 0)
        {
                val_3.alignment = 0;
            val_3.fontSize = val_6;
        }
        else
        {
                val_3.alignment = 0;
            val_3.fontSize = val_6;
        }
        
        UnityEngine.GUIStyleState val_8 = val_3.normal;
        UnityEngine.Color val_9 = new UnityEngine.Color(r:  (float)val_6, g:  null, b:  null, a:  null);
        val_3.textColor = new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a};
        float val_10 = 1f / this.deltaTime;
        float val_12 = 1000f;
        val_12 = this.deltaTime * val_12;
        string val_11 = System.String.Format(format:  -1610597111, arg0:  536893745, arg1:  536893745);
        val_12 = mem[536887392];
        if((val_12 & true) == 0)
        {
                val_12 = mem[536887321];
        }
        
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_7.m_XMin, m_YMin = val_7.m_YMin, m_Width = val_7.m_Width, m_Height = val_7.m_Height}, text:  -1610597111, style:  val_3);
    }
    public FPSDisplay()
    {
    
    }

}
