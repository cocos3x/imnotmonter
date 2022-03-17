using UnityEngine;

namespace Crazy
{
    public class LoadNextScene : MonoBehaviour
    {
        // Fields
        private float withDelay;
        
        // Methods
        private void Start()
        {
            this.Invoke(methodName:  -1610599407, time:  null);
        }
        private void loadNextScene()
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            int val_2 = val_1.m_Handle.buildIndex;
            val_2 = val_2 + 1;
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneBuildIndex:  val_2);
        }
        public LoadNextScene()
        {
            this.withDelay = 2f;
        }
    
    }

}
