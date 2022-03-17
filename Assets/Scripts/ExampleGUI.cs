using UnityEngine;
public class ExampleGUI : MonoBehaviour
{
    // Fields
    private int numberOfButtons;
    private bool isEnabled;
    private bool showPopUp;
    private string txtSetEnabled;
    private string txtManualLaunch;
    private string txtSetOfflineMode;
    
    // Methods
    private void OnGUI()
    {
        bool val_63;
        bool val_64;
        bool val_65;
        bool val_66;
        string val_67;
        bool val_68;
        string val_69;
        bool val_70;
        if(this.showPopUp != false)
        {
                int val_1 = UnityEngine.Screen.width;
            val_1 = val_1 + (val_1 >> 31);
            int val_3 = UnityEngine.Screen.height;
            val_3 = val_3 + (val_3 >> 31);
            val_3 = 64 + (val_3 >> 1);
            UnityEngine.Rect val_4 = new UnityEngine.Rect(x:  (float)149 + (val_1 >> 1), y:  null, width:  (float)val_3, height:  null);
            536899119 = new GUI.WindowFunction(object:  436872528, method:  new IntPtr(1610675857));
            UnityEngine.Rect val_6 = UnityEngine.GUI.Window(id:  436860456, clientRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_4.m_XMin, m_Width = val_4.m_YMin, m_Height = val_4.m_Width}, func:  val_4.m_Height, text:  536899119);
        }
        
