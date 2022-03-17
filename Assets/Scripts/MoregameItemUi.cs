using UnityEngine;
public class MoregameItemUi : MonoBehaviour
{
    // Fields
    public bool UseNativeSize;
    public bool IsFeature;
    public UnityEngine.UI.RawImage IconView;
    public MoregameInfor Infor;
    public bool IsLoading;
    public UnityEngine.UI.Text gameNameText;
    public string gameName;
    private bool _isInited;
    public const string StoreLinkPrefix = "https://play.google.com/store/apps/details?id=";
    
    // Methods
    private void OnEnable()
    {
    
    }
    private void Start()
    {
    
    }
    public void LoadMoregame()
    {
        System.Collections.IEnumerator val_1 = this.GetTextureIE();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  490366896);
    }
    public System.Collections.IEnumerator DelayGetMore()
    {
        536900053 = new MoregameItemUi.<DelayGetMore>d__12(<>1__state:  0);
    }
    public System.Collections.IEnumerator GetTextureIE()
    {
        536900055 = new MoregameItemUi.<GetTextureIE>d__13(<>1__state:  0);
        mem[536900071] = this;
    }
    private string GetPackage(string link)
    {
        if(API.IsIOS() != false)
        {
                return;
        }
        
        if(link != null)
        {
                return link.Replace(oldValue:  -1610600083, newValue:  mem[536894675]);
        }
        
        return link.Replace(oldValue:  -1610600083, newValue:  mem[536894675]);
    }
    public void ApplyMoregameInfor(UnityEngine.Texture texture, string gameName)
    {
    
    }
    public void OnClick()
    {
        mem[536890903].OnClick(item:  490955568);
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        536874379.Add(key:  -1610607951, value:  this.gameName);
        -1073700879.TrackEvent(eventName:  -1610606239, parameters:  536874379);
    }
    public MoregameItemUi()
    {
    
    }

}
