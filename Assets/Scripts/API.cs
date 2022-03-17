using UnityEngine;
public class API : SingletonMonoBehaviour<API>
{
    // Fields
    private string apiKey;
    private UnityEngine.GameObject loadingObj;
    private bool DisableAdsFake;
    public static bool IsBannerShowing;
    public ApiInfor ApiInforAndroid;
    public ApiInfor ApiInforIOS;
    public ApiInfor ApiInfor;
    private System.Action<bool> _onRewardSuccess;
    private MaxManager maxManager;
    private bool finishSetData;
    private static int sVersionNumber;
    
    // Properties
    public static bool IsRemoveAds { get; set; }
    public static string StartDay { get; set; }
    public static int PlayedDay { get; set; }
    public static int StartVersion { get; set; }
    
    // Methods
    public static bool get_IsRemoveAds()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  -1610606923, defaultValue:  0);
        val_1 = val_1 - 1;
        val_1 = val_1 >> 5;
        return (bool)val_1;
    }
    public static void set_IsRemoveAds(bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1610606923, value:  value);
    }
    private void Start()
    {
        var val_5;
        this.ApiInfor = this.ApiInforAndroid;
        UnityEngine.Application.targetFrameRate = 60;
        this.loadingObj.SetActive(value:  false);
        System.Collections.IEnumerator val_1 = this.CheckFinishData();
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  499405744);
        536873173 = new System.Action<SdkConfiguration>(object:  499405744, method:  new IntPtr(1610676745));
        System.Delegate val_4 = System.Delegate.Combine(a:  mem[536887065] + 4, b:  536873173);
        val_5 = mem[536887065] + 4;
        if(val_5 != 0)
        {
                if(val_5 == 536873173)
        {
            goto label_5;
        }
        
        }
        
        val_5 = 0;
        label_5:
        mem2[0] = val_5;
        this.InitAds();
    }
    private void InitDefaultAPI(System.Collections.Generic.Dictionary<string, object> defaults)
    {
        string val_1 = UnityEngine.JsonUtility.ToJson(obj:  this.ApiInforAndroid);
        defaults.Add(key:  this.apiKey, value:  this.ApiInforAndroid);
    }
    private void InitAds()
    {
        this.maxManager.Init(apiInfor:  this.ApiInfor);
        this.finishSetData = true;
    }
    private System.Collections.IEnumerator CheckFinishData()
    {
        536897799 = new API.<CheckFinishData>d__16(<>1__state:  0);
        mem[536897815] = this;
    }
    public void ShowBanner(MaxManager.BannerPosition position = 1, AnalyticID.BannerPlaceID bannerPlaceID = 0)
    {
        bool val_1 = API.IsEditor();
        if(val_1 == true)
        {
                val_1 = this.DisableAdsFake;
            goto label_3;
        }
        
        label_16:
        if(this.ApiInfor.IsUseBanner == false)
        {
                return;
        }
        
        if(API.IsRemoveAds == true)
        {
                return;
        }
        
        UnityEngine.NetworkReachability val_3 = UnityEngine.Application.internetReachability;
        if(0 == 0)
        {
                return;
        }
        
        this = this.maxManager;
        this.ShowAdsBanner(position:  position, bannerPlaceID:  bannerPlaceID);
        return;
        label_3:
        if((this.ApiInfor.IsUseBanner == false) || (API.IsRemoveAds == true))
        {
            goto label_16;
        }
        
        UnityEngine.NetworkReachability val_5 = UnityEngine.Application.internetReachability;
        if(0 == 0)
        {
            goto label_16;
        }
        
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        string val_6 = -1610604597(-1610604597) + 536899889;
        UnityEngine.Debug.Log(message:  -1610604597);
    }
    public void HideBanner()
    {
        if(((mem[536883130] & true) == 0) && (mem[536883059] == 0))
        {
                536882943 = 536882943;
        }
        
        mem2[0] = 0;
        this.maxManager.HideAdsBanner();
    }
    public void ShowFull(System.Action<bool> onClosed, AnalyticID.InterPlaceID interPlaceID)
    {
        if((API.IsRemoveAds != true) && (this.ApiInfor.IsUseInterstitial != false))
        {
                UnityEngine.NetworkReachability val_2 = UnityEngine.Application.internetReachability;
            if(0 != 0)
        {
                bool val_3 = API.IsEditor();
            if(val_3 == true)
        {
                val_3 = this.DisableAdsFake;
            goto label_9;
        }
        
            this.maxManager.ShowAdsInterstitial(callback:  onClosed, interPlaceID:  interPlaceID);
            return;
        }
        
        }
        
        if(onClosed == 0)
        {
                return;
        }
        
        onClosed.Invoke(obj:  false);
        return;
        label_9:
        if(onClosed != 0)
        {
                onClosed.Invoke(obj:  false);
        }
        
        UnityEngine.Debug.Log(message:  -1610604595);
    }
    public void ShowLoading(System.Action onClosed)
    {
        System.Collections.IEnumerator val_1 = this.OnShowLoading(onClosedLoading:  onClosed);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  500324912);
    }
    private System.Collections.IEnumerator OnShowLoading(System.Action onClosedLoading)
    {
        API.<OnShowLoading>d__21 val_1 = 536897801;
        val_1 = new API.<OnShowLoading>d__21(<>1__state:  0);
        if(val_1 != 0)
        {
                mem[536897817] = this;
        }
        else
        {
                mem[16] = this;
        }
        
        mem[536897821] = onClosedLoading;
    }
    public bool IsRewardLoaded()
    {
        UnityEngine.NetworkReachability val_1 = UnityEngine.Application.internetReachability;
        if(0 == 0)
        {
                return (bool)0;
        }
        
        0 = 1;
        if(API.IsEditor() != false)
        {
                return (bool)0;
        }
        
        if(this.maxManager != 0)
        {
                return this.maxManager.IsRewardAdAvailable();
        }
        
        return this.maxManager.IsRewardAdAvailable();
    }
    public void ShowReward(System.Action<bool> callBack, AnalyticID.RewardPlaceID rewardPlaceID)
    {
        this._onRewardSuccess = callBack;
        bool val_1 = API.IsEditor();
        if(val_1 == true)
        {
                val_1 = this.DisableAdsFake;
            goto label_3;
        }
        
        if(this.IsRewardLoaded() != false)
        {
                536873261 = new System.Action<System.Boolean>(object:  500693680, method:  new IntPtr(1610676765));
            this.maxManager.ShowAdsReward(callback:  536873261, rewardPlaceID:  rewardPlaceID);
            return;
        }
        
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700885.Show(mess:  -1610602637, callBack:  0);
        this._onRewardSuccess.Invoke(obj:  false);
        return;
        label_3:
        this.CallbackRewardVideo(Success:  true);
    }
    private void CallbackRewardVideo(bool Success)
    {
        var val_5;
        this.loadingObj.SetActive(value:  false);
        if(Success == false)
        {
            goto label_2;
        }
        
        object val_1 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883) == 0)
        {
            goto label_3;
        }
        
        val_5 = -1073708883.Diamond;
        goto label_4;
        label_2:
        this._onRewardSuccess.Invoke(obj:  false);
        return;
        label_3:
        val_5 = -1073708883.Diamond;
        label_4:
        -1073708883.Diamond = val_5 + 1;
        this._onRewardSuccess.Invoke(obj:  true);
        GameTool.EventDispatcherExtension.PostEvent(sender:  500830256, eventID:  8);
    }
    private void SetDay()
    {
    
    }
    private static int GetVersionNumber()
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = 536882943;
        if(((mem[536883130] & true) == 0) && (mem[536883059] == 0))
        {
                val_4 = 536882943;
        }
        
        if((mem[536883035] + 4) <= 1)
        {
                string val_1 = UnityEngine.Application.version;
            mem[536881809] = 46;
            val_5 = 0;
            System.String[] val_2 = 0.Split(separator:  536881793);
            val_6 = 536882943;
            if(((mem[536883130] & true) == 0) && (mem[536883059] == 0))
        {
                val_6 = 536882943;
        }
        
            mem2[0] = val_5;
            val_7 = 536882943;
            if((0 - 1) >= 0)
        {
                var val_4 = 0 + 3;
            do
        {
            var val_5 = val_4 - 4;
            if(((mem[536883130] & true) == 0) && (mem[536883059] == 0))
        {
                val_8 = 536882943;
        }
        
            val_4 = 536882943;
            mem2[0] = System.Int32.Parse(s:  0 + ((0 + 3)) << 2);
            var val_8 = val_4 - 1;
            val_5 = (1 + 4) << 1;
        }
        while((val_4 - 5) > 1);
        
        }
        
        }
        
        if((mem[536883130] & true) != 0)
        {
                return (int)mem[536883035] + 4;
        }
        
        if(mem[536883059] != 0)
        {
                return (int)mem[536883035] + 4;
        }
        
        val_4 = 536882943;
        return (int)mem[536883035] + 4;
    }
    public static string get_StartDay()
    {
        return UnityEngine.PlayerPrefs.GetString(key:  -1610604385, defaultValue:  -1610611655);
    }
    public static void set_StartDay(string value)
    {
        UnityEngine.PlayerPrefs.SetString(key:  -1610604385, value:  value);
    }
    public static int get_PlayedDay()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1610605339, defaultValue:  0);
    }
    public static void set_PlayedDay(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1610605339, value:  value);
    }
    public static int get_StartVersion()
    {
        return UnityEngine.PlayerPrefs.GetInt(key:  -1610604381, defaultValue:  0);
    }
    public static void set_StartVersion(int value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  -1610604381, value:  value);
    }
    public bool HasTurnOffInternet()
    {
        UnityEngine.NetworkReachability val_1 = UnityEngine.Application.internetReachability;
        return false;
    }
    public void RequestReview()
    {
        var val_7;
        API.<>c__DisplayClass38_0 val_1 = 536897797;
        val_1 = new API.<>c__DisplayClass38_0();
        object val_2 = AFramework.ManualSingletonMono<System.Object>.I;
        if((-1073708883.Rated) != false)
        {
                return;
        }
        
        Google.Play.Review.ReviewManager val_4 = 536892919;
        val_4 = new Google.Play.Review.ReviewManager();
        if(val_1 != 0)
        {
                val_7 = val_1;
            mem[536897805] = val_4;
        }
        else
        {
                val_7 = 8;
            mem[8] = val_4;
        }
        
        Google.Play.Common.PlayAsyncOperation<Google.Play.Review.PlayReviewInfo, Google.Play.Review.ReviewErrorCode> val_5 = val_7.RequestReviewFlow();
        536873211 = new System.Action<SdkConfiguration>(object:  536897797, method:  new IntPtr(1610676829));
        if(val_7 == 0)
        {
            
        }
    
    }
    public string GetKey()
    {
    
    }
    public void ApiDebug(string content)
    {
        mem[536882227] = content;
        UnityEngine.Debug.LogFormat(format:  -1610604059, args:  536882211);
    }
    public static bool IsEditor()
    {
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 == 7)
        {
                0 = 1;
            return (bool)0;
        }
        
        UnityEngine.RuntimePlatform val_2 = UnityEngine.Application.platform;
        return false;
    }
    public static bool IsAndroid()
    {
        return true;
    }
    public static bool IsIOS()
    {
        return false;
    }
    public bool IsAppInstalled(string bundleID)
    {
        var val_10;
        var val_11;
        val_10 = 0;
        UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
        if(0 != 11)
        {
                return (bool)val_10;
        }
        
        536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601241);
        string val_3 = 536883199.GetStatic<System.String>(fieldName:  -1610600971);
        val_11 = mem[mem[3221271783] + 186];
        val_11 = mem[3221271783] + 186;
        if(val_11 == 1)
        {
                val_11 = mem[mem[3221271783] + 186];
            val_11 = mem[3221271783] + 186;
        }
        
        string val_4 = 536883199.Call<System.String>(methodName:  -1610600357, args:  mem[3221271783] + 92);
        string val_5 = -1610612503(-1610612503) + bundleID;
        UnityEngine.Debug.Log(message:  -1610612503);
        mem[536882227] = bundleID;
        string val_6 = 536883199.Call<System.String>(methodName:  -1610600377, args:  536882211);
        if(536883199 != 0)
        {
                string val_7 = -1610611921(-1610611921) + bundleID;
            UnityEngine.Debug.Log(message:  -1610611921);
            val_10 = 1;
            return (bool)val_10;
        }
        
        val_10 = 0;
        string val_9 = -1610611919(-1610611919) + -1610611921(-1610611921);
        UnityEngine.Debug.Log(message:  -1610611919);
        return (bool)val_10;
    }
    public API()
    {
        this.apiKey = -1610601771;
        this.DisableAdsFake = true;
    }
    private static API()
    {
        mem2[0] = 1;
        mem2[0] = 0;
    }

}