        int val_7 = UnityEngine.Screen.height;
        int val_8 = UnityEngine.Screen.width;
        UnityEngine.Rect val_10 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_6.m_YMin, width:  val_6.m_Width, height:  val_6.m_Height);
        if(((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_10.m_XMin, m_YMin = val_10.m_YMin, m_Width = val_10.m_Width, m_Height = val_10.m_Height}, text:  this.txtManualLaunch)) != false) && ((System.String.Equals(a:  this.txtManualLaunch, b:  -1610604833, comparisonType:  5)) != true))
        {
                536883061 = new com.adjust.sdk.AdjustConfig(appToken:  -1610610945, environment:  0);
            536883061.setLogLevel(logLevel:  1);
            if((mem[536898985] + 4) == 0)
        {
                536873327 = new System.Action<SdkConfiguration>(object:  mem[536898985], method:  new IntPtr(1610675879));
            mem2[0] = 536873327;
        }
        
            mem[536883257] = 536873327;
            536873233 = new System.Action<SdkConfiguration>(object:  436872528, method:  new IntPtr(1610675863));
            536883061.setEventSuccessDelegate(eventSuccessDelegate:  536873233, sceneName:  -1610610299);
            536873227 = new System.Action<SdkConfiguration>(object:  436872528, method:  new IntPtr(1610675865));
            536883061.setEventFailureDelegate(eventFailureDelegate:  536873227, sceneName:  -1610610299);
            536873245 = new System.Action<SdkConfiguration>(object:  436872528, method:  new IntPtr(1610675867));
            536883061.setSessionSuccessDelegate(sessionSuccessDelegate:  536873245, sceneName:  -1610610299);
            536873239 = new System.Action<SdkConfiguration>(object:  436872528, method:  new IntPtr(1610675869));
            536883061.setSessionFailureDelegate(sessionFailureDelegate:  536873239, sceneName:  -1610610299);
            536873327 = new System.Action<SdkConfiguration>(object:  436872528, method:  new IntPtr(1610675871));
            536883061.setDeferredDeeplinkDelegate(deferredDeeplinkDelegate:  536873327, sceneName:  -1610610299);
            536873221 = new System.Action<SdkConfiguration>(object:  436872528, method:  new IntPtr(1610675861));
            536883061.setAttributionChangedDelegate(attributionChangedDelegate:  536873221, sceneName:  -1610610299);
            com.adjust.sdk.Adjust.start(adjustConfig:  536883061);
            this.isEnabled = true;
            this.txtManualLaunch = -1610604833;
        }
        
        int val_21 = UnityEngine.Screen.height;
        int val_22 = UnityEngine.Screen.width;
        UnityEngine.Rect val_24 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_6.m_YMin, width:  val_6.m_Width, height:  val_6.m_Height);
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_24.m_XMin, m_YMin = val_24.m_YMin, m_Width = val_24.m_Width, m_Height = val_24.m_Height}, text:  -1610603367)) != false)
        {
                536883075 = new com.adjust.sdk.AdjustEvent(eventToken:  -1610600467);
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  536883075);
        }
        
        int val_27 = UnityEngine.Screen.height;
        val_27 = val_27 << 1;
        int val_28 = UnityEngine.Screen.width;
        UnityEngine.Rect val_30 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_6.m_YMin, width:  val_6.m_Width, height:  val_6.m_Height);
        val_63 = mem[536887392];
        if((val_63 & true) == 0)
        {
                val_63 = mem[536887321];
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_30.m_XMin, m_YMin = val_30.m_YMin, m_Width = val_30.m_Width, m_Height = val_30.m_Height}, text:  -1610603369)) != false)
        {
                536883075 = new com.adjust.sdk.AdjustEvent(eventToken:  -1610601885);
            536883075.setRevenue(amount:  null, currency:  -1610601885);
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  536883075);
        }
        
        int val_33 = UnityEngine.Screen.height;
        val_33 = val_33 + (val_33 << 1);
        int val_34 = UnityEngine.Screen.width;
        UnityEngine.Rect val_36 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_6.m_YMin, width:  val_6.m_Width, height:  val_6.m_Height);
        val_64 = mem[536887392];
        if((val_64 & true) == 0)
        {
                val_64 = mem[536887321];
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_36.m_XMin, m_YMin = val_36.m_YMin, m_Width = val_36.m_Width, m_Height = val_36.m_Height}, text:  -1610603375)) != false)
        {
                536883075 = new com.adjust.sdk.AdjustEvent(eventToken:  -1610610917);
            if(536883075 != 0)
        {
                536883075.addCallbackParameter(key:  -1610599575, value:  -1610597487);
        }
        else
        {
                536883075.addCallbackParameter(key:  -1610599575, value:  -1610597487);
        }
        
            536883075.addCallbackParameter(key:  -1610600509, value:  -1610601641);
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  536883075);
        }
        
        int val_39 = UnityEngine.Screen.height;
        val_39 = val_39 << 2;
        int val_40 = UnityEngine.Screen.width;
        UnityEngine.Rect val_42 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_6.m_YMin, width:  val_6.m_Width, height:  val_6.m_Height);
        val_65 = mem[536887392];
        if((val_65 & true) == 0)
        {
                val_65 = mem[536887321];
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_42.m_XMin, m_YMin = val_42.m_YMin, m_Width = val_42.m_Width, m_Height = val_42.m_Height}, text:  -1610603371)) != false)
        {
                536883075 = new com.adjust.sdk.AdjustEvent(eventToken:  -1610597417);
            if(536883075 != 0)
        {
                536883075.addPartnerParameter(key:  -1610599575, value:  -1610597487);
        }
        else
        {
                536883075.addPartnerParameter(key:  -1610599575, value:  -1610597487);
        }
        
            536883075.addPartnerParameter(key:  -1610600509, value:  -1610601641);
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  536883075);
        }
        
        int val_45 = UnityEngine.Screen.height;
        val_45 = val_45 + (val_45 << 2);
        int val_46 = UnityEngine.Screen.width;
        UnityEngine.Rect val_48 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_6.m_YMin, width:  val_6.m_Width, height:  val_6.m_Height);
        val_66 = mem[536887392];
        if((val_66 & true) == 0)
        {
                val_66 = mem[536887321];
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_48.m_XMin, m_YMin = val_48.m_YMin, m_Width = val_48.m_Width, m_Height = val_48.m_Height}, text:  this.txtSetOfflineMode)) != false)
        {
                if((System.String.Equals(a:  this.txtSetOfflineMode, b:  -1610603287, comparisonType:  5)) != false)
        {
                com.adjust.sdk.Adjust.setOfflineMode(enabled:  true);
            val_67 = -1610603289;
        }
        else
        {
                com.adjust.sdk.Adjust.setOfflineMode(enabled:  false);
            val_67 = -1610603287;
        }
        
            this.txtSetOfflineMode = val_67;
        }
        
        int val_51 = UnityEngine.Screen.height;
        val_51 = val_51 + (val_51 << 1);
        val_51 = val_51 << 1;
        int val_52 = UnityEngine.Screen.width;
        UnityEngine.Rect val_54 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_6.m_YMin, width:  val_6.m_Width, height:  val_6.m_Height);
        val_68 = mem[536887392];
        if((val_68 & true) == 0)
        {
                val_68 = mem[536887321];
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_54.m_XMin, m_YMin = val_54.m_YMin, m_Width = val_54.m_Width, m_Height = val_54.m_Height}, text:  this.txtSetEnabled)) != false)
        {
                if((System.String.Equals(a:  this.txtSetEnabled, b:  -1610608711, comparisonType:  5)) != false)
        {
                com.adjust.sdk.Adjust.setEnabled(enabled:  false);
            val_69 = -1610608539;
        }
        else
        {
                com.adjust.sdk.Adjust.setEnabled(enabled:  true);
            val_69 = -1610608711;
        }
        
            this.txtSetEnabled = val_69;
        }
        
        int val_57 = UnityEngine.Screen.height;
        val_57 = (val_57 << 3) - val_57;
        int val_58 = UnityEngine.Screen.width;
        UnityEngine.Rect val_60 = new UnityEngine.Rect(x:  (float)UnityEngine.Screen.height, y:  val_6.m_YMin, width:  val_6.m_Width, height:  val_6.m_Height);
        val_70 = mem[536887392];
        if((val_70 & true) == 0)
        {
                val_70 = mem[536887321];
        }
        
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_60.m_XMin, m_YMin = val_60.m_YMin, m_Width = val_60.m_Width, m_Height = val_60.m_Height}, text:  -1610607101)) == false)
        {
                return;
        }
        
        this.isEnabled = com.adjust.sdk.Adjust.isEnabled();
        this.showPopUp = true;
    }
    private void ShowGUI(int windowID)
    {
        var val_5;
        bool val_6;
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        string val_11;
        bool val_12;
        bool val_13;
        if(this.isEnabled != false)
        {
                val_5 = 0;
            UnityEngine.Rect val_1 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            val_6 = mem[536887392];
            if((val_6 & true) == 0)
        {
                val_6 = mem[536887321];
        }
        
            val_11 = 22781760;
        }
        else
        {
                val_5 = 0;
            UnityEngine.Rect val_2 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
            val_12 = mem[536887392];
            if((val_12 & true) == 0)
        {
                val_12 = mem[536887321];
        }
        
            val_11 = 22781756;
        }
        
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_7, m_YMin = val_8, m_Width = val_9, m_Height = val_10}, text:  val_11);
        UnityEngine.Rect val_3 = new UnityEngine.Rect(x:  null, y:  null, width:  null, height:  null);
        val_13 = mem[536887392];
        if((val_13 & true) == 0)
        {
                val_13 = mem[536887321];
        }
        
        bool val_4 = UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = val_3.m_XMin, m_YMin = val_3.m_YMin, m_Width = val_3.m_Width, m_Height = val_3.m_Height}, text:  -1610605893);
        if(val_4 == true)
        {
                val_4 = false;
            this.showPopUp = val_4;
        }
    
    }
    public void HandleGooglePlayId(string adId)
    {
        string val_1 = -1610607883(-1610607883) + adId;
        UnityEngine.Debug.Log(message:  -1610607883);
    }
    public void AttributionChangedCallback(com.adjust.sdk.AdjustAttribution attributionData)
    {
        UnityEngine.Debug.Log(message:  -1610610027);
        if((attributionData.<trackerName>k__BackingField) != null)
        {
                string val_1 = -1610603357(-1610603357) + attributionData.<trackerName>k__BackingField(attributionData.<trackerName>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610603357);
        }
        
        if((attributionData.<trackerToken>k__BackingField) != null)
        {
                string val_2 = -1610603355(-1610603355) + attributionData.<trackerToken>k__BackingField(attributionData.<trackerToken>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610603355);
        }
        
        if((attributionData.<network>k__BackingField) != null)
        {
                string val_3 = -1610606119(-1610606119) + attributionData.<network>k__BackingField(attributionData.<network>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610606119);
        }
        
        if((attributionData.<campaign>k__BackingField) != null)
        {
                string val_4 = -1610609695(-1610609695) + attributionData.<campaign>k__BackingField(attributionData.<campaign>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610609695);
        }
        
        if((attributionData.<adgroup>k__BackingField) != null)
        {
                string val_5 = -1610610303(-1610610303) + attributionData.<adgroup>k__BackingField(attributionData.<adgroup>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610610303);
        }
        
        if((attributionData.<creative>k__BackingField) != null)
        {
                string val_6 = -1610609011(-1610609011) + attributionData.<creative>k__BackingField(attributionData.<creative>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610609011);
        }
        
        if((attributionData.<clickLabel>k__BackingField) != null)
        {
                string val_7 = -1610609337(-1610609337) + attributionData.<clickLabel>k__BackingField(attributionData.<clickLabel>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610609337);
        }
        
        if((attributionData.<adid>k__BackingField) == null)
        {
                return;
        }
        
        string val_8 = -1610610409(-1610610409) + attributionData.<adid>k__BackingField(attributionData.<adid>k__BackingField);
        UnityEngine.Debug.Log(message:  -1610610409);
    }
    public void EventSuccessCallback(com.adjust.sdk.AdjustEventSuccess eventSuccessData)
    {
        UnityEngine.Debug.Log(message:  -1610608377);
        if((eventSuccessData.<Message>k__BackingField) != null)
        {
                string val_1 = -1610606365(-1610606365) + eventSuccessData.<Message>k__BackingField(eventSuccessData.<Message>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610606365);
        }
        
        if((eventSuccessData.<Timestamp>k__BackingField) != null)
        {
                string val_2 = -1610603421(-1610603421) + eventSuccessData.<Timestamp>k__BackingField(eventSuccessData.<Timestamp>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610603421);
        }
        
        if((eventSuccessData.<Adid>k__BackingField) != null)
        {
                string val_3 = -1610610301(-1610610301) + eventSuccessData.<Adid>k__BackingField(eventSuccessData.<Adid>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610610301);
        }
        
        if((eventSuccessData.<EventToken>k__BackingField) != null)
        {
                string val_4 = -1610608361(-1610608361) + eventSuccessData.<EventToken>k__BackingField(eventSuccessData.<EventToken>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610608361);
        }
        
        if((eventSuccessData.<CallbackId>k__BackingField) != null)
        {
                string val_5 = -1610609719(-1610609719) + eventSuccessData.<CallbackId>k__BackingField(eventSuccessData.<CallbackId>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610609719);
        }
        
        if((eventSuccessData.<JsonResponse>k__BackingField) == 0)
        {
                return;
        }
        
        string val_6 = eventSuccessData.GetJsonResponse();
        string val_7 = -1610606801(-1610606801) + eventSuccessData;
        UnityEngine.Debug.Log(message:  -1610606801);
    }
    public void EventFailureCallback(com.adjust.sdk.AdjustEventFailure eventFailureData)
    {
        UnityEngine.Debug.Log(message:  -1610608375);
        if((eventFailureData.<Message>k__BackingField) != null)
        {
                string val_1 = -1610606365(-1610606365) + eventFailureData.<Message>k__BackingField(eventFailureData.<Message>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610606365);
        }
        
        if((eventFailureData.<Timestamp>k__BackingField) != null)
        {
                string val_2 = -1610603421(-1610603421) + eventFailureData.<Timestamp>k__BackingField(eventFailureData.<Timestamp>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610603421);
        }
        
        if((eventFailureData.<Adid>k__BackingField) != null)
        {
                string val_3 = -1610610301(-1610610301) + eventFailureData.<Adid>k__BackingField(eventFailureData.<Adid>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610610301);
        }
        
        if((eventFailureData.<EventToken>k__BackingField) != null)
        {
                string val_4 = -1610608361(-1610608361) + eventFailureData.<EventToken>k__BackingField(eventFailureData.<EventToken>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610608361);
        }
        
        if((eventFailureData.<CallbackId>k__BackingField) != null)
        {
                string val_5 = -1610609719(-1610609719) + eventFailureData.<CallbackId>k__BackingField(eventFailureData.<CallbackId>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610609719);
        }
        
        if((eventFailureData.<JsonResponse>k__BackingField) != 0)
        {
                string val_6 = eventFailureData.GetJsonResponse();
            string val_7 = -1610606801(-1610606801) + eventFailureData;
            UnityEngine.Debug.Log(message:  -1610606801);
        }
        
        string val_8 = eventFailureData.<WillRetry>k__BackingField.ToString();
        string val_9 = -1610602545(-1610602545) + 437600727;
        UnityEngine.Debug.Log(message:  -1610602545);
    }
    public void SessionSuccessCallback(com.adjust.sdk.AdjustSessionSuccess sessionSuccessData)
    {
        UnityEngine.Debug.Log(message:  -1610604663);
        if((sessionSuccessData.<Message>k__BackingField) != null)
        {
                string val_1 = -1610606365(-1610606365) + sessionSuccessData.<Message>k__BackingField(sessionSuccessData.<Message>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610606365);
        }
        
        if((sessionSuccessData.<Timestamp>k__BackingField) != null)
        {
                string val_2 = -1610603421(-1610603421) + sessionSuccessData.<Timestamp>k__BackingField(sessionSuccessData.<Timestamp>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610603421);
        }
        
        if((sessionSuccessData.<Adid>k__BackingField) != null)
        {
                string val_3 = -1610610301(-1610610301) + sessionSuccessData.<Adid>k__BackingField(sessionSuccessData.<Adid>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610610301);
        }
        
        if((sessionSuccessData.<JsonResponse>k__BackingField) == 0)
        {
                return;
        }
        
        string val_4 = sessionSuccessData.GetJsonResponse();
        string val_5 = -1610606801(-1610606801) + sessionSuccessData;
        UnityEngine.Debug.Log(message:  -1610606801);
    }
    public void SessionFailureCallback(com.adjust.sdk.AdjustSessionFailure sessionFailureData)
    {
        UnityEngine.Debug.Log(message:  -1610604661);
        if((sessionFailureData.<Message>k__BackingField) != null)
        {
                string val_1 = -1610606365(-1610606365) + sessionFailureData.<Message>k__BackingField(sessionFailureData.<Message>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610606365);
        }
        
        if((sessionFailureData.<Timestamp>k__BackingField) != null)
        {
                string val_2 = -1610603421(-1610603421) + sessionFailureData.<Timestamp>k__BackingField(sessionFailureData.<Timestamp>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610603421);
        }
        
        if((sessionFailureData.<Adid>k__BackingField) != null)
        {
                string val_3 = -1610610301(-1610610301) + sessionFailureData.<Adid>k__BackingField(sessionFailureData.<Adid>k__BackingField);
            UnityEngine.Debug.Log(message:  -1610610301);
        }
        
        if((sessionFailureData.<JsonResponse>k__BackingField) != 0)
        {
                string val_4 = sessionFailureData.GetJsonResponse();
            string val_5 = -1610606801(-1610606801) + sessionFailureData;
            UnityEngine.Debug.Log(message:  -1610606801);
        }
        
        string val_6 = sessionFailureData.<WillRetry>k__BackingField.ToString();
        string val_7 = -1610602545(-1610602545) + 437914839;
        UnityEngine.Debug.Log(message:  -1610602545);
    }
    private void DeferredDeeplinkCallback(string deeplinkURL)
    {
        var val_2;
        UnityEngine.Debug.Log(message:  -1610608807);
        if(deeplinkURL != null)
        {
                string val_1 = -1610608817(-1610608817) + deeplinkURL;
            val_2 = -1610608817;
        }
        else
        {
                val_2 = -1610608819;
        }
        
        UnityEngine.Debug.Log(message:  -1610608819);
    }
    public ExampleGUI()
    {
        this.numberOfButtons = 8;
        this.txtSetEnabled = -1610608711;
        this.txtManualLaunch = -1610606465;
        this.txtSetOfflineMode = -1610603287;
    }

}
