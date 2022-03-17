using UnityEngine;
public class MaxManager : MonoBehaviour
{
    // Fields
    private string applovingSDKKey;
    private bool showMediationDebugger;
    private string bannerID;
    private string interstitialID;
    private string rewardVideoID;
    private ApiInfor mApiInfor;
    private System.Action<bool> mInterstitialAdCallback;
    private System.Action<bool> mRewardedAdCallback;
    private MaxManager.BannerPosition mBannerPosition;
    private string isAdaptiveBanner;
    private bool isShowingBanner;
    private AnalyticID.BannerPlaceID mBannerPlaceID;
    private float _lastTimeShowInterstitial;
    private bool startAds;
    private int retryAttempt;
    private AnalyticID.InterPlaceID mInterPlaceID;
    private bool mHaveRewarded;
    private AnalyticID.RewardPlaceID mRewardPlaceID;
    private bool showLog;
    
    // Methods
    public void Init(ApiInfor apiInfor)
    {
        ApiInfor val_23;
        MaxManager.<>c__DisplayClass9_0 val_1 = 536899887;
        val_1 = new MaxManager.<>c__DisplayClass9_0();
        if(val_1 != 0)
        {
                val_23 = val_1;
            mem[536899895] = apiInfor;
            mem[536899899] = this;
        }
        else
        {
                val_23 = 8;
            mem[8] = apiInfor;
            mem[12] = this;
        }
        
        this.mApiInfor = val_23;
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676877));
        MaxSdkCallbacks.Banner.add_OnAdLoadedEvent(value:  536873445);
        536873449 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676883));
        MaxSdkCallbacks.Banner.add_OnAdLoadFailedEvent(value:  536873449);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676879));
        MaxSdkCallbacks.Banner.add_OnAdClickedEvent(value:  536873445);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676881));
        MaxSdkCallbacks.Banner.add_OnAdCollapsedEvent(value:  536873445);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676903));
        MaxSdkCallbacks.Interstitial.add_OnAdLoadedEvent(value:  536873445);
        536873449 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676901));
        MaxSdkCallbacks.Interstitial.add_OnAdLoadFailedEvent(value:  536873449);
        536873489 = new System.Action<System.String, ErrorInfo, AdInfo>(object:  505113520, method:  new IntPtr(1610676899));
        MaxSdkCallbacks.Interstitial.add_OnAdDisplayFailedEvent(value:  536873489);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676893));
        MaxSdkCallbacks.Interstitial.add_OnAdHiddenEvent(value:  536873445);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676895));
        MaxSdkCallbacks.Interstitial.add_OnAdDisplayedEvent(value:  536873445);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676897));
        MaxSdkCallbacks.Interstitial.add_OnAdClickedEvent(value:  536873445);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(1610676905));
        MaxSdkCallbacks.Interstitial.add_OnAdRevenuePaidEvent(value:  536873445);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676925));
        MaxSdkCallbacks.Rewarded.add_OnAdLoadedEvent(value:  536873445);
        536873449 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676923));
        MaxSdkCallbacks.Rewarded.add_OnAdLoadFailedEvent(value:  536873449);
        536873489 = new System.Action<System.String, ErrorInfo, AdInfo>(object:  505113520, method:  new IntPtr(1610676921));
        MaxSdkCallbacks.Rewarded.add_OnAdDisplayFailedEvent(value:  536873489);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676919));
        MaxSdkCallbacks.Rewarded.add_OnAdDisplayedEvent(value:  536873445);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676917));
        MaxSdkCallbacks.Rewarded.add_OnAdClickedEvent(value:  536873445);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  505113520, method:  new IntPtr(1610676915));
        MaxSdkCallbacks.Rewarded.add_OnAdHiddenEvent(value:  536873445);
        536873493 = new System.Action<System.String, Reward, AdInfo>(object:  505113520, method:  new IntPtr(1610676913));
        MaxSdkCallbacks.Rewarded.add_OnAdReceivedRewardEvent(value:  536873493);
        536873445 = new System.Action<System.Threading.Tasks.Task, System.Object>(object:  0, method:  new IntPtr(1610676927));
        MaxSdkCallbacks.Rewarded.add_OnAdRevenuePaidEvent(value:  536873445);
        536873375 = new System.Action<SdkConfiguration>(object:  536899887, method:  new IntPtr(1610676939));
        MaxSdkCallbacks.add_OnSdkInitializedEvent(value:  536873375);
        if((System.String.op_Inequality(a:  this.applovingSDKKey, b:  -1610612735)) != false)
        {
                MaxSdkAndroid.SetSdkKey(sdkKey:  this.applovingSDKKey);
            MaxSdkAndroid.InitializeSdk(adUnitIds:  null);
        }
        else
        {
                this.MaxLog(logContent:  -1610610167, maxLogType:  2);
        }
        
        if(this.showMediationDebugger == false)
        {
                return;
        }
        
        MaxSdkAndroid.ShowMediationDebugger();
    }
    private void LoadAds()
    {
        if(this.mApiInfor.IsUseBanner != false)
        {
                if((System.String.op_Inequality(a:  this.bannerID, b:  -1610612735)) != false)
        {
                MaxSdkAndroid.SetBannerExtraParameter(adUnitIdentifier:  this.bannerID, key:  -1610601851, value:  this.isAdaptiveBanner);
            if(this.mBannerPosition <= 5)
        {
                7 = 2425060;
            7 = 20387840;
            7 = mem[7 + (this.mBannerPosition) << 2];
        }
        
            MaxSdkAndroid.CreateBanner(adUnitIdentifier:  this.bannerID, bannerPosition:  7 = 7 + (this.mBannerPosition) << 2);
        }
        else
        {
                this.MaxLog(logContent:  -1610601643, maxLogType:  2);
        }
        
        }
        
        if(this.mApiInfor.IsUseInterstitial != false)
        {
                if((System.String.op_Inequality(a:  this.interstitialID, b:  -1610612735)) != false)
        {
                this.LoadInterstitial();
        }
        else
        {
                this.MaxLog(logContent:  -1610599897, maxLogType:  2);
        }
        
        }
        
        if(this.mApiInfor.IsUseReward == false)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  this.rewardVideoID, b:  -1610612735)) != false)
        {
                this.LoadRewardVideoAds();
            return;
        }
        
        this.MaxLog(logContent:  -1610598619, maxLogType:  2);
    }
    private MaxSdkBase.BannerPosition AdapterBannerPosition(MaxManager.BannerPosition position)
    {
        if(position > 5)
        {
                this = 7;
            return;
        }
    
    }
    public void SetBannerPosition(MaxManager.BannerPosition position)
    {
        this.mBannerPosition = position;
        if(position <= 5)
        {
                true = 2424408;
            true = 20387840;
            7 = mem[true + (position) << 2];
            7 = true + (position) << 2;
        }
        
        MaxSdkAndroid.UpdateBannerPosition(adUnitIdentifier:  this.bannerID, bannerPosition:  7);
    }
    public void ShowAdsBanner(MaxManager.BannerPosition position, AnalyticID.BannerPlaceID bannerPlaceID)
    {
        this.mBannerPlaceID = bannerPlaceID;
        this.SetBannerPosition(position:  position);
        MaxSdkAndroid.SetBannerExtraParameter(adUnitIdentifier:  this.bannerID, key:  -1610601851, value:  this.isAdaptiveBanner);
        MaxSdkAndroid.ShowBanner(adUnitIdentifier:  this.bannerID);
        string val_1 = -1610604591(-1610604591) + this.bannerID;
        this.MaxLog(logContent:  -1610604591, maxLogType:  0);
        GameTool.EventDispatcherExtension.PostEvent(sender:  505704880, eventID:  12, param:  536884213);
    }
    public void HideAdsBanner()
    {
        GameTool.EventDispatcherExtension.PostEvent(sender:  505849648, eventID:  12, param:  536884213);
        MaxSdkAndroid.HideBanner(adUnitIdentifier:  this.bannerID);
        if(this.isShowingBanner == true)
        {
                this.isShowingBanner = false;
        }
        
        string val_1 = -1610607737(-1610607737) + this.bannerID;
        this.MaxLog(logContent:  -1610607737, maxLogType:  0);
    }
    public bool IsShowingBanner()
    {
        return (bool)this.isShowingBanner;
    }
    private void HandleOnBannerAdLoadedEvent(string adId, MaxSdkBase.AdInfo apiInfor)
    {
        this.isShowingBanner = true;
        string val_1 = -1610607801(-1610607801) + this.bannerID;
        this.MaxLog(logContent:  -1610607801, maxLogType:  0);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897833];
        536874379.Add(key:  -1610610321, value:  536897833);
        -1073700879.TrackEvent(eventName:  -1610609973, parameters:  536874379);
    }
    private void HandleOnBannerAdClickedEvent(string adId, MaxSdkBase.AdInfo apiInfor)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897833];
        536874379.Add(key:  -1610610335, value:  536897833);
        -1073700879.TrackEvent(eventName:  -1610609973, parameters:  536874379);
        string val_3 = -1610607805(-1610607805) + this.bannerID;
        this.MaxLog(logContent:  -1610607805, maxLogType:  0);
    }
    private void HandleOnBannerCollapsedEvent(string adId, MaxSdkBase.AdInfo apiInfor)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897833];
        536874379.Add(key:  -1610610333, value:  536897833);
        -1073700879.TrackEvent(eventName:  -1610609973, parameters:  536874379);
        this.isShowingBanner = false;
        string val_3 = -1610607805(-1610607805) + this.bannerID;
        this.MaxLog(logContent:  -1610607805, maxLogType:  0);
    }
    private void HandleOnBannerAdLoadFailedEvent(string adId, MaxSdkBase.ErrorInfo errorInfo)
    {
        MaxSdkAndroid.SetBannerExtraParameter(adUnitIdentifier:  this.bannerID, key:  -1610601851, value:  this.isAdaptiveBanner);
        if(this.mBannerPosition <= 5)
        {
                7 = 2421988;
            7 = 20387840;
            7 = mem[7 + (this.mBannerPosition) << 2];
        }
        
        MaxSdkAndroid.CreateBanner(adUnitIdentifier:  this.bannerID, bannerPosition:  7 = 7 + (this.mBannerPosition) << 2);
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897833];
        536874379.Add(key:  -1610610323, value:  536897833);
        -1073700879.TrackEvent(eventName:  -1610609973, parameters:  536874379);
        string val_3 = -1610607803(-1610607803) + this.bannerID;
        this.MaxLog(logContent:  -1610607803, maxLogType:  0);
    }
    private void LoadInterstitial()
    {
        MaxSdkAndroid.LoadInterstitial(adUnitIdentifier:  this.interstitialID);
    }
    public bool CanShowFull()
    {
        bool val_4;
        if(this.startAds != false)
        {
                float val_1 = UnityEngine.Time.time;
            WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            float val_3 = 0 - this._lastTimeShowInterstitial;
            if(mem[3221266201] >= 0)
        {
                val_4 = 1;
        }
        
            return val_4;
        }
        
        val_4 = true;
        this.startAds = val_4;
        return val_4;
    }
    private bool IsInterstitialAdAvailable()
    {
        if((System.String.op_Inequality(a:  this.interstitialID, b:  -1610612735)) == false)
        {
                return false;
        }
        
        if((MaxSdkAndroid.IsInterstitialReady(adUnitIdentifier:  this.interstitialID)) == false)
        {
                return false;
        }
        
        return this.CanShowFull();
    }
    public void ShowAdsInterstitial(System.Action<bool> callback, AnalyticID.InterPlaceID interPlaceID)
    {
        this.mInterstitialAdCallback = callback;
        if(this.IsInterstitialAdAvailable() != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536882991 = new System.Action(object:  507033776, method:  new IntPtr(1610676933));
            -1073701127.ShowLoading(onClosed:  536882991);
            return;
        }
        
        this.mInterPlaceID = interPlaceID;
        this.mInterstitialAdCallback.Invoke(obj:  false);
        this.LoadInterstitial();
    }
    private void HandleOnInterstitialHiddenEvent(string adId, MaxSdkBase.AdInfo adInfo)
    {
        UnityEngine.AudioListener.volume = null;
        if(this.mInterstitialAdCallback != 0)
        {
                this.mInterstitialAdCallback.Invoke(obj:  true);
        }
        
        this.LoadInterstitial();
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897847];
        536874379.Add(key:  -1610610325, value:  536897847);
        -1073700879.TrackEvent(eventName:  -1610607331, parameters:  536874379);
    }
    private void HandleOnInterstitialDisplayedEvent(string adId, MaxSdkBase.AdInfo adInfo)
    {
        this._lastTimeShowInterstitial = 0f;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610607359);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610610281);
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897847];
        536874379.Add(key:  -1610610329, value:  536897847);
        -1073700879.TrackEvent(eventName:  -1610607331, parameters:  536874379);
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_7 = AnalyticID.AdjustEventToken.inter_impression;
        -1073700879.TrackAjustEvent(eventName:  null);
        UnityEngine.AudioListener.volume = UnityEngine.Time.time;
        string val_8 = -1610607795(-1610607795) + this.interstitialID;
        this.MaxLog(logContent:  -1610607795, maxLogType:  0);
    }
    private void HandleOnInterstitialClickedEvent(string adId, MaxSdkBase.AdInfo adInfo)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610607363);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610610283);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897847];
        536874379.Add(key:  -1610610335, value:  536897847);
        -1073700879.TrackEvent(eventName:  -1610607331, parameters:  536874379);
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_6 = AnalyticID.AdjustEventToken.inter_click;
        -1073700879.TrackAjustEvent(eventName:  null);
        string val_7 = -1610607797(-1610607797) + this.interstitialID;
        this.MaxLog(logContent:  -1610607797, maxLogType:  0);
    }
    private void HandleOnInterstitialAdFailedToDisplayEvent(string adId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610607361);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897847];
        536874379.Add(key:  -1610610327, value:  536897847);
        -1073700879.TrackEvent(eventName:  -1610607331, parameters:  536874379);
        this.LoadInterstitial();
        UnityEngine.AudioListener.volume = null;
        if(this.mInterstitialAdCallback != 0)
        {
                this.mInterstitialAdCallback.Invoke(obj:  false);
            this.mInterstitialAdCallback = 0;
        }
        
        string val_4 = -1610607799(-1610607799) + this.interstitialID;
        this.MaxLog(logContent:  -1610607799, maxLogType:  0);
    }
    private void HandleOnInterstitialLoadFailedEvent(string adId, MaxSdkBase.ErrorInfo errorInfo)
    {
        int val_1 = this.retryAttempt + 1;
        this.retryAttempt = val_1;
        double val_3 = System.Math.Pow(x:  null, y:  null);
        this.Invoke(methodName:  -1610606597, time:  System.Math.Min(val1:  6, val2:  val_1));
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897847];
        536874379.Add(key:  -1610610323, value:  536897847);
        -1073700879.TrackEvent(eventName:  -1610607331, parameters:  536874379);
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610607357);
        string val_7 = -1610607793(-1610607793) + this.interstitialID;
        this.MaxLog(logContent:  -1610607793, maxLogType:  0);
    }
    private void HandleOnInterstitialLoadedEvent(string adId, MaxSdkBase.AdInfo adInfo)
    {
        this.retryAttempt = 0;
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897847];
        536874379.Add(key:  -1610610321, value:  536897847);
        -1073700879.TrackEvent(eventName:  -1610607331, parameters:  536874379);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610607355);
        string val_4 = -1610607791(-1610607791) + this.interstitialID;
        this.MaxLog(logContent:  -1610607791, maxLogType:  0);
    }
    public static void OnInterstitialAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        536883051 = new com.adjust.sdk.AdjustAdRevenue(source:  -1610601749);
        536883051.setRevenue(amount:  null, currency:  null);
        mem[536883095] = adInfo.<NetworkName>k__BackingField;
        mem[536883099] = adInfo.<AdUnitIdentifier>k__BackingField;
        mem[536883103] = adInfo.<Placement>k__BackingField;
        com.adjust.sdk.Adjust.trackAdRevenue(adRevenue:  536883051);
    }
    public bool IsRewardAdAvailable()
    {
        if((System.String.op_Inequality(a:  this.rewardVideoID, b:  -1610612735)) == false)
        {
                return false;
        }
        
        if((mem[536890514] & true) != 0)
        {
                return MaxSdkAndroid.IsRewardedAdReady(adUnitIdentifier:  this.rewardVideoID);
        }
        
        if(mem[536890443] != 0)
        {
                return MaxSdkAndroid.IsRewardedAdReady(adUnitIdentifier:  this.rewardVideoID);
        }
        
        return MaxSdkAndroid.IsRewardedAdReady(adUnitIdentifier:  this.rewardVideoID);
    }
    public void ShowAdsReward(System.Action<bool> callback, AnalyticID.RewardPlaceID rewardPlaceID)
    {
        this.mHaveRewarded = false;
        this.mRewardedAdCallback = callback;
        this.mRewardPlaceID = rewardPlaceID;
        if(this.IsRewardAdAvailable() != false)
        {
                WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
            536882991 = new System.Action(object:  508287536, method:  new IntPtr(1610676935));
            -1073701127.ShowLoading(onClosed:  536882991);
            return;
        }
        
        this.LoadRewardVideoAds();
        this.mRewardedAdCallback.Invoke(obj:  false);
    }
    private void LoadRewardVideoAds()
    {
        MaxSdkAndroid.LoadRewardedAd(adUnitIdentifier:  this.rewardVideoID);
    }
    private void HandleOnRewardedAdReceivedRewardEvent(string adId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_2 = AnalyticID.AdjustEventToken.reward_completed;
        -1073700879.TrackAjustEvent(eventName:  null);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897853];
        536874379.Add(key:  -1610610331, value:  536897853);
        -1073700879.TrackEvent(eventName:  -1610604877, parameters:  536874379);
        this.mHaveRewarded = true;
        string val_5 = -1610607777(-1610607777) + this.rewardVideoID;
        this.MaxLog(logContent:  -1610607777, maxLogType:  0);
    }
    private void HandleOnRewardedAdHiddenEvent(string adId, MaxSdkBase.AdInfo adInfo)
    {
        this.LoadRewardVideoAds();
        string val_1 = -1610607783(-1610607783) + this.rewardVideoID;
        this.MaxLog(logContent:  -1610607783, maxLogType:  0);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897853];
        536874379.Add(key:  -1610610325, value:  536897853);
        -1073700879.TrackEvent(eventName:  -1610604877, parameters:  536874379);
        UnityEngine.AudioListener.volume = null;
        if(this.mRewardedAdCallback == 0)
        {
                return;
        }
        
        this.mRewardedAdCallback.Invoke(obj:  this.mHaveRewarded);
    }
    private void HandleOnRewardedAdClickedEvent(string adId, MaxSdkBase.AdInfo adInfo)
    {
        string val_1 = -1610607789(-1610607789) + this.rewardVideoID;
        this.MaxLog(logContent:  -1610607789, maxLogType:  0);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_3 = AnalyticID.AdjustEventToken.reward_click;
        -1073700879.TrackAjustEvent(eventName:  null);
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897853];
        536874379.Add(key:  -1610610335, value:  536897853);
        -1073700879.TrackEvent(eventName:  -1610604877, parameters:  536874379);
    }
    private void HandleOnRewardedAdDisplayedEvent(string adId, MaxSdkBase.AdInfo adInfo)
    {
        string val_1 = -1610607787(-1610607787) + this.rewardVideoID;
        this.MaxLog(logContent:  -1610607787, maxLogType:  0);
        UnityEngine.AudioListener.volume = null;
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        string val_3 = AnalyticID.AdjustEventToken.reward_impression;
        -1073700879.TrackAjustEvent(eventName:  null);
        WorldTimeAPI val_4 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610604871);
        WorldTimeAPI val_5 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610610281);
        WorldTimeAPI val_6 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897853];
        536874379.Add(key:  -1610610329, value:  536897853);
        -1073700879.TrackEvent(eventName:  -1610604877, parameters:  536874379);
        this.LoadRewardVideoAds();
    }
    private void HandleOnRewardedAdFailedToDisplayEvent(string adId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        var val_6;
        var val_7;
        System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation> val_8;
        RewardPlaceID val_9;
        val_6 = this;
        string val_1 = -1610607785(-1610607785) + this.rewardVideoID;
        this.MaxLog(logContent:  -1610607785, maxLogType:  0);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610604875);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_7 = -1073700879;
        val_8 = 536874379;
        val_8 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        val_9 = this.mRewardPlaceID;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897853];
        val_8.Add(key:  -1610610327, value:  536897853);
        val_7.TrackEvent(eventName:  -1610604877, parameters:  536874379);
        this.LoadRewardVideoAds();
        UnityEngine.AudioListener.volume = null;
        if(this.mRewardedAdCallback == 0)
        {
                return;
        }
        
        this.mRewardedAdCallback.Invoke(obj:  false);
        this.mRewardedAdCallback = 0;
    }
    private void HandleOnRewardedAdLoadFailedEvent(string adId, MaxSdkBase.ErrorInfo errorInfo)
    {
        var val_6;
        var val_7;
        System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation> val_8;
        RewardPlaceID val_9;
        val_6 = this;
        string val_1 = -1610607781(-1610607781) + this.rewardVideoID;
        this.MaxLog(logContent:  -1610607781, maxLogType:  0);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610604873);
        WorldTimeAPI val_3 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        val_7 = -1073700879;
        val_8 = 536874379;
        val_8 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        val_9 = this.mRewardPlaceID;
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897853];
        val_8.Add(key:  -1610610323, value:  536897853);
        val_7.TrackEvent(eventName:  -1610604877, parameters:  536874379);
        this.LoadRewardVideoAds();
        if(this.mRewardedAdCallback == 0)
        {
                return;
        }
        
        this.mRewardedAdCallback.Invoke(obj:  false);
        this.mRewardedAdCallback = 0;
    }
    private void HandleOnRewardedAdLoadedEvent(string adId, MaxSdkBase.AdInfo adInfo)
    {
        WorldTimeAPI val_1 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        -1073700879.TrackEvent(eventName:  -1610604869);
        WorldTimeAPI val_2 = SingletonMonoBehaviour<WorldTimeAPI>.Instance;
        536874379 = new System.Collections.Generic.Dictionary<System.Type, System.Runtime.Serialization.Formatters.Binary.TypeInformation>();
        Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
        mem2[0] = mem[536897853];
        536874379.Add(key:  -1610610321, value:  536897853);
        -1073700879.TrackEvent(eventName:  -1610604877, parameters:  536874379);
        string val_4 = -1610607779(-1610607779) + this.rewardVideoID;
        this.MaxLog(logContent:  -1610607779, maxLogType:  0);
    }
    public static void OnOnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        536883051 = new com.adjust.sdk.AdjustAdRevenue(source:  -1610601749);
        536883051.setRevenue(amount:  null, currency:  null);
        mem[536883095] = adInfo.<NetworkName>k__BackingField;
        mem[536883099] = adInfo.<AdUnitIdentifier>k__BackingField;
        mem[536883103] = adInfo.<Placement>k__BackingField;
        com.adjust.sdk.Adjust.trackAdRevenue(adRevenue:  536883051);
    }
    public void MaxLog(string logContent, MaxManager.MaxLogType maxLogType = 0)
    {
        if(maxLogType == 1)
        {
                UnityEngine.Debug.LogWarning(message:  logContent);
            return;
        }
        
        if(maxLogType != 0)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  logContent);
    }
    public MaxManager()
    {
        this.applovingSDKKey = -1610601509;
        this.bannerID = -1610610905;
        this.interstitialID = -1610601475;
        this.rewardVideoID = -1610611107;
        this.isAdaptiveBanner = -1610597659;
        this.showLog = true;
    }
    private void <ShowAdsInterstitial>b__31_0()
    {
        this.LoadInterstitial();
        MaxSdkAndroid.ShowInterstitial(adUnitIdentifier:  this.interstitialID);
    }
    private void <ShowAdsReward>b__42_0()
    {
        this.LoadRewardVideoAds();
        MaxSdkAndroid.ShowRewardedAd(adUnitIdentifier:  this.rewardVideoID);
    }

}
