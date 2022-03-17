using UnityEngine;
public class ResizeQuadEffectController : MonoBehaviour
{
    // Fields
    public bool FlipTexture;
    public int sorting;
    public static ResizeQuadEffectController instance;
    private UnityEngine.Texture effectTex2d;
    private UnityEngine.Camera effectCam;
    private UnityEngine.RenderTexture backTex2d;
    private UnityEngine.GameObject effectCamera;
    private UnityEngine.GameObject backgroundCamera;
    
    // Methods
    public static void RebuildTextures(int flipTex = -1)
    {
        var val_5;
        var val_6;
        var val_7;
        if(mem[536892951] == 0)
        {
                T[] val_2 = UnityEngine.Object.FindObjectsOfType<Water2D.Water2D_Spawner>();
            val_5 = mem[3221279063];
            if(val_5 >= 2)
        {
                var val_7 = 5;
            do
        {
            val_7 = val_7 - 4;
            UnityEngine.GameObject val_3 = mem[3221279071].gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  mem[3221279071]);
            val_5 = mem[3221279063];
            var val_5 = val_7 + 1;
        }
        while((val_7 - 3) < val_5);
        
        }
        
            UnityEngine.Transform val_6 = mem[3221279067].GetComponent<UnityEngine.Transform>();
            mem2[0] = mem[3221279067];
        }
        
        if(flipTex == 1)
        {
            goto label_15;
        }
        
        if(flipTex != 0)
        {
            goto label_16;
        }
        
        val_6 = 536892859;
        val_7 = 0;
        goto label_17;
        label_15:
        val_6 = 536892859;
        val_7 = 1;
        label_17:
        mem2[0] = val_7;
        label_16:
        mem[536892951].RebuildRenderTexturesAll();
    }
    private void Awake()
    {
        var val_3 = 22714624;
        if(mem[536892951] != 0)
        {
                return;
        }
        
        mem2[0] = this;
    }
    private void Start()
    {
        this.RebuildRenderTexturesAll();
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Transform val_2 = this.transform;
        this.hideFlags = 2;
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
    public void AboutToRebuildAll()
    {
        Weight val_1 = this.effectCamera.GetComponent<Weight>();
        this.effectCamera.targetTexture = 0;
    }
    public void RebuildRenderTexturesAll()
    {
        int val_34;
        UnityEngine.GameObject val_35;
        UnityEngine.Camera val_1 = UnityEngine.Camera.main;
        val_34 = 0.pixelWidth;
        UnityEngine.Camera val_3 = UnityEngine.Camera.main;
        int val_4 = 0.pixelHeight;
        UnityEngine.GameObject val_5 = this.gameObject;
        UnityEngine.Transform val_6 = this.transform;
        UnityEngine.Transform val_7 = this.parent;
        UnityEngine.GameObject val_8 = this.gameObject;
        this.effectCamera = this;
        UnityEngine.GameObject val_9 = this.gameObject;
        UnityEngine.Transform val_10 = this.transform;
        UnityEngine.Transform val_11 = this.parent;
        UnityEngine.Transform val_12 = this.parent;
        UnityEngine.Transform val_13 = this.Find(n:  -1610611651);
        if((UnityEngine.Object.op_Implicit(exists:  866845456)) != false)
        {
                UnityEngine.GameObject val_15 = this.gameObject;
            UnityEngine.Transform val_16 = this.transform;
            UnityEngine.Transform val_17 = this.parent;
            UnityEngine.Transform val_18 = this.parent;
            UnityEngine.Transform val_19 = this.Find(n:  -1610611651);
            UnityEngine.GameObject val_20 = this.gameObject;
            val_35 = this;
            this.backgroundCamera = this;
        }
        else
        {
                val_35 = this.backgroundCamera;
        }
        
        if(mem[this.backgroundCamera] != 0)
        {
                536892813 = new UnityEngine.RenderTexture(width:  val_34, height:  val_4, depth:  24, format:  0, readWrite:  0);
            UnityEngine.Transform val_23 = this.GetComponent<UnityEngine.Transform>();
            UnityEngine.Material val_24 = this.sharedMaterial;
            this.SetTexture(name:  -1610602169, value:  536892813);
            Weight val_25 = mem[this.backgroundCamera].GetComponent<Weight>();
            mem[this.backgroundCamera].forceIntoRenderTexture = true;
            Weight val_26 = mem[this.backgroundCamera].GetComponent<Weight>();
            mem[this.backgroundCamera].targetTexture = 536892813;
            val_34 = val_34;
        }
        
        536892813 = new UnityEngine.RenderTexture(width:  val_34, height:  val_4, depth:  24, format:  0, readWrite:  0);
        UnityEngine.Transform val_28 = this.GetComponent<UnityEngine.Transform>();
        UnityEngine.Material val_29 = this.sharedMaterial;
        this.SetTexture(name:  -1610602093, value:  536892813);
        UnityEngine.Transform val_30 = this.GetComponent<UnityEngine.Transform>();
        UnityEngine.Material val_31 = this.sharedMaterial;
        this.SetTexture(name:  -1610602135, value:  536892813);
        Weight val_32 = this.GetComponent<Weight>();
        this.forceIntoRenderTexture = true;
        Weight val_33 = this.GetComponent<Weight>();
        this.targetTexture = 536892813;
    }
    public void SetSorting(int id = 0)
    {
        UnityEngine.Transform val_1 = this.GetComponent<UnityEngine.Transform>();
        this.sortingOrder = id;
    }
    public ResizeQuadEffectController()
    {
    
    }

}
