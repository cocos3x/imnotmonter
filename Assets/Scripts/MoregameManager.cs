using UnityEngine;
public class MoregameManager : MonoBehaviour
{
    // Fields
    public bool IsAddFeatureGameToRandomList;
    public const string StoreLinkPrefix = "https://play.google.com/store/apps/details?id=";
    public static MoregameManager Instance;
    public static System.Action OnMoregameLoaded;
    public static bool IsMoregameLoaded;
    private System.Collections.Generic.List<MoregameInfor> _moregameCanUse;
    private System.Collections.Generic.List<MoregameInfor> _moregameUsed;
    public System.Collections.Generic.Dictionary<string, UnityEngine.Texture2D> MoregameLoaded;
    private UnityEngine.Texture2D featureImage;
    private MoregameInfor featureItem;
    public MoregameInfors MoregameInfors;
    public string AndroidSheetId;
    public string AndroidGridId;
    public MoregameInfors AndroidMoregameInfors;
    public string IOSSheetId;
    public string IOSGridId;
    public MoregameInfors IosMoregameInfors;
    public UnityEngine.GameObject MoregameFullPrefab;
    public UnityEngine.GameObject MoregameItemPrefab;
    private bool FullMoregameShowed;
    private bool openFirstTime;
    
    // Methods
    private void Awake()
    {
        MoregameManager val_11;
        bool val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_11 = this;
        System.Collections.IEnumerator val_1 = this.WaitForData();
        val_12 = 0;
        UnityEngine.Coroutine val_2 = val_11.StartCoroutine(routine:  494609072);
        if((UnityEngine.PlayerPrefs.GetInt(key:  -1610608077)) == 0)
        {
                val_12 = true;
            UnityEngine.PlayerPrefs.SetInt(key:  -1610608077, value:  1);
        }
        
        this.openFirstTime = val_12;
        val_13 = 22713340;
        val_14 = 22713552;
        if(mem[536890903] != 0)
        {
            goto label_4;
        }
        
        mem2[0] = val_11;
        536873173 = new System.Action<SdkConfiguration>(object:  494609072, method:  new IntPtr(1610676649));
        System.Delegate val_6 = System.Delegate.Combine(a:  mem[536887065] + 4, b:  536873173);
        val_15 = mem[536887065] + 4;
        if(val_15 != 0)
        {
                if(val_15 == 536873173)
        {
            goto label_6;
        }
        
        }
        
        val_15 = 0;
        label_6:
        mem2[0] = val_15;
        536882991 = new System.Action(object:  494609072, method:  new IntPtr(1610676643));
        System.Delegate val_8 = System.Delegate.Combine(a:  mem[536887065], b:  536882991);
        val_16 = mem[536887065];
        if(val_16 != 0)
        {
                if(val_16 == 536882991)
        {
            goto label_8;
        }
        
        }
        
        val_16 = 0;
        label_8:
        mem2[0] = val_16;
        label_4:
        UnityEngine.GameObject val_9 = R4.gameObject;
        UnityEngine.Object.Destroy(obj:  R4);
    }
    private void LoadData()
    {
        var val_8 = 4999657;
        val_8 = 17999652 + val_8;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        Firebase.RemoteConfig.FirebaseRemoteConfig val_1 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance;
        if(val_8 == 0)
        {
                mem2[0] = 1;
        }
        
        Firebase.RemoteConfig.ConfigValue val_2 = 0.GetValue(key:  null);
        string val_3 = 0.StringValue;
        string val_4 = APIExtention.CorrectString(input:  494709032);
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_6 = System.String.Format(format:  -1610608085, arg0:  -1610599179, arg1:  494709032);
        -1073701127.ApiDebug(content:  -1610608085);
        LoadGameDictionary val_7 = UnityEngine.JsonUtility.FromJson<LoadGameDictionary>(json:  494709032);
        this.MoregameInfors = ;
    }
    private System.Collections.IEnumerator WaitForData()
    {
        536900069 = new MoregameManager.<WaitForData>d__23(<>1__state:  0);
        mem[536900085] = this;
    }
    private void LoadMoregame()
    {
        MoregameInfor val_9;
        System.Collections.Generic.List<MoregameInfor> val_12;
        var val_13;
        System.Collections.Generic.List<MoregameInfor> val_14;
        var val_16;
        object val_17;
        System.Predicate<Page> val_18;
        val_12 = this.MoregameInfors.Moregames;
        this._moregameCanUse.Clear();
        val_13 = 4;
        goto label_3;
        label_11:
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_14 = -1073701127;
        if((-1073701127) <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        string val_2 = this.GetPackage(link:  -1610611231);
        if((val_14.IsAppInstalled(bundleID:  null)) != true)
        {
                val_14 = this._moregameCanUse;
            if(this <= SB)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_14.Add(item:  2621443);
        }
        
        val_13 = 5;
        label_3:
        if((val_13 - 4) < val_14)
        {
            goto label_11;
        }
        
        if(val_14 == 0)
        {
                this._moregameCanUse.AddRange(collection:  val_12);
        }
        
        if(this._moregameCanUse <= 0)
        {
                return;
        }
        
        val_16 = 536900057;
        if(((mem[536900244] & true) == 0) && (mem[536900173] == 0))
        {
                val_16 = 536900057;
        }
        
        val_17 = mem[536900149];
        val_18 = mem[mem[536900149] + 8];
        val_18 = mem[536900149] + 8;
        if(val_18 == 0)
        {
                if(((mem[536900244] & true) == 0) && (mem[536900173] == 0))
        {
                val_17 = mem[536900149];
        }
        
            val_18 = 536879227;
            val_18 = new System.Predicate<Page>(object:  val_17, method:  new IntPtr(1610676687));
            mem2[0] = val_18;
        }
        
        MoregameInfor val_6 = this._moregameCanUse.Find(match:  536879227);
        val_12 = this;
        mem[1152921509396771664] = this._moregameCanUse;
        val_14 = mem[1152921509396771664];
        if(val_14 != 0)
        {
            goto label_23;
        }
        
        List.Enumerator<T> val_7 = GetEnumerator();
        label_27:
        if(MoveNext() == false)
        {
            goto label_25;
        }
        
        string val_10 = APIExtention.CorrectString(input:  val_9 + 20);
        if((System.String.op_Inequality(a:  val_9 + 20, b:  mem[536894675])) == false)
        {
            goto label_27;
        }
        
        mem[1152921509396771664] = val_9;
        label_25:
        Dispose();
        if(1 != 0)
        {
                var val_12 = 1 - 1;
        }
        
        val_14 = mem[1152921509396771664];
        if(val_14 == 0)
        {
            goto label_30;
        }
        
        label_23:
        bool val_13 = this._moregameCanUse.Remove(item:  val_14);
        label_30:
        APIExtention.Shuffle<System.Object>(list:  this._moregameCanUse);
        mem2[0] = 1;
        this.LoadMoregameFull();
    }
    private void InitDefaultMoregame(System.Collections.Generic.Dictionary<string, object> defaults)
    {
        var val_4;
        MoregameInfors val_5;
        if(API.IsAndroid() != false)
        {
                val_4 = -1610599179;
            val_5 = this.AndroidMoregameInfors;
        }
        else
        {
                if(API.IsIOS() == false)
        {
                return;
        }
        
            val_4 = -1610599179;
            val_5 = this.IosMoregameInfors;
        }
        
        string val_3 = UnityEngine.JsonUtility.ToJson(obj:  val_5);
        defaults.Add(key:  -1610599179, value:  val_5);
    }
    public void GetGame(MoregameItemUi item)
    {
        MoregameInfor val_7 = item.Infor;
        if(item.Infor.IconLink == null)
        {
                return;
        }
        
        item.IsLoading = true;
        string val_1 = this.GetPackage(link:  item.Infor.GameLink);
        if((this.MoregameLoaded.ContainsKey(key:  1)) != false)
        {
                UnityEngine.Texture2D val_3 = this.MoregameLoaded.Item[1];
            if(item.Infor != 0)
        {
                return;
        }
        
            return;
        }
        
        System.Collections.IEnumerator val_4 = this.TryLoadGame(item:  item);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  495250992);
    }
    public System.Collections.IEnumerator TryLoadGame(MoregameItemUi item)
    {
        MoregameManager.<TryLoadGame>d__27 val_1 = 536900067;
        val_1 = new MoregameManager.<TryLoadGame>d__27(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900087] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536900083] = item;
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
    public void OnClick(MoregameItemUi item)
    {
        string val_4 = item.Infor.GameLink;
        bool val_1 = API.IsAndroid();
        if(val_1 != false)
        {
                string val_2 = val_1.GetPackage(link:  val_4 = item.Infor.GameLink);
            string val_3 = -1610600083(-1610600083) + val_1;
            val_4 = -1610600083;
        }
        
        UnityEngine.Application.OpenURL(url:  -1610600083);
    }
    public string GetKey()
    {
    
    }
    public void LoadMoregameFromGoogleSheet(MoregameInfors moregameInfors, bool isAnroid)
    {
        var val_3;
        MoregameManager.<>c__DisplayClass31_0 val_1 = 536900061;
        val_1 = new MoregameManager.<>c__DisplayClass31_0();
        if(val_1 != 0)
        {
                val_3 = val_1;
            mem[536900069] = moregameInfors;
        }
        else
        {
                val_3 = 8;
            mem[8] = moregameInfors;
        }
        
        moregameInfors + 8.Clear();
        if(isAnroid == true)
        {
                56 = 44;
            52 = 40;
        }
        
        536873181 = new System.Action<SdkConfiguration>(object:  536900061, method:  new IntPtr(1610676717));
        MoregameManager.GetTable(id:  this.AndroidSheetId, gridId:  this.AndroidGridId, callBack:  536873181);
    }
    public static void GetTable(string id, string gridId, System.Action<System.Collections.Generic.List<System.Collections.Generic.List<string>>> callBack)
    {
        536900063 = new MoregameManager.<>c__DisplayClass32_0();
        mem[536900071] = callBack;
        536873327 = new System.Action<SdkConfiguration>(object:  536900063, method:  new IntPtr(1610676721));
        MoregameManager.LoadWebClient(id:  id, gridId:  gridId, callBack:  536873327);
    }
    public static void LoadWebClient(string id, string gridId, System.Action<string> callBack)
    {
        string val_1 = System.String.Format(format:  -1610600091, arg0:  id, arg1:  gridId);
        MoregameManager.LoadWebClient3(id:  -1610600091, callBack:  callBack);
    }
    public static void LoadWebClient3(string id, System.Action<string> callBack)
    {
        UnityEngine.WWW val_1 = 536896821;
        val_1 = new UnityEngine.WWW(url:  id);
        goto label_1;
        label_3:
        if(val_1.isDone == true)
        {
            goto label_2;
        }
        
        label_4:
        bool val_3 = val_1.MoveNext();
        label_1:
        if(val_1 == 0)
        {
            goto label_3;
        }
        
        if(val_1.isDone == false)
        {
            goto label_4;
        }
        
        label_2:
        string val_5 = val_1.text;
        UnityEngine.Debug.Log(message:  536896821);
        string val_6 = val_1.text;
        callBack.Invoke(obj:  536896821);
    }
    public void LoadMoregameFull()
    {
        this.FullMoregameShowed = false;
        if(this.featureItem == 0)
        {
                return;
        }
        
        string val_1 = APIExtention.CorrectString(input:  this.featureItem.FullLink);
        if((System.String.op_Inequality(a:  this.featureItem.FullLink, b:  mem[536894675])) == false)
        {
                return;
        }
        
        System.Collections.IEnumerator val_3 = R4.TryLoadFullMoreGame(item:  R4 + 32);
        UnityEngine.Coroutine val_4 = R4.StartCoroutine(routine:  R4);
    }
    public void LoadMoreGameItem(UnityEngine.Transform content)
    {
        float val_5;
        float val_6;
        UnityEngine.Transform val_11;
        var val_12;
        var val_13;
        val_11 = content;
        if(true < 1)
        {
                return;
        }
        
        val_12 = 135;
        val_13 = 0;
        goto label_3;
        label_17:
        DropdownItem val_1 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this.MoregameItemPrefab);
        UnityEngine.Transform val_2 = this.MoregameItemPrefab.transform;
        this.MoregameItemPrefab.parent = val_11;
        UnityEngine.Transform val_3 = this.MoregameItemPrefab.transform;
        UnityEngine.Vector2 val_4 = UnityEngine.Vector2.one;
        this.MoregameItemPrefab.localScale = new UnityEngine.Vector3() {x = val_5, y = val_6, z = 0f};
        Weight val_7 = this.MoregameItemPrefab.GetComponent<Weight>();
        val_11 = val_11;
        if(this.MoregameItemPrefab <= val_13)
        {
                var val_11 = 0;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_11 = val_11 + 0;
        mem2[0] = (0 + 0) + 16;
        UnityEngine.Transform val_8 = val_11.GetComponent<UnityEngine.Transform>();
        val_13 = 1;
        val_11.sizeDelta = new UnityEngine.Vector2() {x = 135f, y = 150f};
        System.Collections.IEnumerator val_9 = this.MoregameItemPrefab.GetTextureIE();
        UnityEngine.Coroutine val_10 = this.MoregameItemPrefab.StartCoroutine(routine:  this.MoregameItemPrefab);
        val_12 = val_12 + 135;
        label_3:
        if(val_13 < this.MoregameItemPrefab)
        {
            goto label_17;
        }
    
    }
    public System.Collections.IEnumerator TryLoadFullMoreGame(MoregameInfor item)
    {
        MoregameManager.<TryLoadFullMoreGame>d__37 val_1 = 536900065;
        val_1 = new MoregameManager.<TryLoadFullMoreGame>d__37(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536900085] = this;
        }
        else
        {
                mem[20] = this;
        }
        
