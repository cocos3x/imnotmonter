using UnityEngine;

namespace Com.LuisPedroFonseca.ProCamera2D.TopDownShooter
{
    public class GameOver : MonoBehaviour
    {
        // Fields
        public UnityEngine.Canvas GameOverScreen;
        
        // Methods
        private void Awake()
        {
            UnityEngine.GameObject val_1 = this.GameOverScreen.gameObject;
            this.GameOverScreen.SetActive(value:  false);
        }
        public void ShowScreen()
        {
            UnityEngine.GameObject val_1 = this.GameOverScreen.gameObject;
            this.GameOverScreen.SetActive(value:  true);
            UnityEngine.Time.timeScale = null;
        }
        public void PlayAgain()
        {
            UnityEngine.Time.timeScale = null;
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            string val_2 = val_1.m_Handle.name;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  1093308476);
        }
        public GameOver()
        {
        
        }
    
    }

}
