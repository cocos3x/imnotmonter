using UnityEngine;
public class RandomPosVFXUI : MonoBehaviour
{
    // Fields
    private float timeDelayStart;
    private float timePlayVFX;
    private UnityEngine.ParticleSystem particle;
    private UnityEngine.RectTransform rectTransform;
    private UnityEngine.Vector2 posLimmitTop;
    private UnityEngine.Vector2 posLimmitBot;
    private float timeRamdomMin;
    private float timeRamdomMax;
    
    // Methods
    private void OnEnable()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  -1610605347);
    }
    private System.Collections.IEnumerator PlayEffStart()
    {
        536900693 = new RandomPosVFXUI.<PlayEffStart>d__9(<>1__state:  0);
        mem[536900709] = this;
    }
    private System.Collections.IEnumerator PlayEff()
    {
        536900691 = new RandomPosVFXUI.<PlayEff>d__10(<>1__state:  0);
        mem[536900707] = this;
    }
    public RandomPosVFXUI()
    {
        this.timeRamdomMax = 1f;
        this.timePlayVFX = 2f;
    }

}
