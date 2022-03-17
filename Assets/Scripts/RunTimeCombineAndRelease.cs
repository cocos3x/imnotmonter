using UnityEngine;
public class RunTimeCombineAndRelease : MonoBehaviour
{
    // Fields
    public SimpleMeshCombine simpleMeshCombine;
    public float combineTime;
    public float releaseTime;
    
    // Methods
    public void Awake()
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.simpleMeshCombine = this;
    }
    public void Start()
    {
        if(this.simpleMeshCombine == 0)
        {
                UnityEngine.Debug.Log(message:  -1610609063);
            return;
        }
        
        this.Invoke(methodName:  -1610609277, time:  null);
        this.Invoke(methodName:  -1610604993, time:  null);
    }
    public void Combine()
    {
        this.simpleMeshCombine.CombineMeshes();
        UnityEngine.Debug.Log(message:  -1610609275);
    }
    public void Release()
    {
        this.simpleMeshCombine.EnableRenderers(e:  true);
        if(this.simpleMeshCombine.combined == 0)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.simpleMeshCombine.combined);
        this.simpleMeshCombine.combinedGameOjects = 0;
        UnityEngine.Debug.Log(message:  -1610604991);
    }
    public RunTimeCombineAndRelease()
    {
        this.combineTime = 0.5f;
        this.releaseTime = 2f;
    }

}
