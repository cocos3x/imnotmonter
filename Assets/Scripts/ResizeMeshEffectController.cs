using UnityEngine;
public class ResizeMeshEffectController : MonoBehaviour
{
    // Fields
    private UnityEngine.Texture effectTex2d;
    private UnityEngine.RenderTexture backTex2d;
    private UnityEngine.Camera effectCam;
    private UnityEngine.Camera backgroundCam;
    private UnityEngine.GameObject effectCamera;
    private UnityEngine.GameObject backgroundCamera;
    
    // Methods
    private void Start()
    {
        this.RebuildRenderTexturesAll();
    }
    private void Update()
    {
        Weight val_1 = this.effectCamera.GetComponent<Weight>();
        UnityEngine.RenderTexture val_2 = this.effectCamera.targetTexture;
        if(this.effectCamera != 0)
        {
                return;
        }
        
        R4.RebuildRenderTexturesAll();
    }
    public void RebuildRenderTexturesAll()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Transform val_2 = this.transform;
        UnityEngine.Transform val_3 = this.parent;
        UnityEngine.GameObject val_4 = this.gameObject;
        this.effectCamera = this;
        UnityEngine.GameObject val_5 = this.gameObject;
        UnityEngine.Transform val_6 = this.transform;
        UnityEngine.Transform val_7 = this.parent;
        UnityEngine.Transform val_8 = this.parent;
        UnityEngine.Transform val_9 = this.Find(n:  -1610611651);
        UnityEngine.GameObject val_10 = this.gameObject;
        this.backgroundCamera = this;
        Weight val_11 = this.GetComponent<Weight>();
        UnityEngine.Color val_12 = new UnityEngine.Color(r:  null, g:  null, b:  null, a:  null);
        this.backgroundColor = new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a};
        536892813 = new UnityEngine.RenderTexture(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, depth:  24, format:  0, readWrite:  0);
        536892813 = new UnityEngine.RenderTexture(width:  UnityEngine.Screen.width, height:  UnityEngine.Screen.height, depth:  24, format:  0, readWrite:  0);
        UnityEngine.Transform val_19 = this.GetComponent<UnityEngine.Transform>();
        UnityEngine.Material val_20 = this.sharedMaterial;
        this.SetTexture(name:  -1610602135, value:  536892813);
        UnityEngine.Transform val_21 = this.GetComponent<UnityEngine.Transform>();
        UnityEngine.Material val_22 = this.sharedMaterial;
        this.SetTexture(name:  -1610602169, value:  536892813);
        Weight val_23 = this.GetComponent<Weight>();
        this.targetTexture = 536892813;
        Weight val_24 = this.GetComponent<Weight>();
        this.targetTexture = 536892813;
    }
    public ResizeMeshEffectController()
    {
    
    }

}
