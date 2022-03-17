using UnityEngine;
public class MoreGameFullManager : MonoBehaviour
{
    // Fields
    public MoregameInfor Infor;
    public UnityEngine.UI.RawImage ImgLandscape;
    public UnityEngine.UI.RawImage ImgPortrait;
    public UnityEngine.Transform contentScrollView;
    private UnityEngine.GameObject closeBtn;
    private System.Action<bool> moreGameCallBack;
    private UnityEngine.GameObject landscapeContent;
    private UnityEngine.GameObject portraitContent;
    
    // Methods
    private void OnEnable()
    {
        this.closeBtn.SetActive(value:  false);
        this.Invoke(methodName:  -1610610347, time:  null);
    }
    private void ActiveCloseBtn()
    {
        this.closeBtn.SetActive(value:  true);
    }
    public void ButtonCloseClick()
    {
        if(this.moreGameCallBack != 0)
        {
                this.moreGameCallBack.Invoke(obj:  true);
        }
        
        UnityEngine.GameObject val_1 = this.gameObject;
        UnityEngine.Object.Destroy(obj:  487814192);
    }
    public void ButtonDownloadClick()
    {
        mem[536890903].OnClick(item:  487930288);
    }
    public void ShowMoregame(UnityEngine.Texture sprite, System.Action<bool> action, bool forceFirstTime = False, bool isPortrait = False)
    {
        UnityEngine.GameObject val_3;
        UnityEngine.UI.RawImage val_4;
        if(forceFirstTime != false)
        {
                UnityEngine.Time.timeScale = null;
        }
        
        this.moreGameCallBack = action;
        if(isPortrait != false)
        {
                if(UnityEngine.Screen.width <= UnityEngine.Screen.height)
        {
            goto label_2;
        }
        
        }
        
        val_3 = this.landscapeContent;
        val_3.SetActive(value:  true);
        val_4 = this.ImgLandscape;
        goto label_4;
        label_2:
        val_3 = this.portraitContent;
        val_3.SetActive(value:  true);
        val_4 = this.ImgPortrait;
        label_4:
        val_4.texture = sprite;
    }
    public MoreGameFullManager()
    {
    
    }

}
