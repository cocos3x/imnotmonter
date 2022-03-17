using UnityEngine;
public class ScreenRecorder : MonoBehaviour
{
    // Fields
    public int captureWidth;
    public int captureHeight;
    public UnityEngine.GameObject hideGameObject;
    public bool optimizeForManyScreenshots;
    public ScreenRecorder.Format format;
    public string folder;
    private UnityEngine.Rect rect;
    private UnityEngine.RenderTexture renderTexture;
    private UnityEngine.Texture2D screenShot;
    private int counter;
    private bool captureScreenshot;
    private bool captureVideo;
    
    // Methods
    private string uniqueFilename(int width, int height)
    {
        int val_12;
        int val_13;
        val_12 = height;
        val_13 = width;
        if(this.folder != null)
        {
                this.folder = this.folder.m_stringLength;
        }
        
        if(this.folder == 0)
        {
                string val_1 = UnityEngine.Application.dataPath;
            this.folder = 0;
            if(UnityEngine.Application.isEditor != false)
        {
                string val_3 = null + -1610611737(-1610611737);
            string val_4 = System.IO.Path.GetFullPath(path:  null);
            this.folder = this.folder;
        }
        
            string val_5 = this.folder + -1610611669(-1610611669);
            this.folder = this.folder;
            System.IO.DirectoryInfo val_6 = System.IO.Directory.CreateDirectory(path:  this.folder);
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            mem2[0] = mem[536900901];
            string val_7 = 536900901.ToLower();
            string val_8 = System.String.Format(format:  -1610598517, arg0:  536888987, arg1:  536888987, arg2:  536900901);
            System.String[] val_9 = System.IO.Directory.GetFiles(path:  this.folder, searchPattern:  -1610598517, searchOption:  0);
            val_13 = val_13;
            val_12 = val_12;
            this.counter = this.folder.m_firstChar;
        }
        
        mem[536882227] = this.folder;
        mem[536882231] = 536888987;
        mem[536882235] = 536888987;
        mem[536882239] = 536888987;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536900901];
        string val_10 = 536900901.ToLower();
        mem[536882243] = 536900901;
        string val_11 = System.String.Format(format:  -1610597009, args:  536882211);
        int val_12 = this.counter;
        val_12 = val_12 + 1;
        this.counter = val_12;
    }
    public void CaptureScreenshot()
    {
        this.captureScreenshot = true;
    }
    private void Update()
    {
        var val_24;
        UnityEngine.Texture2D val_25;
        var val_26;
        UnityEngine.Object val_27;
        var val_28;
        UnityEngine.Texture2D val_29;
        bool val_1 = UnityEngine.Input.GetKeyDown(name:  -1610599637);
        if(this.captureScreenshot == true)
        {
                val_24 = 1;
        }
        
        val_1 = 1 | val_1;
        this.captureScreenshot = val_1;
        this.captureVideo = UnityEngine.Input.GetKey(name:  -1610597493);
        if(this.captureScreenshot == false)
        {
                return;
        }
        
        536900899 = new ScreenRecorder.<>c__DisplayClass15_0();
        this.captureScreenshot = false;
        if(this.hideGameObject != 0)
        {
                this.hideGameObject.SetActive(value:  false);
        }
        
        if(this.renderTexture == 0)
        {
                UnityEngine.Rect val_6 = new UnityEngine.Rect(x:  (float)this.captureHeight, y:  null, width:  this.captureHeight, height:  null);
            UnityEngine.RenderTexture val_7 = 536892813;
            val_7 = new UnityEngine.RenderTexture(width:  this.captureWidth, height:  this.captureHeight, depth:  24);
            this.renderTexture = val_7;
            UnityEngine.Texture2D val_8 = 536895327;
            val_8 = new UnityEngine.Texture2D(width:  this.captureWidth, height:  this.captureHeight, textureFormat:  3, mipChain:  false);
            this.screenShot = val_8;
        }
        
        UnityEngine.Transform val_9 = this.GetComponent<UnityEngine.Transform>();
        if(this != 0)
        {
                this.targetTexture = this.renderTexture;
        }
        else
        {
                this.targetTexture = this.renderTexture;
        }
        
        this.Render();
        UnityEngine.RenderTexture.active = this.renderTexture;
        val_25 = this.screenShot;
        val_25.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = new UnityEngine.Rect(), m_YMin = this.renderTexture, m_Width = 0f, m_Height = 1.087358E-19f}, destX:  0, destY:  0);
        this.targetTexture = 0;
        UnityEngine.RenderTexture.active = 0;
        float val_10 = this.rect.width;
        float val_11 = this.rect.height;
        string val_12 = this.uniqueFilename(width:  (int)this.rect, height:  (int)this.rect);
        val_27 = this.renderTexture;
        if((1.088078E-19f) != 0)
        {
                mem[536900907] = this;
            val_28 = 1.088078E-19f;
            mem[536900911] = 0;
        }
        else
        {
                mem[8] = this;
            val_28 = 12;
            mem[12] = 0;
        }
        
        mem[536900915] = 0;
        if(this.format == 2)
        {
            goto label_15;
        }
        
        if(this.format == 1)
        {
            goto label_16;
        }
        
        if(this.format != 0)
        {
            goto label_17;
        }
        
        val_29 = this.screenShot;
        System.Byte[] val_13 = val_29.GetRawTextureData();
        goto label_20;
        label_15:
        val_29 = mem[this.screenShot];
        val_29 = this.screenShot;
        System.Byte[] val_14 = UnityEngine.ImageConversion.EncodeToPNG(tex:  val_29);
        goto label_20;
        label_16:
        val_29 = mem[this.screenShot];
        val_29 = this.screenShot;
        System.Byte[] val_15 = UnityEngine.ImageConversion.EncodeToJPG(tex:  val_29);
        label_20:
        mem[536900915] = val_29;
        goto label_21;
        label_17:
        val_25 = this.rect;
        float val_16 = val_25.width;
        float val_17 = val_25.height;
        string val_18 = System.String.Format(format:  -1610605529, arg0:  536893745, arg1:  536893745);
        val_26 = -1610605529;
        System.Text.Encoding val_19 = System.Text.Encoding.ASCII;
        mem[12] = 0;
        System.Byte[] val_20 = this.screenShot.GetRawTextureData();
        mem[536900915] = this.screenShot;
        val_27 = this.renderTexture;
        label_21:
        536895437 = new System.Threading.ThreadStart(object:  536900899, method:  new IntPtr(1610677469));
        536895401 = new System.Threading.Thread(start:  536895437);
        val_22.Start();
        val_24 = 22713552;
        if(this.hideGameObject != 0)
        {
                this.hideGameObject.SetActive(value:  true);
        }
        
        if(this.optimizeForManyScreenshots != true)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  val_27);
        mem2[0] = 0;
        mem2[0] = 0;
    }
    public ScreenRecorder()
    {
        this.captureWidth = 1920;
        this.captureHeight = 1080;
        this.optimizeForManyScreenshots = true;
        this.format = 3;
    }

}
