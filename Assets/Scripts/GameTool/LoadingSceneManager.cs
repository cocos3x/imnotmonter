using UnityEngine;

namespace GameTool
{
    public class LoadingSceneManager : MonoBehaviour
    {
        // Fields
        public static string LoadingScreenSceneName;
        public float StartFadeDuration;
        public float ProgressBarSpeed;
        public float ExitFadeDuration;
        public float LoadCompleteDelay;
        protected UnityEngine.AsyncOperation _asyncOperation;
        protected static string _sceneToLoad;
        protected float _fadeDuration;
        protected float _fillTarget;
        protected string _loadingTextValue;
        
        // Methods
        public static void LoadScene(string sceneToLoad, string page = "")
        {
            var val_1;
            string val_2;
            val_1 = 536889775;
            if(((mem[536889962] & true) == 0) && (mem[536889891] == 0))
            {
                    val_1 = 536889775;
            }
            
            mem2[0] = sceneToLoad;
            UnityEngine.Application.backgroundLoadingPriority = 4;
            val_2 = mem[mem[536889867]];
            val_2 = mem[536889867];
            if(val_2 == 0)
            {
                    return;
            }
            
            if(((mem[536889962] & true) == 0) && (mem[536889891] == 0))
            {
                    val_2 = mem[mem[536889867]];
                val_2 = mem[536889867];
            }
            
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName:  val_2);
        }
        protected virtual void Start()
        {
            if(((mem[536889962] & true) == 0) && (mem[536889891] == 0))
            {
                    536889775 = 536889775;
            }
            
            if((System.String.op_Inequality(a:  mem[536889867] + 4, b:  -1610612735)) == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = R4.StartCoroutine(routine:  R4);
        }
        protected virtual void Update()
        {
        
        }
        protected virtual System.Collections.IEnumerator LoadAsynchronously()
        {
            536899613 = new LoadingSceneManager.<LoadAsynchronously>d__13(<>1__state:  0);
            mem[536899629] = this;
        }
        protected virtual void LoadingSetup()
        {
        
        }
        protected virtual void LoadingComplete()
        {
        
        }
        public LoadingSceneManager()
        {
            this._fadeDuration = 0.5f;
        }
        private static LoadingSceneManager()
        {
            mem2[0] = -1610606591;
            mem2[0] = -1610612735;
        }
    
    }

}
