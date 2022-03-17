using UnityEngine;

namespace Dmobin.Analytics
{
    public class FirebaseAnalytics : IAnalytic
    {
        // Fields
        private bool <InitSuccess>k__BackingField;
        private string mUDID;
        
        // Properties
        public bool InitSuccess { get; set; }
        
        // Methods
        public bool get_InitSuccess()
        {
            return (bool)this.<InitSuccess>k__BackingField;
        }
        public void set_InitSuccess(bool value)
        {
            this.<InitSuccess>k__BackingField = value;
        }
        public void ApplicationOnPause(bool Paused)
        {
        
        }
        public void Init(string[] args)
        {
            string val_1 = Dmobin.Utility.GetUDID();
            this.mUDID = 0;
            536882991 = new System.Action(object:  1154853744, method:  new IntPtr(1610686851));
            Dmobin.FirebaseService.FirebaseInstance.CheckAndTryInit(callback:  536882991);
        }
        public void TrackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> parameters)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = parameters;
            if(Dmobin.FirebaseService.FirebaseInstance.HasInstance == false)
            {
                    return;
            }
            
            int val_2 = val_6.Count;
            Dictionary.Enumerator<TKey, TValue> val_3 = 0.GetEnumerator();
            val_6 = 536882249 + 16;
            goto label_6;
            label_11:
            Firebase.Analytics.Parameter val_4 = val_3.getEnumeratorRetType.ParseParameter(paramName:  null, paramValue:  0);
            mem2[0] = val_3.getEnumeratorRetType;
            val_6 = val_6 + 4;
            label_6:
            if(0.MoveNext() == true)
            {
                goto label_11;
            }
            
            0.Dispose();
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  eventName, parameters:  536882249);
        }
        public void TrackEvent(string eventName)
        {
            if(Dmobin.FirebaseService.FirebaseInstance.HasInstance == false)
            {
                    return;
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  R4);
        }
        private Firebase.Analytics.Parameter ParseParameter(string paramName, object paramValue)
        {
            var val_5;
            Firebase.Analytics.Parameter val_6;
            var val_7;
            var val_8;
            var val_10;
            Firebase.Analytics.Parameter val_11;
            if(paramValue == 0)
            {
                goto label_1;
            }
            
            val_5 = 22715452;
            if(null == 536894583)
            {
                goto label_2;
            }
            
            val_5 = 22715124;
            if(null == 536893745)
            {
                goto label_3;
            }
            
            val_5 = 22710552;
            if(null == 536886067)
            {
                goto label_4;
            }
            
            if(null == 536885795)
            {
                goto label_5;
            }
            
            if(null == 536888987)
            {
                goto label_6;
            }
            
            val_5 = 22712456;
            if(null != 536889041)
            {
                goto label_7;
            }
            
            val_6 = 536891495;
            val_7 = 536889041;
            val_8 = mem[536889073];
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            goto label_9;
            label_1:
            label_7:
            val_10 = paramValue;
            val_11 = 536891495;
            goto label_10;
            label_2:
            val_11 = 536891495;
            if(null != 536894583)
            {
                    val_10 = 0;
            }
            
            label_10:
            val_11 = new Firebase.Analytics.Parameter(parameterName:  paramName, parameterValue:  null);
            return;
            label_3:
            val_11 = 536891495;
            val_7 = 536893745;
            val_8 = mem[536893777];
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            goto label_13;
            label_4:
            val_11 = 536891495;
            val_7 = 536886067;
            val_8 = mem[536886099];
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            label_13:
            label_18:
            val_11 = new Firebase.Analytics.Parameter(parameterName:  paramName, parameterValue:  null);
            return;
            label_5:
            val_7 = 1152921504626016256;
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            double val_3 = System.Decimal.op_Explicit(value:  new System.Decimal() {flags = 19169280, hi = mem[paramValue + (4)], lo = mem[paramValue + (8)], mid = mem[paramValue + (12)]});
            goto label_18;
            label_6:
            val_6 = 536891495;
            val_7 = 536888987;
            val_8 = mem[536889019];
            Unity.SpriteShape.External.LibTessDotNet.Vec3..cctor();
            label_9:
            val_6 = new Firebase.Analytics.Parameter(parameterName:  paramName, parameterValue:  1152921504626016256);
        }
        public FirebaseAnalytics()
        {
        
        }
        private void <Init>b__6_0()
        {
            Firebase.Analytics.FirebaseAnalytics.SetUserId(userId:  this.mUDID);
            Firebase.Analytics.FirebaseAnalytics.SetAnalyticsCollectionEnabled(enabled:  true);
            this.<InitSuccess>k__BackingField = true;
        }
    
    }

}
