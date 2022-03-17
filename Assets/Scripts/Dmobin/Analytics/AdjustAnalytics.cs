using UnityEngine;

namespace Dmobin.Analytics
{
    public class AdjustAnalytics : IAnalytic
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
            com.adjust.sdk.AdjustConfig val_1 = 536883061;
            val_1 = new com.adjust.sdk.AdjustConfig(appToken:  args[0], environment:  1);
            if(val_1 != 0)
            {
                    val_1.setLogLevel(logLevel:  7);
                val_1.setSendInBackground(sendInBackground:  false);
                val_1.setEventBufferingEnabled(eventBufferingEnabled:  false);
            }
            else
            {
                    val_1.setLogLevel(logLevel:  7);
                val_1.setSendInBackground(sendInBackground:  false);
                val_1.setEventBufferingEnabled(eventBufferingEnabled:  false);
            }
            
            mem[536883199] = 1;
            com.adjust.sdk.Adjust.start(adjustConfig:  536883061);
        }
        public void TrackEvent(string eventName, System.Collections.Generic.Dictionary<string, object> parameters)
        {
        
        }
        public void TrackEvent(string eventName)
        {
            536883075 = new System.Object();
            mem[536883087] = eventName;
            mem[536883127] = 0;
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  536883075);
            string val_2 = -1610610293(-1610610293) + eventName;
            UnityEngine.Debug.Log(message:  -1610610293);
        }
        public AdjustAnalytics()
        {
        
        }
    
    }

}
