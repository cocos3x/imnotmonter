using UnityEngine;
public class CanvasDetechBanner : MonoBehaviour
{
    // Fields
    private UnityEngine.RectTransform rectTransform;
    private float bannerPos;
    private float noBannerPos;
    public static bool isShowBanner;
    
    // Methods
    private void OnEnable()
    {
        var val_3;
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  800923280, method:  new IntPtr(1610681543));
        GameTool.EventDispatcherExtension.RegisterListener(sender:  800923280, eventID:  12, callback:  536873423);
        if(API.IsRemoveAds != false)
        {
                this.CheckBanner(isShow:  false);
            return;
        }
        
        val_3 = 536884605;
        if(((mem[536884792] & true) == 0) && (mem[536884721] == 0))
        {
                val_3 = 536884605;
        }
        
        this.CheckBanner(isShow:  mem[536884697]);
    }
    private void OnDisable()
    {
        536873423 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  801035280, method:  new IntPtr(1610681545));
        GameTool.EventDispatcherExtension.RemoveListener(sender:  801035280, eventID:  12, callback:  536873423);
    }
    private void CheckBanner(bool isShow)
    {
        var val_1;
        var val_2;
        UnityEngine.RectTransform val_3;
        float val_4;
        var val_5;
        val_1 = 536884605;
        var val_1 = mem[536884791];
        val_1 = val_1 & 512;
        if(isShow != false)
        {
                if((val_1 != 0) && (mem[536884721] == 0))
        {
                val_2 = 536884605;
        }
        
            mem2[0] = 1;
            val_3 = this.rectTransform;
            val_4 = this.bannerPos;
        }
        else
        {
                if((val_1 != 0) && (mem[536884721] == 0))
        {
                val_5 = 536884605;
        }
        
            mem2[0] = 0;
            val_3 = this.rectTransform;
            val_4 = this.noBannerPos;
        }
        
        val_3.anchoredPosition = new UnityEngine.Vector2() {x = 0f, y = val_4};
    }
    public CanvasDetechBanner()
    {
    
    }
    private static CanvasDetechBanner()
    {
        mem2[0] = 1;
    }
    private void <OnEnable>b__4_0(UnityEngine.Component sender, object param)
    {
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        this.CheckBanner(isShow:  false);
    }
    private void <OnDisable>b__5_0(UnityEngine.Component sender, object param)
    {
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        this.CheckBanner(isShow:  false);
    }

}