        mem[536900081] = item;
    }
    public void ShowMoregameFull(System.Action<bool> callBack, bool forceFirstTime = False)
    {
        if(this.FullMoregameShowed == false)
        {
                this.FullMoregameShowed = this.openFirstTime;
            goto label_2;
        }
        
        if(forceFirstTime != true)
        {
                return;
        }
        
        label_2:
        if(this.featureImage == 0)
        {
                callBack.Invoke(obj:  false);
            return;
        }
        
        DropdownItem val_2 = UnityEngine.Object.Instantiate<DropdownItem>(original:  this.MoregameFullPrefab);
        UnityEngine.Transform val_3 = this.MoregameFullPrefab.transform;
        UnityEngine.Transform val_4 = this.transform;
        this.MoregameFullPrefab.parent = 496844848;
        Weight val_5 = this.MoregameFullPrefab.GetComponent<Weight>();
        mem2[0] = this.featureItem;
        this.MoregameFullPrefab.ShowMoregame(sprite:  this.featureImage, action:  callBack, forceFirstTime:  forceFirstTime, isPortrait:  this.MoregameFullPrefab + 12 + 32);
        this.FullMoregameShowed = true;
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        536874379.Add(key:  -1610607951, value:  this.MoregameFullPrefab);
        -1073700879.TrackEvent(eventName:  -1610606237, parameters:  536874379);
    }
    public void OnClick(MoreGameFullManager item)
    {
        string val_7 = item.Infor.GameLink;
        bool val_1 = API.IsAndroid();
        if(val_1 != false)
        {
                string val_2 = val_1.GetPackage(link:  val_7 = item.Infor.GameLink);
            string val_3 = -1610600083(-1610600083) + val_1;
            val_7 = -1610600083;
        }
        
        if((System.String.op_Inequality(a:  item.Infor.AdjustLink, b:  -1610612735)) != false)
        {
                val_7 = item.Infor.AdjustLink;
        }
        
        UnityEngine.Application.OpenURL(url:  val_7);
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        536874379.Add(key:  -1610607951, value:  item.Infor.GameName);
        -1073700879.TrackEvent(eventName:  -1610606239, parameters:  536874379);
    }
    public MoregameManager()
    {
        System.Collections.Generic.List<Page> val_1 = 536878095;
        val_1 = new System.Collections.Generic.List<Page>();
        this._moregameCanUse = val_1;
        System.Collections.Generic.List<Page> val_2 = 536878095;
        val_2 = new System.Collections.Generic.List<Page>();
        this._moregameUsed = val_2;
        536874415 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        this.MoregameLoaded = 536874415;
        this.AndroidSheetId = -1610611219;
        this.AndroidGridId = -1610610845;
        this.IOSSheetId = -1610611309;
        this.IOSGridId = -1610611655;
    }

}
