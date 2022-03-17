using UnityEngine;

namespace WrappingRope.Demo
{
    public class GUICharacter : MonoBehaviour
    {
        // Methods
        private void Start()
        {
        
        }
        private void Update()
        {
        
        }
        private void OnGUI()
        {
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = val_1.m_XMin, m_YMin = val_1.m_YMin, m_Width = val_1.m_Width, m_Height = val_1.m_XMin});
            UnityEngine.GUIStyle val_2 = UnityEngine.GUIStyle.op_Implicit(str:  -1610601557);
            val_6 = mem[mem[3221271779] + 186];
            val_6 = mem[3221271779] + 186;
            if(val_6 == 1)
            {
                    val_6 = mem[mem[3221271779] + 186];
                val_6 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.BeginHorizontal(style:  -1610601557, options:  mem[3221271779] + 92);
            val_7 = mem[mem[3221271779] + 186];
            val_7 = mem[3221271779] + 186;
            if(val_7 == 1)
            {
                    val_7 = mem[mem[3221271779] + 186];
                val_7 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.BeginVertical(options:  mem[3221271779] + 92);
            val_8 = mem[mem[3221271779] + 186];
            val_8 = mem[3221271779] + 186;
            if(val_8 == 1)
            {
                    val_8 = mem[mem[3221271779] + 186];
                val_8 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.Label(text:  -1610605325, options:  mem[3221271779] + 92);
            val_9 = mem[mem[3221271779] + 186];
            val_9 = mem[3221271779] + 186;
            if(val_9 == 1)
            {
                    val_9 = mem[mem[3221271779] + 186];
                val_9 = mem[3221271779] + 186;
            }
            
            UnityEngine.GUILayout.Label(text:  -1610602625, options:  mem[3221271779] + 92);
            val_10 = mem[mem[3221271779] + 186];
            val_10 = mem[3221271779] + 186;
            if(val_10 == 1)
            {
                    val_10 = mem[mem[3221271779] + 186];
                val_10 = mem[3221271779] + 186;
            }
            
            if((UnityEngine.GUILayout.Button(text:  -1610604923, options:  mem[3221271779] + 92)) != false)
            {
                    UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
                string val_5 = val_4.m_Handle.name;
                UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  922126132);
            }
            
            UnityEngine.GUILayout.EndVertical();
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.EndArea();
        }
        public GUICharacter()
        {
        
        }
    
    }

}
