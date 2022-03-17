using UnityEngine;

namespace com.adjust.sdk
{
    public class Adjust : MonoBehaviour
    {
        // Fields
        private const string errorMsgEditor = "[Adjust]: SDK can not be used in Editor.";
        private const string errorMsgStart = "[Adjust]: SDK not started. Start it manually using the \'start\' method.";
        private const string errorMsgPlatform = "[Adjust]: SDK can only be used in Android, iOS, Windows Phone 8.1, Windows Store or Universal Windows apps.";
        public bool startManually;
        public bool eventBuffering;
        public bool sendInBackground;
        public bool launchDeferredDeeplink;
        public string appToken;
        public com.adjust.sdk.AdjustLogLevel logLevel;
        public com.adjust.sdk.AdjustEnvironment environment;
        
        // Methods
        private void Awake()
        {
            var val_6;
            bool val_7;
            UnityEngine.Transform val_1 = this.transform;
            UnityEngine.GameObject val_2 = this.gameObject;
            UnityEngine.Object.DontDestroyOnLoad(target:  1458761744);
            if(this.startManually != false)
            {
                    return;
            }
            
            536883061 = new com.adjust.sdk.AdjustConfig(appToken:  this.appToken, environment:  this.environment, allowSuppressLogLevel:  (this.logLevel - 7) >> 5);
            536883061.setLogLevel(logLevel:  this.logLevel);
            if(this.sendInBackground == true)
            {
                    this.sendInBackground = 1;
            }
            
            536883061.setSendInBackground(sendInBackground:  true);
            if(536883061 != 0)
            {
                    if(this.eventBuffering == true)
            {
                    val_6 = 1;
            }
            
                536883061.setEventBufferingEnabled(eventBufferingEnabled:  true);
                val_7 = this.launchDeferredDeeplink;
            }
            else
            {
                    if(this.eventBuffering == true)
            {
                    val_6 = 1;
            }
            
                536883061.setEventBufferingEnabled(eventBufferingEnabled:  true);
                val_7 = this.launchDeferredDeeplink;
            }
            
            mem[536883199] = val_7;
            com.adjust.sdk.Adjust.start(adjustConfig:  536883061);
        }
        private void OnApplicationPause(bool pauseStatus)
        {
            var val_1 = mem[536883241];
            val_1 = val_1 & 512;
            if(pauseStatus != false)
            {
                    com.adjust.sdk.AdjustAndroid.OnPause();
                return;
            }
            
            com.adjust.sdk.AdjustAndroid.OnResume();
        }
        public static void start(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            if(adjustConfig != 0)
            {
                    com.adjust.sdk.AdjustAndroid.Start(adjustConfig:  adjustConfig);
                return;
            }
            
            UnityEngine.Debug.Log(message:  -1610602371);
        }
        public static void trackEvent(com.adjust.sdk.AdjustEvent adjustEvent)
        {
            if(adjustEvent != 0)
            {
                    com.adjust.sdk.AdjustAndroid.TrackEvent(adjustEvent:  adjustEvent);
                return;
            }
            
            UnityEngine.Debug.Log(message:  -1610602369);
        }
        public static void setEnabled(bool enabled)
        {
            com.adjust.sdk.AdjustAndroid.SetEnabled(enabled:  enabled);
        }
        public static bool isEnabled()
        {
            if((mem[536883242] & true) != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.IsEnabled();
            }
            
            if(mem[536883171] != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.IsEnabled();
            }
            
            return com.adjust.sdk.AdjustAndroid.IsEnabled();
        }
        public static void setOfflineMode(bool enabled)
        {
            com.adjust.sdk.AdjustAndroid.SetOfflineMode(enabled:  enabled);
        }
        public static void setDeviceToken(string deviceToken)
        {
            com.adjust.sdk.AdjustAndroid.SetDeviceToken(deviceToken:  deviceToken);
        }
        public static void gdprForgetMe()
        {
            com.adjust.sdk.AdjustAndroid.GdprForgetMe();
        }
        public static void disableThirdPartySharing()
        {
            com.adjust.sdk.AdjustAndroid.DisableThirdPartySharing();
        }
        public static void appWillOpenUrl(string url)
        {
            com.adjust.sdk.AdjustAndroid.AppWillOpenUrl(url:  url);
        }
        public static void sendFirstPackages()
        {
            com.adjust.sdk.AdjustAndroid.SendFirstPackages();
        }
        public static void addSessionPartnerParameter(string key, string value)
        {
            com.adjust.sdk.AdjustAndroid.AddSessionPartnerParameter(key:  key, value:  value);
        }
        public static void addSessionCallbackParameter(string key, string value)
        {
            com.adjust.sdk.AdjustAndroid.AddSessionCallbackParameter(key:  key, value:  value);
        }
        public static void removeSessionPartnerParameter(string key)
        {
            com.adjust.sdk.AdjustAndroid.RemoveSessionPartnerParameter(key:  key);
        }
        public static void removeSessionCallbackParameter(string key)
        {
            com.adjust.sdk.AdjustAndroid.RemoveSessionCallbackParameter(key:  key);
        }
        public static void resetSessionPartnerParameters()
        {
            com.adjust.sdk.AdjustAndroid.ResetSessionPartnerParameters();
        }
        public static void resetSessionCallbackParameters()
        {
            com.adjust.sdk.AdjustAndroid.ResetSessionCallbackParameters();
        }
        public static void trackAdRevenue(string source, string payload)
        {
            com.adjust.sdk.AdjustAndroid.TrackAdRevenue(source:  source, payload:  payload);
        }
        public static void trackAdRevenue(com.adjust.sdk.AdjustAdRevenue adRevenue)
        {
            com.adjust.sdk.AdjustAndroid.TrackAdRevenue(adRevenue:  adRevenue);
        }
        public static void trackAppStoreSubscription(com.adjust.sdk.AdjustAppStoreSubscription subscription)
        {
            UnityEngine.Debug.Log(message:  -1610602379);
        }
        public static void trackPlayStoreSubscription(com.adjust.sdk.AdjustPlayStoreSubscription subscription)
        {
            com.adjust.sdk.AdjustAndroid.TrackPlayStoreSubscription(subscription:  subscription);
        }
        public static void trackThirdPartySharing(com.adjust.sdk.AdjustThirdPartySharing thirdPartySharing)
        {
            com.adjust.sdk.AdjustAndroid.TrackThirdPartySharing(thirdPartySharing:  thirdPartySharing);
        }
        public static void trackMeasurementConsent(bool measurementConsent)
        {
            com.adjust.sdk.AdjustAndroid.TrackMeasurementConsent(measurementConsent:  measurementConsent);
        }
        public static void requestTrackingAuthorizationWithCompletionHandler(System.Action<int> statusCallback, string sceneName = "Adjust")
        {
            UnityEngine.Debug.Log(message:  -1610602367);
        }
        public static void updateConversionValue(int conversionValue)
        {
            UnityEngine.Debug.Log(message:  -1610602365);
        }
        public static int getAppTrackingAuthorizationStatus()
        {
            UnityEngine.Debug.Log(message:  -1610602377);
            return 0;
        }
        public static string getAdid()
        {
            if((mem[536883242] & true) != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.GetAdid();
            }
            
            if(mem[536883171] != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.GetAdid();
            }
            
            return com.adjust.sdk.AdjustAndroid.GetAdid();
        }
        public static com.adjust.sdk.AdjustAttribution getAttribution()
        {
            if((mem[536883242] & true) != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.GetAttribution();
            }
            
            if(mem[536883171] != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.GetAttribution();
            }
            
            return com.adjust.sdk.AdjustAndroid.GetAttribution();
        }
        public static string getWinAdid()
        {
            UnityEngine.Debug.Log(message:  -1610602373);
        }
        public static string getIdfa()
        {
            UnityEngine.Debug.Log(message:  -1610602375);
        }
        public static string getSdkVersion()
        {
            if((mem[536883242] & true) != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.GetSdkVersion();
            }
            
            if(mem[536883171] != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.GetSdkVersion();
            }
            
            return com.adjust.sdk.AdjustAndroid.GetSdkVersion();
        }
        public static void setReferrer(string referrer)
        {
            com.adjust.sdk.AdjustAndroid.SetReferrer(referrer:  referrer);
        }
        public static void getGoogleAdId(System.Action<string> onDeviceIdsRead)
        {
            com.adjust.sdk.AdjustAndroid.GetGoogleAdId(onDeviceIdsRead:  onDeviceIdsRead);
        }
        public static string getAmazonAdId()
        {
            if((mem[536883242] & true) != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.GetAmazonAdId();
            }
            
            if(mem[536883171] != 0)
            {
                    return com.adjust.sdk.AdjustAndroid.GetAmazonAdId();
            }
            
            return com.adjust.sdk.AdjustAndroid.GetAmazonAdId();
        }
        private static bool IsEditor()
        {
            return false;
        }
        public static void SetTestOptions(System.Collections.Generic.Dictionary<string, string> testOptions)
        {
            com.adjust.sdk.AdjustAndroid.SetTestOptions(testOptions:  testOptions);
        }
        public Adjust()
        {
            this.launchDeferredDeeplink = true;
            this.startManually = true;
            this.appToken = -1610596955;
            this.logLevel = 3;
        }
    
    }

}
