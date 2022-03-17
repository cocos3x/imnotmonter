using UnityEngine;

namespace Dmobin.Analytics
{
    public class TrackingManager : SingletonMonoBehaviour<Dmobin.Analytics.TrackingManager>
    {
        // Fields
        private bool firebaseAnalytics;
        private bool adjustAnalytics;
        private bool appsflyerAnalytics;
        private string appsflyerID;
        private string adjustAppToken;
        private com.adjust.sdk.AdjustEnvironment adjustEnvironment;
        private bool showLog;
        protected System.Collections.Generic.List<Dmobin.Analytics.IAnalytic> Analytics;
        protected System.Collections.Generic.List<Dmobin.Analytics.IAnalytic> LimitedAnalytics;
        private bool <IsInited>k__BackingField;
        private bool isEditor;
        
        // Properties
        public bool IsInited { get; set; }
        
        // Methods
        public bool get_IsInited()
        {
            return (bool)this.<IsInited>k__BackingField;
        }
        private void set_IsInited(bool value)
        {
            this.<IsInited>k__BackingField = value;
        }
        private void Start()
        {
            this.InitTracking();
            this.isEditor = API.IsEditor();
        }
        private void OnApplicationQuit()
        {
            this.TrackEvent(eventName:  -1610601765);
        }
        private void InitTracking()
        {
            string val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            this.Analytics.Clear();
            if(this.firebaseAnalytics == false)
            {
                goto label_2;
            }
            
            Dmobin.Analytics.FirebaseAnalytics val_1 = 536886919;
            val_1 = new Dmobin.Analytics.FirebaseAnalytics();
            this.Analytics.Add(item:  536886919);
            val_9 = -1073695535;
            val_10 = mem[mem[3221271785] + 186];
            val_10 = mem[3221271785] + 186;
            if(val_10 == 1)
            {
                    val_10 = mem[mem[3221271785] + 186];
                val_10 = mem[3221271785] + 186;
            }
            
            val_11 = mem[mem[3221271785]];
            val_11 = mem[3221271785];
            val_12 = mem[mem[3221271785] + 92];
            val_12 = mem[3221271785] + 92;
            var val_9 = mem[536886919];
            if((mem[536886919] + 178) == 0)
            {
                goto label_11;
            }
            
            val_9 = 0;
            label_13:
            val_11 = 0;
            if((mem[536886919] + 88 + 0) == 536887989)
            {
                goto label_12;
            }
            
            val_9 = val_9 + 1;
            val_11 = (uint)val_9 & 65535;
            if(val_11 < (mem[536886919] + 178))
            {
                goto label_13;
            }
            
            label_11:
            val_13 = val_1;
            goto label_14;
            label_12:
            var val_2 = (mem[536886919] + 88) + 0;
            val_9 = val_9 + (((mem[536886919] + 88 + 0) + 4) << 3);
            val_13 = val_9 + 204;
            label_14:
            label_2:
            if(this.adjustAnalytics == false)
            {
                goto label_15;
            }
            
            if((System.String.op_Equality(a:  this.adjustAppToken, b:  -1610612735)) != false)
            {
                    UnityEngine.Debug.LogError(message:  -1610610289);
            }
            
            UnityEngine.GameObject val_4 = this.gameObject;
            SynchronizationContextBehavoir val_5 = this.AddComponent<SynchronizationContextBehavoir>();
            536883061 = new com.adjust.sdk.AdjustConfig(appToken:  this.adjustAppToken, environment:  this.adjustEnvironment);
            com.adjust.sdk.Adjust.start(adjustConfig:  536883061);
            Dmobin.Analytics.AdjustAnalytics val_7 = 536883053;
            val_12 = val_7;
            val_7 = new Dmobin.Analytics.AdjustAnalytics();
            this.LimitedAnalytics.Add(item:  536883053);
            val_9 = this.adjustAppToken;
            val_11 = 536882401;
            mem[536882417] = val_9;
            var val_10 = mem[536883053];
            if((mem[536883053] + 178) == 0)
            {
                goto label_26;
            }
            
            val_9 = 0;
            label_28:
            if((mem[536883053] + 88 + 0) == 536887989)
            {
                goto label_27;
            }
            
            val_9 = val_9 + 1;
            if(((uint)val_9 & 65535) < (mem[536883053] + 178))
            {
                goto label_28;
            }
            
            label_26:
            val_14 = val_12;
            goto label_29;
            label_27:
            var val_8 = (mem[536883053] + 88) + 0;
            val_10 = val_10 + (((mem[536883053] + 88 + 0) + 4) << 3);
            val_14 = val_10 + 204;
            label_29:
            label_15:
            this.<IsInited>k__BackingField = true;
        }
        public void TrackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> parameters)
        {
            var val_3;
            object val_7;
            var val_9;
            var val_10;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            var val_11 = val_3;
            if((val_3 + 178) == 0)
            {
                goto label_4;
            }
            
            var val_10 = 0;
            label_6:
            if((val_3 + 88 + 0) == 536887989)
            {
                goto label_5;
            }
            
            val_10 = val_10 + 1;
            if(((uint)val_10 & 65535) < (val_3 + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_9 = val_3;
            val_10 = parameters;
            goto label_8;
            label_5:
            var val_4 = (val_3 + 88) + 0;
            val_10 = parameters;
            val_11 = val_11 + (((val_3 + 88 + 0) + 4) << 3);
            val_9 = val_11 + 220;
            goto label_8;
            label_2:
            Dispose();
            if(mem[1152921510058055692] == true)
            {
                    mem[1152921510058055692] = mem[1152921510058055705];
                goto label_9;
            }
            
            return;
            label_9:
            Dictionary.Enumerator<TKey, TValue> val_5 = 0.GetEnumerator();
            label_16:
            if(0.MoveNext() == false)
            {
                goto label_11;
            }
            
            string val_8 = System.String.Format(format:  -1610603351, arg0:  eventName, arg1:  val_7, arg2:  0);
            UnityEngine.Debug.Log(message:  -1610603351);
            goto label_16;
            label_11:
            0.Dispose();
            if(1 == 0)
            {
                    return;
            }
        
        }
        public void TrackEvent(string eventName)
        {
            var val_3;
            var val_6;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            var val_7 = val_3;
            if((val_3 + 178) == 0)
            {
                goto label_4;
            }
            
            var val_6 = 0;
            label_6:
            if((val_3 + 88 + 0) == 536887989)
            {
                goto label_5;
            }
            
            val_6 = val_6 + 1;
            if(((uint)val_6 & 65535) < (val_3 + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_6 = val_3;
            goto label_8;
            label_5:
            var val_4 = (val_3 + 88) + 0;
            val_7 = val_7 + (((val_3 + 88 + 0) + 4) << 3);
            val_6 = val_7 + 212;
            goto label_8;
            label_2:
            Dispose();
            if(mem[1152921510058188172] == true)
            {
                    mem[1152921510058188172] = mem[1152921510058188185];
            }
            
            if(mem[1152921510058188172] == false)
            {
                    return;
            }
            
            string val_5 = -1610603353(-1610603353) + eventName;
            UnityEngine.Debug.Log(message:  -1610603353);
        }
        public void TrackAjustEvent(string eventName)
        {
            var val_3;
            var val_5;
            List.Enumerator<T> val_1 = GetEnumerator();
            label_8:
            if(MoveNext() == false)
            {
                goto label_2;
            }
            
            var val_6 = val_3;
            if((val_3 + 178) == 0)
            {
                goto label_4;
            }
            
            var val_5 = 0;
            label_6:
            if((val_3 + 88 + 0) == 536887989)
            {
                goto label_5;
            }
            
            val_5 = val_5 + 1;
            if(((uint)val_5 & 65535) < (val_3 + 178))
            {
                goto label_6;
            }
            
            label_4:
            val_5 = val_3;
            goto label_8;
            label_5:
            var val_4 = (val_3 + 88) + 0;
            val_6 = val_6 + (((val_3 + 88 + 0) + 4) << 3);
            val_5 = val_6 + 212;
            goto label_8;
            label_2:
            Dispose();
        }
        public TrackingManager()
        {
            System.Collections.Generic.List<Page> val_1 = 536877913;
            val_1 = new System.Collections.Generic.List<Page>();
            this.Analytics = val_1;
            System.Collections.Generic.List<Page> val_2 = 536877913;
            val_2 = new System.Collections.Generic.List<Page>();
            this.LimitedAnalytics = val_2;
        }
    
    }

}
