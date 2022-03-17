using UnityEngine;
public class SceneFader : SingletonMonoBehaviour<SceneFader>
{
    // Fields
    public UnityEngine.UI.Image fadeOutUIImage;
    public float fadeSpeed;
    
    // Methods
    private void OnEnable()
    {
        System.Collections.IEnumerator val_1 = this.Fade(fadeDirection:  1);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  539918000);
    }
    private System.Collections.IEnumerator Fade(SceneFader.FadeDirection fadeDirection)
    {
        SceneFader.<Fade>d__4 val_1 = 536900877;
        val_1 = new SceneFader.<Fade>d__4(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900897] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536900893] = fadeDirection;
    }
    public System.Collections.IEnumerator FadeAndLoadScene(SceneFader.FadeDirection fadeDirection, string sceneToLoad)
    {
        SceneFader.<FadeAndLoadScene>d__5 val_1 = 536900879;
        val_1 = new SceneFader.<FadeAndLoadScene>d__5(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900895] = this;
            mem[536900899] = fadeDirection;
        }
        else
        {
                mem[16] = this;
            mem[20] = fadeDirection;
        }
        
        mem[536900903] = sceneToLoad;
    }
    private void SetColorImage(ref float alpha, SceneFader.FadeDirection fadeDirection)
    {
        UnityEngine.Color val_1 = color;
        UnityEngine.Color val_3 = color;
        UnityEngine.Color val_5 = color;
        UnityEngine.Color val_7 = new UnityEngine.Color(r:  alpha, g:  val_5.g, b:  val_5.b, a:  val_5.a);
        this.fadeOutUIImage.color = new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.r};
        float val_8 = UnityEngine.Time.deltaTime;
        float val_9 = this.fadeSpeed;
        val_9 = 1f / val_9;
        if(fadeDirection == 1)
        {
                1f = -1f;
        }
        
        val_9 = 0 * val_9;
        alpha = alpha;
    }
    public void LoadScene(string sceneName)
    {
        System.Collections.IEnumerator val_1 = this.FadeAndLoadScene(fadeDirection:  0, sceneToLoad:  sceneName);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  540435472);
    }
    public SceneFader()
    {
        this.fadeSpeed = 0.8f;
    }

}
