using UnityEngine;
public class SceneLoadManager : SingletonMonoBehaviour<SceneLoadManager>
{
    // Fields
    public bool isLoading;
    private readonly string nameSceneSpl;
    private readonly string nameSceneHome;
    private readonly string nameSceneGamePlay;
    private readonly string nameScenePinPull;
    private readonly string nameSceneGameRopeRescue;
    private readonly string nameSceneGameCutRescue;
    
    // Methods
    public void LoadSceneWithName(string name)
    {
        this.isLoading = true;
        System.Collections.IEnumerator val_1 = this.WaitLoadAsyncScene(name:  name);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  541388816);
    }
    public void LoadSceneHome()
    {
        mem2[0] = 0;
        this.isLoading = true;
        System.Collections.IEnumerator val_1 = this.WaitLoadAsyncScene(name:  this.nameSceneHome);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  541509008);
    }
    public void LoadScenePinPull()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.GameMode = 1;
        this.isLoading = true;
        System.Collections.IEnumerator val_2 = this.WaitLoadAsyncScene(name:  this.nameScenePinPull);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  541629200);
    }
    public void LoadSceneRopeRescue()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.GameMode = 0;
        this.isLoading = true;
        System.Collections.IEnumerator val_2 = this.WaitLoadAsyncScene(name:  this.nameSceneGameRopeRescue);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  541749392);
    }
    public void LoadSceneCutRescue()
    {
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        -1073708883.GameMode = 2;
        this.isLoading = true;
        System.Collections.IEnumerator val_2 = this.WaitLoadAsyncScene(name:  this.nameSceneGameCutRescue);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  541869584);
    }
    public void OpenSelectModePopup()
    {
    
    }
    private void LoadAsyncScene(string name)
    {
        this.isLoading = true;
        System.Collections.IEnumerator val_1 = this.WaitLoadAsyncScene(name:  name);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  542101776);
    }
    private System.Collections.IEnumerator WaitLoadAsyncScene(string name)
    {
        SceneLoadManager.<WaitLoadAsyncScene>d__14 val_1 = 536900887;
        val_1 = new SceneLoadManager.<WaitLoadAsyncScene>d__14(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900907] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536900903] = name;
    }
    public SceneLoadManager()
    {
        this.nameSceneSpl = -1610604413;
        this.nameSceneHome = -1610607723;
        this.nameSceneGamePlay = -1610607943;
        this.nameScenePinPull = -1610605361;
        this.nameSceneGameRopeRescue = -1610607941;
        this.nameSceneGameCutRescue = -1610607955;
    }

}
