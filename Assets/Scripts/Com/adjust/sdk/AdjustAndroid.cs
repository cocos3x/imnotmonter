using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustAndroid
    {
        // Fields
        private const string sdkPrefix = "unity4.29.4";
        private static bool launchDeferredDeeplink;
        private static UnityEngine.AndroidJavaClass ajcAdjust;
        private static UnityEngine.AndroidJavaObject ajoCurrentActivity;
        private static com.adjust.sdk.AdjustAndroid.DeferredDeeplinkListener onDeferredDeeplinkListener;
        private static com.adjust.sdk.AdjustAndroid.AttributionChangeListener onAttributionChangedListener;
        private static com.adjust.sdk.AdjustAndroid.EventTrackingFailedListener onEventTrackingFailedListener;
        private static com.adjust.sdk.AdjustAndroid.EventTrackingSucceededListener onEventTrackingSucceededListener;
        private static com.adjust.sdk.AdjustAndroid.SessionTrackingFailedListener onSessionTrackingFailedListener;
        private static com.adjust.sdk.AdjustAndroid.SessionTrackingSucceededListener onSessionTrackingSucceededListener;
        
        // Methods
        public static void Start(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            com.adjust.sdk.AdjustConfig val_40;
            float val_41;
            UnityEngine.AndroidJavaObject val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            System.Action<com.adjust.sdk.AdjustSessionFailure> val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            val_40 = adjustConfig;
            if(val_40 != 0)
            {
                    if(adjustConfig.environment == 1)
            {
                    22805248 = 22804760;
            }
            
            }
            else
            {
                    if(2 == 1)
            {
                    22805248 = 22804760;
            }
            
            }
            
            val_41 = 4.013265E-38f;
            if(22804760 != 0)
            {
                    mem[536882227] = mem[536883147] + 8;
                mem[536882231] = adjustConfig.appToken;
                mem[536882235] = -1610598785;
                mem[536882239] = 536878991;
            }
            else
            {
                    mem[536882227] = mem[536883147] + 8;
                mem[536882231] = adjustConfig.appToken;
                mem[536882235] = -1610598785;
            }
            
            val_42 = 536883209;
            val_42 = new UnityEngine.AndroidJavaObject(className:  -1610601327, args:  536882211);
            val_43 = 22708904;
            mem2[0] = adjustConfig.launchDeferredDeeplink;
            if(mem[536883147] != 0)
            {
                    com.adjust.sdk.AdjustLogLevel val_2 = adjustConfig.logLevel.Value;
                string val_3 = com.adjust.sdk.AdjustLogLevelExtension.ToUppercaseString(AdjustLogLevel:  adjustConfig.logLevel);
                536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601317);
                if((adjustConfig.logLevel.Equals(value:  -1610604787)) != false)
            {
                    val_43 = val_43;
                string val_6 = 536883199.GetStatic<System.String>(fieldName:  -1610604785);
            }
            else
            {
                    com.adjust.sdk.AdjustLogLevel val_7 = adjustConfig.logLevel.Value;
                string val_8 = com.adjust.sdk.AdjustLogLevelExtension.ToUppercaseString(AdjustLogLevel:  adjustConfig.logLevel);
                string val_9 = 536883199.GetStatic<System.String>(fieldName:  adjustConfig.logLevel);
                val_43 = val_43;
            }
            
                val_41 = 4.013265E-38f;
                if(536883199 != 0)
            {
                    mem[536882227] = 536883199;
                val_42.Call(methodName:  -1610598393, args:  536882211);
            }
            
            }
            
            mem[536882227] = -1610597595;
            val_42.Call(methodName:  -1610598333, args:  536882211);
            if(val_42 != 0)
            {
                    mem[536882227] = 536879011;
                val_42.Call(methodName:  -1610598415, args:  536882211);
            }
            
            if(val_42 != 0)
            {
                    bool val_10 = adjustConfig.eventBufferingEnabled.Value;
                mem[536882227] = 536884213;
                536883209 = new UnityEngine.AndroidJavaObject(className:  -1610599687, args:  536882211);
                mem[536882227] = 536883209;
                val_42.Call(methodName:  -1610598407, args:  536882211);
            }
            
            if(val_42 != 0)
            {
                    bool val_12 = adjustConfig.sendInBackground.Value;
                mem[536882227] = 536884213;
                val_42.Call(methodName:  -1610598331, args:  536882211);
            }
            
            if(val_42 != 0)
            {
                    bool val_13 = adjustConfig.needsCost.Value;
                mem[536882227] = 536884213;
                val_42.Call(methodName:  -1610598381, args:  536882211);
            }
            
            if(val_42 != 0)
            {
                    bool val_14 = adjustConfig.preinstallTrackingEnabled.Value;
                mem[536882227] = 536884213;
                val_42.Call(methodName:  -1610598355, args:  536882211);
            }
            
            if(adjustConfig.userAgent != null)
            {
                    mem[536882227] = adjustConfig.userAgent;
                val_42.Call(methodName:  -1610598317, args:  536882211);
            }
            
            if((System.String.IsNullOrEmpty(value:  adjustConfig.processName)) != true)
            {
                    mem[536882227] = adjustConfig.processName;
                val_42.Call(methodName:  -1610598353, args:  536882211);
            }
            
            if(adjustConfig.defaultTracker != null)
            {
                    mem[536882227] = adjustConfig.defaultTracker;
                val_42.Call(methodName:  -1610598417, args:  536882211);
            }
            
            if(adjustConfig.externalDeviceId != null)
            {
                    mem[536882227] = adjustConfig.externalDeviceId;
                val_42.Call(methodName:  -1610598403, args:  536882211);
            }
            
            if(adjustConfig.urlStrategy == null)
            {
                goto label_121;
            }
            
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  -1610601403)) == false)
            {
                goto label_109;
            }
            
            536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601327);
            if(536883199 != 0)
            {
                goto label_120;
            }
            
            goto label_120;
            label_109:
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  -1610599949)) == false)
            {
                goto label_112;
            }
            
            536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601327);
            if(536883199 != 0)
            {
                goto label_120;
            }
            
            goto label_120;
            label_112:
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  -1610600935)) == false)
            {
                goto label_115;
            }
            
            536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601327);
            if(536883199 != 0)
            {
                goto label_120;
            }
            
            goto label_120;
            label_115:
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  -1610600933)) == false)
            {
                goto label_118;
            }
            
            536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601327);
            if(536883199 != 0)
            {
                goto label_120;
            }
            
            goto label_120;
            label_118:
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  -1610600931)) == false)
            {
                goto label_121;
            }
            
            536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601327);
            label_120:
            string val_26 = 536883199.GetStatic<System.String>(fieldName:  -1610608961);
            mem[536882227] = 536883199;
            val_42.Call(methodName:  -1610598319, args:  536882211);
            label_121:
            if((com.adjust.sdk.AdjustAndroid.IsAppSecretSet(adjustConfig:  val_40)) != false)
            {
                    long val_28 = adjustConfig.secretId.Value;
                mem[536882227] = 536889041;
                long val_29 = adjustConfig.info1.Value;
                mem[536882231] = 536889041;
                long val_30 = adjustConfig.info2.Value;
                mem[536882235] = 536889041;
                long val_31 = adjustConfig.info3.Value;
                mem[536882239] = 536889041;
                long val_32 = adjustConfig.info4.Value;
                val_41 = 22708416;
                mem[536882243] = 536889041;
                val_42.Call(methodName:  -1610598433, args:  536882211);
            }
            
            if(val_42 != 0)
            {
                    bool val_33 = adjustConfig.isDeviceKnown.Value;
                mem[536882227] = 536884213;
                val_42.Call(methodName:  -1610598413, args:  536882211);
            }
            
            if(adjustConfig.attributionChangedDelegate != 0)
            {
                    AdjustAndroid.AttributionChangeListener val_34 = 536897805;
                val_34 = new AdjustAndroid.AttributionChangeListener(pCallback:  adjustConfig.attributionChangedDelegate);
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_44 = 536883055;
            }
            
                mem2[0] = val_34;
                mem[536882227] = mem[536883147] + 16;
                val_42.Call(methodName:  -1610598369, args:  536882211);
            }
            
            if(adjustConfig.eventSuccessDelegate != 0)
            {
                    AdjustAndroid.EventTrackingSucceededListener val_35 = 536897819;
                val_35 = new AdjustAndroid.EventTrackingSucceededListener(pCallback:  adjustConfig.eventSuccessDelegate);
                val_45 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_45 = 536883055;
            }
            
                mem2[0] = val_35;
                mem[536882227] = mem[536883147] + 24;
                val_42.Call(methodName:  -1610598363, args:  536882211);
            }
            
            if(adjustConfig.eventFailureDelegate != 0)
            {
                    AdjustAndroid.EventTrackingFailedListener val_36 = 536897815;
                val_36 = new AdjustAndroid.EventTrackingFailedListener(pCallback:  adjustConfig.eventFailureDelegate);
                val_46 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_46 = 536883055;
            }
            
                mem2[0] = val_36;
                mem[536882227] = mem[536883147] + 20;
                val_42.Call(methodName:  -1610598365, args:  536882211);
            }
            
            if(adjustConfig.sessionSuccessDelegate != 0)
            {
                    AdjustAndroid.SessionTrackingSucceededListener val_37 = 536897827;
                val_37 = new AdjustAndroid.SessionTrackingSucceededListener(pCallback:  adjustConfig.sessionSuccessDelegate);
                val_47 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_47 = 536883055;
            }
            
                mem2[0] = val_37;
                mem[536882227] = mem[536883147] + 32;
                val_42.Call(methodName:  -1610598359, args:  536882211);
            }
            
            val_48 = adjustConfig.sessionFailureDelegate;
            if(val_48 != 0)
            {
                    AdjustAndroid.SessionTrackingFailedListener val_38 = 536897823;
                val_38 = new AdjustAndroid.SessionTrackingFailedListener(pCallback:  val_48);
                val_49 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_49 = 536883055;
            }
            
                mem2[0] = val_38;
                val_48 = mem[mem[536883147] + 28];
                val_48 = mem[536883147] + 28;
                mem[536882227] = val_48;
                val_42.Call(methodName:  -1610598361, args:  536882211);
            }
            
            if(adjustConfig.deferredDeeplinkDelegate != 0)
            {
                    AdjustAndroid.DeferredDeeplinkListener val_39 = 536897809;
                val_39 = new AdjustAndroid.DeferredDeeplinkListener(pCallback:  adjustConfig.deferredDeeplinkDelegate);
                val_50 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_50 = 536883055;
            }
            
                mem2[0] = val_39;
                mem[536882227] = mem[536883147] + 12;
                val_42.Call(methodName:  -1610598367, args:  536882211);
            }
            
            val_51 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_51 = 536883055;
            }
            
            mem[536882227] = val_42;
            mem[536883147] + 4.CallStatic(methodName:  -1610598961, args:  536882211);
            val_52 = mem[mem[3221271783] + 186];
            val_52 = mem[3221271783] + 186;
            if(val_52 == 1)
            {
                    val_52 = mem[mem[3221271783] + 186];
                val_52 = mem[3221271783] + 186;
            }
            
            mem[536883147] + 4.CallStatic(methodName:  -1610598951, args:  mem[3221271783] + 92);
        }
        public static void TrackEvent(com.adjust.sdk.AdjustEvent adjustEvent)
        {
            string val_3;
            System.Collections.Generic.List<System.String> val_4;
            float val_5;
            var val_6;
            System.Collections.Generic.List<System.String> val_7;
            var val_8;
            val_3 = adjustEvent.eventToken;
            mem[536882227] = val_3;
            536883209 = new UnityEngine.AndroidJavaObject(className:  -1610601325, args:  536882211);
            if(536883209 != 0)
            {
                    val_3 = 536882211;
                double val_2 = adjustEvent.revenue.Value;
                mem[536882227] = 536886067;
                mem[536882231] = adjustEvent.currency;
                var val_4 = -1610598341;
                536883209.Call(methodName:  -1610598341, args:  536882211);
            }
            
            val_4 = adjustEvent.callbackList;
            if(val_4 == 0)
            {
                goto label_15;
            }
            
            val_3 = 0;
            goto label_16;
            label_30:
            if(536883209 <= val_3)
            {
                    var val_3 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_3 = val_3 + 0;
            val_5 = 1;
            if(val_3 <= val_5)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            val_6 = mem[(-1610598341 + 0) + 20];
            val_6 = (-1610598341 + 0) + 20;
            mem[536882227] = (0 + 0) + 16;
            mem[536882231] = val_6;
            var val_6 = -1610601847;
            536883209.Call(methodName:  -1610601847, args:  536882211);
            val_4 = adjustEvent.callbackList;
            val_3 = val_5 + 1;
            label_16:
            if(val_3 < 536883209)
            {
                goto label_30;
            }
            
            label_15:
            val_7 = adjustEvent.partnerList;
            if(val_7 == 0)
            {
                goto label_31;
            }
            
            val_3 = 0;
            val_5 = 4.038555E-38f;
            goto label_32;
            label_46:
            if(536883209 <= val_3)
            {
                    var val_5 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            if(val_5 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            val_6 = mem[(-1610601847 + 0) + 20];
            val_6 = (-1610601847 + 0) + 20;
            mem[536882227] = (0 + 0) + 16;
            mem[536882231] = val_6;
            536883209.Call(methodName:  -1610601839, args:  536882211);
            val_7 = adjustEvent.partnerList;
            val_3 = 1 + 1;
            label_32:
            if(val_3 < 536883209)
            {
                goto label_46;
            }
            
            label_31:
            if(adjustEvent.transactionId != null)
            {
                    val_3 = adjustEvent.transactionId;
                mem[536882227] = val_3;
                536883209.Call(methodName:  -1610598357, args:  536882211);
            }
            
            if(adjustEvent.callbackId != null)
            {
                    mem[536882227] = adjustEvent.callbackId;
                536883209.Call(methodName:  -1610598423, args:  536882211);
            }
            
            val_8 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_8 = 536883055;
            }
            
            mem[536882227] = 536883209;
            mem[536883147] + 4.CallStatic(methodName:  -1610597699, args:  536882211);
        }
        public static bool IsEnabled()
        {
            var val_1;
            var val_2;
            val_1 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_1 = 536883055;
            }
            
            val_2 = mem[mem[3221271783] + 186];
            val_2 = mem[3221271783] + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[mem[3221271783] + 186];
                val_2 = mem[3221271783] + 186;
            }
            
            if((mem[536883147] + 4) != 0)
            {
                    return mem[536883147] + 4.CallStatic<System.Boolean>(methodName:  -1610599815, args:  mem[3221271783] + 92);
            }
            
            return mem[536883147] + 4.CallStatic<System.Boolean>(methodName:  -1610599815, args:  mem[3221271783] + 92);
        }
        public static void SetEnabled(bool enabled)
        {
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    536883055 = 536883055;
            }
            
            mem[536882227] = 536884213;
            mem[536883147] + 4.CallStatic(methodName:  -1610598409, args:  536882211);
        }
        public static void SetOfflineMode(bool enabled)
        {
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    536883055 = 536883055;
            }
            
            mem[536882227] = 536884213;
            mem[536883147] + 4.CallStatic(methodName:  -1610598373, args:  536882211);
        }
        public static void SendFirstPackages()
        {
            var val_1;
            var val_2;
            val_1 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_1 = 536883055;
            }
            
            val_2 = mem[mem[3221271783] + 186];
            val_2 = mem[3221271783] + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[mem[3221271783] + 186];
                val_2 = mem[3221271783] + 186;
            }
            
            mem[536883147] + 4.CallStatic(methodName:  -1610598491, args:  mem[3221271783] + 92);
        }
        public static void SetDeviceToken(string deviceToken)
        {
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    536883055 = 536883055;
            }
            
            mem[536882227] = deviceToken;
            mem[536882231] = mem[536883147] + 8;
            mem[536883147] + 4.CallStatic(methodName:  -1610598347, args:  536882211);
        }
        public static string GetAdid()
        {
            var val_1;
            var val_2;
            val_1 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_1 = 536883055;
            }
            
            val_2 = mem[mem[3221271783] + 186];
            val_2 = mem[3221271783] + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[mem[3221271783] + 186];
                val_2 = mem[3221271783] + 186;
            }
            
            if((mem[536883147] + 4) != 0)
            {
                    return mem[536883147] + 4.CallStatic<System.String>(methodName:  -1610600431, args:  mem[3221271783] + 92);
            }
            
            return mem[536883147] + 4.CallStatic<System.String>(methodName:  -1610600431, args:  mem[3221271783] + 92);
        }
        public static void GdprForgetMe()
        {
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    536883055 = 536883055;
            }
            
            mem[536882227] = mem[536883147] + 8;
            mem[536883147] + 4.CallStatic(methodName:  -1610600453, args:  536882211);
        }
        public static void DisableThirdPartySharing()
        {
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    536883055 = 536883055;
            }
            
            mem[536882227] = mem[536883147] + 8;
            mem[536883147] + 4.CallStatic(methodName:  -1610600795, args:  536882211);
        }
        public static com.adjust.sdk.AdjustAttribution GetAttribution()
        {
            var val_37;
            float val_38;
            var val_39;
            var val_40;
            var val_41;
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            val_37 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_37 = 536883055;
            }
            
            val_38 = 4.023709E-38f;
            val_39 = -1073695537;
            val_40 = mem[mem[3221271783] + 186];
            val_40 = mem[3221271783] + 186;
            if(val_40 == 1)
            {
                    val_40 = mem[mem[3221271783] + 186];
                val_40 = mem[3221271783] + 186;
            }
            
            string val_1 = mem[536883147] + 4.CallStatic<System.String>(methodName:  -1610600425, args:  mem[3221271783] + 92);
            if((mem[536883147] + 4) == 0)
            {
                goto label_10;
            }
            
            object val_2 = 536883059;
            val_41 = val_2;
            val_2 = new System.Object();
            val_42 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_42 = 536883097;
            }
            
            string val_3 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 44);
            val_43 = 22776880;
            val_44 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_45 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_45 = 536883097;
            }
            
                string val_5 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 44);
                val_44 = mem[536883147] + 4;
            }
            
            mem[536883091] = val_44;
            val_46 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_46 = 536883097;
            }
            
            string val_6 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 48);
            val_47 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_48 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_48 = 536883097;
            }
            
                string val_8 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 48);
                val_47 = mem[536883147] + 4;
            }
            
            mem[536883095] = val_47;
            val_49 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_49 = 536883097;
            }
            
            string val_9 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 8);
            val_50 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_51 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_51 = 536883097;
            }
            
                string val_11 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 8);
                val_50 = mem[536883147] + 4;
            }
            
            mem[536883071] = val_50;
            val_52 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_52 = 536883097;
            }
            
            string val_12 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 16);
            val_53 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_54 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_54 = 536883097;
            }
            
                string val_14 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 16);
                val_53 = mem[536883147] + 4;
            }
            
            mem[536883079] = val_53;
            val_55 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_55 = 536883097;
            }
            
            string val_15 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 12);
            val_56 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_57 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_57 = 536883097;
            }
            
                string val_17 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 12);
                val_56 = mem[536883147] + 4;
            }
            
            mem[536883075] = val_56;
            val_58 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_58 = 536883097;
            }
            
            string val_18 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 20);
            val_59 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_60 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_60 = 536883097;
            }
            
                string val_20 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 20);
                val_59 = mem[536883147] + 4;
            }
            
            mem[536883083] = val_59;
            val_61 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_61 = 536883097;
            }
            
            string val_21 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 40);
            val_62 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_63 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_63 = 536883097;
            }
            
                string val_23 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 40);
                val_62 = mem[536883147] + 4;
            }
            
            mem[536883087] = val_62;
            val_64 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_64 = 536883097;
            }
            
            string val_24 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189]);
            val_65 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_66 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_66 = 536883097;
            }
            
                string val_26 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189]);
                val_65 = mem[536883147] + 4;
            }
            
            mem[536883067] = val_65;
            val_67 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_67 = 536883097;
            }
            
            string val_27 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 56);
            val_68 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_69 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_69 = 536883097;
            }
            
                string val_29 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 56);
                val_68 = mem[536883147] + 4;
            }
            
            mem[536883099] = val_68;
            val_70 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_70 = 536883097;
            }
            
            string val_30 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 60);
            if((mem[536883147] + 4) == 0)
            {
                goto label_62;
            }
            
            val_71 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_71 = 536883097;
            }
            
            string val_31 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 60);
            if((mem[536883147] + 4) == 0)
            {
                goto label_62;
            }
            
            val_38 = -2.011036f;
            val_72 = mem[mem[3221271783] + 186];
            val_72 = mem[3221271783] + 186;
            if(val_72 == 1)
            {
                    val_72 = mem[mem[3221271783] + 186];
                val_72 = mem[3221271783] + 186;
            }
            
            System.Nullable<System.Double> val_33 = new System.Nullable<System.Double>(value:  mem[536883147] + 4.Call<System.Double>(methodName:  -1610600787, args:  mem[3221271783] + 92));
            val_43 = 22776880;
            goto label_69;
            label_62:
            label_69:
            var val_34 = val_41 + 48;
            val_73 = 536883097;
            if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_73 = 536883097;
            }
            
            string val_35 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 64);
            val_39 = 0;
            if((System.String.op_Equality(a:  mem[536883147] + 4, b:  -1610612735)) != true)
            {
                    val_74 = 536883097;
                if(((mem[536883284] & true) == 0) && (mem[536883213] == 0))
            {
                    val_74 = 536883097;
            }
            
                string val_37 = mem[536883147] + 4.Get<System.String>(fieldName:  mem[536883189] + 64);
                val_39 = mem[536883147] + 4;
            }
            
            mem[536883123] = val_39;
            return;
            label_10:
            val_41 = 0;
        }
        public static void AddSessionPartnerParameter(string key, string value)
        {
            var val_2;
            var val_3;
            val_2 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            if((mem[536883147] + 4) == 0)
            {
                    536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601331);
                val_3 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_3 = 536883055;
            }
            
                mem2[0] = 536883199;
                val_2 = 536883055;
            }
            
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            mem[536882227] = key;
            mem[536882231] = value;
            mem[536883147] + 4.CallStatic(methodName:  -1610601835, args:  536882211);
        }
        public static void AddSessionCallbackParameter(string key, string value)
        {
            var val_2;
            var val_3;
            val_2 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            if((mem[536883147] + 4) == 0)
            {
                    536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601331);
                val_3 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_3 = 536883055;
            }
            
                mem2[0] = 536883199;
                val_2 = 536883055;
            }
            
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            mem[536882227] = key;
            mem[536882231] = value;
            mem[536883147] + 4.CallStatic(methodName:  -1610601837, args:  536882211);
        }
        public static void RemoveSessionPartnerParameter(string key)
        {
            var val_2;
            var val_3;
            val_2 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            if((mem[536883147] + 4) == 0)
            {
                    536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601331);
                val_3 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_3 = 536883055;
            }
            
                mem2[0] = 536883199;
                val_2 = 536883055;
            }
            
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            mem[536882227] = key;
            mem[536883147] + 4.CallStatic(methodName:  -1610598673, args:  536882211);
        }
        public static void RemoveSessionCallbackParameter(string key)
        {
            var val_2;
            var val_3;
            val_2 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            if((mem[536883147] + 4) == 0)
            {
                    536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601331);
                val_3 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_3 = 536883055;
            }
            
                mem2[0] = 536883199;
                val_2 = 536883055;
            }
            
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            mem[536882227] = key;
            mem[536883147] + 4.CallStatic(methodName:  -1610598675, args:  536882211);
        }
        public static void ResetSessionPartnerParameters()
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            if((mem[536883147] + 4) == 0)
            {
                    536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601331);
                val_3 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_3 = 536883055;
            }
            
                mem2[0] = 536883199;
                val_2 = 536883055;
            }
            
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            val_4 = mem[mem[3221271783] + 186];
            val_4 = mem[3221271783] + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[mem[3221271783] + 186];
                val_4 = mem[3221271783] + 186;
            }
            
            mem[536883147] + 4.CallStatic(methodName:  -1610598643, args:  mem[3221271783] + 92);
        }
        public static void ResetSessionCallbackParameters()
        {
            var val_2;
            var val_3;
            var val_4;
            val_2 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            if((mem[536883147] + 4) == 0)
            {
                    536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601331);
                val_3 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_3 = 536883055;
            }
            
                mem2[0] = 536883199;
                val_2 = 536883055;
            }
            
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            val_4 = mem[mem[3221271783] + 186];
            val_4 = mem[3221271783] + 186;
            if(val_4 == 1)
            {
                    val_4 = mem[mem[3221271783] + 186];
                val_4 = mem[3221271783] + 186;
            }
            
            mem[536883147] + 4.CallStatic(methodName:  -1610598645, args:  mem[3221271783] + 92);
        }
        public static void AppWillOpenUrl(string url)
        {
            var val_3;
            536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601795);
            mem[536882227] = url;
            string val_2 = 536883199.CallStatic<System.String>(methodName:  -1610598879, args:  536882211);
            val_3 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_3 = 536883055;
            }
            
            mem[536882227] = 536883199;
            mem[536882231] = mem[536883147] + 8;
            mem[536883147] + 4.CallStatic(methodName:  -1610601767, args:  536882211);
        }
        public static void TrackAdRevenue(string source, string payload)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_3 = 536883055;
            }
            
            if((mem[536883147] + 4) == 0)
            {
                    536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601331);
                val_4 = 536883055;
                if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_4 = 536883055;
            }
            
                mem2[0] = 536883199;
            }
            
            mem[536882227] = payload;
            536883209 = new UnityEngine.AndroidJavaObject(className:  -1610598921, args:  536882211);
            val_5 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_5 = 536883055;
            }
            
            mem[536882227] = source;
            mem[536882231] = 536883209;
            mem[536883147] + 4.CallStatic(methodName:  -1610597701, args:  536882211);
        }
        public static void TrackAdRevenue(com.adjust.sdk.AdjustAdRevenue adRevenue)
        {
            string val_4;
            var val_5;
            System.Collections.Generic.List<System.String> val_6;
            float val_7;
            System.Collections.Generic.List<System.String> val_8;
            var val_9;
            val_4 = adRevenue.source;
            mem[536882227] = val_4;
            val_5 = 22709008;
            536883209 = new UnityEngine.AndroidJavaObject(className:  -1610601329, args:  536882211);
            if(536883209 != 0)
            {
                    mem[536882227] = 536879011;
                536883209 = new UnityEngine.AndroidJavaObject(className:  -1610599679, args:  536882211);
                val_4 = 536882211;
                mem[536882227] = 536883209;
                mem[536882231] = adRevenue.currency;
                536883209.Call(methodName:  -1610598341, args:  536882211);
            }
            
            if(536883209 != 0)
            {
                    mem[536882227] = 536879021;
                536883209 = new UnityEngine.AndroidJavaObject(className:  -1610599675, args:  536882211);
                val_4 = 536882211;
                mem[536882227] = 536883209;
                536883209.Call(methodName:  -1610598441, args:  536882211);
            }
            
            if(adRevenue.adRevenueNetwork != null)
            {
                    val_4 = adRevenue.adRevenueNetwork;
                mem[536882227] = val_4;
                536883209.Call(methodName:  -1610598439, args:  536882211);
            }
            
            if(adRevenue.adRevenueUnit != null)
            {
                    val_4 = adRevenue.adRevenueUnit;
                mem[536882227] = val_4;
                536883209.Call(methodName:  -1610598435, args:  536882211);
            }
            
            if(adRevenue.adRevenuePlacement != null)
            {
                    val_4 = adRevenue.adRevenuePlacement;
                mem[536882227] = val_4;
                var val_5 = -1610598437;
                536883209.Call(methodName:  -1610598437, args:  536882211);
            }
            
            val_6 = adRevenue.callbackList;
            if(val_6 == 0)
            {
                goto label_47;
            }
            
            val_4 = 0;
            goto label_48;
            label_62:
            if(536883209 <= val_4)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            val_7 = 1;
            if(val_4 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            val_5 = mem[(-1610598437 + 0) + 20];
            val_5 = (-1610598437 + 0) + 20;
            mem[536882227] = (0 + 0) + 16;
            mem[536882231] = val_5;
            var val_7 = -1610601847;
            536883209.Call(methodName:  -1610601847, args:  536882211);
            val_6 = adRevenue.callbackList;
            val_4 = val_7 + 1;
            label_48:
            if(val_4 < 536883209)
            {
                goto label_62;
            }
            
            label_47:
            val_8 = adRevenue.partnerList;
            if(val_8 == 0)
            {
                goto label_63;
            }
            
            val_4 = 0;
            val_7 = 4.038555E-38f;
            goto label_64;
            label_78:
            if(536883209 <= val_4)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            if(val_6 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            val_5 = mem[(-1610601847 + 0) + 20];
            val_5 = (-1610601847 + 0) + 20;
            mem[536882227] = (0 + 0) + 16;
            mem[536882231] = val_5;
            536883209.Call(methodName:  -1610601839, args:  536882211);
            val_8 = adRevenue.partnerList;
            val_4 = 1 + 1;
            label_64:
            if(val_4 < 536883209)
            {
                goto label_78;
            }
            
            label_63:
            val_9 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_9 = 536883055;
            }
            
            mem[536882227] = 536883209;
            mem[536883147] + 4.CallStatic(methodName:  -1610597701, args:  536882211);
        }
        public static void TrackPlayStoreSubscription(com.adjust.sdk.AdjustPlayStoreSubscription subscription)
        {
            var val_4;
            System.Collections.Generic.List<System.String> val_5;
            var val_6;
            float val_7;
            System.Collections.Generic.List<System.String> val_8;
            var val_9;
            var val_10;
            long val_1 = System.Convert.ToInt64(value:  subscription.price);
            val_4 = 22712456;
            mem[536882227] = 536889041;
            mem[536882231] = subscription.currency;
            mem[536882235] = subscription.sku;
            mem[536882239] = subscription.orderId;
            mem[536882243] = subscription.signature;
            mem[536882247] = subscription.purchaseToken;
            536883209 = new UnityEngine.AndroidJavaObject(className:  -1610601323, args:  536882211);
            if(subscription.purchaseTime != null)
            {
                    long val_3 = System.Convert.ToInt64(value:  subscription.purchaseTime);
                mem[536882227] = 536889041;
                var val_5 = -1610598351;
                536883209.Call(methodName:  -1610598351, args:  536882211);
            }
            
            val_5 = subscription.callbackList;
            if(val_5 == 0)
            {
                goto label_31;
            }
            
            val_6 = 0;
            goto label_32;
            label_46:
            if(536883209 <= val_6)
            {
                    var val_4 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_4 = val_4 + 0;
            val_7 = 1;
            if(val_4 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_5 = val_5 + 0;
            val_4 = mem[(-1610598351 + 0) + 20];
            val_4 = (-1610598351 + 0) + 20;
            mem[536882227] = (0 + 0) + 16;
            mem[536882231] = val_4;
            var val_7 = -1610601847;
            536883209.Call(methodName:  -1610601847, args:  536882211);
            val_5 = subscription.callbackList;
            val_6 = val_7 + 1;
            label_32:
            if(val_6 < 536883209)
            {
                goto label_46;
            }
            
            label_31:
            val_8 = subscription.partnerList;
            if(val_8 == 0)
            {
                goto label_47;
            }
            
            val_9 = 0;
            val_7 = 4.038555E-38f;
            goto label_48;
            label_62:
            if(536883209 <= val_9)
            {
                    var val_6 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_6 = val_6 + 0;
            if(val_6 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_7 = val_7 + 0;
            val_4 = mem[(-1610601847 + 0) + 20];
            val_4 = (-1610601847 + 0) + 20;
            mem[536882227] = (0 + 0) + 16;
            mem[536882231] = val_4;
            536883209.Call(methodName:  -1610601839, args:  536882211);
            val_8 = subscription.partnerList;
            val_9 = 1 + 1;
            label_48:
            if(val_9 < 536883209)
            {
                goto label_62;
            }
            
            label_47:
            val_10 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_10 = 536883055;
            }
            
            mem[536882227] = 536883209;
            mem[536883147] + 4.CallStatic(methodName:  -1610597695, args:  536882211);
        }
        public static void TrackThirdPartySharing(com.adjust.sdk.AdjustThirdPartySharing thirdPartySharing)
        {
            UnityEngine.AndroidJavaObject val_7;
            var val_8;
            if(0 != 0)
            {
                    mem[536882227] = 536884213;
                536883209 = new UnityEngine.AndroidJavaObject(className:  -1610599687, args:  536882211);
                mem[536882227] = 536883209;
                val_7 = 536883209;
                val_7 = new UnityEngine.AndroidJavaObject(className:  -1610601319, args:  536882211);
            }
            else
            {
                    val_7 = 536883209;
                val_7 = new UnityEngine.AndroidJavaObject(className:  -1610601319, args:  null);
            }
            
            if(thirdPartySharing.granularOptions == 0)
            {
                goto label_12;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_5 = thirdPartySharing.isEnabled.Value.GetEnumerator();
            label_15:
            if(0.MoveNext() == false)
            {
                goto label_13;
            }
            
            var val_10 = 0;
            label_29:
            if(val_10 >= 1599295075)
            {
                goto label_15;
            }
            
            mem[536882227] = ;
            if(1599295075 <= val_10)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_8 = 1231451490;
            val_8 = val_8 + 0;
            mem[536882231] = (1231451490 + 0) + 16;
            var val_7 = val_10 + 1;
            if(1599295075 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_9 = 1231451490;
            val_9 = val_9 + 0;
            mem[536882235] = (1231451490 + 0) + 20;
            val_10 = val_7 + 1;
            val_7.Call(methodName:  -1610601845, args:  536882211);
            goto label_29;
            label_13:
            0.Dispose();
            label_12:
            val_8 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_8 = 536883055;
            }
            
            mem[536882227] = val_7;
            mem[536883147] + 4.CallStatic(methodName:  -1610597693, args:  536882211);
        }
        public static void TrackMeasurementConsent(bool measurementConsent)
        {
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    536883055 = 536883055;
            }
            
            mem[536882227] = 536884213;
            mem[536883147] + 4.CallStatic(methodName:  -1610597697, args:  536882211);
        }
        public static void OnPause()
        {
            var val_1;
            var val_2;
            val_1 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_1 = 536883055;
            }
            
            val_2 = mem[mem[3221271783] + 186];
            val_2 = mem[3221271783] + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[mem[3221271783] + 186];
                val_2 = mem[3221271783] + 186;
            }
            
            mem[536883147] + 4.CallStatic(methodName:  -1610598959, args:  mem[3221271783] + 92);
        }
        public static void OnResume()
        {
            var val_1;
            var val_2;
            val_1 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_1 = 536883055;
            }
            
            val_2 = mem[mem[3221271783] + 186];
            val_2 = mem[3221271783] + 186;
            if(val_2 == 1)
            {
                    val_2 = mem[mem[3221271783] + 186];
                val_2 = mem[3221271783] + 186;
            }
            
            mem[536883147] + 4.CallStatic(methodName:  -1610598951, args:  mem[3221271783] + 92);
        }
        public static void SetReferrer(string referrer)
        {
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    536883055 = 536883055;
            }
            
            mem[536882227] = referrer;
            mem[536882231] = mem[536883147] + 8;
            mem[536883147] + 4.CallStatic(methodName:  -1610598345, args:  536882211);
        }
        public static void GetGoogleAdId(System.Action<string> onDeviceIdsRead)
        {
            var val_2;
            AdjustAndroid.DeviceIdsReadListener val_1 = 536897813;
            val_1 = new AdjustAndroid.DeviceIdsReadListener(pCallback:  onDeviceIdsRead);
            val_2 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            mem[536882227] = mem[536883147] + 8;
            mem[536882231] = val_1;
            mem[536883147] + 4.CallStatic(methodName:  -1610600391, args:  536882211);
        }
        public static string GetAmazonAdId()
        {
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    536883055 = 536883055;
            }
            
            mem[536882227] = mem[536883147] + 8;
            if((mem[536883147] + 4) != 0)
            {
                    return mem[536883147] + 4.CallStatic<System.String>(methodName:  -1610600429, args:  536882211);
            }
            
            return mem[536883147] + 4.CallStatic<System.String>(methodName:  -1610600429, args:  536882211);
        }
        public static string GetSdkVersion()
        {
            var val_2;
            var val_3;
            val_2 = 536883055;
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    val_2 = 536883055;
            }
            
            val_3 = mem[mem[3221271783] + 186];
            val_3 = mem[3221271783] + 186;
            if(val_3 == 1)
            {
                    val_3 = mem[mem[3221271783] + 186];
                val_3 = mem[3221271783] + 186;
            }
            
            string val_1 = mem[536883147] + 4.CallStatic<System.String>(methodName:  -1610600337, args:  mem[3221271783] + 92);
            return -1610597593(-1610597593) + mem[536883147] + 4(mem[536883147] + 4);
        }
        public static void SetTestOptions(System.Collections.Generic.Dictionary<string, string> testOptions)
        {
            if(((mem[536883242] & true) == 0) && (mem[536883171] == 0))
            {
                    536883055 = 536883055;
            }
            
            UnityEngine.AndroidJavaObject val_1 = com.adjust.sdk.AdjustUtils.TestOptionsMap2AndroidJavaObject(testOptionsMap:  testOptions, ajoCurrentActivity:  mem[536883147] + 8);
            mem[536882227] = testOptions;
            mem[536883147] + 4.CallStatic(methodName:  -1610598323, args:  536882211);
        }
        private static bool IsAppSecretSet(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            if(R1 == 0)
            {
                    return false;
            }
            
            return false;
        }
        public AdjustAndroid()
        {
        
        }
        private static AdjustAndroid()
        {
            mem2[0] = 1;
            536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601331);
            mem2[0] = 536883199;
            536883199 = new UnityEngine.AndroidJavaClass(className:  -1610601241);
            string val_3 = 536883199.GetStatic<System.String>(fieldName:  -1610600971);
            mem2[0] = 536883199;
        }
    
    }

}
